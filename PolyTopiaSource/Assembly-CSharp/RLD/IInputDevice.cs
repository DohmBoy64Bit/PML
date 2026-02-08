using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000136 RID: 310
	public class IInputDevice : global::Il2CppSystem.Object
	{
		// Token: 0x06001C37 RID: 7223 RVA: 0x0008F7E4 File Offset: 0x0008D9E4
		// Note: this type is marked as 'beforefieldinit'.
		static IInputDevice()
		{
			Il2CppClassPointerStore<IInputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IInputDevice");
			IInputDevice.NativeMethodInfoPtr_get_DidDoubleTap_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667537);
			IInputDevice.NativeMethodInfoPtr_get_DoubleTapDelay_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667538);
			IInputDevice.NativeMethodInfoPtr_set_DoubleTapDelay_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667539);
			IInputDevice.NativeMethodInfoPtr_get_DeviceType_Public_Abstract_Virtual_New_get_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667540);
			IInputDevice.NativeMethodInfoPtr_add_DoubleTap_Public_Abstract_Virtual_New_add_Void_InputDeviceDoubleTapHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667535);
			IInputDevice.NativeMethodInfoPtr_remove_DoubleTap_Public_Abstract_Virtual_New_rem_Void_InputDeviceDoubleTapHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667536);
			IInputDevice.NativeMethodInfoPtr_GetRay_Public_Abstract_Virtual_New_Ray_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667541);
			IInputDevice.NativeMethodInfoPtr_GetPositionYAxisUp_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667542);
			IInputDevice.NativeMethodInfoPtr_HasPointer_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667543);
			IInputDevice.NativeMethodInfoPtr_IsButtonPressed_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667544);
			IInputDevice.NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667545);
			IInputDevice.NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667546);
			IInputDevice.NativeMethodInfoPtr_WasMoved_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667547);
			IInputDevice.NativeMethodInfoPtr_CreateDeltaCapture_Public_Abstract_Virtual_New_Boolean_Vector3_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667548);
			IInputDevice.NativeMethodInfoPtr_RemoveDeltaCapture_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667549);
			IInputDevice.NativeMethodInfoPtr_GetCaptureDelta_Public_Abstract_Virtual_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667550);
			IInputDevice.NativeMethodInfoPtr_GetFrameDelta_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667551);
			IInputDevice.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputDevice>.NativeClassPtr, 100667552);
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x0008F974 File Offset: 0x0008DB74
		public unsafe virtual bool DidDoubleTap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_get_DidDoubleTap_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x0008F9BC File Offset: 0x0008DBBC
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x0008FA04 File Offset: 0x0008DC04
		public unsafe virtual float DoubleTapDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_get_DoubleTapDelay_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_set_DoubleTapDelay_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0008FA50 File Offset: 0x0008DC50
		public unsafe virtual InputDeviceType DeviceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_get_DeviceType_Public_Abstract_Virtual_New_get_InputDeviceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDeviceType>(intPtr3) : null;
			}
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0008FA9C File Offset: 0x0008DC9C
		[CallerCount(0)]
		public unsafe virtual void add_DoubleTap(InputDeviceDoubleTapHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_add_DoubleTap_Public_Abstract_Virtual_New_add_Void_InputDeviceDoubleTapHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0008FAEC File Offset: 0x0008DCEC
		[CallerCount(0)]
		public unsafe virtual void remove_DoubleTap(InputDeviceDoubleTapHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_remove_DoubleTap_Public_Abstract_Virtual_New_rem_Void_InputDeviceDoubleTapHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0008FB3C File Offset: 0x0008DD3C
		[CallerCount(0)]
		public unsafe virtual Ray GetRay(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_GetRay_Public_Abstract_Virtual_New_Ray_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr3) : null;
			}
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0008FB98 File Offset: 0x0008DD98
		[CallerCount(0)]
		public unsafe virtual Vector3 GetPositionYAxisUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_GetPositionYAxisUp_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0008FBE4 File Offset: 0x0008DDE4
		[CallerCount(0)]
		public unsafe virtual bool HasPointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_HasPointer_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0008FC2C File Offset: 0x0008DE2C
		[CallerCount(0)]
		public unsafe virtual bool IsButtonPressed(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_IsButtonPressed_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0008FC80 File Offset: 0x0008DE80
		[CallerCount(0)]
		public unsafe virtual bool WasButtonPressedInCurrentFrame(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0008FCD4 File Offset: 0x0008DED4
		[CallerCount(0)]
		public unsafe virtual bool WasButtonReleasedInCurrentFrame(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0008FD28 File Offset: 0x0008DF28
		[CallerCount(0)]
		public unsafe virtual bool WasMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_WasMoved_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0008FD70 File Offset: 0x0008DF70
		[CallerCount(0)]
		public unsafe virtual bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deltaOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &deltaCaptureId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_CreateDeltaCapture_Public_Abstract_Virtual_New_Boolean_Vector3_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0008FDD8 File Offset: 0x0008DFD8
		[CallerCount(0)]
		public unsafe virtual void RemoveDeltaCapture(int deltaCaptureId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaCaptureId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_RemoveDeltaCapture_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0008FE24 File Offset: 0x0008E024
		[CallerCount(0)]
		public unsafe virtual Vector3 GetCaptureDelta(int deltaCaptureId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaCaptureId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_GetCaptureDelta_Public_Abstract_Virtual_New_Vector3_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0008FE7C File Offset: 0x0008E07C
		[CallerCount(0)]
		public unsafe virtual Vector3 GetFrameDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_GetFrameDelta_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0008FEC8 File Offset: 0x0008E0C8
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputDevice.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0000C031 File Offset: 0x0000A231
		public IInputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_get_DidDoubleTap_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_get_DoubleTapDelay_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_set_DoubleTapDelay_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceType_Public_Abstract_Virtual_New_get_InputDeviceType_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_add_DoubleTap_Public_Abstract_Virtual_New_add_Void_InputDeviceDoubleTapHandler_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_remove_DoubleTap_Public_Abstract_Virtual_New_rem_Void_InputDeviceDoubleTapHandler_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_GetRay_Public_Abstract_Virtual_New_Ray_Camera_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionYAxisUp_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr_HasPointer_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr_IsButtonPressed_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_WasMoved_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeltaCapture_Public_Abstract_Virtual_New_Boolean_Vector3_byref_Int32_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDeltaCapture_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_GetCaptureDelta_Public_Abstract_Virtual_New_Vector3_Int32_0;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeMethodInfoPtr_GetFrameDelta_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;
	}
}
