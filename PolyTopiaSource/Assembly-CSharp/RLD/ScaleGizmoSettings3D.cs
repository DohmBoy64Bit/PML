using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000E9 RID: 233
	[Serializable]
	public class ScaleGizmoSettings3D : Settings
	{
		// Token: 0x060014E4 RID: 5348 RVA: 0x0007117C File Offset: 0x0006F37C
		// Note: this type is marked as 'beforefieldinit'.
		static ScaleGizmoSettings3D()
		{
			Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ScaleGizmoSettings3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr);
			ScaleGizmoSettings3D.NativeFieldInfoPtr__uniformSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, "_uniformSnapStep");
			ScaleGizmoSettings3D.NativeFieldInfoPtr__sglSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, "_sglSliderSettings");
			ScaleGizmoSettings3D.NativeFieldInfoPtr__dblSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, "_dblSliderSettings");
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_LineSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666275);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_BoxSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666276);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_CylinderSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666277);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666278);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666279);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666280);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_XYSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666281);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_YZSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666282);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_ZXSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666283);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_UniformSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666284);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666285);
			ScaleGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666286);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetLineSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666287);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetBoxSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666288);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetCylinderSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666289);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666290);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666291);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetZSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666292);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetXYSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666293);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetYZSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666294);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetZXSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666295);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetUniformScaleSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666296);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666297);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666298);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_ConnectDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666299);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_GetSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666300);
			ScaleGizmoSettings3D.NativeMethodInfoPtr_GetDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr, 100666301);
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00071404 File Offset: 0x0006F604
		public unsafe float LineSliderHoverEps
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70425, RefRangeEnd = 70428, XrefRangeStart = 70425, XrefRangeEnd = 70428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_LineSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00071440 File Offset: 0x0006F640
		public unsafe float BoxSliderHoverEps
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70428, RefRangeEnd = 70431, XrefRangeStart = 70428, XrefRangeEnd = 70431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_BoxSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0007147C File Offset: 0x0006F67C
		public unsafe float CylinderSliderHoverEps
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 70033, RefRangeEnd = 70037, XrefRangeStart = 70033, XrefRangeEnd = 70037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_CylinderSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x000714B8 File Offset: 0x0006F6B8
		public unsafe float XSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72007, RefRangeEnd = 72008, XrefRangeStart = 72007, XrefRangeEnd = 72007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x000714F4 File Offset: 0x0006F6F4
		public unsafe float YSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72008, RefRangeEnd = 72009, XrefRangeStart = 72008, XrefRangeEnd = 72008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x00071530 File Offset: 0x0006F730
		public unsafe float ZSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72009, RefRangeEnd = 72010, XrefRangeStart = 72009, XrefRangeEnd = 72009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x0007156C File Offset: 0x0006F76C
		public unsafe float XYSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72010, RefRangeEnd = 72011, XrefRangeStart = 72010, XrefRangeEnd = 72010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_XYSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x000715A8 File Offset: 0x0006F7A8
		public unsafe float YZSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72011, RefRangeEnd = 72012, XrefRangeStart = 72011, XrefRangeEnd = 72011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_YZSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x000715E4 File Offset: 0x0006F7E4
		public unsafe float ZXSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72012, RefRangeEnd = 72013, XrefRangeStart = 72012, XrefRangeEnd = 72012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_ZXSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x00071620 File Offset: 0x0006F820
		public unsafe float UniformSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_UniformSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0007165C File Offset: 0x0006F85C
		public unsafe float DragSensitivity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72013, RefRangeEnd = 72014, XrefRangeStart = 72013, XrefRangeEnd = 72013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00071698 File Offset: 0x0006F898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72042, RefRangeEnd = 72044, XrefRangeStart = 72014, XrefRangeEnd = 72042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScaleGizmoSettings3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleGizmoSettings3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000716D4 File Offset: 0x0006F8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLineSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetLineSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00071714 File Offset: 0x0006F914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetBoxSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00071754 File Offset: 0x0006F954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCylinderSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetCylinderSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00071794 File Offset: 0x0006F994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72044, XrefRangeEnd = 72050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetXSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000717D4 File Offset: 0x0006F9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72050, XrefRangeEnd = 72056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetYSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00071814 File Offset: 0x0006FA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72056, XrefRangeEnd = 72062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetZSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00071854 File Offset: 0x0006FA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72062, XrefRangeEnd = 72065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetXYSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetXYSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00071894 File Offset: 0x0006FA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72065, XrefRangeEnd = 72068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetYZSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetYZSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000718D4 File Offset: 0x0006FAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72068, XrefRangeEnd = 72071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZXSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetZXSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00071914 File Offset: 0x0006FB14
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65070, XrefRangeStart = 65039, XrefRangeEnd = 65070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUniformScaleSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetUniformScaleSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00071954 File Offset: 0x0006FB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72071, XrefRangeEnd = 72073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00071994 File Offset: 0x0006FB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x000719F8 File Offset: 0x0006FBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dblSlider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_ConnectDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00071A4C File Offset: 0x0006FC4C
		[CallerCount(0)]
		public unsafe GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_GetSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DSettings>(intPtr3) : null;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00071AAC File Offset: 0x0006FCAC
		[CallerCount(0)]
		public unsafe GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoSettings3D.NativeMethodInfoPtr_GetDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00009D05 File Offset: 0x00007F05
		public ScaleGizmoSettings3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x00071AFC File Offset: 0x0006FCFC
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x00009D0E File Offset: 0x00007F0E
		public unsafe float _uniformSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoSettings3D.NativeFieldInfoPtr__uniformSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoSettings3D.NativeFieldInfoPtr__uniformSnapStep)) = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x00071B24 File Offset: 0x0006FD24
		// (set) Token: 0x06001504 RID: 5380 RVA: 0x00009D29 File Offset: 0x00007F29
		public unsafe Il2CppReferenceArray<GizmoLineSlider3DSettings> _sglSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoSettings3D.NativeFieldInfoPtr__sglSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoSettings3D.NativeFieldInfoPtr__sglSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x00071B54 File Offset: 0x0006FD54
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x00009D48 File Offset: 0x00007F48
		public unsafe Il2CppReferenceArray<GizmoPlaneSlider3DSettings> _dblSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoSettings3D.NativeFieldInfoPtr__dblSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoPlaneSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoSettings3D.NativeFieldInfoPtr__dblSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeFieldInfoPtr__uniformSnapStep;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderSettings;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeFieldInfoPtr__dblSliderSettings;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_get_LineSliderHoverEps_Public_get_Single_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxSliderHoverEps_Public_get_Single_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_get_CylinderSliderHoverEps_Public_get_Single_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_get_XYSnapStep_Public_get_Single_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_get_YZSnapStep_Public_get_Single_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_get_ZXSnapStep_Public_get_Single_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_get_UniformSnapStep_Public_get_Single_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_SetLineSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_SetCylinderSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_SetZSnapStep_Public_Void_Single_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_SetXYSnapStep_Public_Void_Single_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_SetYZSnapStep_Public_Void_Single_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_SetZXSnapStep_Public_Void_Single_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_SetUniformScaleSnapStep_Public_Void_Single_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_ConnectDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_GetSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_GetDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0;
	}
}
