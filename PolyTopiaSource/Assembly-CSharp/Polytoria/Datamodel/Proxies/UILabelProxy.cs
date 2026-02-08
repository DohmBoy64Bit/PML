using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000303 RID: 771
	public class UILabelProxy : UIViewProxy
	{
		// Token: 0x060042FE RID: 17150 RVA: 0x0012CDEC File Offset: 0x0012AFEC
		// Note: this type is marked as 'beforefieldinit'.
		static UILabelProxy()
		{
			Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "UILabelProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr);
			UILabelProxy.NativeFieldInfoPtr_uiLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, "uiLabel");
			UILabelProxy.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673895);
			UILabelProxy.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673896);
			UILabelProxy.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673897);
			UILabelProxy.NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673898);
			UILabelProxy.NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673899);
			UILabelProxy.NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673900);
			UILabelProxy.NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673901);
			UILabelProxy.NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673902);
			UILabelProxy.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673903);
			UILabelProxy.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673904);
			UILabelProxy.NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673905);
			UILabelProxy.NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673906);
			UILabelProxy.NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673907);
			UILabelProxy.NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673908);
			UILabelProxy.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673909);
			UILabelProxy.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673910);
			UILabelProxy.NativeMethodInfoPtr_get_OutlineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673911);
			UILabelProxy.NativeMethodInfoPtr_set_OutlineColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673912);
			UILabelProxy.NativeMethodInfoPtr_get_OutlineWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673913);
			UILabelProxy.NativeMethodInfoPtr_set_OutlineWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673914);
			UILabelProxy.NativeMethodInfoPtr__ctor_Public_Void_UILabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr, 100673894);
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x060042FF RID: 17151 RVA: 0x0012CFD4 File Offset: 0x0012B1D4
		// (set) Token: 0x06004300 RID: 17152 RVA: 0x0012D00C File Offset: 0x0012B20C
		public unsafe string Text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129129, XrefRangeEnd = 129131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06004301 RID: 17153 RVA: 0x0012D050 File Offset: 0x0012B250
		// (set) Token: 0x06004302 RID: 17154 RVA: 0x0012D090 File Offset: 0x0012B290
		public unsafe Color TextColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129131, XrefRangeEnd = 129132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06004303 RID: 17155 RVA: 0x0012D0D4 File Offset: 0x0012B2D4
		// (set) Token: 0x06004304 RID: 17156 RVA: 0x0012D114 File Offset: 0x0012B314
		public unsafe TextJustify JustifyText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextJustify>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129132, XrefRangeEnd = 129134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x0012D158 File Offset: 0x0012B358
		// (set) Token: 0x06004306 RID: 17158 RVA: 0x0012D198 File Offset: 0x0012B398
		public unsafe TextVerticalAlign VerticalAlign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVerticalAlign>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129134, XrefRangeEnd = 129136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x0012D1DC File Offset: 0x0012B3DC
		// (set) Token: 0x06004308 RID: 17160 RVA: 0x0012D218 File Offset: 0x0012B418
		public unsafe float FontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129136, XrefRangeEnd = 129138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06004309 RID: 17161 RVA: 0x0012D258 File Offset: 0x0012B458
		// (set) Token: 0x0600430A RID: 17162 RVA: 0x0012D294 File Offset: 0x0012B494
		public unsafe float MaxFontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129138, XrefRangeEnd = 129140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x0012D2D4 File Offset: 0x0012B4D4
		// (set) Token: 0x0600430C RID: 17164 RVA: 0x0012D310 File Offset: 0x0012B510
		public unsafe bool AutoSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129140, XrefRangeEnd = 129142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x0012D350 File Offset: 0x0012B550
		// (set) Token: 0x0600430E RID: 17166 RVA: 0x0012D390 File Offset: 0x0012B590
		public unsafe TextFontPreset Font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129142, XrefRangeEnd = 129144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x0012D3D4 File Offset: 0x0012B5D4
		// (set) Token: 0x06004310 RID: 17168 RVA: 0x0012D414 File Offset: 0x0012B614
		public unsafe Color OutlineColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_OutlineColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129144, XrefRangeEnd = 129145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_OutlineColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06004311 RID: 17169 RVA: 0x0012D458 File Offset: 0x0012B658
		// (set) Token: 0x06004312 RID: 17170 RVA: 0x0012D494 File Offset: 0x0012B694
		public unsafe float OutlineWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_get_OutlineWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129145, XrefRangeEnd = 129147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr_set_OutlineWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x0012D4D4 File Offset: 0x0012B6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UILabelProxy(UILabel target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UILabelProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabelProxy.NativeMethodInfoPtr__ctor_Public_Void_UILabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00018CB9 File Offset: 0x00016EB9
		public UILabelProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06004315 RID: 17173 RVA: 0x0012D520 File Offset: 0x0012B720
		// (set) Token: 0x06004316 RID: 17174 RVA: 0x00018CC2 File Offset: 0x00016EC2
		public unsafe UILabel uiLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabelProxy.NativeFieldInfoPtr_uiLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILabel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabelProxy.NativeFieldInfoPtr_uiLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003434 RID: 13364
		private static readonly IntPtr NativeFieldInfoPtr_uiLabel;

		// Token: 0x04003435 RID: 13365
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x04003436 RID: 13366
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x04003437 RID: 13367
		private static readonly IntPtr NativeMethodInfoPtr_get_TextColor_Public_get_Color_0;

		// Token: 0x04003438 RID: 13368
		private static readonly IntPtr NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0;

		// Token: 0x04003439 RID: 13369
		private static readonly IntPtr NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0;

		// Token: 0x0400343A RID: 13370
		private static readonly IntPtr NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0;

		// Token: 0x0400343B RID: 13371
		private static readonly IntPtr NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0;

		// Token: 0x0400343C RID: 13372
		private static readonly IntPtr NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0;

		// Token: 0x0400343D RID: 13373
		private static readonly IntPtr NativeMethodInfoPtr_get_FontSize_Public_get_Single_0;

		// Token: 0x0400343E RID: 13374
		private static readonly IntPtr NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0;

		// Token: 0x0400343F RID: 13375
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0;

		// Token: 0x04003440 RID: 13376
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0;

		// Token: 0x04003441 RID: 13377
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0;

		// Token: 0x04003442 RID: 13378
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0;

		// Token: 0x04003443 RID: 13379
		private static readonly IntPtr NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0;

		// Token: 0x04003444 RID: 13380
		private static readonly IntPtr NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0;

		// Token: 0x04003445 RID: 13381
		private static readonly IntPtr NativeMethodInfoPtr_get_OutlineColor_Public_get_Color_0;

		// Token: 0x04003446 RID: 13382
		private static readonly IntPtr NativeMethodInfoPtr_set_OutlineColor_Public_set_Void_Color_0;

		// Token: 0x04003447 RID: 13383
		private static readonly IntPtr NativeMethodInfoPtr_get_OutlineWidth_Public_get_Single_0;

		// Token: 0x04003448 RID: 13384
		private static readonly IntPtr NativeMethodInfoPtr_set_OutlineWidth_Public_set_Void_Single_0;

		// Token: 0x04003449 RID: 13385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UILabel_0;
	}
}
