using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000165 RID: 357
	public class AchievementManager : Object
	{
		// Token: 0x0600186D RID: 6253 RVA: 0x0007ACCC File Offset: 0x00078ECC
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementManager()
		{
			Il2CppClassPointerStore<AchievementManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "AchievementManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr);
			AchievementManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "MethodsPtr");
			AchievementManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "MethodsStructure");
			AchievementManager.NativeFieldInfoPtr_OnUserAchievementUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "OnUserAchievementUpdate");
			AchievementManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668500);
			AchievementManager.NativeMethodInfoPtr_add_OnUserAchievementUpdate_Public_add_Void_UserAchievementUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668501);
			AchievementManager.NativeMethodInfoPtr_remove_OnUserAchievementUpdate_Public_rem_Void_UserAchievementUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668502);
			AchievementManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668503);
			AchievementManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668504);
			AchievementManager.NativeMethodInfoPtr_SetUserAchievementCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668505);
			AchievementManager.NativeMethodInfoPtr_SetUserAchievement_Public_Void_Int64_Byte_SetUserAchievementHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668506);
			AchievementManager.NativeMethodInfoPtr_FetchUserAchievementsCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668507);
			AchievementManager.NativeMethodInfoPtr_FetchUserAchievements_Public_Void_FetchUserAchievementsHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668508);
			AchievementManager.NativeMethodInfoPtr_CountUserAchievements_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668509);
			AchievementManager.NativeMethodInfoPtr_GetUserAchievement_Public_UserAchievement_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668510);
			AchievementManager.NativeMethodInfoPtr_GetUserAchievementAt_Public_UserAchievement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668511);
			AchievementManager.NativeMethodInfoPtr_OnUserAchievementUpdateImpl_Private_Static_Void_IntPtr_byref_UserAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100668512);
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x0007AE3C File Offset: 0x0007903C
		public unsafe AchievementManager.FFIMethods Methods
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 55493, RefRangeEnd = 55498, XrefRangeStart = 55480, XrefRangeEnd = 55493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AchievementManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0007AE74 File Offset: 0x00079074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55498, XrefRangeEnd = 55502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnUserAchievementUpdate(AchievementManager.UserAchievementUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_add_OnUserAchievementUpdate_Public_add_Void_UserAchievementUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0007AEB8 File Offset: 0x000790B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55502, XrefRangeEnd = 55506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnUserAchievementUpdate(AchievementManager.UserAchievementUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_remove_OnUserAchievementUpdate_Public_rem_Void_UserAchievementUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0007AEFC File Offset: 0x000790FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55522, RefRangeEnd = 55523, XrefRangeStart = 55506, XrefRangeEnd = 55522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref AchievementManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0007AF64 File Offset: 0x00079164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55523, XrefRangeEnd = 55540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref AchievementManager.FFIEvents events)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x0007AFB8 File Offset: 0x000791B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55540, XrefRangeEnd = 55547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_SetUserAchievementCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0007AFFC File Offset: 0x000791FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55547, XrefRangeEnd = 55558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUserAchievement(long achievementId, byte percentComplete, AchievementManager.SetUserAchievementHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref achievementId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percentComplete;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_SetUserAchievement_Public_Void_Int64_Byte_SetUserAchievementHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0007B05C File Offset: 0x0007925C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55558, XrefRangeEnd = 55565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_FetchUserAchievementsCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0007B0A0 File Offset: 0x000792A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55565, XrefRangeEnd = 55576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FetchUserAchievements(AchievementManager.FetchUserAchievementsHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_FetchUserAchievements_Public_Void_FetchUserAchievementsHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0007B0E4 File Offset: 0x000792E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55576, XrefRangeEnd = 55577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountUserAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_CountUserAchievements_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0007B120 File Offset: 0x00079320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55577, XrefRangeEnd = 55578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserAchievement GetUserAchievement(long userAchievementId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userAchievementId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_GetUserAchievement_Public_UserAchievement_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UserAchievement>(intPtr3) : null;
			}
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0007B16C File Offset: 0x0007936C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55578, XrefRangeEnd = 55579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserAchievement GetUserAchievementAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_GetUserAchievementAt_Public_UserAchievement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UserAchievement>(intPtr3) : null;
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0007B1B8 File Offset: 0x000793B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55579, XrefRangeEnd = 55585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_OnUserAchievementUpdateImpl_Private_Static_Void_IntPtr_byref_UserAchievement_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00009A26 File Offset: 0x00007C26
		public AchievementManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x0007B214 File Offset: 0x00079414
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x00009A2F File Offset: 0x00007C2F
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0007B23C File Offset: 0x0007943C
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x00009A4A File Offset: 0x00007C4A
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0007B26C File Offset: 0x0007946C
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x00009A69 File Offset: 0x00007C69
		public unsafe AchievementManager.UserAchievementUpdateHandler OnUserAchievementUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_OnUserAchievementUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManager.UserAchievementUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.NativeFieldInfoPtr_OnUserAchievementUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr_OnUserAchievementUpdate;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUserAchievementUpdate_Public_add_Void_UserAchievementUpdateHandler_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUserAchievementUpdate_Public_rem_Void_UserAchievementUpdateHandler_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_SetUserAchievementCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_SetUserAchievement_Public_Void_Int64_Byte_SetUserAchievementHandler_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_FetchUserAchievementsCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_FetchUserAchievements_Public_Void_FetchUserAchievementsHandler_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr_CountUserAchievements_Public_Int32_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_GetUserAchievement_Public_UserAchievement_Int64_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_GetUserAchievementAt_Public_UserAchievement_Int32_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_OnUserAchievementUpdateImpl_Private_Static_Void_IntPtr_byref_UserAchievement_0;

		// Token: 0x02000247 RID: 583
		public sealed class FFIEvents : ValueType
		{
			// Token: 0x0600214B RID: 8523 RVA: 0x0000DDF1 File Offset: 0x0000BFF1
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<AchievementManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager.FFIEvents>.NativeClassPtr);
				AchievementManager.FFIEvents.NativeFieldInfoPtr_OnUserAchievementUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.FFIEvents>.NativeClassPtr, "OnUserAchievementUpdate");
			}

			// Token: 0x0600214C RID: 8524 RVA: 0x0000DE25 File Offset: 0x0000C025
			public FFIEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600214D RID: 8525 RVA: 0x0000DE2E File Offset: 0x0000C02E
			public FFIEvents()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIEvents>.NativeClassPtr))
			{
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x0600214E RID: 8526 RVA: 0x00097B64 File Offset: 0x00095D64
			// (set) Token: 0x0600214F RID: 8527 RVA: 0x0000DE40 File Offset: 0x0000C040
			public unsafe AchievementManager.FFIEvents.UserAchievementUpdateHandler OnUserAchievementUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIEvents.NativeFieldInfoPtr_OnUserAchievementUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManager.FFIEvents.UserAchievementUpdateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIEvents.NativeFieldInfoPtr_OnUserAchievementUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001970 RID: 6512
			private static readonly IntPtr NativeFieldInfoPtr_OnUserAchievementUpdate;

			// Token: 0x02000317 RID: 791
			public sealed class UserAchievementUpdateHandler : MulticastDelegate
			{
				// Token: 0x060027D6 RID: 10198 RVA: 0x000B22A8 File Offset: 0x000B04A8
				// Note: this type is marked as 'beforefieldinit'.
				static UserAchievementUpdateHandler()
				{
					Il2CppClassPointerStore<AchievementManager.FFIEvents.UserAchievementUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager.FFIEvents>.NativeClassPtr, "UserAchievementUpdateHandler");
					AchievementManager.FFIEvents.UserAchievementUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIEvents.UserAchievementUpdateHandler>.NativeClassPtr, 100668513);
					AchievementManager.FFIEvents.UserAchievementUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_UserAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIEvents.UserAchievementUpdateHandler>.NativeClassPtr, 100668514);
					AchievementManager.FFIEvents.UserAchievementUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_UserAchievement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIEvents.UserAchievementUpdateHandler>.NativeClassPtr, 100668515);
					AchievementManager.FFIEvents.UserAchievementUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UserAchievement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIEvents.UserAchievementUpdateHandler>.NativeClassPtr, 100668516);
				}

				// Token: 0x060027D7 RID: 10199 RVA: 0x000B231C File Offset: 0x000B051C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UserAchievementUpdateHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIEvents.UserAchievementUpdateHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIEvents.UserAchievementUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027D8 RID: 10200 RVA: 0x000B2378 File Offset: 0x000B0578
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, ref UserAchievement userAchievement)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIEvents.UserAchievementUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_UserAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
				}

				// Token: 0x060027D9 RID: 10201 RVA: 0x000B23E0 File Offset: 0x000B05E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55422, XrefRangeEnd = 55428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, ref UserAchievement userAchievement, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIEvents.UserAchievementUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_UserAchievement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x060027DA RID: 10202 RVA: 0x000B247C File Offset: 0x000B067C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIEvents.UserAchievementUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UserAchievement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
				}

				// Token: 0x060027DB RID: 10203 RVA: 0x0000FD1F File Offset: 0x0000DF1F
				public UserAchievementUpdateHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001CA1 RID: 7329
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001CA2 RID: 7330
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_UserAchievement_0;

				// Token: 0x04001CA3 RID: 7331
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_UserAchievement_AsyncCallback_Object_0;

				// Token: 0x04001CA4 RID: 7332
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UserAchievement_IAsyncResult_0;
			}
		}

		// Token: 0x02000248 RID: 584
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06002150 RID: 8528 RVA: 0x00097B94 File Offset: 0x00095D94
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr);
				AchievementManager.FFIMethods.NativeFieldInfoPtr_SetUserAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "SetUserAchievement");
				AchievementManager.FFIMethods.NativeFieldInfoPtr_FetchUserAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "FetchUserAchievements");
				AchievementManager.FFIMethods.NativeFieldInfoPtr_CountUserAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "CountUserAchievements");
				AchievementManager.FFIMethods.NativeFieldInfoPtr_GetUserAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "GetUserAchievement");
				AchievementManager.FFIMethods.NativeFieldInfoPtr_GetUserAchievementAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "GetUserAchievementAt");
			}

			// Token: 0x06002151 RID: 8529 RVA: 0x0000DE5F File Offset: 0x0000C05F
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002152 RID: 8530 RVA: 0x0000DE68 File Offset: 0x0000C068
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x06002153 RID: 8531 RVA: 0x00097C24 File Offset: 0x00095E24
			// (set) Token: 0x06002154 RID: 8532 RVA: 0x0000DE7A File Offset: 0x0000C07A
			public unsafe AchievementManager.FFIMethods.SetUserAchievementMethod SetUserAchievement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_SetUserAchievement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManager.FFIMethods.SetUserAchievementMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_SetUserAchievement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x06002155 RID: 8533 RVA: 0x00097C54 File Offset: 0x00095E54
			// (set) Token: 0x06002156 RID: 8534 RVA: 0x0000DE99 File Offset: 0x0000C099
			public unsafe AchievementManager.FFIMethods.FetchUserAchievementsMethod FetchUserAchievements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_FetchUserAchievements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManager.FFIMethods.FetchUserAchievementsMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_FetchUserAchievements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078E RID: 1934
			// (get) Token: 0x06002157 RID: 8535 RVA: 0x00097C84 File Offset: 0x00095E84
			// (set) Token: 0x06002158 RID: 8536 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
			public unsafe AchievementManager.FFIMethods.CountUserAchievementsMethod CountUserAchievements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_CountUserAchievements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManager.FFIMethods.CountUserAchievementsMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_CountUserAchievements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x06002159 RID: 8537 RVA: 0x00097CB4 File Offset: 0x00095EB4
			// (set) Token: 0x0600215A RID: 8538 RVA: 0x0000DED7 File Offset: 0x0000C0D7
			public unsafe AchievementManager.FFIMethods.GetUserAchievementMethod GetUserAchievement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_GetUserAchievement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManager.FFIMethods.GetUserAchievementMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_GetUserAchievement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x0600215B RID: 8539 RVA: 0x00097CE4 File Offset: 0x00095EE4
			// (set) Token: 0x0600215C RID: 8540 RVA: 0x0000DEF6 File Offset: 0x0000C0F6
			public unsafe AchievementManager.FFIMethods.GetUserAchievementAtMethod GetUserAchievementAt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_GetUserAchievementAt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManager.FFIMethods.GetUserAchievementAtMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementManager.FFIMethods.NativeFieldInfoPtr_GetUserAchievementAt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001971 RID: 6513
			private static readonly IntPtr NativeFieldInfoPtr_SetUserAchievement;

			// Token: 0x04001972 RID: 6514
			private static readonly IntPtr NativeFieldInfoPtr_FetchUserAchievements;

			// Token: 0x04001973 RID: 6515
			private static readonly IntPtr NativeFieldInfoPtr_CountUserAchievements;

			// Token: 0x04001974 RID: 6516
			private static readonly IntPtr NativeFieldInfoPtr_GetUserAchievement;

			// Token: 0x04001975 RID: 6517
			private static readonly IntPtr NativeFieldInfoPtr_GetUserAchievementAt;

			// Token: 0x02000318 RID: 792
			public sealed class SetUserAchievementCallback : MulticastDelegate
			{
				// Token: 0x060027DC RID: 10204 RVA: 0x000B24E8 File Offset: 0x000B06E8
				// Note: this type is marked as 'beforefieldinit'.
				static SetUserAchievementCallback()
				{
					Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "SetUserAchievementCallback");
					AchievementManager.FFIMethods.SetUserAchievementCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementCallback>.NativeClassPtr, 100668517);
					AchievementManager.FFIMethods.SetUserAchievementCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementCallback>.NativeClassPtr, 100668518);
					AchievementManager.FFIMethods.SetUserAchievementCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementCallback>.NativeClassPtr, 100668519);
					AchievementManager.FFIMethods.SetUserAchievementCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementCallback>.NativeClassPtr, 100668520);
				}

				// Token: 0x060027DD RID: 10205 RVA: 0x000B255C File Offset: 0x000B075C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetUserAchievementCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.SetUserAchievementCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027DE RID: 10206 RVA: 0x000B25B8 File Offset: 0x000B07B8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.SetUserAchievementCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027DF RID: 10207 RVA: 0x000B2608 File Offset: 0x000B0808
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55428, XrefRangeEnd = 55434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.SetUserAchievementCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027E0 RID: 10208 RVA: 0x000B268C File Offset: 0x000B088C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.SetUserAchievementCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060027E1 RID: 10209 RVA: 0x0000FD28 File Offset: 0x0000DF28
				public SetUserAchievementCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060027E2 RID: 10210 RVA: 0x0000FD31 File Offset: 0x0000DF31
				public static implicit operator AchievementManager.FFIMethods.SetUserAchievementCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<AchievementManager.FFIMethods.SetUserAchievementCallback>(A_0);
				}

				// Token: 0x060027E3 RID: 10211 RVA: 0x0000FD39 File Offset: 0x0000DF39
				public static AchievementManager.FFIMethods.SetUserAchievementCallback operator +(AchievementManager.FFIMethods.SetUserAchievementCallback A_0, AchievementManager.FFIMethods.SetUserAchievementCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<AchievementManager.FFIMethods.SetUserAchievementCallback>();
				}

				// Token: 0x060027E4 RID: 10212 RVA: 0x0000FD47 File Offset: 0x0000DF47
				public static AchievementManager.FFIMethods.SetUserAchievementCallback operator -(AchievementManager.FFIMethods.SetUserAchievementCallback A_0, AchievementManager.FFIMethods.SetUserAchievementCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<AchievementManager.FFIMethods.SetUserAchievementCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001CA5 RID: 7333
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001CA6 RID: 7334
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001CA7 RID: 7335
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001CA8 RID: 7336
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000319 RID: 793
			public sealed class SetUserAchievementMethod : MulticastDelegate
			{
				// Token: 0x060027E5 RID: 10213 RVA: 0x000B26D0 File Offset: 0x000B08D0
				// Note: this type is marked as 'beforefieldinit'.
				static SetUserAchievementMethod()
				{
					Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "SetUserAchievementMethod");
					AchievementManager.FFIMethods.SetUserAchievementMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementMethod>.NativeClassPtr, 100668521);
					AchievementManager.FFIMethods.SetUserAchievementMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Byte_IntPtr_SetUserAchievementCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementMethod>.NativeClassPtr, 100668522);
					AchievementManager.FFIMethods.SetUserAchievementMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Byte_IntPtr_SetUserAchievementCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementMethod>.NativeClassPtr, 100668523);
					AchievementManager.FFIMethods.SetUserAchievementMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementMethod>.NativeClassPtr, 100668524);
				}

				// Token: 0x060027E6 RID: 10214 RVA: 0x000B2744 File Offset: 0x000B0944
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55434, XrefRangeEnd = 55437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetUserAchievementMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIMethods.SetUserAchievementMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.SetUserAchievementMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027E7 RID: 10215 RVA: 0x000B27A0 File Offset: 0x000B09A0
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, AchievementManager.FFIMethods.SetUserAchievementCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref achievementId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percentComplete;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.SetUserAchievementMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Byte_IntPtr_SetUserAchievementCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027E8 RID: 10216 RVA: 0x000B281C File Offset: 0x000B0A1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55437, XrefRangeEnd = 55446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, AchievementManager.FFIMethods.SetUserAchievementCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref achievementId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percentComplete;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.SetUserAchievementMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Byte_IntPtr_SetUserAchievementCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027E9 RID: 10217 RVA: 0x000B28CC File Offset: 0x000B0ACC
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.SetUserAchievementMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060027EA RID: 10218 RVA: 0x0000FD58 File Offset: 0x0000DF58
				public SetUserAchievementMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060027EB RID: 10219 RVA: 0x0000FD61 File Offset: 0x0000DF61
				public static implicit operator AchievementManager.FFIMethods.SetUserAchievementMethod(Action<IntPtr, long, byte, IntPtr, AchievementManager.FFIMethods.SetUserAchievementCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<AchievementManager.FFIMethods.SetUserAchievementMethod>(A_0);
				}

				// Token: 0x060027EC RID: 10220 RVA: 0x0000FD69 File Offset: 0x0000DF69
				public static AchievementManager.FFIMethods.SetUserAchievementMethod operator +(AchievementManager.FFIMethods.SetUserAchievementMethod A_0, AchievementManager.FFIMethods.SetUserAchievementMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<AchievementManager.FFIMethods.SetUserAchievementMethod>();
				}

				// Token: 0x060027ED RID: 10221 RVA: 0x0000FD77 File Offset: 0x0000DF77
				public static AchievementManager.FFIMethods.SetUserAchievementMethod operator -(AchievementManager.FFIMethods.SetUserAchievementMethod A_0, AchievementManager.FFIMethods.SetUserAchievementMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<AchievementManager.FFIMethods.SetUserAchievementMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001CA9 RID: 7337
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001CAA RID: 7338
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Byte_IntPtr_SetUserAchievementCallback_0;

				// Token: 0x04001CAB RID: 7339
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Byte_IntPtr_SetUserAchievementCallback_AsyncCallback_Object_0;

				// Token: 0x04001CAC RID: 7340
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200031A RID: 794
			public sealed class FetchUserAchievementsCallback : MulticastDelegate
			{
				// Token: 0x060027EE RID: 10222 RVA: 0x000B2910 File Offset: 0x000B0B10
				// Note: this type is marked as 'beforefieldinit'.
				static FetchUserAchievementsCallback()
				{
					Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "FetchUserAchievementsCallback");
					AchievementManager.FFIMethods.FetchUserAchievementsCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsCallback>.NativeClassPtr, 100668525);
					AchievementManager.FFIMethods.FetchUserAchievementsCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsCallback>.NativeClassPtr, 100668526);
					AchievementManager.FFIMethods.FetchUserAchievementsCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsCallback>.NativeClassPtr, 100668527);
					AchievementManager.FFIMethods.FetchUserAchievementsCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsCallback>.NativeClassPtr, 100668528);
				}

				// Token: 0x060027EF RID: 10223 RVA: 0x000B2984 File Offset: 0x000B0B84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FetchUserAchievementsCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.FetchUserAchievementsCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027F0 RID: 10224 RVA: 0x000B29E0 File Offset: 0x000B0BE0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.FetchUserAchievementsCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027F1 RID: 10225 RVA: 0x000B2A30 File Offset: 0x000B0C30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55446, XrefRangeEnd = 55452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.FetchUserAchievementsCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027F2 RID: 10226 RVA: 0x000B2AB4 File Offset: 0x000B0CB4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.FetchUserAchievementsCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060027F3 RID: 10227 RVA: 0x0000FD88 File Offset: 0x0000DF88
				public FetchUserAchievementsCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060027F4 RID: 10228 RVA: 0x0000FD91 File Offset: 0x0000DF91
				public static implicit operator AchievementManager.FFIMethods.FetchUserAchievementsCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<AchievementManager.FFIMethods.FetchUserAchievementsCallback>(A_0);
				}

				// Token: 0x060027F5 RID: 10229 RVA: 0x0000FD99 File Offset: 0x0000DF99
				public static AchievementManager.FFIMethods.FetchUserAchievementsCallback operator +(AchievementManager.FFIMethods.FetchUserAchievementsCallback A_0, AchievementManager.FFIMethods.FetchUserAchievementsCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<AchievementManager.FFIMethods.FetchUserAchievementsCallback>();
				}

				// Token: 0x060027F6 RID: 10230 RVA: 0x0000FDA7 File Offset: 0x0000DFA7
				public static AchievementManager.FFIMethods.FetchUserAchievementsCallback operator -(AchievementManager.FFIMethods.FetchUserAchievementsCallback A_0, AchievementManager.FFIMethods.FetchUserAchievementsCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<AchievementManager.FFIMethods.FetchUserAchievementsCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001CAD RID: 7341
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001CAE RID: 7342
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001CAF RID: 7343
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001CB0 RID: 7344
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200031B RID: 795
			public sealed class FetchUserAchievementsMethod : MulticastDelegate
			{
				// Token: 0x060027F7 RID: 10231 RVA: 0x000B2AF8 File Offset: 0x000B0CF8
				// Note: this type is marked as 'beforefieldinit'.
				static FetchUserAchievementsMethod()
				{
					Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "FetchUserAchievementsMethod");
					AchievementManager.FFIMethods.FetchUserAchievementsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsMethod>.NativeClassPtr, 100668529);
					AchievementManager.FFIMethods.FetchUserAchievementsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FetchUserAchievementsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsMethod>.NativeClassPtr, 100668530);
					AchievementManager.FFIMethods.FetchUserAchievementsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FetchUserAchievementsCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsMethod>.NativeClassPtr, 100668531);
					AchievementManager.FFIMethods.FetchUserAchievementsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsMethod>.NativeClassPtr, 100668532);
				}

				// Token: 0x060027F8 RID: 10232 RVA: 0x000B2B6C File Offset: 0x000B0D6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FetchUserAchievementsMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIMethods.FetchUserAchievementsMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.FetchUserAchievementsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027F9 RID: 10233 RVA: 0x000B2BC8 File Offset: 0x000B0DC8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr callbackData, AchievementManager.FFIMethods.FetchUserAchievementsCallback callback)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.FetchUserAchievementsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FetchUserAchievementsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060027FA RID: 10234 RVA: 0x000B2C28 File Offset: 0x000B0E28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, AchievementManager.FFIMethods.FetchUserAchievementsCallback callback, AsyncCallback __callback, Object @object)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.FetchUserAchievementsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FetchUserAchievementsCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060027FB RID: 10235 RVA: 0x000B2CBC File Offset: 0x000B0EBC
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.FetchUserAchievementsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060027FC RID: 10236 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
				public FetchUserAchievementsMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060027FD RID: 10237 RVA: 0x0000FDC1 File Offset: 0x0000DFC1
				public static implicit operator AchievementManager.FFIMethods.FetchUserAchievementsMethod(Action<IntPtr, IntPtr, AchievementManager.FFIMethods.FetchUserAchievementsCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<AchievementManager.FFIMethods.FetchUserAchievementsMethod>(A_0);
				}

				// Token: 0x060027FE RID: 10238 RVA: 0x0000FDC9 File Offset: 0x0000DFC9
				public static AchievementManager.FFIMethods.FetchUserAchievementsMethod operator +(AchievementManager.FFIMethods.FetchUserAchievementsMethod A_0, AchievementManager.FFIMethods.FetchUserAchievementsMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<AchievementManager.FFIMethods.FetchUserAchievementsMethod>();
				}

				// Token: 0x060027FF RID: 10239 RVA: 0x0000FDD7 File Offset: 0x0000DFD7
				public static AchievementManager.FFIMethods.FetchUserAchievementsMethod operator -(AchievementManager.FFIMethods.FetchUserAchievementsMethod A_0, AchievementManager.FFIMethods.FetchUserAchievementsMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<AchievementManager.FFIMethods.FetchUserAchievementsMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001CB1 RID: 7345
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001CB2 RID: 7346
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_FetchUserAchievementsCallback_0;

				// Token: 0x04001CB3 RID: 7347
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_FetchUserAchievementsCallback_AsyncCallback_Object_0;

				// Token: 0x04001CB4 RID: 7348
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200031C RID: 796
			public sealed class CountUserAchievementsMethod : MulticastDelegate
			{
				// Token: 0x06002800 RID: 10240 RVA: 0x000B2D00 File Offset: 0x000B0F00
				// Note: this type is marked as 'beforefieldinit'.
				static CountUserAchievementsMethod()
				{
					Il2CppClassPointerStore<AchievementManager.FFIMethods.CountUserAchievementsMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "CountUserAchievementsMethod");
					AchievementManager.FFIMethods.CountUserAchievementsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.CountUserAchievementsMethod>.NativeClassPtr, 100668533);
					AchievementManager.FFIMethods.CountUserAchievementsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.CountUserAchievementsMethod>.NativeClassPtr, 100668534);
					AchievementManager.FFIMethods.CountUserAchievementsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.CountUserAchievementsMethod>.NativeClassPtr, 100668535);
					AchievementManager.FFIMethods.CountUserAchievementsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.CountUserAchievementsMethod>.NativeClassPtr, 100668536);
				}

				// Token: 0x06002801 RID: 10241 RVA: 0x000B2D74 File Offset: 0x000B0F74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CountUserAchievementsMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIMethods.CountUserAchievementsMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.CountUserAchievementsMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002802 RID: 10242 RVA: 0x000B2DD0 File Offset: 0x000B0FD0
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ref int count)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.CountUserAchievementsMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002803 RID: 10243 RVA: 0x000B2E1C File Offset: 0x000B101C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.CountUserAchievementsMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002804 RID: 10244 RVA: 0x000B2E9C File Offset: 0x000B109C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref int count, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &count;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.CountUserAchievementsMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002805 RID: 10245 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
				public CountUserAchievementsMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001CB5 RID: 7349
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001CB6 RID: 7350
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0;

				// Token: 0x04001CB7 RID: 7351
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0;

				// Token: 0x04001CB8 RID: 7352
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0;
			}

			// Token: 0x0200031D RID: 797
			public sealed class GetUserAchievementMethod : MulticastDelegate
			{
				// Token: 0x06002806 RID: 10246 RVA: 0x000B2EEC File Offset: 0x000B10EC
				// Note: this type is marked as 'beforefieldinit'.
				static GetUserAchievementMethod()
				{
					Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "GetUserAchievementMethod");
					AchievementManager.FFIMethods.GetUserAchievementMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementMethod>.NativeClassPtr, 100668537);
					AchievementManager.FFIMethods.GetUserAchievementMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_UserAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementMethod>.NativeClassPtr, 100668538);
					AchievementManager.FFIMethods.GetUserAchievementMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_UserAchievement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementMethod>.NativeClassPtr, 100668539);
					AchievementManager.FFIMethods.GetUserAchievementMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_UserAchievement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementMethod>.NativeClassPtr, 100668540);
				}

				// Token: 0x06002807 RID: 10247 RVA: 0x000B2F60 File Offset: 0x000B1160
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetUserAchievementMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.GetUserAchievementMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002808 RID: 10248 RVA: 0x000B2FBC File Offset: 0x000B11BC
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userAchievementId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.GetUserAchievementMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_UserAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002809 RID: 10249 RVA: 0x000B3040 File Offset: 0x000B1240
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55452, XrefRangeEnd = 55460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userAchievementId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.GetUserAchievementMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_UserAchievement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x0600280A RID: 10250 RVA: 0x000B30EC File Offset: 0x000B12EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.GetUserAchievementMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_UserAchievement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x0600280B RID: 10251 RVA: 0x0000FDF1 File Offset: 0x0000DFF1
				public GetUserAchievementMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001CB9 RID: 7353
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001CBA RID: 7354
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_UserAchievement_0;

				// Token: 0x04001CBB RID: 7355
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_UserAchievement_AsyncCallback_Object_0;

				// Token: 0x04001CBC RID: 7356
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_UserAchievement_IAsyncResult_0;
			}

			// Token: 0x0200031E RID: 798
			public sealed class GetUserAchievementAtMethod : MulticastDelegate
			{
				// Token: 0x0600280C RID: 10252 RVA: 0x000B3168 File Offset: 0x000B1368
				// Note: this type is marked as 'beforefieldinit'.
				static GetUserAchievementAtMethod()
				{
					Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementAtMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager.FFIMethods>.NativeClassPtr, "GetUserAchievementAtMethod");
					AchievementManager.FFIMethods.GetUserAchievementAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementAtMethod>.NativeClassPtr, 100668541);
					AchievementManager.FFIMethods.GetUserAchievementAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_UserAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementAtMethod>.NativeClassPtr, 100668542);
					AchievementManager.FFIMethods.GetUserAchievementAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_UserAchievement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementAtMethod>.NativeClassPtr, 100668543);
					AchievementManager.FFIMethods.GetUserAchievementAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_UserAchievement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementAtMethod>.NativeClassPtr, 100668544);
				}

				// Token: 0x0600280D RID: 10253 RVA: 0x000B31DC File Offset: 0x000B13DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetUserAchievementAtMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FFIMethods.GetUserAchievementAtMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.GetUserAchievementAtMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600280E RID: 10254 RVA: 0x000B3238 File Offset: 0x000B1438
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.GetUserAchievementAtMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_UserAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x0600280F RID: 10255 RVA: 0x000B32BC File Offset: 0x000B14BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55460, XrefRangeEnd = 55468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.GetUserAchievementAtMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_UserAchievement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002810 RID: 10256 RVA: 0x000B3368 File Offset: 0x000B1568
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FFIMethods.GetUserAchievementAtMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_UserAchievement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002811 RID: 10257 RVA: 0x0000FDFA File Offset: 0x0000DFFA
				public GetUserAchievementAtMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001CBD RID: 7357
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001CBE RID: 7358
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_UserAchievement_0;

				// Token: 0x04001CBF RID: 7359
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_UserAchievement_AsyncCallback_Object_0;

				// Token: 0x04001CC0 RID: 7360
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_UserAchievement_IAsyncResult_0;
			}
		}

		// Token: 0x02000249 RID: 585
		public sealed class SetUserAchievementHandler : MulticastDelegate
		{
			// Token: 0x0600215D RID: 8541 RVA: 0x00097D14 File Offset: 0x00095F14
			// Note: this type is marked as 'beforefieldinit'.
			static SetUserAchievementHandler()
			{
				Il2CppClassPointerStore<AchievementManager.SetUserAchievementHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "SetUserAchievementHandler");
				AchievementManager.SetUserAchievementHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.SetUserAchievementHandler>.NativeClassPtr, 100668545);
				AchievementManager.SetUserAchievementHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.SetUserAchievementHandler>.NativeClassPtr, 100668546);
				AchievementManager.SetUserAchievementHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.SetUserAchievementHandler>.NativeClassPtr, 100668547);
				AchievementManager.SetUserAchievementHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.SetUserAchievementHandler>.NativeClassPtr, 100668548);
			}

			// Token: 0x0600215E RID: 8542 RVA: 0x00097D88 File Offset: 0x00095F88
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetUserAchievementHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.SetUserAchievementHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.SetUserAchievementHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600215F RID: 8543 RVA: 0x00097DE4 File Offset: 0x00095FE4
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.SetUserAchievementHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002160 RID: 8544 RVA: 0x00097E28 File Offset: 0x00096028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55468, XrefRangeEnd = 55472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.SetUserAchievementHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002161 RID: 8545 RVA: 0x00097E9C File Offset: 0x0009609C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.SetUserAchievementHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002162 RID: 8546 RVA: 0x0000DF15 File Offset: 0x0000C115
			public SetUserAchievementHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002163 RID: 8547 RVA: 0x0000DF1E File Offset: 0x0000C11E
			public static implicit operator AchievementManager.SetUserAchievementHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<AchievementManager.SetUserAchievementHandler>(A_0);
			}

			// Token: 0x06002164 RID: 8548 RVA: 0x0000DF26 File Offset: 0x0000C126
			public static AchievementManager.SetUserAchievementHandler operator +(AchievementManager.SetUserAchievementHandler A_0, AchievementManager.SetUserAchievementHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AchievementManager.SetUserAchievementHandler>();
			}

			// Token: 0x06002165 RID: 8549 RVA: 0x0000DF34 File Offset: 0x0000C134
			public static AchievementManager.SetUserAchievementHandler operator -(AchievementManager.SetUserAchievementHandler A_0, AchievementManager.SetUserAchievementHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AchievementManager.SetUserAchievementHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001976 RID: 6518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001977 RID: 6519
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x04001978 RID: 6520
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x04001979 RID: 6521
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200024A RID: 586
		public sealed class FetchUserAchievementsHandler : MulticastDelegate
		{
			// Token: 0x06002166 RID: 8550 RVA: 0x00097EE0 File Offset: 0x000960E0
			// Note: this type is marked as 'beforefieldinit'.
			static FetchUserAchievementsHandler()
			{
				Il2CppClassPointerStore<AchievementManager.FetchUserAchievementsHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "FetchUserAchievementsHandler");
				AchievementManager.FetchUserAchievementsHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FetchUserAchievementsHandler>.NativeClassPtr, 100668549);
				AchievementManager.FetchUserAchievementsHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FetchUserAchievementsHandler>.NativeClassPtr, 100668550);
				AchievementManager.FetchUserAchievementsHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FetchUserAchievementsHandler>.NativeClassPtr, 100668551);
				AchievementManager.FetchUserAchievementsHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.FetchUserAchievementsHandler>.NativeClassPtr, 100668552);
			}

			// Token: 0x06002167 RID: 8551 RVA: 0x00097F54 File Offset: 0x00096154
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FetchUserAchievementsHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.FetchUserAchievementsHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FetchUserAchievementsHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002168 RID: 8552 RVA: 0x00097FB0 File Offset: 0x000961B0
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FetchUserAchievementsHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002169 RID: 8553 RVA: 0x00097FF4 File Offset: 0x000961F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55472, XrefRangeEnd = 55476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FetchUserAchievementsHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600216A RID: 8554 RVA: 0x00098068 File Offset: 0x00096268
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.FetchUserAchievementsHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600216B RID: 8555 RVA: 0x0000DF45 File Offset: 0x0000C145
			public FetchUserAchievementsHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600216C RID: 8556 RVA: 0x0000DF4E File Offset: 0x0000C14E
			public static implicit operator AchievementManager.FetchUserAchievementsHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<AchievementManager.FetchUserAchievementsHandler>(A_0);
			}

			// Token: 0x0600216D RID: 8557 RVA: 0x0000DF56 File Offset: 0x0000C156
			public static AchievementManager.FetchUserAchievementsHandler operator +(AchievementManager.FetchUserAchievementsHandler A_0, AchievementManager.FetchUserAchievementsHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AchievementManager.FetchUserAchievementsHandler>();
			}

			// Token: 0x0600216E RID: 8558 RVA: 0x0000DF64 File Offset: 0x0000C164
			public static AchievementManager.FetchUserAchievementsHandler operator -(AchievementManager.FetchUserAchievementsHandler A_0, AchievementManager.FetchUserAchievementsHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AchievementManager.FetchUserAchievementsHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400197A RID: 6522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400197B RID: 6523
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x0400197C RID: 6524
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x0400197D RID: 6525
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200024B RID: 587
		public sealed class UserAchievementUpdateHandler : MulticastDelegate
		{
			// Token: 0x0600216F RID: 8559 RVA: 0x000980AC File Offset: 0x000962AC
			// Note: this type is marked as 'beforefieldinit'.
			static UserAchievementUpdateHandler()
			{
				Il2CppClassPointerStore<AchievementManager.UserAchievementUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "UserAchievementUpdateHandler");
				AchievementManager.UserAchievementUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.UserAchievementUpdateHandler>.NativeClassPtr, 100668553);
				AchievementManager.UserAchievementUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_UserAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.UserAchievementUpdateHandler>.NativeClassPtr, 100668554);
				AchievementManager.UserAchievementUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_UserAchievement_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.UserAchievementUpdateHandler>.NativeClassPtr, 100668555);
				AchievementManager.UserAchievementUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UserAchievement_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.UserAchievementUpdateHandler>.NativeClassPtr, 100668556);
			}

			// Token: 0x06002170 RID: 8560 RVA: 0x00098120 File Offset: 0x00096320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UserAchievementUpdateHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.UserAchievementUpdateHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.UserAchievementUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002171 RID: 8561 RVA: 0x0009817C File Offset: 0x0009637C
			[CallerCount(0)]
			public unsafe void Invoke(ref UserAchievement userAchievement)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.UserAchievementUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_UserAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
				}
			}

			// Token: 0x06002172 RID: 8562 RVA: 0x000981D4 File Offset: 0x000963D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55476, XrefRangeEnd = 55480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ref UserAchievement userAchievement, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.UserAchievementUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_UserAchievement_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06002173 RID: 8563 RVA: 0x00098260 File Offset: 0x00096460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(userAchievement);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AchievementManager.UserAchievementUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UserAchievement_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				userAchievement = ((intPtr4 == 0) ? null : new UserAchievement(intPtr4));
			}

			// Token: 0x06002174 RID: 8564 RVA: 0x0000DF75 File Offset: 0x0000C175
			public UserAchievementUpdateHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400197E RID: 6526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400197F RID: 6527
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_UserAchievement_0;

			// Token: 0x04001980 RID: 6528
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_UserAchievement_AsyncCallback_Object_0;

			// Token: 0x04001981 RID: 6529
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_UserAchievement_IAsyncResult_0;
		}
	}
}
