using System;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FA RID: 250
	[Flags]
	public enum DebuggerCaps
	{
		// Token: 0x04000F9B RID: 3995
		CanDebugSourceCode = 1,
		// Token: 0x04000F9C RID: 3996
		CanDebugByteCode = 2,
		// Token: 0x04000F9D RID: 3997
		HasLineBasedBreakpoints = 4
	}
}
