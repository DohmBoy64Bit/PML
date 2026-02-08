using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002EF RID: 751
	public class PointLightProxy : DynamicInstanceProxy
	{
		// Token: 0x06004200 RID: 16896 RVA: 0x00128B3C File Offset: 0x00126D3C
		// Note: this type is marked as 'beforefieldinit'.
		static PointLightProxy()
		{
			Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "PointLightProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr);
			PointLightProxy.NativeFieldInfoPtr_pointLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, "pointLight");
			PointLightProxy.NativeMethodInfoPtr_get_Range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, 100673721);
			PointLightProxy.NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, 100673722);
			PointLightProxy.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, 100673723);
			PointLightProxy.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, 100673724);
			PointLightProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, 100673725);
			PointLightProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, 100673726);
			PointLightProxy.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, 100673727);
			PointLightProxy.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, 100673728);
			PointLightProxy.NativeMethodInfoPtr__ctor_Public_Void_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr, 100673720);
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x00128C34 File Offset: 0x00126E34
		// (set) Token: 0x06004202 RID: 16898 RVA: 0x00128C70 File Offset: 0x00126E70
		public unsafe float Range
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128950, XrefRangeEnd = 128952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLightProxy.NativeMethodInfoPtr_get_Range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128952, XrefRangeEnd = 128954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLightProxy.NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06004203 RID: 16899 RVA: 0x00128CB0 File Offset: 0x00126EB0
		// (set) Token: 0x06004204 RID: 16900 RVA: 0x00128CEC File Offset: 0x00126EEC
		public unsafe float Brightness
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128954, XrefRangeEnd = 128956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLightProxy.NativeMethodInfoPtr_get_Brightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128956, XrefRangeEnd = 128958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLightProxy.NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x00128D2C File Offset: 0x00126F2C
		// (set) Token: 0x06004206 RID: 16902 RVA: 0x00128D6C File Offset: 0x00126F6C
		public unsafe Color Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128958, XrefRangeEnd = 128959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLightProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128959, XrefRangeEnd = 128960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLightProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x00128DB0 File Offset: 0x00126FB0
		// (set) Token: 0x06004208 RID: 16904 RVA: 0x00128DEC File Offset: 0x00126FEC
		public unsafe bool Shadows
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128960, XrefRangeEnd = 128962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLightProxy.NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128962, XrefRangeEnd = 128964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLightProxy.NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00128E2C File Offset: 0x0012702C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointLightProxy(PointLight target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointLightProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointLightProxy.NativeMethodInfoPtr__ctor_Public_Void_PointLight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00018999 File Offset: 0x00016B99
		public PointLightProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x00128E78 File Offset: 0x00127078
		// (set) Token: 0x0600420C RID: 16908 RVA: 0x000189A2 File Offset: 0x00016BA2
		public unsafe PointLight pointLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLightProxy.NativeFieldInfoPtr_pointLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointLightProxy.NativeFieldInfoPtr_pointLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003372 RID: 13170
		private static readonly IntPtr NativeFieldInfoPtr_pointLight;

		// Token: 0x04003373 RID: 13171
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_get_Single_0;

		// Token: 0x04003374 RID: 13172
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_set_Void_Single_0;

		// Token: 0x04003375 RID: 13173
		private static readonly IntPtr NativeMethodInfoPtr_get_Brightness_Public_get_Single_0;

		// Token: 0x04003376 RID: 13174
		private static readonly IntPtr NativeMethodInfoPtr_set_Brightness_Public_set_Void_Single_0;

		// Token: 0x04003377 RID: 13175
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04003378 RID: 13176
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04003379 RID: 13177
		private static readonly IntPtr NativeMethodInfoPtr_get_Shadows_Public_get_Boolean_0;

		// Token: 0x0400337A RID: 13178
		private static readonly IntPtr NativeMethodInfoPtr_set_Shadows_Public_set_Void_Boolean_0;

		// Token: 0x0400337B RID: 13179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PointLight_0;
	}
}
