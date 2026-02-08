using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x02000103 RID: 259
	[Serializable]
	public class CameraPanSettings : Settings
	{
		// Token: 0x060018D1 RID: 6353 RVA: 0x00081E94 File Offset: 0x00080094
		// Note: this type is marked as 'beforefieldinit'.
		static CameraPanSettings()
		{
			Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraPanSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr);
			CameraPanSettings.NativeFieldInfoPtr__panMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, "_panMode");
			CameraPanSettings.NativeFieldInfoPtr__standardPanSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, "_standardPanSensitivity");
			CameraPanSettings.NativeFieldInfoPtr__smoothPanSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, "_smoothPanSensitivity");
			CameraPanSettings.NativeFieldInfoPtr__smoothValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, "_smoothValue");
			CameraPanSettings.NativeFieldInfoPtr__invertX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, "_invertX");
			CameraPanSettings.NativeFieldInfoPtr__invertY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, "_invertY");
			CameraPanSettings.NativeFieldInfoPtr__isPanningEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, "_isPanningEnabled");
			CameraPanSettings.NativeMethodInfoPtr_get_PanMode_Public_get_CameraPanMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666950);
			CameraPanSettings.NativeMethodInfoPtr_set_PanMode_Public_set_Void_CameraPanMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666951);
			CameraPanSettings.NativeMethodInfoPtr_get_StandardPanSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666952);
			CameraPanSettings.NativeMethodInfoPtr_set_StandardPanSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666953);
			CameraPanSettings.NativeMethodInfoPtr_get_SmoothPanSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666954);
			CameraPanSettings.NativeMethodInfoPtr_set_SmoothPanSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666955);
			CameraPanSettings.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666956);
			CameraPanSettings.NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666957);
			CameraPanSettings.NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666958);
			CameraPanSettings.NativeMethodInfoPtr_get_InvertX_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666959);
			CameraPanSettings.NativeMethodInfoPtr_set_InvertX_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666960);
			CameraPanSettings.NativeMethodInfoPtr_get_InvertY_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666961);
			CameraPanSettings.NativeMethodInfoPtr_set_InvertY_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666962);
			CameraPanSettings.NativeMethodInfoPtr_get_IsPanningEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666963);
			CameraPanSettings.NativeMethodInfoPtr_set_IsPanningEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666964);
			CameraPanSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr, 100666965);
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00082090 File Offset: 0x00080290
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x000820D0 File Offset: 0x000802D0
		public unsafe CameraPanMode PanMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_get_PanMode_Public_get_CameraPanMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraPanMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_set_PanMode_Public_set_Void_CameraPanMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00082114 File Offset: 0x00080314
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x00082150 File Offset: 0x00080350
		public unsafe float StandardPanSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_get_StandardPanSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_set_StandardPanSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00082190 File Offset: 0x00080390
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x000821CC File Offset: 0x000803CC
		public unsafe float SmoothPanSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_get_SmoothPanSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_set_SmoothPanSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0008220C File Offset: 0x0008040C
		public unsafe float Sensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x00082248 File Offset: 0x00080448
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x00082284 File Offset: 0x00080484
		public unsafe float SmoothValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x000822C4 File Offset: 0x000804C4
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x00082300 File Offset: 0x00080500
		public unsafe bool InvertX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_get_InvertX_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_set_InvertX_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x00082340 File Offset: 0x00080540
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x0008237C File Offset: 0x0008057C
		public unsafe bool InvertY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_get_InvertY_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_set_InvertY_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x000823BC File Offset: 0x000805BC
		// (set) Token: 0x060018E0 RID: 6368 RVA: 0x000823F8 File Offset: 0x000805F8
		public unsafe bool IsPanningEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_get_IsPanningEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr_set_IsPanningEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00082438 File Offset: 0x00080638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74506, XrefRangeEnd = 74511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraPanSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraPanSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPanSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0000AF1E File Offset: 0x0000911E
		public CameraPanSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00082474 File Offset: 0x00080674
		// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0000AF27 File Offset: 0x00009127
		public unsafe CameraPanMode _panMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__panMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraPanMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__panMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x000824A4 File Offset: 0x000806A4
		// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0000AF46 File Offset: 0x00009146
		public unsafe float _standardPanSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__standardPanSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__standardPanSensitivity)) = value;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x000824CC File Offset: 0x000806CC
		// (set) Token: 0x060018E8 RID: 6376 RVA: 0x0000AF61 File Offset: 0x00009161
		public unsafe float _smoothPanSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__smoothPanSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__smoothPanSensitivity)) = value;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x000824F4 File Offset: 0x000806F4
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0000AF7C File Offset: 0x0000917C
		public unsafe float _smoothValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__smoothValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__smoothValue)) = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0008251C File Offset: 0x0008071C
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x0000AF97 File Offset: 0x00009197
		public unsafe bool _invertX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__invertX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__invertX)) = value;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00082544 File Offset: 0x00080744
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x0000AFB2 File Offset: 0x000091B2
		public unsafe bool _invertY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__invertY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__invertY)) = value;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x0008256C File Offset: 0x0008076C
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0000AFCD File Offset: 0x000091CD
		public unsafe bool _isPanningEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__isPanningEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPanSettings.NativeFieldInfoPtr__isPanningEnabled)) = value;
			}
		}

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeFieldInfoPtr__panMode;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeFieldInfoPtr__standardPanSensitivity;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr__smoothPanSensitivity;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr__smoothValue;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeFieldInfoPtr__invertX;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeFieldInfoPtr__invertY;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeFieldInfoPtr__isPanningEnabled;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_get_PanMode_Public_get_CameraPanMode_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_set_PanMode_Public_set_Void_CameraPanMode_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_get_StandardPanSensitivity_Public_get_Single_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_set_StandardPanSensitivity_Public_set_Void_Single_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_get_SmoothPanSensitivity_Public_get_Single_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_set_SmoothPanSensitivity_Public_set_Void_Single_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_get_SmoothValue_Public_get_Single_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_set_SmoothValue_Public_set_Void_Single_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertX_Public_get_Boolean_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertX_Public_set_Void_Boolean_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertY_Public_get_Boolean_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertY_Public_set_Void_Boolean_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPanningEnabled_Public_get_Boolean_0;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPanningEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
