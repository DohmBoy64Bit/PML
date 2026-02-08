using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200000D RID: 13
	public class GizmoCap2D : GizmoCap
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00022EA4 File Offset: 0x000210A4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCap2D()
		{
			Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCap2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr);
			GizmoCap2D.NativeFieldInfoPtr__quadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_quadIndex");
			GizmoCap2D.NativeFieldInfoPtr__quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_quad");
			GizmoCap2D.NativeFieldInfoPtr__circleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_circleIndex");
			GizmoCap2D.NativeFieldInfoPtr__circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_circle");
			GizmoCap2D.NativeFieldInfoPtr__arrowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_arrowIndex");
			GizmoCap2D.NativeFieldInfoPtr__arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_arrow");
			GizmoCap2D.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_transform");
			GizmoCap2D.NativeFieldInfoPtr__overrideFillColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_overrideFillColor");
			GizmoCap2D.NativeFieldInfoPtr__overrideBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_overrideBorderColor");
			GizmoCap2D.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_controllerData");
			GizmoCap2D.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_controllers");
			GizmoCap2D.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_lookAndFeel");
			GizmoCap2D.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, "_sharedLookAndFeel");
			GizmoCap2D.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663384);
			GizmoCap2D.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663385);
			GizmoCap2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663386);
			GizmoCap2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663387);
			GizmoCap2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663388);
			GizmoCap2D.NativeMethodInfoPtr_get_OverrideFillColor_Public_get_GizmoOverrideColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663389);
			GizmoCap2D.NativeMethodInfoPtr_get_OverrideBorderColor_Public_get_GizmoOverrideColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663390);
			GizmoCap2D.NativeMethodInfoPtr_get_DragSession_Public_get_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663391);
			GizmoCap2D.NativeMethodInfoPtr_set_DragSession_Public_set_Void_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663392);
			GizmoCap2D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoCap2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663393);
			GizmoCap2D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoCap2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663394);
			GizmoCap2D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoCap2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663395);
			GizmoCap2D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663396);
			GizmoCap2D.NativeMethodInfoPtr_RegisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663397);
			GizmoCap2D.NativeMethodInfoPtr_UnregisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663398);
			GizmoCap2D.NativeMethodInfoPtr_AlignTransformAxis_Public_Void_Int32_AxisSign_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663399);
			GizmoCap2D.NativeMethodInfoPtr_GetRealQuadWidth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663400);
			GizmoCap2D.NativeMethodInfoPtr_GetRealQuadHeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663401);
			GizmoCap2D.NativeMethodInfoPtr_GetRealCircleRadius_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663402);
			GizmoCap2D.NativeMethodInfoPtr_GetRealArrowHeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663403);
			GizmoCap2D.NativeMethodInfoPtr_GetRealArrowBaseRadius_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663404);
			GizmoCap2D.NativeMethodInfoPtr_CapSlider2D_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663405);
			GizmoCap2D.NativeMethodInfoPtr_CapSlider2DInvert_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663406);
			GizmoCap2D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663407);
			GizmoCap2D.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663408);
			GizmoCap2D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663409);
			GizmoCap2D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663410);
			GizmoCap2D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663411);
			GizmoCap2D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663412);
			GizmoCap2D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr, 100663413);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00023230 File Offset: 0x00021430
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00023270 File Offset: 0x00021470
		public unsafe Vector2 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 56749, RefRangeEnd = 56755, XrefRangeStart = 56747, XrefRangeEnd = 56749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000232B4 File Offset: 0x000214B4
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000232F4 File Offset: 0x000214F4
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00023330 File Offset: 0x00021530
		public unsafe float RotationDegrees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56755, XrefRangeEnd = 56756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00023370 File Offset: 0x00021570
		public unsafe GizmoOverrideColor OverrideFillColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_get_OverrideFillColor_Public_get_GizmoOverrideColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr3) : null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000233B0 File Offset: 0x000215B0
		public unsafe GizmoOverrideColor OverrideBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_get_OverrideBorderColor_Public_get_GizmoOverrideColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr3) : null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000233F0 File Offset: 0x000215F0
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00023430 File Offset: 0x00021630
		public unsafe IGizmoDragSession DragSession
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_get_DragSession_Public_get_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 56758, RefRangeEnd = 56769, XrefRangeStart = 56756, XrefRangeEnd = 56758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_set_DragSession_Public_set_Void_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00023474 File Offset: 0x00021674
		public unsafe GizmoCap2DLookAndFeel LookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoCap2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000234B4 File Offset: 0x000216B4
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000234F4 File Offset: 0x000216F4
		public unsafe GizmoCap2DLookAndFeel SharedLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoCap2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2DLookAndFeel>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoCap2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00023538 File Offset: 0x00021738
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 56887, RefRangeEnd = 56896, XrefRangeStart = 56769, XrefRangeEnd = 56887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCap2D(Gizmo gizmo, int handleId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00023594 File Offset: 0x00021794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56900, RefRangeEnd = 56902, XrefRangeStart = 56896, XrefRangeEnd = 56900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_RegisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000235D8 File Offset: 0x000217D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56902, XrefRangeEnd = 56906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_UnregisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0002361C File Offset: 0x0002181C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56906, XrefRangeEnd = 56909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector2 axis)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_AlignTransformAxis_Public_Void_Int32_AxisSign_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00023680 File Offset: 0x00021880
		[CallerCount(0)]
		public unsafe float GetRealQuadWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_GetRealQuadWidth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000236BC File Offset: 0x000218BC
		[CallerCount(0)]
		public unsafe float GetRealQuadHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_GetRealQuadHeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000236F8 File Offset: 0x000218F8
		[CallerCount(0)]
		public unsafe float GetRealCircleRadius()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_GetRealCircleRadius_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00023734 File Offset: 0x00021934
		[CallerCount(0)]
		public unsafe float GetRealArrowHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_GetRealArrowHeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00023770 File Offset: 0x00021970
		[CallerCount(0)]
		public unsafe float GetRealArrowBaseRadius()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_GetRealArrowBaseRadius_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000237AC File Offset: 0x000219AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 56912, RefRangeEnd = 56917, XrefRangeStart = 56909, XrefRangeEnd = 56912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_CapSlider2D_Public_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00023800 File Offset: 0x00021A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56917, XrefRangeEnd = 56920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_CapSlider2DInvert_Public_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00023854 File Offset: 0x00021A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56920, XrefRangeEnd = 56945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCap2D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000238A4 File Offset: 0x00021AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56945, XrefRangeEnd = 56952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000238D8 File Offset: 0x00021AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56952, XrefRangeEnd = 56959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVisibilityStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCap2D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00023914 File Offset: 0x00021B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56959, XrefRangeEnd = 56961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHoverableStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCap2D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00023950 File Offset: 0x00021B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56961, XrefRangeEnd = 56968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00023994 File Offset: 0x00021B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56968, XrefRangeEnd = 56971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000239E4 File Offset: 0x00021BE4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002308 File Offset: 0x00000508
		public GizmoCap2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00023A28 File Offset: 0x00021C28
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002311 File Offset: 0x00000511
		public unsafe int _quadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__quadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__quadIndex)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00023A50 File Offset: 0x00021C50
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000232C File Offset: 0x0000052C
		public unsafe QuadShape2D _quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00023A80 File Offset: 0x00021C80
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000234B File Offset: 0x0000054B
		public unsafe int _circleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__circleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__circleIndex)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00023AA8 File Offset: 0x00021CA8
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002366 File Offset: 0x00000566
		public unsafe CircleShape2D _circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00023AD8 File Offset: 0x00021CD8
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002385 File Offset: 0x00000585
		public unsafe int _arrowIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__arrowIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__arrowIndex)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00023B00 File Offset: 0x00021D00
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000023A0 File Offset: 0x000005A0
		public unsafe ConeShape2D _arrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__arrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConeShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__arrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00023B30 File Offset: 0x00021D30
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000023BF File Offset: 0x000005BF
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00023B60 File Offset: 0x00021D60
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000023DE File Offset: 0x000005DE
		public unsafe GizmoOverrideColor _overrideFillColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__overrideFillColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__overrideFillColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00023B90 File Offset: 0x00021D90
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000023FD File Offset: 0x000005FD
		public unsafe GizmoOverrideColor _overrideBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__overrideBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__overrideBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00023BC0 File Offset: 0x00021DC0
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000241C File Offset: 0x0000061C
		public unsafe GizmoCap2DControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2DControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00023BF0 File Offset: 0x00021DF0
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000243B File Offset: 0x0000063B
		public unsafe Il2CppReferenceArray<IGizmoCap2DController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoCap2DController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00023C20 File Offset: 0x00021E20
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000245A File Offset: 0x0000065A
		public unsafe GizmoCap2DLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00023C50 File Offset: 0x00021E50
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002479 File Offset: 0x00000679
		public unsafe GizmoCap2DLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2D.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr__quadIndex;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr__quad;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr__circleIndex;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr__circle;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr__arrowIndex;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr__arrow;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr__overrideFillColor;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr__overrideBorderColor;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector2_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideFillColor_Public_get_GizmoOverrideColor_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideBorderColor_Public_get_GizmoOverrideColor_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSession_Public_get_IGizmoDragSession_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_set_DragSession_Public_set_Void_IGizmoDragSession_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoCap2DLookAndFeel_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoCap2DLookAndFeel_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoCap2DLookAndFeel_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterTransformAsDragTarget_Public_Void_IGizmoDragSession_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_AlignTransformAxis_Public_Void_Int32_AxisSign_Vector2_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_GetRealQuadWidth_Public_Single_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_GetRealQuadHeight_Public_Single_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_GetRealCircleRadius_Public_Single_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_GetRealArrowHeight_Public_Single_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_GetRealArrowBaseRadius_Public_Single_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider2D_Public_Void_Vector2_Vector2_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider2DInvert_Public_Void_Vector2_Vector2_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0;
	}
}
