using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001EF RID: 495
	public class SphereShape3D : Shape3D
	{
		// Token: 0x06002801 RID: 10241 RVA: 0x000C02D8 File Offset: 0x000BE4D8
		// Note: this type is marked as 'beforefieldinit'.
		static SphereShape3D()
		{
			Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SphereShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr);
			SphereShape3D.NativeFieldInfoPtr__radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, "_radius");
			SphereShape3D.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, "_center");
			SphereShape3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, "_rotation");
			SphereShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, "_epsilon");
			SphereShape3D.NativeFieldInfoPtr__wireRenderDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, "_wireRenderDesc");
			SphereShape3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669399);
			SphereShape3D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669400);
			SphereShape3D.NativeMethodInfoPtr_get_WireRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669401);
			SphereShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669402);
			SphereShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669403);
			SphereShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669404);
			SphereShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669405);
			SphereShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_SphereEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669406);
			SphereShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_SphereEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669407);
			SphereShape3D.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669408);
			SphereShape3D.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669409);
			SphereShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669410);
			SphereShape3D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669411);
			SphereShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669412);
			SphereShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669413);
			SphereShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669414);
			SphereShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669415);
			SphereShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669416);
			SphereShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669417);
			SphereShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669418);
			SphereShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669424);
			SphereShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669419);
			SphereShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669420);
			SphereShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669421);
			SphereShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669422);
			SphereShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, 100669423);
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000C0574 File Offset: 0x000BE774
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x000C05B0 File Offset: 0x000BE7B0
		public unsafe float Radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_Radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89734, RefRangeEnd = 89737, XrefRangeStart = 89734, XrefRangeEnd = 89737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x000C05F0 File Offset: 0x000BE7F0
		public unsafe float WireRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_WireRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x000C062C File Offset: 0x000BE82C
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x000C066C File Offset: 0x000BE86C
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x000C06B0 File Offset: 0x000BE8B0
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x000C06F0 File Offset: 0x000BE8F0
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x000C0734 File Offset: 0x000BE934
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x000C0774 File Offset: 0x000BE974
		public unsafe SphereEpsilon Epsilon
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 21737, RefRangeEnd = 21743, XrefRangeStart = 21737, XrefRangeEnd = 21743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_SphereEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SphereEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_SphereEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x000C07B8 File Offset: 0x000BE9B8
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x000C07F4 File Offset: 0x000BE9F4
		public unsafe float RadiusEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89247, RefRangeEnd = 89248, XrefRangeStart = 89247, XrefRangeEnd = 89248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x000C0834 File Offset: 0x000BEA34
		public unsafe SphereShape3D.WireRenderDescriptor WireRenderDesc
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SphereShape3D.WireRenderDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x0600280E RID: 10254 RVA: 0x000C0874 File Offset: 0x000BEA74
		public unsafe Vector3 CentralAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x000C08B4 File Offset: 0x000BEAB4
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x000C08F4 File Offset: 0x000BEAF4
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x000C0934 File Offset: 0x000BEB34
		public unsafe Vector3 Look
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x000C0974 File Offset: 0x000BEB74
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x000C09A8 File Offset: 0x000BEBA8
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x000C09DC File Offset: 0x000BEBDC
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x000C0A10 File Offset: 0x000BEC10
		public unsafe static Vector3 ModelCenter
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x000C0A44 File Offset: 0x000BEC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90671, RefRangeEnd = 90672, XrefRangeStart = 90661, XrefRangeEnd = 90671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SphereShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x000C0A80 File Offset: 0x000BEC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90672, XrefRangeEnd = 90687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SphereShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000C0ABC File Offset: 0x000BECBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90687, XrefRangeEnd = 90743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SphereShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000C0AF8 File Offset: 0x000BECF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90743, XrefRangeEnd = 90744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SphereShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000C0B60 File Offset: 0x000BED60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90744, XrefRangeEnd = 90745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x000C0BB0 File Offset: 0x000BEDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90745, XrefRangeEnd = 90747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SphereShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x0000FE0D File Offset: 0x0000E00D
		public SphereShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000C0BFC File Offset: 0x000BEDFC
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x0000FE16 File Offset: 0x0000E016
		public unsafe float _radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__radius)) = value;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x000C0C24 File Offset: 0x000BEE24
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x0000FE31 File Offset: 0x0000E031
		public unsafe Vector3 _center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x000C0C54 File Offset: 0x000BEE54
		// (set) Token: 0x06002822 RID: 10274 RVA: 0x0000FE50 File Offset: 0x0000E050
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x000C0C84 File Offset: 0x000BEE84
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x0000FE6F File Offset: 0x0000E06F
		public unsafe SphereEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x000C0CB4 File Offset: 0x000BEEB4
		// (set) Token: 0x06002826 RID: 10278 RVA: 0x0000FE8E File Offset: 0x0000E08E
		public unsafe SphereShape3D.WireRenderDescriptor _wireRenderDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__wireRenderDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereShape3D.WireRenderDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.NativeFieldInfoPtr__wireRenderDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeFieldInfoPtr__radius;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeFieldInfoPtr__wireRenderDesc;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeMethodInfoPtr_get_Radius_Public_get_Single_0;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeMethodInfoPtr_set_Radius_Public_set_Void_Single_0;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr_get_WireRadius_Public_get_Single_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_SphereEpsilon_0;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_SphereEpsilon_0;

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0;

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;

		// Token: 0x020003BB RID: 955
		public enum WireRenderMode
		{
			// Token: 0x04003B28 RID: 15144
			Basic,
			// Token: 0x04003B29 RID: 15145
			Detailed
		}

		// Token: 0x020003BC RID: 956
		public class WireRenderDescriptor : global::Il2CppSystem.Object
		{
			// Token: 0x06004C2C RID: 19500 RVA: 0x0014CBDC File Offset: 0x0014ADDC
			// Note: this type is marked as 'beforefieldinit'.
			static WireRenderDescriptor()
			{
				Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SphereShape3D>.NativeClassPtr, "WireRenderDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr);
				SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, "_wireMode");
				SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailAxialRings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, "_numDetailAxialRings");
				SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailSliceRings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, "_numDetailSliceRings");
				SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__radiusAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, "_radiusAdd");
				SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireMode_Public_get_WireRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, 100669425);
				SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireMode_Public_set_Void_WireRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, 100669426);
				SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumDetailAxialRings_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, 100669427);
				SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumDetailAxialRings_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, 100669428);
				SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumDetailSliceRings_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, 100669429);
				SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumDetailSliceRings_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, 100669430);
				SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_RadiusAdd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, 100669431);
				SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_RadiusAdd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, 100669432);
				SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr, 100669433);
			}

			// Token: 0x170019AC RID: 6572
			// (get) Token: 0x06004C2D RID: 19501 RVA: 0x0014CD0C File Offset: 0x0014AF0C
			// (set) Token: 0x06004C2E RID: 19502 RVA: 0x0014CD48 File Offset: 0x0014AF48
			public unsafe SphereShape3D.WireRenderMode WireMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireMode_Public_get_WireRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireMode_Public_set_Void_WireRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170019AD RID: 6573
			// (get) Token: 0x06004C2F RID: 19503 RVA: 0x0014CD88 File Offset: 0x0014AF88
			// (set) Token: 0x06004C30 RID: 19504 RVA: 0x0014CDC4 File Offset: 0x0014AFC4
			public unsafe int NumDetailAxialRings
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumDetailAxialRings_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumDetailAxialRings_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170019AE RID: 6574
			// (get) Token: 0x06004C31 RID: 19505 RVA: 0x0014CE04 File Offset: 0x0014B004
			// (set) Token: 0x06004C32 RID: 19506 RVA: 0x0014CE40 File Offset: 0x0014B040
			public unsafe int NumDetailSliceRings
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumDetailSliceRings_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumDetailSliceRings_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170019AF RID: 6575
			// (get) Token: 0x06004C33 RID: 19507 RVA: 0x0014CE80 File Offset: 0x0014B080
			// (set) Token: 0x06004C34 RID: 19508 RVA: 0x0014CEBC File Offset: 0x0014B0BC
			public unsafe float RadiusAdd
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_RadiusAdd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 57146, RefRangeEnd = 57149, XrefRangeStart = 57146, XrefRangeEnd = 57149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_RadiusAdd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004C35 RID: 19509 RVA: 0x0014CEFC File Offset: 0x0014B0FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WireRenderDescriptor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SphereShape3D.WireRenderDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C36 RID: 19510 RVA: 0x0001C934 File Offset: 0x0001AB34
			public WireRenderDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019A8 RID: 6568
			// (get) Token: 0x06004C37 RID: 19511 RVA: 0x0014CF38 File Offset: 0x0014B138
			// (set) Token: 0x06004C38 RID: 19512 RVA: 0x0001C93D File Offset: 0x0001AB3D
			public unsafe SphereShape3D.WireRenderMode _wireMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireMode)) = value;
				}
			}

			// Token: 0x170019A9 RID: 6569
			// (get) Token: 0x06004C39 RID: 19513 RVA: 0x0014CF60 File Offset: 0x0014B160
			// (set) Token: 0x06004C3A RID: 19514 RVA: 0x0001C958 File Offset: 0x0001AB58
			public unsafe int _numDetailAxialRings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailAxialRings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailAxialRings)) = value;
				}
			}

			// Token: 0x170019AA RID: 6570
			// (get) Token: 0x06004C3B RID: 19515 RVA: 0x0014CF88 File Offset: 0x0014B188
			// (set) Token: 0x06004C3C RID: 19516 RVA: 0x0001C973 File Offset: 0x0001AB73
			public unsafe int _numDetailSliceRings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailSliceRings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailSliceRings)) = value;
				}
			}

			// Token: 0x170019AB RID: 6571
			// (get) Token: 0x06004C3D RID: 19517 RVA: 0x0014CFB0 File Offset: 0x0014B1B0
			// (set) Token: 0x06004C3E RID: 19518 RVA: 0x0001C98E File Offset: 0x0001AB8E
			public unsafe float _radiusAdd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__radiusAdd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SphereShape3D.WireRenderDescriptor.NativeFieldInfoPtr__radiusAdd)) = value;
				}
			}

			// Token: 0x04003B2A RID: 15146
			private static readonly IntPtr NativeFieldInfoPtr__wireMode;

			// Token: 0x04003B2B RID: 15147
			private static readonly IntPtr NativeFieldInfoPtr__numDetailAxialRings;

			// Token: 0x04003B2C RID: 15148
			private static readonly IntPtr NativeFieldInfoPtr__numDetailSliceRings;

			// Token: 0x04003B2D RID: 15149
			private static readonly IntPtr NativeFieldInfoPtr__radiusAdd;

			// Token: 0x04003B2E RID: 15150
			private static readonly IntPtr NativeMethodInfoPtr_get_WireMode_Public_get_WireRenderMode_0;

			// Token: 0x04003B2F RID: 15151
			private static readonly IntPtr NativeMethodInfoPtr_set_WireMode_Public_set_Void_WireRenderMode_0;

			// Token: 0x04003B30 RID: 15152
			private static readonly IntPtr NativeMethodInfoPtr_get_NumDetailAxialRings_Public_get_Int32_0;

			// Token: 0x04003B31 RID: 15153
			private static readonly IntPtr NativeMethodInfoPtr_set_NumDetailAxialRings_Public_set_Void_Int32_0;

			// Token: 0x04003B32 RID: 15154
			private static readonly IntPtr NativeMethodInfoPtr_get_NumDetailSliceRings_Public_get_Int32_0;

			// Token: 0x04003B33 RID: 15155
			private static readonly IntPtr NativeMethodInfoPtr_set_NumDetailSliceRings_Public_set_Void_Int32_0;

			// Token: 0x04003B34 RID: 15156
			private static readonly IntPtr NativeMethodInfoPtr_get_RadiusAdd_Public_get_Single_0;

			// Token: 0x04003B35 RID: 15157
			private static readonly IntPtr NativeMethodInfoPtr_set_RadiusAdd_Public_set_Void_Single_0;

			// Token: 0x04003B36 RID: 15158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
