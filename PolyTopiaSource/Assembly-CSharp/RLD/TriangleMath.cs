using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000175 RID: 373
	public static class TriangleMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001E1A RID: 7706 RVA: 0x000992B0 File Offset: 0x000974B0
		// Note: this type is marked as 'beforefieldinit'.
		static TriangleMath()
		{
			Il2CppClassPointerStore<TriangleMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TriangleMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr);
			TriangleMath.NativeFieldInfoPtr__eqTriangleAltFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, "_eqTriangleAltFactor");
			TriangleMath.NativeMethodInfoPtr_get_EqTriangleAltFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667889);
			TriangleMath.NativeMethodInfoPtr_GetEqTriangleAltitude_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667890);
			TriangleMath.NativeMethodInfoPtr_GetEqTriangleCentroidAltitude_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667891);
			TriangleMath.NativeMethodInfoPtr_CalcEqTriangle3DPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667892);
			TriangleMath.NativeMethodInfoPtr_CalcEqTriangle2DPoints_Public_Static_List_1_Vector2_Vector2_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667893);
			TriangleMath.NativeMethodInfoPtr_CalcRATriangleHypotenuse_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667894);
			TriangleMath.NativeMethodInfoPtr_CalcRATriangleHypotenuse_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667895);
			TriangleMath.NativeMethodInfoPtr_CalcRATriangleAltitude_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667896);
			TriangleMath.NativeMethodInfoPtr_CalcRATriangle3DPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667897);
			TriangleMath.NativeMethodInfoPtr_CalcRATriangle2DPoints_Public_Static_List_1_Vector2_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667898);
			TriangleMath.NativeMethodInfoPtr_Calc3DTriangleOBB_Public_Static_OBB_Vector3_Vector3_Vector3_Vector3_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667899);
			TriangleMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667900);
			TriangleMath.NativeMethodInfoPtr_RaycastWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667901);
			TriangleMath.NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667902);
			TriangleMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMath>.NativeClassPtr, 100667903);
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00099420 File Offset: 0x00097620
		public unsafe static float EqTriangleAltFactor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81241, XrefRangeEnd = 81245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_get_EqTriangleAltFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00099450 File Offset: 0x00097650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81245, XrefRangeEnd = 81249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetEqTriangleAltitude(float sideLength)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sideLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_GetEqTriangleAltitude_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00099490 File Offset: 0x00097690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81249, XrefRangeEnd = 81253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetEqTriangleCentroidAltitude(float sideLength)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sideLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_GetEqTriangleCentroidAltitude_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000994D0 File Offset: 0x000976D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81292, RefRangeEnd = 81295, XrefRangeStart = 81253, XrefRangeEnd = 81292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CalcEqTriangle3DPoints(Vector3 centroid, float sideLength, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(centroid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sideLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_CalcEqTriangle3DPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00099534 File Offset: 0x00097734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81325, RefRangeEnd = 81326, XrefRangeStart = 81295, XrefRangeEnd = 81325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> CalcEqTriangle2DPoints(Vector2 centroid, float sideLength, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(centroid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sideLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_CalcEqTriangle2DPoints_Public_Static_List_1_Vector2_Vector2_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00099598 File Offset: 0x00097798
		[CallerCount(0)]
		public unsafe static float CalcRATriangleHypotenuse(float side0, float side1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref side0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref side1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_CalcRATriangleHypotenuse_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000995E4 File Offset: 0x000977E4
		[CallerCount(0)]
		public unsafe static float CalcRATriangleHypotenuse(Vector2 sides)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sides);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_CalcRATriangleHypotenuse_Public_Static_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00099628 File Offset: 0x00097828
		[CallerCount(0)]
		public unsafe static float CalcRATriangleAltitude(Vector2 sides)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sides);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_CalcRATriangleAltitude_Public_Static_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0009966C File Offset: 0x0009786C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81348, RefRangeEnd = 81349, XrefRangeStart = 81326, XrefRangeEnd = 81348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CalcRATriangle3DPoints(Vector3 rightAngleCorner, float xLength, float yLength, Quaternion triangleRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rightAngleCorner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triangleRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_CalcRATriangle3DPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x000996E0 File Offset: 0x000978E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81371, RefRangeEnd = 81372, XrefRangeStart = 81349, XrefRangeEnd = 81371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> CalcRATriangle2DPoints(Vector2 rightAngleCorner, float xLength, float yLength, float degreeTriRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rightAngleCorner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreeTriRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_CalcRATriangle2DPoints_Public_Static_List_1_Vector2_Vector2_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00099750 File Offset: 0x00097950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81385, RefRangeEnd = 81387, XrefRangeStart = 81372, XrefRangeEnd = 81385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OBB Calc3DTriangleOBB(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 normal, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normal);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_Calc3DTriangleOBB_Public_Static_OBB_Vector3_Vector3_Vector3_Vector3_TriangleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x000997E0 File Offset: 0x000979E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81406, RefRangeEnd = 81410, XrefRangeStart = 81387, XrefRangeEnd = 81406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_TriangleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0009987C File Offset: 0x00097A7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81429, RefRangeEnd = 81432, XrefRangeStart = 81410, XrefRangeEnd = 81429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastWire(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_RaycastWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_TriangleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00099918 File Offset: 0x00097B18
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 81449, RefRangeEnd = 81456, XrefRangeStart = 81432, XrefRangeEnd = 81449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_TriangleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x000999B4 File Offset: 0x00097BB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81460, RefRangeEnd = 81463, XrefRangeStart = 81456, XrefRangeEnd = 81460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains2DPoint(Vector2 point, Vector2 p0, Vector2 p1, Vector2 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_TriangleEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0000C5BA File Offset: 0x0000A7BA
		public TriangleMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x00099A40 File Offset: 0x00097C40
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x0000C5C3 File Offset: 0x0000A7C3
		public unsafe static float _eqTriangleAltFactor
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TriangleMath.NativeFieldInfoPtr__eqTriangleAltFactor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TriangleMath.NativeFieldInfoPtr__eqTriangleAltFactor, (void*)(&value));
			}
		}

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeFieldInfoPtr__eqTriangleAltFactor;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeMethodInfoPtr_get_EqTriangleAltFactor_Public_Static_get_Single_0;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeMethodInfoPtr_GetEqTriangleAltitude_Public_Static_Single_Single_0;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeMethodInfoPtr_GetEqTriangleCentroidAltitude_Public_Static_Single_Single_0;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_CalcEqTriangle3DPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr_CalcEqTriangle2DPoints_Public_Static_List_1_Vector2_Vector2_Single_Quaternion_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeMethodInfoPtr_CalcRATriangleHypotenuse_Public_Static_Single_Single_Single_0;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeMethodInfoPtr_CalcRATriangleHypotenuse_Public_Static_Single_Vector2_0;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeMethodInfoPtr_CalcRATriangleAltitude_Public_Static_Single_Vector2_0;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeMethodInfoPtr_CalcRATriangle3DPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Quaternion_0;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeMethodInfoPtr_CalcRATriangle2DPoints_Public_Static_List_1_Vector2_Vector2_Single_Single_Single_0;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_Calc3DTriangleOBB_Public_Static_OBB_Vector3_Vector3_Vector3_Vector3_TriangleEpsilon_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_TriangleEpsilon_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_TriangleEpsilon_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_TriangleEpsilon_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_TriangleEpsilon_0;
	}
}
