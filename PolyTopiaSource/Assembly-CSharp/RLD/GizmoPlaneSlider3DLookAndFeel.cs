using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000A9 RID: 169
	[Serializable]
	public class GizmoPlaneSlider3DLookAndFeel : global::Il2CppSystem.Object
	{
		// Token: 0x06000E30 RID: 3632 RVA: 0x00057B30 File Offset: 0x00055D30
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPlaneSlider3DLookAndFeel()
		{
			Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPlaneSlider3DLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr);
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__planeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_planeType");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_scale");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__useZoomFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_useZoomFactor");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__quadWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_quadWidth");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__quadHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_quadHeight");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__raTriangleXLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_raTriangleXLength");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__raTriangleYLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_raTriangleYLength");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__circleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_circleRadius");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderBoxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_borderBoxHeight");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderBoxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_borderBoxDepth");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderTorusThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_borderTorusThickness");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__numBorderTorusWireAxialSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_numBorderTorusWireAxialSlices");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderCylTorusWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_borderCylTorusWidth");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderCylTorusHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_borderCylTorusHeight");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__shadeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_shadeMode");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_color");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__hoveredColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_hoveredColor");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_borderColor");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_hoveredBorderColor");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderCircleCullAlphaScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_borderCircleCullAlphaScale");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderShadeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_borderShadeMode");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderFillMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_borderFillMode");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__quadBorderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_quadBorderType");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__raTriangleBorderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_raTriangleBorderType");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__circleBorderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_circleBorderType");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_isRotationArcVisible");
			GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, "_rotationArcLookAndFeel");
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665354);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_ShadeMode_Public_set_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665355);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_PlaneType_Public_get_GizmoPlane3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665356);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_PlaneType_Public_set_Void_GizmoPlane3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665357);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665358);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665359);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665360);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665361);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_QuadWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665362);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_QuadWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665363);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_QuadHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665364);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_QuadHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665365);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_RATriangleXLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665366);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_RATriangleXLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665367);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_RATriangleYLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665368);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_RATriangleYLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665369);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_CircleRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665370);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_CircleRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665371);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderCircleCullAlphaScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665372);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderCircleCullAlphaScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665373);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderBoxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665374);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderBoxHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665375);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderBoxDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665376);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderBoxDepth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665377);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderTorusThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665378);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderTorusThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665379);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderCylTorusWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665380);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderCylTorusWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665381);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderCylTorusHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665382);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderCylTorusHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665383);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_NumBorderTorusWireAxialSlices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665384);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_NumBorderTorusWireAxialSlices_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665385);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665386);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665387);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665388);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665389);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665390);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665391);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665392);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665393);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665394);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderShadeMode_Public_set_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665395);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665396);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderFillMode_Public_set_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665397);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_QuadBorderType_Public_get_GizmoQuad3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665398);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_QuadBorderType_Public_set_Void_GizmoQuad3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665399);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_CircleBorderType_Public_get_GizmoCircle3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665400);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_CircleBorderType_Public_set_Void_GizmoCircle3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665401);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_RATriangleBorderType_Public_get_GizmoRATriangle3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665402);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_RATriangleBorderType_Public_set_Void_GizmoRATriangle3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665403);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665404);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665405);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665406);
			GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr, 100665407);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000581B4 File Offset: 0x000563B4
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x000581F4 File Offset: 0x000563F4
		public unsafe GizmoShadeMode ShadeMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 28415, RefRangeEnd = 28418, XrefRangeStart = 28415, XrefRangeEnd = 28418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_ShadeMode_Public_set_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00058238 File Offset: 0x00056438
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x00058278 File Offset: 0x00056478
		public unsafe GizmoPlane3DType PlaneType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_PlaneType_Public_get_GizmoPlane3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlane3DType>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_PlaneType_Public_set_Void_GizmoPlane3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x000582BC File Offset: 0x000564BC
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x000582F8 File Offset: 0x000564F8
		public unsafe float Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 65770, RefRangeEnd = 65793, XrefRangeStart = 65770, XrefRangeEnd = 65793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00058338 File Offset: 0x00056538
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00058374 File Offset: 0x00056574
		public unsafe bool UseZoomFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x000583B4 File Offset: 0x000565B4
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x000583F0 File Offset: 0x000565F0
		public unsafe float QuadWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_QuadWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 57743, RefRangeEnd = 57779, XrefRangeStart = 57743, XrefRangeEnd = 57779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_QuadWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00058430 File Offset: 0x00056630
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x0005846C File Offset: 0x0005666C
		public unsafe float QuadHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_QuadHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 57150, RefRangeEnd = 57178, XrefRangeStart = 57150, XrefRangeEnd = 57178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_QuadHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x000584AC File Offset: 0x000566AC
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x000584E8 File Offset: 0x000566E8
		public unsafe float RATriangleXLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_RATriangleXLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 57179, RefRangeEnd = 57194, XrefRangeStart = 57179, XrefRangeEnd = 57194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_RATriangleXLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00058528 File Offset: 0x00056728
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00058564 File Offset: 0x00056764
		public unsafe float RATriangleYLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_RATriangleYLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 57194, RefRangeEnd = 57207, XrefRangeStart = 57194, XrefRangeEnd = 57207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_RATriangleYLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x000585A4 File Offset: 0x000567A4
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x000585E0 File Offset: 0x000567E0
		public unsafe float CircleRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_CircleRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 57207, RefRangeEnd = 57220, XrefRangeStart = 57207, XrefRangeEnd = 57220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_CircleRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00058620 File Offset: 0x00056820
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x0005865C File Offset: 0x0005685C
		public unsafe float BorderCircleCullAlphaScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderCircleCullAlphaScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 68146, RefRangeEnd = 68149, XrefRangeStart = 68146, XrefRangeEnd = 68146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderCircleCullAlphaScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0005869C File Offset: 0x0005689C
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x000586D8 File Offset: 0x000568D8
		public unsafe float BorderBoxHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderBoxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 67305, RefRangeEnd = 67314, XrefRangeStart = 67305, XrefRangeEnd = 67314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderBoxHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00058718 File Offset: 0x00056918
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00058754 File Offset: 0x00056954
		public unsafe float BorderBoxDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderBoxDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 68149, RefRangeEnd = 68152, XrefRangeStart = 68149, XrefRangeEnd = 68149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderBoxDepth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00058794 File Offset: 0x00056994
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x000587D0 File Offset: 0x000569D0
		public unsafe float BorderTorusThickness
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57816, RefRangeEnd = 57817, XrefRangeStart = 57816, XrefRangeEnd = 57817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderTorusThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 68152, RefRangeEnd = 68155, XrefRangeStart = 68152, XrefRangeEnd = 68152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderTorusThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00058810 File Offset: 0x00056A10
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x0005884C File Offset: 0x00056A4C
		public unsafe float BorderCylTorusWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57846, RefRangeEnd = 57847, XrefRangeStart = 57846, XrefRangeEnd = 57847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderCylTorusWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 68155, RefRangeEnd = 68158, XrefRangeStart = 68155, XrefRangeEnd = 68155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderCylTorusWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0005888C File Offset: 0x00056A8C
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x000588C8 File Offset: 0x00056AC8
		public unsafe float BorderCylTorusHeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57861, RefRangeEnd = 57864, XrefRangeStart = 57861, XrefRangeEnd = 57864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderCylTorusHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 63686, RefRangeEnd = 63692, XrefRangeStart = 63686, XrefRangeEnd = 63692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderCylTorusHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00058908 File Offset: 0x00056B08
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00058944 File Offset: 0x00056B44
		public unsafe int NumBorderTorusWireAxialSlices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_NumBorderTorusWireAxialSlices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 68158, RefRangeEnd = 68162, XrefRangeStart = 68158, XrefRangeEnd = 68158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_NumBorderTorusWireAxialSlices_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00058984 File Offset: 0x00056B84
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x000589C4 File Offset: 0x00056BC4
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00058A08 File Offset: 0x00056C08
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00058A48 File Offset: 0x00056C48
		public unsafe Color HoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00058A8C File Offset: 0x00056C8C
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00058ACC File Offset: 0x00056CCC
		public unsafe Color BorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00058B10 File Offset: 0x00056D10
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00058B50 File Offset: 0x00056D50
		public unsafe Color HoveredBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00058B94 File Offset: 0x00056D94
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00058BD4 File Offset: 0x00056DD4
		public unsafe GizmoShadeMode BorderShadeMode
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 24691, RefRangeEnd = 24697, XrefRangeStart = 24691, XrefRangeEnd = 24697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderShadeMode_Public_set_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x00058C18 File Offset: 0x00056E18
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x00058C58 File Offset: 0x00056E58
		public unsafe GizmoFillMode3D BorderFillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_BorderFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_BorderFillMode_Public_set_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00058C9C File Offset: 0x00056E9C
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00058CDC File Offset: 0x00056EDC
		public unsafe GizmoQuad3DBorderType QuadBorderType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_QuadBorderType_Public_get_GizmoQuad3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoQuad3DBorderType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_QuadBorderType_Public_set_Void_GizmoQuad3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00058D20 File Offset: 0x00056F20
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00058D60 File Offset: 0x00056F60
		public unsafe GizmoCircle3DBorderType CircleBorderType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 68162, RefRangeEnd = 68163, XrefRangeStart = 68162, XrefRangeEnd = 68162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_CircleBorderType_Public_get_GizmoCircle3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCircle3DBorderType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_CircleBorderType_Public_set_Void_GizmoCircle3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00058DA4 File Offset: 0x00056FA4
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00058DE4 File Offset: 0x00056FE4
		public unsafe GizmoRATriangle3DBorderType RATriangleBorderType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_RATriangleBorderType_Public_get_GizmoRATriangle3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoRATriangle3DBorderType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_RATriangleBorderType_Public_set_Void_GizmoRATriangle3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00058E28 File Offset: 0x00057028
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00058E64 File Offset: 0x00057064
		public unsafe bool IsRotationArcVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00058EA4 File Offset: 0x000570A4
		public unsafe GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc3DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00058EE4 File Offset: 0x000570E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 68171, RefRangeEnd = 68177, XrefRangeStart = 68163, XrefRangeEnd = 68171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPlaneSlider3DLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPlaneSlider3DLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000072E1 File Offset: 0x000054E1
		public GizmoPlaneSlider3DLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00058F20 File Offset: 0x00057120
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x000072EA File Offset: 0x000054EA
		public unsafe GizmoPlane3DType _planeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__planeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlane3DType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__planeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00058F50 File Offset: 0x00057150
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00007309 File Offset: 0x00005509
		public unsafe float _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__scale)) = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00058F78 File Offset: 0x00057178
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00007324 File Offset: 0x00005524
		public unsafe bool _useZoomFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__useZoomFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__useZoomFactor)) = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00058FA0 File Offset: 0x000571A0
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x0000733F File Offset: 0x0000553F
		public unsafe float _quadWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__quadWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__quadWidth)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x00058FC8 File Offset: 0x000571C8
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x0000735A File Offset: 0x0000555A
		public unsafe float _quadHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__quadHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__quadHeight)) = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00058FF0 File Offset: 0x000571F0
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00007375 File Offset: 0x00005575
		public unsafe float _raTriangleXLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__raTriangleXLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__raTriangleXLength)) = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00059018 File Offset: 0x00057218
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00007390 File Offset: 0x00005590
		public unsafe float _raTriangleYLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__raTriangleYLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__raTriangleYLength)) = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00059040 File Offset: 0x00057240
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x000073AB File Offset: 0x000055AB
		public unsafe float _circleRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__circleRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__circleRadius)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00059068 File Offset: 0x00057268
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x000073C6 File Offset: 0x000055C6
		public unsafe float _borderBoxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderBoxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderBoxHeight)) = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00059090 File Offset: 0x00057290
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x000073E1 File Offset: 0x000055E1
		public unsafe float _borderBoxDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderBoxDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderBoxDepth)) = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000590B8 File Offset: 0x000572B8
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x000073FC File Offset: 0x000055FC
		public unsafe float _borderTorusThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderTorusThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderTorusThickness)) = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x000590E0 File Offset: 0x000572E0
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00007417 File Offset: 0x00005617
		public unsafe int _numBorderTorusWireAxialSlices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__numBorderTorusWireAxialSlices);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__numBorderTorusWireAxialSlices)) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00059108 File Offset: 0x00057308
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00007432 File Offset: 0x00005632
		public unsafe float _borderCylTorusWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderCylTorusWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderCylTorusWidth)) = value;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00059130 File Offset: 0x00057330
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x0000744D File Offset: 0x0000564D
		public unsafe float _borderCylTorusHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderCylTorusHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderCylTorusHeight)) = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00059158 File Offset: 0x00057358
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00007468 File Offset: 0x00005668
		public unsafe GizmoShadeMode _shadeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__shadeMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__shadeMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00059188 File Offset: 0x00057388
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00007487 File Offset: 0x00005687
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000591B8 File Offset: 0x000573B8
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x000074A6 File Offset: 0x000056A6
		public unsafe Color _hoveredColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__hoveredColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__hoveredColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x000591E8 File Offset: 0x000573E8
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x000074C5 File Offset: 0x000056C5
		public unsafe Color _borderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00059218 File Offset: 0x00057418
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x000074E4 File Offset: 0x000056E4
		public unsafe Color _hoveredBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00059248 File Offset: 0x00057448
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x00007503 File Offset: 0x00005703
		public unsafe float _borderCircleCullAlphaScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderCircleCullAlphaScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderCircleCullAlphaScale)) = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00059270 File Offset: 0x00057470
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x0000751E File Offset: 0x0000571E
		public unsafe GizmoShadeMode _borderShadeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderShadeMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderShadeMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x000592A0 File Offset: 0x000574A0
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x0000753D File Offset: 0x0000573D
		public unsafe GizmoFillMode3D _borderFillMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderFillMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__borderFillMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x000592D0 File Offset: 0x000574D0
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x0000755C File Offset: 0x0000575C
		public unsafe GizmoQuad3DBorderType _quadBorderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__quadBorderType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad3DBorderType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__quadBorderType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00059300 File Offset: 0x00057500
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x0000757B File Offset: 0x0000577B
		public unsafe GizmoRATriangle3DBorderType _raTriangleBorderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__raTriangleBorderType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRATriangle3DBorderType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__raTriangleBorderType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00059330 File Offset: 0x00057530
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x0000759A File Offset: 0x0000579A
		public unsafe GizmoCircle3DBorderType _circleBorderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__circleBorderType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle3DBorderType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__circleBorderType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00059360 File Offset: 0x00057560
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x000075B9 File Offset: 0x000057B9
		public unsafe bool _isRotationArcVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible)) = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00059388 File Offset: 0x00057588
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x000075D4 File Offset: 0x000057D4
		public unsafe GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeFieldInfoPtr__planeType;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeFieldInfoPtr__useZoomFactor;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeFieldInfoPtr__quadWidth;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeFieldInfoPtr__quadHeight;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeFieldInfoPtr__raTriangleXLength;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeFieldInfoPtr__raTriangleYLength;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeFieldInfoPtr__circleRadius;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeFieldInfoPtr__borderBoxHeight;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeFieldInfoPtr__borderBoxDepth;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeFieldInfoPtr__borderTorusThickness;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeFieldInfoPtr__numBorderTorusWireAxialSlices;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr__borderCylTorusWidth;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr__borderCylTorusHeight;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr__shadeMode;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr__hoveredColor;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeFieldInfoPtr__borderColor;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr__hoveredBorderColor;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr__borderCircleCullAlphaScale;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr__borderShadeMode;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr__borderFillMode;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr__quadBorderType;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr__raTriangleBorderType;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr__circleBorderType;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr__isRotationArcVisible;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr__rotationArcLookAndFeel;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_set_ShadeMode_Public_set_Void_GizmoShadeMode_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_get_PlaneType_Public_get_GizmoPlane3DType_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_set_PlaneType_Public_set_Void_GizmoPlane3DType_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr_get_QuadWidth_Public_get_Single_0;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr_set_QuadWidth_Public_set_Void_Single_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr_get_QuadHeight_Public_get_Single_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_set_QuadHeight_Public_set_Void_Single_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_get_RATriangleXLength_Public_get_Single_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_set_RATriangleXLength_Public_set_Void_Single_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_get_RATriangleYLength_Public_get_Single_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_set_RATriangleYLength_Public_set_Void_Single_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_get_CircleRadius_Public_get_Single_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_set_CircleRadius_Public_set_Void_Single_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderCircleCullAlphaScale_Public_get_Single_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderCircleCullAlphaScale_Public_set_Void_Single_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderBoxHeight_Public_get_Single_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderBoxHeight_Public_set_Void_Single_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderBoxDepth_Public_get_Single_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderBoxDepth_Public_set_Void_Single_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderTorusThickness_Public_get_Single_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderTorusThickness_Public_set_Void_Single_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderCylTorusWidth_Public_get_Single_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderCylTorusWidth_Public_set_Void_Single_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderCylTorusHeight_Public_get_Single_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderCylTorusHeight_Public_set_Void_Single_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_get_NumBorderTorusWireAxialSlices_Public_get_Int32_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_set_NumBorderTorusWireAxialSlices_Public_set_Void_Int32_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderShadeMode_Public_set_Void_GizmoShadeMode_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderFillMode_Public_set_Void_GizmoFillMode3D_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_get_QuadBorderType_Public_get_GizmoQuad3DBorderType_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_set_QuadBorderType_Public_set_Void_GizmoQuad3DBorderType_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_get_CircleBorderType_Public_get_GizmoCircle3DBorderType_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_set_CircleBorderType_Public_set_Void_GizmoCircle3DBorderType_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_get_RATriangleBorderType_Public_get_GizmoRATriangle3DBorderType_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_set_RATriangleBorderType_Public_set_Void_GizmoRATriangle3DBorderType_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc3DLookAndFeel_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
