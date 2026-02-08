using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005C RID: 92
	public class Lexer : Object
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x0003A310 File Offset: 0x00038510
		// Note: this type is marked as 'beforefieldinit'.
		static Lexer()
		{
			Il2CppClassPointerStore<Lexer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree", "Lexer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lexer>.NativeClassPtr);
			Lexer.NativeFieldInfoPtr_m_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_Current");
			Lexer.NativeFieldInfoPtr_m_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_Code");
			Lexer.NativeFieldInfoPtr_m_PrevLineTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_PrevLineTo");
			Lexer.NativeFieldInfoPtr_m_PrevColTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_PrevColTo");
			Lexer.NativeFieldInfoPtr_m_Cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_Cursor");
			Lexer.NativeFieldInfoPtr_m_StartCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_StartCursor");
			Lexer.NativeFieldInfoPtr_m_Line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_Line");
			Lexer.NativeFieldInfoPtr_m_Col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_Col");
			Lexer.NativeFieldInfoPtr_m_SourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_SourceId");
			Lexer.NativeFieldInfoPtr_m_AutoSkipComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lexer>.NativeClassPtr, "m_AutoSkipComments");
			Lexer.NativeMethodInfoPtr_get_Current_Public_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665049);
			Lexer.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665048);
			Lexer.NativeMethodInfoPtr_FetchNewToken_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665050);
			Lexer.NativeMethodInfoPtr_Next_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665051);
			Lexer.NativeMethodInfoPtr_PeekNext_Public_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665052);
			Lexer.NativeMethodInfoPtr_CursorNext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665053);
			Lexer.NativeMethodInfoPtr_CursorChar_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665054);
			Lexer.NativeMethodInfoPtr_CursorCharNext_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665055);
			Lexer.NativeMethodInfoPtr_CursorMatches_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665056);
			Lexer.NativeMethodInfoPtr_CursorNotEof_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665057);
			Lexer.NativeMethodInfoPtr_SkipWhiteSpace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665058);
			Lexer.NativeMethodInfoPtr_ReadToken_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665059);
			Lexer.NativeMethodInfoPtr_ReadLongString_Private_String_Int32_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665060);
			Lexer.NativeMethodInfoPtr_ReadNumberToken_Private_Token_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665061);
			Lexer.NativeMethodInfoPtr_CreateSingleCharToken_Private_Token_TokenType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665062);
			Lexer.NativeMethodInfoPtr_ReadHashBang_Private_Token_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665063);
			Lexer.NativeMethodInfoPtr_ReadComment_Private_Token_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665064);
			Lexer.NativeMethodInfoPtr_ReadSimpleStringToken_Private_Token_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665065);
			Lexer.NativeMethodInfoPtr_PotentiallyDoubleCharOperator_Private_Token_Char_TokenType_TokenType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665066);
			Lexer.NativeMethodInfoPtr_CreateNameToken_Private_Token_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665067);
			Lexer.NativeMethodInfoPtr_CreateToken_Private_Token_TokenType_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665068);
			Lexer.NativeMethodInfoPtr_ReadNameToken_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lexer>.NativeClassPtr, 100665069);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0003A5C0 File Offset: 0x000387C0
		public unsafe Token Current
		{
			[CallerCount(119)]
			[CachedScanResults(RefRangeStart = 28599, RefRangeEnd = 28718, XrefRangeStart = 28597, XrefRangeEnd = 28599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_get_Current_Public_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0003A600 File Offset: 0x00038800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 28721, RefRangeEnd = 28723, XrefRangeStart = 28718, XrefRangeEnd = 28721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lexer(int sourceID, string scriptContent, bool autoSkipComments)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lexer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scriptContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoSkipComments;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0003A668 File Offset: 0x00038868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28723, XrefRangeEnd = 28724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token FetchNewToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_FetchNewToken_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0003A6A8 File Offset: 0x000388A8
		[CallerCount(68)]
		[CachedScanResults(RefRangeStart = 28727, RefRangeEnd = 28795, XrefRangeStart = 28724, XrefRangeEnd = 28727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_Next_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0003A6DC File Offset: 0x000388DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28800, RefRangeEnd = 28801, XrefRangeStart = 28795, XrefRangeEnd = 28800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token PeekNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_PeekNext_Public_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0003A71C File Offset: 0x0003891C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28801, XrefRangeEnd = 28802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_CursorNext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0003A750 File Offset: 0x00038950
		[CallerCount(0)]
		public unsafe char CursorChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_CursorChar_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0003A78C File Offset: 0x0003898C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 28805, RefRangeEnd = 28823, XrefRangeStart = 28802, XrefRangeEnd = 28805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char CursorCharNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_CursorCharNext_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0003A7C8 File Offset: 0x000389C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28823, XrefRangeEnd = 28826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CursorMatches(string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_CursorMatches_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0003A818 File Offset: 0x00038A18
		[CallerCount(0)]
		public unsafe bool CursorNotEof()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_CursorNotEof_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0003A854 File Offset: 0x00038A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 28834, RefRangeEnd = 28836, XrefRangeStart = 28826, XrefRangeEnd = 28834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhiteSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_SkipWhiteSpace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0003A888 File Offset: 0x00038A88
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 28850, RefRangeEnd = 28870, XrefRangeStart = 28836, XrefRangeEnd = 28850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token ReadToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_ReadToken_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0003A8C8 File Offset: 0x00038AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28956, RefRangeEnd = 28957, XrefRangeStart = 28870, XrefRangeEnd = 28956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadLongString(int fromLine, int fromCol, string startpattern, string subtypeforerrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromLine;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(startpattern);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtypeforerrors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_ReadLongString_Private_String_Int32_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0003A940 File Offset: 0x00038B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28957, XrefRangeEnd = 28987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token ReadNumberToken(int fromLine, int fromCol, bool leadingDot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromLine;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leadingDot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_ReadNumberToken_Private_Token_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0003A9A8 File Offset: 0x00038BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28987, XrefRangeEnd = 28994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token CreateSingleCharToken(TokenType tokenType, int fromLine, int fromCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromLine;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_CreateSingleCharToken_Private_Token_TokenType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0003AA14 File Offset: 0x00038C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28994, XrefRangeEnd = 29005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token ReadHashBang(int fromLine, int fromCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromLine;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_ReadHashBang_Private_Token_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0003AA70 File Offset: 0x00038C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29005, XrefRangeEnd = 29016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token ReadComment(int fromLine, int fromCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromLine;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_ReadComment_Private_Token_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0003AACC File Offset: 0x00038CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29016, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token ReadSimpleStringToken(int fromLine, int fromCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromLine;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_ReadSimpleStringToken_Private_Token_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0003AB28 File Offset: 0x00038D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29043, XrefRangeEnd = 29052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token PotentiallyDoubleCharOperator(char expectedSecondChar, TokenType singleCharToken, TokenType doubleCharToken, int fromLine, int fromCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expectedSecondChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(singleCharToken);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doubleCharToken);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromLine;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_PotentiallyDoubleCharOperator_Private_Token_Char_TokenType_TokenType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0003ABB4 File Offset: 0x00038DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29052, XrefRangeEnd = 29059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token CreateNameToken(string name, int fromLine, int fromCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromLine;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_CreateNameToken_Private_Token_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0003AC20 File Offset: 0x00038E20
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 29064, RefRangeEnd = 29075, XrefRangeStart = 29059, XrefRangeEnd = 29064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token CreateToken(TokenType tokenType, int fromLine, int fromCol, string text = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromLine;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_CreateToken_Private_Token_TokenType_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0003ACA0 File Offset: 0x00038EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29075, XrefRangeEnd = 29088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadNameToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lexer.NativeMethodInfoPtr_ReadNameToken_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0000472B File Offset: 0x0000292B
		public Lexer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0003ACD8 File Offset: 0x00038ED8
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00004734 File Offset: 0x00002934
		public unsafe Token m_Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Token>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0003AD08 File Offset: 0x00038F08
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00004753 File Offset: 0x00002953
		public unsafe string m_Code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Code);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Code), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0003AD30 File Offset: 0x00038F30
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x00004772 File Offset: 0x00002972
		public unsafe int m_PrevLineTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_PrevLineTo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_PrevLineTo)) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0003AD58 File Offset: 0x00038F58
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0000478D File Offset: 0x0000298D
		public unsafe int m_PrevColTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_PrevColTo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_PrevColTo)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0003AD80 File Offset: 0x00038F80
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x000047A8 File Offset: 0x000029A8
		public unsafe int m_Cursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Cursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Cursor)) = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0003ADA8 File Offset: 0x00038FA8
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x000047C3 File Offset: 0x000029C3
		public unsafe int m_StartCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_StartCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_StartCursor)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0003ADD0 File Offset: 0x00038FD0
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x000047DE File Offset: 0x000029DE
		public unsafe int m_Line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Line)) = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0003ADF8 File Offset: 0x00038FF8
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x000047F9 File Offset: 0x000029F9
		public unsafe int m_Col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Col);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_Col)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0003AE20 File Offset: 0x00039020
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00004814 File Offset: 0x00002A14
		public unsafe int m_SourceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_SourceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_SourceId)) = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0003AE48 File Offset: 0x00039048
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0000482F File Offset: 0x00002A2F
		public unsafe bool m_AutoSkipComments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_AutoSkipComments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lexer.NativeFieldInfoPtr_m_AutoSkipComments)) = value;
			}
		}

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_m_Current;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_m_Code;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevLineTo;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevColTo;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr_m_Cursor;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeFieldInfoPtr_m_StartCursor;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_m_Line;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr_m_Col;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceId;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSkipComments;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_Token_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Boolean_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_FetchNewToken_Private_Token_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Void_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_PeekNext_Public_Token_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_CursorNext_Private_Void_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_CursorChar_Private_Char_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_CursorCharNext_Private_Char_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_CursorMatches_Private_Boolean_String_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_CursorNotEof_Private_Boolean_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpace_Private_Void_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_ReadToken_Private_Token_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_ReadLongString_Private_String_Int32_Int32_String_String_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_ReadNumberToken_Private_Token_Int32_Int32_Boolean_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_CreateSingleCharToken_Private_Token_TokenType_Int32_Int32_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_ReadHashBang_Private_Token_Int32_Int32_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_ReadComment_Private_Token_Int32_Int32_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_ReadSimpleStringToken_Private_Token_Int32_Int32_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_PotentiallyDoubleCharOperator_Private_Token_Char_TokenType_TokenType_Int32_Int32_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_CreateNameToken_Private_Token_String_Int32_Int32_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_CreateToken_Private_Token_TokenType_Int32_Int32_String_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_ReadNameToken_Private_String_0;
	}
}
