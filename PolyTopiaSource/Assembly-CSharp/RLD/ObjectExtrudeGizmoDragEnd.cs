using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200000B RID: 11
	public class ObjectExtrudeGizmoDragEnd : global::Il2CppSystem.Object
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00022720 File Offset: 0x00020920
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectExtrudeGizmoDragEnd()
		{
			Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectExtrudeGizmoDragEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr);
			ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__wasExecuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, "_wasExecuted");
			ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__destroyClones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, "_destroyClones");
			ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__targetParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, "_targetParents");
			ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__undoTargetSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, "_undoTargetSnapshots");
			ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__redoTargetSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, "_redoTargetSnapshots");
			ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__extrudeClones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, "_extrudeClones");
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_get_NumTargets_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663367);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663377);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_SetTargetParents_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663368);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_TakeUndoTargetSnapshots_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663369);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_TakeRedoTargetSnapshots_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663370);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_AddExtrudeClones_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663371);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_AddExtrudeClone_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663372);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663373);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663374);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663375);
			ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr, 100663376);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000228A4 File Offset: 0x00020AA4
		public unsafe int NumTargets
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56561, XrefRangeEnd = 56562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_get_NumTargets_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000228E0 File Offset: 0x00020AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56587, RefRangeEnd = 56588, XrefRangeStart = 56562, XrefRangeEnd = 56587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectExtrudeGizmoDragEnd()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectExtrudeGizmoDragEnd>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0002291C File Offset: 0x00020B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56595, RefRangeEnd = 56596, XrefRangeStart = 56588, XrefRangeEnd = 56595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetParents(IEnumerable<GameObject> targetParents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetParents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_SetTargetParents_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00022960 File Offset: 0x00020B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56598, RefRangeEnd = 56599, XrefRangeStart = 56596, XrefRangeEnd = 56598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeUndoTargetSnapshots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_TakeUndoTargetSnapshots_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00022994 File Offset: 0x00020B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56601, RefRangeEnd = 56602, XrefRangeStart = 56599, XrefRangeEnd = 56601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeRedoTargetSnapshots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_TakeRedoTargetSnapshots_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000229C8 File Offset: 0x00020BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56602, XrefRangeEnd = 56623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExtrudeClones(List<GameObject> extrudeClones)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extrudeClones);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_AddExtrudeClones_Public_Void_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00022A0C File Offset: 0x00020C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56630, RefRangeEnd = 56632, XrefRangeStart = 56623, XrefRangeEnd = 56630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExtrudeClone(GameObject extrudeClone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extrudeClone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_AddExtrudeClone_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00022A50 File Offset: 0x00020C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 56639, RefRangeEnd = 56640, XrefRangeStart = 56632, XrefRangeEnd = 56639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00022A84 File Offset: 0x00020C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56640, XrefRangeEnd = 56674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00022AB8 File Offset: 0x00020CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56674, XrefRangeEnd = 56708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00022AEC File Offset: 0x00020CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56708, XrefRangeEnd = 56729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemovedFromUndoRedoStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmoDragEnd.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002244 File Offset: 0x00000444
		public ObjectExtrudeGizmoDragEnd(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00022B20 File Offset: 0x00020D20
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000224D File Offset: 0x0000044D
		public unsafe bool _wasExecuted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__wasExecuted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__wasExecuted)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00022B48 File Offset: 0x00020D48
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002268 File Offset: 0x00000468
		public unsafe bool _destroyClones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__destroyClones);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__destroyClones)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00022B70 File Offset: 0x00020D70
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002283 File Offset: 0x00000483
		public unsafe List<GameObject> _targetParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__targetParents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__targetParents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00022BA0 File Offset: 0x00020DA0
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000022A2 File Offset: 0x000004A2
		public unsafe List<LocalTransformSnapshot> _undoTargetSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__undoTargetSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__undoTargetSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00022BD0 File Offset: 0x00020DD0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000022C1 File Offset: 0x000004C1
		public unsafe List<LocalTransformSnapshot> _redoTargetSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__redoTargetSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__redoTargetSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00022C00 File Offset: 0x00020E00
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000022E0 File Offset: 0x000004E0
		public unsafe List<GameObject> _extrudeClones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__extrudeClones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmoDragEnd.NativeFieldInfoPtr__extrudeClones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr__wasExecuted;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr__destroyClones;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr__targetParents;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr__undoTargetSnapshots;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr__redoTargetSnapshots;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr__extrudeClones;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_NumTargets_Public_get_Int32_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetParents_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_TakeUndoTargetSnapshots_Public_Void_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_TakeRedoTargetSnapshots_Public_Void_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_AddExtrudeClones_Public_Void_List_1_GameObject_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_AddExtrudeClone_Public_Void_GameObject_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0;
	}
}
