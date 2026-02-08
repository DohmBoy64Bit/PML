using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000106 RID: 262
	public sealed class CameraProjectionSwitchEndHandler : MulticastDelegate
	{
		// Token: 0x06001903 RID: 6403 RVA: 0x00082924 File Offset: 0x00080B24
		// Note: this type is marked as 'beforefieldinit'.
		static CameraProjectionSwitchEndHandler()
		{
			Il2CppClassPointerStore<CameraProjectionSwitchEndHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraProjectionSwitchEndHandler");
			CameraProjectionSwitchEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchEndHandler>.NativeClassPtr, 100666974);
			CameraProjectionSwitchEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchEndHandler>.NativeClassPtr, 100666975);
			CameraProjectionSwitchEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Type_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchEndHandler>.NativeClassPtr, 100666976);
			CameraProjectionSwitchEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchEndHandler>.NativeClassPtr, 100666977);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0008299C File Offset: 0x00080B9C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraProjectionSwitchEndHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraProjectionSwitchEndHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchEndHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x000829F8 File Offset: 0x00080BF8
		[CallerCount(0)]
		public unsafe void Invoke(CameraPrjSwitchTransition.Type transitionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transitionType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchEndHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00082A38 File Offset: 0x00080C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74519, XrefRangeEnd = 74523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(CameraPrjSwitchTransition.Type transitionType, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transitionType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchEndHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Type_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00082AA8 File Offset: 0x00080CA8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchEndHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0000B048 File Offset: 0x00009248
		public CameraProjectionSwitchEndHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0000B051 File Offset: 0x00009251
		public static implicit operator CameraProjectionSwitchEndHandler(Action<CameraPrjSwitchTransition.Type> A_0)
		{
			return DelegateSupport.ConvertDelegate<CameraProjectionSwitchEndHandler>(A_0);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0000B059 File Offset: 0x00009259
		public static CameraProjectionSwitchEndHandler operator +(CameraProjectionSwitchEndHandler A_0, CameraProjectionSwitchEndHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CameraProjectionSwitchEndHandler>();
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0000B067 File Offset: 0x00009267
		public static CameraProjectionSwitchEndHandler operator -(CameraProjectionSwitchEndHandler A_0, CameraProjectionSwitchEndHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CameraProjectionSwitchEndHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Type_0;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Type_AsyncCallback_Object_0;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
