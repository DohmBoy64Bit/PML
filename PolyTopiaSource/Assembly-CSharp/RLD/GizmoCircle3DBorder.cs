using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000C0 RID: 192
	public class GizmoCircle3DBorder : global::Il2CppSystem.Object
	{
		// Token: 0x06000FC0 RID: 4032 RVA: 0x0005CD10 File Offset: 0x0005AF10
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCircle3DBorder()
		{
			Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCircle3DBorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr);
			GizmoCircle3DBorder.NativeFieldInfoPtr__planeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_planeSlider");
			GizmoCircle3DBorder.NativeFieldInfoPtr__targetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_targetHandle");
			GizmoCircle3DBorder.NativeFieldInfoPtr__targetCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_targetCircle");
			GizmoCircle3DBorder.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_isVisible");
			GizmoCircle3DBorder.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_isHoverable");
			GizmoCircle3DBorder.NativeFieldInfoPtr__borderCircleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_borderCircleIndex");
			GizmoCircle3DBorder.NativeFieldInfoPtr__borderTorusIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_borderTorusIndex");
			GizmoCircle3DBorder.NativeFieldInfoPtr__borderCylTorusIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_borderCylTorusIndex");
			GizmoCircle3DBorder.NativeFieldInfoPtr__borderCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_borderCircle");
			GizmoCircle3DBorder.NativeFieldInfoPtr__borderTorus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_borderTorus");
			GizmoCircle3DBorder.NativeFieldInfoPtr__borderCylTorus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_borderCylTorus");
			GizmoCircle3DBorder.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_controllerData");
			GizmoCircle3DBorder.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, "_controllers");
			GizmoCircle3DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665516);
			GizmoCircle3DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665517);
			GizmoCircle3DBorder.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665518);
			GizmoCircle3DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3D_GizmoHandle_CircleShape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665519);
			GizmoCircle3DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665520);
			GizmoCircle3DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665521);
			GizmoCircle3DBorder.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665522);
			GizmoCircle3DBorder.NativeMethodInfoPtr_GetRealTorusThickness_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665523);
			GizmoCircle3DBorder.NativeMethodInfoPtr_GetRealCylTorusWidth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665524);
			GizmoCircle3DBorder.NativeMethodInfoPtr_GetRealCylTorusHeight_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665525);
			GizmoCircle3DBorder.NativeMethodInfoPtr_OnCircleShapeChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665526);
			GizmoCircle3DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665527);
			GizmoCircle3DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr, 100665528);
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x0005CF48 File Offset: 0x0005B148
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0005CF84 File Offset: 0x0005B184
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x0005CFC0 File Offset: 0x0005B1C0
		public unsafe Gizmo Gizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0005D000 File Offset: 0x0005B200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68637, RefRangeEnd = 68638, XrefRangeStart = 68552, XrefRangeEnd = 68637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCircle3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, CircleShape3D targetCircle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCircle3DBorder>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3D_GizmoHandle_CircleShape3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0005D070 File Offset: 0x0005B270
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68653, RefRangeEnd = 68656, XrefRangeStart = 68638, XrefRangeEnd = 68653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0005D0B0 File Offset: 0x0005B2B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68660, RefRangeEnd = 68663, XrefRangeStart = 68656, XrefRangeEnd = 68660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0005D0F0 File Offset: 0x0005B2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68663, XrefRangeEnd = 68665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0005D140 File Offset: 0x0005B340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68665, XrefRangeEnd = 68667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealTorusThickness(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_GetRealTorusThickness_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0005D18C File Offset: 0x0005B38C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68669, RefRangeEnd = 68670, XrefRangeStart = 68667, XrefRangeEnd = 68669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealCylTorusWidth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_GetRealCylTorusWidth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0005D1D8 File Offset: 0x0005B3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68672, RefRangeEnd = 68673, XrefRangeStart = 68670, XrefRangeEnd = 68672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealCylTorusHeight(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_GetRealCylTorusHeight_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0005D224 File Offset: 0x0005B424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68681, RefRangeEnd = 68682, XrefRangeStart = 68673, XrefRangeEnd = 68681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCircleShapeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_OnCircleShapeChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0005D258 File Offset: 0x0005B458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68718, RefRangeEnd = 68719, XrefRangeStart = 68682, XrefRangeEnd = 68718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0005D29C File Offset: 0x0005B49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68719, XrefRangeEnd = 68730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircle3DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00007ECC File Offset: 0x000060CC
		public GizmoCircle3DBorder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0005D2E0 File Offset: 0x0005B4E0
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x00007ED5 File Offset: 0x000060D5
		public unsafe GizmoPlaneSlider3D _planeSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__planeSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__planeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0005D310 File Offset: 0x0005B510
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00007EF4 File Offset: 0x000060F4
		public unsafe GizmoHandle _targetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__targetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__targetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0005D340 File Offset: 0x0005B540
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00007F13 File Offset: 0x00006113
		public unsafe CircleShape3D _targetCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__targetCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__targetCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x0005D370 File Offset: 0x0005B570
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x00007F32 File Offset: 0x00006132
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x0005D398 File Offset: 0x0005B598
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x00007F4D File Offset: 0x0000614D
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0005D3C0 File Offset: 0x0005B5C0
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00007F68 File Offset: 0x00006168
		public unsafe int _borderCircleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderCircleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderCircleIndex)) = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x0005D3E8 File Offset: 0x0005B5E8
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00007F83 File Offset: 0x00006183
		public unsafe int _borderTorusIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderTorusIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderTorusIndex)) = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0005D410 File Offset: 0x0005B610
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00007F9E File Offset: 0x0000619E
		public unsafe int _borderCylTorusIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderCylTorusIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderCylTorusIndex)) = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0005D438 File Offset: 0x0005B638
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00007FB9 File Offset: 0x000061B9
		public unsafe CircleShape3D _borderCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0005D468 File Offset: 0x0005B668
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00007FD8 File Offset: 0x000061D8
		public unsafe TorusShape3D _borderTorus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderTorus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TorusShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderTorus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x0005D498 File Offset: 0x0005B698
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00007FF7 File Offset: 0x000061F7
		public unsafe CylTorusShape3D _borderCylTorus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderCylTorus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CylTorusShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__borderCylTorus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0005D4C8 File Offset: 0x0005B6C8
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00008016 File Offset: 0x00006216
		public unsafe GizmoCircle3DBorderControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle3DBorderControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0005D4F8 File Offset: 0x0005B6F8
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00008035 File Offset: 0x00006235
		public unsafe Il2CppReferenceArray<IGizmoCircle3DBorderController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoCircle3DBorderController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCircle3DBorder.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeFieldInfoPtr__planeSlider;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr__targetHandle;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeFieldInfoPtr__targetCircle;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr__borderCircleIndex;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr__borderTorusIndex;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr__borderCylTorusIndex;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr__borderCircle;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr__borderTorus;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr__borderCylTorus;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3D_GizmoHandle_CircleShape3D_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_GetRealTorusThickness_Public_Single_Single_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_GetRealCylTorusWidth_Public_Single_Single_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_GetRealCylTorusHeight_Public_Single_Single_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_OnCircleShapeChanged_Public_Void_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;
	}
}
