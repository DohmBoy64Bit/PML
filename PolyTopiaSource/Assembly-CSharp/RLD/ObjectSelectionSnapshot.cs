using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000229 RID: 553
	public class ObjectSelectionSnapshot : global::Il2CppSystem.Object
	{
		// Token: 0x06002B00 RID: 11008 RVA: 0x000CB364 File Offset: 0x000C9564
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionSnapshot()
		{
			Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionSnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr);
			ObjectSelectionSnapshot.NativeFieldInfoPtr__snapshotObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr, "_snapshotObjects");
			ObjectSelectionSnapshot.NativeFieldInfoPtr__gizmosSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr, "_gizmosSnapshot");
			ObjectSelectionSnapshot.NativeMethodInfoPtr_get_NumObjects_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr, 100669835);
			ObjectSelectionSnapshot.NativeMethodInfoPtr_get_SnapshotObjects_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr, 100669836);
			ObjectSelectionSnapshot.NativeMethodInfoPtr_get_GizmosSnapshot_Public_get_ObjectSelectionGizmosSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr, 100669837);
			ObjectSelectionSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr, 100669838);
			ObjectSelectionSnapshot.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectionSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr, 100669839);
			ObjectSelectionSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr, 100669840);
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x000CB434 File Offset: 0x000C9634
		public unsafe int NumObjects
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93757, XrefRangeEnd = 93758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSnapshot.NativeMethodInfoPtr_get_NumObjects_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06002B02 RID: 11010 RVA: 0x000CB470 File Offset: 0x000C9670
		public unsafe List<GameObject> SnapshotObjects
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93758, XrefRangeEnd = 93764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSnapshot.NativeMethodInfoPtr_get_SnapshotObjects_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x000CB4B0 File Offset: 0x000C96B0
		public unsafe ObjectSelectionGizmosSnapshot GizmosSnapshot
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93769, RefRangeEnd = 93771, XrefRangeStart = 93764, XrefRangeEnd = 93769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSnapshot.NativeMethodInfoPtr_get_GizmosSnapshot_Public_get_ObjectSelectionGizmosSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionGizmosSnapshot>(intPtr3) : null;
			}
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x000CB4F0 File Offset: 0x000C96F0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 93784, RefRangeEnd = 93798, XrefRangeStart = 93771, XrefRangeEnd = 93784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionSnapshot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000CB52C File Offset: 0x000C972C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93798, XrefRangeEnd = 93821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionSnapshot(ObjectSelectionSnapshot copy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionSnapshot>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(copy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSnapshot.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectionSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x000CB578 File Offset: 0x000C9778
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 93855, RefRangeEnd = 93869, XrefRangeStart = 93821, XrefRangeEnd = 93855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Snapshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00011007 File Offset: 0x0000F207
		public ObjectSelectionSnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x000CB5AC File Offset: 0x000C97AC
		// (set) Token: 0x06002B09 RID: 11017 RVA: 0x00011010 File Offset: 0x0000F210
		public unsafe List<GameObject> _snapshotObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSnapshot.NativeFieldInfoPtr__snapshotObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSnapshot.NativeFieldInfoPtr__snapshotObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x000CB5DC File Offset: 0x000C97DC
		// (set) Token: 0x06002B0B RID: 11019 RVA: 0x0001102F File Offset: 0x0000F22F
		public unsafe ObjectSelectionGizmosSnapshot _gizmosSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSnapshot.NativeFieldInfoPtr__gizmosSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionGizmosSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSnapshot.NativeFieldInfoPtr__gizmosSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeFieldInfoPtr__snapshotObjects;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeFieldInfoPtr__gizmosSnapshot;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeMethodInfoPtr_get_NumObjects_Public_get_Int32_0;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeMethodInfoPtr_get_SnapshotObjects_Public_get_List_1_GameObject_0;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeMethodInfoPtr_get_GizmosSnapshot_Public_get_ObjectSelectionGizmosSnapshot_0;

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectionSnapshot_0;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeMethodInfoPtr_Snapshot_Public_Void_0;
	}
}
