using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000B5 RID: 181
	public class GizmoPolygon2DBorder : global::Il2CppSystem.Object
	{
		// Token: 0x06000F32 RID: 3890 RVA: 0x0005B2B0 File Offset: 0x000594B0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPolygon2DBorder()
		{
			Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPolygon2DBorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr);
			GizmoPolygon2DBorder.NativeFieldInfoPtr__planeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_planeSlider");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__targetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_targetHandle");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__targetPolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_targetPolygon");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_isVisible");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_isHoverable");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__borderPolygonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_borderPolygonIndex");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__thickBorderPolygonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_thickBorderPolygonIndex");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__borderPolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_borderPolygon");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__thickBorderPolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_thickBorderPolygon");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_controllerData");
			GizmoPolygon2DBorder.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, "_controllers");
			GizmoPolygon2DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, 100665472);
			GizmoPolygon2DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, 100665473);
			GizmoPolygon2DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2D_GizmoHandle_PolygonShape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, 100665474);
			GizmoPolygon2DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, 100665475);
			GizmoPolygon2DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, 100665476);
			GizmoPolygon2DBorder.NativeMethodInfoPtr_OnPolygonShapeChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, 100665477);
			GizmoPolygon2DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, 100665478);
			GizmoPolygon2DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr, 100665479);
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0005B45C File Offset: 0x0005965C
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0005B498 File Offset: 0x00059698
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0005B4D4 File Offset: 0x000596D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68381, RefRangeEnd = 68382, XrefRangeStart = 68314, XrefRangeEnd = 68381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPolygon2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, PolygonShape2D targetPolygon)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPolygon2DBorder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeSlider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPolygon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2D_GizmoHandle_PolygonShape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0005B544 File Offset: 0x00059744
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68393, RefRangeEnd = 68396, XrefRangeStart = 68382, XrefRangeEnd = 68393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0005B584 File Offset: 0x00059784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68399, RefRangeEnd = 68400, XrefRangeStart = 68396, XrefRangeEnd = 68399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0005B5C4 File Offset: 0x000597C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68406, RefRangeEnd = 68407, XrefRangeStart = 68400, XrefRangeEnd = 68406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPolygonShapeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorder.NativeMethodInfoPtr_OnPolygonShapeChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0005B5F8 File Offset: 0x000597F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68422, RefRangeEnd = 68423, XrefRangeStart = 68407, XrefRangeEnd = 68422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0005B63C File Offset: 0x0005983C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68423, XrefRangeEnd = 68432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPolygon2DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x000079F7 File Offset: 0x00005BF7
		public GizmoPolygon2DBorder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x0005B680 File Offset: 0x00059880
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x00007A00 File Offset: 0x00005C00
		public unsafe GizmoPlaneSlider2D _planeSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__planeSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__planeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0005B6B0 File Offset: 0x000598B0
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x00007A1F File Offset: 0x00005C1F
		public unsafe GizmoHandle _targetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__targetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__targetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0005B6E0 File Offset: 0x000598E0
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x00007A3E File Offset: 0x00005C3E
		public unsafe PolygonShape2D _targetPolygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__targetPolygon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__targetPolygon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0005B710 File Offset: 0x00059910
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00007A5D File Offset: 0x00005C5D
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0005B738 File Offset: 0x00059938
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x00007A78 File Offset: 0x00005C78
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x0005B760 File Offset: 0x00059960
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x00007A93 File Offset: 0x00005C93
		public unsafe int _borderPolygonIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__borderPolygonIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__borderPolygonIndex)) = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0005B788 File Offset: 0x00059988
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x00007AAE File Offset: 0x00005CAE
		public unsafe int _thickBorderPolygonIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__thickBorderPolygonIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__thickBorderPolygonIndex)) = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0005B7B0 File Offset: 0x000599B0
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x00007AC9 File Offset: 0x00005CC9
		public unsafe PolygonShape2D _borderPolygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__borderPolygon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__borderPolygon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0005B7E0 File Offset: 0x000599E0
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x00007AE8 File Offset: 0x00005CE8
		public unsafe PolygonShape2D _thickBorderPolygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__thickBorderPolygon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__thickBorderPolygon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0005B810 File Offset: 0x00059A10
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x00007B07 File Offset: 0x00005D07
		public unsafe GizmoPolygon2DBorderControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPolygon2DBorderControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x0005B840 File Offset: 0x00059A40
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x00007B26 File Offset: 0x00005D26
		public unsafe Il2CppReferenceArray<IGizmoPolygon2DBorderController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoPolygon2DBorderController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPolygon2DBorder.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeFieldInfoPtr__planeSlider;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr__targetHandle;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr__targetPolygon;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeFieldInfoPtr__borderPolygonIndex;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeFieldInfoPtr__thickBorderPolygonIndex;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeFieldInfoPtr__borderPolygon;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeFieldInfoPtr__thickBorderPolygon;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2D_GizmoHandle_PolygonShape2D_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_OnPolygonShapeChanged_Public_Void_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;
	}
}
