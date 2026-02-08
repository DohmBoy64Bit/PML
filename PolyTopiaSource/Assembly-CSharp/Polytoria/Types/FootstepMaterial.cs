using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Polytoria.Datamodel;

namespace Polytoria.Types
{
	// Token: 0x0200025B RID: 603
	[Serializable]
	public sealed class FootstepMaterial : ValueType
	{
		// Token: 0x06002ECC RID: 11980 RVA: 0x000D7DE8 File Offset: 0x000D5FE8
		// Note: this type is marked as 'beforefieldinit'.
		static FootstepMaterial()
		{
			Il2CppClassPointerStore<FootstepMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Types", "FootstepMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepMaterial>.NativeClassPtr);
			FootstepMaterial.NativeFieldInfoPtr_partMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepMaterial>.NativeClassPtr, "partMaterial");
			FootstepMaterial.NativeFieldInfoPtr_sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepMaterial>.NativeClassPtr, "sounds");
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x00012CD9 File Offset: 0x00010ED9
		public FootstepMaterial(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x00012CE2 File Offset: 0x00010EE2
		public FootstepMaterial()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepMaterial>.NativeClassPtr))
		{
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x000D7E40 File Offset: 0x000D6040
		// (set) Token: 0x06002ED0 RID: 11984 RVA: 0x00012CF4 File Offset: 0x00010EF4
		public unsafe PartMaterial partMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepMaterial.NativeFieldInfoPtr_partMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartMaterial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepMaterial.NativeFieldInfoPtr_partMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x000D7E70 File Offset: 0x000D6070
		// (set) Token: 0x06002ED2 RID: 11986 RVA: 0x00012D13 File Offset: 0x00010F13
		public unsafe FootstepSounds sounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepMaterial.NativeFieldInfoPtr_sounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepSounds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepMaterial.NativeFieldInfoPtr_sounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023C5 RID: 9157
		private static readonly IntPtr NativeFieldInfoPtr_partMaterial;

		// Token: 0x040023C6 RID: 9158
		private static readonly IntPtr NativeFieldInfoPtr_sounds;
	}
}
