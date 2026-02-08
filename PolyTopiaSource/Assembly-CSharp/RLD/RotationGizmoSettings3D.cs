using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000E5 RID: 229
	[Serializable]
	public class RotationGizmoSettings3D : Settings
	{
		// Token: 0x060013EF RID: 5103 RVA: 0x0006D084 File Offset: 0x0006B284
		// Note: this type is marked as 'beforefieldinit'.
		static RotationGizmoSettings3D()
		{
			Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RotationGizmoSettings3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr);
			RotationGizmoSettings3D.NativeFieldInfoPtr__camRightSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, "_camRightSnapStep");
			RotationGizmoSettings3D.NativeFieldInfoPtr__camUpSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, "_camUpSnapStep");
			RotationGizmoSettings3D.NativeFieldInfoPtr__sliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, "_sliderSettings");
			RotationGizmoSettings3D.NativeFieldInfoPtr__camLookSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, "_camLookSliderSettings");
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_AxisLineHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666114);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_AxisTorusHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666115);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamLookLineHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666116);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamLookThickHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666117);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_CanHoverCulledPixels_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666118);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_SnapMode_Public_get_GizmoSnapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666119);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666120);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666121);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666122);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamRightSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666123);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamUpSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666124);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamLookSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666125);
			RotationGizmoSettings3D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666126);
			RotationGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666127);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetCanHoverCulledPixels_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666128);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetAxisLineHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666129);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetAxisTorusHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666130);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamLookLineHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666131);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamLookThickHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666132);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetAxisSnapStep_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666133);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamRightSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666134);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamUpSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666135);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamLookSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666136);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetSnapMode_Public_Void_GizmoSnapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666137);
			RotationGizmoSettings3D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666138);
			RotationGizmoSettings3D.NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoPlaneSlider3D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666139);
			RotationGizmoSettings3D.NativeMethodInfoPtr_ConnectCamLookSliderSettings_Public_Void_GizmoPlaneSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr, 100666140);
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0006D320 File Offset: 0x0006B520
		public unsafe float AxisLineHoverEps
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 70033, RefRangeEnd = 70037, XrefRangeStart = 70033, XrefRangeEnd = 70037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_AxisLineHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0006D35C File Offset: 0x0006B55C
		public unsafe float AxisTorusHoverEps
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70037, RefRangeEnd = 70039, XrefRangeStart = 70037, XrefRangeEnd = 70039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_AxisTorusHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0006D398 File Offset: 0x0006B598
		public unsafe float CamLookLineHoverEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71480, RefRangeEnd = 71481, XrefRangeStart = 71480, XrefRangeEnd = 71480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamLookLineHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0006D3D4 File Offset: 0x0006B5D4
		public unsafe float CamLookThickHoverEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71481, RefRangeEnd = 71482, XrefRangeStart = 71481, XrefRangeEnd = 71481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamLookThickHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0006D410 File Offset: 0x0006B610
		public unsafe bool CanHoverCulledPixels
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71482, RefRangeEnd = 71483, XrefRangeStart = 71482, XrefRangeEnd = 71482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_CanHoverCulledPixels_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0006D44C File Offset: 0x0006B64C
		public unsafe GizmoSnapMode SnapMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 71483, RefRangeEnd = 71485, XrefRangeStart = 71483, XrefRangeEnd = 71483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_SnapMode_Public_get_GizmoSnapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoSnapMode>(intPtr3) : null;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0006D48C File Offset: 0x0006B68C
		public unsafe float XSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71485, RefRangeEnd = 71486, XrefRangeStart = 71485, XrefRangeEnd = 71485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0006D4C8 File Offset: 0x0006B6C8
		public unsafe float YSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71486, RefRangeEnd = 71487, XrefRangeStart = 71486, XrefRangeEnd = 71486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0006D504 File Offset: 0x0006B704
		public unsafe float ZSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71487, RefRangeEnd = 71488, XrefRangeStart = 71487, XrefRangeEnd = 71487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0006D540 File Offset: 0x0006B740
		public unsafe float CamRightSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamRightSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0006D57C File Offset: 0x0006B77C
		public unsafe float CamUpSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamUpSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0006D5B8 File Offset: 0x0006B7B8
		public unsafe float CamLookSnapStep
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70204, RefRangeEnd = 70206, XrefRangeStart = 70204, XrefRangeEnd = 70206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_CamLookSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0006D5F4 File Offset: 0x0006B7F4
		public unsafe float DragSensitivity
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 71488, RefRangeEnd = 71490, XrefRangeStart = 71488, XrefRangeEnd = 71488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0006D630 File Offset: 0x0006B830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71511, RefRangeEnd = 71513, XrefRangeStart = 71490, XrefRangeEnd = 71511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotationGizmoSettings3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotationGizmoSettings3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0006D66C File Offset: 0x0006B86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71513, XrefRangeEnd = 71514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanHoverCulledPixels(bool canHover)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canHover;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetCanHoverCulledPixels_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0006D6AC File Offset: 0x0006B8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisLineHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetAxisLineHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0006D6EC File Offset: 0x0006B8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisTorusHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetAxisTorusHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0006D72C File Offset: 0x0006B92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71514, XrefRangeEnd = 71516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCamLookLineHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamLookLineHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0006D76C File Offset: 0x0006B96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71516, XrefRangeEnd = 71518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCamLookThickHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamLookThickHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0006D7AC File Offset: 0x0006B9AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 71521, RefRangeEnd = 71527, XrefRangeStart = 71518, XrefRangeEnd = 71521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisSnapStep(int axisIndex, float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapStep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetAxisSnapStep_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0006D7F8 File Offset: 0x0006B9F8
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65070, XrefRangeStart = 65039, XrefRangeEnd = 65070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCamRightSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamRightSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0006D838 File Offset: 0x0006BA38
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 65070, RefRangeEnd = 65083, XrefRangeStart = 65070, XrefRangeEnd = 65083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCamUpSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamUpSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0006D878 File Offset: 0x0006BA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71527, XrefRangeEnd = 71529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCamLookSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetCamLookSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0006D8B8 File Offset: 0x0006BAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71529, XrefRangeEnd = 71530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSnapMode(GizmoSnapMode snapMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(snapMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetSnapMode_Public_Void_GizmoSnapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0006D8FC File Offset: 0x0006BAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71530, XrefRangeEnd = 71535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0006D93C File Offset: 0x0006BB3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 71538, RefRangeEnd = 71541, XrefRangeStart = 71535, XrefRangeEnd = 71538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectSliderSettings(GizmoPlaneSlider3D slider, int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoPlaneSlider3D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0006D98C File Offset: 0x0006BB8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71543, RefRangeEnd = 71544, XrefRangeStart = 71541, XrefRangeEnd = 71543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectCamLookSliderSettings(GizmoPlaneSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmoSettings3D.NativeMethodInfoPtr_ConnectCamLookSliderSettings_Public_Void_GizmoPlaneSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0000985B File Offset: 0x00007A5B
		public RotationGizmoSettings3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0006D9D0 File Offset: 0x0006BBD0
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x00009864 File Offset: 0x00007A64
		public unsafe float _camRightSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoSettings3D.NativeFieldInfoPtr__camRightSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoSettings3D.NativeFieldInfoPtr__camRightSnapStep)) = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0006D9F8 File Offset: 0x0006BBF8
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x0000987F File Offset: 0x00007A7F
		public unsafe float _camUpSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoSettings3D.NativeFieldInfoPtr__camUpSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoSettings3D.NativeFieldInfoPtr__camUpSnapStep)) = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0006DA20 File Offset: 0x0006BC20
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x0000989A File Offset: 0x00007A9A
		public unsafe Il2CppReferenceArray<GizmoPlaneSlider3DSettings> _sliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoSettings3D.NativeFieldInfoPtr__sliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoPlaneSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoSettings3D.NativeFieldInfoPtr__sliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0006DA50 File Offset: 0x0006BC50
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x000098B9 File Offset: 0x00007AB9
		public unsafe GizmoPlaneSlider2DSettings _camLookSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoSettings3D.NativeFieldInfoPtr__camLookSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmoSettings3D.NativeFieldInfoPtr__camLookSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeFieldInfoPtr__camRightSnapStep;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeFieldInfoPtr__camUpSnapStep;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeFieldInfoPtr__sliderSettings;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeFieldInfoPtr__camLookSliderSettings;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisLineHoverEps_Public_get_Single_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisTorusHoverEps_Public_get_Single_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_get_CamLookLineHoverEps_Public_get_Single_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_get_CamLookThickHoverEps_Public_get_Single_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_get_CanHoverCulledPixels_Public_get_Boolean_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_get_SnapMode_Public_get_GizmoSnapMode_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_get_CamRightSnapStep_Public_get_Single_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_get_CamUpSnapStep_Public_get_Single_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_get_CamLookSnapStep_Public_get_Single_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_SetCanHoverCulledPixels_Public_Void_Boolean_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisLineHoverEps_Public_Void_Single_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisTorusHoverEps_Public_Void_Single_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_SetCamLookLineHoverEps_Public_Void_Single_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_SetCamLookThickHoverEps_Public_Void_Single_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisSnapStep_Public_Void_Int32_Single_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_SetCamRightSnapStep_Public_Void_Single_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_SetCamUpSnapStep_Public_Void_Single_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_SetCamLookSnapStep_Public_Void_Single_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapMode_Public_Void_GizmoSnapMode_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoPlaneSlider3D_Int32_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_ConnectCamLookSliderSettings_Public_Void_GizmoPlaneSlider2D_0;
	}
}
