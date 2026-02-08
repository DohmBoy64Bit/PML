using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F1 RID: 497
	public class TriangPrismShape3D : Shape3D
	{
		// Token: 0x0600284F RID: 10319 RVA: 0x000C171C File Offset: 0x000BF91C
		// Note: this type is marked as 'beforefieldinit'.
		static TriangPrismShape3D()
		{
			Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TriangPrismShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr);
			TriangPrismShape3D.NativeFieldInfoPtr__baseCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, "_baseCenter");
			TriangPrismShape3D.NativeFieldInfoPtr__width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, "_width");
			TriangPrismShape3D.NativeFieldInfoPtr__height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, "_height");
			TriangPrismShape3D.NativeFieldInfoPtr__depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, "_depth");
			TriangPrismShape3D.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, "_rotation");
			TriangPrismShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, "_epsilon");
			TriangPrismShape3D.NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669467);
			TriangPrismShape3D.NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669468);
			TriangPrismShape3D.NativeMethodInfoPtr_get_TopCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669469);
			TriangPrismShape3D.NativeMethodInfoPtr_set_TopCenter_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669470);
			TriangPrismShape3D.NativeMethodInfoPtr_get_FrontCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669471);
			TriangPrismShape3D.NativeMethodInfoPtr_set_FrontCenter_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669472);
			TriangPrismShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669473);
			TriangPrismShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669474);
			TriangPrismShape3D.NativeMethodInfoPtr_get_MidTip_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669475);
			TriangPrismShape3D.NativeMethodInfoPtr_set_MidTip_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669476);
			TriangPrismShape3D.NativeMethodInfoPtr_get_Width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669477);
			TriangPrismShape3D.NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669478);
			TriangPrismShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669479);
			TriangPrismShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669480);
			TriangPrismShape3D.NativeMethodInfoPtr_get_Depth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669481);
			TriangPrismShape3D.NativeMethodInfoPtr_set_Depth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669482);
			TriangPrismShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_PrismEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669483);
			TriangPrismShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_PrismEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669484);
			TriangPrismShape3D.NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669485);
			TriangPrismShape3D.NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669486);
			TriangPrismShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669487);
			TriangPrismShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669488);
			TriangPrismShape3D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669489);
			TriangPrismShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669490);
			TriangPrismShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669491);
			TriangPrismShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669492);
			TriangPrismShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669493);
			TriangPrismShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669494);
			TriangPrismShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669495);
			TriangPrismShape3D.NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669496);
			TriangPrismShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669506);
			TriangPrismShape3D.NativeMethodInfoPtr_AlignWidth_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669497);
			TriangPrismShape3D.NativeMethodInfoPtr_AlignHeight_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669498);
			TriangPrismShape3D.NativeMethodInfoPtr_AlignDepth_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669499);
			TriangPrismShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669500);
			TriangPrismShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669501);
			TriangPrismShape3D.NativeMethodInfoPtr_MakeEquilateral_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669502);
			TriangPrismShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669503);
			TriangPrismShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669504);
			TriangPrismShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr, 100669505);
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x000C1AE4 File Offset: 0x000BFCE4
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x000C1B24 File Offset: 0x000BFD24
		public unsafe Vector3 BaseCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x000C1B68 File Offset: 0x000BFD68
		// (set) Token: 0x06002853 RID: 10323 RVA: 0x000C1BA8 File Offset: 0x000BFDA8
		public unsafe Vector3 TopCenter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90822, XrefRangeEnd = 90825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_TopCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90825, XrefRangeEnd = 90828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_TopCenter_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x000C1BEC File Offset: 0x000BFDEC
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x000C1C2C File Offset: 0x000BFE2C
		public unsafe Vector3 FrontCenter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90828, XrefRangeEnd = 90834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_FrontCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90840, RefRangeEnd = 90841, XrefRangeStart = 90834, XrefRangeEnd = 90840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_FrontCenter_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x000C1C70 File Offset: 0x000BFE70
		// (set) Token: 0x06002857 RID: 10327 RVA: 0x000C1CB0 File Offset: 0x000BFEB0
		public unsafe Vector3 Center
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90841, XrefRangeEnd = 90844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90844, XrefRangeEnd = 90847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000C1CF4 File Offset: 0x000BFEF4
		// (set) Token: 0x06002859 RID: 10329 RVA: 0x000C1D34 File Offset: 0x000BFF34
		public unsafe Vector3 MidTip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90847, XrefRangeEnd = 90853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_MidTip_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90853, XrefRangeEnd = 90859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_MidTip_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x000C1D78 File Offset: 0x000BFF78
		// (set) Token: 0x0600285B RID: 10331 RVA: 0x000C1DB4 File Offset: 0x000BFFB4
		public unsafe float Width
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_Width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x000C1DF4 File Offset: 0x000BFFF4
		// (set) Token: 0x0600285D RID: 10333 RVA: 0x000C1E30 File Offset: 0x000C0030
		public unsafe float Height
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_Height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000C1E70 File Offset: 0x000C0070
		// (set) Token: 0x0600285F RID: 10335 RVA: 0x000C1EAC File Offset: 0x000C00AC
		public unsafe float Depth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_Depth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_Depth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x000C1EEC File Offset: 0x000C00EC
		// (set) Token: 0x06002861 RID: 10337 RVA: 0x000C1F2C File Offset: 0x000C012C
		public unsafe PrismEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_PrismEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrismEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_PrismEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x000C1F70 File Offset: 0x000C0170
		// (set) Token: 0x06002863 RID: 10339 RVA: 0x000C1FAC File Offset: 0x000C01AC
		public unsafe float PtContainEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57816, RefRangeEnd = 57817, XrefRangeStart = 57816, XrefRangeEnd = 57817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x000C1FEC File Offset: 0x000C01EC
		// (set) Token: 0x06002865 RID: 10341 RVA: 0x000C202C File Offset: 0x000C022C
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x000C2070 File Offset: 0x000C0270
		public unsafe Vector3 CentralAxis
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89763, RefRangeEnd = 89764, XrefRangeStart = 89763, XrefRangeEnd = 89764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x000C20B0 File Offset: 0x000C02B0
		public unsafe Vector3 Right
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89759, RefRangeEnd = 89760, XrefRangeStart = 89759, XrefRangeEnd = 89760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x000C20F0 File Offset: 0x000C02F0
		public unsafe Vector3 Up
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89763, RefRangeEnd = 89764, XrefRangeStart = 89763, XrefRangeEnd = 89764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x000C2130 File Offset: 0x000C0330
		public unsafe Vector3 Look
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89767, RefRangeEnd = 89768, XrefRangeStart = 89767, XrefRangeEnd = 89768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x000C2170 File Offset: 0x000C0370
		public unsafe static Vector3 ModelRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x000C21A4 File Offset: 0x000C03A4
		public unsafe static Vector3 ModelUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x000C21D8 File Offset: 0x000C03D8
		public unsafe static Vector3 ModelLook
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x000C220C File Offset: 0x000C040C
		public unsafe static Vector3 ModelBaseCenter
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 88996, RefRangeEnd = 89026, XrefRangeStart = 88996, XrefRangeEnd = 89026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x000C2240 File Offset: 0x000C0440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90202, RefRangeEnd = 90204, XrefRangeStart = 90202, XrefRangeEnd = 90204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriangPrismShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriangPrismShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x000C227C File Offset: 0x000C047C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignWidth(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_AlignWidth_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x000C22C0 File Offset: 0x000C04C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignHeight(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_AlignHeight_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x000C2304 File Offset: 0x000C0504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignDepth(Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_AlignDepth_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x000C2348 File Offset: 0x000C0548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90859, XrefRangeEnd = 90871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriangPrismShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x000C2384 File Offset: 0x000C0584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90871, XrefRangeEnd = 90883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriangPrismShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000C23C0 File Offset: 0x000C05C0
		[CallerCount(0)]
		public unsafe void MakeEquilateral(float sideLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sideLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_MakeEquilateral_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x000C2400 File Offset: 0x000C0600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90883, XrefRangeEnd = 90884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriangPrismShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000C2468 File Offset: 0x000C0668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90884, XrefRangeEnd = 90885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangPrismShape3D.NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000C24B8 File Offset: 0x000C06B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90885, XrefRangeEnd = 90887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TriangPrismShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x0000FF68 File Offset: 0x0000E168
		public TriangPrismShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x000C2504 File Offset: 0x000C0704
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x0000FF71 File Offset: 0x0000E171
		public unsafe Vector3 _baseCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__baseCenter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__baseCenter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x000C2534 File Offset: 0x000C0734
		// (set) Token: 0x0600287C RID: 10364 RVA: 0x0000FF90 File Offset: 0x0000E190
		public unsafe float _width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__width)) = value;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x000C255C File Offset: 0x000C075C
		// (set) Token: 0x0600287E RID: 10366 RVA: 0x0000FFAB File Offset: 0x0000E1AB
		public unsafe float _height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__height)) = value;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x000C2584 File Offset: 0x000C0784
		// (set) Token: 0x06002880 RID: 10368 RVA: 0x0000FFC6 File Offset: 0x0000E1C6
		public unsafe float _depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__depth)) = value;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x000C25AC File Offset: 0x000C07AC
		// (set) Token: 0x06002882 RID: 10370 RVA: 0x0000FFE1 File Offset: 0x0000E1E1
		public unsafe Quaternion _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x000C25DC File Offset: 0x000C07DC
		// (set) Token: 0x06002884 RID: 10372 RVA: 0x00010000 File Offset: 0x0000E200
		public unsafe PrismEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrismEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriangPrismShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeFieldInfoPtr__baseCenter;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeFieldInfoPtr__width;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeFieldInfoPtr__height;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeFieldInfoPtr__depth;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseCenter_Public_get_Vector3_0;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseCenter_Public_set_Void_Vector3_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr_get_TopCenter_Public_get_Vector3_0;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr_set_TopCenter_Public_set_Void_Vector3_0;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_get_FrontCenter_Public_get_Vector3_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_set_FrontCenter_Public_set_Void_Vector3_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_set_Center_Public_set_Void_Vector3_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_get_MidTip_Public_get_Vector3_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr_set_MidTip_Public_set_Void_Vector3_0;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeMethodInfoPtr_get_Width_Public_get_Single_0;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_Single_0;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Single_0;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_get_Single_0;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeMethodInfoPtr_set_Depth_Public_set_Void_Single_0;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_PrismEpsilon_0;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_PrismEpsilon_0;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeMethodInfoPtr_get_CentralAxis_Public_get_Vector3_0;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelRight_Public_Static_get_Vector3_0;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelUp_Public_Static_get_Vector3_0;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelLook_Public_Static_get_Vector3_0;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr_get_ModelBaseCenter_Public_Static_get_Vector3_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_AlignWidth_Public_Void_Vector3_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_AlignHeight_Public_Void_Vector3_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr_AlignDepth_Public_Void_Vector3_0;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeMethodInfoPtr_MakeEquilateral_Public_Void_Single_0;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Boolean_Vector3_0;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;
	}
}
