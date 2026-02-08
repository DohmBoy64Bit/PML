using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000133 RID: 307
	[Serializable]
	[StructLayout(2)]
	public struct HotkeysStaticData
	{
		// Token: 0x06001BDB RID: 7131 RVA: 0x0000BDF1 File Offset: 0x00009FF1
		// Note: this type is marked as 'beforefieldinit'.
		static HotkeysStaticData()
		{
			Il2CppClassPointerStore<HotkeysStaticData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "HotkeysStaticData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotkeysStaticData>.NativeClassPtr);
			HotkeysStaticData.NativeFieldInfoPtr_CanHaveMouseButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotkeysStaticData>.NativeClassPtr, "CanHaveMouseButtons");
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0000BE2A File Offset: 0x0000A02A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HotkeysStaticData>.NativeClassPtr, ref this));
		}

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeFieldInfoPtr_CanHaveMouseButtons;

		// Token: 0x0400153B RID: 5435
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool CanHaveMouseButtons;
	}
}
