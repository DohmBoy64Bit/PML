using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200009F RID: 159
	[Serializable]
	public class GizmoLineSlider3DLookAndFeel : global::Il2CppSystem.Object
	{
		// Token: 0x06000D05 RID: 3333 RVA: 0x000534F4 File Offset: 0x000516F4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider3DLookAndFeel()
		{
			Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider3DLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr);
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__shadeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_shadeMode");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__lineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_lineType");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__fillMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_fillMode");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_length");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_scale");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__useZoomFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_useZoomFactor");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__boxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_boxHeight");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__boxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_boxDepth");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__cylinderRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_cylinderRadius");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_isRotationArcVisible");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_rotationArcLookAndFeel");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_color");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__hoveredColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_hoveredColor");
			GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__capLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, "_capLookAndFeel");
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665201);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_ShadeMode_Public_set_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665202);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_LineType_Public_get_GizmoLine3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665203);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_LineType_Public_set_Void_GizmoLine3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665204);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665205);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665206);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_Length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665207);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665208);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665209);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665210);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665211);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665212);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665213);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665214);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665215);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_CapLookAndFeel_Public_get_GizmoCap3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665216);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_BoxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665217);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_BoxHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665218);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_BoxDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665219);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_BoxDepth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665220);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_CylinderRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665221);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_CylinderRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665222);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665223);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665224);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665225);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665226);
			GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr, 100665227);
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00053858 File Offset: 0x00051A58
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00053898 File Offset: 0x00051A98
		public unsafe GizmoShadeMode ShadeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_ShadeMode_Public_set_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x000538DC File Offset: 0x00051ADC
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x0005391C File Offset: 0x00051B1C
		public unsafe GizmoLine3DType LineType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_LineType_Public_get_GizmoLine3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLine3DType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_LineType_Public_set_Void_GizmoLine3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00053960 File Offset: 0x00051B60
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x000539A0 File Offset: 0x00051BA0
		public unsafe GizmoFillMode3D FillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x000539E4 File Offset: 0x00051BE4
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00053A20 File Offset: 0x00051C20
		public unsafe float Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_Length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x00053A60 File Offset: 0x00051C60
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00053A9C File Offset: 0x00051C9C
		public unsafe float Scale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00053ADC File Offset: 0x00051CDC
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00053B18 File Offset: 0x00051D18
		public unsafe bool UseZoomFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x00053B58 File Offset: 0x00051D58
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00053B94 File Offset: 0x00051D94
		public unsafe bool IsRotationArcVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00053BD4 File Offset: 0x00051DD4
		public unsafe GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc3DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00053C14 File Offset: 0x00051E14
		public unsafe GizmoCap3DLookAndFeel CapLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_CapLookAndFeel_Public_get_GizmoCap3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00053C54 File Offset: 0x00051E54
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x00053C90 File Offset: 0x00051E90
		public unsafe float BoxHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_BoxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_BoxHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00053CD0 File Offset: 0x00051ED0
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00053D0C File Offset: 0x00051F0C
		public unsafe float BoxDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_BoxDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_BoxDepth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00053D4C File Offset: 0x00051F4C
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00053D88 File Offset: 0x00051F88
		public unsafe float CylinderRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_CylinderRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 67305, RefRangeEnd = 67314, XrefRangeStart = 67305, XrefRangeEnd = 67305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_CylinderRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00053DC8 File Offset: 0x00051FC8
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x00053E08 File Offset: 0x00052008
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00053E4C File Offset: 0x0005204C
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00053E8C File Offset: 0x0005208C
		public unsafe Color HoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00053ED0 File Offset: 0x000520D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 67327, RefRangeEnd = 67332, XrefRangeStart = 67314, XrefRangeEnd = 67327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider3DLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3DLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00006B19 File Offset: 0x00004D19
		public GizmoLineSlider3DLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00053F0C File Offset: 0x0005210C
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x00006B22 File Offset: 0x00004D22
		public unsafe GizmoShadeMode _shadeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__shadeMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__shadeMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00053F3C File Offset: 0x0005213C
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00006B41 File Offset: 0x00004D41
		public unsafe GizmoLine3DType _lineType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__lineType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLine3DType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__lineType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00053F6C File Offset: 0x0005216C
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00006B60 File Offset: 0x00004D60
		public unsafe GizmoFillMode3D _fillMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__fillMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__fillMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x00053F9C File Offset: 0x0005219C
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00006B7F File Offset: 0x00004D7F
		public unsafe float _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00053FC4 File Offset: 0x000521C4
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x00006B9A File Offset: 0x00004D9A
		public unsafe float _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__scale)) = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00053FEC File Offset: 0x000521EC
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x00006BB5 File Offset: 0x00004DB5
		public unsafe bool _useZoomFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__useZoomFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__useZoomFactor)) = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00054014 File Offset: 0x00052214
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x00006BD0 File Offset: 0x00004DD0
		public unsafe float _boxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__boxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__boxHeight)) = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0005403C File Offset: 0x0005223C
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x00006BEB File Offset: 0x00004DEB
		public unsafe float _boxDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__boxDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__boxDepth)) = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00054064 File Offset: 0x00052264
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00006C06 File Offset: 0x00004E06
		public unsafe float _cylinderRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__cylinderRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__cylinderRadius)) = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0005408C File Offset: 0x0005228C
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00006C21 File Offset: 0x00004E21
		public unsafe bool _isRotationArcVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible)) = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x000540B4 File Offset: 0x000522B4
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00006C3C File Offset: 0x00004E3C
		public unsafe GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x000540E4 File Offset: 0x000522E4
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x00006C5B File Offset: 0x00004E5B
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00054114 File Offset: 0x00052314
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00006C7A File Offset: 0x00004E7A
		public unsafe Color _hoveredColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__hoveredColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__hoveredColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00054144 File Offset: 0x00052344
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x00006C99 File Offset: 0x00004E99
		public unsafe GizmoCap3DLookAndFeel _capLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__capLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DLookAndFeel.NativeFieldInfoPtr__capLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeFieldInfoPtr__shadeMode;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeFieldInfoPtr__lineType;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeFieldInfoPtr__fillMode;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeFieldInfoPtr__useZoomFactor;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeFieldInfoPtr__boxHeight;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeFieldInfoPtr__boxDepth;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr__cylinderRadius;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr__isRotationArcVisible;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr__rotationArcLookAndFeel;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr__hoveredColor;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr__capLookAndFeel;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_get_ShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_set_ShadeMode_Public_set_Void_GizmoShadeMode_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_get_LineType_Public_get_GizmoLine3DType_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_set_LineType_Public_set_Void_GizmoLine3DType_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode3D_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Single_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc3DLookAndFeel_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_get_CapLookAndFeel_Public_get_GizmoCap3DLookAndFeel_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxHeight_Public_get_Single_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_set_BoxHeight_Public_set_Void_Single_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxDepth_Public_get_Single_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_set_BoxDepth_Public_set_Void_Single_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_get_CylinderRadius_Public_get_Single_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_set_CylinderRadius_Public_set_Void_Single_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
