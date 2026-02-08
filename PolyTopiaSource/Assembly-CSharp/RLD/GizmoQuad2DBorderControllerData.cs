using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000BD RID: 189
	public class GizmoQuad2DBorderControllerData : Object
	{
		// Token: 0x06000FA4 RID: 4004 RVA: 0x0005C824 File Offset: 0x0005AA24
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoQuad2DBorderControllerData()
		{
			Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoQuad2DBorderControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr);
			GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr, "Gizmo");
			GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_PlaneSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr, "PlaneSlider");
			GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr, "Border");
			GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_TargetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr, "TargetHandle");
			GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_TargetQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr, "TargetQuad");
			GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_BorderQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr, "BorderQuad");
			GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_BorderQuadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr, "BorderQuadIndex");
			GizmoQuad2DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr, 100665508);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0005C8F4 File Offset: 0x0005AAF4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoQuad2DBorderControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoQuad2DBorderControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad2DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00007DDC File Offset: 0x00005FDC
		public GizmoQuad2DBorderControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x0005C930 File Offset: 0x0005AB30
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x00007DE5 File Offset: 0x00005FE5
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0005C960 File Offset: 0x0005AB60
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00007E04 File Offset: 0x00006004
		public unsafe GizmoPlaneSlider2D PlaneSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_PlaneSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_PlaneSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x0005C990 File Offset: 0x0005AB90
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00007E23 File Offset: 0x00006023
		public unsafe GizmoQuad2DBorder Border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_Border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad2DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_Border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0005C9C0 File Offset: 0x0005ABC0
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x00007E42 File Offset: 0x00006042
		public unsafe GizmoHandle TargetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_TargetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_TargetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x0005C9F0 File Offset: 0x0005ABF0
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00007E61 File Offset: 0x00006061
		public unsafe QuadShape2D TargetQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_TargetQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_TargetQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0005CA20 File Offset: 0x0005AC20
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x00007E80 File Offset: 0x00006080
		public unsafe QuadShape2D BorderQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_BorderQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_BorderQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0005CA50 File Offset: 0x0005AC50
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00007E9F File Offset: 0x0000609F
		public unsafe int BorderQuadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_BorderQuadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorderControllerData.NativeFieldInfoPtr_BorderQuadIndex)) = value;
			}
		}

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeFieldInfoPtr_PlaneSlider;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeFieldInfoPtr_Border;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeFieldInfoPtr_TargetHandle;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeFieldInfoPtr_TargetQuad;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeFieldInfoPtr_BorderQuad;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeFieldInfoPtr_BorderQuadIndex;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
