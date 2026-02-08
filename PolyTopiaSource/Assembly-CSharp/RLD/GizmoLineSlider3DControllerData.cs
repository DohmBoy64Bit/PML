using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200009E RID: 158
	public class GizmoLineSlider3DControllerData : Object
	{
		// Token: 0x06000CF0 RID: 3312 RVA: 0x00053228 File Offset: 0x00051428
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider3DControllerData()
		{
			Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider3DControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr);
			GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, "Gizmo");
			GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, "Slider");
			GizmoLineSlider3DControllerData.NativeFieldInfoPtr_SliderHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, "SliderHandle");
			GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Segment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, "Segment");
			GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, "Box");
			GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Cylinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, "Cylinder");
			GizmoLineSlider3DControllerData.NativeFieldInfoPtr_SegmentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, "SegmentIndex");
			GizmoLineSlider3DControllerData.NativeFieldInfoPtr_BoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, "BoxIndex");
			GizmoLineSlider3DControllerData.NativeFieldInfoPtr_CylinderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, "CylinderIndex");
			GizmoLineSlider3DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr, 100665200);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00053320 File Offset: 0x00051520
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider3DControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3DControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00006A05 File Offset: 0x00004C05
		public GizmoLineSlider3DControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0005335C File Offset: 0x0005155C
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00006A0E File Offset: 0x00004C0E
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0005338C File Offset: 0x0005158C
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00006A2D File Offset: 0x00004C2D
		public unsafe GizmoLineSlider3D Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x000533BC File Offset: 0x000515BC
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00006A4C File Offset: 0x00004C4C
		public unsafe GizmoHandle SliderHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_SliderHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_SliderHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000533EC File Offset: 0x000515EC
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00006A6B File Offset: 0x00004C6B
		public unsafe SegmentShape3D Segment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Segment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SegmentShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Segment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0005341C File Offset: 0x0005161C
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00006A8A File Offset: 0x00004C8A
		public unsafe BoxShape3D Box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0005344C File Offset: 0x0005164C
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00006AA9 File Offset: 0x00004CA9
		public unsafe CylinderShape3D Cylinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Cylinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CylinderShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_Cylinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0005347C File Offset: 0x0005167C
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00006AC8 File Offset: 0x00004CC8
		public unsafe int SegmentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_SegmentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_SegmentIndex)) = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000534A4 File Offset: 0x000516A4
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00006AE3 File Offset: 0x00004CE3
		public unsafe int BoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_BoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_BoxIndex)) = value;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x000534CC File Offset: 0x000516CC
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00006AFE File Offset: 0x00004CFE
		public unsafe int CylinderIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_CylinderIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DControllerData.NativeFieldInfoPtr_CylinderIndex)) = value;
			}
		}

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeFieldInfoPtr_SliderHandle;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr_Segment;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr_Box;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_Cylinder;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_SegmentIndex;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_BoxIndex;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr_CylinderIndex;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
