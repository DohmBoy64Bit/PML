using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006A RID: 106
	public class ForLoopStatement : Statement
	{
		// Token: 0x06000A07 RID: 2567 RVA: 0x0003CE0C File Offset: 0x0003B00C
		// Note: this type is marked as 'beforefieldinit'.
		static ForLoopStatement()
		{
			Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "ForLoopStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr);
			ForLoopStatement.NativeFieldInfoPtr_m_StackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, "m_StackFrame");
			ForLoopStatement.NativeFieldInfoPtr_m_InnerBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, "m_InnerBlock");
			ForLoopStatement.NativeFieldInfoPtr_m_VarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, "m_VarName");
			ForLoopStatement.NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, "m_Start");
			ForLoopStatement.NativeFieldInfoPtr_m_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, "m_End");
			ForLoopStatement.NativeFieldInfoPtr_m_Step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, "m_Step");
			ForLoopStatement.NativeFieldInfoPtr_m_RefFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, "m_RefFor");
			ForLoopStatement.NativeFieldInfoPtr_m_RefEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, "m_RefEnd");
			ForLoopStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, 100665130);
			ForLoopStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr, 100665131);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0003CF04 File Offset: 0x0003B104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29961, XrefRangeEnd = 30013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForLoopStatement(ScriptLoadingContext lcontext, Token nameToken, Token forToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForLoopStatement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameToken);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForLoopStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0003CF74 File Offset: 0x0003B174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30013, XrefRangeEnd = 30054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForLoopStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00004C1D File Offset: 0x00002E1D
		public ForLoopStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0003CFC4 File Offset: 0x0003B1C4
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00004C26 File Offset: 0x00002E26
		public unsafe RuntimeScopeBlock m_StackFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_StackFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_StackFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0003CFF4 File Offset: 0x0003B1F4
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00004C45 File Offset: 0x00002E45
		public unsafe Statement m_InnerBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_InnerBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_InnerBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0003D024 File Offset: 0x0003B224
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00004C64 File Offset: 0x00002E64
		public unsafe SymbolRef m_VarName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_VarName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_VarName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0003D054 File Offset: 0x0003B254
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00004C83 File Offset: 0x00002E83
		public unsafe Expression m_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_Start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_Start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0003D084 File Offset: 0x0003B284
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00004CA2 File Offset: 0x00002EA2
		public unsafe Expression m_End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_End);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_End), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0003D0B4 File Offset: 0x0003B2B4
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00004CC1 File Offset: 0x00002EC1
		public unsafe Expression m_Step
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_Step);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_Step), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0003D0E4 File Offset: 0x0003B2E4
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public unsafe SourceRef m_RefFor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_RefFor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_RefFor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0003D114 File Offset: 0x0003B314
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00004CFF File Offset: 0x00002EFF
		public unsafe SourceRef m_RefEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_RefEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForLoopStatement.NativeFieldInfoPtr_m_RefEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_m_StackFrame;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_m_InnerBlock;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_m_VarName;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_m_Start;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_m_End;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_m_Step;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeFieldInfoPtr_m_RefFor;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_m_RefEnd;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_Token_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;
	}
}
