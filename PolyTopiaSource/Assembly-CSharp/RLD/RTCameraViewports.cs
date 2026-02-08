using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000111 RID: 273
	public class RTCameraViewports : Singleton<RTCameraViewports>
	{
		// Token: 0x060019C5 RID: 6597 RVA: 0x000854D8 File Offset: 0x000836D8
		// Note: this type is marked as 'beforefieldinit'.
		static RTCameraViewports()
		{
			Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTCameraViewports");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr);
			RTCameraViewports.NativeFieldInfoPtr_CameraAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, "CameraAdded");
			RTCameraViewports.NativeFieldInfoPtr_CameraRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, "CameraRemoved");
			RTCameraViewports.NativeFieldInfoPtr_FocusCameraChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, "FocusCameraChanged");
			RTCameraViewports.NativeFieldInfoPtr__cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, "_cameras");
			RTCameraViewports.NativeMethodInfoPtr_get_FocusCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667084);
			RTCameraViewports.NativeMethodInfoPtr_get_NumCameras_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667085);
			RTCameraViewports.NativeMethodInfoPtr_add_CameraAdded_Public_add_Void_CameraAddedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667078);
			RTCameraViewports.NativeMethodInfoPtr_remove_CameraAdded_Public_rem_Void_CameraAddedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667079);
			RTCameraViewports.NativeMethodInfoPtr_add_CameraRemoved_Public_add_Void_CameraRemovedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667080);
			RTCameraViewports.NativeMethodInfoPtr_remove_CameraRemoved_Public_rem_Void_CameraRemovedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667081);
			RTCameraViewports.NativeMethodInfoPtr_add_FocusCameraChanged_Public_add_Void_FocusCameraChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667082);
			RTCameraViewports.NativeMethodInfoPtr_remove_FocusCameraChanged_Public_rem_Void_FocusCameraChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667083);
			RTCameraViewports.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667092);
			RTCameraViewports.NativeMethodInfoPtr_ContainsCamera_Public_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667086);
			RTCameraViewports.NativeMethodInfoPtr_AddCamera_Public_Void_Camera_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667087);
			RTCameraViewports.NativeMethodInfoPtr_AddCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667088);
			RTCameraViewports.NativeMethodInfoPtr_RemoveCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667089);
			RTCameraViewports.NativeMethodInfoPtr_SetFocusCamera_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667090);
			RTCameraViewports.NativeMethodInfoPtr_SetFocusCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, 100667091);
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00085684 File Offset: 0x00083884
		public unsafe Camera FocusCamera
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 74945, RefRangeEnd = 74949, XrefRangeStart = 74939, XrefRangeEnd = 74945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_get_FocusCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x000856C4 File Offset: 0x000838C4
		public unsafe int NumCameras
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74949, XrefRangeEnd = 74950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_get_NumCameras_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00085700 File Offset: 0x00083900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74950, XrefRangeEnd = 74954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CameraAdded(RTCameraViewports.CameraAddedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_add_CameraAdded_Public_add_Void_CameraAddedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00085744 File Offset: 0x00083944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74954, XrefRangeEnd = 74958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CameraAdded(RTCameraViewports.CameraAddedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_remove_CameraAdded_Public_rem_Void_CameraAddedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00085788 File Offset: 0x00083988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74958, XrefRangeEnd = 74962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CameraRemoved(RTCameraViewports.CameraRemovedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_add_CameraRemoved_Public_add_Void_CameraRemovedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x000857CC File Offset: 0x000839CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74962, XrefRangeEnd = 74966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CameraRemoved(RTCameraViewports.CameraRemovedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_remove_CameraRemoved_Public_rem_Void_CameraRemovedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00085810 File Offset: 0x00083A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74966, XrefRangeEnd = 74970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_FocusCameraChanged(RTCameraViewports.FocusCameraChangedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_add_FocusCameraChanged_Public_add_Void_FocusCameraChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00085854 File Offset: 0x00083A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74970, XrefRangeEnd = 74974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_FocusCameraChanged(RTCameraViewports.FocusCameraChangedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_remove_FocusCameraChanged_Public_rem_Void_FocusCameraChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00085898 File Offset: 0x00083A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74974, XrefRangeEnd = 74987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTCameraViewports()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000858D4 File Offset: 0x00083AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74987, XrefRangeEnd = 74991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_ContainsCamera_Public_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00085924 File Offset: 0x00083B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74991, XrefRangeEnd = 75002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCamera(Camera camera, Rect normViewRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normViewRect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_AddCamera_Public_Void_Camera_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00085978 File Offset: 0x00083B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75002, XrefRangeEnd = 75012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_AddCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x000859BC File Offset: 0x00083BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75012, XrefRangeEnd = 75019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_RemoveCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00085A00 File Offset: 0x00083C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75019, XrefRangeEnd = 75045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFocusCamera(int cameraIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cameraIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_SetFocusCamera_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00085A40 File Offset: 0x00083C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75045, XrefRangeEnd = 75067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFocusCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.NativeMethodInfoPtr_SetFocusCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0000B4FD File Offset: 0x000096FD
		public RTCameraViewports(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00085A84 File Offset: 0x00083C84
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0000B506 File Offset: 0x00009706
		public unsafe RTCameraViewports.CameraAddedHandler CameraAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraViewports.NativeFieldInfoPtr_CameraAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTCameraViewports.CameraAddedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraViewports.NativeFieldInfoPtr_CameraAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00085AB4 File Offset: 0x00083CB4
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x0000B525 File Offset: 0x00009725
		public unsafe RTCameraViewports.CameraRemovedHandler CameraRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraViewports.NativeFieldInfoPtr_CameraRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTCameraViewports.CameraRemovedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraViewports.NativeFieldInfoPtr_CameraRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00085AE4 File Offset: 0x00083CE4
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x0000B544 File Offset: 0x00009744
		public unsafe RTCameraViewports.FocusCameraChangedHandler FocusCameraChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraViewports.NativeFieldInfoPtr_FocusCameraChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTCameraViewports.FocusCameraChangedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraViewports.NativeFieldInfoPtr_FocusCameraChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x00085B14 File Offset: 0x00083D14
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x0000B563 File Offset: 0x00009763
		public unsafe List<Camera> _cameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraViewports.NativeFieldInfoPtr__cameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraViewports.NativeFieldInfoPtr__cameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr_CameraAdded;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_CameraRemoved;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeFieldInfoPtr_FocusCameraChanged;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeFieldInfoPtr__cameras;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusCamera_Public_get_Camera_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_get_NumCameras_Public_get_Int32_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_add_CameraAdded_Public_add_Void_CameraAddedHandler_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_remove_CameraAdded_Public_rem_Void_CameraAddedHandler_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_add_CameraRemoved_Public_add_Void_CameraRemovedHandler_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_remove_CameraRemoved_Public_rem_Void_CameraRemovedHandler_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_add_FocusCameraChanged_Public_add_Void_FocusCameraChangedHandler_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_remove_FocusCameraChanged_Public_rem_Void_FocusCameraChangedHandler_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_ContainsCamera_Public_Boolean_Camera_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_AddCamera_Public_Void_Camera_Rect_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_AddCamera_Public_Void_Camera_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCamera_Public_Void_Camera_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_SetFocusCamera_Public_Void_Int32_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_SetFocusCamera_Public_Void_Camera_0;

		// Token: 0x0200037E RID: 894
		public sealed class CameraAddedHandler : MulticastDelegate
		{
			// Token: 0x06004A4D RID: 19021 RVA: 0x0014736C File Offset: 0x0014556C
			// Note: this type is marked as 'beforefieldinit'.
			static CameraAddedHandler()
			{
				Il2CppClassPointerStore<RTCameraViewports.CameraAddedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, "CameraAddedHandler");
				RTCameraViewports.CameraAddedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.CameraAddedHandler>.NativeClassPtr, 100667093);
				RTCameraViewports.CameraAddedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.CameraAddedHandler>.NativeClassPtr, 100667094);
				RTCameraViewports.CameraAddedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.CameraAddedHandler>.NativeClassPtr, 100667095);
				RTCameraViewports.CameraAddedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.CameraAddedHandler>.NativeClassPtr, 100667096);
			}

			// Token: 0x06004A4E RID: 19022 RVA: 0x001473E0 File Offset: 0x001455E0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 51910, RefRangeEnd = 51916, XrefRangeStart = 51910, XrefRangeEnd = 51916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraAddedHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCameraViewports.CameraAddedHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.CameraAddedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A4F RID: 19023 RVA: 0x0014743C File Offset: 0x0014563C
			[CallerCount(0)]
			public unsafe void Invoke(Camera camera)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.CameraAddedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A50 RID: 19024 RVA: 0x00147480 File Offset: 0x00145680
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Camera camera, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.CameraAddedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004A51 RID: 19025 RVA: 0x001474F4 File Offset: 0x001456F4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.CameraAddedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A52 RID: 19026 RVA: 0x0001BB16 File Offset: 0x00019D16
			public CameraAddedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004A53 RID: 19027 RVA: 0x0001BB1F File Offset: 0x00019D1F
			public static implicit operator RTCameraViewports.CameraAddedHandler(Action<Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<RTCameraViewports.CameraAddedHandler>(A_0);
			}

			// Token: 0x06004A54 RID: 19028 RVA: 0x0001BB27 File Offset: 0x00019D27
			public static RTCameraViewports.CameraAddedHandler operator +(RTCameraViewports.CameraAddedHandler A_0, RTCameraViewports.CameraAddedHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RTCameraViewports.CameraAddedHandler>();
			}

			// Token: 0x06004A55 RID: 19029 RVA: 0x0001BB35 File Offset: 0x00019D35
			public static RTCameraViewports.CameraAddedHandler operator -(RTCameraViewports.CameraAddedHandler A_0, RTCameraViewports.CameraAddedHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RTCameraViewports.CameraAddedHandler>();
				}
				return delegate2;
			}

			// Token: 0x040039C8 RID: 14792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040039C9 RID: 14793
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;

			// Token: 0x040039CA RID: 14794
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0;

			// Token: 0x040039CB RID: 14795
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200037F RID: 895
		public sealed class CameraRemovedHandler : MulticastDelegate
		{
			// Token: 0x06004A56 RID: 19030 RVA: 0x00147538 File Offset: 0x00145738
			// Note: this type is marked as 'beforefieldinit'.
			static CameraRemovedHandler()
			{
				Il2CppClassPointerStore<RTCameraViewports.CameraRemovedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, "CameraRemovedHandler");
				RTCameraViewports.CameraRemovedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.CameraRemovedHandler>.NativeClassPtr, 100667097);
				RTCameraViewports.CameraRemovedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.CameraRemovedHandler>.NativeClassPtr, 100667098);
				RTCameraViewports.CameraRemovedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.CameraRemovedHandler>.NativeClassPtr, 100667099);
				RTCameraViewports.CameraRemovedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.CameraRemovedHandler>.NativeClassPtr, 100667100);
			}

			// Token: 0x06004A57 RID: 19031 RVA: 0x001475AC File Offset: 0x001457AC
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 51910, RefRangeEnd = 51916, XrefRangeStart = 51910, XrefRangeEnd = 51916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraRemovedHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCameraViewports.CameraRemovedHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.CameraRemovedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A58 RID: 19032 RVA: 0x00147608 File Offset: 0x00145808
			[CallerCount(0)]
			public unsafe void Invoke(Camera camera)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.CameraRemovedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A59 RID: 19033 RVA: 0x0014764C File Offset: 0x0014584C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Camera camera, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.CameraRemovedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004A5A RID: 19034 RVA: 0x001476C0 File Offset: 0x001458C0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.CameraRemovedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A5B RID: 19035 RVA: 0x0001BB46 File Offset: 0x00019D46
			public CameraRemovedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004A5C RID: 19036 RVA: 0x0001BB4F File Offset: 0x00019D4F
			public static implicit operator RTCameraViewports.CameraRemovedHandler(Action<Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<RTCameraViewports.CameraRemovedHandler>(A_0);
			}

			// Token: 0x06004A5D RID: 19037 RVA: 0x0001BB57 File Offset: 0x00019D57
			public static RTCameraViewports.CameraRemovedHandler operator +(RTCameraViewports.CameraRemovedHandler A_0, RTCameraViewports.CameraRemovedHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RTCameraViewports.CameraRemovedHandler>();
			}

			// Token: 0x06004A5E RID: 19038 RVA: 0x0001BB65 File Offset: 0x00019D65
			public static RTCameraViewports.CameraRemovedHandler operator -(RTCameraViewports.CameraRemovedHandler A_0, RTCameraViewports.CameraRemovedHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RTCameraViewports.CameraRemovedHandler>();
				}
				return delegate2;
			}

			// Token: 0x040039CC RID: 14796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040039CD RID: 14797
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;

			// Token: 0x040039CE RID: 14798
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0;

			// Token: 0x040039CF RID: 14799
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000380 RID: 896
		public sealed class FocusCameraChangedHandler : MulticastDelegate
		{
			// Token: 0x06004A5F RID: 19039 RVA: 0x00147704 File Offset: 0x00145904
			// Note: this type is marked as 'beforefieldinit'.
			static FocusCameraChangedHandler()
			{
				Il2CppClassPointerStore<RTCameraViewports.FocusCameraChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTCameraViewports>.NativeClassPtr, "FocusCameraChangedHandler");
				RTCameraViewports.FocusCameraChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.FocusCameraChangedHandler>.NativeClassPtr, 100667101);
				RTCameraViewports.FocusCameraChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.FocusCameraChangedHandler>.NativeClassPtr, 100667102);
				RTCameraViewports.FocusCameraChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_Camera_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.FocusCameraChangedHandler>.NativeClassPtr, 100667103);
				RTCameraViewports.FocusCameraChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraViewports.FocusCameraChangedHandler>.NativeClassPtr, 100667104);
			}

			// Token: 0x06004A60 RID: 19040 RVA: 0x00147778 File Offset: 0x00145978
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 74936, RefRangeEnd = 74939, XrefRangeStart = 74932, XrefRangeEnd = 74936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FocusCameraChangedHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCameraViewports.FocusCameraChangedHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.FocusCameraChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A61 RID: 19041 RVA: 0x001477D4 File Offset: 0x001459D4
			[CallerCount(0)]
			public unsafe void Invoke(Camera oldFocusCam, Camera newFocusCam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldFocusCam);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newFocusCam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.FocusCameraChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A62 RID: 19042 RVA: 0x00147828 File Offset: 0x00145A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Camera oldFocusCam, Camera newFocusCam, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldFocusCam);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newFocusCam);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.FocusCameraChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_Camera_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004A63 RID: 19043 RVA: 0x001478B0 File Offset: 0x00145AB0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraViewports.FocusCameraChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A64 RID: 19044 RVA: 0x0001BB76 File Offset: 0x00019D76
			public FocusCameraChangedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004A65 RID: 19045 RVA: 0x0001BB7F File Offset: 0x00019D7F
			public static implicit operator RTCameraViewports.FocusCameraChangedHandler(Action<Camera, Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<RTCameraViewports.FocusCameraChangedHandler>(A_0);
			}

			// Token: 0x06004A66 RID: 19046 RVA: 0x0001BB87 File Offset: 0x00019D87
			public static RTCameraViewports.FocusCameraChangedHandler operator +(RTCameraViewports.FocusCameraChangedHandler A_0, RTCameraViewports.FocusCameraChangedHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RTCameraViewports.FocusCameraChangedHandler>();
			}

			// Token: 0x06004A67 RID: 19047 RVA: 0x0001BB95 File Offset: 0x00019D95
			public static RTCameraViewports.FocusCameraChangedHandler operator -(RTCameraViewports.FocusCameraChangedHandler A_0, RTCameraViewports.FocusCameraChangedHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RTCameraViewports.FocusCameraChangedHandler>();
				}
				return delegate2;
			}

			// Token: 0x040039D0 RID: 14800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040039D1 RID: 14801
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_Camera_0;

			// Token: 0x040039D2 RID: 14802
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_Camera_AsyncCallback_Object_0;

			// Token: 0x040039D3 RID: 14803
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
