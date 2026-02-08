using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000075 RID: 117
	public class AdjustmentExpression : Expression
	{
		// Token: 0x06000ABC RID: 2748 RVA: 0x0003F294 File Offset: 0x0003D494
		// Note: this type is marked as 'beforefieldinit'.
		static AdjustmentExpression()
		{
			Il2CppClassPointerStore<AdjustmentExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "AdjustmentExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdjustmentExpression>.NativeClassPtr);
			AdjustmentExpression.NativeFieldInfoPtr_expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustmentExpression>.NativeClassPtr, "expression");
			AdjustmentExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentExpression>.NativeClassPtr, 100665192);
			AdjustmentExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentExpression>.NativeClassPtr, 100665193);
			AdjustmentExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustmentExpression>.NativeClassPtr, 100665194);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0003F314 File Offset: 0x0003D514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30755, XrefRangeEnd = 30757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdjustmentExpression(ScriptLoadingContext lcontext, Expression exp)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdjustmentExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustmentExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0003F374 File Offset: 0x0003D574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30757, XrefRangeEnd = 30759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdjustmentExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0003F3C4 File Offset: 0x0003D5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30759, XrefRangeEnd = 30761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdjustmentExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00005295 File Offset: 0x00003495
		public AdjustmentExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0003F420 File Offset: 0x0003D620
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0000529E File Offset: 0x0000349E
		public unsafe Expression expression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustmentExpression.NativeFieldInfoPtr_expression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustmentExpression.NativeFieldInfoPtr_expression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeFieldInfoPtr_expression;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;
	}
}
