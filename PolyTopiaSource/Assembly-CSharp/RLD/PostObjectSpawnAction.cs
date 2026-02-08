using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001FF RID: 511
	public class PostObjectSpawnAction : global::Il2CppSystem.Object
	{
		// Token: 0x06002910 RID: 10512 RVA: 0x000C4450 File Offset: 0x000C2650
		// Note: this type is marked as 'beforefieldinit'.
		static PostObjectSpawnAction()
		{
			Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PostObjectSpawnAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr);
			PostObjectSpawnAction.NativeFieldInfoPtr__cleanupOnRemovedFromStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr, "_cleanupOnRemovedFromStack");
			PostObjectSpawnAction.NativeFieldInfoPtr__spawnedParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr, "_spawnedParents");
			PostObjectSpawnAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr, 100669572);
			PostObjectSpawnAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr, 100669573);
			PostObjectSpawnAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr, 100669574);
			PostObjectSpawnAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr, 100669575);
			PostObjectSpawnAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr, 100669576);
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000C450C File Offset: 0x000C270C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91240, RefRangeEnd = 91241, XrefRangeStart = 91226, XrefRangeEnd = 91240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostObjectSpawnAction(List<GameObject> spawnedParents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostObjectSpawnAction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spawnedParents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSpawnAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000C4558 File Offset: 0x000C2758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91249, RefRangeEnd = 91250, XrefRangeStart = 91241, XrefRangeEnd = 91249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSpawnAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000C458C File Offset: 0x000C278C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91250, XrefRangeEnd = 91265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSpawnAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000C45C0 File Offset: 0x000C27C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91265, XrefRangeEnd = 91280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSpawnAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000C45F4 File Offset: 0x000C27F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91280, XrefRangeEnd = 91301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemovedFromUndoRedoStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSpawnAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x0001035A File Offset: 0x0000E55A
		public PostObjectSpawnAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000C4628 File Offset: 0x000C2828
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x00010363 File Offset: 0x0000E563
		public unsafe bool _cleanupOnRemovedFromStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectSpawnAction.NativeFieldInfoPtr__cleanupOnRemovedFromStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectSpawnAction.NativeFieldInfoPtr__cleanupOnRemovedFromStack)) = value;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x000C4650 File Offset: 0x000C2850
		// (set) Token: 0x0600291A RID: 10522 RVA: 0x0001037E File Offset: 0x0000E57E
		public unsafe List<GameObject> _spawnedParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectSpawnAction.NativeFieldInfoPtr__spawnedParents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectSpawnAction.NativeFieldInfoPtr__spawnedParents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeFieldInfoPtr__cleanupOnRemovedFromStack;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeFieldInfoPtr__spawnedParents;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_0;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0;
	}
}
