using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001FD RID: 509
	public sealed class CanUndoRedoHandler : MulticastDelegate
	{
		// Token: 0x060028DD RID: 10461 RVA: 0x000C38B8 File Offset: 0x000C1AB8
		// Note: this type is marked as 'beforefieldinit'.
		static CanUndoRedoHandler()
		{
			Il2CppClassPointerStore<CanUndoRedoHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CanUndoRedoHandler");
			CanUndoRedoHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanUndoRedoHandler>.NativeClassPtr, 100669545);
			CanUndoRedoHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UndoRedoOpType_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanUndoRedoHandler>.NativeClassPtr, 100669546);
			CanUndoRedoHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UndoRedoOpType_YesNoAnswer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanUndoRedoHandler>.NativeClassPtr, 100669547);
			CanUndoRedoHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanUndoRedoHandler>.NativeClassPtr, 100669548);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000C3930 File Offset: 0x000C1B30
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52325, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanUndoRedoHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanUndoRedoHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanUndoRedoHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000C398C File Offset: 0x000C1B8C
		[CallerCount(0)]
		public unsafe void Invoke(UndoRedoOpType undoRedoOpType, YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoRedoOpType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanUndoRedoHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UndoRedoOpType_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000C39E0 File Offset: 0x000C1BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90995, XrefRangeEnd = 90999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UndoRedoOpType undoRedoOpType, YesNoAnswer answer, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoRedoOpType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanUndoRedoHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UndoRedoOpType_YesNoAnswer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000C3A68 File Offset: 0x000C1C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanUndoRedoHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x00010216 File Offset: 0x0000E416
		public CanUndoRedoHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x0001021F File Offset: 0x0000E41F
		public static implicit operator CanUndoRedoHandler(Action<UndoRedoOpType, YesNoAnswer> A_0)
		{
			return DelegateSupport.ConvertDelegate<CanUndoRedoHandler>(A_0);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00010227 File Offset: 0x0000E427
		public static CanUndoRedoHandler operator +(CanUndoRedoHandler A_0, CanUndoRedoHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CanUndoRedoHandler>();
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00010235 File Offset: 0x0000E435
		public static CanUndoRedoHandler operator -(CanUndoRedoHandler A_0, CanUndoRedoHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CanUndoRedoHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UndoRedoOpType_YesNoAnswer_0;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UndoRedoOpType_YesNoAnswer_AsyncCallback_Object_0;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
