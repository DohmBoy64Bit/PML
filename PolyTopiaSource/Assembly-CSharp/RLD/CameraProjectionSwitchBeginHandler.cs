using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000104 RID: 260
	public sealed class CameraProjectionSwitchBeginHandler : MulticastDelegate
	{
		// Token: 0x060018F1 RID: 6385 RVA: 0x00082594 File Offset: 0x00080794
		// Note: this type is marked as 'beforefieldinit'.
		static CameraProjectionSwitchBeginHandler()
		{
			Il2CppClassPointerStore<CameraProjectionSwitchBeginHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraProjectionSwitchBeginHandler");
			CameraProjectionSwitchBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchBeginHandler>.NativeClassPtr, 100666966);
			CameraProjectionSwitchBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchBeginHandler>.NativeClassPtr, 100666967);
			CameraProjectionSwitchBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Type_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchBeginHandler>.NativeClassPtr, 100666968);
			CameraProjectionSwitchBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchBeginHandler>.NativeClassPtr, 100666969);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0008260C File Offset: 0x0008080C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraProjectionSwitchBeginHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraProjectionSwitchBeginHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchBeginHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00082668 File Offset: 0x00080868
		[CallerCount(0)]
		public unsafe void Invoke(CameraPrjSwitchTransition.Type transitionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transitionType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchBeginHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000826A8 File Offset: 0x000808A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74511, XrefRangeEnd = 74515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchBeginHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Type_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00082718 File Offset: 0x00080918
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchBeginHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0000AFE8 File Offset: 0x000091E8
		public CameraProjectionSwitchBeginHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0000AFF1 File Offset: 0x000091F1
		public static implicit operator CameraProjectionSwitchBeginHandler(Action<CameraPrjSwitchTransition.Type> A_0)
		{
			return DelegateSupport.ConvertDelegate<CameraProjectionSwitchBeginHandler>(A_0);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0000AFF9 File Offset: 0x000091F9
		public static CameraProjectionSwitchBeginHandler operator +(CameraProjectionSwitchBeginHandler A_0, CameraProjectionSwitchBeginHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CameraProjectionSwitchBeginHandler>();
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0000B007 File Offset: 0x00009207
		public static CameraProjectionSwitchBeginHandler operator -(CameraProjectionSwitchBeginHandler A_0, CameraProjectionSwitchBeginHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CameraProjectionSwitchBeginHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Type_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Type_AsyncCallback_Object_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
