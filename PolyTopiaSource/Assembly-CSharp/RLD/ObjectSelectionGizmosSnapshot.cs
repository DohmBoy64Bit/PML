using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200022A RID: 554
	public class ObjectSelectionGizmosSnapshot : global::Il2CppSystem.Object
	{
		// Token: 0x06002B0C RID: 11020 RVA: 0x000CB60C File Offset: 0x000C980C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionGizmosSnapshot()
		{
			Il2CppClassPointerStore<ObjectSelectionGizmosSnapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionGizmosSnapshot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionGizmosSnapshot>.NativeClassPtr);
			ObjectSelectionGizmosSnapshot.NativeFieldInfoPtr__pivotObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionGizmosSnapshot>.NativeClassPtr, "_pivotObject");
			ObjectSelectionGizmosSnapshot.NativeMethodInfoPtr_get_PivotObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosSnapshot>.NativeClassPtr, 100669841);
			ObjectSelectionGizmosSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosSnapshot>.NativeClassPtr, 100669842);
			ObjectSelectionGizmosSnapshot.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectionGizmosSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosSnapshot>.NativeClassPtr, 100669843);
			ObjectSelectionGizmosSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionGizmosSnapshot>.NativeClassPtr, 100669844);
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x000CB6A0 File Offset: 0x000C98A0
		public unsafe GameObject PivotObject
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosSnapshot.NativeMethodInfoPtr_get_PivotObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x000CB6E0 File Offset: 0x000C98E0
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionGizmosSnapshot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionGizmosSnapshot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosSnapshot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x000CB71C File Offset: 0x000C991C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29440, RefRangeEnd = 29441, XrefRangeStart = 29440, XrefRangeEnd = 29441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionGizmosSnapshot(ObjectSelectionGizmosSnapshot copy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionGizmosSnapshot>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(copy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosSnapshot.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectionGizmosSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x000CB768 File Offset: 0x000C9968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93869, XrefRangeEnd = 93884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Snapshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionGizmosSnapshot.NativeMethodInfoPtr_Snapshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x0001104E File Offset: 0x0000F24E
		public ObjectSelectionGizmosSnapshot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000CB79C File Offset: 0x000C999C
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x00011057 File Offset: 0x0000F257
		public unsafe GameObject _pivotObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosSnapshot.NativeFieldInfoPtr__pivotObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionGizmosSnapshot.NativeFieldInfoPtr__pivotObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002155 RID: 8533
		private static readonly IntPtr NativeFieldInfoPtr__pivotObject;

		// Token: 0x04002156 RID: 8534
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotObject_Public_get_GameObject_0;

		// Token: 0x04002157 RID: 8535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectionGizmosSnapshot_0;

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeMethodInfoPtr_Snapshot_Public_Void_0;
	}
}
