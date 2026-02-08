using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000149 RID: 329
	public sealed class Activity : ValueType
	{
		// Token: 0x0600162E RID: 5678 RVA: 0x00072578 File Offset: 0x00070778
		// Note: this type is marked as 'beforefieldinit'.
		static Activity()
		{
			Il2CppClassPointerStore<Activity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "Activity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Activity>.NativeClassPtr);
			Activity.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "Type");
			Activity.NativeFieldInfoPtr_ApplicationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ApplicationId");
			Activity.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "Name");
			Activity.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "State");
			Activity.NativeFieldInfoPtr_Details = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "Details");
			Activity.NativeFieldInfoPtr_Timestamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "Timestamps");
			Activity.NativeFieldInfoPtr_Assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "Assets");
			Activity.NativeFieldInfoPtr_Party = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "Party");
			Activity.NativeFieldInfoPtr_Secrets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "Secrets");
			Activity.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "Instance");
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00008961 File Offset: 0x00006B61
		public Activity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0000896A File Offset: 0x00006B6A
		public Activity()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Activity>.NativeClassPtr))
		{
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00072670 File Offset: 0x00070870
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x0000897C File Offset: 0x00006B7C
		public unsafe ActivityType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x000726A0 File Offset: 0x000708A0
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x0000899B File Offset: 0x00006B9B
		public unsafe long ApplicationId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_ApplicationId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_ApplicationId)) = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x000726C8 File Offset: 0x000708C8
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x000089B6 File Offset: 0x00006BB6
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x000726F0 File Offset: 0x000708F0
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x000089D5 File Offset: 0x00006BD5
		public unsafe string State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_State);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_State), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x00072718 File Offset: 0x00070918
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x000089F4 File Offset: 0x00006BF4
		public unsafe string Details
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Details);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Details), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x00072740 File Offset: 0x00070940
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x00008A13 File Offset: 0x00006C13
		public unsafe ActivityTimestamps Timestamps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Timestamps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityTimestamps>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Timestamps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x00072770 File Offset: 0x00070970
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x00008A32 File Offset: 0x00006C32
		public unsafe ActivityAssets Assets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Assets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityAssets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Assets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x000727A0 File Offset: 0x000709A0
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x00008A51 File Offset: 0x00006C51
		public unsafe ActivityParty Party
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Party);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityParty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Party), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x000727D0 File Offset: 0x000709D0
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x00008A70 File Offset: 0x00006C70
		public unsafe ActivitySecrets Secrets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Secrets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivitySecrets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Secrets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x00072800 File Offset: 0x00070A00
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x00008A8F File Offset: 0x00006C8F
		public unsafe bool Instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Instance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_Instance)) = value;
			}
		}

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeFieldInfoPtr_ApplicationId;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr_Details;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr_Timestamps;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr_Assets;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_Party;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr_Secrets;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr_Instance;
	}
}
