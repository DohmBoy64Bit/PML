using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using TMPro;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002BB RID: 699
	public class UILabel : UIView
	{
		// Token: 0x06003CFA RID: 15610 RVA: 0x00112F80 File Offset: 0x00111180
		// Note: this type is marked as 'beforefieldinit'.
		static UILabel()
		{
			Il2CppClassPointerStore<UILabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "UILabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILabel>.NativeClassPtr);
			UILabel.NativeFieldInfoPtr_FONT_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "FONT_SCALE");
			UILabel.NativeFieldInfoPtr_tmp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "tmp");
			UILabel.NativeFieldInfoPtr_justify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "justify");
			UILabel.NativeFieldInfoPtr_verticalAlign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "verticalAlign");
			UILabel.NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "fontSize");
			UILabel.NativeFieldInfoPtr_maxFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "maxFontSize");
			UILabel.NativeFieldInfoPtr_autoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "autoSize");
			UILabel.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "text");
			UILabel.NativeFieldInfoPtr_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "textColor");
			UILabel.NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "font");
			UILabel.NativeFieldInfoPtr_outlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "outlineColor");
			UILabel.NativeFieldInfoPtr_outlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "outlineWidth");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_justify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_justify");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_verticalAlign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_verticalAlign");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_fontSize");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_maxFontSize");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_autoSize");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_text");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_textColor");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_font");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_outlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_outlineColor");
			UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_outlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILabel>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_outlineWidth");
			UILabel.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672696);
			UILabel.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672697);
			UILabel.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672698);
			UILabel.NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672699);
			UILabel.NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672700);
			UILabel.NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672701);
			UILabel.NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672702);
			UILabel.NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672703);
			UILabel.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672704);
			UILabel.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672705);
			UILabel.NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672706);
			UILabel.NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672707);
			UILabel.NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672708);
			UILabel.NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672709);
			UILabel.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672710);
			UILabel.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672711);
			UILabel.NativeMethodInfoPtr_get_OutlineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672712);
			UILabel.NativeMethodInfoPtr_set_OutlineColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672713);
			UILabel.NativeMethodInfoPtr_get_OutlineWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672714);
			UILabel.NativeMethodInfoPtr_set_OutlineWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672715);
			UILabel.NativeMethodInfoPtr_get_Networkjustify_Public_get_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672725);
			UILabel.NativeMethodInfoPtr_set_Networkjustify_Public_set_Void_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672726);
			UILabel.NativeMethodInfoPtr_get_NetworkverticalAlign_Public_get_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672727);
			UILabel.NativeMethodInfoPtr_set_NetworkverticalAlign_Public_set_Void_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672728);
			UILabel.NativeMethodInfoPtr_get_NetworkfontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672729);
			UILabel.NativeMethodInfoPtr_set_NetworkfontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672730);
			UILabel.NativeMethodInfoPtr_get_NetworkmaxFontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672731);
			UILabel.NativeMethodInfoPtr_set_NetworkmaxFontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672732);
			UILabel.NativeMethodInfoPtr_get_NetworkautoSize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672733);
			UILabel.NativeMethodInfoPtr_set_NetworkautoSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672734);
			UILabel.NativeMethodInfoPtr_get_Networktext_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672735);
			UILabel.NativeMethodInfoPtr_set_Networktext_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672736);
			UILabel.NativeMethodInfoPtr_get_NetworktextColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672737);
			UILabel.NativeMethodInfoPtr_set_NetworktextColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672738);
			UILabel.NativeMethodInfoPtr_get_Networkfont_Public_get_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672739);
			UILabel.NativeMethodInfoPtr_set_Networkfont_Public_set_Void_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672740);
			UILabel.NativeMethodInfoPtr_get_NetworkoutlineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672741);
			UILabel.NativeMethodInfoPtr_set_NetworkoutlineColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672742);
			UILabel.NativeMethodInfoPtr_get_NetworkoutlineWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672743);
			UILabel.NativeMethodInfoPtr_set_NetworkoutlineWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672744);
			UILabel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672723);
			UILabel.NativeMethodInfoPtr_SyncSetText_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672686);
			UILabel.NativeMethodInfoPtr_SyncSetTextJustify_Private_Void_TextJustify_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672687);
			UILabel.NativeMethodInfoPtr_SyncSetTextAlign_Private_Void_TextVerticalAlign_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672688);
			UILabel.NativeMethodInfoPtr_SyncSetFontSize_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672689);
			UILabel.NativeMethodInfoPtr_SyncSetMaxFontSize_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672690);
			UILabel.NativeMethodInfoPtr_SyncSetAutoSize_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672691);
			UILabel.NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672692);
			UILabel.NativeMethodInfoPtr_SyncSetFont_Private_Void_TextFontPreset_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672693);
			UILabel.NativeMethodInfoPtr_SyncSetOutlineColor_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672694);
			UILabel.NativeMethodInfoPtr_SyncSetOutlineWidth_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672695);
			UILabel.NativeMethodInfoPtr_UpdateOutline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672716);
			UILabel.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672717);
			UILabel.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672718);
			UILabel.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672719);
			UILabel.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672720);
			UILabel.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672721);
			UILabel.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672722);
			UILabel.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672724);
			UILabel.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672745);
			UILabel.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UILabel>.NativeClassPtr, 100672746);
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06003CFB RID: 15611 RVA: 0x0011362C File Offset: 0x0011182C
		// (set) Token: 0x06003CFC RID: 15612 RVA: 0x00113664 File Offset: 0x00111864
		public unsafe string Text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122233, RefRangeEnd = 122239, XrefRangeStart = 122229, XrefRangeEnd = 122233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06003CFD RID: 15613 RVA: 0x001136A8 File Offset: 0x001118A8
		// (set) Token: 0x06003CFE RID: 15614 RVA: 0x001136E8 File Offset: 0x001118E8
		public unsafe Color TextColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122242, RefRangeEnd = 122248, XrefRangeStart = 122239, XrefRangeEnd = 122242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06003CFF RID: 15615 RVA: 0x0011372C File Offset: 0x0011192C
		// (set) Token: 0x06003D00 RID: 15616 RVA: 0x0011376C File Offset: 0x0011196C
		public unsafe TextJustify JustifyText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextJustify>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122257, RefRangeEnd = 122263, XrefRangeStart = 122248, XrefRangeEnd = 122257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06003D01 RID: 15617 RVA: 0x001137B0 File Offset: 0x001119B0
		// (set) Token: 0x06003D02 RID: 15618 RVA: 0x001137F0 File Offset: 0x001119F0
		public unsafe TextVerticalAlign VerticalAlign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVerticalAlign>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122270, RefRangeEnd = 122276, XrefRangeStart = 122263, XrefRangeEnd = 122270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x00113834 File Offset: 0x00111A34
		// (set) Token: 0x06003D04 RID: 15620 RVA: 0x00113870 File Offset: 0x00111A70
		public unsafe float FontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122282, RefRangeEnd = 122288, XrefRangeStart = 122276, XrefRangeEnd = 122282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x001138B0 File Offset: 0x00111AB0
		// (set) Token: 0x06003D06 RID: 15622 RVA: 0x001138EC File Offset: 0x00111AEC
		public unsafe float MaxFontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122294, RefRangeEnd = 122300, XrefRangeStart = 122288, XrefRangeEnd = 122294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06003D07 RID: 15623 RVA: 0x0011392C File Offset: 0x00111B2C
		// (set) Token: 0x06003D08 RID: 15624 RVA: 0x00113968 File Offset: 0x00111B68
		public unsafe bool AutoSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122305, RefRangeEnd = 122311, XrefRangeStart = 122300, XrefRangeEnd = 122305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x001139A8 File Offset: 0x00111BA8
		// (set) Token: 0x06003D0A RID: 15626 RVA: 0x001139E8 File Offset: 0x00111BE8
		public unsafe TextFontPreset Font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122355, RefRangeEnd = 122361, XrefRangeStart = 122311, XrefRangeEnd = 122355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x00113A2C File Offset: 0x00111C2C
		// (set) Token: 0x06003D0C RID: 15628 RVA: 0x00113A6C File Offset: 0x00111C6C
		public unsafe Color OutlineColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_OutlineColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122365, RefRangeEnd = 122366, XrefRangeStart = 122361, XrefRangeEnd = 122365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_OutlineColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x00113AB0 File Offset: 0x00111CB0
		// (set) Token: 0x06003D0E RID: 15630 RVA: 0x00113AEC File Offset: 0x00111CEC
		public unsafe float OutlineWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_OutlineWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122371, RefRangeEnd = 122377, XrefRangeStart = 122366, XrefRangeEnd = 122371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_OutlineWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x00113B2C File Offset: 0x00111D2C
		// (set) Token: 0x06003D10 RID: 15632 RVA: 0x00113B6C File Offset: 0x00111D6C
		public unsafe TextJustify Networkjustify
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_Networkjustify_Public_get_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextJustify>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122377, XrefRangeEnd = 122380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_Networkjustify_Public_set_Void_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06003D11 RID: 15633 RVA: 0x00113BB0 File Offset: 0x00111DB0
		// (set) Token: 0x06003D12 RID: 15634 RVA: 0x00113BF0 File Offset: 0x00111DF0
		public unsafe TextVerticalAlign NetworkverticalAlign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_NetworkverticalAlign_Public_get_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVerticalAlign>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122380, XrefRangeEnd = 122383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_NetworkverticalAlign_Public_set_Void_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06003D13 RID: 15635 RVA: 0x00113C34 File Offset: 0x00111E34
		// (set) Token: 0x06003D14 RID: 15636 RVA: 0x00113C70 File Offset: 0x00111E70
		public unsafe float NetworkfontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_NetworkfontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122383, XrefRangeEnd = 122386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_NetworkfontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x00113CB0 File Offset: 0x00111EB0
		// (set) Token: 0x06003D16 RID: 15638 RVA: 0x00113CEC File Offset: 0x00111EEC
		public unsafe float NetworkmaxFontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_NetworkmaxFontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122389, RefRangeEnd = 122390, XrefRangeStart = 122386, XrefRangeEnd = 122389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_NetworkmaxFontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x00113D2C File Offset: 0x00111F2C
		// (set) Token: 0x06003D18 RID: 15640 RVA: 0x00113D68 File Offset: 0x00111F68
		public unsafe bool NetworkautoSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_NetworkautoSize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122390, XrefRangeEnd = 122393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_NetworkautoSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x00113DA8 File Offset: 0x00111FA8
		// (set) Token: 0x06003D1A RID: 15642 RVA: 0x00113DE0 File Offset: 0x00111FE0
		public unsafe string Networktext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_Networktext_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122393, XrefRangeEnd = 122396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_Networktext_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06003D1B RID: 15643 RVA: 0x00113E24 File Offset: 0x00112024
		// (set) Token: 0x06003D1C RID: 15644 RVA: 0x00113E64 File Offset: 0x00112064
		public unsafe Color NetworktextColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_NetworktextColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122396, XrefRangeEnd = 122399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_NetworktextColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x00113EA8 File Offset: 0x001120A8
		// (set) Token: 0x06003D1E RID: 15646 RVA: 0x00113EE8 File Offset: 0x001120E8
		public unsafe TextFontPreset Networkfont
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_Networkfont_Public_get_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122399, XrefRangeEnd = 122402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_Networkfont_Public_set_Void_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06003D1F RID: 15647 RVA: 0x00113F2C File Offset: 0x0011212C
		// (set) Token: 0x06003D20 RID: 15648 RVA: 0x00113F6C File Offset: 0x0011216C
		public unsafe Color NetworkoutlineColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_NetworkoutlineColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122402, XrefRangeEnd = 122405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_NetworkoutlineColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06003D21 RID: 15649 RVA: 0x00113FB0 File Offset: 0x001121B0
		// (set) Token: 0x06003D22 RID: 15650 RVA: 0x00113FEC File Offset: 0x001121EC
		public unsafe float NetworkoutlineWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_get_NetworkoutlineWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122405, XrefRangeEnd = 122408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_set_NetworkoutlineWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x0011402C File Offset: 0x0011222C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122480, RefRangeEnd = 122481, XrefRangeStart = 122408, XrefRangeEnd = 122480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UILabel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UILabel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x00114068 File Offset: 0x00112268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122481, XrefRangeEnd = 122482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetText(string oldtext, string newtext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldtext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newtext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetText_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x001140BC File Offset: 0x001122BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122482, XrefRangeEnd = 122483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetTextJustify(TextJustify oldValue, TextJustify newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetTextJustify_Private_Void_TextJustify_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x00114110 File Offset: 0x00112310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122483, XrefRangeEnd = 122484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetTextAlign(TextVerticalAlign oldValue, TextVerticalAlign newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetTextAlign_Private_Void_TextVerticalAlign_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x00114164 File Offset: 0x00112364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122484, XrefRangeEnd = 122485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetFontSize(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetFontSize_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x001141B0 File Offset: 0x001123B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122485, XrefRangeEnd = 122486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetMaxFontSize(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetMaxFontSize_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x001141FC File Offset: 0x001123FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122486, XrefRangeEnd = 122487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetAutoSize(bool oldValue, bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetAutoSize_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x00114248 File Offset: 0x00112448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122487, XrefRangeEnd = 122488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void SyncSetColor(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x0011429C File Offset: 0x0011249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122488, XrefRangeEnd = 122489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetFont_Private_Void_TextFontPreset_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x001142F0 File Offset: 0x001124F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122489, XrefRangeEnd = 122493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetOutlineColor(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetOutlineColor_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00114344 File Offset: 0x00112544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122493, XrefRangeEnd = 122494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetOutlineWidth(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_SyncSetOutlineWidth_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00114390 File Offset: 0x00112590
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 122515, RefRangeEnd = 122523, XrefRangeStart = 122494, XrefRangeEnd = 122515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UILabel.NativeMethodInfoPtr_UpdateOutline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x001143C4 File Offset: 0x001125C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122523, XrefRangeEnd = 122533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UILabel.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00114400 File Offset: 0x00112600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122533, XrefRangeEnd = 122547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UILabel.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x0011443C File Offset: 0x0011263C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122547, XrefRangeEnd = 122554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UILabel.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00114478 File Offset: 0x00112678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122554, XrefRangeEnd = 122559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UILabel.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x001144B4 File Offset: 0x001126B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122559, XrefRangeEnd = 122577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UILabel.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00114504 File Offset: 0x00112704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122577, XrefRangeEnd = 122595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UILabel.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00114540 File Offset: 0x00112740
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UILabel.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x00114588 File Offset: 0x00112788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122617, RefRangeEnd = 122618, XrefRangeStart = 122595, XrefRangeEnd = 122617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UILabel.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x001145E4 File Offset: 0x001127E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122685, RefRangeEnd = 122686, XrefRangeStart = 122618, XrefRangeEnd = 122685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UILabel.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x000175FF File Offset: 0x000157FF
		public UILabel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00114640 File Offset: 0x00112840
		// (set) Token: 0x06003D3A RID: 15674 RVA: 0x00017608 File Offset: 0x00015808
		public unsafe static float FONT_SCALE
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(UILabel.NativeFieldInfoPtr_FONT_SCALE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UILabel.NativeFieldInfoPtr_FONT_SCALE, (void*)(&value));
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06003D3B RID: 15675 RVA: 0x0011465C File Offset: 0x0011285C
		// (set) Token: 0x06003D3C RID: 15676 RVA: 0x00017616 File Offset: 0x00015816
		public unsafe TMP_Text tmp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_tmp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_tmp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x0011468C File Offset: 0x0011288C
		// (set) Token: 0x06003D3E RID: 15678 RVA: 0x00017635 File Offset: 0x00015835
		public unsafe TextJustify justify
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_justify);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextJustify>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_justify), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06003D3F RID: 15679 RVA: 0x001146BC File Offset: 0x001128BC
		// (set) Token: 0x06003D40 RID: 15680 RVA: 0x00017654 File Offset: 0x00015854
		public unsafe TextVerticalAlign verticalAlign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_verticalAlign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextVerticalAlign>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_verticalAlign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x001146EC File Offset: 0x001128EC
		// (set) Token: 0x06003D42 RID: 15682 RVA: 0x00017673 File Offset: 0x00015873
		public unsafe float fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_fontSize)) = value;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x00114714 File Offset: 0x00112914
		// (set) Token: 0x06003D44 RID: 15684 RVA: 0x0001768E File Offset: 0x0001588E
		public unsafe float maxFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_maxFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_maxFontSize)) = value;
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x0011473C File Offset: 0x0011293C
		// (set) Token: 0x06003D46 RID: 15686 RVA: 0x000176A9 File Offset: 0x000158A9
		public unsafe bool autoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_autoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_autoSize)) = value;
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x00114764 File Offset: 0x00112964
		// (set) Token: 0x06003D48 RID: 15688 RVA: 0x000176C4 File Offset: 0x000158C4
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x0011478C File Offset: 0x0011298C
		// (set) Token: 0x06003D4A RID: 15690 RVA: 0x000176E3 File Offset: 0x000158E3
		public unsafe Color textColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_textColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_textColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x001147BC File Offset: 0x001129BC
		// (set) Token: 0x06003D4C RID: 15692 RVA: 0x00017702 File Offset: 0x00015902
		public unsafe TextFontPreset font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x001147EC File Offset: 0x001129EC
		// (set) Token: 0x06003D4E RID: 15694 RVA: 0x00017721 File Offset: 0x00015921
		public unsafe Color outlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_outlineColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_outlineColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x0011481C File Offset: 0x00112A1C
		// (set) Token: 0x06003D50 RID: 15696 RVA: 0x00017740 File Offset: 0x00015940
		public unsafe float outlineWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_outlineWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr_outlineWidth)) = value;
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x00114844 File Offset: 0x00112A44
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x0001775B File Offset: 0x0001595B
		public unsafe Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_justify);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextJustify, TextJustify>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_justify), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x00114874 File Offset: 0x00112A74
		// (set) Token: 0x06003D54 RID: 15700 RVA: 0x0001777A File Offset: 0x0001597A
		public unsafe Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_verticalAlign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextVerticalAlign, TextVerticalAlign>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_verticalAlign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06003D55 RID: 15701 RVA: 0x001148A4 File Offset: 0x00112AA4
		// (set) Token: 0x06003D56 RID: 15702 RVA: 0x00017799 File Offset: 0x00015999
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_fontSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_fontSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06003D57 RID: 15703 RVA: 0x001148D4 File Offset: 0x00112AD4
		// (set) Token: 0x06003D58 RID: 15704 RVA: 0x000177B8 File Offset: 0x000159B8
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_maxFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxFontSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxFontSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06003D59 RID: 15705 RVA: 0x00114904 File Offset: 0x00112B04
		// (set) Token: 0x06003D5A RID: 15706 RVA: 0x000177D7 File Offset: 0x000159D7
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_autoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06003D5B RID: 15707 RVA: 0x00114934 File Offset: 0x00112B34
		// (set) Token: 0x06003D5C RID: 15708 RVA: 0x000177F6 File Offset: 0x000159F6
		public unsafe Action<string, string> _Mirror_SyncVarHookDelegate_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06003D5D RID: 15709 RVA: 0x00114964 File Offset: 0x00112B64
		// (set) Token: 0x06003D5E RID: 15710 RVA: 0x00017815 File Offset: 0x00015A15
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x00114994 File Offset: 0x00112B94
		// (set) Token: 0x06003D60 RID: 15712 RVA: 0x00017834 File Offset: 0x00015A34
		public unsafe Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextFontPreset, TextFontPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x001149C4 File Offset: 0x00112BC4
		// (set) Token: 0x06003D62 RID: 15714 RVA: 0x00017853 File Offset: 0x00015A53
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_outlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_outlineColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_outlineColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x001149F4 File Offset: 0x00112BF4
		// (set) Token: 0x06003D64 RID: 15716 RVA: 0x00017872 File Offset: 0x00015A72
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_outlineWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_outlineWidth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UILabel.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_outlineWidth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F76 RID: 12150
		private static readonly IntPtr NativeFieldInfoPtr_FONT_SCALE;

		// Token: 0x04002F77 RID: 12151
		private static readonly IntPtr NativeFieldInfoPtr_tmp;

		// Token: 0x04002F78 RID: 12152
		private static readonly IntPtr NativeFieldInfoPtr_justify;

		// Token: 0x04002F79 RID: 12153
		private static readonly IntPtr NativeFieldInfoPtr_verticalAlign;

		// Token: 0x04002F7A RID: 12154
		private static readonly IntPtr NativeFieldInfoPtr_fontSize;

		// Token: 0x04002F7B RID: 12155
		private static readonly IntPtr NativeFieldInfoPtr_maxFontSize;

		// Token: 0x04002F7C RID: 12156
		private static readonly IntPtr NativeFieldInfoPtr_autoSize;

		// Token: 0x04002F7D RID: 12157
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002F7E RID: 12158
		private static readonly IntPtr NativeFieldInfoPtr_textColor;

		// Token: 0x04002F7F RID: 12159
		private static readonly IntPtr NativeFieldInfoPtr_font;

		// Token: 0x04002F80 RID: 12160
		private static readonly IntPtr NativeFieldInfoPtr_outlineColor;

		// Token: 0x04002F81 RID: 12161
		private static readonly IntPtr NativeFieldInfoPtr_outlineWidth;

		// Token: 0x04002F82 RID: 12162
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_justify;

		// Token: 0x04002F83 RID: 12163
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_verticalAlign;

		// Token: 0x04002F84 RID: 12164
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_fontSize;

		// Token: 0x04002F85 RID: 12165
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxFontSize;

		// Token: 0x04002F86 RID: 12166
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoSize;

		// Token: 0x04002F87 RID: 12167
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_text;

		// Token: 0x04002F88 RID: 12168
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textColor;

		// Token: 0x04002F89 RID: 12169
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font;

		// Token: 0x04002F8A RID: 12170
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_outlineColor;

		// Token: 0x04002F8B RID: 12171
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_outlineWidth;

		// Token: 0x04002F8C RID: 12172
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x04002F8D RID: 12173
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x04002F8E RID: 12174
		private static readonly IntPtr NativeMethodInfoPtr_get_TextColor_Public_get_Color_0;

		// Token: 0x04002F8F RID: 12175
		private static readonly IntPtr NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly IntPtr NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0;

		// Token: 0x04002F91 RID: 12177
		private static readonly IntPtr NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0;

		// Token: 0x04002F92 RID: 12178
		private static readonly IntPtr NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0;

		// Token: 0x04002F93 RID: 12179
		private static readonly IntPtr NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly IntPtr NativeMethodInfoPtr_get_FontSize_Public_get_Single_0;

		// Token: 0x04002F95 RID: 12181
		private static readonly IntPtr NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0;

		// Token: 0x04002F96 RID: 12182
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0;

		// Token: 0x04002F97 RID: 12183
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0;

		// Token: 0x04002F98 RID: 12184
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0;

		// Token: 0x04002F99 RID: 12185
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0;

		// Token: 0x04002F9A RID: 12186
		private static readonly IntPtr NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0;

		// Token: 0x04002F9B RID: 12187
		private static readonly IntPtr NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0;

		// Token: 0x04002F9C RID: 12188
		private static readonly IntPtr NativeMethodInfoPtr_get_OutlineColor_Public_get_Color_0;

		// Token: 0x04002F9D RID: 12189
		private static readonly IntPtr NativeMethodInfoPtr_set_OutlineColor_Public_set_Void_Color_0;

		// Token: 0x04002F9E RID: 12190
		private static readonly IntPtr NativeMethodInfoPtr_get_OutlineWidth_Public_get_Single_0;

		// Token: 0x04002F9F RID: 12191
		private static readonly IntPtr NativeMethodInfoPtr_set_OutlineWidth_Public_set_Void_Single_0;

		// Token: 0x04002FA0 RID: 12192
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkjustify_Public_get_TextJustify_0;

		// Token: 0x04002FA1 RID: 12193
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkjustify_Public_set_Void_TextJustify_0;

		// Token: 0x04002FA2 RID: 12194
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkverticalAlign_Public_get_TextVerticalAlign_0;

		// Token: 0x04002FA3 RID: 12195
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkverticalAlign_Public_set_Void_TextVerticalAlign_0;

		// Token: 0x04002FA4 RID: 12196
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfontSize_Public_get_Single_0;

		// Token: 0x04002FA5 RID: 12197
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfontSize_Public_set_Void_Single_0;

		// Token: 0x04002FA6 RID: 12198
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkmaxFontSize_Public_get_Single_0;

		// Token: 0x04002FA7 RID: 12199
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkmaxFontSize_Public_set_Void_Single_0;

		// Token: 0x04002FA8 RID: 12200
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkautoSize_Public_get_Boolean_0;

		// Token: 0x04002FA9 RID: 12201
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkautoSize_Public_set_Void_Boolean_0;

		// Token: 0x04002FAA RID: 12202
		private static readonly IntPtr NativeMethodInfoPtr_get_Networktext_Public_get_String_0;

		// Token: 0x04002FAB RID: 12203
		private static readonly IntPtr NativeMethodInfoPtr_set_Networktext_Public_set_Void_String_0;

		// Token: 0x04002FAC RID: 12204
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworktextColor_Public_get_Color_0;

		// Token: 0x04002FAD RID: 12205
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworktextColor_Public_set_Void_Color_0;

		// Token: 0x04002FAE RID: 12206
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkfont_Public_get_TextFontPreset_0;

		// Token: 0x04002FAF RID: 12207
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkfont_Public_set_Void_TextFontPreset_0;

		// Token: 0x04002FB0 RID: 12208
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkoutlineColor_Public_get_Color_0;

		// Token: 0x04002FB1 RID: 12209
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkoutlineColor_Public_set_Void_Color_0;

		// Token: 0x04002FB2 RID: 12210
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkoutlineWidth_Public_get_Single_0;

		// Token: 0x04002FB3 RID: 12211
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkoutlineWidth_Public_set_Void_Single_0;

		// Token: 0x04002FB4 RID: 12212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002FB5 RID: 12213
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetText_Private_Void_String_String_0;

		// Token: 0x04002FB6 RID: 12214
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetTextJustify_Private_Void_TextJustify_TextJustify_0;

		// Token: 0x04002FB7 RID: 12215
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetTextAlign_Private_Void_TextVerticalAlign_TextVerticalAlign_0;

		// Token: 0x04002FB8 RID: 12216
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetFontSize_Private_Void_Single_Single_0;

		// Token: 0x04002FB9 RID: 12217
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetMaxFontSize_Private_Void_Single_Single_0;

		// Token: 0x04002FBA RID: 12218
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetAutoSize_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002FBB RID: 12219
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0;

		// Token: 0x04002FBC RID: 12220
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetFont_Private_Void_TextFontPreset_TextFontPreset_0;

		// Token: 0x04002FBD RID: 12221
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetOutlineColor_Private_Void_Color_Color_0;

		// Token: 0x04002FBE RID: 12222
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetOutlineWidth_Private_Void_Single_Single_0;

		// Token: 0x04002FBF RID: 12223
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutline_Private_Void_0;

		// Token: 0x04002FC0 RID: 12224
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002FC1 RID: 12225
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002FC2 RID: 12226
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002FC3 RID: 12227
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002FC4 RID: 12228
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002FC5 RID: 12229
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04002FC6 RID: 12230
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002FC7 RID: 12231
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002FC8 RID: 12232
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
