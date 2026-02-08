using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000189 RID: 393
	public class MeshVertexChunkCollectionDb : Singleton<MeshVertexChunkCollectionDb>
	{
		// Token: 0x06001EBD RID: 7869 RVA: 0x0009C0B4 File Offset: 0x0009A2B4
		// Note: this type is marked as 'beforefieldinit'.
		static MeshVertexChunkCollectionDb()
		{
			Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MeshVertexChunkCollectionDb");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr);
			MeshVertexChunkCollectionDb.NativeFieldInfoPtr__vertexChunkCollections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, "_vertexChunkCollections");
			MeshVertexChunkCollectionDb.NativeFieldInfoPtr__meshToVChunkCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, "_meshToVChunkCollection");
			MeshVertexChunkCollectionDb.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, 100667983);
			MeshVertexChunkCollectionDb.NativeMethodInfoPtr_get_Item_Public_get_MeshVertexChunkCollection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, 100667984);
			MeshVertexChunkCollectionDb.NativeMethodInfoPtr_get_Item_Public_get_MeshVertexChunkCollection_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, 100667985);
			MeshVertexChunkCollectionDb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, 100667990);
			MeshVertexChunkCollectionDb.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_MeshVertexChunkCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, 100667986);
			MeshVertexChunkCollectionDb.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, 100667987);
			MeshVertexChunkCollectionDb.NativeMethodInfoPtr_HasChunkCollectionForMesh_Public_Boolean_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, 100667988);
			MeshVertexChunkCollectionDb.NativeMethodInfoPtr_CreateMeshVertChunkCollection_Private_Boolean_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr, 100667989);
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x0009C1AC File Offset: 0x0009A3AC
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82837, XrefRangeEnd = 82838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollectionDb.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC1 RID: 2753
		public unsafe MeshVertexChunkCollection this[int collectionIndex]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82838, XrefRangeEnd = 82842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref collectionIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollectionDb.NativeMethodInfoPtr_get_Item_Public_get_MeshVertexChunkCollection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshVertexChunkCollection>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000AC2 RID: 2754
		public unsafe MeshVertexChunkCollection this[Mesh mesh]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82868, RefRangeEnd = 82869, XrefRangeStart = 82842, XrefRangeEnd = 82868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollectionDb.NativeMethodInfoPtr_get_Item_Public_get_MeshVertexChunkCollection_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshVertexChunkCollection>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0009C284 File Offset: 0x0009A484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82869, XrefRangeEnd = 82889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshVertexChunkCollectionDb()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshVertexChunkCollectionDb>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollectionDb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x0009C2C0 File Offset: 0x0009A4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82889, XrefRangeEnd = 82895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<MeshVertexChunkCollection> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollectionDb.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_MeshVertexChunkCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<MeshVertexChunkCollection>>(intPtr3) : null;
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0009C300 File Offset: 0x0009A500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollectionDb.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0009C340 File Offset: 0x0009A540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82895, XrefRangeEnd = 82899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChunkCollectionForMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollectionDb.NativeMethodInfoPtr_HasChunkCollectionForMesh_Public_Boolean_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x0009C390 File Offset: 0x0009A590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82899, XrefRangeEnd = 82920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreateMeshVertChunkCollection(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollectionDb.NativeMethodInfoPtr_CreateMeshVertChunkCollection_Private_Boolean_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0000C8EC File Offset: 0x0000AAEC
		public MeshVertexChunkCollectionDb(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x0009C3E0 File Offset: 0x0009A5E0
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x0000C8F5 File Offset: 0x0000AAF5
		public unsafe List<MeshVertexChunkCollection> _vertexChunkCollections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunkCollectionDb.NativeFieldInfoPtr__vertexChunkCollections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshVertexChunkCollection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunkCollectionDb.NativeFieldInfoPtr__vertexChunkCollections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x0009C410 File Offset: 0x0009A610
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x0000C914 File Offset: 0x0000AB14
		public unsafe Dictionary<Mesh, MeshVertexChunkCollection> _meshToVChunkCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunkCollectionDb.NativeFieldInfoPtr__meshToVChunkCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Mesh, MeshVertexChunkCollection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunkCollectionDb.NativeFieldInfoPtr__meshToVChunkCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeFieldInfoPtr__vertexChunkCollections;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeFieldInfoPtr__meshToVChunkCollection;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_MeshVertexChunkCollection_Int32_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_MeshVertexChunkCollection_Mesh_0;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_MeshVertexChunkCollection_0;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeMethodInfoPtr_HasChunkCollectionForMesh_Public_Boolean_Mesh_0;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeMethodInfoPtr_CreateMeshVertChunkCollection_Private_Boolean_Mesh_0;
	}
}
