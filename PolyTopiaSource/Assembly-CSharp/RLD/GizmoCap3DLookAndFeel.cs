using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class GizmoCap3DLookAndFeel : global::Il2CppSystem.Object
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00027B54 File Offset: 0x00025D54
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCap3DLookAndFeel()
		{
			Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCap3DLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr);
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__capType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_capType");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__fillMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_fillMode");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__shadeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_shadeMode");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_scale");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__useZoomFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_useZoomFactor");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__coneHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_coneHeight");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__coneRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_coneRadius");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__pyramidHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_pyramidHeight");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__pyramidWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_pyramidWidth");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__pyramidDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_pyramidDepth");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__boxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_boxWidth");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__boxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_boxHeight");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__boxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_boxDepth");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_sphereRadius");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__trPrismWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_trPrismWidth");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__trPrismHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_trPrismHeight");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__trPrismDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_trPrismDepth");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__isSphereBorderVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_isSphereBorderVisible");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__sphereBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_sphereBorderColor");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__numSphereBorderPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_numSphereBorderPoints");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_color");
			GizmoCap3DLookAndFeel.NativeFieldInfoPtr__hoveredColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, "_hoveredColor");
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_CapType_Public_get_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663545);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_CapType_Public_set_Void_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663546);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663547);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663548);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663549);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_ShadeMode_Public_set_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663550);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663551);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663552);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663553);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663554);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_ConeHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663555);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_ConeHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663556);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_ConeRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663557);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_ConeRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663558);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_PyramidHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663559);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_PyramidHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663560);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_PyramidWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663561);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_PyramidWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663562);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_PyramidDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663563);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_PyramidDepth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663564);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_BoxWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663565);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_BoxWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663566);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_BoxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663567);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_BoxHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663568);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_BoxDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663569);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_BoxDepth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663570);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_SphereRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663571);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_SphereRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663572);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_TrPrismWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663573);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_TrPrismWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663574);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_TrPrismHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663575);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_TrPrismHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663576);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_TrPrismDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663577);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_TrPrismDepth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663578);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_IsSphereBorderVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663579);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_IsSphereBorderVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663580);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_SphereBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663581);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_SphereBorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663582);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_NumSphereBorderPoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663583);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_NumSphereBorderPoints_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663584);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663585);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663586);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663587);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663588);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultConeHeight_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663589);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultConeRadius_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663590);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultPyramidHeight_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663591);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultPyramidWidth_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663592);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultPyramidDepth_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663593);
			GizmoCap3DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr, 100663594);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00028124 File Offset: 0x00026324
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00028164 File Offset: 0x00026364
		public unsafe GizmoCap3DType CapType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_CapType_Public_get_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_CapType_Public_set_Void_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000281A8 File Offset: 0x000263A8
		// (set) Token: 0x060001CD RID: 461 RVA: 0x000281E8 File Offset: 0x000263E8
		public unsafe GizmoFillMode3D FillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0002822C File Offset: 0x0002642C
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0002826C File Offset: 0x0002646C
		public unsafe GizmoShadeMode ShadeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_ShadeMode_Public_set_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000282B0 File Offset: 0x000264B0
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x000282EC File Offset: 0x000264EC
		public unsafe float Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 57743, RefRangeEnd = 57779, XrefRangeStart = 57743, XrefRangeEnd = 57743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0002832C File Offset: 0x0002652C
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00028368 File Offset: 0x00026568
		public unsafe bool UseZoomFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000283A8 File Offset: 0x000265A8
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x000283E4 File Offset: 0x000265E4
		public unsafe float ConeHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_ConeHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 57779, RefRangeEnd = 57787, XrefRangeStart = 57779, XrefRangeEnd = 57779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_ConeHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00028424 File Offset: 0x00026624
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00028460 File Offset: 0x00026660
		public unsafe float ConeRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_ConeRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 57787, RefRangeEnd = 57795, XrefRangeStart = 57787, XrefRangeEnd = 57787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_ConeRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000284A0 File Offset: 0x000266A0
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000284DC File Offset: 0x000266DC
		public unsafe float PyramidHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_PyramidHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 57795, RefRangeEnd = 57802, XrefRangeStart = 57795, XrefRangeEnd = 57795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_PyramidHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0002851C File Offset: 0x0002671C
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00028558 File Offset: 0x00026758
		public unsafe float PyramidWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_PyramidWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 57802, RefRangeEnd = 57809, XrefRangeStart = 57802, XrefRangeEnd = 57802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_PyramidWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00028598 File Offset: 0x00026798
		// (set) Token: 0x060001DD RID: 477 RVA: 0x000285D4 File Offset: 0x000267D4
		public unsafe float PyramidDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_PyramidDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 57809, RefRangeEnd = 57816, XrefRangeStart = 57809, XrefRangeEnd = 57809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_PyramidDepth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00028614 File Offset: 0x00026814
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00028650 File Offset: 0x00026850
		public unsafe float BoxWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57816, RefRangeEnd = 57817, XrefRangeStart = 57816, XrefRangeEnd = 57816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_BoxWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 57817, RefRangeEnd = 57831, XrefRangeStart = 57817, XrefRangeEnd = 57817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_BoxWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00028690 File Offset: 0x00026890
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x000286CC File Offset: 0x000268CC
		public unsafe float BoxHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57831, RefRangeEnd = 57832, XrefRangeStart = 57831, XrefRangeEnd = 57831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_BoxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 57832, RefRangeEnd = 57846, XrefRangeStart = 57832, XrefRangeEnd = 57832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_BoxHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0002870C File Offset: 0x0002690C
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00028748 File Offset: 0x00026948
		public unsafe float BoxDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57846, RefRangeEnd = 57847, XrefRangeStart = 57846, XrefRangeEnd = 57846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_BoxDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 57847, RefRangeEnd = 57861, XrefRangeStart = 57847, XrefRangeEnd = 57847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_BoxDepth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00028788 File Offset: 0x00026988
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x000287C4 File Offset: 0x000269C4
		public unsafe float SphereRadius
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57861, RefRangeEnd = 57864, XrefRangeStart = 57861, XrefRangeEnd = 57861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_SphereRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 57864, RefRangeEnd = 57883, XrefRangeStart = 57864, XrefRangeEnd = 57864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_SphereRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00028804 File Offset: 0x00026A04
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00028840 File Offset: 0x00026A40
		public unsafe float TrPrismWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_TrPrismWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 57883, RefRangeEnd = 57890, XrefRangeStart = 57883, XrefRangeEnd = 57883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_TrPrismWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00028880 File Offset: 0x00026A80
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000288BC File Offset: 0x00026ABC
		public unsafe float TrPrismHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_TrPrismHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 57890, RefRangeEnd = 57897, XrefRangeStart = 57890, XrefRangeEnd = 57890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_TrPrismHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000288FC File Offset: 0x00026AFC
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00028938 File Offset: 0x00026B38
		public unsafe float TrPrismDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_TrPrismDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 57897, RefRangeEnd = 57904, XrefRangeStart = 57897, XrefRangeEnd = 57897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_TrPrismDepth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00028978 File Offset: 0x00026B78
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000289B4 File Offset: 0x00026BB4
		public unsafe bool IsSphereBorderVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_IsSphereBorderVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35813, RefRangeEnd = 35814, XrefRangeStart = 35813, XrefRangeEnd = 35814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_IsSphereBorderVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000289F4 File Offset: 0x00026BF4
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00028A34 File Offset: 0x00026C34
		public unsafe Color SphereBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_SphereBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_SphereBorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00028A78 File Offset: 0x00026C78
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00028AB4 File Offset: 0x00026CB4
		public unsafe int NumSphereBorderPoints
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57904, RefRangeEnd = 57905, XrefRangeStart = 57904, XrefRangeEnd = 57904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_NumSphereBorderPoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_NumSphereBorderPoints_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00028AF4 File Offset: 0x00026CF4
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00028B34 File Offset: 0x00026D34
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00028B78 File Offset: 0x00026D78
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00028BB8 File Offset: 0x00026DB8
		public unsafe Color HoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00028BFC File Offset: 0x00026DFC
		public unsafe static float DefaultConeHeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57905, RefRangeEnd = 57908, XrefRangeStart = 57905, XrefRangeEnd = 57905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultConeHeight_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00028C2C File Offset: 0x00026E2C
		public unsafe static float DefaultConeRadius
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57908, RefRangeEnd = 57910, XrefRangeStart = 57908, XrefRangeEnd = 57908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultConeRadius_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00028C5C File Offset: 0x00026E5C
		public unsafe static float DefaultPyramidHeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57905, RefRangeEnd = 57908, XrefRangeStart = 57905, XrefRangeEnd = 57908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultPyramidHeight_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00028C8C File Offset: 0x00026E8C
		public unsafe static float DefaultPyramidWidth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57910, RefRangeEnd = 57912, XrefRangeStart = 57910, XrefRangeEnd = 57910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultPyramidWidth_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00028CBC File Offset: 0x00026EBC
		public unsafe static float DefaultPyramidDepth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57910, RefRangeEnd = 57912, XrefRangeStart = 57910, XrefRangeEnd = 57912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr_get_DefaultPyramidDepth_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00028CEC File Offset: 0x00026EEC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 57915, RefRangeEnd = 57924, XrefRangeStart = 57912, XrefRangeEnd = 57915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCap3DLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap3DLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002B80 File Offset: 0x00000D80
		public GizmoCap3DLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00028D28 File Offset: 0x00026F28
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002B89 File Offset: 0x00000D89
		public unsafe GizmoCap3DType _capType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__capType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3DType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__capType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00028D58 File Offset: 0x00026F58
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002BA8 File Offset: 0x00000DA8
		public unsafe GizmoFillMode3D _fillMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__fillMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__fillMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00028D88 File Offset: 0x00026F88
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002BC7 File Offset: 0x00000DC7
		public unsafe GizmoShadeMode _shadeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__shadeMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__shadeMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00028DB8 File Offset: 0x00026FB8
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002BE6 File Offset: 0x00000DE6
		public unsafe float _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__scale)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00028DE0 File Offset: 0x00026FE0
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002C01 File Offset: 0x00000E01
		public unsafe bool _useZoomFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__useZoomFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__useZoomFactor)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00028E08 File Offset: 0x00027008
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002C1C File Offset: 0x00000E1C
		public unsafe float _coneHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__coneHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__coneHeight)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00028E30 File Offset: 0x00027030
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002C37 File Offset: 0x00000E37
		public unsafe float _coneRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__coneRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__coneRadius)) = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00028E58 File Offset: 0x00027058
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002C52 File Offset: 0x00000E52
		public unsafe float _pyramidHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__pyramidHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__pyramidHeight)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00028E80 File Offset: 0x00027080
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002C6D File Offset: 0x00000E6D
		public unsafe float _pyramidWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__pyramidWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__pyramidWidth)) = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00028EA8 File Offset: 0x000270A8
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002C88 File Offset: 0x00000E88
		public unsafe float _pyramidDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__pyramidDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__pyramidDepth)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00028ED0 File Offset: 0x000270D0
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002CA3 File Offset: 0x00000EA3
		public unsafe float _boxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__boxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__boxWidth)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00028EF8 File Offset: 0x000270F8
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002CBE File Offset: 0x00000EBE
		public unsafe float _boxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__boxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__boxHeight)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00028F20 File Offset: 0x00027120
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002CD9 File Offset: 0x00000ED9
		public unsafe float _boxDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__boxDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__boxDepth)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00028F48 File Offset: 0x00027148
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public unsafe float _sphereRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__sphereRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__sphereRadius)) = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00028F70 File Offset: 0x00027170
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002D0F File Offset: 0x00000F0F
		public unsafe float _trPrismWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__trPrismWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__trPrismWidth)) = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00028F98 File Offset: 0x00027198
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002D2A File Offset: 0x00000F2A
		public unsafe float _trPrismHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__trPrismHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__trPrismHeight)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00028FC0 File Offset: 0x000271C0
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002D45 File Offset: 0x00000F45
		public unsafe float _trPrismDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__trPrismDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__trPrismDepth)) = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00028FE8 File Offset: 0x000271E8
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002D60 File Offset: 0x00000F60
		public unsafe bool _isSphereBorderVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__isSphereBorderVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__isSphereBorderVisible)) = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00029010 File Offset: 0x00027210
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002D7B File Offset: 0x00000F7B
		public unsafe Color _sphereBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__sphereBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__sphereBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00029040 File Offset: 0x00027240
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002D9A File Offset: 0x00000F9A
		public unsafe int _numSphereBorderPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__numSphereBorderPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__numSphereBorderPoints)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00029068 File Offset: 0x00027268
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002DB5 File Offset: 0x00000FB5
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00029098 File Offset: 0x00027298
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002DD4 File Offset: 0x00000FD4
		public unsafe Color _hoveredColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__hoveredColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DLookAndFeel.NativeFieldInfoPtr__hoveredColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr__capType;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr__fillMode;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr__shadeMode;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr__useZoomFactor;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr__coneHeight;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr__coneRadius;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr__pyramidHeight;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr__pyramidWidth;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr__pyramidDepth;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr__boxWidth;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr__boxHeight;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr__boxDepth;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr__sphereRadius;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr__trPrismWidth;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr__trPrismHeight;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr__trPrismDepth;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr__isSphereBorderVisible;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr__sphereBorderColor;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr__numSphereBorderPoints;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr__hoveredColor;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_CapType_Public_get_GizmoCap3DType_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_set_CapType_Public_set_Void_GizmoCap3DType_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode3D_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_set_ShadeMode_Public_set_Void_GizmoShadeMode_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_get_ConeHeight_Public_get_Single_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_set_ConeHeight_Public_set_Void_Single_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_get_ConeRadius_Public_get_Single_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_set_ConeRadius_Public_set_Void_Single_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_PyramidHeight_Public_get_Single_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_set_PyramidHeight_Public_set_Void_Single_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_PyramidWidth_Public_get_Single_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_set_PyramidWidth_Public_set_Void_Single_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_PyramidDepth_Public_get_Single_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_set_PyramidDepth_Public_set_Void_Single_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxWidth_Public_get_Single_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_set_BoxWidth_Public_set_Void_Single_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxHeight_Public_get_Single_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_set_BoxHeight_Public_set_Void_Single_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxDepth_Public_get_Single_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_set_BoxDepth_Public_set_Void_Single_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_get_SphereRadius_Public_get_Single_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_set_SphereRadius_Public_set_Void_Single_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_get_TrPrismWidth_Public_get_Single_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_set_TrPrismWidth_Public_set_Void_Single_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_get_TrPrismHeight_Public_get_Single_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_set_TrPrismHeight_Public_set_Void_Single_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_get_TrPrismDepth_Public_get_Single_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_set_TrPrismDepth_Public_set_Void_Single_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSphereBorderVisible_Public_get_Boolean_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSphereBorderVisible_Public_set_Void_Boolean_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_get_SphereBorderColor_Public_get_Color_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_set_SphereBorderColor_Public_set_Void_Color_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_get_NumSphereBorderPoints_Public_get_Int32_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_set_NumSphereBorderPoints_Public_set_Void_Int32_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultConeHeight_Public_Static_get_Single_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultConeRadius_Public_Static_get_Single_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPyramidHeight_Public_Static_get_Single_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPyramidWidth_Public_Static_get_Single_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPyramidDepth_Public_Static_get_Single_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
