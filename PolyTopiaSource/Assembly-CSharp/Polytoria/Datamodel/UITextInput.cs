using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using Polytoria.Lua;
using TMPro;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002BC RID: 700
	public class UITextInput : UIView
	{
		// Token: 0x06003D65 RID: 15717 RVA: 0x00114A24 File Offset: 0x00112C24
		// Note: this type is marked as 'beforefieldinit'.
		static UITextInput()
		{
			Il2CppClassPointerStore<UITextInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "UITextInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITextInput>.NativeClassPtr);
			UITextInput.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "inputField");
			UITextInput.NativeFieldInfoPtr_placeholderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "placeholderText");
			UITextInput.NativeFieldInfoPtr_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "Changed");
			UITextInput.NativeFieldInfoPtr_Submitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "Submitted");
			UITextInput.NativeFieldInfoPtr_justify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "justify");
			UITextInput.NativeFieldInfoPtr_verticalAlign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "verticalAlign");
			UITextInput.NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "fontSize");
			UITextInput.NativeFieldInfoPtr_maxFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "maxFontSize");
			UITextInput.NativeFieldInfoPtr_autoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "autoSize");
			UITextInput.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "text");
			UITextInput.NativeFieldInfoPtr_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "textColor");
			UITextInput.NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "font");
			UITextInput.NativeFieldInfoPtr_placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "placeholder");
			UITextInput.NativeFieldInfoPtr_placeholderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "placeholderColor");
			UITextInput.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "isReadOnly");
			UITextInput.NativeFieldInfoPtr_isMultiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "isMultiline");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_justify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_justify");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_verticalAlign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_verticalAlign");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_fontSize");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_maxFontSize");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_autoSize");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_text");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_textColor");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_font");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_placeholder");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_placeholderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_placeholderColor");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_isReadOnly");
			UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isMultiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_isMultiline");
			UITextInput.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672747);
			UITextInput.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672748);
			UITextInput.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672749);
			UITextInput.NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672750);
			UITextInput.NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672751);
			UITextInput.NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672752);
			UITextInput.NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672753);
			UITextInput.NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672754);
			UITextInput.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672755);
			UITextInput.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672756);
			UITextInput.NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672757);
			UITextInput.NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672758);
			UITextInput.NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672759);
			UITextInput.NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672760);
			UITextInput.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672761);
			UITextInput.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672762);
			UITextInput.NativeMethodInfoPtr_get_Placeholder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672763);
			UITextInput.NativeMethodInfoPtr_set_Placeholder_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672764);
			UITextInput.NativeMethodInfoPtr_get_PlaceholderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672765);
			UITextInput.NativeMethodInfoPtr_set_PlaceholderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672766);
			UITextInput.NativeMethodInfoPtr_get_IsMultiline_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672767);
			UITextInput.NativeMethodInfoPtr_set_IsMultiline_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672768);
			UITextInput.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672769);
			UITextInput.NativeMethodInfoPtr_set_IsReadOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672770);
			UITextInput.NativeMethodInfoPtr_get_IsFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672771);
			UITextInput.NativeMethodInfoPtr_get_Networkjustify_Public_get_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672794);
			UITextInput.NativeMethodInfoPtr_set_Networkjustify_Public_set_Void_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672795);
			UITextInput.NativeMethodInfoPtr_get_NetworkverticalAlign_Public_get_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672796);
			UITextInput.NativeMethodInfoPtr_set_NetworkverticalAlign_Public_set_Void_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672797);
			UITextInput.NativeMethodInfoPtr_get_NetworkfontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672798);
			UITextInput.NativeMethodInfoPtr_set_NetworkfontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672799);
			UITextInput.NativeMethodInfoPtr_get_NetworkmaxFontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672800);
			UITextInput.NativeMethodInfoPtr_set_NetworkmaxFontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672801);
			UITextInput.NativeMethodInfoPtr_get_NetworkautoSize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672802);
			UITextInput.NativeMethodInfoPtr_set_NetworkautoSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672803);
			UITextInput.NativeMethodInfoPtr_get_Networktext_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672804);
			UITextInput.NativeMethodInfoPtr_set_Networktext_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672805);
			UITextInput.NativeMethodInfoPtr_get_NetworktextColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672806);
			UITextInput.NativeMethodInfoPtr_set_NetworktextColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672807);
			UITextInput.NativeMethodInfoPtr_get_Networkfont_Public_get_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672808);
			UITextInput.NativeMethodInfoPtr_set_Networkfont_Public_set_Void_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672809);
			UITextInput.NativeMethodInfoPtr_get_Networkplaceholder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672810);
			UITextInput.NativeMethodInfoPtr_set_Networkplaceholder_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672811);
			UITextInput.NativeMethodInfoPtr_get_NetworkplaceholderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672812);
			UITextInput.NativeMethodInfoPtr_set_NetworkplaceholderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672813);
			UITextInput.NativeMethodInfoPtr_get_NetworkisReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672814);
			UITextInput.NativeMethodInfoPtr_set_NetworkisReadOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672815);
			UITextInput.NativeMethodInfoPtr_get_NetworkisMultiline_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672816);
			UITextInput.NativeMethodInfoPtr_set_NetworkisMultiline_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672817);
			UITextInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672790);
			UITextInput.NativeMethodInfoPtr_Focus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672772);
			UITextInput.NativeMethodInfoPtr_SyncSetText_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672773);
			UITextInput.NativeMethodInfoPtr_SyncSetTextJustify_Private_Void_TextJustify_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672774);
			UITextInput.NativeMethodInfoPtr_SyncSetTextAlign_Private_Void_TextVerticalAlign_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672775);
			UITextInput.NativeMethodInfoPtr_SyncSetFontSize_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672776);
			UITextInput.NativeMethodInfoPtr_SyncSetMaxFontSize_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672777);
			UITextInput.NativeMethodInfoPtr_SyncSetAutoSize_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672778);
			UITextInput.NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672779);
			UITextInput.NativeMethodInfoPtr_SyncSetFont_Private_Void_TextFontPreset_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672780);
			UITextInput.NativeMethodInfoPtr_SyncSetPlaceholder_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672781);
			UITextInput.NativeMethodInfoPtr_SyncSetPlaceholderColor_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672782);
			UITextInput.NativeMethodInfoPtr_SyncSetIsMultiline_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672783);
			UITextInput.NativeMethodInfoPtr_SyncSetIsReadOnly_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672784);
			UITextInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672785);
			UITextInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672786);
			UITextInput.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672787);
			UITextInput.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672788);
			UITextInput.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672789);
			UITextInput.NativeMethodInfoPtr__Awake_b__67_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672791);
			UITextInput.NativeMethodInfoPtr__Awake_b__67_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672792);
			UITextInput.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672793);
			UITextInput.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672818);
			UITextInput.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInput>.NativeClassPtr, 100672819);
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x00115238 File Offset: 0x00113438
		// (set) Token: 0x06003D67 RID: 15719 RVA: 0x00115270 File Offset: 0x00113470
		public unsafe string Text
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122686, RefRangeEnd = 122687, XrefRangeStart = 122686, XrefRangeEnd = 122686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122692, RefRangeEnd = 122696, XrefRangeStart = 122687, XrefRangeEnd = 122692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06003D68 RID: 15720 RVA: 0x001152B4 File Offset: 0x001134B4
		// (set) Token: 0x06003D69 RID: 15721 RVA: 0x001152F4 File Offset: 0x001134F4
		public unsafe Color TextColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122699, RefRangeEnd = 122703, XrefRangeStart = 122696, XrefRangeEnd = 122699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x00115338 File Offset: 0x00113538
		// (set) Token: 0x06003D6B RID: 15723 RVA: 0x00115378 File Offset: 0x00113578
		public unsafe TextJustify JustifyText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextJustify>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122713, RefRangeEnd = 122717, XrefRangeStart = 122703, XrefRangeEnd = 122713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06003D6C RID: 15724 RVA: 0x001153BC File Offset: 0x001135BC
		// (set) Token: 0x06003D6D RID: 15725 RVA: 0x001153FC File Offset: 0x001135FC
		public unsafe TextVerticalAlign VerticalAlign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVerticalAlign>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122725, RefRangeEnd = 122729, XrefRangeStart = 122717, XrefRangeEnd = 122725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06003D6E RID: 15726 RVA: 0x00115440 File Offset: 0x00113640
		// (set) Token: 0x06003D6F RID: 15727 RVA: 0x0011547C File Offset: 0x0011367C
		public unsafe float FontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122736, RefRangeEnd = 122740, XrefRangeStart = 122729, XrefRangeEnd = 122736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06003D70 RID: 15728 RVA: 0x001154BC File Offset: 0x001136BC
		// (set) Token: 0x06003D71 RID: 15729 RVA: 0x001154F8 File Offset: 0x001136F8
		public unsafe float MaxFontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122748, RefRangeEnd = 122752, XrefRangeStart = 122740, XrefRangeEnd = 122748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06003D72 RID: 15730 RVA: 0x00115538 File Offset: 0x00113738
		// (set) Token: 0x06003D73 RID: 15731 RVA: 0x00115574 File Offset: 0x00113774
		public unsafe bool AutoSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122758, RefRangeEnd = 122762, XrefRangeStart = 122752, XrefRangeEnd = 122758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06003D74 RID: 15732 RVA: 0x001155B4 File Offset: 0x001137B4
		// (set) Token: 0x06003D75 RID: 15733 RVA: 0x001155F4 File Offset: 0x001137F4
		public unsafe TextFontPreset Font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122864, RefRangeEnd = 122868, XrefRangeStart = 122762, XrefRangeEnd = 122864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06003D76 RID: 15734 RVA: 0x00115638 File Offset: 0x00113838
		// (set) Token: 0x06003D77 RID: 15735 RVA: 0x00115670 File Offset: 0x00113870
		public unsafe string Placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_Placeholder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122872, RefRangeEnd = 122876, XrefRangeStart = 122868, XrefRangeEnd = 122872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_Placeholder_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06003D78 RID: 15736 RVA: 0x001156B4 File Offset: 0x001138B4
		// (set) Token: 0x06003D79 RID: 15737 RVA: 0x001156F4 File Offset: 0x001138F4
		public unsafe Color PlaceholderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_PlaceholderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122879, RefRangeEnd = 122880, XrefRangeStart = 122876, XrefRangeEnd = 122879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_PlaceholderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06003D7A RID: 15738 RVA: 0x00115738 File Offset: 0x00113938
		// (set) Token: 0x06003D7B RID: 15739 RVA: 0x00115774 File Offset: 0x00113974
		public unsafe bool IsMultiline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_IsMultiline_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 122885, RefRangeEnd = 122888, XrefRangeStart = 122880, XrefRangeEnd = 122885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_IsMultiline_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06003D7C RID: 15740 RVA: 0x001157B4 File Offset: 0x001139B4
		// (set) Token: 0x06003D7D RID: 15741 RVA: 0x001157F0 File Offset: 0x001139F0
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 122891, RefRangeEnd = 122894, XrefRangeStart = 122888, XrefRangeEnd = 122891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_IsReadOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06003D7E RID: 15742 RVA: 0x00115830 File Offset: 0x00113A30
		public unsafe bool IsFocused
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122894, RefRangeEnd = 122895, XrefRangeStart = 122894, XrefRangeEnd = 122894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_IsFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x0011586C File Offset: 0x00113A6C
		// (set) Token: 0x06003D80 RID: 15744 RVA: 0x001158AC File Offset: 0x00113AAC
		public unsafe TextJustify Networkjustify
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_Networkjustify_Public_get_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextJustify>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122895, XrefRangeEnd = 122898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_Networkjustify_Public_set_Void_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x001158F0 File Offset: 0x00113AF0
		// (set) Token: 0x06003D82 RID: 15746 RVA: 0x00115930 File Offset: 0x00113B30
		public unsafe TextVerticalAlign NetworkverticalAlign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_NetworkverticalAlign_Public_get_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVerticalAlign>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122898, XrefRangeEnd = 122901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_NetworkverticalAlign_Public_set_Void_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00115974 File Offset: 0x00113B74
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x001159B0 File Offset: 0x00113BB0
		public unsafe float NetworkfontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_NetworkfontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122901, XrefRangeEnd = 122904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_NetworkfontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x001159F0 File Offset: 0x00113BF0
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x00115A2C File Offset: 0x00113C2C
		public unsafe float NetworkmaxFontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_NetworkmaxFontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122907, RefRangeEnd = 122908, XrefRangeStart = 122904, XrefRangeEnd = 122907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_NetworkmaxFontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x00115A6C File Offset: 0x00113C6C
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x00115AA8 File Offset: 0x00113CA8
		public unsafe bool NetworkautoSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_NetworkautoSize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122908, XrefRangeEnd = 122911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_NetworkautoSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x00115AE8 File Offset: 0x00113CE8
		// (set) Token: 0x06003D8A RID: 15754 RVA: 0x00115B20 File Offset: 0x00113D20
		public unsafe string Networktext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_Networktext_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122911, XrefRangeEnd = 122914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_Networktext_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06003D8B RID: 15755 RVA: 0x00115B64 File Offset: 0x00113D64
		// (set) Token: 0x06003D8C RID: 15756 RVA: 0x00115BA4 File Offset: 0x00113DA4
		public unsafe Color NetworktextColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_NetworktextColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122914, XrefRangeEnd = 122917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_NetworktextColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x00115BE8 File Offset: 0x00113DE8
		// (set) Token: 0x06003D8E RID: 15758 RVA: 0x00115C28 File Offset: 0x00113E28
		public unsafe TextFontPreset Networkfont
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_Networkfont_Public_get_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122917, XrefRangeEnd = 122920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_Networkfont_Public_set_Void_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x00115C6C File Offset: 0x00113E6C
		// (set) Token: 0x06003D90 RID: 15760 RVA: 0x00115CA4 File Offset: 0x00113EA4
		public unsafe string Networkplaceholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_Networkplaceholder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122920, XrefRangeEnd = 122923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_Networkplaceholder_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x00115CE8 File Offset: 0x00113EE8
		// (set) Token: 0x06003D92 RID: 15762 RVA: 0x00115D28 File Offset: 0x00113F28
		public unsafe Color NetworkplaceholderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_NetworkplaceholderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122923, XrefRangeEnd = 122926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_NetworkplaceholderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06003D93 RID: 15763 RVA: 0x00115D6C File Offset: 0x00113F6C
		// (set) Token: 0x06003D94 RID: 15764 RVA: 0x00115DA8 File Offset: 0x00113FA8
		public unsafe bool NetworkisReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_NetworkisReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122926, XrefRangeEnd = 122929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_NetworkisReadOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x00115DE8 File Offset: 0x00113FE8
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x00115E24 File Offset: 0x00114024
		public unsafe bool NetworkisMultiline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_get_NetworkisMultiline_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122929, XrefRangeEnd = 122932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_set_NetworkisMultiline_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00115E64 File Offset: 0x00114064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122932, XrefRangeEnd = 123030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UITextInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UITextInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00115EA0 File Offset: 0x001140A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123032, RefRangeEnd = 123033, XrefRangeStart = 123030, XrefRangeEnd = 123032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Focus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_Focus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00115ED4 File Offset: 0x001140D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123033, XrefRangeEnd = 123034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetText_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00115F28 File Offset: 0x00114128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123034, XrefRangeEnd = 123035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetTextJustify_Private_Void_TextJustify_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00115F7C File Offset: 0x0011417C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123035, XrefRangeEnd = 123036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetTextAlign_Private_Void_TextVerticalAlign_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00115FD0 File Offset: 0x001141D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123036, XrefRangeEnd = 123037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetFontSize_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x0011601C File Offset: 0x0011421C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123037, XrefRangeEnd = 123038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetMaxFontSize_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00116068 File Offset: 0x00114268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123038, XrefRangeEnd = 123039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetAutoSize_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x001160B4 File Offset: 0x001142B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123039, XrefRangeEnd = 123040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00116108 File Offset: 0x00114308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123040, XrefRangeEnd = 123041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetFont_Private_Void_TextFontPreset_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x0011615C File Offset: 0x0011435C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123041, XrefRangeEnd = 123042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetPlaceholder(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetPlaceholder_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x001161B0 File Offset: 0x001143B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123042, XrefRangeEnd = 123045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetPlaceholderColor(Color oldValue, Color newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetPlaceholderColor_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00116204 File Offset: 0x00114404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123045, XrefRangeEnd = 123046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetIsMultiline(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetIsMultiline_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00116250 File Offset: 0x00114450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123046, XrefRangeEnd = 123047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetIsReadOnly(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr_SyncSetIsReadOnly_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x0011629C File Offset: 0x0011449C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123047, XrefRangeEnd = 123079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITextInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x001162D8 File Offset: 0x001144D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123079, XrefRangeEnd = 123092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITextInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00116314 File Offset: 0x00114514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITextInput.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00116350 File Offset: 0x00114550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123092, XrefRangeEnd = 123094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITextInput.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x0011638C File Offset: 0x0011458C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123094, XrefRangeEnd = 123113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITextInput.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x001163DC File Offset: 0x001145DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123113, XrefRangeEnd = 123123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__67_0(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr__Awake_b__67_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x00116420 File Offset: 0x00114620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123123, XrefRangeEnd = 123133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__67_1(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInput.NativeMethodInfoPtr__Awake_b__67_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00116464 File Offset: 0x00114664
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITextInput.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x001164AC File Offset: 0x001146AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123133, XrefRangeEnd = 123159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITextInput.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00116508 File Offset: 0x00114708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123159, XrefRangeEnd = 123238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITextInput.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00017891 File Offset: 0x00015A91
		public UITextInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x00116564 File Offset: 0x00114764
		// (set) Token: 0x06003DB1 RID: 15793 RVA: 0x0001789A File Offset: 0x00015A9A
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x00116594 File Offset: 0x00114794
		// (set) Token: 0x06003DB3 RID: 15795 RVA: 0x000178B9 File Offset: 0x00015AB9
		public unsafe TMP_Text placeholderText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_placeholderText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_placeholderText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x001165C4 File Offset: 0x001147C4
		// (set) Token: 0x06003DB5 RID: 15797 RVA: 0x000178D8 File Offset: 0x00015AD8
		public unsafe LuaEvent Changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_Changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_Changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x001165F4 File Offset: 0x001147F4
		// (set) Token: 0x06003DB7 RID: 15799 RVA: 0x000178F7 File Offset: 0x00015AF7
		public unsafe LuaEvent Submitted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_Submitted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_Submitted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x00116624 File Offset: 0x00114824
		// (set) Token: 0x06003DB9 RID: 15801 RVA: 0x00017916 File Offset: 0x00015B16
		public unsafe TextJustify justify
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_justify);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextJustify>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_justify), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x00116654 File Offset: 0x00114854
		// (set) Token: 0x06003DBB RID: 15803 RVA: 0x00017935 File Offset: 0x00015B35
		public unsafe TextVerticalAlign verticalAlign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_verticalAlign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextVerticalAlign>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_verticalAlign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x00116684 File Offset: 0x00114884
		// (set) Token: 0x06003DBD RID: 15805 RVA: 0x00017954 File Offset: 0x00015B54
		public unsafe float fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_fontSize)) = value;
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x001166AC File Offset: 0x001148AC
		// (set) Token: 0x06003DBF RID: 15807 RVA: 0x0001796F File Offset: 0x00015B6F
		public unsafe float maxFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_maxFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_maxFontSize)) = value;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06003DC0 RID: 15808 RVA: 0x001166D4 File Offset: 0x001148D4
		// (set) Token: 0x06003DC1 RID: 15809 RVA: 0x0001798A File Offset: 0x00015B8A
		public unsafe bool autoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_autoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_autoSize)) = value;
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06003DC2 RID: 15810 RVA: 0x001166FC File Offset: 0x001148FC
		// (set) Token: 0x06003DC3 RID: 15811 RVA: 0x000179A5 File Offset: 0x00015BA5
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06003DC4 RID: 15812 RVA: 0x00116724 File Offset: 0x00114924
		// (set) Token: 0x06003DC5 RID: 15813 RVA: 0x000179C4 File Offset: 0x00015BC4
		public unsafe Color textColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_textColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_textColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06003DC6 RID: 15814 RVA: 0x00116754 File Offset: 0x00114954
		// (set) Token: 0x06003DC7 RID: 15815 RVA: 0x000179E3 File Offset: 0x00015BE3
		public unsafe TextFontPreset font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x00116784 File Offset: 0x00114984
		// (set) Token: 0x06003DC9 RID: 15817 RVA: 0x00017A02 File Offset: 0x00015C02
		public unsafe string placeholder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_placeholder);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_placeholder), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x001167AC File Offset: 0x001149AC
		// (set) Token: 0x06003DCB RID: 15819 RVA: 0x00017A21 File Offset: 0x00015C21
		public unsafe Color placeholderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_placeholderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_placeholderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x001167DC File Offset: 0x001149DC
		// (set) Token: 0x06003DCD RID: 15821 RVA: 0x00017A40 File Offset: 0x00015C40
		public unsafe bool isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_isReadOnly)) = value;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x00116804 File Offset: 0x00114A04
		// (set) Token: 0x06003DCF RID: 15823 RVA: 0x00017A5B File Offset: 0x00015C5B
		public unsafe bool isMultiline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_isMultiline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr_isMultiline)) = value;
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x0011682C File Offset: 0x00114A2C
		// (set) Token: 0x06003DD1 RID: 15825 RVA: 0x00017A76 File Offset: 0x00015C76
		public unsafe Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_justify);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextJustify, TextJustify>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_justify), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06003DD2 RID: 15826 RVA: 0x0011685C File Offset: 0x00114A5C
		// (set) Token: 0x06003DD3 RID: 15827 RVA: 0x00017A95 File Offset: 0x00015C95
		public unsafe Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_verticalAlign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextVerticalAlign, TextVerticalAlign>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_verticalAlign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x0011688C File Offset: 0x00114A8C
		// (set) Token: 0x06003DD5 RID: 15829 RVA: 0x00017AB4 File Offset: 0x00015CB4
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_fontSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_fontSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06003DD6 RID: 15830 RVA: 0x001168BC File Offset: 0x00114ABC
		// (set) Token: 0x06003DD7 RID: 15831 RVA: 0x00017AD3 File Offset: 0x00015CD3
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_maxFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxFontSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxFontSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06003DD8 RID: 15832 RVA: 0x001168EC File Offset: 0x00114AEC
		// (set) Token: 0x06003DD9 RID: 15833 RVA: 0x00017AF2 File Offset: 0x00015CF2
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_autoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x0011691C File Offset: 0x00114B1C
		// (set) Token: 0x06003DDB RID: 15835 RVA: 0x00017B11 File Offset: 0x00015D11
		public unsafe Action<string, string> _Mirror_SyncVarHookDelegate_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x0011694C File Offset: 0x00114B4C
		// (set) Token: 0x06003DDD RID: 15837 RVA: 0x00017B30 File Offset: 0x00015D30
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x0011697C File Offset: 0x00114B7C
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x00017B4F File Offset: 0x00015D4F
		public unsafe Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextFontPreset, TextFontPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x001169AC File Offset: 0x00114BAC
		// (set) Token: 0x06003DE1 RID: 15841 RVA: 0x00017B6E File Offset: 0x00015D6E
		public unsafe Action<string, string> _Mirror_SyncVarHookDelegate_placeholder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_placeholder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_placeholder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x001169DC File Offset: 0x00114BDC
		// (set) Token: 0x06003DE3 RID: 15843 RVA: 0x00017B8D File Offset: 0x00015D8D
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_placeholderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_placeholderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_placeholderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x00116A0C File Offset: 0x00114C0C
		// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x00017BAC File Offset: 0x00015DAC
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isReadOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isReadOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x00116A3C File Offset: 0x00114C3C
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x00017BCB File Offset: 0x00015DCB
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_isMultiline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isMultiline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInput.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isMultiline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FC9 RID: 12233
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x04002FCA RID: 12234
		private static readonly IntPtr NativeFieldInfoPtr_placeholderText;

		// Token: 0x04002FCB RID: 12235
		private static readonly IntPtr NativeFieldInfoPtr_Changed;

		// Token: 0x04002FCC RID: 12236
		private static readonly IntPtr NativeFieldInfoPtr_Submitted;

		// Token: 0x04002FCD RID: 12237
		private static readonly IntPtr NativeFieldInfoPtr_justify;

		// Token: 0x04002FCE RID: 12238
		private static readonly IntPtr NativeFieldInfoPtr_verticalAlign;

		// Token: 0x04002FCF RID: 12239
		private static readonly IntPtr NativeFieldInfoPtr_fontSize;

		// Token: 0x04002FD0 RID: 12240
		private static readonly IntPtr NativeFieldInfoPtr_maxFontSize;

		// Token: 0x04002FD1 RID: 12241
		private static readonly IntPtr NativeFieldInfoPtr_autoSize;

		// Token: 0x04002FD2 RID: 12242
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002FD3 RID: 12243
		private static readonly IntPtr NativeFieldInfoPtr_textColor;

		// Token: 0x04002FD4 RID: 12244
		private static readonly IntPtr NativeFieldInfoPtr_font;

		// Token: 0x04002FD5 RID: 12245
		private static readonly IntPtr NativeFieldInfoPtr_placeholder;

		// Token: 0x04002FD6 RID: 12246
		private static readonly IntPtr NativeFieldInfoPtr_placeholderColor;

		// Token: 0x04002FD7 RID: 12247
		private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

		// Token: 0x04002FD8 RID: 12248
		private static readonly IntPtr NativeFieldInfoPtr_isMultiline;

		// Token: 0x04002FD9 RID: 12249
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_justify;

		// Token: 0x04002FDA RID: 12250
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_verticalAlign;

		// Token: 0x04002FDB RID: 12251
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_fontSize;

		// Token: 0x04002FDC RID: 12252
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxFontSize;

		// Token: 0x04002FDD RID: 12253
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoSize;

		// Token: 0x04002FDE RID: 12254
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_text;

		// Token: 0x04002FDF RID: 12255
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textColor;

		// Token: 0x04002FE0 RID: 12256
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_font;

		// Token: 0x04002FE1 RID: 12257
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_placeholder;

		// Token: 0x04002FE2 RID: 12258
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_placeholderColor;

		// Token: 0x04002FE3 RID: 12259
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isReadOnly;

		// Token: 0x04002FE4 RID: 12260
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isMultiline;

		// Token: 0x04002FE5 RID: 12261
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x04002FE6 RID: 12262
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x04002FE7 RID: 12263
		private static readonly IntPtr NativeMethodInfoPtr_get_TextColor_Public_get_Color_0;

		// Token: 0x04002FE8 RID: 12264
		private static readonly IntPtr NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0;

		// Token: 0x04002FE9 RID: 12265
		private static readonly IntPtr NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0;

		// Token: 0x04002FEA RID: 12266
		private static readonly IntPtr NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0;

		// Token: 0x04002FEB RID: 12267
		private static readonly IntPtr NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0;

		// Token: 0x04002FEC RID: 12268
		private static readonly IntPtr NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0;

		// Token: 0x04002FED RID: 12269
		private static readonly IntPtr NativeMethodInfoPtr_get_FontSize_Public_get_Single_0;

		// Token: 0x04002FEE RID: 12270
		private static readonly IntPtr NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0;

		// Token: 0x04002FEF RID: 12271
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0;

		// Token: 0x04002FF0 RID: 12272
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0;

		// Token: 0x04002FF1 RID: 12273
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0;

		// Token: 0x04002FF2 RID: 12274
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0;

		// Token: 0x04002FF3 RID: 12275
		private static readonly IntPtr NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0;

		// Token: 0x04002FF4 RID: 12276
		private static readonly IntPtr NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0;

		// Token: 0x04002FF5 RID: 12277
		private static readonly IntPtr NativeMethodInfoPtr_get_Placeholder_Public_get_String_0;

		// Token: 0x04002FF6 RID: 12278
		private static readonly IntPtr NativeMethodInfoPtr_set_Placeholder_Public_set_Void_String_0;

		// Token: 0x04002FF7 RID: 12279
		private static readonly IntPtr NativeMethodInfoPtr_get_PlaceholderColor_Public_get_Color_0;

		// Token: 0x04002FF8 RID: 12280
		private static readonly IntPtr NativeMethodInfoPtr_set_PlaceholderColor_Public_set_Void_Color_0;

		// Token: 0x04002FF9 RID: 12281
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMultiline_Public_get_Boolean_0;

		// Token: 0x04002FFA RID: 12282
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMultiline_Public_set_Void_Boolean_0;

		// Token: 0x04002FFB RID: 12283
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x04002FFC RID: 12284
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReadOnly_Public_set_Void_Boolean_0;

		// Token: 0x04002FFD RID: 12285
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFocused_Public_get_Boolean_0;

		// Token: 0x04002FFE RID: 12286
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkjustify_Public_get_TextJustify_0;

		// Token: 0x04002FFF RID: 12287
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkjustify_Public_set_Void_TextJustify_0;

		// Token: 0x04003000 RID: 12288
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkverticalAlign_Public_get_TextVerticalAlign_0;

		// Token: 0x04003001 RID: 12289
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkverticalAlign_Public_set_Void_TextVerticalAlign_0;

		// Token: 0x04003002 RID: 12290
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfontSize_Public_get_Single_0;

		// Token: 0x04003003 RID: 12291
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfontSize_Public_set_Void_Single_0;

		// Token: 0x04003004 RID: 12292
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkmaxFontSize_Public_get_Single_0;

		// Token: 0x04003005 RID: 12293
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkmaxFontSize_Public_set_Void_Single_0;

		// Token: 0x04003006 RID: 12294
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkautoSize_Public_get_Boolean_0;

		// Token: 0x04003007 RID: 12295
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkautoSize_Public_set_Void_Boolean_0;

		// Token: 0x04003008 RID: 12296
		private static readonly IntPtr NativeMethodInfoPtr_get_Networktext_Public_get_String_0;

		// Token: 0x04003009 RID: 12297
		private static readonly IntPtr NativeMethodInfoPtr_set_Networktext_Public_set_Void_String_0;

		// Token: 0x0400300A RID: 12298
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworktextColor_Public_get_Color_0;

		// Token: 0x0400300B RID: 12299
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworktextColor_Public_set_Void_Color_0;

		// Token: 0x0400300C RID: 12300
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkfont_Public_get_TextFontPreset_0;

		// Token: 0x0400300D RID: 12301
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkfont_Public_set_Void_TextFontPreset_0;

		// Token: 0x0400300E RID: 12302
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkplaceholder_Public_get_String_0;

		// Token: 0x0400300F RID: 12303
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkplaceholder_Public_set_Void_String_0;

		// Token: 0x04003010 RID: 12304
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkplaceholderColor_Public_get_Color_0;

		// Token: 0x04003011 RID: 12305
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkplaceholderColor_Public_set_Void_Color_0;

		// Token: 0x04003012 RID: 12306
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkisReadOnly_Public_get_Boolean_0;

		// Token: 0x04003013 RID: 12307
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkisReadOnly_Public_set_Void_Boolean_0;

		// Token: 0x04003014 RID: 12308
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkisMultiline_Public_get_Boolean_0;

		// Token: 0x04003015 RID: 12309
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkisMultiline_Public_set_Void_Boolean_0;

		// Token: 0x04003016 RID: 12310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003017 RID: 12311
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Public_Void_0;

		// Token: 0x04003018 RID: 12312
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetText_Private_Void_String_String_0;

		// Token: 0x04003019 RID: 12313
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetTextJustify_Private_Void_TextJustify_TextJustify_0;

		// Token: 0x0400301A RID: 12314
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetTextAlign_Private_Void_TextVerticalAlign_TextVerticalAlign_0;

		// Token: 0x0400301B RID: 12315
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetFontSize_Private_Void_Single_Single_0;

		// Token: 0x0400301C RID: 12316
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetMaxFontSize_Private_Void_Single_Single_0;

		// Token: 0x0400301D RID: 12317
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetAutoSize_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400301E RID: 12318
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0;

		// Token: 0x0400301F RID: 12319
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetFont_Private_Void_TextFontPreset_TextFontPreset_0;

		// Token: 0x04003020 RID: 12320
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetPlaceholder_Private_Void_String_String_0;

		// Token: 0x04003021 RID: 12321
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetPlaceholderColor_Private_Void_Color_Color_0;

		// Token: 0x04003022 RID: 12322
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetIsMultiline_Private_Void_Boolean_Boolean_0;

		// Token: 0x04003023 RID: 12323
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetIsReadOnly_Private_Void_Boolean_Boolean_0;

		// Token: 0x04003024 RID: 12324
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003025 RID: 12325
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003026 RID: 12326
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04003027 RID: 12327
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04003028 RID: 12328
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04003029 RID: 12329
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__67_0_Private_Void_String_0;

		// Token: 0x0400302A RID: 12330
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__67_1_Private_Void_String_0;

		// Token: 0x0400302B RID: 12331
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x0400302C RID: 12332
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x0400302D RID: 12333
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
