using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000151 RID: 337
	public static class CircleMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001D5E RID: 7518 RVA: 0x000950E8 File Offset: 0x000932E8
		// Note: this type is marked as 'beforefieldinit'.
		static CircleMath()
		{
			Il2CppClassPointerStore<CircleMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CircleMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleMath>.NativeClassPtr);
			CircleMath.NativeMethodInfoPtr_Calc3DExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleMath>.NativeClassPtr, 100667747);
			CircleMath.NativeMethodInfoPtr_Calc2DExtentPoints_Public_Static_List_1_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleMath>.NativeClassPtr, 100667748);
			CircleMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Vector3_CircleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleMath>.NativeClassPtr, 100667749);
			CircleMath.NativeMethodInfoPtr_RaycastWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Vector3_CircleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleMath>.NativeClassPtr, 100667750);
			CircleMath.NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Single_Vector3_CircleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleMath>.NativeClassPtr, 100667751);
			CircleMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Single_CircleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleMath>.NativeClassPtr, 100667752);
			CircleMath.NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_Vector2_Single_CircleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleMath>.NativeClassPtr, 100667753);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000951A4 File Offset: 0x000933A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79869, RefRangeEnd = 79871, XrefRangeStart = 79844, XrefRangeEnd = 79869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> Calc3DExtentPoints(Vector3 circleCenter, float circleRadius, Quaternion circleRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleMath.NativeMethodInfoPtr_Calc3DExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00095208 File Offset: 0x00093408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79895, RefRangeEnd = 79897, XrefRangeStart = 79871, XrefRangeEnd = 79895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> Calc2DExtentPoints(Vector2 circleCenter, float circleRadius, float degreeCircleRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreeCircleRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleMath.NativeMethodInfoPtr_Calc2DExtentPoints_Public_Static_List_1_Vector2_Vector2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00095268 File Offset: 0x00093468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79906, RefRangeEnd = 79907, XrefRangeStart = 79897, XrefRangeEnd = 79906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Vector3_CircleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00095300 File Offset: 0x00093500
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79916, RefRangeEnd = 79918, XrefRangeStart = 79907, XrefRangeEnd = 79916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastWire(Ray ray, out float t, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleMath.NativeMethodInfoPtr_RaycastWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Vector3_CircleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00095398 File Offset: 0x00093598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79924, RefRangeEnd = 79925, XrefRangeStart = 79918, XrefRangeEnd = 79924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleMath.NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Single_Vector3_CircleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00095430 File Offset: 0x00093630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79925, XrefRangeEnd = 79930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains2DPoint(Vector2 point, Vector2 circleCenter, float circleRadius, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Single_CircleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x000954A4 File Offset: 0x000936A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79936, RefRangeEnd = 79937, XrefRangeStart = 79930, XrefRangeEnd = 79936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is2DPointOnBorder(Vector2 point, Vector2 circleCenter, float circleRadius, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleMath.NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_Vector2_Single_CircleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x0000C3E9 File Offset: 0x0000A5E9
		public CircleMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_Calc3DExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_Calc2DExtentPoints_Public_Static_List_1_Vector2_Vector2_Single_Single_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Vector3_CircleEpsilon_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Vector3_CircleEpsilon_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Single_Vector3_CircleEpsilon_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Single_CircleEpsilon_0;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_Vector2_Single_CircleEpsilon_0;
	}
}
