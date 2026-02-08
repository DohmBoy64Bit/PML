using System;

namespace SimpleJSON
{
	// Token: 0x0200001A RID: 26
	public enum JSONNodeType
	{
		// Token: 0x0400044F RID: 1103
		Array = 1,
		// Token: 0x04000450 RID: 1104
		Object,
		// Token: 0x04000451 RID: 1105
		String,
		// Token: 0x04000452 RID: 1106
		Number,
		// Token: 0x04000453 RID: 1107
		NullValue,
		// Token: 0x04000454 RID: 1108
		Boolean,
		// Token: 0x04000455 RID: 1109
		None,
		// Token: 0x04000456 RID: 1110
		Custom = 255
	}
}
