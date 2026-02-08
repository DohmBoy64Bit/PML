using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001CC RID: 460
	public class DeviceObjectGrabSession : global::Il2CppSystem.Object
	{
		// Token: 0x06002381 RID: 9089 RVA: 0x000AD930 File Offset: 0x000ABB30
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceObjectGrabSession()
		{
			Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "DeviceObjectGrabSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr);
			DeviceObjectGrabSession.NativeFieldInfoPtr_SessionBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "SessionBegin");
			DeviceObjectGrabSession.NativeFieldInfoPtr_SessionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "SessionEnd");
			DeviceObjectGrabSession.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_state");
			DeviceObjectGrabSession.NativeFieldInfoPtr__sharedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_sharedSettings");
			DeviceObjectGrabSession.NativeFieldInfoPtr__sharedHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_sharedHotkeys");
			DeviceObjectGrabSession.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_sharedLookAndFeel");
			DeviceObjectGrabSession.NativeFieldInfoPtr__targetParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_targetParents");
			DeviceObjectGrabSession.NativeFieldInfoPtr__grabTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_grabTargets");
			DeviceObjectGrabSession.NativeFieldInfoPtr__grabSurfaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_grabSurfaceInfo");
			DeviceObjectGrabSession.NativeFieldInfoPtr__deltaCaptureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_deltaCaptureId");
			DeviceObjectGrabSession.NativeFieldInfoPtr__possibleAlignmentAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_possibleAlignmentAxes");
			DeviceObjectGrabSession.NativeFieldInfoPtr__preTargetTransformSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "_preTargetTransformSnapshots");
			DeviceObjectGrabSession.NativeMethodInfoPtr_get_SharedSettings_Public_get_ObjectGrabSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668628);
			DeviceObjectGrabSession.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_ObjectGrabSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668629);
			DeviceObjectGrabSession.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ObjectGrabHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668630);
			DeviceObjectGrabSession.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ObjectGrabHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668631);
			DeviceObjectGrabSession.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_ObjectGrabLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668632);
			DeviceObjectGrabSession.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_ObjectGrabLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668633);
			DeviceObjectGrabSession.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668634);
			DeviceObjectGrabSession.NativeMethodInfoPtr_add_SessionBegin_Public_add_Void_ObjectGrabSessionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668624);
			DeviceObjectGrabSession.NativeMethodInfoPtr_remove_SessionBegin_Public_rem_Void_ObjectGrabSessionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668625);
			DeviceObjectGrabSession.NativeMethodInfoPtr_add_SessionEnd_Public_add_Void_ObjectGrabSessionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668626);
			DeviceObjectGrabSession.NativeMethodInfoPtr_remove_SessionEnd_Public_rem_Void_ObjectGrabSessionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668627);
			DeviceObjectGrabSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668652);
			DeviceObjectGrabSession.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668635);
			DeviceObjectGrabSession.NativeMethodInfoPtr_Update_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668636);
			DeviceObjectGrabSession.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668637);
			DeviceObjectGrabSession.NativeMethodInfoPtr_Begin_Private_Boolean_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668638);
			DeviceObjectGrabSession.NativeMethodInfoPtr_SnapTargetsToSurface_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668639);
			DeviceObjectGrabSession.NativeMethodInfoPtr_RotateTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668640);
			DeviceObjectGrabSession.NativeMethodInfoPtr_RotateTargetsAroundAnchor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668641);
			DeviceObjectGrabSession.NativeMethodInfoPtr_ScaleTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668642);
			DeviceObjectGrabSession.NativeMethodInfoPtr_OffsetTargetsFromSurface_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668643);
			DeviceObjectGrabSession.NativeMethodInfoPtr_OffsetTargetsFromAnchor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668644);
			DeviceObjectGrabSession.NativeMethodInfoPtr_IdentifyGrabTargets_Private_Boolean_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668645);
			DeviceObjectGrabSession.NativeMethodInfoPtr_CalculateGrabTargetsAnchorVectors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668646);
			DeviceObjectGrabSession.NativeMethodInfoPtr_StoreGrabTargetsWorldScaleSnapshots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668647);
			DeviceObjectGrabSession.NativeMethodInfoPtr_StoreGrabTargetsAnchorVectorSnapshots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668648);
			DeviceObjectGrabSession.NativeMethodInfoPtr_IdentifyGrabSurface_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668649);
			DeviceObjectGrabSession.NativeMethodInfoPtr_SwitchToNextAlignmentAxis_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668650);
			DeviceObjectGrabSession.NativeMethodInfoPtr_GetObjectBoundsQConfig_Private_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, 100668651);
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x000ADC94 File Offset: 0x000ABE94
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x000ADCD4 File Offset: 0x000ABED4
		public unsafe ObjectGrabSettings SharedSettings
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_get_SharedSettings_Public_get_ObjectGrabSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGrabSettings>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87851, RefRangeEnd = 87852, XrefRangeStart = 87850, XrefRangeEnd = 87851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_ObjectGrabSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000ADD18 File Offset: 0x000ABF18
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x000ADD58 File Offset: 0x000ABF58
		public unsafe ObjectGrabHotkeys SharedHotkeys
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ObjectGrabHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGrabHotkeys>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87853, RefRangeEnd = 87854, XrefRangeStart = 87852, XrefRangeEnd = 87853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ObjectGrabHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000ADD9C File Offset: 0x000ABF9C
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x000ADDDC File Offset: 0x000ABFDC
		public unsafe ObjectGrabLookAndFeel SharedLookAndFeel
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_ObjectGrabLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGrabLookAndFeel>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84493, RefRangeEnd = 84495, XrefRangeStart = 84493, XrefRangeEnd = 84495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_ObjectGrabLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x000ADE20 File Offset: 0x000AC020
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x000ADE5C File Offset: 0x000AC05C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87858, RefRangeEnd = 87859, XrefRangeStart = 87854, XrefRangeEnd = 87858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SessionBegin(ObjectGrabSessionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_add_SessionBegin_Public_add_Void_ObjectGrabSessionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x000ADEA0 File Offset: 0x000AC0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87859, XrefRangeEnd = 87863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SessionBegin(ObjectGrabSessionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_remove_SessionBegin_Public_rem_Void_ObjectGrabSessionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x000ADEE4 File Offset: 0x000AC0E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87867, RefRangeEnd = 87868, XrefRangeStart = 87863, XrefRangeEnd = 87867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SessionEnd(ObjectGrabSessionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_add_SessionEnd_Public_add_Void_ObjectGrabSessionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x000ADF28 File Offset: 0x000AC128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87868, XrefRangeEnd = 87872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SessionEnd(ObjectGrabSessionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_remove_SessionEnd_Public_rem_Void_ObjectGrabSessionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x000ADF6C File Offset: 0x000AC16C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87894, RefRangeEnd = 87895, XrefRangeStart = 87872, XrefRangeEnd = 87894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceObjectGrabSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x000ADFA8 File Offset: 0x000AC1A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87988, RefRangeEnd = 87989, XrefRangeStart = 87895, XrefRangeEnd = 87988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x000ADFEC File Offset: 0x000AC1EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88055, RefRangeEnd = 88056, XrefRangeStart = 87989, XrefRangeEnd = 88055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_Update_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x000AE030 File Offset: 0x000AC230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88066, RefRangeEnd = 88068, XrefRangeStart = 88056, XrefRangeEnd = 88066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x000AE064 File Offset: 0x000AC264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88068, XrefRangeEnd = 88076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Begin(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_Begin_Private_Boolean_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x000AE0B4 File Offset: 0x000AC2B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 88103, RefRangeEnd = 88108, XrefRangeStart = 88076, XrefRangeEnd = 88103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SnapTargetsToSurface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_SnapTargetsToSurface_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x000AE0E8 File Offset: 0x000AC2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88108, XrefRangeEnd = 88146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_RotateTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x000AE11C File Offset: 0x000AC31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88146, XrefRangeEnd = 88192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateTargetsAroundAnchor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_RotateTargetsAroundAnchor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x000AE150 File Offset: 0x000AC350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88192, XrefRangeEnd = 88222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScaleTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_ScaleTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x000AE184 File Offset: 0x000AC384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88261, RefRangeEnd = 88262, XrefRangeStart = 88222, XrefRangeEnd = 88261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OffsetTargetsFromSurface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_OffsetTargetsFromSurface_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x000AE1B8 File Offset: 0x000AC3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88262, XrefRangeEnd = 88290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OffsetTargetsFromAnchor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_OffsetTargetsFromAnchor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x000AE1EC File Offset: 0x000AC3EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88324, RefRangeEnd = 88326, XrefRangeStart = 88290, XrefRangeEnd = 88324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IdentifyGrabTargets(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_IdentifyGrabTargets_Private_Boolean_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x000AE23C File Offset: 0x000AC43C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 88341, RefRangeEnd = 88351, XrefRangeStart = 88326, XrefRangeEnd = 88341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateGrabTargetsAnchorVectors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_CalculateGrabTargetsAnchorVectors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x000AE270 File Offset: 0x000AC470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88366, RefRangeEnd = 88367, XrefRangeStart = 88351, XrefRangeEnd = 88366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreGrabTargetsWorldScaleSnapshots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_StoreGrabTargetsWorldScaleSnapshots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x000AE2A4 File Offset: 0x000AC4A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88381, RefRangeEnd = 88382, XrefRangeStart = 88367, XrefRangeEnd = 88381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreGrabTargetsAnchorVectorSnapshots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_StoreGrabTargetsAnchorVectorSnapshots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x000AE2D8 File Offset: 0x000AC4D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88436, RefRangeEnd = 88439, XrefRangeStart = 88382, XrefRangeEnd = 88436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IdentifyGrabSurface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_IdentifyGrabSurface_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x000AE314 File Offset: 0x000AC514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88463, RefRangeEnd = 88464, XrefRangeStart = 88439, XrefRangeEnd = 88463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchToNextAlignmentAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_SwitchToNextAlignmentAxis_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x000AE348 File Offset: 0x000AC548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88464, XrefRangeEnd = 88466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectBounds.QueryConfig GetObjectBoundsQConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.NativeMethodInfoPtr_GetObjectBoundsQConfig_Private_QueryConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		public DeviceObjectGrabSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x000AE384 File Offset: 0x000AC584
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x0000E8C1 File Offset: 0x0000CAC1
		public unsafe ObjectGrabSessionBeginHandler SessionBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr_SessionBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGrabSessionBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr_SessionBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x000AE3B4 File Offset: 0x000AC5B4
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		public unsafe ObjectGrabSessionEndHandler SessionEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr_SessionEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGrabSessionEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr_SessionEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x000AE3E4 File Offset: 0x000AC5E4
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x0000E8FF File Offset: 0x0000CAFF
		public unsafe DeviceObjectGrabSession.State _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x000AE40C File Offset: 0x000AC60C
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x0000E91A File Offset: 0x0000CB1A
		public unsafe ObjectGrabSettings _sharedSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__sharedSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGrabSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__sharedSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x000AE43C File Offset: 0x000AC63C
		// (set) Token: 0x060023A9 RID: 9129 RVA: 0x0000E939 File Offset: 0x0000CB39
		public unsafe ObjectGrabHotkeys _sharedHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__sharedHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGrabHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__sharedHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x000AE46C File Offset: 0x000AC66C
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x0000E958 File Offset: 0x0000CB58
		public unsafe ObjectGrabLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGrabLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x000AE49C File Offset: 0x000AC69C
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x0000E977 File Offset: 0x0000CB77
		public unsafe List<GameObject> _targetParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__targetParents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__targetParents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x000AE4CC File Offset: 0x000AC6CC
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x0000E996 File Offset: 0x0000CB96
		public unsafe List<DeviceObjectGrabSession.GrabTarget> _grabTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__grabTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeviceObjectGrabSession.GrabTarget>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__grabTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000AE4FC File Offset: 0x000AC6FC
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x0000E9B5 File Offset: 0x0000CBB5
		public DeviceObjectGrabSession.GrabSurfaceInfo _grabSurfaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__grabSurfaceInfo);
				return new DeviceObjectGrabSession.GrabSurfaceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__grabSurfaceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x000AE52C File Offset: 0x000AC72C
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x0000E9E3 File Offset: 0x0000CBE3
		public unsafe int _deltaCaptureId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__deltaCaptureId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__deltaCaptureId)) = value;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000AE554 File Offset: 0x000AC754
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0000E9FE File Offset: 0x0000CBFE
		public unsafe Il2CppStructArray<TransformAxis> _possibleAlignmentAxes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__possibleAlignmentAxes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TransformAxis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__possibleAlignmentAxes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000AE584 File Offset: 0x000AC784
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x0000EA1D File Offset: 0x0000CC1D
		public unsafe List<LocalTransformSnapshot> _preTargetTransformSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__preTargetTransformSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.NativeFieldInfoPtr__preTargetTransformSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeFieldInfoPtr_SessionBegin;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeFieldInfoPtr_SessionEnd;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeFieldInfoPtr__sharedHotkeys;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeFieldInfoPtr__targetParents;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeFieldInfoPtr__grabTargets;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeFieldInfoPtr__grabSurfaceInfo;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeFieldInfoPtr__deltaCaptureId;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeFieldInfoPtr__possibleAlignmentAxes;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeFieldInfoPtr__preTargetTransformSnapshots;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings_Public_get_ObjectGrabSettings_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_ObjectGrabSettings_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ObjectGrabHotkeys_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ObjectGrabHotkeys_0;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_ObjectGrabLookAndFeel_0;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_ObjectGrabLookAndFeel_0;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeMethodInfoPtr_add_SessionBegin_Public_add_Void_ObjectGrabSessionBeginHandler_0;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeMethodInfoPtr_remove_SessionBegin_Public_rem_Void_ObjectGrabSessionBeginHandler_0;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeMethodInfoPtr_add_SessionEnd_Public_add_Void_ObjectGrabSessionEndHandler_0;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr_remove_SessionEnd_Public_rem_Void_ObjectGrabSessionEndHandler_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Private_Boolean_IEnumerable_1_GameObject_0;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeMethodInfoPtr_SnapTargetsToSurface_Private_Void_0;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeMethodInfoPtr_RotateTargets_Private_Void_0;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr_RotateTargetsAroundAnchor_Private_Void_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr_ScaleTargets_Private_Void_0;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeMethodInfoPtr_OffsetTargetsFromSurface_Private_Void_0;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr_OffsetTargetsFromAnchor_Private_Void_0;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeMethodInfoPtr_IdentifyGrabTargets_Private_Boolean_IEnumerable_1_GameObject_0;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_CalculateGrabTargetsAnchorVectors_Private_Void_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_StoreGrabTargetsWorldScaleSnapshots_Private_Void_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_StoreGrabTargetsAnchorVectorSnapshots_Private_Void_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_IdentifyGrabSurface_Private_Boolean_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToNextAlignmentAxis_Private_Void_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectBoundsQConfig_Private_QueryConfig_0;

		// Token: 0x020003AA RID: 938
		public enum State
		{
			// Token: 0x04003AC0 RID: 15040
			Inactive,
			// Token: 0x04003AC1 RID: 15041
			ActiveSnapToSurface,
			// Token: 0x04003AC2 RID: 15042
			ActiveRotate,
			// Token: 0x04003AC3 RID: 15043
			ActiveRotateAroundAnchor,
			// Token: 0x04003AC4 RID: 15044
			ActiveScale,
			// Token: 0x04003AC5 RID: 15045
			ActiveOffsetFromSurface,
			// Token: 0x04003AC6 RID: 15046
			ActiveAnchorAdjust,
			// Token: 0x04003AC7 RID: 15047
			ActiveOffsetFromAnchor
		}

		// Token: 0x020003AB RID: 939
		public enum GrabSurfaceType
		{
			// Token: 0x04003AC9 RID: 15049
			Invalid,
			// Token: 0x04003ACA RID: 15050
			Mesh,
			// Token: 0x04003ACB RID: 15051
			SphericalMesh,
			// Token: 0x04003ACC RID: 15052
			UnityTerrain,
			// Token: 0x04003ACD RID: 15053
			TerrainMesh,
			// Token: 0x04003ACE RID: 15054
			Grid
		}

		// Token: 0x020003AC RID: 940
		public sealed class GrabSurfaceInfo : ValueType
		{
			// Token: 0x06004BC8 RID: 19400 RVA: 0x0014B990 File Offset: 0x00149B90
			// Note: this type is marked as 'beforefieldinit'.
			static GrabSurfaceInfo()
			{
				Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "GrabSurfaceInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr);
				DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_SurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr, "SurfaceType");
				DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_AnchorPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr, "AnchorPoint");
				DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_AnchorNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr, "AnchorNormal");
				DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_AnchorPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr, "AnchorPlane");
				DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_SceneRaycastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr, "SceneRaycastHit");
			}

			// Token: 0x06004BC9 RID: 19401 RVA: 0x0001C603 File Offset: 0x0001A803
			public GrabSurfaceInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004BCA RID: 19402 RVA: 0x0001C60C File Offset: 0x0001A80C
			public GrabSurfaceInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabSurfaceInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17001981 RID: 6529
			// (get) Token: 0x06004BCB RID: 19403 RVA: 0x0014BA20 File Offset: 0x00149C20
			// (set) Token: 0x06004BCC RID: 19404 RVA: 0x0001C61E File Offset: 0x0001A81E
			public unsafe DeviceObjectGrabSession.GrabSurfaceType SurfaceType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_SurfaceType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_SurfaceType)) = value;
				}
			}

			// Token: 0x17001982 RID: 6530
			// (get) Token: 0x06004BCD RID: 19405 RVA: 0x0014BA48 File Offset: 0x00149C48
			// (set) Token: 0x06004BCE RID: 19406 RVA: 0x0001C639 File Offset: 0x0001A839
			public unsafe Vector3 AnchorPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_AnchorPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_AnchorPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001983 RID: 6531
			// (get) Token: 0x06004BCF RID: 19407 RVA: 0x0014BA78 File Offset: 0x00149C78
			// (set) Token: 0x06004BD0 RID: 19408 RVA: 0x0001C658 File Offset: 0x0001A858
			public unsafe Vector3 AnchorNormal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_AnchorNormal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_AnchorNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001984 RID: 6532
			// (get) Token: 0x06004BD1 RID: 19409 RVA: 0x0014BAA8 File Offset: 0x00149CA8
			// (set) Token: 0x06004BD2 RID: 19410 RVA: 0x0001C677 File Offset: 0x0001A877
			public unsafe Plane AnchorPlane
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_AnchorPlane);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_AnchorPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001985 RID: 6533
			// (get) Token: 0x06004BD3 RID: 19411 RVA: 0x0014BAD8 File Offset: 0x00149CD8
			// (set) Token: 0x06004BD4 RID: 19412 RVA: 0x0001C696 File Offset: 0x0001A896
			public unsafe SceneRaycastHit SceneRaycastHit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_SceneRaycastHit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneRaycastHit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabSurfaceInfo.NativeFieldInfoPtr_SceneRaycastHit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003ACF RID: 15055
			private static readonly IntPtr NativeFieldInfoPtr_SurfaceType;

			// Token: 0x04003AD0 RID: 15056
			private static readonly IntPtr NativeFieldInfoPtr_AnchorPoint;

			// Token: 0x04003AD1 RID: 15057
			private static readonly IntPtr NativeFieldInfoPtr_AnchorNormal;

			// Token: 0x04003AD2 RID: 15058
			private static readonly IntPtr NativeFieldInfoPtr_AnchorPlane;

			// Token: 0x04003AD3 RID: 15059
			private static readonly IntPtr NativeFieldInfoPtr_SceneRaycastHit;
		}

		// Token: 0x020003AD RID: 941
		public class GrabTarget : global::Il2CppSystem.Object
		{
			// Token: 0x06004BD5 RID: 19413 RVA: 0x0014BB08 File Offset: 0x00149D08
			// Note: this type is marked as 'beforefieldinit'.
			static GrabTarget()
			{
				Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeviceObjectGrabSession>.NativeClassPtr, "GrabTarget");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr);
				DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr__gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, "_gameObject");
				DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, "_transform");
				DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_AnchorVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, "AnchorVector");
				DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_WorldScaleSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, "WorldScaleSnapshot");
				DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_AnchorVectorSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, "AnchorVectorSnapshot");
				DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_SittingPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, "SittingPlane");
				DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_SittingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, "SittingPoint");
				DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_OffsetFromSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, "OffsetFromSurface");
				DeviceObjectGrabSession.GrabTarget.NativeMethodInfoPtr_get_GameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, 100668653);
				DeviceObjectGrabSession.GrabTarget.NativeMethodInfoPtr_get_Transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, 100668654);
				DeviceObjectGrabSession.GrabTarget.NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr, 100668655);
			}

			// Token: 0x1700198E RID: 6542
			// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x0014BC10 File Offset: 0x00149E10
			public unsafe GameObject GameObject
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.GrabTarget.NativeMethodInfoPtr_get_GameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
				}
			}

			// Token: 0x1700198F RID: 6543
			// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x0014BC50 File Offset: 0x00149E50
			public unsafe Transform Transform
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.GrabTarget.NativeMethodInfoPtr_get_Transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
				}
			}

			// Token: 0x06004BD8 RID: 19416 RVA: 0x0014BC90 File Offset: 0x00149E90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87849, RefRangeEnd = 87850, XrefRangeStart = 87844, XrefRangeEnd = 87849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GrabTarget(GameObject parentObject)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceObjectGrabSession.GrabTarget>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceObjectGrabSession.GrabTarget.NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004BD9 RID: 19417 RVA: 0x0001C6B5 File Offset: 0x0001A8B5
			public GrabTarget(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001986 RID: 6534
			// (get) Token: 0x06004BDA RID: 19418 RVA: 0x0014BCDC File Offset: 0x00149EDC
			// (set) Token: 0x06004BDB RID: 19419 RVA: 0x0001C6BE File Offset: 0x0001A8BE
			public unsafe GameObject _gameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr__gameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr__gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001987 RID: 6535
			// (get) Token: 0x06004BDC RID: 19420 RVA: 0x0014BD0C File Offset: 0x00149F0C
			// (set) Token: 0x06004BDD RID: 19421 RVA: 0x0001C6DD File Offset: 0x0001A8DD
			public unsafe Transform _transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr__transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001988 RID: 6536
			// (get) Token: 0x06004BDE RID: 19422 RVA: 0x0014BD3C File Offset: 0x00149F3C
			// (set) Token: 0x06004BDF RID: 19423 RVA: 0x0001C6FC File Offset: 0x0001A8FC
			public unsafe Vector3 AnchorVector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_AnchorVector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_AnchorVector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001989 RID: 6537
			// (get) Token: 0x06004BE0 RID: 19424 RVA: 0x0014BD6C File Offset: 0x00149F6C
			// (set) Token: 0x06004BE1 RID: 19425 RVA: 0x0001C71B File Offset: 0x0001A91B
			public unsafe Vector3 WorldScaleSnapshot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_WorldScaleSnapshot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_WorldScaleSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700198A RID: 6538
			// (get) Token: 0x06004BE2 RID: 19426 RVA: 0x0014BD9C File Offset: 0x00149F9C
			// (set) Token: 0x06004BE3 RID: 19427 RVA: 0x0001C73A File Offset: 0x0001A93A
			public unsafe Vector3 AnchorVectorSnapshot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_AnchorVectorSnapshot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_AnchorVectorSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700198B RID: 6539
			// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x0014BDCC File Offset: 0x00149FCC
			// (set) Token: 0x06004BE5 RID: 19429 RVA: 0x0001C759 File Offset: 0x0001A959
			public unsafe Plane SittingPlane
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_SittingPlane);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_SittingPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700198C RID: 6540
			// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x0014BDFC File Offset: 0x00149FFC
			// (set) Token: 0x06004BE7 RID: 19431 RVA: 0x0001C778 File Offset: 0x0001A978
			public unsafe Vector3 SittingPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_SittingPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_SittingPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700198D RID: 6541
			// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x0014BE2C File Offset: 0x0014A02C
			// (set) Token: 0x06004BE9 RID: 19433 RVA: 0x0001C797 File Offset: 0x0001A997
			public unsafe float OffsetFromSurface
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_OffsetFromSurface);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceObjectGrabSession.GrabTarget.NativeFieldInfoPtr_OffsetFromSurface)) = value;
				}
			}

			// Token: 0x04003AD4 RID: 15060
			private static readonly IntPtr NativeFieldInfoPtr__gameObject;

			// Token: 0x04003AD5 RID: 15061
			private static readonly IntPtr NativeFieldInfoPtr__transform;

			// Token: 0x04003AD6 RID: 15062
			private static readonly IntPtr NativeFieldInfoPtr_AnchorVector;

			// Token: 0x04003AD7 RID: 15063
			private static readonly IntPtr NativeFieldInfoPtr_WorldScaleSnapshot;

			// Token: 0x04003AD8 RID: 15064
			private static readonly IntPtr NativeFieldInfoPtr_AnchorVectorSnapshot;

			// Token: 0x04003AD9 RID: 15065
			private static readonly IntPtr NativeFieldInfoPtr_SittingPlane;

			// Token: 0x04003ADA RID: 15066
			private static readonly IntPtr NativeFieldInfoPtr_SittingPoint;

			// Token: 0x04003ADB RID: 15067
			private static readonly IntPtr NativeFieldInfoPtr_OffsetFromSurface;

			// Token: 0x04003ADC RID: 15068
			private static readonly IntPtr NativeMethodInfoPtr_get_GameObject_Public_get_GameObject_0;

			// Token: 0x04003ADD RID: 15069
			private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_get_Transform_0;

			// Token: 0x04003ADE RID: 15070
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;
		}
	}
}
