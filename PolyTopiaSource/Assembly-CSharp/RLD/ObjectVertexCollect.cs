using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020E RID: 526
	public static class ObjectVertexCollect : global::Il2CppSystem.Object
	{
		// Token: 0x060029AA RID: 10666 RVA: 0x000C68A8 File Offset: 0x000C4AA8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectVertexCollect()
		{
			Il2CppClassPointerStore<ObjectVertexCollect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectVertexCollect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectVertexCollect>.NativeClassPtr);
			ObjectVertexCollect.NativeFieldInfoPtr__hierarchyVertsCollectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectVertexCollect>.NativeClassPtr, "_hierarchyVertsCollectBuffer");
			ObjectVertexCollect.NativeMethodInfoPtr_CollectModelSpriteVerts_Public_Static_List_1_Vector3_Sprite_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectVertexCollect>.NativeClassPtr, 100669674);
			ObjectVertexCollect.NativeMethodInfoPtr_CollectWorldSpriteVerts_Public_Static_List_1_Vector3_Sprite_Transform_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectVertexCollect>.NativeClassPtr, 100669675);
			ObjectVertexCollect.NativeMethodInfoPtr_CollectHierarchyVerts_Public_Static_List_1_Vector3_GameObject_BoxFace_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectVertexCollect>.NativeClassPtr, 100669676);
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x000C6928 File Offset: 0x000C4B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92675, XrefRangeEnd = 92692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CollectModelSpriteVerts(Sprite sprite, AABB collectAABB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectAABB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectVertexCollect.NativeMethodInfoPtr_CollectModelSpriteVerts_Public_Static_List_1_Vector3_Sprite_AABB_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x000C6980 File Offset: 0x000C4B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92692, XrefRangeEnd = 92720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CollectWorldSpriteVerts(Sprite sprite, Transform spriteTransform, OBB collectOBB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectOBB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectVertexCollect.NativeMethodInfoPtr_CollectWorldSpriteVerts_Public_Static_List_1_Vector3_Sprite_Transform_OBB_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000C69E8 File Offset: 0x000C4BE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 92744, RefRangeEnd = 92749, XrefRangeStart = 92720, XrefRangeEnd = 92744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> CollectHierarchyVerts(GameObject root, BoxFace collectFace, float collectBoxScale, float collectEps)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectFace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collectBoxScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collectEps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectVertexCollect.NativeMethodInfoPtr_CollectHierarchyVerts_Public_Static_List_1_Vector3_GameObject_BoxFace_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x0001066D File Offset: 0x0000E86D
		public ObjectVertexCollect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x000C6A5C File Offset: 0x000C4C5C
		// (set) Token: 0x060029B0 RID: 10672 RVA: 0x00010676 File Offset: 0x0000E876
		public unsafe static List<Vector3> _hierarchyVertsCollectBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectVertexCollect.NativeFieldInfoPtr__hierarchyVertsCollectBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectVertexCollect.NativeFieldInfoPtr__hierarchyVertsCollectBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeFieldInfoPtr__hierarchyVertsCollectBuffer;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr_CollectModelSpriteVerts_Public_Static_List_1_Vector3_Sprite_AABB_0;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeMethodInfoPtr_CollectWorldSpriteVerts_Public_Static_List_1_Vector3_Sprite_Transform_OBB_0;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeMethodInfoPtr_CollectHierarchyVerts_Public_Static_List_1_Vector3_GameObject_BoxFace_Single_Single_0;
	}
}
