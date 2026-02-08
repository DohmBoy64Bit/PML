using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000185 RID: 389
	public class MeshTransform : global::Il2CppSystem.Object
	{
		// Token: 0x06001E7A RID: 7802 RVA: 0x0009B06C File Offset: 0x0009926C
		// Note: this type is marked as 'beforefieldinit'.
		static MeshTransform()
		{
			Il2CppClassPointerStore<MeshTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MeshTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr);
			MeshTransform.NativeFieldInfoPtr__position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, "_position");
			MeshTransform.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, "_rotation");
			MeshTransform.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, "_scale");
			MeshTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, 100667948);
			MeshTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, 100667949);
			MeshTransform.NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, 100667950);
			MeshTransform.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, 100667951);
			MeshTransform.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, 100667952);
			MeshTransform.NativeMethodInfoPtr_InverseTransformOBB_Public_OBB_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, 100667953);
			MeshTransform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, 100667954);
			MeshTransform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr, 100667955);
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x0009B178 File Offset: 0x00099378
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTransform.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x0009B1B8 File Offset: 0x000993B8
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTransform.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x0009B1F8 File Offset: 0x000993F8
		public unsafe Vector3 Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTransform.NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0009B238 File Offset: 0x00099438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82431, XrefRangeEnd = 82432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTransform(Vector3 position, Quaternion rotation, Vector3 scale)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTransform.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0009B2A8 File Offset: 0x000994A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82432, XrefRangeEnd = 82436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTransform(Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshTransform>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTransform.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0009B2F4 File Offset: 0x000994F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82442, RefRangeEnd = 82443, XrefRangeStart = 82436, XrefRangeEnd = 82442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB InverseTransformOBB(OBB obb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTransform.NativeMethodInfoPtr_InverseTransformOBB_Public_OBB_OBB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0009B344 File Offset: 0x00099544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82443, XrefRangeEnd = 82444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTransform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0009B394 File Offset: 0x00099594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82444, XrefRangeEnd = 82447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshTransform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0000C71A File Offset: 0x0000A91A
		public MeshTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0009B3E4 File Offset: 0x000995E4
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x0000C723 File Offset: 0x0000A923
		public unsafe Vector3 _position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTransform.NativeFieldInfoPtr__position);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTransform.NativeFieldInfoPtr__position), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x0009B414 File Offset: 0x00099614
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x0000C742 File Offset: 0x0000A942
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTransform.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTransform.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x0009B444 File Offset: 0x00099644
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x0000C761 File Offset: 0x0000A961
		public unsafe Vector3 _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTransform.NativeFieldInfoPtr__scale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshTransform.NativeFieldInfoPtr__scale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeFieldInfoPtr__position;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Vector3_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformOBB_Public_OBB_OBB_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;
	}
}
