using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200015C RID: 348
	public class UserManager : Object
	{
		// Token: 0x0600173E RID: 5950 RVA: 0x000750C4 File Offset: 0x000732C4
		// Note: this type is marked as 'beforefieldinit'.
		static UserManager()
		{
			Il2CppClassPointerStore<UserManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "UserManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserManager>.NativeClassPtr);
			UserManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserManager>.NativeClassPtr, "MethodsPtr");
			UserManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserManager>.NativeClassPtr, "MethodsStructure");
			UserManager.NativeFieldInfoPtr_OnCurrentUserUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserManager>.NativeClassPtr, "OnCurrentUserUpdate");
			UserManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667525);
			UserManager.NativeMethodInfoPtr_add_OnCurrentUserUpdate_Public_add_Void_CurrentUserUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667526);
			UserManager.NativeMethodInfoPtr_remove_OnCurrentUserUpdate_Public_rem_Void_CurrentUserUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667527);
			UserManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667528);
			UserManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667529);
			UserManager.NativeMethodInfoPtr_GetCurrentUser_Public_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667530);
			UserManager.NativeMethodInfoPtr_GetUserCallbackImpl_Private_Static_Void_IntPtr_Result_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667531);
			UserManager.NativeMethodInfoPtr_GetUser_Public_Void_Int64_GetUserHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667532);
			UserManager.NativeMethodInfoPtr_GetCurrentUserPremiumType_Public_PremiumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667533);
			UserManager.NativeMethodInfoPtr_CurrentUserHasFlag_Public_Boolean_UserFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667534);
			UserManager.NativeMethodInfoPtr_OnCurrentUserUpdateImpl_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager>.NativeClassPtr, 100667535);
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x0007520C File Offset: 0x0007340C
		public unsafe UserManager.FFIMethods Methods
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 52800, RefRangeEnd = 52804, XrefRangeStart = 52787, XrefRangeEnd = 52800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new UserManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00075244 File Offset: 0x00073444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52804, XrefRangeEnd = 52808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnCurrentUserUpdate(UserManager.CurrentUserUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_add_OnCurrentUserUpdate_Public_add_Void_CurrentUserUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00075288 File Offset: 0x00073488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52808, XrefRangeEnd = 52812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnCurrentUserUpdate(UserManager.CurrentUserUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_remove_OnCurrentUserUpdate_Public_rem_Void_CurrentUserUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x000752CC File Offset: 0x000734CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52812, XrefRangeEnd = 52828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserManager(IntPtr ptr, IntPtr eventsPtr, ref UserManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00075334 File Offset: 0x00073534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52828, XrefRangeEnd = 52845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref UserManager.FFIEvents events)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00075388 File Offset: 0x00073588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52845, XrefRangeEnd = 52846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe User GetCurrentUser()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_GetCurrentUser_Public_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<User>(intPtr3) : null;
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x000753C8 File Offset: 0x000735C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52846, XrefRangeEnd = 52853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_GetUserCallbackImpl_Private_Static_Void_IntPtr_Result_byref_User_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			user = ((intPtr4 == 0) ? null : new User(intPtr4));
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00075434 File Offset: 0x00073634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52853, XrefRangeEnd = 52864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUser(long userId, UserManager.GetUserHandler callback)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_GetUser_Public_Void_Int64_GetUserHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00075484 File Offset: 0x00073684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52864, XrefRangeEnd = 52865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PremiumType GetCurrentUserPremiumType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_GetCurrentUserPremiumType_Public_PremiumType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PremiumType>(intPtr3) : null;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000754C4 File Offset: 0x000736C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52865, XrefRangeEnd = 52866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CurrentUserHasFlag(UserFlag flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_CurrentUserHasFlag_Public_Boolean_UserFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00075514 File Offset: 0x00073714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52866, XrefRangeEnd = 52872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnCurrentUserUpdateImpl(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.NativeMethodInfoPtr_OnCurrentUserUpdateImpl_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000095BC File Offset: 0x000077BC
		public UserManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x00075548 File Offset: 0x00073748
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x000095C5 File Offset: 0x000077C5
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x00075570 File Offset: 0x00073770
		// (set) Token: 0x0600174E RID: 5966 RVA: 0x000095E0 File Offset: 0x000077E0
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x000755A0 File Offset: 0x000737A0
		// (set) Token: 0x06001750 RID: 5968 RVA: 0x000095FF File Offset: 0x000077FF
		public unsafe UserManager.CurrentUserUpdateHandler OnCurrentUserUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.NativeFieldInfoPtr_OnCurrentUserUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserManager.CurrentUserUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.NativeFieldInfoPtr_OnCurrentUserUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeFieldInfoPtr_OnCurrentUserUpdate;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_add_OnCurrentUserUpdate_Public_add_Void_CurrentUserUpdateHandler_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnCurrentUserUpdate_Public_rem_Void_CurrentUserUpdateHandler_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentUser_Public_User_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_GetUserCallbackImpl_Private_Static_Void_IntPtr_Result_byref_User_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr_GetUser_Public_Void_Int64_GetUserHandler_0;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentUserPremiumType_Public_PremiumType_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_CurrentUserHasFlag_Public_Boolean_UserFlag_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_OnCurrentUserUpdateImpl_Private_Static_Void_IntPtr_0;

		// Token: 0x02000209 RID: 521
		public sealed class FFIEvents : ValueType
		{
			// Token: 0x06001EB8 RID: 7864 RVA: 0x0000C5F7 File Offset: 0x0000A7F7
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<UserManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserManager.FFIEvents>.NativeClassPtr);
				UserManager.FFIEvents.NativeFieldInfoPtr_OnCurrentUserUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserManager.FFIEvents>.NativeClassPtr, "OnCurrentUserUpdate");
			}

			// Token: 0x06001EB9 RID: 7865 RVA: 0x0000C62B File Offset: 0x0000A82B
			public FFIEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EBA RID: 7866 RVA: 0x0000C634 File Offset: 0x0000A834
			public FFIEvents()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.FFIEvents>.NativeClassPtr))
			{
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00090628 File Offset: 0x0008E828
			// (set) Token: 0x06001EBC RID: 7868 RVA: 0x0000C646 File Offset: 0x0000A846
			public unsafe UserManager.FFIEvents.CurrentUserUpdateHandler OnCurrentUserUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIEvents.NativeFieldInfoPtr_OnCurrentUserUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserManager.FFIEvents.CurrentUserUpdateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIEvents.NativeFieldInfoPtr_OnCurrentUserUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001849 RID: 6217
			private static readonly IntPtr NativeFieldInfoPtr_OnCurrentUserUpdate;

			// Token: 0x02000285 RID: 645
			public sealed class CurrentUserUpdateHandler : MulticastDelegate
			{
				// Token: 0x06002347 RID: 9031 RVA: 0x0009ED6C File Offset: 0x0009CF6C
				// Note: this type is marked as 'beforefieldinit'.
				static CurrentUserUpdateHandler()
				{
					Il2CppClassPointerStore<UserManager.FFIEvents.CurrentUserUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager.FFIEvents>.NativeClassPtr, "CurrentUserUpdateHandler");
					UserManager.FFIEvents.CurrentUserUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIEvents.CurrentUserUpdateHandler>.NativeClassPtr, 100667536);
					UserManager.FFIEvents.CurrentUserUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIEvents.CurrentUserUpdateHandler>.NativeClassPtr, 100667537);
					UserManager.FFIEvents.CurrentUserUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIEvents.CurrentUserUpdateHandler>.NativeClassPtr, 100667538);
					UserManager.FFIEvents.CurrentUserUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIEvents.CurrentUserUpdateHandler>.NativeClassPtr, 100667539);
				}

				// Token: 0x06002348 RID: 9032 RVA: 0x0009EDE0 File Offset: 0x0009CFE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CurrentUserUpdateHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.FFIEvents.CurrentUserUpdateHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIEvents.CurrentUserUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002349 RID: 9033 RVA: 0x0009EE3C File Offset: 0x0009D03C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIEvents.CurrentUserUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600234A RID: 9034 RVA: 0x0009EE7C File Offset: 0x0009D07C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIEvents.CurrentUserUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600234B RID: 9035 RVA: 0x0009EEEC File Offset: 0x0009D0EC
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIEvents.CurrentUserUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600234C RID: 9036 RVA: 0x0000E936 File Offset: 0x0000CB36
				public CurrentUserUpdateHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600234D RID: 9037 RVA: 0x0000E93F File Offset: 0x0000CB3F
				public static implicit operator UserManager.FFIEvents.CurrentUserUpdateHandler(Action<IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<UserManager.FFIEvents.CurrentUserUpdateHandler>(A_0);
				}

				// Token: 0x0600234E RID: 9038 RVA: 0x0000E947 File Offset: 0x0000CB47
				public static UserManager.FFIEvents.CurrentUserUpdateHandler operator +(UserManager.FFIEvents.CurrentUserUpdateHandler A_0, UserManager.FFIEvents.CurrentUserUpdateHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<UserManager.FFIEvents.CurrentUserUpdateHandler>();
				}

				// Token: 0x0600234F RID: 9039 RVA: 0x0000E955 File Offset: 0x0000CB55
				public static UserManager.FFIEvents.CurrentUserUpdateHandler operator -(UserManager.FFIEvents.CurrentUserUpdateHandler A_0, UserManager.FFIEvents.CurrentUserUpdateHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<UserManager.FFIEvents.CurrentUserUpdateHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001A59 RID: 6745
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A5A RID: 6746
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

				// Token: 0x04001A5B RID: 6747
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A5C RID: 6748
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}

		// Token: 0x0200020A RID: 522
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001EBD RID: 7869 RVA: 0x00090658 File Offset: 0x0008E858
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr);
				UserManager.FFIMethods.NativeFieldInfoPtr_GetCurrentUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr, "GetCurrentUser");
				UserManager.FFIMethods.NativeFieldInfoPtr_GetUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr, "GetUser");
				UserManager.FFIMethods.NativeFieldInfoPtr_GetCurrentUserPremiumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr, "GetCurrentUserPremiumType");
				UserManager.FFIMethods.NativeFieldInfoPtr_CurrentUserHasFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr, "CurrentUserHasFlag");
			}

			// Token: 0x06001EBE RID: 7870 RVA: 0x0000C665 File Offset: 0x0000A865
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EBF RID: 7871 RVA: 0x0000C66E File Offset: 0x0000A86E
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x000906D4 File Offset: 0x0008E8D4
			// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x0000C680 File Offset: 0x0000A880
			public unsafe UserManager.FFIMethods.GetCurrentUserMethod GetCurrentUser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIMethods.NativeFieldInfoPtr_GetCurrentUser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserManager.FFIMethods.GetCurrentUserMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIMethods.NativeFieldInfoPtr_GetCurrentUser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00090704 File Offset: 0x0008E904
			// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x0000C69F File Offset: 0x0000A89F
			public unsafe UserManager.FFIMethods.GetUserMethod GetUser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIMethods.NativeFieldInfoPtr_GetUser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserManager.FFIMethods.GetUserMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIMethods.NativeFieldInfoPtr_GetUser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00090734 File Offset: 0x0008E934
			// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x0000C6BE File Offset: 0x0000A8BE
			public unsafe UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIMethods.NativeFieldInfoPtr_GetCurrentUserPremiumType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIMethods.NativeFieldInfoPtr_GetCurrentUserPremiumType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x00090764 File Offset: 0x0008E964
			// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x0000C6DD File Offset: 0x0000A8DD
			public unsafe UserManager.FFIMethods.CurrentUserHasFlagMethod CurrentUserHasFlag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIMethods.NativeFieldInfoPtr_CurrentUserHasFlag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserManager.FFIMethods.CurrentUserHasFlagMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserManager.FFIMethods.NativeFieldInfoPtr_CurrentUserHasFlag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400184A RID: 6218
			private static readonly IntPtr NativeFieldInfoPtr_GetCurrentUser;

			// Token: 0x0400184B RID: 6219
			private static readonly IntPtr NativeFieldInfoPtr_GetUser;

			// Token: 0x0400184C RID: 6220
			private static readonly IntPtr NativeFieldInfoPtr_GetCurrentUserPremiumType;

			// Token: 0x0400184D RID: 6221
			private static readonly IntPtr NativeFieldInfoPtr_CurrentUserHasFlag;

			// Token: 0x02000286 RID: 646
			public sealed class GetCurrentUserMethod : MulticastDelegate
			{
				// Token: 0x06002350 RID: 9040 RVA: 0x0009EF30 File Offset: 0x0009D130
				// Note: this type is marked as 'beforefieldinit'.
				static GetCurrentUserMethod()
				{
					Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr, "GetCurrentUserMethod");
					UserManager.FFIMethods.GetCurrentUserMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserMethod>.NativeClassPtr, 100667540);
					UserManager.FFIMethods.GetCurrentUserMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserMethod>.NativeClassPtr, 100667541);
					UserManager.FFIMethods.GetCurrentUserMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_User_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserMethod>.NativeClassPtr, 100667542);
					UserManager.FFIMethods.GetCurrentUserMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_User_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserMethod>.NativeClassPtr, 100667543);
				}

				// Token: 0x06002351 RID: 9041 RVA: 0x0009EFA4 File Offset: 0x0009D1A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetCurrentUserMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetCurrentUserMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002352 RID: 9042 RVA: 0x0009F000 File Offset: 0x0009D200
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ref User currentUser)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentUser);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetCurrentUserMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					currentUser = ((intPtr4 == 0) ? null : new User(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002353 RID: 9043 RVA: 0x0009F078 File Offset: 0x0009D278
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52746, XrefRangeEnd = 52752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref User currentUser, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentUser);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetCurrentUserMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_User_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					currentUser = ((intPtr4 == 0) ? null : new User(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002354 RID: 9044 RVA: 0x0009F114 File Offset: 0x0009D314
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52752, XrefRangeEnd = 52754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref User currentUser, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentUser);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetCurrentUserMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_User_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					currentUser = ((intPtr4 == 0) ? null : new User(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002355 RID: 9045 RVA: 0x0000E966 File Offset: 0x0000CB66
				public GetCurrentUserMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A5D RID: 6749
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A5E RID: 6750
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_User_0;

				// Token: 0x04001A5F RID: 6751
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_User_AsyncCallback_Object_0;

				// Token: 0x04001A60 RID: 6752
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_User_IAsyncResult_0;
			}

			// Token: 0x02000287 RID: 647
			public sealed class GetUserCallback : MulticastDelegate
			{
				// Token: 0x06002356 RID: 9046 RVA: 0x0009F190 File Offset: 0x0009D390
				// Note: this type is marked as 'beforefieldinit'.
				static GetUserCallback()
				{
					Il2CppClassPointerStore<UserManager.FFIMethods.GetUserCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr, "GetUserCallback");
					UserManager.FFIMethods.GetUserCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserCallback>.NativeClassPtr, 100667544);
					UserManager.FFIMethods.GetUserCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserCallback>.NativeClassPtr, 100667545);
					UserManager.FFIMethods.GetUserCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_User_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserCallback>.NativeClassPtr, 100667546);
					UserManager.FFIMethods.GetUserCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserCallback>.NativeClassPtr, 100667547);
				}

				// Token: 0x06002357 RID: 9047 RVA: 0x0009F204 File Offset: 0x0009D404
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetUserCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetUserCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002358 RID: 9048 RVA: 0x0009F260 File Offset: 0x0009D460
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result, ref User user)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetUserCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
				}

				// Token: 0x06002359 RID: 9049 RVA: 0x0009F2D8 File Offset: 0x0009D4D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52754, XrefRangeEnd = 52763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref User user, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetUserCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_User_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x0600235A RID: 9050 RVA: 0x0009F388 File Offset: 0x0009D588
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetUserCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
				}

				// Token: 0x0600235B RID: 9051 RVA: 0x0000E96F File Offset: 0x0000CB6F
				public GetUserCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A61 RID: 6753
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A62 RID: 6754
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_User_0;

				// Token: 0x04001A63 RID: 6755
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_User_AsyncCallback_Object_0;

				// Token: 0x04001A64 RID: 6756
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0;
			}

			// Token: 0x02000288 RID: 648
			public sealed class GetUserMethod : MulticastDelegate
			{
				// Token: 0x0600235C RID: 9052 RVA: 0x0009F3F4 File Offset: 0x0009D5F4
				// Note: this type is marked as 'beforefieldinit'.
				static GetUserMethod()
				{
					Il2CppClassPointerStore<UserManager.FFIMethods.GetUserMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr, "GetUserMethod");
					UserManager.FFIMethods.GetUserMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserMethod>.NativeClassPtr, 100667548);
					UserManager.FFIMethods.GetUserMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_GetUserCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserMethod>.NativeClassPtr, 100667549);
					UserManager.FFIMethods.GetUserMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_GetUserCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserMethod>.NativeClassPtr, 100667550);
					UserManager.FFIMethods.GetUserMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserMethod>.NativeClassPtr, 100667551);
				}

				// Token: 0x0600235D RID: 9053 RVA: 0x0009F468 File Offset: 0x0009D668
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetUserMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.FFIMethods.GetUserMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetUserMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600235E RID: 9054 RVA: 0x0009F4C4 File Offset: 0x0009D6C4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long userId, IntPtr callbackData, UserManager.FFIMethods.GetUserCallback callback)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetUserMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_GetUserCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600235F RID: 9055 RVA: 0x0009F534 File Offset: 0x0009D734
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, IntPtr callbackData, UserManager.FFIMethods.GetUserCallback callback, AsyncCallback __callback, Object @object)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetUserMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_GetUserCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002360 RID: 9056 RVA: 0x0009F5D8 File Offset: 0x0009D7D8
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetUserMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002361 RID: 9057 RVA: 0x0000E978 File Offset: 0x0000CB78
				public GetUserMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002362 RID: 9058 RVA: 0x0000E981 File Offset: 0x0000CB81
				public static implicit operator UserManager.FFIMethods.GetUserMethod(Action<IntPtr, long, IntPtr, UserManager.FFIMethods.GetUserCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<UserManager.FFIMethods.GetUserMethod>(A_0);
				}

				// Token: 0x06002363 RID: 9059 RVA: 0x0000E989 File Offset: 0x0000CB89
				public static UserManager.FFIMethods.GetUserMethod operator +(UserManager.FFIMethods.GetUserMethod A_0, UserManager.FFIMethods.GetUserMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<UserManager.FFIMethods.GetUserMethod>();
				}

				// Token: 0x06002364 RID: 9060 RVA: 0x0000E997 File Offset: 0x0000CB97
				public static UserManager.FFIMethods.GetUserMethod operator -(UserManager.FFIMethods.GetUserMethod A_0, UserManager.FFIMethods.GetUserMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<UserManager.FFIMethods.GetUserMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A65 RID: 6757
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A66 RID: 6758
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_GetUserCallback_0;

				// Token: 0x04001A67 RID: 6759
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_GetUserCallback_AsyncCallback_Object_0;

				// Token: 0x04001A68 RID: 6760
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000289 RID: 649
			public sealed class GetCurrentUserPremiumTypeMethod : MulticastDelegate
			{
				// Token: 0x06002365 RID: 9061 RVA: 0x0009F61C File Offset: 0x0009D81C
				// Note: this type is marked as 'beforefieldinit'.
				static GetCurrentUserPremiumTypeMethod()
				{
					Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr, "GetCurrentUserPremiumTypeMethod");
					UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod>.NativeClassPtr, 100667552);
					UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_PremiumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod>.NativeClassPtr, 100667553);
					UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_PremiumType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod>.NativeClassPtr, 100667554);
					UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_PremiumType_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod>.NativeClassPtr, 100667555);
				}

				// Token: 0x06002366 RID: 9062 RVA: 0x0009F690 File Offset: 0x0009D890
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetCurrentUserPremiumTypeMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002367 RID: 9063 RVA: 0x0009F6EC File Offset: 0x0009D8EC
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ref PremiumType premiumType)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &premiumType;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_PremiumType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002368 RID: 9064 RVA: 0x0009F748 File Offset: 0x0009D948
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52763, XrefRangeEnd = 52769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref PremiumType premiumType, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &premiumType;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_PremiumType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002369 RID: 9065 RVA: 0x0009F7C8 File Offset: 0x0009D9C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref PremiumType premiumType, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &premiumType;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_PremiumType_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600236A RID: 9066 RVA: 0x0000E9A8 File Offset: 0x0000CBA8
				public GetCurrentUserPremiumTypeMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A69 RID: 6761
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A6A RID: 6762
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_PremiumType_0;

				// Token: 0x04001A6B RID: 6763
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_PremiumType_AsyncCallback_Object_0;

				// Token: 0x04001A6C RID: 6764
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_PremiumType_IAsyncResult_0;
			}

			// Token: 0x0200028A RID: 650
			public sealed class CurrentUserHasFlagMethod : MulticastDelegate
			{
				// Token: 0x0600236B RID: 9067 RVA: 0x0009F828 File Offset: 0x0009DA28
				// Note: this type is marked as 'beforefieldinit'.
				static CurrentUserHasFlagMethod()
				{
					Il2CppClassPointerStore<UserManager.FFIMethods.CurrentUserHasFlagMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager.FFIMethods>.NativeClassPtr, "CurrentUserHasFlagMethod");
					UserManager.FFIMethods.CurrentUserHasFlagMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.CurrentUserHasFlagMethod>.NativeClassPtr, 100667556);
					UserManager.FFIMethods.CurrentUserHasFlagMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UserFlag_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.CurrentUserHasFlagMethod>.NativeClassPtr, 100667557);
					UserManager.FFIMethods.CurrentUserHasFlagMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UserFlag_byref_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.CurrentUserHasFlagMethod>.NativeClassPtr, 100667558);
					UserManager.FFIMethods.CurrentUserHasFlagMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.FFIMethods.CurrentUserHasFlagMethod>.NativeClassPtr, 100667559);
				}

				// Token: 0x0600236C RID: 9068 RVA: 0x0009F89C File Offset: 0x0009DA9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52769, XrefRangeEnd = 52772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CurrentUserHasFlagMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.FFIMethods.CurrentUserHasFlagMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.CurrentUserHasFlagMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600236D RID: 9069 RVA: 0x0009F8F8 File Offset: 0x0009DAF8
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flag);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasFlag;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.CurrentUserHasFlagMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UserFlag_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600236E RID: 9070 RVA: 0x0009F964 File Offset: 0x0009DB64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52772, XrefRangeEnd = 52780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flag);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasFlag;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.CurrentUserHasFlagMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UserFlag_byref_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600236F RID: 9071 RVA: 0x0009F9F8 File Offset: 0x0009DBF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref bool hasFlag, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &hasFlag;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.FFIMethods.CurrentUserHasFlagMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002370 RID: 9072 RVA: 0x0000E9B1 File Offset: 0x0000CBB1
				public CurrentUserHasFlagMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001A6D RID: 6765
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A6E RID: 6766
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UserFlag_byref_Boolean_0;

				// Token: 0x04001A6F RID: 6767
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UserFlag_byref_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001A70 RID: 6768
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Boolean_IAsyncResult_0;
			}
		}

		// Token: 0x0200020B RID: 523
		public sealed class GetUserHandler : MulticastDelegate
		{
			// Token: 0x06001EC8 RID: 7880 RVA: 0x00090794 File Offset: 0x0008E994
			// Note: this type is marked as 'beforefieldinit'.
			static GetUserHandler()
			{
				Il2CppClassPointerStore<UserManager.GetUserHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager>.NativeClassPtr, "GetUserHandler");
				UserManager.GetUserHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.GetUserHandler>.NativeClassPtr, 100667560);
				UserManager.GetUserHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.GetUserHandler>.NativeClassPtr, 100667561);
				UserManager.GetUserHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_User_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.GetUserHandler>.NativeClassPtr, 100667562);
				UserManager.GetUserHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.GetUserHandler>.NativeClassPtr, 100667563);
			}

			// Token: 0x06001EC9 RID: 7881 RVA: 0x00090808 File Offset: 0x0008EA08
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52325, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetUserHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.GetUserHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.GetUserHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ECA RID: 7882 RVA: 0x00090864 File Offset: 0x0008EA64
			[CallerCount(0)]
			public unsafe void Invoke(Result result, ref User user)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.GetUserHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				user = ((intPtr4 == 0) ? null : new User(intPtr4));
			}

			// Token: 0x06001ECB RID: 7883 RVA: 0x000908D0 File Offset: 0x0008EAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52780, XrefRangeEnd = 52787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, ref User user, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.GetUserHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_User_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				user = ((intPtr4 == 0) ? null : new User(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06001ECC RID: 7884 RVA: 0x00090970 File Offset: 0x0008EB70
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UserManager.GetUserHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				user = ((intPtr4 == 0) ? null : new User(intPtr4));
			}

			// Token: 0x06001ECD RID: 7885 RVA: 0x0000C6FC File Offset: 0x0000A8FC
			public GetUserHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400184E RID: 6222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400184F RID: 6223
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_User_0;

			// Token: 0x04001850 RID: 6224
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_User_AsyncCallback_Object_0;

			// Token: 0x04001851 RID: 6225
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_User_IAsyncResult_0;
		}

		// Token: 0x0200020C RID: 524
		public sealed class CurrentUserUpdateHandler : MulticastDelegate
		{
			// Token: 0x06001ECE RID: 7886 RVA: 0x000909DC File Offset: 0x0008EBDC
			// Note: this type is marked as 'beforefieldinit'.
			static CurrentUserUpdateHandler()
			{
				Il2CppClassPointerStore<UserManager.CurrentUserUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserManager>.NativeClassPtr, "CurrentUserUpdateHandler");
				UserManager.CurrentUserUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.CurrentUserUpdateHandler>.NativeClassPtr, 100667564);
				UserManager.CurrentUserUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.CurrentUserUpdateHandler>.NativeClassPtr, 100667565);
				UserManager.CurrentUserUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.CurrentUserUpdateHandler>.NativeClassPtr, 100667566);
				UserManager.CurrentUserUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserManager.CurrentUserUpdateHandler>.NativeClassPtr, 100667567);
			}

			// Token: 0x06001ECF RID: 7887 RVA: 0x00090A50 File Offset: 0x0008EC50
			[CallerCount(247)]
			[CachedScanResults(RefRangeStart = 14625, RefRangeEnd = 14872, XrefRangeStart = 14625, XrefRangeEnd = 14872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CurrentUserUpdateHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserManager.CurrentUserUpdateHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.CurrentUserUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ED0 RID: 7888 RVA: 0x00090AAC File Offset: 0x0008ECAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.CurrentUserUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ED1 RID: 7889 RVA: 0x00090AE0 File Offset: 0x0008ECE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.CurrentUserUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001ED2 RID: 7890 RVA: 0x00090B44 File Offset: 0x0008ED44
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserManager.CurrentUserUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001ED3 RID: 7891 RVA: 0x0000C705 File Offset: 0x0000A905
			public CurrentUserUpdateHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001ED4 RID: 7892 RVA: 0x0000C70E File Offset: 0x0000A90E
			public static implicit operator UserManager.CurrentUserUpdateHandler(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<UserManager.CurrentUserUpdateHandler>(A_0);
			}

			// Token: 0x06001ED5 RID: 7893 RVA: 0x0000C716 File Offset: 0x0000A916
			public static UserManager.CurrentUserUpdateHandler operator +(UserManager.CurrentUserUpdateHandler A_0, UserManager.CurrentUserUpdateHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<UserManager.CurrentUserUpdateHandler>();
			}

			// Token: 0x06001ED6 RID: 7894 RVA: 0x0000C724 File Offset: 0x0000A924
			public static UserManager.CurrentUserUpdateHandler operator -(UserManager.CurrentUserUpdateHandler A_0, UserManager.CurrentUserUpdateHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<UserManager.CurrentUserUpdateHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001852 RID: 6226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001853 RID: 6227
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001854 RID: 6228
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001855 RID: 6229
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
