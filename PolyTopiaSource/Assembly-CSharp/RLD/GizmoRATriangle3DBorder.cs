using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000CD RID: 205
	public class GizmoRATriangle3DBorder : global::Il2CppSystem.Object
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x0005F8E4 File Offset: 0x0005DAE4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoRATriangle3DBorder()
		{
			Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoRATriangle3DBorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr);
			GizmoRATriangle3DBorder.NativeFieldInfoPtr__planeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, "_planeSlider");
			GizmoRATriangle3DBorder.NativeFieldInfoPtr__targetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, "_targetHandle");
			GizmoRATriangle3DBorder.NativeFieldInfoPtr__targetTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, "_targetTriangle");
			GizmoRATriangle3DBorder.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, "_isVisible");
			GizmoRATriangle3DBorder.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, "_isHoverable");
			GizmoRATriangle3DBorder.NativeFieldInfoPtr__borderTriangleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, "_borderTriangleIndex");
			GizmoRATriangle3DBorder.NativeFieldInfoPtr__borderTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, "_borderTriangle");
			GizmoRATriangle3DBorder.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, "_controllerData");
			GizmoRATriangle3DBorder.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, "_controllers");
			GizmoRATriangle3DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665581);
			GizmoRATriangle3DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665582);
			GizmoRATriangle3DBorder.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665583);
			GizmoRATriangle3DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3D_GizmoHandle_RightAngTriangle3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665584);
			GizmoRATriangle3DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665585);
			GizmoRATriangle3DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665586);
			GizmoRATriangle3DBorder.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665587);
			GizmoRATriangle3DBorder.NativeMethodInfoPtr_OnTriangleShapeChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665588);
			GizmoRATriangle3DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665589);
			GizmoRATriangle3DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr, 100665590);
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0005FA90 File Offset: 0x0005DC90
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0005FACC File Offset: 0x0005DCCC
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0005FB08 File Offset: 0x0005DD08
		public unsafe Gizmo Gizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0005FB48 File Offset: 0x0005DD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69240, RefRangeEnd = 69241, XrefRangeStart = 69188, XrefRangeEnd = 69240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoRATriangle3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, RightAngTriangle3D targetRiangle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoRATriangle3DBorder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeSlider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetRiangle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3D_GizmoHandle_RightAngTriangle3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0005FBB8 File Offset: 0x0005DDB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69256, RefRangeEnd = 69259, XrefRangeStart = 69241, XrefRangeEnd = 69256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0005FBF8 File Offset: 0x0005DDF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69261, RefRangeEnd = 69264, XrefRangeStart = 69259, XrefRangeEnd = 69261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0005FC38 File Offset: 0x0005DE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0005FC88 File Offset: 0x0005DE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69272, RefRangeEnd = 69273, XrefRangeStart = 69264, XrefRangeEnd = 69272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriangleShapeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr_OnTriangleShapeChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0005FCBC File Offset: 0x0005DEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69273, XrefRangeEnd = 69287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0005FD00 File Offset: 0x0005DF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69287, XrefRangeEnd = 69298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATriangle3DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x000087E6 File Offset: 0x000069E6
		public GizmoRATriangle3DBorder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0005FD44 File Offset: 0x0005DF44
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x000087EF File Offset: 0x000069EF
		public unsafe GizmoPlaneSlider3D _planeSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__planeSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__planeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x0005FD74 File Offset: 0x0005DF74
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x0000880E File Offset: 0x00006A0E
		public unsafe GizmoHandle _targetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__targetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__targetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0005FDA4 File Offset: 0x0005DFA4
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x0000882D File Offset: 0x00006A2D
		public unsafe RightAngTriangle3D _targetTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__targetTriangle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RightAngTriangle3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__targetTriangle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x0005FDD4 File Offset: 0x0005DFD4
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x0000884C File Offset: 0x00006A4C
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0005FDFC File Offset: 0x0005DFFC
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x00008867 File Offset: 0x00006A67
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0005FE24 File Offset: 0x0005E024
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00008882 File Offset: 0x00006A82
		public unsafe int _borderTriangleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__borderTriangleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__borderTriangleIndex)) = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x0005FE4C File Offset: 0x0005E04C
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x0000889D File Offset: 0x00006A9D
		public unsafe RightAngTriangle3D _borderTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__borderTriangle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RightAngTriangle3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__borderTriangle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x0005FE7C File Offset: 0x0005E07C
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x000088BC File Offset: 0x00006ABC
		public unsafe GizmoRATriangle3DBorderControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRATriangle3DBorderControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0005FEAC File Offset: 0x0005E0AC
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x000088DB File Offset: 0x00006ADB
		public unsafe Il2CppReferenceArray<IGizmoRATriangle3DBorderController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoRATriangle3DBorderController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoRATriangle3DBorder.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeFieldInfoPtr__planeSlider;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeFieldInfoPtr__targetHandle;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeFieldInfoPtr__targetTriangle;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeFieldInfoPtr__borderTriangleIndex;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeFieldInfoPtr__borderTriangle;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3D_GizmoHandle_RightAngTriangle3D_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_OnTriangleShapeChanged_Public_Void_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;
	}
}
