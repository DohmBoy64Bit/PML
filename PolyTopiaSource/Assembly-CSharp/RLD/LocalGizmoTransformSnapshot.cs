using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000036 RID: 54
	public class LocalGizmoTransformSnapshot : global::Il2CppSystem.Object
	{
		// Token: 0x06000349 RID: 841 RVA: 0x0002E0C4 File Offset: 0x0002C2C4
		// Note: this type is marked as 'beforefieldinit'.
		static LocalGizmoTransformSnapshot()
		{
			Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "LocalGizmoTransformSnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr);
			LocalGizmoTransformSnapshot.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, "_transform");
			LocalGizmoTransformSnapshot.NativeFieldInfoPtr__parentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, "_parentTransform");
			LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localPosition3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, "_localPosition3D");
			LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localRotation3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, "_localRotation3D");
			LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localPosition2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, "_localPosition2D");
			LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localRotation2D_Degrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, "_localRotation2D_Degrees");
			LocalGizmoTransformSnapshot.NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, 100663795);
			LocalGizmoTransformSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, 100663799);
			LocalGizmoTransformSnapshot.NativeMethodInfoPtr_GetSnapshotCollection_Public_Static_List_1_LocalGizmoTransformSnapshot_IEnumerable_1_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, 100663796);
			LocalGizmoTransformSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, 100663797);
			LocalGizmoTransformSnapshot.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr, 100663798);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		public unsafe GizmoTransform Transform
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalGizmoTransformSnapshot.NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0002E210 File Offset: 0x0002C410
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalGizmoTransformSnapshot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalGizmoTransformSnapshot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalGizmoTransformSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0002E24C File Offset: 0x0002C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58866, XrefRangeEnd = 58904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<LocalGizmoTransformSnapshot> GetSnapshotCollection(IEnumerable<Gizmo> gizmos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalGizmoTransformSnapshot.NativeMethodInfoPtr_GetSnapshotCollection_Public_Static_List_1_LocalGizmoTransformSnapshot_IEnumerable_1_Gizmo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LocalGizmoTransformSnapshot>>(intPtr3) : null;
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0002E290 File Offset: 0x0002C490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58904, XrefRangeEnd = 58906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Snapshot(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalGizmoTransformSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0002E2D4 File Offset: 0x0002C4D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58930, RefRangeEnd = 58932, XrefRangeStart = 58906, XrefRangeEnd = 58930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalGizmoTransformSnapshot.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003211 File Offset: 0x00001411
		public LocalGizmoTransformSnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0002E308 File Offset: 0x0002C508
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0000321A File Offset: 0x0000141A
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0002E338 File Offset: 0x0002C538
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00003239 File Offset: 0x00001439
		public unsafe GizmoTransform _parentTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__parentTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__parentTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0002E368 File Offset: 0x0002C568
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00003258 File Offset: 0x00001458
		public unsafe Vector3 _localPosition3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localPosition3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localPosition3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0002E398 File Offset: 0x0002C598
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00003277 File Offset: 0x00001477
		public unsafe Quaternion _localRotation3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localRotation3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localRotation3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00003296 File Offset: 0x00001496
		public unsafe Vector2 _localPosition2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localPosition2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localPosition2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
		// (set) Token: 0x0600035B RID: 859 RVA: 0x000032B5 File Offset: 0x000014B5
		public unsafe float _localRotation2D_Degrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localRotation2D_Degrees);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalGizmoTransformSnapshot.NativeFieldInfoPtr__localRotation2D_Degrees)) = value;
			}
		}

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr__parentTransform;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr__localPosition3D;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr__localRotation3D;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr__localPosition2D;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr__localRotation2D_Degrees;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_GetSnapshotCollection_Public_Static_List_1_LocalGizmoTransformSnapshot_IEnumerable_1_Gizmo_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_Snapshot_Public_Void_GizmoTransform_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;
	}
}
