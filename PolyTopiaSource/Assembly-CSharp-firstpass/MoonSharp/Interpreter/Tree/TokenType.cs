using System;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005F RID: 95
	public enum TokenType
	{
		// Token: 0x04000849 RID: 2121
		Eof,
		// Token: 0x0400084A RID: 2122
		HashBang,
		// Token: 0x0400084B RID: 2123
		Name,
		// Token: 0x0400084C RID: 2124
		And,
		// Token: 0x0400084D RID: 2125
		Break,
		// Token: 0x0400084E RID: 2126
		Do,
		// Token: 0x0400084F RID: 2127
		Else,
		// Token: 0x04000850 RID: 2128
		ElseIf,
		// Token: 0x04000851 RID: 2129
		End,
		// Token: 0x04000852 RID: 2130
		False,
		// Token: 0x04000853 RID: 2131
		For,
		// Token: 0x04000854 RID: 2132
		Function,
		// Token: 0x04000855 RID: 2133
		Lambda,
		// Token: 0x04000856 RID: 2134
		Goto,
		// Token: 0x04000857 RID: 2135
		If,
		// Token: 0x04000858 RID: 2136
		In,
		// Token: 0x04000859 RID: 2137
		Local,
		// Token: 0x0400085A RID: 2138
		Nil,
		// Token: 0x0400085B RID: 2139
		Not,
		// Token: 0x0400085C RID: 2140
		Or,
		// Token: 0x0400085D RID: 2141
		Repeat,
		// Token: 0x0400085E RID: 2142
		Return,
		// Token: 0x0400085F RID: 2143
		Then,
		// Token: 0x04000860 RID: 2144
		True,
		// Token: 0x04000861 RID: 2145
		Until,
		// Token: 0x04000862 RID: 2146
		While,
		// Token: 0x04000863 RID: 2147
		Op_Equal,
		// Token: 0x04000864 RID: 2148
		Op_Assignment,
		// Token: 0x04000865 RID: 2149
		Op_LessThan,
		// Token: 0x04000866 RID: 2150
		Op_LessThanEqual,
		// Token: 0x04000867 RID: 2151
		Op_GreaterThanEqual,
		// Token: 0x04000868 RID: 2152
		Op_GreaterThan,
		// Token: 0x04000869 RID: 2153
		Op_NotEqual,
		// Token: 0x0400086A RID: 2154
		Op_Concat,
		// Token: 0x0400086B RID: 2155
		VarArgs,
		// Token: 0x0400086C RID: 2156
		Dot,
		// Token: 0x0400086D RID: 2157
		Colon,
		// Token: 0x0400086E RID: 2158
		DoubleColon,
		// Token: 0x0400086F RID: 2159
		Comma,
		// Token: 0x04000870 RID: 2160
		Brk_Close_Curly,
		// Token: 0x04000871 RID: 2161
		Brk_Open_Curly,
		// Token: 0x04000872 RID: 2162
		Brk_Close_Round,
		// Token: 0x04000873 RID: 2163
		Brk_Open_Round,
		// Token: 0x04000874 RID: 2164
		Brk_Close_Square,
		// Token: 0x04000875 RID: 2165
		Brk_Open_Square,
		// Token: 0x04000876 RID: 2166
		Op_Len,
		// Token: 0x04000877 RID: 2167
		Op_Pwr,
		// Token: 0x04000878 RID: 2168
		Op_Mod,
		// Token: 0x04000879 RID: 2169
		Op_Div,
		// Token: 0x0400087A RID: 2170
		Op_Mul,
		// Token: 0x0400087B RID: 2171
		Op_MinusOrSub,
		// Token: 0x0400087C RID: 2172
		Op_Add,
		// Token: 0x0400087D RID: 2173
		Comment,
		// Token: 0x0400087E RID: 2174
		String,
		// Token: 0x0400087F RID: 2175
		String_Long,
		// Token: 0x04000880 RID: 2176
		Number,
		// Token: 0x04000881 RID: 2177
		Number_HexFloat,
		// Token: 0x04000882 RID: 2178
		Number_Hex,
		// Token: 0x04000883 RID: 2179
		SemiColon,
		// Token: 0x04000884 RID: 2180
		Invalid,
		// Token: 0x04000885 RID: 2181
		Brk_Open_Curly_Shared,
		// Token: 0x04000886 RID: 2182
		Op_Dollar
	}
}
