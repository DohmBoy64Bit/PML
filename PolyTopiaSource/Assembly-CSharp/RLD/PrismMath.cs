using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000168 RID: 360
	public static class PrismMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001DEC RID: 7660 RVA: 0x00097CA0 File Offset: 0x00095EA0
		// Note: this type is marked as 'beforefieldinit'.
		static PrismMath()
		{
			Il2CppClassPointerStore<PrismMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrismMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrismMath>.NativeClassPtr);
			PrismMath.NativeMethodInfoPtr_CalcTriangPrismCornerPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Single_Single_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrismMath>.NativeClassPtr, 100667849);
			PrismMath.NativeMethodInfoPtr_RaycastTriangular_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Single_Single_Single_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrismMath>.NativeClassPtr, 100667850);
			PrismMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_Single_Single_Single_Single_Quaternion_PrismEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrismMath>.NativeClassPtr, 100667851);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00097D0C File Offset: 0x00095F0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 80542, RefRangeEnd = 80547, XrefRangeStart = 80496, XrefRangeEnd = 80542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CalcTriangPrismCornerPoints(Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Quaternion prismRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prismRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrismMath.NativeMethodInfoPtr_CalcTriangPrismCornerPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Single_Single_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00097DAC File Offset: 0x00095FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80694, RefRangeEnd = 80695, XrefRangeStart = 80547, XrefRangeEnd = 80694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastTriangular(Ray ray, out float t, Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Quaternion prismRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topWidth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topDepth;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prismRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrismMath.NativeMethodInfoPtr_RaycastTriangular_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Single_Single_Single_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00097E68 File Offset: 0x00096068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80731, RefRangeEnd = 80732, XrefRangeStart = 80695, XrefRangeEnd = 80731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsPoint(Vector3 point, Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Quaternion prismRotation, PrismEpsilon epsilon = default(PrismEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topWidth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topDepth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prismRotation);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrismMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_Single_Single_Single_Single_Quaternion_PrismEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x0000C584 File Offset: 0x0000A784
		public PrismMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_CalcTriangPrismCornerPoints_Public_Static_List_1_Vector3_Vector3_Single_Single_Single_Single_Single_Quaternion_0;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTriangular_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Single_Single_Single_Quaternion_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Single_Single_Single_Single_Single_Quaternion_PrismEpsilon_0;

		// Token: 0x02000393 RID: 915
		[ObfuscatedName("RLD.PrismMath+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004B37 RID: 19255 RVA: 0x00149DDC File Offset: 0x00147FDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PrismMath.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrismMath>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrismMath.__c>.NativeClassPtr);
				PrismMath.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrismMath.__c>.NativeClassPtr, "<>9");
				PrismMath.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrismMath.__c>.NativeClassPtr, "<>9__1_0");
				PrismMath.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrismMath.__c>.NativeClassPtr, 100667853);
				PrismMath.__c.NativeMethodInfoPtr__RaycastTriangular_b__1_0_Internal_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrismMath.__c>.NativeClassPtr, 100667854);
			}

			// Token: 0x06004B38 RID: 19256 RVA: 0x00149E58 File Offset: 0x00148058
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrismMath.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrismMath.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B39 RID: 19257 RVA: 0x00149E94 File Offset: 0x00148094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80495, XrefRangeEnd = 80496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RaycastTriangular_b__1_0(float t0, float t1)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrismMath.__c.NativeMethodInfoPtr__RaycastTriangular_b__1_0_Internal_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B3A RID: 19258 RVA: 0x0001C2C8 File Offset: 0x0001A4C8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001969 RID: 6505
			// (get) Token: 0x06004B3B RID: 19259 RVA: 0x00149EEC File Offset: 0x001480EC
			// (set) Token: 0x06004B3C RID: 19260 RVA: 0x0001C2D1 File Offset: 0x0001A4D1
			public unsafe static PrismMath.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrismMath.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrismMath.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrismMath.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700196A RID: 6506
			// (get) Token: 0x06004B3D RID: 19261 RVA: 0x00149F14 File Offset: 0x00148114
			// (set) Token: 0x06004B3E RID: 19262 RVA: 0x0001C2E3 File Offset: 0x0001A4E3
			public unsafe static Comparison<float> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrismMath.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrismMath.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A5E RID: 14942
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003A5F RID: 14943
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04003A60 RID: 14944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A61 RID: 14945
			private static readonly IntPtr NativeMethodInfoPtr__RaycastTriangular_b__1_0_Internal_Int32_Single_Single_0;
		}
	}
}
