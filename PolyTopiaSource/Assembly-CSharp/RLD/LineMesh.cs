using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200017E RID: 382
	public static class LineMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E5C RID: 7772 RVA: 0x0009A6B4 File Offset: 0x000988B4
		// Note: this type is marked as 'beforefieldinit'.
		static LineMesh()
		{
			Il2CppClassPointerStore<LineMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "LineMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineMesh>.NativeClassPtr);
			LineMesh.NativeMethodInfoPtr_CreateCoordSystemAxesLines_Public_Static_Mesh_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineMesh>.NativeClassPtr, 100667932);
			LineMesh.NativeMethodInfoPtr_CreateLine_Public_Static_Mesh_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineMesh>.NativeClassPtr, 100667933);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0009A70C File Offset: 0x0009890C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81836, RefRangeEnd = 81837, XrefRangeStart = 81810, XrefRangeEnd = 81836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateCoordSystemAxesLines(float axisLength, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineMesh.NativeMethodInfoPtr_CreateCoordSystemAxesLines_Public_Static_Mesh_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0009A760 File Offset: 0x00098960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81852, RefRangeEnd = 81853, XrefRangeStart = 81837, XrefRangeEnd = 81852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateLine(Vector3 startPoint, Vector3 endPoint, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startPoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineMesh.NativeMethodInfoPtr_CreateLine_Public_Static_Mesh_Vector3_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0000C6A2 File Offset: 0x0000A8A2
		public LineMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeMethodInfoPtr_CreateCoordSystemAxesLines_Public_Static_Mesh_Single_Color_0;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr_CreateLine_Public_Static_Mesh_Vector3_Vector3_Color_0;
	}
}
