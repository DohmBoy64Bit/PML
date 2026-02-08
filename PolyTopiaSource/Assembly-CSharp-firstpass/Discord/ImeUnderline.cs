using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200014D RID: 333
	[StructLayout(2)]
	public struct ImeUnderline
	{
		// Token: 0x06001664 RID: 5732 RVA: 0x00072B7C File Offset: 0x00070D7C
		// Note: this type is marked as 'beforefieldinit'.
		static ImeUnderline()
		{
			Il2CppClassPointerStore<ImeUnderline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ImeUnderline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImeUnderline>.NativeClassPtr);
			ImeUnderline.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImeUnderline>.NativeClassPtr, "From");
			ImeUnderline.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImeUnderline>.NativeClassPtr, "To");
			ImeUnderline.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImeUnderline>.NativeClassPtr, "Color");
			ImeUnderline.NativeFieldInfoPtr_BackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImeUnderline>.NativeClassPtr, "BackgroundColor");
			ImeUnderline.NativeFieldInfoPtr_Thick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImeUnderline>.NativeClassPtr, "Thick");
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00008C40 File Offset: 0x00006E40
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImeUnderline>.NativeClassPtr, ref this));
		}

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeFieldInfoPtr_From;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeFieldInfoPtr_To;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundColor;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeFieldInfoPtr_Thick;

		// Token: 0x040012C7 RID: 4807
		[FieldOffset(0)]
		public int From;

		// Token: 0x040012C8 RID: 4808
		[FieldOffset(4)]
		public int To;

		// Token: 0x040012C9 RID: 4809
		[FieldOffset(8)]
		public uint Color;

		// Token: 0x040012CA RID: 4810
		[FieldOffset(12)]
		public uint BackgroundColor;

		// Token: 0x040012CB RID: 4811
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool Thick;
	}
}
