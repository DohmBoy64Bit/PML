using System;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000E8 RID: 232
	[Flags]
	public enum CallStackItemFlags
	{
		// Token: 0x04000E51 RID: 3665
		None = 0,
		// Token: 0x04000E52 RID: 3666
		EntryPoint = 1,
		// Token: 0x04000E53 RID: 3667
		ResumeEntryPoint = 3,
		// Token: 0x04000E54 RID: 3668
		CallEntryPoint = 5,
		// Token: 0x04000E55 RID: 3669
		TailCall = 16,
		// Token: 0x04000E56 RID: 3670
		MethodCall = 32
	}
}
