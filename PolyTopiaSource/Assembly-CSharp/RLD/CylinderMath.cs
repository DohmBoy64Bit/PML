using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000155 RID: 341
	public static class CylinderMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001D6C RID: 7532 RVA: 0x00095724 File Offset: 0x00093924
		// Note: this type is marked as 'beforefieldinit'.
		static CylinderMath()
		{
			Il2CppClassPointerStore<CylinderMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CylinderMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CylinderMath>.NativeClassPtr);
			CylinderMath.NativeMethodInfoPtr_CalcExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderMath>.NativeClassPtr, 100667757);
			CylinderMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_CylinderEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderMath>.NativeClassPtr, 100667758);
			CylinderMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_Single_CylinderEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderMath>.NativeClassPtr, 100667759);
			CylinderMath.NativeMethodInfoPtr_RaycastNoCaps_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_CylinderEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderMath>.NativeClassPtr, 100667760);
			CylinderMath.NativeMethodInfoPtr_RaycastNoCaps_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_Single_CylinderEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderMath>.NativeClassPtr, 100667761);
			CylinderMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Vector3_Single_CylinderEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderMath>.NativeClassPtr, 100667762);
			CylinderMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Vector3_Single_Single_CylinderEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderMath>.NativeClassPtr, 100667763);
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x000957E0 File Offset: 0x000939E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 80030, RefRangeEnd = 80034, XrefRangeStart = 80005, XrefRangeEnd = 80030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CalcExtentPoints(Vector3 center, float cylinderRadius, Quaternion cylinderRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderMath.NativeMethodInfoPtr_CalcExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00095844 File Offset: 0x00093A44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80036, RefRangeEnd = 80039, XrefRangeStart = 80034, XrefRangeEnd = 80036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderRadius;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_CylinderEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x000958D8 File Offset: 0x00093AD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 80054, RefRangeEnd = 80058, XrefRangeStart = 80039, XrefRangeEnd = 80054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderRadius;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderHeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_Single_CylinderEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0009597C File Offset: 0x00093B7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80060, RefRangeEnd = 80062, XrefRangeStart = 80058, XrefRangeEnd = 80060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastNoCaps(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderRadius;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderMath.NativeMethodInfoPtr_RaycastNoCaps_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_CylinderEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00095A10 File Offset: 0x00093C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80068, RefRangeEnd = 80069, XrefRangeStart = 80062, XrefRangeEnd = 80068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastNoCaps(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderRadius;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderHeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderMath.NativeMethodInfoPtr_RaycastNoCaps_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_Single_CylinderEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00095AB4 File Offset: 0x00093CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80069, XrefRangeEnd = 80076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsPoint(Vector3 point, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Vector3_Single_CylinderEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00095B3C File Offset: 0x00093D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80082, RefRangeEnd = 80083, XrefRangeStart = 80076, XrefRangeEnd = 80082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsPoint(Vector3 point, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cylinderAxisPt1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cylinderHeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Vector3_Single_Single_CylinderEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0000C3FB File Offset: 0x0000A5FB
		public CylinderMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_CalcExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_CylinderEpsilon_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_Single_CylinderEpsilon_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNoCaps_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_CylinderEpsilon_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_RaycastNoCaps_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Single_Single_CylinderEpsilon_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Vector3_Single_CylinderEpsilon_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Vector3_Single_Single_CylinderEpsilon_0;
	}
}
