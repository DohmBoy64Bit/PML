using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E3 RID: 483
	public class QuadShape3D : Shape3D
	{
		// Token: 0x06002710 RID: 10000 RVA: 0x000BC0AC File Offset: 0x000BA2AC
		// Note: this type is marked as 'beforefieldinit'.
		static QuadShape3D()
		{
			Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "QuadShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr);
			QuadShape3D.NativeFieldInfoPtr__raycastMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, "_raycastMode");
			QuadShape3D.NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, "_center");
			QuadShape3D.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, "_size");
			QuadShape3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, "_rotation");
			QuadShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, "_epsilon");
			QuadShape3D.NativeFieldInfoPtr__wireRenderDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, "_wireRenderDesc");
			QuadShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669227);
			QuadShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669228);
			QuadShape3D.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669229);
			QuadShape3D.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669230);
			QuadShape3D.NativeMethodInfoPtr_get_Width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669231);
			QuadShape3D.NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669232);
			QuadShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669233);
			QuadShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669234);
			QuadShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669235);
			QuadShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669236);
			QuadShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669237);
			QuadShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669238);
			QuadShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669239);
			QuadShape3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669240);
			QuadShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669241);
			QuadShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_QuadEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669242);
			QuadShape3D.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669243);
			QuadShape3D.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669244);
			QuadShape3D.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669245);
			QuadShape3D.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669246);
			QuadShape3D.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669247);
			QuadShape3D.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669248);
			QuadShape3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669249);
			QuadShape3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669250);
			QuadShape3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669251);
			QuadShape3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669252);
			QuadShape3D.NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669253);
			QuadShape3D.NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669254);
			QuadShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669255);
			QuadShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669256);
			QuadShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669257);
			QuadShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669258);
			QuadShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669259);
			QuadShape3D.NativeMethodInfoPtr_get_ModelNormal_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669260);
			QuadShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669274);
			QuadShape3D.NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669261);
			QuadShape3D.NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669262);
			QuadShape3D.NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669263);
			QuadShape3D.NativeMethodInfoPtr_GetCornerPoints_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669264);
			QuadShape3D.NativeMethodInfoPtr_GetCornerPosition_Public_Vector3_QuadCorner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669265);
			QuadShape3D.NativeMethodInfoPtr_SetCornerPointPosition_Public_Void_QuadCorner_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669266);
			QuadShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669267);
			QuadShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669268);
			QuadShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669269);
			QuadShape3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669270);
			QuadShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669271);
			QuadShape3D.NativeMethodInfoPtr_GetCorners_Public_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669272);
			QuadShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, 100669273);
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x000BC514 File Offset: 0x000BA714
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x000BC554 File Offset: 0x000BA754
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x000BC598 File Offset: 0x000BA798
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x000BC5D8 File Offset: 0x000BA7D8
		public unsafe Vector2 Size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 90343, RefRangeEnd = 90346, XrefRangeStart = 90342, XrefRangeEnd = 90343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x000BC61C File Offset: 0x000BA81C
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x000BC658 File Offset: 0x000BA858
		public unsafe float Width
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x000BC698 File Offset: 0x000BA898
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x000BC6D4 File Offset: 0x000BA8D4
		public unsafe float Height
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90193, RefRangeEnd = 90195, XrefRangeStart = 90193, XrefRangeEnd = 90195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x000BC714 File Offset: 0x000BA914
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x000BC754 File Offset: 0x000BA954
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x000BC798 File Offset: 0x000BA998
		public unsafe Vector3 Right
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89759, RefRangeEnd = 89760, XrefRangeStart = 89759, XrefRangeEnd = 89760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x000BC7D8 File Offset: 0x000BA9D8
		public unsafe Vector3 Up
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89763, RefRangeEnd = 89764, XrefRangeStart = 89763, XrefRangeEnd = 89764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x000BC818 File Offset: 0x000BAA18
		public unsafe Vector3 Look
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89767, RefRangeEnd = 89768, XrefRangeStart = 89767, XrefRangeEnd = 89768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x000BC858 File Offset: 0x000BAA58
		public unsafe Vector3 Normal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89767, RefRangeEnd = 89768, XrefRangeStart = 89767, XrefRangeEnd = 89768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x000BC898 File Offset: 0x000BAA98
		// (set) Token: 0x06002720 RID: 10016 RVA: 0x000BC8D8 File Offset: 0x000BAAD8
		public unsafe QuadEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_QuadEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuadEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_QuadEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x000BC91C File Offset: 0x000BAB1C
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x000BC95C File Offset: 0x000BAB5C
		public unsafe Vector2 SizeEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90347, RefRangeEnd = 90348, XrefRangeStart = 90346, XrefRangeEnd = 90347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x000BC9A0 File Offset: 0x000BABA0
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x000BC9DC File Offset: 0x000BABDC
		public unsafe float WidthEps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90348, XrefRangeEnd = 90349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90196, RefRangeEnd = 90197, XrefRangeStart = 90196, XrefRangeEnd = 90197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x000BCA1C File Offset: 0x000BAC1C
		// (set) Token: 0x06002726 RID: 10022 RVA: 0x000BCA58 File Offset: 0x000BAC58
		public unsafe float HeightEps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90349, XrefRangeEnd = 90350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90350, XrefRangeEnd = 90351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000BCA98 File Offset: 0x000BAC98
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x000BCAD4 File Offset: 0x000BACD4
		public unsafe float ExtrudeEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57846, RefRangeEnd = 57847, XrefRangeStart = 57846, XrefRangeEnd = 57847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90352, RefRangeEnd = 90354, XrefRangeStart = 90351, XrefRangeEnd = 90352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x000BCB14 File Offset: 0x000BAD14
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x000BCB50 File Offset: 0x000BAD50
		public unsafe float WireEps
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57861, RefRangeEnd = 57864, XrefRangeStart = 57861, XrefRangeEnd = 57864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90355, RefRangeEnd = 90356, XrefRangeStart = 90354, XrefRangeEnd = 90355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x000BCB90 File Offset: 0x000BAD90
		// (set) Token: 0x0600272C RID: 10028 RVA: 0x000BCBD0 File Offset: 0x000BADD0
		public unsafe Shape3DRaycastMode RaycastMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape3DRaycastMode>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x000BCC14 File Offset: 0x000BAE14
		public unsafe QuadShape3D.WireRenderDescriptor WireRenderDesc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuadShape3D.WireRenderDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000BCC54 File Offset: 0x000BAE54
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x000BCC88 File Offset: 0x000BAE88
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x000BCCBC File Offset: 0x000BAEBC
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002731 RID: 10033 RVA: 0x000BCCF0 File Offset: 0x000BAEF0
		public unsafe static Vector3 ModelCenter
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000BCD24 File Offset: 0x000BAF24
		public unsafe static Vector3 ModelNormal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_get_ModelNormal_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000BCD58 File Offset: 0x000BAF58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90368, RefRangeEnd = 90371, XrefRangeStart = 90356, XrefRangeEnd = 90368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuadShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000BCD94 File Offset: 0x000BAF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90371, XrefRangeEnd = 90378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignNormal(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000BCDD8 File Offset: 0x000BAFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90378, XrefRangeEnd = 90385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignRight(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000BCE1C File Offset: 0x000BB01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90385, XrefRangeEnd = 90392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignUp(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x000BCE60 File Offset: 0x000BB060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90393, RefRangeEnd = 90394, XrefRangeStart = 90392, XrefRangeEnd = 90393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetCornerPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_GetCornerPoints_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x000BCEA0 File Offset: 0x000BB0A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 90395, RefRangeEnd = 90398, XrefRangeStart = 90394, XrefRangeEnd = 90395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetCornerPosition(QuadCorner quadCorner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quadCorner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_GetCornerPosition_Public_Vector3_QuadCorner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x000BCEF0 File Offset: 0x000BB0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90398, XrefRangeEnd = 90399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCornerPointPosition(QuadCorner quadCorner, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quadCorner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_SetCornerPointPosition_Public_Void_QuadCorner_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x000BCF44 File Offset: 0x000BB144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90399, XrefRangeEnd = 90411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuadShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x000BCF80 File Offset: 0x000BB180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90411, XrefRangeEnd = 90436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuadShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000BCFBC File Offset: 0x000BB1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90436, XrefRangeEnd = 90444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuadShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000BD024 File Offset: 0x000BB224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90444, XrefRangeEnd = 90451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuadShape3D.NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000BD08C File Offset: 0x000BB28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90451, XrefRangeEnd = 90458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000BD0E8 File Offset: 0x000BB2E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90393, RefRangeEnd = 90394, XrefRangeStart = 90393, XrefRangeEnd = 90394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Vector3> GetCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.NativeMethodInfoPtr_GetCorners_Public_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000BD128 File Offset: 0x000BB328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90458, XrefRangeEnd = 90460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuadShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0000FA67 File Offset: 0x0000DC67
		public QuadShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x000BD174 File Offset: 0x000BB374
		// (set) Token: 0x06002743 RID: 10051 RVA: 0x0000FA70 File Offset: 0x0000DC70
		public unsafe Shape3DRaycastMode _raycastMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__raycastMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape3DRaycastMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__raycastMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x000BD1A4 File Offset: 0x000BB3A4
		// (set) Token: 0x06002745 RID: 10053 RVA: 0x0000FA8F File Offset: 0x0000DC8F
		public unsafe Vector3 _center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x000BD1D4 File Offset: 0x000BB3D4
		// (set) Token: 0x06002747 RID: 10055 RVA: 0x0000FAAE File Offset: 0x0000DCAE
		public unsafe Vector2 _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__size);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__size), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x000BD204 File Offset: 0x000BB404
		// (set) Token: 0x06002749 RID: 10057 RVA: 0x0000FACD File Offset: 0x0000DCCD
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x000BD234 File Offset: 0x000BB434
		// (set) Token: 0x0600274B RID: 10059 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		public unsafe QuadEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000BD264 File Offset: 0x000BB464
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x0000FB0B File Offset: 0x0000DD0B
		public unsafe QuadShape3D.WireRenderDescriptor _wireRenderDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__wireRenderDesc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape3D.WireRenderDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.NativeFieldInfoPtr__wireRenderDesc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeFieldInfoPtr__raycastMode;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeFieldInfoPtr__center;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeFieldInfoPtr__wireRenderDesc;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector2_0;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector2_0;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeMethodInfoPtr_get_Width_Public_get_Single_0;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_QuadEpsilon_0;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_QuadEpsilon_0;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeEps_Public_get_Vector2_0;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector2_0;

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeMethodInfoPtr_get_RaycastMode_Public_get_Shape3DRaycastMode_0;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeMethodInfoPtr_set_RaycastMode_Public_set_Void_Shape3DRaycastMode_0;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeMethodInfoPtr_get_WireRenderDesc_Public_get_WireRenderDescriptor_0;

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001E69 RID: 7785
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001E6A RID: 7786
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelCenter_Public_Static_get_Vector3_0;

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelNormal_Public_Static_get_Vector3_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeMethodInfoPtr_AlignNormal_Public_Void_Vector3_0;

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeMethodInfoPtr_AlignRight_Public_Void_Vector3_0;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr_AlignUp_Public_Void_Vector3_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeMethodInfoPtr_GetCornerPoints_Public_List_1_Vector3_0;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeMethodInfoPtr_GetCornerPosition_Public_Vector3_QuadCorner_0;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr_SetCornerPointPosition_Public_Void_QuadCorner_Vector3_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_RaycastWire_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_Boolean_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr_GetCorners_Public_List_1_Vector3_0;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;

		// Token: 0x020003B9 RID: 953
		[Flags]
		public enum WireEdgeFlags
		{
			// Token: 0x04003B1D RID: 15133
			None = 0,
			// Token: 0x04003B1E RID: 15134
			Top = 1,
			// Token: 0x04003B1F RID: 15135
			Right = 2,
			// Token: 0x04003B20 RID: 15136
			Bottom = 4,
			// Token: 0x04003B21 RID: 15137
			Left = 8,
			// Token: 0x04003B22 RID: 15138
			All = 15
		}

		// Token: 0x020003BA RID: 954
		public class WireRenderDescriptor : global::Il2CppSystem.Object
		{
			// Token: 0x06004C25 RID: 19493 RVA: 0x0014CA80 File Offset: 0x0014AC80
			// Note: this type is marked as 'beforefieldinit'.
			static WireRenderDescriptor()
			{
				Il2CppClassPointerStore<QuadShape3D.WireRenderDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuadShape3D>.NativeClassPtr, "WireRenderDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadShape3D.WireRenderDescriptor>.NativeClassPtr);
				QuadShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireEdgeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadShape3D.WireRenderDescriptor>.NativeClassPtr, "_wireEdgeFlags");
				QuadShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireEdgeFlags_Public_get_WireEdgeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D.WireRenderDescriptor>.NativeClassPtr, 100669275);
				QuadShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireEdgeFlags_Public_set_Void_WireEdgeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D.WireRenderDescriptor>.NativeClassPtr, 100669276);
				QuadShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadShape3D.WireRenderDescriptor>.NativeClassPtr, 100669277);
			}

			// Token: 0x170019A7 RID: 6567
			// (get) Token: 0x06004C26 RID: 19494 RVA: 0x0014CAFC File Offset: 0x0014ACFC
			// (set) Token: 0x06004C27 RID: 19495 RVA: 0x0014CB38 File Offset: 0x0014AD38
			public unsafe QuadShape3D.WireEdgeFlags WireEdgeFlags
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.WireRenderDescriptor.NativeMethodInfoPtr_get_WireEdgeFlags_Public_get_WireEdgeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.WireRenderDescriptor.NativeMethodInfoPtr_set_WireEdgeFlags_Public_set_Void_WireEdgeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004C28 RID: 19496 RVA: 0x0014CB78 File Offset: 0x0014AD78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90341, XrefRangeEnd = 90342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WireRenderDescriptor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuadShape3D.WireRenderDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadShape3D.WireRenderDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C29 RID: 19497 RVA: 0x0001C910 File Offset: 0x0001AB10
			public WireRenderDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019A6 RID: 6566
			// (get) Token: 0x06004C2A RID: 19498 RVA: 0x0014CBB4 File Offset: 0x0014ADB4
			// (set) Token: 0x06004C2B RID: 19499 RVA: 0x0001C919 File Offset: 0x0001AB19
			public unsafe QuadShape3D.WireEdgeFlags _wireEdgeFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireEdgeFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuadShape3D.WireRenderDescriptor.NativeFieldInfoPtr__wireEdgeFlags)) = value;
				}
			}

			// Token: 0x04003B23 RID: 15139
			private static readonly IntPtr NativeFieldInfoPtr__wireEdgeFlags;

			// Token: 0x04003B24 RID: 15140
			private static readonly IntPtr NativeMethodInfoPtr_get_WireEdgeFlags_Public_get_WireEdgeFlags_0;

			// Token: 0x04003B25 RID: 15141
			private static readonly IntPtr NativeMethodInfoPtr_set_WireEdgeFlags_Public_set_Void_WireEdgeFlags_0;

			// Token: 0x04003B26 RID: 15142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
