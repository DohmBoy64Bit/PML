using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000EC RID: 236
	[Serializable]
	public class UniversalGizmoLookAndFeel2D : Settings
	{
		// Token: 0x060015B2 RID: 5554 RVA: 0x00074020 File Offset: 0x00072220
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalGizmoLookAndFeel2D()
		{
			Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "UniversalGizmoLookAndFeel2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr);
			UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__displayCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, "_displayCategory");
			UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvDblSliderLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, "_mvDblSliderLookAndFeel");
			UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvSglSliderLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, "_mvSglSliderLookAndFeel");
			UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__isMvDblSliderVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, "_isMvDblSliderVisible");
			UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvSglSliderVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, "_mvSglSliderVis");
			UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvSglSliderCapVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, "_mvSglSliderCapVis");
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666371);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666372);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvBoxSliderThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666373);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderArrowCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666374);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderArrowCapBaseRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666375);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderQuadCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666376);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderQuadCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666377);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderCircleCapRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666378);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderQuadWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666379);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderQuadHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666380);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderCircleRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666381);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvXColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666382);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvYColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666383);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvXBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666384);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvYBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666385);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666386);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666387);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderHoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666388);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderHoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666389);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_IsMvDblSliderVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666390);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderHoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666391);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderHoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666392);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderFillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666393);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderCapFillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666394);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderFillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666395);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderCapType_Public_get_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666396);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderLineType_Public_get_GizmoLine2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666397);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderPlaneType_Public_get_GizmoPlane2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666398);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666399);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666400);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666401);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666402);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvSliderVisible_Public_Boolean_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666403);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvPositiveSliderVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666404);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvNegativeSliderVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666405);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderVisible_Public_Void_Int32_AxisSign_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666406);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvSliderCapVisible_Public_Boolean_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666407);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvPositiveSliderCapVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666408);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvNegativeSliderCapVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666409);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666410);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvAxisColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666411);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvAxisBorderColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666412);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderHoveredFillColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666413);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderHoveredBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666414);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderFillMode_Public_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666415);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderFillMode_Public_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666416);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderCapFillMode_Public_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666417);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderLineType_Public_Void_GizmoLine2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666418);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvBoxSliderThickness_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666419);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderLength_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666420);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderCapType_Public_Void_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666421);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderArrowCapBaseRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666422);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderArrowCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666423);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderQuadCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666424);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderQuadCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666425);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderCircleCapRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666426);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderPlaneType_Public_Void_GizmoPlane2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666427);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderQuadWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666428);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderQuadHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666429);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderCircleRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666430);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666431);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666432);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderHoveredColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666433);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderHoveredBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666434);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666435);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_ConnectMvSliderLookAndFeel_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666436);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_ConnectMvDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666437);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_Inherit_Public_Void_MoveGizmoLookAndFeel2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666438);
			UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_GetMvSliderLookAndFeel_Private_GizmoLineSlider2DLookAndFeel_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr, 100666439);
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x0007462C File Offset: 0x0007282C
		public unsafe float MvScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00074668 File Offset: 0x00072868
		public unsafe float MvSliderLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x000746A4 File Offset: 0x000728A4
		public unsafe float MvBoxSliderThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvBoxSliderThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x000746E0 File Offset: 0x000728E0
		public unsafe float MvSliderArrowCapHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderArrowCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x0007471C File Offset: 0x0007291C
		public unsafe float MvSliderArrowCapBaseRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderArrowCapBaseRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x00074758 File Offset: 0x00072958
		public unsafe float MvSliderQuadCapWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderQuadCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x00074794 File Offset: 0x00072994
		public unsafe float MvSliderQuadCapHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderQuadCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x000747D0 File Offset: 0x000729D0
		public unsafe float MvSliderCircleCapRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderCircleCapRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x0007480C File Offset: 0x00072A0C
		public unsafe float MvDblSliderQuadWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70167, RefRangeEnd = 70168, XrefRangeStart = 70167, XrefRangeEnd = 70168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderQuadWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x00074848 File Offset: 0x00072A48
		public unsafe float MvDblSliderQuadHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderQuadHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00074884 File Offset: 0x00072A84
		public unsafe float MvDblSliderCircleRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderCircleRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x000748C0 File Offset: 0x00072AC0
		public unsafe Color MvXColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvXColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00074900 File Offset: 0x00072B00
		public unsafe Color MvYColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvYColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00074940 File Offset: 0x00072B40
		public unsafe Color MvXBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvXBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00074980 File Offset: 0x00072B80
		public unsafe Color MvYBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvYBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x000749C0 File Offset: 0x00072BC0
		public unsafe Color MvDblSliderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x00074A00 File Offset: 0x00072C00
		public unsafe Color MvDblSliderBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00074A40 File Offset: 0x00072C40
		public unsafe Color MvDblSliderHoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderHoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x00074A80 File Offset: 0x00072C80
		public unsafe Color MvDblSliderHoveredBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderHoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x00074AC0 File Offset: 0x00072CC0
		public unsafe bool IsMvDblSliderVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_IsMvDblSliderVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x00074AFC File Offset: 0x00072CFC
		public unsafe Color MvSliderHoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderHoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x00074B3C File Offset: 0x00072D3C
		public unsafe Color MvSliderHoveredBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderHoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00074B7C File Offset: 0x00072D7C
		public unsafe GizmoFillMode2D MvSliderFillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderFillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00074BBC File Offset: 0x00072DBC
		public unsafe GizmoFillMode2D MvSliderCapFillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderCapFillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x00074BFC File Offset: 0x00072DFC
		public unsafe GizmoFillMode2D MvDblSliderFillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderFillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00074C3C File Offset: 0x00072E3C
		public unsafe GizmoCap2DType MvSliderCapType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderCapType_Public_get_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2DType>(intPtr3) : null;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x00074C7C File Offset: 0x00072E7C
		public unsafe GizmoLine2DType MvSliderLineType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvSliderLineType_Public_get_GizmoLine2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLine2DType>(intPtr3) : null;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x00074CBC File Offset: 0x00072EBC
		public unsafe GizmoPlane2DType MvDblSliderPlaneType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_MvDblSliderPlaneType_Public_get_GizmoPlane2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlane2DType>(intPtr3) : null;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x00074CFC File Offset: 0x00072EFC
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x00074D3C File Offset: 0x00072F3C
		public unsafe UniversalGizmoSettingsCategory DisplayCategory
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsCategory>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00074D80 File Offset: 0x00072F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72783, RefRangeEnd = 72785, XrefRangeStart = 72742, XrefRangeEnd = 72783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalGizmoLookAndFeel2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGizmoLookAndFeel2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00074DBC File Offset: 0x00072FBC
		[CallerCount(0)]
		public unsafe void SetMvDblSliderVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00074DFC File Offset: 0x00072FFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 70128, RefRangeEnd = 70132, XrefRangeStart = 70128, XrefRangeEnd = 70132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMvSliderVisible(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvSliderVisible_Public_Boolean_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00074E58 File Offset: 0x00073058
		[CallerCount(0)]
		public unsafe bool IsMvPositiveSliderVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvPositiveSliderVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00074EA4 File Offset: 0x000730A4
		[CallerCount(0)]
		public unsafe bool IsMvNegativeSliderVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvNegativeSliderVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00074EF0 File Offset: 0x000730F0
		[CallerCount(0)]
		public unsafe void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderVisible_Public_Void_Int32_AxisSign_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00074F50 File Offset: 0x00073150
		[CallerCount(0)]
		public unsafe bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvSliderCapVisible_Public_Boolean_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00074FAC File Offset: 0x000731AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70335, RefRangeEnd = 70338, XrefRangeStart = 70335, XrefRangeEnd = 70338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMvPositiveSliderCapVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvPositiveSliderCapVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00074FF8 File Offset: 0x000731F8
		[CallerCount(0)]
		public unsafe bool IsMvNegativeSliderCapVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_IsMvNegativeSliderCapVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00075044 File Offset: 0x00073244
		[CallerCount(0)]
		public unsafe void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x000750A4 File Offset: 0x000732A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72785, RefRangeEnd = 72787, XrefRangeStart = 72785, XrefRangeEnd = 72785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvAxisColor(int axisIndex, Color color)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvAxisColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000750F4 File Offset: 0x000732F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72787, RefRangeEnd = 72789, XrefRangeStart = 72787, XrefRangeEnd = 72787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvAxisBorderColor(int axisIndex, Color color)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvAxisBorderColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00075144 File Offset: 0x00073344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72789, XrefRangeEnd = 72790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderHoveredFillColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderHoveredFillColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00075188 File Offset: 0x00073388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72790, XrefRangeEnd = 72791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderHoveredBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderHoveredBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x000751CC File Offset: 0x000733CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderFillMode(GizmoFillMode2D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderFillMode_Public_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00075210 File Offset: 0x00073410
		[CallerCount(0)]
		public unsafe void SetMvDblSliderFillMode(GizmoFillMode2D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderFillMode_Public_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00075254 File Offset: 0x00073454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72791, XrefRangeEnd = 72792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderCapFillMode(GizmoFillMode2D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderCapFillMode_Public_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00075298 File Offset: 0x00073498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72792, XrefRangeEnd = 72793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderLineType(GizmoLine2DType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderLineType_Public_Void_GizmoLine2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x000752DC File Offset: 0x000734DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvBoxSliderThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thickness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvBoxSliderThickness_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0007531C File Offset: 0x0007351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72793, XrefRangeEnd = 72795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderLength(float length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderLength_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0007535C File Offset: 0x0007355C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72795, XrefRangeEnd = 72796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderCapType(GizmoCap2DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderCapType_Public_Void_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x000753A0 File Offset: 0x000735A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72796, XrefRangeEnd = 72798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderArrowCapBaseRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderArrowCapBaseRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x000753E0 File Offset: 0x000735E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72798, XrefRangeEnd = 72800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderArrowCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderArrowCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00075420 File Offset: 0x00073620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72800, XrefRangeEnd = 72802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderQuadCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderQuadCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00075460 File Offset: 0x00073660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72802, XrefRangeEnd = 72804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderQuadCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderQuadCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000754A0 File Offset: 0x000736A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72804, XrefRangeEnd = 72805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvSliderCircleCapRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvSliderCircleCapRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000754E0 File Offset: 0x000736E0
		[CallerCount(0)]
		public unsafe void SetMvDblSliderPlaneType(GizmoPlane2DType sliderType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sliderType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderPlaneType_Public_Void_GizmoPlane2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00075524 File Offset: 0x00073724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72805, XrefRangeEnd = 72807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvDblSliderQuadWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderQuadWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00075564 File Offset: 0x00073764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72807, XrefRangeEnd = 72809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvDblSliderQuadHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderQuadHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000755A4 File Offset: 0x000737A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72809, XrefRangeEnd = 72811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvDblSliderCircleRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderCircleRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000755E4 File Offset: 0x000737E4
		[CallerCount(0)]
		public unsafe void SetMvDblSliderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00075628 File Offset: 0x00073828
		[CallerCount(0)]
		public unsafe void SetMvDblSliderBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x0007566C File Offset: 0x0007386C
		[CallerCount(0)]
		public unsafe void SetMvDblSliderHoveredColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderHoveredColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x000756B0 File Offset: 0x000738B0
		[CallerCount(0)]
		public unsafe void SetMvDblSliderHoveredBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvDblSliderHoveredBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000756F4 File Offset: 0x000738F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72811, XrefRangeEnd = 72817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_SetMvScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00075734 File Offset: 0x00073934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72817, XrefRangeEnd = 72821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMvSliderLookAndFeel(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_ConnectMvSliderLookAndFeel_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00075798 File Offset: 0x00073998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72821, XrefRangeEnd = 72823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_ConnectMvDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x000757DC File Offset: 0x000739DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72823, XrefRangeEnd = 72888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Inherit(MoveGizmoLookAndFeel2D lookAndFeel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookAndFeel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_Inherit_Public_Void_MoveGizmoLookAndFeel2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00075820 File Offset: 0x00073A20
		[CallerCount(0)]
		public unsafe GizmoLineSlider2DLookAndFeel GetMvSliderLookAndFeel(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoLookAndFeel2D.NativeMethodInfoPtr_GetMvSliderLookAndFeel_Private_GizmoLineSlider2DLookAndFeel_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DLookAndFeel>(intPtr3) : null;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0000A354 File Offset: 0x00008554
		public UniversalGizmoLookAndFeel2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00075880 File Offset: 0x00073A80
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x0000A35D File Offset: 0x0000855D
		public unsafe UniversalGizmoSettingsCategory _displayCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__displayCategory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__displayCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x000758B0 File Offset: 0x00073AB0
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x0000A37C File Offset: 0x0000857C
		public unsafe GizmoPlaneSlider2DLookAndFeel _mvDblSliderLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvDblSliderLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvDblSliderLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x000758E0 File Offset: 0x00073AE0
		// (set) Token: 0x060015FE RID: 5630 RVA: 0x0000A39B File Offset: 0x0000859B
		public unsafe Il2CppReferenceArray<GizmoLineSlider2DLookAndFeel> _mvSglSliderLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvSglSliderLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider2DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvSglSliderLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00075910 File Offset: 0x00073B10
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x0000A3BA File Offset: 0x000085BA
		public unsafe bool _isMvDblSliderVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__isMvDblSliderVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__isMvDblSliderVisible)) = value;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00075938 File Offset: 0x00073B38
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x0000A3D5 File Offset: 0x000085D5
		public unsafe Il2CppStructArray<bool> _mvSglSliderVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvSglSliderVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvSglSliderVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00075968 File Offset: 0x00073B68
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x0000A3F4 File Offset: 0x000085F4
		public unsafe Il2CppStructArray<bool> _mvSglSliderCapVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvSglSliderCapVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoLookAndFeel2D.NativeFieldInfoPtr__mvSglSliderCapVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeFieldInfoPtr__displayCategory;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr__mvDblSliderLookAndFeel;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr__mvSglSliderLookAndFeel;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeFieldInfoPtr__isMvDblSliderVisible;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeFieldInfoPtr__mvSglSliderVis;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeFieldInfoPtr__mvSglSliderCapVis;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_get_MvScale_Public_get_Single_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderLength_Public_get_Single_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_get_MvBoxSliderThickness_Public_get_Single_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderArrowCapHeight_Public_get_Single_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderArrowCapBaseRadius_Public_get_Single_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderQuadCapWidth_Public_get_Single_0;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderQuadCapHeight_Public_get_Single_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderCircleCapRadius_Public_get_Single_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDblSliderQuadWidth_Public_get_Single_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDblSliderQuadHeight_Public_get_Single_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDblSliderCircleRadius_Public_get_Single_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_get_MvXColor_Public_get_Color_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_get_MvYColor_Public_get_Color_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_get_MvXBorderColor_Public_get_Color_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr_get_MvYBorderColor_Public_get_Color_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDblSliderColor_Public_get_Color_0;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDblSliderBorderColor_Public_get_Color_0;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDblSliderHoveredColor_Public_get_Color_0;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDblSliderHoveredBorderColor_Public_get_Color_0;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMvDblSliderVisible_Public_get_Boolean_0;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderHoveredColor_Public_get_Color_0;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderHoveredBorderColor_Public_get_Color_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderFillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderCapFillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDblSliderFillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderCapType_Public_get_GizmoCap2DType_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_get_MvSliderLineType_Public_get_GizmoLine2DType_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDblSliderPlaneType_Public_get_GizmoPlane2DType_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderVisible_Public_Void_Boolean_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_IsMvSliderVisible_Public_Boolean_Int32_AxisSign_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_IsMvPositiveSliderVisible_Public_Boolean_Int32_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_IsMvNegativeSliderVisible_Public_Boolean_Int32_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderVisible_Public_Void_Int32_AxisSign_Boolean_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_IsMvSliderCapVisible_Public_Boolean_Int32_AxisSign_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_IsMvPositiveSliderCapVisible_Public_Boolean_Int32_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_IsMvNegativeSliderCapVisible_Public_Boolean_Int32_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_SetMvAxisColor_Public_Void_Int32_Color_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_SetMvAxisBorderColor_Public_Void_Int32_Color_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderHoveredFillColor_Public_Void_Color_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderHoveredBorderColor_Public_Void_Color_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderFillMode_Public_Void_GizmoFillMode2D_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderFillMode_Public_Void_GizmoFillMode2D_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderCapFillMode_Public_Void_GizmoFillMode2D_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderLineType_Public_Void_GizmoLine2DType_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_SetMvBoxSliderThickness_Public_Void_Single_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderLength_Public_Void_Single_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderCapType_Public_Void_GizmoCap2DType_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderArrowCapBaseRadius_Public_Void_Single_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderArrowCapHeight_Public_Void_Single_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderQuadCapWidth_Public_Void_Single_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderQuadCapHeight_Public_Void_Single_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_SetMvSliderCircleCapRadius_Public_Void_Single_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderPlaneType_Public_Void_GizmoPlane2DType_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderQuadWidth_Public_Void_Single_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderQuadHeight_Public_Void_Single_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderCircleRadius_Public_Void_Single_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderColor_Public_Void_Color_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderBorderColor_Public_Void_Color_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderHoveredColor_Public_Void_Color_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDblSliderHoveredBorderColor_Public_Void_Color_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_SetMvScale_Public_Void_Single_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMvSliderLookAndFeel_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMvDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider2D_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_Inherit_Public_Void_MoveGizmoLookAndFeel2D_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_GetMvSliderLookAndFeel_Private_GizmoLineSlider2DLookAndFeel_Int32_AxisSign_0;
	}
}
