using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F5 RID: 501
	public class LocalTransformSnapshot : global::Il2CppSystem.Object
	{
		// Token: 0x06002893 RID: 10387 RVA: 0x000C2988 File Offset: 0x000C0B88
		// Note: this type is marked as 'beforefieldinit'.
		static LocalTransformSnapshot()
		{
			Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "LocalTransformSnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr);
			LocalTransformSnapshot.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, "_transform");
			LocalTransformSnapshot.NativeFieldInfoPtr__parentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, "_parentTransform");
			LocalTransformSnapshot.NativeFieldInfoPtr__localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, "_localPosition");
			LocalTransformSnapshot.NativeFieldInfoPtr__localRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, "_localRotation");
			LocalTransformSnapshot.NativeFieldInfoPtr__localScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, "_localScale");
			LocalTransformSnapshot.NativeMethodInfoPtr_get_Transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, 100669513);
			LocalTransformSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, 100669518);
			LocalTransformSnapshot.NativeMethodInfoPtr_GetSnapshotCollection_Public_Static_List_1_LocalTransformSnapshot_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, 100669514);
			LocalTransformSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, 100669515);
			LocalTransformSnapshot.NativeMethodInfoPtr_SameAs_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, 100669516);
			LocalTransformSnapshot.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr, 100669517);
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000C2A94 File Offset: 0x000C0C94
		public unsafe Transform Transform
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransformSnapshot.NativeMethodInfoPtr_get_Transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000C2AD4 File Offset: 0x000C0CD4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalTransformSnapshot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalTransformSnapshot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransformSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000C2B10 File Offset: 0x000C0D10
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 90927, RefRangeEnd = 90945, XrefRangeStart = 90887, XrefRangeEnd = 90927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<LocalTransformSnapshot> GetSnapshotCollection(IEnumerable<GameObject> gameObjects)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransformSnapshot.NativeMethodInfoPtr_GetSnapshotCollection_Public_Static_List_1_LocalTransformSnapshot_IEnumerable_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LocalTransformSnapshot>>(intPtr3) : null;
			}
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000C2B54 File Offset: 0x000C0D54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90955, RefRangeEnd = 90958, XrefRangeStart = 90945, XrefRangeEnd = 90955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Snapshot(Transform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransformSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000C2B98 File Offset: 0x000C0D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90958, XrefRangeEnd = 90966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SameAs(Transform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransformSnapshot.NativeMethodInfoPtr_SameAs_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x000C2BE8 File Offset: 0x000C0DE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 90976, RefRangeEnd = 90980, XrefRangeStart = 90966, XrefRangeEnd = 90976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransformSnapshot.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00010043 File Offset: 0x0000E243
		public LocalTransformSnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x000C2C1C File Offset: 0x000C0E1C
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x0001004C File Offset: 0x0000E24C
		public unsafe Transform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x000C2C4C File Offset: 0x000C0E4C
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x0001006B File Offset: 0x0000E26B
		public unsafe Transform _parentTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__parentTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__parentTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x000C2C7C File Offset: 0x000C0E7C
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x0001008A File Offset: 0x0000E28A
		public unsafe Vector3 _localPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__localPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__localPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x000C2CAC File Offset: 0x000C0EAC
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x000100A9 File Offset: 0x0000E2A9
		public unsafe Quaternion _localRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__localRotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__localRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x000C2CDC File Offset: 0x000C0EDC
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x000100C8 File Offset: 0x0000E2C8
		public unsafe Vector3 _localScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__localScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalTransformSnapshot.NativeFieldInfoPtr__localScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F96 RID: 8086
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x04001F97 RID: 8087
		private static readonly IntPtr NativeFieldInfoPtr__parentTransform;

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeFieldInfoPtr__localPosition;

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeFieldInfoPtr__localRotation;

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeFieldInfoPtr__localScale;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_get_Transform_0;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeMethodInfoPtr_GetSnapshotCollection_Public_Static_List_1_LocalTransformSnapshot_IEnumerable_1_GameObject_0;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeMethodInfoPtr_Snapshot_Public_Void_Transform_0;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeMethodInfoPtr_SameAs_Public_Boolean_Transform_0;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;
	}
}
