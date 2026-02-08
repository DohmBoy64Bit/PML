using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000091 RID: 145
	public class GizmoPlaneSlider2DControllerData : Object
	{
		// Token: 0x06000B9F RID: 2975 RVA: 0x0004E1B4 File Offset: 0x0004C3B4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPlaneSlider2DControllerData()
		{
			Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPlaneSlider2DControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr);
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "Gizmo");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "Slider");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_SliderHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "SliderHandle");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_QuadBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "QuadBorder");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_CircleBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "CircleBorder");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_PolygonBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "PolygonBorder");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "Quad");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "Circle");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Polygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "Polygon");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_QuadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "QuadIndex");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_CircleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "CircleIndex");
			GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_PolygonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, "PolygonIndex");
			GizmoPlaneSlider2DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr, 100665013);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0004E2E8 File Offset: 0x0004C4E8
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPlaneSlider2DControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPlaneSlider2DControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000061AB File Offset: 0x000043AB
		public GizmoPlaneSlider2DControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0004E324 File Offset: 0x0004C524
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x000061B4 File Offset: 0x000043B4
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0004E354 File Offset: 0x0004C554
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x000061D3 File Offset: 0x000043D3
		public unsafe GizmoPlaneSlider2D Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0004E384 File Offset: 0x0004C584
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x000061F2 File Offset: 0x000043F2
		public unsafe GizmoHandle SliderHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_SliderHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_SliderHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0004E3B4 File Offset: 0x0004C5B4
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00006211 File Offset: 0x00004411
		public unsafe GizmoQuad2DBorder QuadBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_QuadBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad2DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_QuadBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0004E3E4 File Offset: 0x0004C5E4
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x00006230 File Offset: 0x00004430
		public unsafe GizmoCircle2DBorder CircleBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_CircleBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle2DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_CircleBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0004E414 File Offset: 0x0004C614
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0000624F File Offset: 0x0000444F
		public unsafe GizmoPolygon2DBorder PolygonBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_PolygonBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPolygon2DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_PolygonBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0004E444 File Offset: 0x0004C644
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0000626E File Offset: 0x0000446E
		public unsafe QuadShape2D Quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0004E474 File Offset: 0x0004C674
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0000628D File Offset: 0x0000448D
		public unsafe CircleShape2D Circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0004E4A4 File Offset: 0x0004C6A4
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x000062AC File Offset: 0x000044AC
		public unsafe PolygonShape2D Polygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Polygon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_Polygon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0004E4D4 File Offset: 0x0004C6D4
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x000062CB File Offset: 0x000044CB
		public unsafe int QuadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_QuadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_QuadIndex)) = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0004E4FC File Offset: 0x0004C6FC
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x000062E6 File Offset: 0x000044E6
		public unsafe int CircleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_CircleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_CircleIndex)) = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0004E524 File Offset: 0x0004C724
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x00006301 File Offset: 0x00004501
		public unsafe int PolygonIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_PolygonIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2DControllerData.NativeFieldInfoPtr_PolygonIndex)) = value;
			}
		}

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_SliderHandle;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_QuadBorder;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr_CircleBorder;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_PolygonBorder;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_Quad;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_Circle;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_Polygon;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr_QuadIndex;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeFieldInfoPtr_CircleIndex;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeFieldInfoPtr_PolygonIndex;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
