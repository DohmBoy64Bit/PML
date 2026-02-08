using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200006E RID: 110
	[Serializable]
	public class ObjectExtrudeGizmoLookAndFeel3D : Settings
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x000403A4 File Offset: 0x0003E5A4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectExtrudeGizmoLookAndFeel3D()
		{
			Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectExtrudeGizmoLookAndFeel3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr);
			ObjectExtrudeGizmoLookAndFeel3D.NativeFieldInfoPtr__boxWireColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, "_boxWireColor");
			ObjectExtrudeGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSlidersLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, "_sglSlidersLookAndFeel");
			ObjectExtrudeGizmoLookAndFeel3D.NativeFieldInfoPtr__extrudeSliderVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, "_extrudeSliderVis");
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664500);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxWireColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664501);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664502);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664503);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664504);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664505);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664506);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664507);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664508);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664509);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664510);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664511);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664512);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapBaseRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664513);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664514);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664515);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664516);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664517);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664518);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664519);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderSphereCapRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664520);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664521);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_IsExtrudeSliderVisible_Public_Boolean_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664522);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetExtrudeSliderVisible_Public_Void_Int32_AxisSign_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664523);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxWireColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664524);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664525);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664526);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664527);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664528);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664529);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapBaseRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664530);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664531);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664532);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664533);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664534);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664535);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664536);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderSphereCapRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664537);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664538);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664539);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664540);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664541);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664542);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664543);
			ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_GetSglSliderLookAndFeel_Private_GizmoLineSlider3DLookAndFeel_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr, 100664544);
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00040794 File Offset: 0x0003E994
		public unsafe bool UseZoomFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x000407D0 File Offset: 0x0003E9D0
		public unsafe Color BoxWireColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxWireColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00040810 File Offset: 0x0003EA10
		public unsafe GizmoCap3DType SliderCapType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DType>(intPtr3) : null;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00040850 File Offset: 0x0003EA50
		public unsafe GizmoShadeMode SliderCapShadeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00040890 File Offset: 0x0003EA90
		public unsafe GizmoFillMode3D SliderCapFillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000408D0 File Offset: 0x0003EAD0
		public unsafe Color XColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00040910 File Offset: 0x0003EB10
		public unsafe Color YColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00040950 File Offset: 0x0003EB50
		public unsafe Color ZColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00040990 File Offset: 0x0003EB90
		public unsafe Color HoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x000409D0 File Offset: 0x0003EBD0
		public unsafe float SliderBoxCapWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00040A0C File Offset: 0x0003EC0C
		public unsafe float SliderBoxCapHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00040A48 File Offset: 0x0003EC48
		public unsafe float SliderBoxCapDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00040A84 File Offset: 0x0003EC84
		public unsafe float SliderConeCapHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00040AC0 File Offset: 0x0003ECC0
		public unsafe float SliderConeCapBaseRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapBaseRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00040AFC File Offset: 0x0003ECFC
		public unsafe float SliderPyramidCapWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00040B38 File Offset: 0x0003ED38
		public unsafe float SliderPyramidCapHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00040B74 File Offset: 0x0003ED74
		public unsafe float SliderPyramidCapDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00040BB0 File Offset: 0x0003EDB0
		public unsafe float SliderTriPrismCapWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00040BEC File Offset: 0x0003EDEC
		public unsafe float SliderTriPrismCapHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00040C28 File Offset: 0x0003EE28
		public unsafe float SliderTriPrismCapDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00040C64 File Offset: 0x0003EE64
		public unsafe float SliderSphereCapRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderSphereCapRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00040CA0 File Offset: 0x0003EEA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62886, RefRangeEnd = 62888, XrefRangeStart = 62864, XrefRangeEnd = 62886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectExtrudeGizmoLookAndFeel3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectExtrudeGizmoLookAndFeel3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00040CDC File Offset: 0x0003EEDC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 62888, RefRangeEnd = 62894, XrefRangeStart = 62888, XrefRangeEnd = 62888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsExtrudeSliderVisible(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_IsExtrudeSliderVisible_Public_Boolean_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00040D38 File Offset: 0x0003EF38
		[CallerCount(0)]
		public unsafe void SetExtrudeSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetExtrudeSliderVisible_Public_Void_Int32_AxisSign_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00040D98 File Offset: 0x0003EF98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 58119, RefRangeEnd = 58122, XrefRangeStart = 58119, XrefRangeEnd = 58122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxWireColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxWireColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00040DDC File Offset: 0x0003EFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62894, XrefRangeEnd = 62895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapType(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00040E20 File Offset: 0x0003F020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62895, XrefRangeEnd = 62897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderBoxCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00040E60 File Offset: 0x0003F060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62897, XrefRangeEnd = 62899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderBoxCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00040EA0 File Offset: 0x0003F0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62899, XrefRangeEnd = 62901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderBoxCapDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00040EE0 File Offset: 0x0003F0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62901, XrefRangeEnd = 62903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderConeCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00040F20 File Offset: 0x0003F120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62903, XrefRangeEnd = 62905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderConeCapBaseRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapBaseRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00040F60 File Offset: 0x0003F160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62905, XrefRangeEnd = 62907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderPyramidCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00040FA0 File Offset: 0x0003F1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62907, XrefRangeEnd = 62909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderPyramidCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00040FE0 File Offset: 0x0003F1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62909, XrefRangeEnd = 62911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderPyramidCapDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00041020 File Offset: 0x0003F220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62911, XrefRangeEnd = 62913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderTriPrismCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00041060 File Offset: 0x0003F260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62913, XrefRangeEnd = 62915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderTriPrismCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000410A0 File Offset: 0x0003F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62915, XrefRangeEnd = 62917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderTriPrismCapDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000410E0 File Offset: 0x0003F2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62917, XrefRangeEnd = 62919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderSphereCapRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderSphereCapRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00041120 File Offset: 0x0003F320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62919, XrefRangeEnd = 62920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUseZoomFactor(bool useZoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useZoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00041160 File Offset: 0x0003F360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62920, XrefRangeEnd = 62921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000411A4 File Offset: 0x0003F3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62921, XrefRangeEnd = 62922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000411E8 File Offset: 0x0003F3E8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00041238 File Offset: 0x0003F438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62922, XrefRangeEnd = 62923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoveredColor(Color hoveredColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoveredColor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0004127C File Offset: 0x0003F47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62923, XrefRangeEnd = 62927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000412E0 File Offset: 0x0003F4E0
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoLookAndFeel3D.NativeMethodInfoPtr_GetSglSliderLookAndFeel_Private_GizmoLineSlider3DLookAndFeel_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DLookAndFeel>(intPtr3) : null;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00004B2F File Offset: 0x00002D2F
		public ObjectExtrudeGizmoLookAndFeel3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00041340 File Offset: 0x0003F540
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00004B38 File Offset: 0x00002D38
		public unsafe Color _boxWireColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoLookAndFeel3D.NativeFieldInfoPtr__boxWireColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoLookAndFeel3D.NativeFieldInfoPtr__boxWireColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00041370 File Offset: 0x0003F570
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00004B57 File Offset: 0x00002D57
		public unsafe Il2CppReferenceArray<GizmoLineSlider3DLookAndFeel> _sglSlidersLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSlidersLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider3DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSlidersLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000413A0 File Offset: 0x0003F5A0
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00004B76 File Offset: 0x00002D76
		public unsafe Il2CppStructArray<bool> _extrudeSliderVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoLookAndFeel3D.NativeFieldInfoPtr__extrudeSliderVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoLookAndFeel3D.NativeFieldInfoPtr__extrudeSliderVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr__boxWireColor;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr__sglSlidersLookAndFeel;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr__extrudeSliderVis;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxWireColor_Public_get_Color_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap3DType_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_get_XColor_Public_get_Color_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_get_YColor_Public_get_Color_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_get_ZColor_Public_get_Color_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderBoxCapWidth_Public_get_Single_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderBoxCapHeight_Public_get_Single_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderBoxCapDepth_Public_get_Single_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderConeCapHeight_Public_get_Single_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderConeCapBaseRadius_Public_get_Single_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderPyramidCapWidth_Public_get_Single_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderPyramidCapHeight_Public_get_Single_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderPyramidCapDepth_Public_get_Single_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderTriPrismCapWidth_Public_get_Single_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderTriPrismCapHeight_Public_get_Single_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderTriPrismCapDepth_Public_get_Single_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderSphereCapRadius_Public_get_Single_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_IsExtrudeSliderVisible_Public_Boolean_Int32_AxisSign_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_SetExtrudeSliderVisible_Public_Void_Int32_AxisSign_Boolean_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxWireColor_Public_Void_Color_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap3DType_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderBoxCapWidth_Public_Void_Single_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderBoxCapHeight_Public_Void_Single_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderBoxCapDepth_Public_Void_Single_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderConeCapHeight_Public_Void_Single_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderConeCapBaseRadius_Public_Void_Single_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderPyramidCapWidth_Public_Void_Single_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderPyramidCapHeight_Public_Void_Single_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderPyramidCapDepth_Public_Void_Single_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderTriPrismCapWidth_Public_Void_Single_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderTriPrismCapHeight_Public_Void_Single_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderTriPrismCapDepth_Public_Void_Single_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderSphereCapRadius_Public_Void_Single_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_GetSglSliderLookAndFeel_Private_GizmoLineSlider3DLookAndFeel_Int32_AxisSign_0;
	}
}
