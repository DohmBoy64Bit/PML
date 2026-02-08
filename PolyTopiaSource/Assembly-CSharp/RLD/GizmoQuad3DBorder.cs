using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000C8 RID: 200
	public class GizmoQuad3DBorder : global::Il2CppSystem.Object
	{
		// Token: 0x06001029 RID: 4137 RVA: 0x0005E2D8 File Offset: 0x0005C4D8
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoQuad3DBorder()
		{
			Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoQuad3DBorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr);
			GizmoQuad3DBorder.NativeFieldInfoPtr__planeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_planeSlider");
			GizmoQuad3DBorder.NativeFieldInfoPtr__targetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_targetHandle");
			GizmoQuad3DBorder.NativeFieldInfoPtr__targetQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_targetQuad");
			GizmoQuad3DBorder.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_isVisible");
			GizmoQuad3DBorder.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_isHoverable");
			GizmoQuad3DBorder.NativeFieldInfoPtr__borderQuadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_borderQuadIndex");
			GizmoQuad3DBorder.NativeFieldInfoPtr__borderQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_borderQuad");
			GizmoQuad3DBorder.NativeFieldInfoPtr__topBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_topBoxIndex");
			GizmoQuad3DBorder.NativeFieldInfoPtr__topBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_topBox");
			GizmoQuad3DBorder.NativeFieldInfoPtr__rightBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_rightBoxIndex");
			GizmoQuad3DBorder.NativeFieldInfoPtr__rightBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_rightBox");
			GizmoQuad3DBorder.NativeFieldInfoPtr__bottomBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_bottomBoxIndex");
			GizmoQuad3DBorder.NativeFieldInfoPtr__bottomBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_bottomBox");
			GizmoQuad3DBorder.NativeFieldInfoPtr__leftBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_leftBoxIndex");
			GizmoQuad3DBorder.NativeFieldInfoPtr__leftBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_leftBox");
			GizmoQuad3DBorder.NativeFieldInfoPtr__topLeftBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_topLeftBoxIndex");
			GizmoQuad3DBorder.NativeFieldInfoPtr__topLeftBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_topLeftBox");
			GizmoQuad3DBorder.NativeFieldInfoPtr__topRightBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_topRightBoxIndex");
			GizmoQuad3DBorder.NativeFieldInfoPtr__topRightBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_topRightBox");
			GizmoQuad3DBorder.NativeFieldInfoPtr__bottomRightBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_bottomRightBoxIndex");
			GizmoQuad3DBorder.NativeFieldInfoPtr__bottomRightBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_bottomRightBox");
			GizmoQuad3DBorder.NativeFieldInfoPtr__bottomLeftBoxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_bottomLeftBoxIndex");
			GizmoQuad3DBorder.NativeFieldInfoPtr__bottomLeftBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_bottomLeftBox");
			GizmoQuad3DBorder.NativeFieldInfoPtr__sortedBoxIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_sortedBoxIndices");
			GizmoQuad3DBorder.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_controllerData");
			GizmoQuad3DBorder.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "_controllers");
			GizmoQuad3DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665555);
			GizmoQuad3DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665556);
			GizmoQuad3DBorder.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665557);
			GizmoQuad3DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3D_GizmoHandle_QuadShape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665558);
			GizmoQuad3DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665559);
			GizmoQuad3DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665560);
			GizmoQuad3DBorder.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665561);
			GizmoQuad3DBorder.NativeMethodInfoPtr_GetRealBoxHeight_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665562);
			GizmoQuad3DBorder.NativeMethodInfoPtr_GetRealBoxDepth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665563);
			GizmoQuad3DBorder.NativeMethodInfoPtr_OnQuadShapeChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665564);
			GizmoQuad3DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665565);
			GizmoQuad3DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, 100665566);
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x0005E600 File Offset: 0x0005C800
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x0005E63C File Offset: 0x0005C83C
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x0005E678 File Offset: 0x0005C878
		public unsafe Gizmo Gizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0005E6B8 File Offset: 0x0005C8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69038, RefRangeEnd = 69039, XrefRangeStart = 68896, XrefRangeEnd = 69038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoQuad3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, QuadShape3D targetQuad)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeSlider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetHandle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetQuad);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3D_GizmoHandle_QuadShape3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0005E728 File Offset: 0x0005C928
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69054, RefRangeEnd = 69057, XrefRangeStart = 69039, XrefRangeEnd = 69054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0005E768 File Offset: 0x0005C968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69073, RefRangeEnd = 69076, XrefRangeStart = 69057, XrefRangeEnd = 69073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0005E7A8 File Offset: 0x0005C9A8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0005E7F8 File Offset: 0x0005C9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69076, XrefRangeEnd = 69078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealBoxHeight(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_GetRealBoxHeight_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0005E844 File Offset: 0x0005CA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69078, XrefRangeEnd = 69080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealBoxDepth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_GetRealBoxDepth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0005E890 File Offset: 0x0005CA90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69088, RefRangeEnd = 69089, XrefRangeStart = 69080, XrefRangeEnd = 69088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuadShapeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_OnQuadShapeChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0005E8C4 File Offset: 0x0005CAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69089, XrefRangeEnd = 69160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0005E908 File Offset: 0x0005CB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69160, XrefRangeEnd = 69171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000081FB File Offset: 0x000063FB
		public GizmoQuad3DBorder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0005E94C File Offset: 0x0005CB4C
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x00008204 File Offset: 0x00006404
		public unsafe GizmoPlaneSlider3D _planeSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__planeSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__planeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0005E97C File Offset: 0x0005CB7C
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x00008223 File Offset: 0x00006423
		public unsafe GizmoHandle _targetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__targetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__targetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0005E9AC File Offset: 0x0005CBAC
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x00008242 File Offset: 0x00006442
		public unsafe QuadShape3D _targetQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__targetQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__targetQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0005E9DC File Offset: 0x0005CBDC
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x00008261 File Offset: 0x00006461
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x0005EA04 File Offset: 0x0005CC04
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x0000827C File Offset: 0x0000647C
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x0005EA2C File Offset: 0x0005CC2C
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x00008297 File Offset: 0x00006497
		public unsafe int _borderQuadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__borderQuadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__borderQuadIndex)) = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0005EA54 File Offset: 0x0005CC54
		// (set) Token: 0x06001044 RID: 4164 RVA: 0x000082B2 File Offset: 0x000064B2
		public unsafe QuadShape3D _borderQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__borderQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__borderQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x0005EA84 File Offset: 0x0005CC84
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x000082D1 File Offset: 0x000064D1
		public unsafe int _topBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topBoxIndex)) = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0005EAAC File Offset: 0x0005CCAC
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x000082EC File Offset: 0x000064EC
		public unsafe BoxShape3D _topBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0005EADC File Offset: 0x0005CCDC
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x0000830B File Offset: 0x0000650B
		public unsafe int _rightBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__rightBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__rightBoxIndex)) = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0005EB04 File Offset: 0x0005CD04
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x00008326 File Offset: 0x00006526
		public unsafe BoxShape3D _rightBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__rightBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__rightBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x0005EB34 File Offset: 0x0005CD34
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x00008345 File Offset: 0x00006545
		public unsafe int _bottomBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomBoxIndex)) = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x0005EB5C File Offset: 0x0005CD5C
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x00008360 File Offset: 0x00006560
		public unsafe BoxShape3D _bottomBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x0005EB8C File Offset: 0x0005CD8C
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x0000837F File Offset: 0x0000657F
		public unsafe int _leftBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__leftBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__leftBoxIndex)) = value;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x0005EBB4 File Offset: 0x0005CDB4
		// (set) Token: 0x06001054 RID: 4180 RVA: 0x0000839A File Offset: 0x0000659A
		public unsafe BoxShape3D _leftBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__leftBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__leftBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x0005EBE4 File Offset: 0x0005CDE4
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x000083B9 File Offset: 0x000065B9
		public unsafe int _topLeftBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topLeftBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topLeftBoxIndex)) = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x0005EC0C File Offset: 0x0005CE0C
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x000083D4 File Offset: 0x000065D4
		public unsafe BoxShape3D _topLeftBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topLeftBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topLeftBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x0005EC3C File Offset: 0x0005CE3C
		// (set) Token: 0x0600105A RID: 4186 RVA: 0x000083F3 File Offset: 0x000065F3
		public unsafe int _topRightBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topRightBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topRightBoxIndex)) = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x0005EC64 File Offset: 0x0005CE64
		// (set) Token: 0x0600105C RID: 4188 RVA: 0x0000840E File Offset: 0x0000660E
		public unsafe BoxShape3D _topRightBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topRightBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__topRightBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x0005EC94 File Offset: 0x0005CE94
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x0000842D File Offset: 0x0000662D
		public unsafe int _bottomRightBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomRightBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomRightBoxIndex)) = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x0005ECBC File Offset: 0x0005CEBC
		// (set) Token: 0x06001060 RID: 4192 RVA: 0x00008448 File Offset: 0x00006648
		public unsafe BoxShape3D _bottomRightBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomRightBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomRightBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x0005ECEC File Offset: 0x0005CEEC
		// (set) Token: 0x06001062 RID: 4194 RVA: 0x00008467 File Offset: 0x00006667
		public unsafe int _bottomLeftBoxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomLeftBoxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomLeftBoxIndex)) = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x0005ED14 File Offset: 0x0005CF14
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x00008482 File Offset: 0x00006682
		public unsafe BoxShape3D _bottomLeftBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomLeftBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__bottomLeftBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x0005ED44 File Offset: 0x0005CF44
		// (set) Token: 0x06001066 RID: 4198 RVA: 0x000084A1 File Offset: 0x000066A1
		public unsafe List<int> _sortedBoxIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__sortedBoxIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__sortedBoxIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x0005ED74 File Offset: 0x0005CF74
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x000084C0 File Offset: 0x000066C0
		public unsafe GizmoQuad3DBorderControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad3DBorderControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0005EDA4 File Offset: 0x0005CFA4
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x000084DF File Offset: 0x000066DF
		public unsafe Il2CppReferenceArray<IGizmoQuad3DBorderController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoQuad3DBorderController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr__planeSlider;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeFieldInfoPtr__targetHandle;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeFieldInfoPtr__targetQuad;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr__borderQuadIndex;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeFieldInfoPtr__borderQuad;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeFieldInfoPtr__topBoxIndex;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeFieldInfoPtr__topBox;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeFieldInfoPtr__rightBoxIndex;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr__rightBox;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr__bottomBoxIndex;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr__bottomBox;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr__leftBoxIndex;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr__leftBox;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr__topLeftBoxIndex;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeFieldInfoPtr__topLeftBox;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeFieldInfoPtr__topRightBoxIndex;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeFieldInfoPtr__topRightBox;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeFieldInfoPtr__bottomRightBoxIndex;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeFieldInfoPtr__bottomRightBox;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeFieldInfoPtr__bottomLeftBoxIndex;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeFieldInfoPtr__bottomLeftBox;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr__sortedBoxIndices;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3D_GizmoHandle_QuadShape3D_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_GetRealBoxHeight_Public_Single_Single_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_GetRealBoxDepth_Public_Single_Single_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_OnQuadShapeChanged_Public_Void_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x02000372 RID: 882
		[ObfuscatedName("RLD.GizmoQuad3DBorder+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A0E RID: 18958 RVA: 0x001466A8 File Offset: 0x001448A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<GizmoQuad3DBorder.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoQuad3DBorder>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoQuad3DBorder.__c__DisplayClass39_0>.NativeClassPtr);
				GizmoQuad3DBorder.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				GizmoQuad3DBorder.__c__DisplayClass39_0.NativeFieldInfoPtr_camPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad3DBorder.__c__DisplayClass39_0>.NativeClassPtr, "camPos");
				GizmoQuad3DBorder.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder.__c__DisplayClass39_0>.NativeClassPtr, 100665567);
				GizmoQuad3DBorder.__c__DisplayClass39_0.NativeMethodInfoPtr__Render_b__0_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad3DBorder.__c__DisplayClass39_0>.NativeClassPtr, 100665568);
			}

			// Token: 0x06004A0F RID: 18959 RVA: 0x00146724 File Offset: 0x00144924
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoQuad3DBorder.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A10 RID: 18960 RVA: 0x00146760 File Offset: 0x00144960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68889, XrefRangeEnd = 68896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Render_b__0(int i0, int i1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad3DBorder.__c__DisplayClass39_0.NativeMethodInfoPtr__Render_b__0_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A11 RID: 18961 RVA: 0x0001B91A File Offset: 0x00019B1A
			public __c__DisplayClass39_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700190E RID: 6414
			// (get) Token: 0x06004A12 RID: 18962 RVA: 0x001467B8 File Offset: 0x001449B8
			// (set) Token: 0x06004A13 RID: 18963 RVA: 0x0001B923 File Offset: 0x00019B23
			public unsafe GizmoQuad3DBorder __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad3DBorder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700190F RID: 6415
			// (get) Token: 0x06004A14 RID: 18964 RVA: 0x001467E8 File Offset: 0x001449E8
			// (set) Token: 0x06004A15 RID: 18965 RVA: 0x0001B942 File Offset: 0x00019B42
			public unsafe Vector3 camPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.__c__DisplayClass39_0.NativeFieldInfoPtr_camPos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad3DBorder.__c__DisplayClass39_0.NativeFieldInfoPtr_camPos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003979 RID: 14713
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400397A RID: 14714
			private static readonly IntPtr NativeFieldInfoPtr_camPos;

			// Token: 0x0400397B RID: 14715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400397C RID: 14716
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__0_Internal_Int32_Int32_Int32_0;
		}
	}
}
