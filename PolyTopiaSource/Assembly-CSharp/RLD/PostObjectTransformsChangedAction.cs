using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x02000200 RID: 512
	public class PostObjectTransformsChangedAction : Object
	{
		// Token: 0x0600291B RID: 10523 RVA: 0x000C4680 File Offset: 0x000C2880
		// Note: this type is marked as 'beforefieldinit'.
		static PostObjectTransformsChangedAction()
		{
			Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PostObjectTransformsChangedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr);
			PostObjectTransformsChangedAction.NativeFieldInfoPtr__preChangeTransformSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr, "_preChangeTransformSnapshots");
			PostObjectTransformsChangedAction.NativeFieldInfoPtr__postChangeTransformSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr, "_postChangeTransformSnapshots");
			PostObjectTransformsChangedAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_LocalTransformSnapshot_List_1_LocalTransformSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr, 100669577);
			PostObjectTransformsChangedAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr, 100669578);
			PostObjectTransformsChangedAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr, 100669579);
			PostObjectTransformsChangedAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr, 100669580);
			PostObjectTransformsChangedAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr, 100669581);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000C473C File Offset: 0x000C293C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 91325, RefRangeEnd = 91335, XrefRangeStart = 91301, XrefRangeEnd = 91325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostObjectTransformsChangedAction(List<LocalTransformSnapshot> preChangeTransformSnapshots, List<LocalTransformSnapshot> postChangeTransformSnapshots)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostObjectTransformsChangedAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(preChangeTransformSnapshots);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postChangeTransformSnapshots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectTransformsChangedAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_LocalTransformSnapshot_List_1_LocalTransformSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000C479C File Offset: 0x000C299C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 91343, RefRangeEnd = 91353, XrefRangeStart = 91335, XrefRangeEnd = 91343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectTransformsChangedAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000C47D0 File Offset: 0x000C29D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91353, XrefRangeEnd = 91368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectTransformsChangedAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000C4804 File Offset: 0x000C2A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91368, XrefRangeEnd = 91383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectTransformsChangedAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000C4838 File Offset: 0x000C2A38
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemovedFromUndoRedoStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectTransformsChangedAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x0001039D File Offset: 0x0000E59D
		public PostObjectTransformsChangedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002922 RID: 10530 RVA: 0x000C486C File Offset: 0x000C2A6C
		// (set) Token: 0x06002923 RID: 10531 RVA: 0x000103A6 File Offset: 0x0000E5A6
		public unsafe List<LocalTransformSnapshot> _preChangeTransformSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectTransformsChangedAction.NativeFieldInfoPtr__preChangeTransformSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectTransformsChangedAction.NativeFieldInfoPtr__preChangeTransformSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x000C489C File Offset: 0x000C2A9C
		// (set) Token: 0x06002925 RID: 10533 RVA: 0x000103C5 File Offset: 0x0000E5C5
		public unsafe List<LocalTransformSnapshot> _postChangeTransformSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectTransformsChangedAction.NativeFieldInfoPtr__postChangeTransformSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectTransformsChangedAction.NativeFieldInfoPtr__postChangeTransformSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeFieldInfoPtr__preChangeTransformSnapshots;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeFieldInfoPtr__postChangeTransformSnapshots;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_LocalTransformSnapshot_List_1_LocalTransformSnapshot_0;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0;
	}
}
