using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	public class CameraLookAroundSettings : Settings
	{
		// Token: 0x06001880 RID: 6272 RVA: 0x00080D44 File Offset: 0x0007EF44
		// Note: this type is marked as 'beforefieldinit'.
		static CameraLookAroundSettings()
		{
			Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraLookAroundSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr);
			CameraLookAroundSettings.NativeFieldInfoPtr__lookAroundMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, "_lookAroundMode");
			CameraLookAroundSettings.NativeFieldInfoPtr__standardLookAroundSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, "_standardLookAroundSensitivity");
			CameraLookAroundSettings.NativeFieldInfoPtr__smoothLookAroundSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, "_smoothLookAroundSensitivity");
			CameraLookAroundSettings.NativeFieldInfoPtr_smoothValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, "smoothValue");
			CameraLookAroundSettings.NativeFieldInfoPtr__invertX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, "_invertX");
			CameraLookAroundSettings.NativeFieldInfoPtr__invertY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, "_invertY");
			CameraLookAroundSettings.NativeFieldInfoPtr__isLookAroundEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, "_isLookAroundEnabled");
			CameraLookAroundSettings.NativeMethodInfoPtr_get_LookAroundMode_Public_get_CameraLookAroundMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666910);
			CameraLookAroundSettings.NativeMethodInfoPtr_set_LookAroundMode_Public_set_Void_CameraLookAroundMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666911);
			CameraLookAroundSettings.NativeMethodInfoPtr_get_StandardLookAroundSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666912);
			CameraLookAroundSettings.NativeMethodInfoPtr_set_StandardLookAroundSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666913);
			CameraLookAroundSettings.NativeMethodInfoPtr_get_SmoothLookAroundSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666914);
			CameraLookAroundSettings.NativeMethodInfoPtr_set_SmoothLookAroundSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666915);
			CameraLookAroundSettings.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666916);
			CameraLookAroundSettings.NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666917);
			CameraLookAroundSettings.NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666918);
			CameraLookAroundSettings.NativeMethodInfoPtr_get_InvertX_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666919);
			CameraLookAroundSettings.NativeMethodInfoPtr_set_InvertX_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666920);
			CameraLookAroundSettings.NativeMethodInfoPtr_get_InvertY_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666921);
			CameraLookAroundSettings.NativeMethodInfoPtr_set_InvertY_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666922);
			CameraLookAroundSettings.NativeMethodInfoPtr_get_IsLookAroundEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666923);
			CameraLookAroundSettings.NativeMethodInfoPtr_set_IsLookAroundEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666924);
			CameraLookAroundSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr, 100666925);
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x00080F40 File Offset: 0x0007F140
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x00080F80 File Offset: 0x0007F180
		public unsafe CameraLookAroundMode LookAroundMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_get_LookAroundMode_Public_get_CameraLookAroundMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraLookAroundMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_set_LookAroundMode_Public_set_Void_CameraLookAroundMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x00080FC4 File Offset: 0x0007F1C4
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x00081000 File Offset: 0x0007F200
		public unsafe float StandardLookAroundSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_get_StandardLookAroundSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_set_StandardLookAroundSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00081040 File Offset: 0x0007F240
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x0008107C File Offset: 0x0007F27C
		public unsafe float SmoothLookAroundSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_get_SmoothLookAroundSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_set_SmoothLookAroundSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x000810BC File Offset: 0x0007F2BC
		public unsafe float Sensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000810F8 File Offset: 0x0007F2F8
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x00081134 File Offset: 0x0007F334
		public unsafe float SmoothValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00081174 File Offset: 0x0007F374
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x000811B0 File Offset: 0x0007F3B0
		public unsafe bool InvertX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_get_InvertX_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_set_InvertX_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x000811F0 File Offset: 0x0007F3F0
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0008122C File Offset: 0x0007F42C
		public unsafe bool InvertY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_get_InvertY_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_set_InvertY_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x0008126C File Offset: 0x0007F46C
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x000812A8 File Offset: 0x0007F4A8
		public unsafe bool IsLookAroundEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_get_IsLookAroundEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr_set_IsLookAroundEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x000812E8 File Offset: 0x0007F4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74483, XrefRangeEnd = 74488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraLookAroundSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraLookAroundSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraLookAroundSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0000AD22 File Offset: 0x00008F22
		public CameraLookAroundSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00081324 File Offset: 0x0007F524
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x0000AD2B File Offset: 0x00008F2B
		public unsafe CameraLookAroundMode _lookAroundMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__lookAroundMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraLookAroundMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__lookAroundMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x00081354 File Offset: 0x0007F554
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x0000AD4A File Offset: 0x00008F4A
		public unsafe float _standardLookAroundSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__standardLookAroundSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__standardLookAroundSensitivity)) = value;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0008137C File Offset: 0x0007F57C
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x0000AD65 File Offset: 0x00008F65
		public unsafe float _smoothLookAroundSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__smoothLookAroundSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__smoothLookAroundSensitivity)) = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x000813A4 File Offset: 0x0007F5A4
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0000AD80 File Offset: 0x00008F80
		public unsafe float smoothValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr_smoothValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr_smoothValue)) = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x000813CC File Offset: 0x0007F5CC
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x0000AD9B File Offset: 0x00008F9B
		public unsafe bool _invertX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__invertX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__invertX)) = value;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x000813F4 File Offset: 0x0007F5F4
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0000ADB6 File Offset: 0x00008FB6
		public unsafe bool _invertY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__invertY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__invertY)) = value;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x0008141C File Offset: 0x0007F61C
		// (set) Token: 0x0600189F RID: 6303 RVA: 0x0000ADD1 File Offset: 0x00008FD1
		public unsafe bool _isLookAroundEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__isLookAroundEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraLookAroundSettings.NativeFieldInfoPtr__isLookAroundEnabled)) = value;
			}
		}

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr__lookAroundMode;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr__standardLookAroundSensitivity;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr__smoothLookAroundSensitivity;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_smoothValue;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr__invertX;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr__invertY;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr__isLookAroundEnabled;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAroundMode_Public_get_CameraLookAroundMode_0;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeMethodInfoPtr_set_LookAroundMode_Public_set_Void_CameraLookAroundMode_0;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeMethodInfoPtr_get_StandardLookAroundSensitivity_Public_get_Single_0;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeMethodInfoPtr_set_StandardLookAroundSensitivity_Public_set_Void_Single_0;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeMethodInfoPtr_get_SmoothLookAroundSensitivity_Public_get_Single_0;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeMethodInfoPtr_set_SmoothLookAroundSensitivity_Public_set_Void_Single_0;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertX_Public_get_Boolean_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertX_Public_set_Void_Boolean_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertY_Public_get_Boolean_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertY_Public_set_Void_Boolean_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLookAroundEnabled_Public_get_Boolean_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLookAroundEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
