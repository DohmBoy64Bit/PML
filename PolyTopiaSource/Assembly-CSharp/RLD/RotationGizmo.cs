using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E2 RID: 226
	[Serializable]
	public class RotationGizmo : GizmoBehaviour
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x0006AAA4 File Offset: 0x00068CA4
		// Note: this type is marked as 'beforefieldinit'.
		static RotationGizmo()
		{
			Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RotationGizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr);
			RotationGizmo.NativeFieldInfoPtr__xSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_xSlider");
			RotationGizmo.NativeFieldInfoPtr__ySlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_ySlider");
			RotationGizmo.NativeFieldInfoPtr__zSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_zSlider");
			RotationGizmo.NativeFieldInfoPtr__axesSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_axesSliders");
			RotationGizmo.NativeFieldInfoPtr__midCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_midCap");
			RotationGizmo.NativeFieldInfoPtr__camXYRotationDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_camXYRotationDrag");
			RotationGizmo.NativeFieldInfoPtr__camLookSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_camLookSlider");
			RotationGizmo.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_hotkeys");
			RotationGizmo.NativeFieldInfoPtr__settings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_settings3D");
			RotationGizmo.NativeFieldInfoPtr__lookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_lookAndFeel3D");
			RotationGizmo.NativeFieldInfoPtr__useSnapEnableHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_useSnapEnableHotkey");
			RotationGizmo.NativeFieldInfoPtr__sharedHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_sharedHotkeys");
			RotationGizmo.NativeFieldInfoPtr__sharedSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_sharedSettings3D");
			RotationGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, "_sharedLookAndFeel3D");
			RotationGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_RotationGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666019);
			RotationGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_RotationGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666020);
			RotationGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_RotationGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666021);
			RotationGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_RotationGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666022);
			RotationGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_RotationGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666023);
			RotationGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_RotationGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666024);
			RotationGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_RotationGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666025);
			RotationGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_RotationGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666026);
			RotationGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_RotationGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666027);
			RotationGizmo.NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666028);
			RotationGizmo.NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666029);
			RotationGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666047);
			RotationGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666030);
			RotationGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666031);
			RotationGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666032);
			RotationGizmo.NativeMethodInfoPtr_SetMidCapHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666033);
			RotationGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666034);
			RotationGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666035);
			RotationGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666036);
			RotationGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666037);
			RotationGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666038);
			RotationGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666039);
			RotationGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666040);
			RotationGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666041);
			RotationGizmo.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666042);
			RotationGizmo.NativeMethodInfoPtr_UpdateCamLookSlider_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666043);
			RotationGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666044);
			RotationGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666045);
			RotationGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr, 100666046);
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x0006AE30 File Offset: 0x00069030
		public unsafe RotationGizmoSettings3D Settings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_RotationGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0006AE70 File Offset: 0x00069070
		public unsafe RotationGizmoLookAndFeel3D LookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_RotationGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0006AEB0 File Offset: 0x000690B0
		public unsafe RotationGizmoHotkeys Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_RotationGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x0006AEF0 File Offset: 0x000690F0
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x0006AF30 File Offset: 0x00069130
		public unsafe RotationGizmoSettings3D SharedSettings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_RotationGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmoSettings3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71206, RefRangeEnd = 71207, XrefRangeStart = 71204, XrefRangeEnd = 71206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_RotationGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0006AF74 File Offset: 0x00069174
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x0006AFB4 File Offset: 0x000691B4
		public unsafe RotationGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_RotationGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmoLookAndFeel3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71209, RefRangeEnd = 71210, XrefRangeStart = 71207, XrefRangeEnd = 71209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_RotationGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0006AFF8 File Offset: 0x000691F8
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x0006B038 File Offset: 0x00069238
		public unsafe RotationGizmoHotkeys SharedHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_RotationGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmoHotkeys>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_RotationGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0006B07C File Offset: 0x0006927C
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x0006B0B8 File Offset: 0x000692B8
		public unsafe bool UseSnapEnableHotkey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0006B0F8 File Offset: 0x000692F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71236, RefRangeEnd = 71238, XrefRangeStart = 71210, XrefRangeEnd = 71236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotationGizmo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotationGizmo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0006B134 File Offset: 0x00069334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71238, XrefRangeEnd = 71244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0006B184 File Offset: 0x00069384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71244, XrefRangeEnd = 71249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0006B1E4 File Offset: 0x000693E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71249, XrefRangeEnd = 71250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OwnsHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0006B230 File Offset: 0x00069430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71250, XrefRangeEnd = 71252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMidCapHoverable(bool hoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_SetMidCapHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0006B270 File Offset: 0x00069470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71252, XrefRangeEnd = 71254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0006B2B0 File Offset: 0x000694B0
		[CallerCount(0)]
		public unsafe override void OnGizmoEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RotationGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0006B2EC File Offset: 0x000694EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71254, XrefRangeEnd = 71262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDetached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RotationGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0006B328 File Offset: 0x00069528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71262, XrefRangeEnd = 71270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RotationGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0006B364 File Offset: 0x00069564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71270, XrefRangeEnd = 71278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RotationGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0006B3A0 File Offset: 0x000695A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71278, XrefRangeEnd = 71324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RotationGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0006B3DC File Offset: 0x000695DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71324, XrefRangeEnd = 71338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoUpdateBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RotationGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0006B418 File Offset: 0x00069618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71338, XrefRangeEnd = 71349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoRender(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RotationGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0006B468 File Offset: 0x00069668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71349, XrefRangeEnd = 71362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RotationGizmo.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0006B4B4 File Offset: 0x000696B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 71365, RefRangeEnd = 71368, XrefRangeStart = 71362, XrefRangeEnd = 71365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCamLookSlider(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_UpdateCamLookSlider_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0006B4F8 File Offset: 0x000696F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71374, RefRangeEnd = 71376, XrefRangeStart = 71368, XrefRangeEnd = 71374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedLookAndFeel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0006B52C File Offset: 0x0006972C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71381, RefRangeEnd = 71383, XrefRangeStart = 71376, XrefRangeEnd = 71381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0006B560 File Offset: 0x00069760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71383, XrefRangeEnd = 71385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotationGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000095A6 File Offset: 0x000077A6
		public RotationGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0006B5B0 File Offset: 0x000697B0
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x000095AF File Offset: 0x000077AF
		public unsafe GizmoPlaneSlider3D _xSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__xSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__xSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0006B5E0 File Offset: 0x000697E0
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x000095CE File Offset: 0x000077CE
		public unsafe GizmoPlaneSlider3D _ySlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__ySlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__ySlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0006B610 File Offset: 0x00069810
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x000095ED File Offset: 0x000077ED
		public unsafe GizmoPlaneSlider3D _zSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__zSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__zSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0006B640 File Offset: 0x00069840
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x0000960C File Offset: 0x0000780C
		public unsafe GizmoPlaneSlider3DCollection _axesSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__axesSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__axesSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0006B670 File Offset: 0x00069870
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x0000962B File Offset: 0x0000782B
		public unsafe GizmoCap3D _midCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__midCap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__midCap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0006B6A0 File Offset: 0x000698A0
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x0000964A File Offset: 0x0000784A
		public unsafe GizmoDblAxisRotationDrag3D _camXYRotationDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__camXYRotationDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDblAxisRotationDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__camXYRotationDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0006B6D0 File Offset: 0x000698D0
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x00009669 File Offset: 0x00007869
		public unsafe GizmoPlaneSlider2D _camLookSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__camLookSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__camLookSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0006B700 File Offset: 0x00069900
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x00009688 File Offset: 0x00007888
		public unsafe RotationGizmoHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0006B730 File Offset: 0x00069930
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x000096A7 File Offset: 0x000078A7
		public unsafe RotationGizmoSettings3D _settings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__settings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__settings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x0006B760 File Offset: 0x00069960
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x000096C6 File Offset: 0x000078C6
		public unsafe RotationGizmoLookAndFeel3D _lookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__lookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__lookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0006B790 File Offset: 0x00069990
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x000096E5 File Offset: 0x000078E5
		public unsafe bool _useSnapEnableHotkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__useSnapEnableHotkey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__useSnapEnableHotkey)) = value;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0006B7B8 File Offset: 0x000699B8
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x00009700 File Offset: 0x00007900
		public unsafe RotationGizmoHotkeys _sharedHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__sharedHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__sharedHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x0006B7E8 File Offset: 0x000699E8
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x0000971F File Offset: 0x0000791F
		public unsafe RotationGizmoSettings3D _sharedSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__sharedSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__sharedSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x0006B818 File Offset: 0x00069A18
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x0000973E File Offset: 0x0000793E
		public unsafe RotationGizmoLookAndFeel3D _sharedLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotationGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeFieldInfoPtr__xSlider;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeFieldInfoPtr__ySlider;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeFieldInfoPtr__zSlider;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeFieldInfoPtr__axesSliders;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeFieldInfoPtr__midCap;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeFieldInfoPtr__camXYRotationDrag;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeFieldInfoPtr__camLookSlider;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeFieldInfoPtr__settings3D;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel3D;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeFieldInfoPtr__useSnapEnableHotkey;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeFieldInfoPtr__sharedHotkeys;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings3D;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel3D;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings3D_Public_get_RotationGizmoSettings3D_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_RotationGizmoLookAndFeel3D_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_RotationGizmoHotkeys_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings3D_Public_get_RotationGizmoSettings3D_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_RotationGizmoSettings3D_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_RotationGizmoLookAndFeel3D_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_RotationGizmoLookAndFeel3D_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedHotkeys_Public_get_RotationGizmoHotkeys_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_RotationGizmoHotkeys_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_Camera_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapHoverable_Public_Void_Boolean_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCamLookSlider_Private_Void_Camera_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0;
	}
}
