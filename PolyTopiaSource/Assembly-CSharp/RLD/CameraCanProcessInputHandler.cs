using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000112 RID: 274
	public sealed class CameraCanProcessInputHandler : MulticastDelegate
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x00085B44 File Offset: 0x00083D44
		// Note: this type is marked as 'beforefieldinit'.
		static CameraCanProcessInputHandler()
		{
			Il2CppClassPointerStore<CameraCanProcessInputHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraCanProcessInputHandler");
			CameraCanProcessInputHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCanProcessInputHandler>.NativeClassPtr, 100667105);
			CameraCanProcessInputHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCanProcessInputHandler>.NativeClassPtr, 100667106);
			CameraCanProcessInputHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCanProcessInputHandler>.NativeClassPtr, 100667107);
			CameraCanProcessInputHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCanProcessInputHandler>.NativeClassPtr, 100667108);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00085BBC File Offset: 0x00083DBC
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraCanProcessInputHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraCanProcessInputHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCanProcessInputHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00085C18 File Offset: 0x00083E18
		[CallerCount(0)]
		public unsafe void Invoke(YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCanProcessInputHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00085C5C File Offset: 0x00083E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(YesNoAnswer answer, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCanProcessInputHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00085CD0 File Offset: 0x00083ED0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCanProcessInputHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0000B582 File Offset: 0x00009782
		public CameraCanProcessInputHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0000B58B File Offset: 0x0000978B
		public static implicit operator CameraCanProcessInputHandler(Action<YesNoAnswer> A_0)
		{
			return DelegateSupport.ConvertDelegate<CameraCanProcessInputHandler>(A_0);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0000B593 File Offset: 0x00009793
		public static CameraCanProcessInputHandler operator +(CameraCanProcessInputHandler A_0, CameraCanProcessInputHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CameraCanProcessInputHandler>();
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0000B5A1 File Offset: 0x000097A1
		public static CameraCanProcessInputHandler operator -(CameraCanProcessInputHandler A_0, CameraCanProcessInputHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CameraCanProcessInputHandler>();
			}
			return delegate2;
		}

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_YesNoAnswer_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YesNoAnswer_AsyncCallback_Object_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
