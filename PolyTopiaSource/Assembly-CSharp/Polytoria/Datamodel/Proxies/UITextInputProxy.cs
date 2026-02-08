using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000304 RID: 772
	public class UITextInputProxy : UIViewProxy
	{
		// Token: 0x06004317 RID: 17175 RVA: 0x0012D550 File Offset: 0x0012B750
		// Note: this type is marked as 'beforefieldinit'.
		static UITextInputProxy()
		{
			Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "UITextInputProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr);
			UITextInputProxy.NativeFieldInfoPtr_uiTextInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, "uiTextInput");
			UITextInputProxy.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673916);
			UITextInputProxy.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673917);
			UITextInputProxy.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673918);
			UITextInputProxy.NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673919);
			UITextInputProxy.NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673920);
			UITextInputProxy.NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673921);
			UITextInputProxy.NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673922);
			UITextInputProxy.NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673923);
			UITextInputProxy.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673924);
			UITextInputProxy.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673925);
			UITextInputProxy.NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673926);
			UITextInputProxy.NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673927);
			UITextInputProxy.NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673928);
			UITextInputProxy.NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673929);
			UITextInputProxy.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673930);
			UITextInputProxy.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673931);
			UITextInputProxy.NativeMethodInfoPtr_get_Placeholder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673932);
			UITextInputProxy.NativeMethodInfoPtr_set_Placeholder_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673933);
			UITextInputProxy.NativeMethodInfoPtr_get_PlaceholderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673934);
			UITextInputProxy.NativeMethodInfoPtr_set_PlaceholderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673935);
			UITextInputProxy.NativeMethodInfoPtr_get_IsMultiline_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673936);
			UITextInputProxy.NativeMethodInfoPtr_set_IsMultiline_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673937);
			UITextInputProxy.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673938);
			UITextInputProxy.NativeMethodInfoPtr_set_IsReadOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673939);
			UITextInputProxy.NativeMethodInfoPtr_get_IsFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673940);
			UITextInputProxy.NativeMethodInfoPtr_get_Changed_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673941);
			UITextInputProxy.NativeMethodInfoPtr_get_Submitted_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673942);
			UITextInputProxy.NativeMethodInfoPtr__ctor_Public_Void_UITextInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673915);
			UITextInputProxy.NativeMethodInfoPtr_Focus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr, 100673943);
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x0012D7D8 File Offset: 0x0012B9D8
		// (set) Token: 0x06004319 RID: 17177 RVA: 0x0012D810 File Offset: 0x0012BA10
		public unsafe string Text
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129147, XrefRangeEnd = 129149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129149, XrefRangeEnd = 129151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x0012D854 File Offset: 0x0012BA54
		// (set) Token: 0x0600431B RID: 17179 RVA: 0x0012D894 File Offset: 0x0012BA94
		public unsafe Color TextColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129151, XrefRangeEnd = 129152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x0012D8D8 File Offset: 0x0012BAD8
		// (set) Token: 0x0600431D RID: 17181 RVA: 0x0012D918 File Offset: 0x0012BB18
		public unsafe TextJustify JustifyText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextJustify>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129152, XrefRangeEnd = 129154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x0012D95C File Offset: 0x0012BB5C
		// (set) Token: 0x0600431F RID: 17183 RVA: 0x0012D99C File Offset: 0x0012BB9C
		public unsafe TextVerticalAlign VerticalAlign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVerticalAlign>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129154, XrefRangeEnd = 129156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x0012D9E0 File Offset: 0x0012BBE0
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x0012DA1C File Offset: 0x0012BC1C
		public unsafe float FontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_FontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129156, XrefRangeEnd = 129158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x0012DA5C File Offset: 0x0012BC5C
		// (set) Token: 0x06004323 RID: 17187 RVA: 0x0012DA98 File Offset: 0x0012BC98
		public unsafe float MaxFontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129158, XrefRangeEnd = 129160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x0012DAD8 File Offset: 0x0012BCD8
		// (set) Token: 0x06004325 RID: 17189 RVA: 0x0012DB14 File Offset: 0x0012BD14
		public unsafe bool AutoSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129160, XrefRangeEnd = 129162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x0012DB54 File Offset: 0x0012BD54
		// (set) Token: 0x06004327 RID: 17191 RVA: 0x0012DB94 File Offset: 0x0012BD94
		public unsafe TextFontPreset Font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129162, XrefRangeEnd = 129164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06004328 RID: 17192 RVA: 0x0012DBD8 File Offset: 0x0012BDD8
		// (set) Token: 0x06004329 RID: 17193 RVA: 0x0012DC10 File Offset: 0x0012BE10
		public unsafe string Placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_Placeholder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129164, XrefRangeEnd = 129166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_Placeholder_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x0012DC54 File Offset: 0x0012BE54
		// (set) Token: 0x0600432B RID: 17195 RVA: 0x0012DC94 File Offset: 0x0012BE94
		public unsafe Color PlaceholderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_PlaceholderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129166, XrefRangeEnd = 129167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_PlaceholderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x0012DCD8 File Offset: 0x0012BED8
		// (set) Token: 0x0600432D RID: 17197 RVA: 0x0012DD14 File Offset: 0x0012BF14
		public unsafe bool IsMultiline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_IsMultiline_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129167, XrefRangeEnd = 129169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_IsMultiline_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x0600432E RID: 17198 RVA: 0x0012DD54 File Offset: 0x0012BF54
		// (set) Token: 0x0600432F RID: 17199 RVA: 0x0012DD90 File Offset: 0x0012BF90
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129169, XrefRangeEnd = 129171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_set_IsReadOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06004330 RID: 17200 RVA: 0x0012DDD0 File Offset: 0x0012BFD0
		public unsafe bool IsFocused
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129171, XrefRangeEnd = 129173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_IsFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x0012DE0C File Offset: 0x0012C00C
		public unsafe LuaEvent Changed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_Changed_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06004332 RID: 17202 RVA: 0x0012DE4C File Offset: 0x0012C04C
		public unsafe LuaEvent Submitted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_get_Submitted_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x0012DE8C File Offset: 0x0012C08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UITextInputProxy(UITextInput target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UITextInputProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr__ctor_Public_Void_UITextInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x0012DED8 File Offset: 0x0012C0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129173, XrefRangeEnd = 129175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Focus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITextInputProxy.NativeMethodInfoPtr_Focus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x00018CE1 File Offset: 0x00016EE1
		public UITextInputProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06004336 RID: 17206 RVA: 0x0012DF0C File Offset: 0x0012C10C
		// (set) Token: 0x06004337 RID: 17207 RVA: 0x00018CEA File Offset: 0x00016EEA
		public unsafe UITextInput uiTextInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInputProxy.NativeFieldInfoPtr_uiTextInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITextInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITextInputProxy.NativeFieldInfoPtr_uiTextInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400344A RID: 13386
		private static readonly IntPtr NativeFieldInfoPtr_uiTextInput;

		// Token: 0x0400344B RID: 13387
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x0400344C RID: 13388
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x0400344D RID: 13389
		private static readonly IntPtr NativeMethodInfoPtr_get_TextColor_Public_get_Color_0;

		// Token: 0x0400344E RID: 13390
		private static readonly IntPtr NativeMethodInfoPtr_set_TextColor_Public_set_Void_Color_0;

		// Token: 0x0400344F RID: 13391
		private static readonly IntPtr NativeMethodInfoPtr_get_JustifyText_Public_get_TextJustify_0;

		// Token: 0x04003450 RID: 13392
		private static readonly IntPtr NativeMethodInfoPtr_set_JustifyText_Public_set_Void_TextJustify_0;

		// Token: 0x04003451 RID: 13393
		private static readonly IntPtr NativeMethodInfoPtr_get_VerticalAlign_Public_get_TextVerticalAlign_0;

		// Token: 0x04003452 RID: 13394
		private static readonly IntPtr NativeMethodInfoPtr_set_VerticalAlign_Public_set_Void_TextVerticalAlign_0;

		// Token: 0x04003453 RID: 13395
		private static readonly IntPtr NativeMethodInfoPtr_get_FontSize_Public_get_Single_0;

		// Token: 0x04003454 RID: 13396
		private static readonly IntPtr NativeMethodInfoPtr_set_FontSize_Public_set_Void_Single_0;

		// Token: 0x04003455 RID: 13397
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxFontSize_Public_get_Single_0;

		// Token: 0x04003456 RID: 13398
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxFontSize_Public_set_Void_Single_0;

		// Token: 0x04003457 RID: 13399
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoSize_Public_get_Boolean_0;

		// Token: 0x04003458 RID: 13400
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoSize_Public_set_Void_Boolean_0;

		// Token: 0x04003459 RID: 13401
		private static readonly IntPtr NativeMethodInfoPtr_get_Font_Public_get_TextFontPreset_0;

		// Token: 0x0400345A RID: 13402
		private static readonly IntPtr NativeMethodInfoPtr_set_Font_Public_set_Void_TextFontPreset_0;

		// Token: 0x0400345B RID: 13403
		private static readonly IntPtr NativeMethodInfoPtr_get_Placeholder_Public_get_String_0;

		// Token: 0x0400345C RID: 13404
		private static readonly IntPtr NativeMethodInfoPtr_set_Placeholder_Public_set_Void_String_0;

		// Token: 0x0400345D RID: 13405
		private static readonly IntPtr NativeMethodInfoPtr_get_PlaceholderColor_Public_get_Color_0;

		// Token: 0x0400345E RID: 13406
		private static readonly IntPtr NativeMethodInfoPtr_set_PlaceholderColor_Public_set_Void_Color_0;

		// Token: 0x0400345F RID: 13407
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMultiline_Public_get_Boolean_0;

		// Token: 0x04003460 RID: 13408
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMultiline_Public_set_Void_Boolean_0;

		// Token: 0x04003461 RID: 13409
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x04003462 RID: 13410
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReadOnly_Public_set_Void_Boolean_0;

		// Token: 0x04003463 RID: 13411
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFocused_Public_get_Boolean_0;

		// Token: 0x04003464 RID: 13412
		private static readonly IntPtr NativeMethodInfoPtr_get_Changed_Public_get_LuaEvent_0;

		// Token: 0x04003465 RID: 13413
		private static readonly IntPtr NativeMethodInfoPtr_get_Submitted_Public_get_LuaEvent_0;

		// Token: 0x04003466 RID: 13414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UITextInput_0;

		// Token: 0x04003467 RID: 13415
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Public_Void_0;
	}
}
