using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000105 RID: 261
	public sealed class CameraProjectionSwitchUpdateHandler : MulticastDelegate
	{
		// Token: 0x060018FA RID: 6394 RVA: 0x0008275C File Offset: 0x0008095C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraProjectionSwitchUpdateHandler()
		{
			Il2CppClassPointerStore<CameraProjectionSwitchUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraProjectionSwitchUpdateHandler");
			CameraProjectionSwitchUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchUpdateHandler>.NativeClassPtr, 100666970);
			CameraProjectionSwitchUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchUpdateHandler>.NativeClassPtr, 100666971);
			CameraProjectionSwitchUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Type_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchUpdateHandler>.NativeClassPtr, 100666972);
			CameraProjectionSwitchUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchUpdateHandler>.NativeClassPtr, 100666973);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x000827D4 File Offset: 0x000809D4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraProjectionSwitchUpdateHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraProjectionSwitchUpdateHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00082830 File Offset: 0x00080A30
		[CallerCount(0)]
		public unsafe void Invoke(CameraPrjSwitchTransition.Type transitionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transitionType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00082870 File Offset: 0x00080A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74515, XrefRangeEnd = 74519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Type_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000828E0 File Offset: 0x00080AE0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0000B018 File Offset: 0x00009218
		public CameraProjectionSwitchUpdateHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0000B021 File Offset: 0x00009221
		public static implicit operator CameraProjectionSwitchUpdateHandler(Action<CameraPrjSwitchTransition.Type> A_0)
		{
			return DelegateSupport.ConvertDelegate<CameraProjectionSwitchUpdateHandler>(A_0);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0000B029 File Offset: 0x00009229
		public static CameraProjectionSwitchUpdateHandler operator +(CameraProjectionSwitchUpdateHandler A_0, CameraProjectionSwitchUpdateHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CameraProjectionSwitchUpdateHandler>();
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0000B037 File Offset: 0x00009237
		public static CameraProjectionSwitchUpdateHandler operator -(CameraProjectionSwitchUpdateHandler A_0, CameraProjectionSwitchUpdateHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CameraProjectionSwitchUpdateHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Type_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Type_AsyncCallback_Object_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
