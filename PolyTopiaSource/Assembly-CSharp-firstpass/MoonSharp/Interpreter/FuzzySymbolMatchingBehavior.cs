using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000056 RID: 86
	[Flags]
	public enum FuzzySymbolMatchingBehavior
	{
		// Token: 0x0400078F RID: 1935
		None = 0,
		// Token: 0x04000790 RID: 1936
		UpperFirstLetter = 1,
		// Token: 0x04000791 RID: 1937
		Camelify = 2,
		// Token: 0x04000792 RID: 1938
		PascalCase = 4
	}
}
