using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200017B RID: 379
	public static class BoxMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E51 RID: 7761 RVA: 0x0009A3BC File Offset: 0x000985BC
		// Note: this type is marked as 'beforefieldinit'.
		static BoxMesh()
		{
			Il2CppClassPointerStore<BoxMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxMesh>.NativeClassPtr);
			BoxMesh.NativeMethodInfoPtr_CreateBox_Public_Static_Mesh_Single_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMesh>.NativeClassPtr, 100667927);
			BoxMesh.NativeMethodInfoPtr_CreateWireBox_Public_Static_Mesh_Single_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxMesh>.NativeClassPtr, 100667928);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x0009A414 File Offset: 0x00098614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81590, RefRangeEnd = 81591, XrefRangeStart = 81521, XrefRangeEnd = 81590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateBox(float width, float height, float depth, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMesh.NativeMethodInfoPtr_CreateBox_Public_Static_Mesh_Single_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0009A484 File Offset: 0x00098684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81660, RefRangeEnd = 81661, XrefRangeStart = 81591, XrefRangeEnd = 81660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateWireBox(float width, float height, float depth, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxMesh.NativeMethodInfoPtr_CreateWireBox_Public_Static_Mesh_Single_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x0000C64E File Offset: 0x0000A84E
		public BoxMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeMethodInfoPtr_CreateBox_Public_Static_Mesh_Single_Single_Single_Color_0;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeMethodInfoPtr_CreateWireBox_Public_Static_Mesh_Single_Single_Single_Color_0;
	}
}
