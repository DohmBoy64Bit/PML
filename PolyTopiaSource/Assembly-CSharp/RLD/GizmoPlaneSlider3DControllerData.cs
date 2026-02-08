using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000A8 RID: 168
	public class GizmoPlaneSlider3DControllerData : Object
	{
		// Token: 0x06000E15 RID: 3605 RVA: 0x00057798 File Offset: 0x00055998
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPlaneSlider3DControllerData()
		{
			Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPlaneSlider3DControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr);
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "Gizmo");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "Slider");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_SliderHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "SliderHandle");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_QuadBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "QuadBorder");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "Quad");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_RATriangleBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "RATriangleBorder");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_RATriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "RATriangle");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_CircleBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "CircleBorder");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "Circle");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_QuadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "QuadIndex");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_RATriangleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "RATriangleIndex");
			GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_CircleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, "CircleIndex");
			GizmoPlaneSlider3DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr, 100665353);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000578CC File Offset: 0x00055ACC
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPlaneSlider3DControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPlaneSlider3DControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00007170 File Offset: 0x00005370
		public GizmoPlaneSlider3DControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00057908 File Offset: 0x00055B08
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00007179 File Offset: 0x00005379
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00057938 File Offset: 0x00055B38
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00007198 File Offset: 0x00005398
		public unsafe GizmoPlaneSlider3D Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00057968 File Offset: 0x00055B68
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x000071B7 File Offset: 0x000053B7
		public unsafe GizmoHandle SliderHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_SliderHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_SliderHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00057998 File Offset: 0x00055B98
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x000071D6 File Offset: 0x000053D6
		public unsafe GizmoQuad3DBorder QuadBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_QuadBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad3DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_QuadBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x000579C8 File Offset: 0x00055BC8
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x000071F5 File Offset: 0x000053F5
		public unsafe QuadShape3D Quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000579F8 File Offset: 0x00055BF8
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00007214 File Offset: 0x00005414
		public unsafe GizmoRATriangle3DBorder RATriangleBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_RATriangleBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRATriangle3DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_RATriangleBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x00057A28 File Offset: 0x00055C28
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00007233 File Offset: 0x00005433
		public unsafe RightAngTriangle3D RATriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_RATriangle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RightAngTriangle3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_RATriangle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00057A58 File Offset: 0x00055C58
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00007252 File Offset: 0x00005452
		public unsafe GizmoCircle3DBorder CircleBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_CircleBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle3DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_CircleBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00057A88 File Offset: 0x00055C88
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00007271 File Offset: 0x00005471
		public unsafe CircleShape3D Circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_Circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00057AB8 File Offset: 0x00055CB8
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00007290 File Offset: 0x00005490
		public unsafe int QuadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_QuadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_QuadIndex)) = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00057AE0 File Offset: 0x00055CE0
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x000072AB File Offset: 0x000054AB
		public unsafe int RATriangleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_RATriangleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_RATriangleIndex)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00057B08 File Offset: 0x00055D08
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x000072C6 File Offset: 0x000054C6
		public unsafe int CircleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_CircleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DControllerData.NativeFieldInfoPtr_CircleIndex)) = value;
			}
		}

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeFieldInfoPtr_SliderHandle;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeFieldInfoPtr_QuadBorder;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeFieldInfoPtr_Quad;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeFieldInfoPtr_RATriangleBorder;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeFieldInfoPtr_RATriangle;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeFieldInfoPtr_CircleBorder;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeFieldInfoPtr_Circle;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeFieldInfoPtr_QuadIndex;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeFieldInfoPtr_RATriangleIndex;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeFieldInfoPtr_CircleIndex;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
