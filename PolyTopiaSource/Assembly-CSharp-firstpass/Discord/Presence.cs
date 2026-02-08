using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200014A RID: 330
	public sealed class Presence : ValueType
	{
		// Token: 0x06001645 RID: 5701 RVA: 0x00072828 File Offset: 0x00070A28
		// Note: this type is marked as 'beforefieldinit'.
		static Presence()
		{
			Il2CppClassPointerStore<Presence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "Presence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Presence>.NativeClassPtr);
			Presence.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Presence>.NativeClassPtr, "Status");
			Presence.NativeFieldInfoPtr_Activity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Presence>.NativeClassPtr, "Activity");
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00008AAA File Offset: 0x00006CAA
		public Presence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00008AB3 File Offset: 0x00006CB3
		public Presence()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Presence>.NativeClassPtr))
		{
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00072880 File Offset: 0x00070A80
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00008AC5 File Offset: 0x00006CC5
		public unsafe Status Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Presence.NativeFieldInfoPtr_Status);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Status>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Presence.NativeFieldInfoPtr_Status), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x000728B0 File Offset: 0x00070AB0
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x00008AE4 File Offset: 0x00006CE4
		public unsafe Activity Activity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Presence.NativeFieldInfoPtr_Activity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Presence.NativeFieldInfoPtr_Activity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeFieldInfoPtr_Activity;
	}
}
