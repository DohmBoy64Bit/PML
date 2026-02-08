using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000150 RID: 336
	[StructLayout(2)]
	public struct Entitlement
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x00072D74 File Offset: 0x00070F74
		// Note: this type is marked as 'beforefieldinit'.
		static Entitlement()
		{
			Il2CppClassPointerStore<Entitlement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "Entitlement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entitlement>.NativeClassPtr);
			Entitlement.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entitlement>.NativeClassPtr, "Id");
			Entitlement.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entitlement>.NativeClassPtr, "Type");
			Entitlement.NativeFieldInfoPtr_SkuId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entitlement>.NativeClassPtr, "SkuId");
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00008CD4 File Offset: 0x00006ED4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Entitlement>.NativeClassPtr, ref this));
		}

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr_SkuId;

		// Token: 0x040012DA RID: 4826
		[FieldOffset(0)]
		public long Id;

		// Token: 0x040012DB RID: 4827
		[FieldOffset(8)]
		public IntPtr Type;

		// Token: 0x040012DC RID: 4828
		[FieldOffset(16)]
		public long SkuId;
	}
}
