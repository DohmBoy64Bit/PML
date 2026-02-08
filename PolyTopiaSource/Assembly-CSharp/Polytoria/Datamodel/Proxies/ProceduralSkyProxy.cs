using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F0 RID: 752
	public class ProceduralSkyProxy : SkyBaseProxy
	{
		// Token: 0x0600420D RID: 16909 RVA: 0x00128EA8 File Offset: 0x001270A8
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralSkyProxy()
		{
			Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ProceduralSkyProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr);
			ProceduralSkyProxy.NativeFieldInfoPtr_proceduralSky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, "proceduralSky");
			ProceduralSkyProxy.NativeMethodInfoPtr_get_SunSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673730);
			ProceduralSkyProxy.NativeMethodInfoPtr_set_SunSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673731);
			ProceduralSkyProxy.NativeMethodInfoPtr_get_SunSizeConvergence_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673732);
			ProceduralSkyProxy.NativeMethodInfoPtr_set_SunSizeConvergence_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673733);
			ProceduralSkyProxy.NativeMethodInfoPtr_get_AtmosphereThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673734);
			ProceduralSkyProxy.NativeMethodInfoPtr_set_AtmosphereThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673735);
			ProceduralSkyProxy.NativeMethodInfoPtr_get_SkyTint_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673736);
			ProceduralSkyProxy.NativeMethodInfoPtr_set_SkyTint_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673737);
			ProceduralSkyProxy.NativeMethodInfoPtr_get_GroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673738);
			ProceduralSkyProxy.NativeMethodInfoPtr_set_GroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673739);
			ProceduralSkyProxy.NativeMethodInfoPtr_get_Exposure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673740);
			ProceduralSkyProxy.NativeMethodInfoPtr_set_Exposure_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673741);
			ProceduralSkyProxy.NativeMethodInfoPtr__ctor_Public_Void_ProceduralSky_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr, 100673729);
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x0600420E RID: 16910 RVA: 0x00128FF0 File Offset: 0x001271F0
		// (set) Token: 0x0600420F RID: 16911 RVA: 0x0012902C File Offset: 0x0012722C
		public unsafe float SunSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_get_SunSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128964, XrefRangeEnd = 128966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_set_SunSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06004210 RID: 16912 RVA: 0x0012906C File Offset: 0x0012726C
		// (set) Token: 0x06004211 RID: 16913 RVA: 0x001290A8 File Offset: 0x001272A8
		public unsafe float SunSizeConvergence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_get_SunSizeConvergence_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128966, XrefRangeEnd = 128968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_set_SunSizeConvergence_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06004212 RID: 16914 RVA: 0x001290E8 File Offset: 0x001272E8
		// (set) Token: 0x06004213 RID: 16915 RVA: 0x00129124 File Offset: 0x00127324
		public unsafe float AtmosphereThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_get_AtmosphereThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128968, XrefRangeEnd = 128970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_set_AtmosphereThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x00129164 File Offset: 0x00127364
		// (set) Token: 0x06004215 RID: 16917 RVA: 0x001291A4 File Offset: 0x001273A4
		public unsafe Color SkyTint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_get_SkyTint_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128970, XrefRangeEnd = 128971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_set_SkyTint_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x001291E8 File Offset: 0x001273E8
		// (set) Token: 0x06004217 RID: 16919 RVA: 0x00129228 File Offset: 0x00127428
		public unsafe Color GroundColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_get_GroundColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128971, XrefRangeEnd = 128972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_set_GroundColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x0012926C File Offset: 0x0012746C
		// (set) Token: 0x06004219 RID: 16921 RVA: 0x001292A8 File Offset: 0x001274A8
		public unsafe float Exposure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_get_Exposure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128972, XrefRangeEnd = 128974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr_set_Exposure_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x001292E8 File Offset: 0x001274E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralSkyProxy(ProceduralSky target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralSkyProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSkyProxy.NativeMethodInfoPtr__ctor_Public_Void_ProceduralSky_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x000189C1 File Offset: 0x00016BC1
		public ProceduralSkyProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x0600421C RID: 16924 RVA: 0x00129334 File Offset: 0x00127534
		// (set) Token: 0x0600421D RID: 16925 RVA: 0x000189CA File Offset: 0x00016BCA
		public unsafe ProceduralSky proceduralSky
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSkyProxy.NativeFieldInfoPtr_proceduralSky);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralSky>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSkyProxy.NativeFieldInfoPtr_proceduralSky), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400337C RID: 13180
		private static readonly IntPtr NativeFieldInfoPtr_proceduralSky;

		// Token: 0x0400337D RID: 13181
		private static readonly IntPtr NativeMethodInfoPtr_get_SunSize_Public_get_Single_0;

		// Token: 0x0400337E RID: 13182
		private static readonly IntPtr NativeMethodInfoPtr_set_SunSize_Public_set_Void_Single_0;

		// Token: 0x0400337F RID: 13183
		private static readonly IntPtr NativeMethodInfoPtr_get_SunSizeConvergence_Public_get_Single_0;

		// Token: 0x04003380 RID: 13184
		private static readonly IntPtr NativeMethodInfoPtr_set_SunSizeConvergence_Public_set_Void_Single_0;

		// Token: 0x04003381 RID: 13185
		private static readonly IntPtr NativeMethodInfoPtr_get_AtmosphereThickness_Public_get_Single_0;

		// Token: 0x04003382 RID: 13186
		private static readonly IntPtr NativeMethodInfoPtr_set_AtmosphereThickness_Public_set_Void_Single_0;

		// Token: 0x04003383 RID: 13187
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyTint_Public_get_Color_0;

		// Token: 0x04003384 RID: 13188
		private static readonly IntPtr NativeMethodInfoPtr_set_SkyTint_Public_set_Void_Color_0;

		// Token: 0x04003385 RID: 13189
		private static readonly IntPtr NativeMethodInfoPtr_get_GroundColor_Public_get_Color_0;

		// Token: 0x04003386 RID: 13190
		private static readonly IntPtr NativeMethodInfoPtr_set_GroundColor_Public_set_Void_Color_0;

		// Token: 0x04003387 RID: 13191
		private static readonly IntPtr NativeMethodInfoPtr_get_Exposure_Public_get_Single_0;

		// Token: 0x04003388 RID: 13192
		private static readonly IntPtr NativeMethodInfoPtr_set_Exposure_Public_set_Void_Single_0;

		// Token: 0x04003389 RID: 13193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProceduralSky_0;
	}
}
