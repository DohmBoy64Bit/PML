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
	// Token: 0x02000143 RID: 323
	[StructLayout(2)]
	public struct OBB
	{
		// Token: 0x06001CD9 RID: 7385 RVA: 0x00092508 File Offset: 0x00090708
		// Note: this type is marked as 'beforefieldinit'.
		static OBB()
		{
			Il2CppClassPointerStore<OBB>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "OBB");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OBB>.NativeClassPtr);
			OBB.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBB>.NativeClassPtr, "_size");
			OBB.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBB>.NativeClassPtr, "_center");
			OBB.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBB>.NativeClassPtr, "_rotation");
			OBB.NativeFieldInfoPtr__isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBB>.NativeClassPtr, "_isValid");
			OBB.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667649);
			OBB.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667650);
			OBB.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667651);
			OBB.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667652);
			OBB.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667653);
			OBB.NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667654);
			OBB.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667655);
			OBB.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667656);
			OBB.NativeMethodInfoPtr_get_RotationMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667657);
			OBB.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667658);
			OBB.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667659);
			OBB.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667660);
			OBB.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667661);
			OBB.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667662);
			OBB.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667663);
			OBB.NativeMethodInfoPtr__ctor_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667664);
			OBB.NativeMethodInfoPtr__ctor_Public_Void_Bounds_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667665);
			OBB.NativeMethodInfoPtr__ctor_Public_Void_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667666);
			OBB.NativeMethodInfoPtr__ctor_Public_Void_AABB_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667667);
			OBB.NativeMethodInfoPtr__ctor_Public_Void_AABB_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667668);
			OBB.NativeMethodInfoPtr__ctor_Public_Void_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667669);
			OBB.NativeMethodInfoPtr_GetInvalid_Public_Static_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667670);
			OBB.NativeMethodInfoPtr_Inflate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667671);
			OBB.NativeMethodInfoPtr_GetUnitBoxTransform_Public_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667672);
			OBB.NativeMethodInfoPtr_GetCornerPoints_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667673);
			OBB.NativeMethodInfoPtr_GetCenterAndCornerPoints_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667674);
			OBB.NativeMethodInfoPtr_Encapsulate_Public_Void_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667675);
			OBB.NativeMethodInfoPtr_GetPointFaceNormal_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667676);
			OBB.NativeMethodInfoPtr_IntersectsOBB_Public_Boolean_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667677);
			OBB.NativeMethodInfoPtr_GetClosestPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667678);
			OBB.NativeMethodInfoPtr_IntersectsSphere_Public_Boolean_Sphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBB>.NativeClassPtr, 100667679);
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000927F4 File Offset: 0x000909F4
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00092824 File Offset: 0x00090A24
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x00092858 File Offset: 0x00090A58
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x00092890 File Offset: 0x00090A90
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x000928C4 File Offset: 0x00090AC4
		public unsafe Vector3 Size
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x000928FC File Offset: 0x00090AFC
		public unsafe Vector3 Extents
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 78698, RefRangeEnd = 78702, XrefRangeStart = 78698, XrefRangeEnd = 78702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00092930 File Offset: 0x00090B30
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x00092964 File Offset: 0x00090B64
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0009299C File Offset: 0x00090B9C
		public unsafe Matrix4x4 RotationMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78959, XrefRangeEnd = 78964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_get_RotationMatrix_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x000929D0 File Offset: 0x00090BD0
		public unsafe Vector3 Right
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78967, RefRangeEnd = 78969, XrefRangeStart = 78964, XrefRangeEnd = 78967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00092A04 File Offset: 0x00090C04
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78969, XrefRangeEnd = 78972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x00092A38 File Offset: 0x00090C38
		public unsafe Vector3 Look
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78975, RefRangeEnd = 78977, XrefRangeStart = 78972, XrefRangeEnd = 78975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00092A6C File Offset: 0x00090C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78979, RefRangeEnd = 78980, XrefRangeStart = 78977, XrefRangeEnd = 78979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB(Vector3 center, Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00092AB4 File Offset: 0x00090CB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 78980, RefRangeEnd = 78987, XrefRangeStart = 78980, XrefRangeEnd = 78980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB(Vector3 center, Vector3 size, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00092B10 File Offset: 0x00090D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78987, XrefRangeEnd = 78989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB(Vector3 center, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00092B58 File Offset: 0x00090D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78993, RefRangeEnd = 78994, XrefRangeStart = 78989, XrefRangeEnd = 78993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB(Quaternion rotation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr__ctor_Public_Void_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00092B90 File Offset: 0x00090D90
		[CallerCount(0)]
		public unsafe OBB(Bounds bounds, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr__ctor_Public_Void_Bounds_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00092BD8 File Offset: 0x00090DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78996, RefRangeEnd = 78999, XrefRangeStart = 78994, XrefRangeEnd = 78996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB(AABB aabb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aabb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr__ctor_Public_Void_AABB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00092C10 File Offset: 0x00090E10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78999, RefRangeEnd = 79001, XrefRangeStart = 78999, XrefRangeEnd = 78999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB(AABB aabb, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aabb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr__ctor_Public_Void_AABB_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00092C58 File Offset: 0x00090E58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 79004, RefRangeEnd = 79011, XrefRangeStart = 79001, XrefRangeEnd = 79004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB(AABB modelSpaceAABB, Transform worldTransform)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modelSpaceAABB);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr__ctor_Public_Void_AABB_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00092CA0 File Offset: 0x00090EA0
		[CallerCount(0)]
		public unsafe OBB(OBB copy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(copy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr__ctor_Public_Void_OBB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00092CD8 File Offset: 0x00090ED8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 79011, RefRangeEnd = 79016, XrefRangeStart = 79011, XrefRangeEnd = 79011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OBB GetInvalid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_GetInvalid_Public_Static_OBB_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00092D0C File Offset: 0x00090F0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78778, RefRangeEnd = 78781, XrefRangeStart = 78778, XrefRangeEnd = 78781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Inflate(float amount)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_Inflate_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00092D40 File Offset: 0x00090F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79020, RefRangeEnd = 79021, XrefRangeStart = 79016, XrefRangeEnd = 79020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetUnitBoxTransform()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_GetUnitBoxTransform_Public_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00092D74 File Offset: 0x00090F74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79025, RefRangeEnd = 79028, XrefRangeStart = 79021, XrefRangeEnd = 79025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetCornerPoints()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_GetCornerPoints_Public_List_1_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00092DA8 File Offset: 0x00090FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79032, RefRangeEnd = 79034, XrefRangeStart = 79028, XrefRangeEnd = 79032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetCenterAndCornerPoints()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_GetCenterAndCornerPoints_Public_List_1_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00092DDC File Offset: 0x00090FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79047, RefRangeEnd = 79048, XrefRangeStart = 79034, XrefRangeEnd = 79047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encapsulate(OBB otherOBB)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherOBB);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_Encapsulate_Public_Void_OBB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00092E14 File Offset: 0x00091014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79048, XrefRangeEnd = 79063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPointFaceNormal(Vector3 pointOnFace)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointOnFace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_GetPointFaceNormal_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00092E58 File Offset: 0x00091058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79067, RefRangeEnd = 79068, XrefRangeStart = 79063, XrefRangeEnd = 79067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IntersectsOBB(OBB otherOBB)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherOBB);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_IntersectsOBB_Public_Boolean_OBB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00092E9C File Offset: 0x0009109C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79072, RefRangeEnd = 79073, XrefRangeStart = 79068, XrefRangeEnd = 79072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetClosestPoint(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_GetClosestPoint_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00092EE0 File Offset: 0x000910E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79073, XrefRangeEnd = 79075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IntersectsSphere(Sphere sphere)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sphere);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OBB.NativeMethodInfoPtr_IntersectsSphere_Public_Boolean_Sphere_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0000C240 File Offset: 0x0000A440
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OBB>.NativeClassPtr, ref this));
		}

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeFieldInfoPtr__isValid;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Quaternion_0;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Quaternion_0;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Bounds_Quaternion_0;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AABB_0;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AABB_Quaternion_0;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AABB_Transform_0;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_OBB_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalid_Public_Static_OBB_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_Inflate_Public_Void_Single_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitBoxTransform_Public_Matrix4x4_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr_GetCornerPoints_Public_List_1_Vector3_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_GetCenterAndCornerPoints_Public_List_1_Vector3_0;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_OBB_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_GetPointFaceNormal_Public_Vector3_Vector3_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_IntersectsOBB_Public_Boolean_OBB_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPoint_Public_Vector3_Vector3_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_IntersectsSphere_Public_Boolean_Sphere_0;

		// Token: 0x04001638 RID: 5688
		[FieldOffset(0)]
		public IntPtr _size;

		// Token: 0x04001639 RID: 5689
		[FieldOffset(12)]
		public IntPtr _center;

		// Token: 0x0400163A RID: 5690
		[FieldOffset(24)]
		public IntPtr _rotation;

		// Token: 0x0400163B RID: 5691
		[FieldOffset(40)]
		[MarshalAs(4)]
		public bool _isValid;
	}
}
