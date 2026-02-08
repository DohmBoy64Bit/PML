using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000219 RID: 537
	public class DeleteSelectedObjectsAction : global::Il2CppSystem.Object
	{
		// Token: 0x06002A19 RID: 10777 RVA: 0x000C8128 File Offset: 0x000C6328
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteSelectedObjectsAction()
		{
			Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "DeleteSelectedObjectsAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr);
			DeleteSelectedObjectsAction.NativeFieldInfoPtr__selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, "_selectedObjects");
			DeleteSelectedObjectsAction.NativeFieldInfoPtr__deletedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, "_deletedObjects");
			DeleteSelectedObjectsAction.NativeFieldInfoPtr__preDeleteSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, "_preDeleteSnapshot");
			DeleteSelectedObjectsAction.NativeFieldInfoPtr__postDeleteSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, "_postDeleteSnapshot");
			DeleteSelectedObjectsAction.NativeFieldInfoPtr__canDestroyObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, "_canDestroyObjects");
			DeleteSelectedObjectsAction.NativeMethodInfoPtr_get_PreDeleteSnapshot_Public_get_ObjectSelectionSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, 100669727);
			DeleteSelectedObjectsAction.NativeMethodInfoPtr_get_PostDeleteSnapshot_Public_get_ObjectSelectionSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, 100669728);
			DeleteSelectedObjectsAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_ObjectSelectionSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, 100669729);
			DeleteSelectedObjectsAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, 100669730);
			DeleteSelectedObjectsAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, 100669731);
			DeleteSelectedObjectsAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, 100669732);
			DeleteSelectedObjectsAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr, 100669733);
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000C8248 File Offset: 0x000C6448
		public unsafe ObjectSelectionSnapshot PreDeleteSnapshot
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteSelectedObjectsAction.NativeMethodInfoPtr_get_PreDeleteSnapshot_Public_get_ObjectSelectionSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr3) : null;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000C8288 File Offset: 0x000C6488
		public unsafe ObjectSelectionSnapshot PostDeleteSnapshot
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteSelectedObjectsAction.NativeMethodInfoPtr_get_PostDeleteSnapshot_Public_get_ObjectSelectionSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr3) : null;
			}
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000C82C8 File Offset: 0x000C64C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93344, RefRangeEnd = 93345, XrefRangeStart = 93335, XrefRangeEnd = 93344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteSelectedObjectsAction(List<GameObject> selectedObjects, ObjectSelectionSnapshot preDeleteSnapshot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteSelectedObjectsAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preDeleteSnapshot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteSelectedObjectsAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_ObjectSelectionSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000C8328 File Offset: 0x000C6528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93386, RefRangeEnd = 93388, XrefRangeStart = 93345, XrefRangeEnd = 93386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteSelectedObjectsAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000C835C File Offset: 0x000C655C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93388, XrefRangeEnd = 93403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteSelectedObjectsAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000C8390 File Offset: 0x000C6590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93403, XrefRangeEnd = 93418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteSelectedObjectsAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x000C83C4 File Offset: 0x000C65C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93418, XrefRangeEnd = 93440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemovedFromUndoRedoStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteSelectedObjectsAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x0001099A File Offset: 0x0000EB9A
		public DeleteSelectedObjectsAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000C83F8 File Offset: 0x000C65F8
		// (set) Token: 0x06002A23 RID: 10787 RVA: 0x000109A3 File Offset: 0x0000EBA3
		public unsafe List<GameObject> _selectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__selectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000C8428 File Offset: 0x000C6628
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x000109C2 File Offset: 0x0000EBC2
		public unsafe List<GameObject> _deletedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__deletedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__deletedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x000C8458 File Offset: 0x000C6658
		// (set) Token: 0x06002A27 RID: 10791 RVA: 0x000109E1 File Offset: 0x0000EBE1
		public unsafe ObjectSelectionSnapshot _preDeleteSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__preDeleteSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__preDeleteSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x000C8488 File Offset: 0x000C6688
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x00010A00 File Offset: 0x0000EC00
		public unsafe ObjectSelectionSnapshot _postDeleteSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__postDeleteSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__postDeleteSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x000C84B8 File Offset: 0x000C66B8
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x00010A1F File Offset: 0x0000EC1F
		public unsafe bool _canDestroyObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__canDestroyObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteSelectedObjectsAction.NativeFieldInfoPtr__canDestroyObjects)) = value;
			}
		}

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeFieldInfoPtr__selectedObjects;

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeFieldInfoPtr__deletedObjects;

		// Token: 0x04002094 RID: 8340
		private static readonly IntPtr NativeFieldInfoPtr__preDeleteSnapshot;

		// Token: 0x04002095 RID: 8341
		private static readonly IntPtr NativeFieldInfoPtr__postDeleteSnapshot;

		// Token: 0x04002096 RID: 8342
		private static readonly IntPtr NativeFieldInfoPtr__canDestroyObjects;

		// Token: 0x04002097 RID: 8343
		private static readonly IntPtr NativeMethodInfoPtr_get_PreDeleteSnapshot_Public_get_ObjectSelectionSnapshot_0;

		// Token: 0x04002098 RID: 8344
		private static readonly IntPtr NativeMethodInfoPtr_get_PostDeleteSnapshot_Public_get_ObjectSelectionSnapshot_0;

		// Token: 0x04002099 RID: 8345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_ObjectSelectionSnapshot_0;

		// Token: 0x0400209A RID: 8346
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400209B RID: 8347
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400209C RID: 8348
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400209D RID: 8349
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0;
	}
}
