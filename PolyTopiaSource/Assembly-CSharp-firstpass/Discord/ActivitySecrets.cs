using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000148 RID: 328
	public sealed class ActivitySecrets : ValueType
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x00072494 File Offset: 0x00070694
		// Note: this type is marked as 'beforefieldinit'.
		static ActivitySecrets()
		{
			Il2CppClassPointerStore<ActivitySecrets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ActivitySecrets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivitySecrets>.NativeClassPtr);
			ActivitySecrets.NativeFieldInfoPtr_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivitySecrets>.NativeClassPtr, "Match");
			ActivitySecrets.NativeFieldInfoPtr_Join = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivitySecrets>.NativeClassPtr, "Join");
			ActivitySecrets.NativeFieldInfoPtr_Spectate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivitySecrets>.NativeClassPtr, "Spectate");
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000088E9 File Offset: 0x00006AE9
		public ActivitySecrets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x000088F2 File Offset: 0x00006AF2
		public ActivitySecrets()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivitySecrets>.NativeClassPtr))
		{
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00072500 File Offset: 0x00070700
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x00008904 File Offset: 0x00006B04
		public unsafe string Match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivitySecrets.NativeFieldInfoPtr_Match);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivitySecrets.NativeFieldInfoPtr_Match), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00072528 File Offset: 0x00070728
		// (set) Token: 0x0600162B RID: 5675 RVA: 0x00008923 File Offset: 0x00006B23
		public unsafe string Join
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivitySecrets.NativeFieldInfoPtr_Join);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivitySecrets.NativeFieldInfoPtr_Join), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00072550 File Offset: 0x00070750
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x00008942 File Offset: 0x00006B42
		public unsafe string Spectate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivitySecrets.NativeFieldInfoPtr_Spectate);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivitySecrets.NativeFieldInfoPtr_Spectate), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeFieldInfoPtr_Match;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeFieldInfoPtr_Join;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeFieldInfoPtr_Spectate;
	}
}
