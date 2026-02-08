using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DD RID: 477
	public class CylTorusShape3D : Shape3D
	{
		// Token: 0x060025F7 RID: 9719 RVA: 0x000B7544 File Offset: 0x000B5744
		// Note: this type is marked as 'beforefieldinit'.
		static CylTorusShape3D()
		{
			Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CylTorusShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr);
			CylTorusShape3D.NativeFieldInfoPtr__coreRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, "_coreRadius");
			CylTorusShape3D.NativeFieldInfoPtr__hrzRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, "_hrzRadius");
			CylTorusShape3D.NativeFieldInfoPtr__vertRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, "_vertRadius");
			CylTorusShape3D.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, "_center");
			CylTorusShape3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, "_rotation");
			CylTorusShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, "_epsilon");
			CylTorusShape3D.NativeMethodInfoPtr_get_CoreRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669025);
			CylTorusShape3D.NativeMethodInfoPtr_set_CoreRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669026);
			CylTorusShape3D.NativeMethodInfoPtr_get_HrzRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669027);
			CylTorusShape3D.NativeMethodInfoPtr_set_HrzRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669028);
			CylTorusShape3D.NativeMethodInfoPtr_get_VertRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669029);
			CylTorusShape3D.NativeMethodInfoPtr_set_VertRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669030);
			CylTorusShape3D.NativeMethodInfoPtr_get_Bottom_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669031);
			CylTorusShape3D.NativeMethodInfoPtr_set_Bottom_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669032);
			CylTorusShape3D.NativeMethodInfoPtr_get_Top_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669033);
			CylTorusShape3D.NativeMethodInfoPtr_set_Top_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669034);
			CylTorusShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669035);
			CylTorusShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669036);
			CylTorusShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669037);
			CylTorusShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669038);
			CylTorusShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669039);
			CylTorusShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669040);
			CylTorusShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669041);
			CylTorusShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_TorusEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669042);
			CylTorusShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TorusEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669043);
			CylTorusShape3D.NativeMethodInfoPtr_get_CylHrzRadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669044);
			CylTorusShape3D.NativeMethodInfoPtr_set_CylHrzRadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669045);
			CylTorusShape3D.NativeMethodInfoPtr_get_CylVertRadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669046);
			CylTorusShape3D.NativeMethodInfoPtr_set_CylVertRadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669047);
			CylTorusShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669048);
			CylTorusShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669049);
			CylTorusShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669050);
			CylTorusShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669051);
			CylTorusShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669057);
			CylTorusShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669052);
			CylTorusShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669053);
			CylTorusShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669054);
			CylTorusShape3D.NativeMethodInfoPtr_GetHrzExtents_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669055);
			CylTorusShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr, 100669056);
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000B7880 File Offset: 0x000B5A80
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x000B78BC File Offset: 0x000B5ABC
		public unsafe float CoreRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_CoreRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89734, RefRangeEnd = 89737, XrefRangeStart = 89734, XrefRangeEnd = 89734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_CoreRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x000B78FC File Offset: 0x000B5AFC
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x000B7938 File Offset: 0x000B5B38
		public unsafe float HrzRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_HrzRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89737, RefRangeEnd = 89740, XrefRangeStart = 89737, XrefRangeEnd = 89737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_HrzRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000B7978 File Offset: 0x000B5B78
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x000B79B4 File Offset: 0x000B5BB4
		public unsafe float VertRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_VertRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 88914, RefRangeEnd = 88928, XrefRangeStart = 88914, XrefRangeEnd = 88928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_VertRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000B79F4 File Offset: 0x000B5BF4
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x000B7A34 File Offset: 0x000B5C34
		public unsafe Vector3 Bottom
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89743, RefRangeEnd = 89745, XrefRangeStart = 89740, XrefRangeEnd = 89743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_Bottom_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89745, XrefRangeEnd = 89748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_Bottom_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000B7A78 File Offset: 0x000B5C78
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x000B7AB8 File Offset: 0x000B5CB8
		public unsafe Vector3 Top
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89751, RefRangeEnd = 89753, XrefRangeStart = 89748, XrefRangeEnd = 89751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_Top_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89753, XrefRangeEnd = 89756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_Top_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000B7AFC File Offset: 0x000B5CFC
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x000B7B3C File Offset: 0x000B5D3C
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000B7B80 File Offset: 0x000B5D80
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x000B7BC0 File Offset: 0x000B5DC0
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 58119, RefRangeEnd = 58122, XrefRangeStart = 58119, XrefRangeEnd = 58122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000B7C04 File Offset: 0x000B5E04
		public unsafe Vector3 Right
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89759, RefRangeEnd = 89760, XrefRangeStart = 89756, XrefRangeEnd = 89759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x000B7C44 File Offset: 0x000B5E44
		public unsafe Vector3 Up
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89763, RefRangeEnd = 89764, XrefRangeStart = 89760, XrefRangeEnd = 89763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x000B7C84 File Offset: 0x000B5E84
		public unsafe Vector3 Look
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89767, RefRangeEnd = 89768, XrefRangeStart = 89764, XrefRangeEnd = 89767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x000B7CC4 File Offset: 0x000B5EC4
		// (set) Token: 0x0600260A RID: 9738 RVA: 0x000B7D04 File Offset: 0x000B5F04
		public unsafe TorusEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_TorusEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TorusEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TorusEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x000B7D48 File Offset: 0x000B5F48
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x000B7D84 File Offset: 0x000B5F84
		public unsafe float CylHrzRadiusEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57831, RefRangeEnd = 57832, XrefRangeStart = 57831, XrefRangeEnd = 57832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_CylHrzRadiusEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89769, RefRangeEnd = 89770, XrefRangeStart = 89768, XrefRangeEnd = 89769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_CylHrzRadiusEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x000B7DC4 File Offset: 0x000B5FC4
		// (set) Token: 0x0600260E RID: 9742 RVA: 0x000B7E00 File Offset: 0x000B6000
		public unsafe float CylVertRadiusEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57846, RefRangeEnd = 57847, XrefRangeStart = 57846, XrefRangeEnd = 57847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_CylVertRadiusEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89771, RefRangeEnd = 89772, XrefRangeStart = 89770, XrefRangeEnd = 89771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_set_CylVertRadiusEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x000B7E40 File Offset: 0x000B6040
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000B7E74 File Offset: 0x000B6074
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x000B7EA8 File Offset: 0x000B60A8
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x000B7EDC File Offset: 0x000B60DC
		public unsafe static Vector3 ModelCenter
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x000B7F10 File Offset: 0x000B6110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89777, RefRangeEnd = 89778, XrefRangeStart = 89772, XrefRangeEnd = 89777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CylTorusShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CylTorusShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x000B7F4C File Offset: 0x000B614C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89778, XrefRangeEnd = 89779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Raycast(Ray ray, out float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CylTorusShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x000B7FB4 File Offset: 0x000B61B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89779, XrefRangeEnd = 89793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CylTorusShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x000B7FF0 File Offset: 0x000B61F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89793, XrefRangeEnd = 89816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CylTorusShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x000B802C File Offset: 0x000B622C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89816, XrefRangeEnd = 89817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetHrzExtents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylTorusShape3D.NativeMethodInfoPtr_GetHrzExtents_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x000B806C File Offset: 0x000B626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89817, XrefRangeEnd = 89818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CylTorusShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x0000F5D3 File Offset: 0x0000D7D3
		public CylTorusShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000B80B8 File Offset: 0x000B62B8
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x0000F5DC File Offset: 0x0000D7DC
		public unsafe float _coreRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__coreRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__coreRadius)) = value;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x000B80E0 File Offset: 0x000B62E0
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x0000F5F7 File Offset: 0x0000D7F7
		public unsafe float _hrzRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__hrzRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__hrzRadius)) = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x000B8108 File Offset: 0x000B6308
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x0000F612 File Offset: 0x0000D812
		public unsafe float _vertRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__vertRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__vertRadius)) = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x000B8130 File Offset: 0x000B6330
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x0000F62D File Offset: 0x0000D82D
		public unsafe Vector3 _center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x000B8160 File Offset: 0x000B6360
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x0000F64C File Offset: 0x0000D84C
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x000B8190 File Offset: 0x000B6390
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x0000F66B File Offset: 0x0000D86B
		public unsafe TorusEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TorusEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylTorusShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeFieldInfoPtr__coreRadius;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeFieldInfoPtr__hrzRadius;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeFieldInfoPtr__vertRadius;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr_get_CoreRadius_Public_get_Single_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_set_CoreRadius_Public_set_Void_Single_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_get_HrzRadius_Public_get_Single_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_set_HrzRadius_Public_set_Void_Single_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_get_VertRadius_Public_get_Single_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_set_VertRadius_Public_set_Void_Single_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr_get_Bottom_Public_get_Vector3_0;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_set_Bottom_Public_set_Void_Vector3_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_get_Top_Public_get_Vector3_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_set_Top_Public_set_Void_Vector3_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_TorusEpsilon_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TorusEpsilon_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_get_CylHrzRadiusEps_Public_get_Single_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_set_CylHrzRadiusEps_Public_set_Void_Single_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_get_CylVertRadiusEps_Public_get_Single_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_set_CylVertRadiusEps_Public_set_Void_Single_0;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_GetHrzExtents_Public_List_1_Vector3_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;
	}
}
