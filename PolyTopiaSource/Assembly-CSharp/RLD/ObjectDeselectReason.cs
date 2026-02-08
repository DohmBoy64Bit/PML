using System;

namespace RLD
{
	// Token: 0x02000225 RID: 549
	public enum ObjectDeselectReason
	{
		// Token: 0x0400212D RID: 8493
		None,
		// Token: 0x0400212E RID: 8494
		ClickSelectOther,
		// Token: 0x0400212F RID: 8495
		CickAppendAlreadySelected,
		// Token: 0x04002130 RID: 8496
		ClickAir,
		// Token: 0x04002131 RID: 8497
		MultiDeselect,
		// Token: 0x04002132 RID: 8498
		MultiSelectNotOverlapped,
		// Token: 0x04002133 RID: 8499
		Undo,
		// Token: 0x04002134 RID: 8500
		Redo,
		// Token: 0x04002135 RID: 8501
		RemoveFromSelectionCall,
		// Token: 0x04002136 RID: 8502
		ClearSelectionCall,
		// Token: 0x04002137 RID: 8503
		SetSelectedCall,
		// Token: 0x04002138 RID: 8504
		Inactive,
		// Token: 0x04002139 RID: 8505
		WillBeDeleted
	}
}
