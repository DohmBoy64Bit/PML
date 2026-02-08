using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200016D RID: 365
	public static class SegmentMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001E05 RID: 7685 RVA: 0x000989A8 File Offset: 0x00096BA8
		// Note: this type is marked as 'beforefieldinit'.
		static SegmentMath()
		{
			Il2CppClassPointerStore<SegmentMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SegmentMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SegmentMath>.NativeClassPtr);
			SegmentMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_SegmentEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentMath>.NativeClassPtr, 100667874);
			SegmentMath.NativeMethodInfoPtr_Is3DPointOnSegment_Public_Static_Boolean_Vector3_Vector3_Vector3_SegmentEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentMath>.NativeClassPtr, 100667875);
			SegmentMath.NativeMethodInfoPtr_Is2DPointOnSegment_Public_Static_Boolean_Vector2_Vector2_Vector2_SegmentEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentMath>.NativeClassPtr, 100667876);
			SegmentMath.NativeMethodInfoPtr_ProjectPtOnSegment_Public_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentMath>.NativeClassPtr, 100667877);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00098A28 File Offset: 0x00096C28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81142, RefRangeEnd = 81143, XrefRangeStart = 81138, XrefRangeEnd = 81142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 startPoint, Vector3 endPoint, SegmentEpsilon epsilon = default(SegmentEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startPoint);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_SegmentEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00098AB0 File Offset: 0x00096CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81143, XrefRangeEnd = 81144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is3DPointOnSegment(Vector3 point, Vector3 startPoint, Vector3 endPoint, SegmentEpsilon epsilon = default(SegmentEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentMath.NativeMethodInfoPtr_Is3DPointOnSegment_Public_Static_Boolean_Vector3_Vector3_Vector3_SegmentEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00098B28 File Offset: 0x00096D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81145, RefRangeEnd = 81146, XrefRangeStart = 81144, XrefRangeEnd = 81145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is2DPointOnSegment(Vector2 point, Vector2 startPoint, Vector2 endPoint, SegmentEpsilon epsilon = default(SegmentEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentMath.NativeMethodInfoPtr_Is2DPointOnSegment_Public_Static_Boolean_Vector2_Vector2_Vector2_SegmentEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00098BA0 File Offset: 0x00096DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78105, RefRangeEnd = 78106, XrefRangeStart = 78105, XrefRangeEnd = 78106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ProjectPtOnSegment(Vector3 point, Vector3 startPoint, Vector3 endPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentMath.NativeMethodInfoPtr_ProjectPtOnSegment_Public_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0000C59F File Offset: 0x0000A79F
		public SegmentMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_SegmentEpsilon_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_Is3DPointOnSegment_Public_Static_Boolean_Vector3_Vector3_Vector3_SegmentEpsilon_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_Is2DPointOnSegment_Public_Static_Boolean_Vector2_Vector2_Vector2_SegmentEpsilon_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_ProjectPtOnSegment_Public_Static_Vector3_Vector3_Vector3_Vector3_0;
	}
}
