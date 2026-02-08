using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000121 RID: 289
	public static class GraphicsEx : Object
	{
		// Token: 0x06001B47 RID: 6983 RVA: 0x0008B574 File Offset: 0x00089774
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsEx()
		{
			Il2CppClassPointerStore<GraphicsEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GraphicsEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsEx>.NativeClassPtr);
			GraphicsEx.NativeMethodInfoPtr_DrawWireBox_Public_Static_Void_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsEx>.NativeClassPtr, 100667372);
			GraphicsEx.NativeMethodInfoPtr_DrawWireCornerBox_Public_Static_Void_AABB_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsEx>.NativeClassPtr, 100667373);
			GraphicsEx.NativeMethodInfoPtr_DrawWireBox_Public_Static_Void_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsEx>.NativeClassPtr, 100667374);
			GraphicsEx.NativeMethodInfoPtr_DrawWireCornerBox_Public_Static_Void_OBB_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsEx>.NativeClassPtr, 100667375);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0008B5F4 File Offset: 0x000897F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76945, XrefRangeEnd = 76957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireBox(AABB box)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(box);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsEx.NativeMethodInfoPtr_DrawWireBox_Public_Static_Void_AABB_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0008B62C File Offset: 0x0008982C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76957, XrefRangeEnd = 77019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireCornerBox(AABB box, float wireCornerLinePercentage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(box);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wireCornerLinePercentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsEx.NativeMethodInfoPtr_DrawWireCornerBox_Public_Static_Void_AABB_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0008B670 File Offset: 0x00089870
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 77031, RefRangeEnd = 77037, XrefRangeStart = 77019, XrefRangeEnd = 77031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireBox(OBB box)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(box);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsEx.NativeMethodInfoPtr_DrawWireBox_Public_Static_Void_OBB_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0008B6A8 File Offset: 0x000898A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77083, RefRangeEnd = 77086, XrefRangeStart = 77037, XrefRangeEnd = 77083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawWireCornerBox(OBB box, float wireCornerLinePercentage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(box);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wireCornerLinePercentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsEx.NativeMethodInfoPtr_DrawWireCornerBox_Public_Static_Void_OBB_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0000BD0D File Offset: 0x00009F0D
		public GraphicsEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireBox_Public_Static_Void_AABB_0;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireCornerBox_Public_Static_Void_AABB_Single_0;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireBox_Public_Static_Void_OBB_0;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeMethodInfoPtr_DrawWireCornerBox_Public_Static_Void_OBB_Single_0;
	}
}
