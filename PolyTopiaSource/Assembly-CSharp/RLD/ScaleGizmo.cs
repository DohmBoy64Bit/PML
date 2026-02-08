using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E6 RID: 230
	[Serializable]
	public class ScaleGizmo : GizmoBehaviour
	{
		// Token: 0x06001414 RID: 5140 RVA: 0x0006DA80 File Offset: 0x0006BC80
		// Note: this type is marked as 'beforefieldinit'.
		static ScaleGizmo()
		{
			Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ScaleGizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr);
			ScaleGizmo.NativeFieldInfoPtr__pstvXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_pstvXSlider");
			ScaleGizmo.NativeFieldInfoPtr__pstvYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_pstvYSlider");
			ScaleGizmo.NativeFieldInfoPtr__pstvZSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_pstvZSlider");
			ScaleGizmo.NativeFieldInfoPtr__negXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_negXSlider");
			ScaleGizmo.NativeFieldInfoPtr__negYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_negYSlider");
			ScaleGizmo.NativeFieldInfoPtr__negZSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_negZSlider");
			ScaleGizmo.NativeFieldInfoPtr__axesSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_axesSliders");
			ScaleGizmo.NativeFieldInfoPtr__multiAxisScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_multiAxisScaleMode");
			ScaleGizmo.NativeFieldInfoPtr__xySlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_xySlider");
			ScaleGizmo.NativeFieldInfoPtr__yzSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_yzSlider");
			ScaleGizmo.NativeFieldInfoPtr__zxSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_zxSlider");
			ScaleGizmo.NativeFieldInfoPtr__dblSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_dblSliders");
			ScaleGizmo.NativeFieldInfoPtr__midCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_midCap");
			ScaleGizmo.NativeFieldInfoPtr__unformScaleDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_unformScaleDrag");
			ScaleGizmo.NativeFieldInfoPtr__scaleGuide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_scaleGuide");
			ScaleGizmo.NativeFieldInfoPtr__scaleGuideTargetObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_scaleGuideTargetObjects");
			ScaleGizmo.NativeFieldInfoPtr__lookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_lookAndFeel3D");
			ScaleGizmo.NativeFieldInfoPtr__settings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_settings3D");
			ScaleGizmo.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_hotkeys");
			ScaleGizmo.NativeFieldInfoPtr__useSnapEnableHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_useSnapEnableHotkey");
			ScaleGizmo.NativeFieldInfoPtr__useMultiAxisScaleModeHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_useMultiAxisScaleModeHotkey");
			ScaleGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_sharedLookAndFeel3D");
			ScaleGizmo.NativeFieldInfoPtr__sharedSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_sharedSettings3D");
			ScaleGizmo.NativeFieldInfoPtr__sharedHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, "_sharedHotkeys");
			ScaleGizmo.NativeMethodInfoPtr_get_MultiAxisScaleMode_Public_get_GizmoMultiAxisScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666141);
			ScaleGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_ScaleGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666142);
			ScaleGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_ScaleGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666143);
			ScaleGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_ScaleGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666144);
			ScaleGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ScaleGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666145);
			ScaleGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ScaleGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666146);
			ScaleGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_ScaleGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666147);
			ScaleGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_ScaleGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666148);
			ScaleGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_ScaleGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666149);
			ScaleGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_ScaleGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666150);
			ScaleGizmo.NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666151);
			ScaleGizmo.NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666152);
			ScaleGizmo.NativeMethodInfoPtr_get_UseMultiAxisScaleModeHotkey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666153);
			ScaleGizmo.NativeMethodInfoPtr_set_UseMultiAxisScaleModeHotkey_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666154);
			ScaleGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666170);
			ScaleGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666155);
			ScaleGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666156);
			ScaleGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666157);
			ScaleGizmo.NativeMethodInfoPtr_SetAxesLinesHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666158);
			ScaleGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666159);
			ScaleGizmo.NativeMethodInfoPtr_SetMultiAxisScaleMode_Public_Void_GizmoMultiAxisScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666160);
			ScaleGizmo.NativeMethodInfoPtr_SetScaleGuideTargetObjects_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666161);
			ScaleGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666162);
			ScaleGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666163);
			ScaleGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666164);
			ScaleGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666165);
			ScaleGizmo.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666166);
			ScaleGizmo.NativeMethodInfoPtr_PlaceDblSlidersInSliderPlanes_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666167);
			ScaleGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666168);
			ScaleGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr, 100666169);
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x0006DEE8 File Offset: 0x0006C0E8
		public unsafe GizmoMultiAxisScaleMode MultiAxisScaleMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_get_MultiAxisScaleMode_Public_get_GizmoMultiAxisScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoMultiAxisScaleMode>(intPtr3) : null;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0006DF28 File Offset: 0x0006C128
		public unsafe ScaleGizmoLookAndFeel3D LookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_ScaleGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x0006DF68 File Offset: 0x0006C168
		public unsafe ScaleGizmoSettings3D Settings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_ScaleGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0006DFA8 File Offset: 0x0006C1A8
		public unsafe ScaleGizmoHotkeys Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_ScaleGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0006DFE8 File Offset: 0x0006C1E8
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x0006E028 File Offset: 0x0006C228
		public unsafe ScaleGizmoHotkeys SharedHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ScaleGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmoHotkeys>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71549, RefRangeEnd = 71550, XrefRangeStart = 71544, XrefRangeEnd = 71549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ScaleGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0006E06C File Offset: 0x0006C26C
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0006E0AC File Offset: 0x0006C2AC
		public unsafe ScaleGizmoSettings3D SharedSettings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_ScaleGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmoSettings3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71552, RefRangeEnd = 71553, XrefRangeStart = 71550, XrefRangeEnd = 71552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_ScaleGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0006E0F0 File Offset: 0x0006C2F0
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0006E130 File Offset: 0x0006C330
		public unsafe ScaleGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_ScaleGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmoLookAndFeel3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71555, RefRangeEnd = 71556, XrefRangeStart = 71553, XrefRangeEnd = 71555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_ScaleGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0006E174 File Offset: 0x0006C374
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x0006E1B0 File Offset: 0x0006C3B0
		public unsafe bool UseSnapEnableHotkey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 25668, RefRangeEnd = 25669, XrefRangeStart = 25668, XrefRangeEnd = 25669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 25669, RefRangeEnd = 25673, XrefRangeStart = 25669, XrefRangeEnd = 25673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0006E1F0 File Offset: 0x0006C3F0
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x0006E22C File Offset: 0x0006C42C
		public unsafe bool UseMultiAxisScaleModeHotkey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_get_UseMultiAxisScaleModeHotkey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_set_UseMultiAxisScaleModeHotkey_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0006E26C File Offset: 0x0006C46C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71608, RefRangeEnd = 71610, XrefRangeStart = 71556, XrefRangeEnd = 71608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScaleGizmo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleGizmo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0006E2A8 File Offset: 0x0006C4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71610, XrefRangeEnd = 71615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0006E2F8 File Offset: 0x0006C4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71615, XrefRangeEnd = 71619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Vector3 position, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0006E358 File Offset: 0x0006C558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71619, XrefRangeEnd = 71623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OwnsHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0006E3A4 File Offset: 0x0006C5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71623, XrefRangeEnd = 71630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxesLinesHoverable(bool hoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_SetAxesLinesHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0006E3E4 File Offset: 0x0006C5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71630, XrefRangeEnd = 71633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0006E424 File Offset: 0x0006C624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71633, XrefRangeEnd = 71636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiAxisScaleMode(GizmoMultiAxisScaleMode scaleMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaleMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_SetMultiAxisScaleMode_Public_Void_GizmoMultiAxisScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0006E468 File Offset: 0x0006C668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_SetScaleGuideTargetObjects_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0006E4AC File Offset: 0x0006C6AC
		[CallerCount(0)]
		public unsafe override void OnGizmoEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScaleGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0006E4E8 File Offset: 0x0006C6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71636, XrefRangeEnd = 71758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScaleGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0006E524 File Offset: 0x0006C724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71758, XrefRangeEnd = 71789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoUpdateBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScaleGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0006E560 File Offset: 0x0006C760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71789, XrefRangeEnd = 71826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoRender(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScaleGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0006E5B0 File Offset: 0x0006C7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71826, XrefRangeEnd = 71835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScaleGizmo.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0006E5FC File Offset: 0x0006C7FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71838, RefRangeEnd = 71840, XrefRangeStart = 71835, XrefRangeEnd = 71838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceDblSlidersInSliderPlanes(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_PlaceDblSlidersInSliderPlanes_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0006E640 File Offset: 0x0006C840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71853, RefRangeEnd = 71855, XrefRangeStart = 71840, XrefRangeEnd = 71853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedLookAndFeel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0006E674 File Offset: 0x0006C874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71866, RefRangeEnd = 71868, XrefRangeStart = 71855, XrefRangeEnd = 71866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x000098D8 File Offset: 0x00007AD8
		public ScaleGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0006E6A8 File Offset: 0x0006C8A8
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x000098E1 File Offset: 0x00007AE1
		public unsafe GizmoLineSlider3D _pstvXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__pstvXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__pstvXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0006E6D8 File Offset: 0x0006C8D8
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x00009900 File Offset: 0x00007B00
		public unsafe GizmoLineSlider3D _pstvYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__pstvYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__pstvYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0006E708 File Offset: 0x0006C908
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x0000991F File Offset: 0x00007B1F
		public unsafe GizmoLineSlider3D _pstvZSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__pstvZSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__pstvZSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0006E738 File Offset: 0x0006C938
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x0000993E File Offset: 0x00007B3E
		public unsafe GizmoLineSlider3D _negXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__negXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__negXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0006E768 File Offset: 0x0006C968
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x0000995D File Offset: 0x00007B5D
		public unsafe GizmoLineSlider3D _negYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__negYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__negYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0006E798 File Offset: 0x0006C998
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x0000997C File Offset: 0x00007B7C
		public unsafe GizmoLineSlider3D _negZSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__negZSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__negZSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0006E7C8 File Offset: 0x0006C9C8
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x0000999B File Offset: 0x00007B9B
		public unsafe GizmoLineSlider3DCollection _axesSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__axesSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__axesSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0006E7F8 File Offset: 0x0006C9F8
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x000099BA File Offset: 0x00007BBA
		public unsafe GizmoMultiAxisScaleMode _multiAxisScaleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__multiAxisScaleMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoMultiAxisScaleMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__multiAxisScaleMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0006E828 File Offset: 0x0006CA28
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x000099D9 File Offset: 0x00007BD9
		public unsafe GizmoPlaneSlider3D _xySlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__xySlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__xySlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0006E858 File Offset: 0x0006CA58
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x000099F8 File Offset: 0x00007BF8
		public unsafe GizmoPlaneSlider3D _yzSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__yzSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__yzSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0006E888 File Offset: 0x0006CA88
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x00009A17 File Offset: 0x00007C17
		public unsafe GizmoPlaneSlider3D _zxSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__zxSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__zxSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0006E8B8 File Offset: 0x0006CAB8
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x00009A36 File Offset: 0x00007C36
		public unsafe GizmoPlaneSlider3DCollection _dblSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__dblSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__dblSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0006E8E8 File Offset: 0x0006CAE8
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x00009A55 File Offset: 0x00007C55
		public unsafe GizmoCap3D _midCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__midCap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__midCap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0006E918 File Offset: 0x0006CB18
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00009A74 File Offset: 0x00007C74
		public unsafe GizmoUniformScaleDrag3D _unformScaleDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__unformScaleDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoUniformScaleDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__unformScaleDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0006E948 File Offset: 0x0006CB48
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x00009A93 File Offset: 0x00007C93
		public unsafe GizmoScaleGuide _scaleGuide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__scaleGuide);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoScaleGuide>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__scaleGuide), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0006E978 File Offset: 0x0006CB78
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x00009AB2 File Offset: 0x00007CB2
		public unsafe IEnumerable<GameObject> _scaleGuideTargetObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__scaleGuideTargetObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__scaleGuideTargetObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0006E9A8 File Offset: 0x0006CBA8
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x00009AD1 File Offset: 0x00007CD1
		public unsafe ScaleGizmoLookAndFeel3D _lookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__lookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__lookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x0006E9D8 File Offset: 0x0006CBD8
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x00009AF0 File Offset: 0x00007CF0
		public unsafe ScaleGizmoSettings3D _settings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__settings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__settings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0006EA08 File Offset: 0x0006CC08
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x00009B0F File Offset: 0x00007D0F
		public unsafe ScaleGizmoHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0006EA38 File Offset: 0x0006CC38
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x00009B2E File Offset: 0x00007D2E
		public unsafe bool _useSnapEnableHotkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__useSnapEnableHotkey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__useSnapEnableHotkey)) = value;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0006EA60 File Offset: 0x0006CC60
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x00009B49 File Offset: 0x00007D49
		public unsafe bool _useMultiAxisScaleModeHotkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__useMultiAxisScaleModeHotkey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__useMultiAxisScaleModeHotkey)) = value;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0006EA88 File Offset: 0x0006CC88
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x00009B64 File Offset: 0x00007D64
		public unsafe ScaleGizmoLookAndFeel3D _sharedLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0006EAB8 File Offset: 0x0006CCB8
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x00009B83 File Offset: 0x00007D83
		public unsafe ScaleGizmoSettings3D _sharedSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__sharedSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__sharedSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0006EAE8 File Offset: 0x0006CCE8
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x00009BA2 File Offset: 0x00007DA2
		public unsafe ScaleGizmoHotkeys _sharedHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__sharedHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmo.NativeFieldInfoPtr__sharedHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeFieldInfoPtr__pstvXSlider;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeFieldInfoPtr__pstvYSlider;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeFieldInfoPtr__pstvZSlider;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeFieldInfoPtr__negXSlider;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeFieldInfoPtr__negYSlider;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeFieldInfoPtr__negZSlider;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeFieldInfoPtr__axesSliders;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeFieldInfoPtr__multiAxisScaleMode;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeFieldInfoPtr__xySlider;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeFieldInfoPtr__yzSlider;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeFieldInfoPtr__zxSlider;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeFieldInfoPtr__dblSliders;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeFieldInfoPtr__midCap;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeFieldInfoPtr__unformScaleDrag;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeFieldInfoPtr__scaleGuide;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeFieldInfoPtr__scaleGuideTargetObjects;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel3D;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeFieldInfoPtr__settings3D;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr__useSnapEnableHotkey;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr__useMultiAxisScaleModeHotkey;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel3D;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings3D;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr__sharedHotkeys;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_get_MultiAxisScaleMode_Public_get_GizmoMultiAxisScaleMode_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_ScaleGizmoLookAndFeel3D_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings3D_Public_get_ScaleGizmoSettings3D_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_ScaleGizmoHotkeys_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ScaleGizmoHotkeys_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ScaleGizmoHotkeys_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings3D_Public_get_ScaleGizmoSettings3D_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_ScaleGizmoSettings3D_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_ScaleGizmoLookAndFeel3D_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_ScaleGizmoLookAndFeel3D_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_get_UseMultiAxisScaleModeHotkey_Public_get_Boolean_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_set_UseMultiAxisScaleModeHotkey_Public_set_Void_Boolean_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_Camera_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_SetAxesLinesHoverable_Public_Void_Boolean_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiAxisScaleMode_Public_Void_GizmoMultiAxisScaleMode_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleGuideTargetObjects_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_PlaceDblSlidersInSliderPlanes_Private_Void_Camera_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0;
	}
}
