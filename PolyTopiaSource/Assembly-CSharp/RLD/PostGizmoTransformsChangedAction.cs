using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x02000201 RID: 513
	public class PostGizmoTransformsChangedAction : Object
	{
		// Token: 0x06002926 RID: 10534 RVA: 0x000C48CC File Offset: 0x000C2ACC
		// Note: this type is marked as 'beforefieldinit'.
		static PostGizmoTransformsChangedAction()
		{
			Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PostGizmoTransformsChangedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr);
			PostGizmoTransformsChangedAction.NativeFieldInfoPtr__preChangeTransformSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr, "_preChangeTransformSnapshots");
			PostGizmoTransformsChangedAction.NativeFieldInfoPtr__postChangeTransformSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr, "_postChangeTransformSnapshots");
			PostGizmoTransformsChangedAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_LocalGizmoTransformSnapshot_List_1_LocalGizmoTransformSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr, 100669582);
			PostGizmoTransformsChangedAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr, 100669583);
			PostGizmoTransformsChangedAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr, 100669584);
			PostGizmoTransformsChangedAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr, 100669585);
			PostGizmoTransformsChangedAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr, 100669586);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000C4988 File Offset: 0x000C2B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91383, XrefRangeEnd = 91407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostGizmoTransformsChangedAction(List<LocalGizmoTransformSnapshot> preChangeTransformSnapshots, List<LocalGizmoTransformSnapshot> postChangeTransformSnapshots)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostGizmoTransformsChangedAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(preChangeTransformSnapshots);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postChangeTransformSnapshots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostGizmoTransformsChangedAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_LocalGizmoTransformSnapshot_List_1_LocalGizmoTransformSnapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000C49E8 File Offset: 0x000C2BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91407, XrefRangeEnd = 91415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostGizmoTransformsChangedAction.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000C4A1C File Offset: 0x000C2C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91415, XrefRangeEnd = 91430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostGizmoTransformsChangedAction.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000C4A50 File Offset: 0x000C2C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91430, XrefRangeEnd = 91445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostGizmoTransformsChangedAction.NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000C4A84 File Offset: 0x000C2C84
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemovedFromUndoRedoStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostGizmoTransformsChangedAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000103E4 File Offset: 0x0000E5E4
		public PostGizmoTransformsChangedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x000C4AB8 File Offset: 0x000C2CB8
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x000103ED File Offset: 0x0000E5ED
		public unsafe List<LocalGizmoTransformSnapshot> _preChangeTransformSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostGizmoTransformsChangedAction.NativeFieldInfoPtr__preChangeTransformSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalGizmoTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostGizmoTransformsChangedAction.NativeFieldInfoPtr__preChangeTransformSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x000C4AE8 File Offset: 0x000C2CE8
		// (set) Token: 0x06002930 RID: 10544 RVA: 0x0001040C File Offset: 0x0000E60C
		public unsafe List<LocalGizmoTransformSnapshot> _postChangeTransformSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostGizmoTransformsChangedAction.NativeFieldInfoPtr__postChangeTransformSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalGizmoTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostGizmoTransformsChangedAction.NativeFieldInfoPtr__postChangeTransformSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeFieldInfoPtr__preChangeTransformSnapshots;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeFieldInfoPtr__postChangeTransformSnapshots;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_LocalGizmoTransformSnapshot_List_1_LocalGizmoTransformSnapshot_0;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Virtual_Final_New_Void_0;
	}
}
