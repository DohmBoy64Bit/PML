using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000202 RID: 514
	public class DuplicateObjectsAction : global::Il2CppSystem.Object
	{
		// Token: 0x06002931 RID: 10545 RVA: 0x000C4B18 File Offset: 0x000C2D18
		// Note: this type is marked as 'beforefieldinit'.
		static DuplicateObjectsAction()
		{
			Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "DuplicateObjectsAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr);
			DuplicateObjectsAction.NativeFieldInfoPtr__rootsToDuplicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr, "_rootsToDuplicate");
			DuplicateObjectsAction.NativeFieldInfoPtr__duplicateResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr, "_duplicateResult");
			DuplicateObjectsAction.NativeFieldInfoPtr__cleanupOnRemovedFromStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr, "_cleanupOnRemovedFromStack");
			DuplicateObjectsAction.NativeMethodInfoPtr_get_DuplicateResult_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr, 100669587);
			DuplicateObjectsAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr, 100669588);
			DuplicateObjectsAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr, 100669589);
			DuplicateObjectsAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr, 100669590);
			DuplicateObjectsAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr, 100669591);
			DuplicateObjectsAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr, 100669592);
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000C4BFC File Offset: 0x000C2DFC
		public unsafe List<GameObject> DuplicateResult
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 91451, RefRangeEnd = 91452, XrefRangeStart = 91445, XrefRangeEnd = 91451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateObjectsAction.NativeMethodInfoPtr_get_DuplicateResult_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000C4C3C File Offset: 0x000C2E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91465, RefRangeEnd = 91466, XrefRangeStart = 91452, XrefRangeEnd = 91465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuplicateObjectsAction(List<GameObject> rootsToDuplicate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuplicateObjectsAction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootsToDuplicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateObjectsAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000C4C88 File Offset: 0x000C2E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91507, RefRangeEnd = 91508, XrefRangeStart = 91466, XrefRangeEnd = 91507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateObjectsAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000C4CBC File Offset: 0x000C2EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91508, XrefRangeEnd = 91523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateObjectsAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000C4CF0 File Offset: 0x000C2EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91523, XrefRangeEnd = 91538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateObjectsAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000C4D24 File Offset: 0x000C2F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91538, XrefRangeEnd = 91559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemovedFromUndoRedoStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateObjectsAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x0001042B File Offset: 0x0000E62B
		public DuplicateObjectsAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x000C4D58 File Offset: 0x000C2F58
		// (set) Token: 0x0600293A RID: 10554 RVA: 0x00010434 File Offset: 0x0000E634
		public unsafe List<GameObject> _rootsToDuplicate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateObjectsAction.NativeFieldInfoPtr__rootsToDuplicate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateObjectsAction.NativeFieldInfoPtr__rootsToDuplicate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x000C4D88 File Offset: 0x000C2F88
		// (set) Token: 0x0600293C RID: 10556 RVA: 0x00010453 File Offset: 0x0000E653
		public unsafe List<GameObject> _duplicateResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateObjectsAction.NativeFieldInfoPtr__duplicateResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateObjectsAction.NativeFieldInfoPtr__duplicateResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x000C4DB8 File Offset: 0x000C2FB8
		// (set) Token: 0x0600293E RID: 10558 RVA: 0x00010472 File Offset: 0x0000E672
		public unsafe bool _cleanupOnRemovedFromStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateObjectsAction.NativeFieldInfoPtr__cleanupOnRemovedFromStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateObjectsAction.NativeFieldInfoPtr__cleanupOnRemovedFromStack)) = value;
			}
		}

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeFieldInfoPtr__rootsToDuplicate;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeFieldInfoPtr__duplicateResult;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeFieldInfoPtr__cleanupOnRemovedFromStack;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr_get_DuplicateResult_Public_get_List_1_GameObject_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_GameObject_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0;
	}
}
