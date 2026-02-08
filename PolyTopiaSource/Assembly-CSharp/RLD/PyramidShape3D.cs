using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E1 RID: 481
	public class PyramidShape3D : Shape3D
	{
		// Token: 0x060026B1 RID: 9905 RVA: 0x000BA694 File Offset: 0x000B8894
		// Note: this type is marked as 'beforefieldinit'.
		static PyramidShape3D()
		{
			Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PyramidShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr);
			PyramidShape3D.NativeFieldInfoPtr__baseCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, "_baseCenter");
			PyramidShape3D.NativeFieldInfoPtr__baseWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, "_baseWidth");
			PyramidShape3D.NativeFieldInfoPtr__baseDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, "_baseDepth");
			PyramidShape3D.NativeFieldInfoPtr__height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, "_height");
			PyramidShape3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, "_rotation");
			PyramidShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, "_epsilon");
			PyramidShape3D.NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669158);
			PyramidShape3D.NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669159);
			PyramidShape3D.NativeMethodInfoPtr_get_Tip_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669160);
			PyramidShape3D.NativeMethodInfoPtr_set_Tip_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669161);
			PyramidShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669162);
			PyramidShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669163);
			PyramidShape3D.NativeMethodInfoPtr_get_BaseWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669164);
			PyramidShape3D.NativeMethodInfoPtr_set_BaseWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669165);
			PyramidShape3D.NativeMethodInfoPtr_get_BaseDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669166);
			PyramidShape3D.NativeMethodInfoPtr_set_BaseDepth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669167);
			PyramidShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669168);
			PyramidShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669169);
			PyramidShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_PyramidEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669170);
			PyramidShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_PyramidEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669171);
			PyramidShape3D.NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669172);
			PyramidShape3D.NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669173);
			PyramidShape3D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669174);
			PyramidShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669175);
			PyramidShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669176);
			PyramidShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669177);
			PyramidShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669178);
			PyramidShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669179);
			PyramidShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669180);
			PyramidShape3D.NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669181);
			PyramidShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669189);
			PyramidShape3D.NativeMethodInfoPtr_PointTipAlongAxis_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669182);
			PyramidShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669183);
			PyramidShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669184);
			PyramidShape3D.NativeMethodInfoPtr_GetBaseCornerPoints_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669185);
			PyramidShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669186);
			PyramidShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669187);
			PyramidShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr, 100669188);
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x000BA9BC File Offset: 0x000B8BBC
		// (set) Token: 0x060026B3 RID: 9907 RVA: 0x000BA9FC File Offset: 0x000B8BFC
		public unsafe Vector3 BaseCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x000BAA40 File Offset: 0x000B8C40
		// (set) Token: 0x060026B5 RID: 9909 RVA: 0x000BAA80 File Offset: 0x000B8C80
		public unsafe Vector3 Tip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90187, XrefRangeEnd = 90190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_Tip_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90190, XrefRangeEnd = 90193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_set_Tip_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x000BAAC4 File Offset: 0x000B8CC4
		// (set) Token: 0x060026B7 RID: 9911 RVA: 0x000BAB04 File Offset: 0x000B8D04
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x000BAB48 File Offset: 0x000B8D48
		// (set) Token: 0x060026B9 RID: 9913 RVA: 0x000BAB84 File Offset: 0x000B8D84
		public unsafe float BaseWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_BaseWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_set_BaseWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x000BABC4 File Offset: 0x000B8DC4
		// (set) Token: 0x060026BB RID: 9915 RVA: 0x000BAC00 File Offset: 0x000B8E00
		public unsafe float BaseDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_BaseDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 88946, RefRangeEnd = 88960, XrefRangeStart = 88946, XrefRangeEnd = 88960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_set_BaseDepth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x000BAC40 File Offset: 0x000B8E40
		// (set) Token: 0x060026BD RID: 9917 RVA: 0x000BAC7C File Offset: 0x000B8E7C
		public unsafe float Height
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90193, RefRangeEnd = 90195, XrefRangeStart = 90193, XrefRangeEnd = 90193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x000BACBC File Offset: 0x000B8EBC
		// (set) Token: 0x060026BF RID: 9919 RVA: 0x000BACFC File Offset: 0x000B8EFC
		public unsafe PyramidEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_PyramidEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PyramidEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_PyramidEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x000BAD40 File Offset: 0x000B8F40
		// (set) Token: 0x060026C1 RID: 9921 RVA: 0x000BAD7C File Offset: 0x000B8F7C
		public unsafe float PtContainEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57816, RefRangeEnd = 57817, XrefRangeStart = 57816, XrefRangeEnd = 57817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90196, RefRangeEnd = 90197, XrefRangeStart = 90195, XrefRangeEnd = 90196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x000BADBC File Offset: 0x000B8FBC
		public unsafe Vector3 CentralAxis
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89763, RefRangeEnd = 89764, XrefRangeStart = 89763, XrefRangeEnd = 89764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000BADFC File Offset: 0x000B8FFC
		public unsafe Vector3 Right
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89759, RefRangeEnd = 89760, XrefRangeStart = 89759, XrefRangeEnd = 89760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x000BAE3C File Offset: 0x000B903C
		public unsafe Vector3 Up
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89763, RefRangeEnd = 89764, XrefRangeStart = 89763, XrefRangeEnd = 89764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000BAE7C File Offset: 0x000B907C
		public unsafe Vector3 Look
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89767, RefRangeEnd = 89768, XrefRangeStart = 89767, XrefRangeEnd = 89768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000BAEBC File Offset: 0x000B90BC
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000BAEF0 File Offset: 0x000B90F0
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x000BAF24 File Offset: 0x000B9124
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000BAF58 File Offset: 0x000B9158
		public unsafe static Vector3 ModelBaseCenter
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x000BAF8C File Offset: 0x000B918C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90202, RefRangeEnd = 90204, XrefRangeStart = 90197, XrefRangeEnd = 90202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PyramidShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PyramidShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x000BAFC8 File Offset: 0x000B91C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90204, XrefRangeEnd = 90211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PointTipAlongAxis(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_PointTipAlongAxis_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x000BB00C File Offset: 0x000B920C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90211, XrefRangeEnd = 90223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PyramidShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x000BB048 File Offset: 0x000B9248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90223, XrefRangeEnd = 90235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PyramidShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000BB084 File Offset: 0x000B9284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90235, XrefRangeEnd = 90236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetBaseCornerPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_GetBaseCornerPoints_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x000BB0C4 File Offset: 0x000B92C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90236, XrefRangeEnd = 90245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PyramidShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000BB110 File Offset: 0x000B9310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90245, XrefRangeEnd = 90246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PyramidShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000BB178 File Offset: 0x000B9378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90246, XrefRangeEnd = 90247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PyramidShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0000F910 File Offset: 0x0000DB10
		public PyramidShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000BB1C8 File Offset: 0x000B93C8
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x0000F919 File Offset: 0x0000DB19
		public unsafe Vector3 _baseCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__baseCenter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__baseCenter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000BB1F8 File Offset: 0x000B93F8
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x0000F938 File Offset: 0x0000DB38
		public unsafe float _baseWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__baseWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__baseWidth)) = value;
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000BB220 File Offset: 0x000B9420
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x0000F953 File Offset: 0x0000DB53
		public unsafe float _baseDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__baseDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__baseDepth)) = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000BB248 File Offset: 0x000B9448
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x0000F96E File Offset: 0x0000DB6E
		public unsafe float _height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__height)) = value;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000BB270 File Offset: 0x000B9470
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x0000F989 File Offset: 0x0000DB89
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x000BB2A0 File Offset: 0x000B94A0
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		public unsafe PyramidEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PyramidEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PyramidShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeFieldInfoPtr__baseCenter;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeFieldInfoPtr__baseWidth;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeFieldInfoPtr__baseDepth;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeFieldInfoPtr__height;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector3_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector3_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr_get_Tip_Public_get_Vector3_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr_set_Tip_Public_set_Void_Vector3_0;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseWidth_Public_get_Single_0;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseWidth_Public_set_Void_Single_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseDepth_Public_get_Single_0;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseDepth_Public_set_Void_Single_0;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_PyramidEpsilon_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_PyramidEpsilon_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector3_0;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeMethodInfoPtr_PointTipAlongAxis_Public_Void_Vector3_0;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseCornerPoints_Public_List_1_Vector3_0;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0;
	}
}
