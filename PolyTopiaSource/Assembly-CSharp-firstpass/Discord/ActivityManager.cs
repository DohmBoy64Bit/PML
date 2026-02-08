using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000129 RID: 297
	public class ActivityManager : Object
	{
		// Token: 0x060015C3 RID: 5571 RVA: 0x000711A8 File Offset: 0x0006F3A8
		// Note: this type is marked as 'beforefieldinit'.
		static ActivityManager()
		{
			Il2CppClassPointerStore<ActivityManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ActivityManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr);
			ActivityManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "MethodsPtr");
			ActivityManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "MethodsStructure");
			ActivityManager.NativeFieldInfoPtr_OnActivityJoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "OnActivityJoin");
			ActivityManager.NativeFieldInfoPtr_OnActivitySpectate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "OnActivitySpectate");
			ActivityManager.NativeFieldInfoPtr_OnActivityJoinRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "OnActivityJoinRequest");
			ActivityManager.NativeFieldInfoPtr_OnActivityInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "OnActivityInvite");
			ActivityManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667188);
			ActivityManager.NativeMethodInfoPtr_add_OnActivityJoin_Public_add_Void_ActivityJoinHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667189);
			ActivityManager.NativeMethodInfoPtr_remove_OnActivityJoin_Public_rem_Void_ActivityJoinHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667190);
			ActivityManager.NativeMethodInfoPtr_add_OnActivitySpectate_Public_add_Void_ActivitySpectateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667191);
			ActivityManager.NativeMethodInfoPtr_remove_OnActivitySpectate_Public_rem_Void_ActivitySpectateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667192);
			ActivityManager.NativeMethodInfoPtr_add_OnActivityJoinRequest_Public_add_Void_ActivityJoinRequestHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667193);
			ActivityManager.NativeMethodInfoPtr_remove_OnActivityJoinRequest_Public_rem_Void_ActivityJoinRequestHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667194);
			ActivityManager.NativeMethodInfoPtr_add_OnActivityInvite_Public_add_Void_ActivityInviteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667195);
			ActivityManager.NativeMethodInfoPtr_remove_OnActivityInvite_Public_rem_Void_ActivityInviteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667196);
			ActivityManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667197);
			ActivityManager.NativeMethodInfoPtr_RegisterCommand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667187);
			ActivityManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667198);
			ActivityManager.NativeMethodInfoPtr_RegisterCommand_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667199);
			ActivityManager.NativeMethodInfoPtr_RegisterSteam_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667200);
			ActivityManager.NativeMethodInfoPtr_UpdateActivityCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667201);
			ActivityManager.NativeMethodInfoPtr_UpdateActivity_Public_Void_Activity_UpdateActivityHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667202);
			ActivityManager.NativeMethodInfoPtr_ClearActivityCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667203);
			ActivityManager.NativeMethodInfoPtr_ClearActivity_Public_Void_ClearActivityHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667204);
			ActivityManager.NativeMethodInfoPtr_SendRequestReplyCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667205);
			ActivityManager.NativeMethodInfoPtr_SendRequestReply_Public_Void_Int64_ActivityJoinRequestReply_SendRequestReplyHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667206);
			ActivityManager.NativeMethodInfoPtr_SendInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667207);
			ActivityManager.NativeMethodInfoPtr_SendInvite_Public_Void_Int64_ActivityActionType_String_SendInviteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667208);
			ActivityManager.NativeMethodInfoPtr_AcceptInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667209);
			ActivityManager.NativeMethodInfoPtr_AcceptInvite_Public_Void_Int64_AcceptInviteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667210);
			ActivityManager.NativeMethodInfoPtr_OnActivityJoinImpl_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667211);
			ActivityManager.NativeMethodInfoPtr_OnActivitySpectateImpl_Private_Static_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667212);
			ActivityManager.NativeMethodInfoPtr_OnActivityJoinRequestImpl_Private_Static_Void_IntPtr_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667213);
			ActivityManager.NativeMethodInfoPtr_OnActivityInviteImpl_Private_Static_Void_IntPtr_ActivityActionType_byref_User_byref_Activity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, 100667214);
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00071480 File Offset: 0x0006F680
		public unsafe ActivityManager.FFIMethods Methods
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 51950, RefRangeEnd = 51958, XrefRangeStart = 51937, XrefRangeEnd = 51950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ActivityManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x000714B8 File Offset: 0x0006F6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51958, XrefRangeEnd = 51962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnActivityJoin(ActivityManager.ActivityJoinHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_add_OnActivityJoin_Public_add_Void_ActivityJoinHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000714FC File Offset: 0x0006F6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51962, XrefRangeEnd = 51966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnActivityJoin(ActivityManager.ActivityJoinHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_remove_OnActivityJoin_Public_rem_Void_ActivityJoinHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00071540 File Offset: 0x0006F740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51966, XrefRangeEnd = 51970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnActivitySpectate(ActivityManager.ActivitySpectateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_add_OnActivitySpectate_Public_add_Void_ActivitySpectateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00071584 File Offset: 0x0006F784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51970, XrefRangeEnd = 51974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnActivitySpectate(ActivityManager.ActivitySpectateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_remove_OnActivitySpectate_Public_rem_Void_ActivitySpectateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000715C8 File Offset: 0x0006F7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51974, XrefRangeEnd = 51978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnActivityJoinRequest(ActivityManager.ActivityJoinRequestHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_add_OnActivityJoinRequest_Public_add_Void_ActivityJoinRequestHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0007160C File Offset: 0x0006F80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51978, XrefRangeEnd = 51982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnActivityJoinRequest(ActivityManager.ActivityJoinRequestHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_remove_OnActivityJoinRequest_Public_rem_Void_ActivityJoinRequestHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00071650 File Offset: 0x0006F850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51982, XrefRangeEnd = 51986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnActivityInvite(ActivityManager.ActivityInviteHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_add_OnActivityInvite_Public_add_Void_ActivityInviteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00071694 File Offset: 0x0006F894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51986, XrefRangeEnd = 51990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnActivityInvite(ActivityManager.ActivityInviteHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_remove_OnActivityInvite_Public_rem_Void_ActivityInviteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x000716D8 File Offset: 0x0006F8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51990, XrefRangeEnd = 51992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityManager(IntPtr ptr, IntPtr eventsPtr, ref ActivityManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00071740 File Offset: 0x0006F940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51992, XrefRangeEnd = 51993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_RegisterCommand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00071774 File Offset: 0x0006F974
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52035, RefRangeEnd = 52037, XrefRangeStart = 51993, XrefRangeEnd = 52035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref ActivityManager.FFIEvents events)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x000717C8 File Offset: 0x0006F9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52037, XrefRangeEnd = 52038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCommand(string command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_RegisterCommand_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0007180C File Offset: 0x0006FA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52038, XrefRangeEnd = 52039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSteam(uint steamId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_RegisterSteam_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0007184C File Offset: 0x0006FA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52039, XrefRangeEnd = 52046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateActivityCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_UpdateActivityCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00071890 File Offset: 0x0006FA90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52057, RefRangeEnd = 52058, XrefRangeStart = 52046, XrefRangeEnd = 52057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActivity(Activity activity, ActivityManager.UpdateActivityHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_UpdateActivity_Public_Void_Activity_UpdateActivityHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000718E4 File Offset: 0x0006FAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52058, XrefRangeEnd = 52065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearActivityCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_ClearActivityCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00071928 File Offset: 0x0006FB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52065, XrefRangeEnd = 52076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearActivity(ActivityManager.ClearActivityHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_ClearActivity_Public_Void_ClearActivityHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0007196C File Offset: 0x0006FB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52076, XrefRangeEnd = 52083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_SendRequestReplyCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000719B0 File Offset: 0x0006FBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52083, XrefRangeEnd = 52094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRequestReply(long userId, ActivityJoinRequestReply reply, ActivityManager.SendRequestReplyHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reply);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_SendRequestReply_Public_Void_Int64_ActivityJoinRequestReply_SendRequestReplyHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00071A14 File Offset: 0x0006FC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52094, XrefRangeEnd = 52101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendInviteCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_SendInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00071A58 File Offset: 0x0006FC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52101, XrefRangeEnd = 52112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendInvite(long userId, ActivityActionType type, string content, ActivityManager.SendInviteHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_SendInvite_Public_Void_Int64_ActivityActionType_String_SendInviteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00071AD0 File Offset: 0x0006FCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52112, XrefRangeEnd = 52119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AcceptInviteCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_AcceptInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00071B14 File Offset: 0x0006FD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52119, XrefRangeEnd = 52130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcceptInvite(long userId, ActivityManager.AcceptInviteHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_AcceptInvite_Public_Void_Int64_AcceptInviteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00071B64 File Offset: 0x0006FD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52130, XrefRangeEnd = 52136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActivityJoinImpl(IntPtr ptr, string secret)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secret);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_OnActivityJoinImpl_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00071BA8 File Offset: 0x0006FDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52136, XrefRangeEnd = 52142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActivitySpectateImpl(IntPtr ptr, string secret)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secret);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_OnActivitySpectateImpl_Private_Static_Void_IntPtr_String_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00071BEC File Offset: 0x0006FDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52142, XrefRangeEnd = 52148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_OnActivityJoinRequestImpl_Private_Static_Void_IntPtr_byref_User_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			user = ((intPtr4 == 0) ? null : new User(intPtr4));
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00071C48 File Offset: 0x0006FE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52148, XrefRangeEnd = 52154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
			ptr3 = &intPtr;
			ref IntPtr ptr4 = ref ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(activity);
			ptr4 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.NativeMethodInfoPtr_OnActivityInviteImpl_Private_Static_Void_IntPtr_ActivityActionType_byref_User_byref_Activity_0, 0, (void**)ptr2, ref intPtr4);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			user = ((intPtr5 == 0) ? null : new User(intPtr5));
			IntPtr intPtr6 = intPtr2;
			activity = ((intPtr6 == 0) ? null : new Activity(intPtr6));
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0000855D File Offset: 0x0000675D
		public ActivityManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00071CDC File Offset: 0x0006FEDC
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x00008566 File Offset: 0x00006766
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00071D04 File Offset: 0x0006FF04
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00008581 File Offset: 0x00006781
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00071D34 File Offset: 0x0006FF34
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x000085A0 File Offset: 0x000067A0
		public unsafe ActivityManager.ActivityJoinHandler OnActivityJoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_OnActivityJoin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.ActivityJoinHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_OnActivityJoin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x00071D64 File Offset: 0x0006FF64
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x000085BF File Offset: 0x000067BF
		public unsafe ActivityManager.ActivitySpectateHandler OnActivitySpectate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_OnActivitySpectate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.ActivitySpectateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_OnActivitySpectate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x00071D94 File Offset: 0x0006FF94
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x000085DE File Offset: 0x000067DE
		public unsafe ActivityManager.ActivityJoinRequestHandler OnActivityJoinRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_OnActivityJoinRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.ActivityJoinRequestHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_OnActivityJoinRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00071DC4 File Offset: 0x0006FFC4
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x000085FD File Offset: 0x000067FD
		public unsafe ActivityManager.ActivityInviteHandler OnActivityInvite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_OnActivityInvite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.ActivityInviteHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.NativeFieldInfoPtr_OnActivityInvite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeFieldInfoPtr_OnActivityJoin;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeFieldInfoPtr_OnActivitySpectate;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeFieldInfoPtr_OnActivityJoinRequest;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeFieldInfoPtr_OnActivityInvite;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_add_OnActivityJoin_Public_add_Void_ActivityJoinHandler_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnActivityJoin_Public_rem_Void_ActivityJoinHandler_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_add_OnActivitySpectate_Public_add_Void_ActivitySpectateHandler_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnActivitySpectate_Public_rem_Void_ActivitySpectateHandler_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_add_OnActivityJoinRequest_Public_add_Void_ActivityJoinRequestHandler_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnActivityJoinRequest_Public_rem_Void_ActivityJoinRequestHandler_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_add_OnActivityInvite_Public_add_Void_ActivityInviteHandler_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnActivityInvite_Public_rem_Void_ActivityInviteHandler_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCommand_Public_Void_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCommand_Public_Void_String_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSteam_Public_Void_UInt32_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActivityCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActivity_Public_Void_Activity_UpdateActivityHandler_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_ClearActivityCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_ClearActivity_Public_Void_ClearActivityHandler_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_SendRequestReplyCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_SendRequestReply_Public_Void_Int64_ActivityJoinRequestReply_SendRequestReplyHandler_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_SendInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_SendInvite_Public_Void_Int64_ActivityActionType_String_SendInviteHandler_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_AcceptInviteCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_AcceptInvite_Public_Void_Int64_AcceptInviteHandler_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_OnActivityJoinImpl_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_OnActivitySpectateImpl_Private_Static_Void_IntPtr_String_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_OnActivityJoinRequestImpl_Private_Static_Void_IntPtr_byref_User_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_OnActivityInviteImpl_Private_Static_Void_IntPtr_ActivityActionType_byref_User_byref_Activity_0;

		// Token: 0x020001F2 RID: 498
		public sealed class FFIEvents : ValueType
		{
			// Token: 0x06001DDE RID: 7646 RVA: 0x0008DD84 File Offset: 0x0008BF84
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr);
				ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivityJoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, "OnActivityJoin");
				ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivitySpectate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, "OnActivitySpectate");
				ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivityJoinRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, "OnActivityJoinRequest");
				ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivityInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, "OnActivityInvite");
			}

			// Token: 0x06001DDF RID: 7647 RVA: 0x0000BDBB File Offset: 0x00009FBB
			public FFIEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001DE0 RID: 7648 RVA: 0x0000BDC4 File Offset: 0x00009FC4
			public FFIEvents()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr))
			{
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0008DE00 File Offset: 0x0008C000
			// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0000BDD6 File Offset: 0x00009FD6
			public unsafe ActivityManager.FFIEvents.ActivityJoinHandler OnActivityJoin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivityJoin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIEvents.ActivityJoinHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivityJoin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x0008DE30 File Offset: 0x0008C030
			// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0000BDF5 File Offset: 0x00009FF5
			public unsafe ActivityManager.FFIEvents.ActivitySpectateHandler OnActivitySpectate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivitySpectate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIEvents.ActivitySpectateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivitySpectate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EB RID: 1771
			// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x0008DE60 File Offset: 0x0008C060
			// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x0000BE14 File Offset: 0x0000A014
			public unsafe ActivityManager.FFIEvents.ActivityJoinRequestHandler OnActivityJoinRequest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivityJoinRequest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIEvents.ActivityJoinRequestHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivityJoinRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EC RID: 1772
			// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0008DE90 File Offset: 0x0008C090
			// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0000BE33 File Offset: 0x0000A033
			public unsafe ActivityManager.FFIEvents.ActivityInviteHandler OnActivityInvite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivityInvite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIEvents.ActivityInviteHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIEvents.NativeFieldInfoPtr_OnActivityInvite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017B2 RID: 6066
			private static readonly IntPtr NativeFieldInfoPtr_OnActivityJoin;

			// Token: 0x040017B3 RID: 6067
			private static readonly IntPtr NativeFieldInfoPtr_OnActivitySpectate;

			// Token: 0x040017B4 RID: 6068
			private static readonly IntPtr NativeFieldInfoPtr_OnActivityJoinRequest;

			// Token: 0x040017B5 RID: 6069
			private static readonly IntPtr NativeFieldInfoPtr_OnActivityInvite;

			// Token: 0x02000251 RID: 593
			public sealed class ActivityJoinHandler : MulticastDelegate
			{
				// Token: 0x06002182 RID: 8578 RVA: 0x000983C8 File Offset: 0x000965C8
				// Note: this type is marked as 'beforefieldinit'.
				static ActivityJoinHandler()
				{
					Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, "ActivityJoinHandler");
					ActivityManager.FFIEvents.ActivityJoinHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinHandler>.NativeClassPtr, 100667215);
					ActivityManager.FFIEvents.ActivityJoinHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinHandler>.NativeClassPtr, 100667216);
					ActivityManager.FFIEvents.ActivityJoinHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinHandler>.NativeClassPtr, 100667217);
					ActivityManager.FFIEvents.ActivityJoinHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinHandler>.NativeClassPtr, 100667218);
				}

				// Token: 0x06002183 RID: 8579 RVA: 0x0009843C File Offset: 0x0009663C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51731, XrefRangeEnd = 51734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ActivityJoinHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityJoinHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002184 RID: 8580 RVA: 0x00098498 File Offset: 0x00096698
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, string secret)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secret);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityJoinHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002185 RID: 8581 RVA: 0x000984E8 File Offset: 0x000966E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51734, XrefRangeEnd = 51737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, string secret, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secret);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityJoinHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002186 RID: 8582 RVA: 0x0009856C File Offset: 0x0009676C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityJoinHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002187 RID: 8583 RVA: 0x0000E039 File Offset: 0x0000C239
				public ActivityJoinHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002188 RID: 8584 RVA: 0x0000E042 File Offset: 0x0000C242
				public static implicit operator ActivityManager.FFIEvents.ActivityJoinHandler(Action<IntPtr, string> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIEvents.ActivityJoinHandler>(A_0);
				}

				// Token: 0x06002189 RID: 8585 RVA: 0x0000E04A File Offset: 0x0000C24A
				public static ActivityManager.FFIEvents.ActivityJoinHandler operator +(ActivityManager.FFIEvents.ActivityJoinHandler A_0, ActivityManager.FFIEvents.ActivityJoinHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIEvents.ActivityJoinHandler>();
				}

				// Token: 0x0600218A RID: 8586 RVA: 0x0000E058 File Offset: 0x0000C258
				public static ActivityManager.FFIEvents.ActivityJoinHandler operator -(ActivityManager.FFIEvents.ActivityJoinHandler A_0, ActivityManager.FFIEvents.ActivityJoinHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIEvents.ActivityJoinHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001989 RID: 6537
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400198A RID: 6538
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0;

				// Token: 0x0400198B RID: 6539
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0;

				// Token: 0x0400198C RID: 6540
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000252 RID: 594
			public sealed class ActivitySpectateHandler : MulticastDelegate
			{
				// Token: 0x0600218B RID: 8587 RVA: 0x000985B0 File Offset: 0x000967B0
				// Note: this type is marked as 'beforefieldinit'.
				static ActivitySpectateHandler()
				{
					Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivitySpectateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, "ActivitySpectateHandler");
					ActivityManager.FFIEvents.ActivitySpectateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivitySpectateHandler>.NativeClassPtr, 100667219);
					ActivityManager.FFIEvents.ActivitySpectateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivitySpectateHandler>.NativeClassPtr, 100667220);
					ActivityManager.FFIEvents.ActivitySpectateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivitySpectateHandler>.NativeClassPtr, 100667221);
					ActivityManager.FFIEvents.ActivitySpectateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivitySpectateHandler>.NativeClassPtr, 100667222);
				}

				// Token: 0x0600218C RID: 8588 RVA: 0x00098624 File Offset: 0x00096824
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ActivitySpectateHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivitySpectateHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivitySpectateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600218D RID: 8589 RVA: 0x00098680 File Offset: 0x00096880
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, string secret)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secret);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivitySpectateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600218E RID: 8590 RVA: 0x000986D0 File Offset: 0x000968D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, string secret, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secret);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivitySpectateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600218F RID: 8591 RVA: 0x00098754 File Offset: 0x00096954
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivitySpectateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002190 RID: 8592 RVA: 0x0000E069 File Offset: 0x0000C269
				public ActivitySpectateHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002191 RID: 8593 RVA: 0x0000E072 File Offset: 0x0000C272
				public static implicit operator ActivityManager.FFIEvents.ActivitySpectateHandler(Action<IntPtr, string> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIEvents.ActivitySpectateHandler>(A_0);
				}

				// Token: 0x06002192 RID: 8594 RVA: 0x0000E07A File Offset: 0x0000C27A
				public static ActivityManager.FFIEvents.ActivitySpectateHandler operator +(ActivityManager.FFIEvents.ActivitySpectateHandler A_0, ActivityManager.FFIEvents.ActivitySpectateHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIEvents.ActivitySpectateHandler>();
				}

				// Token: 0x06002193 RID: 8595 RVA: 0x0000E088 File Offset: 0x0000C288
				public static ActivityManager.FFIEvents.ActivitySpectateHandler operator -(ActivityManager.FFIEvents.ActivitySpectateHandler A_0, ActivityManager.FFIEvents.ActivitySpectateHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIEvents.ActivitySpectateHandler>();
					}
					return delegate2;
				}

				// Token: 0x0400198D RID: 6541
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400198E RID: 6542
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_0;

				// Token: 0x0400198F RID: 6543
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0;

				// Token: 0x04001990 RID: 6544
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000253 RID: 595
			public sealed class ActivityJoinRequestHandler : MulticastDelegate
			{
				// Token: 0x06002194 RID: 8596 RVA: 0x00098798 File Offset: 0x00096998
				// Note: this type is marked as 'beforefieldinit'.
				static ActivityJoinRequestHandler()
				{
					Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinRequestHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, "ActivityJoinRequestHandler");
					ActivityManager.FFIEvents.ActivityJoinRequestHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinRequestHandler>.NativeClassPtr, 100667223);
					ActivityManager.FFIEvents.ActivityJoinRequestHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinRequestHandler>.NativeClassPtr, 100667224);
					ActivityManager.FFIEvents.ActivityJoinRequestHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_User_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinRequestHandler>.NativeClassPtr, 100667225);
					ActivityManager.FFIEvents.ActivityJoinRequestHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinRequestHandler>.NativeClassPtr, 100667226);
				}

				// Token: 0x06002195 RID: 8597 RVA: 0x0009880C File Offset: 0x00096A0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ActivityJoinRequestHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityJoinRequestHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityJoinRequestHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002196 RID: 8598 RVA: 0x00098868 File Offset: 0x00096A68
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, ref User user)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityJoinRequestHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
				}

				// Token: 0x06002197 RID: 8599 RVA: 0x000988D0 File Offset: 0x00096AD0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51737, XrefRangeEnd = 51743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, ref User user, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityJoinRequestHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_User_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002198 RID: 8600 RVA: 0x0009896C File Offset: 0x00096B6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51743, XrefRangeEnd = 51744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref User user, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityJoinRequestHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
				}

				// Token: 0x06002199 RID: 8601 RVA: 0x0000E099 File Offset: 0x0000C299
				public ActivityJoinRequestHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001991 RID: 6545
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001992 RID: 6546
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_User_0;

				// Token: 0x04001993 RID: 6547
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_User_AsyncCallback_Object_0;

				// Token: 0x04001994 RID: 6548
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0;
			}

			// Token: 0x02000254 RID: 596
			public sealed class ActivityInviteHandler : MulticastDelegate
			{
				// Token: 0x0600219A RID: 8602 RVA: 0x000989D8 File Offset: 0x00096BD8
				// Note: this type is marked as 'beforefieldinit'.
				static ActivityInviteHandler()
				{
					Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityInviteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, "ActivityInviteHandler");
					ActivityManager.FFIEvents.ActivityInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityInviteHandler>.NativeClassPtr, 100667227);
					ActivityManager.FFIEvents.ActivityInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_ActivityActionType_byref_User_byref_Activity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityInviteHandler>.NativeClassPtr, 100667228);
					ActivityManager.FFIEvents.ActivityInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ActivityActionType_byref_User_byref_Activity_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityInviteHandler>.NativeClassPtr, 100667229);
					ActivityManager.FFIEvents.ActivityInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_byref_Activity_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityInviteHandler>.NativeClassPtr, 100667230);
				}

				// Token: 0x0600219B RID: 8603 RVA: 0x00098A4C File Offset: 0x00096C4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51744, XrefRangeEnd = 51747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ActivityInviteHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIEvents.ActivityInviteHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600219C RID: 8604 RVA: 0x00098AA8 File Offset: 0x00096CA8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr3 = &intPtr;
					ref IntPtr ptr4 = ref ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(activity);
					ptr4 = &intPtr2;
					IntPtr intPtr4;
					IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_ActivityActionType_byref_User_byref_Activity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr4);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
					IntPtr intPtr5 = intPtr;
					user = ((intPtr5 == 0) ? null : new User(intPtr5));
					IntPtr intPtr6 = intPtr2;
					activity = ((intPtr6 == 0) ? null : new Activity(intPtr6));
				}

				// Token: 0x0600219D RID: 8605 RVA: 0x00098B4C File Offset: 0x00096D4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51747, XrefRangeEnd = 51759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr3 = &intPtr;
					ref IntPtr ptr4 = ref ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(activity);
					ptr4 = &intPtr2;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr4;
					IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ActivityActionType_byref_User_byref_Activity_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr4);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
					IntPtr intPtr5 = intPtr;
					user = ((intPtr5 == 0) ? null : new User(intPtr5));
					IntPtr intPtr6 = intPtr2;
					activity = ((intPtr6 == 0) ? null : new Activity(intPtr6));
					IntPtr intPtr7 = intPtr3;
					return (intPtr7 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr7) : null;
				}

				// Token: 0x0600219E RID: 8606 RVA: 0x00098C24 File Offset: 0x00096E24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51759, XrefRangeEnd = 51760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref User user, ref Activity activity, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
						ptr2 = &intPtr;
					}
					ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(activity);
					ptr3 = &intPtr2;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr4;
					IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIEvents.ActivityInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_byref_Activity_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
					IntPtr intPtr5 = intPtr;
					user = ((intPtr5 == 0) ? null : new User(intPtr5));
					IntPtr intPtr6 = intPtr2;
					activity = ((intPtr6 == 0) ? null : new Activity(intPtr6));
				}

				// Token: 0x0600219F RID: 8607 RVA: 0x0000E0A2 File Offset: 0x0000C2A2
				public ActivityInviteHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001995 RID: 6549
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001996 RID: 6550
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_ActivityActionType_byref_User_byref_Activity_0;

				// Token: 0x04001997 RID: 6551
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_ActivityActionType_byref_User_byref_Activity_AsyncCallback_Object_0;

				// Token: 0x04001998 RID: 6552
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_byref_Activity_IAsyncResult_0;
			}
		}

		// Token: 0x020001F3 RID: 499
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001DE9 RID: 7657 RVA: 0x0008DEC0 File Offset: 0x0008C0C0
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr);
				ActivityManager.FFIMethods.NativeFieldInfoPtr_RegisterCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "RegisterCommand");
				ActivityManager.FFIMethods.NativeFieldInfoPtr_RegisterSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "RegisterSteam");
				ActivityManager.FFIMethods.NativeFieldInfoPtr_UpdateActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "UpdateActivity");
				ActivityManager.FFIMethods.NativeFieldInfoPtr_ClearActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "ClearActivity");
				ActivityManager.FFIMethods.NativeFieldInfoPtr_SendRequestReply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "SendRequestReply");
				ActivityManager.FFIMethods.NativeFieldInfoPtr_SendInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "SendInvite");
				ActivityManager.FFIMethods.NativeFieldInfoPtr_AcceptInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "AcceptInvite");
			}

			// Token: 0x06001DEA RID: 7658 RVA: 0x0000BE52 File Offset: 0x0000A052
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001DEB RID: 7659 RVA: 0x0000BE5B File Offset: 0x0000A05B
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0008DF78 File Offset: 0x0008C178
			// (set) Token: 0x06001DED RID: 7661 RVA: 0x0000BE6D File Offset: 0x0000A06D
			public unsafe ActivityManager.FFIMethods.RegisterCommandMethod RegisterCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_RegisterCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIMethods.RegisterCommandMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_RegisterCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0008DFA8 File Offset: 0x0008C1A8
			// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0000BE8C File Offset: 0x0000A08C
			public unsafe ActivityManager.FFIMethods.RegisterSteamMethod RegisterSteam
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_RegisterSteam);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIMethods.RegisterSteamMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_RegisterSteam), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0008DFD8 File Offset: 0x0008C1D8
			// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0000BEAB File Offset: 0x0000A0AB
			public unsafe ActivityManager.FFIMethods.UpdateActivityMethod UpdateActivity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_UpdateActivity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIMethods.UpdateActivityMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_UpdateActivity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0008E008 File Offset: 0x0008C208
			// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0000BECA File Offset: 0x0000A0CA
			public unsafe ActivityManager.FFIMethods.ClearActivityMethod ClearActivity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_ClearActivity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIMethods.ClearActivityMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_ClearActivity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x0008E038 File Offset: 0x0008C238
			// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x0000BEE9 File Offset: 0x0000A0E9
			public unsafe ActivityManager.FFIMethods.SendRequestReplyMethod SendRequestReply
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_SendRequestReply);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIMethods.SendRequestReplyMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_SendRequestReply), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x0008E068 File Offset: 0x0008C268
			// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x0000BF08 File Offset: 0x0000A108
			public unsafe ActivityManager.FFIMethods.SendInviteMethod SendInvite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_SendInvite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIMethods.SendInviteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_SendInvite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x0008E098 File Offset: 0x0008C298
			// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x0000BF27 File Offset: 0x0000A127
			public unsafe ActivityManager.FFIMethods.AcceptInviteMethod AcceptInvite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_AcceptInvite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.FFIMethods.AcceptInviteMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityManager.FFIMethods.NativeFieldInfoPtr_AcceptInvite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017B6 RID: 6070
			private static readonly IntPtr NativeFieldInfoPtr_RegisterCommand;

			// Token: 0x040017B7 RID: 6071
			private static readonly IntPtr NativeFieldInfoPtr_RegisterSteam;

			// Token: 0x040017B8 RID: 6072
			private static readonly IntPtr NativeFieldInfoPtr_UpdateActivity;

			// Token: 0x040017B9 RID: 6073
			private static readonly IntPtr NativeFieldInfoPtr_ClearActivity;

			// Token: 0x040017BA RID: 6074
			private static readonly IntPtr NativeFieldInfoPtr_SendRequestReply;

			// Token: 0x040017BB RID: 6075
			private static readonly IntPtr NativeFieldInfoPtr_SendInvite;

			// Token: 0x040017BC RID: 6076
			private static readonly IntPtr NativeFieldInfoPtr_AcceptInvite;

			// Token: 0x02000255 RID: 597
			public sealed class RegisterCommandMethod : MulticastDelegate
			{
				// Token: 0x060021A0 RID: 8608 RVA: 0x00098CB8 File Offset: 0x00096EB8
				// Note: this type is marked as 'beforefieldinit'.
				static RegisterCommandMethod()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterCommandMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "RegisterCommandMethod");
					ActivityManager.FFIMethods.RegisterCommandMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterCommandMethod>.NativeClassPtr, 100667231);
					ActivityManager.FFIMethods.RegisterCommandMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterCommandMethod>.NativeClassPtr, 100667232);
					ActivityManager.FFIMethods.RegisterCommandMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterCommandMethod>.NativeClassPtr, 100667233);
					ActivityManager.FFIMethods.RegisterCommandMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterCommandMethod>.NativeClassPtr, 100667234);
				}

				// Token: 0x060021A1 RID: 8609 RVA: 0x00098D2C File Offset: 0x00096F2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51760, XrefRangeEnd = 51763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RegisterCommandMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterCommandMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.RegisterCommandMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021A2 RID: 8610 RVA: 0x00098D88 File Offset: 0x00096F88
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string command)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(command);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.RegisterCommandMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060021A3 RID: 8611 RVA: 0x00098DE8 File Offset: 0x00096FE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string command, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(command);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.RegisterCommandMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021A4 RID: 8612 RVA: 0x00098E6C File Offset: 0x0009706C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51763, XrefRangeEnd = 51765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.RegisterCommandMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060021A5 RID: 8613 RVA: 0x0000E0AB File Offset: 0x0000C2AB
				public RegisterCommandMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021A6 RID: 8614 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
				public static implicit operator ActivityManager.FFIMethods.RegisterCommandMethod(Func<IntPtr, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.RegisterCommandMethod>(A_0);
				}

				// Token: 0x060021A7 RID: 8615 RVA: 0x0000E0BC File Offset: 0x0000C2BC
				public static ActivityManager.FFIMethods.RegisterCommandMethod operator +(ActivityManager.FFIMethods.RegisterCommandMethod A_0, ActivityManager.FFIMethods.RegisterCommandMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.RegisterCommandMethod>();
				}

				// Token: 0x060021A8 RID: 8616 RVA: 0x0000E0CA File Offset: 0x0000C2CA
				public static ActivityManager.FFIMethods.RegisterCommandMethod operator -(ActivityManager.FFIMethods.RegisterCommandMethod A_0, ActivityManager.FFIMethods.RegisterCommandMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.RegisterCommandMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001999 RID: 6553
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400199A RID: 6554
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0;

				// Token: 0x0400199B RID: 6555
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0;

				// Token: 0x0400199C RID: 6556
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000256 RID: 598
			public sealed class RegisterSteamMethod : MulticastDelegate
			{
				// Token: 0x060021A9 RID: 8617 RVA: 0x00098EBC File Offset: 0x000970BC
				// Note: this type is marked as 'beforefieldinit'.
				static RegisterSteamMethod()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterSteamMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "RegisterSteamMethod");
					ActivityManager.FFIMethods.RegisterSteamMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterSteamMethod>.NativeClassPtr, 100667235);
					ActivityManager.FFIMethods.RegisterSteamMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterSteamMethod>.NativeClassPtr, 100667236);
					ActivityManager.FFIMethods.RegisterSteamMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterSteamMethod>.NativeClassPtr, 100667237);
					ActivityManager.FFIMethods.RegisterSteamMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterSteamMethod>.NativeClassPtr, 100667238);
				}

				// Token: 0x060021AA RID: 8618 RVA: 0x00098F30 File Offset: 0x00097130
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51765, XrefRangeEnd = 51768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RegisterSteamMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.RegisterSteamMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.RegisterSteamMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021AB RID: 8619 RVA: 0x00098F8C File Offset: 0x0009718C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, uint steamId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.RegisterSteamMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060021AC RID: 8620 RVA: 0x00098FE8 File Offset: 0x000971E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51768, XrefRangeEnd = 51773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, uint steamId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.RegisterSteamMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021AD RID: 8621 RVA: 0x00099068 File Offset: 0x00097268
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.RegisterSteamMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060021AE RID: 8622 RVA: 0x0000E0DB File Offset: 0x0000C2DB
				public RegisterSteamMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021AF RID: 8623 RVA: 0x0000E0E4 File Offset: 0x0000C2E4
				public static implicit operator ActivityManager.FFIMethods.RegisterSteamMethod(Func<IntPtr, uint, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.RegisterSteamMethod>(A_0);
				}

				// Token: 0x060021B0 RID: 8624 RVA: 0x0000E0EC File Offset: 0x0000C2EC
				public static ActivityManager.FFIMethods.RegisterSteamMethod operator +(ActivityManager.FFIMethods.RegisterSteamMethod A_0, ActivityManager.FFIMethods.RegisterSteamMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.RegisterSteamMethod>();
				}

				// Token: 0x060021B1 RID: 8625 RVA: 0x0000E0FA File Offset: 0x0000C2FA
				public static ActivityManager.FFIMethods.RegisterSteamMethod operator -(ActivityManager.FFIMethods.RegisterSteamMethod A_0, ActivityManager.FFIMethods.RegisterSteamMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.RegisterSteamMethod>();
					}
					return delegate2;
				}

				// Token: 0x0400199D RID: 6557
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400199E RID: 6558
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_0;

				// Token: 0x0400199F RID: 6559
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_AsyncCallback_Object_0;

				// Token: 0x040019A0 RID: 6560
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000257 RID: 599
			public sealed class UpdateActivityCallback : MulticastDelegate
			{
				// Token: 0x060021B2 RID: 8626 RVA: 0x000990B8 File Offset: 0x000972B8
				// Note: this type is marked as 'beforefieldinit'.
				static UpdateActivityCallback()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "UpdateActivityCallback");
					ActivityManager.FFIMethods.UpdateActivityCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityCallback>.NativeClassPtr, 100667239);
					ActivityManager.FFIMethods.UpdateActivityCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityCallback>.NativeClassPtr, 100667240);
					ActivityManager.FFIMethods.UpdateActivityCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityCallback>.NativeClassPtr, 100667241);
					ActivityManager.FFIMethods.UpdateActivityCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityCallback>.NativeClassPtr, 100667242);
				}

				// Token: 0x060021B3 RID: 8627 RVA: 0x0009912C File Offset: 0x0009732C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51773, XrefRangeEnd = 51776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UpdateActivityCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.UpdateActivityCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021B4 RID: 8628 RVA: 0x00099188 File Offset: 0x00097388
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.UpdateActivityCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021B5 RID: 8629 RVA: 0x000991D8 File Offset: 0x000973D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51776, XrefRangeEnd = 51782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.UpdateActivityCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021B6 RID: 8630 RVA: 0x0009925C File Offset: 0x0009745C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.UpdateActivityCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060021B7 RID: 8631 RVA: 0x0000E10B File Offset: 0x0000C30B
				public UpdateActivityCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021B8 RID: 8632 RVA: 0x0000E114 File Offset: 0x0000C314
				public static implicit operator ActivityManager.FFIMethods.UpdateActivityCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.UpdateActivityCallback>(A_0);
				}

				// Token: 0x060021B9 RID: 8633 RVA: 0x0000E11C File Offset: 0x0000C31C
				public static ActivityManager.FFIMethods.UpdateActivityCallback operator +(ActivityManager.FFIMethods.UpdateActivityCallback A_0, ActivityManager.FFIMethods.UpdateActivityCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.UpdateActivityCallback>();
				}

				// Token: 0x060021BA RID: 8634 RVA: 0x0000E12A File Offset: 0x0000C32A
				public static ActivityManager.FFIMethods.UpdateActivityCallback operator -(ActivityManager.FFIMethods.UpdateActivityCallback A_0, ActivityManager.FFIMethods.UpdateActivityCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.UpdateActivityCallback>();
					}
					return delegate2;
				}

				// Token: 0x040019A1 RID: 6561
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019A2 RID: 6562
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x040019A3 RID: 6563
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x040019A4 RID: 6564
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000258 RID: 600
			public sealed class UpdateActivityMethod : MulticastDelegate
			{
				// Token: 0x060021BB RID: 8635 RVA: 0x000992A0 File Offset: 0x000974A0
				// Note: this type is marked as 'beforefieldinit'.
				static UpdateActivityMethod()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "UpdateActivityMethod");
					ActivityManager.FFIMethods.UpdateActivityMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityMethod>.NativeClassPtr, 100667243);
					ActivityManager.FFIMethods.UpdateActivityMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Activity_IntPtr_UpdateActivityCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityMethod>.NativeClassPtr, 100667244);
					ActivityManager.FFIMethods.UpdateActivityMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Activity_IntPtr_UpdateActivityCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityMethod>.NativeClassPtr, 100667245);
					ActivityManager.FFIMethods.UpdateActivityMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Activity_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityMethod>.NativeClassPtr, 100667246);
				}

				// Token: 0x060021BC RID: 8636 RVA: 0x00099314 File Offset: 0x00097514
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51782, XrefRangeEnd = 51785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UpdateActivityMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.UpdateActivityMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.UpdateActivityMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021BD RID: 8637 RVA: 0x00099370 File Offset: 0x00097570
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, ActivityManager.FFIMethods.UpdateActivityCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(activity);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.UpdateActivityMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Activity_IntPtr_UpdateActivityCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					activity = ((intPtr4 == 0) ? null : new Activity(intPtr4));
				}

				// Token: 0x060021BE RID: 8638 RVA: 0x000993F8 File Offset: 0x000975F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51785, XrefRangeEnd = 51793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, ActivityManager.FFIMethods.UpdateActivityCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(activity);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.UpdateActivityMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Activity_IntPtr_UpdateActivityCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					activity = ((intPtr4 == 0) ? null : new Activity(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x060021BF RID: 8639 RVA: 0x000994B4 File Offset: 0x000976B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref Activity activity, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(activity);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.UpdateActivityMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Activity_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					activity = ((intPtr4 == 0) ? null : new Activity(intPtr4));
				}

				// Token: 0x060021C0 RID: 8640 RVA: 0x0000E13B File Offset: 0x0000C33B
				public UpdateActivityMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040019A5 RID: 6565
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019A6 RID: 6566
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Activity_IntPtr_UpdateActivityCallback_0;

				// Token: 0x040019A7 RID: 6567
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Activity_IntPtr_UpdateActivityCallback_AsyncCallback_Object_0;

				// Token: 0x040019A8 RID: 6568
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Activity_IAsyncResult_0;
			}

			// Token: 0x02000259 RID: 601
			public sealed class ClearActivityCallback : MulticastDelegate
			{
				// Token: 0x060021C1 RID: 8641 RVA: 0x00099520 File Offset: 0x00097720
				// Note: this type is marked as 'beforefieldinit'.
				static ClearActivityCallback()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "ClearActivityCallback");
					ActivityManager.FFIMethods.ClearActivityCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityCallback>.NativeClassPtr, 100667247);
					ActivityManager.FFIMethods.ClearActivityCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityCallback>.NativeClassPtr, 100667248);
					ActivityManager.FFIMethods.ClearActivityCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityCallback>.NativeClassPtr, 100667249);
					ActivityManager.FFIMethods.ClearActivityCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityCallback>.NativeClassPtr, 100667250);
				}

				// Token: 0x060021C2 RID: 8642 RVA: 0x00099594 File Offset: 0x00097794
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ClearActivityCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.ClearActivityCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021C3 RID: 8643 RVA: 0x000995F0 File Offset: 0x000977F0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.ClearActivityCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021C4 RID: 8644 RVA: 0x00099640 File Offset: 0x00097840
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51793, XrefRangeEnd = 51799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.ClearActivityCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021C5 RID: 8645 RVA: 0x000996C4 File Offset: 0x000978C4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.ClearActivityCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060021C6 RID: 8646 RVA: 0x0000E144 File Offset: 0x0000C344
				public ClearActivityCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021C7 RID: 8647 RVA: 0x0000E14D File Offset: 0x0000C34D
				public static implicit operator ActivityManager.FFIMethods.ClearActivityCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.ClearActivityCallback>(A_0);
				}

				// Token: 0x060021C8 RID: 8648 RVA: 0x0000E155 File Offset: 0x0000C355
				public static ActivityManager.FFIMethods.ClearActivityCallback operator +(ActivityManager.FFIMethods.ClearActivityCallback A_0, ActivityManager.FFIMethods.ClearActivityCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.ClearActivityCallback>();
				}

				// Token: 0x060021C9 RID: 8649 RVA: 0x0000E163 File Offset: 0x0000C363
				public static ActivityManager.FFIMethods.ClearActivityCallback operator -(ActivityManager.FFIMethods.ClearActivityCallback A_0, ActivityManager.FFIMethods.ClearActivityCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.ClearActivityCallback>();
					}
					return delegate2;
				}

				// Token: 0x040019A9 RID: 6569
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019AA RID: 6570
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x040019AB RID: 6571
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x040019AC RID: 6572
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200025A RID: 602
			public sealed class ClearActivityMethod : MulticastDelegate
			{
				// Token: 0x060021CA RID: 8650 RVA: 0x00099708 File Offset: 0x00097908
				// Note: this type is marked as 'beforefieldinit'.
				static ClearActivityMethod()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "ClearActivityMethod");
					ActivityManager.FFIMethods.ClearActivityMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityMethod>.NativeClassPtr, 100667251);
					ActivityManager.FFIMethods.ClearActivityMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_ClearActivityCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityMethod>.NativeClassPtr, 100667252);
					ActivityManager.FFIMethods.ClearActivityMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_ClearActivityCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityMethod>.NativeClassPtr, 100667253);
					ActivityManager.FFIMethods.ClearActivityMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityMethod>.NativeClassPtr, 100667254);
				}

				// Token: 0x060021CB RID: 8651 RVA: 0x0009977C File Offset: 0x0009797C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51799, XrefRangeEnd = 51802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ClearActivityMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.ClearActivityMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.ClearActivityMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021CC RID: 8652 RVA: 0x000997D8 File Offset: 0x000979D8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, ActivityManager.FFIMethods.ClearActivityCallback callback)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.ClearActivityMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_ClearActivityCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021CD RID: 8653 RVA: 0x00099838 File Offset: 0x00097A38
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51802, XrefRangeEnd = 51807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ActivityManager.FFIMethods.ClearActivityCallback callback, AsyncCallback __callback, Object @object)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.ClearActivityMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_ClearActivityCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021CE RID: 8654 RVA: 0x000998CC File Offset: 0x00097ACC
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.ClearActivityMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060021CF RID: 8655 RVA: 0x0000E174 File Offset: 0x0000C374
				public ClearActivityMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021D0 RID: 8656 RVA: 0x0000E17D File Offset: 0x0000C37D
				public static implicit operator ActivityManager.FFIMethods.ClearActivityMethod(Action<IntPtr, IntPtr, ActivityManager.FFIMethods.ClearActivityCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.ClearActivityMethod>(A_0);
				}

				// Token: 0x060021D1 RID: 8657 RVA: 0x0000E185 File Offset: 0x0000C385
				public static ActivityManager.FFIMethods.ClearActivityMethod operator +(ActivityManager.FFIMethods.ClearActivityMethod A_0, ActivityManager.FFIMethods.ClearActivityMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.ClearActivityMethod>();
				}

				// Token: 0x060021D2 RID: 8658 RVA: 0x0000E193 File Offset: 0x0000C393
				public static ActivityManager.FFIMethods.ClearActivityMethod operator -(ActivityManager.FFIMethods.ClearActivityMethod A_0, ActivityManager.FFIMethods.ClearActivityMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.ClearActivityMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019AD RID: 6573
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019AE RID: 6574
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_ClearActivityCallback_0;

				// Token: 0x040019AF RID: 6575
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_ClearActivityCallback_AsyncCallback_Object_0;

				// Token: 0x040019B0 RID: 6576
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200025B RID: 603
			public sealed class SendRequestReplyCallback : MulticastDelegate
			{
				// Token: 0x060021D3 RID: 8659 RVA: 0x00099910 File Offset: 0x00097B10
				// Note: this type is marked as 'beforefieldinit'.
				static SendRequestReplyCallback()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "SendRequestReplyCallback");
					ActivityManager.FFIMethods.SendRequestReplyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyCallback>.NativeClassPtr, 100667255);
					ActivityManager.FFIMethods.SendRequestReplyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyCallback>.NativeClassPtr, 100667256);
					ActivityManager.FFIMethods.SendRequestReplyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyCallback>.NativeClassPtr, 100667257);
					ActivityManager.FFIMethods.SendRequestReplyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyCallback>.NativeClassPtr, 100667258);
				}

				// Token: 0x060021D4 RID: 8660 RVA: 0x00099984 File Offset: 0x00097B84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SendRequestReplyCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendRequestReplyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021D5 RID: 8661 RVA: 0x000999E0 File Offset: 0x00097BE0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendRequestReplyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021D6 RID: 8662 RVA: 0x00099A30 File Offset: 0x00097C30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51807, XrefRangeEnd = 51813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendRequestReplyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021D7 RID: 8663 RVA: 0x00099AB4 File Offset: 0x00097CB4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendRequestReplyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060021D8 RID: 8664 RVA: 0x0000E1A4 File Offset: 0x0000C3A4
				public SendRequestReplyCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021D9 RID: 8665 RVA: 0x0000E1AD File Offset: 0x0000C3AD
				public static implicit operator ActivityManager.FFIMethods.SendRequestReplyCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.SendRequestReplyCallback>(A_0);
				}

				// Token: 0x060021DA RID: 8666 RVA: 0x0000E1B5 File Offset: 0x0000C3B5
				public static ActivityManager.FFIMethods.SendRequestReplyCallback operator +(ActivityManager.FFIMethods.SendRequestReplyCallback A_0, ActivityManager.FFIMethods.SendRequestReplyCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.SendRequestReplyCallback>();
				}

				// Token: 0x060021DB RID: 8667 RVA: 0x0000E1C3 File Offset: 0x0000C3C3
				public static ActivityManager.FFIMethods.SendRequestReplyCallback operator -(ActivityManager.FFIMethods.SendRequestReplyCallback A_0, ActivityManager.FFIMethods.SendRequestReplyCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.SendRequestReplyCallback>();
					}
					return delegate2;
				}

				// Token: 0x040019B1 RID: 6577
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019B2 RID: 6578
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x040019B3 RID: 6579
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x040019B4 RID: 6580
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200025C RID: 604
			public sealed class SendRequestReplyMethod : MulticastDelegate
			{
				// Token: 0x060021DC RID: 8668 RVA: 0x00099AF8 File Offset: 0x00097CF8
				// Note: this type is marked as 'beforefieldinit'.
				static SendRequestReplyMethod()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "SendRequestReplyMethod");
					ActivityManager.FFIMethods.SendRequestReplyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyMethod>.NativeClassPtr, 100667259);
					ActivityManager.FFIMethods.SendRequestReplyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_ActivityJoinRequestReply_IntPtr_SendRequestReplyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyMethod>.NativeClassPtr, 100667260);
					ActivityManager.FFIMethods.SendRequestReplyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_ActivityJoinRequestReply_IntPtr_SendRequestReplyCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyMethod>.NativeClassPtr, 100667261);
					ActivityManager.FFIMethods.SendRequestReplyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyMethod>.NativeClassPtr, 100667262);
				}

				// Token: 0x060021DD RID: 8669 RVA: 0x00099B6C File Offset: 0x00097D6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51813, XrefRangeEnd = 51816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SendRequestReplyMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendRequestReplyMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendRequestReplyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021DE RID: 8670 RVA: 0x00099BC8 File Offset: 0x00097DC8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, ActivityManager.FFIMethods.SendRequestReplyCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reply);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendRequestReplyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_ActivityJoinRequestReply_IntPtr_SendRequestReplyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021DF RID: 8671 RVA: 0x00099C48 File Offset: 0x00097E48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51816, XrefRangeEnd = 51826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, ActivityManager.FFIMethods.SendRequestReplyCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reply);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendRequestReplyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_ActivityJoinRequestReply_IntPtr_SendRequestReplyCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021E0 RID: 8672 RVA: 0x00099CFC File Offset: 0x00097EFC
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendRequestReplyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060021E1 RID: 8673 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
				public SendRequestReplyMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021E2 RID: 8674 RVA: 0x0000E1DD File Offset: 0x0000C3DD
				public static implicit operator ActivityManager.FFIMethods.SendRequestReplyMethod(Action<IntPtr, long, ActivityJoinRequestReply, IntPtr, ActivityManager.FFIMethods.SendRequestReplyCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.SendRequestReplyMethod>(A_0);
				}

				// Token: 0x060021E3 RID: 8675 RVA: 0x0000E1E5 File Offset: 0x0000C3E5
				public static ActivityManager.FFIMethods.SendRequestReplyMethod operator +(ActivityManager.FFIMethods.SendRequestReplyMethod A_0, ActivityManager.FFIMethods.SendRequestReplyMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.SendRequestReplyMethod>();
				}

				// Token: 0x060021E4 RID: 8676 RVA: 0x0000E1F3 File Offset: 0x0000C3F3
				public static ActivityManager.FFIMethods.SendRequestReplyMethod operator -(ActivityManager.FFIMethods.SendRequestReplyMethod A_0, ActivityManager.FFIMethods.SendRequestReplyMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.SendRequestReplyMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019B5 RID: 6581
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019B6 RID: 6582
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_ActivityJoinRequestReply_IntPtr_SendRequestReplyCallback_0;

				// Token: 0x040019B7 RID: 6583
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_ActivityJoinRequestReply_IntPtr_SendRequestReplyCallback_AsyncCallback_Object_0;

				// Token: 0x040019B8 RID: 6584
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200025D RID: 605
			public sealed class SendInviteCallback : MulticastDelegate
			{
				// Token: 0x060021E5 RID: 8677 RVA: 0x00099D40 File Offset: 0x00097F40
				// Note: this type is marked as 'beforefieldinit'.
				static SendInviteCallback()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "SendInviteCallback");
					ActivityManager.FFIMethods.SendInviteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteCallback>.NativeClassPtr, 100667263);
					ActivityManager.FFIMethods.SendInviteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteCallback>.NativeClassPtr, 100667264);
					ActivityManager.FFIMethods.SendInviteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteCallback>.NativeClassPtr, 100667265);
					ActivityManager.FFIMethods.SendInviteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteCallback>.NativeClassPtr, 100667266);
				}

				// Token: 0x060021E6 RID: 8678 RVA: 0x00099DB4 File Offset: 0x00097FB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SendInviteCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendInviteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021E7 RID: 8679 RVA: 0x00099E10 File Offset: 0x00098010
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendInviteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021E8 RID: 8680 RVA: 0x00099E60 File Offset: 0x00098060
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51826, XrefRangeEnd = 51832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendInviteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021E9 RID: 8681 RVA: 0x00099EE4 File Offset: 0x000980E4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendInviteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060021EA RID: 8682 RVA: 0x0000E204 File Offset: 0x0000C404
				public SendInviteCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021EB RID: 8683 RVA: 0x0000E20D File Offset: 0x0000C40D
				public static implicit operator ActivityManager.FFIMethods.SendInviteCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.SendInviteCallback>(A_0);
				}

				// Token: 0x060021EC RID: 8684 RVA: 0x0000E215 File Offset: 0x0000C415
				public static ActivityManager.FFIMethods.SendInviteCallback operator +(ActivityManager.FFIMethods.SendInviteCallback A_0, ActivityManager.FFIMethods.SendInviteCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.SendInviteCallback>();
				}

				// Token: 0x060021ED RID: 8685 RVA: 0x0000E223 File Offset: 0x0000C423
				public static ActivityManager.FFIMethods.SendInviteCallback operator -(ActivityManager.FFIMethods.SendInviteCallback A_0, ActivityManager.FFIMethods.SendInviteCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.SendInviteCallback>();
					}
					return delegate2;
				}

				// Token: 0x040019B9 RID: 6585
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019BA RID: 6586
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x040019BB RID: 6587
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x040019BC RID: 6588
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200025E RID: 606
			public sealed class SendInviteMethod : MulticastDelegate
			{
				// Token: 0x060021EE RID: 8686 RVA: 0x00099F28 File Offset: 0x00098128
				// Note: this type is marked as 'beforefieldinit'.
				static SendInviteMethod()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "SendInviteMethod");
					ActivityManager.FFIMethods.SendInviteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteMethod>.NativeClassPtr, 100667267);
					ActivityManager.FFIMethods.SendInviteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_ActivityActionType_String_IntPtr_SendInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteMethod>.NativeClassPtr, 100667268);
					ActivityManager.FFIMethods.SendInviteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_ActivityActionType_String_IntPtr_SendInviteCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteMethod>.NativeClassPtr, 100667269);
					ActivityManager.FFIMethods.SendInviteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteMethod>.NativeClassPtr, 100667270);
				}

				// Token: 0x060021EF RID: 8687 RVA: 0x00099F9C File Offset: 0x0009819C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51832, XrefRangeEnd = 51835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SendInviteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.SendInviteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendInviteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021F0 RID: 8688 RVA: 0x00099FF8 File Offset: 0x000981F8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, ActivityManager.FFIMethods.SendInviteCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(content);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendInviteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_ActivityActionType_String_IntPtr_SendInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021F1 RID: 8689 RVA: 0x0009A08C File Offset: 0x0009828C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51835, XrefRangeEnd = 51845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, ActivityManager.FFIMethods.SendInviteCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(content);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendInviteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_ActivityActionType_String_IntPtr_SendInviteCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021F2 RID: 8690 RVA: 0x0009A154 File Offset: 0x00098354
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.SendInviteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060021F3 RID: 8691 RVA: 0x0000E234 File Offset: 0x0000C434
				public SendInviteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021F4 RID: 8692 RVA: 0x0000E23D File Offset: 0x0000C43D
				public static implicit operator ActivityManager.FFIMethods.SendInviteMethod(Action<IntPtr, long, ActivityActionType, string, IntPtr, ActivityManager.FFIMethods.SendInviteCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.SendInviteMethod>(A_0);
				}

				// Token: 0x060021F5 RID: 8693 RVA: 0x0000E245 File Offset: 0x0000C445
				public static ActivityManager.FFIMethods.SendInviteMethod operator +(ActivityManager.FFIMethods.SendInviteMethod A_0, ActivityManager.FFIMethods.SendInviteMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.SendInviteMethod>();
				}

				// Token: 0x060021F6 RID: 8694 RVA: 0x0000E253 File Offset: 0x0000C453
				public static ActivityManager.FFIMethods.SendInviteMethod operator -(ActivityManager.FFIMethods.SendInviteMethod A_0, ActivityManager.FFIMethods.SendInviteMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.SendInviteMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019BD RID: 6589
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019BE RID: 6590
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_ActivityActionType_String_IntPtr_SendInviteCallback_0;

				// Token: 0x040019BF RID: 6591
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_ActivityActionType_String_IntPtr_SendInviteCallback_AsyncCallback_Object_0;

				// Token: 0x040019C0 RID: 6592
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200025F RID: 607
			public sealed class AcceptInviteCallback : MulticastDelegate
			{
				// Token: 0x060021F7 RID: 8695 RVA: 0x0009A198 File Offset: 0x00098398
				// Note: this type is marked as 'beforefieldinit'.
				static AcceptInviteCallback()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "AcceptInviteCallback");
					ActivityManager.FFIMethods.AcceptInviteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteCallback>.NativeClassPtr, 100667271);
					ActivityManager.FFIMethods.AcceptInviteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteCallback>.NativeClassPtr, 100667272);
					ActivityManager.FFIMethods.AcceptInviteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteCallback>.NativeClassPtr, 100667273);
					ActivityManager.FFIMethods.AcceptInviteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteCallback>.NativeClassPtr, 100667274);
				}

				// Token: 0x060021F8 RID: 8696 RVA: 0x0009A20C File Offset: 0x0009840C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe AcceptInviteCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.AcceptInviteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021F9 RID: 8697 RVA: 0x0009A268 File Offset: 0x00098468
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.AcceptInviteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060021FA RID: 8698 RVA: 0x0009A2B8 File Offset: 0x000984B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51845, XrefRangeEnd = 51851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.AcceptInviteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060021FB RID: 8699 RVA: 0x0009A33C File Offset: 0x0009853C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.AcceptInviteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060021FC RID: 8700 RVA: 0x0000E264 File Offset: 0x0000C464
				public AcceptInviteCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060021FD RID: 8701 RVA: 0x0000E26D File Offset: 0x0000C46D
				public static implicit operator ActivityManager.FFIMethods.AcceptInviteCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.AcceptInviteCallback>(A_0);
				}

				// Token: 0x060021FE RID: 8702 RVA: 0x0000E275 File Offset: 0x0000C475
				public static ActivityManager.FFIMethods.AcceptInviteCallback operator +(ActivityManager.FFIMethods.AcceptInviteCallback A_0, ActivityManager.FFIMethods.AcceptInviteCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.AcceptInviteCallback>();
				}

				// Token: 0x060021FF RID: 8703 RVA: 0x0000E283 File Offset: 0x0000C483
				public static ActivityManager.FFIMethods.AcceptInviteCallback operator -(ActivityManager.FFIMethods.AcceptInviteCallback A_0, ActivityManager.FFIMethods.AcceptInviteCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.AcceptInviteCallback>();
					}
					return delegate2;
				}

				// Token: 0x040019C1 RID: 6593
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019C2 RID: 6594
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x040019C3 RID: 6595
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x040019C4 RID: 6596
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000260 RID: 608
			public sealed class AcceptInviteMethod : MulticastDelegate
			{
				// Token: 0x06002200 RID: 8704 RVA: 0x0009A380 File Offset: 0x00098580
				// Note: this type is marked as 'beforefieldinit'.
				static AcceptInviteMethod()
				{
					Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager.FFIMethods>.NativeClassPtr, "AcceptInviteMethod");
					ActivityManager.FFIMethods.AcceptInviteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteMethod>.NativeClassPtr, 100667275);
					ActivityManager.FFIMethods.AcceptInviteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_AcceptInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteMethod>.NativeClassPtr, 100667276);
					ActivityManager.FFIMethods.AcceptInviteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_AcceptInviteCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteMethod>.NativeClassPtr, 100667277);
					ActivityManager.FFIMethods.AcceptInviteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteMethod>.NativeClassPtr, 100667278);
				}

				// Token: 0x06002201 RID: 8705 RVA: 0x0009A3F4 File Offset: 0x000985F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe AcceptInviteMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.FFIMethods.AcceptInviteMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.AcceptInviteMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002202 RID: 8706 RVA: 0x0009A450 File Offset: 0x00098650
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long userId, IntPtr callbackData, ActivityManager.FFIMethods.AcceptInviteCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.AcceptInviteMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_AcceptInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002203 RID: 8707 RVA: 0x0009A4C0 File Offset: 0x000986C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51851, XrefRangeEnd = 51858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, IntPtr callbackData, ActivityManager.FFIMethods.AcceptInviteCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.AcceptInviteMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_AcceptInviteCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002204 RID: 8708 RVA: 0x0009A564 File Offset: 0x00098764
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.FFIMethods.AcceptInviteMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002205 RID: 8709 RVA: 0x0000E294 File Offset: 0x0000C494
				public AcceptInviteMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002206 RID: 8710 RVA: 0x0000E29D File Offset: 0x0000C49D
				public static implicit operator ActivityManager.FFIMethods.AcceptInviteMethod(Action<IntPtr, long, IntPtr, ActivityManager.FFIMethods.AcceptInviteCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<ActivityManager.FFIMethods.AcceptInviteMethod>(A_0);
				}

				// Token: 0x06002207 RID: 8711 RVA: 0x0000E2A5 File Offset: 0x0000C4A5
				public static ActivityManager.FFIMethods.AcceptInviteMethod operator +(ActivityManager.FFIMethods.AcceptInviteMethod A_0, ActivityManager.FFIMethods.AcceptInviteMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<ActivityManager.FFIMethods.AcceptInviteMethod>();
				}

				// Token: 0x06002208 RID: 8712 RVA: 0x0000E2B3 File Offset: 0x0000C4B3
				public static ActivityManager.FFIMethods.AcceptInviteMethod operator -(ActivityManager.FFIMethods.AcceptInviteMethod A_0, ActivityManager.FFIMethods.AcceptInviteMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<ActivityManager.FFIMethods.AcceptInviteMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019C5 RID: 6597
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019C6 RID: 6598
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_AcceptInviteCallback_0;

				// Token: 0x040019C7 RID: 6599
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_AcceptInviteCallback_AsyncCallback_Object_0;

				// Token: 0x040019C8 RID: 6600
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}

		// Token: 0x020001F4 RID: 500
		public sealed class UpdateActivityHandler : MulticastDelegate
		{
			// Token: 0x06001DFA RID: 7674 RVA: 0x0008E0C8 File Offset: 0x0008C2C8
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateActivityHandler()
			{
				Il2CppClassPointerStore<ActivityManager.UpdateActivityHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "UpdateActivityHandler");
				ActivityManager.UpdateActivityHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.UpdateActivityHandler>.NativeClassPtr, 100667279);
				ActivityManager.UpdateActivityHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.UpdateActivityHandler>.NativeClassPtr, 100667280);
				ActivityManager.UpdateActivityHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.UpdateActivityHandler>.NativeClassPtr, 100667281);
				ActivityManager.UpdateActivityHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.UpdateActivityHandler>.NativeClassPtr, 100667282);
			}

			// Token: 0x06001DFB RID: 7675 RVA: 0x0008E13C File Offset: 0x0008C33C
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51858, XrefRangeEnd = 51861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateActivityHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.UpdateActivityHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.UpdateActivityHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DFC RID: 7676 RVA: 0x0008E198 File Offset: 0x0008C398
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.UpdateActivityHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DFD RID: 7677 RVA: 0x0008E1DC File Offset: 0x0008C3DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51886, XrefRangeEnd = 51890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.UpdateActivityHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001DFE RID: 7678 RVA: 0x0008E250 File Offset: 0x0008C450
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.UpdateActivityHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DFF RID: 7679 RVA: 0x0000BF46 File Offset: 0x0000A146
			public UpdateActivityHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E00 RID: 7680 RVA: 0x0000BF4F File Offset: 0x0000A14F
			public static implicit operator ActivityManager.UpdateActivityHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<ActivityManager.UpdateActivityHandler>(A_0);
			}

			// Token: 0x06001E01 RID: 7681 RVA: 0x0000BF57 File Offset: 0x0000A157
			public static ActivityManager.UpdateActivityHandler operator +(ActivityManager.UpdateActivityHandler A_0, ActivityManager.UpdateActivityHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ActivityManager.UpdateActivityHandler>();
			}

			// Token: 0x06001E02 RID: 7682 RVA: 0x0000BF65 File Offset: 0x0000A165
			public static ActivityManager.UpdateActivityHandler operator -(ActivityManager.UpdateActivityHandler A_0, ActivityManager.UpdateActivityHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ActivityManager.UpdateActivityHandler>();
				}
				return delegate2;
			}

			// Token: 0x040017BD RID: 6077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017BE RID: 6078
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040017BF RID: 6079
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040017C0 RID: 6080
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001F5 RID: 501
		public sealed class ClearActivityHandler : MulticastDelegate
		{
			// Token: 0x06001E03 RID: 7683 RVA: 0x0008E294 File Offset: 0x0008C494
			// Note: this type is marked as 'beforefieldinit'.
			static ClearActivityHandler()
			{
				Il2CppClassPointerStore<ActivityManager.ClearActivityHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "ClearActivityHandler");
				ActivityManager.ClearActivityHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ClearActivityHandler>.NativeClassPtr, 100667283);
				ActivityManager.ClearActivityHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ClearActivityHandler>.NativeClassPtr, 100667284);
				ActivityManager.ClearActivityHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ClearActivityHandler>.NativeClassPtr, 100667285);
				ActivityManager.ClearActivityHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ClearActivityHandler>.NativeClassPtr, 100667286);
			}

			// Token: 0x06001E04 RID: 7684 RVA: 0x0008E308 File Offset: 0x0008C508
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearActivityHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.ClearActivityHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ClearActivityHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E05 RID: 7685 RVA: 0x0008E364 File Offset: 0x0008C564
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ClearActivityHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E06 RID: 7686 RVA: 0x0008E3A8 File Offset: 0x0008C5A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51890, XrefRangeEnd = 51894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ClearActivityHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E07 RID: 7687 RVA: 0x0008E41C File Offset: 0x0008C61C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ClearActivityHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E08 RID: 7688 RVA: 0x0000BF76 File Offset: 0x0000A176
			public ClearActivityHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E09 RID: 7689 RVA: 0x0000BF7F File Offset: 0x0000A17F
			public static implicit operator ActivityManager.ClearActivityHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<ActivityManager.ClearActivityHandler>(A_0);
			}

			// Token: 0x06001E0A RID: 7690 RVA: 0x0000BF87 File Offset: 0x0000A187
			public static ActivityManager.ClearActivityHandler operator +(ActivityManager.ClearActivityHandler A_0, ActivityManager.ClearActivityHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ActivityManager.ClearActivityHandler>();
			}

			// Token: 0x06001E0B RID: 7691 RVA: 0x0000BF95 File Offset: 0x0000A195
			public static ActivityManager.ClearActivityHandler operator -(ActivityManager.ClearActivityHandler A_0, ActivityManager.ClearActivityHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ActivityManager.ClearActivityHandler>();
				}
				return delegate2;
			}

			// Token: 0x040017C1 RID: 6081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017C2 RID: 6082
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040017C3 RID: 6083
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040017C4 RID: 6084
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001F6 RID: 502
		public sealed class SendRequestReplyHandler : MulticastDelegate
		{
			// Token: 0x06001E0C RID: 7692 RVA: 0x0008E460 File Offset: 0x0008C660
			// Note: this type is marked as 'beforefieldinit'.
			static SendRequestReplyHandler()
			{
				Il2CppClassPointerStore<ActivityManager.SendRequestReplyHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "SendRequestReplyHandler");
				ActivityManager.SendRequestReplyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.SendRequestReplyHandler>.NativeClassPtr, 100667287);
				ActivityManager.SendRequestReplyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.SendRequestReplyHandler>.NativeClassPtr, 100667288);
				ActivityManager.SendRequestReplyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.SendRequestReplyHandler>.NativeClassPtr, 100667289);
				ActivityManager.SendRequestReplyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.SendRequestReplyHandler>.NativeClassPtr, 100667290);
			}

			// Token: 0x06001E0D RID: 7693 RVA: 0x0008E4D4 File Offset: 0x0008C6D4
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SendRequestReplyHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.SendRequestReplyHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.SendRequestReplyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E0E RID: 7694 RVA: 0x0008E530 File Offset: 0x0008C730
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.SendRequestReplyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E0F RID: 7695 RVA: 0x0008E574 File Offset: 0x0008C774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51894, XrefRangeEnd = 51898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.SendRequestReplyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E10 RID: 7696 RVA: 0x0008E5E8 File Offset: 0x0008C7E8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.SendRequestReplyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E11 RID: 7697 RVA: 0x0000BFA6 File Offset: 0x0000A1A6
			public SendRequestReplyHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E12 RID: 7698 RVA: 0x0000BFAF File Offset: 0x0000A1AF
			public static implicit operator ActivityManager.SendRequestReplyHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<ActivityManager.SendRequestReplyHandler>(A_0);
			}

			// Token: 0x06001E13 RID: 7699 RVA: 0x0000BFB7 File Offset: 0x0000A1B7
			public static ActivityManager.SendRequestReplyHandler operator +(ActivityManager.SendRequestReplyHandler A_0, ActivityManager.SendRequestReplyHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ActivityManager.SendRequestReplyHandler>();
			}

			// Token: 0x06001E14 RID: 7700 RVA: 0x0000BFC5 File Offset: 0x0000A1C5
			public static ActivityManager.SendRequestReplyHandler operator -(ActivityManager.SendRequestReplyHandler A_0, ActivityManager.SendRequestReplyHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ActivityManager.SendRequestReplyHandler>();
				}
				return delegate2;
			}

			// Token: 0x040017C5 RID: 6085
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017C6 RID: 6086
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040017C7 RID: 6087
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040017C8 RID: 6088
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001F7 RID: 503
		public sealed class SendInviteHandler : MulticastDelegate
		{
			// Token: 0x06001E15 RID: 7701 RVA: 0x0008E62C File Offset: 0x0008C82C
			// Note: this type is marked as 'beforefieldinit'.
			static SendInviteHandler()
			{
				Il2CppClassPointerStore<ActivityManager.SendInviteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "SendInviteHandler");
				ActivityManager.SendInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.SendInviteHandler>.NativeClassPtr, 100667291);
				ActivityManager.SendInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.SendInviteHandler>.NativeClassPtr, 100667292);
				ActivityManager.SendInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.SendInviteHandler>.NativeClassPtr, 100667293);
				ActivityManager.SendInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.SendInviteHandler>.NativeClassPtr, 100667294);
			}

			// Token: 0x06001E16 RID: 7702 RVA: 0x0008E6A0 File Offset: 0x0008C8A0
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SendInviteHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.SendInviteHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.SendInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E17 RID: 7703 RVA: 0x0008E6FC File Offset: 0x0008C8FC
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.SendInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E18 RID: 7704 RVA: 0x0008E740 File Offset: 0x0008C940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51898, XrefRangeEnd = 51902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.SendInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E19 RID: 7705 RVA: 0x0008E7B4 File Offset: 0x0008C9B4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.SendInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E1A RID: 7706 RVA: 0x0000BFD6 File Offset: 0x0000A1D6
			public SendInviteHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E1B RID: 7707 RVA: 0x0000BFDF File Offset: 0x0000A1DF
			public static implicit operator ActivityManager.SendInviteHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<ActivityManager.SendInviteHandler>(A_0);
			}

			// Token: 0x06001E1C RID: 7708 RVA: 0x0000BFE7 File Offset: 0x0000A1E7
			public static ActivityManager.SendInviteHandler operator +(ActivityManager.SendInviteHandler A_0, ActivityManager.SendInviteHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ActivityManager.SendInviteHandler>();
			}

			// Token: 0x06001E1D RID: 7709 RVA: 0x0000BFF5 File Offset: 0x0000A1F5
			public static ActivityManager.SendInviteHandler operator -(ActivityManager.SendInviteHandler A_0, ActivityManager.SendInviteHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ActivityManager.SendInviteHandler>();
				}
				return delegate2;
			}

			// Token: 0x040017C9 RID: 6089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017CA RID: 6090
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040017CB RID: 6091
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040017CC RID: 6092
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001F8 RID: 504
		public sealed class AcceptInviteHandler : MulticastDelegate
		{
			// Token: 0x06001E1E RID: 7710 RVA: 0x0008E7F8 File Offset: 0x0008C9F8
			// Note: this type is marked as 'beforefieldinit'.
			static AcceptInviteHandler()
			{
				Il2CppClassPointerStore<ActivityManager.AcceptInviteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "AcceptInviteHandler");
				ActivityManager.AcceptInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.AcceptInviteHandler>.NativeClassPtr, 100667295);
				ActivityManager.AcceptInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.AcceptInviteHandler>.NativeClassPtr, 100667296);
				ActivityManager.AcceptInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.AcceptInviteHandler>.NativeClassPtr, 100667297);
				ActivityManager.AcceptInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.AcceptInviteHandler>.NativeClassPtr, 100667298);
			}

			// Token: 0x06001E1F RID: 7711 RVA: 0x0008E86C File Offset: 0x0008CA6C
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AcceptInviteHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.AcceptInviteHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.AcceptInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E20 RID: 7712 RVA: 0x0008E8C8 File Offset: 0x0008CAC8
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.AcceptInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E21 RID: 7713 RVA: 0x0008E90C File Offset: 0x0008CB0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51902, XrefRangeEnd = 51906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.AcceptInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E22 RID: 7714 RVA: 0x0008E980 File Offset: 0x0008CB80
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.AcceptInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E23 RID: 7715 RVA: 0x0000C006 File Offset: 0x0000A206
			public AcceptInviteHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E24 RID: 7716 RVA: 0x0000C00F File Offset: 0x0000A20F
			public static implicit operator ActivityManager.AcceptInviteHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<ActivityManager.AcceptInviteHandler>(A_0);
			}

			// Token: 0x06001E25 RID: 7717 RVA: 0x0000C017 File Offset: 0x0000A217
			public static ActivityManager.AcceptInviteHandler operator +(ActivityManager.AcceptInviteHandler A_0, ActivityManager.AcceptInviteHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ActivityManager.AcceptInviteHandler>();
			}

			// Token: 0x06001E26 RID: 7718 RVA: 0x0000C025 File Offset: 0x0000A225
			public static ActivityManager.AcceptInviteHandler operator -(ActivityManager.AcceptInviteHandler A_0, ActivityManager.AcceptInviteHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ActivityManager.AcceptInviteHandler>();
				}
				return delegate2;
			}

			// Token: 0x040017CD RID: 6093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017CE RID: 6094
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040017CF RID: 6095
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040017D0 RID: 6096
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001F9 RID: 505
		public sealed class ActivityJoinHandler : MulticastDelegate
		{
			// Token: 0x06001E27 RID: 7719 RVA: 0x0008E9C4 File Offset: 0x0008CBC4
			// Note: this type is marked as 'beforefieldinit'.
			static ActivityJoinHandler()
			{
				Il2CppClassPointerStore<ActivityManager.ActivityJoinHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "ActivityJoinHandler");
				ActivityManager.ActivityJoinHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityJoinHandler>.NativeClassPtr, 100667299);
				ActivityManager.ActivityJoinHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityJoinHandler>.NativeClassPtr, 100667300);
				ActivityManager.ActivityJoinHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityJoinHandler>.NativeClassPtr, 100667301);
				ActivityManager.ActivityJoinHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityJoinHandler>.NativeClassPtr, 100667302);
			}

			// Token: 0x06001E28 RID: 7720 RVA: 0x0008EA38 File Offset: 0x0008CC38
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 51910, RefRangeEnd = 51916, XrefRangeStart = 51906, XrefRangeEnd = 51910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActivityJoinHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.ActivityJoinHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityJoinHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E29 RID: 7721 RVA: 0x0008EA94 File Offset: 0x0008CC94
			[CallerCount(0)]
			public unsafe void Invoke(string secret)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(secret);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityJoinHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E2A RID: 7722 RVA: 0x0008EAD8 File Offset: 0x0008CCD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string secret, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(secret);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityJoinHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E2B RID: 7723 RVA: 0x0008EB4C File Offset: 0x0008CD4C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityJoinHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E2C RID: 7724 RVA: 0x0000C036 File Offset: 0x0000A236
			public ActivityJoinHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E2D RID: 7725 RVA: 0x0000C03F File Offset: 0x0000A23F
			public static implicit operator ActivityManager.ActivityJoinHandler(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<ActivityManager.ActivityJoinHandler>(A_0);
			}

			// Token: 0x06001E2E RID: 7726 RVA: 0x0000C047 File Offset: 0x0000A247
			public static ActivityManager.ActivityJoinHandler operator +(ActivityManager.ActivityJoinHandler A_0, ActivityManager.ActivityJoinHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ActivityManager.ActivityJoinHandler>();
			}

			// Token: 0x06001E2F RID: 7727 RVA: 0x0000C055 File Offset: 0x0000A255
			public static ActivityManager.ActivityJoinHandler operator -(ActivityManager.ActivityJoinHandler A_0, ActivityManager.ActivityJoinHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ActivityManager.ActivityJoinHandler>();
				}
				return delegate2;
			}

			// Token: 0x040017D1 RID: 6097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017D2 RID: 6098
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x040017D3 RID: 6099
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x040017D4 RID: 6100
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001FA RID: 506
		public sealed class ActivitySpectateHandler : MulticastDelegate
		{
			// Token: 0x06001E30 RID: 7728 RVA: 0x0008EB90 File Offset: 0x0008CD90
			// Note: this type is marked as 'beforefieldinit'.
			static ActivitySpectateHandler()
			{
				Il2CppClassPointerStore<ActivityManager.ActivitySpectateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "ActivitySpectateHandler");
				ActivityManager.ActivitySpectateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivitySpectateHandler>.NativeClassPtr, 100667303);
				ActivityManager.ActivitySpectateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivitySpectateHandler>.NativeClassPtr, 100667304);
				ActivityManager.ActivitySpectateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivitySpectateHandler>.NativeClassPtr, 100667305);
				ActivityManager.ActivitySpectateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivitySpectateHandler>.NativeClassPtr, 100667306);
			}

			// Token: 0x06001E31 RID: 7729 RVA: 0x0008EC04 File Offset: 0x0008CE04
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 51910, RefRangeEnd = 51916, XrefRangeStart = 51910, XrefRangeEnd = 51916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActivitySpectateHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.ActivitySpectateHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivitySpectateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E32 RID: 7730 RVA: 0x0008EC60 File Offset: 0x0008CE60
			[CallerCount(0)]
			public unsafe void Invoke(string secret)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(secret);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivitySpectateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E33 RID: 7731 RVA: 0x0008ECA4 File Offset: 0x0008CEA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string secret, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(secret);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivitySpectateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E34 RID: 7732 RVA: 0x0008ED18 File Offset: 0x0008CF18
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivitySpectateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E35 RID: 7733 RVA: 0x0000C066 File Offset: 0x0000A266
			public ActivitySpectateHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E36 RID: 7734 RVA: 0x0000C06F File Offset: 0x0000A26F
			public static implicit operator ActivityManager.ActivitySpectateHandler(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<ActivityManager.ActivitySpectateHandler>(A_0);
			}

			// Token: 0x06001E37 RID: 7735 RVA: 0x0000C077 File Offset: 0x0000A277
			public static ActivityManager.ActivitySpectateHandler operator +(ActivityManager.ActivitySpectateHandler A_0, ActivityManager.ActivitySpectateHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ActivityManager.ActivitySpectateHandler>();
			}

			// Token: 0x06001E38 RID: 7736 RVA: 0x0000C085 File Offset: 0x0000A285
			public static ActivityManager.ActivitySpectateHandler operator -(ActivityManager.ActivitySpectateHandler A_0, ActivityManager.ActivitySpectateHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ActivityManager.ActivitySpectateHandler>();
				}
				return delegate2;
			}

			// Token: 0x040017D5 RID: 6101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017D6 RID: 6102
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x040017D7 RID: 6103
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x040017D8 RID: 6104
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001FB RID: 507
		public sealed class ActivityJoinRequestHandler : MulticastDelegate
		{
			// Token: 0x06001E39 RID: 7737 RVA: 0x0008ED5C File Offset: 0x0008CF5C
			// Note: this type is marked as 'beforefieldinit'.
			static ActivityJoinRequestHandler()
			{
				Il2CppClassPointerStore<ActivityManager.ActivityJoinRequestHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "ActivityJoinRequestHandler");
				ActivityManager.ActivityJoinRequestHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityJoinRequestHandler>.NativeClassPtr, 100667307);
				ActivityManager.ActivityJoinRequestHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityJoinRequestHandler>.NativeClassPtr, 100667308);
				ActivityManager.ActivityJoinRequestHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_User_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityJoinRequestHandler>.NativeClassPtr, 100667309);
				ActivityManager.ActivityJoinRequestHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityJoinRequestHandler>.NativeClassPtr, 100667310);
			}

			// Token: 0x06001E3A RID: 7738 RVA: 0x0008EDD0 File Offset: 0x0008CFD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51916, XrefRangeEnd = 51920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActivityJoinRequestHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.ActivityJoinRequestHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityJoinRequestHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E3B RID: 7739 RVA: 0x0008EE2C File Offset: 0x0008D02C
			[CallerCount(0)]
			public unsafe void Invoke(ref User user)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityJoinRequestHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
				}
			}

			// Token: 0x06001E3C RID: 7740 RVA: 0x0008EE84 File Offset: 0x0008D084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51920, XrefRangeEnd = 51924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref User user, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityJoinRequestHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_User_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				user = ((intPtr4 == 0) ? null : new User(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06001E3D RID: 7741 RVA: 0x0008EF10 File Offset: 0x0008D110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref User user, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityJoinRequestHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				user = ((intPtr4 == 0) ? null : new User(intPtr4));
			}

			// Token: 0x06001E3E RID: 7742 RVA: 0x0000C096 File Offset: 0x0000A296
			public ActivityJoinRequestHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040017D9 RID: 6105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017DA RID: 6106
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_User_0;

			// Token: 0x040017DB RID: 6107
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_User_AsyncCallback_Object_0;

			// Token: 0x040017DC RID: 6108
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0;
		}

		// Token: 0x020001FC RID: 508
		public sealed class ActivityInviteHandler : MulticastDelegate
		{
			// Token: 0x06001E3F RID: 7743 RVA: 0x0008EF7C File Offset: 0x0008D17C
			// Note: this type is marked as 'beforefieldinit'.
			static ActivityInviteHandler()
			{
				Il2CppClassPointerStore<ActivityManager.ActivityInviteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivityManager>.NativeClassPtr, "ActivityInviteHandler");
				ActivityManager.ActivityInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityInviteHandler>.NativeClassPtr, 100667311);
				ActivityManager.ActivityInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ActivityActionType_byref_User_byref_Activity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityInviteHandler>.NativeClassPtr, 100667312);
				ActivityManager.ActivityInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ActivityActionType_byref_User_byref_Activity_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityInviteHandler>.NativeClassPtr, 100667313);
				ActivityManager.ActivityInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_byref_Activity_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityManager.ActivityInviteHandler>.NativeClassPtr, 100667314);
			}

			// Token: 0x06001E40 RID: 7744 RVA: 0x0008EFF0 File Offset: 0x0008D1F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51924, XrefRangeEnd = 51927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActivityInviteHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityManager.ActivityInviteHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityInviteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E41 RID: 7745 RVA: 0x0008F04C File Offset: 0x0008D24C
			[CallerCount(0)]
			public unsafe void Invoke(ActivityActionType type, ref User user, ref Activity activity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
				ptr2 = &intPtr;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(activity);
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityInviteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ActivityActionType_byref_User_byref_Activity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				user = ((intPtr5 == 0) ? null : new User(intPtr5));
				IntPtr intPtr6 = intPtr2;
				activity = ((intPtr6 == 0) ? null : new Activity(intPtr6));
			}

			// Token: 0x06001E42 RID: 7746 RVA: 0x0008F0E0 File Offset: 0x0008D2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51927, XrefRangeEnd = 51937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ActivityActionType type, ref User user, ref Activity activity, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
				ptr2 = &intPtr;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(activity);
				ptr3 = &intPtr2;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityInviteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ActivityActionType_byref_User_byref_Activity_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				user = ((intPtr5 == 0) ? null : new User(intPtr5));
				IntPtr intPtr6 = intPtr2;
				activity = ((intPtr6 == 0) ? null : new Activity(intPtr6));
				IntPtr intPtr7 = intPtr3;
				return (intPtr7 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr7) : null;
			}

			// Token: 0x06001E43 RID: 7747 RVA: 0x0008F1A8 File Offset: 0x0008D3A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref User user, ref Activity activity, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr2 = &intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(activity);
				ptr3 = &intPtr2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ActivityManager.ActivityInviteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_byref_Activity_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				user = ((intPtr5 == 0) ? null : new User(intPtr5));
				IntPtr intPtr6 = intPtr2;
				activity = ((intPtr6 == 0) ? null : new Activity(intPtr6));
			}

			// Token: 0x06001E44 RID: 7748 RVA: 0x0000C09F File Offset: 0x0000A29F
			public ActivityInviteHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040017DD RID: 6109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040017DE RID: 6110
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ActivityActionType_byref_User_byref_Activity_0;

			// Token: 0x040017DF RID: 6111
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ActivityActionType_byref_User_byref_Activity_AsyncCallback_Object_0;

			// Token: 0x040017E0 RID: 6112
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_byref_Activity_IAsyncResult_0;
		}
	}
}
