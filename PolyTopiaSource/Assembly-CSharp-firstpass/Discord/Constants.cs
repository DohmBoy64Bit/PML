using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200012A RID: 298
	public static class Constants : Object
	{
		// Token: 0x060015ED RID: 5613 RVA: 0x0000861C File Offset: 0x0000681C
		// Note: this type is marked as 'beforefieldinit'.
		static Constants()
		{
			Il2CppClassPointerStore<Constants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "Constants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constants>.NativeClassPtr);
			Constants.NativeFieldInfoPtr_DllName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constants>.NativeClassPtr, "DllName");
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00008655 File Offset: 0x00006855
		public Constants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00071DF4 File Offset: 0x0006FFF4
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000865E File Offset: 0x0000685E
		public unsafe static string DllName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Constants.NativeFieldInfoPtr_DllName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Constants.NativeFieldInfoPtr_DllName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeFieldInfoPtr_DllName;
	}
}
