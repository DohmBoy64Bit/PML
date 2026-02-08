using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200012B RID: 299
	public static class RectEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B91 RID: 7057 RVA: 0x0008CAF4 File Offset: 0x0008ACF4
		// Note: this type is marked as 'beforefieldinit'.
		static RectEx()
		{
			Il2CppClassPointerStore<RectEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RectEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectEx>.NativeClassPtr);
			RectEx.NativeMethodInfoPtr_GetCornerPoints_Public_Static_List_1_Vector2_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectEx>.NativeClassPtr, 100667427);
			RectEx.NativeMethodInfoPtr_PlaceBelowCenterHrz_Public_Static_Rect_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectEx>.NativeClassPtr, 100667428);
			RectEx.NativeMethodInfoPtr_InvertScreenY_Public_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectEx>.NativeClassPtr, 100667429);
			RectEx.NativeMethodInfoPtr_FromCenterAndSize_Public_Static_Rect_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectEx>.NativeClassPtr, 100667430);
			RectEx.NativeMethodInfoPtr_FromPoints_Public_Static_Rect_IEnumerable_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectEx>.NativeClassPtr, 100667431);
			RectEx.NativeMethodInfoPtr_FromTexture2D_Public_Static_Rect_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectEx>.NativeClassPtr, 100667432);
			RectEx.NativeMethodInfoPtr_Inflate_Public_Static_Rect_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectEx>.NativeClassPtr, 100667433);
			RectEx.NativeMethodInfoPtr_ContainsAllPoints_Public_Static_Boolean_Rect_IEnumerable_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectEx>.NativeClassPtr, 100667434);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0008CBC4 File Offset: 0x0008ADC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 77562, RefRangeEnd = 77567, XrefRangeStart = 77544, XrefRangeEnd = 77562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2> GetCornerPoints(this Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectEx.NativeMethodInfoPtr_GetCornerPoints_Public_Static_List_1_Vector2_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0008CC08 File Offset: 0x0008AE08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77570, RefRangeEnd = 77573, XrefRangeStart = 77567, XrefRangeEnd = 77570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect PlaceBelowCenterHrz(this Rect rect, Rect other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectEx.NativeMethodInfoPtr_PlaceBelowCenterHrz_Public_Static_Rect_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0008CC60 File Offset: 0x0008AE60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77577, RefRangeEnd = 77579, XrefRangeStart = 77573, XrefRangeEnd = 77577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect InvertScreenY(this Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectEx.NativeMethodInfoPtr_InvertScreenY_Public_Static_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0008CCA4 File Offset: 0x0008AEA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77579, RefRangeEnd = 77582, XrefRangeStart = 77579, XrefRangeEnd = 77579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect FromCenterAndSize(Vector2 center, Vector2 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectEx.NativeMethodInfoPtr_FromCenterAndSize_Public_Static_Rect_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0008CCFC File Offset: 0x0008AEFC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77608, RefRangeEnd = 77617, XrefRangeStart = 77582, XrefRangeEnd = 77608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect FromPoints(IEnumerable<Vector2> points)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectEx.NativeMethodInfoPtr_FromPoints_Public_Static_Rect_IEnumerable_1_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
			}
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0008CD40 File Offset: 0x0008AF40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77617, RefRangeEnd = 77620, XrefRangeStart = 77617, XrefRangeEnd = 77617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect FromTexture2D(Texture2D texture2D)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture2D);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectEx.NativeMethodInfoPtr_FromTexture2D_Public_Static_Rect_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0008CD84 File Offset: 0x0008AF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77620, XrefRangeEnd = 77637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect Inflate(this Rect rect, float inflateAmount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inflateAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectEx.NativeMethodInfoPtr_Inflate_Public_Static_Rect_Rect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0008CDD8 File Offset: 0x0008AFD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77653, RefRangeEnd = 77655, XrefRangeStart = 77637, XrefRangeEnd = 77653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsAllPoints(this Rect rect, IEnumerable<Vector2> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectEx.NativeMethodInfoPtr_ContainsAllPoints_Public_Static_Boolean_Rect_IEnumerable_1_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0000BD70 File Offset: 0x00009F70
		public RectEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr_GetCornerPoints_Public_Static_List_1_Vector2_Rect_0;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeMethodInfoPtr_PlaceBelowCenterHrz_Public_Static_Rect_Rect_Rect_0;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr_InvertScreenY_Public_Static_Rect_Rect_0;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeMethodInfoPtr_FromCenterAndSize_Public_Static_Rect_Vector2_Vector2_0;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr_FromPoints_Public_Static_Rect_IEnumerable_1_Vector2_0;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_FromTexture2D_Public_Static_Rect_Texture2D_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_Inflate_Public_Static_Rect_Rect_Single_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_ContainsAllPoints_Public_Static_Boolean_Rect_IEnumerable_1_Vector2_0;
	}
}
