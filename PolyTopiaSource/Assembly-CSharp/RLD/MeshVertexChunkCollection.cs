using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000188 RID: 392
	public class MeshVertexChunkCollection : global::Il2CppSystem.Object
	{
		// Token: 0x06001EAF RID: 7855 RVA: 0x0009BCE0 File Offset: 0x00099EE0
		// Note: this type is marked as 'beforefieldinit'.
		static MeshVertexChunkCollection()
		{
			Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MeshVertexChunkCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr);
			MeshVertexChunkCollection.NativeFieldInfoPtr__mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, "_mesh");
			MeshVertexChunkCollection.NativeFieldInfoPtr__vertexChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, "_vertexChunks");
			MeshVertexChunkCollection.NativeMethodInfoPtr_get_Item_Public_get_MeshVertexChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, 100667971);
			MeshVertexChunkCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, 100667972);
			MeshVertexChunkCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, 100667978);
			MeshVertexChunkCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_MeshVertexChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, 100667973);
			MeshVertexChunkCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, 100667974);
			MeshVertexChunkCollection.NativeMethodInfoPtr_GetWorldChunksHoveredByPoint_Public_List_1_MeshVertexChunk_Vector3_Matrix4x4_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, 100667975);
			MeshVertexChunkCollection.NativeMethodInfoPtr_GetWorldVertChunkClosestToScreenPt_Public_MeshVertexChunk_Vector2_Matrix4x4_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, 100667976);
			MeshVertexChunkCollection.NativeMethodInfoPtr_FromMesh_Public_Boolean_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, 100667977);
		}

		// Token: 0x17000ABC RID: 2748
		public unsafe MeshVertexChunk this[int chunkIndex]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82672, XrefRangeEnd = 82676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref chunkIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.NativeMethodInfoPtr_get_Item_Public_get_MeshVertexChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshVertexChunk>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x0009BE24 File Offset: 0x0009A024
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82676, XrefRangeEnd = 82677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0009BE60 File Offset: 0x0009A060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82677, XrefRangeEnd = 82685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshVertexChunkCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x0009BE9C File Offset: 0x0009A09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82685, XrefRangeEnd = 82691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<MeshVertexChunk> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_MeshVertexChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<MeshVertexChunk>>(intPtr3) : null;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0009BEDC File Offset: 0x0009A0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0009BF1C File Offset: 0x0009A11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82726, RefRangeEnd = 82727, XrefRangeStart = 82691, XrefRangeEnd = 82726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MeshVertexChunk> GetWorldChunksHoveredByPoint(Vector3 hoverPoint, Matrix4x4 worldMtx, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoverPoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldMtx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.NativeMethodInfoPtr_GetWorldChunksHoveredByPoint_Public_List_1_MeshVertexChunk_Vector3_Matrix4x4_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MeshVertexChunk>>(intPtr3) : null;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0009BF90 File Offset: 0x0009A190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82757, RefRangeEnd = 82758, XrefRangeStart = 82727, XrefRangeEnd = 82757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshVertexChunk GetWorldVertChunkClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.NativeMethodInfoPtr_GetWorldVertChunkClosestToScreenPt_Public_MeshVertexChunk_Vector2_Matrix4x4_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshVertexChunk>(intPtr3) : null;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0009C004 File Offset: 0x0009A204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82835, RefRangeEnd = 82837, XrefRangeStart = 82758, XrefRangeEnd = 82835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FromMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.NativeMethodInfoPtr_FromMesh_Public_Boolean_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0000C8A5 File Offset: 0x0000AAA5
		public MeshVertexChunkCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x0009C054 File Offset: 0x0009A254
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x0000C8AE File Offset: 0x0000AAAE
		public unsafe Mesh _mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunkCollection.NativeFieldInfoPtr__mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunkCollection.NativeFieldInfoPtr__mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x0009C084 File Offset: 0x0009A284
		// (set) Token: 0x06001EBC RID: 7868 RVA: 0x0000C8CD File Offset: 0x0000AACD
		public unsafe List<MeshVertexChunk> _vertexChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunkCollection.NativeFieldInfoPtr__vertexChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshVertexChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshVertexChunkCollection.NativeFieldInfoPtr__vertexChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeFieldInfoPtr__mesh;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeFieldInfoPtr__vertexChunks;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_MeshVertexChunk_Int32_0;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_MeshVertexChunk_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldChunksHoveredByPoint_Public_List_1_MeshVertexChunk_Vector3_Matrix4x4_Camera_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldVertChunkClosestToScreenPt_Public_MeshVertexChunk_Vector2_Matrix4x4_Camera_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_FromMesh_Public_Boolean_Mesh_0;

		// Token: 0x02000395 RID: 917
		[StructLayout(2)]
		public struct VertexChunkIndices
		{
			// Token: 0x06004B47 RID: 19271 RVA: 0x0014A09C File Offset: 0x0014829C
			// Note: this type is marked as 'beforefieldinit'.
			static VertexChunkIndices()
			{
				Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshVertexChunkCollection>.NativeClassPtr, "VertexChunkIndices");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr);
				MeshVertexChunkCollection.VertexChunkIndices.NativeFieldInfoPtr__XIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr, "_XIndex");
				MeshVertexChunkCollection.VertexChunkIndices.NativeFieldInfoPtr__YIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr, "_YIndex");
				MeshVertexChunkCollection.VertexChunkIndices.NativeFieldInfoPtr__ZIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr, "_ZIndex");
				MeshVertexChunkCollection.VertexChunkIndices.NativeMethodInfoPtr_get_XIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr, 100667979);
				MeshVertexChunkCollection.VertexChunkIndices.NativeMethodInfoPtr_get_YIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr, 100667980);
				MeshVertexChunkCollection.VertexChunkIndices.NativeMethodInfoPtr_get_ZIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr, 100667981);
				MeshVertexChunkCollection.VertexChunkIndices.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr, 100667982);
			}

			// Token: 0x1700196D RID: 6509
			// (get) Token: 0x06004B48 RID: 19272 RVA: 0x0014A154 File Offset: 0x00148354
			public unsafe int XIndex
			{
				[CallerCount(63)]
				[CachedScanResults(RefRangeStart = 33677, RefRangeEnd = 33740, XrefRangeStart = 33677, XrefRangeEnd = 33740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.VertexChunkIndices.NativeMethodInfoPtr_get_XIndex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700196E RID: 6510
			// (get) Token: 0x06004B49 RID: 19273 RVA: 0x0014A184 File Offset: 0x00148384
			public unsafe int YIndex
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.VertexChunkIndices.NativeMethodInfoPtr_get_YIndex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700196F RID: 6511
			// (get) Token: 0x06004B4A RID: 19274 RVA: 0x0014A1B4 File Offset: 0x001483B4
			public unsafe int ZIndex
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.VertexChunkIndices.NativeMethodInfoPtr_get_ZIndex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B4B RID: 19275 RVA: 0x0014A1E4 File Offset: 0x001483E4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 82669, RefRangeEnd = 82672, XrefRangeStart = 82669, XrefRangeEnd = 82669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VertexChunkIndices(int xIndex, int yIndex, int zIndex)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref xIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshVertexChunkCollection.VertexChunkIndices.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B4C RID: 19276 RVA: 0x0001C322 File Offset: 0x0001A522
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshVertexChunkCollection.VertexChunkIndices>.NativeClassPtr, ref this));
			}

			// Token: 0x04003A66 RID: 14950
			private static readonly IntPtr NativeFieldInfoPtr__XIndex;

			// Token: 0x04003A67 RID: 14951
			private static readonly IntPtr NativeFieldInfoPtr__YIndex;

			// Token: 0x04003A68 RID: 14952
			private static readonly IntPtr NativeFieldInfoPtr__ZIndex;

			// Token: 0x04003A69 RID: 14953
			private static readonly IntPtr NativeMethodInfoPtr_get_XIndex_Public_get_Int32_0;

			// Token: 0x04003A6A RID: 14954
			private static readonly IntPtr NativeMethodInfoPtr_get_YIndex_Public_get_Int32_0;

			// Token: 0x04003A6B RID: 14955
			private static readonly IntPtr NativeMethodInfoPtr_get_ZIndex_Public_get_Int32_0;

			// Token: 0x04003A6C RID: 14956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

			// Token: 0x04003A6D RID: 14957
			[FieldOffset(0)]
			public int _XIndex;

			// Token: 0x04003A6E RID: 14958
			[FieldOffset(4)]
			public int _YIndex;

			// Token: 0x04003A6F RID: 14959
			[FieldOffset(8)]
			public int _ZIndex;
		}
	}
}
