using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D9 RID: 473
	public class CircleShape3D : Shape3D
	{
		// Token: 0x06002544 RID: 9540 RVA: 0x000B4400 File Offset: 0x000B2600
		// Note: this type is marked as 'beforefieldinit'.
		static CircleShape3D()
		{
			Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CircleShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr);
			CircleShape3D.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, "_center");
			CircleShape3D.NativeFieldInfoPtr__radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, "_radius");
			CircleShape3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, "_rotation");
			CircleShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, "_epsilon");
			CircleShape3D.NativeFieldInfoPtr__raycastMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, "_raycastMode");
			CircleShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668887);
			CircleShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668888);
			CircleShape3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668889);
			CircleShape3D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668890);
			CircleShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668891);
			CircleShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668892);
			CircleShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668893);
			CircleShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668894);
			CircleShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668895);
			CircleShape3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668896);
			CircleShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_CircleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668897);
			CircleShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_CircleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668898);
			CircleShape3D.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668899);
			CircleShape3D.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668900);
			CircleShape3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668901);
			CircleShape3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668902);
			CircleShape3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668903);
			CircleShape3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668904);
			CircleShape3D.NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668905);
			CircleShape3D.NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668906);
			CircleShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668907);
			CircleShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668908);
			CircleShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668909);
			CircleShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668910);
			CircleShape3D.NativeMethodInfoPtr_get_ModelNormal_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668911);
			CircleShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668922);
			CircleShape3D.NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668912);
			CircleShape3D.NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668913);
			CircleShape3D.NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668914);
			CircleShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668915);
			CircleShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668916);
			CircleShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668917);
			CircleShape3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668918);
			CircleShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668919);
			CircleShape3D.NativeMethodInfoPtr_GetExtentPoints_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668920);
			CircleShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr, 100668921);
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x000B4764 File Offset: 0x000B2964
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x000B47A4 File Offset: 0x000B29A4
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x000B47E8 File Offset: 0x000B29E8
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x000B4824 File Offset: 0x000B2A24
		public unsafe float Radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 88928, RefRangeEnd = 88946, XrefRangeStart = 88928, XrefRangeEnd = 88946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x000B4864 File Offset: 0x000B2A64
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x000B48A4 File Offset: 0x000B2AA4
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x000B48E8 File Offset: 0x000B2AE8
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89237, XrefRangeEnd = 89240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x000B4928 File Offset: 0x000B2B28
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89240, XrefRangeEnd = 89243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x000B4968 File Offset: 0x000B2B68
		public unsafe Vector3 Look
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89243, XrefRangeEnd = 89246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x000B49A8 File Offset: 0x000B2BA8
		public unsafe Vector3 Normal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x000B49E8 File Offset: 0x000B2BE8
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x000B4A28 File Offset: 0x000B2C28
		public unsafe CircleEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_CircleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CircleEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_CircleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x000B4A6C File Offset: 0x000B2C6C
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x000B4AA8 File Offset: 0x000B2CA8
		public unsafe float RadiusEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89247, RefRangeEnd = 89248, XrefRangeStart = 89246, XrefRangeEnd = 89247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x000B4AE8 File Offset: 0x000B2CE8
		// (set) Token: 0x06002554 RID: 9556 RVA: 0x000B4B24 File Offset: 0x000B2D24
		public unsafe float ExtrudeEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89249, RefRangeEnd = 89251, XrefRangeStart = 89248, XrefRangeEnd = 89249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x000B4B64 File Offset: 0x000B2D64
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x000B4BA0 File Offset: 0x000B2DA0
		public unsafe float WireEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57816, RefRangeEnd = 57817, XrefRangeStart = 57816, XrefRangeEnd = 57817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89252, RefRangeEnd = 89253, XrefRangeStart = 89251, XrefRangeEnd = 89252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x000B4BE0 File Offset: 0x000B2DE0
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x000B4C20 File Offset: 0x000B2E20
		public unsafe Shape3DRaycastMode RaycastMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape3DRaycastMode>(intPtr3) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 89253, RefRangeEnd = 89263, XrefRangeStart = 89253, XrefRangeEnd = 89253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x000B4C64 File Offset: 0x000B2E64
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x000B4C98 File Offset: 0x000B2E98
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x000B4CCC File Offset: 0x000B2ECC
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x000B4D00 File Offset: 0x000B2F00
		public unsafe static Vector3 ModelCenter
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x000B4D34 File Offset: 0x000B2F34
		public unsafe static Vector3 ModelNormal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_get_ModelNormal_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000B4D68 File Offset: 0x000B2F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89268, RefRangeEnd = 89270, XrefRangeStart = 89263, XrefRangeEnd = 89268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CircleShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircleShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000B4DA4 File Offset: 0x000B2FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89270, XrefRangeEnd = 89277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignNormal(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000B4DE8 File Offset: 0x000B2FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89277, XrefRangeEnd = 89284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignRight(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000B4E2C File Offset: 0x000B302C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89284, XrefRangeEnd = 89291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignUp(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000B4E70 File Offset: 0x000B3070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89291, XrefRangeEnd = 89304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x000B4EAC File Offset: 0x000B30AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89304, XrefRangeEnd = 89317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x000B4EE8 File Offset: 0x000B30E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89317, XrefRangeEnd = 89326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000B4F50 File Offset: 0x000B3150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89326, XrefRangeEnd = 89330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool RaycastWire(Ray ray, out float t)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleShape3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000B4FB8 File Offset: 0x000B31B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89330, XrefRangeEnd = 89334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPoint(Vector3 point, bool checkOnPlane)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkOnPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x000B5014 File Offset: 0x000B3214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89334, XrefRangeEnd = 89335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetExtentPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleShape3D.NativeMethodInfoPtr_GetExtentPoints_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000B5054 File Offset: 0x000B3254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89335, XrefRangeEnd = 89337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CircleShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x0000F363 File Offset: 0x0000D563
		public CircleShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000B50A0 File Offset: 0x000B32A0
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x0000F36C File Offset: 0x0000D56C
		public unsafe Vector3 _center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000B50D0 File Offset: 0x000B32D0
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x0000F38B File Offset: 0x0000D58B
		public unsafe float _radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__radius)) = value;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x000B50F8 File Offset: 0x000B32F8
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x0000F3A6 File Offset: 0x0000D5A6
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x000B5128 File Offset: 0x000B3328
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x0000F3C5 File Offset: 0x0000D5C5
		public unsafe CircleEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x000B5158 File Offset: 0x000B3358
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x0000F3E4 File Offset: 0x0000D5E4
		public unsafe Shape3DRaycastMode _raycastMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__raycastMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape3DRaycastMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircleShape3D.NativeFieldInfoPtr__raycastMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeFieldInfoPtr__radius;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeFieldInfoPtr__raycastMode;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_CircleEpsilon_0;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_CircleEpsilon_0;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelNormal_Public_Static_get_Vector3_0;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr_GetExtentPoints_Public_List_1_Vector3_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;
	}
}
