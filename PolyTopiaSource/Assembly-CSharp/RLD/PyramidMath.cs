using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200016A RID: 362
	public static class PyramidMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001DF1 RID: 7665 RVA: 0x00097F28 File Offset: 0x00096128
		// Note: this type is marked as 'beforefieldinit'.
		static PyramidMath()
		{
			Il2CppClassPointerStore<PyramidMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PyramidMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PyramidMath>.NativeClassPtr);
			PyramidMath.NativeMethodInfoPtr_CalcBaseCornerPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidMath>.NativeClassPtr, 100667855);
			PyramidMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidMath>.NativeClassPtr, 100667856);
			PyramidMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_Single_Single_Quaternion_PyramidEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidMath>.NativeClassPtr, 100667857);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00097F94 File Offset: 0x00096194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80757, RefRangeEnd = 80759, XrefRangeStart = 80732, XrefRangeEnd = 80757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CalcBaseCornerPoints(Vector3 baseCenter, float baseWidth, float baseDepth, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidMath.NativeMethodInfoPtr_CalcBaseCornerPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00098008 File Offset: 0x00096208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80880, RefRangeEnd = 80881, XrefRangeStart = 80759, XrefRangeEnd = 80880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 baseCenter, float baseWidth, float baseDepth, float height, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000980A8 File Offset: 0x000962A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80926, RefRangeEnd = 80927, XrefRangeStart = 80881, XrefRangeEnd = 80926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsPoint(Vector3 point, Vector3 baseCenter, float baseWidth, float baseDepth, float height, Quaternion rotation, PyramidEpsilon epsilon = default(PyramidEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_Single_Single_Quaternion_PyramidEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0000C58D File Offset: 0x0000A78D
		public PyramidMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_CalcBaseCornerPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Quaternion_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Single_Quaternion_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_Single_Single_Quaternion_PyramidEpsilon_0;

		// Token: 0x02000394 RID: 916
		[ObfuscatedName("RLD.PyramidMath+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004B3F RID: 19263 RVA: 0x00149F3C File Offset: 0x0014813C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PyramidMath.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PyramidMath>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PyramidMath.__c>.NativeClassPtr);
				PyramidMath.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PyramidMath.__c>.NativeClassPtr, "<>9");
				PyramidMath.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PyramidMath.__c>.NativeClassPtr, "<>9__1_0");
				PyramidMath.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidMath.__c>.NativeClassPtr, 100667859);
				PyramidMath.__c.NativeMethodInfoPtr__Raycast_b__1_0_Internal_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidMath.__c>.NativeClassPtr, 100667860);
			}

			// Token: 0x06004B40 RID: 19264 RVA: 0x00149FB8 File Offset: 0x001481B8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PyramidMath.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidMath.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B41 RID: 19265 RVA: 0x00149FF4 File Offset: 0x001481F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Raycast_b__1_0(float t0, float t1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidMath.__c.NativeMethodInfoPtr__Raycast_b__1_0_Internal_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B42 RID: 19266 RVA: 0x0001C2F5 File Offset: 0x0001A4F5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700196B RID: 6507
			// (get) Token: 0x06004B43 RID: 19267 RVA: 0x0014A04C File Offset: 0x0014824C
			// (set) Token: 0x06004B44 RID: 19268 RVA: 0x0001C2FE File Offset: 0x0001A4FE
			public unsafe static PyramidMath.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PyramidMath.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PyramidMath.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PyramidMath.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700196C RID: 6508
			// (get) Token: 0x06004B45 RID: 19269 RVA: 0x0014A074 File Offset: 0x00148274
			// (set) Token: 0x06004B46 RID: 19270 RVA: 0x0001C310 File Offset: 0x0001A510
			public unsafe static Comparison<float> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PyramidMath.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PyramidMath.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A62 RID: 14946
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003A63 RID: 14947
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04003A64 RID: 14948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A65 RID: 14949
			private static readonly IntPtr NativeMethodInfoPtr__Raycast_b__1_0_Internal_Int32_Single_Single_0;
		}
	}
}
