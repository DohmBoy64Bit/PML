using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200021A RID: 538
	public class PostObjectSelectionChangedAction : Object
	{
		// Token: 0x06002A2C RID: 10796 RVA: 0x000C84E0 File Offset: 0x000C66E0
		// Note: this type is marked as 'beforefieldinit'.
		static PostObjectSelectionChangedAction()
		{
			Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PostObjectSelectionChangedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr);
			PostObjectSelectionChangedAction.NativeFieldInfoPtr__preChangeSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr, "_preChangeSnapshot");
			PostObjectSelectionChangedAction.NativeFieldInfoPtr__postChangeSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr, "_postChangeSnapshot");
			PostObjectSelectionChangedAction.NativeMethodInfoPtr_get_PreChangeSnapshot_Public_get_ObjectSelectionSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr, 100669734);
			PostObjectSelectionChangedAction.NativeMethodInfoPtr_get_PostChangeSnapshot_Public_get_ObjectSelectionSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr, 100669735);
			PostObjectSelectionChangedAction.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectionSnapshot_ObjectSelectionSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr, 100669736);
			PostObjectSelectionChangedAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr, 100669737);
			PostObjectSelectionChangedAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr, 100669738);
			PostObjectSelectionChangedAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr, 100669739);
			PostObjectSelectionChangedAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr, 100669740);
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x000C85C4 File Offset: 0x000C67C4
		public unsafe ObjectSelectionSnapshot PreChangeSnapshot
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSelectionChangedAction.NativeMethodInfoPtr_get_PreChangeSnapshot_Public_get_ObjectSelectionSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr3) : null;
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x000C8604 File Offset: 0x000C6804
		public unsafe ObjectSelectionSnapshot PostChangeSnapshot
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSelectionChangedAction.NativeMethodInfoPtr_get_PostChangeSnapshot_Public_get_ObjectSelectionSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr3) : null;
			}
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x000C8644 File Offset: 0x000C6844
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 33819, RefRangeEnd = 33846, XrefRangeStart = 33819, XrefRangeEnd = 33846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostObjectSelectionChangedAction(ObjectSelectionSnapshot preChangeSnapshot, ObjectSelectionSnapshot postChangeSnapshot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostObjectSelectionChangedAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(preChangeSnapshot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postChangeSnapshot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSelectionChangedAction.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectionSnapshot_ObjectSelectionSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x000C86A4 File Offset: 0x000C68A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 93447, RefRangeEnd = 93452, XrefRangeStart = 93440, XrefRangeEnd = 93447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSelectionChangedAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x000C86D8 File Offset: 0x000C68D8
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSelectionChangedAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x000C870C File Offset: 0x000C690C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSelectionChangedAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000C8740 File Offset: 0x000C6940
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemovedFromUndoRedoStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostObjectSelectionChangedAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00010A3A File Offset: 0x0000EC3A
		public PostObjectSelectionChangedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x000C8774 File Offset: 0x000C6974
		// (set) Token: 0x06002A36 RID: 10806 RVA: 0x00010A43 File Offset: 0x0000EC43
		public unsafe ObjectSelectionSnapshot _preChangeSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectSelectionChangedAction.NativeFieldInfoPtr__preChangeSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectSelectionChangedAction.NativeFieldInfoPtr__preChangeSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x000C87A4 File Offset: 0x000C69A4
		// (set) Token: 0x06002A38 RID: 10808 RVA: 0x00010A62 File Offset: 0x0000EC62
		public unsafe ObjectSelectionSnapshot _postChangeSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectSelectionChangedAction.NativeFieldInfoPtr__postChangeSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostObjectSelectionChangedAction.NativeFieldInfoPtr__postChangeSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400209E RID: 8350
		private static readonly IntPtr NativeFieldInfoPtr__preChangeSnapshot;

		// Token: 0x0400209F RID: 8351
		private static readonly IntPtr NativeFieldInfoPtr__postChangeSnapshot;

		// Token: 0x040020A0 RID: 8352
		private static readonly IntPtr NativeMethodInfoPtr_get_PreChangeSnapshot_Public_get_ObjectSelectionSnapshot_0;

		// Token: 0x040020A1 RID: 8353
		private static readonly IntPtr NativeMethodInfoPtr_get_PostChangeSnapshot_Public_get_ObjectSelectionSnapshot_0;

		// Token: 0x040020A2 RID: 8354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectionSnapshot_ObjectSelectionSnapshot_0;

		// Token: 0x040020A3 RID: 8355
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0;
	}
}
