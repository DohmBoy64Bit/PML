using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000CF RID: 207
	public class GizmoRATriangle3DBorderControllerData : Object
	{
		// Token: 0x060010D5 RID: 4309 RVA: 0x000600C0 File Offset: 0x0005E2C0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoRATriangle3DBorderControllerData()
		{
			Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoRATriangle3DBorderControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr);
			GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr, "Gizmo");
			GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_PlaneSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr, "PlaneSlider");
			GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr, "Border");
			GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_TargetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr, "TargetHandle");
			GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_TargetTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr, "TargetTriangle");
			GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_BorderTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr, "BorderTriangle");
			GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_BorderTriangleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr, "BorderTriangleIndex");
			GizmoRATriangle3DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr, 100665595);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00060190 File Offset: 0x0005E390
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoRATriangle3DBorderControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoRATriangle3DBorderControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00008922 File Offset: 0x00006B22
		public GizmoRATriangle3DBorderControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x000601CC File Offset: 0x0005E3CC
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x0000892B File Offset: 0x00006B2B
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x000601FC File Offset: 0x0005E3FC
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x0000894A File Offset: 0x00006B4A
		public unsafe GizmoPlaneSlider3D PlaneSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_PlaneSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_PlaneSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0006022C File Offset: 0x0005E42C
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x00008969 File Offset: 0x00006B69
		public unsafe GizmoRATriangle3DBorder Border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_Border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRATriangle3DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_Border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0006025C File Offset: 0x0005E45C
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x00008988 File Offset: 0x00006B88
		public unsafe GizmoHandle TargetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_TargetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_TargetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x0006028C File Offset: 0x0005E48C
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x000089A7 File Offset: 0x00006BA7
		public unsafe RightAngTriangle3D TargetTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_TargetTriangle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RightAngTriangle3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_TargetTriangle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x000602BC File Offset: 0x0005E4BC
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x000089C6 File Offset: 0x00006BC6
		public unsafe RightAngTriangle3D BorderTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_BorderTriangle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RightAngTriangle3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_BorderTriangle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x000602EC File Offset: 0x0005E4EC
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x000089E5 File Offset: 0x00006BE5
		public unsafe int BorderTriangleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_BorderTriangleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorderControllerData.NativeFieldInfoPtr_BorderTriangleIndex)) = value;
			}
		}

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr_PlaneSlider;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeFieldInfoPtr_Border;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr_TargetHandle;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeFieldInfoPtr_TargetTriangle;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeFieldInfoPtr_BorderTriangle;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeFieldInfoPtr_BorderTriangleIndex;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
