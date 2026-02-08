using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200014E RID: 334
	[StructLayout(2)]
	public struct BoxFaceDesc
	{
		// Token: 0x06001D3F RID: 7487 RVA: 0x00094600 File Offset: 0x00092800
		// Note: this type is marked as 'beforefieldinit'.
		static BoxFaceDesc()
		{
			Il2CppClassPointerStore<BoxFaceDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxFaceDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxFaceDesc>.NativeClassPtr);
			BoxFaceDesc.NativeFieldInfoPtr_Face = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxFaceDesc>.NativeClassPtr, "Face");
			BoxFaceDesc.NativeFieldInfoPtr_Plane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxFaceDesc>.NativeClassPtr, "Plane");
			BoxFaceDesc.NativeFieldInfoPtr_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxFaceDesc>.NativeClassPtr, "Center");
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0000C374 File Offset: 0x0000A574
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoxFaceDesc>.NativeClassPtr, ref this));
		}

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeFieldInfoPtr_Face;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeFieldInfoPtr_Plane;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeFieldInfoPtr_Center;

		// Token: 0x04001692 RID: 5778
		[FieldOffset(0)]
		public IntPtr Face;

		// Token: 0x04001693 RID: 5779
		[FieldOffset(4)]
		public IntPtr Plane;

		// Token: 0x04001694 RID: 5780
		[FieldOffset(20)]
		public IntPtr Center;
	}
}
