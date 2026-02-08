using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004E RID: 78
	[Flags]
	public enum CoreModules
	{
		// Token: 0x04000760 RID: 1888
		None = 0,
		// Token: 0x04000761 RID: 1889
		Basic = 64,
		// Token: 0x04000762 RID: 1890
		GlobalConsts = 1,
		// Token: 0x04000763 RID: 1891
		TableIterators = 2,
		// Token: 0x04000764 RID: 1892
		Metatables = 4,
		// Token: 0x04000765 RID: 1893
		String = 8,
		// Token: 0x04000766 RID: 1894
		LoadMethods = 16,
		// Token: 0x04000767 RID: 1895
		Table = 32,
		// Token: 0x04000768 RID: 1896
		ErrorHandling = 128,
		// Token: 0x04000769 RID: 1897
		Math = 256,
		// Token: 0x0400076A RID: 1898
		Coroutine = 512,
		// Token: 0x0400076B RID: 1899
		Bit32 = 1024,
		// Token: 0x0400076C RID: 1900
		OS_Time = 2048,
		// Token: 0x0400076D RID: 1901
		OS_System = 4096,
		// Token: 0x0400076E RID: 1902
		IO = 8192,
		// Token: 0x0400076F RID: 1903
		Debug = 16384,
		// Token: 0x04000770 RID: 1904
		Dynamic = 32768,
		// Token: 0x04000771 RID: 1905
		Json = 65536,
		// Token: 0x04000772 RID: 1906
		Preset_HardSandbox = 1387,
		// Token: 0x04000773 RID: 1907
		Preset_SoftSandbox = 102383,
		// Token: 0x04000774 RID: 1908
		Preset_Default = 114687,
		// Token: 0x04000775 RID: 1909
		Preset_Complete = 131071
	}
}
