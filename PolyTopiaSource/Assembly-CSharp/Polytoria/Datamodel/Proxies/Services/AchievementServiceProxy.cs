using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x02000309 RID: 777
	public class AchievementServiceProxy : Object
	{
		// Token: 0x06004357 RID: 17239 RVA: 0x0012E62C File Offset: 0x0012C82C
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementServiceProxy()
		{
			Il2CppClassPointerStore<AchievementServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "AchievementServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementServiceProxy>.NativeClassPtr);
			AchievementServiceProxy.NativeFieldInfoPtr_achievementService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementServiceProxy>.NativeClassPtr, "achievementService");
			AchievementServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_AchievementService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementServiceProxy>.NativeClassPtr, 100673959);
			AchievementServiceProxy.NativeMethodInfoPtr_Award_Public_Void_Int32_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementServiceProxy>.NativeClassPtr, 100673960);
			AchievementServiceProxy.NativeMethodInfoPtr_HasAchievement_Public_Void_Int32_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementServiceProxy>.NativeClassPtr, 100673961);
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x0012E6AC File Offset: 0x0012C8AC
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementServiceProxy(AchievementService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_AchievementService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x0012E6F8 File Offset: 0x0012C8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129182, XrefRangeEnd = 129184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Award(int userID, int achievementID, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref achievementID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementServiceProxy.NativeMethodInfoPtr_Award_Public_Void_Int32_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x0012E758 File Offset: 0x0012C958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129184, XrefRangeEnd = 129186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HasAchievement(int userID, int achievementID, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref achievementID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementServiceProxy.NativeMethodInfoPtr_HasAchievement_Public_Void_Int32_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x00018DA9 File Offset: 0x00016FA9
		public AchievementServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x0600435C RID: 17244 RVA: 0x0012E7B8 File Offset: 0x0012C9B8
		// (set) Token: 0x0600435D RID: 17245 RVA: 0x00018DB2 File Offset: 0x00016FB2
		public unsafe AchievementService achievementService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementServiceProxy.NativeFieldInfoPtr_achievementService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementServiceProxy.NativeFieldInfoPtr_achievementService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400347B RID: 13435
		private static readonly IntPtr NativeFieldInfoPtr_achievementService;

		// Token: 0x0400347C RID: 13436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AchievementService_0;

		// Token: 0x0400347D RID: 13437
		private static readonly IntPtr NativeMethodInfoPtr_Award_Public_Void_Int32_Int32_DynValue_0;

		// Token: 0x0400347E RID: 13438
		private static readonly IntPtr NativeMethodInfoPtr_HasAchievement_Public_Void_Int32_Int32_DynValue_0;
	}
}
