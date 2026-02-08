using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x0200014E RID: 334
	[StructLayout(2)]
	public struct Rect
	{
		// Token: 0x06001666 RID: 5734 RVA: 0x00072C10 File Offset: 0x00070E10
		// Note: this type is marked as 'beforefieldinit'.
		static Rect()
		{
			Il2CppClassPointerStore<Rect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "Rect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rect>.NativeClassPtr);
			Rect.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "Left");
			Rect.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "Top");
			Rect.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "Right");
			Rect.NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "Bottom");
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00008C52 File Offset: 0x00006E52
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Rect>.NativeClassPtr, ref this));
		}

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeFieldInfoPtr_Left;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeFieldInfoPtr_Top;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeFieldInfoPtr_Right;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeFieldInfoPtr_Bottom;

		// Token: 0x040012D0 RID: 4816
		[FieldOffset(0)]
		public int Left;

		// Token: 0x040012D1 RID: 4817
		[FieldOffset(4)]
		public int Top;

		// Token: 0x040012D2 RID: 4818
		[FieldOffset(8)]
		public int Right;

		// Token: 0x040012D3 RID: 4819
		[FieldOffset(12)]
		public int Bottom;
	}
}
