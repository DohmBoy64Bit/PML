using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000C2 RID: 194
	public class GizmoCircle3DBorderControllerData : Object
	{
		// Token: 0x06000FF1 RID: 4081 RVA: 0x0005D70C File Offset: 0x0005B90C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCircle3DBorderControllerData()
		{
			Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCircle3DBorderControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr);
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "Gizmo");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_PlaneSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "PlaneSlider");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "Border");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_TargetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "TargetHandle");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_TargetCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "TargetCircle");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "BorderCircle");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderTorus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "BorderTorus");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCylTorus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "BorderCylTorus");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCircleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "BorderCircleIndex");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderTorusIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "BorderTorusIndex");
			GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCylTorusIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, "BorderCylTorusIndex");
			GizmoCircle3DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr, 100665533);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0005D82C File Offset: 0x0005BA2C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCircle3DBorderControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCircle3DBorderControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0000807C File Offset: 0x0000627C
		public GizmoCircle3DBorderControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0005D868 File Offset: 0x0005BA68
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00008085 File Offset: 0x00006285
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0005D898 File Offset: 0x0005BA98
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x000080A4 File Offset: 0x000062A4
		public unsafe GizmoPlaneSlider3D PlaneSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_PlaneSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_PlaneSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0005D8C8 File Offset: 0x0005BAC8
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x000080C3 File Offset: 0x000062C3
		public unsafe GizmoCircle3DBorder Border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_Border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle3DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_Border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0005D8F8 File Offset: 0x0005BAF8
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x000080E2 File Offset: 0x000062E2
		public unsafe GizmoHandle TargetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_TargetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_TargetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0005D928 File Offset: 0x0005BB28
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x00008101 File Offset: 0x00006301
		public unsafe CircleShape3D TargetCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_TargetCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_TargetCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0005D958 File Offset: 0x0005BB58
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00008120 File Offset: 0x00006320
		public unsafe CircleShape3D BorderCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0005D988 File Offset: 0x0005BB88
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x0000813F File Offset: 0x0000633F
		public unsafe TorusShape3D BorderTorus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderTorus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TorusShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderTorus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x0005D9B8 File Offset: 0x0005BBB8
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x0000815E File Offset: 0x0000635E
		public unsafe CylTorusShape3D BorderCylTorus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCylTorus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CylTorusShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCylTorus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x0005D9E8 File Offset: 0x0005BBE8
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x0000817D File Offset: 0x0000637D
		public unsafe int BorderCircleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCircleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCircleIndex)) = value;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x0005DA10 File Offset: 0x0005BC10
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x00008198 File Offset: 0x00006398
		public unsafe int BorderTorusIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderTorusIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderTorusIndex)) = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x0005DA38 File Offset: 0x0005BC38
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x000081B3 File Offset: 0x000063B3
		public unsafe int BorderCylTorusIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCylTorusIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorderControllerData.NativeFieldInfoPtr_BorderCylTorusIndex)) = value;
			}
		}

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeFieldInfoPtr_PlaneSlider;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeFieldInfoPtr_Border;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeFieldInfoPtr_TargetHandle;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeFieldInfoPtr_TargetCircle;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeFieldInfoPtr_BorderCircle;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeFieldInfoPtr_BorderTorus;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeFieldInfoPtr_BorderCylTorus;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr_BorderCircleIndex;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr_BorderTorusIndex;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr_BorderCylTorusIndex;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
