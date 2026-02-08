using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000064 RID: 100
	public class AssignmentStatement : Statement
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x0003C268 File Offset: 0x0003A468
		// Note: this type is marked as 'beforefieldinit'.
		static AssignmentStatement()
		{
			Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "AssignmentStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr);
			AssignmentStatement.NativeFieldInfoPtr_m_LValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr, "m_LValues");
			AssignmentStatement.NativeFieldInfoPtr_m_RValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr, "m_RValues");
			AssignmentStatement.NativeFieldInfoPtr_m_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr, "m_Ref");
			AssignmentStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr, 100665112);
			AssignmentStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr, 100665113);
			AssignmentStatement.NativeMethodInfoPtr_CheckVar_Private_IVariable_ScriptLoadingContext_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr, 100665114);
			AssignmentStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr, 100665115);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0003C324 File Offset: 0x0003A524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29517, XrefRangeEnd = 29603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignmentStatement(ScriptLoadingContext lcontext, Token startToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignmentStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0003C384 File Offset: 0x0003A584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29603, XrefRangeEnd = 29636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignmentStatement(ScriptLoadingContext lcontext, Expression firstExpression, Token first)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignmentStatement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstExpression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(first);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignmentStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0003C3F4 File Offset: 0x0003A5F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29639, RefRangeEnd = 29641, XrefRangeStart = 29636, XrefRangeEnd = 29639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IVariable CheckVar(ScriptLoadingContext lcontext, Expression firstExpression)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstExpression);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignmentStatement.NativeMethodInfoPtr_CheckVar_Private_IVariable_ScriptLoadingContext_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVariable>(intPtr3) : null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0003C458 File Offset: 0x0003A658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29641, XrefRangeEnd = 29678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignmentStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000049F7 File Offset: 0x00002BF7
		public AssignmentStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0003C4A8 File Offset: 0x0003A6A8
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00004A00 File Offset: 0x00002C00
		public unsafe List<IVariable> m_LValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignmentStatement.NativeFieldInfoPtr_m_LValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignmentStatement.NativeFieldInfoPtr_m_LValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0003C4D8 File Offset: 0x0003A6D8
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x00004A1F File Offset: 0x00002C1F
		public unsafe List<Expression> m_RValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignmentStatement.NativeFieldInfoPtr_m_RValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignmentStatement.NativeFieldInfoPtr_m_RValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0003C508 File Offset: 0x0003A708
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x00004A3E File Offset: 0x00002C3E
		public unsafe SourceRef m_Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignmentStatement.NativeFieldInfoPtr_m_Ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignmentStatement.NativeFieldInfoPtr_m_Ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_m_LValues;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_m_RValues;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr_m_Ref;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Token_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_Token_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_CheckVar_Private_IVariable_ScriptLoadingContext_Expression_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;
	}
}
