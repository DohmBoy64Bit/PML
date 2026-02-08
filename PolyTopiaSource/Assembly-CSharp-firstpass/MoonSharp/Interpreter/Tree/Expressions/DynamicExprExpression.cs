using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000077 RID: 119
	public class DynamicExprExpression : Expression
	{
		// Token: 0x06000AEA RID: 2794 RVA: 0x0003FD94 File Offset: 0x0003DF94
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicExprExpression()
		{
			Il2CppClassPointerStore<DynamicExprExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "DynamicExprExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicExprExpression>.NativeClassPtr);
			DynamicExprExpression.NativeFieldInfoPtr_m_Exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicExprExpression>.NativeClassPtr, "m_Exp");
			DynamicExprExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExprExpression>.NativeClassPtr, 100665214);
			DynamicExprExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExprExpression>.NativeClassPtr, 100665215);
			DynamicExprExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExprExpression>.NativeClassPtr, 100665216);
			DynamicExprExpression.NativeMethodInfoPtr_FindDynamic_Public_Virtual_SymbolRef_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExprExpression>.NativeClassPtr, 100665217);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0003FE28 File Offset: 0x0003E028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30927, XrefRangeEnd = 30930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicExprExpression(Expression exp, ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicExprExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExprExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0003FE88 File Offset: 0x0003E088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30930, XrefRangeEnd = 30931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicExprExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0003FEE4 File Offset: 0x0003E0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30931, XrefRangeEnd = 30936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicExprExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0003FF34 File Offset: 0x0003E134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30936, XrefRangeEnd = 30937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicExprExpression.NativeMethodInfoPtr_FindDynamic_Public_Virtual_SymbolRef_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00005381 File Offset: 0x00003581
		public DynamicExprExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0003FF90 File Offset: 0x0003E190
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x0000538A File Offset: 0x0000358A
		public unsafe Expression m_Exp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExprExpression.NativeFieldInfoPtr_m_Exp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicExprExpression.NativeFieldInfoPtr_m_Exp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_m_Exp;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_ScriptLoadingContext_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_FindDynamic_Public_Virtual_SymbolRef_ScriptExecutionContext_0;
	}
}
