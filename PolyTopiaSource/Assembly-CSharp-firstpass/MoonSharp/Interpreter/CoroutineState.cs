using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002B RID: 43
	public enum CoroutineState
	{
		// Token: 0x0400058B RID: 1419
		Main,
		// Token: 0x0400058C RID: 1420
		NotStarted,
		// Token: 0x0400058D RID: 1421
		Suspended,
		// Token: 0x0400058E RID: 1422
		ForceSuspended,
		// Token: 0x0400058F RID: 1423
		Running,
		// Token: 0x04000590 RID: 1424
		Dead
	}
}
