using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000080 RID: 128
	[Serializable]
	public class BoxGizmo : GizmoBehaviour
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00046048 File Offset: 0x00044248
		// Note: this type is marked as 'beforefieldinit'.
		static BoxGizmo()
		{
			Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxGizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr);
			BoxGizmo.NativeFieldInfoPtr__usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_usage");
			BoxGizmo.NativeFieldInfoPtr__isUsagePermanent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_isUsagePermanent");
			BoxGizmo.NativeFieldInfoPtr__boxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_boxSize");
			BoxGizmo.NativeFieldInfoPtr__targetHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_targetHierarchy");
			BoxGizmo.NativeFieldInfoPtr__targetHierarchyTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_targetHierarchyTransform");
			BoxGizmo.NativeFieldInfoPtr__dragBeginTargetTransformSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_dragBeginTargetTransformSnapshot");
			BoxGizmo.NativeFieldInfoPtr__rightTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_rightTick");
			BoxGizmo.NativeFieldInfoPtr__topTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_topTick");
			BoxGizmo.NativeFieldInfoPtr__backTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_backTick");
			BoxGizmo.NativeFieldInfoPtr__leftTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_leftTick");
			BoxGizmo.NativeFieldInfoPtr__bottomTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_bottomTick");
			BoxGizmo.NativeFieldInfoPtr__frontTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_frontTick");
			BoxGizmo.NativeFieldInfoPtr__ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_ticks");
			BoxGizmo.NativeFieldInfoPtr__scaleFromCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_scaleFromCenter");
			BoxGizmo.NativeFieldInfoPtr__scalePivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_scalePivot");
			BoxGizmo.NativeFieldInfoPtr__scaleDragWorkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_scaleDragWorkData");
			BoxGizmo.NativeFieldInfoPtr__scaleDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_scaleDrag");
			BoxGizmo.NativeFieldInfoPtr__settings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_settings3D");
			BoxGizmo.NativeFieldInfoPtr__sharedSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_sharedSettings3D");
			BoxGizmo.NativeFieldInfoPtr__lookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_lookAndFeel3D");
			BoxGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_sharedLookAndFeel3D");
			BoxGizmo.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_hotkeys");
			BoxGizmo.NativeFieldInfoPtr__sharedHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, "_sharedHotkeys");
			BoxGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_BoxGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664725);
			BoxGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_BoxGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664726);
			BoxGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_BoxGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664727);
			BoxGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_BoxGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664728);
			BoxGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_BoxGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664729);
			BoxGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_BoxGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664730);
			BoxGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_BoxGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664731);
			BoxGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_BoxGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664732);
			BoxGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_BoxGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664733);
			BoxGizmo.NativeMethodInfoPtr_get_BoxUsage_Public_get_Usage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664734);
			BoxGizmo.NativeMethodInfoPtr_get_IsUsagePermanent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664735);
			BoxGizmo.NativeMethodInfoPtr_get_BoxCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664736);
			BoxGizmo.NativeMethodInfoPtr_get_BoxRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664737);
			BoxGizmo.NativeMethodInfoPtr_get_BoxRight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664738);
			BoxGizmo.NativeMethodInfoPtr_get_BoxUp_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664739);
			BoxGizmo.NativeMethodInfoPtr_get_BoxLook_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664740);
			BoxGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664769);
			BoxGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664741);
			BoxGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664742);
			BoxGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664743);
			BoxGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664744);
			BoxGizmo.NativeMethodInfoPtr_MakeUsagePermanent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664745);
			BoxGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664746);
			BoxGizmo.NativeMethodInfoPtr_IsXTick_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664747);
			BoxGizmo.NativeMethodInfoPtr_IsYTick_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664748);
			BoxGizmo.NativeMethodInfoPtr_IsZTick_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664749);
			BoxGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664750);
			BoxGizmo.NativeMethodInfoPtr_SetSize_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664751);
			BoxGizmo.NativeMethodInfoPtr_SetUsage_Public_Void_Usage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664752);
			BoxGizmo.NativeMethodInfoPtr_SetTargetHierarchy_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664753);
			BoxGizmo.NativeMethodInfoPtr_FitBoxToTargetHierarchy_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664754);
			BoxGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664755);
			BoxGizmo.NativeMethodInfoPtr_OnGizmoCanBeginDrag_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664756);
			BoxGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664757);
			BoxGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664758);
			BoxGizmo.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664759);
			BoxGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664760);
			BoxGizmo.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664761);
			BoxGizmo.NativeMethodInfoPtr_OnUndoRedoEnd_Private_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664762);
			BoxGizmo.NativeMethodInfoPtr_UpdateTickPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664763);
			BoxGizmo.NativeMethodInfoPtr_ValidateBoxSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664764);
			BoxGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664765);
			BoxGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664766);
			BoxGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664767);
			BoxGizmo.NativeMethodInfoPtr_CalcTargetRootOBB_Private_OBB_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr, 100664768);
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x000465C8 File Offset: 0x000447C8
		public unsafe BoxGizmoSettings3D Settings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_BoxGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00046608 File Offset: 0x00044808
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00046648 File Offset: 0x00044848
		public unsafe BoxGizmoSettings3D SharedSettings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_BoxGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmoSettings3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17932, RefRangeEnd = 17933, XrefRangeStart = 17932, XrefRangeEnd = 17933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_BoxGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0004668C File Offset: 0x0004488C
		public unsafe BoxGizmoLookAndFeel3D LookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_BoxGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x000466CC File Offset: 0x000448CC
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0004670C File Offset: 0x0004490C
		public unsafe BoxGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_BoxGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmoLookAndFeel3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 64589, RefRangeEnd = 64590, XrefRangeStart = 64587, XrefRangeEnd = 64589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_BoxGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00046750 File Offset: 0x00044950
		public unsafe BoxGizmoHotkeys Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_BoxGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00046790 File Offset: 0x00044990
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000467D0 File Offset: 0x000449D0
		public unsafe BoxGizmoHotkeys SharedHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_BoxGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmoHotkeys>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64590, XrefRangeEnd = 64591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_BoxGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00046814 File Offset: 0x00044A14
		public unsafe BoxGizmo.Usage BoxUsage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_BoxUsage_Public_get_Usage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00046850 File Offset: 0x00044A50
		public unsafe bool IsUsagePermanent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_IsUsagePermanent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0004688C File Offset: 0x00044A8C
		public unsafe Vector3 BoxCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_BoxCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x000468CC File Offset: 0x00044ACC
		public unsafe Quaternion BoxRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_BoxRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0004690C File Offset: 0x00044B0C
		public unsafe Vector3 BoxRight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62257, RefRangeEnd = 62259, XrefRangeStart = 62257, XrefRangeEnd = 62259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_BoxRight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0004694C File Offset: 0x00044B4C
		public unsafe Vector3 BoxUp
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62262, RefRangeEnd = 62264, XrefRangeStart = 62262, XrefRangeEnd = 62264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_BoxUp_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0004698C File Offset: 0x00044B8C
		public unsafe Vector3 BoxLook
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62267, RefRangeEnd = 62271, XrefRangeStart = 62267, XrefRangeEnd = 62271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_get_BoxLook_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000469CC File Offset: 0x00044BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64591, XrefRangeEnd = 64622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxGizmo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoxGizmo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00046A08 File Offset: 0x00044C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64622, XrefRangeEnd = 64651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDetached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00046A44 File Offset: 0x00044C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64651, XrefRangeEnd = 64659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00046A80 File Offset: 0x00044C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64659, XrefRangeEnd = 64667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00046ABC File Offset: 0x00044CBC
		[CallerCount(0)]
		public unsafe override void OnGizmoEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00046AF8 File Offset: 0x00044CF8
		[CallerCount(0)]
		public unsafe void MakeUsagePermanent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_MakeUsagePermanent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00046B2C File Offset: 0x00044D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64667, XrefRangeEnd = 64669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OwnsHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00046B78 File Offset: 0x00044D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64669, XrefRangeEnd = 64670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXTick(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_IsXTick_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00046BC4 File Offset: 0x00044DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64670, XrefRangeEnd = 64671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsYTick(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_IsYTick_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00046C10 File Offset: 0x00044E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64671, XrefRangeEnd = 64672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsZTick(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_IsZTick_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00046C5C File Offset: 0x00044E5C
		[CallerCount(0)]
		public unsafe void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00046C9C File Offset: 0x00044E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64672, XrefRangeEnd = 64673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(Vector3 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(size);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_SetSize_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00046CE0 File Offset: 0x00044EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64673, XrefRangeEnd = 64675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUsage(BoxGizmo.Usage usage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref usage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_SetUsage_Public_Void_Usage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00046D20 File Offset: 0x00044F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64675, XrefRangeEnd = 64683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetTargetHierarchy(GameObject targetHierarchy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetHierarchy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_SetTargetHierarchy_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00046D70 File Offset: 0x00044F70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 64686, RefRangeEnd = 64691, XrefRangeStart = 64683, XrefRangeEnd = 64686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FitBoxToTargetHierarchy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_FitBoxToTargetHierarchy_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00046DAC File Offset: 0x00044FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64691, XrefRangeEnd = 64746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00046DE8 File Offset: 0x00044FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64746, XrefRangeEnd = 64757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGizmoCanBeginDrag(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnGizmoCanBeginDrag_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00046E3C File Offset: 0x0004503C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64757, XrefRangeEnd = 64762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoUpdateBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00046E78 File Offset: 0x00045078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64762, XrefRangeEnd = 64787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoRender(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00046EC8 File Offset: 0x000450C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64787, XrefRangeEnd = 64832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00046F14 File Offset: 0x00045114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64832, XrefRangeEnd = 64858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragUpdate(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00046F60 File Offset: 0x00045160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64858, XrefRangeEnd = 64888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragEnd(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoxGizmo.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00046FAC File Offset: 0x000451AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUndoRedoEnd(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_OnUndoRedoEnd_Private_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00046FF0 File Offset: 0x000451F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 64914, RefRangeEnd = 64919, XrefRangeStart = 64891, XrefRangeEnd = 64914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTickPositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_UpdateTickPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00047024 File Offset: 0x00045224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64932, RefRangeEnd = 64934, XrefRangeStart = 64919, XrefRangeEnd = 64932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateBoxSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_ValidateBoxSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00047058 File Offset: 0x00045258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64940, RefRangeEnd = 64942, XrefRangeStart = 64934, XrefRangeEnd = 64940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedLookAndFeel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0004708C File Offset: 0x0004528C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000470C0 File Offset: 0x000452C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64942, XrefRangeEnd = 64943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoTransformChanged(GizmoTransform gizmoTransform, GizmoTransform.ChangeData changeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmoTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00047110 File Offset: 0x00045310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64943, XrefRangeEnd = 64947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OBB CalcTargetRootOBB(GameObject targetRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmo.NativeMethodInfoPtr_CalcTargetRootOBB_Private_OBB_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00005351 File Offset: 0x00003551
		public BoxGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00047160 File Offset: 0x00045360
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x0000535A File Offset: 0x0000355A
		public unsafe BoxGizmo.Usage _usage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__usage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__usage)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00047188 File Offset: 0x00045388
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00005375 File Offset: 0x00003575
		public unsafe bool _isUsagePermanent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__isUsagePermanent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__isUsagePermanent)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x000471B0 File Offset: 0x000453B0
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00005390 File Offset: 0x00003590
		public unsafe Vector3 _boxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__boxSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__boxSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x000471E0 File Offset: 0x000453E0
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x000053AF File Offset: 0x000035AF
		public unsafe GameObject _targetHierarchy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__targetHierarchy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__targetHierarchy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00047210 File Offset: 0x00045410
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x000053CE File Offset: 0x000035CE
		public unsafe Transform _targetHierarchyTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__targetHierarchyTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__targetHierarchyTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00047240 File Offset: 0x00045440
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x000053ED File Offset: 0x000035ED
		public unsafe LocalTransformSnapshot _dragBeginTargetTransformSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__dragBeginTargetTransformSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalTransformSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__dragBeginTargetTransformSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00047270 File Offset: 0x00045470
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0000540C File Offset: 0x0000360C
		public unsafe GizmoCap2D _rightTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__rightTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__rightTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x000472A0 File Offset: 0x000454A0
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x0000542B File Offset: 0x0000362B
		public unsafe GizmoCap2D _topTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__topTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__topTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x000472D0 File Offset: 0x000454D0
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x0000544A File Offset: 0x0000364A
		public unsafe GizmoCap2D _backTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__backTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__backTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00047300 File Offset: 0x00045500
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x00005469 File Offset: 0x00003669
		public unsafe GizmoCap2D _leftTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__leftTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__leftTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00047330 File Offset: 0x00045530
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x00005488 File Offset: 0x00003688
		public unsafe GizmoCap2D _bottomTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__bottomTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__bottomTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00047360 File Offset: 0x00045560
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x000054A7 File Offset: 0x000036A7
		public unsafe GizmoCap2D _frontTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__frontTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__frontTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00047390 File Offset: 0x00045590
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x000054C6 File Offset: 0x000036C6
		public unsafe GizmoCap2DCollection _ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__ticks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__ticks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x000473C0 File Offset: 0x000455C0
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x000054E5 File Offset: 0x000036E5
		public unsafe bool _scaleFromCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__scaleFromCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__scaleFromCenter)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x000473E8 File Offset: 0x000455E8
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x00005500 File Offset: 0x00003700
		public unsafe Vector3 _scalePivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__scalePivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__scalePivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00047418 File Offset: 0x00045618
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0000551F File Offset: 0x0000371F
		public unsafe GizmoSglAxisScaleDrag3D.WorkData _scaleDragWorkData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__scaleDragWorkData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__scaleDragWorkData)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00047440 File Offset: 0x00045640
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0000553A File Offset: 0x0000373A
		public unsafe GizmoSglAxisScaleDrag3D _scaleDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__scaleDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSglAxisScaleDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__scaleDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00047470 File Offset: 0x00045670
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00005559 File Offset: 0x00003759
		public unsafe BoxGizmoSettings3D _settings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__settings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__settings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x000474A0 File Offset: 0x000456A0
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00005578 File Offset: 0x00003778
		public unsafe BoxGizmoSettings3D _sharedSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__sharedSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__sharedSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000474D0 File Offset: 0x000456D0
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00005597 File Offset: 0x00003797
		public unsafe BoxGizmoLookAndFeel3D _lookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__lookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__lookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00047500 File Offset: 0x00045700
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x000055B6 File Offset: 0x000037B6
		public unsafe BoxGizmoLookAndFeel3D _sharedLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00047530 File Offset: 0x00045730
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x000055D5 File Offset: 0x000037D5
		public unsafe BoxGizmoHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00047560 File Offset: 0x00045760
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x000055F4 File Offset: 0x000037F4
		public unsafe BoxGizmoHotkeys _sharedHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__sharedHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmo.NativeFieldInfoPtr__sharedHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr__usage;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr__isUsagePermanent;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr__boxSize;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr__targetHierarchy;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr__targetHierarchyTransform;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr__dragBeginTargetTransformSnapshot;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr__rightTick;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr__topTick;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr__backTick;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr__leftTick;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr__bottomTick;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr__frontTick;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr__ticks;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr__scaleFromCenter;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr__scalePivot;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragWorkData;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr__scaleDrag;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr__settings3D;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings3D;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel3D;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel3D;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr__sharedHotkeys;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings3D_Public_get_BoxGizmoSettings3D_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings3D_Public_get_BoxGizmoSettings3D_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_BoxGizmoSettings3D_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_BoxGizmoLookAndFeel3D_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_BoxGizmoLookAndFeel3D_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_BoxGizmoLookAndFeel3D_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_BoxGizmoHotkeys_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedHotkeys_Public_get_BoxGizmoHotkeys_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_BoxGizmoHotkeys_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxUsage_Public_get_Usage_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUsagePermanent_Public_get_Boolean_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxCenter_Public_get_Vector3_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxRotation_Public_get_Quaternion_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxRight_Public_get_Vector3_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxUp_Public_get_Vector3_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxLook_Public_get_Vector3_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_MakeUsagePermanent_Public_Void_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_IsXTick_Public_Boolean_Int32_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_IsYTick_Public_Boolean_Int32_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_IsZTick_Public_Boolean_Int32_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Vector3_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_SetUsage_Public_Void_Usage_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetHierarchy_Public_Boolean_GameObject_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_FitBoxToTargetHierarchy_Public_Boolean_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoCanBeginDrag_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_OnUndoRedoEnd_Private_Void_IUndoRedoAction_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTickPositions_Private_Void_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_ValidateBoxSize_Private_Void_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_CalcTargetRootOBB_Private_OBB_GameObject_0;

		// Token: 0x0200036A RID: 874
		public enum Usage
		{
			// Token: 0x04003961 RID: 14689
			Generic,
			// Token: 0x04003962 RID: 14690
			ObjectScale
		}
	}
}
