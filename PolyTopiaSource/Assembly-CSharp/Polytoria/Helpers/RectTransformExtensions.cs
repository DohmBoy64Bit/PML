using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Helpers
{
	// Token: 0x0200026C RID: 620
	public static class RectTransformExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x06002FA4 RID: 12196 RVA: 0x000DBCB0 File Offset: 0x000D9EB0
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransformExtensions()
		{
			Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Helpers", "RectTransformExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr);
			RectTransformExtensions.NativeMethodInfoPtr_Left_Public_Static_RectTransform_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100670467);
			RectTransformExtensions.NativeMethodInfoPtr_Right_Public_Static_RectTransform_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100670468);
			RectTransformExtensions.NativeMethodInfoPtr_Bottom_Public_Static_RectTransform_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100670469);
			RectTransformExtensions.NativeMethodInfoPtr_Top_Public_Static_RectTransform_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtensions>.NativeClassPtr, 100670470);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000DBD30 File Offset: 0x000D9F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100261, XrefRangeEnd = 100263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectTransform Left(this RectTransform rt, float x)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformExtensions.NativeMethodInfoPtr_Left_Public_Static_RectTransform_RectTransform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x000DBD84 File Offset: 0x000D9F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100263, XrefRangeEnd = 100265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectTransform Right(this RectTransform rt, float x)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformExtensions.NativeMethodInfoPtr_Right_Public_Static_RectTransform_RectTransform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x000DBDD8 File Offset: 0x000D9FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100265, XrefRangeEnd = 100267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectTransform Bottom(this RectTransform rt, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformExtensions.NativeMethodInfoPtr_Bottom_Public_Static_RectTransform_RectTransform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x000DBE2C File Offset: 0x000DA02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100267, XrefRangeEnd = 100269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectTransform Top(this RectTransform rt, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformExtensions.NativeMethodInfoPtr_Top_Public_Static_RectTransform_RectTransform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00012FD8 File Offset: 0x000111D8
		public RectTransformExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeMethodInfoPtr_Left_Public_Static_RectTransform_RectTransform_Single_0;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeMethodInfoPtr_Right_Public_Static_RectTransform_RectTransform_Single_0;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeMethodInfoPtr_Bottom_Public_Static_RectTransform_RectTransform_Single_0;

		// Token: 0x04002470 RID: 9328
		private static readonly IntPtr NativeMethodInfoPtr_Top_Public_Static_RectTransform_RectTransform_Single_0;
	}
}
