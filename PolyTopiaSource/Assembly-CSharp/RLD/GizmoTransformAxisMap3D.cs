using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000035 RID: 53
	public class GizmoTransformAxisMap3D : global::Il2CppSystem.Object
	{
		// Token: 0x06000335 RID: 821 RVA: 0x0002DBC0 File Offset: 0x0002BDC0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoTransformAxisMap3D()
		{
			Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoTransformAxisMap3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr);
			GizmoTransformAxisMap3D.NativeFieldInfoPtr__freeAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, "_freeAxis");
			GizmoTransformAxisMap3D.NativeFieldInfoPtr__mappedAxisDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, "_mappedAxisDesc");
			GizmoTransformAxisMap3D.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, "_transform");
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_MappedAxisDesc_Public_get_AxisDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663783);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_MappedAxisIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663784);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_MappedAxisSign_Public_get_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663785);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_IsMapped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663786);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_Axis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663787);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663788);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663794);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_Map_Public_Void_GizmoTransform_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663789);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_Unmap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663790);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_SetAxis_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663791);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_SetMappedAxis_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663792);
			GizmoTransformAxisMap3D.NativeMethodInfoPtr_SetFreeAxis_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr, 100663793);
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0002DD1C File Offset: 0x0002BF1C
		public unsafe AxisDescriptor MappedAxisDesc
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_MappedAxisDesc_Public_get_AxisDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0002DD5C File Offset: 0x0002BF5C
		public unsafe int MappedAxisIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_MappedAxisIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0002DD98 File Offset: 0x0002BF98
		public unsafe AxisSign MappedAxisSign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_MappedAxisSign_Public_get_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr3) : null;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0002DDD8 File Offset: 0x0002BFD8
		public unsafe bool IsMapped
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 58825, RefRangeEnd = 58826, XrefRangeStart = 58825, XrefRangeEnd = 58825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_IsMapped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0002DE14 File Offset: 0x0002C014
		public unsafe Vector3 Axis
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 58826, RefRangeEnd = 58834, XrefRangeStart = 58826, XrefRangeEnd = 58826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_Axis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0002DE54 File Offset: 0x0002C054
		public unsafe GizmoTransform Transform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0002DE94 File Offset: 0x0002C094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58842, RefRangeEnd = 58844, XrefRangeStart = 58834, XrefRangeEnd = 58842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoTransformAxisMap3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoTransformAxisMap3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 58850, RefRangeEnd = 58853, XrefRangeStart = 58844, XrefRangeEnd = 58850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_Map_Public_Void_GizmoTransform_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0002DF34 File Offset: 0x0002C134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58854, RefRangeEnd = 58856, XrefRangeStart = 58853, XrefRangeEnd = 58854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unmap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_Unmap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0002DF68 File Offset: 0x0002C168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58858, RefRangeEnd = 58860, XrefRangeStart = 58856, XrefRangeEnd = 58858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxis(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_SetAxis_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0002DFAC File Offset: 0x0002C1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58860, XrefRangeEnd = 58864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMappedAxis(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_SetMappedAxis_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58864, XrefRangeEnd = 58866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFreeAxis(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransformAxisMap3D.NativeMethodInfoPtr_SetFreeAxis_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000031AB File Offset: 0x000013AB
		public GizmoTransformAxisMap3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0002E034 File Offset: 0x0002C234
		// (set) Token: 0x06000344 RID: 836 RVA: 0x000031B4 File Offset: 0x000013B4
		public unsafe Vector3 _freeAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap3D.NativeFieldInfoPtr__freeAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap3D.NativeFieldInfoPtr__freeAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0002E064 File Offset: 0x0002C264
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000031D3 File Offset: 0x000013D3
		public unsafe AxisDescriptor _mappedAxisDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap3D.NativeFieldInfoPtr__mappedAxisDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap3D.NativeFieldInfoPtr__mappedAxisDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0002E094 File Offset: 0x0002C294
		// (set) Token: 0x06000348 RID: 840 RVA: 0x000031F2 File Offset: 0x000013F2
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap3D.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransformAxisMap3D.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr__freeAxis;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr__mappedAxisDesc;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedAxisDesc_Public_get_AxisDescriptor_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedAxisIndex_Public_get_Int32_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedAxisSign_Public_get_AxisSign_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMapped_Public_get_Boolean_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_get_Axis_Public_get_Vector3_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_Map_Public_Void_GizmoTransform_Int32_AxisSign_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_Unmap_Public_Void_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_SetAxis_Public_Void_Vector3_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_SetMappedAxis_Public_Void_Vector3_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_SetFreeAxis_Public_Void_Vector3_0;
	}
}
