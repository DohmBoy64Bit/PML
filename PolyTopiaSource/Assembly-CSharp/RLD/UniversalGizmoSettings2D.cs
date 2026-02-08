using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000EE RID: 238
	[Serializable]
	public class UniversalGizmoSettings2D : Settings
	{
		// Token: 0x06001750 RID: 5968 RVA: 0x0007BF80 File Offset: 0x0007A180
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalGizmoSettings2D()
		{
			Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "UniversalGizmoSettings2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr);
			UniversalGizmoSettings2D.NativeFieldInfoPtr__displayCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, "_displayCategory");
			UniversalGizmoSettings2D.NativeFieldInfoPtr__mvDblSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, "_mvDblSliderSettings");
			UniversalGizmoSettings2D.NativeFieldInfoPtr__mvSglSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, "_mvSglSliderSettings");
			UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvLineSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666723);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvBoxSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666724);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvXSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666725);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvYSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666726);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvDragSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666727);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666728);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666729);
			UniversalGizmoSettings2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666730);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvLineSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666731);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvBoxSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666732);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvXSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666733);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvYSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666734);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvDragSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666735);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_ConnectMvSliderSettings_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666736);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_ConnectMvDblSliderSettings_Public_Void_GizmoPlaneSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666737);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_Inherit_Public_Void_MoveGizmoSettings2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666738);
			UniversalGizmoSettings2D.NativeMethodInfoPtr_GetMvSliderSettings_Private_GizmoLineSlider2DSettings_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr, 100666739);
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x0007C140 File Offset: 0x0007A340
		public unsafe float MvLineSliderHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvLineSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x0007C17C File Offset: 0x0007A37C
		public unsafe float MvBoxSliderHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvBoxSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x0007C1B8 File Offset: 0x0007A3B8
		public unsafe float MvXSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70167, RefRangeEnd = 70168, XrefRangeStart = 70167, XrefRangeEnd = 70168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvXSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x0007C1F4 File Offset: 0x0007A3F4
		public unsafe float MvYSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvYSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x0007C230 File Offset: 0x0007A430
		public unsafe float MvDragSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_get_MvDragSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x0007C26C File Offset: 0x0007A46C
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x0007C2AC File Offset: 0x0007A4AC
		public unsafe UniversalGizmoSettingsCategory DisplayCategory
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsCategory>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0007C2F0 File Offset: 0x0007A4F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73510, RefRangeEnd = 73512, XrefRangeStart = 73489, XrefRangeEnd = 73510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalGizmoSettings2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGizmoSettings2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0007C32C File Offset: 0x0007A52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73512, XrefRangeEnd = 73514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvLineSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvLineSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0007C36C File Offset: 0x0007A56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73514, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvBoxSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvBoxSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0007C3AC File Offset: 0x0007A5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73516, XrefRangeEnd = 73521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvXSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvXSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0007C3EC File Offset: 0x0007A5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73521, XrefRangeEnd = 73526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvYSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvYSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0007C42C File Offset: 0x0007A62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73526, XrefRangeEnd = 73531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvDragSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_SetMvDragSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0007C46C File Offset: 0x0007A66C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 73535, RefRangeEnd = 73539, XrefRangeStart = 73531, XrefRangeEnd = 73535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMvSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_ConnectMvSliderSettings_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0007C4D0 File Offset: 0x0007A6D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73541, RefRangeEnd = 73542, XrefRangeStart = 73539, XrefRangeEnd = 73541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMvDblSliderSettings(GizmoPlaneSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_ConnectMvDblSliderSettings_Public_Void_GizmoPlaneSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0007C514 File Offset: 0x0007A714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73542, XrefRangeEnd = 73562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Inherit(MoveGizmoSettings2D settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_Inherit_Public_Void_MoveGizmoSettings2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0007C558 File Offset: 0x0007A758
		[CallerCount(0)]
		public unsafe GizmoLineSlider2DSettings GetMvSliderSettings(int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings2D.NativeMethodInfoPtr_GetMvSliderSettings_Private_GizmoLineSlider2DSettings_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DSettings>(intPtr3) : null;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0000A6D1 File Offset: 0x000088D1
		public UniversalGizmoSettings2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x0007C5B8 File Offset: 0x0007A7B8
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x0000A6DA File Offset: 0x000088DA
		public unsafe UniversalGizmoSettingsCategory _displayCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings2D.NativeFieldInfoPtr__displayCategory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings2D.NativeFieldInfoPtr__displayCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x0007C5E8 File Offset: 0x0007A7E8
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x0000A6F9 File Offset: 0x000088F9
		public unsafe GizmoPlaneSlider2DSettings _mvDblSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings2D.NativeFieldInfoPtr__mvDblSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings2D.NativeFieldInfoPtr__mvDblSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x0007C618 File Offset: 0x0007A818
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x0000A718 File Offset: 0x00008918
		public unsafe Il2CppReferenceArray<GizmoLineSlider2DSettings> _mvSglSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings2D.NativeFieldInfoPtr__mvSglSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider2DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings2D.NativeFieldInfoPtr__mvSglSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeFieldInfoPtr__displayCategory;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeFieldInfoPtr__mvDblSliderSettings;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr__mvSglSliderSettings;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_get_MvLineSliderHoverEps_Public_get_Single_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_get_MvBoxSliderHoverEps_Public_get_Single_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_get_MvXSnapStep_Public_get_Single_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_get_MvYSnapStep_Public_get_Single_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDragSensitivity_Public_get_Single_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_SetMvLineSliderHoverEps_Public_Void_Single_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_SetMvBoxSliderHoverEps_Public_Void_Single_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_SetMvXSnapStep_Public_Void_Single_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr_SetMvYSnapStep_Public_Void_Single_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDragSensitivity_Public_Void_Single_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMvSliderSettings_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMvDblSliderSettings_Public_Void_GizmoPlaneSlider2D_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_Inherit_Public_Void_MoveGizmoSettings2D_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_GetMvSliderSettings_Private_GizmoLineSlider2DSettings_Int32_AxisSign_0;
	}
}
