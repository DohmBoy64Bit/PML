using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000144 RID: 324
	[StructLayout(2)]
	public struct ActivityTimestamps
	{
		// Token: 0x0600160D RID: 5645 RVA: 0x000721D0 File Offset: 0x000703D0
		// Note: this type is marked as 'beforefieldinit'.
		static ActivityTimestamps()
		{
			Il2CppClassPointerStore<ActivityTimestamps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ActivityTimestamps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityTimestamps>.NativeClassPtr);
			ActivityTimestamps.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTimestamps>.NativeClassPtr, "Start");
			ActivityTimestamps.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTimestamps>.NativeClassPtr, "End");
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000087B6 File Offset: 0x000069B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActivityTimestamps>.NativeClassPtr, ref this));
		}

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeFieldInfoPtr_End;

		// Token: 0x0400129D RID: 4765
		[FieldOffset(0)]
		public long Start;

		// Token: 0x0400129E RID: 4766
		[FieldOffset(8)]
		public long End;
	}
}
