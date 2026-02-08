using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200017D RID: 381
	public static class CylinderMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E59 RID: 7769 RVA: 0x0000C660 File Offset: 0x0000A860
		// Note: this type is marked as 'beforefieldinit'.
		static CylinderMesh()
		{
			Il2CppClassPointerStore<CylinderMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CylinderMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CylinderMesh>.NativeClassPtr);
			CylinderMesh.NativeMethodInfoPtr_CreateCylinder_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderMesh>.NativeClassPtr, 100667931);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0009A60C File Offset: 0x0009880C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81808, RefRangeEnd = 81810, XrefRangeStart = 81704, XrefRangeEnd = 81808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateCylinder(float bottomRadius, float topRadius, float height, int numSlices, int numStacks, int numBottomCapRings, int numTopCapRings, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bottomRadius;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSlices;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numStacks;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBottomCapRings;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numTopCapRings;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderMesh.NativeMethodInfoPtr_CreateCylinder_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Int32_Int32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0000C699 File Offset: 0x0000A899
		public CylinderMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeMethodInfoPtr_CreateCylinder_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Int32_Int32_Color_0;
	}
}
