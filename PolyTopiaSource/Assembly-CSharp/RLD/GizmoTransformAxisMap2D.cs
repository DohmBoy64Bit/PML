using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000034 RID: 52
	public class GizmoTransformAxisMap2D : global::Il2CppSystem.Object
	{
		// Token: 0x06000321 RID: 801 RVA: 0x0002D6BC File Offset: 0x0002B8BC
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoTransformAxisMap2D()
		{
			Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoTransformAxisMap2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr);
			GizmoTransformAxisMap2D.NativeFieldInfoPtr__freeAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, "_freeAxis");
			GizmoTransformAxisMap2D.NativeFieldInfoPtr__mappedAxisDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, "_mappedAxisDesc");
			GizmoTransformAxisMap2D.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, "_transform");
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_MappedAxisDesc_Public_get_AxisDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663771);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_MappedAxisIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663772);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_MappedAxisSign_Public_get_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663773);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_IsMapped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663774);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_Axis_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663775);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663776);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663782);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_Map_Public_Void_GizmoTransform_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663777);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_Unmap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663778);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_SetAxis_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663779);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_SetMappedAxis_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663780);
			GizmoTransformAxisMap2D.NativeMethodInfoPtr_SetFreeAxis_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr, 100663781);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0002D818 File Offset: 0x0002BA18
		public unsafe AxisDescriptor MappedAxisDesc
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_MappedAxisDesc_Public_get_AxisDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0002D858 File Offset: 0x0002BA58
		public unsafe int MappedAxisIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_MappedAxisIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0002D894 File Offset: 0x0002BA94
		public unsafe AxisSign MappedAxisSign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_MappedAxisSign_Public_get_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr3) : null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0002D8D4 File Offset: 0x0002BAD4
		public unsafe bool IsMapped
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 58783, RefRangeEnd = 58797, XrefRangeStart = 58783, XrefRangeEnd = 58783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_IsMapped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0002D910 File Offset: 0x0002BB10
		public unsafe Vector2 Axis
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 58797, RefRangeEnd = 58801, XrefRangeStart = 58797, XrefRangeEnd = 58797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_Axis_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0002D950 File Offset: 0x0002BB50
		public unsafe GizmoTransform Transform
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0002D990 File Offset: 0x0002BB90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58809, RefRangeEnd = 58810, XrefRangeStart = 58801, XrefRangeEnd = 58809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoTransformAxisMap2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoTransformAxisMap2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0002D9CC File Offset: 0x0002BBCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58816, RefRangeEnd = 58817, XrefRangeStart = 58810, XrefRangeEnd = 58816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_Map_Public_Void_GizmoTransform_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0002DA30 File Offset: 0x0002BC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58817, XrefRangeEnd = 58818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unmap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_Unmap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0002DA64 File Offset: 0x0002BC64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58819, RefRangeEnd = 58820, XrefRangeStart = 58818, XrefRangeEnd = 58819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxis(Vector2 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_SetAxis_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0002DAA8 File Offset: 0x0002BCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58820, XrefRangeEnd = 58824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMappedAxis(Vector2 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_SetMappedAxis_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0002DAEC File Offset: 0x0002BCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58824, XrefRangeEnd = 58825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFreeAxis(Vector2 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap2D.NativeMethodInfoPtr_SetFreeAxis_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00003145 File Offset: 0x00001345
		public GizmoTransformAxisMap2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0002DB30 File Offset: 0x0002BD30
		// (set) Token: 0x06000330 RID: 816 RVA: 0x0000314E File Offset: 0x0000134E
		public unsafe Vector2 _freeAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap2D.NativeFieldInfoPtr__freeAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap2D.NativeFieldInfoPtr__freeAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0002DB60 File Offset: 0x0002BD60
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0000316D File Offset: 0x0000136D
		public unsafe AxisDescriptor _mappedAxisDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap2D.NativeFieldInfoPtr__mappedAxisDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap2D.NativeFieldInfoPtr__mappedAxisDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0002DB90 File Offset: 0x0002BD90
		// (set) Token: 0x06000334 RID: 820 RVA: 0x0000318C File Offset: 0x0000138C
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap2D.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap2D.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr__freeAxis;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr__mappedAxisDesc;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedAxisDesc_Public_get_AxisDescriptor_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedAxisIndex_Public_get_Int32_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedAxisSign_Public_get_AxisSign_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMapped_Public_get_Boolean_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_get_Axis_Public_get_Vector2_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_Map_Public_Void_GizmoTransform_Int32_AxisSign_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_Unmap_Public_Void_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_SetAxis_Public_Void_Vector2_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_SetMappedAxis_Public_Void_Vector2_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_SetFreeAxis_Public_Void_Vector2_0;
	}
}
