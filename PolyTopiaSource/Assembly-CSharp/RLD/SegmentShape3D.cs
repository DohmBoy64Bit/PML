using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E7 RID: 487
	public class SegmentShape3D : Shape3D
	{
		// Token: 0x060027D0 RID: 10192 RVA: 0x000BF53C File Offset: 0x000BD73C
		// Note: this type is marked as 'beforefieldinit'.
		static SegmentShape3D()
		{
			Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SegmentShape3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr);
			SegmentShape3D.NativeFieldInfoPtr__startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, "_startPoint");
			SegmentShape3D.NativeFieldInfoPtr__endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, "_endPoint");
			SegmentShape3D.NativeFieldInfoPtr__direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, "_direction");
			SegmentShape3D.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, "_length");
			SegmentShape3D.NativeFieldInfoPtr__epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, "_epsilon");
			SegmentShape3D.NativeMethodInfoPtr_get_Length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669366);
			SegmentShape3D.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669367);
			SegmentShape3D.NativeMethodInfoPtr_get_StartPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669368);
			SegmentShape3D.NativeMethodInfoPtr_set_StartPoint_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669369);
			SegmentShape3D.NativeMethodInfoPtr_get_EndPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669370);
			SegmentShape3D.NativeMethodInfoPtr_set_EndPoint_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669371);
			SegmentShape3D.NativeMethodInfoPtr_get_Direction_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669372);
			SegmentShape3D.NativeMethodInfoPtr_set_Direction_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669373);
			SegmentShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_SegmentEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669374);
			SegmentShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_SegmentEpsilon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669375);
			SegmentShape3D.NativeMethodInfoPtr_get_RaycastEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669376);
			SegmentShape3D.NativeMethodInfoPtr_set_RaycastEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669377);
			SegmentShape3D.NativeMethodInfoPtr_get_PtOnSegmentEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669378);
			SegmentShape3D.NativeMethodInfoPtr_set_PtOnSegmentEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669379);
			SegmentShape3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669385);
			SegmentShape3D.NativeMethodInfoPtr_SetEndPtFromStart_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669380);
			SegmentShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669381);
			SegmentShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669382);
			SegmentShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669383);
			SegmentShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr, 100669384);
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x060027D1 RID: 10193 RVA: 0x000BF760 File Offset: 0x000BD960
		// (set) Token: 0x060027D2 RID: 10194 RVA: 0x000BF79C File Offset: 0x000BD99C
		public unsafe float Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_get_Length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x000BF7DC File Offset: 0x000BD9DC
		// (set) Token: 0x060027D4 RID: 10196 RVA: 0x000BF81C File Offset: 0x000BDA1C
		public unsafe Vector3 StartPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_get_StartPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90635, RefRangeEnd = 90636, XrefRangeStart = 90635, XrefRangeEnd = 90635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_set_StartPoint_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x000BF860 File Offset: 0x000BDA60
		// (set) Token: 0x060027D6 RID: 10198 RVA: 0x000BF8A0 File Offset: 0x000BDAA0
		public unsafe Vector3 EndPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_get_EndPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90636, XrefRangeEnd = 90639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_set_EndPoint_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x000BF8E4 File Offset: 0x000BDAE4
		// (set) Token: 0x060027D8 RID: 10200 RVA: 0x000BF924 File Offset: 0x000BDB24
		public unsafe Vector3 Direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_get_Direction_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90639, XrefRangeEnd = 90643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_set_Direction_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x000BF968 File Offset: 0x000BDB68
		// (set) Token: 0x060027DA RID: 10202 RVA: 0x000BF9A8 File Offset: 0x000BDBA8
		public unsafe SegmentEpsilon Epsilon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_get_Epsilon_Public_get_SegmentEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SegmentEpsilon>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_set_Epsilon_Public_set_Void_SegmentEpsilon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000BF9EC File Offset: 0x000BDBEC
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x000BFA28 File Offset: 0x000BDC28
		public unsafe float RaycastEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57816, RefRangeEnd = 57817, XrefRangeStart = 57816, XrefRangeEnd = 57817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_get_RaycastEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_set_RaycastEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x000BFA68 File Offset: 0x000BDC68
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x000BFAA4 File Offset: 0x000BDCA4
		public unsafe float PtOnSegmentEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57831, RefRangeEnd = 57832, XrefRangeStart = 57831, XrefRangeEnd = 57832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_get_PtOnSegmentEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_set_PtOnSegmentEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x000BFAE4 File Offset: 0x000BDCE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90650, RefRangeEnd = 90651, XrefRangeStart = 90643, XrefRangeEnd = 90650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SegmentShape3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SegmentShape3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x000BFB20 File Offset: 0x000BDD20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90654, RefRangeEnd = 90655, XrefRangeStart = 90651, XrefRangeEnd = 90654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEndPtFromStart(Vector3 dirDromStart, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dirDromStart);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentShape3D.NativeMethodInfoPtr_SetEndPtFromStart_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000BFB70 File Offset: 0x000BDD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90655, XrefRangeEnd = 90656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SegmentShape3D.NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000BFBAC File Offset: 0x000BDDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RenderWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SegmentShape3D.NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000BFBE8 File Offset: 0x000BDDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90656, XrefRangeEnd = 90657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SegmentShape3D.NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x000BFC50 File Offset: 0x000BDE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90657, XrefRangeEnd = 90661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AABB GetAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SegmentShape3D.NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x0000FD5B File Offset: 0x0000DF5B
		public SegmentShape3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x000BFC9C File Offset: 0x000BDE9C
		// (set) Token: 0x060027E7 RID: 10215 RVA: 0x0000FD64 File Offset: 0x0000DF64
		public unsafe Vector3 _startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__startPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__startPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x000BFCCC File Offset: 0x000BDECC
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x0000FD83 File Offset: 0x0000DF83
		public unsafe Vector3 _endPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__endPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__endPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x000BFCFC File Offset: 0x000BDEFC
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x0000FDA2 File Offset: 0x0000DFA2
		public unsafe Vector3 _direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__direction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__direction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x000BFD2C File Offset: 0x000BDF2C
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x0000FDC1 File Offset: 0x0000DFC1
		public unsafe float _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x000BFD54 File Offset: 0x000BDF54
		// (set) Token: 0x060027EF RID: 10223 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		public unsafe SegmentEpsilon _epsilon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__epsilon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SegmentEpsilon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SegmentShape3D.NativeFieldInfoPtr__epsilon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeFieldInfoPtr__startPoint;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeFieldInfoPtr__endPoint;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeFieldInfoPtr__direction;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeFieldInfoPtr__epsilon;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Single_0;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Public_set_Void_Single_0;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_get_StartPoint_Public_get_Vector3_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_set_StartPoint_Public_set_Void_Vector3_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_get_EndPoint_Public_get_Vector3_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_set_EndPoint_Public_set_Void_Vector3_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Vector3_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr_set_Direction_Public_set_Void_Vector3_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr_get_Epsilon_Public_get_SegmentEpsilon_0;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeMethodInfoPtr_set_Epsilon_Public_set_Void_SegmentEpsilon_0;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeMethodInfoPtr_get_RaycastEps_Public_get_Single_0;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeMethodInfoPtr_set_RaycastEps_Public_set_Void_Single_0;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeMethodInfoPtr_get_PtOnSegmentEps_Public_get_Single_0;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeMethodInfoPtr_set_PtOnSegmentEps_Public_set_Void_Single_0;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EF8 RID: 7928
		private static readonly IntPtr NativeMethodInfoPtr_SetEndPtFromStart_Public_Void_Vector3_Single_0;

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeMethodInfoPtr_RenderSolid_Public_Virtual_Void_0;

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeMethodInfoPtr_RenderWire_Public_Virtual_Void_0;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Boolean_Ray_byref_Single_0;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeMethodInfoPtr_GetAABB_Public_Virtual_AABB_0;
	}
}
