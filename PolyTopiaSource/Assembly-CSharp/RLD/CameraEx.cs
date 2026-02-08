using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200011E RID: 286
	public static class CameraEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B13 RID: 6931 RVA: 0x0008A470 File Offset: 0x00088670
		// Note: this type is marked as 'beforefieldinit'.
		static CameraEx()
		{
			Il2CppClassPointerStore<CameraEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraEx>.NativeClassPtr);
			CameraEx.NativeFieldInfoPtr__objectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, "_objectBuffer");
			CameraEx.NativeMethodInfoPtr_IsCurrent_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667328);
			CameraEx.NativeMethodInfoPtr_GetFrustumDistanceFromHeight_Public_Static_Single_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667329);
			CameraEx.NativeMethodInfoPtr_GetFOVFromDistanceAndHeight_Public_Static_Single_Camera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667330);
			CameraEx.NativeMethodInfoPtr_GetFrustumWidthFromDistance_Public_Static_Single_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667331);
			CameraEx.NativeMethodInfoPtr_GetFrustumHeightFromDistance_Public_Static_Single_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667332);
			CameraEx.NativeMethodInfoPtr_CalculateVolumeAABB_Public_Static_AABB_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667333);
			CameraEx.NativeMethodInfoPtr_CalculateFrustumAABB_Public_Static_AABB_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667334);
			CameraEx.NativeMethodInfoPtr_CalculateOrthoAABB_Public_Static_AABB_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667335);
			CameraEx.NativeMethodInfoPtr_IsPointInFrontNearPlane_Public_Static_Boolean_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667336);
			CameraEx.NativeMethodInfoPtr_GetNearPlaneForward_Public_Static_Plane_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667337);
			CameraEx.NativeMethodInfoPtr_GetFarMidPoint_Public_Static_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667338);
			CameraEx.NativeMethodInfoPtr_GetFarMidOrthoTop_Public_Static_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667339);
			CameraEx.NativeMethodInfoPtr_GetOrthoFOV_Public_Static_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667340);
			CameraEx.NativeMethodInfoPtr_IsPointFacingCamera_Public_Static_Boolean_Camera_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667341);
			CameraEx.NativeMethodInfoPtr_GetPointZDistance_Public_Static_Single_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667342);
			CameraEx.NativeMethodInfoPtr_GetVisibleSphereExtents_Public_Static_List_1_Vector3_Camera_Sphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667343);
			CameraEx.NativeMethodInfoPtr_ConvertWorldToScreenPoints_Public_Static_List_1_Vector2_Camera_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667344);
			CameraEx.NativeMethodInfoPtr_ScreenToEstimatedWorldSize_Public_Static_Single_Camera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667345);
			CameraEx.NativeMethodInfoPtr_EstimateZoomFactor_Public_Static_Single_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667346);
			CameraEx.NativeMethodInfoPtr_EstimateZoomFactorSpherical_Public_Static_Single_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667347);
			CameraEx.NativeMethodInfoPtr_GetVisibleObjects_Public_Static_Void_Camera_CameraViewVolume_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEx>.NativeClassPtr, 100667348);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0008A658 File Offset: 0x00088858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76061, XrefRangeEnd = 76066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCurrent(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_IsCurrent_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0008A69C File Offset: 0x0008889C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76066, XrefRangeEnd = 76068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFrustumDistanceFromHeight(this Camera camera, float frustumHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frustumHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetFrustumDistanceFromHeight_Public_Static_Single_Camera_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0008A6EC File Offset: 0x000888EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76068, XrefRangeEnd = 76069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFOVFromDistanceAndHeight(this Camera camera, float frustumHeight, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frustumHeight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetFOVFromDistanceAndHeight_Public_Static_Single_Camera_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0008A74C File Offset: 0x0008894C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76069, XrefRangeEnd = 76072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFrustumWidthFromDistance(this Camera camera, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetFrustumWidthFromDistance_Public_Static_Single_Camera_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0008A79C File Offset: 0x0008899C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76072, XrefRangeEnd = 76074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFrustumHeightFromDistance(this Camera camera, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetFrustumHeightFromDistance_Public_Static_Single_Camera_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0008A7EC File Offset: 0x000889EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76082, RefRangeEnd = 76083, XrefRangeStart = 76074, XrefRangeEnd = 76082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalculateVolumeAABB(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_CalculateVolumeAABB_Public_Static_AABB_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0008A830 File Offset: 0x00088A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76107, RefRangeEnd = 76108, XrefRangeStart = 76083, XrefRangeEnd = 76107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalculateFrustumAABB(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_CalculateFrustumAABB_Public_Static_AABB_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0008A874 File Offset: 0x00088A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76131, RefRangeEnd = 76132, XrefRangeStart = 76108, XrefRangeEnd = 76131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalculateOrthoAABB(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_CalculateOrthoAABB_Public_Static_AABB_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0008A8B8 File Offset: 0x00088AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76132, XrefRangeEnd = 76136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPointInFrontNearPlane(this Camera camera, Vector3 position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_IsPointInFrontNearPlane_Public_Static_Boolean_Camera_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0008A90C File Offset: 0x00088B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76143, RefRangeEnd = 76144, XrefRangeStart = 76136, XrefRangeEnd = 76143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Plane GetNearPlaneForward(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetNearPlaneForward_Public_Static_Plane_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0008A950 File Offset: 0x00088B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76144, XrefRangeEnd = 76148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetFarMidPoint(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetFarMidPoint_Public_Static_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0008A994 File Offset: 0x00088B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76148, XrefRangeEnd = 76158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetFarMidOrthoTop(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetFarMidOrthoTop_Public_Static_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0008A9D8 File Offset: 0x00088BD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76178, RefRangeEnd = 76180, XrefRangeStart = 76158, XrefRangeEnd = 76178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetOrthoFOV(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetOrthoFOV_Public_Static_Single_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0008AA1C File Offset: 0x00088C1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76185, RefRangeEnd = 76189, XrefRangeStart = 76180, XrefRangeEnd = 76185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPointFacingCamera(this Camera camera, Vector3 point, Vector3 pointNormal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointNormal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_IsPointFacingCamera_Public_Static_Boolean_Camera_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0008AA84 File Offset: 0x00088C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76192, RefRangeEnd = 76194, XrefRangeStart = 76189, XrefRangeEnd = 76192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPointZDistance(this Camera camera, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetPointZDistance_Public_Static_Single_Camera_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0008AAD8 File Offset: 0x00088CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76194, XrefRangeEnd = 76211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> GetVisibleSphereExtents(this Camera camera, Sphere sphere)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sphere);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetVisibleSphereExtents_Public_Static_List_1_Vector3_Camera_Sphere_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0008AB30 File Offset: 0x00088D30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 76238, RefRangeEnd = 76241, XrefRangeStart = 76211, XrefRangeEnd = 76238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> ConvertWorldToScreenPoints(this Camera camera, List<Vector3> worldPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_ConvertWorldToScreenPoints_Public_Static_List_1_Vector2_Camera_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0008AB88 File Offset: 0x00088D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76248, RefRangeEnd = 76250, XrefRangeStart = 76241, XrefRangeEnd = 76248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ScreenToEstimatedWorldSize(this Camera camera, Vector3 worldPos, float screenSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldPos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_ScreenToEstimatedWorldSize_Public_Static_Single_Camera_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0008ABEC File Offset: 0x00088DEC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 76256, RefRangeEnd = 76270, XrefRangeStart = 76250, XrefRangeEnd = 76256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EstimateZoomFactor(this Camera camera, Vector3 worldPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldPos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_EstimateZoomFactor_Public_Static_Single_Camera_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0008AC40 File Offset: 0x00088E40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76276, RefRangeEnd = 76278, XrefRangeStart = 76270, XrefRangeEnd = 76276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EstimateZoomFactorSpherical(this Camera camera, Vector3 worldPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldPos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_EstimateZoomFactorSpherical_Public_Static_Single_Camera_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0008AC94 File Offset: 0x00088E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76326, RefRangeEnd = 76327, XrefRangeStart = 76278, XrefRangeEnd = 76326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetVisibleObjects(this Camera camera, CameraViewVolume viewVolume, List<GameObject> visibleObjects)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(viewVolume);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visibleObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEx.NativeMethodInfoPtr_GetVisibleObjects_Public_Static_Void_Camera_CameraViewVolume_List_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0000BCCE File Offset: 0x00009ECE
		public CameraEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0008ACF0 File Offset: 0x00088EF0
		// (set) Token: 0x06001B2B RID: 6955 RVA: 0x0000BCD7 File Offset: 0x00009ED7
		public unsafe static List<GameObject> _objectBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraEx.NativeFieldInfoPtr__objectBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraEx.NativeFieldInfoPtr__objectBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeFieldInfoPtr__objectBuffer;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrent_Public_Static_Boolean_Camera_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_GetFrustumDistanceFromHeight_Public_Static_Single_Camera_Single_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_GetFOVFromDistanceAndHeight_Public_Static_Single_Camera_Single_Single_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_GetFrustumWidthFromDistance_Public_Static_Single_Camera_Single_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_GetFrustumHeightFromDistance_Public_Static_Single_Camera_Single_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_CalculateVolumeAABB_Public_Static_AABB_Camera_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumAABB_Public_Static_AABB_Camera_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_CalculateOrthoAABB_Public_Static_AABB_Camera_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInFrontNearPlane_Public_Static_Boolean_Camera_Vector3_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_GetNearPlaneForward_Public_Static_Plane_Camera_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_GetFarMidPoint_Public_Static_Vector3_Camera_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_GetFarMidOrthoTop_Public_Static_Vector3_Camera_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_GetOrthoFOV_Public_Static_Single_Camera_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_IsPointFacingCamera_Public_Static_Boolean_Camera_Vector3_Vector3_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_GetPointZDistance_Public_Static_Single_Camera_Vector3_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibleSphereExtents_Public_Static_List_1_Vector3_Camera_Sphere_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_ConvertWorldToScreenPoints_Public_Static_List_1_Vector2_Camera_List_1_Vector3_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToEstimatedWorldSize_Public_Static_Single_Camera_Vector3_Single_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_EstimateZoomFactor_Public_Static_Single_Camera_Vector3_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_EstimateZoomFactorSpherical_Public_Static_Single_Camera_Vector3_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibleObjects_Public_Static_Void_Camera_CameraViewVolume_List_1_GameObject_0;
	}
}
