using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005D RID: 93
	public static class LexerUtils : Object
	{
		// Token: 0x0600097C RID: 2428 RVA: 0x0003AE70 File Offset: 0x00039070
		// Note: this type is marked as 'beforefieldinit'.
		static LexerUtils()
		{
			Il2CppClassPointerStore<LexerUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree", "LexerUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr);
			LexerUtils.NativeMethodInfoPtr_ParseNumber_Public_Static_Double_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr, 100665070);
			LexerUtils.NativeMethodInfoPtr_ParseHexInteger_Public_Static_Double_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr, 100665071);
			LexerUtils.NativeMethodInfoPtr_ReadHexProgressive_Public_Static_String_String_byref_Double_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr, 100665072);
			LexerUtils.NativeMethodInfoPtr_ParseHexFloat_Public_Static_Double_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr, 100665073);
			LexerUtils.NativeMethodInfoPtr_HexDigit2Value_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr, 100665074);
			LexerUtils.NativeMethodInfoPtr_CharIsHexDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr, 100665075);
			LexerUtils.NativeMethodInfoPtr_AdjustLuaLongString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr, 100665076);
			LexerUtils.NativeMethodInfoPtr_UnescapeLuaString_Public_Static_String_Token_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr, 100665077);
			LexerUtils.NativeMethodInfoPtr_ConvertUtf32ToChar_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LexerUtils>.NativeClassPtr, 100665078);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0003AF54 File Offset: 0x00039154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29088, XrefRangeEnd = 29093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ParseNumber(Token T)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(T);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LexerUtils.NativeMethodInfoPtr_ParseNumber_Public_Static_Double_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0003AF98 File Offset: 0x00039198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29108, XrefRangeStart = 29093, XrefRangeEnd = 29107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ParseHexInteger(Token T)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(T);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LexerUtils.NativeMethodInfoPtr_ParseHexInteger_Public_Static_Double_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0003AFDC File Offset: 0x000391DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29115, RefRangeEnd = 29116, XrefRangeStart = 29108, XrefRangeEnd = 29115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadHexProgressive(string s, ref double d, out int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LexerUtils.NativeMethodInfoPtr_ReadHexProgressive_Public_Static_String_String_byref_Double_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0003B034 File Offset: 0x00039234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29155, RefRangeEnd = 29156, XrefRangeStart = 29116, XrefRangeEnd = 29155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ParseHexFloat(Token T)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(T);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LexerUtils.NativeMethodInfoPtr_ParseHexFloat_Public_Static_Double_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0003B078 File Offset: 0x00039278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29156, RefRangeEnd = 29158, XrefRangeStart = 29156, XrefRangeEnd = 29156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexDigit2Value(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LexerUtils.NativeMethodInfoPtr_HexDigit2Value_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0003B0B8 File Offset: 0x000392B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29161, RefRangeEnd = 29163, XrefRangeStart = 29158, XrefRangeEnd = 29161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharIsHexDigit(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LexerUtils.NativeMethodInfoPtr_CharIsHexDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0003B0F8 File Offset: 0x000392F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29171, RefRangeEnd = 29172, XrefRangeStart = 29163, XrefRangeEnd = 29171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AdjustLuaLongString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LexerUtils.NativeMethodInfoPtr_AdjustLuaLongString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0003B134 File Offset: 0x00039334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29285, RefRangeEnd = 29286, XrefRangeStart = 29172, XrefRangeEnd = 29285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeLuaString(Token token, string str)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LexerUtils.NativeMethodInfoPtr_UnescapeLuaString_Public_Static_String_Token_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0003B184 File Offset: 0x00039384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29286, XrefRangeEnd = 29289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConvertUtf32ToChar(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LexerUtils.NativeMethodInfoPtr_ConvertUtf32ToChar_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0000484A File Offset: 0x00002A4A
		public LexerUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Public_Static_Double_Token_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_ParseHexInteger_Public_Static_Double_Token_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_ReadHexProgressive_Public_Static_String_String_byref_Double_byref_Int32_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_ParseHexFloat_Public_Static_Double_Token_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_HexDigit2Value_Public_Static_Int32_Char_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_CharIsHexDigit_Public_Static_Boolean_Char_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_AdjustLuaLongString_Public_Static_String_String_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeLuaString_Public_Static_String_Token_String_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_ConvertUtf32ToChar_Private_Static_String_Int32_0;
	}
}
