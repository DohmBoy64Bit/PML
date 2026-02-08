using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000183 RID: 387
	public static class TorusMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E70 RID: 7792 RVA: 0x0009ACC4 File Offset: 0x00098EC4
		// Note: this type is marked as 'beforefieldinit'.
		static TorusMesh()
		{
			Il2CppClassPointerStore<TorusMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TorusMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TorusMesh>.NativeClassPtr);
			TorusMesh.NativeMethodInfoPtr_CreateCylindricalTorus_Public_Static_Mesh_Vector3_Single_Single_Single_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusMesh>.NativeClassPtr, 100667942);
			TorusMesh.NativeMethodInfoPtr_CreateTorus_Public_Static_Mesh_Vector3_Single_Single_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusMesh>.NativeClassPtr, 100667943);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0009AD1C File Offset: 0x00098F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82300, RefRangeEnd = 82301, XrefRangeStart = 82248, XrefRangeEnd = 82300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateCylindricalTorus(Vector3 center, float coreRadius, float tubeHrzRadius, float tubeVertRadius, int numTubeSlices, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coreRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tubeHrzRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tubeVertRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numTubeSlices;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusMesh.NativeMethodInfoPtr_CreateCylindricalTorus_Public_Static_Mesh_Vector3_Single_Single_Single_Int32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0009ADAC File Offset: 0x00098FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82328, RefRangeEnd = 82329, XrefRangeStart = 82301, XrefRangeEnd = 82328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateTorus(Vector3 center, float coreRadius, float tubeRadius, int numTubeSlices, int numSlices, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coreRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tubeRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numTubeSlices;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSlices;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusMesh.NativeMethodInfoPtr_CreateTorus_Public_Static_Mesh_Vector3_Single_Single_Int32_Int32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0000C708 File Offset: 0x0000A908
		public TorusMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeMethodInfoPtr_CreateCylindricalTorus_Public_Static_Mesh_Vector3_Single_Single_Single_Int32_Color_0;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeMethodInfoPtr_CreateTorus_Public_Static_Mesh_Vector3_Single_Single_Int32_Int32_Color_0;
	}
}
