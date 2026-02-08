using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200014F RID: 335
	public static class BoxMath : global::Il2CppSystem.Object
	{
		// Token: 0x06001D41 RID: 7489 RVA: 0x0009466C File Offset: 0x0009286C
		// Note: this type is marked as 'beforefieldinit'.
		static BoxMath()
		{
			Il2CppClassPointerStore<BoxMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxMath");
			BoxMath.NativeFieldInfoPtr__allBoxFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, "_allBoxFaces");
			BoxMath.NativeFieldInfoPtr_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, "A");
			BoxMath.NativeFieldInfoPtr_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, "B");
			BoxMath.NativeFieldInfoPtr_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, "R");
			BoxMath.NativeFieldInfoPtr_absR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, "absR");
			BoxMath.NativeMethodInfoPtr_get_AllBoxFaces_Public_Static_get_List_1_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667730);
			BoxMath.NativeMethodInfoPtr_GetFaceAxisIndex_Public_Static_Int32_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667731);
			BoxMath.NativeMethodInfoPtr_GetFaceClosestToPoint_Public_Static_BoxFaceDesc_Vector3_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667732);
			BoxMath.NativeMethodInfoPtr_GetFaceClosestToPoint_Public_Static_BoxFaceDesc_Vector3_Vector3_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667733);
			BoxMath.NativeMethodInfoPtr_GetMostAlignedFace_Public_Static_BoxFace_Vector3_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667734);
			BoxMath.NativeMethodInfoPtr_CalcBoxFaceSize_Public_Static_Vector3_Vector3_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667735);
			BoxMath.NativeMethodInfoPtr_GetBoxFaceAreaDesc_Public_Static_BoxFaceAreaDesc_Vector3_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667736);
			BoxMath.NativeMethodInfoPtr_CalcBoxFacePlane_Public_Static_Plane_Vector3_Vector3_Quaternion_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667737);
			BoxMath.NativeMethodInfoPtr_CalcBoxFaceNormal_Public_Static_Vector3_Vector3_Vector3_Quaternion_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667738);
			BoxMath.NativeMethodInfoPtr_CalcBoxFaceCenter_Public_Static_Vector3_Vector3_Vector3_Quaternion_BoxFace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667739);
			BoxMath.NativeMethodInfoPtr_CalcBoxCornerPoints_Public_Static_List_1_Vector3_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667740);
			BoxMath.NativeMethodInfoPtr_TransformBox_Public_Static_Void_Vector3_Vector3_Matrix4x4_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667741);
			BoxMath.NativeMethodInfoPtr_BoxIntersectsBox_Public_Static_Boolean_Vector3_Vector3_Quaternion_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667742);
			BoxMath.NativeMethodInfoPtr_CalcBoxPtClosestToPt_Public_Static_Vector3_Vector3_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667743);
			BoxMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Vector3_Vector3_Quaternion_BoxEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667744);
			BoxMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Quaternion_BoxEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667745);
			BoxMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Vector3_Quaternion_BoxEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMath>.NativeClassPtr, 100667746);
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0009484C File Offset: 0x00092A4C
		public unsafe static List<BoxFace> AllBoxFaces
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 79509, RefRangeEnd = 79512, XrefRangeStart = 79499, XrefRangeEnd = 79509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_get_AllBoxFaces_Public_Static_get_List_1_BoxFace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BoxFace>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00094880 File Offset: 0x00092A80
		[CallerCount(0)]
		public unsafe static int GetFaceAxisIndex(BoxFace face)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(face);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_GetFaceAxisIndex_Public_Static_Int32_BoxFace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x000948C4 File Offset: 0x00092AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79512, XrefRangeEnd = 79537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BoxFaceDesc GetFaceClosestToPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_GetFaceClosestToPoint_Public_Static_BoxFaceDesc_Vector3_Vector3_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxFaceDesc>(intPtr3) : null;
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00094940 File Offset: 0x00092B40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79562, RefRangeEnd = 79564, XrefRangeStart = 79537, XrefRangeEnd = 79562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BoxFaceDesc GetFaceClosestToPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, Vector3 viewVector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(viewVector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_GetFaceClosestToPoint_Public_Static_BoxFaceDesc_Vector3_Vector3_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxFaceDesc>(intPtr3) : null;
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x000949D0 File Offset: 0x00092BD0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 79581, RefRangeEnd = 79586, XrefRangeStart = 79564, XrefRangeEnd = 79581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BoxFace GetMostAlignedFace(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_GetMostAlignedFace_Public_Static_BoxFace_Vector3_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxFace>(intPtr3) : null;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00094A4C File Offset: 0x00092C4C
		[CallerCount(0)]
		public unsafe static Vector3 CalcBoxFaceSize(Vector3 boxSize, BoxFace boxFace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxFace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_CalcBoxFaceSize_Public_Static_Vector3_Vector3_BoxFace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00094AA4 File Offset: 0x00092CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79586, RefRangeEnd = 79587, XrefRangeStart = 79586, XrefRangeEnd = 79586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BoxFaceAreaDesc GetBoxFaceAreaDesc(Vector3 boxSize, BoxFace boxFace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxFace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_GetBoxFaceAreaDesc_Public_Static_BoxFaceAreaDesc_Vector3_BoxFace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxFaceAreaDesc>(intPtr3) : null;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00094AFC File Offset: 0x00092CFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79609, RefRangeEnd = 79611, XrefRangeStart = 79587, XrefRangeEnd = 79609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Plane CalcBoxFacePlane(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxFace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_CalcBoxFacePlane_Public_Static_Plane_Vector3_Vector3_Quaternion_BoxFace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00094B78 File Offset: 0x00092D78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79625, RefRangeEnd = 79627, XrefRangeStart = 79611, XrefRangeEnd = 79625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 CalcBoxFaceNormal(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxFace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_CalcBoxFaceNormal_Public_Static_Vector3_Vector3_Vector3_Quaternion_BoxFace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00094BF4 File Offset: 0x00092DF4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 79641, RefRangeEnd = 79659, XrefRangeStart = 79627, XrefRangeEnd = 79641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 CalcBoxFaceCenter(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxFace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_CalcBoxFaceCenter_Public_Static_Vector3_Vector3_Vector3_Quaternion_BoxFace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00094C70 File Offset: 0x00092E70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 79677, RefRangeEnd = 79681, XrefRangeStart = 79659, XrefRangeEnd = 79677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CalcBoxCornerPoints(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_CalcBoxCornerPoints_Public_Static_List_1_Vector3_Vector3_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00094CD8 File Offset: 0x00092ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79681, RefRangeEnd = 79682, XrefRangeStart = 79681, XrefRangeEnd = 79681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TransformBox(Vector3 boxCenter, Vector3 boxSize, Matrix4x4 transformMatrix, out Vector3 newBoxCenter, out Vector3 newBoxSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformMatrix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newBoxCenter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newBoxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_TransformBox_Public_Static_Void_Vector3_Vector3_Matrix4x4_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00094D50 File Offset: 0x00092F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79764, RefRangeEnd = 79765, XrefRangeStart = 79682, XrefRangeEnd = 79764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BoxIntersectsBox(Vector3 center0, Vector3 size0, Quaternion rotation0, Vector3 center1, Vector3 size1, Quaternion rotation1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(center1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size1);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_BoxIntersectsBox_Public_Static_Boolean_Vector3_Vector3_Quaternion_Vector3_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00094DF0 File Offset: 0x00092FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79783, RefRangeEnd = 79784, XrefRangeStart = 79765, XrefRangeEnd = 79783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 CalcBoxPtClosestToPt(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_CalcBoxPtClosestToPt_Public_Static_Vector3_Vector3_Vector3_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00094E6C File Offset: 0x0009306C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 79788, RefRangeEnd = 79793, XrefRangeStart = 79784, XrefRangeEnd = 79788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = default(BoxEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Vector3_Vector3_Quaternion_BoxEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00094EF8 File Offset: 0x000930F8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 79824, RefRangeEnd = 79835, XrefRangeStart = 79793, XrefRangeEnd = 79824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Raycast(Ray ray, out float t, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = default(BoxEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Quaternion_BoxEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00094F94 File Offset: 0x00093194
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 79838, RefRangeEnd = 79844, XrefRangeStart = 79835, XrefRangeEnd = 79838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = default(BoxEpsilon))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxSize);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boxRotation);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epsilon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMath.NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Vector3_Quaternion_BoxEpsilon_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x0000C386 File Offset: 0x0000A586
		public BoxMath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00095020 File Offset: 0x00093220
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0000C38F File Offset: 0x0000A58F
		public unsafe static List<BoxFace> _allBoxFaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxMath.NativeFieldInfoPtr__allBoxFaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BoxFace>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxMath.NativeFieldInfoPtr__allBoxFaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00095048 File Offset: 0x00093248
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x0000C3A1 File Offset: 0x0000A5A1
		public unsafe static Il2CppStructArray<Vector3> A
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxMath.NativeFieldInfoPtr_A, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxMath.NativeFieldInfoPtr_A, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00095070 File Offset: 0x00093270
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0000C3B3 File Offset: 0x0000A5B3
		public unsafe static Il2CppStructArray<Vector3> B
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxMath.NativeFieldInfoPtr_B, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxMath.NativeFieldInfoPtr_B, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00095098 File Offset: 0x00093298
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0000C3C5 File Offset: 0x0000A5C5
		public unsafe static Il2CppObjectBase R
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxMath.NativeFieldInfoPtr_R, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxMath.NativeFieldInfoPtr_R, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x000950C0 File Offset: 0x000932C0
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0000C3D7 File Offset: 0x0000A5D7
		public unsafe static Il2CppObjectBase absR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoxMath.NativeFieldInfoPtr_absR, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoxMath.NativeFieldInfoPtr_absR, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeFieldInfoPtr__allBoxFaces;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeFieldInfoPtr_A;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeFieldInfoPtr_B;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeFieldInfoPtr_R;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeFieldInfoPtr_absR;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_get_AllBoxFaces_Public_Static_get_List_1_BoxFace_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_GetFaceAxisIndex_Public_Static_Int32_BoxFace_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr_GetFaceClosestToPoint_Public_Static_BoxFaceDesc_Vector3_Vector3_Vector3_Quaternion_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_GetFaceClosestToPoint_Public_Static_BoxFaceDesc_Vector3_Vector3_Vector3_Quaternion_Vector3_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr_GetMostAlignedFace_Public_Static_BoxFace_Vector3_Vector3_Quaternion_Vector3_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_CalcBoxFaceSize_Public_Static_Vector3_Vector3_BoxFace_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_GetBoxFaceAreaDesc_Public_Static_BoxFaceAreaDesc_Vector3_BoxFace_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_CalcBoxFacePlane_Public_Static_Plane_Vector3_Vector3_Quaternion_BoxFace_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr_CalcBoxFaceNormal_Public_Static_Vector3_Vector3_Vector3_Quaternion_BoxFace_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_CalcBoxFaceCenter_Public_Static_Vector3_Vector3_Vector3_Quaternion_BoxFace_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_CalcBoxCornerPoints_Public_Static_List_1_Vector3_Vector3_Vector3_Quaternion_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr_TransformBox_Public_Static_Void_Vector3_Vector3_Matrix4x4_byref_Vector3_byref_Vector3_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr_BoxIntersectsBox_Public_Static_Boolean_Vector3_Vector3_Quaternion_Vector3_Vector3_Quaternion_0;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeMethodInfoPtr_CalcBoxPtClosestToPt_Public_Static_Vector3_Vector3_Vector3_Vector3_Quaternion_0;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Vector3_Vector3_Quaternion_BoxEpsilon_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_Single_Vector3_Vector3_Quaternion_BoxEpsilon_0;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Static_Boolean_Vector3_Vector3_Vector3_Quaternion_BoxEpsilon_0;
	}
}
