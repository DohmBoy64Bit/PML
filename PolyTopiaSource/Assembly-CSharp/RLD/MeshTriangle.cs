using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200018A RID: 394
	public class MeshTriangle : global::Il2CppSystem.Object
	{
		// Token: 0x06001ECB RID: 7883 RVA: 0x0009C440 File Offset: 0x0009A640
		// Note: this type is marked as 'beforefieldinit'.
		static MeshTriangle()
		{
			Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MeshTriangle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr);
			MeshTriangle.NativeFieldInfoPtr__vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, "_vertices");
			MeshTriangle.NativeFieldInfoPtr__normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, "_normal");
			MeshTriangle.NativeFieldInfoPtr__triangleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, "_triangleIndex");
			MeshTriangle.NativeFieldInfoPtr__vertIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, "_vertIndices");
			MeshTriangle.NativeMethodInfoPtr_get_TriangleIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100667991);
			MeshTriangle.NativeMethodInfoPtr_get_Vertices_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100667992);
			MeshTriangle.NativeMethodInfoPtr_get_Vertex0_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100667993);
			MeshTriangle.NativeMethodInfoPtr_get_Vertex1_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100667994);
			MeshTriangle.NativeMethodInfoPtr_get_Vertex2_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100667995);
			MeshTriangle.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100667996);
			MeshTriangle.NativeMethodInfoPtr_get_VertIndices_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100667997);
			MeshTriangle.NativeMethodInfoPtr_get_VertIndex0_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100667998);
			MeshTriangle.NativeMethodInfoPtr_get_VertIndex1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100667999);
			MeshTriangle.NativeMethodInfoPtr_get_VertIndex2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100668000);
			MeshTriangle.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100668001);
			MeshTriangle.NativeMethodInfoPtr_GetVertIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr, 100668002);
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x0009C5B0 File Offset: 0x0009A7B0
		public unsafe int TriangleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_TriangleIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x0009C5EC File Offset: 0x0009A7EC
		public unsafe Il2CppStructArray<Vector3> Vertices
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82920, XrefRangeEnd = 82925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_Vertices_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x0009C62C File Offset: 0x0009A82C
		public unsafe Vector3 Vertex0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_Vertex0_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x0009C66C File Offset: 0x0009A86C
		public unsafe Vector3 Vertex1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_Vertex1_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x0009C6AC File Offset: 0x0009A8AC
		public unsafe Vector3 Vertex2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_Vertex2_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x0009C6EC File Offset: 0x0009A8EC
		public unsafe Vector3 Normal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x0009C72C File Offset: 0x0009A92C
		public unsafe Il2CppStructArray<int> VertIndices
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82925, XrefRangeEnd = 82930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_VertIndices_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0009C76C File Offset: 0x0009A96C
		public unsafe int VertIndex0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_VertIndex0_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x0009C7A8 File Offset: 0x0009A9A8
		public unsafe int VertIndex1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_VertIndex1_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x0009C7E4 File Offset: 0x0009A9E4
		public unsafe int VertIndex2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_get_VertIndex2_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x0009C820 File Offset: 0x0009AA20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82946, RefRangeEnd = 82947, XrefRangeStart = 82930, XrefRangeEnd = 82946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTriangle(Il2CppStructArray<Vector3> vertices, int triangleIndex, int vertIndex0, int vertIndex1, int vertIndex2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshTriangle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triangleIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertIndex0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertIndex1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertIndex2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x0009C8A4 File Offset: 0x0009AAA4
		[CallerCount(0)]
		public unsafe int GetVertIndex(int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTriangle.NativeMethodInfoPtr_GetVertIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0000C933 File Offset: 0x0000AB33
		public MeshTriangle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x0009C8F0 File Offset: 0x0009AAF0
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x0000C93C File Offset: 0x0000AB3C
		public unsafe Il2CppStructArray<Vector3> _vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTriangle.NativeFieldInfoPtr__vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTriangle.NativeFieldInfoPtr__vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x0009C920 File Offset: 0x0009AB20
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x0000C95B File Offset: 0x0000AB5B
		public unsafe Vector3 _normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTriangle.NativeFieldInfoPtr__normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTriangle.NativeFieldInfoPtr__normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x0009C950 File Offset: 0x0009AB50
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x0000C97A File Offset: 0x0000AB7A
		public unsafe int _triangleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTriangle.NativeFieldInfoPtr__triangleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTriangle.NativeFieldInfoPtr__triangleIndex)) = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x0009C978 File Offset: 0x0009AB78
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x0000C995 File Offset: 0x0000AB95
		public unsafe Il2CppStructArray<int> _vertIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTriangle.NativeFieldInfoPtr__vertIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTriangle.NativeFieldInfoPtr__vertIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeFieldInfoPtr__vertices;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeFieldInfoPtr__normal;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeFieldInfoPtr__triangleIndex;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeFieldInfoPtr__vertIndices;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_get_TriangleIndex_Public_get_Int32_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_get_Vertices_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeMethodInfoPtr_get_Vertex0_Public_get_Vector3_0;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeMethodInfoPtr_get_Vertex1_Public_get_Vector3_0;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeMethodInfoPtr_get_Vertex2_Public_get_Vector3_0;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeMethodInfoPtr_get_VertIndices_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeMethodInfoPtr_get_VertIndex0_Public_get_Int32_0;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr_get_VertIndex1_Public_get_Int32_0;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr_get_VertIndex2_Public_get_Int32_0;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr_GetVertIndex_Public_Int32_Int32_0;
	}
}
