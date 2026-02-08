using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000182 RID: 386
	public static class SphereMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E6D RID: 7789 RVA: 0x0000C6C6 File Offset: 0x0000A8C6
		// Note: this type is marked as 'beforefieldinit'.
		static SphereMesh()
		{
			Il2CppClassPointerStore<SphereMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SphereMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereMesh>.NativeClassPtr);
			SphereMesh.NativeMethodInfoPtr_CreateSphere_Public_Static_Mesh_Single_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereMesh>.NativeClassPtr, 100667941);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0009AC54 File Offset: 0x00098E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82247, RefRangeEnd = 82248, XrefRangeStart = 82215, XrefRangeEnd = 82247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateSphere(float radius, int numSlices, int numStacks, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSlices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numStacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereMesh.NativeMethodInfoPtr_CreateSphere_Public_Static_Mesh_Single_Int32_Int32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0000C6FF File Offset: 0x0000A8FF
		public SphereMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeMethodInfoPtr_CreateSphere_Public_Static_Mesh_Single_Int32_Int32_Color_0;
	}
}
