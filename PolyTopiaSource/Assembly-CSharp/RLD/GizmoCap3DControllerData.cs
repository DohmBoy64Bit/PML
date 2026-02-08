using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200001A RID: 26
	public class GizmoCap3DControllerData : Object
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00027788 File Offset: 0x00025988
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCap3DControllerData()
		{
			Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCap3DControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr);
			GizmoCap3DControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "Gizmo");
			GizmoCap3DControllerData.NativeFieldInfoPtr_Cap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "Cap");
			GizmoCap3DControllerData.NativeFieldInfoPtr_CapHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "CapHandle");
			GizmoCap3DControllerData.NativeFieldInfoPtr_Cone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "Cone");
			GizmoCap3DControllerData.NativeFieldInfoPtr_Pyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "Pyramid");
			GizmoCap3DControllerData.NativeFieldInfoPtr_Box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "Box");
			GizmoCap3DControllerData.NativeFieldInfoPtr_Sphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "Sphere");
			GizmoCap3DControllerData.NativeFieldInfoPtr_TrPrism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "TrPrism");
			GizmoCap3DControllerData.NativeFieldInfoPtr_ConeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "ConeIndex");
			GizmoCap3DControllerData.NativeFieldInfoPtr_PyramidIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "PyramidIndex");
			GizmoCap3DControllerData.NativeFieldInfoPtr_BoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "BoxIndex");
			GizmoCap3DControllerData.NativeFieldInfoPtr_SphereIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "SphereIndex");
			GizmoCap3DControllerData.NativeFieldInfoPtr_TrPrismIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, "TrPrismIndex");
			GizmoCap3DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr, 100663544);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000278D0 File Offset: 0x00025AD0
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCap3DControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap3DControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000029F8 File Offset: 0x00000BF8
		public GizmoCap3DControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0002790C File Offset: 0x00025B0C
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002A01 File Offset: 0x00000C01
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0002793C File Offset: 0x00025B3C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002A20 File Offset: 0x00000C20
		public unsafe GizmoCap3D Cap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Cap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Cap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0002796C File Offset: 0x00025B6C
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002A3F File Offset: 0x00000C3F
		public unsafe GizmoHandle CapHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_CapHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_CapHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0002799C File Offset: 0x00025B9C
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002A5E File Offset: 0x00000C5E
		public unsafe ConeShape3D Cone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Cone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConeShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Cone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000279CC File Offset: 0x00025BCC
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002A7D File Offset: 0x00000C7D
		public unsafe PyramidShape3D Pyramid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Pyramid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PyramidShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Pyramid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000279FC File Offset: 0x00025BFC
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002A9C File Offset: 0x00000C9C
		public unsafe BoxShape3D Box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00027A2C File Offset: 0x00025C2C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002ABB File Offset: 0x00000CBB
		public unsafe SphereShape3D Sphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Sphere);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_Sphere), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00027A5C File Offset: 0x00025C5C
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002ADA File Offset: 0x00000CDA
		public unsafe TriangPrismShape3D TrPrism
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_TrPrism);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriangPrismShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_TrPrism), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00027A8C File Offset: 0x00025C8C
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002AF9 File Offset: 0x00000CF9
		public unsafe int ConeIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_ConeIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_ConeIndex)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00027AB4 File Offset: 0x00025CB4
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002B14 File Offset: 0x00000D14
		public unsafe int PyramidIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_PyramidIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_PyramidIndex)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00027ADC File Offset: 0x00025CDC
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002B2F File Offset: 0x00000D2F
		public unsafe int BoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_BoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_BoxIndex)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00027B04 File Offset: 0x00025D04
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002B4A File Offset: 0x00000D4A
		public unsafe int SphereIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_SphereIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_SphereIndex)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00027B2C File Offset: 0x00025D2C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002B65 File Offset: 0x00000D65
		public unsafe int TrPrismIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_TrPrismIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DControllerData.NativeFieldInfoPtr_TrPrismIndex)) = value;
			}
		}

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_Cap;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_CapHandle;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_Cone;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_Pyramid;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_Box;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_Sphere;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_TrPrism;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_ConeIndex;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_PyramidIndex;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_BoxIndex;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_SphereIndex;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_TrPrismIndex;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
