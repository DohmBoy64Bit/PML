using System;
using Discord;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000326 RID: 806
	public class DiscordController : MonoBehaviour
	{
		// Token: 0x0600453A RID: 17722 RVA: 0x0013596C File Offset: 0x00133B6C
		// Note: this type is marked as 'beforefieldinit'.
		static DiscordController()
		{
			Il2CppClassPointerStore<DiscordController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "DiscordController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscordController>.NativeClassPtr);
			DiscordController.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, "<Instance>k__BackingField");
			DiscordController.NativeFieldInfoPtr_discord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, "discord");
			DiscordController.NativeFieldInfoPtr_activityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, "activityManager");
			DiscordController.NativeFieldInfoPtr_currentActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, "currentActivity");
			DiscordController.NativeMethodInfoPtr_get_Instance_Public_Static_get_DiscordController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, 100674256);
			DiscordController.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DiscordController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, 100674257);
			DiscordController.NativeMethodInfoPtr_get_Activity_Public_get_Activity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, 100674258);
			DiscordController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, 100674264);
			DiscordController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, 100674259);
			DiscordController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, 100674260);
			DiscordController.NativeMethodInfoPtr_UpdateActivity_Public_Void_Activity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, 100674261);
			DiscordController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, 100674262);
			DiscordController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, 100674263);
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x00135AA0 File Offset: 0x00133CA0
		// (set) Token: 0x0600453C RID: 17724 RVA: 0x00135AD4 File Offset: 0x00133CD4
		public unsafe static DiscordController Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132179, XrefRangeEnd = 132181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.NativeMethodInfoPtr_get_Instance_Public_Static_get_DiscordController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DiscordController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132181, XrefRangeEnd = 132185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DiscordController_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x00135B0C File Offset: 0x00133D0C
		public unsafe Activity Activity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.NativeMethodInfoPtr_get_Activity_Public_get_Activity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr3) : null;
			}
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00135B4C File Offset: 0x00133D4C
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiscordController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscordController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00135B88 File Offset: 0x00133D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132185, XrefRangeEnd = 132189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00135BBC File Offset: 0x00133DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132189, XrefRangeEnd = 132202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00135BF0 File Offset: 0x00133DF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 132219, RefRangeEnd = 132226, XrefRangeStart = 132202, XrefRangeEnd = 132219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActivity(Activity activity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.NativeMethodInfoPtr_UpdateActivity_Public_Void_Activity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x00135C34 File Offset: 0x00133E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132226, XrefRangeEnd = 132227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x00135C68 File Offset: 0x00133E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132227, XrefRangeEnd = 132228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x000198C7 File Offset: 0x00017AC7
		public DiscordController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x00135C9C File Offset: 0x00133E9C
		// (set) Token: 0x06004546 RID: 17734 RVA: 0x000198D0 File Offset: 0x00017AD0
		public unsafe static DiscordController _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DiscordController.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DiscordController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiscordController.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x00135CC4 File Offset: 0x00133EC4
		// (set) Token: 0x06004548 RID: 17736 RVA: 0x000198E2 File Offset: 0x00017AE2
		public unsafe global::Discord.Discord discord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscordController.NativeFieldInfoPtr_discord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Discord.Discord>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscordController.NativeFieldInfoPtr_discord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x00135CF4 File Offset: 0x00133EF4
		// (set) Token: 0x0600454A RID: 17738 RVA: 0x00019901 File Offset: 0x00017B01
		public unsafe ActivityManager activityManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscordController.NativeFieldInfoPtr_activityManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscordController.NativeFieldInfoPtr_activityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x00135D24 File Offset: 0x00133F24
		// (set) Token: 0x0600454C RID: 17740 RVA: 0x00019920 File Offset: 0x00017B20
		public unsafe Activity currentActivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscordController.NativeFieldInfoPtr_currentActivity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiscordController.NativeFieldInfoPtr_currentActivity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035CC RID: 13772
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x040035CD RID: 13773
		private static readonly IntPtr NativeFieldInfoPtr_discord;

		// Token: 0x040035CE RID: 13774
		private static readonly IntPtr NativeFieldInfoPtr_activityManager;

		// Token: 0x040035CF RID: 13775
		private static readonly IntPtr NativeFieldInfoPtr_currentActivity;

		// Token: 0x040035D0 RID: 13776
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DiscordController_0;

		// Token: 0x040035D1 RID: 13777
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DiscordController_0;

		// Token: 0x040035D2 RID: 13778
		private static readonly IntPtr NativeMethodInfoPtr_get_Activity_Public_get_Activity_0;

		// Token: 0x040035D3 RID: 13779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035D4 RID: 13780
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040035D5 RID: 13781
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040035D6 RID: 13782
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActivity_Public_Void_Activity_0;

		// Token: 0x040035D7 RID: 13783
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040035D8 RID: 13784
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x02000427 RID: 1063
		[ObfuscatedName("Polytoria.Controllers.DiscordController+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060051AA RID: 20906 RVA: 0x0015CD74 File Offset: 0x0015AF74
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DiscordController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DiscordController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscordController.__c>.NativeClassPtr);
				DiscordController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscordController.__c>.NativeClassPtr, "<>9");
				DiscordController.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscordController.__c>.NativeClassPtr, "<>9__11_0");
				DiscordController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController.__c>.NativeClassPtr, 100674266);
				DiscordController.__c.NativeMethodInfoPtr__UpdateActivity_b__11_0_Internal_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscordController.__c>.NativeClassPtr, 100674267);
			}

			// Token: 0x060051AB RID: 20907 RVA: 0x0015CDF0 File Offset: 0x0015AFF0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscordController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051AC RID: 20908 RVA: 0x0015CE2C File Offset: 0x0015B02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132169, XrefRangeEnd = 132179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateActivity_b__11_0(Result res)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiscordController.__c.NativeMethodInfoPtr__UpdateActivity_b__11_0_Internal_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051AD RID: 20909 RVA: 0x0001F6FB File Offset: 0x0001D8FB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B8C RID: 7052
			// (get) Token: 0x060051AE RID: 20910 RVA: 0x0015CE70 File Offset: 0x0015B070
			// (set) Token: 0x060051AF RID: 20911 RVA: 0x0001F704 File Offset: 0x0001D904
			public unsafe static DiscordController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DiscordController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DiscordController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DiscordController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B8D RID: 7053
			// (get) Token: 0x060051B0 RID: 20912 RVA: 0x0015CE98 File Offset: 0x0015B098
			// (set) Token: 0x060051B1 RID: 20913 RVA: 0x0001F716 File Offset: 0x0001D916
			public unsafe static ActivityManager.UpdateActivityHandler __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DiscordController.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager.UpdateActivityHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DiscordController.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EAF RID: 16047
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003EB0 RID: 16048
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04003EB1 RID: 16049
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003EB2 RID: 16050
			private static readonly IntPtr NativeMethodInfoPtr__UpdateActivity_b__11_0_Internal_Void_Result_0;
		}
	}
}
