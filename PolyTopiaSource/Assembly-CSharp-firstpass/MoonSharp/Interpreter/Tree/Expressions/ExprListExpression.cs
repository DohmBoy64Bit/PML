using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000078 RID: 120
	public class ExprListExpression : Expression
	{
		// Token: 0x06000AF2 RID: 2802 RVA: 0x0003FFC0 File Offset: 0x0003E1C0
		// Note: this type is marked as 'beforefieldinit'.
		static ExprListExpression()
		{
			Il2CppClassPointerStore<ExprListExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "ExprListExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExprListExpression>.NativeClassPtr);
			ExprListExpression.NativeFieldInfoPtr_expressions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExprListExpression>.NativeClassPtr, "expressions");
			ExprListExpression.NativeMethodInfoPtr__ctor_Public_Void_List_1_Expression_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprListExpression>.NativeClassPtr, 100665218);
			ExprListExpression.NativeMethodInfoPtr_GetExpressions_Public_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprListExpression>.NativeClassPtr, 100665219);
			ExprListExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprListExpression>.NativeClassPtr, 100665220);
			ExprListExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExprListExpression>.NativeClassPtr, 100665221);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00040054 File Offset: 0x0003E254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30937, XrefRangeEnd = 30939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExprListExpression(List<Expression> exps, ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExprListExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprListExpression.NativeMethodInfoPtr__ctor_Public_Void_List_1_Expression_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x000400B4 File Offset: 0x0003E2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30939, XrefRangeEnd = 30943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Expression> GetExpressions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExprListExpression.NativeMethodInfoPtr_GetExpressions_Public_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Expression>>(intPtr3) : null;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000400F4 File Offset: 0x0003E2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30943, XrefRangeEnd = 30959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExprListExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00040144 File Offset: 0x0003E344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30959, XrefRangeEnd = 30968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExprListExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000053A9 File Offset: 0x000035A9
		public ExprListExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x000401A0 File Offset: 0x0003E3A0
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x000053B2 File Offset: 0x000035B2
		public unsafe List<Expression> expressions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExprListExpression.NativeFieldInfoPtr_expressions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExprListExpression.NativeFieldInfoPtr_expressions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr_expressions;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Expression_ScriptLoadingContext_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_GetExpressions_Public_Il2CppReferenceArray_1_Expression_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;
	}
}
