using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000B7 RID: 183
	public class GizmoPolygon2DBorderControllerData : Object
	{
		// Token: 0x06000F5A RID: 3930 RVA: 0x0005BA34 File Offset: 0x00059C34
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPolygon2DBorderControllerData()
		{
			Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPolygon2DBorderControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr);
			GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, "Gizmo");
			GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_PlaneSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, "PlaneSlider");
			GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, "Border");
			GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_TargetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, "TargetHandle");
			GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_TargetPolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, "TargetPolygon");
			GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_BorderPolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, "BorderPolygon");
			GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_ThickBorderPolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, "ThickBorderPolygon");
			GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_BorderPolygonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, "BorderPolygonIndex");
			GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_ThickBorderPolygonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, "ThickBorderPolygonIndex");
			GizmoPolygon2DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr, 100665484);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0005BB2C File Offset: 0x00059D2C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPolygon2DBorderControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPolygon2DBorderControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00007B6D File Offset: 0x00005D6D
		public GizmoPolygon2DBorderControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0005BB68 File Offset: 0x00059D68
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x00007B76 File Offset: 0x00005D76
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0005BB98 File Offset: 0x00059D98
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x00007B95 File Offset: 0x00005D95
		public unsafe GizmoPlaneSlider2D PlaneSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_PlaneSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_PlaneSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0005BBC8 File Offset: 0x00059DC8
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x00007BB4 File Offset: 0x00005DB4
		public unsafe GizmoPolygon2DBorder Border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_Border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPolygon2DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_Border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0005BBF8 File Offset: 0x00059DF8
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00007BD3 File Offset: 0x00005DD3
		public unsafe GizmoHandle TargetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_TargetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_TargetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x0005BC28 File Offset: 0x00059E28
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00007BF2 File Offset: 0x00005DF2
		public unsafe PolygonShape2D TargetPolygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_TargetPolygon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_TargetPolygon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x0005BC58 File Offset: 0x00059E58
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00007C11 File Offset: 0x00005E11
		public unsafe PolygonShape2D BorderPolygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_BorderPolygon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_BorderPolygon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x0005BC88 File Offset: 0x00059E88
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x00007C30 File Offset: 0x00005E30
		public unsafe PolygonShape2D ThickBorderPolygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_ThickBorderPolygon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_ThickBorderPolygon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x0005BCB8 File Offset: 0x00059EB8
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x00007C4F File Offset: 0x00005E4F
		public unsafe int BorderPolygonIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_BorderPolygonIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_BorderPolygonIndex)) = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0005BCE0 File Offset: 0x00059EE0
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x00007C6A File Offset: 0x00005E6A
		public unsafe int ThickBorderPolygonIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_ThickBorderPolygonIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorderControllerData.NativeFieldInfoPtr_ThickBorderPolygonIndex)) = value;
			}
		}

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeFieldInfoPtr_PlaneSlider;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeFieldInfoPtr_Border;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeFieldInfoPtr_TargetHandle;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeFieldInfoPtr_TargetPolygon;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeFieldInfoPtr_BorderPolygon;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeFieldInfoPtr_ThickBorderPolygon;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeFieldInfoPtr_BorderPolygonIndex;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeFieldInfoPtr_ThickBorderPolygonIndex;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
