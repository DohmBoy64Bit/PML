using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000177 RID: 375
	[StructLayout(2)]
	public struct NumSnapSteps
	{
		// Token: 0x06001E35 RID: 7733 RVA: 0x00099C2C File Offset: 0x00097E2C
		// Note: this type is marked as 'beforefieldinit'.
		static NumSnapSteps()
		{
			Il2CppClassPointerStore<NumSnapSteps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "NumSnapSteps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumSnapSteps>.NativeClassPtr);
			NumSnapSteps.NativeFieldInfoPtr_FltNumSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumSnapSteps>.NativeClassPtr, "FltNumSteps");
			NumSnapSteps.NativeFieldInfoPtr_AbsFltNumSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumSnapSteps>.NativeClassPtr, "AbsFltNumSteps");
			NumSnapSteps.NativeFieldInfoPtr_IntNumSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumSnapSteps>.NativeClassPtr, "IntNumSteps");
			NumSnapSteps.NativeFieldInfoPtr_AbsIntNumSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumSnapSteps>.NativeClassPtr, "AbsIntNumSteps");
			NumSnapSteps.NativeFieldInfoPtr_AbsFracSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumSnapSteps>.NativeClassPtr, "AbsFracSteps");
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0000C5F9 File Offset: 0x0000A7F9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NumSnapSteps>.NativeClassPtr, ref this));
		}

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeFieldInfoPtr_FltNumSteps;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeFieldInfoPtr_AbsFltNumSteps;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeFieldInfoPtr_IntNumSteps;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeFieldInfoPtr_AbsIntNumSteps;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeFieldInfoPtr_AbsFracSteps;

		// Token: 0x040017BD RID: 6077
		[FieldOffset(0)]
		public float FltNumSteps;

		// Token: 0x040017BE RID: 6078
		[FieldOffset(4)]
		public float AbsFltNumSteps;

		// Token: 0x040017BF RID: 6079
		[FieldOffset(8)]
		public int IntNumSteps;

		// Token: 0x040017C0 RID: 6080
		[FieldOffset(12)]
		public int AbsIntNumSteps;

		// Token: 0x040017C1 RID: 6081
		[FieldOffset(16)]
		public float AbsFracSteps;
	}
}
