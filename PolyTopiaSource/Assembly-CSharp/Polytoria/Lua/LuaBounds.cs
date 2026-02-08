using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x02000263 RID: 611
	public class LuaBounds : global::Il2CppSystem.Object
	{
		// Token: 0x06002F39 RID: 12089 RVA: 0x000D9968 File Offset: 0x000D7B68
		// Note: this type is marked as 'beforefieldinit'.
		static LuaBounds()
		{
			Il2CppClassPointerStore<LuaBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaBounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr);
			LuaBounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670392);
			LuaBounds.NativeMethodInfoPtr_New_Public_Static_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670382);
			LuaBounds.NativeMethodInfoPtr_New_Public_Static_Bounds_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670383);
			LuaBounds.NativeMethodInfoPtr_ClosestPoint_Public_Static_Vector3_Bounds_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670384);
			LuaBounds.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Bounds_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670385);
			LuaBounds.NativeMethodInfoPtr_Encapsulate_Public_Static_Void_Bounds_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670386);
			LuaBounds.NativeMethodInfoPtr_Encapsulate_Public_Static_Void_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670387);
			LuaBounds.NativeMethodInfoPtr_Intersects_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670388);
			LuaBounds.NativeMethodInfoPtr_SetMinMax_Public_Static_Void_Bounds_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670389);
			LuaBounds.NativeMethodInfoPtr_SqrDistance_Public_Static_Single_Bounds_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670390);
			LuaBounds.NativeMethodInfoPtr_IntersectRay_Public_Static_Tuple_2_Boolean_Single_Bounds_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr, 100670391);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000D9A74 File Offset: 0x000D7C74
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaBounds()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaBounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000D9AB0 File Offset: 0x000D7CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99976, XrefRangeEnd = 99980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_New_Public_Static_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Bounds>(intPtr3) : null;
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000D9AE4 File Offset: 0x000D7CE4
		[CallerCount(0)]
		public unsafe static Bounds New(Vector3 center, Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_New_Public_Static_Bounds_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Bounds>(intPtr3) : null;
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000D9B3C File Offset: 0x000D7D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99980, XrefRangeEnd = 99981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ClosestPoint(Bounds bounds, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_ClosestPoint_Public_Static_Vector3_Bounds_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000D9B94 File Offset: 0x000D7D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99981, XrefRangeEnd = 99982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains(Bounds bounds, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Bounds_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000D9BE8 File Offset: 0x000D7DE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 99982, RefRangeEnd = 99985, XrefRangeStart = 99982, XrefRangeEnd = 99982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Encapsulate(Bounds bounds, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_Encapsulate_Public_Static_Void_Bounds_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x000D9C30 File Offset: 0x000D7E30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 99982, RefRangeEnd = 99985, XrefRangeStart = 99982, XrefRangeEnd = 99985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Encapsulate(Bounds bounds, Bounds other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_Encapsulate_Public_Static_Void_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x000D9C78 File Offset: 0x000D7E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99985, XrefRangeEnd = 99986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Intersects(Bounds bounds, Bounds other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_Intersects_Public_Static_Boolean_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x000D9CCC File Offset: 0x000D7ECC
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMinMax(Bounds bounds, Vector3 min, Vector3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(min);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(max);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_SetMinMax_Public_Static_Void_Bounds_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x000D9D28 File Offset: 0x000D7F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99986, XrefRangeEnd = 99987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SqrDistance(Bounds bounds, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(point);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_SqrDistance_Public_Static_Single_Bounds_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x000D9D7C File Offset: 0x000D7F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99987, XrefRangeEnd = 99996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tuple<bool, float> IntersectRay(Bounds bounds, Vector3 origin, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(origin);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaBounds.NativeMethodInfoPtr_IntersectRay_Public_Static_Tuple_2_Boolean_Single_Bounds_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<bool, float>>(intPtr3) : null;
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x00012F4D File Offset: 0x0001114D
		public LuaBounds(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Bounds_0;

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Bounds_Vector3_Vector3_0;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Static_Vector3_Bounds_Vector3_0;

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_Bounds_Vector3_0;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Static_Void_Bounds_Vector3_0;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Static_Void_Bounds_Bounds_0;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Static_Boolean_Bounds_Bounds_0;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeMethodInfoPtr_SetMinMax_Public_Static_Void_Bounds_Vector3_Vector3_0;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeMethodInfoPtr_SqrDistance_Public_Static_Single_Bounds_Vector3_0;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeMethodInfoPtr_IntersectRay_Public_Static_Tuple_2_Boolean_Single_Bounds_Vector3_Vector3_0;
	}
}
