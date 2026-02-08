using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000B0 RID: 176
	public class GizmoCircle2DBorder : global::Il2CppSystem.Object
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x0005A6C0 File Offset: 0x000588C0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCircle2DBorder()
		{
			Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCircle2DBorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr);
			GizmoCircle2DBorder.NativeFieldInfoPtr__planeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, "_planeSlider");
			GizmoCircle2DBorder.NativeFieldInfoPtr__targetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, "_targetHandle");
			GizmoCircle2DBorder.NativeFieldInfoPtr__targetCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, "_targetCircle");
			GizmoCircle2DBorder.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, "_isVisible");
			GizmoCircle2DBorder.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, "_isHoverable");
			GizmoCircle2DBorder.NativeFieldInfoPtr__borderCircleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, "_borderCircleIndex");
			GizmoCircle2DBorder.NativeFieldInfoPtr__borderCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, "_borderCircle");
			GizmoCircle2DBorder.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, "_controllerData");
			GizmoCircle2DBorder.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, "_controllers");
			GizmoCircle2DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, 100665452);
			GizmoCircle2DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, 100665453);
			GizmoCircle2DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2D_GizmoHandle_CircleShape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, 100665454);
			GizmoCircle2DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, 100665455);
			GizmoCircle2DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, 100665456);
			GizmoCircle2DBorder.NativeMethodInfoPtr_OnCircleShapeChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, 100665457);
			GizmoCircle2DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, 100665458);
			GizmoCircle2DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr, 100665459);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x0005A844 File Offset: 0x00058A44
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle2DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0005A880 File Offset: 0x00058A80
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle2DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0005A8BC File Offset: 0x00058ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68269, RefRangeEnd = 68270, XrefRangeStart = 68218, XrefRangeEnd = 68269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCircle2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, CircleShape2D targetCircle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCircle2DBorder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeSlider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetCircle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle2DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2D_GizmoHandle_CircleShape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0005A92C File Offset: 0x00058B2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68276, RefRangeEnd = 68279, XrefRangeStart = 68270, XrefRangeEnd = 68276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle2DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0005A96C File Offset: 0x00058B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68281, RefRangeEnd = 68282, XrefRangeStart = 68279, XrefRangeEnd = 68281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle2DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0005A9AC File Offset: 0x00058BAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68287, RefRangeEnd = 68289, XrefRangeStart = 68282, XrefRangeEnd = 68287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCircleShapeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle2DBorder.NativeMethodInfoPtr_OnCircleShapeChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0005A9E0 File Offset: 0x00058BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68289, XrefRangeEnd = 68300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle2DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0005AA24 File Offset: 0x00058C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68300, XrefRangeEnd = 68307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle2DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000077CB File Offset: 0x000059CB
		public GizmoCircle2DBorder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x0005AA68 File Offset: 0x00058C68
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x000077D4 File Offset: 0x000059D4
		public unsafe GizmoPlaneSlider2D _planeSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__planeSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__planeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0005AA98 File Offset: 0x00058C98
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x000077F3 File Offset: 0x000059F3
		public unsafe GizmoHandle _targetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__targetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__targetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0005AAC8 File Offset: 0x00058CC8
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x00007812 File Offset: 0x00005A12
		public unsafe CircleShape2D _targetCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__targetCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__targetCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0005AAF8 File Offset: 0x00058CF8
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00007831 File Offset: 0x00005A31
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0005AB20 File Offset: 0x00058D20
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x0000784C File Offset: 0x00005A4C
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0005AB48 File Offset: 0x00058D48
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00007867 File Offset: 0x00005A67
		public unsafe int _borderCircleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__borderCircleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__borderCircleIndex)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0005AB70 File Offset: 0x00058D70
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x00007882 File Offset: 0x00005A82
		public unsafe CircleShape2D _borderCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__borderCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__borderCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x0005ABA0 File Offset: 0x00058DA0
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x000078A1 File Offset: 0x00005AA1
		public unsafe GizmoCircle2DBorderControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle2DBorderControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0005ABD0 File Offset: 0x00058DD0
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x000078C0 File Offset: 0x00005AC0
		public unsafe Il2CppReferenceArray<IGizmoCircle2DBorderController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoCircle2DBorderController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle2DBorder.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeFieldInfoPtr__planeSlider;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeFieldInfoPtr__targetHandle;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr__targetCircle;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeFieldInfoPtr__borderCircleIndex;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr__borderCircle;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2D_GizmoHandle_CircleShape2D_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_OnCircleShapeChanged_Public_Void_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;
	}
}
