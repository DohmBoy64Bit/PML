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
	// Token: 0x020000DC RID: 220
	[Serializable]
	public class MoveGizmoLookAndFeel2D : Settings
	{
		// Token: 0x060011E0 RID: 4576 RVA: 0x00063B5C File Offset: 0x00061D5C
		// Note: this type is marked as 'beforefieldinit'.
		static MoveGizmoLookAndFeel2D()
		{
			Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MoveGizmoLookAndFeel2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr);
			MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__dblSliderLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, "_dblSliderLookAndFeel");
			MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__sglSliderLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, "_sglSliderLookAndFeel");
			MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__isDblSliderVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, "_isDblSliderVisible");
			MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__sglSliderVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, "_sglSliderVis");
			MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__sglSliderCapVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, "_sglSliderCapVis");
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665714);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665715);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_BoxSliderThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665716);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderArrowCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665717);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderArrowCapBaseRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665718);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderQuadCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665719);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderQuadCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665720);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderCircleCapRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665721);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderQuadWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665722);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderQuadHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665723);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderCircleRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665724);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_XColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665725);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_YColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665726);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_XBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665727);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_YBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665728);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665729);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665730);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderHoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665731);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderHoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665732);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_IsDblSliderVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665733);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderHoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665734);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderHoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665735);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderFillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665736);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665737);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderFillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665738);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665739);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderLineType_Public_get_GizmoLine2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665740);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderPlaneType_Public_get_GizmoPlane2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665741);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665742);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsDblSliderPlaneTypeAllowed_Public_Boolean_GizmoPlane2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665743);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_GetAllowedDblSliderPlaneTypes_Public_List_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665744);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665745);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsSliderVisible_Public_Boolean_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665746);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsPositiveSliderVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665747);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsNegativeSliderVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665748);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderVisible_Public_Void_Int32_AxisSign_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665749);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsSliderCapVisible_Public_Boolean_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665750);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsPositiveSliderCapVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665751);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsNegativeSliderCapVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665752);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665753);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665754);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetAxisBorderColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665755);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderHoveredFillColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665756);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderHoveredBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665757);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderFillMode_Public_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665758);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderFillMode_Public_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665759);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665760);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderLineType_Public_Void_GizmoLine2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665761);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetBoxSliderThickness_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665762);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderLength_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665763);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665764);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderArrowCapBaseRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665765);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderArrowCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665766);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderQuadCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665767);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderQuadCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665768);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderCircleCapRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665769);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderPlaneType_Public_Void_GizmoPlane2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665770);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderQuadWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665771);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderQuadHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665772);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderCircleRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665773);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665774);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665775);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderHoveredColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665776);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderHoveredBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665777);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665778);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665779);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_ConnectDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665780);
			MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_GetSliderLookAndFeel_Private_GizmoLineSlider2DLookAndFeel_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr, 100665781);
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00064140 File Offset: 0x00062340
		public unsafe float Scale
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70031, RefRangeEnd = 70033, XrefRangeStart = 70031, XrefRangeEnd = 70031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0006417C File Offset: 0x0006237C
		public unsafe float SliderLength
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 70033, RefRangeEnd = 70037, XrefRangeStart = 70033, XrefRangeEnd = 70033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x000641B8 File Offset: 0x000623B8
		public unsafe float BoxSliderThickness
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70037, RefRangeEnd = 70039, XrefRangeStart = 70037, XrefRangeEnd = 70037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_BoxSliderThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x000641F4 File Offset: 0x000623F4
		public unsafe float SliderArrowCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70039, RefRangeEnd = 70040, XrefRangeStart = 70039, XrefRangeEnd = 70039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderArrowCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x00064230 File Offset: 0x00062430
		public unsafe float SliderArrowCapBaseRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70040, RefRangeEnd = 70041, XrefRangeStart = 70040, XrefRangeEnd = 70040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderArrowCapBaseRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0006426C File Offset: 0x0006246C
		public unsafe float SliderQuadCapWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70041, RefRangeEnd = 70042, XrefRangeStart = 70041, XrefRangeEnd = 70041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderQuadCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x000642A8 File Offset: 0x000624A8
		public unsafe float SliderQuadCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70042, RefRangeEnd = 70043, XrefRangeStart = 70042, XrefRangeEnd = 70042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderQuadCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x000642E4 File Offset: 0x000624E4
		public unsafe float SliderCircleCapRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70043, RefRangeEnd = 70044, XrefRangeStart = 70043, XrefRangeEnd = 70043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderCircleCapRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x00064320 File Offset: 0x00062520
		public unsafe float DblSliderQuadWidth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70044, RefRangeEnd = 70046, XrefRangeStart = 70044, XrefRangeEnd = 70044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderQuadWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0006435C File Offset: 0x0006255C
		public unsafe float DblSliderQuadHeight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70046, RefRangeEnd = 70048, XrefRangeStart = 70046, XrefRangeEnd = 70046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderQuadHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00064398 File Offset: 0x00062598
		public unsafe float DblSliderCircleRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70048, RefRangeEnd = 70049, XrefRangeStart = 70048, XrefRangeEnd = 70048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderCircleRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x000643D4 File Offset: 0x000625D4
		public unsafe Color XColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70049, RefRangeEnd = 70050, XrefRangeStart = 70049, XrefRangeEnd = 70049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_XColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00064414 File Offset: 0x00062614
		public unsafe Color YColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70050, RefRangeEnd = 70051, XrefRangeStart = 70050, XrefRangeEnd = 70050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_YColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00064454 File Offset: 0x00062654
		public unsafe Color XBorderColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70051, RefRangeEnd = 70052, XrefRangeStart = 70051, XrefRangeEnd = 70051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_XBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00064494 File Offset: 0x00062694
		public unsafe Color YBorderColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70052, RefRangeEnd = 70053, XrefRangeStart = 70052, XrefRangeEnd = 70052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_YBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x000644D4 File Offset: 0x000626D4
		public unsafe Color DblSliderColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70053, RefRangeEnd = 70054, XrefRangeStart = 70053, XrefRangeEnd = 70053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00064514 File Offset: 0x00062714
		public unsafe Color DblSliderBorderColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70054, RefRangeEnd = 70055, XrefRangeStart = 70054, XrefRangeEnd = 70054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00064554 File Offset: 0x00062754
		public unsafe Color DblSliderHoveredColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70055, RefRangeEnd = 70056, XrefRangeStart = 70055, XrefRangeEnd = 70055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderHoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00064594 File Offset: 0x00062794
		public unsafe Color DblSliderHoveredBorderColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70056, RefRangeEnd = 70057, XrefRangeStart = 70056, XrefRangeEnd = 70056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderHoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x000645D4 File Offset: 0x000627D4
		public unsafe bool IsDblSliderVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_IsDblSliderVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00064610 File Offset: 0x00062810
		public unsafe Color SliderHoveredColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70057, RefRangeEnd = 70058, XrefRangeStart = 70057, XrefRangeEnd = 70057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderHoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00064650 File Offset: 0x00062850
		public unsafe Color SliderHoveredBorderColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70058, RefRangeEnd = 70059, XrefRangeStart = 70058, XrefRangeEnd = 70058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderHoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00064690 File Offset: 0x00062890
		public unsafe GizmoFillMode2D SliderFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70059, RefRangeEnd = 70060, XrefRangeStart = 70059, XrefRangeEnd = 70059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderFillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x000646D0 File Offset: 0x000628D0
		public unsafe GizmoFillMode2D SliderCapFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70060, RefRangeEnd = 70061, XrefRangeStart = 70060, XrefRangeEnd = 70060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00064710 File Offset: 0x00062910
		public unsafe GizmoFillMode2D DblSliderFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 64400, RefRangeEnd = 64401, XrefRangeStart = 64400, XrefRangeEnd = 64401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderFillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x00064750 File Offset: 0x00062950
		public unsafe GizmoCap2DType SliderCapType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70061, RefRangeEnd = 70062, XrefRangeStart = 70061, XrefRangeEnd = 70061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2DType>(intPtr3) : null;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00064790 File Offset: 0x00062990
		public unsafe GizmoLine2DType SliderLineType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 64399, RefRangeEnd = 64400, XrefRangeStart = 64399, XrefRangeEnd = 64400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_SliderLineType_Public_get_GizmoLine2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLine2DType>(intPtr3) : null;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x000647D0 File Offset: 0x000629D0
		public unsafe GizmoPlane2DType DblSliderPlaneType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70062, RefRangeEnd = 70063, XrefRangeStart = 70062, XrefRangeEnd = 70062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_get_DblSliderPlaneType_Public_get_GizmoPlane2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlane2DType>(intPtr3) : null;
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00064810 File Offset: 0x00062A10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70104, RefRangeEnd = 70106, XrefRangeStart = 70063, XrefRangeEnd = 70104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveGizmoLookAndFeel2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveGizmoLookAndFeel2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0006484C File Offset: 0x00062A4C
		[CallerCount(0)]
		public unsafe bool IsDblSliderPlaneTypeAllowed(GizmoPlane2DType planeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsDblSliderPlaneTypeAllowed_Public_Boolean_GizmoPlane2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0006489C File Offset: 0x00062A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70106, XrefRangeEnd = 70124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Enum> GetAllowedDblSliderPlaneTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_GetAllowedDblSliderPlaneTypes_Public_List_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Enum>>(intPtr3) : null;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x000648DC File Offset: 0x00062ADC
		[CallerCount(0)]
		public unsafe void SetDblSliderVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0006491C File Offset: 0x00062B1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 70124, RefRangeEnd = 70128, XrefRangeStart = 70124, XrefRangeEnd = 70124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsSliderVisible_Public_Boolean_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00064978 File Offset: 0x00062B78
		[CallerCount(0)]
		public unsafe bool IsPositiveSliderVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsPositiveSliderVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x000649C4 File Offset: 0x00062BC4
		[CallerCount(0)]
		public unsafe bool IsNegativeSliderVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsNegativeSliderVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00064A10 File Offset: 0x00062C10
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderVisible_Public_Void_Int32_AxisSign_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00064A70 File Offset: 0x00062C70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 70128, RefRangeEnd = 70132, XrefRangeStart = 70128, XrefRangeEnd = 70128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsSliderCapVisible_Public_Boolean_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00064ACC File Offset: 0x00062CCC
		[CallerCount(0)]
		public unsafe bool IsPositiveSliderCapVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsPositiveSliderCapVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00064B18 File Offset: 0x00062D18
		[CallerCount(0)]
		public unsafe bool IsNegativeSliderCapVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_IsNegativeSliderCapVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00064B64 File Offset: 0x00062D64
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00064BC4 File Offset: 0x00062DC4
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00064C14 File Offset: 0x00062E14
		[CallerCount(0)]
		public unsafe void SetAxisBorderColor(int axisIndex, Color color)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetAxisBorderColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00064C64 File Offset: 0x00062E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70132, XrefRangeEnd = 70133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderHoveredFillColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderHoveredFillColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00064CA8 File Offset: 0x00062EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70133, XrefRangeEnd = 70134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderHoveredBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderHoveredBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00064CEC File Offset: 0x00062EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderFillMode(GizmoFillMode2D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderFillMode_Public_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00064D30 File Offset: 0x00062F30
		[CallerCount(0)]
		public unsafe void SetDblSliderFillMode(GizmoFillMode2D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderFillMode_Public_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00064D74 File Offset: 0x00062F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70134, XrefRangeEnd = 70135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapFillMode(GizmoFillMode2D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00064DB8 File Offset: 0x00062FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderLineType(GizmoLine2DType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderLineType_Public_Void_GizmoLine2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00064DFC File Offset: 0x00062FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70135, XrefRangeEnd = 70137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxSliderThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thickness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetBoxSliderThickness_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00064E3C File Offset: 0x0006303C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70137, XrefRangeEnd = 70139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderLength(float length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderLength_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00064E7C File Offset: 0x0006307C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70139, XrefRangeEnd = 70140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapType(GizmoCap2DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00064EC0 File Offset: 0x000630C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70140, XrefRangeEnd = 70142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderArrowCapBaseRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderArrowCapBaseRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00064F00 File Offset: 0x00063100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70142, XrefRangeEnd = 70144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderArrowCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderArrowCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00064F40 File Offset: 0x00063140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70144, XrefRangeEnd = 70146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderQuadCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderQuadCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00064F80 File Offset: 0x00063180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70146, XrefRangeEnd = 70148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderQuadCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderQuadCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00064FC0 File Offset: 0x000631C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70148, XrefRangeEnd = 70149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCircleCapRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetSliderCircleCapRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00065000 File Offset: 0x00063200
		[CallerCount(0)]
		public unsafe void SetDblSliderPlaneType(GizmoPlane2DType sliderType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sliderType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderPlaneType_Public_Void_GizmoPlane2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00065044 File Offset: 0x00063244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70149, XrefRangeEnd = 70151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderQuadWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderQuadWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00065084 File Offset: 0x00063284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70151, XrefRangeEnd = 70153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderQuadHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderQuadHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x000650C4 File Offset: 0x000632C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70153, XrefRangeEnd = 70155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderCircleRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderCircleRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00065104 File Offset: 0x00063304
		[CallerCount(0)]
		public unsafe void SetDblSliderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00065148 File Offset: 0x00063348
		[CallerCount(0)]
		public unsafe void SetDblSliderBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0006518C File Offset: 0x0006338C
		[CallerCount(0)]
		public unsafe void SetDblSliderHoveredColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderHoveredColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000651D0 File Offset: 0x000633D0
		[CallerCount(0)]
		public unsafe void SetDblSliderHoveredBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetDblSliderHoveredBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00065214 File Offset: 0x00063414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70155, XrefRangeEnd = 70161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00065254 File Offset: 0x00063454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70161, XrefRangeEnd = 70165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectSliderLookAndFeel(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x000652B8 File Offset: 0x000634B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70165, XrefRangeEnd = 70167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectDblSliderLookAndFeel(GizmoPlaneSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_ConnectDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000652FC File Offset: 0x000634FC
		[CallerCount(0)]
		public unsafe GizmoLineSlider2DLookAndFeel GetSliderLookAndFeel(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel2D.NativeMethodInfoPtr_GetSliderLookAndFeel_Private_GizmoLineSlider2DLookAndFeel_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DLookAndFeel>(intPtr3) : null;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x000090F6 File Offset: 0x000072F6
		public MoveGizmoLookAndFeel2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x0006535C File Offset: 0x0006355C
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x000090FF File Offset: 0x000072FF
		public unsafe GizmoPlaneSlider2DLookAndFeel _dblSliderLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__dblSliderLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__dblSliderLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x0006538C File Offset: 0x0006358C
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x0000911E File Offset: 0x0000731E
		public unsafe Il2CppReferenceArray<GizmoLineSlider2DLookAndFeel> _sglSliderLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__sglSliderLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider2DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__sglSliderLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000653BC File Offset: 0x000635BC
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x0000913D File Offset: 0x0000733D
		public unsafe bool _isDblSliderVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__isDblSliderVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__isDblSliderVisible)) = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x000653E4 File Offset: 0x000635E4
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x00009158 File Offset: 0x00007358
		public unsafe Il2CppStructArray<bool> _sglSliderVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__sglSliderVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__sglSliderVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00065414 File Offset: 0x00063614
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x00009177 File Offset: 0x00007377
		public unsafe Il2CppStructArray<bool> _sglSliderCapVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__sglSliderCapVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel2D.NativeFieldInfoPtr__sglSliderCapVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeFieldInfoPtr__dblSliderLookAndFeel;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderLookAndFeel;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeFieldInfoPtr__isDblSliderVisible;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderVis;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderCapVis;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderLength_Public_get_Single_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxSliderThickness_Public_get_Single_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderArrowCapHeight_Public_get_Single_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderArrowCapBaseRadius_Public_get_Single_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderQuadCapWidth_Public_get_Single_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderQuadCapHeight_Public_get_Single_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCircleCapRadius_Public_get_Single_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderQuadWidth_Public_get_Single_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderQuadHeight_Public_get_Single_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderCircleRadius_Public_get_Single_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_get_XColor_Public_get_Color_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_get_YColor_Public_get_Color_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_get_XBorderColor_Public_get_Color_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_get_YBorderColor_Public_get_Color_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderColor_Public_get_Color_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderBorderColor_Public_get_Color_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderHoveredColor_Public_get_Color_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderHoveredBorderColor_Public_get_Color_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDblSliderVisible_Public_get_Boolean_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderHoveredColor_Public_get_Color_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderHoveredBorderColor_Public_get_Color_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderFillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderFillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap2DType_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderLineType_Public_get_GizmoLine2DType_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderPlaneType_Public_get_GizmoPlane2DType_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_IsDblSliderPlaneTypeAllowed_Public_Boolean_GizmoPlane2DType_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_GetAllowedDblSliderPlaneTypes_Public_List_1_Enum_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderVisible_Public_Void_Boolean_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_IsSliderVisible_Public_Boolean_Int32_AxisSign_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_IsPositiveSliderVisible_Public_Boolean_Int32_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeSliderVisible_Public_Boolean_Int32_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderVisible_Public_Void_Int32_AxisSign_Boolean_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_IsSliderCapVisible_Public_Boolean_Int32_AxisSign_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_IsPositiveSliderCapVisible_Public_Boolean_Int32_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeSliderCapVisible_Public_Boolean_Int32_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisBorderColor_Public_Void_Int32_Color_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderHoveredFillColor_Public_Void_Color_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderHoveredBorderColor_Public_Void_Color_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderFillMode_Public_Void_GizmoFillMode2D_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderFillMode_Public_Void_GizmoFillMode2D_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode2D_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderLineType_Public_Void_GizmoLine2DType_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxSliderThickness_Public_Void_Single_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderLength_Public_Void_Single_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap2DType_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderArrowCapBaseRadius_Public_Void_Single_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderArrowCapHeight_Public_Void_Single_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderQuadCapWidth_Public_Void_Single_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderQuadCapHeight_Public_Void_Single_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCircleCapRadius_Public_Void_Single_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderPlaneType_Public_Void_GizmoPlane2DType_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderQuadWidth_Public_Void_Single_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderQuadHeight_Public_Void_Single_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderCircleRadius_Public_Void_Single_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderColor_Public_Void_Color_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderBorderColor_Public_Void_Color_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderHoveredColor_Public_Void_Color_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderHoveredBorderColor_Public_Void_Color_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_ConnectDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider2D_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_GetSliderLookAndFeel_Private_GizmoLineSlider2DLookAndFeel_Int32_AxisSign_0;
	}
}
