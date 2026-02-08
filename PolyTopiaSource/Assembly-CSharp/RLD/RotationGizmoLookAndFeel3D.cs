using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E4 RID: 228
	[Serializable]
	public class RotationGizmoLookAndFeel3D : Settings
	{
		// Token: 0x0600139F RID: 5023 RVA: 0x0006B960 File Offset: 0x00069B60
		// Note: this type is marked as 'beforefieldinit'.
		static RotationGizmoLookAndFeel3D()
		{
			Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RotationGizmoLookAndFeel3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr);
			RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__isMidCapVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, "_isMidCapVisible");
			RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__midCapLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, "_midCapLookAndFeel");
			RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__axesVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, "_axesVis");
			RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__axesLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, "_axesLookAndFeel");
			RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__isCamLookSliderVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, "_isCamLookSliderVisible");
			RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__camLookSliderRadiusOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, "_camLookSliderRadiusOffset");
			RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__camLookSliderLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, "_camLookSliderLookAndFeel");
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666050);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666051);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666052);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666053);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666054);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666055);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666056);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisTorusThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666057);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisCylTorusWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666058);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisCylTorusHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666059);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisCullAlphaScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666060);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666061);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisBorderType_Public_get_GizmoCircle3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666062);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisBorderFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666063);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_NumAxisTorusWireAxialSlices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666064);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_RotationArcColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666065);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_RotationArcBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666066);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseShortestRotationArc_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666067);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666068);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666069);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666070);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredMidCapColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666071);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsMidCapVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666072);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsMidCapBorderVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666073);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderRadiusOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666074);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666075);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderHoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666076);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderPolyBorderType_Public_get_GizmoPolygon2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666077);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderPolyBorderThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666078);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsCamLookSliderVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666079);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666080);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_IsAxisVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666081);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisVisible_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666082);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666083);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisBorderFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666084);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNumAxisTorusWireAxialSlices_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666085);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666086);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666087);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666088);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisBorderCullAlphaScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666089);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisBorderType_Public_Void_GizmoCircle3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666090);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisTorusThickness_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666091);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisCylTorusWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666092);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisCylTorusHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666093);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666094);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666095);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredMidCapColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666096);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBorderVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666097);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666098);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisBorderColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666099);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666100);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetRotationArcColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666101);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetRotationArcBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666102);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseShortestRotationArc_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666103);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetRotationArcVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666104);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderRadiusOffset_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666105);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666106);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderHoveredBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666107);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666108);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderPolyBorderType_Public_Void_GizmoPolygon2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666109);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderPolyBorderThickness_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666110);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoPlaneSlider3D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666111);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666112);
			RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectCamLookSliderLookAndFeel_Public_Void_GizmoPlaneSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr, 100666113);
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0006BF1C File Offset: 0x0006A11C
		public unsafe float Scale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70167, RefRangeEnd = 70168, XrefRangeStart = 70167, XrefRangeEnd = 70168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0006BF58 File Offset: 0x0006A158
		public unsafe float Radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0006BF94 File Offset: 0x0006A194
		public unsafe bool UseZoomFactor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70168, RefRangeEnd = 70171, XrefRangeStart = 70168, XrefRangeEnd = 70171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0006BFD0 File Offset: 0x0006A1D0
		public unsafe Color XBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x0006C010 File Offset: 0x0006A210
		public unsafe Color YBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x0006C050 File Offset: 0x0006A250
		public unsafe Color ZBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0006C090 File Offset: 0x0006A290
		public unsafe Color HoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x0006C0D0 File Offset: 0x0006A2D0
		public unsafe float AxisTorusThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisTorusThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0006C10C File Offset: 0x0006A30C
		public unsafe float AxisCylTorusWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisCylTorusWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0006C148 File Offset: 0x0006A348
		public unsafe float AxisCylTorusHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisCylTorusHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0006C184 File Offset: 0x0006A384
		public unsafe float AxisCullAlphaScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisCullAlphaScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0006C1C0 File Offset: 0x0006A3C0
		public unsafe GizmoShadeMode ShadeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0006C200 File Offset: 0x0006A400
		public unsafe GizmoCircle3DBorderType AxisBorderType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisBorderType_Public_get_GizmoCircle3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCircle3DBorderType>(intPtr3) : null;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0006C240 File Offset: 0x0006A440
		public unsafe GizmoFillMode3D AxisBorderFillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_AxisBorderFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0006C280 File Offset: 0x0006A480
		public unsafe int NumAxisTorusWireAxialSlices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_NumAxisTorusWireAxialSlices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x0006C2BC File Offset: 0x0006A4BC
		public unsafe Color RotationArcColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_RotationArcColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0006C2FC File Offset: 0x0006A4FC
		public unsafe Color RotationArcBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_RotationArcBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x0006C33C File Offset: 0x0006A53C
		public unsafe bool UseShortestRotationArc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseShortestRotationArc_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0006C378 File Offset: 0x0006A578
		public unsafe bool IsRotationArcVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0006C3B4 File Offset: 0x0006A5B4
		public unsafe Color MidCapColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0006C3F4 File Offset: 0x0006A5F4
		public unsafe Color MidCapBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0006C434 File Offset: 0x0006A634
		public unsafe Color HoveredMidCapColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredMidCapColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0006C474 File Offset: 0x0006A674
		public unsafe bool IsMidCapVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsMidCapVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0006C4B0 File Offset: 0x0006A6B0
		public unsafe bool IsMidCapBorderVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsMidCapBorderVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0006C4EC File Offset: 0x0006A6EC
		public unsafe float CamLookSliderRadiusOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderRadiusOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0006C528 File Offset: 0x0006A728
		public unsafe Color CamLookSliderBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x0006C568 File Offset: 0x0006A768
		public unsafe Color CamLookSliderHoveredBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderHoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x0006C5A8 File Offset: 0x0006A7A8
		public unsafe GizmoPolygon2DBorderType CamLookSliderPolyBorderType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderPolyBorderType_Public_get_GizmoPolygon2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPolygon2DBorderType>(intPtr3) : null;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0006C5E8 File Offset: 0x0006A7E8
		public unsafe float CamLookSliderPolyBorderThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CamLookSliderPolyBorderThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0006C624 File Offset: 0x0006A824
		public unsafe bool IsCamLookSliderVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsCamLookSliderVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0006C660 File Offset: 0x0006A860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71435, RefRangeEnd = 71437, XrefRangeStart = 71397, XrefRangeEnd = 71435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotationGizmoLookAndFeel3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotationGizmoLookAndFeel3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0006C69C File Offset: 0x0006A89C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 71437, RefRangeEnd = 71440, XrefRangeStart = 71437, XrefRangeEnd = 71437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAxisVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_IsAxisVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0006C6E8 File Offset: 0x0006A8E8
		[CallerCount(0)]
		public unsafe void SetAxisVisible(int axisIndex, bool isVisible)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisVisible_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0006C734 File Offset: 0x0006A934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71440, XrefRangeEnd = 71441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0006C778 File Offset: 0x0006A978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71441, XrefRangeEnd = 71442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisBorderFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisBorderFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0006C7BC File Offset: 0x0006A9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71442, XrefRangeEnd = 71444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNumAxisTorusWireAxialSlices(int numSlices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numSlices;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNumAxisTorusWireAxialSlices_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0006C7FC File Offset: 0x0006A9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71444, XrefRangeEnd = 71445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUseZoomFactor(bool useZoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useZoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0006C83C File Offset: 0x0006AA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71445, XrefRangeEnd = 71450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0006C87C File Offset: 0x0006AA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71450, XrefRangeEnd = 71455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0006C8BC File Offset: 0x0006AABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71455, XrefRangeEnd = 71457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisBorderCullAlphaScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisBorderCullAlphaScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0006C8FC File Offset: 0x0006AAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71457, XrefRangeEnd = 71458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisBorderType(GizmoCircle3DBorderType borderType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(borderType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisBorderType_Public_Void_GizmoCircle3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0006C940 File Offset: 0x0006AB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71458, XrefRangeEnd = 71460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisTorusThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thickness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisTorusThickness_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0006C980 File Offset: 0x0006AB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71460, XrefRangeEnd = 71462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisCylTorusWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisCylTorusWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0006C9C0 File Offset: 0x0006ABC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71462, XrefRangeEnd = 71464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisCylTorusHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisCylTorusHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0006CA00 File Offset: 0x0006AC00
		[CallerCount(0)]
		public unsafe void SetMidCapVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0006CA40 File Offset: 0x0006AC40
		[CallerCount(0)]
		public unsafe void SetMidCapColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0006CA84 File Offset: 0x0006AC84
		[CallerCount(0)]
		public unsafe void SetHoveredMidCapColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredMidCapColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0006CAC8 File Offset: 0x0006ACC8
		[CallerCount(0)]
		public unsafe void SetMidCapBorderVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBorderVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0006CB08 File Offset: 0x0006AD08
		[CallerCount(0)]
		public unsafe void SetMidCapBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0006CB4C File Offset: 0x0006AD4C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisBorderColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0006CB9C File Offset: 0x0006AD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71464, XrefRangeEnd = 71465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoveredColor(Color hoveredColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoveredColor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0006CBE0 File Offset: 0x0006ADE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71465, XrefRangeEnd = 71466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotationArcColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetRotationArcColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0006CC24 File Offset: 0x0006AE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71466, XrefRangeEnd = 71467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotationArcBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetRotationArcBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0006CC68 File Offset: 0x0006AE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71467, XrefRangeEnd = 71468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUseShortestRotationArc(bool useShortest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useShortest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseShortestRotationArc_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0006CCA8 File Offset: 0x0006AEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71468, XrefRangeEnd = 71469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotationArcVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetRotationArcVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0006CCE8 File Offset: 0x0006AEE8
		[CallerCount(0)]
		public unsafe void SetCamLookSliderRadiusOffset(float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderRadiusOffset_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0006CD28 File Offset: 0x0006AF28
		[CallerCount(0)]
		public unsafe void SetCamLookSliderBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0006CD6C File Offset: 0x0006AF6C
		[CallerCount(0)]
		public unsafe void SetCamLookSliderHoveredBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderHoveredBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0006CDB0 File Offset: 0x0006AFB0
		[CallerCount(0)]
		public unsafe void SetCamLookSliderVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0006CDF0 File Offset: 0x0006AFF0
		[CallerCount(0)]
		public unsafe void SetCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polyBorderType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderPolyBorderType_Public_Void_GizmoPolygon2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0006CE34 File Offset: 0x0006B034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71469, XrefRangeEnd = 71471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCamLookSliderPolyBorderThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thickness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCamLookSliderPolyBorderThickness_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0006CE74 File Offset: 0x0006B074
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 71474, RefRangeEnd = 71477, XrefRangeStart = 71471, XrefRangeEnd = 71474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoPlaneSlider3D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0006CEC4 File Offset: 0x0006B0C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70422, RefRangeEnd = 70423, XrefRangeStart = 70422, XrefRangeEnd = 70423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMidCapLookAndFeel(GizmoCap3D cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0006CF08 File Offset: 0x0006B108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71479, RefRangeEnd = 71480, XrefRangeStart = 71477, XrefRangeEnd = 71479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectCamLookSliderLookAndFeel_Public_Void_GizmoPlaneSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00009785 File Offset: 0x00007985
		public RotationGizmoLookAndFeel3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0006CF4C File Offset: 0x0006B14C
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x0000978E File Offset: 0x0000798E
		public unsafe bool _isMidCapVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__isMidCapVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__isMidCapVisible)) = value;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0006CF74 File Offset: 0x0006B174
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x000097A9 File Offset: 0x000079A9
		public unsafe GizmoCap3DLookAndFeel _midCapLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__midCapLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__midCapLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0006CFA4 File Offset: 0x0006B1A4
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x000097C8 File Offset: 0x000079C8
		public unsafe Il2CppStructArray<bool> _axesVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__axesVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__axesVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x0006CFD4 File Offset: 0x0006B1D4
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x000097E7 File Offset: 0x000079E7
		public unsafe Il2CppReferenceArray<GizmoPlaneSlider3DLookAndFeel> _axesLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__axesLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoPlaneSlider3DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__axesLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x0006D004 File Offset: 0x0006B204
		// (set) Token: 0x060013EA RID: 5098 RVA: 0x00009806 File Offset: 0x00007A06
		public unsafe bool _isCamLookSliderVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__isCamLookSliderVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__isCamLookSliderVisible)) = value;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0006D02C File Offset: 0x0006B22C
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x00009821 File Offset: 0x00007A21
		public unsafe float _camLookSliderRadiusOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__camLookSliderRadiusOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__camLookSliderRadiusOffset)) = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0006D054 File Offset: 0x0006B254
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x0000983C File Offset: 0x00007A3C
		public unsafe GizmoPlaneSlider2DLookAndFeel _camLookSliderLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__camLookSliderLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoLookAndFeel3D.NativeFieldInfoPtr__camLookSliderLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeFieldInfoPtr__isMidCapVisible;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeFieldInfoPtr__midCapLookAndFeel;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeFieldInfoPtr__axesVis;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeFieldInfoPtr__axesLookAndFeel;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeFieldInfoPtr__isCamLookSliderVisible;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeFieldInfoPtr__camLookSliderRadiusOffset;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeFieldInfoPtr__camLookSliderLookAndFeel;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_get_XBorderColor_Public_get_Color_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_get_YBorderColor_Public_get_Color_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_get_ZBorderColor_Public_get_Color_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisTorusThickness_Public_get_Single_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisCylTorusWidth_Public_get_Single_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisCylTorusHeight_Public_get_Single_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisCullAlphaScale_Public_get_Single_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisBorderType_Public_get_GizmoCircle3DBorderType_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisBorderFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_get_NumAxisTorusWireAxialSlices_Public_get_Int32_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationArcColor_Public_get_Color_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationArcBorderColor_Public_get_Color_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr_get_UseShortestRotationArc_Public_get_Boolean_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapColor_Public_get_Color_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapBorderColor_Public_get_Color_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredMidCapColor_Public_get_Color_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMidCapVisible_Public_get_Boolean_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMidCapBorderVisible_Public_get_Boolean_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_get_CamLookSliderRadiusOffset_Public_get_Single_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_get_CamLookSliderBorderColor_Public_get_Color_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_get_CamLookSliderHoveredBorderColor_Public_get_Color_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_get_CamLookSliderPolyBorderType_Public_get_GizmoPolygon2DBorderType_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_get_CamLookSliderPolyBorderThickness_Public_get_Single_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCamLookSliderVisible_Public_get_Boolean_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_IsAxisVisible_Public_Boolean_Int32_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisVisible_Public_Void_Int32_Boolean_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_SetShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisBorderFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_SetNumAxisTorusWireAxialSlices_Public_Void_Int32_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_SetRadius_Public_Void_Single_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisBorderCullAlphaScale_Public_Void_Single_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisBorderType_Public_Void_GizmoCircle3DBorderType_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisTorusThickness_Public_Void_Single_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisCylTorusWidth_Public_Void_Single_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisCylTorusHeight_Public_Void_Single_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapVisible_Public_Void_Boolean_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_SetHoveredMidCapColor_Public_Void_Color_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapBorderVisible_Public_Void_Boolean_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapBorderColor_Public_Void_Color_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisBorderColor_Public_Void_Int32_Color_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_SetRotationArcColor_Public_Void_Color_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_SetRotationArcBorderColor_Public_Void_Color_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_SetUseShortestRotationArc_Public_Void_Boolean_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_SetRotationArcVisible_Public_Void_Boolean_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_SetCamLookSliderRadiusOffset_Public_Void_Single_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_SetCamLookSliderBorderColor_Public_Void_Color_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_SetCamLookSliderHoveredBorderColor_Public_Void_Color_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_SetCamLookSliderVisible_Public_Void_Boolean_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_SetCamLookSliderPolyBorderType_Public_Void_GizmoPolygon2DBorderType_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_SetCamLookSliderPolyBorderThickness_Public_Void_Single_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoPlaneSlider3D_Int32_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_ConnectCamLookSliderLookAndFeel_Public_Void_GizmoPlaneSlider2D_0;
	}
}
