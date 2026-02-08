using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000107 RID: 263
	public class CameraPrjSwitchTransition : global::Il2CppSystem.Object
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x00082AEC File Offset: 0x00080CEC
		// Note: this type is marked as 'beforefieldinit'.
		static CameraPrjSwitchTransition()
		{
			Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraPrjSwitchTransition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr);
			CameraPrjSwitchTransition.NativeFieldInfoPtr_TransitionBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "TransitionBegin");
			CameraPrjSwitchTransition.NativeFieldInfoPtr_TransitionUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "TransitionUpdate");
			CameraPrjSwitchTransition.NativeFieldInfoPtr_TransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "TransitionEnd");
			CameraPrjSwitchTransition.NativeFieldInfoPtr__transitionCrtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "_transitionCrtn");
			CameraPrjSwitchTransition.NativeFieldInfoPtr__targetMono = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "_targetMono");
			CameraPrjSwitchTransition.NativeFieldInfoPtr__targetCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "_targetCamera");
			CameraPrjSwitchTransition.NativeFieldInfoPtr__camFieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "_camFieldOfView");
			CameraPrjSwitchTransition.NativeFieldInfoPtr__camFocusPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "_camFocusPoint");
			CameraPrjSwitchTransition.NativeFieldInfoPtr__camRestorePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "_camRestorePosition");
			CameraPrjSwitchTransition.NativeFieldInfoPtr__transitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "_transitionType");
			CameraPrjSwitchTransition.NativeFieldInfoPtr__durationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "_durationInSeconds");
			CameraPrjSwitchTransition.NativeFieldInfoPtr__progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "_progress");
			CameraPrjSwitchTransition.NativeMethodInfoPtr_get_TargetMono_Public_get_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666984);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_set_TargetMono_Public_set_Void_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666985);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_get_TargetCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666986);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_set_TargetCamera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666987);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_get_TransitionType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666988);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_get_DurationInSeconds_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666989);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_set_DurationInSeconds_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666990);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_get_Progress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666991);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_get_CamFieldOfView_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666992);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_set_CamFieldOfView_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666993);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_get_CamFocusPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666994);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_set_CamFocusPoint_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666995);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666996);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_add_TransitionBegin_Public_add_Void_CameraProjectionSwitchBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666978);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_remove_TransitionBegin_Public_rem_Void_CameraProjectionSwitchBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666979);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_add_TransitionUpdate_Public_add_Void_CameraProjectionSwitchUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666980);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_remove_TransitionUpdate_Public_rem_Void_CameraProjectionSwitchUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666981);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_add_TransitionEnd_Public_add_Void_CameraProjectionSwitchBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666982);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_remove_TransitionEnd_Public_rem_Void_CameraProjectionSwitchBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666983);
			CameraPrjSwitchTransition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666999);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666997);
			CameraPrjSwitchTransition.NativeMethodInfoPtr_DoTransition_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, 100666998);
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x00082DC4 File Offset: 0x00080FC4
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x00082E04 File Offset: 0x00081004
		public unsafe MonoBehaviour TargetMono
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_get_TargetMono_Public_get_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74566, XrefRangeEnd = 74571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_set_TargetMono_Public_set_Void_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00082E48 File Offset: 0x00081048
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x00082E88 File Offset: 0x00081088
		public unsafe Camera TargetCamera
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_get_TargetCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74571, XrefRangeEnd = 74576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_set_TargetCamera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00082ECC File Offset: 0x000810CC
		public unsafe CameraPrjSwitchTransition.Type TransitionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_get_TransitionType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x00082F08 File Offset: 0x00081108
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x00082F44 File Offset: 0x00081144
		public unsafe float DurationInSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_get_DurationInSeconds_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_set_DurationInSeconds_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x00082F84 File Offset: 0x00081184
		public unsafe float Progress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_get_Progress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00082FC0 File Offset: 0x000811C0
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x00082FFC File Offset: 0x000811FC
		public unsafe float CamFieldOfView
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57846, RefRangeEnd = 57847, XrefRangeStart = 57846, XrefRangeEnd = 57847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_get_CamFieldOfView_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_set_CamFieldOfView_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0008303C File Offset: 0x0008123C
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0008307C File Offset: 0x0008127C
		public unsafe Vector3 CamFocusPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_get_CamFocusPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_set_CamFocusPoint_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x000830C0 File Offset: 0x000812C0
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000830FC File Offset: 0x000812FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74576, XrefRangeEnd = 74580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TransitionBegin(CameraProjectionSwitchBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_add_TransitionBegin_Public_add_Void_CameraProjectionSwitchBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00083140 File Offset: 0x00081340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74580, XrefRangeEnd = 74584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TransitionBegin(CameraProjectionSwitchBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_remove_TransitionBegin_Public_rem_Void_CameraProjectionSwitchBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00083184 File Offset: 0x00081384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74584, XrefRangeEnd = 74588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TransitionUpdate(CameraProjectionSwitchUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_add_TransitionUpdate_Public_add_Void_CameraProjectionSwitchUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000831C8 File Offset: 0x000813C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74588, XrefRangeEnd = 74592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TransitionUpdate(CameraProjectionSwitchUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_remove_TransitionUpdate_Public_rem_Void_CameraProjectionSwitchUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0008320C File Offset: 0x0008140C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74592, XrefRangeEnd = 74596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TransitionEnd(CameraProjectionSwitchBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_add_TransitionEnd_Public_add_Void_CameraProjectionSwitchBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00083250 File Offset: 0x00081450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74596, XrefRangeEnd = 74600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TransitionEnd(CameraProjectionSwitchBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_remove_TransitionEnd_Public_rem_Void_CameraProjectionSwitchBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00083294 File Offset: 0x00081494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74600, XrefRangeEnd = 74601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraPrjSwitchTransition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000832D0 File Offset: 0x000814D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74601, XrefRangeEnd = 74619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00083304 File Offset: 0x00081504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74619, XrefRangeEnd = 74624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoTransition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition.NativeMethodInfoPtr_DoTransition_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0000B078 File Offset: 0x00009278
		public CameraPrjSwitchTransition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x00083344 File Offset: 0x00081544
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x0000B081 File Offset: 0x00009281
		public unsafe CameraProjectionSwitchBeginHandler TransitionBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr_TransitionBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr_TransitionBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x00083374 File Offset: 0x00081574
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x0000B0A0 File Offset: 0x000092A0
		public unsafe CameraProjectionSwitchUpdateHandler TransitionUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr_TransitionUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr_TransitionUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x000833A4 File Offset: 0x000815A4
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x0000B0BF File Offset: 0x000092BF
		public unsafe CameraProjectionSwitchBeginHandler TransitionEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr_TransitionEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr_TransitionEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x000833D4 File Offset: 0x000815D4
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0000B0DE File Offset: 0x000092DE
		public unsafe IEnumerator _transitionCrtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__transitionCrtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__transitionCrtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00083404 File Offset: 0x00081604
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0000B0FD File Offset: 0x000092FD
		public unsafe MonoBehaviour _targetMono
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__targetMono);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__targetMono), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x00083434 File Offset: 0x00081634
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x0000B11C File Offset: 0x0000931C
		public unsafe Camera _targetCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__targetCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__targetCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x00083464 File Offset: 0x00081664
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x0000B13B File Offset: 0x0000933B
		public unsafe float _camFieldOfView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__camFieldOfView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__camFieldOfView)) = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0008348C File Offset: 0x0008168C
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0000B156 File Offset: 0x00009356
		public unsafe Vector3 _camFocusPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__camFocusPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__camFocusPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000834BC File Offset: 0x000816BC
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0000B175 File Offset: 0x00009375
		public unsafe Vector3 _camRestorePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__camRestorePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__camRestorePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000834EC File Offset: 0x000816EC
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000B194 File Offset: 0x00009394
		public unsafe CameraPrjSwitchTransition.Type _transitionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__transitionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__transitionType)) = value;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00083514 File Offset: 0x00081714
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0000B1AF File Offset: 0x000093AF
		public unsafe float _durationInSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__durationInSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__durationInSeconds)) = value;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0008353C File Offset: 0x0008173C
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0000B1CA File Offset: 0x000093CA
		public unsafe float _progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition.NativeFieldInfoPtr__progress)) = value;
			}
		}

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_TransitionBegin;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_TransitionUpdate;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_TransitionEnd;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr__transitionCrtn;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr__targetMono;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr__targetCamera;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeFieldInfoPtr__camFieldOfView;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr__camFocusPoint;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr__camRestorePosition;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr__transitionType;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr__durationInSeconds;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr__progress;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetMono_Public_get_MonoBehaviour_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetMono_Public_set_Void_MonoBehaviour_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetCamera_Public_get_Camera_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetCamera_Public_set_Void_Camera_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_get_TransitionType_Public_get_Type_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_get_DurationInSeconds_Public_get_Single_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_set_DurationInSeconds_Public_set_Void_Single_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Public_get_Single_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_get_CamFieldOfView_Public_get_Single_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_set_CamFieldOfView_Public_set_Void_Single_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_get_CamFocusPoint_Public_get_Vector3_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_set_CamFocusPoint_Public_set_Void_Vector3_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_add_TransitionBegin_Public_add_Void_CameraProjectionSwitchBeginHandler_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_remove_TransitionBegin_Public_rem_Void_CameraProjectionSwitchBeginHandler_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_add_TransitionUpdate_Public_add_Void_CameraProjectionSwitchUpdateHandler_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_remove_TransitionUpdate_Public_rem_Void_CameraProjectionSwitchUpdateHandler_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_add_TransitionEnd_Public_add_Void_CameraProjectionSwitchBeginHandler_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_remove_TransitionEnd_Public_rem_Void_CameraProjectionSwitchBeginHandler_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_DoTransition_Private_IEnumerator_0;

		// Token: 0x0200037A RID: 890
		public enum Type
		{
			// Token: 0x040039A7 RID: 14759
			None,
			// Token: 0x040039A8 RID: 14760
			ToOrtho,
			// Token: 0x040039A9 RID: 14761
			ToPerspective
		}

		// Token: 0x0200037B RID: 891
		[ObfuscatedName("RLD.CameraPrjSwitchTransition+<DoTransition>d__41")]
		public sealed class _DoTransition_d__41 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A35 RID: 18997 RVA: 0x00146F64 File Offset: 0x00145164
			// Note: this type is marked as 'beforefieldinit'.
			static _DoTransition_d__41()
			{
				Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraPrjSwitchTransition>.NativeClassPtr, "<DoTransition>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr);
				CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, "<>1__state");
				CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, "<>2__current");
				CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, "<>4__this");
				CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__frustumHeight_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, "<frustumHeight>5__2");
				CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__targetFOV_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, "<targetFOV>5__3");
				CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__invDuration_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, "<invDuration>5__4");
				CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__fovSpeed_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, "<fovSpeed>5__5");
				CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___targetTransform_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, "<_targetTransform>5__6");
				CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, 100667003);
				CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, 100667005);
				CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, 100667000);
				CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, 100667001);
				CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, 100667002);
				CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr, 100667004);
			}

			// Token: 0x17001921 RID: 6433
			// (get) Token: 0x06004A36 RID: 18998 RVA: 0x001470A8 File Offset: 0x001452A8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001922 RID: 6434
			// (get) Token: 0x06004A37 RID: 18999 RVA: 0x001470E8 File Offset: 0x001452E8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A38 RID: 19000 RVA: 0x00147128 File Offset: 0x00145328
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoTransition_d__41(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraPrjSwitchTransition._DoTransition_d__41>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A39 RID: 19001 RVA: 0x00147170 File Offset: 0x00145370
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A3A RID: 19002 RVA: 0x001471A4 File Offset: 0x001453A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74523, XrefRangeEnd = 74561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A3B RID: 19003 RVA: 0x001471E0 File Offset: 0x001453E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74561, XrefRangeEnd = 74566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraPrjSwitchTransition._DoTransition_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A3C RID: 19004 RVA: 0x0001BA29 File Offset: 0x00019C29
			public _DoTransition_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001919 RID: 6425
			// (get) Token: 0x06004A3D RID: 19005 RVA: 0x00147214 File Offset: 0x00145414
			// (set) Token: 0x06004A3E RID: 19006 RVA: 0x0001BA32 File Offset: 0x00019C32
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700191A RID: 6426
			// (get) Token: 0x06004A3F RID: 19007 RVA: 0x0014723C File Offset: 0x0014543C
			// (set) Token: 0x06004A40 RID: 19008 RVA: 0x0001BA4D File Offset: 0x00019C4D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700191B RID: 6427
			// (get) Token: 0x06004A41 RID: 19009 RVA: 0x0014726C File Offset: 0x0014546C
			// (set) Token: 0x06004A42 RID: 19010 RVA: 0x0001BA6C File Offset: 0x00019C6C
			public unsafe CameraPrjSwitchTransition __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraPrjSwitchTransition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700191C RID: 6428
			// (get) Token: 0x06004A43 RID: 19011 RVA: 0x0014729C File Offset: 0x0014549C
			// (set) Token: 0x06004A44 RID: 19012 RVA: 0x0001BA8B File Offset: 0x00019C8B
			public unsafe float _frustumHeight_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__frustumHeight_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__frustumHeight_5__2)) = value;
				}
			}

			// Token: 0x1700191D RID: 6429
			// (get) Token: 0x06004A45 RID: 19013 RVA: 0x001472C4 File Offset: 0x001454C4
			// (set) Token: 0x06004A46 RID: 19014 RVA: 0x0001BAA6 File Offset: 0x00019CA6
			public unsafe float _targetFOV_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__targetFOV_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__targetFOV_5__3)) = value;
				}
			}

			// Token: 0x1700191E RID: 6430
			// (get) Token: 0x06004A47 RID: 19015 RVA: 0x001472EC File Offset: 0x001454EC
			// (set) Token: 0x06004A48 RID: 19016 RVA: 0x0001BAC1 File Offset: 0x00019CC1
			public unsafe float _invDuration_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__invDuration_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__invDuration_5__4)) = value;
				}
			}

			// Token: 0x1700191F RID: 6431
			// (get) Token: 0x06004A49 RID: 19017 RVA: 0x00147314 File Offset: 0x00145514
			// (set) Token: 0x06004A4A RID: 19018 RVA: 0x0001BADC File Offset: 0x00019CDC
			public unsafe float _fovSpeed_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__fovSpeed_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr__fovSpeed_5__5)) = value;
				}
			}

			// Token: 0x17001920 RID: 6432
			// (get) Token: 0x06004A4B RID: 19019 RVA: 0x0014733C File Offset: 0x0014553C
			// (set) Token: 0x06004A4C RID: 19020 RVA: 0x0001BAF7 File Offset: 0x00019CF7
			public unsafe Transform __targetTransform_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___targetTransform_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraPrjSwitchTransition._DoTransition_d__41.NativeFieldInfoPtr___targetTransform_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040039AA RID: 14762
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040039AB RID: 14763
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040039AC RID: 14764
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040039AD RID: 14765
			private static readonly IntPtr NativeFieldInfoPtr__frustumHeight_5__2;

			// Token: 0x040039AE RID: 14766
			private static readonly IntPtr NativeFieldInfoPtr__targetFOV_5__3;

			// Token: 0x040039AF RID: 14767
			private static readonly IntPtr NativeFieldInfoPtr__invDuration_5__4;

			// Token: 0x040039B0 RID: 14768
			private static readonly IntPtr NativeFieldInfoPtr__fovSpeed_5__5;

			// Token: 0x040039B1 RID: 14769
			private static readonly IntPtr NativeFieldInfoPtr___targetTransform_5__6;

			// Token: 0x040039B2 RID: 14770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039B3 RID: 14771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039B4 RID: 14772
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040039B5 RID: 14773
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040039B6 RID: 14774
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040039B7 RID: 14775
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
