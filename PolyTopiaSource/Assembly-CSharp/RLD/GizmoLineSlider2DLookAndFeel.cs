using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000089 RID: 137
	[Serializable]
	public class GizmoLineSlider2DLookAndFeel : global::Il2CppSystem.Object
	{
		// Token: 0x06000AB0 RID: 2736 RVA: 0x0004AAC0 File Offset: 0x00048CC0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider2DLookAndFeel()
		{
			Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider2DLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr);
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__lineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_lineType");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__fillMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_fillMode");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_length");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_scale");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__boxThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_boxThickness");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_isRotationArcVisible");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_color");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_hoveredColor");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__borderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_borderColor");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_hoveredBorderColor");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_rotationArcLookAndFeel");
			GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__capLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, "_capLookAndFeel");
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_LineType_Public_get_GizmoLine2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664892);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_LineType_Public_set_Void_GizmoLine2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664893);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664894);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664895);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_Length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664896);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664897);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664898);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664899);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_CapLookAndFeel_Public_get_GizmoCap2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664900);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_BoxThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664901);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_BoxThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664902);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664903);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664904);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664905);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664906);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664907);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664908);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664909);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664910);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664911);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664912);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664913);
			GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr, 100664914);
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0004ADAC File Offset: 0x00048FAC
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0004ADEC File Offset: 0x00048FEC
		public unsafe GizmoLine2DType LineType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_LineType_Public_get_GizmoLine2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLine2DType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_LineType_Public_set_Void_GizmoLine2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0004AE30 File Offset: 0x00049030
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0004AE70 File Offset: 0x00049070
		public unsafe GizmoFillMode2D FillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0004AEB4 File Offset: 0x000490B4
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0004AEF0 File Offset: 0x000490F0
		public unsafe float Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_Length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0004AF30 File Offset: 0x00049130
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0004AF6C File Offset: 0x0004916C
		public unsafe float Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0004AFAC File Offset: 0x000491AC
		public unsafe GizmoCap2DLookAndFeel CapLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_CapLookAndFeel_Public_get_GizmoCap2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0004AFEC File Offset: 0x000491EC
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0004B028 File Offset: 0x00049228
		public unsafe float BoxThickness
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_BoxThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_BoxThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0004B068 File Offset: 0x00049268
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x0004B0A4 File Offset: 0x000492A4
		public unsafe bool IsRotationArcVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0004B0E4 File Offset: 0x000492E4
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0004B124 File Offset: 0x00049324
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 58119, RefRangeEnd = 58122, XrefRangeStart = 58119, XrefRangeEnd = 58122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0004B168 File Offset: 0x00049368
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x0004B1A8 File Offset: 0x000493A8
		public unsafe Color HoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0004B1EC File Offset: 0x000493EC
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x0004B22C File Offset: 0x0004942C
		public unsafe Color BorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0004B270 File Offset: 0x00049470
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x0004B2B0 File Offset: 0x000494B0
		public unsafe Color HoveredBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0004B2F4 File Offset: 0x000494F4
		public unsafe GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc2DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0004B334 File Offset: 0x00049534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65755, RefRangeEnd = 65757, XrefRangeStart = 65742, XrefRangeEnd = 65755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider2DLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider2DLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00005B6C File Offset: 0x00003D6C
		public GizmoLineSlider2DLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0004B370 File Offset: 0x00049570
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00005B75 File Offset: 0x00003D75
		public unsafe GizmoLine2DType _lineType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__lineType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLine2DType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__lineType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0004B3A0 File Offset: 0x000495A0
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00005B94 File Offset: 0x00003D94
		public unsafe GizmoFillMode2D _fillMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__fillMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__fillMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0004B3D0 File Offset: 0x000495D0
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00005BB3 File Offset: 0x00003DB3
		public unsafe float _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0004B3F8 File Offset: 0x000495F8
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00005BCE File Offset: 0x00003DCE
		public unsafe float _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__scale)) = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0004B420 File Offset: 0x00049620
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00005BE9 File Offset: 0x00003DE9
		public unsafe float _boxThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__boxThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__boxThickness)) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0004B448 File Offset: 0x00049648
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00005C04 File Offset: 0x00003E04
		public unsafe bool _isRotationArcVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__isRotationArcVisible)) = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0004B470 File Offset: 0x00049670
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00005C1F File Offset: 0x00003E1F
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0004B4A0 File Offset: 0x000496A0
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00005C3E File Offset: 0x00003E3E
		public unsafe Color _hoveredColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0004B4D0 File Offset: 0x000496D0
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00005C5D File Offset: 0x00003E5D
		public unsafe Color _borderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__borderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__borderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0004B500 File Offset: 0x00049700
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00005C7C File Offset: 0x00003E7C
		public unsafe Color _hoveredBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0004B530 File Offset: 0x00049730
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00005C9B File Offset: 0x00003E9B
		public unsafe GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__rotationArcLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0004B560 File Offset: 0x00049760
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00005CBA File Offset: 0x00003EBA
		public unsafe GizmoCap2DLookAndFeel _capLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__capLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DLookAndFeel.NativeFieldInfoPtr__capLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeFieldInfoPtr__lineType;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeFieldInfoPtr__fillMode;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeFieldInfoPtr__boxThickness;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeFieldInfoPtr__isRotationArcVisible;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr__hoveredColor;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr__borderColor;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr__hoveredBorderColor;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr__rotationArcLookAndFeel;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr__capLookAndFeel;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_get_LineType_Public_get_GizmoLine2DType_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_set_LineType_Public_set_Void_GizmoLine2DType_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode2D_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Single_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_get_CapLookAndFeel_Public_get_GizmoCap2DLookAndFeel_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxThickness_Public_get_Single_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_set_BoxThickness_Public_set_Void_Single_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotationArcVisible_Public_get_Boolean_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRotationArcVisible_Public_set_Void_Boolean_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationArcLookAndFeel_Public_get_GizmoRotationArc2DLookAndFeel_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
