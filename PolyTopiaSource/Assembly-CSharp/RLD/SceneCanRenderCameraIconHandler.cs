using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B6 RID: 438
	public sealed class SceneCanRenderCameraIconHandler : MulticastDelegate
	{
		// Token: 0x060021D9 RID: 8665 RVA: 0x000A7A28 File Offset: 0x000A5C28
		// Note: this type is marked as 'beforefieldinit'.
		static SceneCanRenderCameraIconHandler()
		{
			Il2CppClassPointerStore<SceneCanRenderCameraIconHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneCanRenderCameraIconHandler");
			SceneCanRenderCameraIconHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCanRenderCameraIconHandler>.NativeClassPtr, 100668423);
			SceneCanRenderCameraIconHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCanRenderCameraIconHandler>.NativeClassPtr, 100668424);
			SceneCanRenderCameraIconHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_YesNoAnswer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCanRenderCameraIconHandler>.NativeClassPtr, 100668425);
			SceneCanRenderCameraIconHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCanRenderCameraIconHandler>.NativeClassPtr, 100668426);
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000A7AA0 File Offset: 0x000A5CA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74936, RefRangeEnd = 74939, XrefRangeStart = 74936, XrefRangeEnd = 74939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneCanRenderCameraIconHandler(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneCanRenderCameraIconHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneCanRenderCameraIconHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x000A7AFC File Offset: 0x000A5CFC
		[CallerCount(0)]
		public unsafe void Invoke(Camera camera, YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneCanRenderCameraIconHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000A7B50 File Offset: 0x000A5D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Camera camera, YesNoAnswer answer, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneCanRenderCameraIconHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_YesNoAnswer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x000A7BD8 File Offset: 0x000A5DD8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneCanRenderCameraIconHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0000DCF5 File Offset: 0x0000BEF5
		public SceneCanRenderCameraIconHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0000DCFE File Offset: 0x0000BEFE
		public static implicit operator SceneCanRenderCameraIconHandler(Action<Camera, YesNoAnswer> A_0)
		{
			return DelegateSupport.ConvertDelegate<SceneCanRenderCameraIconHandler>(A_0);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0000DD06 File Offset: 0x0000BF06
		public static SceneCanRenderCameraIconHandler operator +(SceneCanRenderCameraIconHandler A_0, SceneCanRenderCameraIconHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SceneCanRenderCameraIconHandler>();
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0000DD14 File Offset: 0x0000BF14
		public static SceneCanRenderCameraIconHandler operator -(SceneCanRenderCameraIconHandler A_0, SceneCanRenderCameraIconHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SceneCanRenderCameraIconHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_YesNoAnswer_0;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_YesNoAnswer_AsyncCallback_Object_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
