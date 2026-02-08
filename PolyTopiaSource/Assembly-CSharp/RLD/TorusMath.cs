using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000171 RID: 369
	public static class TorusMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001E12 RID: 7698 RVA: 0x00098F10 File Offset: 0x00097110
		// Note: this type is marked as 'beforefieldinit'.
		static TorusMath()
		{
			Il2CppClassPointerStore<TorusMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TorusMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TorusMath>.NativeClassPtr);
			TorusMath.NativeMethodInfoPtr_CalcSphereRadius_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusMath>.NativeClassPtr, 100667883);
			TorusMath.NativeMethodInfoPtr_CalcCylModelAABB_Public_Static_AABB_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusMath>.NativeClassPtr, 100667884);
			TorusMath.NativeMethodInfoPtr_CalcCylAABB_Public_Static_AABB_Vector3_Single_Single_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusMath>.NativeClassPtr, 100667885);
			TorusMath.NativeMethodInfoPtr_Calc3DHrzExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusMath>.NativeClassPtr, 100667886);
			TorusMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Quaternion_TorusEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusMath>.NativeClassPtr, 100667887);
			TorusMath.NativeMethodInfoPtr_RaycastCylindrical_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Single_Quaternion_TorusEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusMath>.NativeClassPtr, 100667888);
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00098FB8 File Offset: 0x000971B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81176, RefRangeEnd = 81177, XrefRangeStart = 81176, XrefRangeEnd = 81176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalcSphereRadius(float torusCoreRadius, float torusTubeRadius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref torusCoreRadius;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusTubeRadius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusMath.NativeMethodInfoPtr_CalcSphereRadius_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00099004 File Offset: 0x00097204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81177, XrefRangeEnd = 81180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcCylModelAABB(float torusCoreRadius, float torusHrzRadius, float torusVertRadius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref torusCoreRadius;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusHrzRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusVertRadius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusMath.NativeMethodInfoPtr_CalcCylModelAABB_Public_Static_AABB_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00099060 File Offset: 0x00097260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81187, RefRangeEnd = 81188, XrefRangeStart = 81180, XrefRangeEnd = 81187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcCylAABB(Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(torusCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusCoreRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusHrzRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusVertRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(torusRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusMath.NativeMethodInfoPtr_CalcCylAABB_Public_Static_AABB_Vector3_Single_Single_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x000990E4 File Offset: 0x000972E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81213, RefRangeEnd = 81215, XrefRangeStart = 81188, XrefRangeEnd = 81213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> Calc3DHrzExtentPoints(Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(torusCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusCoreRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusTubeRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(torusRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusMath.NativeMethodInfoPtr_Calc3DHrzExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00099158 File Offset: 0x00097358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81227, RefRangeEnd = 81228, XrefRangeStart = 81215, XrefRangeEnd = 81227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation, TorusEpsilon epsilon = default(TorusEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(torusCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusCoreRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusTubeRadius;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(torusRotation);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Quaternion_TorusEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000991FC File Offset: 0x000973FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81240, RefRangeEnd = 81241, XrefRangeStart = 81228, XrefRangeEnd = 81240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastCylindrical(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation, TorusEpsilon epsilon = default(TorusEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(torusCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusCoreRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusHrzRadius;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torusVertRadius;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(torusRotation);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusMath.NativeMethodInfoPtr_RaycastCylindrical_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Single_Quaternion_TorusEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0000C5B1 File Offset: 0x0000A7B1
		public TorusMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_CalcSphereRadius_Public_Static_Single_Single_Single_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_CalcCylModelAABB_Public_Static_AABB_Single_Single_Single_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr_CalcCylAABB_Public_Static_AABB_Vector3_Single_Single_Single_Quaternion_0;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeMethodInfoPtr_Calc3DHrzExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Quaternion_0;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Quaternion_TorusEpsilon_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr_RaycastCylindrical_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Single_Quaternion_TorusEpsilon_0;
	}
}
