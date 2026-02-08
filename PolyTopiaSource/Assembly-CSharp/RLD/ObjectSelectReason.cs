using System;

namespace RLD
{
	// Token: 0x02000224 RID: 548
	public enum ObjectSelectReason
	{
		// Token: 0x04002123 RID: 8483
		None,
		// Token: 0x04002124 RID: 8484
		Click,
		// Token: 0x04002125 RID: 8485
		ClickAppend,
		// Token: 0x04002126 RID: 8486
		MultiSelect,
		// Token: 0x04002127 RID: 8487
		MultiSelectAppend,
		// Token: 0x04002128 RID: 8488
		Undo,
		// Token: 0x04002129 RID: 8489
		Redo,
		// Token: 0x0400212A RID: 8490
		AppendToSelectionCall,
		// Token: 0x0400212B RID: 8491
		SetSelectedCall
	}
}
