using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000092 RID: 146
	[Serializable]
	public class GizmoPlaneSlider2DLookAndFeel : global::Il2CppSystem.Object
	{
		// Token: 0x06000BBA RID: 3002 RVA: 0x0004E54C File Offset: 0x0004C74C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPlaneSlider2DLookAndFeel()
		{
			Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPlaneSlider2DLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr);
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__fillMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_fillMode");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__planeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_planeType");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_scale");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__quadWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_quadWidth");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__quadHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_quadHeight");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__circleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_circleRadius");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_isRotationArcVisible");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_rotationArcLookAndFeel");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_color");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_hoveredColor");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__borderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_borderColor");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_hoveredBorderColor");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__quadBorderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_quadBorderType");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__circleBorderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_circleBorderType");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__polygonBorderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_polygonBorderType");
			GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__borderPolyThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, "_borderPolyThickness");
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665014);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665015);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_PlaneType_Public_get_GizmoPlane2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665016);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_PlaneType_Public_set_Void_GizmoPlane2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665017);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665018);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665019);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_QuadWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665020);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_QuadWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665021);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_QuadHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665022);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_QuadHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665023);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_CircleRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665024);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_CircleRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665025);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665026);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665027);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665028);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665029);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665030);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665031);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665032);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665033);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665034);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665035);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665036);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_QuadBorderType_Public_get_GizmoQuad2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665037);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_QuadBorderType_Public_set_Void_GizmoQuad2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665038);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_CircleBorderType_Public_get_GizmoCircle2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665039);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_CircleBorderType_Public_set_Void_GizmoCircle2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665040);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_PolygonBorderType_Public_get_GizmoPolygon2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665041);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_PolygonBorderType_Public_set_Void_GizmoPolygon2DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665042);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_BorderPolyThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665043);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_BorderPolyThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665044);
			GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr, 100665045);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0004E93C File Offset: 0x0004CB3C
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0004E97C File Offset: 0x0004CB7C
		public unsafe GizmoFillMode2D FillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0004E9C0 File Offset: 0x0004CBC0
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0004EA00 File Offset: 0x0004CC00
		public unsafe GizmoPlane2DType PlaneType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_PlaneType_Public_get_GizmoPlane2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlane2DType>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43069, RefRangeEnd = 43073, XrefRangeStart = 43069, XrefRangeEnd = 43073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_PlaneType_Public_set_Void_GizmoPlane2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0004EA44 File Offset: 0x0004CC44
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x0004EA80 File Offset: 0x0004CC80
		public unsafe float Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 57121, RefRangeEnd = 57146, XrefRangeStart = 57121, XrefRangeEnd = 57146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0004EAC0 File Offset: 0x0004CCC0
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x0004EAFC File Offset: 0x0004CCFC
		public unsafe float QuadWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_QuadWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_QuadWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0004EB3C File Offset: 0x0004CD3C
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x0004EB78 File Offset: 0x0004CD78
		public unsafe float QuadHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_QuadHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_QuadHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0004EBF4 File Offset: 0x0004CDF4
		public unsafe float CircleRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_CircleRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_CircleRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0004EC34 File Offset: 0x0004CE34
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x0004EC70 File Offset: 0x0004CE70
		public unsafe bool IsRotationArcVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0004ECB0 File Offset: 0x0004CEB0
		public unsafe GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc2DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0004ECF0 File Offset: 0x0004CEF0
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0004ED30 File Offset: 0x0004CF30
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0004ED74 File Offset: 0x0004CF74
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x0004EDB4 File Offset: 0x0004CFB4
		public unsafe Color HoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0004EDF8 File Offset: 0x0004CFF8
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x0004EE38 File Offset: 0x0004D038
		public unsafe Color BorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0004EE7C File Offset: 0x0004D07C
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0004EEBC File Offset: 0x0004D0BC
		public unsafe Color HoveredBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0004EF00 File Offset: 0x0004D100
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0004EF40 File Offset: 0x0004D140
		public unsafe GizmoQuad2DBorderType QuadBorderType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_QuadBorderType_Public_get_GizmoQuad2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoQuad2DBorderType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_QuadBorderType_Public_set_Void_GizmoQuad2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0004EF84 File Offset: 0x0004D184
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0004EFC4 File Offset: 0x0004D1C4
		public unsafe GizmoCircle2DBorderType CircleBorderType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_CircleBorderType_Public_get_GizmoCircle2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCircle2DBorderType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_CircleBorderType_Public_set_Void_GizmoCircle2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0004F008 File Offset: 0x0004D208
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0004F048 File Offset: 0x0004D248
		public unsafe GizmoPolygon2DBorderType PolygonBorderType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_PolygonBorderType_Public_get_GizmoPolygon2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPolygon2DBorderType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_PolygonBorderType_Public_set_Void_GizmoPolygon2DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0004F08C File Offset: 0x0004D28C
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x0004F0C8 File Offset: 0x0004D2C8
		public unsafe float BorderPolyThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_get_BorderPolyThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 66231, RefRangeEnd = 66236, XrefRangeStart = 66231, XrefRangeEnd = 66231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr_set_BorderPolyThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0004F108 File Offset: 0x0004D308
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 66244, RefRangeEnd = 66248, XrefRangeStart = 66236, XrefRangeEnd = 66244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPlaneSlider2DLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPlaneSlider2DLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0000631C File Offset: 0x0000451C
		public GizmoPlaneSlider2DLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0004F144 File Offset: 0x0004D344
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x00006325 File Offset: 0x00004525
		public unsafe GizmoFillMode2D _fillMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__fillMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__fillMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0004F174 File Offset: 0x0004D374
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00006344 File Offset: 0x00004544
		public unsafe GizmoPlane2DType _planeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__planeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlane2DType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__planeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0004F1A4 File Offset: 0x0004D3A4
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00006363 File Offset: 0x00004563
		public unsafe float _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__scale)) = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0004F1CC File Offset: 0x0004D3CC
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0000637E File Offset: 0x0000457E
		public unsafe float _quadWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__quadWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__quadWidth)) = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0004F1F4 File Offset: 0x0004D3F4
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00006399 File Offset: 0x00004599
		public unsafe float _quadHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__quadHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__quadHeight)) = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0004F21C File Offset: 0x0004D41C
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x000063B4 File Offset: 0x000045B4
		public unsafe float _circleRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__circleRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__circleRadius)) = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0004F244 File Offset: 0x0004D444
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x000063CF File Offset: 0x000045CF
		public unsafe bool _isRotationArcVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible)) = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0004F26C File Offset: 0x0004D46C
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x000063EA File Offset: 0x000045EA
		public unsafe GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0004F29C File Offset: 0x0004D49C
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00006409 File Offset: 0x00004609
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0004F2CC File Offset: 0x0004D4CC
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00006428 File Offset: 0x00004628
		public unsafe Color _hoveredColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0004F2FC File Offset: 0x0004D4FC
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00006447 File Offset: 0x00004647
		public unsafe Color _borderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__borderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__borderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0004F32C File Offset: 0x0004D52C
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00006466 File Offset: 0x00004666
		public unsafe Color _hoveredBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0004F35C File Offset: 0x0004D55C
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00006485 File Offset: 0x00004685
		public unsafe GizmoQuad2DBorderType _quadBorderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__quadBorderType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad2DBorderType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__quadBorderType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0004F38C File Offset: 0x0004D58C
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x000064A4 File Offset: 0x000046A4
		public unsafe GizmoCircle2DBorderType _circleBorderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__circleBorderType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle2DBorderType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__circleBorderType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0004F3BC File Offset: 0x0004D5BC
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x000064C3 File Offset: 0x000046C3
		public unsafe GizmoPolygon2DBorderType _polygonBorderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__polygonBorderType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPolygon2DBorderType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__polygonBorderType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0004F3EC File Offset: 0x0004D5EC
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x000064E2 File Offset: 0x000046E2
		public unsafe float _borderPolyThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__borderPolyThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DLookAndFeel.NativeFieldInfoPtr__borderPolyThickness)) = value;
			}
		}

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr__fillMode;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr__planeType;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr__quadWidth;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr__quadHeight;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr__circleRadius;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr__isRotationArcVisible;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr__rotationArcLookAndFeel;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr__hoveredColor;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr__borderColor;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr__hoveredBorderColor;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr__quadBorderType;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr__circleBorderType;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr__polygonBorderType;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr__borderPolyThickness;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode2D_0;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr_get_PlaneType_Public_get_GizmoPlane2DType_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr_set_PlaneType_Public_set_Void_GizmoPlane2DType_0;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_get_QuadWidth_Public_get_Single_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_set_QuadWidth_Public_set_Void_Single_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_get_QuadHeight_Public_get_Single_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_set_QuadHeight_Public_set_Void_Single_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_get_CircleRadius_Public_get_Single_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_set_CircleRadius_Public_set_Void_Single_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc2DLookAndFeel_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_get_QuadBorderType_Public_get_GizmoQuad2DBorderType_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_set_QuadBorderType_Public_set_Void_GizmoQuad2DBorderType_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_get_CircleBorderType_Public_get_GizmoCircle2DBorderType_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_set_CircleBorderType_Public_set_Void_GizmoCircle2DBorderType_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_get_PolygonBorderType_Public_get_GizmoPolygon2DBorderType_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_set_PolygonBorderType_Public_set_Void_GizmoPolygon2DBorderType_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderPolyThickness_Public_get_Single_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderPolyThickness_Public_set_Void_Single_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
