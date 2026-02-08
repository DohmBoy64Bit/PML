using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002C RID: 44
	public enum DataType
	{
		// Token: 0x04000592 RID: 1426
		Nil,
		// Token: 0x04000593 RID: 1427
		Void,
		// Token: 0x04000594 RID: 1428
		Boolean,
		// Token: 0x04000595 RID: 1429
		Number,
		// Token: 0x04000596 RID: 1430
		String,
		// Token: 0x04000597 RID: 1431
		Function,
		// Token: 0x04000598 RID: 1432
		Table,
		// Token: 0x04000599 RID: 1433
		Tuple,
		// Token: 0x0400059A RID: 1434
		UserData,
		// Token: 0x0400059B RID: 1435
		Thread,
		// Token: 0x0400059C RID: 1436
		ClrFunction,
		// Token: 0x0400059D RID: 1437
		TailCallRequest,
		// Token: 0x0400059E RID: 1438
		YieldRequest
	}
}
