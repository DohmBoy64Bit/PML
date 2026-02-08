using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000180 RID: 384
	public static class PyramidMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E64 RID: 7780 RVA: 0x0009A960 File Offset: 0x00098B60
		// Note: this type is marked as 'beforefieldinit'.
		static PyramidMesh()
		{
			Il2CppClassPointerStore<PyramidMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PyramidMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PyramidMesh>.NativeClassPtr);
			PyramidMesh.NativeMethodInfoPtr_CreatePyramid_Public_Static_Mesh_Vector3_Single_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidMesh>.NativeClassPtr, 100667936);
			PyramidMesh.NativeMethodInfoPtr_CreateWirePyramid_Public_Static_Mesh_Vector3_Single_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidMesh>.NativeClassPtr, 100667937);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0009A9B8 File Offset: 0x00098BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82037, RefRangeEnd = 82038, XrefRangeStart = 81954, XrefRangeEnd = 82037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreatePyramid(Vector3 baseCenter, float baseWidth, float baseDepth, float height, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidMesh.NativeMethodInfoPtr_CreatePyramid_Public_Static_Mesh_Vector3_Single_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0009AA3C File Offset: 0x00098C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82074, RefRangeEnd = 82075, XrefRangeStart = 82038, XrefRangeEnd = 82074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateWirePyramid(Vector3 baseCenter, float baseWidth, float baseDepth, float height, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidMesh.NativeMethodInfoPtr_CreateWirePyramid_Public_Static_Mesh_Vector3_Single_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		public PyramidMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeMethodInfoPtr_CreatePyramid_Public_Static_Mesh_Vector3_Single_Single_Single_Color_0;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeMethodInfoPtr_CreateWirePyramid_Public_Static_Mesh_Vector3_Single_Single_Single_Color_0;
	}
}
