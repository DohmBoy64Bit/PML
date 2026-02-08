using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000187 RID: 391
	public class MeshVertexChunk : global::Il2CppSystem.Object
	{
		// Token: 0x06001E9F RID: 7839 RVA: 0x0009B8E8 File Offset: 0x00099AE8
		// Note: this type is marked as 'beforefieldinit'.
		static MeshVertexChunk()
		{
			Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MeshVertexChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr);
			MeshVertexChunk.NativeFieldInfoPtr__modelSpaceVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, "_modelSpaceVerts");
			MeshVertexChunk.NativeFieldInfoPtr__modelSpaceAABB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, "_modelSpaceAABB");
			MeshVertexChunk.NativeFieldInfoPtr__mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, "_mesh");
			MeshVertexChunk.NativeMethodInfoPtr_get_Item_Public_get_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, 100667963);
			MeshVertexChunk.NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, 100667964);
			MeshVertexChunk.NativeMethodInfoPtr_get_VertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, 100667965);
			MeshVertexChunk.NativeMethodInfoPtr_get_ModelSpaceAABB_Public_get_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, 100667966);
			MeshVertexChunk.NativeMethodInfoPtr__ctor_Public_Void_List_1_Vector3_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, 100667967);
			MeshVertexChunk.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, 100667968);
			MeshVertexChunk.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, 100667969);
			MeshVertexChunk.NativeMethodInfoPtr_GetWorldVertClosestToScreenPt_Public_Vector3_Vector2_Matrix4x4_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr, 100667970);
		}

		// Token: 0x17000AB6 RID: 2742
		public unsafe Vector3 this[int vertexIndex]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82623, XrefRangeEnd = 82626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref vertexIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunk.NativeMethodInfoPtr_get_Item_Public_get_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x0009BA40 File Offset: 0x00099C40
		public unsafe Mesh Mesh
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunk.NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x0009BA80 File Offset: 0x00099C80
		public unsafe int VertexCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82627, RefRangeEnd = 82628, XrefRangeStart = 82626, XrefRangeEnd = 82627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunk.NativeMethodInfoPtr_get_VertexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x0009BABC File Offset: 0x00099CBC
		public unsafe AABB ModelSpaceAABB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunk.NativeMethodInfoPtr_get_ModelSpaceAABB_Public_get_AABB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x0009BAFC File Offset: 0x00099CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82644, RefRangeEnd = 82645, XrefRangeStart = 82628, XrefRangeEnd = 82644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshVertexChunk(List<Vector3> modelSpaceVerts, Mesh mesh)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshVertexChunk>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modelSpaceVerts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunk.NativeMethodInfoPtr__ctor_Public_Void_List_1_Vector3_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0009BB5C File Offset: 0x00099D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82645, XrefRangeEnd = 82651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<Vector3> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunk.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0009BB9C File Offset: 0x00099D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunk.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0009BBDC File Offset: 0x00099DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82668, RefRangeEnd = 82669, XrefRangeStart = 82651, XrefRangeEnd = 82668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetWorldVertClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(screenPoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldMtx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunk.NativeMethodInfoPtr_GetWorldVertClosestToScreenPt_Public_Vector3_Vector2_Matrix4x4_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0000C83F File Offset: 0x0000AA3F
		public MeshVertexChunk(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x0009BC50 File Offset: 0x00099E50
		// (set) Token: 0x06001EAA RID: 7850 RVA: 0x0000C848 File Offset: 0x0000AA48
		public unsafe List<Vector3> _modelSpaceVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunk.NativeFieldInfoPtr__modelSpaceVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunk.NativeFieldInfoPtr__modelSpaceVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x0009BC80 File Offset: 0x00099E80
		// (set) Token: 0x06001EAC RID: 7852 RVA: 0x0000C867 File Offset: 0x0000AA67
		public unsafe AABB _modelSpaceAABB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunk.NativeFieldInfoPtr__modelSpaceAABB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunk.NativeFieldInfoPtr__modelSpaceAABB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x0009BCB0 File Offset: 0x00099EB0
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x0000C886 File Offset: 0x0000AA86
		public unsafe Mesh _mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunk.NativeFieldInfoPtr__mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunk.NativeFieldInfoPtr__mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeFieldInfoPtr__modelSpaceVerts;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeFieldInfoPtr__modelSpaceAABB;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeFieldInfoPtr__mesh;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Vector3_Int32_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_get_VertexCount_Public_get_Int32_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelSpaceAABB_Public_get_AABB_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Vector3_Mesh_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Vector3_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldVertClosestToScreenPt_Public_Vector3_Vector2_Matrix4x4_Camera_0;
	}
}
