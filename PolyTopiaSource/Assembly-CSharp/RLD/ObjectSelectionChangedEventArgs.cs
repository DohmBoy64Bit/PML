using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000226 RID: 550
	public class ObjectSelectionChangedEventArgs : global::Il2CppSystem.Object
	{
		// Token: 0x06002AE0 RID: 10976 RVA: 0x000CACA0 File Offset: 0x000C8EA0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionChangedEventArgs()
		{
			Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr);
			ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__selectReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, "_selectReason");
			ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__objectsWhichWereSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, "_objectsWhichWereSelected");
			ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__deselectReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, "_deselectReason");
			ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__objectsWhichWereDeselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, "_objectsWhichWereDeselected");
			ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__undoRedoSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, "_undoRedoSnapshot");
			ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_SelectReason_Public_get_ObjectSelectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, 100669823);
			ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_NumObjectsSelected_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, 100669824);
			ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_ObjectsWhichWereSelected_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, 100669825);
			ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_DeselectReason_Public_get_ObjectDeselectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, 100669826);
			ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_NumObjectsDeselected_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, 100669827);
			ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_ObjectsWhichWereDeselected_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, 100669828);
			ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_UndoRedoSnapshot_Public_get_ObjectSelectionSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, 100669829);
			ObjectSelectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectReason_List_1_GameObject_ObjectDeselectReason_List_1_GameObject_ObjectSelectionSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr, 100669830);
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x000CADD4 File Offset: 0x000C8FD4
		public unsafe ObjectSelectReason SelectReason
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_SelectReason_Public_get_ObjectSelectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectReason>(intPtr3) : null;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000CAE14 File Offset: 0x000C9014
		public unsafe int NumObjectsSelected
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93701, XrefRangeEnd = 93702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_NumObjectsSelected_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x000CAE50 File Offset: 0x000C9050
		public unsafe List<GameObject> ObjectsWhichWereSelected
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93708, RefRangeEnd = 93709, XrefRangeStart = 93702, XrefRangeEnd = 93708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_ObjectsWhichWereSelected_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000CAE90 File Offset: 0x000C9090
		public unsafe ObjectDeselectReason DeselectReason
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_DeselectReason_Public_get_ObjectDeselectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectDeselectReason>(intPtr3) : null;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x000CAED0 File Offset: 0x000C90D0
		public unsafe int NumObjectsDeselected
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93709, XrefRangeEnd = 93710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_NumObjectsDeselected_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000CAF0C File Offset: 0x000C910C
		public unsafe List<GameObject> ObjectsWhichWereDeselected
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93710, XrefRangeEnd = 93716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_ObjectsWhichWereDeselected_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000CAF4C File Offset: 0x000C914C
		public unsafe ObjectSelectionSnapshot UndoRedoSnapshot
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedEventArgs.NativeMethodInfoPtr_get_UndoRedoSnapshot_Public_get_ObjectSelectionSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr3) : null;
			}
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000CAF8C File Offset: 0x000C918C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 93747, RefRangeEnd = 93757, XrefRangeStart = 93716, XrefRangeEnd = 93747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionChangedEventArgs(ObjectSelectReason selectReason, List<GameObject> objectsWhichWereSelected, ObjectDeselectReason deselectReason, List<GameObject> objectsWhichWereDeselected, ObjectSelectionSnapshot undoRedoSnapshot = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectReason);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectsWhichWereSelected);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deselectReason);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectsWhichWereDeselected);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoRedoSnapshot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectReason_List_1_GameObject_ObjectDeselectReason_List_1_GameObject_ObjectSelectionSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00010F13 File Offset: 0x0000F113
		public ObjectSelectionChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x000CB024 File Offset: 0x000C9224
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x00010F1C File Offset: 0x0000F11C
		public unsafe ObjectSelectReason _selectReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__selectReason);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectReason>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__selectReason), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000CB054 File Offset: 0x000C9254
		// (set) Token: 0x06002AED RID: 10989 RVA: 0x00010F3B File Offset: 0x0000F13B
		public unsafe List<GameObject> _objectsWhichWereSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__objectsWhichWereSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__objectsWhichWereSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x000CB084 File Offset: 0x000C9284
		// (set) Token: 0x06002AEF RID: 10991 RVA: 0x00010F5A File Offset: 0x0000F15A
		public unsafe ObjectDeselectReason _deselectReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__deselectReason);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectDeselectReason>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__deselectReason), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x000CB0B4 File Offset: 0x000C92B4
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x00010F79 File Offset: 0x0000F179
		public unsafe List<GameObject> _objectsWhichWereDeselected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__objectsWhichWereDeselected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__objectsWhichWereDeselected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x000CB0E4 File Offset: 0x000C92E4
		// (set) Token: 0x06002AF3 RID: 10995 RVA: 0x00010F98 File Offset: 0x0000F198
		public unsafe ObjectSelectionSnapshot _undoRedoSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__undoRedoSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionChangedEventArgs.NativeFieldInfoPtr__undoRedoSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeFieldInfoPtr__selectReason;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeFieldInfoPtr__objectsWhichWereSelected;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeFieldInfoPtr__deselectReason;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeFieldInfoPtr__objectsWhichWereDeselected;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeFieldInfoPtr__undoRedoSnapshot;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectReason_Public_get_ObjectSelectReason_0;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeMethodInfoPtr_get_NumObjectsSelected_Public_get_Int32_0;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectsWhichWereSelected_Public_get_List_1_GameObject_0;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr_get_DeselectReason_Public_get_ObjectDeselectReason_0;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeMethodInfoPtr_get_NumObjectsDeselected_Public_get_Int32_0;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectsWhichWereDeselected_Public_get_List_1_GameObject_0;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeMethodInfoPtr_get_UndoRedoSnapshot_Public_get_ObjectSelectionSnapshot_0;

		// Token: 0x04002146 RID: 8518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectReason_List_1_GameObject_ObjectDeselectReason_List_1_GameObject_ObjectSelectionSnapshot_0;
	}
}
