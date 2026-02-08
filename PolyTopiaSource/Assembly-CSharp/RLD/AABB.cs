using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200013E RID: 318
	[StructLayout(2)]
	public struct AABB
	{
		// Token: 0x06001CA8 RID: 7336 RVA: 0x00091780 File Offset: 0x0008F980
		// Note: this type is marked as 'beforefieldinit'.
		static AABB()
		{
			Il2CppClassPointerStore<AABB>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "AABB");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AABB>.NativeClassPtr);
			AABB.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AABB>.NativeClassPtr, "_size");
			AABB.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AABB>.NativeClassPtr, "_center");
			AABB.NativeFieldInfoPtr__isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AABB>.NativeClassPtr, "_isValid");
			AABB.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667610);
			AABB.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667611);
			AABB.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667612);
			AABB.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667613);
			AABB.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667614);
			AABB.NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667615);
			AABB.NativeMethodInfoPtr_get_Min_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667616);
			AABB.NativeMethodInfoPtr_set_Min_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667617);
			AABB.NativeMethodInfoPtr_get_Max_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667618);
			AABB.NativeMethodInfoPtr_set_Max_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667619);
			AABB.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667620);
			AABB.NativeMethodInfoPtr__ctor_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667621);
			AABB.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667622);
			AABB.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667623);
			AABB.NativeMethodInfoPtr_GetInvalid_Public_Static_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667624);
			AABB.NativeMethodInfoPtr_Inflate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667625);
			AABB.NativeMethodInfoPtr_Inflate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667626);
			AABB.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667627);
			AABB.NativeMethodInfoPtr_Encapsulate_Public_Void_IEnumerable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667628);
			AABB.NativeMethodInfoPtr_Encapsulate_Public_Void_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667629);
			AABB.NativeMethodInfoPtr_Transform_Public_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667630);
			AABB.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667631);
			AABB.NativeMethodInfoPtr_GetCornerPoints_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667632);
			AABB.NativeMethodInfoPtr_GetCenterAndCornerPoints_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667633);
			AABB.NativeMethodInfoPtr_GetScreenCornerPoints_Public_List_1_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667634);
			AABB.NativeMethodInfoPtr_GetScreenCenterAndCornerPoints_Public_List_1_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667635);
			AABB.NativeMethodInfoPtr_GetScreenRectangle_Public_Rect_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667636);
			AABB.NativeMethodInfoPtr_GetUnitBoxTransform_Public_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667637);
			AABB.NativeMethodInfoPtr_ToBounds_Public_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667638);
			AABB.NativeMethodInfoPtr_RecalculateCenterAndSize_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AABB>.NativeClassPtr, 100667639);
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00091A44 File Offset: 0x0008FC44
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00091A74 File Offset: 0x0008FC74
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x00091AA8 File Offset: 0x0008FCA8
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00091AE0 File Offset: 0x0008FCE0
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x00091B14 File Offset: 0x0008FD14
		public unsafe Vector3 Size
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00091B4C File Offset: 0x0008FD4C
		public unsafe Vector3 Extents
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 78698, RefRangeEnd = 78702, XrefRangeStart = 78698, XrefRangeEnd = 78698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00091B80 File Offset: 0x0008FD80
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x00091BB4 File Offset: 0x0008FDB4
		public unsafe Vector3 Min
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_get_Min_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78702, RefRangeEnd = 78704, XrefRangeStart = 78702, XrefRangeEnd = 78702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_set_Min_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x00091BEC File Offset: 0x0008FDEC
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x00091C20 File Offset: 0x0008FE20
		public unsafe Vector3 Max
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_get_Max_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78704, RefRangeEnd = 78706, XrefRangeStart = 78704, XrefRangeEnd = 78704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_set_Max_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00091C58 File Offset: 0x0008FE58
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 78706, RefRangeEnd = 78714, XrefRangeStart = 78706, XrefRangeEnd = 78706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AABB(Vector3 center, Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00091CA0 File Offset: 0x0008FEA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78714, RefRangeEnd = 78717, XrefRangeStart = 78714, XrefRangeEnd = 78714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AABB(Bounds bounds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr__ctor_Public_Void_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00091CD8 File Offset: 0x0008FED8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 78734, RefRangeEnd = 78747, XrefRangeStart = 78717, XrefRangeEnd = 78734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AABB(IEnumerable<Vector3> pointCloud)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointCloud);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00091D10 File Offset: 0x0008FF10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78764, RefRangeEnd = 78765, XrefRangeStart = 78747, XrefRangeEnd = 78764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AABB(IEnumerable<Vector2> pointCloud)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointCloud);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00091D48 File Offset: 0x0008FF48
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 78765, RefRangeEnd = 78778, XrefRangeStart = 78765, XrefRangeEnd = 78765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB GetInvalid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_GetInvalid_Public_Static_AABB_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00091D7C File Offset: 0x0008FF7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78778, RefRangeEnd = 78781, XrefRangeStart = 78778, XrefRangeEnd = 78778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Inflate(float amount)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_Inflate_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00091DB0 File Offset: 0x0008FFB0
		[CallerCount(0)]
		public unsafe void Inflate(Vector3 amount)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(amount);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_Inflate_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00091DE8 File Offset: 0x0008FFE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78783, RefRangeEnd = 78786, XrefRangeStart = 78781, XrefRangeEnd = 78783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encapsulate(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00091E20 File Offset: 0x00090020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78804, RefRangeEnd = 78805, XrefRangeStart = 78786, XrefRangeEnd = 78804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encapsulate(IEnumerable<Vector3> points)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_Encapsulate_Public_Void_IEnumerable_1_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00091E58 File Offset: 0x00090058
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 78807, RefRangeEnd = 78813, XrefRangeStart = 78805, XrefRangeEnd = 78807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encapsulate(AABB aabb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aabb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_Encapsulate_Public_Void_AABB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00091E90 File Offset: 0x00090090
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 78817, RefRangeEnd = 78829, XrefRangeStart = 78813, XrefRangeEnd = 78817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Transform(Matrix4x4 transformMatrix)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformMatrix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_Transform_Public_Void_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00091EC8 File Offset: 0x000900C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78835, RefRangeEnd = 78836, XrefRangeStart = 78829, XrefRangeEnd = 78835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPoint(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00091F0C File Offset: 0x0009010C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 78842, RefRangeEnd = 78846, XrefRangeStart = 78836, XrefRangeEnd = 78842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetCornerPoints()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_GetCornerPoints_Public_List_1_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00091F40 File Offset: 0x00090140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78850, RefRangeEnd = 78851, XrefRangeStart = 78846, XrefRangeEnd = 78850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetCenterAndCornerPoints()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_GetCenterAndCornerPoints_Public_List_1_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00091F74 File Offset: 0x00090174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78878, RefRangeEnd = 78879, XrefRangeStart = 78851, XrefRangeEnd = 78878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector2> GetScreenCornerPoints(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_GetScreenCornerPoints_Public_List_1_Vector2_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00091FB8 File Offset: 0x000901B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78906, RefRangeEnd = 78907, XrefRangeStart = 78879, XrefRangeEnd = 78906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector2> GetScreenCenterAndCornerPoints(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_GetScreenCenterAndCornerPoints_Public_List_1_Vector2_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00091FFC File Offset: 0x000901FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78922, RefRangeEnd = 78924, XrefRangeStart = 78907, XrefRangeEnd = 78922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetScreenRectangle(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_GetScreenRectangle_Public_Rect_Camera_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
			}
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x00092040 File Offset: 0x00090240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78927, RefRangeEnd = 78928, XrefRangeStart = 78924, XrefRangeEnd = 78927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetUnitBoxTransform()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_GetUnitBoxTransform_Public_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00092074 File Offset: 0x00090274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78928, RefRangeEnd = 78931, XrefRangeStart = 78928, XrefRangeEnd = 78928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds ToBounds()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_ToBounds_Public_Bounds_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Bounds>(intPtr3) : null;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x000920A8 File Offset: 0x000902A8
		[CallerCount(0)]
		public unsafe void RecalculateCenterAndSize(Vector3 min, Vector3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(min);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(max);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AABB.NativeMethodInfoPtr_RecalculateCenterAndSize_Private_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0000C1E2 File Offset: 0x0000A3E2
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AABB>.NativeClassPtr, ref this));
		}

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeFieldInfoPtr__isValid;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_get_Vector3_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_set_Min_Public_set_Void_Vector3_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_get_Vector3_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_set_Max_Public_set_Void_Vector3_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Bounds_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Vector3_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Vector2_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalid_Public_Static_AABB_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_Inflate_Public_Void_Single_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_Inflate_Public_Void_Vector3_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_IEnumerable_1_Vector3_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_AABB_0;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Void_Matrix4x4_0;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeMethodInfoPtr_GetCornerPoints_Public_List_1_Vector3_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_GetCenterAndCornerPoints_Public_List_1_Vector3_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenCornerPoints_Public_List_1_Vector2_Camera_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenCenterAndCornerPoints_Public_List_1_Vector2_Camera_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenRectangle_Public_Rect_Camera_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitBoxTransform_Public_Matrix4x4_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr_ToBounds_Public_Bounds_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateCenterAndSize_Private_Void_Vector3_Vector3_0;

		// Token: 0x04001600 RID: 5632
		[FieldOffset(0)]
		public IntPtr _size;

		// Token: 0x04001601 RID: 5633
		[FieldOffset(12)]
		public IntPtr _center;

		// Token: 0x04001602 RID: 5634
		[FieldOffset(24)]
		[MarshalAs(4)]
		public bool _isValid;
	}
}
