using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FB RID: 763
	public class Text3DProxy : DynamicInstanceProxy
	{
		// Token: 0x0600428A RID: 17034 RVA: 0x0012AE84 File Offset: 0x00129084
		// Note: this type is marked as 'beforefieldinit'.
		static Text3DProxy()
		{
			Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "Text3DProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr);
			Text3DProxy.NativeFieldInfoPtr_text3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, "text3D");
			Text3DProxy.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673811);
			Text3DProxy.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673812);
			Text3DProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673813);
			Text3DProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673814);
			Text3DProxy.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673815);
			Text3DProxy.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673816);
			Text3DProxy.NativeMethodInfoPtr_get_FaceCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673817);
			Text3DProxy.NativeMethodInfoPtr_set_FaceCamera_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673818);
			Text3DProxy.NativeMethodInfoPtr_get_HorizontalAlignment_Public_get_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673819);
			Text3DProxy.NativeMethodInfoPtr_set_HorizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673820);
			Text3DProxy.NativeMethodInfoPtr_get_VerticalAlignment_Public_get_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673821);
			Text3DProxy.NativeMethodInfoPtr_set_VerticalAlignment_Public_set_Void_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673822);
			Text3DProxy.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673823);
			Text3DProxy.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673824);
			Text3DProxy.NativeMethodInfoPtr__ctor_Public_Void_Text3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr, 100673810);
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x0012AFF4 File Offset: 0x001291F4
		// (set) Token: 0x0600428C RID: 17036 RVA: 0x0012B02C File Offset: 0x0012922C
		public unsafe string Text
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129046, XrefRangeEnd = 129048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129048, XrefRangeEnd = 129050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x0012B070 File Offset: 0x00129270
		// (set) Token: 0x0600428E RID: 17038 RVA: 0x0012B0B0 File Offset: 0x001292B0
		public unsafe Color Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129050, XrefRangeEnd = 129051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129051, XrefRangeEnd = 129052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x0600428F RID: 17039 RVA: 0x0012B0F4 File Offset: 0x001292F4
		// (set) Token: 0x06004290 RID: 17040 RVA: 0x0012B130 File Offset: 0x00129330
		public unsafe float FontSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129052, XrefRangeEnd = 129054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129054, XrefRangeEnd = 129056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x0012B170 File Offset: 0x00129370
		// (set) Token: 0x06004292 RID: 17042 RVA: 0x0012B1AC File Offset: 0x001293AC
		public unsafe bool FaceCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_get_FaceCamera_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129056, XrefRangeEnd = 129058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_set_FaceCamera_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x0012B1EC File Offset: 0x001293EC
		// (set) Token: 0x06004294 RID: 17044 RVA: 0x0012B22C File Offset: 0x0012942C
		public unsafe HorizontalAlignmentOptions HorizontalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_get_HorizontalAlignment_Public_get_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HorizontalAlignmentOptions>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129058, XrefRangeEnd = 129060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_set_HorizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x0012B270 File Offset: 0x00129470
		// (set) Token: 0x06004296 RID: 17046 RVA: 0x0012B2B0 File Offset: 0x001294B0
		public unsafe VerticalAlignmentOptions VerticalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_get_VerticalAlignment_Public_get_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VerticalAlignmentOptions>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129060, XrefRangeEnd = 129062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_set_VerticalAlignment_Public_set_Void_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x0012B2F4 File Offset: 0x001294F4
		// (set) Token: 0x06004298 RID: 17048 RVA: 0x0012B334 File Offset: 0x00129534
		public unsafe TextFontPreset Font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129062, XrefRangeEnd = 129064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x0012B378 File Offset: 0x00129578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Text3DProxy(Text3D target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Text3DProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Text3DProxy.NativeMethodInfoPtr__ctor_Public_Void_Text3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x00018B79 File Offset: 0x00016D79
		public Text3DProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x0600429B RID: 17051 RVA: 0x0012B3C4 File Offset: 0x001295C4
		// (set) Token: 0x0600429C RID: 17052 RVA: 0x00018B82 File Offset: 0x00016D82
		public unsafe Text3D text3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3DProxy.NativeFieldInfoPtr_text3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Text3DProxy.NativeFieldInfoPtr_text3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033D8 RID: 13272
		private static readonly IntPtr NativeFieldInfoPtr_text3D;

		// Token: 0x040033D9 RID: 13273
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x040033DA RID: 13274
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x040033DB RID: 13275
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x040033DC RID: 13276
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x040033DD RID: 13277
		private static readonly IntPtr NativeMethodInfoPtr_get_FontSize_Public_get_Single_0;

		// Token: 0x040033DE RID: 13278
		private static readonly IntPtr NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0;

		// Token: 0x040033DF RID: 13279
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceCamera_Public_get_Boolean_0;

		// Token: 0x040033E0 RID: 13280
		private static readonly IntPtr NativeMethodInfoPtr_set_FaceCamera_Public_set_Void_Boolean_0;

		// Token: 0x040033E1 RID: 13281
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizontalAlignment_Public_get_HorizontalAlignmentOptions_0;

		// Token: 0x040033E2 RID: 13282
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0;

		// Token: 0x040033E3 RID: 13283
		private static readonly IntPtr NativeMethodInfoPtr_get_VerticalAlignment_Public_get_VerticalAlignmentOptions_0;

		// Token: 0x040033E4 RID: 13284
		private static readonly IntPtr NativeMethodInfoPtr_set_VerticalAlignment_Public_set_Void_VerticalAlignmentOptions_0;

		// Token: 0x040033E5 RID: 13285
		private static readonly IntPtr NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0;

		// Token: 0x040033E6 RID: 13286
		private static readonly IntPtr NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0;

		// Token: 0x040033E7 RID: 13287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Text3D_0;
	}
}
