using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200022C RID: 556
	public sealed class ObjectSelectionManipSessionBeginHandler : MulticastDelegate
	{
		// Token: 0x06002B1C RID: 11036 RVA: 0x000CB9A4 File Offset: 0x000C9BA4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionManipSessionBeginHandler()
		{
			Il2CppClassPointerStore<ObjectSelectionManipSessionBeginHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionManipSessionBeginHandler");
			ObjectSelectionManipSessionBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionManipSessionBeginHandler>.NativeClassPtr, 100669849);
			ObjectSelectionManipSessionBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionManipSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionManipSessionBeginHandler>.NativeClassPtr, 100669850);
			ObjectSelectionManipSessionBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionManipSession_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionManipSessionBeginHandler>.NativeClassPtr, 100669851);
			ObjectSelectionManipSessionBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionManipSessionBeginHandler>.NativeClassPtr, 100669852);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000CBA1C File Offset: 0x000C9C1C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionManipSessionBeginHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionManipSessionBeginHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionManipSessionBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000CBA78 File Offset: 0x000C9C78
		[CallerCount(0)]
		public unsafe void Invoke(ObjectSelectionManipSession session)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(session);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionManipSessionBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionManipSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000CBABC File Offset: 0x000C9CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93905, XrefRangeEnd = 93909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionManipSessionBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionManipSession_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x000CBB30 File Offset: 0x000C9D30
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionManipSessionBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x0001109E File Offset: 0x0000F29E
		public ObjectSelectionManipSessionBeginHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x000110A7 File Offset: 0x0000F2A7
		public static implicit operator ObjectSelectionManipSessionBeginHandler(Action<ObjectSelectionManipSession> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectSelectionManipSessionBeginHandler>(A_0);
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000110AF File Offset: 0x0000F2AF
		public static ObjectSelectionManipSessionBeginHandler operator +(ObjectSelectionManipSessionBeginHandler A_0, ObjectSelectionManipSessionBeginHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectSelectionManipSessionBeginHandler>();
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000110BD File Offset: 0x0000F2BD
		public static ObjectSelectionManipSessionBeginHandler operator -(ObjectSelectionManipSessionBeginHandler A_0, ObjectSelectionManipSessionBeginHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectSelectionManipSessionBeginHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObjectSelectionManipSession_0;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObjectSelectionManipSession_AsyncCallback_Object_0;

		// Token: 0x04002162 RID: 8546
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
