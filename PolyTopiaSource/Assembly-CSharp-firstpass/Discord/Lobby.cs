using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200014C RID: 332
	public sealed class Lobby : ValueType
	{
		// Token: 0x06001655 RID: 5717 RVA: 0x000729DC File Offset: 0x00070BDC
		// Note: this type is marked as 'beforefieldinit'.
		static Lobby()
		{
			Il2CppClassPointerStore<Lobby>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "Lobby");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby>.NativeClassPtr);
			Lobby.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "Id");
			Lobby.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "Type");
			Lobby.NativeFieldInfoPtr_OwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "OwnerId");
			Lobby.NativeFieldInfoPtr_Secret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "Secret");
			Lobby.NativeFieldInfoPtr_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "Capacity");
			Lobby.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "Locked");
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00008B7B File Offset: 0x00006D7B
		public Lobby(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00008B84 File Offset: 0x00006D84
		public Lobby()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby>.NativeClassPtr))
		{
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x00072A84 File Offset: 0x00070C84
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x00008B96 File Offset: 0x00006D96
		public unsafe long Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Id)) = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x00072AAC File Offset: 0x00070CAC
		// (set) Token: 0x0600165B RID: 5723 RVA: 0x00008BB1 File Offset: 0x00006DB1
		public unsafe LobbyType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x00072ADC File Offset: 0x00070CDC
		// (set) Token: 0x0600165D RID: 5725 RVA: 0x00008BD0 File Offset: 0x00006DD0
		public unsafe long OwnerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_OwnerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_OwnerId)) = value;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x00072B04 File Offset: 0x00070D04
		// (set) Token: 0x0600165F RID: 5727 RVA: 0x00008BEB File Offset: 0x00006DEB
		public unsafe string Secret
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Secret);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Secret), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x00072B2C File Offset: 0x00070D2C
		// (set) Token: 0x06001661 RID: 5729 RVA: 0x00008C0A File Offset: 0x00006E0A
		public unsafe uint Capacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Capacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Capacity)) = value;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x00072B54 File Offset: 0x00070D54
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x00008C25 File Offset: 0x00006E25
		public unsafe bool Locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Locked)) = value;
			}
		}

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeFieldInfoPtr_OwnerId;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeFieldInfoPtr_Secret;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeFieldInfoPtr_Capacity;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeFieldInfoPtr_Locked;
	}
}
