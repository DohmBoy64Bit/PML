using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000069 RID: 105
	public class ForEachLoopStatement : Statement
	{
		// Token: 0x060009F5 RID: 2549 RVA: 0x0003CB18 File Offset: 0x0003AD18
		// Note: this type is marked as 'beforefieldinit'.
		static ForEachLoopStatement()
		{
			Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "ForEachLoopStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr);
			ForEachLoopStatement.NativeFieldInfoPtr_m_StackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, "m_StackFrame");
			ForEachLoopStatement.NativeFieldInfoPtr_m_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, "m_Names");
			ForEachLoopStatement.NativeFieldInfoPtr_m_NameExps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, "m_NameExps");
			ForEachLoopStatement.NativeFieldInfoPtr_m_RValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, "m_RValues");
			ForEachLoopStatement.NativeFieldInfoPtr_m_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, "m_Block");
			ForEachLoopStatement.NativeFieldInfoPtr_m_RefFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, "m_RefFor");
			ForEachLoopStatement.NativeFieldInfoPtr_m_RefEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, "m_RefEnd");
			ForEachLoopStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, 100665125);
			ForEachLoopStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, 100665126);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0003CBFC File Offset: 0x0003ADFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29909, RefRangeEnd = 29910, XrefRangeStart = 29821, XrefRangeEnd = 29909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForEachLoopStatement(ScriptLoadingContext lcontext, Token firstNameToken, Token forToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstNameToken);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForEachLoopStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0003CC6C File Offset: 0x0003AE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29910, XrefRangeEnd = 29961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForEachLoopStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00004B3B File Offset: 0x00002D3B
		public ForEachLoopStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0003CCBC File Offset: 0x0003AEBC
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00004B44 File Offset: 0x00002D44
		public unsafe RuntimeScopeBlock m_StackFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_StackFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_StackFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0003CCEC File Offset: 0x0003AEEC
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00004B63 File Offset: 0x00002D63
		public unsafe Il2CppReferenceArray<SymbolRef> m_Names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_Names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SymbolRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_Names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0003CD1C File Offset: 0x0003AF1C
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00004B82 File Offset: 0x00002D82
		public unsafe Il2CppReferenceArray<IVariable> m_NameExps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_NameExps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_NameExps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0003CD4C File Offset: 0x0003AF4C
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00004BA1 File Offset: 0x00002DA1
		public unsafe Expression m_RValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_RValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_RValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0003CD7C File Offset: 0x0003AF7C
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public unsafe Statement m_Block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_Block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_Block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0003CDAC File Offset: 0x0003AFAC
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00004BDF File Offset: 0x00002DDF
		public unsafe SourceRef m_RefFor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_RefFor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_RefFor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0003CDDC File Offset: 0x0003AFDC
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00004BFE File Offset: 0x00002DFE
		public unsafe SourceRef m_RefEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_RefEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.NativeFieldInfoPtr_m_RefEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr_m_StackFrame;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_m_Names;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_m_NameExps;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_m_RValues;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_m_Block;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_m_RefFor;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_m_RefEnd;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_Token_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x020001A0 RID: 416
		[ObfuscatedName("MoonSharp.Interpreter.Tree.Statements.ForEachLoopStatement+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06001A72 RID: 6770 RVA: 0x00081770 File Offset: 0x0007F970
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ForEachLoopStatement.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForEachLoopStatement>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForEachLoopStatement.__c__DisplayClass7_0>.NativeClassPtr);
				ForEachLoopStatement.__c__DisplayClass7_0.NativeFieldInfoPtr_lcontext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForEachLoopStatement.__c__DisplayClass7_0>.NativeClassPtr, "lcontext");
				ForEachLoopStatement.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForEachLoopStatement.__c__DisplayClass7_0>.NativeClassPtr, 100665127);
				ForEachLoopStatement.__c__DisplayClass7_0.NativeMethodInfoPtr___ctor_b__0_Internal_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForEachLoopStatement.__c__DisplayClass7_0>.NativeClassPtr, 100665128);
				ForEachLoopStatement.__c__DisplayClass7_0.NativeMethodInfoPtr___ctor_b__1_Internal_SymbolRefExpression_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForEachLoopStatement.__c__DisplayClass7_0>.NativeClassPtr, 100665129);
			}

			// Token: 0x06001A73 RID: 6771 RVA: 0x000817EC File Offset: 0x0007F9EC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForEachLoopStatement.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForEachLoopStatement.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A74 RID: 6772 RVA: 0x00081828 File Offset: 0x0007FA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29814, XrefRangeEnd = 29816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SymbolRef __ctor_b__0(string n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForEachLoopStatement.__c__DisplayClass7_0.NativeMethodInfoPtr___ctor_b__0_Internal_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
				}
			}

			// Token: 0x06001A75 RID: 6773 RVA: 0x00081878 File Offset: 0x0007FA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29816, XrefRangeEnd = 29821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SymbolRefExpression __ctor_b__1(SymbolRef s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForEachLoopStatement.__c__DisplayClass7_0.NativeMethodInfoPtr___ctor_b__1_Internal_SymbolRefExpression_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRefExpression>(intPtr3) : null;
				}
			}

			// Token: 0x06001A76 RID: 6774 RVA: 0x0000A6C6 File Offset: 0x000088C6
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x06001A77 RID: 6775 RVA: 0x000818C8 File Offset: 0x0007FAC8
			// (set) Token: 0x06001A78 RID: 6776 RVA: 0x0000A6CF File Offset: 0x000088CF
			public unsafe ScriptLoadingContext lcontext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.__c__DisplayClass7_0.NativeFieldInfoPtr_lcontext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptLoadingContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForEachLoopStatement.__c__DisplayClass7_0.NativeFieldInfoPtr_lcontext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015A1 RID: 5537
			private static readonly IntPtr NativeFieldInfoPtr_lcontext;

			// Token: 0x040015A2 RID: 5538
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015A3 RID: 5539
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_SymbolRef_String_0;

			// Token: 0x040015A4 RID: 5540
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_Internal_SymbolRefExpression_SymbolRef_0;
		}
	}
}
