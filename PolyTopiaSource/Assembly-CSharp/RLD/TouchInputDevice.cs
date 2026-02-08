using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200013D RID: 317
	public class TouchInputDevice : InputDeviceBase
	{
		// Token: 0x06001C97 RID: 7319 RVA: 0x00091248 File Offset: 0x0008F448
		// Note: this type is marked as 'beforefieldinit'.
		static TouchInputDevice()
		{
			Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TouchInputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr);
			TouchInputDevice.NativeFieldInfoPtr__maxNumberOfTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, "_maxNumberOfTouches");
			TouchInputDevice.NativeMethodInfoPtr_get_MaxNumberOfTouches_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667597);
			TouchInputDevice.NativeMethodInfoPtr_get_TouchCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667598);
			TouchInputDevice.NativeMethodInfoPtr_get_DeviceType_Public_Virtual_get_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667599);
			TouchInputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667600);
			TouchInputDevice.NativeMethodInfoPtr_GetFrameDelta_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667601);
			TouchInputDevice.NativeMethodInfoPtr_GetRay_Public_Virtual_Ray_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667602);
			TouchInputDevice.NativeMethodInfoPtr_GetPositionYAxisUp_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667603);
			TouchInputDevice.NativeMethodInfoPtr_HasPointer_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667604);
			TouchInputDevice.NativeMethodInfoPtr_IsButtonPressed_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667605);
			TouchInputDevice.NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667606);
			TouchInputDevice.NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667607);
			TouchInputDevice.NativeMethodInfoPtr_WasMoved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667608);
			TouchInputDevice.NativeMethodInfoPtr_UpateFrameDeltas_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100667609);
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x00091390 File Offset: 0x0008F590
		public unsafe int MaxNumberOfTouches
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 21737, RefRangeEnd = 21743, XrefRangeStart = 21737, XrefRangeEnd = 21743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputDevice.NativeMethodInfoPtr_get_MaxNumberOfTouches_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x000913CC File Offset: 0x0008F5CC
		public unsafe int TouchCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78665, XrefRangeEnd = 78666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputDevice.NativeMethodInfoPtr_get_TouchCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x00091408 File Offset: 0x0008F608
		public unsafe override InputDeviceType DeviceType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 20120, RefRangeEnd = 20124, XrefRangeStart = 20120, XrefRangeEnd = 20124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_get_DeviceType_Public_Virtual_get_InputDeviceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDeviceType>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00091454 File Offset: 0x0008F654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78666, XrefRangeEnd = 78671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchInputDevice(int maxNumberOfTouches)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxNumberOfTouches;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0009149C File Offset: 0x0008F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78671, XrefRangeEnd = 78674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetFrameDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_GetFrameDelta_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x000914E8 File Offset: 0x0008F6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78674, XrefRangeEnd = 78684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Ray GetRay(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_GetRay_Public_Virtual_Ray_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00091544 File Offset: 0x0008F744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78684, XrefRangeEnd = 78687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetPositionYAxisUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_GetPositionYAxisUp_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00091590 File Offset: 0x0008F790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78687, XrefRangeEnd = 78688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasPointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_HasPointer_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000915D8 File Offset: 0x0008F7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78688, XrefRangeEnd = 78689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsButtonPressed(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_IsButtonPressed_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0009162C File Offset: 0x0008F82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78689, XrefRangeEnd = 78692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool WasButtonPressedInCurrentFrame(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00091680 File Offset: 0x0008F880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78692, XrefRangeEnd = 78695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool WasButtonReleasedInCurrentFrame(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x000916D4 File Offset: 0x0008F8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78695, XrefRangeEnd = 78698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool WasMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_WasMoved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0009171C File Offset: 0x0008F91C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpateFrameDeltas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputDevice.NativeMethodInfoPtr_UpateFrameDeltas_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0000C1BE File Offset: 0x0000A3BE
		public TouchInputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00091758 File Offset: 0x0008F958
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0000C1C7 File Offset: 0x0000A3C7
		public unsafe int _maxNumberOfTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputDevice.NativeFieldInfoPtr__maxNumberOfTouches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputDevice.NativeFieldInfoPtr__maxNumberOfTouches)) = value;
			}
		}

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeFieldInfoPtr__maxNumberOfTouches;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxNumberOfTouches_Public_get_Int32_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr_get_TouchCount_Public_get_Int32_0;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceType_Public_Virtual_get_InputDeviceType_0;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeMethodInfoPtr_GetFrameDelta_Public_Virtual_Vector3_0;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeMethodInfoPtr_GetRay_Public_Virtual_Ray_Camera_0;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionYAxisUp_Public_Virtual_Vector3_0;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_HasPointer_Public_Virtual_Boolean_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_IsButtonPressed_Public_Virtual_Boolean_Int32_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_WasButtonPressedInCurrentFrame_Public_Virtual_Boolean_Int32_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_WasButtonReleasedInCurrentFrame_Public_Virtual_Boolean_Int32_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_WasMoved_Public_Virtual_Boolean_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr_UpateFrameDeltas_Protected_Virtual_Void_0;
	}
}
