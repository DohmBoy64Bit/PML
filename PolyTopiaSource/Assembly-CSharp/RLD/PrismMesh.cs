using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200017F RID: 383
	public static class PrismMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E60 RID: 7776 RVA: 0x0009A7C8 File Offset: 0x000989C8
		// Note: this type is marked as 'beforefieldinit'.
		static PrismMesh()
		{
			Il2CppClassPointerStore<PrismMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrismMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrismMesh>.NativeClassPtr);
			PrismMesh.NativeMethodInfoPtr_CreateTriangularPrism_Public_Static_Mesh_Vector3_Single_Single_Single_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrismMesh>.NativeClassPtr, 100667934);
			PrismMesh.NativeMethodInfoPtr_CreateWireTriangularPrism_Public_Static_Mesh_Vector3_Single_Single_Single_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrismMesh>.NativeClassPtr, 100667935);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0009A820 File Offset: 0x00098A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81918, RefRangeEnd = 81919, XrefRangeStart = 81853, XrefRangeEnd = 81918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateTriangularPrism(Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrismMesh.NativeMethodInfoPtr_CreateTriangularPrism_Public_Static_Mesh_Vector3_Single_Single_Single_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0009A8C0 File Offset: 0x00098AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81953, RefRangeEnd = 81954, XrefRangeStart = 81919, XrefRangeEnd = 81953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateWireTriangularPrism(Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrismMesh.NativeMethodInfoPtr_CreateWireTriangularPrism_Public_Static_Mesh_Vector3_Single_Single_Single_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0000C6AB File Offset: 0x0000A8AB
		public PrismMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr_CreateTriangularPrism_Public_Static_Mesh_Vector3_Single_Single_Single_Single_Single_Color_0;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr_CreateWireTriangularPrism_Public_Static_Mesh_Vector3_Single_Single_Single_Single_Single_Color_0;
	}
}
