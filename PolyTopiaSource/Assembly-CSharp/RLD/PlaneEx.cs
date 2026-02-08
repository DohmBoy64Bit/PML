using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000127 RID: 295
	public static class PlaneEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B79 RID: 7033 RVA: 0x0008C30C File Offset: 0x0008A50C
		// Note: this type is marked as 'beforefieldinit'.
		static PlaneEx()
		{
			Il2CppClassPointerStore<PlaneEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PlaneEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr);
			PlaneEx.NativeMethodInfoPtr_InvertNormal_Public_Static_Plane_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr, 100667409);
			PlaneEx.NativeMethodInfoPtr_GetAbsDistanceToPoint_Public_Static_Single_Plane_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr, 100667410);
			PlaneEx.NativeMethodInfoPtr_ProjectPoint_Public_Static_Vector3_Plane_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr, 100667411);
			PlaneEx.NativeMethodInfoPtr_ProjectAllPoints_Public_Static_List_1_Vector3_Plane_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr, 100667412);
			PlaneEx.NativeMethodInfoPtr_GetFurthestPtInFront_Public_Static_Int32_Plane_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr, 100667413);
			PlaneEx.NativeMethodInfoPtr_GetClosestPtInFront_Public_Static_Int32_Plane_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr, 100667414);
			PlaneEx.NativeMethodInfoPtr_GetClosestPtInFrontOrOnPlane_Public_Static_Int32_Plane_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr, 100667415);
			PlaneEx.NativeMethodInfoPtr_GetFurthestPtBehind_Public_Static_Int32_Plane_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr, 100667416);
			PlaneEx.NativeMethodInfoPtr_GetCameraFacingAxisSlicePlane_Public_Static_Plane_Vector3_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneEx>.NativeClassPtr, 100667417);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0008C3F0 File Offset: 0x0008A5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77311, RefRangeEnd = 77312, XrefRangeStart = 77309, XrefRangeEnd = 77311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Plane InvertNormal(this Plane plane)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneEx.NativeMethodInfoPtr_InvertNormal_Public_Static_Plane_Plane_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0008C434 File Offset: 0x0008A634
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 77312, RefRangeEnd = 77320, XrefRangeStart = 77312, XrefRangeEnd = 77312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAbsDistanceToPoint(this Plane plane, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneEx.NativeMethodInfoPtr_GetAbsDistanceToPoint_Public_Static_Single_Plane_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0008C488 File Offset: 0x0008A688
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 77320, RefRangeEnd = 77335, XrefRangeStart = 77320, XrefRangeEnd = 77320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ProjectPoint(this Plane plane, Vector3 pt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneEx.NativeMethodInfoPtr_ProjectPoint_Public_Static_Vector3_Plane_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0008C4E0 File Offset: 0x0008A6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77335, XrefRangeEnd = 77361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> ProjectAllPoints(this Plane plane, List<Vector3> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneEx.NativeMethodInfoPtr_ProjectAllPoints_Public_Static_List_1_Vector3_Plane_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0008C538 File Offset: 0x0008A738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77366, RefRangeEnd = 77367, XrefRangeStart = 77361, XrefRangeEnd = 77366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFurthestPtInFront(this Plane plane, List<Vector3> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneEx.NativeMethodInfoPtr_GetFurthestPtInFront_Public_Static_Int32_Plane_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0008C58C File Offset: 0x0008A78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77367, XrefRangeEnd = 77372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetClosestPtInFront(this Plane plane, List<Vector3> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneEx.NativeMethodInfoPtr_GetClosestPtInFront_Public_Static_Int32_Plane_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0008C5E0 File Offset: 0x0008A7E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77377, RefRangeEnd = 77379, XrefRangeStart = 77372, XrefRangeEnd = 77377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetClosestPtInFrontOrOnPlane(this Plane plane, List<Vector3> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneEx.NativeMethodInfoPtr_GetClosestPtInFrontOrOnPlane_Public_Static_Int32_Plane_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0008C634 File Offset: 0x0008A834
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77384, RefRangeEnd = 77387, XrefRangeStart = 77379, XrefRangeEnd = 77384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFurthestPtBehind(this Plane plane, List<Vector3> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneEx.NativeMethodInfoPtr_GetFurthestPtBehind_Public_Static_Int32_Plane_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0008C688 File Offset: 0x0008A888
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77403, RefRangeEnd = 77405, XrefRangeStart = 77387, XrefRangeEnd = 77403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Plane GetCameraFacingAxisSlicePlane(Vector3 axisOrigin, Vector3 axis, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneEx.NativeMethodInfoPtr_GetCameraFacingAxisSlicePlane_Public_Static_Plane_Vector3_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0000BD55 File Offset: 0x00009F55
		public PlaneEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_InvertNormal_Public_Static_Plane_Plane_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsDistanceToPoint_Public_Static_Single_Plane_Vector3_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr_ProjectPoint_Public_Static_Vector3_Plane_Vector3_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_ProjectAllPoints_Public_Static_List_1_Vector3_Plane_List_1_Vector3_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_GetFurthestPtInFront_Public_Static_Int32_Plane_List_1_Vector3_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPtInFront_Public_Static_Int32_Plane_List_1_Vector3_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPtInFrontOrOnPlane_Public_Static_Int32_Plane_List_1_Vector3_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_GetFurthestPtBehind_Public_Static_Int32_Plane_List_1_Vector3_0;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFacingAxisSlicePlane_Public_Static_Plane_Vector3_Vector3_Camera_0;
	}
}
