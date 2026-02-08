using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000154 RID: 340
	public sealed class UserAchievement : ValueType
	{
		// Token: 0x0600168C RID: 5772 RVA: 0x00073068 File Offset: 0x00071268
		// Note: this type is marked as 'beforefieldinit'.
		static UserAchievement()
		{
			Il2CppClassPointerStore<UserAchievement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "UserAchievement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserAchievement>.NativeClassPtr);
			UserAchievement.NativeFieldInfoPtr_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievement>.NativeClassPtr, "UserId");
			UserAchievement.NativeFieldInfoPtr_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievement>.NativeClassPtr, "AchievementId");
			UserAchievement.NativeFieldInfoPtr_PercentComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievement>.NativeClassPtr, "PercentComplete");
			UserAchievement.NativeFieldInfoPtr_UnlockedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievement>.NativeClassPtr, "UnlockedAt");
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00008E27 File Offset: 0x00007027
		public UserAchievement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00008E30 File Offset: 0x00007030
		public UserAchievement()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserAchievement>.NativeClassPtr))
		{
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x000730E8 File Offset: 0x000712E8
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00008E42 File Offset: 0x00007042
		public unsafe long UserId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievement.NativeFieldInfoPtr_UserId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievement.NativeFieldInfoPtr_UserId)) = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x00073110 File Offset: 0x00071310
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x00008E5D File Offset: 0x0000705D
		public unsafe long AchievementId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievement.NativeFieldInfoPtr_AchievementId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievement.NativeFieldInfoPtr_AchievementId)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00073138 File Offset: 0x00071338
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x00008E78 File Offset: 0x00007078
		public unsafe byte PercentComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievement.NativeFieldInfoPtr_PercentComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievement.NativeFieldInfoPtr_PercentComplete)) = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x00073160 File Offset: 0x00071360
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x00008E93 File Offset: 0x00007093
		public unsafe string UnlockedAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievement.NativeFieldInfoPtr_UnlockedAt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievement.NativeFieldInfoPtr_UnlockedAt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeFieldInfoPtr_UserId;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeFieldInfoPtr_AchievementId;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeFieldInfoPtr_PercentComplete;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedAt;
	}
}
