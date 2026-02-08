using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001FC RID: 508
	public sealed class RedoEndHandler : MulticastDelegate
	{
		// Token: 0x060028D4 RID: 10452 RVA: 0x000C36E8 File Offset: 0x000C18E8
		// Note: this type is marked as 'beforefieldinit'.
		static RedoEndHandler()
		{
			Il2CppClassPointerStore<RedoEndHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RedoEndHandler");
			RedoEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedoEndHandler>.NativeClassPtr, 100669541);
			RedoEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedoEndHandler>.NativeClassPtr, 100669542);
			RedoEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedoEndHandler>.NativeClassPtr, 100669543);
			RedoEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedoEndHandler>.NativeClassPtr, 100669544);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000C3760 File Offset: 0x000C1960
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RedoEndHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedoEndHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedoEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000C37BC File Offset: 0x000C19BC
		[CallerCount(0)]
		public unsafe void Invoke(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedoEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000C3800 File Offset: 0x000C1A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(IUndoRedoAction action, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedoEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000C3874 File Offset: 0x000C1A74
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedoEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000101E6 File Offset: 0x0000E3E6
		public RedoEndHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000101EF File Offset: 0x0000E3EF
		public static implicit operator RedoEndHandler(Action<IUndoRedoAction> A_0)
		{
			return DelegateSupport.ConvertDelegate<RedoEndHandler>(A_0);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x000101F7 File Offset: 0x0000E3F7
		public static RedoEndHandler operator +(RedoEndHandler A_0, RedoEndHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<RedoEndHandler>();
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00010205 File Offset: 0x0000E405
		public static RedoEndHandler operator -(RedoEndHandler A_0, RedoEndHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<RedoEndHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
