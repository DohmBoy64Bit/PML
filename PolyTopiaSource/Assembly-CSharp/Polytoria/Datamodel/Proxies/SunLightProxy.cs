using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FA RID: 762
	public class SunLightProxy : DynamicInstanceProxy
	{
		// Token: 0x0600427F RID: 17023 RVA: 0x0012ABBC File Offset: 0x00128DBC
		// Note: this type is marked as 'beforefieldinit'.
		static SunLightProxy()
		{
			Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "SunLightProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr);
			SunLightProxy.NativeFieldInfoPtr_sunLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr, "sunLight");
			SunLightProxy.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr, 100673804);
			SunLightProxy.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr, 100673805);
			SunLightProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr, 100673806);
			SunLightProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr, 100673807);
			SunLightProxy.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr, 100673808);
			SunLightProxy.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr, 100673809);
			SunLightProxy.NativeMethodInfoPtr__ctor_Public_Void_SunLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr, 100673803);
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06004280 RID: 17024 RVA: 0x0012AC8C File Offset: 0x00128E8C
		// (set) Token: 0x06004281 RID: 17025 RVA: 0x0012ACC8 File Offset: 0x00128EC8
		public unsafe float Brightness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLightProxy.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129041, XrefRangeEnd = 129043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLightProxy.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06004282 RID: 17026 RVA: 0x0012AD08 File Offset: 0x00128F08
		// (set) Token: 0x06004283 RID: 17027 RVA: 0x0012AD48 File Offset: 0x00128F48
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLightProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129043, XrefRangeEnd = 129044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLightProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06004284 RID: 17028 RVA: 0x0012AD8C File Offset: 0x00128F8C
		// (set) Token: 0x06004285 RID: 17029 RVA: 0x0012ADC8 File Offset: 0x00128FC8
		public unsafe bool Shadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLightProxy.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129044, XrefRangeEnd = 129046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLightProxy.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x0012AE08 File Offset: 0x00129008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SunLightProxy(SunLight target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SunLightProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SunLightProxy.NativeMethodInfoPtr__ctor_Public_Void_SunLight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x00018B51 File Offset: 0x00016D51
		public SunLightProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06004288 RID: 17032 RVA: 0x0012AE54 File Offset: 0x00129054
		// (set) Token: 0x06004289 RID: 17033 RVA: 0x00018B5A File Offset: 0x00016D5A
		public unsafe SunLight sunLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLightProxy.NativeFieldInfoPtr_sunLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SunLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SunLightProxy.NativeFieldInfoPtr_sunLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033D0 RID: 13264
		private static readonly IntPtr NativeFieldInfoPtr_sunLight;

		// Token: 0x040033D1 RID: 13265
		private static readonly IntPtr NativeMethodInfoPtr_get_Brightness_Public_get_Single_0;

		// Token: 0x040033D2 RID: 13266
		private static readonly IntPtr NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0;

		// Token: 0x040033D3 RID: 13267
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x040033D4 RID: 13268
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x040033D5 RID: 13269
		private static readonly IntPtr NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0;

		// Token: 0x040033D6 RID: 13270
		private static readonly IntPtr NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0;

		// Token: 0x040033D7 RID: 13271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SunLight_0;
	}
}
