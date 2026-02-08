using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F0 RID: 496
	public class TorusShape3D : Shape3D
	{
		// Token: 0x06002827 RID: 10279 RVA: 0x000C0CE4 File Offset: 0x000BEEE4
		// Note: this type is marked as 'beforefieldinit'.
		static TorusShape3D()
		{
			Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TorusShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr);
			TorusShape3D.NativeFieldInfoPtr__coreRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, "_coreRadius");
			TorusShape3D.NativeFieldInfoPtr__tubeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, "_tubeRadius");
			TorusShape3D.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, "_center");
			TorusShape3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, "_rotation");
			TorusShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, "_epsilon");
			TorusShape3D.NativeFieldInfoPtr__wireRenderDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, "_wireRenderDesc");
			TorusShape3D.NativeMethodInfoPtr_get_CoreRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669434);
			TorusShape3D.NativeMethodInfoPtr_set_CoreRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669435);
			TorusShape3D.NativeMethodInfoPtr_get_TubeRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669436);
			TorusShape3D.NativeMethodInfoPtr_set_TubeRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669437);
			TorusShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669438);
			TorusShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669439);
			TorusShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669440);
			TorusShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669441);
			TorusShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669442);
			TorusShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669443);
			TorusShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669444);
			TorusShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_TorusEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669445);
			TorusShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TorusEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669446);
			TorusShape3D.NativeMethodInfoPtr_get_TubeRadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669447);
			TorusShape3D.NativeMethodInfoPtr_set_TubeRadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669448);
			TorusShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669449);
			TorusShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669450);
			TorusShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669451);
			TorusShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669452);
			TorusShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669453);
			TorusShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669459);
			TorusShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669454);
			TorusShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669455);
			TorusShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669456);
			TorusShape3D.NativeMethodInfoPtr_GetHrzExtents_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669457);
			TorusShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, 100669458);
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x000C0F94 File Offset: 0x000BF194
		// (set) Token: 0x06002829 RID: 10281 RVA: 0x000C0FD0 File Offset: 0x000BF1D0
		public unsafe float CoreRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_CoreRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_set_CoreRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x000C1010 File Offset: 0x000BF210
		// (set) Token: 0x0600282B RID: 10283 RVA: 0x000C104C File Offset: 0x000BF24C
		public unsafe float TubeRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_TubeRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89737, RefRangeEnd = 89740, XrefRangeStart = 89737, XrefRangeEnd = 89740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_set_TubeRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x000C108C File Offset: 0x000BF28C
		// (set) Token: 0x0600282D RID: 10285 RVA: 0x000C10CC File Offset: 0x000BF2CC
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x000C1110 File Offset: 0x000BF310
		// (set) Token: 0x0600282F RID: 10287 RVA: 0x000C1150 File Offset: 0x000BF350
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x000C1194 File Offset: 0x000BF394
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x000C11D4 File Offset: 0x000BF3D4
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x000C1214 File Offset: 0x000BF414
		public unsafe Vector3 Look
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x000C1254 File Offset: 0x000BF454
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x000C1294 File Offset: 0x000BF494
		public unsafe TorusEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_TorusEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TorusEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x000C12D8 File Offset: 0x000BF4D8
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x000C1314 File Offset: 0x000BF514
		public unsafe float TubeRadiusEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_TubeRadiusEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89161, RefRangeEnd = 89164, XrefRangeStart = 89161, XrefRangeEnd = 89164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_set_TubeRadiusEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x000C1354 File Offset: 0x000BF554
		public unsafe TorusShape3D.WireRenderDescriptor WireRenderDesc
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TorusShape3D.WireRenderDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002838 RID: 10296 RVA: 0x000C1394 File Offset: 0x000BF594
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x000C13C8 File Offset: 0x000BF5C8
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x000C13FC File Offset: 0x000BF5FC
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x000C1430 File Offset: 0x000BF630
		public unsafe static Vector3 ModelCenter
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x000C1464 File Offset: 0x000BF664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90759, RefRangeEnd = 90760, XrefRangeStart = 90749, XrefRangeEnd = 90759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TorusShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000C14A0 File Offset: 0x000BF6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90760, XrefRangeEnd = 90761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TorusShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000C1508 File Offset: 0x000BF708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90761, XrefRangeEnd = 90775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TorusShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000C1544 File Offset: 0x000BF744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90775, XrefRangeEnd = 90818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TorusShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000C1580 File Offset: 0x000BF780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90818, XrefRangeEnd = 90819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetHrzExtents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.NativeMethodInfoPtr_GetHrzExtents_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000C15C0 File Offset: 0x000BF7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90819, XrefRangeEnd = 90822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TorusShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x0000FEAD File Offset: 0x0000E0AD
		public TorusShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x000C160C File Offset: 0x000BF80C
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x0000FEB6 File Offset: 0x0000E0B6
		public unsafe float _coreRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__coreRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__coreRadius)) = value;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x000C1634 File Offset: 0x000BF834
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x0000FED1 File Offset: 0x0000E0D1
		public unsafe float _tubeRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__tubeRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__tubeRadius)) = value;
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x000C165C File Offset: 0x000BF85C
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		public unsafe Vector3 _center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x000C168C File Offset: 0x000BF88C
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x0000FF0B File Offset: 0x0000E10B
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x000C16BC File Offset: 0x000BF8BC
		// (set) Token: 0x0600284C RID: 10316 RVA: 0x0000FF2A File Offset: 0x0000E12A
		public unsafe TorusEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TorusEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x0600284D RID: 10317 RVA: 0x000C16EC File Offset: 0x000BF8EC
		// (set) Token: 0x0600284E RID: 10318 RVA: 0x0000FF49 File Offset: 0x0000E149
		public unsafe TorusShape3D.WireRenderDescriptor _wireRenderDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__wireRenderDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TorusShape3D.WireRenderDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.NativeFieldInfoPtr__wireRenderDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeFieldInfoPtr__coreRadius;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeFieldInfoPtr__tubeRadius;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeFieldInfoPtr__wireRenderDesc;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeMethodInfoPtr_get_CoreRadius_Public_get_Single_0;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeMethodInfoPtr_set_CoreRadius_Public_set_Void_Single_0;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeMethodInfoPtr_get_TubeRadius_Public_get_Single_0;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeMethodInfoPtr_set_TubeRadius_Public_set_Void_Single_0;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_TorusEpsilon_0;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TorusEpsilon_0;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeMethodInfoPtr_get_TubeRadiusEps_Public_get_Single_0;

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeMethodInfoPtr_set_TubeRadiusEps_Public_set_Void_Single_0;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr_GetHrzExtents_Public_List_1_Vector3_0;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;

		// Token: 0x020003BD RID: 957
		public enum WireRenderFlags
		{
			// Token: 0x04003B38 RID: 15160
			None,
			// Token: 0x04003B39 RID: 15161
			TubeSlices,
			// Token: 0x04003B3A RID: 15162
			AxialSlices,
			// Token: 0x04003B3B RID: 15163
			All
		}

		// Token: 0x020003BE RID: 958
		public class WireRenderDescriptor : global::Il2CppSystem.Object
		{
			// Token: 0x06004C3F RID: 19519 RVA: 0x0014CFD8 File Offset: 0x0014B1D8
			// Note: this type is marked as 'beforefieldinit'.
			static WireRenderDescriptor()
			{
				Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TorusShape3D>.NativeClassPtr, "WireRenderDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr);
				TorusShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, "_wireFlags");
				TorusShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numTubeSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, "_numTubeSlices");
				TorusShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numAxialSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, "_numAxialSlices");
				TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumTubeSlices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, 100669460);
				TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumTubeSlices_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, 100669461);
				TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumAxialSlices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, 100669462);
				TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumAxialSlices_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, 100669463);
				TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireFlags_Public_get_WireRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, 100669464);
				TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireFlags_Public_set_Void_WireRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, 100669465);
				TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr, 100669466);
			}

			// Token: 0x170019B3 RID: 6579
			// (get) Token: 0x06004C40 RID: 19520 RVA: 0x0014D0CC File Offset: 0x0014B2CC
			// (set) Token: 0x06004C41 RID: 19521 RVA: 0x0014D108 File Offset: 0x0014B308
			public unsafe int NumTubeSlices
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumTubeSlices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 90747, RefRangeEnd = 90748, XrefRangeStart = 90747, XrefRangeEnd = 90747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumTubeSlices_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170019B4 RID: 6580
			// (get) Token: 0x06004C42 RID: 19522 RVA: 0x0014D148 File Offset: 0x0014B348
			// (set) Token: 0x06004C43 RID: 19523 RVA: 0x0014D184 File Offset: 0x0014B384
			public unsafe int NumAxialSlices
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumAxialSlices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumAxialSlices_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170019B5 RID: 6581
			// (get) Token: 0x06004C44 RID: 19524 RVA: 0x0014D1C4 File Offset: 0x0014B3C4
			// (set) Token: 0x06004C45 RID: 19525 RVA: 0x0014D200 File Offset: 0x0014B400
			public unsafe TorusShape3D.WireRenderFlags WireFlags
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireFlags_Public_get_WireRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireFlags_Public_set_Void_WireRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004C46 RID: 19526 RVA: 0x0014D240 File Offset: 0x0014B440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90748, XrefRangeEnd = 90749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WireRenderDescriptor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TorusShape3D.WireRenderDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TorusShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C47 RID: 19527 RVA: 0x0001C9A9 File Offset: 0x0001ABA9
			public WireRenderDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019B0 RID: 6576
			// (get) Token: 0x06004C48 RID: 19528 RVA: 0x0014D27C File Offset: 0x0014B47C
			// (set) Token: 0x06004C49 RID: 19529 RVA: 0x0001C9B2 File Offset: 0x0001ABB2
			public unsafe TorusShape3D.WireRenderFlags _wireFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireFlags)) = value;
				}
			}

			// Token: 0x170019B1 RID: 6577
			// (get) Token: 0x06004C4A RID: 19530 RVA: 0x0014D2A4 File Offset: 0x0014B4A4
			// (set) Token: 0x06004C4B RID: 19531 RVA: 0x0001C9CD File Offset: 0x0001ABCD
			public unsafe int _numTubeSlices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numTubeSlices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numTubeSlices)) = value;
				}
			}

			// Token: 0x170019B2 RID: 6578
			// (get) Token: 0x06004C4C RID: 19532 RVA: 0x0014D2CC File Offset: 0x0014B4CC
			// (set) Token: 0x06004C4D RID: 19533 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
			public unsafe int _numAxialSlices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numAxialSlices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TorusShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numAxialSlices)) = value;
				}
			}

			// Token: 0x04003B3C RID: 15164
			private static readonly IntPtr NativeFieldInfoPtr__wireFlags;

			// Token: 0x04003B3D RID: 15165
			private static readonly IntPtr NativeFieldInfoPtr__numTubeSlices;

			// Token: 0x04003B3E RID: 15166
			private static readonly IntPtr NativeFieldInfoPtr__numAxialSlices;

			// Token: 0x04003B3F RID: 15167
			private static readonly IntPtr NativeMethodInfoPtr_get_NumTubeSlices_Public_get_Int32_0;

			// Token: 0x04003B40 RID: 15168
			private static readonly IntPtr NativeMethodInfoPtr_set_NumTubeSlices_Public_set_Void_Int32_0;

			// Token: 0x04003B41 RID: 15169
			private static readonly IntPtr NativeMethodInfoPtr_get_NumAxialSlices_Public_get_Int32_0;

			// Token: 0x04003B42 RID: 15170
			private static readonly IntPtr NativeMethodInfoPtr_set_NumAxialSlices_Public_set_Void_Int32_0;

			// Token: 0x04003B43 RID: 15171
			private static readonly IntPtr NativeMethodInfoPtr_get_WireFlags_Public_get_WireRenderFlags_0;

			// Token: 0x04003B44 RID: 15172
			private static readonly IntPtr NativeMethodInfoPtr_set_WireFlags_Public_set_Void_WireRenderFlags_0;

			// Token: 0x04003B45 RID: 15173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
