using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DE RID: 478
	public class EqTriangle2D : Shape2D
	{
		// Token: 0x06002626 RID: 9766 RVA: 0x000B81C0 File Offset: 0x000B63C0
		// Note: this type is marked as 'beforefieldinit'.
		static EqTriangle2D()
		{
			Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "EqTriangle2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr);
			EqTriangle2D.NativeFieldInfoPtr__sideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, "_sideLength");
			EqTriangle2D.NativeFieldInfoPtr__rotationDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, "_rotationDegrees");
			EqTriangle2D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, "_epsilon");
			EqTriangle2D.NativeFieldInfoPtr__points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, "_points");
			EqTriangle2D.NativeFieldInfoPtr__centroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, "_centroid");
			EqTriangle2D.NativeFieldInfoPtr__arePointsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, "_arePointsDirty");
			EqTriangle2D.NativeMethodInfoPtr_get_SideLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669058);
			EqTriangle2D.NativeMethodInfoPtr_set_SideLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669059);
			EqTriangle2D.NativeMethodInfoPtr_get_Centroid_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669060);
			EqTriangle2D.NativeMethodInfoPtr_set_Centroid_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669061);
			EqTriangle2D.NativeMethodInfoPtr_get_Altitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669062);
			EqTriangle2D.NativeMethodInfoPtr_get_CentroidAltitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669063);
			EqTriangle2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669064);
			EqTriangle2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669065);
			EqTriangle2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669066);
			EqTriangle2D.NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669067);
			EqTriangle2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669068);
			EqTriangle2D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669069);
			EqTriangle2D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669070);
			EqTriangle2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669071);
			EqTriangle2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669072);
			EqTriangle2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669073);
			EqTriangle2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669074);
			EqTriangle2D.NativeMethodInfoPtr_get_ModelCentroid_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669075);
			EqTriangle2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669085);
			EqTriangle2D.NativeMethodInfoPtr_GetPoint_Public_Vector2_EqTrianglePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669076);
			EqTriangle2D.NativeMethodInfoPtr_SetPoint_Public_Void_EqTrianglePoint_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669077);
			EqTriangle2D.NativeMethodInfoPtr_GetEdgeMidPoint_Public_Vector2_EqTriangleEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669078);
			EqTriangle2D.NativeMethodInfoPtr_GetEdge_Public_Vector2_EqTriangleEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669079);
			EqTriangle2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669080);
			EqTriangle2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669081);
			EqTriangle2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669082);
			EqTriangle2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669083);
			EqTriangle2D.NativeMethodInfoPtr_OnPointsFoundDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr, 100669084);
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x000B8498 File Offset: 0x000B6698
		// (set) Token: 0x06002628 RID: 9768 RVA: 0x000B84D4 File Offset: 0x000B66D4
		public unsafe float SideLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_SideLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_set_SideLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x000B8514 File Offset: 0x000B6714
		// (set) Token: 0x0600262A RID: 9770 RVA: 0x000B8554 File Offset: 0x000B6754
		public unsafe Vector2 Centroid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_Centroid_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_set_Centroid_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x000B8598 File Offset: 0x000B6798
		public unsafe float Altitude
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89818, XrefRangeEnd = 89825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_Altitude_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x000B85D4 File Offset: 0x000B67D4
		public unsafe float CentroidAltitude
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89825, XrefRangeEnd = 89832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_CentroidAltitude_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x000B8610 File Offset: 0x000B6810
		// (set) Token: 0x0600262E RID: 9774 RVA: 0x000B864C File Offset: 0x000B684C
		public unsafe float RotationDegrees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x0600262F RID: 9775 RVA: 0x000B868C File Offset: 0x000B688C
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89832, XrefRangeEnd = 89835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x000B86CC File Offset: 0x000B68CC
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x000B870C File Offset: 0x000B690C
		public unsafe TriangleEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TriangleEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x000B8750 File Offset: 0x000B6950
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x000B878C File Offset: 0x000B698C
		public unsafe float AreaEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89835, XrefRangeEnd = 89836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x000B87CC File Offset: 0x000B69CC
		public unsafe Vector2 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89836, XrefRangeEnd = 89842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x000B880C File Offset: 0x000B6A0C
		public unsafe Vector2 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89842, XrefRangeEnd = 89848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x000B884C File Offset: 0x000B6A4C
		public unsafe static Vector2 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x000B8880 File Offset: 0x000B6A80
		public unsafe static Vector2 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x000B88B4 File Offset: 0x000B6AB4
		public unsafe static Vector2 ModelCentroid
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 89172, RefRangeEnd = 89203, XrefRangeStart = 89172, XrefRangeEnd = 89203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_get_ModelCentroid_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x000B88E8 File Offset: 0x000B6AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89848, XrefRangeEnd = 89855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EqTriangle2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqTriangle2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000B8924 File Offset: 0x000B6B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89855, XrefRangeEnd = 89856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPoint(EqTrianglePoint point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_GetPoint_Public_Vector2_EqTrianglePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000B8974 File Offset: 0x000B6B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89856, XrefRangeEnd = 89857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPoint(EqTrianglePoint point, Vector2 pointValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_SetPoint_Public_Void_EqTrianglePoint_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000B89C8 File Offset: 0x000B6BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89857, XrefRangeEnd = 89864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetEdgeMidPoint(EqTriangleEdge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_GetEdgeMidPoint_Public_Vector2_EqTriangleEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000B8A18 File Offset: 0x000B6C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89866, RefRangeEnd = 89867, XrefRangeStart = 89864, XrefRangeEnd = 89866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetEdge(EqTriangleEdge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_GetEdge_Public_Vector2_EqTriangleEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x000B8A68 File Offset: 0x000B6C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89867, XrefRangeEnd = 89884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderArea(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqTriangle2D.NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000B8AB8 File Offset: 0x000B6CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89884, XrefRangeEnd = 89903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderBorder(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqTriangle2D.NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000B8B08 File Offset: 0x000B6D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89903, XrefRangeEnd = 89910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqTriangle2D.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000B8B60 File Offset: 0x000B6D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89910, XrefRangeEnd = 89912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetEncapsulatingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqTriangle2D.NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000B8BAC File Offset: 0x000B6DAC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 89926, RefRangeEnd = 89943, XrefRangeStart = 89912, XrefRangeEnd = 89926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointsFoundDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle2D.NativeMethodInfoPtr_OnPointsFoundDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x0000F68A File Offset: 0x0000D88A
		public EqTriangle2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x000B8BE0 File Offset: 0x000B6DE0
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x0000F693 File Offset: 0x0000D893
		public unsafe float _sideLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__sideLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__sideLength)) = value;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x000B8C08 File Offset: 0x000B6E08
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x0000F6AE File Offset: 0x0000D8AE
		public unsafe float _rotationDegrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__rotationDegrees);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__rotationDegrees)) = value;
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x000B8C30 File Offset: 0x000B6E30
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x0000F6C9 File Offset: 0x0000D8C9
		public unsafe TriangleEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriangleEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x000B8C60 File Offset: 0x000B6E60
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x0000F6E8 File Offset: 0x0000D8E8
		public unsafe Il2CppStructArray<Vector2> _points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x000B8C90 File Offset: 0x000B6E90
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x0000F707 File Offset: 0x0000D907
		public unsafe Vector2 _centroid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__centroid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__centroid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x000B8CC0 File Offset: 0x000B6EC0
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x0000F726 File Offset: 0x0000D926
		public unsafe bool _arePointsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__arePointsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle2D.NativeFieldInfoPtr__arePointsDirty)) = value;
			}
		}

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeFieldInfoPtr__sideLength;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeFieldInfoPtr__rotationDegrees;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeFieldInfoPtr__points;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeFieldInfoPtr__centroid;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeFieldInfoPtr__arePointsDirty;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_get_SideLength_Public_get_Single_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_set_SideLength_Public_set_Void_Single_0;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_get_Centroid_Public_get_Vector2_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr_set_Centroid_Public_set_Void_Vector2_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr_get_Altitude_Public_get_Single_0;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeMethodInfoPtr_get_CentroidAltitude_Public_get_Single_0;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector2_0;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector2_0;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector2_0;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector2_0;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCentroid_Public_Static_get_Vector2_0;

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Public_Vector2_EqTrianglePoint_0;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeMethodInfoPtr_SetPoint_Public_Void_EqTrianglePoint_Vector2_0;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeMethodInfoPtr_GetEdgeMidPoint_Public_Vector2_EqTriangleEdge_0;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeMethodInfoPtr_GetEdge_Public_Vector2_EqTriangleEdge_0;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeMethodInfoPtr_RenderArea_Public_Virtual_Void_Camera_0;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr_RenderBorder_Public_Virtual_Void_Camera_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_Boolean_Vector2_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_GetEncapsulatingRect_Public_Virtual_Rect_0;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeMethodInfoPtr_OnPointsFoundDirty_Private_Void_0;
	}
}
