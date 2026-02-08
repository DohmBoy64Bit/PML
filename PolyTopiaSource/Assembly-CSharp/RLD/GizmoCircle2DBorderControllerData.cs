using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000B2 RID: 178
	public class GizmoCircle2DBorderControllerData : Object
	{
		// Token: 0x06000F16 RID: 3862 RVA: 0x0005ADC4 File Offset: 0x00058FC4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCircle2DBorderControllerData()
		{
			Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCircle2DBorderControllerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr);
			GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr, "Gizmo");
			GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_PlaneSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr, "PlaneSlider");
			GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr, "Border");
			GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_TargetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr, "TargetHandle");
			GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_TargetCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr, "TargetCircle");
			GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_BorderCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr, "BorderCircle");
			GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_BorderCircleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr, "BorderCircleIndex");
			GizmoCircle2DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr, 100665464);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0005AE94 File Offset: 0x00059094
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCircle2DBorderControllerData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCircle2DBorderControllerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle2DBorderControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00007907 File Offset: 0x00005B07
		public GizmoCircle2DBorderControllerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0005AED0 File Offset: 0x000590D0
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00007910 File Offset: 0x00005B10
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0005AF00 File Offset: 0x00059100
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x0000792F File Offset: 0x00005B2F
		public unsafe GizmoPlaneSlider2D PlaneSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_PlaneSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_PlaneSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x0005AF30 File Offset: 0x00059130
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x0000794E File Offset: 0x00005B4E
		public unsafe GizmoCircle2DBorder Border
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_Border);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle2DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_Border), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x0005AF60 File Offset: 0x00059160
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x0000796D File Offset: 0x00005B6D
		public unsafe GizmoHandle TargetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_TargetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_TargetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x0005AF90 File Offset: 0x00059190
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x0000798C File Offset: 0x00005B8C
		public unsafe CircleShape2D TargetCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_TargetCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_TargetCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0005AFC0 File Offset: 0x000591C0
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x000079AB File Offset: 0x00005BAB
		public unsafe CircleShape2D BorderCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_BorderCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_BorderCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x0005AFF0 File Offset: 0x000591F0
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x000079CA File Offset: 0x00005BCA
		public unsafe int BorderCircleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_BorderCircleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorderControllerData.NativeFieldInfoPtr_BorderCircleIndex)) = value;
			}
		}

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeFieldInfoPtr_PlaneSlider;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeFieldInfoPtr_Border;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeFieldInfoPtr_TargetHandle;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeFieldInfoPtr_TargetCircle;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeFieldInfoPtr_BorderCircle;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeFieldInfoPtr_BorderCircleIndex;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
