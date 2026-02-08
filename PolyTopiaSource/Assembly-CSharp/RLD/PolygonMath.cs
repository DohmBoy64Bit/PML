using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000157 RID: 343
	public static class PolygonMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001D78 RID: 7544 RVA: 0x00095C58 File Offset: 0x00093E58
		// Note: this type is marked as 'beforefieldinit'.
		static PolygonMath()
		{
			Il2CppClassPointerStore<PolygonMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PolygonMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonMath>.NativeClassPtr);
			PolygonMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_List_1_Vector3_Boolean_Vector3_PolygonEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonMath>.NativeClassPtr, 100667765);
			PolygonMath.NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_List_1_Vector3_Boolean_Vector3_PolygonEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonMath>.NativeClassPtr, 100667766);
			PolygonMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_List_1_Vector2_Boolean_PolygonEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonMath>.NativeClassPtr, 100667767);
			PolygonMath.NativeMethodInfoPtr_Is3DPointOnBorder_Public_Static_Boolean_Vector3_Boolean_List_1_Vector3_Boolean_Vector3_PolygonEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonMath>.NativeClassPtr, 100667768);
			PolygonMath.NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_List_1_Vector2_Boolean_PolygonEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonMath>.NativeClassPtr, 100667769);
			PolygonMath.NativeMethodInfoPtr_Is2DPointOnThickBorder_Public_Static_Boolean_Vector2_List_1_Vector2_List_1_Vector2_Boolean_PolygonEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonMath>.NativeClassPtr, 100667770);
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00095D00 File Offset: 0x00093F00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80092, RefRangeEnd = 80095, XrefRangeStart = 80083, XrefRangeEnd = 80092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cwPolyPoints);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(polyNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_List_1_Vector3_Boolean_Vector3_PolygonEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00095D98 File Offset: 0x00093F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80123, RefRangeEnd = 80124, XrefRangeStart = 80095, XrefRangeEnd = 80123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains3DPoint(Vector3 point, bool checkOnPlane, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cwPolyPoints);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(polyNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonMath.NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_List_1_Vector3_Boolean_Vector3_PolygonEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00095E30 File Offset: 0x00094030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80142, RefRangeEnd = 80143, XrefRangeStart = 80124, XrefRangeEnd = 80142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains2DPoint(Vector2 point, List<Vector2> polyPoints, bool isClosed, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_List_1_Vector2_Boolean_PolygonEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00095EA4 File Offset: 0x000940A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80143, XrefRangeEnd = 80149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is3DPointOnBorder(Vector3 point, bool checkOnPlane, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cwPolyPoints);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(polyNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonMath.NativeMethodInfoPtr_Is3DPointOnBorder_Public_Static_Boolean_Vector3_Boolean_List_1_Vector3_Boolean_Vector3_PolygonEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00095F3C File Offset: 0x0009413C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80149, XrefRangeEnd = 80163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is2DPointOnBorder(Vector2 point, List<Vector2> polyPoints, bool isClosed, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonMath.NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_List_1_Vector2_Boolean_PolygonEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x00095FB0 File Offset: 0x000941B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80195, RefRangeEnd = 80196, XrefRangeStart = 80163, XrefRangeEnd = 80195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is2DPointOnThickBorder(Vector2 point, List<Vector2> polyPoints, List<Vector2> thickBorderPoints, bool isClosed, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thickBorderPoints);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonMath.NativeMethodInfoPtr_Is2DPointOnThickBorder_Public_Static_Boolean_Vector2_List_1_Vector2_List_1_Vector2_Boolean_PolygonEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0000C446 File Offset: 0x0000A646
		public PolygonMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_List_1_Vector3_Boolean_Vector3_PolygonEpsilon_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_List_1_Vector3_Boolean_Vector3_PolygonEpsilon_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_List_1_Vector2_Boolean_PolygonEpsilon_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_Is3DPointOnBorder_Public_Static_Boolean_Vector3_Boolean_List_1_Vector3_Boolean_Vector3_PolygonEpsilon_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_List_1_Vector2_Boolean_PolygonEpsilon_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_Is2DPointOnThickBorder_Public_Static_Boolean_Vector2_List_1_Vector2_List_1_Vector2_Boolean_PolygonEpsilon_0;
	}
}
