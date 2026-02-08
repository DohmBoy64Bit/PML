using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200022D RID: 557
	public sealed class ObjectSelectionManipSessionEndHandler : MulticastDelegate
	{
		// Token: 0x06002B25 RID: 11045 RVA: 0x000CBB74 File Offset: 0x000C9D74
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionManipSessionEndHandler()
		{
			Il2CppClassPointerStore<ObjectSelectionManipSessionEndHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionManipSessionEndHandler");
			ObjectSelectionManipSessionEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionManipSessionEndHandler>.NativeClassPtr, 100669853);
			ObjectSelectionManipSessionEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionManipSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionManipSessionEndHandler>.NativeClassPtr, 100669854);
			ObjectSelectionManipSessionEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionManipSession_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionManipSessionEndHandler>.NativeClassPtr, 100669855);
			ObjectSelectionManipSessionEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionManipSessionEndHandler>.NativeClassPtr, 100669856);
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x000CBBEC File Offset: 0x000C9DEC
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionManipSessionEndHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionManipSessionEndHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionManipSessionEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000CBC48 File Offset: 0x000C9E48
		[CallerCount(0)]
		public unsafe void Invoke(ObjectSelectionManipSession session)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(session);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionManipSessionEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionManipSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000CBC8C File Offset: 0x000C9E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93909, XrefRangeEnd = 93913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ObjectSelectionManipSession session, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(session);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionManipSessionEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionManipSession_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000CBD00 File Offset: 0x000C9F00
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionManipSessionEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000110CE File Offset: 0x0000F2CE
		public ObjectSelectionManipSessionEndHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x000110D7 File Offset: 0x0000F2D7
		public static implicit operator ObjectSelectionManipSessionEndHandler(Action<ObjectSelectionManipSession> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectSelectionManipSessionEndHandler>(A_0);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x000110DF File Offset: 0x0000F2DF
		public static ObjectSelectionManipSessionEndHandler operator +(ObjectSelectionManipSessionEndHandler A_0, ObjectSelectionManipSessionEndHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectSelectionManipSessionEndHandler>();
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000110ED File Offset: 0x0000F2ED
		public static ObjectSelectionManipSessionEndHandler operator -(ObjectSelectionManipSessionEndHandler A_0, ObjectSelectionManipSessionEndHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectSelectionManipSessionEndHandler>();
			}
			return delegate2;
		}

		// Token: 0x04002163 RID: 8547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002164 RID: 8548
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionManipSession_0;

		// Token: 0x04002165 RID: 8549
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionManipSession_AsyncCallback_Object_0;

		// Token: 0x04002166 RID: 8550
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
