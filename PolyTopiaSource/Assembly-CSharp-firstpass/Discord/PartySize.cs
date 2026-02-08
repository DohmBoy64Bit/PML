using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000146 RID: 326
	[StructLayout(2)]
	public struct PartySize
	{
		// Token: 0x0600161A RID: 5658 RVA: 0x00072348 File Offset: 0x00070548
		// Note: this type is marked as 'beforefieldinit'.
		static PartySize()
		{
			Il2CppClassPointerStore<PartySize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "PartySize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartySize>.NativeClassPtr);
			PartySize.NativeFieldInfoPtr_CurrentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartySize>.NativeClassPtr, "CurrentSize");
			PartySize.NativeFieldInfoPtr_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartySize>.NativeClassPtr, "MaxSize");
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0000885F File Offset: 0x00006A5F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PartySize>.NativeClassPtr, ref this));
		}

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSize;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeFieldInfoPtr_MaxSize;

		// Token: 0x040012A5 RID: 4773
		[FieldOffset(0)]
		public int CurrentSize;

		// Token: 0x040012A6 RID: 4774
		[FieldOffset(4)]
		public int MaxSize;
	}
}
