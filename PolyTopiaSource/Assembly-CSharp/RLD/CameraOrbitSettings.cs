using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x02000101 RID: 257
	[Serializable]
	public class CameraOrbitSettings : Settings
	{
		// Token: 0x060018B1 RID: 6321 RVA: 0x00081794 File Offset: 0x0007F994
		// Note: this type is marked as 'beforefieldinit'.
		static CameraOrbitSettings()
		{
			Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraOrbitSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr);
			CameraOrbitSettings.NativeFieldInfoPtr__orbitMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, "_orbitMode");
			CameraOrbitSettings.NativeFieldInfoPtr__standardOrbitSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, "_standardOrbitSensitivity");
			CameraOrbitSettings.NativeFieldInfoPtr__smoothOrbitSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, "_smoothOrbitSensitivity");
			CameraOrbitSettings.NativeFieldInfoPtr__smoothValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, "_smoothValue");
			CameraOrbitSettings.NativeFieldInfoPtr__invertX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, "_invertX");
			CameraOrbitSettings.NativeFieldInfoPtr__invertY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, "_invertY");
			CameraOrbitSettings.NativeFieldInfoPtr__isOrbitEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, "_isOrbitEnabled");
			CameraOrbitSettings.NativeMethodInfoPtr_get_OrbitMode_Public_get_CameraOrbitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666934);
			CameraOrbitSettings.NativeMethodInfoPtr_set_OrbitMode_Public_set_Void_CameraOrbitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666935);
			CameraOrbitSettings.NativeMethodInfoPtr_get_StandardOrbitSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666936);
			CameraOrbitSettings.NativeMethodInfoPtr_set_StandardOrbitSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666937);
			CameraOrbitSettings.NativeMethodInfoPtr_get_SmoothOrbitSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666938);
			CameraOrbitSettings.NativeMethodInfoPtr_set_SmoothOrbitSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666939);
			CameraOrbitSettings.NativeMethodInfoPtr_get_OrbitSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666940);
			CameraOrbitSettings.NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666941);
			CameraOrbitSettings.NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666942);
			CameraOrbitSettings.NativeMethodInfoPtr_get_InvertX_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666943);
			CameraOrbitSettings.NativeMethodInfoPtr_set_InvertX_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666944);
			CameraOrbitSettings.NativeMethodInfoPtr_get_InvertY_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666945);
			CameraOrbitSettings.NativeMethodInfoPtr_set_InvertY_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666946);
			CameraOrbitSettings.NativeMethodInfoPtr_get_IsOrbitEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666947);
			CameraOrbitSettings.NativeMethodInfoPtr_set_IsOrbitEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666948);
			CameraOrbitSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr, 100666949);
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00081990 File Offset: 0x0007FB90
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x000819D0 File Offset: 0x0007FBD0
		public unsafe CameraOrbitMode OrbitMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_get_OrbitMode_Public_get_CameraOrbitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraOrbitMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_set_OrbitMode_Public_set_Void_CameraOrbitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00081A14 File Offset: 0x0007FC14
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x00081A50 File Offset: 0x0007FC50
		public unsafe float StandardOrbitSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_get_StandardOrbitSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_set_StandardOrbitSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x00081A90 File Offset: 0x0007FC90
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x00081ACC File Offset: 0x0007FCCC
		public unsafe float SmoothOrbitSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_get_SmoothOrbitSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_set_SmoothOrbitSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00081B0C File Offset: 0x0007FD0C
		public unsafe float OrbitSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_get_OrbitSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x00081B48 File Offset: 0x0007FD48
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x00081B84 File Offset: 0x0007FD84
		public unsafe float SmoothValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x00081BC4 File Offset: 0x0007FDC4
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x00081C00 File Offset: 0x0007FE00
		public unsafe bool InvertX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_get_InvertX_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_set_InvertX_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x00081C40 File Offset: 0x0007FE40
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x00081C7C File Offset: 0x0007FE7C
		public unsafe bool InvertY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_get_InvertY_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_set_InvertY_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x00081CBC File Offset: 0x0007FEBC
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x00081CF8 File Offset: 0x0007FEF8
		public unsafe bool IsOrbitEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_get_IsOrbitEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr_set_IsOrbitEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00081D38 File Offset: 0x0007FF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74501, XrefRangeEnd = 74506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraOrbitSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOrbitSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbitSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0000AE54 File Offset: 0x00009054
		public CameraOrbitSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x00081D74 File Offset: 0x0007FF74
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0000AE5D File Offset: 0x0000905D
		public unsafe CameraOrbitMode _orbitMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__orbitMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraOrbitMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__orbitMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x00081DA4 File Offset: 0x0007FFA4
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0000AE7C File Offset: 0x0000907C
		public unsafe float _standardOrbitSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__standardOrbitSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__standardOrbitSensitivity)) = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x00081DCC File Offset: 0x0007FFCC
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0000AE97 File Offset: 0x00009097
		public unsafe float _smoothOrbitSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__smoothOrbitSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__smoothOrbitSensitivity)) = value;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00081DF4 File Offset: 0x0007FFF4
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x0000AEB2 File Offset: 0x000090B2
		public unsafe float _smoothValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__smoothValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__smoothValue)) = value;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x00081E1C File Offset: 0x0008001C
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x0000AECD File Offset: 0x000090CD
		public unsafe bool _invertX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__invertX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__invertX)) = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x00081E44 File Offset: 0x00080044
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x0000AEE8 File Offset: 0x000090E8
		public unsafe bool _invertY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__invertY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__invertY)) = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x00081E6C File Offset: 0x0008006C
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x0000AF03 File Offset: 0x00009103
		public unsafe bool _isOrbitEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__isOrbitEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbitSettings.NativeFieldInfoPtr__isOrbitEnabled)) = value;
			}
		}

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr__orbitMode;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr__standardOrbitSensitivity;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeFieldInfoPtr__smoothOrbitSensitivity;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr__smoothValue;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeFieldInfoPtr__invertX;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeFieldInfoPtr__invertY;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeFieldInfoPtr__isOrbitEnabled;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_get_OrbitMode_Public_get_CameraOrbitMode_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_set_OrbitMode_Public_set_Void_CameraOrbitMode_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_get_StandardOrbitSensitivity_Public_get_Single_0;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_set_StandardOrbitSensitivity_Public_set_Void_Single_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_get_SmoothOrbitSensitivity_Public_get_Single_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_set_SmoothOrbitSensitivity_Public_set_Void_Single_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_get_OrbitSensitivity_Public_get_Single_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertX_Public_get_Boolean_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertX_Public_set_Void_Boolean_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertY_Public_get_Boolean_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertY_Public_set_Void_Boolean_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOrbitEnabled_Public_get_Boolean_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOrbitEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
