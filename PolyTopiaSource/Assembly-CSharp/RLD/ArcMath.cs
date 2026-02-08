using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000149 RID: 329
	public static class ArcMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001D2B RID: 7467 RVA: 0x00093B80 File Offset: 0x00091D80
		// Note: this type is marked as 'beforefieldinit'.
		static ArcMath()
		{
			Il2CppClassPointerStore<ArcMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ArcMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcMath>.NativeClassPtr);
			ArcMath.NativeMethodInfoPtr_ConvertToSh3DArcAngle_Public_Static_Single_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667713);
			ArcMath.NativeMethodInfoPtr_ConvertToSh2DArcAngle_Public_Static_Single_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667714);
			ArcMath.NativeMethodInfoPtr_CalcSh3DArcOBB_Public_Static_OBB_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667715);
			ArcMath.NativeMethodInfoPtr_CalcLg3DArcOBB_Public_Static_OBB_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667716);
			ArcMath.NativeMethodInfoPtr_RaycastShArc_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667717);
			ArcMath.NativeMethodInfoPtr_RaycastShArcWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667718);
			ArcMath.NativeMethodInfoPtr_RaycastLgArc_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667719);
			ArcMath.NativeMethodInfoPtr_RaycastLgArcWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667720);
			ArcMath.NativeMethodInfoPtr_ShArcContains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667721);
			ArcMath.NativeMethodInfoPtr_Is3DPointOnShArcWire_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667722);
			ArcMath.NativeMethodInfoPtr_ShArcContains2DPoint_Public_Static_Boolean_Vector2_Vector2_Vector2_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667723);
			ArcMath.NativeMethodInfoPtr_LgArcContains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667724);
			ArcMath.NativeMethodInfoPtr_Is3DPointOnLgArcWire_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667725);
			ArcMath.NativeMethodInfoPtr_LgArcContains2DPoint_Public_Static_Boolean_Vector2_Vector2_Vector2_Single_ArcEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcMath>.NativeClassPtr, 100667726);
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00093CC8 File Offset: 0x00091EC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 79305, RefRangeEnd = 79311, XrefRangeStart = 79296, XrefRangeEnd = 79305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertToSh3DArcAngle(Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_ConvertToSh3DArcAngle_Public_Static_Single_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x00093D3C File Offset: 0x00091F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79323, RefRangeEnd = 79325, XrefRangeStart = 79311, XrefRangeEnd = 79323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertToSh2DArcAngle(Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_ConvertToSh2DArcAngle_Public_Static_Single_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00093DA0 File Offset: 0x00091FA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79348, RefRangeEnd = 79351, XrefRangeStart = 79325, XrefRangeEnd = 79348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OBB CalcSh3DArcOBB(Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_CalcSh3DArcOBB_Public_Static_OBB_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00093E2C File Offset: 0x0009202C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79374, RefRangeEnd = 79376, XrefRangeStart = 79351, XrefRangeEnd = 79374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OBB CalcLg3DArcOBB(Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_CalcLg3DArcOBB_Public_Static_OBB_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00093EB8 File Offset: 0x000920B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79376, XrefRangeEnd = 79392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastShArc(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_RaycastShArc_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00093F60 File Offset: 0x00092160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79392, XrefRangeEnd = 79408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastShArcWire(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_RaycastShArcWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00094008 File Offset: 0x00092208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79408, XrefRangeEnd = 79423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastLgArc(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_RaycastLgArc_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x000940B0 File Offset: 0x000922B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79438, RefRangeEnd = 79440, XrefRangeStart = 79423, XrefRangeEnd = 79438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastLgArcWire(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_RaycastLgArcWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00094158 File Offset: 0x00092358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79452, RefRangeEnd = 79454, XrefRangeStart = 79440, XrefRangeEnd = 79452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShArcContains3DPoint(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_ShArcContains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00094200 File Offset: 0x00092400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79466, RefRangeEnd = 79467, XrefRangeStart = 79454, XrefRangeEnd = 79466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is3DPointOnShArcWire(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_Is3DPointOnShArcWire_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000942A8 File Offset: 0x000924A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79467, XrefRangeEnd = 79471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShArcContains2DPoint(Vector2 point, Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_ShArcContains2DPoint_Public_Static_Boolean_Vector2_Vector2_Vector2_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x00094330 File Offset: 0x00092530
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79479, RefRangeEnd = 79482, XrefRangeStart = 79471, XrefRangeEnd = 79479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LgArcContains3DPoint(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_LgArcContains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000943D8 File Offset: 0x000925D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79494, RefRangeEnd = 79495, XrefRangeStart = 79482, XrefRangeEnd = 79494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is3DPointOnLgArcWire(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlaneNormal);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_Is3DPointOnLgArcWire_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00094480 File Offset: 0x00092680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79498, RefRangeEnd = 79499, XrefRangeStart = 79495, XrefRangeEnd = 79498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LgArcContains2DPoint(Vector2 point, Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcMath.NativeMethodInfoPtr_LgArcContains2DPoint_Public_Static_Boolean_Vector2_Vector2_Vector2_Single_ArcEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0000C359 File Offset: 0x0000A559
		public ArcMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSh3DArcAngle_Public_Static_Single_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToSh2DArcAngle_Public_Static_Single_Vector2_Vector2_Single_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_CalcSh3DArcOBB_Public_Static_OBB_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_CalcLg3DArcOBB_Public_Static_OBB_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_RaycastShArc_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_RaycastShArcWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_RaycastLgArc_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr_RaycastLgArcWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeMethodInfoPtr_ShArcContains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeMethodInfoPtr_Is3DPointOnShArcWire_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeMethodInfoPtr_ShArcContains2DPoint_Public_Static_Boolean_Vector2_Vector2_Vector2_Single_ArcEpsilon_0;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeMethodInfoPtr_LgArcContains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr_Is3DPointOnLgArcWire_Public_Static_Boolean_Vector3_Boolean_Vector3_Vector3_Vector3_Single_ArcEpsilon_0;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeMethodInfoPtr_LgArcContains2DPoint_Public_Static_Boolean_Vector2_Vector2_Vector2_Single_ArcEpsilon_0;
	}
}
