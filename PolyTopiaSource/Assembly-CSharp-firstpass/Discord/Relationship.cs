using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200014B RID: 331
	public sealed class Relationship : ValueType
	{
		// Token: 0x0600164C RID: 5708 RVA: 0x000728E0 File Offset: 0x00070AE0
		// Note: this type is marked as 'beforefieldinit'.
		static Relationship()
		{
			Il2CppClassPointerStore<Relationship>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "Relationship");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Relationship>.NativeClassPtr);
			Relationship.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relationship>.NativeClassPtr, "Type");
			Relationship.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relationship>.NativeClassPtr, "User");
			Relationship.NativeFieldInfoPtr_Presence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relationship>.NativeClassPtr, "Presence");
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00008B03 File Offset: 0x00006D03
		public Relationship(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00008B0C File Offset: 0x00006D0C
		public Relationship()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Relationship>.NativeClassPtr))
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x0007294C File Offset: 0x00070B4C
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x00008B1E File Offset: 0x00006D1E
		public unsafe RelationshipType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x0007297C File Offset: 0x00070B7C
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x00008B3D File Offset: 0x00006D3D
		public unsafe User User
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_User);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<User>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_User), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x000729AC File Offset: 0x00070BAC
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x00008B5C File Offset: 0x00006D5C
		public unsafe Presence Presence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_Presence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Presence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Relationship.NativeFieldInfoPtr_Presence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeFieldInfoPtr_User;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_Presence;
	}
}
