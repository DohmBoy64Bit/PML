using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002DA RID: 730
	public class GradientSkyProxy : SkyBaseProxy
	{
		// Token: 0x0600403B RID: 16443 RVA: 0x001206A0 File Offset: 0x0011E8A0
		// Note: this type is marked as 'beforefieldinit'.
		static GradientSkyProxy()
		{
			Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "GradientSkyProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr);
			GradientSkyProxy.NativeFieldInfoPtr_gradientSky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, "gradientSky");
			GradientSkyProxy.NativeMethodInfoPtr_get_SunDiscColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673352);
			GradientSkyProxy.NativeMethodInfoPtr_set_SunDiscColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673353);
			GradientSkyProxy.NativeMethodInfoPtr_get_SunDiscMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673354);
			GradientSkyProxy.NativeMethodInfoPtr_set_SunDiscMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673355);
			GradientSkyProxy.NativeMethodInfoPtr_get_SunDiscExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673356);
			GradientSkyProxy.NativeMethodInfoPtr_set_SunDiscExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673357);
			GradientSkyProxy.NativeMethodInfoPtr_get_SunHaloColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673358);
			GradientSkyProxy.NativeMethodInfoPtr_set_SunHaloColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673359);
			GradientSkyProxy.NativeMethodInfoPtr_get_SunHaloExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673360);
			GradientSkyProxy.NativeMethodInfoPtr_set_SunHaloExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673361);
			GradientSkyProxy.NativeMethodInfoPtr_get_SunHaloContribution_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673362);
			GradientSkyProxy.NativeMethodInfoPtr_set_SunHaloContribution_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673363);
			GradientSkyProxy.NativeMethodInfoPtr_get_HorizonLineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673364);
			GradientSkyProxy.NativeMethodInfoPtr_set_HorizonLineColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673365);
			GradientSkyProxy.NativeMethodInfoPtr_get_HorizonLineExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673366);
			GradientSkyProxy.NativeMethodInfoPtr_set_HorizonLineExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673367);
			GradientSkyProxy.NativeMethodInfoPtr_get_HorizonLineContribution_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673368);
			GradientSkyProxy.NativeMethodInfoPtr_set_HorizonLineContribution_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673369);
			GradientSkyProxy.NativeMethodInfoPtr_get_SkyGradientTop_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673370);
			GradientSkyProxy.NativeMethodInfoPtr_set_SkyGradientTop_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673371);
			GradientSkyProxy.NativeMethodInfoPtr_get_SkyGradientBottom_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673372);
			GradientSkyProxy.NativeMethodInfoPtr_set_SkyGradientBottom_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673373);
			GradientSkyProxy.NativeMethodInfoPtr_get_SkyGradientExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673374);
			GradientSkyProxy.NativeMethodInfoPtr_set_SkyGradientExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673375);
			GradientSkyProxy.NativeMethodInfoPtr__ctor_Public_Void_GradientSky_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr, 100673351);
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x0600403C RID: 16444 RVA: 0x001208D8 File Offset: 0x0011EAD8
		// (set) Token: 0x0600403D RID: 16445 RVA: 0x00120918 File Offset: 0x0011EB18
		public unsafe Color SunDiscColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_SunDiscColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128558, XrefRangeEnd = 128559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_SunDiscColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x0012095C File Offset: 0x0011EB5C
		// (set) Token: 0x0600403F RID: 16447 RVA: 0x00120998 File Offset: 0x0011EB98
		public unsafe float SunDiscMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_SunDiscMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128559, XrefRangeEnd = 128561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_SunDiscMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06004040 RID: 16448 RVA: 0x001209D8 File Offset: 0x0011EBD8
		// (set) Token: 0x06004041 RID: 16449 RVA: 0x00120A14 File Offset: 0x0011EC14
		public unsafe float SunDiscExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_SunDiscExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128561, XrefRangeEnd = 128563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_SunDiscExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06004042 RID: 16450 RVA: 0x00120A54 File Offset: 0x0011EC54
		// (set) Token: 0x06004043 RID: 16451 RVA: 0x00120A94 File Offset: 0x0011EC94
		public unsafe Color SunHaloColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_SunHaloColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128563, XrefRangeEnd = 128564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_SunHaloColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06004044 RID: 16452 RVA: 0x00120AD8 File Offset: 0x0011ECD8
		// (set) Token: 0x06004045 RID: 16453 RVA: 0x00120B14 File Offset: 0x0011ED14
		public unsafe float SunHaloExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_SunHaloExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128564, XrefRangeEnd = 128566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_SunHaloExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06004046 RID: 16454 RVA: 0x00120B54 File Offset: 0x0011ED54
		// (set) Token: 0x06004047 RID: 16455 RVA: 0x00120B90 File Offset: 0x0011ED90
		public unsafe float SunHaloContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_SunHaloContribution_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128566, XrefRangeEnd = 128568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_SunHaloContribution_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x00120BD0 File Offset: 0x0011EDD0
		// (set) Token: 0x06004049 RID: 16457 RVA: 0x00120C10 File Offset: 0x0011EE10
		public unsafe Color HorizonLineColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_HorizonLineColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128568, XrefRangeEnd = 128569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_HorizonLineColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x00120C54 File Offset: 0x0011EE54
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x00120C90 File Offset: 0x0011EE90
		public unsafe float HorizonLineExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_HorizonLineExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128569, XrefRangeEnd = 128571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_HorizonLineExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x00120CD0 File Offset: 0x0011EED0
		// (set) Token: 0x0600404D RID: 16461 RVA: 0x00120D0C File Offset: 0x0011EF0C
		public unsafe float HorizonLineContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_HorizonLineContribution_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128571, XrefRangeEnd = 128573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_HorizonLineContribution_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x0600404E RID: 16462 RVA: 0x00120D4C File Offset: 0x0011EF4C
		// (set) Token: 0x0600404F RID: 16463 RVA: 0x00120D8C File Offset: 0x0011EF8C
		public unsafe Color SkyGradientTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_SkyGradientTop_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128573, XrefRangeEnd = 128574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_SkyGradientTop_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06004050 RID: 16464 RVA: 0x00120DD0 File Offset: 0x0011EFD0
		// (set) Token: 0x06004051 RID: 16465 RVA: 0x00120E10 File Offset: 0x0011F010
		public unsafe Color SkyGradientBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_SkyGradientBottom_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128574, XrefRangeEnd = 128575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_SkyGradientBottom_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x00120E54 File Offset: 0x0011F054
		// (set) Token: 0x06004053 RID: 16467 RVA: 0x00120E90 File Offset: 0x0011F090
		public unsafe float SkyGradientExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_get_SkyGradientExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128575, XrefRangeEnd = 128577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr_set_SkyGradientExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x00120ED0 File Offset: 0x0011F0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientSkyProxy(GradientSky target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientSkyProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSkyProxy.NativeMethodInfoPtr__ctor_Public_Void_GradientSky_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x00018651 File Offset: 0x00016851
		public GradientSkyProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x00120F1C File Offset: 0x0011F11C
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x0001865A File Offset: 0x0001685A
		public unsafe GradientSky gradientSky
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSkyProxy.NativeFieldInfoPtr_gradientSky);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GradientSky>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSkyProxy.NativeFieldInfoPtr_gradientSky), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031EC RID: 12780
		private static readonly IntPtr NativeFieldInfoPtr_gradientSky;

		// Token: 0x040031ED RID: 12781
		private static readonly IntPtr NativeMethodInfoPtr_get_SunDiscColor_Public_get_Color_0;

		// Token: 0x040031EE RID: 12782
		private static readonly IntPtr NativeMethodInfoPtr_set_SunDiscColor_Public_set_Void_Color_0;

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeMethodInfoPtr_get_SunDiscMultiplier_Public_get_Single_0;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeMethodInfoPtr_set_SunDiscMultiplier_Public_set_Void_Single_0;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeMethodInfoPtr_get_SunDiscExponent_Public_get_Single_0;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeMethodInfoPtr_set_SunDiscExponent_Public_set_Void_Single_0;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeMethodInfoPtr_get_SunHaloColor_Public_get_Color_0;

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeMethodInfoPtr_set_SunHaloColor_Public_set_Void_Color_0;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeMethodInfoPtr_get_SunHaloExponent_Public_get_Single_0;

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeMethodInfoPtr_set_SunHaloExponent_Public_set_Void_Single_0;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeMethodInfoPtr_get_SunHaloContribution_Public_get_Single_0;

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeMethodInfoPtr_set_SunHaloContribution_Public_set_Void_Single_0;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizonLineColor_Public_get_Color_0;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizonLineColor_Public_set_Void_Color_0;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizonLineExponent_Public_get_Single_0;

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizonLineExponent_Public_set_Void_Single_0;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizonLineContribution_Public_get_Single_0;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizonLineContribution_Public_set_Void_Single_0;

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyGradientTop_Public_get_Color_0;

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeMethodInfoPtr_set_SkyGradientTop_Public_set_Void_Color_0;

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyGradientBottom_Public_get_Color_0;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeMethodInfoPtr_set_SkyGradientBottom_Public_set_Void_Color_0;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyGradientExponent_Public_get_Single_0;

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeMethodInfoPtr_set_SkyGradientExponent_Public_set_Void_Single_0;

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GradientSky_0;
	}
}
