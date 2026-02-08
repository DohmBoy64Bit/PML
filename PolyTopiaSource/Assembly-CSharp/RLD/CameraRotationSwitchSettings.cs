using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x0200010B RID: 267
	[Serializable]
	public class CameraRotationSwitchSettings : Settings
	{
		// Token: 0x06001947 RID: 6471 RVA: 0x000837B4 File Offset: 0x000819B4
		// Note: this type is marked as 'beforefieldinit'.
		static CameraRotationSwitchSettings()
		{
			Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraRotationSwitchSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr);
			CameraRotationSwitchSettings.NativeFieldInfoPtr__minConstantDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, "_minConstantDuration");
			CameraRotationSwitchSettings.NativeFieldInfoPtr__switchMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, "_switchMode");
			CameraRotationSwitchSettings.NativeFieldInfoPtr__constantSwitchDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, "_constantSwitchDurationInSeconds");
			CameraRotationSwitchSettings.NativeFieldInfoPtr__smoothValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, "_smoothValue");
			CameraRotationSwitchSettings.NativeMethodInfoPtr_get_SwitchMode_Public_get_CameraRotationSwitchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, 100667011);
			CameraRotationSwitchSettings.NativeMethodInfoPtr_set_SwitchMode_Public_set_Void_CameraRotationSwitchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, 100667012);
			CameraRotationSwitchSettings.NativeMethodInfoPtr_get_ConstantSwitchDurationInSeconds_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, 100667013);
			CameraRotationSwitchSettings.NativeMethodInfoPtr_set_ConstantSwitchDurationInSeconds_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, 100667014);
			CameraRotationSwitchSettings.NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, 100667015);
			CameraRotationSwitchSettings.NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, 100667016);
			CameraRotationSwitchSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr, 100667017);
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x000838C0 File Offset: 0x00081AC0
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x00083900 File Offset: 0x00081B00
		public unsafe CameraRotationSwitchMode SwitchMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRotationSwitchSettings.NativeMethodInfoPtr_get_SwitchMode_Public_get_CameraRotationSwitchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraRotationSwitchMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRotationSwitchSettings.NativeMethodInfoPtr_set_SwitchMode_Public_set_Void_CameraRotationSwitchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x00083944 File Offset: 0x00081B44
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x00083980 File Offset: 0x00081B80
		public unsafe float ConstantSwitchDurationInSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRotationSwitchSettings.NativeMethodInfoPtr_get_ConstantSwitchDurationInSeconds_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74629, XrefRangeEnd = 74633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRotationSwitchSettings.NativeMethodInfoPtr_set_ConstantSwitchDurationInSeconds_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x000839C0 File Offset: 0x00081BC0
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x000839FC File Offset: 0x00081BFC
		public unsafe float SmoothValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRotationSwitchSettings.NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRotationSwitchSettings.NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00083A3C File Offset: 0x00081C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74633, XrefRangeEnd = 74638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraRotationSwitchSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraRotationSwitchSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRotationSwitchSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0000B228 File Offset: 0x00009428
		public CameraRotationSwitchSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x00083A78 File Offset: 0x00081C78
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x0000B231 File Offset: 0x00009431
		public unsafe static float _minConstantDuration
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(CameraRotationSwitchSettings.NativeFieldInfoPtr__minConstantDuration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraRotationSwitchSettings.NativeFieldInfoPtr__minConstantDuration, (void*)(&value));
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x00083A94 File Offset: 0x00081C94
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x0000B23F File Offset: 0x0000943F
		public unsafe CameraRotationSwitchMode _switchMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRotationSwitchSettings.NativeFieldInfoPtr__switchMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraRotationSwitchMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRotationSwitchSettings.NativeFieldInfoPtr__switchMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x00083AC4 File Offset: 0x00081CC4
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x0000B25E File Offset: 0x0000945E
		public unsafe float _constantSwitchDurationInSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRotationSwitchSettings.NativeFieldInfoPtr__constantSwitchDurationInSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRotationSwitchSettings.NativeFieldInfoPtr__constantSwitchDurationInSeconds)) = value;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00083AEC File Offset: 0x00081CEC
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x0000B279 File Offset: 0x00009479
		public unsafe float _smoothValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRotationSwitchSettings.NativeFieldInfoPtr__smoothValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraRotationSwitchSettings.NativeFieldInfoPtr__smoothValue)) = value;
			}
		}

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeFieldInfoPtr__minConstantDuration;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeFieldInfoPtr__switchMode;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeFieldInfoPtr__constantSwitchDurationInSeconds;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeFieldInfoPtr__smoothValue;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchMode_Public_get_CameraRotationSwitchMode_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_set_SwitchMode_Public_set_Void_CameraRotationSwitchMode_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstantSwitchDurationInSeconds_Public_get_Single_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_set_ConstantSwitchDurationInSeconds_Public_set_Void_Single_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
