using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x0200013C RID: 316
	public class RTInputDevice : MonoSingleton<RTInputDevice>
	{
		// Token: 0x06001C8E RID: 7310 RVA: 0x0009104C File Offset: 0x0008F24C
		// Note: this type is marked as 'beforefieldinit'.
		static RTInputDevice()
		{
			Il2CppClassPointerStore<RTInputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTInputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTInputDevice>.NativeClassPtr);
			RTInputDevice.NativeFieldInfoPtr__inputDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTInputDevice>.NativeClassPtr, "_inputDevice");
			RTInputDevice.NativeMethodInfoPtr_get_Device_Public_get_IInputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTInputDevice>.NativeClassPtr, 100667592);
			RTInputDevice.NativeMethodInfoPtr_get_DeviceType_Public_get_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTInputDevice>.NativeClassPtr, 100667593);
			RTInputDevice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTInputDevice>.NativeClassPtr, 100667596);
			RTInputDevice.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTInputDevice>.NativeClassPtr, 100667594);
			RTInputDevice.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTInputDevice>.NativeClassPtr, 100667595);
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x000910F4 File Offset: 0x0008F2F4
		public unsafe IInputDevice Device
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTInputDevice.NativeMethodInfoPtr_get_Device_Public_get_IInputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IInputDevice>(intPtr3) : null;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00091134 File Offset: 0x0008F334
		public unsafe InputDeviceType DeviceType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78640, RefRangeEnd = 78642, XrefRangeStart = 78636, XrefRangeEnd = 78640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTInputDevice.NativeMethodInfoPtr_get_DeviceType_Public_get_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDeviceType>(intPtr3) : null;
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00091174 File Offset: 0x0008F374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78642, XrefRangeEnd = 78648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTInputDevice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTInputDevice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTInputDevice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x000911B0 File Offset: 0x0008F3B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78652, RefRangeEnd = 78653, XrefRangeStart = 78648, XrefRangeEnd = 78652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTInputDevice.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000911E4 File Offset: 0x0008F3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78653, XrefRangeEnd = 78665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTInputDevice.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0000C196 File Offset: 0x0000A396
		public RTInputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00091218 File Offset: 0x0008F418
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x0000C19F File Offset: 0x0000A39F
		public unsafe IInputDevice _inputDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTInputDevice.NativeFieldInfoPtr__inputDevice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IInputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTInputDevice.NativeFieldInfoPtr__inputDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeFieldInfoPtr__inputDevice;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_get_Device_Public_get_IInputDevice_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceType_Public_get_InputDeviceType_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr_Update_SystemCall_Public_Void_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
	}
}
