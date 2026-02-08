using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DB RID: 475
	public class ConeShape3D : Shape3D
	{
		// Token: 0x06002598 RID: 9624 RVA: 0x000B5B58 File Offset: 0x000B3D58
		// Note: this type is marked as 'beforefieldinit'.
		static ConeShape3D()
		{
			Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ConeShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr);
			ConeShape3D.NativeFieldInfoPtr__wireRenderDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, "_wireRenderDesc");
			ConeShape3D.NativeFieldInfoPtr__baseCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, "_baseCenter");
			ConeShape3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, "_rotation");
			ConeShape3D.NativeFieldInfoPtr__baseRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, "_baseRadius");
			ConeShape3D.NativeFieldInfoPtr__height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, "_height");
			ConeShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, "_epsilon");
			ConeShape3D.NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668949);
			ConeShape3D.NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668950);
			ConeShape3D.NativeMethodInfoPtr_get_Tip_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668951);
			ConeShape3D.NativeMethodInfoPtr_set_Tip_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668952);
			ConeShape3D.NativeMethodInfoPtr_get_BaseRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668953);
			ConeShape3D.NativeMethodInfoPtr_set_BaseRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668954);
			ConeShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668955);
			ConeShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668956);
			ConeShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668957);
			ConeShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668958);
			ConeShape3D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668959);
			ConeShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668960);
			ConeShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668961);
			ConeShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668962);
			ConeShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_ConeEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668963);
			ConeShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_ConeEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668964);
			ConeShape3D.NativeMethodInfoPtr_get_HrzEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668965);
			ConeShape3D.NativeMethodInfoPtr_set_HrzEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668966);
			ConeShape3D.NativeMethodInfoPtr_get_VertEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668967);
			ConeShape3D.NativeMethodInfoPtr_set_VertEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668968);
			ConeShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668969);
			ConeShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668970);
			ConeShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668971);
			ConeShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668972);
			ConeShape3D.NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668973);
			ConeShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668981);
			ConeShape3D.NativeMethodInfoPtr_AlignTip_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668974);
			ConeShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668975);
			ConeShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668976);
			ConeShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668977);
			ConeShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668978);
			ConeShape3D.NativeMethodInfoPtr_GetBaseExtents_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668979);
			ConeShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, 100668980);
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x000B5E94 File Offset: 0x000B4094
		// (set) Token: 0x0600259A RID: 9626 RVA: 0x000B5ED4 File Offset: 0x000B40D4
		public unsafe Vector3 BaseCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x000B5F18 File Offset: 0x000B4118
		// (set) Token: 0x0600259C RID: 9628 RVA: 0x000B5F58 File Offset: 0x000B4158
		public unsafe Vector3 Tip
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89444, RefRangeEnd = 89446, XrefRangeStart = 89441, XrefRangeEnd = 89444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_Tip_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89446, XrefRangeEnd = 89449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_set_Tip_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x000B5F9C File Offset: 0x000B419C
		// (set) Token: 0x0600259E RID: 9630 RVA: 0x000B5FD8 File Offset: 0x000B41D8
		public unsafe float BaseRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_BaseRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89449, RefRangeEnd = 89450, XrefRangeStart = 89449, XrefRangeEnd = 89449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_set_BaseRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x000B6018 File Offset: 0x000B4218
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x000B6054 File Offset: 0x000B4254
		public unsafe float Height
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57816, RefRangeEnd = 57817, XrefRangeStart = 57816, XrefRangeEnd = 57817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89450, RefRangeEnd = 89451, XrefRangeStart = 89450, XrefRangeEnd = 89450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x000B6094 File Offset: 0x000B4294
		// (set) Token: 0x060025A2 RID: 9634 RVA: 0x000B60D4 File Offset: 0x000B42D4
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x000B6118 File Offset: 0x000B4318
		public unsafe Vector3 CentralAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89451, XrefRangeEnd = 89454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x000B6158 File Offset: 0x000B4358
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89454, XrefRangeEnd = 89457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x000B6198 File Offset: 0x000B4398
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000B61D8 File Offset: 0x000B43D8
		public unsafe Vector3 Look
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89457, XrefRangeEnd = 89460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x000B6218 File Offset: 0x000B4418
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x000B6258 File Offset: 0x000B4458
		public unsafe ConeEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_ConeEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConeEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_ConeEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x000B629C File Offset: 0x000B449C
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x000B62D8 File Offset: 0x000B44D8
		public unsafe float HrzEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57831, RefRangeEnd = 57832, XrefRangeStart = 57831, XrefRangeEnd = 57832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_HrzEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89461, RefRangeEnd = 89463, XrefRangeStart = 89460, XrefRangeEnd = 89461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_set_HrzEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x000B6318 File Offset: 0x000B4518
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x000B6354 File Offset: 0x000B4554
		public unsafe float VertEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57846, RefRangeEnd = 57847, XrefRangeStart = 57846, XrefRangeEnd = 57847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_VertEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89464, RefRangeEnd = 89466, XrefRangeStart = 89463, XrefRangeEnd = 89464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_set_VertEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x000B6394 File Offset: 0x000B4594
		public unsafe ConeShape3D.WireRenderDescriptor WireRenderDesc
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConeShape3D.WireRenderDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x000B63D4 File Offset: 0x000B45D4
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x000B6408 File Offset: 0x000B4608
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x000B643C File Offset: 0x000B463C
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x000B6470 File Offset: 0x000B4670
		public unsafe static Vector3 ModelBaseCenter
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x000B64A4 File Offset: 0x000B46A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89476, RefRangeEnd = 89477, XrefRangeStart = 89466, XrefRangeEnd = 89476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConeShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x000B64E0 File Offset: 0x000B46E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89484, RefRangeEnd = 89485, XrefRangeStart = 89477, XrefRangeEnd = 89484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTip(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_AlignTip_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x000B6524 File Offset: 0x000B4724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89485, XrefRangeEnd = 89497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConeShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x000B6560 File Offset: 0x000B4760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89497, XrefRangeEnd = 89595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConeShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x000B659C File Offset: 0x000B479C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89595, XrefRangeEnd = 89596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConeShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x000B6604 File Offset: 0x000B4804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89596, XrefRangeEnd = 89597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x000B6654 File Offset: 0x000B4854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89597, XrefRangeEnd = 89598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetBaseExtents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.NativeMethodInfoPtr_GetBaseExtents_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x000B6694 File Offset: 0x000B4894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89598, XrefRangeEnd = 89602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConeShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x0000F47C File Offset: 0x0000D67C
		public ConeShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x000B66E0 File Offset: 0x000B48E0
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x0000F485 File Offset: 0x0000D685
		public unsafe ConeShape3D.WireRenderDescriptor _wireRenderDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__wireRenderDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConeShape3D.WireRenderDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__wireRenderDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x000B6710 File Offset: 0x000B4910
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		public unsafe Vector3 _baseCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__baseCenter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__baseCenter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x000B6740 File Offset: 0x000B4940
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x0000F4C3 File Offset: 0x0000D6C3
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x000B6770 File Offset: 0x000B4970
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x0000F4E2 File Offset: 0x0000D6E2
		public unsafe float _baseRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__baseRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__baseRadius)) = value;
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x000B6798 File Offset: 0x000B4998
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x0000F4FD File Offset: 0x0000D6FD
		public unsafe float _height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__height)) = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x000B67C0 File Offset: 0x000B49C0
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x0000F518 File Offset: 0x0000D718
		public unsafe ConeEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConeEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeFieldInfoPtr__wireRenderDesc;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeFieldInfoPtr__baseCenter;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeFieldInfoPtr__baseRadius;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeFieldInfoPtr__height;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector3_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector3_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_get_Tip_Public_get_Vector3_0;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeMethodInfoPtr_set_Tip_Public_set_Void_Vector3_0;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseRadius_Public_get_Single_0;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseRadius_Public_set_Void_Single_0;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_ConeEpsilon_0;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_ConeEpsilon_0;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeMethodInfoPtr_get_HrzEps_Public_get_Single_0;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeMethodInfoPtr_set_HrzEps_Public_set_Void_Single_0;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeMethodInfoPtr_get_VertEps_Public_get_Single_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeMethodInfoPtr_set_VertEps_Public_set_Void_Single_0;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector3_0;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr_AlignTip_Public_Void_Vector3_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseExtents_Public_List_1_Vector3_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;

		// Token: 0x020003B5 RID: 949
		public enum WireRenderMode
		{
			// Token: 0x04003B00 RID: 15104
			Basic,
			// Token: 0x04003B01 RID: 15105
			Detailed
		}

		// Token: 0x020003B6 RID: 950
		public class WireRenderDescriptor : global::Il2CppSystem.Object
		{
			// Token: 0x06004C03 RID: 19459 RVA: 0x0014C348 File Offset: 0x0014A548
			// Note: this type is marked as 'beforefieldinit'.
			static WireRenderDescriptor()
			{
				Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConeShape3D>.NativeClassPtr, "WireRenderDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr);
				ConeShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, "_wireMode");
				ConeShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailAxialRings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, "_numDetailAxialRings");
				ConeShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailAxialSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, "_numDetailAxialSegments");
				ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireMode_Public_get_WireRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, 100668982);
				ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireMode_Public_set_Void_WireRenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, 100668983);
				ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumDetailAxialRings_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, 100668984);
				ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumDetailAxialRings_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, 100668985);
				ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumDetailAxialSegments_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, 100668986);
				ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumDetailAxialSegments_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, 100668987);
				ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr, 100668988);
			}

			// Token: 0x1700199B RID: 6555
			// (get) Token: 0x06004C04 RID: 19460 RVA: 0x0014C43C File Offset: 0x0014A63C
			// (set) Token: 0x06004C05 RID: 19461 RVA: 0x0014C478 File Offset: 0x0014A678
			public unsafe ConeShape3D.WireRenderMode WireMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireMode_Public_get_WireRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireMode_Public_set_Void_WireRenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700199C RID: 6556
			// (get) Token: 0x06004C06 RID: 19462 RVA: 0x0014C4B8 File Offset: 0x0014A6B8
			// (set) Token: 0x06004C07 RID: 19463 RVA: 0x0014C4F4 File Offset: 0x0014A6F4
			public unsafe int NumDetailAxialRings
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumDetailAxialRings_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumDetailAxialRings_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700199D RID: 6557
			// (get) Token: 0x06004C08 RID: 19464 RVA: 0x0014C534 File Offset: 0x0014A734
			// (set) Token: 0x06004C09 RID: 19465 RVA: 0x0014C570 File Offset: 0x0014A770
			public unsafe int NumDetailAxialSegments
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_NumDetailAxialSegments_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_NumDetailAxialSegments_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004C0A RID: 19466 RVA: 0x0014C5B0 File Offset: 0x0014A7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89440, XrefRangeEnd = 89441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WireRenderDescriptor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConeShape3D.WireRenderDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConeShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C0B RID: 19467 RVA: 0x0001C839 File Offset: 0x0001AA39
			public WireRenderDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001998 RID: 6552
			// (get) Token: 0x06004C0C RID: 19468 RVA: 0x0014C5EC File Offset: 0x0014A7EC
			// (set) Token: 0x06004C0D RID: 19469 RVA: 0x0001C842 File Offset: 0x0001AA42
			public unsafe ConeShape3D.WireRenderMode _wireMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireMode)) = value;
				}
			}

			// Token: 0x17001999 RID: 6553
			// (get) Token: 0x06004C0E RID: 19470 RVA: 0x0014C614 File Offset: 0x0014A814
			// (set) Token: 0x06004C0F RID: 19471 RVA: 0x0001C85D File Offset: 0x0001AA5D
			public unsafe int _numDetailAxialRings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailAxialRings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailAxialRings)) = value;
				}
			}

			// Token: 0x1700199A RID: 6554
			// (get) Token: 0x06004C10 RID: 19472 RVA: 0x0014C63C File Offset: 0x0014A83C
			// (set) Token: 0x06004C11 RID: 19473 RVA: 0x0001C878 File Offset: 0x0001AA78
			public unsafe int _numDetailAxialSegments
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailAxialSegments);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConeShape3D.WireRenderDescriptor.NativeFieldInfoPtr__numDetailAxialSegments)) = value;
				}
			}

			// Token: 0x04003B02 RID: 15106
			private static readonly IntPtr NativeFieldInfoPtr__wireMode;

			// Token: 0x04003B03 RID: 15107
			private static readonly IntPtr NativeFieldInfoPtr__numDetailAxialRings;

			// Token: 0x04003B04 RID: 15108
			private static readonly IntPtr NativeFieldInfoPtr__numDetailAxialSegments;

			// Token: 0x04003B05 RID: 15109
			private static readonly IntPtr NativeMethodInfoPtr_get_WireMode_Public_get_WireRenderMode_0;

			// Token: 0x04003B06 RID: 15110
			private static readonly IntPtr NativeMethodInfoPtr_set_WireMode_Public_set_Void_WireRenderMode_0;

			// Token: 0x04003B07 RID: 15111
			private static readonly IntPtr NativeMethodInfoPtr_get_NumDetailAxialRings_Public_get_Int32_0;

			// Token: 0x04003B08 RID: 15112
			private static readonly IntPtr NativeMethodInfoPtr_set_NumDetailAxialRings_Public_set_Void_Int32_0;

			// Token: 0x04003B09 RID: 15113
			private static readonly IntPtr NativeMethodInfoPtr_get_NumDetailAxialSegments_Public_get_Int32_0;

			// Token: 0x04003B0A RID: 15114
			private static readonly IntPtr NativeMethodInfoPtr_set_NumDetailAxialSegments_Public_set_Void_Int32_0;

			// Token: 0x04003B0B RID: 15115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
