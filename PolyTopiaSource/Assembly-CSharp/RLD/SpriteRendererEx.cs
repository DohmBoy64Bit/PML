using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200012D RID: 301
	public static class SpriteRendererEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B9F RID: 7071 RVA: 0x0008CF20 File Offset: 0x0008B120
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRendererEx()
		{
			Il2CppClassPointerStore<SpriteRendererEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SpriteRendererEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRendererEx>.NativeClassPtr);
			SpriteRendererEx.NativeMethodInfoPtr_GetWorldCenterPoint_Public_Static_Vector3_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererEx>.NativeClassPtr, 100667437);
			SpriteRendererEx.NativeMethodInfoPtr_GetModelSpaceSize_Public_Static_Vector3_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererEx>.NativeClassPtr, 100667438);
			SpriteRendererEx.NativeMethodInfoPtr_GetModelSpaceAABB_Public_Static_AABB_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererEx>.NativeClassPtr, 100667439);
			SpriteRendererEx.NativeMethodInfoPtr_IsPixelFullyTransparent_Public_Static_Boolean_SpriteRenderer_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRendererEx>.NativeClassPtr, 100667440);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0008CFA0 File Offset: 0x0008B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77695, XrefRangeEnd = 77698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetWorldCenterPoint(this SpriteRenderer spriteRenderer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRendererEx.NativeMethodInfoPtr_GetWorldCenterPoint_Public_Static_Vector3_SpriteRenderer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0008CFE4 File Offset: 0x0008B1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77698, XrefRangeEnd = 77699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetModelSpaceSize(this SpriteRenderer spriteRenderer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRendererEx.NativeMethodInfoPtr_GetModelSpaceSize_Public_Static_Vector3_SpriteRenderer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0008D028 File Offset: 0x0008B228
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 77712, RefRangeEnd = 77719, XrefRangeStart = 77699, XrefRangeEnd = 77712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB GetModelSpaceAABB(this SpriteRenderer spriteRenderer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRendererEx.NativeMethodInfoPtr_GetModelSpaceAABB_Public_Static_AABB_SpriteRenderer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0008D06C File Offset: 0x0008B26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77719, XrefRangeEnd = 77743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPixelFullyTransparent(this SpriteRenderer spriteRenderer, Vector3 worldPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldPos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRendererEx.NativeMethodInfoPtr_IsPixelFullyTransparent_Public_Static_Boolean_SpriteRenderer_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0000BD82 File Offset: 0x00009F82
		public SpriteRendererEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldCenterPoint_Public_Static_Vector3_SpriteRenderer_0;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeMethodInfoPtr_GetModelSpaceSize_Public_Static_Vector3_SpriteRenderer_0;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeMethodInfoPtr_GetModelSpaceAABB_Public_Static_AABB_SpriteRenderer_0;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeMethodInfoPtr_IsPixelFullyTransparent_Public_Static_Boolean_SpriteRenderer_Vector3_0;
	}
}
