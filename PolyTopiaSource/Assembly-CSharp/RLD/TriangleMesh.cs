using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000184 RID: 388
	public static class TriangleMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E74 RID: 7796 RVA: 0x0009AE3C File Offset: 0x0009903C
		// Note: this type is marked as 'beforefieldinit'.
		static TriangleMesh()
		{
			Il2CppClassPointerStore<TriangleMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TriangleMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriangleMesh>.NativeClassPtr);
			TriangleMesh.NativeMethodInfoPtr_CreateEqXY_Public_Static_Mesh_Vector3_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMesh>.NativeClassPtr, 100667944);
			TriangleMesh.NativeMethodInfoPtr_CreateWireEqXY_Public_Static_Mesh_Vector3_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMesh>.NativeClassPtr, 100667945);
			TriangleMesh.NativeMethodInfoPtr_CreateRightAngledTriangleXY_Public_Static_Mesh_Vector3_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMesh>.NativeClassPtr, 100667946);
			TriangleMesh.NativeMethodInfoPtr_CreateWireRightAngledTriangleXY_Public_Static_Mesh_Vector3_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleMesh>.NativeClassPtr, 100667947);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0009AEBC File Offset: 0x000990BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82362, RefRangeEnd = 82363, XrefRangeStart = 82329, XrefRangeEnd = 82362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateEqXY(Vector3 centroid, float sideLength, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(centroid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sideLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMesh.NativeMethodInfoPtr_CreateEqXY_Public_Static_Mesh_Vector3_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0009AF20 File Offset: 0x00099120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82386, RefRangeEnd = 82387, XrefRangeStart = 82363, XrefRangeEnd = 82386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateWireEqXY(Vector3 centroid, float sideLength, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(centroid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sideLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMesh.NativeMethodInfoPtr_CreateWireEqXY_Public_Static_Mesh_Vector3_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0009AF84 File Offset: 0x00099184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82408, RefRangeEnd = 82409, XrefRangeStart = 82387, XrefRangeEnd = 82408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateRightAngledTriangleXY(Vector3 cornerPosition, float xLength, float yLength, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cornerPosition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMesh.NativeMethodInfoPtr_CreateRightAngledTriangleXY_Public_Static_Mesh_Vector3_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0009AFF8 File Offset: 0x000991F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82430, RefRangeEnd = 82431, XrefRangeStart = 82409, XrefRangeEnd = 82430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateWireRightAngledTriangleXY(Vector3 cornerPosition, float xLength, float yLength, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cornerPosition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleMesh.NativeMethodInfoPtr_CreateWireRightAngledTriangleXY_Public_Static_Mesh_Vector3_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0000C711 File Offset: 0x0000A911
		public TriangleMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeMethodInfoPtr_CreateEqXY_Public_Static_Mesh_Vector3_Single_Color_0;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr_CreateWireEqXY_Public_Static_Mesh_Vector3_Single_Color_0;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeMethodInfoPtr_CreateRightAngledTriangleXY_Public_Static_Mesh_Vector3_Single_Single_Color_0;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeMethodInfoPtr_CreateWireRightAngledTriangleXY_Public_Static_Mesh_Vector3_Single_Single_Color_0;
	}
}
