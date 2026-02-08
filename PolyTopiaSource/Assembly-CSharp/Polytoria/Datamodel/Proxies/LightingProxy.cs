using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E1 RID: 737
	public class LightingProxy : InstanceProxy
	{
		// Token: 0x060040A5 RID: 16549 RVA: 0x00122410 File Offset: 0x00120610
		// Note: this type is marked as 'beforefieldinit'.
		static LightingProxy()
		{
			Il2CppClassPointerStore<LightingProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "LightingProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr);
			LightingProxy.NativeFieldInfoPtr_lighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, "lighting");
			LightingProxy.NativeMethodInfoPtr_get_SunBrightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673430);
			LightingProxy.NativeMethodInfoPtr_set_SunBrightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673431);
			LightingProxy.NativeMethodInfoPtr_get_SunColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673432);
			LightingProxy.NativeMethodInfoPtr_set_SunColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673433);
			LightingProxy.NativeMethodInfoPtr_get_AmbientColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673434);
			LightingProxy.NativeMethodInfoPtr_set_AmbientColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673435);
			LightingProxy.NativeMethodInfoPtr_get_AmbientSource_Public_get_AmbientSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673436);
			LightingProxy.NativeMethodInfoPtr_set_AmbientSource_Public_set_Void_AmbientSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673437);
			LightingProxy.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673438);
			LightingProxy.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673439);
			LightingProxy.NativeMethodInfoPtr__ctor_Public_Void_Lighting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr, 100673429);
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x060040A6 RID: 16550 RVA: 0x00122530 File Offset: 0x00120730
		// (set) Token: 0x060040A7 RID: 16551 RVA: 0x0012256C File Offset: 0x0012076C
		public unsafe float SunBrightness
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128632, XrefRangeEnd = 128634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_get_SunBrightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128634, XrefRangeEnd = 128636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_set_SunBrightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x060040A8 RID: 16552 RVA: 0x001225AC File Offset: 0x001207AC
		// (set) Token: 0x060040A9 RID: 16553 RVA: 0x001225EC File Offset: 0x001207EC
		public unsafe Color SunColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128636, XrefRangeEnd = 128637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_get_SunColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128637, XrefRangeEnd = 128638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_set_SunColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x060040AA RID: 16554 RVA: 0x00122630 File Offset: 0x00120830
		// (set) Token: 0x060040AB RID: 16555 RVA: 0x00122670 File Offset: 0x00120870
		public unsafe Color AmbientColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128638, XrefRangeEnd = 128639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_get_AmbientColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128639, XrefRangeEnd = 128640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_set_AmbientColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x060040AC RID: 16556 RVA: 0x001226B4 File Offset: 0x001208B4
		// (set) Token: 0x060040AD RID: 16557 RVA: 0x001226F4 File Offset: 0x001208F4
		public unsafe AmbientSource AmbientSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_get_AmbientSource_Public_get_AmbientSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AmbientSource>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128640, XrefRangeEnd = 128642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_set_AmbientSource_Public_set_Void_AmbientSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x060040AE RID: 16558 RVA: 0x00122738 File Offset: 0x00120938
		// (set) Token: 0x060040AF RID: 16559 RVA: 0x00122774 File Offset: 0x00120974
		public unsafe bool Shadows
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128642, XrefRangeEnd = 128644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128644, XrefRangeEnd = 128646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x001227B4 File Offset: 0x001209B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightingProxy(Lighting target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightingProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingProxy.NativeMethodInfoPtr__ctor_Public_Void_Lighting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00018769 File Offset: 0x00016969
		public LightingProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x00122800 File Offset: 0x00120A00
		// (set) Token: 0x060040B3 RID: 16563 RVA: 0x00018772 File Offset: 0x00016972
		public unsafe Lighting lighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightingProxy.NativeFieldInfoPtr_lighting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lighting>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightingProxy.NativeFieldInfoPtr_lighting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003241 RID: 12865
		private static readonly IntPtr NativeFieldInfoPtr_lighting;

		// Token: 0x04003242 RID: 12866
		private static readonly IntPtr NativeMethodInfoPtr_get_SunBrightness_Public_get_Single_0;

		// Token: 0x04003243 RID: 12867
		private static readonly IntPtr NativeMethodInfoPtr_set_SunBrightness_Public_set_Void_Single_0;

		// Token: 0x04003244 RID: 12868
		private static readonly IntPtr NativeMethodInfoPtr_get_SunColor_Public_get_Color_0;

		// Token: 0x04003245 RID: 12869
		private static readonly IntPtr NativeMethodInfoPtr_set_SunColor_Public_set_Void_Color_0;

		// Token: 0x04003246 RID: 12870
		private static readonly IntPtr NativeMethodInfoPtr_get_AmbientColor_Public_get_Color_0;

		// Token: 0x04003247 RID: 12871
		private static readonly IntPtr NativeMethodInfoPtr_set_AmbientColor_Public_set_Void_Color_0;

		// Token: 0x04003248 RID: 12872
		private static readonly IntPtr NativeMethodInfoPtr_get_AmbientSource_Public_get_AmbientSource_0;

		// Token: 0x04003249 RID: 12873
		private static readonly IntPtr NativeMethodInfoPtr_set_AmbientSource_Public_set_Void_AmbientSource_0;

		// Token: 0x0400324A RID: 12874
		private static readonly IntPtr NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0;

		// Token: 0x0400324B RID: 12875
		private static readonly IntPtr NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0;

		// Token: 0x0400324C RID: 12876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Lighting_0;
	}
}
