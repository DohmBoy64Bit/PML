using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000135 RID: 309
	public sealed class InputDeviceDoubleTapHandler : MulticastDelegate
	{
		// Token: 0x06001C2E RID: 7214 RVA: 0x0008F5F0 File Offset: 0x0008D7F0
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceDoubleTapHandler()
		{
			Il2CppClassPointerStore<InputDeviceDoubleTapHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "InputDeviceDoubleTapHandler");
			InputDeviceDoubleTapHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceDoubleTapHandler>.NativeClassPtr, 100667531);
			InputDeviceDoubleTapHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IInputDevice_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceDoubleTapHandler>.NativeClassPtr, 100667532);
			InputDeviceDoubleTapHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IInputDevice_Vector2_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceDoubleTapHandler>.NativeClassPtr, 100667533);
			InputDeviceDoubleTapHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceDoubleTapHandler>.NativeClassPtr, 100667534);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0008F668 File Offset: 0x0008D868
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 78571, RefRangeEnd = 78577, XrefRangeStart = 78561, XrefRangeEnd = 78571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDeviceDoubleTapHandler(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceDoubleTapHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceDoubleTapHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0008F6C4 File Offset: 0x0008D8C4
		[CallerCount(0)]
		public unsafe void Invoke(IInputDevice inputDevice, Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceDoubleTapHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IInputDevice_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0008F718 File Offset: 0x0008D918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78577, XrefRangeEnd = 78581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(IInputDevice inputDevice, Vector2 position, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceDoubleTapHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IInputDevice_Vector2_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0008F7A0 File Offset: 0x0008D9A0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceDoubleTapHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0000C001 File Offset: 0x0000A201
		public InputDeviceDoubleTapHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0000C00A File Offset: 0x0000A20A
		public static implicit operator InputDeviceDoubleTapHandler(Action<IInputDevice, Vector2> A_0)
		{
			return DelegateSupport.ConvertDelegate<InputDeviceDoubleTapHandler>(A_0);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0000C012 File Offset: 0x0000A212
		public static InputDeviceDoubleTapHandler operator +(InputDeviceDoubleTapHandler A_0, InputDeviceDoubleTapHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<InputDeviceDoubleTapHandler>();
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0000C020 File Offset: 0x0000A220
		public static InputDeviceDoubleTapHandler operator -(InputDeviceDoubleTapHandler A_0, InputDeviceDoubleTapHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<InputDeviceDoubleTapHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IInputDevice_Vector2_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IInputDevice_Vector2_AsyncCallback_Object_0;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
