using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000137 RID: 311
	public class InputDeviceBase : global::Il2CppSystem.Object
	{
		// Token: 0x06001C4B RID: 7243 RVA: 0x0008FF04 File Offset: 0x0008E104
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceBase()
		{
			Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "InputDeviceBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr);
			InputDeviceBase.NativeFieldInfoPtr_DoubleTap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, "DoubleTap");
			InputDeviceBase.NativeFieldInfoPtr__doubleTapDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, "_doubleTapDelay");
			InputDeviceBase.NativeFieldInfoPtr__lastTapTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, "_lastTapTime");
			InputDeviceBase.NativeFieldInfoPtr__didDoubleTap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, "_didDoubleTap");
			InputDeviceBase.NativeFieldInfoPtr__maxNumDeltaCaptures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, "_maxNumDeltaCaptures");
			InputDeviceBase.NativeFieldInfoPtr__deltaCaptures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, "_deltaCaptures");
			InputDeviceBase.NativeMethodInfoPtr_get_DidDoubleTap_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667555);
			InputDeviceBase.NativeMethodInfoPtr_get_DoubleTapDelay_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667556);
			InputDeviceBase.NativeMethodInfoPtr_set_DoubleTapDelay_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667557);
			InputDeviceBase.NativeMethodInfoPtr_get_DeviceType_Public_Abstract_Virtual_New_get_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667558);
			InputDeviceBase.NativeMethodInfoPtr_add_DoubleTap_Public_Virtual_Final_New_add_Void_InputDeviceDoubleTapHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667553);
			InputDeviceBase.NativeMethodInfoPtr_remove_DoubleTap_Public_Virtual_Final_New_rem_Void_InputDeviceDoubleTapHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667554);
			InputDeviceBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667559);
			InputDeviceBase.NativeMethodInfoPtr_SetMaxNumDeltaCaptures_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667560);
			InputDeviceBase.NativeMethodInfoPtr_CreateDeltaCapture_Public_Virtual_Final_New_Boolean_Vector3_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667561);
			InputDeviceBase.NativeMethodInfoPtr_RemoveDeltaCapture_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667562);
			InputDeviceBase.NativeMethodInfoPtr_GetCaptureDelta_Public_Virtual_Final_New_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667563);
			InputDeviceBase.NativeMethodInfoPtr_GetFrameDelta_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667564);
			InputDeviceBase.NativeMethodInfoPtr_GetRay_Public_Abstract_Virtual_New_Ray_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667565);
			InputDeviceBase.NativeMethodInfoPtr_GetPositionYAxisUp_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667566);
			InputDeviceBase.NativeMethodInfoPtr_HasPointer_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667567);
			InputDeviceBase.NativeMethodInfoPtr_IsButtonPressed_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667568);
			InputDeviceBase.NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667569);
			InputDeviceBase.NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667570);
			InputDeviceBase.NativeMethodInfoPtr_WasMoved_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667571);
			InputDeviceBase.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667572);
			InputDeviceBase.NativeMethodInfoPtr_UpateFrameDeltas_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667573);
			InputDeviceBase.NativeMethodInfoPtr_UpdateDeltaCaptures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667574);
			InputDeviceBase.NativeMethodInfoPtr_DetectAndHandleDoubleTap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr, 100667575);
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00090178 File Offset: 0x0008E378
		public unsafe virtual bool DidDoubleTap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_get_DidDoubleTap_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x000901B4 File Offset: 0x0008E3B4
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x000901F0 File Offset: 0x0008E3F0
		public unsafe virtual float DoubleTapDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_get_DoubleTapDelay_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_set_DoubleTapDelay_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00090230 File Offset: 0x0008E430
		public unsafe virtual InputDeviceType DeviceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_get_DeviceType_Public_Abstract_Virtual_New_get_InputDeviceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDeviceType>(intPtr3) : null;
			}
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0009027C File Offset: 0x0008E47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78581, XrefRangeEnd = 78585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_DoubleTap(InputDeviceDoubleTapHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_add_DoubleTap_Public_Virtual_Final_New_add_Void_InputDeviceDoubleTapHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x000902C0 File Offset: 0x0008E4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78585, XrefRangeEnd = 78589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_DoubleTap(InputDeviceDoubleTapHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_remove_DoubleTap_Public_Virtual_Final_New_rem_Void_InputDeviceDoubleTapHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00090304 File Offset: 0x0008E504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78589, XrefRangeEnd = 78594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDeviceBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00090340 File Offset: 0x0008E540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78594, XrefRangeEnd = 78598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxNumDeltaCaptures(int maxNumDeltaCaptures)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumDeltaCaptures;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_SetMaxNumDeltaCaptures_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00090380 File Offset: 0x0008E580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78598, XrefRangeEnd = 78605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_CreateDeltaCapture_Public_Virtual_Final_New_Boolean_Vector3_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x000903DC File Offset: 0x0008E5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78605, XrefRangeEnd = 78606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveDeltaCapture(int deltaCaptureId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaCaptureId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_RemoveDeltaCapture_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0009041C File Offset: 0x0008E61C
		[CallerCount(0)]
		public unsafe virtual Vector3 GetCaptureDelta(int deltaCaptureId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaCaptureId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_GetCaptureDelta_Public_Virtual_Final_New_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00090468 File Offset: 0x0008E668
		[CallerCount(0)]
		public unsafe virtual Vector3 GetFrameDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_GetFrameDelta_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x000904B4 File Offset: 0x0008E6B4
		[CallerCount(0)]
		public unsafe virtual Ray GetRay(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_GetRay_Public_Abstract_Virtual_New_Ray_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr3) : null;
			}
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00090510 File Offset: 0x0008E710
		[CallerCount(0)]
		public unsafe virtual Vector3 GetPositionYAxisUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_GetPositionYAxisUp_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0009055C File Offset: 0x0008E75C
		[CallerCount(0)]
		public unsafe virtual bool HasPointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_HasPointer_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x000905A4 File Offset: 0x0008E7A4
		[CallerCount(0)]
		public unsafe virtual bool IsButtonPressed(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_IsButtonPressed_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000905F8 File Offset: 0x0008E7F8
		[CallerCount(0)]
		public unsafe virtual bool WasButtonPressedInCurrentFrame(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0009064C File Offset: 0x0008E84C
		[CallerCount(0)]
		public unsafe virtual bool WasButtonReleasedInCurrentFrame(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000906A0 File Offset: 0x0008E8A0
		[CallerCount(0)]
		public unsafe virtual bool WasMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_WasMoved_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x000906E8 File Offset: 0x0008E8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78606, XrefRangeEnd = 78609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0009071C File Offset: 0x0008E91C
		[CallerCount(0)]
		public unsafe virtual void UpateFrameDeltas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceBase.NativeMethodInfoPtr_UpateFrameDeltas_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00090758 File Offset: 0x0008E958
		[CallerCount(0)]
		public unsafe void UpdateDeltaCaptures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_UpdateDeltaCaptures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0009078C File Offset: 0x0008E98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78609, XrefRangeEnd = 78611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectAndHandleDoubleTap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceBase.NativeMethodInfoPtr_DetectAndHandleDoubleTap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0000C03A File Offset: 0x0000A23A
		public InputDeviceBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x000907C0 File Offset: 0x0008E9C0
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x0000C043 File Offset: 0x0000A243
		public unsafe InputDeviceDoubleTapHandler DoubleTap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr_DoubleTap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDeviceDoubleTapHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr_DoubleTap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000907F0 File Offset: 0x0008E9F0
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x0000C062 File Offset: 0x0000A262
		public unsafe float _doubleTapDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__doubleTapDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__doubleTapDelay)) = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x00090818 File Offset: 0x0008EA18
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x0000C07D File Offset: 0x0000A27D
		public unsafe float _lastTapTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__lastTapTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__lastTapTime)) = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00090840 File Offset: 0x0008EA40
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0000C098 File Offset: 0x0000A298
		public unsafe bool _didDoubleTap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__didDoubleTap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__didDoubleTap)) = value;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00090868 File Offset: 0x0008EA68
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x0000C0B3 File Offset: 0x0000A2B3
		public unsafe int _maxNumDeltaCaptures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__maxNumDeltaCaptures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__maxNumDeltaCaptures)) = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00090890 File Offset: 0x0008EA90
		// (set) Token: 0x06001C6F RID: 7279 RVA: 0x0000C0CE File Offset: 0x0000A2CE
		public unsafe Il2CppReferenceArray<InputDeviceDeltaCapture> _deltaCaptures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__deltaCaptures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputDeviceDeltaCapture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceBase.NativeFieldInfoPtr__deltaCaptures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeFieldInfoPtr_DoubleTap;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeFieldInfoPtr__doubleTapDelay;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeFieldInfoPtr__lastTapTime;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeFieldInfoPtr__didDoubleTap;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeFieldInfoPtr__maxNumDeltaCaptures;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeFieldInfoPtr__deltaCaptures;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_get_DidDoubleTap_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_get_DoubleTapDelay_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_set_DoubleTapDelay_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceType_Public_Abstract_Virtual_New_get_InputDeviceType_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_add_DoubleTap_Public_Virtual_Final_New_add_Void_InputDeviceDoubleTapHandler_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_remove_DoubleTap_Public_Virtual_Final_New_rem_Void_InputDeviceDoubleTapHandler_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxNumDeltaCaptures_Public_Void_Int32_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeltaCapture_Public_Virtual_Final_New_Boolean_Vector3_byref_Int32_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDeltaCapture_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_GetCaptureDelta_Public_Virtual_Final_New_Vector3_Int32_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_GetFrameDelta_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_GetRay_Public_Abstract_Virtual_New_Ray_Camera_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionYAxisUp_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeMethodInfoPtr_HasPointer_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeMethodInfoPtr_IsButtonPressed_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_WasMoved_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_UpateFrameDeltas_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeltaCaptures_Private_Void_0;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeMethodInfoPtr_DetectAndHandleDoubleTap_Private_Void_0;
	}
}
