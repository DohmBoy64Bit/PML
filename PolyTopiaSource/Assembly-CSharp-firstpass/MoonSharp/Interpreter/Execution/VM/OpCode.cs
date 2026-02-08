using System;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000EB RID: 235
	public enum OpCode
	{
		// Token: 0x04000E70 RID: 3696
		Nop,
		// Token: 0x04000E71 RID: 3697
		Debug,
		// Token: 0x04000E72 RID: 3698
		Pop,
		// Token: 0x04000E73 RID: 3699
		Copy,
		// Token: 0x04000E74 RID: 3700
		Swap,
		// Token: 0x04000E75 RID: 3701
		Literal,
		// Token: 0x04000E76 RID: 3702
		Closure,
		// Token: 0x04000E77 RID: 3703
		NewTable,
		// Token: 0x04000E78 RID: 3704
		TblInitN,
		// Token: 0x04000E79 RID: 3705
		TblInitI,
		// Token: 0x04000E7A RID: 3706
		StoreLcl,
		// Token: 0x04000E7B RID: 3707
		Local,
		// Token: 0x04000E7C RID: 3708
		StoreUpv,
		// Token: 0x04000E7D RID: 3709
		Upvalue,
		// Token: 0x04000E7E RID: 3710
		IndexSet,
		// Token: 0x04000E7F RID: 3711
		Index,
		// Token: 0x04000E80 RID: 3712
		IndexSetN,
		// Token: 0x04000E81 RID: 3713
		IndexN,
		// Token: 0x04000E82 RID: 3714
		IndexSetL,
		// Token: 0x04000E83 RID: 3715
		IndexL,
		// Token: 0x04000E84 RID: 3716
		Clean,
		// Token: 0x04000E85 RID: 3717
		Meta,
		// Token: 0x04000E86 RID: 3718
		BeginFn,
		// Token: 0x04000E87 RID: 3719
		Args,
		// Token: 0x04000E88 RID: 3720
		Call,
		// Token: 0x04000E89 RID: 3721
		ThisCall,
		// Token: 0x04000E8A RID: 3722
		Ret,
		// Token: 0x04000E8B RID: 3723
		Jump,
		// Token: 0x04000E8C RID: 3724
		Jf,
		// Token: 0x04000E8D RID: 3725
		JNil,
		// Token: 0x04000E8E RID: 3726
		JFor,
		// Token: 0x04000E8F RID: 3727
		JtOrPop,
		// Token: 0x04000E90 RID: 3728
		JfOrPop,
		// Token: 0x04000E91 RID: 3729
		Concat,
		// Token: 0x04000E92 RID: 3730
		LessEq,
		// Token: 0x04000E93 RID: 3731
		Less,
		// Token: 0x04000E94 RID: 3732
		Eq,
		// Token: 0x04000E95 RID: 3733
		Add,
		// Token: 0x04000E96 RID: 3734
		Sub,
		// Token: 0x04000E97 RID: 3735
		Mul,
		// Token: 0x04000E98 RID: 3736
		Div,
		// Token: 0x04000E99 RID: 3737
		Mod,
		// Token: 0x04000E9A RID: 3738
		Not,
		// Token: 0x04000E9B RID: 3739
		Len,
		// Token: 0x04000E9C RID: 3740
		Neg,
		// Token: 0x04000E9D RID: 3741
		Power,
		// Token: 0x04000E9E RID: 3742
		CNot,
		// Token: 0x04000E9F RID: 3743
		MkTuple,
		// Token: 0x04000EA0 RID: 3744
		Scalar,
		// Token: 0x04000EA1 RID: 3745
		Incr,
		// Token: 0x04000EA2 RID: 3746
		ToNum,
		// Token: 0x04000EA3 RID: 3747
		ToBool,
		// Token: 0x04000EA4 RID: 3748
		ExpTuple,
		// Token: 0x04000EA5 RID: 3749
		IterPrep,
		// Token: 0x04000EA6 RID: 3750
		IterUpd,
		// Token: 0x04000EA7 RID: 3751
		Invalid
	}
}
