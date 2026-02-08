using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000128 RID: 296
	public static class QuaternionEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B84 RID: 7044 RVA: 0x0008C6F0 File Offset: 0x0008A8F0
		// Note: this type is marked as 'beforefieldinit'.
		static QuaternionEx()
		{
			Il2CppClassPointerStore<QuaternionEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "QuaternionEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuaternionEx>.NativeClassPtr);
			QuaternionEx.NativeMethodInfoPtr_RotatePoints_Public_Static_Void_Quaternion_List_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionEx>.NativeClassPtr, 100667418);
			QuaternionEx.NativeMethodInfoPtr_GetRelativeRotation_Public_Static_Quaternion_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionEx>.NativeClassPtr, 100667419);
			QuaternionEx.NativeMethodInfoPtr_Length_Public_Static_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionEx>.NativeClassPtr, 100667420);
			QuaternionEx.NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionEx>.NativeClassPtr, 100667421);
			QuaternionEx.NativeMethodInfoPtr_FromToRotation3D_Public_Static_Quaternion_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionEx>.NativeClassPtr, 100667422);
			QuaternionEx.NativeMethodInfoPtr_FromToRotation2D_Public_Static_Quaternion_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionEx>.NativeClassPtr, 100667423);
			QuaternionEx.NativeMethodInfoPtr_ConvertTo2DRotation_Public_Static_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionEx>.NativeClassPtr, 100667424);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0008C7AC File Offset: 0x0008A9AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77414, RefRangeEnd = 77415, XrefRangeStart = 77405, XrefRangeEnd = 77414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotatePoints(this Quaternion quat, List<Vector3> points, Vector3 pivot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pivot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionEx.NativeMethodInfoPtr_RotatePoints_Public_Static_Void_Quaternion_List_1_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0008C808 File Offset: 0x0008AA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77415, XrefRangeEnd = 77416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion GetRelativeRotation(Quaternion from, Quaternion to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionEx.NativeMethodInfoPtr_GetRelativeRotation_Public_Static_Quaternion_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0008C860 File Offset: 0x0008AA60
		[CallerCount(0)]
		public unsafe static float Length(this Quaternion quat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionEx.NativeMethodInfoPtr_Length_Public_Static_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0008C8A4 File Offset: 0x0008AAA4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 77418, RefRangeEnd = 77442, XrefRangeStart = 77416, XrefRangeEnd = 77418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Normalize(Quaternion quat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionEx.NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0008C8E8 File Offset: 0x0008AAE8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 77461, RefRangeEnd = 77484, XrefRangeStart = 77442, XrefRangeEnd = 77461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion FromToRotation3D(Vector3 from, Vector3 to, Vector3 perp180)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perp180);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionEx.NativeMethodInfoPtr_FromToRotation3D_Public_Static_Quaternion_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0008C950 File Offset: 0x0008AB50
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 77499, RefRangeEnd = 77509, XrefRangeStart = 77484, XrefRangeEnd = 77499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion FromToRotation2D(Vector2 from, Vector2 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionEx.NativeMethodInfoPtr_FromToRotation2D_Public_Static_Quaternion_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0008C9A8 File Offset: 0x0008ABA8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 77512, RefRangeEnd = 77527, XrefRangeStart = 77509, XrefRangeEnd = 77512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertTo2DRotation(this Quaternion quat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionEx.NativeMethodInfoPtr_ConvertTo2DRotation_Public_Static_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0000BD5E File Offset: 0x00009F5E
		public QuaternionEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr_RotatePoints_Public_Static_Void_Quaternion_List_1_Vector3_Vector3_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeRotation_Public_Static_Quaternion_Quaternion_Quaternion_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr_Length_Public_Static_Single_Quaternion_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr_FromToRotation3D_Public_Static_Quaternion_Vector3_Vector3_Vector3_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr_FromToRotation2D_Public_Static_Quaternion_Vector2_Vector2_0;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTo2DRotation_Public_Static_Single_Quaternion_0;
	}
}
