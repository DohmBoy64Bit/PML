using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000DE RID: 222
	[Serializable]
	public class MoveGizmoSettings2D : Settings
	{
		// Token: 0x060012C3 RID: 4803 RVA: 0x0006824C File Offset: 0x0006644C
		// Note: this type is marked as 'beforefieldinit'.
		static MoveGizmoSettings2D()
		{
			Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MoveGizmoSettings2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr);
			MoveGizmoSettings2D.NativeFieldInfoPtr__dblSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, "_dblSliderSettings");
			MoveGizmoSettings2D.NativeFieldInfoPtr__sglSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, "_sglSliderSettings");
			MoveGizmoSettings2D.NativeMethodInfoPtr_get_LineSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665911);
			MoveGizmoSettings2D.NativeMethodInfoPtr_get_BoxSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665912);
			MoveGizmoSettings2D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665913);
			MoveGizmoSettings2D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665914);
			MoveGizmoSettings2D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665915);
			MoveGizmoSettings2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665916);
			MoveGizmoSettings2D.NativeMethodInfoPtr_SetLineSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665917);
			MoveGizmoSettings2D.NativeMethodInfoPtr_SetBoxSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665918);
			MoveGizmoSettings2D.NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665919);
			MoveGizmoSettings2D.NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665920);
			MoveGizmoSettings2D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665921);
			MoveGizmoSettings2D.NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665922);
			MoveGizmoSettings2D.NativeMethodInfoPtr_ConnectDblSliderSettings_Public_Void_GizmoPlaneSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665923);
			MoveGizmoSettings2D.NativeMethodInfoPtr_GetSliderSettings_Private_GizmoLineSlider2DSettings_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr, 100665924);
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x000683BC File Offset: 0x000665BC
		public unsafe float LineSliderHoverEps
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70425, RefRangeEnd = 70428, XrefRangeStart = 70425, XrefRangeEnd = 70425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_get_LineSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x000683F8 File Offset: 0x000665F8
		public unsafe float BoxSliderHoverEps
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70428, RefRangeEnd = 70431, XrefRangeStart = 70428, XrefRangeEnd = 70428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_get_BoxSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00068434 File Offset: 0x00066634
		public unsafe float XSnapStep
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70044, RefRangeEnd = 70046, XrefRangeStart = 70044, XrefRangeEnd = 70046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00068470 File Offset: 0x00066670
		public unsafe float YSnapStep
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70046, RefRangeEnd = 70048, XrefRangeStart = 70046, XrefRangeEnd = 70048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x000684AC File Offset: 0x000666AC
		public unsafe float DragSensitivity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70431, RefRangeEnd = 70432, XrefRangeStart = 70431, XrefRangeEnd = 70431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x000684E8 File Offset: 0x000666E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70449, RefRangeEnd = 70450, XrefRangeStart = 70432, XrefRangeEnd = 70449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveGizmoSettings2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveGizmoSettings2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00068524 File Offset: 0x00066724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70450, XrefRangeEnd = 70452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLineSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_SetLineSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00068564 File Offset: 0x00066764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70452, XrefRangeEnd = 70454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_SetBoxSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000685A4 File Offset: 0x000667A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70454, XrefRangeEnd = 70459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetXSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x000685E4 File Offset: 0x000667E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70459, XrefRangeEnd = 70464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetYSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00068624 File Offset: 0x00066824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70464, XrefRangeEnd = 70469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00068664 File Offset: 0x00066864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70469, XrefRangeEnd = 70473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000686C8 File Offset: 0x000668C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70473, XrefRangeEnd = 70475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectDblSliderSettings(GizmoPlaneSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_ConnectDblSliderSettings_Public_Void_GizmoPlaneSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0006870C File Offset: 0x0006690C
		[CallerCount(0)]
		public unsafe GizmoLineSlider2DSettings GetSliderSettings(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings2D.NativeMethodInfoPtr_GetSliderSettings_Private_GizmoLineSlider2DSettings_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DSettings>(intPtr3) : null;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00009293 File Offset: 0x00007493
		public MoveGizmoSettings2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0006876C File Offset: 0x0006696C
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x0000929C File Offset: 0x0000749C
		public unsafe GizmoPlaneSlider2DSettings _dblSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings2D.NativeFieldInfoPtr__dblSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings2D.NativeFieldInfoPtr__dblSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0006879C File Offset: 0x0006699C
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x000092BB File Offset: 0x000074BB
		public unsafe Il2CppReferenceArray<GizmoLineSlider2DSettings> _sglSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings2D.NativeFieldInfoPtr__sglSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider2DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings2D.NativeFieldInfoPtr__sglSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeFieldInfoPtr__dblSliderSettings;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderSettings;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_get_LineSliderHoverEps_Public_get_Single_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxSliderHoverEps_Public_get_Single_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_SetLineSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoLineSlider2D_Int32_AxisSign_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_ConnectDblSliderSettings_Public_Void_GizmoPlaneSlider2D_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_GetSliderSettings_Private_GizmoLineSlider2DSettings_Int32_AxisSign_0;
	}
}
