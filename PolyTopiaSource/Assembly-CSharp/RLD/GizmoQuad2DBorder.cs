using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000BB RID: 187
	public class GizmoQuad2DBorder : global::Il2CppSystem.Object
	{
		// Token: 0x06000F80 RID: 3968 RVA: 0x0005C120 File Offset: 0x0005A320
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoQuad2DBorder()
		{
			Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoQuad2DBorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr);
			GizmoQuad2DBorder.NativeFieldInfoPtr__planeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, "_planeSlider");
			GizmoQuad2DBorder.NativeFieldInfoPtr__targetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, "_targetHandle");
			GizmoQuad2DBorder.NativeFieldInfoPtr__targetQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, "_targetQuad");
			GizmoQuad2DBorder.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, "_isVisible");
			GizmoQuad2DBorder.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, "_isHoverable");
			GizmoQuad2DBorder.NativeFieldInfoPtr__borderQuadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, "_borderQuadIndex");
			GizmoQuad2DBorder.NativeFieldInfoPtr__borderQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, "_borderQuad");
			GizmoQuad2DBorder.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, "_controllerData");
			GizmoQuad2DBorder.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, "_controllers");
			GizmoQuad2DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, 100665496);
			GizmoQuad2DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, 100665497);
			GizmoQuad2DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2D_GizmoHandle_QuadShape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, 100665498);
			GizmoQuad2DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, 100665499);
			GizmoQuad2DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, 100665500);
			GizmoQuad2DBorder.NativeMethodInfoPtr_OnQuadShapeChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, 100665501);
			GizmoQuad2DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, 100665502);
			GizmoQuad2DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr, 100665503);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0005C2A4 File Offset: 0x0005A4A4
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad2DBorder.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0005C2E0 File Offset: 0x0005A4E0
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad2DBorder.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0005C31C File Offset: 0x0005A51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68502, RefRangeEnd = 68503, XrefRangeStart = 68450, XrefRangeEnd = 68502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoQuad2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, QuadShape2D targetQuad)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoQuad2DBorder>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad2DBorder.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2D_GizmoHandle_QuadShape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0005C38C File Offset: 0x0005A58C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68514, RefRangeEnd = 68517, XrefRangeStart = 68503, XrefRangeEnd = 68514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad2DBorder.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0005C3CC File Offset: 0x0005A5CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68281, RefRangeEnd = 68282, XrefRangeStart = 68281, XrefRangeEnd = 68282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad2DBorder.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0005C40C File Offset: 0x0005A60C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68523, RefRangeEnd = 68524, XrefRangeStart = 68517, XrefRangeEnd = 68523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuadShapeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad2DBorder.NativeMethodInfoPtr_OnQuadShapeChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0005C440 File Offset: 0x0005A640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68524, XrefRangeEnd = 68537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad2DBorder.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0005C484 File Offset: 0x0005A684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68537, XrefRangeEnd = 68546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoQuad2DBorder.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00007CA0 File Offset: 0x00005EA0
		public GizmoQuad2DBorder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0005C4C8 File Offset: 0x0005A6C8
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00007CA9 File Offset: 0x00005EA9
		public unsafe GizmoPlaneSlider2D _planeSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__planeSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__planeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0005C4F8 File Offset: 0x0005A6F8
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00007CC8 File Offset: 0x00005EC8
		public unsafe GizmoHandle _targetHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__targetHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__targetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0005C528 File Offset: 0x0005A728
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00007CE7 File Offset: 0x00005EE7
		public unsafe QuadShape2D _targetQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__targetQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__targetQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0005C558 File Offset: 0x0005A758
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00007D06 File Offset: 0x00005F06
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0005C580 File Offset: 0x0005A780
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00007D21 File Offset: 0x00005F21
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0005C5A8 File Offset: 0x0005A7A8
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00007D3C File Offset: 0x00005F3C
		public unsafe int _borderQuadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__borderQuadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__borderQuadIndex)) = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0005C5D0 File Offset: 0x0005A7D0
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x00007D57 File Offset: 0x00005F57
		public unsafe QuadShape2D _borderQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__borderQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__borderQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x0005C600 File Offset: 0x0005A800
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x00007D76 File Offset: 0x00005F76
		public unsafe GizmoQuad2DBorderControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad2DBorderControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0005C630 File Offset: 0x0005A830
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x00007D95 File Offset: 0x00005F95
		public unsafe Il2CppReferenceArray<IGizmoQuad2DBorderController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoQuad2DBorderController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoQuad2DBorder.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeFieldInfoPtr__planeSlider;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeFieldInfoPtr__targetHandle;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeFieldInfoPtr__targetQuad;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeFieldInfoPtr__borderQuadIndex;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr__borderQuad;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider2D_GizmoHandle_QuadShape2D_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_OnQuadShapeChanged_Public_Void_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;
	}
}
