using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000186 RID: 390
	public class MeshTree : global::Il2CppSystem.Object
	{
		// Token: 0x06001E8A RID: 7818 RVA: 0x0009B474 File Offset: 0x00099674
		// Note: this type is marked as 'beforefieldinit'.
		static MeshTree()
		{
			Il2CppClassPointerStore<MeshTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MeshTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshTree>.NativeClassPtr);
			MeshTree.NativeFieldInfoPtr__mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, "_mesh");
			MeshTree.NativeFieldInfoPtr__tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, "_tree");
			MeshTree.NativeFieldInfoPtr__nodeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, "_nodeBuffer");
			MeshTree.NativeFieldInfoPtr__nodeHitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, "_nodeHitBuffer");
			MeshTree.NativeFieldInfoPtr__vertexIndexSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, "_vertexIndexSet");
			MeshTree.NativeFieldInfoPtr__isBuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, "_isBuilt");
			MeshTree.NativeMethodInfoPtr_get_IsBuilt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, 100667956);
			MeshTree.NativeMethodInfoPtr__ctor_Public_Void_RTMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, 100667957);
			MeshTree.NativeMethodInfoPtr_Build_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, 100667958);
			MeshTree.NativeMethodInfoPtr_OverlapVerts_Public_Boolean_OBB_MeshTransform_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, 100667959);
			MeshTree.NativeMethodInfoPtr_OverlapModelVerts_Public_Boolean_OBB_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, 100667960);
			MeshTree.NativeMethodInfoPtr_RaycastClosest_Public_MeshRayHit_Ray_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, 100667961);
			MeshTree.NativeMethodInfoPtr_DebugDraw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTree>.NativeClassPtr, 100667962);
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x0009B5A8 File Offset: 0x000997A8
		public unsafe bool IsBuilt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTree.NativeMethodInfoPtr_get_IsBuilt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0009B5E4 File Offset: 0x000997E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82447, XrefRangeEnd = 82477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTree(RTMesh mesh)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshTree>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTree.NativeMethodInfoPtr__ctor_Public_Void_RTMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0009B630 File Offset: 0x00099830
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 82487, RefRangeEnd = 82492, XrefRangeStart = 82477, XrefRangeEnd = 82487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTree.NativeMethodInfoPtr_Build_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x0009B664 File Offset: 0x00099864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82536, RefRangeEnd = 82537, XrefRangeStart = 82492, XrefRangeEnd = 82536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OverlapVerts(OBB obb, MeshTransform meshTransform, List<Vector3> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(verts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTree.NativeMethodInfoPtr_OverlapVerts_Public_Boolean_OBB_MeshTransform_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0009B6D8 File Offset: 0x000998D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82579, RefRangeEnd = 82581, XrefRangeStart = 82537, XrefRangeEnd = 82579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modelOBB);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(verts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTree.NativeMethodInfoPtr_OverlapModelVerts_Public_Boolean_OBB_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0009B738 File Offset: 0x00099938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82618, RefRangeEnd = 82619, XrefRangeStart = 82581, XrefRangeEnd = 82618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshRayHit RaycastClosest(Ray ray, Matrix4x4 meshTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTree.NativeMethodInfoPtr_RaycastClosest_Public_MeshRayHit_Ray_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshRayHit>(intPtr3) : null;
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0009B79C File Offset: 0x0009999C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82619, XrefRangeEnd = 82623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugDraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTree.NativeMethodInfoPtr_DebugDraw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0000C780 File Offset: 0x0000A980
		public MeshTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x0009B7D0 File Offset: 0x000999D0
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x0000C789 File Offset: 0x0000A989
		public unsafe RTMesh _mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x0009B800 File Offset: 0x00099A00
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		public unsafe SphereTree<MeshTriangle> _tree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__tree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereTree<MeshTriangle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__tree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x0009B830 File Offset: 0x00099A30
		// (set) Token: 0x06001E98 RID: 7832 RVA: 0x0000C7C7 File Offset: 0x0000A9C7
		public unsafe List<SphereTreeNode<MeshTriangle>> _nodeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__nodeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SphereTreeNode<MeshTriangle>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__nodeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001E99 RID: 7833 RVA: 0x0009B860 File Offset: 0x00099A60
		// (set) Token: 0x06001E9A RID: 7834 RVA: 0x0000C7E6 File Offset: 0x0000A9E6
		public unsafe List<SphereTreeNodeRayHit<MeshTriangle>> _nodeHitBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__nodeHitBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SphereTreeNodeRayHit<MeshTriangle>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__nodeHitBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x0009B890 File Offset: 0x00099A90
		// (set) Token: 0x06001E9C RID: 7836 RVA: 0x0000C805 File Offset: 0x0000AA05
		public unsafe HashSet<int> _vertexIndexSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__vertexIndexSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__vertexIndexSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0009B8C0 File Offset: 0x00099AC0
		// (set) Token: 0x06001E9E RID: 7838 RVA: 0x0000C824 File Offset: 0x0000AA24
		public unsafe bool _isBuilt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__isBuilt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTree.NativeFieldInfoPtr__isBuilt)) = value;
			}
		}

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeFieldInfoPtr__mesh;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeFieldInfoPtr__tree;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeFieldInfoPtr__nodeBuffer;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeFieldInfoPtr__nodeHitBuffer;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeFieldInfoPtr__vertexIndexSet;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeFieldInfoPtr__isBuilt;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBuilt_Public_get_Boolean_0;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RTMesh_0;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Void_0;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeMethodInfoPtr_OverlapVerts_Public_Boolean_OBB_MeshTransform_List_1_Vector3_0;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeMethodInfoPtr_OverlapModelVerts_Public_Boolean_OBB_List_1_Vector3_0;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr_RaycastClosest_Public_MeshRayHit_Ray_Matrix4x4_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr_DebugDraw_Public_Void_0;
	}
}
