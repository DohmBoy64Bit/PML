using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000077 RID: 119
	public class RTSceneGizmoCamera : MonoBehaviour
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x0004327C File Offset: 0x0004147C
		// Note: this type is marked as 'beforefieldinit'.
		static RTSceneGizmoCamera()
		{
			Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTSceneGizmoCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr);
			RTSceneGizmoCamera.NativeFieldInfoPtr__camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, "_camera");
			RTSceneGizmoCamera.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, "_transform");
			RTSceneGizmoCamera.NativeFieldInfoPtr__lookAtPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, "_lookAtPoint");
			RTSceneGizmoCamera.NativeFieldInfoPtr__fieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, "_fieldOfView");
			RTSceneGizmoCamera.NativeFieldInfoPtr__orthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, "_orthoSize");
			RTSceneGizmoCamera.NativeFieldInfoPtr__offsetFromFocusPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, "_offsetFromFocusPt");
			RTSceneGizmoCamera.NativeFieldInfoPtr__sceneCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, "_sceneCamera");
			RTSceneGizmoCamera.NativeFieldInfoPtr__viewportUpdater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, "_viewportUpdater");
			RTSceneGizmoCamera.NativeMethodInfoPtr_get_Camera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664620);
			RTSceneGizmoCamera.NativeMethodInfoPtr_get_SceneCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664621);
			RTSceneGizmoCamera.NativeMethodInfoPtr_set_SceneCamera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664622);
			RTSceneGizmoCamera.NativeMethodInfoPtr_get_ViewportUpdater_Public_get_ISceneGizmoCamViewportUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664623);
			RTSceneGizmoCamera.NativeMethodInfoPtr_set_ViewportUpdater_Public_set_Void_ISceneGizmoCamViewportUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664624);
			RTSceneGizmoCamera.NativeMethodInfoPtr_get_WorldPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664625);
			RTSceneGizmoCamera.NativeMethodInfoPtr_set_WorldPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664626);
			RTSceneGizmoCamera.NativeMethodInfoPtr_get_WorldRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664627);
			RTSceneGizmoCamera.NativeMethodInfoPtr_set_WorldRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664628);
			RTSceneGizmoCamera.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664629);
			RTSceneGizmoCamera.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664630);
			RTSceneGizmoCamera.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664631);
			RTSceneGizmoCamera.NativeMethodInfoPtr_get_LookAtPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664632);
			RTSceneGizmoCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664636);
			RTSceneGizmoCamera.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664633);
			RTSceneGizmoCamera.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664634);
			RTSceneGizmoCamera.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr, 100664635);
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000434A0 File Offset: 0x000416A0
		public unsafe Camera Camera
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_get_Camera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x000434E0 File Offset: 0x000416E0
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00043520 File Offset: 0x00041720
		public unsafe Camera SceneCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_get_SceneCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 63735, RefRangeEnd = 63737, XrefRangeStart = 63725, XrefRangeEnd = 63735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_set_SceneCamera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00043564 File Offset: 0x00041764
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x000435A4 File Offset: 0x000417A4
		public unsafe ISceneGizmoCamViewportUpdater ViewportUpdater
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_get_ViewportUpdater_Public_get_ISceneGizmoCamViewportUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISceneGizmoCamViewportUpdater>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63738, RefRangeEnd = 63739, XrefRangeStart = 63737, XrefRangeEnd = 63738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_set_ViewportUpdater_Public_set_Void_ISceneGizmoCamViewportUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x000435E8 File Offset: 0x000417E8
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00043628 File Offset: 0x00041828
		public unsafe Vector3 WorldPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63739, XrefRangeEnd = 63740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_get_WorldPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63740, XrefRangeEnd = 63741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_set_WorldPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0004366C File Offset: 0x0004186C
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x000436AC File Offset: 0x000418AC
		public unsafe Quaternion WorldRotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63741, XrefRangeEnd = 63742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_get_WorldRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63742, XrefRangeEnd = 63743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_set_WorldRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x000436F0 File Offset: 0x000418F0
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63743, XrefRangeEnd = 63744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00043730 File Offset: 0x00041930
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63744, XrefRangeEnd = 63745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00043770 File Offset: 0x00041970
		public unsafe Vector3 Look
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63745, XrefRangeEnd = 63746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x000437B0 File Offset: 0x000419B0
		public unsafe Vector3 LookAtPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_get_LookAtPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000437F0 File Offset: 0x000419F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63746, XrefRangeEnd = 63749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTSceneGizmoCamera()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTSceneGizmoCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0004382C File Offset: 0x00041A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63761, RefRangeEnd = 63762, XrefRangeStart = 63749, XrefRangeEnd = 63761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00043860 File Offset: 0x00041A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63762, XrefRangeEnd = 63770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00043894 File Offset: 0x00041A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63770, XrefRangeEnd = 63812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSceneGizmoCamera.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00004EC4 File Offset: 0x000030C4
		public RTSceneGizmoCamera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x000438C8 File Offset: 0x00041AC8
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00004ECD File Offset: 0x000030CD
		public unsafe Camera _camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x000438F8 File Offset: 0x00041AF8
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00004EEC File Offset: 0x000030EC
		public unsafe Transform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00043928 File Offset: 0x00041B28
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00004F0B File Offset: 0x0000310B
		public unsafe Vector3 _lookAtPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__lookAtPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__lookAtPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00043958 File Offset: 0x00041B58
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00004F2A File Offset: 0x0000312A
		public unsafe float _fieldOfView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__fieldOfView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__fieldOfView)) = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00043980 File Offset: 0x00041B80
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00004F45 File Offset: 0x00003145
		public unsafe float _orthoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__orthoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__orthoSize)) = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x000439A8 File Offset: 0x00041BA8
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00004F60 File Offset: 0x00003160
		public unsafe float _offsetFromFocusPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__offsetFromFocusPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__offsetFromFocusPt)) = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000439D0 File Offset: 0x00041BD0
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00004F7B File Offset: 0x0000317B
		public unsafe Camera _sceneCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__sceneCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__sceneCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00043A00 File Offset: 0x00041C00
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00004F9A File Offset: 0x0000319A
		public unsafe ISceneGizmoCamViewportUpdater _viewportUpdater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__viewportUpdater);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISceneGizmoCamViewportUpdater>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTSceneGizmoCamera.NativeFieldInfoPtr__viewportUpdater), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr__camera;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr__lookAtPoint;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr__fieldOfView;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr__orthoSize;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr__offsetFromFocusPt;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr__sceneCamera;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr__viewportUpdater;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Public_get_Camera_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneCamera_Public_get_Camera_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_set_SceneCamera_Public_set_Void_Camera_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_get_ViewportUpdater_Public_get_ISceneGizmoCamViewportUpdater_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_set_ViewportUpdater_Public_set_Void_ISceneGizmoCamViewportUpdater_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldPosition_Public_get_Vector3_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldPosition_Public_set_Void_Vector3_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldRotation_Public_get_Quaternion_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldRotation_Public_set_Void_Quaternion_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAtPoint_Public_get_Vector3_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_Update_SystemCall_Public_Void_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
	}
}
