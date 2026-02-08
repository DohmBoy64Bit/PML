using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004B RID: 75
	public enum InteropAccessMode
	{
		// Token: 0x04000749 RID: 1865
		Reflection,
		// Token: 0x0400074A RID: 1866
		LazyOptimized,
		// Token: 0x0400074B RID: 1867
		Preoptimized,
		// Token: 0x0400074C RID: 1868
		BackgroundOptimized,
		// Token: 0x0400074D RID: 1869
		Hardwired,
		// Token: 0x0400074E RID: 1870
		HideMembers,
		// Token: 0x0400074F RID: 1871
		NoReflectionAllowed,
		// Token: 0x04000750 RID: 1872
		Default
	}
}
