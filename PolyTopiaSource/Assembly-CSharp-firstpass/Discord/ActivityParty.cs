using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000147 RID: 327
	public sealed class ActivityParty : ValueType
	{
		// Token: 0x0600161C RID: 5660 RVA: 0x000723A0 File Offset: 0x000705A0
		// Note: this type is marked as 'beforefieldinit'.
		static ActivityParty()
		{
			Il2CppClassPointerStore<ActivityParty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ActivityParty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityParty>.NativeClassPtr);
			ActivityParty.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityParty>.NativeClassPtr, "Id");
			ActivityParty.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityParty>.NativeClassPtr, "Size");
			ActivityParty.NativeFieldInfoPtr_Privacy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityParty>.NativeClassPtr, "Privacy");
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00008871 File Offset: 0x00006A71
		public ActivityParty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0000887A File Offset: 0x00006A7A
		public ActivityParty()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityParty>.NativeClassPtr))
		{
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x0007240C File Offset: 0x0007060C
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x0000888C File Offset: 0x00006A8C
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityParty.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityParty.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00072434 File Offset: 0x00070634
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x000088AB File Offset: 0x00006AAB
		public unsafe PartySize Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityParty.NativeFieldInfoPtr_Size);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartySize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityParty.NativeFieldInfoPtr_Size), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00072464 File Offset: 0x00070664
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x000088CA File Offset: 0x00006ACA
		public unsafe ActivityPartyPrivacy Privacy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityParty.NativeFieldInfoPtr_Privacy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityPartyPrivacy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityParty.NativeFieldInfoPtr_Privacy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeFieldInfoPtr_Privacy;
	}
}
