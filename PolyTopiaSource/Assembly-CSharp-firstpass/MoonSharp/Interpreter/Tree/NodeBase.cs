using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x02000062 RID: 98
	public class NodeBase : Object
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x0003BB88 File Offset: 0x00039D88
		// Note: this type is marked as 'beforefieldinit'.
		static NodeBase()
		{
			Il2CppClassPointerStore<NodeBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree", "NodeBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeBase>.NativeClassPtr);
			NodeBase.NativeFieldInfoPtr__Script_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, "<Script>k__BackingField");
			NodeBase.NativeFieldInfoPtr__LoadingContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, "<LoadingContext>k__BackingField");
			NodeBase.NativeMethodInfoPtr_get_Script_Public_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665097);
			NodeBase.NativeMethodInfoPtr_set_Script_Private_set_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665098);
			NodeBase.NativeMethodInfoPtr_get_LoadingContext_Protected_get_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665099);
			NodeBase.NativeMethodInfoPtr_set_LoadingContext_Private_set_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665100);
			NodeBase.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665101);
			NodeBase.NativeMethodInfoPtr_Compile_Public_Abstract_Virtual_New_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665102);
			NodeBase.NativeMethodInfoPtr_UnexpectedTokenType_Protected_Static_Token_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665103);
			NodeBase.NativeMethodInfoPtr_CheckTokenType_Protected_Static_Token_ScriptLoadingContext_TokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665104);
			NodeBase.NativeMethodInfoPtr_CheckTokenType_Protected_Static_Token_ScriptLoadingContext_TokenType_TokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665105);
			NodeBase.NativeMethodInfoPtr_CheckTokenType_Protected_Static_Token_ScriptLoadingContext_TokenType_TokenType_TokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665106);
			NodeBase.NativeMethodInfoPtr_CheckTokenTypeNotNext_Protected_Static_Void_ScriptLoadingContext_TokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665107);
			NodeBase.NativeMethodInfoPtr_CheckMatch_Protected_Static_Token_ScriptLoadingContext_Token_TokenType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeBase>.NativeClassPtr, 100665108);
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0003BCD0 File Offset: 0x00039ED0
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x0003BD10 File Offset: 0x00039F10
		public unsafe Script Script
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_get_Script_Public_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_set_Script_Private_set_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0003BD54 File Offset: 0x00039F54
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x0003BD94 File Offset: 0x00039F94
		public unsafe ScriptLoadingContext LoadingContext
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_get_LoadingContext_Protected_get_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptLoadingContext>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_set_LoadingContext_Private_set_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0003BDD8 File Offset: 0x00039FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29440, RefRangeEnd = 29441, XrefRangeStart = 29437, XrefRangeEnd = 29440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeBase(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0003BE24 File Offset: 0x0003A024
		[CallerCount(0)]
		public unsafe virtual void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NodeBase.NativeMethodInfoPtr_Compile_Public_Abstract_Virtual_New_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0003BE74 File Offset: 0x0003A074
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 29457, RefRangeEnd = 29468, XrefRangeStart = 29441, XrefRangeEnd = 29457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token UnexpectedTokenType(Token t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_UnexpectedTokenType_Protected_Static_Token_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0003BEB8 File Offset: 0x0003A0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29468, XrefRangeEnd = 29470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_CheckTokenType_Protected_Static_Token_ScriptLoadingContext_TokenType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0003BF10 File Offset: 0x0003A110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29470, XrefRangeEnd = 29472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenType1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenType2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_CheckTokenType_Protected_Static_Token_ScriptLoadingContext_TokenType_TokenType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0003BF78 File Offset: 0x0003A178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29472, XrefRangeEnd = 29474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2, TokenType tokenType3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenType1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenType2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenType3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_CheckTokenType_Protected_Static_Token_ScriptLoadingContext_TokenType_TokenType_TokenType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0003BFF4 File Offset: 0x0003A1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29474, XrefRangeEnd = 29475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTokenTypeNotNext(ScriptLoadingContext lcontext, TokenType tokenType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_CheckTokenTypeNotNext_Protected_Static_Void_ScriptLoadingContext_TokenType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0003C03C File Offset: 0x0003A23C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29477, RefRangeEnd = 29479, XrefRangeStart = 29475, XrefRangeEnd = 29477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Token CheckMatch(ScriptLoadingContext lcontext, Token originalToken, TokenType expectedTokenType, string expectedTokenText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalToken);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expectedTokenType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedTokenText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeBase.NativeMethodInfoPtr_CheckMatch_Protected_Static_Token_ScriptLoadingContext_Token_TokenType_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000049A7 File Offset: 0x00002BA7
		public NodeBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0003C0B8 File Offset: 0x0003A2B8
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000049B0 File Offset: 0x00002BB0
		public unsafe Script _Script_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeBase.NativeFieldInfoPtr__Script_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeBase.NativeFieldInfoPtr__Script_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0003C0E8 File Offset: 0x0003A2E8
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000049CF File Offset: 0x00002BCF
		public unsafe ScriptLoadingContext _LoadingContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeBase.NativeFieldInfoPtr__LoadingContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptLoadingContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeBase.NativeFieldInfoPtr__LoadingContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeFieldInfoPtr__Script_k__BackingField;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeFieldInfoPtr__LoadingContext_k__BackingField;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_get_Script_Public_get_Script_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_set_Script_Private_set_Void_Script_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadingContext_Protected_get_ScriptLoadingContext_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadingContext_Private_set_Void_ScriptLoadingContext_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Abstract_Virtual_New_Void_ByteCode_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_UnexpectedTokenType_Protected_Static_Token_Token_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_CheckTokenType_Protected_Static_Token_ScriptLoadingContext_TokenType_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_CheckTokenType_Protected_Static_Token_ScriptLoadingContext_TokenType_TokenType_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_CheckTokenType_Protected_Static_Token_ScriptLoadingContext_TokenType_TokenType_TokenType_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_CheckTokenTypeNotNext_Protected_Static_Void_ScriptLoadingContext_TokenType_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_CheckMatch_Protected_Static_Token_ScriptLoadingContext_Token_TokenType_String_0;
	}
}
