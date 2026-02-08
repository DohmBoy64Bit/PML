using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000143 RID: 323
	[StructLayout(2)]
	public struct ImageDimensions
	{
		// Token: 0x0600160B RID: 5643 RVA: 0x00072178 File Offset: 0x00070378
		// Note: this type is marked as 'beforefieldinit'.
		static ImageDimensions()
		{
			Il2CppClassPointerStore<ImageDimensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ImageDimensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageDimensions>.NativeClassPtr);
			ImageDimensions.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDimensions>.NativeClassPtr, "Width");
			ImageDimensions.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDimensions>.NativeClassPtr, "Height");
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000087A4 File Offset: 0x000069A4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImageDimensions>.NativeClassPtr, ref this));
		}

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeFieldInfoPtr_Width;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04001299 RID: 4761
		[FieldOffset(0)]
		public uint Width;

		// Token: 0x0400129A RID: 4762
		[FieldOffset(4)]
		public uint Height;
	}
}
