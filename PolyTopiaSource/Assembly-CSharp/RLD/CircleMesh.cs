using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200017C RID: 380
	public static class CircleMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E55 RID: 7765 RVA: 0x0009A4F4 File Offset: 0x000986F4
		// Note: this type is marked as 'beforefieldinit'.
		static CircleMesh()
		{
			Il2CppClassPointerStore<CircleMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CircleMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleMesh>.NativeClassPtr);
			CircleMesh.NativeMethodInfoPtr_CreateCircleXY_Public_Static_Mesh_Single_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleMesh>.NativeClassPtr, 100667929);
			CircleMesh.NativeMethodInfoPtr_CreateWireCircleXY_Public_Static_Mesh_Single_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleMesh>.NativeClassPtr, 100667930);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0009A54C File Offset: 0x0009874C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81685, RefRangeEnd = 81686, XrefRangeStart = 81661, XrefRangeEnd = 81685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateCircleXY(float circleRadius, int numBorderPoints, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref circleRadius;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBorderPoints;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleMesh.NativeMethodInfoPtr_CreateCircleXY_Public_Static_Mesh_Single_Int32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0009A5AC File Offset: 0x000987AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81703, RefRangeEnd = 81704, XrefRangeStart = 81686, XrefRangeEnd = 81703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateWireCircleXY(float circleRadius, int numBorderPoints, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref circleRadius;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBorderPoints;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleMesh.NativeMethodInfoPtr_CreateWireCircleXY_Public_Static_Mesh_Single_Int32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0000C657 File Offset: 0x0000A857
		public CircleMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeMethodInfoPtr_CreateCircleXY_Public_Static_Mesh_Single_Int32_Color_0;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeMethodInfoPtr_CreateWireCircleXY_Public_Static_Mesh_Single_Int32_Color_0;
	}
}
