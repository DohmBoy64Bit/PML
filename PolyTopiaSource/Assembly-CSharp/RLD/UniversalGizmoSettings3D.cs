using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000EF RID: 239
	[Serializable]
	public class UniversalGizmoSettings3D : Settings
	{
		// Token: 0x06001769 RID: 5993 RVA: 0x0007C648 File Offset: 0x0007A848
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalGizmoSettings3D()
		{
			Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "UniversalGizmoSettings3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr);
			UniversalGizmoSettings3D.NativeFieldInfoPtr__displayCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_displayCategory");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__mvVertexSnapSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_mvVertexSnapSettings");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__mvSglSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_mvSglSliderSettings");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__mvDblSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_mvDblSliderSettings");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__rtCamRightSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_rtCamRightSnapStep");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__rtCamUpSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_rtCamUpSnapStep");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__rtSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_rtSliderSettings");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__rtCamLookSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_rtCamLookSliderSettings");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__scUniformSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_scUniformSnapStep");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__scSglSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_scSglSliderSettings");
			UniversalGizmoSettings3D.NativeFieldInfoPtr__scDblSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, "_scDblSliderSettings");
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_VertexSnapSettings_Public_get_GizmoObjectVertexSnapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666740);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvLineSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666741);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvBoxSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666742);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvCylinderSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666743);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvXSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666744);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvYSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666745);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvZSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666746);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvDragSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666747);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtAxisLineHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666748);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtAxisTorusHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666749);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamLookLineHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666750);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamLookThickHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666751);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCanHoverCulledPixels_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666752);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtSnapMode_Public_get_GizmoSnapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666753);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtXSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666754);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtYSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666755);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtZSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666756);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamRightSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666757);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamUpSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666758);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamLookSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666759);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtDragSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666760);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScLineSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666761);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScBoxSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666762);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScCylinderSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666763);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScXSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666764);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScYSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666765);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScZSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666766);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScXYSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666767);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScYZSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666768);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScZXSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666769);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScUniformSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666770);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScDragSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666771);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666772);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666773);
			UniversalGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666774);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvLineSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666775);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvBoxSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666776);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvCylinderSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666777);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvXSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666778);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvYSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666779);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvZSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666780);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvDragSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666781);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectMvSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666782);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectMvDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666783);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_Inherit_Public_Void_MoveGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666784);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_GetMvSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666785);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_GetMvDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666786);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCanHoverCulledPixels_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666787);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtAxisLineHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666788);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtAxisTorusHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666789);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamLookLineHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666790);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamLookThickHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666791);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtAxisSnapStep_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666792);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamRightSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666793);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamUpSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666794);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamLookSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666795);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtSnapMode_Public_Void_GizmoSnapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666796);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtDragSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666797);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectRtSliderSettings_Public_Void_GizmoPlaneSlider3D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666798);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectRtCamLookSliderSettings_Public_Void_GizmoPlaneSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666799);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_Inherit_Public_Void_RotationGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666800);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScLineSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666801);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScBoxSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666802);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScCylinderSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666803);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScXSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666804);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScYSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666805);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScZSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666806);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScXYSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666807);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScYZSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666808);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScZXSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666809);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScUniformScaleSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666810);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScDragSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666811);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectScSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666812);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectScDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666813);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_Inherit_Public_Void_ScaleGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666814);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_GetScSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666815);
			UniversalGizmoSettings3D.NativeMethodInfoPtr_GetScDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr, 100666816);
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x0007CD58 File Offset: 0x0007AF58
		public unsafe GizmoObjectVertexSnapSettings VertexSnapSettings
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_VertexSnapSettings_Public_get_GizmoObjectVertexSnapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoObjectVertexSnapSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x0007CD98 File Offset: 0x0007AF98
		public unsafe float MvLineSliderHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvLineSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x0007CDD4 File Offset: 0x0007AFD4
		public unsafe float MvBoxSliderHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvBoxSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x0007CE10 File Offset: 0x0007B010
		public unsafe float MvCylinderSliderHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvCylinderSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x0007CE4C File Offset: 0x0007B04C
		public unsafe float MvXSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvXSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x0007CE88 File Offset: 0x0007B088
		public unsafe float MvYSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvYSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x0007CEC4 File Offset: 0x0007B0C4
		public unsafe float MvZSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvZSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x0007CF00 File Offset: 0x0007B100
		public unsafe float MvDragSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_MvDragSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x0007CF3C File Offset: 0x0007B13C
		public unsafe float RtAxisLineHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtAxisLineHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x0007CF78 File Offset: 0x0007B178
		public unsafe float RtAxisTorusHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtAxisTorusHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x0007CFB4 File Offset: 0x0007B1B4
		public unsafe float RtCamLookLineHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamLookLineHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x0007CFF0 File Offset: 0x0007B1F0
		public unsafe float RtCamLookThickHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamLookThickHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x0007D02C File Offset: 0x0007B22C
		public unsafe bool RtCanHoverCulledPixels
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCanHoverCulledPixels_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x0007D068 File Offset: 0x0007B268
		public unsafe GizmoSnapMode RtSnapMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtSnapMode_Public_get_GizmoSnapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoSnapMode>(intPtr3) : null;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0007D0A8 File Offset: 0x0007B2A8
		public unsafe float RtXSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtXSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x0007D0E4 File Offset: 0x0007B2E4
		public unsafe float RtYSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtYSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0007D120 File Offset: 0x0007B320
		public unsafe float RtZSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtZSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x0007D15C File Offset: 0x0007B35C
		public unsafe float RtCamRightSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamRightSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0007D198 File Offset: 0x0007B398
		public unsafe float RtCamUpSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamUpSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x0007D1D4 File Offset: 0x0007B3D4
		public unsafe float RtCamLookSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtCamLookSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x0007D210 File Offset: 0x0007B410
		public unsafe float RtDragSensitivity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73562, RefRangeEnd = 73563, XrefRangeStart = 73562, XrefRangeEnd = 73562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_RtDragSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x0007D24C File Offset: 0x0007B44C
		public unsafe float ScLineSliderHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScLineSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x0007D288 File Offset: 0x0007B488
		public unsafe float ScBoxSliderHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScBoxSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x0007D2C4 File Offset: 0x0007B4C4
		public unsafe float ScCylinderSliderHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScCylinderSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0007D300 File Offset: 0x0007B500
		public unsafe float ScXSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScXSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x0007D33C File Offset: 0x0007B53C
		public unsafe float ScYSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScYSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x0007D378 File Offset: 0x0007B578
		public unsafe float ScZSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScZSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x0007D3B4 File Offset: 0x0007B5B4
		public unsafe float ScXYSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScXYSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x0007D3F0 File Offset: 0x0007B5F0
		public unsafe float ScYZSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScYZSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x0007D42C File Offset: 0x0007B62C
		public unsafe float ScZXSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScZXSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0007D468 File Offset: 0x0007B668
		public unsafe float ScUniformSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScUniformSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x0007D4A4 File Offset: 0x0007B6A4
		public unsafe float ScDragSensitivity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73563, RefRangeEnd = 73564, XrefRangeStart = 73563, XrefRangeEnd = 73563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_ScDragSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x0007D4E0 File Offset: 0x0007B6E0
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x0007D520 File Offset: 0x0007B720
		public unsafe UniversalGizmoSettingsCategory DisplayCategory
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0007D564 File Offset: 0x0007B764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73640, RefRangeEnd = 73642, XrefRangeStart = 73564, XrefRangeEnd = 73640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalGizmoSettings3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGizmoSettings3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0007D5A0 File Offset: 0x0007B7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvLineSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvLineSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0007D5E0 File Offset: 0x0007B7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvBoxSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvBoxSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0007D620 File Offset: 0x0007B820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvCylinderSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvCylinderSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0007D660 File Offset: 0x0007B860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73642, XrefRangeEnd = 73648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvXSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvXSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0007D6A0 File Offset: 0x0007B8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73648, XrefRangeEnd = 73654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvYSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvYSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0007D6E0 File Offset: 0x0007B8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73654, XrefRangeEnd = 73660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvZSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvZSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0007D720 File Offset: 0x0007B920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73660, XrefRangeEnd = 73664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvDragSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetMvDragSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0007D760 File Offset: 0x0007B960
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 73668, RefRangeEnd = 73674, XrefRangeStart = 73664, XrefRangeEnd = 73668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMvSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectMvSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0007D7C4 File Offset: 0x0007B9C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73677, RefRangeEnd = 73680, XrefRangeStart = 73674, XrefRangeEnd = 73677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMvDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectMvDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0007D818 File Offset: 0x0007BA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73680, XrefRangeEnd = 73712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Inherit(MoveGizmoSettings3D settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_Inherit_Public_Void_MoveGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0007D85C File Offset: 0x0007BA5C
		[CallerCount(0)]
		public unsafe GizmoLineSlider3DSettings GetMvSglSliderSettings(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_GetMvSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DSettings>(intPtr3) : null;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x0007D8BC File Offset: 0x0007BABC
		[CallerCount(0)]
		public unsafe GizmoPlaneSlider3DSettings GetMvDblSliderSettings(PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_GetMvDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0007D90C File Offset: 0x0007BB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73712, XrefRangeEnd = 73713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtCanHoverCulledPixels(bool canHover)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canHover;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCanHoverCulledPixels_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0007D94C File Offset: 0x0007BB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73713, XrefRangeEnd = 73715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtAxisLineHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtAxisLineHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0007D98C File Offset: 0x0007BB8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73717, RefRangeEnd = 73718, XrefRangeStart = 73715, XrefRangeEnd = 73717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtAxisTorusHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtAxisTorusHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0007D9CC File Offset: 0x0007BBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73718, XrefRangeEnd = 73720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtCamLookLineHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamLookLineHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x0007DA0C File Offset: 0x0007BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73720, XrefRangeEnd = 73722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtCamLookThickHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamLookThickHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x0007DA4C File Offset: 0x0007BC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73722, XrefRangeEnd = 73725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtAxisSnapStep(int axisIndex, float snapStep)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtAxisSnapStep_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0007DA98 File Offset: 0x0007BC98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68180, RefRangeEnd = 68183, XrefRangeStart = 68180, XrefRangeEnd = 68183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtCamRightSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamRightSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0007DAD8 File Offset: 0x0007BCD8
		[CallerCount(0)]
		public unsafe void SetRtCamUpSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamUpSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0007DB18 File Offset: 0x0007BD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73725, XrefRangeEnd = 73727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtCamLookSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtCamLookSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0007DB58 File Offset: 0x0007BD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73727, XrefRangeEnd = 73728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtSnapMode(GizmoSnapMode snapMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(snapMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtSnapMode_Public_Void_GizmoSnapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0007DB9C File Offset: 0x0007BD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73728, XrefRangeEnd = 73733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtDragSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetRtDragSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0007DBDC File Offset: 0x0007BDDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73736, RefRangeEnd = 73739, XrefRangeStart = 73733, XrefRangeEnd = 73736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectRtSliderSettings(GizmoPlaneSlider3D slider, int axisIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectRtSliderSettings_Public_Void_GizmoPlaneSlider3D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0007DC2C File Offset: 0x0007BE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73741, RefRangeEnd = 73742, XrefRangeStart = 73739, XrefRangeEnd = 73741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectRtCamLookSliderSettings(GizmoPlaneSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectRtCamLookSliderSettings_Public_Void_GizmoPlaneSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0007DC70 File Offset: 0x0007BE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73742, XrefRangeEnd = 73769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Inherit(RotationGizmoSettings3D settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_Inherit_Public_Void_RotationGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0007DCB4 File Offset: 0x0007BEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73769, XrefRangeEnd = 73771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScLineSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScLineSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0007DCF4 File Offset: 0x0007BEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73771, XrefRangeEnd = 73773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScBoxSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScBoxSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0007DD34 File Offset: 0x0007BF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73773, XrefRangeEnd = 73775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScCylinderSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScCylinderSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0007DD74 File Offset: 0x0007BF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73775, XrefRangeEnd = 73781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScXSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScXSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0007DDB4 File Offset: 0x0007BFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73781, XrefRangeEnd = 73787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScYSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScYSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0007DDF4 File Offset: 0x0007BFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73787, XrefRangeEnd = 73793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScZSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScZSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0007DE34 File Offset: 0x0007C034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73793, XrefRangeEnd = 73796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScXYSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScXYSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0007DE74 File Offset: 0x0007C074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73796, XrefRangeEnd = 73799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScYZSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScYZSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0007DEB4 File Offset: 0x0007C0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73799, XrefRangeEnd = 73802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScZXSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScZXSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0007DEF4 File Offset: 0x0007C0F4
		[CallerCount(0)]
		public unsafe void SetScUniformScaleSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScUniformScaleSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0007DF34 File Offset: 0x0007C134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73804, RefRangeEnd = 73805, XrefRangeStart = 73802, XrefRangeEnd = 73804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScDragSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_SetScDragSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0007DF74 File Offset: 0x0007C174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73805, XrefRangeEnd = 73809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectScSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectScSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0007DFD8 File Offset: 0x0007C1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73809, XrefRangeEnd = 73812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectScDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_ConnectScDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0007E02C File Offset: 0x0007C22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73812, XrefRangeEnd = 73846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Inherit(ScaleGizmoSettings3D settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_Inherit_Public_Void_ScaleGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x0007E070 File Offset: 0x0007C270
		[CallerCount(0)]
		public unsafe GizmoLineSlider3DSettings GetScSglSliderSettings(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_GetScSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DSettings>(intPtr3) : null;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0007E0D0 File Offset: 0x0007C2D0
		[CallerCount(0)]
		public unsafe GizmoPlaneSlider3DSettings GetScDblSliderSettings(PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmoSettings3D.NativeMethodInfoPtr_GetScDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0000A737 File Offset: 0x00008937
		public UniversalGizmoSettings3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0007E120 File Offset: 0x0007C320
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0000A740 File Offset: 0x00008940
		public unsafe UniversalGizmoSettingsCategory _displayCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__displayCategory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettingsCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__displayCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0007E150 File Offset: 0x0007C350
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0000A75F File Offset: 0x0000895F
		public unsafe GizmoObjectVertexSnapSettings _mvVertexSnapSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__mvVertexSnapSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoObjectVertexSnapSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__mvVertexSnapSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x0007E180 File Offset: 0x0007C380
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x0000A77E File Offset: 0x0000897E
		public unsafe Il2CppReferenceArray<GizmoLineSlider3DSettings> _mvSglSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__mvSglSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__mvSglSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x0007E1B0 File Offset: 0x0007C3B0
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x0000A79D File Offset: 0x0000899D
		public unsafe Il2CppReferenceArray<GizmoPlaneSlider3DSettings> _mvDblSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__mvDblSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoPlaneSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__mvDblSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0007E1E0 File Offset: 0x0007C3E0
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0000A7BC File Offset: 0x000089BC
		public unsafe float _rtCamRightSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__rtCamRightSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__rtCamRightSnapStep)) = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x0007E208 File Offset: 0x0007C408
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0000A7D7 File Offset: 0x000089D7
		public unsafe float _rtCamUpSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__rtCamUpSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__rtCamUpSnapStep)) = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0007E230 File Offset: 0x0007C430
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0000A7F2 File Offset: 0x000089F2
		public unsafe Il2CppReferenceArray<GizmoPlaneSlider3DSettings> _rtSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__rtSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoPlaneSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__rtSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0007E260 File Offset: 0x0007C460
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0000A811 File Offset: 0x00008A11
		public unsafe GizmoPlaneSlider2DSettings _rtCamLookSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__rtCamLookSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__rtCamLookSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0007E290 File Offset: 0x0007C490
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0000A830 File Offset: 0x00008A30
		public unsafe float _scUniformSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__scUniformSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__scUniformSnapStep)) = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0007E2B8 File Offset: 0x0007C4B8
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x0000A84B File Offset: 0x00008A4B
		public unsafe Il2CppReferenceArray<GizmoLineSlider3DSettings> _scSglSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__scSglSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__scSglSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0007E2E8 File Offset: 0x0007C4E8
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0000A86A File Offset: 0x00008A6A
		public unsafe Il2CppReferenceArray<GizmoPlaneSlider3DSettings> _scDblSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__scDblSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoPlaneSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmoSettings3D.NativeFieldInfoPtr__scDblSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeFieldInfoPtr__displayCategory;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeFieldInfoPtr__mvVertexSnapSettings;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr__mvSglSliderSettings;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeFieldInfoPtr__mvDblSliderSettings;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeFieldInfoPtr__rtCamRightSnapStep;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeFieldInfoPtr__rtCamUpSnapStep;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeFieldInfoPtr__rtSliderSettings;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeFieldInfoPtr__rtCamLookSliderSettings;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeFieldInfoPtr__scUniformSnapStep;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeFieldInfoPtr__scSglSliderSettings;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeFieldInfoPtr__scDblSliderSettings;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_get_VertexSnapSettings_Public_get_GizmoObjectVertexSnapSettings_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_get_MvLineSliderHoverEps_Public_get_Single_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_get_MvBoxSliderHoverEps_Public_get_Single_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr_get_MvCylinderSliderHoverEps_Public_get_Single_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_get_MvXSnapStep_Public_get_Single_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_get_MvYSnapStep_Public_get_Single_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_get_MvZSnapStep_Public_get_Single_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_get_MvDragSensitivity_Public_get_Single_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_get_RtAxisLineHoverEps_Public_get_Single_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_get_RtAxisTorusHoverEps_Public_get_Single_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_get_RtCamLookLineHoverEps_Public_get_Single_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_get_RtCamLookThickHoverEps_Public_get_Single_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_get_RtCanHoverCulledPixels_Public_get_Boolean_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_get_RtSnapMode_Public_get_GizmoSnapMode_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_get_RtXSnapStep_Public_get_Single_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_get_RtYSnapStep_Public_get_Single_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_get_RtZSnapStep_Public_get_Single_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_get_RtCamRightSnapStep_Public_get_Single_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_get_RtCamUpSnapStep_Public_get_Single_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_get_RtCamLookSnapStep_Public_get_Single_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_get_RtDragSensitivity_Public_get_Single_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_get_ScLineSliderHoverEps_Public_get_Single_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_get_ScBoxSliderHoverEps_Public_get_Single_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_get_ScCylinderSliderHoverEps_Public_get_Single_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_get_ScXSnapStep_Public_get_Single_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_get_ScYSnapStep_Public_get_Single_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_get_ScZSnapStep_Public_get_Single_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_get_ScXYSnapStep_Public_get_Single_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_get_ScYZSnapStep_Public_get_Single_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_get_ScZXSnapStep_Public_get_Single_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_get_ScUniformSnapStep_Public_get_Single_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_get_ScDragSensitivity_Public_get_Single_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayCategory_Public_get_UniversalGizmoSettingsCategory_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayCategory_Public_set_Void_UniversalGizmoSettingsCategory_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_SetMvLineSliderHoverEps_Public_Void_Single_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_SetMvBoxSliderHoverEps_Public_Void_Single_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_SetMvCylinderSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_SetMvXSnapStep_Public_Void_Single_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_SetMvYSnapStep_Public_Void_Single_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_SetMvZSnapStep_Public_Void_Single_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_SetMvDragSensitivity_Public_Void_Single_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMvSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMvDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_Inherit_Public_Void_MoveGizmoSettings3D_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_GetMvSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_GetMvDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_SetRtCanHoverCulledPixels_Public_Void_Boolean_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_SetRtAxisLineHoverEps_Public_Void_Single_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_SetRtAxisTorusHoverEps_Public_Void_Single_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_SetRtCamLookLineHoverEps_Public_Void_Single_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_SetRtCamLookThickHoverEps_Public_Void_Single_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_SetRtAxisSnapStep_Public_Void_Int32_Single_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_SetRtCamRightSnapStep_Public_Void_Single_0;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeMethodInfoPtr_SetRtCamUpSnapStep_Public_Void_Single_0;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr_SetRtCamLookSnapStep_Public_Void_Single_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr_SetRtSnapMode_Public_Void_GizmoSnapMode_0;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_SetRtDragSensitivity_Public_Void_Single_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_ConnectRtSliderSettings_Public_Void_GizmoPlaneSlider3D_Int32_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_ConnectRtCamLookSliderSettings_Public_Void_GizmoPlaneSlider2D_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_Inherit_Public_Void_RotationGizmoSettings3D_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_SetScLineSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_SetScBoxSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_SetScCylinderSliderHoverEps_Public_Void_Single_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_SetScXSnapStep_Public_Void_Single_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_SetScYSnapStep_Public_Void_Single_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_SetScZSnapStep_Public_Void_Single_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_SetScXYSnapStep_Public_Void_Single_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_SetScYZSnapStep_Public_Void_Single_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_SetScZXSnapStep_Public_Void_Single_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_SetScUniformScaleSnapStep_Public_Void_Single_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_SetScDragSensitivity_Public_Void_Single_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_ConnectScSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_ConnectScDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_Inherit_Public_Void_ScaleGizmoSettings3D_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_GetScSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_GetScDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0;
	}
}
