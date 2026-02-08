using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001F7 RID: 503
	public class IUndoRedoAction : Object
	{
		// Token: 0x060028B3 RID: 10419 RVA: 0x000C3010 File Offset: 0x000C1210
		// Note: this type is marked as 'beforefieldinit'.
		static IUndoRedoAction()
		{
			Il2CppClassPointerStore<IUndoRedoAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IUndoRedoAction");
			IUndoRedoAction.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoRedoAction>.NativeClassPtr, 100669525);
			IUndoRedoAction.NativeMethodInfoPtr_Undo_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoRedoAction>.NativeClassPtr, 100669526);
			IUndoRedoAction.NativeMethodInfoPtr_Redo_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoRedoAction>.NativeClassPtr, 100669527);
			IUndoRedoAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUndoRedoAction>.NativeClassPtr, 100669528);
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000C3088 File Offset: 0x000C1288
		[CallerCount(0)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUndoRedoAction.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000C30C4 File Offset: 0x000C12C4
		[CallerCount(0)]
		public unsafe virtual void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUndoRedoAction.NativeMethodInfoPtr_Undo_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000C3100 File Offset: 0x000C1300
		[CallerCount(0)]
		public unsafe virtual void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUndoRedoAction.NativeMethodInfoPtr_Redo_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000C313C File Offset: 0x000C133C
		[CallerCount(0)]
		public unsafe virtual void OnRemovedFromUndoRedoStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUndoRedoAction.NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x0001014D File Offset: 0x0000E34D
		public IUndoRedoAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromUndoRedoStack_Public_Abstract_Virtual_New_Void_0;
	}
}
