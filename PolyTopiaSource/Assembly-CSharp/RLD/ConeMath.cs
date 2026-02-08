using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000153 RID: 339
	public static class ConeMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001D67 RID: 7527 RVA: 0x00095518 File Offset: 0x00093718
		// Note: this type is marked as 'beforefieldinit'.
		static ConeMath()
		{
			Il2CppClassPointerStore<ConeMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ConeMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConeMath>.NativeClassPtr);
			ConeMath.NativeMethodInfoPtr_CalcConeBaseExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeMath>.NativeClassPtr, 100667754);
			ConeMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Quaternion_ConeEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeMath>.NativeClassPtr, 100667755);
			ConeMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_Single_Quaternion_ConeEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeMath>.NativeClassPtr, 100667756);
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00095584 File Offset: 0x00093784
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79962, RefRangeEnd = 79965, XrefRangeStart = 79937, XrefRangeEnd = 79962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CalcConeBaseExtentPoints(Vector3 coneBaseCenter, float coneBaseRadius, Quaternion coneRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coneBaseCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneBaseRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coneRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeMath.NativeMethodInfoPtr_CalcConeBaseExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x000955E8 File Offset: 0x000937E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79991, RefRangeEnd = 79992, XrefRangeStart = 79965, XrefRangeEnd = 79991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 coneBaseCenter, float coneBaseRadius, float coneHeight, Quaternion coneRotation, ConeEpsilon epsilon = default(ConeEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coneBaseCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneBaseRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneHeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coneRotation);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Quaternion_ConeEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0009568C File Offset: 0x0009388C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80004, RefRangeEnd = 80005, XrefRangeStart = 79992, XrefRangeEnd = 80004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsPoint(Vector3 point, Vector3 coneBaseCenter, float coneBaseRadius, float coneHeight, Quaternion coneRotation, ConeEpsilon epsilon = default(ConeEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coneBaseCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneBaseRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coneRotation);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_Single_Quaternion_ConeEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0000C3F2 File Offset: 0x0000A5F2
		public ConeMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_CalcConeBaseExtentPoints_Public_Static_List_1_Vector3_Vector3_Single_Quaternion_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Quaternion_ConeEpsilon_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_Single_Quaternion_ConeEpsilon_0;
	}
}
