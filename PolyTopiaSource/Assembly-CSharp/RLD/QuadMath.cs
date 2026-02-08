using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200016C RID: 364
	public static class QuadMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001DF6 RID: 7670 RVA: 0x0009814C File Offset: 0x0009634C
		// Note: this type is marked as 'beforefieldinit'.
		static QuadMath()
		{
			Il2CppClassPointerStore<QuadMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "QuadMath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadMath>.NativeClassPtr);
			QuadMath.NativeMethodInfoPtr_Calc2DQuadRightUp_Public_Static_Void_Single_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667861);
			QuadMath.NativeMethodInfoPtr_Calc2DQuadCornerPoints_Public_Static_List_1_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667862);
			QuadMath.NativeMethodInfoPtr_Calc2DQuadCornerPoints_Public_Static_List_1_Vector2_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667863);
			QuadMath.NativeMethodInfoPtr_Calc3DQuadCornerPoints_Public_Static_List_1_Vector3_Vector3_Vector2_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667864);
			QuadMath.NativeMethodInfoPtr_Calc3DQuadCorner_Public_Static_Vector3_Vector3_Vector2_Quaternion_QuadCorner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667865);
			QuadMath.NativeMethodInfoPtr_Calc3DQuadOBB_Public_Static_OBB_Vector3_Vector2_Quaternion_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667866);
			QuadMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Vector3_Vector3_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667867);
			QuadMath.NativeMethodInfoPtr_RaycastWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Vector3_Vector3_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667868);
			QuadMath.NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Single_Single_Vector3_Vector3_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667869);
			QuadMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Single_Single_Single_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667870);
			QuadMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Single_Single_Vector2_Vector2_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667871);
			QuadMath.NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_Vector2_Single_Single_Single_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667872);
			QuadMath.NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_Vector2_Single_Single_Vector2_Vector2_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMath>.NativeClassPtr, 100667873);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00098280 File Offset: 0x00096480
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80936, RefRangeEnd = 80939, XrefRangeStart = 80927, XrefRangeEnd = 80936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Calc2DQuadRightUp(float degreeRotation, out Vector2 right, out Vector2 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref degreeRotation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &up;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Calc2DQuadRightUp_Public_Static_Void_Single_byref_Vector2_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000982D0 File Offset: 0x000964D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80959, RefRangeEnd = 80962, XrefRangeStart = 80939, XrefRangeEnd = 80959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> Calc2DQuadCornerPoints(Vector2 quadCenter, Vector2 quadSize, float degreeRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Calc2DQuadCornerPoints_Public_Static_List_1_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00098334 File Offset: 0x00096534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80962, XrefRangeEnd = 80977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> Calc2DQuadCornerPoints(Vector2 quadCenter, Vector2 quadSize, Vector2 right, Vector2 up)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(up);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Calc2DQuadCornerPoints_Public_Static_List_1_Vector2_Vector2_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x000983B0 File Offset: 0x000965B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 81002, RefRangeEnd = 81007, XrefRangeStart = 80977, XrefRangeEnd = 81002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> Calc3DQuadCornerPoints(Vector3 quadCenter, Vector2 quadSize, Quaternion quadRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Calc3DQuadCornerPoints_Public_Static_List_1_Vector3_Vector3_Vector2_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00098418 File Offset: 0x00096618
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81016, RefRangeEnd = 81018, XrefRangeStart = 81007, XrefRangeEnd = 81016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Calc3DQuadCorner(Vector3 quadCenter, Vector2 quadSize, Quaternion quadRotation, QuadCorner quadCorner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadRotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadCorner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Calc3DQuadCorner_Public_Static_Vector3_Vector3_Vector2_Quaternion_QuadCorner_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00098494 File Offset: 0x00096694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81018, XrefRangeEnd = 81019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OBB Calc3DQuadOBB(Vector3 quadCenter, Vector2 quadSize, Quaternion quadRotation, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadRotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Calc3DQuadOBB_Public_Static_OBB_Vector3_Vector2_Quaternion_QuadEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00098510 File Offset: 0x00096710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81038, RefRangeEnd = 81040, XrefRangeStart = 81019, XrefRangeEnd = 81038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 quadCenter, float quadWidth, float quadHeight, Vector3 quadRight, Vector3 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadHeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadRight);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadUp);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Vector3_Vector3_QuadEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x000985C8 File Offset: 0x000967C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81082, RefRangeEnd = 81083, XrefRangeStart = 81040, XrefRangeEnd = 81082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RaycastWire(Ray ray, out float t, Vector3 quadCenter, float quadWidth, float quadHeight, Vector3 quadRight, Vector3 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadHeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadRight);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadUp);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_RaycastWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Vector3_Vector3_QuadEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00098680 File Offset: 0x00096880
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81095, RefRangeEnd = 81098, XrefRangeStart = 81083, XrefRangeEnd = 81095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 quadCenter, float quadWidth, float quadHeight, Vector3 quadRight, Vector3 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadHeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadRight);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadUp);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Single_Single_Vector3_Vector3_QuadEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00098738 File Offset: 0x00096938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81098, XrefRangeEnd = 81104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains2DPoint(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, float degreeRotation, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreeRotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Single_Single_Single_QuadEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x000987C8 File Offset: 0x000969C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81109, RefRangeEnd = 81110, XrefRangeStart = 81104, XrefRangeEnd = 81109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains2DPoint(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, Vector2 quadRight, Vector2 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadRight);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadUp);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Single_Single_Vector2_Vector2_QuadEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00098870 File Offset: 0x00096A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81110, XrefRangeEnd = 81112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is2DPointOnBorder(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, float degreeRotation, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreeRotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_Vector2_Single_Single_Single_QuadEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00098900 File Offset: 0x00096B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81136, RefRangeEnd = 81138, XrefRangeStart = 81112, XrefRangeEnd = 81136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Is2DPointOnBorder(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, Vector2 quadRight, Vector2 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadRight);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadUp);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMath.NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_Vector2_Single_Single_Vector2_Vector2_QuadEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0000C596 File Offset: 0x0000A796
		public QuadMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_Calc2DQuadRightUp_Public_Static_Void_Single_byref_Vector2_byref_Vector2_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_Calc2DQuadCornerPoints_Public_Static_List_1_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_Calc2DQuadCornerPoints_Public_Static_List_1_Vector2_Vector2_Vector2_Vector2_Vector2_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_Calc3DQuadCornerPoints_Public_Static_List_1_Vector3_Vector3_Vector2_Quaternion_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_Calc3DQuadCorner_Public_Static_Vector3_Vector3_Vector2_Quaternion_QuadCorner_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_Calc3DQuadOBB_Public_Static_OBB_Vector3_Vector2_Quaternion_QuadEpsilon_0;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Vector3_Vector3_QuadEpsilon_0;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Static_Boolean_Ray_byref_Single_Vector3_Single_Single_Vector3_Vector3_QuadEpsilon_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_Contains3DPoint_Public_Static_Boolean_Vector3_Boolean_Vector3_Single_Single_Vector3_Vector3_QuadEpsilon_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Single_Single_Single_QuadEpsilon_0;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeMethodInfoPtr_Contains2DPoint_Public_Static_Boolean_Vector2_Vector2_Single_Single_Vector2_Vector2_QuadEpsilon_0;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_Vector2_Single_Single_Single_QuadEpsilon_0;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeMethodInfoPtr_Is2DPointOnBorder_Public_Static_Boolean_Vector2_Vector2_Single_Single_Vector2_Vector2_QuadEpsilon_0;
	}
}
