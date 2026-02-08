using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000130 RID: 304
	public static class Vector2Ex : global::Il2CppSystem.Object
	{
		// Token: 0x06001BB9 RID: 7097 RVA: 0x0008D728 File Offset: 0x0008B928
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2Ex()
		{
			Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Vector2Ex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr);
			Vector2Ex.NativeMethodInfoPtr_ConvertDirTo3D_Public_Static_Vector3_Vector2_Vector2_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667457);
			Vector2Ex.NativeMethodInfoPtr_ConvertDirTo3D_Public_Static_Vector3_Vector2_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667458);
			Vector2Ex.NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667459);
			Vector2Ex.NativeMethodInfoPtr_AbsDot_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667460);
			Vector2Ex.NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667461);
			Vector2Ex.NativeMethodInfoPtr_GetNormal_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667462);
			Vector2Ex.NativeMethodInfoPtr_FromValue_Public_Static_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667463);
			Vector2Ex.NativeMethodInfoPtr_GetInverse_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667464);
			Vector2Ex.NativeMethodInfoPtr_GetDistanceToSegment_Public_Static_Single_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667465);
			Vector2Ex.NativeMethodInfoPtr_GetPointClosestToPoint_Public_Static_Int32_List_1_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Ex>.NativeClassPtr, 100667466);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0008D820 File Offset: 0x0008BA20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77932, RefRangeEnd = 77935, XrefRangeStart = 77926, XrefRangeEnd = 77932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ConvertDirTo3D(Vector2 start, Vector2 end, Vector3 zPos, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zPos);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_ConvertDirTo3D_Public_Static_Vector3_Vector2_Vector2_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0008D89C File Offset: 0x0008BA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77935, XrefRangeEnd = 77941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ConvertDirTo3D(Vector2 dir, Vector3 zPos, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zPos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_ConvertDirTo3D_Public_Static_Vector3_Vector2_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0008D904 File Offset: 0x0008BB04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77941, RefRangeEnd = 77943, XrefRangeStart = 77941, XrefRangeEnd = 77941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Abs(this Vector2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0008D948 File Offset: 0x0008BB48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 77943, RefRangeEnd = 77948, XrefRangeStart = 77943, XrefRangeEnd = 77943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float AbsDot(this Vector2 v1, Vector2 v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_AbsDot_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0008D99C File Offset: 0x0008BB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77948, RefRangeEnd = 77949, XrefRangeStart = 77948, XrefRangeEnd = 77948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ToVector3(this Vector2 vec, float z = 0f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0008D9F0 File Offset: 0x0008BBF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77950, RefRangeEnd = 77952, XrefRangeStart = 77949, XrefRangeEnd = 77950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetNormal(this Vector2 vec)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_GetNormal_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0008DA34 File Offset: 0x0008BC34
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77952, RefRangeEnd = 77961, XrefRangeStart = 77952, XrefRangeEnd = 77952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 FromValue(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_FromValue_Public_Static_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0008DA74 File Offset: 0x0008BC74
		[CallerCount(0)]
		public unsafe static Vector2 GetInverse(this Vector2 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_GetInverse_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0008DAB8 File Offset: 0x0008BCB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77975, RefRangeEnd = 77979, XrefRangeStart = 77961, XrefRangeEnd = 77975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetDistanceToSegment(this Vector2 point, Vector2 point0, Vector2 point1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_GetDistanceToSegment_Public_Static_Single_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0008DB20 File Offset: 0x0008BD20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77984, RefRangeEnd = 77985, XrefRangeStart = 77979, XrefRangeEnd = 77984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPointClosestToPoint(List<Vector2> points, Vector2 pt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Ex.NativeMethodInfoPtr_GetPointClosestToPoint_Public_Static_Int32_List_1_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0000BD9D File Offset: 0x00009F9D
		public Vector2Ex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_ConvertDirTo3D_Public_Static_Vector3_Vector2_Vector2_Vector3_Camera_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_ConvertDirTo3D_Public_Static_Vector3_Vector2_Vector3_Camera_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_AbsDot_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr_ToVector3_Public_Static_Vector3_Vector2_Single_0;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_GetNormal_Public_Static_Vector2_Vector2_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_FromValue_Public_Static_Vector2_Single_0;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_GetInverse_Public_Static_Vector2_Vector2_0;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceToSegment_Public_Static_Single_Vector2_Vector2_Vector2_0;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_GetPointClosestToPoint_Public_Static_Int32_List_1_Vector2_Vector2_0;
	}
}
