using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000110 RID: 272
	public class RTCameraBackground : MonoSingleton<RTCameraBackground>
	{
		// Token: 0x060019B5 RID: 6581 RVA: 0x00085110 File Offset: 0x00083310
		// Note: this type is marked as 'beforefieldinit'.
		static RTCameraBackground()
		{
			Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTCameraBackground");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr);
			RTCameraBackground.NativeFieldInfoPtr__bkSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, "_bkSettings");
			RTCameraBackground.NativeFieldInfoPtr__renderIgnoreCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, "_renderIgnoreCameras");
			RTCameraBackground.NativeFieldInfoPtr__cameraToBkSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, "_cameraToBkSettings");
			RTCameraBackground.NativeMethodInfoPtr_get_Settings_Public_get_CameraBackgroundSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, 100667070);
			RTCameraBackground.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, 100667077);
			RTCameraBackground.NativeMethodInfoPtr_SetCameraBkSettings_Public_Void_Camera_CameraBackgroundSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, 100667071);
			RTCameraBackground.NativeMethodInfoPtr_GetAllRenderIgnoreCameras_Public_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, 100667072);
			RTCameraBackground.NativeMethodInfoPtr_IsRenderIgnoreCamera_Public_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, 100667073);
			RTCameraBackground.NativeMethodInfoPtr_AddRenderIgnoreCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, 100667074);
			RTCameraBackground.NativeMethodInfoPtr_RemoveRenderIgnoreCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, 100667075);
			RTCameraBackground.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr, 100667076);
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0008521C File Offset: 0x0008341C
		public unsafe CameraBackgroundSettings Settings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraBackground.NativeMethodInfoPtr_get_Settings_Public_get_CameraBackgroundSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraBackgroundSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0008525C File Offset: 0x0008345C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74815, XrefRangeEnd = 74846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTCameraBackground()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCameraBackground>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraBackground.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00085298 File Offset: 0x00083498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74846, XrefRangeEnd = 74861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraBkSettings(Camera camera, CameraBackgroundSettings bkSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bkSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraBackground.NativeMethodInfoPtr_SetCameraBkSettings_Public_Void_Camera_CameraBackgroundSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x000852EC File Offset: 0x000834EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74861, XrefRangeEnd = 74867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Camera> GetAllRenderIgnoreCameras()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraBackground.NativeMethodInfoPtr_GetAllRenderIgnoreCameras_Public_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr3) : null;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0008532C File Offset: 0x0008352C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74867, XrefRangeEnd = 74871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraBackground.NativeMethodInfoPtr_IsRenderIgnoreCamera_Public_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0008537C File Offset: 0x0008357C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74877, RefRangeEnd = 74878, XrefRangeStart = 74871, XrefRangeEnd = 74877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraBackground.NativeMethodInfoPtr_AddRenderIgnoreCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000853C0 File Offset: 0x000835C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74878, XrefRangeEnd = 74882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraBackground.NativeMethodInfoPtr_RemoveRenderIgnoreCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00085404 File Offset: 0x00083604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74931, RefRangeEnd = 74932, XrefRangeStart = 74882, XrefRangeEnd = 74931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render_SystemCall(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTCameraBackground.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0000B497 File Offset: 0x00009697
		public RTCameraBackground(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x00085448 File Offset: 0x00083648
		// (set) Token: 0x060019C0 RID: 6592 RVA: 0x0000B4A0 File Offset: 0x000096A0
		public unsafe CameraBackgroundSettings _bkSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraBackground.NativeFieldInfoPtr__bkSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraBackgroundSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraBackground.NativeFieldInfoPtr__bkSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x00085478 File Offset: 0x00083678
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x0000B4BF File Offset: 0x000096BF
		public unsafe List<Camera> _renderIgnoreCameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraBackground.NativeFieldInfoPtr__renderIgnoreCameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraBackground.NativeFieldInfoPtr__renderIgnoreCameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x000854A8 File Offset: 0x000836A8
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x0000B4DE File Offset: 0x000096DE
		public unsafe Dictionary<Camera, CameraBackgroundSettings> _cameraToBkSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraBackground.NativeFieldInfoPtr__cameraToBkSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Camera, CameraBackgroundSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTCameraBackground.NativeFieldInfoPtr__cameraToBkSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeFieldInfoPtr__bkSettings;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeFieldInfoPtr__renderIgnoreCameras;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeFieldInfoPtr__cameraToBkSettings;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_CameraBackgroundSettings_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraBkSettings_Public_Void_Camera_CameraBackgroundSettings_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRenderIgnoreCameras_Public_List_1_Camera_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderIgnoreCamera_Public_Boolean_Camera_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderIgnoreCamera_Public_Void_Camera_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRenderIgnoreCamera_Public_Void_Camera_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0;
	}
}
