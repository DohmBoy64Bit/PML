using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200018C RID: 396
	public static class RTMeshCompiler : global::Il2CppSystem.Object
	{
		// Token: 0x06001EFC RID: 7932 RVA: 0x0009D040 File Offset: 0x0009B240
		// Note: this type is marked as 'beforefieldinit'.
		static RTMeshCompiler()
		{
			Il2CppClassPointerStore<RTMeshCompiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTMeshCompiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTMeshCompiler>.NativeClassPtr);
			RTMeshCompiler.NativeMethodInfoPtr_CompileEntireScene_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMeshCompiler>.NativeClassPtr, 100668016);
			RTMeshCompiler.NativeMethodInfoPtr_CompileForObject_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMeshCompiler>.NativeClassPtr, 100668017);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0009D098 File Offset: 0x0009B298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83039, RefRangeEnd = 83040, XrefRangeStart = 83030, XrefRangeEnd = 83039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompileEntireScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMeshCompiler.NativeMethodInfoPtr_CompileEntireScene_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0009D0C0 File Offset: 0x0009B2C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83061, RefRangeEnd = 83062, XrefRangeStart = 83040, XrefRangeEnd = 83061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompileForObject(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMeshCompiler.NativeMethodInfoPtr_CompileForObject_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x0000CA73 File Offset: 0x0000AC73
		public RTMeshCompiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_CompileEntireScene_Public_Static_Void_0;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_CompileForObject_Public_Static_Boolean_GameObject_0;
	}
}
