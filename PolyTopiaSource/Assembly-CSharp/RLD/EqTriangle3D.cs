using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DF RID: 479
	public class EqTriangle3D : Shape3D
	{
		// Token: 0x06002650 RID: 9808 RVA: 0x000B8CE8 File Offset: 0x000B6EE8
		// Note: this type is marked as 'beforefieldinit'.
		static EqTriangle3D()
		{
			Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "EqTriangle3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr);
			EqTriangle3D.NativeFieldInfoPtr__sideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, "_sideLength");
			EqTriangle3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, "_rotation");
			EqTriangle3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, "_epsilon");
			EqTriangle3D.NativeFieldInfoPtr__points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, "_points");
			EqTriangle3D.NativeFieldInfoPtr__centroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, "_centroid");
			EqTriangle3D.NativeFieldInfoPtr__arePointsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, "_arePointsDirty");
			EqTriangle3D.NativeMethodInfoPtr_get_SideLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669086);
			EqTriangle3D.NativeMethodInfoPtr_set_SideLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669087);
			EqTriangle3D.NativeMethodInfoPtr_get_Centroid_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669088);
			EqTriangle3D.NativeMethodInfoPtr_set_Centroid_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669089);
			EqTriangle3D.NativeMethodInfoPtr_get_Altitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669090);
			EqTriangle3D.NativeMethodInfoPtr_get_CentroidAltitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669091);
			EqTriangle3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669092);
			EqTriangle3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669093);
			EqTriangle3D.NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669094);
			EqTriangle3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669095);
			EqTriangle3D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669096);
			EqTriangle3D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669097);
			EqTriangle3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669098);
			EqTriangle3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669099);
			EqTriangle3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669100);
			EqTriangle3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669101);
			EqTriangle3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669102);
			EqTriangle3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669103);
			EqTriangle3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669104);
			EqTriangle3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669105);
			EqTriangle3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669106);
			EqTriangle3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669107);
			EqTriangle3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669108);
			EqTriangle3D.NativeMethodInfoPtr_get_ModelCentroid_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669109);
			EqTriangle3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669123);
			EqTriangle3D.NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669110);
			EqTriangle3D.NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669111);
			EqTriangle3D.NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669112);
			EqTriangle3D.NativeMethodInfoPtr_GetPoint_Public_Vector3_EqTrianglePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669113);
			EqTriangle3D.NativeMethodInfoPtr_SetPoint_Public_Void_EqTrianglePoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669114);
			EqTriangle3D.NativeMethodInfoPtr_GetEdgeMidPoint_Public_Vector3_EqTriangleEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669115);
			EqTriangle3D.NativeMethodInfoPtr_GetEdge_Public_Vector3_EqTriangleEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669116);
			EqTriangle3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669117);
			EqTriangle3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669118);
			EqTriangle3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669119);
			EqTriangle3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669120);
			EqTriangle3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669121);
			EqTriangle3D.NativeMethodInfoPtr_OnPointsFoundDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr, 100669122);
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x000B9088 File Offset: 0x000B7288
		// (set) Token: 0x06002652 RID: 9810 RVA: 0x000B90C4 File Offset: 0x000B72C4
		public unsafe float SideLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_SideLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_set_SideLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x000B9104 File Offset: 0x000B7304
		// (set) Token: 0x06002654 RID: 9812 RVA: 0x000B9144 File Offset: 0x000B7344
		public unsafe Vector3 Centroid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_Centroid_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_set_Centroid_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x000B9188 File Offset: 0x000B7388
		public unsafe float Altitude
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89943, XrefRangeEnd = 89950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_Altitude_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x000B91C4 File Offset: 0x000B73C4
		public unsafe float CentroidAltitude
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89950, XrefRangeEnd = 89957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_CentroidAltitude_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x000B9200 File Offset: 0x000B7400
		// (set) Token: 0x06002658 RID: 9816 RVA: 0x000B9240 File Offset: 0x000B7440
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x000B9284 File Offset: 0x000B7484
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x000B92C4 File Offset: 0x000B74C4
		public unsafe TriangleEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x000B9308 File Offset: 0x000B7508
		// (set) Token: 0x0600265C RID: 9820 RVA: 0x000B9344 File Offset: 0x000B7544
		public unsafe float AreaEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89957, XrefRangeEnd = 89958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x000B9384 File Offset: 0x000B7584
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x000B93C0 File Offset: 0x000B75C0
		public unsafe float ExtrudeEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89958, XrefRangeEnd = 89959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x000B9400 File Offset: 0x000B7600
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x000B943C File Offset: 0x000B763C
		public unsafe float WireEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89959, XrefRangeEnd = 89960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x000B947C File Offset: 0x000B767C
		public unsafe Vector3 Normal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89960, XrefRangeEnd = 89963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x000B94BC File Offset: 0x000B76BC
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89963, XrefRangeEnd = 89966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x000B94FC File Offset: 0x000B76FC
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89966, XrefRangeEnd = 89969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x000B953C File Offset: 0x000B773C
		public unsafe Vector3 Look
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x000B957C File Offset: 0x000B777C
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x000B95B0 File Offset: 0x000B77B0
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x000B95E4 File Offset: 0x000B77E4
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x000B9618 File Offset: 0x000B7818
		public unsafe static Vector3 ModelCentroid
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_get_ModelCentroid_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000B964C File Offset: 0x000B784C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89969, XrefRangeEnd = 89978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EqTriangle3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqTriangle3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x000B9688 File Offset: 0x000B7888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89978, XrefRangeEnd = 89985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignNormal(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x000B96CC File Offset: 0x000B78CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89985, XrefRangeEnd = 89992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignRight(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000B9710 File Offset: 0x000B7910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89992, XrefRangeEnd = 89999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignUp(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x000B9754 File Offset: 0x000B7954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89999, XrefRangeEnd = 90000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPoint(EqTrianglePoint point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_GetPoint_Public_Vector3_EqTrianglePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x000B97A4 File Offset: 0x000B79A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90000, XrefRangeEnd = 90001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPoint(EqTrianglePoint point, Vector3 pointValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_SetPoint_Public_Void_EqTrianglePoint_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x000B97F8 File Offset: 0x000B79F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90001, XrefRangeEnd = 90007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetEdgeMidPoint(EqTriangleEdge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_GetEdgeMidPoint_Public_Vector3_EqTriangleEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x000B9848 File Offset: 0x000B7A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90009, RefRangeEnd = 90010, XrefRangeStart = 90007, XrefRangeEnd = 90009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetEdge(EqTriangleEdge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_GetEdge_Public_Vector3_EqTriangleEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000B9898 File Offset: 0x000B7A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90010, XrefRangeEnd = 90022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqTriangle3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000B98D4 File Offset: 0x000B7AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90022, XrefRangeEnd = 90034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqTriangle3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000B9910 File Offset: 0x000B7B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90034, XrefRangeEnd = 90041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqTriangle3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x000B9978 File Offset: 0x000B7B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90041, XrefRangeEnd = 90048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqTriangle3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x000B99E0 File Offset: 0x000B7BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90048, XrefRangeEnd = 90050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqTriangle3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x000B9A2C File Offset: 0x000B7C2C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 90061, RefRangeEnd = 90073, XrefRangeStart = 90050, XrefRangeEnd = 90061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointsFoundDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqTriangle3D.NativeMethodInfoPtr_OnPointsFoundDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x0000F741 File Offset: 0x0000D941
		public EqTriangle3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x000B9A60 File Offset: 0x000B7C60
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x0000F74A File Offset: 0x0000D94A
		public unsafe float _sideLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__sideLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__sideLength)) = value;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x000B9A88 File Offset: 0x000B7C88
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x0000F765 File Offset: 0x0000D965
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x000B9AB8 File Offset: 0x000B7CB8
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x0000F784 File Offset: 0x0000D984
		public unsafe TriangleEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriangleEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x000B9AE8 File Offset: 0x000B7CE8
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x0000F7A3 File Offset: 0x0000D9A3
		public unsafe Il2CppStructArray<Vector3> _points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x000B9B18 File Offset: 0x000B7D18
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x0000F7C2 File Offset: 0x0000D9C2
		public unsafe Vector3 _centroid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__centroid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__centroid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x000B9B48 File Offset: 0x000B7D48
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x0000F7E1 File Offset: 0x0000D9E1
		public unsafe bool _arePointsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__arePointsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqTriangle3D.NativeFieldInfoPtr__arePointsDirty)) = value;
			}
		}

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeFieldInfoPtr__sideLength;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeFieldInfoPtr__points;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeFieldInfoPtr__centroid;

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeFieldInfoPtr__arePointsDirty;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeMethodInfoPtr_get_SideLength_Public_get_Single_0;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeMethodInfoPtr_set_SideLength_Public_set_Void_Single_0;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_get_Centroid_Public_get_Vector3_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_set_Centroid_Public_set_Void_Vector3_0;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr_get_Altitude_Public_get_Single_0;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeMethodInfoPtr_get_CentroidAltitude_Public_get_Single_0;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCentroid_Public_Static_get_Vector3_0;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Public_Vector3_EqTrianglePoint_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr_SetPoint_Public_Void_EqTrianglePoint_Vector3_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_GetEdgeMidPoint_Public_Vector3_EqTriangleEdge_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_GetEdge_Public_Vector3_EqTriangleEdge_0;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr_OnPointsFoundDirty_Private_Void_0;
	}
}
