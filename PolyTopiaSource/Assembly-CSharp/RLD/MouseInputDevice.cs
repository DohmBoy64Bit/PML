using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200013B RID: 315
	public class MouseInputDevice : InputDeviceBase
	{
		// Token: 0x06001C7D RID: 7293 RVA: 0x00090B74 File Offset: 0x0008ED74
		// Note: this type is marked as 'beforefieldinit'.
		static MouseInputDevice()
		{
			Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MouseInputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr);
			MouseInputDevice.NativeFieldInfoPtr__frameDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, "_frameDelta");
			MouseInputDevice.NativeFieldInfoPtr__mousePosInLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, "_mousePosInLastFrame");
			MouseInputDevice.NativeMethodInfoPtr_get_DeviceType_Public_Virtual_get_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667581);
			MouseInputDevice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667582);
			MouseInputDevice.NativeMethodInfoPtr_GetFrameDelta_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667583);
			MouseInputDevice.NativeMethodInfoPtr_GetRay_Public_Virtual_Ray_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667584);
			MouseInputDevice.NativeMethodInfoPtr_GetPositionYAxisUp_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667585);
			MouseInputDevice.NativeMethodInfoPtr_HasPointer_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667586);
			MouseInputDevice.NativeMethodInfoPtr_IsButtonPressed_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667587);
			MouseInputDevice.NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667588);
			MouseInputDevice.NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667589);
			MouseInputDevice.NativeMethodInfoPtr_WasMoved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667590);
			MouseInputDevice.NativeMethodInfoPtr_UpateFrameDeltas_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr, 100667591);
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00090CA8 File Offset: 0x0008EEA8
		public unsafe override InputDeviceType DeviceType
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_get_DeviceType_Public_Virtual_get_InputDeviceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDeviceType>(intPtr3) : null;
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00090CF4 File Offset: 0x0008EEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78612, XrefRangeEnd = 78620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseInputDevice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseInputDevice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseInputDevice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00090D30 File Offset: 0x0008EF30
		[CallerCount(0)]
		public unsafe override Vector3 GetFrameDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_GetFrameDelta_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00090D7C File Offset: 0x0008EF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78620, XrefRangeEnd = 78622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Ray GetRay(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_GetRay_Public_Virtual_Ray_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr3) : null;
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00090DD8 File Offset: 0x0008EFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78623, RefRangeEnd = 78624, XrefRangeStart = 78622, XrefRangeEnd = 78623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetPositionYAxisUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_GetPositionYAxisUp_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00090E24 File Offset: 0x0008F024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78624, XrefRangeEnd = 78625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasPointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_HasPointer_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00090E6C File Offset: 0x0008F06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78625, XrefRangeEnd = 78626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsButtonPressed(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_IsButtonPressed_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00090EC0 File Offset: 0x0008F0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78626, XrefRangeEnd = 78627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool WasButtonPressedInCurrentFrame(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00090F14 File Offset: 0x0008F114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78627, XrefRangeEnd = 78628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool WasButtonReleasedInCurrentFrame(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00090F68 File Offset: 0x0008F168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78628, XrefRangeEnd = 78634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool WasMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_WasMoved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00090FB0 File Offset: 0x0008F1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78634, XrefRangeEnd = 78636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpateFrameDeltas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseInputDevice.NativeMethodInfoPtr_UpateFrameDeltas_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0000C14F File Offset: 0x0000A34F
		public MouseInputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00090FEC File Offset: 0x0008F1EC
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x0000C158 File Offset: 0x0000A358
		public unsafe Vector3 _frameDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseInputDevice.NativeFieldInfoPtr__frameDelta);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseInputDevice.NativeFieldInfoPtr__frameDelta), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x0009101C File Offset: 0x0008F21C
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x0000C177 File Offset: 0x0000A377
		public unsafe Vector3 _mousePosInLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseInputDevice.NativeFieldInfoPtr__mousePosInLastFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseInputDevice.NativeFieldInfoPtr__mousePosInLastFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeFieldInfoPtr__frameDelta;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeFieldInfoPtr__mousePosInLastFrame;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceType_Public_Virtual_get_InputDeviceType_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeMethodInfoPtr_GetFrameDelta_Public_Virtual_Vector3_0;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeMethodInfoPtr_GetRay_Public_Virtual_Ray_Camera_0;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionYAxisUp_Public_Virtual_Vector3_0;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeMethodInfoPtr_HasPointer_Public_Virtual_Boolean_0;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeMethodInfoPtr_IsButtonPressed_Public_Virtual_Boolean_Int32_0;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Virtual_Boolean_Int32_0;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Virtual_Boolean_Int32_0;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeMethodInfoPtr_WasMoved_Public_Virtual_Boolean_0;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeMethodInfoPtr_UpateFrameDeltas_Protected_Virtual_Void_0;
	}
}
