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
	// Token: 0x02000131 RID: 305
	public static class Vector3Ex : global::Il2CppSystem.Object
	{
		// Token: 0x06001BC5 RID: 7109 RVA: 0x0008DB74 File Offset: 0x0008BD74
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3Ex()
		{
			Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Vector3Ex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr);
			Vector3Ex.NativeMethodInfoPtr_OffsetPoints_Public_Static_Void_List_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667467);
			Vector3Ex.NativeMethodInfoPtr_ConvertDirTo2D_Public_Static_Vector2_Vector3_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667468);
			Vector3Ex.NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667469);
			Vector3Ex.NativeMethodInfoPtr_GetSignVector_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667470);
			Vector3Ex.NativeMethodInfoPtr_GetMaxAbsComp_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667471);
			Vector3Ex.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667472);
			Vector3Ex.NativeMethodInfoPtr_AbsDot_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667473);
			Vector3Ex.NativeMethodInfoPtr_FromValue_Public_Static_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667474);
			Vector3Ex.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667475);
			Vector3Ex.NativeMethodInfoPtr_GetDistanceToSegment_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667476);
			Vector3Ex.NativeMethodInfoPtr_ProjectOnSegment_Public_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667477);
			Vector3Ex.NativeMethodInfoPtr_GetPointClosestToPoint_Public_Static_Int32_List_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667478);
			Vector3Ex.NativeMethodInfoPtr_GetPointCloudCenter_Public_Static_Vector3_IEnumerable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667479);
			Vector3Ex.NativeMethodInfoPtr_GetInverse_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667480);
			Vector3Ex.NativeMethodInfoPtr_IsAligned_Public_Static_Boolean_Vector3_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667481);
			Vector3Ex.NativeMethodInfoPtr_PointsSameDir_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667482);
			Vector3Ex.NativeMethodInfoPtr_GetMostAligned_Public_Static_Int32_Il2CppStructArray_1_Vector3_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Ex>.NativeClassPtr, 100667483);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0008DCF8 File Offset: 0x0008BEF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77993, RefRangeEnd = 77996, XrefRangeStart = 77985, XrefRangeEnd = 77993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OffsetPoints(List<Vector3> points, Vector3 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_OffsetPoints_Public_Static_Void_List_1_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0008DD40 File Offset: 0x0008BF40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77998, RefRangeEnd = 78002, XrefRangeStart = 77996, XrefRangeEnd = 77998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ConvertDirTo2D(Vector3 start, Vector3 end, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_ConvertDirTo2D_Public_Static_Vector2_Vector3_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0008DDA8 File Offset: 0x0008BFA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 78002, RefRangeEnd = 78007, XrefRangeStart = 78002, XrefRangeEnd = 78002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Abs(this Vector3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0008DDEC File Offset: 0x0008BFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78007, XrefRangeEnd = 78009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetSignVector(this Vector3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_GetSignVector_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0008DE30 File Offset: 0x0008C030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78009, RefRangeEnd = 78011, XrefRangeStart = 78009, XrefRangeEnd = 78009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMaxAbsComp(this Vector3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_GetMaxAbsComp_Public_Static_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0008DE74 File Offset: 0x0008C074
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 78011, RefRangeEnd = 78018, XrefRangeStart = 78011, XrefRangeEnd = 78011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Dot(this Vector3 v1, Vector3 v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0008DEC8 File Offset: 0x0008C0C8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 78018, RefRangeEnd = 78030, XrefRangeStart = 78018, XrefRangeEnd = 78018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float AbsDot(this Vector3 v1, Vector3 v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_AbsDot_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0008DF1C File Offset: 0x0008C11C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 78030, RefRangeEnd = 78057, XrefRangeStart = 78030, XrefRangeEnd = 78030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 FromValue(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_FromValue_Public_Static_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0008DF5C File Offset: 0x0008C15C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 78072, RefRangeEnd = 78079, XrefRangeStart = 78057, XrefRangeEnd = 78072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0008DFC4 File Offset: 0x0008C1C4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 78084, RefRangeEnd = 78101, XrefRangeStart = 78079, XrefRangeEnd = 78084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetDistanceToSegment(this Vector3 point, Vector3 point0, Vector3 point1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_GetDistanceToSegment_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0008E02C File Offset: 0x0008C22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78105, RefRangeEnd = 78106, XrefRangeStart = 78101, XrefRangeEnd = 78105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ProjectOnSegment(this Vector3 point, Vector3 point0, Vector3 point1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_ProjectOnSegment_Public_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0008E094 File Offset: 0x0008C294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78111, RefRangeEnd = 78113, XrefRangeStart = 78106, XrefRangeEnd = 78111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPointClosestToPoint(List<Vector3> points, Vector3 pt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_GetPointClosestToPoint_Public_Static_Int32_List_1_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0008E0E8 File Offset: 0x0008C2E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78130, RefRangeEnd = 78132, XrefRangeStart = 78113, XrefRangeEnd = 78130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointCloudCenter(IEnumerable<Vector3> ptCloud)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ptCloud);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_GetPointCloudCenter_Public_Static_Vector3_IEnumerable_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0008E12C File Offset: 0x0008C32C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 78132, RefRangeEnd = 78136, XrefRangeStart = 78132, XrefRangeEnd = 78132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetInverse(this Vector3 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_GetInverse_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0008E170 File Offset: 0x0008C370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78136, RefRangeEnd = 78137, XrefRangeStart = 78136, XrefRangeEnd = 78136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAligned(this Vector3 vector, Vector3 other, bool checkSameDirection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkSameDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_IsAligned_Public_Static_Boolean_Vector3_Vector3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0008E1D4 File Offset: 0x0008C3D4
		[CallerCount(0)]
		public unsafe static bool PointsSameDir(this Vector3 vector, Vector3 other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_PointsSameDir_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0008E228 File Offset: 0x0008C428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78137, XrefRangeEnd = 78139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMostAligned(Il2CppStructArray<Vector3> vectors, Vector3 dir, bool checkSameDirection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vectors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dir);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkSameDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Ex.NativeMethodInfoPtr_GetMostAligned_Public_Static_Int32_Il2CppStructArray_1_Vector3_Vector3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0000BDA6 File Offset: 0x00009FA6
		public Vector3Ex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_OffsetPoints_Public_Static_Void_List_1_Vector3_Vector3_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_ConvertDirTo2D_Public_Static_Vector2_Vector3_Vector3_Camera_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_GetSignVector_Public_Static_Vector3_Vector3_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxAbsComp_Public_Static_Single_Vector3_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_AbsDot_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_FromValue_Public_Static_Vector3_Single_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceToSegment_Public_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_ProjectOnSegment_Public_Static_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_GetPointClosestToPoint_Public_Static_Int32_List_1_Vector3_Vector3_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_GetPointCloudCenter_Public_Static_Vector3_IEnumerable_1_Vector3_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_GetInverse_Public_Static_Vector3_Vector3_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_IsAligned_Public_Static_Boolean_Vector3_Vector3_Boolean_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_PointsSameDir_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_GetMostAligned_Public_Static_Int32_Il2CppStructArray_1_Vector3_Vector3_Boolean_0;
	}
}
