using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200010F RID: 271
	[Serializable]
	public class CameraZoomSettings : Settings
	{
		// Token: 0x0600198C RID: 6540 RVA: 0x000847D8 File Offset: 0x000829D8
		// Note: this type is marked as 'beforefieldinit'.
		static CameraZoomSettings()
		{
			Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraZoomSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr);
			CameraZoomSettings.NativeFieldInfoPtr__zoomMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, "_zoomMode");
			CameraZoomSettings.NativeFieldInfoPtr__orthoStandardZoomSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, "_orthoStandardZoomSensitivity");
			CameraZoomSettings.NativeFieldInfoPtr__perspStandardZoomSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, "_perspStandardZoomSensitivity");
			CameraZoomSettings.NativeFieldInfoPtr__orthoSmoothZoomSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, "_orthoSmoothZoomSensitivity");
			CameraZoomSettings.NativeFieldInfoPtr__perspSmoothZoomSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, "_perspSmoothZoomSensitivity");
			CameraZoomSettings.NativeFieldInfoPtr__orthoZoomSmoothValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, "_orthoZoomSmoothValue");
			CameraZoomSettings.NativeFieldInfoPtr__perspZoomSmoothValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, "_perspZoomSmoothValue");
			CameraZoomSettings.NativeFieldInfoPtr__invertZoomAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, "_invertZoomAxis");
			CameraZoomSettings.NativeFieldInfoPtr__isZoomEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, "_isZoomEnabled");
			CameraZoomSettings.NativeMethodInfoPtr_get_ZoomMode_Public_get_CameraZoomMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667049);
			CameraZoomSettings.NativeMethodInfoPtr_set_ZoomMode_Public_set_Void_CameraZoomMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667050);
			CameraZoomSettings.NativeMethodInfoPtr_get_OrthoStandardZoomSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667051);
			CameraZoomSettings.NativeMethodInfoPtr_set_OrthoStandardZoomSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667052);
			CameraZoomSettings.NativeMethodInfoPtr_get_PerspStandardZoomSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667053);
			CameraZoomSettings.NativeMethodInfoPtr_set_PerspStandardZoomSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667054);
			CameraZoomSettings.NativeMethodInfoPtr_get_OrthoSmoothZoomSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667055);
			CameraZoomSettings.NativeMethodInfoPtr_set_OrthoSmoothZoomSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667056);
			CameraZoomSettings.NativeMethodInfoPtr_get_PerspSmoothZoomSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667057);
			CameraZoomSettings.NativeMethodInfoPtr_set_PerspSmoothZoomSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667058);
			CameraZoomSettings.NativeMethodInfoPtr_get_OrthoZoomSmoothValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667059);
			CameraZoomSettings.NativeMethodInfoPtr_set_OrthoZoomSmoothValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667060);
			CameraZoomSettings.NativeMethodInfoPtr_get_PerspZoomSmoothValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667061);
			CameraZoomSettings.NativeMethodInfoPtr_set_PerspZoomSmoothValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667062);
			CameraZoomSettings.NativeMethodInfoPtr_get_InvertZoomAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667063);
			CameraZoomSettings.NativeMethodInfoPtr_set_InvertZoomAxis_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667064);
			CameraZoomSettings.NativeMethodInfoPtr_get_IsZoomEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667065);
			CameraZoomSettings.NativeMethodInfoPtr_set_IsZoomEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667066);
			CameraZoomSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667069);
			CameraZoomSettings.NativeMethodInfoPtr_GetZoomSmoothValue_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667067);
			CameraZoomSettings.NativeMethodInfoPtr_GetZoomSensitivity_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr, 100667068);
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00084A60 File Offset: 0x00082C60
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x00084AA0 File Offset: 0x00082CA0
		public unsafe CameraZoomMode ZoomMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_get_ZoomMode_Public_get_CameraZoomMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraZoomMode>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_set_ZoomMode_Public_set_Void_CameraZoomMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x00084AE4 File Offset: 0x00082CE4
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x00084B20 File Offset: 0x00082D20
		public unsafe float OrthoStandardZoomSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_get_OrthoStandardZoomSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_set_OrthoStandardZoomSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00084B60 File Offset: 0x00082D60
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x00084B9C File Offset: 0x00082D9C
		public unsafe float PerspStandardZoomSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_get_PerspStandardZoomSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_set_PerspStandardZoomSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x00084BDC File Offset: 0x00082DDC
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x00084C18 File Offset: 0x00082E18
		public unsafe float OrthoSmoothZoomSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_get_OrthoSmoothZoomSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_set_OrthoSmoothZoomSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x00084C58 File Offset: 0x00082E58
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x00084C94 File Offset: 0x00082E94
		public unsafe float PerspSmoothZoomSensitivity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57816, RefRangeEnd = 57817, XrefRangeStart = 57816, XrefRangeEnd = 57817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_get_PerspSmoothZoomSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_set_PerspSmoothZoomSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x00084CD4 File Offset: 0x00082ED4
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x00084D10 File Offset: 0x00082F10
		public unsafe float OrthoZoomSmoothValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57831, RefRangeEnd = 57832, XrefRangeStart = 57831, XrefRangeEnd = 57832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_get_OrthoZoomSmoothValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_set_OrthoZoomSmoothValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x00084D50 File Offset: 0x00082F50
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x00084D8C File Offset: 0x00082F8C
		public unsafe float PerspZoomSmoothValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57846, RefRangeEnd = 57847, XrefRangeStart = 57846, XrefRangeEnd = 57847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_get_PerspZoomSmoothValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_set_PerspZoomSmoothValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x00084DCC File Offset: 0x00082FCC
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x00084E08 File Offset: 0x00083008
		public unsafe bool InvertZoomAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_get_InvertZoomAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_set_InvertZoomAxis_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x00084E48 File Offset: 0x00083048
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x00084E84 File Offset: 0x00083084
		public unsafe bool IsZoomEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_get_IsZoomEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_set_IsZoomEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00084EC4 File Offset: 0x000830C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74809, XrefRangeEnd = 74814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraZoomSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraZoomSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00084F00 File Offset: 0x00083100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74814, XrefRangeEnd = 74815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomSmoothValue(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_GetZoomSmoothValue_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00084F50 File Offset: 0x00083150
		[CallerCount(0)]
		public unsafe float GetZoomSensitivity(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraZoomSettings.NativeMethodInfoPtr_GetZoomSensitivity_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0000B397 File Offset: 0x00009597
		public CameraZoomSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x00084FA0 File Offset: 0x000831A0
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x0000B3A0 File Offset: 0x000095A0
		public unsafe CameraZoomMode _zoomMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__zoomMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraZoomMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__zoomMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x00084FD0 File Offset: 0x000831D0
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x0000B3BF File Offset: 0x000095BF
		public unsafe float _orthoStandardZoomSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__orthoStandardZoomSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__orthoStandardZoomSensitivity)) = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x00084FF8 File Offset: 0x000831F8
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x0000B3DA File Offset: 0x000095DA
		public unsafe float _perspStandardZoomSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__perspStandardZoomSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__perspStandardZoomSensitivity)) = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x00085020 File Offset: 0x00083220
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x0000B3F5 File Offset: 0x000095F5
		public unsafe float _orthoSmoothZoomSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__orthoSmoothZoomSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__orthoSmoothZoomSensitivity)) = value;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x00085048 File Offset: 0x00083248
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x0000B410 File Offset: 0x00009610
		public unsafe float _perspSmoothZoomSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__perspSmoothZoomSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__perspSmoothZoomSensitivity)) = value;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x00085070 File Offset: 0x00083270
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x0000B42B File Offset: 0x0000962B
		public unsafe float _orthoZoomSmoothValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__orthoZoomSmoothValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__orthoZoomSmoothValue)) = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x00085098 File Offset: 0x00083298
		// (set) Token: 0x060019B0 RID: 6576 RVA: 0x0000B446 File Offset: 0x00009646
		public unsafe float _perspZoomSmoothValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__perspZoomSmoothValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__perspZoomSmoothValue)) = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x000850C0 File Offset: 0x000832C0
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x0000B461 File Offset: 0x00009661
		public unsafe bool _invertZoomAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__invertZoomAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__invertZoomAxis)) = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x000850E8 File Offset: 0x000832E8
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x0000B47C File Offset: 0x0000967C
		public unsafe bool _isZoomEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__isZoomEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraZoomSettings.NativeFieldInfoPtr__isZoomEnabled)) = value;
			}
		}

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeFieldInfoPtr__zoomMode;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr__orthoStandardZoomSensitivity;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeFieldInfoPtr__perspStandardZoomSensitivity;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr__orthoSmoothZoomSensitivity;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeFieldInfoPtr__perspSmoothZoomSensitivity;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeFieldInfoPtr__orthoZoomSmoothValue;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeFieldInfoPtr__perspZoomSmoothValue;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeFieldInfoPtr__invertZoomAxis;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeFieldInfoPtr__isZoomEnabled;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoomMode_Public_get_CameraZoomMode_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_set_ZoomMode_Public_set_Void_CameraZoomMode_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_get_OrthoStandardZoomSensitivity_Public_get_Single_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_set_OrthoStandardZoomSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_get_PerspStandardZoomSensitivity_Public_get_Single_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_set_PerspStandardZoomSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_get_OrthoSmoothZoomSensitivity_Public_get_Single_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_set_OrthoSmoothZoomSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_get_PerspSmoothZoomSensitivity_Public_get_Single_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_set_PerspSmoothZoomSensitivity_Public_set_Void_Single_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_get_OrthoZoomSmoothValue_Public_get_Single_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_set_OrthoZoomSmoothValue_Public_set_Void_Single_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_get_PerspZoomSmoothValue_Public_get_Single_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_set_PerspZoomSmoothValue_Public_set_Void_Single_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertZoomAxis_Public_get_Boolean_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertZoomAxis_Public_set_Void_Boolean_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_get_IsZoomEnabled_Public_get_Boolean_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_set_IsZoomEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomSmoothValue_Public_Single_Camera_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomSensitivity_Public_Single_Camera_0;
	}
}
