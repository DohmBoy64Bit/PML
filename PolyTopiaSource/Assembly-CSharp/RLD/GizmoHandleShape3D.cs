using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000064 RID: 100
	public class GizmoHandleShape3D : Object
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x0003BDE8 File Offset: 0x00039FE8
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoHandleShape3D()
		{
			Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoHandleShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr);
			GizmoHandleShape3D.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr, "_isVisible");
			GizmoHandleShape3D.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr, "_isHoverable");
			GizmoHandleShape3D.NativeFieldInfoPtr__shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr, "_shape");
			GizmoHandleShape3D.NativeMethodInfoPtr_get_Shape_Public_get_Shape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr, 100664324);
			GizmoHandleShape3D.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr, 100664325);
			GizmoHandleShape3D.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr, 100664326);
			GizmoHandleShape3D.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr, 100664327);
			GizmoHandleShape3D.NativeMethodInfoPtr_set_IsHoverable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr, 100664328);
			GizmoHandleShape3D.NativeMethodInfoPtr__ctor_Public_Void_Shape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr, 100664329);
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0003BECC File Offset: 0x0003A0CC
		public unsafe Shape3D Shape
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape3D.NativeMethodInfoPtr_get_Shape_Public_get_Shape3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0003BF0C File Offset: 0x0003A10C
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0003BF48 File Offset: 0x0003A148
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape3D.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape3D.NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0003BF88 File Offset: 0x0003A188
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0003BFC4 File Offset: 0x0003A1C4
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape3D.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape3D.NativeMethodInfoPtr_set_IsHoverable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0003C004 File Offset: 0x0003A204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoHandleShape3D(Shape3D shape)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandleShape3D>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandleShape3D.NativeMethodInfoPtr__ctor_Public_Void_Shape3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000046E2 File Offset: 0x000028E2
		public GizmoHandleShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0003C050 File Offset: 0x0003A250
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000046EB File Offset: 0x000028EB
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape3D.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape3D.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0003C078 File Offset: 0x0003A278
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00004706 File Offset: 0x00002906
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape3D.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape3D.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0003C0A0 File Offset: 0x0003A2A0
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00004721 File Offset: 0x00002921
		public unsafe Shape3D _shape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape3D.NativeFieldInfoPtr__shape);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandleShape3D.NativeFieldInfoPtr__shape), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr__shape;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_get_Shape_Public_get_Shape3D_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Public_set_Void_Boolean_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHoverable_Public_set_Void_Boolean_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shape3D_0;
	}
}
