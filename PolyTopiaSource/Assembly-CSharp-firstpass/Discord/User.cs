using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000140 RID: 320
	public sealed class User : ValueType
	{
		// Token: 0x060015F1 RID: 5617 RVA: 0x00071E14 File Offset: 0x00070014
		// Note: this type is marked as 'beforefieldinit'.
		static User()
		{
			Il2CppClassPointerStore<User>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "User");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<User>.NativeClassPtr);
			User.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, "Id");
			User.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, "Username");
			User.NativeFieldInfoPtr_Discriminator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, "Discriminator");
			User.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, "Avatar");
			User.NativeFieldInfoPtr_Bot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<User>.NativeClassPtr, "Bot");
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00008670 File Offset: 0x00006870
		public User(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00008679 File Offset: 0x00006879
		public User()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<User>.NativeClassPtr))
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x00071EA8 File Offset: 0x000700A8
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x0000868B File Offset: 0x0000688B
		public unsafe long Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Id)) = value;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00071ED0 File Offset: 0x000700D0
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x000086A6 File Offset: 0x000068A6
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00071EF8 File Offset: 0x000700F8
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x000086C5 File Offset: 0x000068C5
		public unsafe string Discriminator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Discriminator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Discriminator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x00071F20 File Offset: 0x00070120
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x000086E4 File Offset: 0x000068E4
		public unsafe string Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Avatar);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Avatar), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x00071F48 File Offset: 0x00070148
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x00008703 File Offset: 0x00006903
		public unsafe bool Bot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Bot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(User.NativeFieldInfoPtr_Bot)) = value;
			}
		}

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeFieldInfoPtr_Discriminator;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeFieldInfoPtr_Bot;
	}
}
