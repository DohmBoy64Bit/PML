using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000153 RID: 339
	public sealed class InputMode : ValueType
	{
		// Token: 0x06001685 RID: 5765 RVA: 0x00072FB8 File Offset: 0x000711B8
		// Note: this type is marked as 'beforefieldinit'.
		static InputMode()
		{
			Il2CppClassPointerStore<InputMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "InputMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMode>.NativeClassPtr);
			InputMode.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMode>.NativeClassPtr, "Type");
			InputMode.NativeFieldInfoPtr_Shortcut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMode>.NativeClassPtr, "Shortcut");
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00008DCE File Offset: 0x00006FCE
		public InputMode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00008DD7 File Offset: 0x00006FD7
		public InputMode()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMode>.NativeClassPtr))
		{
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x00073010 File Offset: 0x00071210
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x00008DE9 File Offset: 0x00006FE9
		public unsafe InputModeType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMode.NativeFieldInfoPtr_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputModeType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMode.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x00073040 File Offset: 0x00071240
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x00008E08 File Offset: 0x00007008
		public unsafe string Shortcut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMode.NativeFieldInfoPtr_Shortcut);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMode.NativeFieldInfoPtr_Shortcut), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeFieldInfoPtr_Shortcut;
	}
}
