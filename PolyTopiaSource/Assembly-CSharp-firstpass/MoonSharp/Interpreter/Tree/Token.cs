using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005E RID: 94
	public class Token : Object
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x0003B1BC File Offset: 0x000393BC
		// Note: this type is marked as 'beforefieldinit'.
		static Token()
		{
			Il2CppClassPointerStore<Token>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree", "Token");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Token>.NativeClassPtr);
			Token.NativeFieldInfoPtr_SourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "SourceId");
			Token.NativeFieldInfoPtr_FromCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "FromCol");
			Token.NativeFieldInfoPtr_ToCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "ToCol");
			Token.NativeFieldInfoPtr_FromLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "FromLine");
			Token.NativeFieldInfoPtr_ToLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "ToLine");
			Token.NativeFieldInfoPtr_PrevCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "PrevCol");
			Token.NativeFieldInfoPtr_PrevLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "PrevLine");
			Token.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "Type");
			Token.NativeFieldInfoPtr__Text_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Token>.NativeClassPtr, "<Text>k__BackingField");
			Token.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665079);
			Token.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665080);
			Token.NativeMethodInfoPtr__ctor_Public_Void_TokenType_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665081);
			Token.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665082);
			Token.NativeMethodInfoPtr_GetReservedTokenType_Public_Static_Nullable_1_TokenType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665083);
			Token.NativeMethodInfoPtr_GetNumberValue_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665084);
			Token.NativeMethodInfoPtr_IsEndOfBlock_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665085);
			Token.NativeMethodInfoPtr_IsUnaryOperator_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665086);
			Token.NativeMethodInfoPtr_IsBinaryOperator_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665087);
			Token.NativeMethodInfoPtr_GetSourceRef_Internal_SourceRef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665088);
			Token.NativeMethodInfoPtr_GetSourceRef_Internal_SourceRef_Token_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665089);
			Token.NativeMethodInfoPtr_GetSourceRefUpTo_Internal_SourceRef_Token_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Token>.NativeClassPtr, 100665090);
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0003B390 File Offset: 0x00039590
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x0003B3C8 File Offset: 0x000395C8
		public unsafe string Text
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21549, RefRangeEnd = 21556, XrefRangeStart = 21549, XrefRangeEnd = 21556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0003B40C File Offset: 0x0003960C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29290, RefRangeEnd = 29291, XrefRangeStart = 29289, XrefRangeEnd = 29290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token(TokenType type, int sourceId, int fromLine, int fromCol, int toLine, int toCol, int prevLine, int prevCol)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Token>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromLine;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCol;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toLine;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toCol;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevLine;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr__ctor_Public_Void_TokenType_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0003B4BC File Offset: 0x000396BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29291, XrefRangeEnd = 29339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Token.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0003B500 File Offset: 0x00039700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29367, RefRangeEnd = 29368, XrefRangeStart = 29339, XrefRangeEnd = 29367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<TokenType> GetReservedTokenType(string reservedWord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reservedWord);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_GetReservedTokenType_Public_Static_Nullable_1_TokenType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<TokenType>>(intPtr3) : null;
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0003B544 File Offset: 0x00039744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29375, RefRangeEnd = 29377, XrefRangeStart = 29368, XrefRangeEnd = 29375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetNumberValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_GetNumberValue_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0003B580 File Offset: 0x00039780
		[CallerCount(0)]
		public unsafe bool IsEndOfBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_IsEndOfBlock_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0003B5BC File Offset: 0x000397BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29377, RefRangeEnd = 29378, XrefRangeStart = 29377, XrefRangeEnd = 29377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnaryOperator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_IsUnaryOperator_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0003B5F8 File Offset: 0x000397F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29378, RefRangeEnd = 29380, XrefRangeStart = 29378, XrefRangeEnd = 29378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBinaryOperator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_IsBinaryOperator_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0003B634 File Offset: 0x00039834
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 29384, RefRangeEnd = 29397, XrefRangeStart = 29380, XrefRangeEnd = 29384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceRef GetSourceRef(bool isStepStop = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isStepStop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_GetSourceRef_Internal_SourceRef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0003B680 File Offset: 0x00039880
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 29401, RefRangeEnd = 29405, XrefRangeStart = 29397, XrefRangeEnd = 29401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceRef GetSourceRef(Token to, bool isStepStop = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(to);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStepStop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_GetSourceRef_Internal_SourceRef_Token_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0003B6E0 File Offset: 0x000398E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29409, RefRangeEnd = 29411, XrefRangeStart = 29405, XrefRangeEnd = 29409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceRef GetSourceRefUpTo(Token to, bool isStepStop = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(to);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStepStop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Token.NativeMethodInfoPtr_GetSourceRefUpTo_Internal_SourceRef_Token_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00004853 File Offset: 0x00002A53
		public Token(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0003B740 File Offset: 0x00039940
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0000485C File Offset: 0x00002A5C
		public unsafe int SourceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_SourceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_SourceId)) = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0003B768 File Offset: 0x00039968
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x00004877 File Offset: 0x00002A77
		public unsafe int FromCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_FromCol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_FromCol)) = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0003B790 File Offset: 0x00039990
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x00004892 File Offset: 0x00002A92
		public unsafe int ToCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_ToCol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_ToCol)) = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0003B7B8 File Offset: 0x000399B8
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x000048AD File Offset: 0x00002AAD
		public unsafe int FromLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_FromLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_FromLine)) = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0003B7E0 File Offset: 0x000399E0
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x000048C8 File Offset: 0x00002AC8
		public unsafe int ToLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_ToLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_ToLine)) = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0003B808 File Offset: 0x00039A08
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x000048E3 File Offset: 0x00002AE3
		public unsafe int PrevCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_PrevCol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_PrevCol)) = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0003B830 File Offset: 0x00039A30
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x000048FE File Offset: 0x00002AFE
		public unsafe int PrevLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_PrevLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_PrevLine)) = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0003B858 File Offset: 0x00039A58
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x00004919 File Offset: 0x00002B19
		public unsafe TokenType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0003B888 File Offset: 0x00039A88
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00004938 File Offset: 0x00002B38
		public unsafe string _Text_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr__Text_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Token.NativeFieldInfoPtr__Text_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_SourceId;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_FromCol;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_ToCol;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_FromLine;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr_ToLine;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr_PrevCol;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr_PrevLine;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeFieldInfoPtr__Text_k__BackingField;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TokenType_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_GetReservedTokenType_Public_Static_Nullable_1_TokenType_String_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberValue_Public_Double_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_IsEndOfBlock_Public_Boolean_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_IsUnaryOperator_Public_Boolean_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_IsBinaryOperator_Public_Boolean_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceRef_Internal_SourceRef_Boolean_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceRef_Internal_SourceRef_Token_Boolean_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceRefUpTo_Internal_SourceRef_Token_Boolean_0;
	}
}
