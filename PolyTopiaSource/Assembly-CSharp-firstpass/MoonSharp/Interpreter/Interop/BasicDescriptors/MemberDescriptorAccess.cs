using System;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D9 RID: 217
	[Flags]
	public enum MemberDescriptorAccess
	{
		// Token: 0x04000DA4 RID: 3492
		CanRead = 1,
		// Token: 0x04000DA5 RID: 3493
		CanWrite = 2,
		// Token: 0x04000DA6 RID: 3494
		CanExecute = 4
	}
}
