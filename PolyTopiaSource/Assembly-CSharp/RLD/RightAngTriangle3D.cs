using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E5 RID: 485
	public class RightAngTriangle3D : Shape3D
	{
		// Token: 0x06002771 RID: 10097 RVA: 0x000BDBA0 File Offset: 0x000BBDA0
		// Note: this type is marked as 'beforefieldinit'.
		static RightAngTriangle3D()
		{
			Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RightAngTriangle3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr);
			RightAngTriangle3D.NativeFieldInfoPtr__rightAngleCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, "_rightAngleCorner");
			RightAngTriangle3D.NativeFieldInfoPtr__XLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, "_XLength");
			RightAngTriangle3D.NativeFieldInfoPtr__YLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, "_YLength");
			RightAngTriangle3D.NativeFieldInfoPtr__XLengthSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, "_XLengthSign");
			RightAngTriangle3D.NativeFieldInfoPtr__YLengthSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, "_YLengthSign");
			RightAngTriangle3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, "_rotation");
			RightAngTriangle3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, "_epsilon");
			RightAngTriangle3D.NativeFieldInfoPtr__raycastMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, "_raycastMode");
			RightAngTriangle3D.NativeMethodInfoPtr_get_RightAngleCorner_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669301);
			RightAngTriangle3D.NativeMethodInfoPtr_set_RightAngleCorner_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669302);
			RightAngTriangle3D.NativeMethodInfoPtr_get_XLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669303);
			RightAngTriangle3D.NativeMethodInfoPtr_set_XLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669304);
			RightAngTriangle3D.NativeMethodInfoPtr_get_YLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669305);
			RightAngTriangle3D.NativeMethodInfoPtr_set_YLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669306);
			RightAngTriangle3D.NativeMethodInfoPtr_get_RealXLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669307);
			RightAngTriangle3D.NativeMethodInfoPtr_get_RealYLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669308);
			RightAngTriangle3D.NativeMethodInfoPtr_get_XLengthSign_Public_get_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669309);
			RightAngTriangle3D.NativeMethodInfoPtr_set_XLengthSign_Public_set_Void_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669310);
			RightAngTriangle3D.NativeMethodInfoPtr_get_YLengthSign_Public_get_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669311);
			RightAngTriangle3D.NativeMethodInfoPtr_set_YLengthSign_Public_set_Void_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669312);
			RightAngTriangle3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669313);
			RightAngTriangle3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669314);
			RightAngTriangle3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669315);
			RightAngTriangle3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669316);
			RightAngTriangle3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669317);
			RightAngTriangle3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669318);
			RightAngTriangle3D.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669319);
			RightAngTriangle3D.NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669320);
			RightAngTriangle3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669321);
			RightAngTriangle3D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669322);
			RightAngTriangle3D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669323);
			RightAngTriangle3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669324);
			RightAngTriangle3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669325);
			RightAngTriangle3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669326);
			RightAngTriangle3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669327);
			RightAngTriangle3D.NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669328);
			RightAngTriangle3D.NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669329);
			RightAngTriangle3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669330);
			RightAngTriangle3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669331);
			RightAngTriangle3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669332);
			RightAngTriangle3D.NativeMethodInfoPtr_get_ModelRightAngleCorner_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669333);
			RightAngTriangle3D.NativeMethodInfoPtr_get_ModelNormal_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669334);
			RightAngTriangle3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669345);
			RightAngTriangle3D.NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669335);
			RightAngTriangle3D.NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669336);
			RightAngTriangle3D.NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669337);
			RightAngTriangle3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669338);
			RightAngTriangle3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669339);
			RightAngTriangle3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669340);
			RightAngTriangle3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669341);
			RightAngTriangle3D.NativeMethodInfoPtr_GetPoints_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669342);
			RightAngTriangle3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669343);
			RightAngTriangle3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr, 100669344);
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x000BDFF4 File Offset: 0x000BC1F4
		// (set) Token: 0x06002773 RID: 10099 RVA: 0x000BE034 File Offset: 0x000BC234
		public unsafe Vector3 RightAngleCorner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_RightAngleCorner_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_RightAngleCorner_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x000BE078 File Offset: 0x000BC278
		// (set) Token: 0x06002775 RID: 10101 RVA: 0x000BE0B4 File Offset: 0x000BC2B4
		public unsafe float XLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_XLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_XLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x000BE0F4 File Offset: 0x000BC2F4
		// (set) Token: 0x06002777 RID: 10103 RVA: 0x000BE130 File Offset: 0x000BC330
		public unsafe float YLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_YLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_YLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000BE170 File Offset: 0x000BC370
		public unsafe float RealXLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_RealXLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000BE1AC File Offset: 0x000BC3AC
		public unsafe float RealYLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_RealYLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000BE1E8 File Offset: 0x000BC3E8
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x000BE228 File Offset: 0x000BC428
		public unsafe AxisSign XLengthSign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_XLengthSign_Public_get_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_XLengthSign_Public_set_Void_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x000BE26C File Offset: 0x000BC46C
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x000BE2AC File Offset: 0x000BC4AC
		public unsafe AxisSign YLengthSign
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_YLengthSign_Public_get_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_YLengthSign_Public_set_Void_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x000BE2F0 File Offset: 0x000BC4F0
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x000BE330 File Offset: 0x000BC530
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x000BE374 File Offset: 0x000BC574
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90496, XrefRangeEnd = 90499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x000BE3B4 File Offset: 0x000BC5B4
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90499, XrefRangeEnd = 90502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x000BE3F4 File Offset: 0x000BC5F4
		public unsafe Vector3 Look
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90502, XrefRangeEnd = 90505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x000BE434 File Offset: 0x000BC634
		public unsafe Vector3 Normal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x000BE474 File Offset: 0x000BC674
		public unsafe Plane Plane
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90505, XrefRangeEnd = 90510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x000BE4B4 File Offset: 0x000BC6B4
		// (set) Token: 0x06002786 RID: 10118 RVA: 0x000BE4F4 File Offset: 0x000BC6F4
		public unsafe TriangleEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x000BE538 File Offset: 0x000BC738
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x000BE574 File Offset: 0x000BC774
		public unsafe float AreaEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57831, RefRangeEnd = 57832, XrefRangeStart = 57831, XrefRangeEnd = 57832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89461, RefRangeEnd = 89463, XrefRangeStart = 89461, XrefRangeEnd = 89463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000BE5B4 File Offset: 0x000BC7B4
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x000BE5F0 File Offset: 0x000BC7F0
		public unsafe float ExtrudeEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57846, RefRangeEnd = 57847, XrefRangeStart = 57846, XrefRangeEnd = 57847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89464, RefRangeEnd = 89466, XrefRangeStart = 89464, XrefRangeEnd = 89466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x000BE630 File Offset: 0x000BC830
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x000BE66C File Offset: 0x000BC86C
		public unsafe float WireEps
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57861, RefRangeEnd = 57864, XrefRangeStart = 57861, XrefRangeEnd = 57864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90076, RefRangeEnd = 90078, XrefRangeStart = 90076, XrefRangeEnd = 90078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000BE6AC File Offset: 0x000BC8AC
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x000BE6EC File Offset: 0x000BC8EC
		public unsafe Shape3DRaycastMode RaycastMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 28415, RefRangeEnd = 28418, XrefRangeStart = 28415, XrefRangeEnd = 28418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape3DRaycastMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000BE730 File Offset: 0x000BC930
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x000BE764 File Offset: 0x000BC964
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000BE798 File Offset: 0x000BC998
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x000BE7CC File Offset: 0x000BC9CC
		public unsafe static Vector3 ModelRightAngleCorner
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_ModelRightAngleCorner_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x000BE800 File Offset: 0x000BCA00
		public unsafe static Vector3 ModelNormal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_get_ModelNormal_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x000BE834 File Offset: 0x000BCA34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90515, RefRangeEnd = 90517, XrefRangeStart = 90510, XrefRangeEnd = 90515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RightAngTriangle3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightAngTriangle3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x000BE870 File Offset: 0x000BCA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90517, XrefRangeEnd = 90524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignNormal(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x000BE8B4 File Offset: 0x000BCAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90524, XrefRangeEnd = 90531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignRight(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000BE8F8 File Offset: 0x000BCAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90531, XrefRangeEnd = 90538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignUp(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000BE93C File Offset: 0x000BCB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90538, XrefRangeEnd = 90550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightAngTriangle3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x000BE9A4 File Offset: 0x000BCBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90550, XrefRangeEnd = 90562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightAngTriangle3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000BEA0C File Offset: 0x000BCC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90562, XrefRangeEnd = 90575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightAngTriangle3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x000BEA48 File Offset: 0x000BCC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90575, XrefRangeEnd = 90588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightAngTriangle3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x000BEA84 File Offset: 0x000BCC84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 90593, RefRangeEnd = 90597, XrefRangeStart = 90588, XrefRangeEnd = 90593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_GetPoints_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000BEAC4 File Offset: 0x000BCCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90597, XrefRangeEnd = 90599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightAngTriangle3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000BEB10 File Offset: 0x000BCD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90599, XrefRangeEnd = 90611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightAngTriangle3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x0000FBC2 File Offset: 0x0000DDC2
		public RightAngTriangle3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000BEB6C File Offset: 0x000BCD6C
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x0000FBCB File Offset: 0x0000DDCB
		public unsafe Vector3 _rightAngleCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__rightAngleCorner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__rightAngleCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x000BEB9C File Offset: 0x000BCD9C
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x0000FBEA File Offset: 0x0000DDEA
		public unsafe float _XLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__XLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__XLength)) = value;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x000BEBC4 File Offset: 0x000BCDC4
		// (set) Token: 0x060027A5 RID: 10149 RVA: 0x0000FC05 File Offset: 0x0000DE05
		public unsafe float _YLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__YLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__YLength)) = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x000BEBEC File Offset: 0x000BCDEC
		// (set) Token: 0x060027A7 RID: 10151 RVA: 0x0000FC20 File Offset: 0x0000DE20
		public unsafe AxisSign _XLengthSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__XLengthSign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__XLengthSign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x000BEC1C File Offset: 0x000BCE1C
		// (set) Token: 0x060027A9 RID: 10153 RVA: 0x0000FC3F File Offset: 0x0000DE3F
		public unsafe AxisSign _YLengthSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__YLengthSign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisSign>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__YLengthSign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x000BEC4C File Offset: 0x000BCE4C
		// (set) Token: 0x060027AB RID: 10155 RVA: 0x0000FC5E File Offset: 0x0000DE5E
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x000BEC7C File Offset: 0x000BCE7C
		// (set) Token: 0x060027AD RID: 10157 RVA: 0x0000FC7D File Offset: 0x0000DE7D
		public unsafe TriangleEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriangleEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x000BECAC File Offset: 0x000BCEAC
		// (set) Token: 0x060027AF RID: 10159 RVA: 0x0000FC9C File Offset: 0x0000DE9C
		public unsafe Shape3DRaycastMode _raycastMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__raycastMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape3DRaycastMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RightAngTriangle3D.NativeFieldInfoPtr__raycastMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeFieldInfoPtr__rightAngleCorner;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeFieldInfoPtr__XLength;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeFieldInfoPtr__YLength;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeFieldInfoPtr__XLengthSign;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeFieldInfoPtr__YLengthSign;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeFieldInfoPtr__raycastMode;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr_get_RightAngleCorner_Public_get_Vector3_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_set_RightAngleCorner_Public_set_Void_Vector3_0;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeMethodInfoPtr_get_XLength_Public_get_Single_0;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeMethodInfoPtr_set_XLength_Public_set_Void_Single_0;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_get_YLength_Public_get_Single_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_set_YLength_Public_set_Void_Single_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_get_RealXLength_Public_get_Single_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_get_RealYLength_Public_get_Single_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeMethodInfoPtr_get_XLengthSign_Public_get_AxisSign_0;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeMethodInfoPtr_set_XLengthSign_Public_set_Void_AxisSign_0;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeMethodInfoPtr_get_YLengthSign_Public_get_AxisSign_0;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeMethodInfoPtr_set_YLengthSign_Public_set_Void_AxisSign_0;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeMethodInfoPtr_get_Plane_Public_get_Plane_0;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_TriangleEpsilon_0;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_TriangleEpsilon_0;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRightAngleCorner_Public_Static_get_Vector3_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelNormal_Public_Static_get_Vector3_0;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_GetPoints_Public_List_1_Vector3_0;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0;
	}
}
