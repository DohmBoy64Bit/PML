using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000181 RID: 385
	public static class QuadMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001E68 RID: 7784 RVA: 0x0009AAC0 File Offset: 0x00098CC0
		// Note: this type is marked as 'beforefieldinit'.
		static QuadMesh()
		{
			Il2CppClassPointerStore<QuadMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "QuadMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadMesh>.NativeClassPtr);
			QuadMesh.NativeMethodInfoPtr_CreateQuadXZ_Public_Static_Mesh_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMesh>.NativeClassPtr, 100667938);
			QuadMesh.NativeMethodInfoPtr_CreateQuadXY_Public_Static_Mesh_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMesh>.NativeClassPtr, 100667939);
			QuadMesh.NativeMethodInfoPtr_CreateWireQuadXY_Public_Static_Mesh_Vector3_Vector2_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadMesh>.NativeClassPtr, 100667940);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0009AB2C File Offset: 0x00098D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82126, RefRangeEnd = 82127, XrefRangeStart = 82075, XrefRangeEnd = 82126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateQuadXZ(float width, float depth, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMesh.NativeMethodInfoPtr_CreateQuadXZ_Public_Static_Mesh_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0009AB8C File Offset: 0x00098D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82178, RefRangeEnd = 82180, XrefRangeStart = 82127, XrefRangeEnd = 82178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateQuadXY(float width, float height, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMesh.NativeMethodInfoPtr_CreateQuadXY_Public_Static_Mesh_Single_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0009ABEC File Offset: 0x00098DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82214, RefRangeEnd = 82215, XrefRangeStart = 82180, XrefRangeEnd = 82214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateWireQuadXY(Vector3 center, Vector2 size, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadMesh.NativeMethodInfoPtr_CreateWireQuadXY_Public_Static_Mesh_Vector3_Vector2_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0000C6BD File Offset: 0x0000A8BD
		public QuadMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeMethodInfoPtr_CreateQuadXZ_Public_Static_Mesh_Single_Single_Color_0;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeMethodInfoPtr_CreateQuadXY_Public_Static_Mesh_Single_Single_Color_0;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeMethodInfoPtr_CreateWireQuadXY_Public_Static_Mesh_Vector3_Vector2_Color_0;
	}
}
