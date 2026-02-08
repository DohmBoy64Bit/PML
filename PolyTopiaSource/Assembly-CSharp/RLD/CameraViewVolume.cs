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
	// Token: 0x0200010D RID: 269
	public class CameraViewVolume : global::Il2CppSystem.Object
	{
		// Token: 0x0600195F RID: 6495 RVA: 0x00083C74 File Offset: 0x00081E74
		// Note: this type is marked as 'beforefieldinit'.
		static CameraViewVolume()
		{
			Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraViewVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr);
			CameraViewVolume.NativeFieldInfoPtr__numWorldPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, "_numWorldPoints");
			CameraViewVolume.NativeFieldInfoPtr__numWorldPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, "_numWorldPlanes");
			CameraViewVolume.NativeFieldInfoPtr__worldPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, "_worldPoints");
			CameraViewVolume.NativeFieldInfoPtr__worldPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, "_worldPlanes");
			CameraViewVolume.NativeFieldInfoPtr__farPlaneSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, "_farPlaneSize");
			CameraViewVolume.NativeFieldInfoPtr__nearPlaneSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, "_nearPlaneSize");
			CameraViewVolume.NativeFieldInfoPtr__worldAABB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, "_worldAABB");
			CameraViewVolume.NativeFieldInfoPtr__worldOBB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, "_worldOBB");
			CameraViewVolume.NativeMethodInfoPtr_get_LeftPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667022);
			CameraViewVolume.NativeMethodInfoPtr_get_RightPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667023);
			CameraViewVolume.NativeMethodInfoPtr_get_BottomPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667024);
			CameraViewVolume.NativeMethodInfoPtr_get_TopPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667025);
			CameraViewVolume.NativeMethodInfoPtr_get_NearPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667026);
			CameraViewVolume.NativeMethodInfoPtr_get_FarPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667027);
			CameraViewVolume.NativeMethodInfoPtr_get_NearTopLeft_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667028);
			CameraViewVolume.NativeMethodInfoPtr_get_NearTopRight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667029);
			CameraViewVolume.NativeMethodInfoPtr_get_NearBottomRight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667030);
			CameraViewVolume.NativeMethodInfoPtr_get_NearBottomLeft_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667031);
			CameraViewVolume.NativeMethodInfoPtr_get_FarTopLeft_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667032);
			CameraViewVolume.NativeMethodInfoPtr_get_FarTopRight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667033);
			CameraViewVolume.NativeMethodInfoPtr_get_FarBottomRight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667034);
			CameraViewVolume.NativeMethodInfoPtr_get_FarBottomLeft_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667035);
			CameraViewVolume.NativeMethodInfoPtr_get_FarPlaneSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667036);
			CameraViewVolume.NativeMethodInfoPtr_get_NearPlaneSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667037);
			CameraViewVolume.NativeMethodInfoPtr_get_WorldAABB_Public_get_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667038);
			CameraViewVolume.NativeMethodInfoPtr_get_WorldOBB_Public_get_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667039);
			CameraViewVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667040);
			CameraViewVolume.NativeMethodInfoPtr__ctor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667041);
			CameraViewVolume.NativeMethodInfoPtr_FromCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667042);
			CameraViewVolume.NativeMethodInfoPtr_GetNearPlanePoints_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667043);
			CameraViewVolume.NativeMethodInfoPtr_GetCameraWorldPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667044);
			CameraViewVolume.NativeMethodInfoPtr_CheckAABB_Public_Boolean_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667045);
			CameraViewVolume.NativeMethodInfoPtr_CheckAABB_Public_Static_Boolean_Camera_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667046);
			CameraViewVolume.NativeMethodInfoPtr_CheckAABB_Public_Static_Boolean_Camera_AABB_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667047);
			CameraViewVolume.NativeMethodInfoPtr_CalculateWorldPoints_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr, 100667048);
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00083F60 File Offset: 0x00082160
		public unsafe Plane LeftPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_LeftPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x00083FA0 File Offset: 0x000821A0
		public unsafe Plane RightPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_RightPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00083FE0 File Offset: 0x000821E0
		public unsafe Plane BottomPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_BottomPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x00084020 File Offset: 0x00082220
		public unsafe Plane TopPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_TopPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00084060 File Offset: 0x00082260
		public unsafe Plane NearPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_NearPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x000840A0 File Offset: 0x000822A0
		public unsafe Plane FarPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_FarPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x000840E0 File Offset: 0x000822E0
		public unsafe Vector3 NearTopLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_NearTopLeft_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x00084120 File Offset: 0x00082320
		public unsafe Vector3 NearTopRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_NearTopRight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00084160 File Offset: 0x00082360
		public unsafe Vector3 NearBottomRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_NearBottomRight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x000841A0 File Offset: 0x000823A0
		public unsafe Vector3 NearBottomLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_NearBottomLeft_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x000841E0 File Offset: 0x000823E0
		public unsafe Vector3 FarTopLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_FarTopLeft_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00084220 File Offset: 0x00082420
		public unsafe Vector3 FarTopRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_FarTopRight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00084260 File Offset: 0x00082460
		public unsafe Vector3 FarBottomRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_FarBottomRight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x000842A0 File Offset: 0x000824A0
		public unsafe Vector3 FarBottomLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_FarBottomLeft_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x000842E0 File Offset: 0x000824E0
		public unsafe Vector2 FarPlaneSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_FarPlaneSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x00084320 File Offset: 0x00082520
		public unsafe Vector2 NearPlaneSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_NearPlaneSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x00084360 File Offset: 0x00082560
		public unsafe AABB WorldAABB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_WorldAABB_Public_get_AABB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000843A0 File Offset: 0x000825A0
		public unsafe OBB WorldOBB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_get_WorldOBB_Public_get_OBB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x000843E0 File Offset: 0x000825E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74643, XrefRangeEnd = 74656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraViewVolume()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0008441C File Offset: 0x0008261C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74656, XrefRangeEnd = 74670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraViewVolume(Camera camera)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraViewVolume>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr__ctor_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00084468 File Offset: 0x00082668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74689, RefRangeEnd = 74691, XrefRangeStart = 74670, XrefRangeEnd = 74689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FromCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_FromCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000844AC File Offset: 0x000826AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74691, XrefRangeEnd = 74709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetNearPlanePoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_GetNearPlanePoints_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000844EC File Offset: 0x000826EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74713, RefRangeEnd = 74715, XrefRangeStart = 74709, XrefRangeEnd = 74713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Plane> GetCameraWorldPlanes(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_GetCameraWorldPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr3) : null;
			}
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00084530 File Offset: 0x00082730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74724, RefRangeEnd = 74725, XrefRangeStart = 74715, XrefRangeEnd = 74724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAABB(AABB aabb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aabb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_CheckAABB_Public_Boolean_AABB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00084580 File Offset: 0x00082780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74725, XrefRangeEnd = 74738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckAABB(Camera camera, AABB aabb)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aabb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_CheckAABB_Public_Static_Boolean_Camera_AABB_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000845D4 File Offset: 0x000827D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74738, XrefRangeEnd = 74747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckAABB(Camera camera, AABB aabb, Il2CppStructArray<Plane> cameraWorldPlanes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aabb);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraWorldPlanes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_CheckAABB_Public_Static_Boolean_Camera_AABB_Il2CppStructArray_1_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0008463C File Offset: 0x0008283C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74808, RefRangeEnd = 74809, XrefRangeStart = 74747, XrefRangeEnd = 74808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateWorldPoints(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraViewVolume.NativeMethodInfoPtr_CalculateWorldPoints_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0000B2B8 File Offset: 0x000094B8
		public CameraViewVolume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00084680 File Offset: 0x00082880
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x0000B2C1 File Offset: 0x000094C1
		public unsafe static int _numWorldPoints
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CameraViewVolume.NativeFieldInfoPtr__numWorldPoints, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraViewVolume.NativeFieldInfoPtr__numWorldPoints, (void*)(&value));
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x0008469C File Offset: 0x0008289C
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x0000B2CF File Offset: 0x000094CF
		public unsafe static int _numWorldPlanes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CameraViewVolume.NativeFieldInfoPtr__numWorldPlanes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraViewVolume.NativeFieldInfoPtr__numWorldPlanes, (void*)(&value));
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x000846B8 File Offset: 0x000828B8
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x0000B2DD File Offset: 0x000094DD
		public unsafe Il2CppStructArray<Vector3> _worldPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__worldPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__worldPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x000846E8 File Offset: 0x000828E8
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x0000B2FC File Offset: 0x000094FC
		public unsafe Il2CppStructArray<Plane> _worldPlanes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__worldPlanes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__worldPlanes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x00084718 File Offset: 0x00082918
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x0000B31B File Offset: 0x0000951B
		public unsafe Vector2 _farPlaneSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__farPlaneSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__farPlaneSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x00084748 File Offset: 0x00082948
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x0000B33A File Offset: 0x0000953A
		public unsafe Vector2 _nearPlaneSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__nearPlaneSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__nearPlaneSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x00084778 File Offset: 0x00082978
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x0000B359 File Offset: 0x00009559
		public unsafe AABB _worldAABB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__worldAABB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__worldAABB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x000847A8 File Offset: 0x000829A8
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x0000B378 File Offset: 0x00009578
		public unsafe OBB _worldOBB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__worldOBB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraViewVolume.NativeFieldInfoPtr__worldOBB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeFieldInfoPtr__numWorldPoints;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeFieldInfoPtr__numWorldPlanes;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeFieldInfoPtr__worldPoints;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeFieldInfoPtr__worldPlanes;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeFieldInfoPtr__farPlaneSize;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeFieldInfoPtr__nearPlaneSize;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeFieldInfoPtr__worldAABB;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeFieldInfoPtr__worldOBB;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftPlane_Public_get_Plane_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_get_RightPlane_Public_get_Plane_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomPlane_Public_get_Plane_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_get_TopPlane_Public_get_Plane_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_get_NearPlane_Public_get_Plane_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_get_FarPlane_Public_get_Plane_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_get_NearTopLeft_Public_get_Vector3_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_get_NearTopRight_Public_get_Vector3_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_get_NearBottomRight_Public_get_Vector3_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_get_NearBottomLeft_Public_get_Vector3_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_get_FarTopLeft_Public_get_Vector3_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_get_FarTopRight_Public_get_Vector3_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_get_FarBottomRight_Public_get_Vector3_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_get_FarBottomLeft_Public_get_Vector3_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_get_FarPlaneSize_Public_get_Vector2_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_get_NearPlaneSize_Public_get_Vector2_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldAABB_Public_get_AABB_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldOBB_Public_get_OBB_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_FromCamera_Public_Void_Camera_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_GetNearPlanePoints_Public_List_1_Vector3_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraWorldPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_CheckAABB_Public_Boolean_AABB_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_CheckAABB_Public_Static_Boolean_Camera_AABB_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_CheckAABB_Public_Static_Boolean_Camera_AABB_Il2CppStructArray_1_Plane_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_CalculateWorldPoints_Private_Void_Camera_0;

		// Token: 0x0200037C RID: 892
		public enum VPoint
		{
			// Token: 0x040039B9 RID: 14777
			NearTopLeft,
			// Token: 0x040039BA RID: 14778
			NearTopRight,
			// Token: 0x040039BB RID: 14779
			NearBottomRight,
			// Token: 0x040039BC RID: 14780
			NearBottomLeft,
			// Token: 0x040039BD RID: 14781
			FarTopLeft,
			// Token: 0x040039BE RID: 14782
			FarTopRight,
			// Token: 0x040039BF RID: 14783
			FarBottomRight,
			// Token: 0x040039C0 RID: 14784
			FarBottomLeft
		}

		// Token: 0x0200037D RID: 893
		public enum VPlane
		{
			// Token: 0x040039C2 RID: 14786
			Left,
			// Token: 0x040039C3 RID: 14787
			Right,
			// Token: 0x040039C4 RID: 14788
			Bottom,
			// Token: 0x040039C5 RID: 14789
			Top,
			// Token: 0x040039C6 RID: 14790
			Near,
			// Token: 0x040039C7 RID: 14791
			Far
		}
	}
}
