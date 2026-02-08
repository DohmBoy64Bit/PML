using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x02000109 RID: 265
	[Serializable]
	public class CameraProjectionSwitchSettings : Settings
	{
		// Token: 0x0600193C RID: 6460 RVA: 0x00083564 File Offset: 0x00081764
		// Note: this type is marked as 'beforefieldinit'.
		static CameraProjectionSwitchSettings()
		{
			Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraProjectionSwitchSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr);
			CameraProjectionSwitchSettings.NativeFieldInfoPtr__switchMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr, "_switchMode");
			CameraProjectionSwitchSettings.NativeFieldInfoPtr__transitionDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr, "_transitionDurationInSeconds");
			CameraProjectionSwitchSettings.NativeMethodInfoPtr_get_SwitchMode_Public_get_CameraProjectionSwitchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr, 100667006);
			CameraProjectionSwitchSettings.NativeMethodInfoPtr_set_SwitchMode_Public_set_Void_CameraProjectionSwitchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr, 100667007);
			CameraProjectionSwitchSettings.NativeMethodInfoPtr_get_TransitionDurationInSeconds_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr, 100667008);
			CameraProjectionSwitchSettings.NativeMethodInfoPtr_set_TransitionDurationInSeconds_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr, 100667009);
			CameraProjectionSwitchSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr, 100667010);
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00083620 File Offset: 0x00081820
		// (set) Token: 0x0600193E RID: 6462 RVA: 0x00083660 File Offset: 0x00081860
		public unsafe CameraProjectionSwitchMode SwitchMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchSettings.NativeMethodInfoPtr_get_SwitchMode_Public_get_CameraProjectionSwitchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchSettings.NativeMethodInfoPtr_set_SwitchMode_Public_set_Void_CameraProjectionSwitchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x000836A4 File Offset: 0x000818A4
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x000836E0 File Offset: 0x000818E0
		public unsafe float TransitionDurationInSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchSettings.NativeMethodInfoPtr_get_TransitionDurationInSeconds_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchSettings.NativeMethodInfoPtr_set_TransitionDurationInSeconds_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00083720 File Offset: 0x00081920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74624, XrefRangeEnd = 74629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraProjectionSwitchSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraProjectionSwitchSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProjectionSwitchSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0000B1E5 File Offset: 0x000093E5
		public CameraProjectionSwitchSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x0008375C File Offset: 0x0008195C
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x0000B1EE File Offset: 0x000093EE
		public unsafe CameraProjectionSwitchMode _switchMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraProjectionSwitchSettings.NativeFieldInfoPtr__switchMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraProjectionSwitchSettings.NativeFieldInfoPtr__switchMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x0008378C File Offset: 0x0008198C
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x0000B20D File Offset: 0x0000940D
		public unsafe float _transitionDurationInSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraProjectionSwitchSettings.NativeFieldInfoPtr__transitionDurationInSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraProjectionSwitchSettings.NativeFieldInfoPtr__transitionDurationInSeconds)) = value;
			}
		}

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeFieldInfoPtr__switchMode;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr__transitionDurationInSeconds;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchMode_Public_get_CameraProjectionSwitchMode_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_set_SwitchMode_Public_set_Void_CameraProjectionSwitchMode_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_get_TransitionDurationInSeconds_Public_get_Single_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_set_TransitionDurationInSeconds_Public_set_Void_Single_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
