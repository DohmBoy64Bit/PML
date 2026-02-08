using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200012F RID: 303
	public static class TransformEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001BAE RID: 7086 RVA: 0x0008D35C File Offset: 0x0008B55C
		// Note: this type is marked as 'beforefieldinit'.
		static TransformEx()
		{
			Il2CppClassPointerStore<TransformEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TransformEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformEx>.NativeClassPtr);
			TransformEx.NativeMethodInfoPtr_TransformPoints_Public_Static_Void_Transform_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformEx>.NativeClassPtr, 100667448);
			TransformEx.NativeMethodInfoPtr_GetGameObjectTransformCollection_Public_Static_List_1_Transform_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformEx>.NativeClassPtr, 100667449);
			TransformEx.NativeMethodInfoPtr_FilterParentsOnly_Public_Static_List_1_Transform_IEnumerable_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformEx>.NativeClassPtr, 100667450);
			TransformEx.NativeMethodInfoPtr_SetWorldScale_Public_Static_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformEx>.NativeClassPtr, 100667451);
			TransformEx.NativeMethodInfoPtr_ScaleFromPivot_Public_Static_Void_Transform_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformEx>.NativeClassPtr, 100667452);
			TransformEx.NativeMethodInfoPtr_RotateAroundPivot_Public_Static_Void_Transform_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformEx>.NativeClassPtr, 100667453);
			TransformEx.NativeMethodInfoPtr_GetLocalAxis_Public_Static_Vector3_Transform_AxisDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformEx>.NativeClassPtr, 100667454);
			TransformEx.NativeMethodInfoPtr_GetLocalPlane_Public_Static_Plane_Transform_PlaneDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformEx>.NativeClassPtr, 100667455);
			TransformEx.NativeMethodInfoPtr_Align_Public_Static_Quaternion_Transform_Vector3_TransformAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformEx>.NativeClassPtr, 100667456);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0008D440 File Offset: 0x0008B640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77754, XrefRangeEnd = 77763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TransformPoints(this Transform transform, List<Vector3> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformEx.NativeMethodInfoPtr_TransformPoints_Public_Static_Void_Transform_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0008D488 File Offset: 0x0008B688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77763, XrefRangeEnd = 77792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Transform> GetGameObjectTransformCollection(IEnumerable<GameObject> gameObjects)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformEx.NativeMethodInfoPtr_GetGameObjectTransformCollection_Public_Static_List_1_Transform_IEnumerable_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0008D4CC File Offset: 0x0008B6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77792, XrefRangeEnd = 77841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Transform> FilterParentsOnly(IEnumerable<Transform> transforms)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transforms);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformEx.NativeMethodInfoPtr_FilterParentsOnly_Public_Static_List_1_Transform_IEnumerable_1_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0008D510 File Offset: 0x0008B710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77846, RefRangeEnd = 77848, XrefRangeStart = 77841, XrefRangeEnd = 77846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWorldScale(this Transform transform, Vector3 worldScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldScale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformEx.NativeMethodInfoPtr_SetWorldScale_Public_Static_Void_Transform_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0008D558 File Offset: 0x0008B758
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77858, RefRangeEnd = 77861, XrefRangeStart = 77848, XrefRangeEnd = 77858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScaleFromPivot(this Transform transform, Vector3 scaleFactor, Vector3 pivot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scaleFactor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pivot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformEx.NativeMethodInfoPtr_ScaleFromPivot_Public_Static_Void_Transform_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0008D5B4 File Offset: 0x0008B7B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 77866, RefRangeEnd = 77873, XrefRangeStart = 77861, XrefRangeEnd = 77866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateAroundPivot(this Transform transform, Quaternion rotation, Vector3 pivot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pivot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformEx.NativeMethodInfoPtr_RotateAroundPivot_Public_Static_Void_Transform_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0008D610 File Offset: 0x0008B810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77873, XrefRangeEnd = 77877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetLocalAxis(this Transform transform, AxisDescriptor axisDesc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisDesc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformEx.NativeMethodInfoPtr_GetLocalAxis_Public_Static_Vector3_Transform_AxisDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0008D668 File Offset: 0x0008B868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77877, XrefRangeEnd = 77892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Plane GetLocalPlane(this Transform transform, PlaneDescriptor planeDesc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeDesc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformEx.NativeMethodInfoPtr_GetLocalPlane_Public_Static_Plane_Transform_PlaneDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0008D6C0 File Offset: 0x0008B8C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 77919, RefRangeEnd = 77926, XrefRangeStart = 77892, XrefRangeEnd = 77919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Align(this Transform transform, Vector3 normAlignVector, TransformAxis alignmentAxis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normAlignVector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignmentAxis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformEx.NativeMethodInfoPtr_Align_Public_Static_Quaternion_Transform_Vector3_TransformAxis_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0000BD94 File Offset: 0x00009F94
		public TransformEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoints_Public_Static_Void_Transform_List_1_Vector3_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectTransformCollection_Public_Static_List_1_Transform_IEnumerable_1_GameObject_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_FilterParentsOnly_Public_Static_List_1_Transform_IEnumerable_1_Transform_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_SetWorldScale_Public_Static_Void_Transform_Vector3_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_ScaleFromPivot_Public_Static_Void_Transform_Vector3_Vector3_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundPivot_Public_Static_Void_Transform_Quaternion_Vector3_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalAxis_Public_Static_Vector3_Transform_AxisDescriptor_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPlane_Public_Static_Plane_Transform_PlaneDescriptor_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_Align_Public_Static_Quaternion_Transform_Vector3_TransformAxis_0;
	}
}
