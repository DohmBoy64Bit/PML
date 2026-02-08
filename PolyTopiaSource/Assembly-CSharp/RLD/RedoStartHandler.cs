using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001FB RID: 507
	public sealed class RedoStartHandler : MulticastDelegate
	{
		// Token: 0x060028CB RID: 10443 RVA: 0x000C3518 File Offset: 0x000C1718
		// Note: this type is marked as 'beforefieldinit'.
		static RedoStartHandler()
		{
			Il2CppClassPointerStore<RedoStartHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RedoStartHandler");
			RedoStartHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedoStartHandler>.NativeClassPtr, 100669537);
			RedoStartHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedoStartHandler>.NativeClassPtr, 100669538);
			RedoStartHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedoStartHandler>.NativeClassPtr, 100669539);
			RedoStartHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedoStartHandler>.NativeClassPtr, 100669540);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000C3590 File Offset: 0x000C1790
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RedoStartHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedoStartHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedoStartHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000C35EC File Offset: 0x000C17EC
		[CallerCount(0)]
		public unsafe void Invoke(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedoStartHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000C3630 File Offset: 0x000C1830
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedoStartHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000C36A4 File Offset: 0x000C18A4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedoStartHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000101B6 File Offset: 0x0000E3B6
		public RedoStartHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000101BF File Offset: 0x0000E3BF
		public static implicit operator RedoStartHandler(Action<IUndoRedoAction> A_0)
		{
			return DelegateSupport.ConvertDelegate<RedoStartHandler>(A_0);
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000101C7 File Offset: 0x0000E3C7
		public static RedoStartHandler operator +(RedoStartHandler A_0, RedoStartHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<RedoStartHandler>();
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000101D5 File Offset: 0x0000E3D5
		public static RedoStartHandler operator -(RedoStartHandler A_0, RedoStartHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<RedoStartHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IUndoRedoAction_0;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IUndoRedoAction_AsyncCallback_Object_0;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
