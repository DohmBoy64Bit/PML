using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000161 RID: 353
	public class OverlayManager : Object
	{
		// Token: 0x060017F3 RID: 6131 RVA: 0x000787BC File Offset: 0x000769BC
		// Note: this type is marked as 'beforefieldinit'.
		static OverlayManager()
		{
			Il2CppClassPointerStore<OverlayManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "OverlayManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr);
			OverlayManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "MethodsPtr");
			OverlayManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "MethodsStructure");
			OverlayManager.NativeFieldInfoPtr_OnToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "OnToggle");
			OverlayManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668074);
			OverlayManager.NativeMethodInfoPtr_add_OnToggle_Public_add_Void_ToggleHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668075);
			OverlayManager.NativeMethodInfoPtr_remove_OnToggle_Public_rem_Void_ToggleHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668076);
			OverlayManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668077);
			OverlayManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668078);
			OverlayManager.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668079);
			OverlayManager.NativeMethodInfoPtr_IsLocked_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668080);
			OverlayManager.NativeMethodInfoPtr_SetLockedCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668081);
			OverlayManager.NativeMethodInfoPtr_SetLocked_Public_Void_Boolean_SetLockedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668082);
			OverlayManager.NativeMethodInfoPtr_OpenActivityInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668083);
			OverlayManager.NativeMethodInfoPtr_OpenActivityInvite_Public_Void_ActivityActionType_OpenActivityInviteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668084);
			OverlayManager.NativeMethodInfoPtr_OpenGuildInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668085);
			OverlayManager.NativeMethodInfoPtr_OpenGuildInvite_Public_Void_String_OpenGuildInviteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668086);
			OverlayManager.NativeMethodInfoPtr_OpenVoiceSettingsCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668087);
			OverlayManager.NativeMethodInfoPtr_OpenVoiceSettings_Public_Void_OpenVoiceSettingsHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668088);
			OverlayManager.NativeMethodInfoPtr_InitDrawingDxgi_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668089);
			OverlayManager.NativeMethodInfoPtr_OnPresent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668090);
			OverlayManager.NativeMethodInfoPtr_ForwardMessage_Public_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668091);
			OverlayManager.NativeMethodInfoPtr_KeyEvent_Public_Void_Boolean_String_KeyVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668092);
			OverlayManager.NativeMethodInfoPtr_CharEvent_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668093);
			OverlayManager.NativeMethodInfoPtr_MouseButtonEvent_Public_Void_Byte_Int32_MouseButton_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668094);
			OverlayManager.NativeMethodInfoPtr_MouseMotionEvent_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668095);
			OverlayManager.NativeMethodInfoPtr_ImeCommitText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668096);
			OverlayManager.NativeMethodInfoPtr_ImeSetComposition_Public_Void_String_ImeUnderline_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668097);
			OverlayManager.NativeMethodInfoPtr_ImeCancelComposition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668098);
			OverlayManager.NativeMethodInfoPtr_SetImeCompositionRangeCallbackCallbackImpl_Private_Static_Void_IntPtr_Int32_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668099);
			OverlayManager.NativeMethodInfoPtr_SetImeCompositionRangeCallback_Public_Void_SetImeCompositionRangeCallbackHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668100);
			OverlayManager.NativeMethodInfoPtr_SetImeSelectionBoundsCallbackCallbackImpl_Private_Static_Void_IntPtr_Rect_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668101);
			OverlayManager.NativeMethodInfoPtr_SetImeSelectionBoundsCallback_Public_Void_SetImeSelectionBoundsCallbackHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668102);
			OverlayManager.NativeMethodInfoPtr_IsPointInsideClickZone_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668103);
			OverlayManager.NativeMethodInfoPtr_OnToggleImpl_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, 100668104);
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00078A94 File Offset: 0x00076C94
		public unsafe OverlayManager.FFIMethods Methods
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 54595, RefRangeEnd = 54614, XrefRangeStart = 54582, XrefRangeEnd = 54595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new OverlayManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00078ACC File Offset: 0x00076CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54614, XrefRangeEnd = 54618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnToggle(OverlayManager.ToggleHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_add_OnToggle_Public_add_Void_ToggleHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00078B10 File Offset: 0x00076D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54618, XrefRangeEnd = 54622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnToggle(OverlayManager.ToggleHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_remove_OnToggle_Public_rem_Void_ToggleHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00078B54 File Offset: 0x00076D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54638, RefRangeEnd = 54639, XrefRangeStart = 54622, XrefRangeEnd = 54638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverlayManager(IntPtr ptr, IntPtr eventsPtr, ref OverlayManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00078BBC File Offset: 0x00076DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54639, XrefRangeEnd = 54656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref OverlayManager.FFIEvents events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00078C10 File Offset: 0x00076E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54656, XrefRangeEnd = 54657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00078C4C File Offset: 0x00076E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54657, XrefRangeEnd = 54658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_IsLocked_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00078C88 File Offset: 0x00076E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54658, XrefRangeEnd = 54665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLockedCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_SetLockedCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00078CCC File Offset: 0x00076ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54665, XrefRangeEnd = 54676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocked(bool locked, OverlayManager.SetLockedHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locked;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_SetLocked_Public_Void_Boolean_SetLockedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00078D1C File Offset: 0x00076F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54676, XrefRangeEnd = 54683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_OpenActivityInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00078D60 File Offset: 0x00076F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54683, XrefRangeEnd = 54694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenActivityInvite(ActivityActionType type, OverlayManager.OpenActivityInviteHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_OpenActivityInvite_Public_Void_ActivityActionType_OpenActivityInviteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00078DB4 File Offset: 0x00076FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54694, XrefRangeEnd = 54701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_OpenGuildInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00078DF8 File Offset: 0x00076FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54701, XrefRangeEnd = 54712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenGuildInvite(string code, OverlayManager.OpenGuildInviteHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_OpenGuildInvite_Public_Void_String_OpenGuildInviteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00078E4C File Offset: 0x0007704C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54712, XrefRangeEnd = 54719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_OpenVoiceSettingsCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00078E90 File Offset: 0x00077090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54719, XrefRangeEnd = 54730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenVoiceSettings(OverlayManager.OpenVoiceSettingsHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_OpenVoiceSettings_Public_Void_OpenVoiceSettingsHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00078ED4 File Offset: 0x000770D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54730, XrefRangeEnd = 54731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDrawingDxgi(IntPtr swapchain, bool useMessageForwarding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref swapchain;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMessageForwarding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_InitDrawingDxgi_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00078F20 File Offset: 0x00077120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54731, XrefRangeEnd = 54733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPresent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_OnPresent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00078F54 File Offset: 0x00077154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54733, XrefRangeEnd = 54735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForwardMessage(IntPtr message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_ForwardMessage_Public_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00078F94 File Offset: 0x00077194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54735, XrefRangeEnd = 54736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeyEvent(bool down, string keyCode, KeyVariant variant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref down;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyCode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_KeyEvent_Public_Void_Boolean_String_KeyVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00078FF8 File Offset: 0x000771F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54736, XrefRangeEnd = 54738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharEvent(string character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(character);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_CharEvent_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0007903C File Offset: 0x0007723C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54738, XrefRangeEnd = 54739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseButtonEvent(byte down, int clickCount, MouseButton which, int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref down;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clickCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(which);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_MouseButtonEvent_Public_Void_Byte_Int32_MouseButton_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000790B8 File Offset: 0x000772B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54739, XrefRangeEnd = 54740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MouseMotionEvent(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_MouseMotionEvent_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00079104 File Offset: 0x00077304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54740, XrefRangeEnd = 54742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImeCommitText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_ImeCommitText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00079148 File Offset: 0x00077348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54742, XrefRangeEnd = 54743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImeSetComposition(string text, ImeUnderline underlines, int from, int to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(underlines);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_ImeSetComposition_Public_Void_String_ImeUnderline_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000791B8 File Offset: 0x000773B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54743, XrefRangeEnd = 54745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImeCancelComposition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_ImeCancelComposition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x000791EC File Offset: 0x000773EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54745, XrefRangeEnd = 54752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetImeCompositionRangeCallbackCallbackImpl(IntPtr ptr, int from, int to, ref Rect bounds)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_SetImeCompositionRangeCallbackCallbackImpl_Private_Static_Void_IntPtr_Int32_Int32_byref_Rect_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00079248 File Offset: 0x00077448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54752, XrefRangeEnd = 54763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetImeCompositionRangeCallback(OverlayManager.SetImeCompositionRangeCallbackHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_SetImeCompositionRangeCallback_Public_Void_SetImeCompositionRangeCallbackHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0007928C File Offset: 0x0007748C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54763, XrefRangeEnd = 54770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetImeSelectionBoundsCallbackCallbackImpl(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(anchor);
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focus);
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAnchorFirst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_SetImeSelectionBoundsCallbackCallbackImpl_Private_Static_Void_IntPtr_Rect_Rect_Boolean_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x000792F0 File Offset: 0x000774F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54770, XrefRangeEnd = 54781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetImeSelectionBoundsCallback(OverlayManager.SetImeSelectionBoundsCallbackHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_SetImeSelectionBoundsCallback_Public_Void_SetImeSelectionBoundsCallbackHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00079334 File Offset: 0x00077534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54781, XrefRangeEnd = 54782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInsideClickZone(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_IsPointInsideClickZone_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0007938C File Offset: 0x0007758C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54782, XrefRangeEnd = 54788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnToggleImpl(IntPtr ptr, bool locked)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.NativeMethodInfoPtr_OnToggleImpl_Private_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0000989E File Offset: 0x00007A9E
		public OverlayManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x000793CC File Offset: 0x000775CC
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x000098A7 File Offset: 0x00007AA7
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x000793F4 File Offset: 0x000775F4
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x000098C2 File Offset: 0x00007AC2
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x00079424 File Offset: 0x00077624
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x000098E1 File Offset: 0x00007AE1
		public unsafe OverlayManager.ToggleHandler OnToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.NativeFieldInfoPtr_OnToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.ToggleHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.NativeFieldInfoPtr_OnToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeFieldInfoPtr_OnToggle;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_add_OnToggle_Public_add_Void_ToggleHandler_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnToggle_Public_rem_Void_ToggleHandler_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_IsLocked_Public_Boolean_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_SetLockedCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_SetLocked_Public_Void_Boolean_SetLockedHandler_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_OpenActivityInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_OpenActivityInvite_Public_Void_ActivityActionType_OpenActivityInviteHandler_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_OpenGuildInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_OpenGuildInvite_Public_Void_String_OpenGuildInviteHandler_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_OpenVoiceSettingsCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_OpenVoiceSettings_Public_Void_OpenVoiceSettingsHandler_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_InitDrawingDxgi_Public_Void_IntPtr_Boolean_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_OnPresent_Public_Void_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_ForwardMessage_Public_Void_IntPtr_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_KeyEvent_Public_Void_Boolean_String_KeyVariant_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_CharEvent_Public_Void_String_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_MouseButtonEvent_Public_Void_Byte_Int32_MouseButton_Int32_Int32_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_MouseMotionEvent_Public_Void_Int32_Int32_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_ImeCommitText_Public_Void_String_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_ImeSetComposition_Public_Void_String_ImeUnderline_Int32_Int32_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_ImeCancelComposition_Public_Void_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_SetImeCompositionRangeCallbackCallbackImpl_Private_Static_Void_IntPtr_Int32_Int32_byref_Rect_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_SetImeCompositionRangeCallback_Public_Void_SetImeCompositionRangeCallbackHandler_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_SetImeSelectionBoundsCallbackCallbackImpl_Private_Static_Void_IntPtr_Rect_Rect_Boolean_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_SetImeSelectionBoundsCallback_Public_Void_SetImeSelectionBoundsCallbackHandler_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInsideClickZone_Public_Boolean_Int32_Int32_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleImpl_Private_Static_Void_IntPtr_Boolean_0;

		// Token: 0x0200022E RID: 558
		public sealed class FFIEvents : ValueType
		{
			// Token: 0x06002038 RID: 8248 RVA: 0x0000D355 File Offset: 0x0000B555
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<OverlayManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlayManager.FFIEvents>.NativeClassPtr);
				OverlayManager.FFIEvents.NativeFieldInfoPtr_OnToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIEvents>.NativeClassPtr, "OnToggle");
			}

			// Token: 0x06002039 RID: 8249 RVA: 0x0000D389 File Offset: 0x0000B589
			public FFIEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600203A RID: 8250 RVA: 0x0000D392 File Offset: 0x0000B592
			public FFIEvents()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIEvents>.NativeClassPtr))
			{
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x0600203B RID: 8251 RVA: 0x00094D20 File Offset: 0x00092F20
			// (set) Token: 0x0600203C RID: 8252 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
			public unsafe OverlayManager.FFIEvents.ToggleHandler OnToggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIEvents.NativeFieldInfoPtr_OnToggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIEvents.ToggleHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIEvents.NativeFieldInfoPtr_OnToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018F6 RID: 6390
			private static readonly IntPtr NativeFieldInfoPtr_OnToggle;

			// Token: 0x020002D4 RID: 724
			public sealed class ToggleHandler : MulticastDelegate
			{
				// Token: 0x060025C0 RID: 9664 RVA: 0x000A9730 File Offset: 0x000A7930
				// Note: this type is marked as 'beforefieldinit'.
				static ToggleHandler()
				{
					Il2CppClassPointerStore<OverlayManager.FFIEvents.ToggleHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIEvents>.NativeClassPtr, "ToggleHandler");
					OverlayManager.FFIEvents.ToggleHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIEvents.ToggleHandler>.NativeClassPtr, 100668105);
					OverlayManager.FFIEvents.ToggleHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIEvents.ToggleHandler>.NativeClassPtr, 100668106);
					OverlayManager.FFIEvents.ToggleHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIEvents.ToggleHandler>.NativeClassPtr, 100668107);
					OverlayManager.FFIEvents.ToggleHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIEvents.ToggleHandler>.NativeClassPtr, 100668108);
				}

				// Token: 0x060025C1 RID: 9665 RVA: 0x000A97A4 File Offset: 0x000A79A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54374, XrefRangeEnd = 54377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ToggleHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIEvents.ToggleHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIEvents.ToggleHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025C2 RID: 9666 RVA: 0x000A9800 File Offset: 0x000A7A00
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, bool locked)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIEvents.ToggleHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025C3 RID: 9667 RVA: 0x000A984C File Offset: 0x000A7A4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, bool locked, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIEvents.ToggleHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025C4 RID: 9668 RVA: 0x000A98CC File Offset: 0x000A7ACC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIEvents.ToggleHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060025C5 RID: 9669 RVA: 0x0000F410 File Offset: 0x0000D610
				public ToggleHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025C6 RID: 9670 RVA: 0x0000F419 File Offset: 0x0000D619
				public static implicit operator OverlayManager.FFIEvents.ToggleHandler(Action<IntPtr, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIEvents.ToggleHandler>(A_0);
				}

				// Token: 0x060025C7 RID: 9671 RVA: 0x0000F421 File Offset: 0x0000D621
				public static OverlayManager.FFIEvents.ToggleHandler operator +(OverlayManager.FFIEvents.ToggleHandler A_0, OverlayManager.FFIEvents.ToggleHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIEvents.ToggleHandler>();
				}

				// Token: 0x060025C8 RID: 9672 RVA: 0x0000F42F File Offset: 0x0000D62F
				public static OverlayManager.FFIEvents.ToggleHandler operator -(OverlayManager.FFIEvents.ToggleHandler A_0, OverlayManager.FFIEvents.ToggleHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIEvents.ToggleHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001B95 RID: 7061
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B96 RID: 7062
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Boolean_0;

				// Token: 0x04001B97 RID: 7063
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001B98 RID: 7064
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}

		// Token: 0x0200022F RID: 559
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x0600203D RID: 8253 RVA: 0x00094D50 File Offset: 0x00092F50
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr);
				OverlayManager.FFIMethods.NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "IsEnabled");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "IsLocked");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_SetLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "SetLocked");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_OpenActivityInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OpenActivityInvite");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_OpenGuildInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OpenGuildInvite");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_OpenVoiceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OpenVoiceSettings");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_InitDrawingDxgi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "InitDrawingDxgi");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_OnPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OnPresent");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_ForwardMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "ForwardMessage");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_KeyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "KeyEvent");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_CharEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "CharEvent");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_MouseButtonEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "MouseButtonEvent");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_MouseMotionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "MouseMotionEvent");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_ImeCommitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "ImeCommitText");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_ImeSetComposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "ImeSetComposition");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_ImeCancelComposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "ImeCancelComposition");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_SetImeCompositionRangeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "SetImeCompositionRangeCallback");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_SetImeSelectionBoundsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "SetImeSelectionBoundsCallback");
				OverlayManager.FFIMethods.NativeFieldInfoPtr_IsPointInsideClickZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "IsPointInsideClickZone");
			}

			// Token: 0x0600203E RID: 8254 RVA: 0x0000D3C3 File Offset: 0x0000B5C3
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600203F RID: 8255 RVA: 0x0000D3CC File Offset: 0x0000B5CC
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06002040 RID: 8256 RVA: 0x00094EF8 File Offset: 0x000930F8
			// (set) Token: 0x06002041 RID: 8257 RVA: 0x0000D3DE File Offset: 0x0000B5DE
			public unsafe OverlayManager.FFIMethods.IsEnabledMethod IsEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_IsEnabled);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.IsEnabledMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_IsEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06002042 RID: 8258 RVA: 0x00094F28 File Offset: 0x00093128
			// (set) Token: 0x06002043 RID: 8259 RVA: 0x0000D3FD File Offset: 0x0000B5FD
			public unsafe OverlayManager.FFIMethods.IsLockedMethod IsLocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_IsLocked);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.IsLockedMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_IsLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06002044 RID: 8260 RVA: 0x00094F58 File Offset: 0x00093158
			// (set) Token: 0x06002045 RID: 8261 RVA: 0x0000D41C File Offset: 0x0000B61C
			public unsafe OverlayManager.FFIMethods.SetLockedMethod SetLocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_SetLocked);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.SetLockedMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_SetLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06002046 RID: 8262 RVA: 0x00094F88 File Offset: 0x00093188
			// (set) Token: 0x06002047 RID: 8263 RVA: 0x0000D43B File Offset: 0x0000B63B
			public unsafe OverlayManager.FFIMethods.OpenActivityInviteMethod OpenActivityInvite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_OpenActivityInvite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.OpenActivityInviteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_OpenActivityInvite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06002048 RID: 8264 RVA: 0x00094FB8 File Offset: 0x000931B8
			// (set) Token: 0x06002049 RID: 8265 RVA: 0x0000D45A File Offset: 0x0000B65A
			public unsafe OverlayManager.FFIMethods.OpenGuildInviteMethod OpenGuildInvite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_OpenGuildInvite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.OpenGuildInviteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_OpenGuildInvite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x0600204A RID: 8266 RVA: 0x00094FE8 File Offset: 0x000931E8
			// (set) Token: 0x0600204B RID: 8267 RVA: 0x0000D479 File Offset: 0x0000B679
			public unsafe OverlayManager.FFIMethods.OpenVoiceSettingsMethod OpenVoiceSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_OpenVoiceSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_OpenVoiceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x0600204C RID: 8268 RVA: 0x00095018 File Offset: 0x00093218
			// (set) Token: 0x0600204D RID: 8269 RVA: 0x0000D498 File Offset: 0x0000B698
			public unsafe OverlayManager.FFIMethods.InitDrawingDxgiMethod InitDrawingDxgi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_InitDrawingDxgi);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.InitDrawingDxgiMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_InitDrawingDxgi), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x0600204E RID: 8270 RVA: 0x00095048 File Offset: 0x00093248
			// (set) Token: 0x0600204F RID: 8271 RVA: 0x0000D4B7 File Offset: 0x0000B6B7
			public unsafe OverlayManager.FFIMethods.OnPresentMethod OnPresent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_OnPresent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.OnPresentMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_OnPresent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06002050 RID: 8272 RVA: 0x00095078 File Offset: 0x00093278
			// (set) Token: 0x06002051 RID: 8273 RVA: 0x0000D4D6 File Offset: 0x0000B6D6
			public unsafe OverlayManager.FFIMethods.ForwardMessageMethod ForwardMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_ForwardMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.ForwardMessageMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_ForwardMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x06002052 RID: 8274 RVA: 0x000950A8 File Offset: 0x000932A8
			// (set) Token: 0x06002053 RID: 8275 RVA: 0x0000D4F5 File Offset: 0x0000B6F5
			public unsafe OverlayManager.FFIMethods.KeyEventMethod KeyEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_KeyEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.KeyEventMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_KeyEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x06002054 RID: 8276 RVA: 0x000950D8 File Offset: 0x000932D8
			// (set) Token: 0x06002055 RID: 8277 RVA: 0x0000D514 File Offset: 0x0000B714
			public unsafe OverlayManager.FFIMethods.CharEventMethod CharEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_CharEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.CharEventMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_CharEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x06002056 RID: 8278 RVA: 0x00095108 File Offset: 0x00093308
			// (set) Token: 0x06002057 RID: 8279 RVA: 0x0000D533 File Offset: 0x0000B733
			public unsafe OverlayManager.FFIMethods.MouseButtonEventMethod MouseButtonEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_MouseButtonEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.MouseButtonEventMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_MouseButtonEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x06002058 RID: 8280 RVA: 0x00095138 File Offset: 0x00093338
			// (set) Token: 0x06002059 RID: 8281 RVA: 0x0000D552 File Offset: 0x0000B752
			public unsafe OverlayManager.FFIMethods.MouseMotionEventMethod MouseMotionEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_MouseMotionEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.MouseMotionEventMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_MouseMotionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x0600205A RID: 8282 RVA: 0x00095168 File Offset: 0x00093368
			// (set) Token: 0x0600205B RID: 8283 RVA: 0x0000D571 File Offset: 0x0000B771
			public unsafe OverlayManager.FFIMethods.ImeCommitTextMethod ImeCommitText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_ImeCommitText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.ImeCommitTextMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_ImeCommitText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x0600205C RID: 8284 RVA: 0x00095198 File Offset: 0x00093398
			// (set) Token: 0x0600205D RID: 8285 RVA: 0x0000D590 File Offset: 0x0000B790
			public unsafe OverlayManager.FFIMethods.ImeSetCompositionMethod ImeSetComposition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_ImeSetComposition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.ImeSetCompositionMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_ImeSetComposition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x0600205E RID: 8286 RVA: 0x000951C8 File Offset: 0x000933C8
			// (set) Token: 0x0600205F RID: 8287 RVA: 0x0000D5AF File Offset: 0x0000B7AF
			public unsafe OverlayManager.FFIMethods.ImeCancelCompositionMethod ImeCancelComposition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_ImeCancelComposition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.ImeCancelCompositionMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_ImeCancelComposition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x06002060 RID: 8288 RVA: 0x000951F8 File Offset: 0x000933F8
			// (set) Token: 0x06002061 RID: 8289 RVA: 0x0000D5CE File Offset: 0x0000B7CE
			public unsafe OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod SetImeCompositionRangeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_SetImeCompositionRangeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_SetImeCompositionRangeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x06002062 RID: 8290 RVA: 0x00095228 File Offset: 0x00093428
			// (set) Token: 0x06002063 RID: 8291 RVA: 0x0000D5ED File Offset: 0x0000B7ED
			public unsafe OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod SetImeSelectionBoundsCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_SetImeSelectionBoundsCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_SetImeSelectionBoundsCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x06002064 RID: 8292 RVA: 0x00095258 File Offset: 0x00093458
			// (set) Token: 0x06002065 RID: 8293 RVA: 0x0000D60C File Offset: 0x0000B80C
			public unsafe OverlayManager.FFIMethods.IsPointInsideClickZoneMethod IsPointInsideClickZone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_IsPointInsideClickZone);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverlayManager.FFIMethods.NativeFieldInfoPtr_IsPointInsideClickZone), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018F7 RID: 6391
			private static readonly IntPtr NativeFieldInfoPtr_IsEnabled;

			// Token: 0x040018F8 RID: 6392
			private static readonly IntPtr NativeFieldInfoPtr_IsLocked;

			// Token: 0x040018F9 RID: 6393
			private static readonly IntPtr NativeFieldInfoPtr_SetLocked;

			// Token: 0x040018FA RID: 6394
			private static readonly IntPtr NativeFieldInfoPtr_OpenActivityInvite;

			// Token: 0x040018FB RID: 6395
			private static readonly IntPtr NativeFieldInfoPtr_OpenGuildInvite;

			// Token: 0x040018FC RID: 6396
			private static readonly IntPtr NativeFieldInfoPtr_OpenVoiceSettings;

			// Token: 0x040018FD RID: 6397
			private static readonly IntPtr NativeFieldInfoPtr_InitDrawingDxgi;

			// Token: 0x040018FE RID: 6398
			private static readonly IntPtr NativeFieldInfoPtr_OnPresent;

			// Token: 0x040018FF RID: 6399
			private static readonly IntPtr NativeFieldInfoPtr_ForwardMessage;

			// Token: 0x04001900 RID: 6400
			private static readonly IntPtr NativeFieldInfoPtr_KeyEvent;

			// Token: 0x04001901 RID: 6401
			private static readonly IntPtr NativeFieldInfoPtr_CharEvent;

			// Token: 0x04001902 RID: 6402
			private static readonly IntPtr NativeFieldInfoPtr_MouseButtonEvent;

			// Token: 0x04001903 RID: 6403
			private static readonly IntPtr NativeFieldInfoPtr_MouseMotionEvent;

			// Token: 0x04001904 RID: 6404
			private static readonly IntPtr NativeFieldInfoPtr_ImeCommitText;

			// Token: 0x04001905 RID: 6405
			private static readonly IntPtr NativeFieldInfoPtr_ImeSetComposition;

			// Token: 0x04001906 RID: 6406
			private static readonly IntPtr NativeFieldInfoPtr_ImeCancelComposition;

			// Token: 0x04001907 RID: 6407
			private static readonly IntPtr NativeFieldInfoPtr_SetImeCompositionRangeCallback;

			// Token: 0x04001908 RID: 6408
			private static readonly IntPtr NativeFieldInfoPtr_SetImeSelectionBoundsCallback;

			// Token: 0x04001909 RID: 6409
			private static readonly IntPtr NativeFieldInfoPtr_IsPointInsideClickZone;

			// Token: 0x020002D5 RID: 725
			public sealed class IsEnabledMethod : MulticastDelegate
			{
				// Token: 0x060025C9 RID: 9673 RVA: 0x000A9910 File Offset: 0x000A7B10
				// Note: this type is marked as 'beforefieldinit'.
				static IsEnabledMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.IsEnabledMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "IsEnabledMethod");
					OverlayManager.FFIMethods.IsEnabledMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsEnabledMethod>.NativeClassPtr, 100668109);
					OverlayManager.FFIMethods.IsEnabledMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsEnabledMethod>.NativeClassPtr, 100668110);
					OverlayManager.FFIMethods.IsEnabledMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsEnabledMethod>.NativeClassPtr, 100668111);
					OverlayManager.FFIMethods.IsEnabledMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsEnabledMethod>.NativeClassPtr, 100668112);
				}

				// Token: 0x060025CA RID: 9674 RVA: 0x000A9984 File Offset: 0x000A7B84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsEnabledMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsEnabledMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsEnabledMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025CB RID: 9675 RVA: 0x000A99E0 File Offset: 0x000A7BE0
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ref bool enabled)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &enabled;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsEnabledMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025CC RID: 9676 RVA: 0x000A9A2C File Offset: 0x000A7C2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54377, XrefRangeEnd = 54382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool enabled, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &enabled;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsEnabledMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025CD RID: 9677 RVA: 0x000A9AAC File Offset: 0x000A7CAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref bool enabled, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &enabled;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsEnabledMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025CE RID: 9678 RVA: 0x0000F440 File Offset: 0x0000D640
				public IsEnabledMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B99 RID: 7065
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B9A RID: 7066
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Boolean_0;

				// Token: 0x04001B9B RID: 7067
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001B9C RID: 7068
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Boolean_IAsyncResult_0;
			}

			// Token: 0x020002D6 RID: 726
			public sealed class IsLockedMethod : MulticastDelegate
			{
				// Token: 0x060025CF RID: 9679 RVA: 0x000A9AFC File Offset: 0x000A7CFC
				// Note: this type is marked as 'beforefieldinit'.
				static IsLockedMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.IsLockedMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "IsLockedMethod");
					OverlayManager.FFIMethods.IsLockedMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsLockedMethod>.NativeClassPtr, 100668113);
					OverlayManager.FFIMethods.IsLockedMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsLockedMethod>.NativeClassPtr, 100668114);
					OverlayManager.FFIMethods.IsLockedMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsLockedMethod>.NativeClassPtr, 100668115);
					OverlayManager.FFIMethods.IsLockedMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsLockedMethod>.NativeClassPtr, 100668116);
				}

				// Token: 0x060025D0 RID: 9680 RVA: 0x000A9B70 File Offset: 0x000A7D70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsLockedMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsLockedMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsLockedMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025D1 RID: 9681 RVA: 0x000A9BCC File Offset: 0x000A7DCC
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ref bool locked)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &locked;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsLockedMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025D2 RID: 9682 RVA: 0x000A9C18 File Offset: 0x000A7E18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool locked, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &locked;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsLockedMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025D3 RID: 9683 RVA: 0x000A9C98 File Offset: 0x000A7E98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref bool locked, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &locked;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsLockedMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025D4 RID: 9684 RVA: 0x0000F449 File Offset: 0x0000D649
				public IsLockedMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B9D RID: 7069
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B9E RID: 7070
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Boolean_0;

				// Token: 0x04001B9F RID: 7071
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001BA0 RID: 7072
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Boolean_IAsyncResult_0;
			}

			// Token: 0x020002D7 RID: 727
			public sealed class SetLockedCallback : MulticastDelegate
			{
				// Token: 0x060025D5 RID: 9685 RVA: 0x000A9CE8 File Offset: 0x000A7EE8
				// Note: this type is marked as 'beforefieldinit'.
				static SetLockedCallback()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "SetLockedCallback");
					OverlayManager.FFIMethods.SetLockedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedCallback>.NativeClassPtr, 100668117);
					OverlayManager.FFIMethods.SetLockedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedCallback>.NativeClassPtr, 100668118);
					OverlayManager.FFIMethods.SetLockedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedCallback>.NativeClassPtr, 100668119);
					OverlayManager.FFIMethods.SetLockedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedCallback>.NativeClassPtr, 100668120);
				}

				// Token: 0x060025D6 RID: 9686 RVA: 0x000A9D5C File Offset: 0x000A7F5C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetLockedCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetLockedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025D7 RID: 9687 RVA: 0x000A9DB8 File Offset: 0x000A7FB8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetLockedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025D8 RID: 9688 RVA: 0x000A9E08 File Offset: 0x000A8008
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54382, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetLockedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025D9 RID: 9689 RVA: 0x000A9E8C File Offset: 0x000A808C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetLockedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060025DA RID: 9690 RVA: 0x0000F452 File Offset: 0x0000D652
				public SetLockedCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025DB RID: 9691 RVA: 0x0000F45B File Offset: 0x0000D65B
				public static implicit operator OverlayManager.FFIMethods.SetLockedCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.SetLockedCallback>(A_0);
				}

				// Token: 0x060025DC RID: 9692 RVA: 0x0000F463 File Offset: 0x0000D663
				public static OverlayManager.FFIMethods.SetLockedCallback operator +(OverlayManager.FFIMethods.SetLockedCallback A_0, OverlayManager.FFIMethods.SetLockedCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.SetLockedCallback>();
				}

				// Token: 0x060025DD RID: 9693 RVA: 0x0000F471 File Offset: 0x0000D671
				public static OverlayManager.FFIMethods.SetLockedCallback operator -(OverlayManager.FFIMethods.SetLockedCallback A_0, OverlayManager.FFIMethods.SetLockedCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.SetLockedCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001BA1 RID: 7073
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BA2 RID: 7074
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001BA3 RID: 7075
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001BA4 RID: 7076
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002D8 RID: 728
			public sealed class SetLockedMethod : MulticastDelegate
			{
				// Token: 0x060025DE RID: 9694 RVA: 0x000A9ED0 File Offset: 0x000A80D0
				// Note: this type is marked as 'beforefieldinit'.
				static SetLockedMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "SetLockedMethod");
					OverlayManager.FFIMethods.SetLockedMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedMethod>.NativeClassPtr, 100668121);
					OverlayManager.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Boolean_IntPtr_SetLockedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedMethod>.NativeClassPtr, 100668122);
					OverlayManager.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_IntPtr_SetLockedCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedMethod>.NativeClassPtr, 100668123);
					OverlayManager.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedMethod>.NativeClassPtr, 100668124);
				}

				// Token: 0x060025DF RID: 9695 RVA: 0x000A9F44 File Offset: 0x000A8144
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54388, XrefRangeEnd = 54391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetLockedMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetLockedMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetLockedMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025E0 RID: 9696 RVA: 0x000A9FA0 File Offset: 0x000A81A0
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, bool locked, IntPtr callbackData, OverlayManager.FFIMethods.SetLockedCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Boolean_IntPtr_SetLockedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025E1 RID: 9697 RVA: 0x000AA010 File Offset: 0x000A8210
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54391, XrefRangeEnd = 54398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, bool locked, IntPtr callbackData, OverlayManager.FFIMethods.SetLockedCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_IntPtr_SetLockedCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025E2 RID: 9698 RVA: 0x000AA0B4 File Offset: 0x000A82B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060025E3 RID: 9699 RVA: 0x0000F482 File Offset: 0x0000D682
				public SetLockedMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025E4 RID: 9700 RVA: 0x0000F48B File Offset: 0x0000D68B
				public static implicit operator OverlayManager.FFIMethods.SetLockedMethod(Action<IntPtr, bool, IntPtr, OverlayManager.FFIMethods.SetLockedCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.SetLockedMethod>(A_0);
				}

				// Token: 0x060025E5 RID: 9701 RVA: 0x0000F493 File Offset: 0x0000D693
				public static OverlayManager.FFIMethods.SetLockedMethod operator +(OverlayManager.FFIMethods.SetLockedMethod A_0, OverlayManager.FFIMethods.SetLockedMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.SetLockedMethod>();
				}

				// Token: 0x060025E6 RID: 9702 RVA: 0x0000F4A1 File Offset: 0x0000D6A1
				public static OverlayManager.FFIMethods.SetLockedMethod operator -(OverlayManager.FFIMethods.SetLockedMethod A_0, OverlayManager.FFIMethods.SetLockedMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.SetLockedMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BA5 RID: 7077
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BA6 RID: 7078
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Boolean_IntPtr_SetLockedCallback_0;

				// Token: 0x04001BA7 RID: 7079
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_IntPtr_SetLockedCallback_AsyncCallback_Object_0;

				// Token: 0x04001BA8 RID: 7080
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002D9 RID: 729
			public sealed class OpenActivityInviteCallback : MulticastDelegate
			{
				// Token: 0x060025E7 RID: 9703 RVA: 0x000AA0F8 File Offset: 0x000A82F8
				// Note: this type is marked as 'beforefieldinit'.
				static OpenActivityInviteCallback()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OpenActivityInviteCallback");
					OverlayManager.FFIMethods.OpenActivityInviteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteCallback>.NativeClassPtr, 100668125);
					OverlayManager.FFIMethods.OpenActivityInviteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteCallback>.NativeClassPtr, 100668126);
					OverlayManager.FFIMethods.OpenActivityInviteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteCallback>.NativeClassPtr, 100668127);
					OverlayManager.FFIMethods.OpenActivityInviteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteCallback>.NativeClassPtr, 100668128);
				}

				// Token: 0x060025E8 RID: 9704 RVA: 0x000AA16C File Offset: 0x000A836C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OpenActivityInviteCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenActivityInviteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025E9 RID: 9705 RVA: 0x000AA1C8 File Offset: 0x000A83C8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenActivityInviteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025EA RID: 9706 RVA: 0x000AA218 File Offset: 0x000A8418
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54398, XrefRangeEnd = 54404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenActivityInviteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025EB RID: 9707 RVA: 0x000AA29C File Offset: 0x000A849C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenActivityInviteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060025EC RID: 9708 RVA: 0x0000F4B2 File Offset: 0x0000D6B2
				public OpenActivityInviteCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025ED RID: 9709 RVA: 0x0000F4BB File Offset: 0x0000D6BB
				public static implicit operator OverlayManager.FFIMethods.OpenActivityInviteCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.OpenActivityInviteCallback>(A_0);
				}

				// Token: 0x060025EE RID: 9710 RVA: 0x0000F4C3 File Offset: 0x0000D6C3
				public static OverlayManager.FFIMethods.OpenActivityInviteCallback operator +(OverlayManager.FFIMethods.OpenActivityInviteCallback A_0, OverlayManager.FFIMethods.OpenActivityInviteCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.OpenActivityInviteCallback>();
				}

				// Token: 0x060025EF RID: 9711 RVA: 0x0000F4D1 File Offset: 0x0000D6D1
				public static OverlayManager.FFIMethods.OpenActivityInviteCallback operator -(OverlayManager.FFIMethods.OpenActivityInviteCallback A_0, OverlayManager.FFIMethods.OpenActivityInviteCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.OpenActivityInviteCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001BA9 RID: 7081
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BAA RID: 7082
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001BAB RID: 7083
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001BAC RID: 7084
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002DA RID: 730
			public sealed class OpenActivityInviteMethod : MulticastDelegate
			{
				// Token: 0x060025F0 RID: 9712 RVA: 0x000AA2E0 File Offset: 0x000A84E0
				// Note: this type is marked as 'beforefieldinit'.
				static OpenActivityInviteMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OpenActivityInviteMethod");
					OverlayManager.FFIMethods.OpenActivityInviteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteMethod>.NativeClassPtr, 100668129);
					OverlayManager.FFIMethods.OpenActivityInviteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_ActivityActionType_IntPtr_OpenActivityInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteMethod>.NativeClassPtr, 100668130);
					OverlayManager.FFIMethods.OpenActivityInviteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ActivityActionType_IntPtr_OpenActivityInviteCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteMethod>.NativeClassPtr, 100668131);
					OverlayManager.FFIMethods.OpenActivityInviteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteMethod>.NativeClassPtr, 100668132);
				}

				// Token: 0x060025F1 RID: 9713 RVA: 0x000AA354 File Offset: 0x000A8554
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OpenActivityInviteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenActivityInviteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenActivityInviteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025F2 RID: 9714 RVA: 0x000AA3B0 File Offset: 0x000A85B0
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OverlayManager.FFIMethods.OpenActivityInviteCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenActivityInviteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_ActivityActionType_IntPtr_OpenActivityInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025F3 RID: 9715 RVA: 0x000AA424 File Offset: 0x000A8624
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54404, XrefRangeEnd = 54412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OverlayManager.FFIMethods.OpenActivityInviteCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenActivityInviteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ActivityActionType_IntPtr_OpenActivityInviteCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025F4 RID: 9716 RVA: 0x000AA4CC File Offset: 0x000A86CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenActivityInviteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060025F5 RID: 9717 RVA: 0x0000F4E2 File Offset: 0x0000D6E2
				public OpenActivityInviteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025F6 RID: 9718 RVA: 0x0000F4EB File Offset: 0x0000D6EB
				public static implicit operator OverlayManager.FFIMethods.OpenActivityInviteMethod(Action<IntPtr, ActivityActionType, IntPtr, OverlayManager.FFIMethods.OpenActivityInviteCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.OpenActivityInviteMethod>(A_0);
				}

				// Token: 0x060025F7 RID: 9719 RVA: 0x0000F4F3 File Offset: 0x0000D6F3
				public static OverlayManager.FFIMethods.OpenActivityInviteMethod operator +(OverlayManager.FFIMethods.OpenActivityInviteMethod A_0, OverlayManager.FFIMethods.OpenActivityInviteMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.OpenActivityInviteMethod>();
				}

				// Token: 0x060025F8 RID: 9720 RVA: 0x0000F501 File Offset: 0x0000D701
				public static OverlayManager.FFIMethods.OpenActivityInviteMethod operator -(OverlayManager.FFIMethods.OpenActivityInviteMethod A_0, OverlayManager.FFIMethods.OpenActivityInviteMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.OpenActivityInviteMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BAD RID: 7085
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BAE RID: 7086
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_ActivityActionType_IntPtr_OpenActivityInviteCallback_0;

				// Token: 0x04001BAF RID: 7087
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ActivityActionType_IntPtr_OpenActivityInviteCallback_AsyncCallback_Object_0;

				// Token: 0x04001BB0 RID: 7088
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002DB RID: 731
			public sealed class OpenGuildInviteCallback : MulticastDelegate
			{
				// Token: 0x060025F9 RID: 9721 RVA: 0x000AA510 File Offset: 0x000A8710
				// Note: this type is marked as 'beforefieldinit'.
				static OpenGuildInviteCallback()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OpenGuildInviteCallback");
					OverlayManager.FFIMethods.OpenGuildInviteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteCallback>.NativeClassPtr, 100668133);
					OverlayManager.FFIMethods.OpenGuildInviteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteCallback>.NativeClassPtr, 100668134);
					OverlayManager.FFIMethods.OpenGuildInviteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteCallback>.NativeClassPtr, 100668135);
					OverlayManager.FFIMethods.OpenGuildInviteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteCallback>.NativeClassPtr, 100668136);
				}

				// Token: 0x060025FA RID: 9722 RVA: 0x000AA584 File Offset: 0x000A8784
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OpenGuildInviteCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenGuildInviteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025FB RID: 9723 RVA: 0x000AA5E0 File Offset: 0x000A87E0
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenGuildInviteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060025FC RID: 9724 RVA: 0x000AA630 File Offset: 0x000A8830
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54412, XrefRangeEnd = 54418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenGuildInviteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060025FD RID: 9725 RVA: 0x000AA6B4 File Offset: 0x000A88B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenGuildInviteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060025FE RID: 9726 RVA: 0x0000F512 File Offset: 0x0000D712
				public OpenGuildInviteCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060025FF RID: 9727 RVA: 0x0000F51B File Offset: 0x0000D71B
				public static implicit operator OverlayManager.FFIMethods.OpenGuildInviteCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.OpenGuildInviteCallback>(A_0);
				}

				// Token: 0x06002600 RID: 9728 RVA: 0x0000F523 File Offset: 0x0000D723
				public static OverlayManager.FFIMethods.OpenGuildInviteCallback operator +(OverlayManager.FFIMethods.OpenGuildInviteCallback A_0, OverlayManager.FFIMethods.OpenGuildInviteCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.OpenGuildInviteCallback>();
				}

				// Token: 0x06002601 RID: 9729 RVA: 0x0000F531 File Offset: 0x0000D731
				public static OverlayManager.FFIMethods.OpenGuildInviteCallback operator -(OverlayManager.FFIMethods.OpenGuildInviteCallback A_0, OverlayManager.FFIMethods.OpenGuildInviteCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.OpenGuildInviteCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001BB1 RID: 7089
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BB2 RID: 7090
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001BB3 RID: 7091
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001BB4 RID: 7092
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002DC RID: 732
			public sealed class OpenGuildInviteMethod : MulticastDelegate
			{
				// Token: 0x06002602 RID: 9730 RVA: 0x000AA6F8 File Offset: 0x000A88F8
				// Note: this type is marked as 'beforefieldinit'.
				static OpenGuildInviteMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OpenGuildInviteMethod");
					OverlayManager.FFIMethods.OpenGuildInviteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteMethod>.NativeClassPtr, 100668137);
					OverlayManager.FFIMethods.OpenGuildInviteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_IntPtr_OpenGuildInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteMethod>.NativeClassPtr, 100668138);
					OverlayManager.FFIMethods.OpenGuildInviteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_IntPtr_OpenGuildInviteCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteMethod>.NativeClassPtr, 100668139);
					OverlayManager.FFIMethods.OpenGuildInviteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteMethod>.NativeClassPtr, 100668140);
				}

				// Token: 0x06002603 RID: 9731 RVA: 0x000AA76C File Offset: 0x000A896C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OpenGuildInviteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenGuildInviteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenGuildInviteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002604 RID: 9732 RVA: 0x000AA7C8 File Offset: 0x000A89C8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, string code, IntPtr callbackData, OverlayManager.FFIMethods.OpenGuildInviteCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenGuildInviteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_IntPtr_OpenGuildInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002605 RID: 9733 RVA: 0x000AA83C File Offset: 0x000A8A3C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string code, IntPtr callbackData, OverlayManager.FFIMethods.OpenGuildInviteCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenGuildInviteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_IntPtr_OpenGuildInviteCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002606 RID: 9734 RVA: 0x000AA8E4 File Offset: 0x000A8AE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenGuildInviteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002607 RID: 9735 RVA: 0x0000F542 File Offset: 0x0000D742
				public OpenGuildInviteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002608 RID: 9736 RVA: 0x0000F54B File Offset: 0x0000D74B
				public static implicit operator OverlayManager.FFIMethods.OpenGuildInviteMethod(Action<IntPtr, string, IntPtr, OverlayManager.FFIMethods.OpenGuildInviteCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.OpenGuildInviteMethod>(A_0);
				}

				// Token: 0x06002609 RID: 9737 RVA: 0x0000F553 File Offset: 0x0000D753
				public static OverlayManager.FFIMethods.OpenGuildInviteMethod operator +(OverlayManager.FFIMethods.OpenGuildInviteMethod A_0, OverlayManager.FFIMethods.OpenGuildInviteMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.OpenGuildInviteMethod>();
				}

				// Token: 0x0600260A RID: 9738 RVA: 0x0000F561 File Offset: 0x0000D761
				public static OverlayManager.FFIMethods.OpenGuildInviteMethod operator -(OverlayManager.FFIMethods.OpenGuildInviteMethod A_0, OverlayManager.FFIMethods.OpenGuildInviteMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.OpenGuildInviteMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BB5 RID: 7093
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BB6 RID: 7094
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_IntPtr_OpenGuildInviteCallback_0;

				// Token: 0x04001BB7 RID: 7095
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_IntPtr_OpenGuildInviteCallback_AsyncCallback_Object_0;

				// Token: 0x04001BB8 RID: 7096
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002DD RID: 733
			public sealed class OpenVoiceSettingsCallback : MulticastDelegate
			{
				// Token: 0x0600260B RID: 9739 RVA: 0x000AA928 File Offset: 0x000A8B28
				// Note: this type is marked as 'beforefieldinit'.
				static OpenVoiceSettingsCallback()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OpenVoiceSettingsCallback");
					OverlayManager.FFIMethods.OpenVoiceSettingsCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsCallback>.NativeClassPtr, 100668141);
					OverlayManager.FFIMethods.OpenVoiceSettingsCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsCallback>.NativeClassPtr, 100668142);
					OverlayManager.FFIMethods.OpenVoiceSettingsCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsCallback>.NativeClassPtr, 100668143);
					OverlayManager.FFIMethods.OpenVoiceSettingsCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsCallback>.NativeClassPtr, 100668144);
				}

				// Token: 0x0600260C RID: 9740 RVA: 0x000AA99C File Offset: 0x000A8B9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OpenVoiceSettingsCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenVoiceSettingsCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600260D RID: 9741 RVA: 0x000AA9F8 File Offset: 0x000A8BF8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenVoiceSettingsCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600260E RID: 9742 RVA: 0x000AAA48 File Offset: 0x000A8C48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54418, XrefRangeEnd = 54424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenVoiceSettingsCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600260F RID: 9743 RVA: 0x000AAACC File Offset: 0x000A8CCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenVoiceSettingsCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002610 RID: 9744 RVA: 0x0000F572 File Offset: 0x0000D772
				public OpenVoiceSettingsCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002611 RID: 9745 RVA: 0x0000F57B File Offset: 0x0000D77B
				public static implicit operator OverlayManager.FFIMethods.OpenVoiceSettingsCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.OpenVoiceSettingsCallback>(A_0);
				}

				// Token: 0x06002612 RID: 9746 RVA: 0x0000F583 File Offset: 0x0000D783
				public static OverlayManager.FFIMethods.OpenVoiceSettingsCallback operator +(OverlayManager.FFIMethods.OpenVoiceSettingsCallback A_0, OverlayManager.FFIMethods.OpenVoiceSettingsCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.OpenVoiceSettingsCallback>();
				}

				// Token: 0x06002613 RID: 9747 RVA: 0x0000F591 File Offset: 0x0000D791
				public static OverlayManager.FFIMethods.OpenVoiceSettingsCallback operator -(OverlayManager.FFIMethods.OpenVoiceSettingsCallback A_0, OverlayManager.FFIMethods.OpenVoiceSettingsCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.OpenVoiceSettingsCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001BB9 RID: 7097
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BBA RID: 7098
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001BBB RID: 7099
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001BBC RID: 7100
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002DE RID: 734
			public sealed class OpenVoiceSettingsMethod : MulticastDelegate
			{
				// Token: 0x06002614 RID: 9748 RVA: 0x000AAB10 File Offset: 0x000A8D10
				// Note: this type is marked as 'beforefieldinit'.
				static OpenVoiceSettingsMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OpenVoiceSettingsMethod");
					OverlayManager.FFIMethods.OpenVoiceSettingsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>.NativeClassPtr, 100668145);
					OverlayManager.FFIMethods.OpenVoiceSettingsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_OpenVoiceSettingsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>.NativeClassPtr, 100668146);
					OverlayManager.FFIMethods.OpenVoiceSettingsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_OpenVoiceSettingsCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>.NativeClassPtr, 100668147);
					OverlayManager.FFIMethods.OpenVoiceSettingsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>.NativeClassPtr, 100668148);
				}

				// Token: 0x06002615 RID: 9749 RVA: 0x000AAB84 File Offset: 0x000A8D84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OpenVoiceSettingsMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenVoiceSettingsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002616 RID: 9750 RVA: 0x000AABE0 File Offset: 0x000A8DE0
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.OpenVoiceSettingsCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenVoiceSettingsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_OpenVoiceSettingsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002617 RID: 9751 RVA: 0x000AAC40 File Offset: 0x000A8E40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.OpenVoiceSettingsCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenVoiceSettingsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_OpenVoiceSettingsCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002618 RID: 9752 RVA: 0x000AACD4 File Offset: 0x000A8ED4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OpenVoiceSettingsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002619 RID: 9753 RVA: 0x0000F5A2 File Offset: 0x0000D7A2
				public OpenVoiceSettingsMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600261A RID: 9754 RVA: 0x0000F5AB File Offset: 0x0000D7AB
				public static implicit operator OverlayManager.FFIMethods.OpenVoiceSettingsMethod(Action<IntPtr, IntPtr, OverlayManager.FFIMethods.OpenVoiceSettingsCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>(A_0);
				}

				// Token: 0x0600261B RID: 9755 RVA: 0x0000F5B3 File Offset: 0x0000D7B3
				public static OverlayManager.FFIMethods.OpenVoiceSettingsMethod operator +(OverlayManager.FFIMethods.OpenVoiceSettingsMethod A_0, OverlayManager.FFIMethods.OpenVoiceSettingsMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>();
				}

				// Token: 0x0600261C RID: 9756 RVA: 0x0000F5C1 File Offset: 0x0000D7C1
				public static OverlayManager.FFIMethods.OpenVoiceSettingsMethod operator -(OverlayManager.FFIMethods.OpenVoiceSettingsMethod A_0, OverlayManager.FFIMethods.OpenVoiceSettingsMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.OpenVoiceSettingsMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BBD RID: 7101
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BBE RID: 7102
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_OpenVoiceSettingsCallback_0;

				// Token: 0x04001BBF RID: 7103
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_OpenVoiceSettingsCallback_AsyncCallback_Object_0;

				// Token: 0x04001BC0 RID: 7104
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002DF RID: 735
			public sealed class InitDrawingDxgiMethod : MulticastDelegate
			{
				// Token: 0x0600261D RID: 9757 RVA: 0x000AAD18 File Offset: 0x000A8F18
				// Note: this type is marked as 'beforefieldinit'.
				static InitDrawingDxgiMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.InitDrawingDxgiMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "InitDrawingDxgiMethod");
					OverlayManager.FFIMethods.InitDrawingDxgiMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.InitDrawingDxgiMethod>.NativeClassPtr, 100668149);
					OverlayManager.FFIMethods.InitDrawingDxgiMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.InitDrawingDxgiMethod>.NativeClassPtr, 100668150);
					OverlayManager.FFIMethods.InitDrawingDxgiMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.InitDrawingDxgiMethod>.NativeClassPtr, 100668151);
					OverlayManager.FFIMethods.InitDrawingDxgiMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.InitDrawingDxgiMethod>.NativeClassPtr, 100668152);
				}

				// Token: 0x0600261E RID: 9758 RVA: 0x000AAD8C File Offset: 0x000A8F8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe InitDrawingDxgiMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.InitDrawingDxgiMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.InitDrawingDxgiMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600261F RID: 9759 RVA: 0x000AADE8 File Offset: 0x000A8FE8
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, IntPtr swapchain, bool useMessageForwarding)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref swapchain;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMessageForwarding;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.InitDrawingDxgiMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002620 RID: 9760 RVA: 0x000AAE50 File Offset: 0x000A9050
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54424, XrefRangeEnd = 54431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr swapchain, bool useMessageForwarding, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref swapchain;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMessageForwarding;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.InitDrawingDxgiMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002621 RID: 9761 RVA: 0x000AAEE0 File Offset: 0x000A90E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.InitDrawingDxgiMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002622 RID: 9762 RVA: 0x0000F5D2 File Offset: 0x0000D7D2
				public InitDrawingDxgiMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002623 RID: 9763 RVA: 0x0000F5DB File Offset: 0x0000D7DB
				public static implicit operator OverlayManager.FFIMethods.InitDrawingDxgiMethod(Func<IntPtr, IntPtr, bool, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.InitDrawingDxgiMethod>(A_0);
				}

				// Token: 0x06002624 RID: 9764 RVA: 0x0000F5E3 File Offset: 0x0000D7E3
				public static OverlayManager.FFIMethods.InitDrawingDxgiMethod operator +(OverlayManager.FFIMethods.InitDrawingDxgiMethod A_0, OverlayManager.FFIMethods.InitDrawingDxgiMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.InitDrawingDxgiMethod>();
				}

				// Token: 0x06002625 RID: 9765 RVA: 0x0000F5F1 File Offset: 0x0000D7F1
				public static OverlayManager.FFIMethods.InitDrawingDxgiMethod operator -(OverlayManager.FFIMethods.InitDrawingDxgiMethod A_0, OverlayManager.FFIMethods.InitDrawingDxgiMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.InitDrawingDxgiMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BC1 RID: 7105
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BC2 RID: 7106
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_IntPtr_Boolean_0;

				// Token: 0x04001BC3 RID: 7107
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001BC4 RID: 7108
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002E0 RID: 736
			public sealed class OnPresentMethod : MulticastDelegate
			{
				// Token: 0x06002626 RID: 9766 RVA: 0x000AAF30 File Offset: 0x000A9130
				// Note: this type is marked as 'beforefieldinit'.
				static OnPresentMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.OnPresentMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "OnPresentMethod");
					OverlayManager.FFIMethods.OnPresentMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OnPresentMethod>.NativeClassPtr, 100668153);
					OverlayManager.FFIMethods.OnPresentMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OnPresentMethod>.NativeClassPtr, 100668154);
					OverlayManager.FFIMethods.OnPresentMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OnPresentMethod>.NativeClassPtr, 100668155);
					OverlayManager.FFIMethods.OnPresentMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.OnPresentMethod>.NativeClassPtr, 100668156);
				}

				// Token: 0x06002627 RID: 9767 RVA: 0x000AAFA4 File Offset: 0x000A91A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OnPresentMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.OnPresentMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OnPresentMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002628 RID: 9768 RVA: 0x000AB000 File Offset: 0x000A9200
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OnPresentMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002629 RID: 9769 RVA: 0x000AB040 File Offset: 0x000A9240
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OnPresentMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600262A RID: 9770 RVA: 0x000AB0B0 File Offset: 0x000A92B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.OnPresentMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600262B RID: 9771 RVA: 0x0000F602 File Offset: 0x0000D802
				public OnPresentMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600262C RID: 9772 RVA: 0x0000F60B File Offset: 0x0000D80B
				public static implicit operator OverlayManager.FFIMethods.OnPresentMethod(Action<IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.OnPresentMethod>(A_0);
				}

				// Token: 0x0600262D RID: 9773 RVA: 0x0000F613 File Offset: 0x0000D813
				public static OverlayManager.FFIMethods.OnPresentMethod operator +(OverlayManager.FFIMethods.OnPresentMethod A_0, OverlayManager.FFIMethods.OnPresentMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.OnPresentMethod>();
				}

				// Token: 0x0600262E RID: 9774 RVA: 0x0000F621 File Offset: 0x0000D821
				public static OverlayManager.FFIMethods.OnPresentMethod operator -(OverlayManager.FFIMethods.OnPresentMethod A_0, OverlayManager.FFIMethods.OnPresentMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.OnPresentMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BC5 RID: 7109
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BC6 RID: 7110
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

				// Token: 0x04001BC7 RID: 7111
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001BC8 RID: 7112
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002E1 RID: 737
			public sealed class ForwardMessageMethod : MulticastDelegate
			{
				// Token: 0x0600262F RID: 9775 RVA: 0x000AB0F4 File Offset: 0x000A92F4
				// Note: this type is marked as 'beforefieldinit'.
				static ForwardMessageMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.ForwardMessageMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "ForwardMessageMethod");
					OverlayManager.FFIMethods.ForwardMessageMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ForwardMessageMethod>.NativeClassPtr, 100668157);
					OverlayManager.FFIMethods.ForwardMessageMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ForwardMessageMethod>.NativeClassPtr, 100668158);
					OverlayManager.FFIMethods.ForwardMessageMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ForwardMessageMethod>.NativeClassPtr, 100668159);
					OverlayManager.FFIMethods.ForwardMessageMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ForwardMessageMethod>.NativeClassPtr, 100668160);
				}

				// Token: 0x06002630 RID: 9776 RVA: 0x000AB168 File Offset: 0x000A9368
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ForwardMessageMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.ForwardMessageMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ForwardMessageMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002631 RID: 9777 RVA: 0x000AB1C4 File Offset: 0x000A93C4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr message)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref message;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ForwardMessageMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002632 RID: 9778 RVA: 0x000AB210 File Offset: 0x000A9410
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54431, XrefRangeEnd = 54436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr message, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref message;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ForwardMessageMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002633 RID: 9779 RVA: 0x000AB290 File Offset: 0x000A9490
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ForwardMessageMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002634 RID: 9780 RVA: 0x0000F632 File Offset: 0x0000D832
				public ForwardMessageMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002635 RID: 9781 RVA: 0x0000F63B File Offset: 0x0000D83B
				public static implicit operator OverlayManager.FFIMethods.ForwardMessageMethod(Action<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.ForwardMessageMethod>(A_0);
				}

				// Token: 0x06002636 RID: 9782 RVA: 0x0000F643 File Offset: 0x0000D843
				public static OverlayManager.FFIMethods.ForwardMessageMethod operator +(OverlayManager.FFIMethods.ForwardMessageMethod A_0, OverlayManager.FFIMethods.ForwardMessageMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.ForwardMessageMethod>();
				}

				// Token: 0x06002637 RID: 9783 RVA: 0x0000F651 File Offset: 0x0000D851
				public static OverlayManager.FFIMethods.ForwardMessageMethod operator -(OverlayManager.FFIMethods.ForwardMessageMethod A_0, OverlayManager.FFIMethods.ForwardMessageMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.ForwardMessageMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BC9 RID: 7113
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BCA RID: 7114
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_0;

				// Token: 0x04001BCB RID: 7115
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001BCC RID: 7116
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002E2 RID: 738
			public sealed class KeyEventMethod : MulticastDelegate
			{
				// Token: 0x06002638 RID: 9784 RVA: 0x000AB2D4 File Offset: 0x000A94D4
				// Note: this type is marked as 'beforefieldinit'.
				static KeyEventMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.KeyEventMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "KeyEventMethod");
					OverlayManager.FFIMethods.KeyEventMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.KeyEventMethod>.NativeClassPtr, 100668161);
					OverlayManager.FFIMethods.KeyEventMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Boolean_String_KeyVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.KeyEventMethod>.NativeClassPtr, 100668162);
					OverlayManager.FFIMethods.KeyEventMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_String_KeyVariant_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.KeyEventMethod>.NativeClassPtr, 100668163);
					OverlayManager.FFIMethods.KeyEventMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.KeyEventMethod>.NativeClassPtr, 100668164);
				}

				// Token: 0x06002639 RID: 9785 RVA: 0x000AB348 File Offset: 0x000A9548
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54436, XrefRangeEnd = 54439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe KeyEventMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.KeyEventMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.KeyEventMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600263A RID: 9786 RVA: 0x000AB3A4 File Offset: 0x000A95A4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, bool down, string keyCode, KeyVariant variant)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref down;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyCode);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variant);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.KeyEventMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Boolean_String_KeyVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600263B RID: 9787 RVA: 0x000AB418 File Offset: 0x000A9618
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54439, XrefRangeEnd = 54447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, bool down, string keyCode, KeyVariant variant, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref down;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyCode);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variant);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.KeyEventMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_String_KeyVariant_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600263C RID: 9788 RVA: 0x000AB4C0 File Offset: 0x000A96C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.KeyEventMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600263D RID: 9789 RVA: 0x0000F662 File Offset: 0x0000D862
				public KeyEventMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600263E RID: 9790 RVA: 0x0000F66B File Offset: 0x0000D86B
				public static implicit operator OverlayManager.FFIMethods.KeyEventMethod(Action<IntPtr, bool, string, KeyVariant> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.KeyEventMethod>(A_0);
				}

				// Token: 0x0600263F RID: 9791 RVA: 0x0000F673 File Offset: 0x0000D873
				public static OverlayManager.FFIMethods.KeyEventMethod operator +(OverlayManager.FFIMethods.KeyEventMethod A_0, OverlayManager.FFIMethods.KeyEventMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.KeyEventMethod>();
				}

				// Token: 0x06002640 RID: 9792 RVA: 0x0000F681 File Offset: 0x0000D881
				public static OverlayManager.FFIMethods.KeyEventMethod operator -(OverlayManager.FFIMethods.KeyEventMethod A_0, OverlayManager.FFIMethods.KeyEventMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.KeyEventMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BCD RID: 7117
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BCE RID: 7118
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Boolean_String_KeyVariant_0;

				// Token: 0x04001BCF RID: 7119
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_String_KeyVariant_AsyncCallback_Object_0;

				// Token: 0x04001BD0 RID: 7120
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002E3 RID: 739
			public sealed class CharEventMethod : MulticastDelegate
			{
				// Token: 0x06002641 RID: 9793 RVA: 0x000AB504 File Offset: 0x000A9704
				// Note: this type is marked as 'beforefieldinit'.
				static CharEventMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.CharEventMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "CharEventMethod");
					OverlayManager.FFIMethods.CharEventMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.CharEventMethod>.NativeClassPtr, 100668165);
					OverlayManager.FFIMethods.CharEventMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.CharEventMethod>.NativeClassPtr, 100668166);
					OverlayManager.FFIMethods.CharEventMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.CharEventMethod>.NativeClassPtr, 100668167);
					OverlayManager.FFIMethods.CharEventMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.CharEventMethod>.NativeClassPtr, 100668168);
				}

				// Token: 0x06002642 RID: 9794 RVA: 0x000AB578 File Offset: 0x000A9778
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CharEventMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.CharEventMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.CharEventMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002643 RID: 9795 RVA: 0x000AB5D4 File Offset: 0x000A97D4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, string character)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(character);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.CharEventMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002644 RID: 9796 RVA: 0x000AB624 File Offset: 0x000A9824
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string character, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(character);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.CharEventMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002645 RID: 9797 RVA: 0x000AB6A8 File Offset: 0x000A98A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.CharEventMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002646 RID: 9798 RVA: 0x0000F692 File Offset: 0x0000D892
				public CharEventMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002647 RID: 9799 RVA: 0x0000F69B File Offset: 0x0000D89B
				public static implicit operator OverlayManager.FFIMethods.CharEventMethod(Action<IntPtr, string> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.CharEventMethod>(A_0);
				}

				// Token: 0x06002648 RID: 9800 RVA: 0x0000F6A3 File Offset: 0x0000D8A3
				public static OverlayManager.FFIMethods.CharEventMethod operator +(OverlayManager.FFIMethods.CharEventMethod A_0, OverlayManager.FFIMethods.CharEventMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.CharEventMethod>();
				}

				// Token: 0x06002649 RID: 9801 RVA: 0x0000F6B1 File Offset: 0x0000D8B1
				public static OverlayManager.FFIMethods.CharEventMethod operator -(OverlayManager.FFIMethods.CharEventMethod A_0, OverlayManager.FFIMethods.CharEventMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.CharEventMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BD1 RID: 7121
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BD2 RID: 7122
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0;

				// Token: 0x04001BD3 RID: 7123
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0;

				// Token: 0x04001BD4 RID: 7124
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002E4 RID: 740
			public sealed class MouseButtonEventMethod : MulticastDelegate
			{
				// Token: 0x0600264A RID: 9802 RVA: 0x000AB6EC File Offset: 0x000A98EC
				// Note: this type is marked as 'beforefieldinit'.
				static MouseButtonEventMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseButtonEventMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "MouseButtonEventMethod");
					OverlayManager.FFIMethods.MouseButtonEventMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseButtonEventMethod>.NativeClassPtr, 100668169);
					OverlayManager.FFIMethods.MouseButtonEventMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Byte_Int32_MouseButton_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseButtonEventMethod>.NativeClassPtr, 100668170);
					OverlayManager.FFIMethods.MouseButtonEventMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Byte_Int32_MouseButton_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseButtonEventMethod>.NativeClassPtr, 100668171);
					OverlayManager.FFIMethods.MouseButtonEventMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseButtonEventMethod>.NativeClassPtr, 100668172);
				}

				// Token: 0x0600264B RID: 9803 RVA: 0x000AB760 File Offset: 0x000A9960
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54447, XrefRangeEnd = 54450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MouseButtonEventMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseButtonEventMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.MouseButtonEventMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600264C RID: 9804 RVA: 0x000AB7BC File Offset: 0x000A99BC
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, byte down, int clickCount, MouseButton which, int x, int y)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref down;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clickCount;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(which);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.MouseButtonEventMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Byte_Int32_MouseButton_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600264D RID: 9805 RVA: 0x000AB848 File Offset: 0x000A9A48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54450, XrefRangeEnd = 54464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, byte down, int clickCount, MouseButton which, int x, int y, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref down;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clickCount;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(which);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.MouseButtonEventMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Byte_Int32_MouseButton_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600264E RID: 9806 RVA: 0x000AB908 File Offset: 0x000A9B08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.MouseButtonEventMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600264F RID: 9807 RVA: 0x0000F6C2 File Offset: 0x0000D8C2
				public MouseButtonEventMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002650 RID: 9808 RVA: 0x0000F6CB File Offset: 0x0000D8CB
				public static implicit operator OverlayManager.FFIMethods.MouseButtonEventMethod(Action<IntPtr, byte, int, MouseButton, int, int> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.MouseButtonEventMethod>(A_0);
				}

				// Token: 0x06002651 RID: 9809 RVA: 0x0000F6D3 File Offset: 0x0000D8D3
				public static OverlayManager.FFIMethods.MouseButtonEventMethod operator +(OverlayManager.FFIMethods.MouseButtonEventMethod A_0, OverlayManager.FFIMethods.MouseButtonEventMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.MouseButtonEventMethod>();
				}

				// Token: 0x06002652 RID: 9810 RVA: 0x0000F6E1 File Offset: 0x0000D8E1
				public static OverlayManager.FFIMethods.MouseButtonEventMethod operator -(OverlayManager.FFIMethods.MouseButtonEventMethod A_0, OverlayManager.FFIMethods.MouseButtonEventMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.MouseButtonEventMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BD5 RID: 7125
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BD6 RID: 7126
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Byte_Int32_MouseButton_Int32_Int32_0;

				// Token: 0x04001BD7 RID: 7127
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Byte_Int32_MouseButton_Int32_Int32_AsyncCallback_Object_0;

				// Token: 0x04001BD8 RID: 7128
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002E5 RID: 741
			public sealed class MouseMotionEventMethod : MulticastDelegate
			{
				// Token: 0x06002653 RID: 9811 RVA: 0x000AB94C File Offset: 0x000A9B4C
				// Note: this type is marked as 'beforefieldinit'.
				static MouseMotionEventMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseMotionEventMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "MouseMotionEventMethod");
					OverlayManager.FFIMethods.MouseMotionEventMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseMotionEventMethod>.NativeClassPtr, 100668173);
					OverlayManager.FFIMethods.MouseMotionEventMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseMotionEventMethod>.NativeClassPtr, 100668174);
					OverlayManager.FFIMethods.MouseMotionEventMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseMotionEventMethod>.NativeClassPtr, 100668175);
					OverlayManager.FFIMethods.MouseMotionEventMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseMotionEventMethod>.NativeClassPtr, 100668176);
				}

				// Token: 0x06002654 RID: 9812 RVA: 0x000AB9C0 File Offset: 0x000A9BC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54464, XrefRangeEnd = 54467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MouseMotionEventMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.MouseMotionEventMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.MouseMotionEventMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002655 RID: 9813 RVA: 0x000ABA1C File Offset: 0x000A9C1C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, int x, int y)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.MouseMotionEventMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002656 RID: 9814 RVA: 0x000ABA78 File Offset: 0x000A9C78
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54467, XrefRangeEnd = 54474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, int x, int y, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.MouseMotionEventMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002657 RID: 9815 RVA: 0x000ABB08 File Offset: 0x000A9D08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.MouseMotionEventMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002658 RID: 9816 RVA: 0x0000F6F2 File Offset: 0x0000D8F2
				public MouseMotionEventMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002659 RID: 9817 RVA: 0x0000F6FB File Offset: 0x0000D8FB
				public static implicit operator OverlayManager.FFIMethods.MouseMotionEventMethod(Action<IntPtr, int, int> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.MouseMotionEventMethod>(A_0);
				}

				// Token: 0x0600265A RID: 9818 RVA: 0x0000F703 File Offset: 0x0000D903
				public static OverlayManager.FFIMethods.MouseMotionEventMethod operator +(OverlayManager.FFIMethods.MouseMotionEventMethod A_0, OverlayManager.FFIMethods.MouseMotionEventMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.MouseMotionEventMethod>();
				}

				// Token: 0x0600265B RID: 9819 RVA: 0x0000F711 File Offset: 0x0000D911
				public static OverlayManager.FFIMethods.MouseMotionEventMethod operator -(OverlayManager.FFIMethods.MouseMotionEventMethod A_0, OverlayManager.FFIMethods.MouseMotionEventMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.MouseMotionEventMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BD9 RID: 7129
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BDA RID: 7130
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_Int32_0;

				// Token: 0x04001BDB RID: 7131
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_Int32_AsyncCallback_Object_0;

				// Token: 0x04001BDC RID: 7132
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002E6 RID: 742
			public sealed class ImeCommitTextMethod : MulticastDelegate
			{
				// Token: 0x0600265C RID: 9820 RVA: 0x000ABB4C File Offset: 0x000A9D4C
				// Note: this type is marked as 'beforefieldinit'.
				static ImeCommitTextMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCommitTextMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "ImeCommitTextMethod");
					OverlayManager.FFIMethods.ImeCommitTextMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCommitTextMethod>.NativeClassPtr, 100668177);
					OverlayManager.FFIMethods.ImeCommitTextMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCommitTextMethod>.NativeClassPtr, 100668178);
					OverlayManager.FFIMethods.ImeCommitTextMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCommitTextMethod>.NativeClassPtr, 100668179);
					OverlayManager.FFIMethods.ImeCommitTextMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCommitTextMethod>.NativeClassPtr, 100668180);
				}

				// Token: 0x0600265D RID: 9821 RVA: 0x000ABBC0 File Offset: 0x000A9DC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ImeCommitTextMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCommitTextMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeCommitTextMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600265E RID: 9822 RVA: 0x000ABC1C File Offset: 0x000A9E1C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, string text)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeCommitTextMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600265F RID: 9823 RVA: 0x000ABC6C File Offset: 0x000A9E6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string text, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeCommitTextMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002660 RID: 9824 RVA: 0x000ABCF0 File Offset: 0x000A9EF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeCommitTextMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002661 RID: 9825 RVA: 0x0000F722 File Offset: 0x0000D922
				public ImeCommitTextMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002662 RID: 9826 RVA: 0x0000F72B File Offset: 0x0000D92B
				public static implicit operator OverlayManager.FFIMethods.ImeCommitTextMethod(Action<IntPtr, string> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.ImeCommitTextMethod>(A_0);
				}

				// Token: 0x06002663 RID: 9827 RVA: 0x0000F733 File Offset: 0x0000D933
				public static OverlayManager.FFIMethods.ImeCommitTextMethod operator +(OverlayManager.FFIMethods.ImeCommitTextMethod A_0, OverlayManager.FFIMethods.ImeCommitTextMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.ImeCommitTextMethod>();
				}

				// Token: 0x06002664 RID: 9828 RVA: 0x0000F741 File Offset: 0x0000D941
				public static OverlayManager.FFIMethods.ImeCommitTextMethod operator -(OverlayManager.FFIMethods.ImeCommitTextMethod A_0, OverlayManager.FFIMethods.ImeCommitTextMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.ImeCommitTextMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BDD RID: 7133
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BDE RID: 7134
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0;

				// Token: 0x04001BDF RID: 7135
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0;

				// Token: 0x04001BE0 RID: 7136
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002E7 RID: 743
			public sealed class ImeSetCompositionMethod : MulticastDelegate
			{
				// Token: 0x06002665 RID: 9829 RVA: 0x000ABD34 File Offset: 0x000A9F34
				// Note: this type is marked as 'beforefieldinit'.
				static ImeSetCompositionMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeSetCompositionMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "ImeSetCompositionMethod");
					OverlayManager.FFIMethods.ImeSetCompositionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeSetCompositionMethod>.NativeClassPtr, 100668181);
					OverlayManager.FFIMethods.ImeSetCompositionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_byref_ImeUnderline_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeSetCompositionMethod>.NativeClassPtr, 100668182);
					OverlayManager.FFIMethods.ImeSetCompositionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_byref_ImeUnderline_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeSetCompositionMethod>.NativeClassPtr, 100668183);
					OverlayManager.FFIMethods.ImeSetCompositionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ImeUnderline_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeSetCompositionMethod>.NativeClassPtr, 100668184);
				}

				// Token: 0x06002666 RID: 9830 RVA: 0x000ABDA8 File Offset: 0x000A9FA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54474, XrefRangeEnd = 54477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ImeSetCompositionMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeSetCompositionMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeSetCompositionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002667 RID: 9831 RVA: 0x000ABE04 File Offset: 0x000AA004
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, string text, ref ImeUnderline underlines, int from, int to)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &underlines;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeSetCompositionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_byref_ImeUnderline_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002668 RID: 9832 RVA: 0x000ABE80 File Offset: 0x000AA080
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54477, XrefRangeEnd = 54487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string text, ref ImeUnderline underlines, int from, int to, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &underlines;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeSetCompositionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_byref_ImeUnderline_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002669 RID: 9833 RVA: 0x000ABF30 File Offset: 0x000AA130
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref ImeUnderline underlines, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &underlines;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeSetCompositionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ImeUnderline_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600266A RID: 9834 RVA: 0x0000F752 File Offset: 0x0000D952
				public ImeSetCompositionMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001BE1 RID: 7137
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BE2 RID: 7138
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_byref_ImeUnderline_Int32_Int32_0;

				// Token: 0x04001BE3 RID: 7139
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_byref_ImeUnderline_Int32_Int32_AsyncCallback_Object_0;

				// Token: 0x04001BE4 RID: 7140
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ImeUnderline_IAsyncResult_0;
			}

			// Token: 0x020002E8 RID: 744
			public sealed class ImeCancelCompositionMethod : MulticastDelegate
			{
				// Token: 0x0600266B RID: 9835 RVA: 0x000ABF80 File Offset: 0x000AA180
				// Note: this type is marked as 'beforefieldinit'.
				static ImeCancelCompositionMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCancelCompositionMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "ImeCancelCompositionMethod");
					OverlayManager.FFIMethods.ImeCancelCompositionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCancelCompositionMethod>.NativeClassPtr, 100668185);
					OverlayManager.FFIMethods.ImeCancelCompositionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCancelCompositionMethod>.NativeClassPtr, 100668186);
					OverlayManager.FFIMethods.ImeCancelCompositionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCancelCompositionMethod>.NativeClassPtr, 100668187);
					OverlayManager.FFIMethods.ImeCancelCompositionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCancelCompositionMethod>.NativeClassPtr, 100668188);
				}

				// Token: 0x0600266C RID: 9836 RVA: 0x000ABFF4 File Offset: 0x000AA1F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ImeCancelCompositionMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.ImeCancelCompositionMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeCancelCompositionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600266D RID: 9837 RVA: 0x000AC050 File Offset: 0x000AA250
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeCancelCompositionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600266E RID: 9838 RVA: 0x000AC090 File Offset: 0x000AA290
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeCancelCompositionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600266F RID: 9839 RVA: 0x000AC100 File Offset: 0x000AA300
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.ImeCancelCompositionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002670 RID: 9840 RVA: 0x0000F75B File Offset: 0x0000D95B
				public ImeCancelCompositionMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002671 RID: 9841 RVA: 0x0000F764 File Offset: 0x0000D964
				public static implicit operator OverlayManager.FFIMethods.ImeCancelCompositionMethod(Action<IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.ImeCancelCompositionMethod>(A_0);
				}

				// Token: 0x06002672 RID: 9842 RVA: 0x0000F76C File Offset: 0x0000D96C
				public static OverlayManager.FFIMethods.ImeCancelCompositionMethod operator +(OverlayManager.FFIMethods.ImeCancelCompositionMethod A_0, OverlayManager.FFIMethods.ImeCancelCompositionMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.ImeCancelCompositionMethod>();
				}

				// Token: 0x06002673 RID: 9843 RVA: 0x0000F77A File Offset: 0x0000D97A
				public static OverlayManager.FFIMethods.ImeCancelCompositionMethod operator -(OverlayManager.FFIMethods.ImeCancelCompositionMethod A_0, OverlayManager.FFIMethods.ImeCancelCompositionMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.ImeCancelCompositionMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BE5 RID: 7141
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BE6 RID: 7142
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

				// Token: 0x04001BE7 RID: 7143
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001BE8 RID: 7144
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002E9 RID: 745
			public sealed class SetImeCompositionRangeCallbackCallback : MulticastDelegate
			{
				// Token: 0x06002674 RID: 9844 RVA: 0x000AC144 File Offset: 0x000AA344
				// Note: this type is marked as 'beforefieldinit'.
				static SetImeCompositionRangeCallbackCallback()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "SetImeCompositionRangeCallbackCallback");
					OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback>.NativeClassPtr, 100668189);
					OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback>.NativeClassPtr, 100668190);
					OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_Int32_byref_Rect_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback>.NativeClassPtr, 100668191);
					OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Rect_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback>.NativeClassPtr, 100668192);
				}

				// Token: 0x06002675 RID: 9845 RVA: 0x000AC1B8 File Offset: 0x000AA3B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54487, XrefRangeEnd = 54490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetImeCompositionRangeCallbackCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002676 RID: 9846 RVA: 0x000AC214 File Offset: 0x000AA414
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, int from, int to, ref Rect bounds)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_Int32_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002677 RID: 9847 RVA: 0x000AC280 File Offset: 0x000AA480
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54490, XrefRangeEnd = 54500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, int from, int to, ref Rect bounds, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_Int32_byref_Rect_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002678 RID: 9848 RVA: 0x000AC320 File Offset: 0x000AA520
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref Rect bounds, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &bounds;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Rect_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002679 RID: 9849 RVA: 0x0000F78B File Offset: 0x0000D98B
				public SetImeCompositionRangeCallbackCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001BE9 RID: 7145
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BEA RID: 7146
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_Int32_byref_Rect_0;

				// Token: 0x04001BEB RID: 7147
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_Int32_byref_Rect_AsyncCallback_Object_0;

				// Token: 0x04001BEC RID: 7148
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Rect_IAsyncResult_0;
			}

			// Token: 0x020002EA RID: 746
			public sealed class SetImeCompositionRangeCallbackMethod : MulticastDelegate
			{
				// Token: 0x0600267A RID: 9850 RVA: 0x000AC370 File Offset: 0x000AA570
				// Note: this type is marked as 'beforefieldinit'.
				static SetImeCompositionRangeCallbackMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "SetImeCompositionRangeCallbackMethod");
					OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>.NativeClassPtr, 100668193);
					OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_SetImeCompositionRangeCallbackCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>.NativeClassPtr, 100668194);
					OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_SetImeCompositionRangeCallbackCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>.NativeClassPtr, 100668195);
					OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>.NativeClassPtr, 100668196);
				}

				// Token: 0x0600267B RID: 9851 RVA: 0x000AC3E4 File Offset: 0x000AA5E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetImeCompositionRangeCallbackMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600267C RID: 9852 RVA: 0x000AC440 File Offset: 0x000AA640
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_SetImeCompositionRangeCallbackCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600267D RID: 9853 RVA: 0x000AC4A0 File Offset: 0x000AA6A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_SetImeCompositionRangeCallbackCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600267E RID: 9854 RVA: 0x000AC534 File Offset: 0x000AA734
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600267F RID: 9855 RVA: 0x0000F794 File Offset: 0x0000D994
				public SetImeCompositionRangeCallbackMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002680 RID: 9856 RVA: 0x0000F79D File Offset: 0x0000D99D
				public static implicit operator OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod(Action<IntPtr, IntPtr, OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>(A_0);
				}

				// Token: 0x06002681 RID: 9857 RVA: 0x0000F7A5 File Offset: 0x0000D9A5
				public static OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod operator +(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod A_0, OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>();
				}

				// Token: 0x06002682 RID: 9858 RVA: 0x0000F7B3 File Offset: 0x0000D9B3
				public static OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod operator -(OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod A_0, OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BED RID: 7149
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BEE RID: 7150
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_SetImeCompositionRangeCallbackCallback_0;

				// Token: 0x04001BEF RID: 7151
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_SetImeCompositionRangeCallbackCallback_AsyncCallback_Object_0;

				// Token: 0x04001BF0 RID: 7152
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002EB RID: 747
			public sealed class SetImeSelectionBoundsCallbackCallback : MulticastDelegate
			{
				// Token: 0x06002683 RID: 9859 RVA: 0x000AC578 File Offset: 0x000AA778
				// Note: this type is marked as 'beforefieldinit'.
				static SetImeSelectionBoundsCallbackCallback()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "SetImeSelectionBoundsCallbackCallback");
					OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback>.NativeClassPtr, 100668197);
					OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Rect_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback>.NativeClassPtr, 100668198);
					OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Rect_Rect_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback>.NativeClassPtr, 100668199);
					OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback>.NativeClassPtr, 100668200);
				}

				// Token: 0x06002684 RID: 9860 RVA: 0x000AC5EC File Offset: 0x000AA7EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54500, XrefRangeEnd = 54503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetImeSelectionBoundsCallbackCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002685 RID: 9861 RVA: 0x000AC648 File Offset: 0x000AA848
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(anchor);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focus);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAnchorFirst;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Rect_Rect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002686 RID: 9862 RVA: 0x000AC6B8 File Offset: 0x000AA8B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54503, XrefRangeEnd = 54513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(anchor);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focus);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAnchorFirst;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Rect_Rect_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002687 RID: 9863 RVA: 0x000AC75C File Offset: 0x000AA95C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002688 RID: 9864 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
				public SetImeSelectionBoundsCallbackCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002689 RID: 9865 RVA: 0x0000F7CD File Offset: 0x0000D9CD
				public static implicit operator OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback(Action<IntPtr, Rect, Rect, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback>(A_0);
				}

				// Token: 0x0600268A RID: 9866 RVA: 0x0000F7D5 File Offset: 0x0000D9D5
				public static OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback operator +(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback A_0, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback>();
				}

				// Token: 0x0600268B RID: 9867 RVA: 0x0000F7E3 File Offset: 0x0000D9E3
				public static OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback operator -(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback A_0, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001BF1 RID: 7153
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BF2 RID: 7154
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Rect_Rect_Boolean_0;

				// Token: 0x04001BF3 RID: 7155
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Rect_Rect_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001BF4 RID: 7156
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002EC RID: 748
			public sealed class SetImeSelectionBoundsCallbackMethod : MulticastDelegate
			{
				// Token: 0x0600268C RID: 9868 RVA: 0x000AC7A0 File Offset: 0x000AA9A0
				// Note: this type is marked as 'beforefieldinit'.
				static SetImeSelectionBoundsCallbackMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "SetImeSelectionBoundsCallbackMethod");
					OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>.NativeClassPtr, 100668201);
					OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_SetImeSelectionBoundsCallbackCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>.NativeClassPtr, 100668202);
					OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_SetImeSelectionBoundsCallbackCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>.NativeClassPtr, 100668203);
					OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>.NativeClassPtr, 100668204);
				}

				// Token: 0x0600268D RID: 9869 RVA: 0x000AC814 File Offset: 0x000AAA14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetImeSelectionBoundsCallbackMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600268E RID: 9870 RVA: 0x000AC870 File Offset: 0x000AAA70
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_SetImeSelectionBoundsCallbackCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600268F RID: 9871 RVA: 0x000AC8D0 File Offset: 0x000AAAD0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_SetImeSelectionBoundsCallbackCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002690 RID: 9872 RVA: 0x000AC964 File Offset: 0x000AAB64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002691 RID: 9873 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
				public SetImeSelectionBoundsCallbackMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002692 RID: 9874 RVA: 0x0000F7FD File Offset: 0x0000D9FD
				public static implicit operator OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod(Action<IntPtr, IntPtr, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>(A_0);
				}

				// Token: 0x06002693 RID: 9875 RVA: 0x0000F805 File Offset: 0x0000DA05
				public static OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod operator +(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod A_0, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>();
				}

				// Token: 0x06002694 RID: 9876 RVA: 0x0000F813 File Offset: 0x0000DA13
				public static OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod operator -(OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod A_0, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BF5 RID: 7157
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BF6 RID: 7158
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_SetImeSelectionBoundsCallbackCallback_0;

				// Token: 0x04001BF7 RID: 7159
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_SetImeSelectionBoundsCallbackCallback_AsyncCallback_Object_0;

				// Token: 0x04001BF8 RID: 7160
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002ED RID: 749
			public sealed class IsPointInsideClickZoneMethod : MulticastDelegate
			{
				// Token: 0x06002695 RID: 9877 RVA: 0x000AC9A8 File Offset: 0x000AABA8
				// Note: this type is marked as 'beforefieldinit'.
				static IsPointInsideClickZoneMethod()
				{
					Il2CppClassPointerStore<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager.FFIMethods>.NativeClassPtr, "IsPointInsideClickZoneMethod");
					OverlayManager.FFIMethods.IsPointInsideClickZoneMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>.NativeClassPtr, 100668205);
					OverlayManager.FFIMethods.IsPointInsideClickZoneMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>.NativeClassPtr, 100668206);
					OverlayManager.FFIMethods.IsPointInsideClickZoneMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>.NativeClassPtr, 100668207);
					OverlayManager.FFIMethods.IsPointInsideClickZoneMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>.NativeClassPtr, 100668208);
				}

				// Token: 0x06002696 RID: 9878 RVA: 0x000ACA1C File Offset: 0x000AAC1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54513, XrefRangeEnd = 54516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsPointInsideClickZoneMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsPointInsideClickZoneMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002697 RID: 9879 RVA: 0x000ACA78 File Offset: 0x000AAC78
				[CallerCount(0)]
				public unsafe bool Invoke(IntPtr methodsPtr, int x, int y)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsPointInsideClickZoneMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002698 RID: 9880 RVA: 0x000ACAE0 File Offset: 0x000AACE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, int x, int y, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsPointInsideClickZoneMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002699 RID: 9881 RVA: 0x000ACB70 File Offset: 0x000AAD70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54516, XrefRangeEnd = 54518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.FFIMethods.IsPointInsideClickZoneMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600269A RID: 9882 RVA: 0x0000F824 File Offset: 0x0000DA24
				public IsPointInsideClickZoneMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600269B RID: 9883 RVA: 0x0000F82D File Offset: 0x0000DA2D
				public static implicit operator OverlayManager.FFIMethods.IsPointInsideClickZoneMethod(Func<IntPtr, int, int, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>(A_0);
				}

				// Token: 0x0600269C RID: 9884 RVA: 0x0000F835 File Offset: 0x0000DA35
				public static OverlayManager.FFIMethods.IsPointInsideClickZoneMethod operator +(OverlayManager.FFIMethods.IsPointInsideClickZoneMethod A_0, OverlayManager.FFIMethods.IsPointInsideClickZoneMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>();
				}

				// Token: 0x0600269D RID: 9885 RVA: 0x0000F843 File Offset: 0x0000DA43
				public static OverlayManager.FFIMethods.IsPointInsideClickZoneMethod operator -(OverlayManager.FFIMethods.IsPointInsideClickZoneMethod A_0, OverlayManager.FFIMethods.IsPointInsideClickZoneMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<OverlayManager.FFIMethods.IsPointInsideClickZoneMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001BF9 RID: 7161
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001BFA RID: 7162
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_Int32_Int32_0;

				// Token: 0x04001BFB RID: 7163
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_Int32_AsyncCallback_Object_0;

				// Token: 0x04001BFC RID: 7164
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
			}
		}

		// Token: 0x02000230 RID: 560
		public sealed class SetLockedHandler : MulticastDelegate
		{
			// Token: 0x06002066 RID: 8294 RVA: 0x00095288 File Offset: 0x00093488
			// Note: this type is marked as 'beforefieldinit'.
			static SetLockedHandler()
			{
				Il2CppClassPointerStore<OverlayManager.SetLockedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "SetLockedHandler");
				OverlayManager.SetLockedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetLockedHandler>.NativeClassPtr, 100668209);
				OverlayManager.SetLockedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetLockedHandler>.NativeClassPtr, 100668210);
				OverlayManager.SetLockedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetLockedHandler>.NativeClassPtr, 100668211);
				OverlayManager.SetLockedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetLockedHandler>.NativeClassPtr, 100668212);
			}

			// Token: 0x06002067 RID: 8295 RVA: 0x000952FC File Offset: 0x000934FC
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetLockedHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.SetLockedHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetLockedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002068 RID: 8296 RVA: 0x00095358 File Offset: 0x00093558
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetLockedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002069 RID: 8297 RVA: 0x0009539C File Offset: 0x0009359C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54518, XrefRangeEnd = 54522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetLockedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600206A RID: 8298 RVA: 0x00095410 File Offset: 0x00093610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetLockedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600206B RID: 8299 RVA: 0x0000D62B File Offset: 0x0000B82B
			public SetLockedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600206C RID: 8300 RVA: 0x0000D634 File Offset: 0x0000B834
			public static implicit operator OverlayManager.SetLockedHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<OverlayManager.SetLockedHandler>(A_0);
			}

			// Token: 0x0600206D RID: 8301 RVA: 0x0000D63C File Offset: 0x0000B83C
			public static OverlayManager.SetLockedHandler operator +(OverlayManager.SetLockedHandler A_0, OverlayManager.SetLockedHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OverlayManager.SetLockedHandler>();
			}

			// Token: 0x0600206E RID: 8302 RVA: 0x0000D64A File Offset: 0x0000B84A
			public static OverlayManager.SetLockedHandler operator -(OverlayManager.SetLockedHandler A_0, OverlayManager.SetLockedHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OverlayManager.SetLockedHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400190A RID: 6410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400190B RID: 6411
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x0400190C RID: 6412
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x0400190D RID: 6413
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000231 RID: 561
		public sealed class OpenActivityInviteHandler : MulticastDelegate
		{
			// Token: 0x0600206F RID: 8303 RVA: 0x00095454 File Offset: 0x00093654
			// Note: this type is marked as 'beforefieldinit'.
			static OpenActivityInviteHandler()
			{
				Il2CppClassPointerStore<OverlayManager.OpenActivityInviteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "OpenActivityInviteHandler");
				OverlayManager.OpenActivityInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenActivityInviteHandler>.NativeClassPtr, 100668213);
				OverlayManager.OpenActivityInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenActivityInviteHandler>.NativeClassPtr, 100668214);
				OverlayManager.OpenActivityInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenActivityInviteHandler>.NativeClassPtr, 100668215);
				OverlayManager.OpenActivityInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenActivityInviteHandler>.NativeClassPtr, 100668216);
			}

			// Token: 0x06002070 RID: 8304 RVA: 0x000954C8 File Offset: 0x000936C8
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenActivityInviteHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.OpenActivityInviteHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenActivityInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002071 RID: 8305 RVA: 0x00095524 File Offset: 0x00093724
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenActivityInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002072 RID: 8306 RVA: 0x00095568 File Offset: 0x00093768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54522, XrefRangeEnd = 54526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenActivityInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002073 RID: 8307 RVA: 0x000955DC File Offset: 0x000937DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenActivityInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002074 RID: 8308 RVA: 0x0000D65B File Offset: 0x0000B85B
			public OpenActivityInviteHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002075 RID: 8309 RVA: 0x0000D664 File Offset: 0x0000B864
			public static implicit operator OverlayManager.OpenActivityInviteHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<OverlayManager.OpenActivityInviteHandler>(A_0);
			}

			// Token: 0x06002076 RID: 8310 RVA: 0x0000D66C File Offset: 0x0000B86C
			public static OverlayManager.OpenActivityInviteHandler operator +(OverlayManager.OpenActivityInviteHandler A_0, OverlayManager.OpenActivityInviteHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OverlayManager.OpenActivityInviteHandler>();
			}

			// Token: 0x06002077 RID: 8311 RVA: 0x0000D67A File Offset: 0x0000B87A
			public static OverlayManager.OpenActivityInviteHandler operator -(OverlayManager.OpenActivityInviteHandler A_0, OverlayManager.OpenActivityInviteHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OverlayManager.OpenActivityInviteHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400190E RID: 6414
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400190F RID: 6415
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x04001910 RID: 6416
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x04001911 RID: 6417
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000232 RID: 562
		public sealed class OpenGuildInviteHandler : MulticastDelegate
		{
			// Token: 0x06002078 RID: 8312 RVA: 0x00095620 File Offset: 0x00093820
			// Note: this type is marked as 'beforefieldinit'.
			static OpenGuildInviteHandler()
			{
				Il2CppClassPointerStore<OverlayManager.OpenGuildInviteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "OpenGuildInviteHandler");
				OverlayManager.OpenGuildInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenGuildInviteHandler>.NativeClassPtr, 100668217);
				OverlayManager.OpenGuildInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenGuildInviteHandler>.NativeClassPtr, 100668218);
				OverlayManager.OpenGuildInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenGuildInviteHandler>.NativeClassPtr, 100668219);
				OverlayManager.OpenGuildInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenGuildInviteHandler>.NativeClassPtr, 100668220);
			}

			// Token: 0x06002079 RID: 8313 RVA: 0x00095694 File Offset: 0x00093894
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenGuildInviteHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.OpenGuildInviteHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenGuildInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600207A RID: 8314 RVA: 0x000956F0 File Offset: 0x000938F0
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenGuildInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600207B RID: 8315 RVA: 0x00095734 File Offset: 0x00093934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54526, XrefRangeEnd = 54530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenGuildInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600207C RID: 8316 RVA: 0x000957A8 File Offset: 0x000939A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenGuildInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600207D RID: 8317 RVA: 0x0000D68B File Offset: 0x0000B88B
			public OpenGuildInviteHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600207E RID: 8318 RVA: 0x0000D694 File Offset: 0x0000B894
			public static implicit operator OverlayManager.OpenGuildInviteHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<OverlayManager.OpenGuildInviteHandler>(A_0);
			}

			// Token: 0x0600207F RID: 8319 RVA: 0x0000D69C File Offset: 0x0000B89C
			public static OverlayManager.OpenGuildInviteHandler operator +(OverlayManager.OpenGuildInviteHandler A_0, OverlayManager.OpenGuildInviteHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OverlayManager.OpenGuildInviteHandler>();
			}

			// Token: 0x06002080 RID: 8320 RVA: 0x0000D6AA File Offset: 0x0000B8AA
			public static OverlayManager.OpenGuildInviteHandler operator -(OverlayManager.OpenGuildInviteHandler A_0, OverlayManager.OpenGuildInviteHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OverlayManager.OpenGuildInviteHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001912 RID: 6418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001913 RID: 6419
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x04001914 RID: 6420
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x04001915 RID: 6421
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000233 RID: 563
		public sealed class OpenVoiceSettingsHandler : MulticastDelegate
		{
			// Token: 0x06002081 RID: 8321 RVA: 0x000957EC File Offset: 0x000939EC
			// Note: this type is marked as 'beforefieldinit'.
			static OpenVoiceSettingsHandler()
			{
				Il2CppClassPointerStore<OverlayManager.OpenVoiceSettingsHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "OpenVoiceSettingsHandler");
				OverlayManager.OpenVoiceSettingsHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenVoiceSettingsHandler>.NativeClassPtr, 100668221);
				OverlayManager.OpenVoiceSettingsHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenVoiceSettingsHandler>.NativeClassPtr, 100668222);
				OverlayManager.OpenVoiceSettingsHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenVoiceSettingsHandler>.NativeClassPtr, 100668223);
				OverlayManager.OpenVoiceSettingsHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.OpenVoiceSettingsHandler>.NativeClassPtr, 100668224);
			}

			// Token: 0x06002082 RID: 8322 RVA: 0x00095860 File Offset: 0x00093A60
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenVoiceSettingsHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.OpenVoiceSettingsHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenVoiceSettingsHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002083 RID: 8323 RVA: 0x000958BC File Offset: 0x00093ABC
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenVoiceSettingsHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002084 RID: 8324 RVA: 0x00095900 File Offset: 0x00093B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54530, XrefRangeEnd = 54534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenVoiceSettingsHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002085 RID: 8325 RVA: 0x00095974 File Offset: 0x00093B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.OpenVoiceSettingsHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002086 RID: 8326 RVA: 0x0000D6BB File Offset: 0x0000B8BB
			public OpenVoiceSettingsHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002087 RID: 8327 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
			public static implicit operator OverlayManager.OpenVoiceSettingsHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<OverlayManager.OpenVoiceSettingsHandler>(A_0);
			}

			// Token: 0x06002088 RID: 8328 RVA: 0x0000D6CC File Offset: 0x0000B8CC
			public static OverlayManager.OpenVoiceSettingsHandler operator +(OverlayManager.OpenVoiceSettingsHandler A_0, OverlayManager.OpenVoiceSettingsHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OverlayManager.OpenVoiceSettingsHandler>();
			}

			// Token: 0x06002089 RID: 8329 RVA: 0x0000D6DA File Offset: 0x0000B8DA
			public static OverlayManager.OpenVoiceSettingsHandler operator -(OverlayManager.OpenVoiceSettingsHandler A_0, OverlayManager.OpenVoiceSettingsHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OverlayManager.OpenVoiceSettingsHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001916 RID: 6422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001917 RID: 6423
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x04001918 RID: 6424
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x04001919 RID: 6425
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000234 RID: 564
		public sealed class SetImeCompositionRangeCallbackHandler : MulticastDelegate
		{
			// Token: 0x0600208A RID: 8330 RVA: 0x000959B8 File Offset: 0x00093BB8
			// Note: this type is marked as 'beforefieldinit'.
			static SetImeCompositionRangeCallbackHandler()
			{
				Il2CppClassPointerStore<OverlayManager.SetImeCompositionRangeCallbackHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "SetImeCompositionRangeCallbackHandler");
				OverlayManager.SetImeCompositionRangeCallbackHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetImeCompositionRangeCallbackHandler>.NativeClassPtr, 100668225);
				OverlayManager.SetImeCompositionRangeCallbackHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetImeCompositionRangeCallbackHandler>.NativeClassPtr, 100668226);
				OverlayManager.SetImeCompositionRangeCallbackHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Int32_byref_Rect_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetImeCompositionRangeCallbackHandler>.NativeClassPtr, 100668227);
				OverlayManager.SetImeCompositionRangeCallbackHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Rect_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetImeCompositionRangeCallbackHandler>.NativeClassPtr, 100668228);
			}

			// Token: 0x0600208B RID: 8331 RVA: 0x00095A2C File Offset: 0x00093C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54534, XrefRangeEnd = 54537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetImeCompositionRangeCallbackHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.SetImeCompositionRangeCallbackHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetImeCompositionRangeCallbackHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600208C RID: 8332 RVA: 0x00095A88 File Offset: 0x00093C88
			[CallerCount(0)]
			public unsafe void Invoke(int from, int to, ref Rect bounds)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref from;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetImeCompositionRangeCallbackHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Int32_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600208D RID: 8333 RVA: 0x00095AE4 File Offset: 0x00093CE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54537, XrefRangeEnd = 54545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int from, int to, ref Rect bounds, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref from;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetImeCompositionRangeCallbackHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Int32_byref_Rect_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600208E RID: 8334 RVA: 0x00095B74 File Offset: 0x00093D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref Rect bounds, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &bounds;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetImeCompositionRangeCallbackHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Rect_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600208F RID: 8335 RVA: 0x0000D6EB File Offset: 0x0000B8EB
			public SetImeCompositionRangeCallbackHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400191A RID: 6426
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400191B RID: 6427
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Int32_byref_Rect_0;

			// Token: 0x0400191C RID: 6428
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Int32_byref_Rect_AsyncCallback_Object_0;

			// Token: 0x0400191D RID: 6429
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Rect_IAsyncResult_0;
		}

		// Token: 0x02000235 RID: 565
		public sealed class SetImeSelectionBoundsCallbackHandler : MulticastDelegate
		{
			// Token: 0x06002090 RID: 8336 RVA: 0x00095BC4 File Offset: 0x00093DC4
			// Note: this type is marked as 'beforefieldinit'.
			static SetImeSelectionBoundsCallbackHandler()
			{
				Il2CppClassPointerStore<OverlayManager.SetImeSelectionBoundsCallbackHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "SetImeSelectionBoundsCallbackHandler");
				OverlayManager.SetImeSelectionBoundsCallbackHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetImeSelectionBoundsCallbackHandler>.NativeClassPtr, 100668229);
				OverlayManager.SetImeSelectionBoundsCallbackHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Rect_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetImeSelectionBoundsCallbackHandler>.NativeClassPtr, 100668230);
				OverlayManager.SetImeSelectionBoundsCallbackHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Rect_Rect_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetImeSelectionBoundsCallbackHandler>.NativeClassPtr, 100668231);
				OverlayManager.SetImeSelectionBoundsCallbackHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.SetImeSelectionBoundsCallbackHandler>.NativeClassPtr, 100668232);
			}

			// Token: 0x06002091 RID: 8337 RVA: 0x00095C38 File Offset: 0x00093E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54545, XrefRangeEnd = 54548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetImeSelectionBoundsCallbackHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.SetImeSelectionBoundsCallbackHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetImeSelectionBoundsCallbackHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002092 RID: 8338 RVA: 0x00095C94 File Offset: 0x00093E94
			[CallerCount(0)]
			public unsafe void Invoke(Rect anchor, Rect focus, bool isAnchorFirst)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(anchor);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focus);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAnchorFirst;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetImeSelectionBoundsCallbackHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Rect_Rect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002093 RID: 8339 RVA: 0x00095CF8 File Offset: 0x00093EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54548, XrefRangeEnd = 54556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Rect anchor, Rect focus, bool isAnchorFirst, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(anchor);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focus);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAnchorFirst;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetImeSelectionBoundsCallbackHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Rect_Rect_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002094 RID: 8340 RVA: 0x00095D90 File Offset: 0x00093F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.SetImeSelectionBoundsCallbackHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002095 RID: 8341 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
			public SetImeSelectionBoundsCallbackHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002096 RID: 8342 RVA: 0x0000D6FD File Offset: 0x0000B8FD
			public static implicit operator OverlayManager.SetImeSelectionBoundsCallbackHandler(Action<Rect, Rect, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<OverlayManager.SetImeSelectionBoundsCallbackHandler>(A_0);
			}

			// Token: 0x06002097 RID: 8343 RVA: 0x0000D705 File Offset: 0x0000B905
			public static OverlayManager.SetImeSelectionBoundsCallbackHandler operator +(OverlayManager.SetImeSelectionBoundsCallbackHandler A_0, OverlayManager.SetImeSelectionBoundsCallbackHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OverlayManager.SetImeSelectionBoundsCallbackHandler>();
			}

			// Token: 0x06002098 RID: 8344 RVA: 0x0000D713 File Offset: 0x0000B913
			public static OverlayManager.SetImeSelectionBoundsCallbackHandler operator -(OverlayManager.SetImeSelectionBoundsCallbackHandler A_0, OverlayManager.SetImeSelectionBoundsCallbackHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OverlayManager.SetImeSelectionBoundsCallbackHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400191E RID: 6430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400191F RID: 6431
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Rect_Rect_Boolean_0;

			// Token: 0x04001920 RID: 6432
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Rect_Rect_Boolean_AsyncCallback_Object_0;

			// Token: 0x04001921 RID: 6433
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000236 RID: 566
		public sealed class ToggleHandler : MulticastDelegate
		{
			// Token: 0x06002099 RID: 8345 RVA: 0x00095DD4 File Offset: 0x00093FD4
			// Note: this type is marked as 'beforefieldinit'.
			static ToggleHandler()
			{
				Il2CppClassPointerStore<OverlayManager.ToggleHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverlayManager>.NativeClassPtr, "ToggleHandler");
				OverlayManager.ToggleHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.ToggleHandler>.NativeClassPtr, 100668233);
				OverlayManager.ToggleHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.ToggleHandler>.NativeClassPtr, 100668234);
				OverlayManager.ToggleHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.ToggleHandler>.NativeClassPtr, 100668235);
				OverlayManager.ToggleHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlayManager.ToggleHandler>.NativeClassPtr, 100668236);
			}

			// Token: 0x0600209A RID: 8346 RVA: 0x00095E48 File Offset: 0x00094048
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 54559, RefRangeEnd = 54579, XrefRangeStart = 54556, XrefRangeEnd = 54559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToggleHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlayManager.ToggleHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.ToggleHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600209B RID: 8347 RVA: 0x00095EA4 File Offset: 0x000940A4
			[CallerCount(0)]
			public unsafe void Invoke(bool locked)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref locked;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.ToggleHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600209C RID: 8348 RVA: 0x00095EE4 File Offset: 0x000940E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54579, XrefRangeEnd = 54582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool locked, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref locked;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.ToggleHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600209D RID: 8349 RVA: 0x00095F54 File Offset: 0x00094154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverlayManager.ToggleHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600209E RID: 8350 RVA: 0x0000D724 File Offset: 0x0000B924
			public ToggleHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600209F RID: 8351 RVA: 0x0000D72D File Offset: 0x0000B92D
			public static implicit operator OverlayManager.ToggleHandler(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<OverlayManager.ToggleHandler>(A_0);
			}

			// Token: 0x060020A0 RID: 8352 RVA: 0x0000D735 File Offset: 0x0000B935
			public static OverlayManager.ToggleHandler operator +(OverlayManager.ToggleHandler A_0, OverlayManager.ToggleHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OverlayManager.ToggleHandler>();
			}

			// Token: 0x060020A1 RID: 8353 RVA: 0x0000D743 File Offset: 0x0000B943
			public static OverlayManager.ToggleHandler operator -(OverlayManager.ToggleHandler A_0, OverlayManager.ToggleHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OverlayManager.ToggleHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001922 RID: 6434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001923 RID: 6435
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x04001924 RID: 6436
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x04001925 RID: 6437
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
