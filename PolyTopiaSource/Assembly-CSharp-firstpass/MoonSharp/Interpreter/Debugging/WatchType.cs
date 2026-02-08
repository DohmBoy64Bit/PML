using System;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x02000100 RID: 256
	public enum WatchType
	{
		// Token: 0x04001000 RID: 4096
		Watches,
		// Token: 0x04001001 RID: 4097
		VStack,
		// Token: 0x04001002 RID: 4098
		CallStack,
		// Token: 0x04001003 RID: 4099
		Coroutines,
		// Token: 0x04001004 RID: 4100
		Locals,
		// Token: 0x04001005 RID: 4101
		Threads,
		// Token: 0x04001006 RID: 4102
		MaxValue
	}
}
