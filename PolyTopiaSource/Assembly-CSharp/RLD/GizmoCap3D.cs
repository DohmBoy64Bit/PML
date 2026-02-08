using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000017 RID: 23
	public class GizmoCap3D : GizmoCap
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00025C3C File Offset: 0x00023E3C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCap3D()
		{
			Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCap3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr);
			GizmoCap3D.NativeFieldInfoPtr__coneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_coneIndex");
			GizmoCap3D.NativeFieldInfoPtr__cone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_cone");
			GizmoCap3D.NativeFieldInfoPtr__pyramidIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_pyramidIndex");
			GizmoCap3D.NativeFieldInfoPtr__pyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_pyramid");
			GizmoCap3D.NativeFieldInfoPtr__boxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_boxIndex");
			GizmoCap3D.NativeFieldInfoPtr__box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_box");
			GizmoCap3D.NativeFieldInfoPtr__sphereIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_sphereIndex");
			GizmoCap3D.NativeFieldInfoPtr__sphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_sphere");
			GizmoCap3D.NativeFieldInfoPtr__trPrismIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_trPrismIndex");
			GizmoCap3D.NativeFieldInfoPtr__trPrism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_trPrism");
			GizmoCap3D.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_controllerData");
			GizmoCap3D.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_controllers");
			GizmoCap3D.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_transform");
			GizmoCap3D.NativeFieldInfoPtr__overrideColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_overrideColor");
			GizmoCap3D.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_lookAndFeel");
			GizmoCap3D.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, "_sharedLookAndFeel");
			GizmoCap3D.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663482);
			GizmoCap3D.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663483);
			GizmoCap3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663484);
			GizmoCap3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663485);
			GizmoCap3D.NativeMethodInfoPtr_get_OverrideColor_Public_get_GizmoOverrideColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663486);
			GizmoCap3D.NativeMethodInfoPtr_get_DragSession_Public_get_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663487);
			GizmoCap3D.NativeMethodInfoPtr_set_DragSession_Public_set_Void_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663488);
			GizmoCap3D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoCap3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663489);
			GizmoCap3D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoCap3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663490);
			GizmoCap3D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoCap3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663491);
			GizmoCap3D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663492);
			GizmoCap3D.NativeMethodInfoPtr_RegisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663493);
			GizmoCap3D.NativeMethodInfoPtr_UnregisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663494);
			GizmoCap3D.NativeMethodInfoPtr_AlignTransformAxis_Public_Void_Int32_AxisSign_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663495);
			GizmoCap3D.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663496);
			GizmoCap3D.NativeMethodInfoPtr_CapSlider3D_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663497);
			GizmoCap3D.NativeMethodInfoPtr_CapSlider3DInvert_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663498);
			GizmoCap3D.NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663499);
			GizmoCap3D.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663500);
			GizmoCap3D.NativeMethodInfoPtr_GetRealConeHeight_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663501);
			GizmoCap3D.NativeMethodInfoPtr_GetRealConeRadius_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663502);
			GizmoCap3D.NativeMethodInfoPtr_GetRealPyramidWidth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663503);
			GizmoCap3D.NativeMethodInfoPtr_GetRealPyramidDepth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663504);
			GizmoCap3D.NativeMethodInfoPtr_GetRealPyramidHeight_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663505);
			GizmoCap3D.NativeMethodInfoPtr_GetRealBoxWidth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663506);
			GizmoCap3D.NativeMethodInfoPtr_GetRealBoxHeight_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663507);
			GizmoCap3D.NativeMethodInfoPtr_GetRealBoxDepth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663508);
			GizmoCap3D.NativeMethodInfoPtr_GetRealBoxSize_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663509);
			GizmoCap3D.NativeMethodInfoPtr_GetRealSphereRadius_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663510);
			GizmoCap3D.NativeMethodInfoPtr_GetRealTriPrismWidth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663511);
			GizmoCap3D.NativeMethodInfoPtr_GetRealTriPrismHeight_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663512);
			GizmoCap3D.NativeMethodInfoPtr_GetRealTriPrismDepth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663513);
			GizmoCap3D.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663514);
			GizmoCap3D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663515);
			GizmoCap3D.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663516);
			GizmoCap3D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663517);
			GizmoCap3D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663518);
			GizmoCap3D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663519);
			GizmoCap3D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663520);
			GizmoCap3D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663521);
			GizmoCap3D.NativeMethodInfoPtr_OnGizmoPostDisabled_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr, 100663522);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000260E0 File Offset: 0x000242E0
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00026120 File Offset: 0x00024320
		public unsafe Vector3 Position
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 57276, RefRangeEnd = 57283, XrefRangeStart = 57276, XrefRangeEnd = 57276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57283, XrefRangeEnd = 57284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00026164 File Offset: 0x00024364
		// (set) Token: 0x06000148 RID: 328 RVA: 0x000261A4 File Offset: 0x000243A4
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57284, XrefRangeEnd = 57285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000261E8 File Offset: 0x000243E8
		public unsafe GizmoOverrideColor OverrideColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_get_OverrideColor_Public_get_GizmoOverrideColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr3) : null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00026228 File Offset: 0x00024428
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00026268 File Offset: 0x00024468
		public unsafe IGizmoDragSession DragSession
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_get_DragSession_Public_get_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 56758, RefRangeEnd = 56769, XrefRangeStart = 56758, XrefRangeEnd = 56769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_set_DragSession_Public_set_Void_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000262AC File Offset: 0x000244AC
		public unsafe GizmoCap3DLookAndFeel LookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoCap3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000262EC File Offset: 0x000244EC
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0002632C File Offset: 0x0002452C
		public unsafe GizmoCap3DLookAndFeel SharedLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoCap3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoCap3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00026370 File Offset: 0x00024570
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 57439, RefRangeEnd = 57449, XrefRangeStart = 57285, XrefRangeEnd = 57439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCap3D(Gizmo gizmo, int handleId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap3D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000263CC File Offset: 0x000245CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 57453, RefRangeEnd = 57456, XrefRangeStart = 57449, XrefRangeEnd = 57453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_RegisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00026410 File Offset: 0x00024610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57456, XrefRangeEnd = 57460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_UnregisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00026454 File Offset: 0x00024654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57460, XrefRangeEnd = 57461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_AlignTransformAxis_Public_Void_Int32_AxisSign_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000264B8 File Offset: 0x000246B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57463, RefRangeEnd = 57464, XrefRangeStart = 57461, XrefRangeEnd = 57463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZoomFactorTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000264FC File Offset: 0x000246FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 57470, RefRangeEnd = 57476, XrefRangeStart = 57464, XrefRangeEnd = 57470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sliderDirection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sliderEndPt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_CapSlider3D_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00026550 File Offset: 0x00024750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57482, RefRangeEnd = 57483, XrefRangeStart = 57476, XrefRangeEnd = 57482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sliderDirection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sliderEndPt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_CapSlider3DInvert_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000265A4 File Offset: 0x000247A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57489, RefRangeEnd = 57491, XrefRangeStart = 57483, XrefRangeEnd = 57489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSliderAlignedRealLength(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000265F0 File Offset: 0x000247F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57492, RefRangeEnd = 57496, XrefRangeStart = 57491, XrefRangeEnd = 57492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00026640 File Offset: 0x00024840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57496, RefRangeEnd = 57498, XrefRangeStart = 57496, XrefRangeEnd = 57496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealConeHeight(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealConeHeight_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0002668C File Offset: 0x0002488C
		[CallerCount(0)]
		public unsafe float GetRealConeRadius(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealConeRadius_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000266D8 File Offset: 0x000248D8
		[CallerCount(0)]
		public unsafe float GetRealPyramidWidth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealPyramidWidth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00026724 File Offset: 0x00024924
		[CallerCount(0)]
		public unsafe float GetRealPyramidDepth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealPyramidDepth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00026770 File Offset: 0x00024970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57498, RefRangeEnd = 57500, XrefRangeStart = 57498, XrefRangeEnd = 57498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealPyramidHeight(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealPyramidHeight_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000267BC File Offset: 0x000249BC
		[CallerCount(0)]
		public unsafe float GetRealBoxWidth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealBoxWidth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00026808 File Offset: 0x00024A08
		[CallerCount(0)]
		public unsafe float GetRealBoxHeight(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealBoxHeight_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00026854 File Offset: 0x00024A54
		[CallerCount(0)]
		public unsafe float GetRealBoxDepth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealBoxDepth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000268A0 File Offset: 0x00024AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57500, XrefRangeEnd = 57501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRealBoxSize(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealBoxSize_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000268EC File Offset: 0x00024AEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 57501, RefRangeEnd = 57507, XrefRangeStart = 57501, XrefRangeEnd = 57501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealSphereRadius(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealSphereRadius_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00026938 File Offset: 0x00024B38
		[CallerCount(0)]
		public unsafe float GetRealTriPrismWidth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealTriPrismWidth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00026984 File Offset: 0x00024B84
		[CallerCount(0)]
		public unsafe float GetRealTriPrismHeight(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealTriPrismHeight_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000269D0 File Offset: 0x00024BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57507, RefRangeEnd = 57509, XrefRangeStart = 57507, XrefRangeEnd = 57507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealTriPrismDepth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_GetRealTriPrismDepth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00026A1C File Offset: 0x00024C1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 57514, RefRangeEnd = 57521, XrefRangeStart = 57509, XrefRangeEnd = 57514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00026A60 File Offset: 0x00024C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57521, XrefRangeEnd = 57559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCap3D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00026AB0 File Offset: 0x00024CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57559, XrefRangeEnd = 57569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00026AE4 File Offset: 0x00024CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57569, XrefRangeEnd = 57579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVisibilityStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCap3D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00026B20 File Offset: 0x00024D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHoverableStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCap3D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00026B5C File Offset: 0x00024D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57579, XrefRangeEnd = 57589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00026BA0 File Offset: 0x00024DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57589, XrefRangeEnd = 57595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00026BF0 File Offset: 0x00024DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPostEnabled(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00026C34 File Offset: 0x00024E34
		[CallerCount(0)]
		public unsafe void OnGizmoPostDisabled(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3D.NativeMethodInfoPtr_OnGizmoPostDisabled_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000027A4 File Offset: 0x000009A4
		public GizmoCap3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00026C78 File Offset: 0x00024E78
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000027AD File Offset: 0x000009AD
		public unsafe int _coneIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__coneIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__coneIndex)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00026CA0 File Offset: 0x00024EA0
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000027C8 File Offset: 0x000009C8
		public unsafe ConeShape3D _cone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__cone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConeShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__cone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00026CD0 File Offset: 0x00024ED0
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000027E7 File Offset: 0x000009E7
		public unsafe int _pyramidIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__pyramidIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__pyramidIndex)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00026CF8 File Offset: 0x00024EF8
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002802 File Offset: 0x00000A02
		public unsafe PyramidShape3D _pyramid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__pyramid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PyramidShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__pyramid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00026D28 File Offset: 0x00024F28
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002821 File Offset: 0x00000A21
		public unsafe int _boxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__boxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__boxIndex)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00026D50 File Offset: 0x00024F50
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000283C File Offset: 0x00000A3C
		public unsafe BoxShape3D _box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00026D80 File Offset: 0x00024F80
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000285B File Offset: 0x00000A5B
		public unsafe int _sphereIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__sphereIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__sphereIndex)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00026DA8 File Offset: 0x00024FA8
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002876 File Offset: 0x00000A76
		public unsafe SphereShape3D _sphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__sphere);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__sphere), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00026DD8 File Offset: 0x00024FD8
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002895 File Offset: 0x00000A95
		public unsafe int _trPrismIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__trPrismIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__trPrismIndex)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00026E00 File Offset: 0x00025000
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000028B0 File Offset: 0x00000AB0
		public unsafe TriangPrismShape3D _trPrism
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__trPrism);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriangPrismShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__trPrism), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00026E30 File Offset: 0x00025030
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000028CF File Offset: 0x00000ACF
		public unsafe GizmoCap3DControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3DControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00026E60 File Offset: 0x00025060
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000028EE File Offset: 0x00000AEE
		public unsafe Il2CppReferenceArray<IGizmoCap3DController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoCap3DController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00026E90 File Offset: 0x00025090
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000290D File Offset: 0x00000B0D
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00026EC0 File Offset: 0x000250C0
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000292C File Offset: 0x00000B2C
		public unsafe GizmoOverrideColor _overrideColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__overrideColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__overrideColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00026EF0 File Offset: 0x000250F0
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000294B File Offset: 0x00000B4B
		public unsafe GizmoCap3DLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00026F20 File Offset: 0x00025120
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0000296A File Offset: 0x00000B6A
		public unsafe GizmoCap3DLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3D.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr__coneIndex;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr__cone;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr__pyramidIndex;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr__pyramid;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr__boxIndex;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr__box;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr__sphereIndex;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr__sphere;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr__trPrismIndex;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr__trPrism;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr__overrideColor;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideColor_Public_get_GizmoOverrideColor_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSession_Public_get_IGizmoDragSession_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_set_DragSession_Public_set_Void_IGizmoDragSession_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoCap3DLookAndFeel_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoCap3DLookAndFeel_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoCap3DLookAndFeel_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_AlignTransformAxis_Public_Void_Int32_AxisSign_Vector3_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider3D_Public_Void_Vector3_Vector3_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider3DInvert_Public_Void_Vector3_Vector3_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Single_Single_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_GetRealConeHeight_Public_Single_Single_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_GetRealConeRadius_Public_Single_Single_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_GetRealPyramidWidth_Public_Single_Single_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_GetRealPyramidDepth_Public_Single_Single_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_GetRealPyramidHeight_Public_Single_Single_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_GetRealBoxWidth_Public_Single_Single_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_GetRealBoxHeight_Public_Single_Single_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_GetRealBoxDepth_Public_Single_Single_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_GetRealBoxSize_Public_Vector3_Single_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_GetRealSphereRadius_Public_Single_Single_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_GetRealTriPrismWidth_Public_Single_Single_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_GetRealTriPrismHeight_Public_Single_Single_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_GetRealTriPrismDepth_Public_Single_Single_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPostDisabled_Private_Void_Gizmo_0;
	}
}
