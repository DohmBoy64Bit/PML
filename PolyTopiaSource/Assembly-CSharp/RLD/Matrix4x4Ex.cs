using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000126 RID: 294
	public static class Matrix4x4Ex : global::Il2CppSystem.Object
	{
		// Token: 0x06001B6E RID: 7022 RVA: 0x0008BF78 File Offset: 0x0008A178
		// Note: this type is marked as 'beforefieldinit'.
		static Matrix4x4Ex()
		{
			Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Matrix4x4Ex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr);
			Matrix4x4Ex.NativeMethodInfoPtr_GetInverse_Public_Static_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr, 100667400);
			Matrix4x4Ex.NativeMethodInfoPtr_GetRelativeTransform_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr, 100667401);
			Matrix4x4Ex.NativeMethodInfoPtr_Translation_Public_Static_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr, 100667402);
			Matrix4x4Ex.NativeMethodInfoPtr_RotationMatrixFromRightUp_Public_Static_Matrix4x4_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr, 100667403);
			Matrix4x4Ex.NativeMethodInfoPtr_GetTranslation_Public_Static_Vector3_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr, 100667404);
			Matrix4x4Ex.NativeMethodInfoPtr_GetScale_Public_Static_Vector3_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr, 100667405);
			Matrix4x4Ex.NativeMethodInfoPtr_GetNormalizedAxis_Public_Static_Vector3_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr, 100667406);
			Matrix4x4Ex.NativeMethodInfoPtr_GetNormalizedAxes_Public_Static_Il2CppStructArray_1_Vector3_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr, 100667407);
			Matrix4x4Ex.NativeMethodInfoPtr_TransformPoints_Public_Static_List_1_Vector3_Matrix4x4_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4Ex>.NativeClassPtr, 100667408);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0008C05C File Offset: 0x0008A25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77223, XrefRangeEnd = 77224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetInverse(this Matrix4x4 mtx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mtx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4Ex.NativeMethodInfoPtr_GetInverse_Public_Static_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0008C0A0 File Offset: 0x0008A2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77226, RefRangeEnd = 77227, XrefRangeStart = 77224, XrefRangeEnd = 77226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetRelativeTransform(this Matrix4x4 matrix, Matrix4x4 referenceTransform)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matrix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(referenceTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4Ex.NativeMethodInfoPtr_GetRelativeTransform_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0008C0F8 File Offset: 0x0008A2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77227, XrefRangeEnd = 77234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Translation(Vector3 translation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(translation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4Ex.NativeMethodInfoPtr_Translation_Public_Static_Matrix4x4_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0008C13C File Offset: 0x0008A33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77234, XrefRangeEnd = 77253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 RotationMatrixFromRightUp(Vector3 right, Vector3 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(right);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(up);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4Ex.NativeMethodInfoPtr_RotationMatrixFromRightUp_Public_Static_Matrix4x4_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0008C194 File Offset: 0x0008A394
		[CallerCount(0)]
		public unsafe static Vector3 GetTranslation(this Matrix4x4 matrix)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matrix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4Ex.NativeMethodInfoPtr_GetTranslation_Public_Static_Vector3_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0008C1D8 File Offset: 0x0008A3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77253, XrefRangeEnd = 77256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetScale(this Matrix4x4 matrix)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matrix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4Ex.NativeMethodInfoPtr_GetScale_Public_Static_Vector3_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0008C21C File Offset: 0x0008A41C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 77261, RefRangeEnd = 77266, XrefRangeStart = 77256, XrefRangeEnd = 77261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetNormalizedAxis(this Matrix4x4 matrix, int axisIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matrix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4Ex.NativeMethodInfoPtr_GetNormalizedAxis_Public_Static_Vector3_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0008C270 File Offset: 0x0008A470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77281, RefRangeEnd = 77282, XrefRangeStart = 77266, XrefRangeEnd = 77281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector3> GetNormalizedAxes(this Matrix4x4 matrix)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matrix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4Ex.NativeMethodInfoPtr_GetNormalizedAxes_Public_Static_Il2CppStructArray_1_Vector3_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0008C2B4 File Offset: 0x0008A4B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77308, RefRangeEnd = 77309, XrefRangeStart = 77282, XrefRangeEnd = 77308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> TransformPoints(this Matrix4x4 matrix, List<Vector3> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matrix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4Ex.NativeMethodInfoPtr_TransformPoints_Public_Static_List_1_Vector3_Matrix4x4_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0000BD4C File Offset: 0x00009F4C
		public Matrix4x4Ex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr_GetInverse_Public_Static_Matrix4x4_Matrix4x4_0;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeTransform_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_Translation_Public_Static_Matrix4x4_Vector3_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_RotationMatrixFromRightUp_Public_Static_Matrix4x4_Vector3_Vector3_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_GetTranslation_Public_Static_Vector3_Matrix4x4_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr_GetScale_Public_Static_Vector3_Matrix4x4_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedAxis_Public_Static_Vector3_Matrix4x4_Int32_0;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedAxes_Public_Static_Il2CppStructArray_1_Vector3_Matrix4x4_0;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoints_Public_Static_List_1_Vector3_Matrix4x4_List_1_Vector3_0;
	}
}
