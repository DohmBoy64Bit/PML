using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001F9 RID: 505
	public sealed class UndoStartHandler : MulticastDelegate
	{
		// Token: 0x060028B9 RID: 10425 RVA: 0x000C3178 File Offset: 0x000C1378
		// Note: this type is marked as 'beforefieldinit'.
		static UndoStartHandler()
		{
			Il2CppClassPointerStore<UndoStartHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "UndoStartHandler");
			UndoStartHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoStartHandler>.NativeClassPtr, 100669529);
			UndoStartHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoStartHandler>.NativeClassPtr, 100669530);
			UndoStartHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoStartHandler>.NativeClassPtr, 100669531);
			UndoStartHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoStartHandler>.NativeClassPtr, 100669532);
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x000C31F0 File Offset: 0x000C13F0
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoStartHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoStartHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoStartHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x000C324C File Offset: 0x000C144C
		[CallerCount(0)]
		public unsafe void Invoke(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoStartHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000C3290 File Offset: 0x000C1490
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoStartHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000C3304 File Offset: 0x000C1504
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoStartHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x00010156 File Offset: 0x0000E356
		public UndoStartHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0001015F File Offset: 0x0000E35F
		public static implicit operator UndoStartHandler(Action<IUndoRedoAction> A_0)
		{
			return DelegateSupport.ConvertDelegate<UndoStartHandler>(A_0);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00010167 File Offset: 0x0000E367
		public static UndoStartHandler operator +(UndoStartHandler A_0, UndoStartHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UndoStartHandler>();
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x00010175 File Offset: 0x0000E375
		public static UndoStartHandler operator -(UndoStartHandler A_0, UndoStartHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UndoStartHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
