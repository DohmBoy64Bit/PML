using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200016F RID: 367
	public static class SphereMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001E0B RID: 7691 RVA: 0x00098C08 File Offset: 0x00096E08
		// Note: this type is marked as 'beforefieldinit'.
		static SphereMath()
		{
			Il2CppClassPointerStore<SphereMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SphereMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereMath>.NativeClassPtr);
			SphereMath.NativeMethodInfoPtr_CalcRightUpExtents_Public_Static_List_1_Vector3_Vector3_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereMath>.NativeClassPtr, 100667878);
			SphereMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Vector3_Single_SphereEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereMath>.NativeClassPtr, 100667879);
			SphereMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_SphereEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereMath>.NativeClassPtr, 100667880);
			SphereMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_byref_Single_Vector3_Single_SphereEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereMath>.NativeClassPtr, 100667881);
			SphereMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_SphereEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereMath>.NativeClassPtr, 100667882);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00098C9C File Offset: 0x00096E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81165, RefRangeEnd = 81166, XrefRangeStart = 81146, XrefRangeEnd = 81165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CalcRightUpExtents(Vector3 sphereCenter, float sphereRadius, Vector3 right, Vector3 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sphereCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(up);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereMath.NativeMethodInfoPtr_CalcRightUpExtents_Public_Static_List_1_Vector3_Vector3_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00098D14 File Offset: 0x00096F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81166, XrefRangeEnd = 81167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sphereCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Vector3_Single_SphereEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00098D88 File Offset: 0x00096F88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81169, RefRangeEnd = 81173, XrefRangeStart = 81167, XrefRangeEnd = 81169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sphereCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_SphereEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00098E0C File Offset: 0x0009700C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81173, XrefRangeEnd = 81175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t0, out float t1, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sphereCenter);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_byref_Single_Vector3_Single_SphereEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00098E9C File Offset: 0x0009709C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81175, RefRangeEnd = 81176, XrefRangeStart = 81175, XrefRangeEnd = 81175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsPoint(Vector3 point, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sphereCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_SphereEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		public SphereMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr_CalcRightUpExtents_Public_Static_List_1_Vector3_Vector3_Single_Vector3_Vector3_0;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Vector3_Single_SphereEpsilon_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_SphereEpsilon_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_byref_Single_Vector3_Single_SphereEpsilon_0;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_SphereEpsilon_0;
	}
}
