using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000088 RID: 136
	public class GizmoLineSlider2DControllerData : Object
	{
		// Token: 0x06000A9F RID: 2719 RVA: 0x0004A874 File Offset: 0x00048A74
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider2DControllerData()
		{
			Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider2DControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr);
			GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr, "Gizmo");
			GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr, "Slider");
			GizmoLineSlider2DControllerData.NativeFieldInfoPtr_SliderHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr, "SliderHandle");
			GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Segment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr, "Segment");
			GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr, "Quad");
			GizmoLineSlider2DControllerData.NativeFieldInfoPtr_SegmentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr, "SegmentIndex");
			GizmoLineSlider2DControllerData.NativeFieldInfoPtr_QuadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr, "QuadIndex");
			GizmoLineSlider2DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr, 100664891);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0004A944 File Offset: 0x00048B44
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider2DControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider2DControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00005A92 File Offset: 0x00003C92
		public GizmoLineSlider2DControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0004A980 File Offset: 0x00048B80
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00005A9B File Offset: 0x00003C9B
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0004A9B0 File Offset: 0x00048BB0
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00005ABA File Offset: 0x00003CBA
		public unsafe GizmoLineSlider2D Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0004A9E0 File Offset: 0x00048BE0
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00005AD9 File Offset: 0x00003CD9
		public unsafe GizmoHandle SliderHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_SliderHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_SliderHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0004AA10 File Offset: 0x00048C10
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public unsafe SegmentShape2D Segment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Segment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SegmentShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Segment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0004AA40 File Offset: 0x00048C40
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00005B17 File Offset: 0x00003D17
		public unsafe QuadShape2D Quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_Quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0004AA70 File Offset: 0x00048C70
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00005B36 File Offset: 0x00003D36
		public unsafe int SegmentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_SegmentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_SegmentIndex)) = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0004AA98 File Offset: 0x00048C98
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00005B51 File Offset: 0x00003D51
		public unsafe int QuadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_QuadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DControllerData.NativeFieldInfoPtr_QuadIndex)) = value;
			}
		}

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeFieldInfoPtr_SliderHandle;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeFieldInfoPtr_Segment;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeFieldInfoPtr_Quad;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeFieldInfoPtr_SegmentIndex;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeFieldInfoPtr_QuadIndex;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
