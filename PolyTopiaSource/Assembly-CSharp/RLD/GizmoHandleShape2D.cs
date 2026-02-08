using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000063 RID: 99
	public class GizmoHandleShape2D : Object
	{
		// Token: 0x060006EC RID: 1772 RVA: 0x0003BB00 File Offset: 0x00039D00
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoHandleShape2D()
		{
			Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoHandleShape2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr);
			GizmoHandleShape2D.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr, "_isVisible");
			GizmoHandleShape2D.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr, "_isHoverable");
			GizmoHandleShape2D.NativeFieldInfoPtr__shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr, "_shape");
			GizmoHandleShape2D.NativeMethodInfoPtr_get_Shape_Public_get_Shape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr, 100664318);
			GizmoHandleShape2D.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr, 100664319);
			GizmoHandleShape2D.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr, 100664320);
			GizmoHandleShape2D.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr, 100664321);
			GizmoHandleShape2D.NativeMethodInfoPtr_set_IsHoverable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr, 100664322);
			GizmoHandleShape2D.NativeMethodInfoPtr__ctor_Public_Void_Shape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr, 100664323);
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0003BBE4 File Offset: 0x00039DE4
		public unsafe Shape2D Shape
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape2D.NativeMethodInfoPtr_get_Shape_Public_get_Shape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0003BC24 File Offset: 0x00039E24
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0003BC60 File Offset: 0x00039E60
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape2D.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20587, RefRangeEnd = 20588, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape2D.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0003BCA0 File Offset: 0x00039EA0
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x0003BCDC File Offset: 0x00039EDC
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape2D.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape2D.NativeMethodInfoPtr_set_IsHoverable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0003BD1C File Offset: 0x00039F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61623, XrefRangeEnd = 61625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoHandleShape2D(Shape2D shape)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandleShape2D>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape2D.NativeMethodInfoPtr__ctor_Public_Void_Shape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00004684 File Offset: 0x00002884
		public GizmoHandleShape2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0003BD68 File Offset: 0x00039F68
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0000468D File Offset: 0x0000288D
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape2D.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape2D.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0003BD90 File Offset: 0x00039F90
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x000046A8 File Offset: 0x000028A8
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape2D.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape2D.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0003BDB8 File Offset: 0x00039FB8
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x000046C3 File Offset: 0x000028C3
		public unsafe Shape2D _shape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape2D.NativeFieldInfoPtr__shape);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape2D.NativeFieldInfoPtr__shape), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr__shape;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_get_Shape_Public_get_Shape2D_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHoverable_Public_set_Void_Boolean_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shape2D_0;
	}
}
