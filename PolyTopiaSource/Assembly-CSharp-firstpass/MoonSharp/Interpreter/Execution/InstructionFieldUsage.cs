using System;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000DC RID: 220
	[Flags]
	public enum InstructionFieldUsage
	{
		// Token: 0x04000DC7 RID: 3527
		None = 0,
		// Token: 0x04000DC8 RID: 3528
		Symbol = 1,
		// Token: 0x04000DC9 RID: 3529
		SymbolList = 2,
		// Token: 0x04000DCA RID: 3530
		Name = 4,
		// Token: 0x04000DCB RID: 3531
		Value = 8,
		// Token: 0x04000DCC RID: 3532
		NumVal = 16,
		// Token: 0x04000DCD RID: 3533
		NumVal2 = 32,
		// Token: 0x04000DCE RID: 3534
		NumValAsCodeAddress = 32784
	}
}
