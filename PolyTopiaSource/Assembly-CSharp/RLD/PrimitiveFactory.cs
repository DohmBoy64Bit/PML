using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000166 RID: 358
	public static class PrimitiveFactory : global::Il2CppSystem.Object
	{
		// Token: 0x06001DE1 RID: 7649 RVA: 0x000977C4 File Offset: 0x000959C4
		// Note: this type is marked as 'beforefieldinit'.
		static PrimitiveFactory()
		{
			Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrimitiveFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr);
			PrimitiveFactory.NativeMethodInfoPtr_Generate2DPolyBorderQuadsCW_Public_Static_List_1_Vector2_List_1_Vector2_List_1_Vector2_PolyBorderDirection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr, 100667840);
			PrimitiveFactory.NativeMethodInfoPtr_PolyBorderDirToSign_Public_Static_Single_PolyBorderDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr, 100667841);
			PrimitiveFactory.NativeMethodInfoPtr_Generate2DPolyBorderPointsCW_Public_Static_List_1_Vector2_List_1_Vector2_PolyBorderDirection_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr, 100667842);
			PrimitiveFactory.NativeMethodInfoPtr_Generate2DCircleBorderPointsCW_Public_Static_List_1_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr, 100667843);
			PrimitiveFactory.NativeMethodInfoPtr_Generate3DCircleBorderPoints_Public_Static_List_1_Vector3_Vector3_Single_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr, 100667844);
			PrimitiveFactory.NativeMethodInfoPtr_GenerateSphereBorderPoints_Public_Static_List_1_Vector3_Camera_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr, 100667845);
			PrimitiveFactory.NativeMethodInfoPtr_Generate2DArcBorderPoints_Public_Static_List_1_Vector2_Vector2_Vector2_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr, 100667846);
			PrimitiveFactory.NativeMethodInfoPtr_ProjectArcPointsOnPoly2DBorder_Public_Static_List_1_Vector2_Vector2_List_1_Vector2_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr, 100667847);
			PrimitiveFactory.NativeMethodInfoPtr_Generate3DArcBorderPoints_Public_Static_List_1_Vector3_Vector3_Vector3_Plane_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveFactory>.NativeClassPtr, 100667848);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000978A8 File Offset: 0x00095AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80272, RefRangeEnd = 80273, XrefRangeStart = 80262, XrefRangeEnd = 80272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> Generate2DPolyBorderQuadsCW(List<Vector2> cwPolyPoints, List<Vector2> cwBorderPts, PrimitiveFactory.PolyBorderDirection borderDirection, bool isClosed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cwPolyPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cwBorderPts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderDirection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveFactory.NativeMethodInfoPtr_Generate2DPolyBorderQuadsCW_Public_Static_List_1_Vector2_List_1_Vector2_List_1_Vector2_PolyBorderDirection_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0009791C File Offset: 0x00095B1C
		[CallerCount(0)]
		public unsafe static float PolyBorderDirToSign(PrimitiveFactory.PolyBorderDirection borderDirection)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref borderDirection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveFactory.NativeMethodInfoPtr_PolyBorderDirToSign_Public_Static_Single_PolyBorderDirection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0009795C File Offset: 0x00095B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80316, RefRangeEnd = 80318, XrefRangeStart = 80273, XrefRangeEnd = 80316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> Generate2DPolyBorderPointsCW(List<Vector2> cwPolyPoints, PrimitiveFactory.PolyBorderDirection borderDirection, float borderThickness, bool isClosed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cwPolyPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderThickness;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveFactory.NativeMethodInfoPtr_Generate2DPolyBorderPointsCW_Public_Static_List_1_Vector2_List_1_Vector2_PolyBorderDirection_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x000979CC File Offset: 0x00095BCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80330, RefRangeEnd = 80333, XrefRangeStart = 80318, XrefRangeEnd = 80330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> Generate2DCircleBorderPointsCW(Vector2 circleCenter, float circleRadius, int numPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveFactory.NativeMethodInfoPtr_Generate2DCircleBorderPointsCW_Public_Static_List_1_Vector2_Vector2_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00097A2C File Offset: 0x00095C2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80345, RefRangeEnd = 80348, XrefRangeStart = 80333, XrefRangeEnd = 80345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> Generate3DCircleBorderPoints(Vector3 circleCenter, float circleRadius, Vector3 circleRight, Vector3 circleUp, int numPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleRight);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleUp);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveFactory.NativeMethodInfoPtr_Generate3DCircleBorderPoints_Public_Static_List_1_Vector3_Vector3_Single_Vector3_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00097AB0 File Offset: 0x00095CB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80388, RefRangeEnd = 80390, XrefRangeStart = 80348, XrefRangeEnd = 80388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> GenerateSphereBorderPoints(Camera camera, Vector3 sphereCenter, float sphereRadius, int numPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sphereCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveFactory.NativeMethodInfoPtr_GenerateSphereBorderPoints_Public_Static_List_1_Vector3_Camera_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00097B24 File Offset: 0x00095D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80421, RefRangeEnd = 80423, XrefRangeStart = 80390, XrefRangeEnd = 80421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> Generate2DArcBorderPoints(Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart, bool forceShortestArc, int numPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceShortestArc;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveFactory.NativeMethodInfoPtr_Generate2DArcBorderPoints_Public_Static_List_1_Vector2_Vector2_Vector2_Single_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00097BA4 File Offset: 0x00095DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80467, RefRangeEnd = 80468, XrefRangeStart = 80423, XrefRangeEnd = 80467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> ProjectArcPointsOnPoly2DBorder(Vector2 arcOrigin, List<Vector2> arcPoints, List<Vector2> clockwisePolyPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clockwisePolyPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveFactory.NativeMethodInfoPtr_ProjectArcPointsOnPoly2DBorder_Public_Static_List_1_Vector2_Vector2_List_1_Vector2_List_1_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00097C0C File Offset: 0x00095E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80494, RefRangeEnd = 80495, XrefRangeStart = 80468, XrefRangeEnd = 80494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> Generate3DArcBorderPoints(Vector3 arcOrigin, Vector3 arcStartPoint, Plane arcPlane, float degreesFromStart, bool forceShortestArc, int numPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arcOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcStartPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arcPlane);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesFromStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceShortestArc;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveFactory.NativeMethodInfoPtr_Generate3DArcBorderPoints_Public_Static_List_1_Vector3_Vector3_Vector3_Plane_Single_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x0000C57B File Offset: 0x0000A77B
		public PrimitiveFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_Generate2DPolyBorderQuadsCW_Public_Static_List_1_Vector2_List_1_Vector2_List_1_Vector2_PolyBorderDirection_Boolean_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_PolyBorderDirToSign_Public_Static_Single_PolyBorderDirection_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_Generate2DPolyBorderPointsCW_Public_Static_List_1_Vector2_List_1_Vector2_PolyBorderDirection_Single_Boolean_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_Generate2DCircleBorderPointsCW_Public_Static_List_1_Vector2_Vector2_Single_Int32_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_Generate3DCircleBorderPoints_Public_Static_List_1_Vector3_Vector3_Single_Vector3_Vector3_Int32_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSphereBorderPoints_Public_Static_List_1_Vector3_Camera_Vector3_Single_Int32_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_Generate2DArcBorderPoints_Public_Static_List_1_Vector2_Vector2_Vector2_Single_Boolean_Int32_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_ProjectArcPointsOnPoly2DBorder_Public_Static_List_1_Vector2_Vector2_List_1_Vector2_List_1_Vector2_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_Generate3DArcBorderPoints_Public_Static_List_1_Vector3_Vector3_Vector3_Plane_Single_Boolean_Int32_0;

		// Token: 0x02000392 RID: 914
		public enum PolyBorderDirection
		{
			// Token: 0x04003A5C RID: 14940
			Inward,
			// Token: 0x04003A5D RID: 14941
			Outward
		}
	}
}
