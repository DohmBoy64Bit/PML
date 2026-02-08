using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	// Token: 0x02000251 RID: 593
	public class ChatWindow : MonoBehaviour
	{
		// Token: 0x06002DFE RID: 11774 RVA: 0x000D5A4C File Offset: 0x000D3C4C
		// Note: this type is marked as 'beforefieldinit'.
		static ChatWindow()
		{
			Il2CppClassPointerStore<ChatWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.UI", "ChatWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr);
			ChatWindow.NativeFieldInfoPtr_darken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "darken");
			ChatWindow.NativeFieldInfoPtr_scrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "scrollbar");
			ChatWindow.NativeFieldInfoPtr_focusImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "focusImage");
			ChatWindow.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "input");
			ChatWindow.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "scrollRect");
			ChatWindow.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "instance");
			ChatWindow.NativeFieldInfoPtr_chatMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "chatMessage");
			ChatWindow.NativeFieldInfoPtr__ChatContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "<ChatContainer>k__BackingField");
			ChatWindow.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "_state");
			ChatWindow.NativeFieldInfoPtr_PopContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "PopContainer");
			ChatWindow.NativeFieldInfoPtr_normalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "normalSize");
			ChatWindow.NativeFieldInfoPtr_focusedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "focusedSize");
			ChatWindow.NativeFieldInfoPtr_stateChangeCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "stateChangeCooldown");
			ChatWindow.NativeFieldInfoPtr_StateChangeRateLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "StateChangeRateLimit");
			ChatWindow.NativeFieldInfoPtr_commandList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "commandList");
			ChatWindow.NativeFieldInfoPtr_chatMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "chatMessages");
			ChatWindow.NativeFieldInfoPtr_chatStayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "chatStayTime");
			ChatWindow.NativeFieldInfoPtr_chatFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "chatFadeTime");
			ChatWindow.NativeMethodInfoPtr_get_ChatContainer_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670223);
			ChatWindow.NativeMethodInfoPtr_set_ChatContainer_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670224);
			ChatWindow.NativeMethodInfoPtr_get_Focused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670225);
			ChatWindow.NativeMethodInfoPtr_get_state_Public_get_ChatWindowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670226);
			ChatWindow.NativeMethodInfoPtr_set_state_Public_set_Void_ChatWindowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670227);
			ChatWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670236);
			ChatWindow.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670228);
			ChatWindow.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670229);
			ChatWindow.NativeMethodInfoPtr_inactiveFade_Private_IEnumerator_ChatMessageRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670230);
			ChatWindow.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670231);
			ChatWindow.NativeMethodInfoPtr_ToggleFocused_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670232);
			ChatWindow.NativeMethodInfoPtr_SetInactive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670233);
			ChatWindow.NativeMethodInfoPtr_scrollViewToBottom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670234);
			ChatWindow.NativeMethodInfoPtr_PushChat_Public_Void_String_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670235);
			ChatWindow.NativeMethodInfoPtr__set_state_b__22_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670237);
			ChatWindow.NativeMethodInfoPtr__set_state_b__22_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670238);
			ChatWindow.NativeMethodInfoPtr__set_state_b__22_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670239);
			ChatWindow.NativeMethodInfoPtr__set_state_b__22_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670240);
			ChatWindow.NativeMethodInfoPtr__set_state_b__22_4_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670241);
			ChatWindow.NativeMethodInfoPtr__set_state_b__22_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670242);
			ChatWindow.NativeMethodInfoPtr__set_state_b__22_6_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670243);
			ChatWindow.NativeMethodInfoPtr__Start_b__25_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, 100670244);
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x000D5D9C File Offset: 0x000D3F9C
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x000D5DDC File Offset: 0x000D3FDC
		public unsafe RectTransform ChatContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_get_ChatContainer_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_set_ChatContainer_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x000D5E20 File Offset: 0x000D4020
		public unsafe bool Focused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_get_Focused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x000D5E5C File Offset: 0x000D405C
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x000D5E9C File Offset: 0x000D409C
		public unsafe ChatWindowState state
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_get_state_Public_get_ChatWindowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChatWindowState>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 98682, RefRangeEnd = 98688, XrefRangeStart = 98613, XrefRangeEnd = 98682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_set_state_Public_set_Void_ChatWindowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x000D5EE0 File Offset: 0x000D40E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98688, XrefRangeEnd = 98696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatWindow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x000D5F1C File Offset: 0x000D411C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98696, XrefRangeEnd = 98700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x000D5F50 File Offset: 0x000D4150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98700, XrefRangeEnd = 98764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000D5F84 File Offset: 0x000D4184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98764, XrefRangeEnd = 98769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator inactiveFade(ChatMessageRef t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_inactiveFade_Private_IEnumerator_ChatMessageRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x000D5FD4 File Offset: 0x000D41D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98769, XrefRangeEnd = 98772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x000D6008 File Offset: 0x000D4208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98772, XrefRangeEnd = 98775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleFocused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_ToggleFocused_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000D603C File Offset: 0x000D423C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98778, RefRangeEnd = 98779, XrefRangeStart = 98775, XrefRangeEnd = 98778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInactive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_SetInactive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000D6070 File Offset: 0x000D4270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98779, XrefRangeEnd = 98782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void scrollViewToBottom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_scrollViewToBottom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x000D60A4 File Offset: 0x000D42A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98865, RefRangeEnd = 98866, XrefRangeStart = 98782, XrefRangeEnd = 98865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushChat(string username, string message, Color usernameColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(usernameColor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr_PushChat_Public_Void_String_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000D610C File Offset: 0x000D430C
		[CallerCount(0)]
		public unsafe void _set_state_b__22_0(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr__set_state_b__22_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000D614C File Offset: 0x000D434C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _set_state_b__22_1(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr__set_state_b__22_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x000D618C File Offset: 0x000D438C
		[CallerCount(0)]
		public unsafe void _set_state_b__22_2(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr__set_state_b__22_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x000D61CC File Offset: 0x000D43CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _set_state_b__22_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr__set_state_b__22_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x000D6200 File Offset: 0x000D4400
		[CallerCount(0)]
		public unsafe void _set_state_b__22_4(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr__set_state_b__22_4_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x000D6240 File Offset: 0x000D4440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98866, XrefRangeEnd = 98868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _set_state_b__22_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr__set_state_b__22_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x000D6274 File Offset: 0x000D4474
		[CallerCount(0)]
		public unsafe void _set_state_b__22_6(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr__set_state_b__22_6_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x000D62B4 File Offset: 0x000D44B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98868, XrefRangeEnd = 98888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__25_0(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.NativeMethodInfoPtr__Start_b__25_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x0001256D File Offset: 0x0001076D
		public ChatWindow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x000D62F8 File Offset: 0x000D44F8
		// (set) Token: 0x06002E17 RID: 11799 RVA: 0x00012576 File Offset: 0x00010776
		public unsafe Image darken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_darken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_darken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x000D6328 File Offset: 0x000D4528
		// (set) Token: 0x06002E19 RID: 11801 RVA: 0x00012595 File Offset: 0x00010795
		public unsafe Scrollbar scrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_scrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_scrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000D6358 File Offset: 0x000D4558
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x000125B4 File Offset: 0x000107B4
		public unsafe Image focusImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_focusImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_focusImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000D6388 File Offset: 0x000D4588
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x000125D3 File Offset: 0x000107D3
		public unsafe TMP_InputField input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x000D63B8 File Offset: 0x000D45B8
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x000125F2 File Offset: 0x000107F2
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x000D63E8 File Offset: 0x000D45E8
		// (set) Token: 0x06002E21 RID: 11809 RVA: 0x00012611 File Offset: 0x00010811
		public unsafe static ChatWindow instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChatWindow.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatWindow>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChatWindow.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x000D6410 File Offset: 0x000D4610
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x00012623 File Offset: 0x00010823
		public unsafe RectTransform chatMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_chatMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_chatMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x000D6440 File Offset: 0x000D4640
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x00012642 File Offset: 0x00010842
		public unsafe RectTransform _ChatContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr__ChatContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr__ChatContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x000D6470 File Offset: 0x000D4670
		// (set) Token: 0x06002E27 RID: 11815 RVA: 0x00012661 File Offset: 0x00010861
		public unsafe ChatWindowState _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatWindowState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x000D64A0 File Offset: 0x000D46A0
		// (set) Token: 0x06002E29 RID: 11817 RVA: 0x00012680 File Offset: 0x00010880
		public unsafe RectTransform PopContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_PopContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_PopContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x000D64D0 File Offset: 0x000D46D0
		// (set) Token: 0x06002E2B RID: 11819 RVA: 0x0001269F File Offset: 0x0001089F
		public unsafe Vector2 normalSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_normalSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_normalSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x000D6500 File Offset: 0x000D4700
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x000126BE File Offset: 0x000108BE
		public unsafe Vector2 focusedSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_focusedSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_focusedSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x000D6530 File Offset: 0x000D4730
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x000126DD File Offset: 0x000108DD
		public unsafe float stateChangeCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_stateChangeCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_stateChangeCooldown)) = value;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x000D6558 File Offset: 0x000D4758
		// (set) Token: 0x06002E31 RID: 11825 RVA: 0x000126F8 File Offset: 0x000108F8
		public unsafe float StateChangeRateLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_StateChangeRateLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_StateChangeRateLimit)) = value;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x000D6580 File Offset: 0x000D4780
		// (set) Token: 0x06002E33 RID: 11827 RVA: 0x00012713 File Offset: 0x00010913
		public unsafe UICommandList commandList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_commandList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UICommandList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_commandList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x000D65B0 File Offset: 0x000D47B0
		// (set) Token: 0x06002E35 RID: 11829 RVA: 0x00012732 File Offset: 0x00010932
		public unsafe List<ChatMessageRef> chatMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_chatMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChatMessageRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.NativeFieldInfoPtr_chatMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x000D65E0 File Offset: 0x000D47E0
		// (set) Token: 0x06002E37 RID: 11831 RVA: 0x00012751 File Offset: 0x00010951
		public unsafe static float chatStayTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ChatWindow.NativeFieldInfoPtr_chatStayTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChatWindow.NativeFieldInfoPtr_chatStayTime, (void*)(&value));
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x000D65FC File Offset: 0x000D47FC
		// (set) Token: 0x06002E39 RID: 11833 RVA: 0x0001275F File Offset: 0x0001095F
		public unsafe static float chatFadeTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ChatWindow.NativeFieldInfoPtr_chatFadeTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChatWindow.NativeFieldInfoPtr_chatFadeTime, (void*)(&value));
			}
		}

		// Token: 0x04002349 RID: 9033
		private static readonly IntPtr NativeFieldInfoPtr_darken;

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeFieldInfoPtr_scrollbar;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeFieldInfoPtr_focusImage;

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeFieldInfoPtr_chatMessage;

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeFieldInfoPtr__ChatContainer_k__BackingField;

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeFieldInfoPtr_PopContainer;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeFieldInfoPtr_normalSize;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeFieldInfoPtr_focusedSize;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeFieldInfoPtr_stateChangeCooldown;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeFieldInfoPtr_StateChangeRateLimit;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeFieldInfoPtr_commandList;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeFieldInfoPtr_chatMessages;

		// Token: 0x04002359 RID: 9049
		private static readonly IntPtr NativeFieldInfoPtr_chatStayTime;

		// Token: 0x0400235A RID: 9050
		private static readonly IntPtr NativeFieldInfoPtr_chatFadeTime;

		// Token: 0x0400235B RID: 9051
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatContainer_Public_get_RectTransform_0;

		// Token: 0x0400235C RID: 9052
		private static readonly IntPtr NativeMethodInfoPtr_set_ChatContainer_Private_set_Void_RectTransform_0;

		// Token: 0x0400235D RID: 9053
		private static readonly IntPtr NativeMethodInfoPtr_get_Focused_Public_get_Boolean_0;

		// Token: 0x0400235E RID: 9054
		private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_get_ChatWindowState_0;

		// Token: 0x0400235F RID: 9055
		private static readonly IntPtr NativeMethodInfoPtr_set_state_Public_set_Void_ChatWindowState_0;

		// Token: 0x04002360 RID: 9056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002361 RID: 9057
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002362 RID: 9058
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002363 RID: 9059
		private static readonly IntPtr NativeMethodInfoPtr_inactiveFade_Private_IEnumerator_ChatMessageRef_0;

		// Token: 0x04002364 RID: 9060
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002365 RID: 9061
		private static readonly IntPtr NativeMethodInfoPtr_ToggleFocused_Public_Void_0;

		// Token: 0x04002366 RID: 9062
		private static readonly IntPtr NativeMethodInfoPtr_SetInactive_Public_Void_0;

		// Token: 0x04002367 RID: 9063
		private static readonly IntPtr NativeMethodInfoPtr_scrollViewToBottom_Private_Void_0;

		// Token: 0x04002368 RID: 9064
		private static readonly IntPtr NativeMethodInfoPtr_PushChat_Public_Void_String_String_Color_0;

		// Token: 0x04002369 RID: 9065
		private static readonly IntPtr NativeMethodInfoPtr__set_state_b__22_0_Private_Void_Single_0;

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeMethodInfoPtr__set_state_b__22_1_Private_Void_Single_0;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeMethodInfoPtr__set_state_b__22_2_Private_Void_Single_0;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeMethodInfoPtr__set_state_b__22_3_Private_Void_0;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeMethodInfoPtr__set_state_b__22_4_Private_Void_Single_0;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeMethodInfoPtr__set_state_b__22_5_Private_Void_0;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeMethodInfoPtr__set_state_b__22_6_Private_Void_Single_0;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__25_0_Private_Void_String_0;

		// Token: 0x020003E2 RID: 994
		[ObfuscatedName("Polytoria.UI.ChatWindow+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004D3A RID: 19770 RVA: 0x0014FB90 File Offset: 0x0014DD90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ChatWindow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatWindow.__c>.NativeClassPtr);
				ChatWindow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow.__c>.NativeClassPtr, "<>9");
				ChatWindow.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow.__c>.NativeClassPtr, "<>9__28_1");
				ChatWindow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow.__c>.NativeClassPtr, 100670246);
				ChatWindow.__c.NativeMethodInfoPtr__inactiveFade_b__28_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow.__c>.NativeClassPtr, 100670247);
			}

			// Token: 0x06004D3B RID: 19771 RVA: 0x0014FC0C File Offset: 0x0014DE0C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatWindow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D3C RID: 19772 RVA: 0x0014FC48 File Offset: 0x0014DE48
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _inactiveFade_b__28_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.__c.NativeMethodInfoPtr__inactiveFade_b__28_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D3D RID: 19773 RVA: 0x0001D236 File Offset: 0x0001B436
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A02 RID: 6658
			// (get) Token: 0x06004D3E RID: 19774 RVA: 0x0014FC7C File Offset: 0x0014DE7C
			// (set) Token: 0x06004D3F RID: 19775 RVA: 0x0001D23F File Offset: 0x0001B43F
			public unsafe static ChatWindow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChatWindow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatWindow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChatWindow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A03 RID: 6659
			// (get) Token: 0x06004D40 RID: 19776 RVA: 0x0014FCA4 File Offset: 0x0014DEA4
			// (set) Token: 0x06004D41 RID: 19777 RVA: 0x0001D251 File Offset: 0x0001B451
			public unsafe static Action __9__28_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChatWindow.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChatWindow.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BFA RID: 15354
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BFB RID: 15355
			private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

			// Token: 0x04003BFC RID: 15356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BFD RID: 15357
			private static readonly IntPtr NativeMethodInfoPtr__inactiveFade_b__28_1_Internal_Void_0;
		}

		// Token: 0x020003E3 RID: 995
		[ObfuscatedName("Polytoria.UI.ChatWindow+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D42 RID: 19778 RVA: 0x0014FCCC File Offset: 0x0014DECC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<ChatWindow.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatWindow.__c__DisplayClass28_0>.NativeClassPtr);
				ChatWindow.__c__DisplayClass28_0.NativeFieldInfoPtr_txt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow.__c__DisplayClass28_0>.NativeClassPtr, "txt");
				ChatWindow.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow.__c__DisplayClass28_0>.NativeClassPtr, 100670248);
				ChatWindow.__c__DisplayClass28_0.NativeMethodInfoPtr__inactiveFade_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow.__c__DisplayClass28_0>.NativeClassPtr, 100670249);
			}

			// Token: 0x06004D43 RID: 19779 RVA: 0x0014FD34 File Offset: 0x0014DF34
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatWindow.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D44 RID: 19780 RVA: 0x0014FD70 File Offset: 0x0014DF70
			[CallerCount(0)]
			public unsafe void _inactiveFade_b__0(float val)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref val;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow.__c__DisplayClass28_0.NativeMethodInfoPtr__inactiveFade_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D45 RID: 19781 RVA: 0x0001D263 File Offset: 0x0001B463
			public __c__DisplayClass28_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A04 RID: 6660
			// (get) Token: 0x06004D46 RID: 19782 RVA: 0x0014FDB0 File Offset: 0x0014DFB0
			// (set) Token: 0x06004D47 RID: 19783 RVA: 0x0001D26C File Offset: 0x0001B46C
			public unsafe TMP_Text txt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.__c__DisplayClass28_0.NativeFieldInfoPtr_txt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow.__c__DisplayClass28_0.NativeFieldInfoPtr_txt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BFE RID: 15358
			private static readonly IntPtr NativeFieldInfoPtr_txt;

			// Token: 0x04003BFF RID: 15359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C00 RID: 15360
			private static readonly IntPtr NativeMethodInfoPtr__inactiveFade_b__0_Internal_Void_Single_0;
		}

		// Token: 0x020003E4 RID: 996
		[ObfuscatedName("Polytoria.UI.ChatWindow+<inactiveFade>d__28")]
		public sealed class _inactiveFade_d__28 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D48 RID: 19784 RVA: 0x0014FDE0 File Offset: 0x0014DFE0
			// Note: this type is marked as 'beforefieldinit'.
			static _inactiveFade_d__28()
			{
				Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatWindow>.NativeClassPtr, "<inactiveFade>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr);
				ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, "<>1__state");
				ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, "<>2__current");
				ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, "t");
				ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, "<>8__1");
				ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, 100670253);
				ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, 100670255);
				ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, 100670250);
				ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, 100670251);
				ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, 100670252);
				ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr, 100670254);
			}

			// Token: 0x17001A09 RID: 6665
			// (get) Token: 0x06004D49 RID: 19785 RVA: 0x0014FED4 File Offset: 0x0014E0D4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A0A RID: 6666
			// (get) Token: 0x06004D4A RID: 19786 RVA: 0x0014FF14 File Offset: 0x0014E114
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D4B RID: 19787 RVA: 0x0014FF54 File Offset: 0x0014E154
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _inactiveFade_d__28(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatWindow._inactiveFade_d__28>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D4C RID: 19788 RVA: 0x0014FF9C File Offset: 0x0014E19C
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D4D RID: 19789 RVA: 0x0014FFD0 File Offset: 0x0014E1D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98591, XrefRangeEnd = 98608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004D4E RID: 19790 RVA: 0x0015000C File Offset: 0x0014E20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98608, XrefRangeEnd = 98613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatWindow._inactiveFade_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D4F RID: 19791 RVA: 0x0001D28B File Offset: 0x0001B48B
			public _inactiveFade_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A05 RID: 6661
			// (get) Token: 0x06004D50 RID: 19792 RVA: 0x00150040 File Offset: 0x0014E240
			// (set) Token: 0x06004D51 RID: 19793 RVA: 0x0001D294 File Offset: 0x0001B494
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A06 RID: 6662
			// (get) Token: 0x06004D52 RID: 19794 RVA: 0x00150068 File Offset: 0x0014E268
			// (set) Token: 0x06004D53 RID: 19795 RVA: 0x0001D2AF File Offset: 0x0001B4AF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A07 RID: 6663
			// (get) Token: 0x06004D54 RID: 19796 RVA: 0x00150098 File Offset: 0x0014E298
			// (set) Token: 0x06004D55 RID: 19797 RVA: 0x0001D2CE File Offset: 0x0001B4CE
			public unsafe ChatMessageRef t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatMessageRef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A08 RID: 6664
			// (get) Token: 0x06004D56 RID: 19798 RVA: 0x001500C8 File Offset: 0x0014E2C8
			// (set) Token: 0x06004D57 RID: 19799 RVA: 0x0001D2ED File Offset: 0x0001B4ED
			public unsafe ChatWindow.__c__DisplayClass28_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatWindow.__c__DisplayClass28_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatWindow._inactiveFade_d__28.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C01 RID: 15361
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C02 RID: 15362
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C03 RID: 15363
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04003C04 RID: 15364
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003C05 RID: 15365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C06 RID: 15366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C07 RID: 15367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C08 RID: 15368
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C09 RID: 15369
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C0A RID: 15370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
