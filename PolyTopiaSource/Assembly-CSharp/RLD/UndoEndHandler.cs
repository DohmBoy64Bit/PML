using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001FA RID: 506
	public sealed class UndoEndHandler : MulticastDelegate
	{
		// Token: 0x060028C2 RID: 10434 RVA: 0x000C3348 File Offset: 0x000C1548
		// Note: this type is marked as 'beforefieldinit'.
		static UndoEndHandler()
		{
			Il2CppClassPointerStore<UndoEndHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "UndoEndHandler");
			UndoEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoEndHandler>.NativeClassPtr, 100669533);
			UndoEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoEndHandler>.NativeClassPtr, 100669534);
			UndoEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoEndHandler>.NativeClassPtr, 100669535);
			UndoEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoEndHandler>.NativeClassPtr, 100669536);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000C33C0 File Offset: 0x000C15C0
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoEndHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoEndHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000C341C File Offset: 0x000C161C
		[CallerCount(0)]
		public unsafe void Invoke(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000C3460 File Offset: 0x000C1660
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000C34D4 File Offset: 0x000C16D4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x00010186 File Offset: 0x0000E386
		public UndoEndHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0001018F File Offset: 0x0000E38F
		public static implicit operator UndoEndHandler(Action<IUndoRedoAction> A_0)
		{
			return DelegateSupport.ConvertDelegate<UndoEndHandler>(A_0);
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00010197 File Offset: 0x0000E397
		public static UndoEndHandler operator +(UndoEndHandler A_0, UndoEndHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UndoEndHandler>();
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000101A5 File Offset: 0x0000E3A5
		public static UndoEndHandler operator -(UndoEndHandler A_0, UndoEndHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UndoEndHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
