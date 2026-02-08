using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200018B RID: 395
	public class RTMesh : global::Il2CppSystem.Object
	{
		// Token: 0x06001EE1 RID: 7905 RVA: 0x0009C9A8 File Offset: 0x0009ABA8
		// Note: this type is marked as 'beforefieldinit'.
		static RTMesh()
		{
			Il2CppClassPointerStore<RTMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTMesh>.NativeClassPtr);
			RTMesh.NativeFieldInfoPtr__unityMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, "_unityMesh");
			RTMesh.NativeFieldInfoPtr__vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, "_vertices");
			RTMesh.NativeFieldInfoPtr__vertIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, "_vertIndices");
			RTMesh.NativeFieldInfoPtr__numTriangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, "_numTriangles");
			RTMesh.NativeFieldInfoPtr__aabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, "_aabb");
			RTMesh.NativeFieldInfoPtr__meshTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, "_meshTree");
			RTMesh.NativeMethodInfoPtr_get_NumTriangles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668003);
			RTMesh.NativeMethodInfoPtr_get_UnityMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668004);
			RTMesh.NativeMethodInfoPtr_get_AABB_Public_get_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668005);
			RTMesh.NativeMethodInfoPtr_get_IsTreeBuilt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668006);
			RTMesh.NativeMethodInfoPtr__ctor_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668007);
			RTMesh.NativeMethodInfoPtr_Create_Public_Static_RTMesh_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668008);
			RTMesh.NativeMethodInfoPtr_BuildTree_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668009);
			RTMesh.NativeMethodInfoPtr_GetTriangle_Public_MeshTriangle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668010);
			RTMesh.NativeMethodInfoPtr_Raycast_Public_MeshRayHit_Ray_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668011);
			RTMesh.NativeMethodInfoPtr_OverlapVerts_Public_Boolean_OBB_Transform_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668012);
			RTMesh.NativeMethodInfoPtr_OverlapModelVerts_Public_Boolean_OBB_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668013);
			RTMesh.NativeMethodInfoPtr_OverlapModelVerts_Public_Boolean_AABB_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668014);
			RTMesh.NativeMethodInfoPtr_DebugDrawTree_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTMesh>.NativeClassPtr, 100668015);
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x0009CB54 File Offset: 0x0009AD54
		public unsafe int NumTriangles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_get_NumTriangles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x0009CB90 File Offset: 0x0009AD90
		public unsafe Mesh UnityMesh
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_get_UnityMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x0009CBD0 File Offset: 0x0009ADD0
		public unsafe AABB AABB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_get_AABB_Public_get_AABB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x0009CC10 File Offset: 0x0009AE10
		public unsafe bool IsTreeBuilt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_get_IsTreeBuilt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0009CC4C File Offset: 0x0009AE4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82989, RefRangeEnd = 82991, XrefRangeStart = 82947, XrefRangeEnd = 82989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTMesh(Mesh unityMesh)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTMesh>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityMesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr__ctor_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0009CC98 File Offset: 0x0009AE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82991, XrefRangeEnd = 83002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTMesh Create(Mesh unityMesh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityMesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_Create_Public_Static_RTMesh_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTMesh>(intPtr3) : null;
			}
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x0009CCDC File Offset: 0x0009AEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83002, XrefRangeEnd = 83004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildTree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_BuildTree_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x0009CD10 File Offset: 0x0009AF10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83011, RefRangeEnd = 83014, XrefRangeStart = 83004, XrefRangeEnd = 83011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTriangle GetTriangle(int triangleIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref triangleIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_GetTriangle_Public_MeshTriangle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshTriangle>(intPtr3) : null;
			}
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0009CD5C File Offset: 0x0009AF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83014, XrefRangeEnd = 83015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshRayHit Raycast(Ray ray, Matrix4x4 meshTransform)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_Raycast_Public_MeshRayHit_Ray_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshRayHit>(intPtr3) : null;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0009CDC0 File Offset: 0x0009AFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83015, XrefRangeEnd = 83023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OverlapVerts(OBB obb, Transform meshObjectTransform, List<Vector3> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshObjectTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(verts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_OverlapVerts_Public_Boolean_OBB_Transform_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0009CE34 File Offset: 0x0009B034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83023, XrefRangeEnd = 83024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_OverlapModelVerts_Public_Boolean_OBB_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0009CE94 File Offset: 0x0009B094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83024, XrefRangeEnd = 83026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OverlapModelVerts(AABB modelAABB, List<Vector3> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modelAABB);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(verts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_OverlapModelVerts_Public_Boolean_AABB_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0009CEF4 File Offset: 0x0009B0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83026, XrefRangeEnd = 83030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugDrawTree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTMesh.NativeMethodInfoPtr_DebugDrawTree_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
		public RTMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x0009CF28 File Offset: 0x0009B128
		// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x0000C9BD File Offset: 0x0000ABBD
		public unsafe Mesh _unityMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__unityMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__unityMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x0009CF58 File Offset: 0x0009B158
		// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		public unsafe Il2CppStructArray<Vector3> _vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0009CF88 File Offset: 0x0009B188
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x0000C9FB File Offset: 0x0000ABFB
		public unsafe Il2CppStructArray<int> _vertIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__vertIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__vertIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x0009CFB8 File Offset: 0x0009B1B8
		// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x0000CA1A File Offset: 0x0000AC1A
		public unsafe int _numTriangles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__numTriangles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__numTriangles)) = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x0009CFE0 File Offset: 0x0009B1E0
		// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x0000CA35 File Offset: 0x0000AC35
		public unsafe AABB _aabb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__aabb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__aabb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x0009D010 File Offset: 0x0009B210
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x0000CA54 File Offset: 0x0000AC54
		public unsafe MeshTree _meshTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__meshTree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshTree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTMesh.NativeFieldInfoPtr__meshTree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeFieldInfoPtr__unityMesh;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeFieldInfoPtr__vertices;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeFieldInfoPtr__vertIndices;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeFieldInfoPtr__numTriangles;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeFieldInfoPtr__aabb;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeFieldInfoPtr__meshTree;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeMethodInfoPtr_get_NumTriangles_Public_get_Int32_0;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeMethodInfoPtr_get_UnityMesh_Public_get_Mesh_0;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr_get_AABB_Public_get_AABB_0;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTreeBuilt_Public_get_Boolean_0;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RTMesh_Mesh_0;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr_BuildTree_Public_Void_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangle_Public_MeshTriangle_Int32_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_MeshRayHit_Ray_Matrix4x4_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_OverlapVerts_Public_Boolean_OBB_Transform_List_1_Vector3_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_OverlapModelVerts_Public_Boolean_OBB_List_1_Vector3_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_OverlapModelVerts_Public_Boolean_AABB_List_1_Vector3_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_DebugDrawTree_Public_Void_0;
	}
}
