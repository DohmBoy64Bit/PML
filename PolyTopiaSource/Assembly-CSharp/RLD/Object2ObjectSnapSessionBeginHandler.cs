using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001C4 RID: 452
	public sealed class Object2ObjectSnapSessionBeginHandler : MulticastDelegate
	{
		// Token: 0x060022DF RID: 8927 RVA: 0x000AB800 File Offset: 0x000A9A00
		// Note: this type is marked as 'beforefieldinit'.
		static Object2ObjectSnapSessionBeginHandler()
		{
			Il2CppClassPointerStore<Object2ObjectSnapSessionBeginHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Object2ObjectSnapSessionBeginHandler");
			Object2ObjectSnapSessionBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSessionBeginHandler>.NativeClassPtr, 100668554);
			Object2ObjectSnapSessionBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSessionBeginHandler>.NativeClassPtr, 100668555);
			Object2ObjectSnapSessionBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSessionBeginHandler>.NativeClassPtr, 100668556);
			Object2ObjectSnapSessionBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object2ObjectSnapSessionBeginHandler>.NativeClassPtr, 100668557);
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000AB878 File Offset: 0x000A9A78
		[CallerCount(247)]
		[CachedScanResults(RefRangeStart = 14625, RefRangeEnd = 14872, XrefRangeStart = 14625, XrefRangeEnd = 14872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object2ObjectSnapSessionBeginHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object2ObjectSnapSessionBeginHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSessionBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000AB8D4 File Offset: 0x000A9AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSessionBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x000AB908 File Offset: 0x000A9B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSessionBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x000AB96C File Offset: 0x000A9B6C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object2ObjectSnapSessionBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0000E424 File Offset: 0x0000C624
		public Object2ObjectSnapSessionBeginHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0000E42D File Offset: 0x0000C62D
		public static implicit operator Object2ObjectSnapSessionBeginHandler(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<Object2ObjectSnapSessionBeginHandler>(A_0);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0000E435 File Offset: 0x0000C635
		public static Object2ObjectSnapSessionBeginHandler operator +(Object2ObjectSnapSessionBeginHandler A_0, Object2ObjectSnapSessionBeginHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Object2ObjectSnapSessionBeginHandler>();
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x0000E443 File Offset: 0x0000C643
		public static Object2ObjectSnapSessionBeginHandler operator -(Object2ObjectSnapSessionBeginHandler A_0, Object2ObjectSnapSessionBeginHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Object2ObjectSnapSessionBeginHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
