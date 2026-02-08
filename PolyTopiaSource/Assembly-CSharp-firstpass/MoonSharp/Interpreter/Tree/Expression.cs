using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Execution;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005A RID: 90
	public class Expression : NodeBase
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00039E50 File Offset: 0x00038050
		// Note: this type is marked as 'beforefieldinit'.
		static Expression()
		{
			Il2CppClassPointerStore<Expression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree", "Expression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression>.NativeClassPtr);
			Expression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665036);
			Expression.NativeMethodInfoPtr_GetFriendlyDebugName_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665037);
			Expression.NativeMethodInfoPtr_Eval_Public_Abstract_Virtual_New_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665038);
			Expression.NativeMethodInfoPtr_FindDynamic_Public_Virtual_New_SymbolRef_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665039);
			Expression.NativeMethodInfoPtr_ExprListAfterFirstExpr_Internal_Static_List_1_Expression_ScriptLoadingContext_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665040);
			Expression.NativeMethodInfoPtr_ExprList_Internal_Static_List_1_Expression_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665041);
			Expression.NativeMethodInfoPtr_Expr_Internal_Static_Expression_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665042);
			Expression.NativeMethodInfoPtr_SubExpr_Internal_Static_Expression_ScriptLoadingContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665043);
			Expression.NativeMethodInfoPtr_SimpleExp_Internal_Static_Expression_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665044);
			Expression.NativeMethodInfoPtr_PrimaryExp_Internal_Static_Expression_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665045);
			Expression.NativeMethodInfoPtr_PrefixExp_Private_Static_Expression_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100665046);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00039F5C File Offset: 0x0003815C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 28426, RefRangeEnd = 28449, XrefRangeStart = 28425, XrefRangeEnd = 28426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expression>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00039FA8 File Offset: 0x000381A8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetFriendlyDebugName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Expression.NativeMethodInfoPtr_GetFriendlyDebugName_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00039FEC File Offset: 0x000381EC
		[CallerCount(0)]
		public unsafe virtual DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Expression.NativeMethodInfoPtr_Eval_Public_Abstract_Virtual_New_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0003A048 File Offset: 0x00038248
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Expression.NativeMethodInfoPtr_FindDynamic_Public_Virtual_New_SymbolRef_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0003A0A4 File Offset: 0x000382A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28449, XrefRangeEnd = 28470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Expression> ExprListAfterFirstExpr(ScriptLoadingContext lcontext, Expression expr1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expr1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression.NativeMethodInfoPtr_ExprListAfterFirstExpr_Internal_Static_List_1_Expression_ScriptLoadingContext_Expression_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Expression>>(intPtr3) : null;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0003A0FC File Offset: 0x000382FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 28488, RefRangeEnd = 28493, XrefRangeStart = 28470, XrefRangeEnd = 28488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Expression> ExprList(ScriptLoadingContext lcontext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression.NativeMethodInfoPtr_ExprList_Internal_Static_List_1_Expression_ScriptLoadingContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0003A140 File Offset: 0x00038340
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 28494, RefRangeEnd = 28506, XrefRangeStart = 28493, XrefRangeEnd = 28494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression Expr(ScriptLoadingContext lcontext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression.NativeMethodInfoPtr_Expr_Internal_Static_Expression_ScriptLoadingContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0003A184 File Offset: 0x00038384
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 28561, RefRangeEnd = 28568, XrefRangeStart = 28506, XrefRangeEnd = 28561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression SubExpr(ScriptLoadingContext lcontext, bool isPrimary)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPrimary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression.NativeMethodInfoPtr_SubExpr_Internal_Static_Expression_ScriptLoadingContext_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0003A1D8 File Offset: 0x000383D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28578, RefRangeEnd = 28579, XrefRangeStart = 28568, XrefRangeEnd = 28578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression SimpleExp(ScriptLoadingContext lcontext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression.NativeMethodInfoPtr_SimpleExp_Internal_Static_Expression_ScriptLoadingContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0003A21C File Offset: 0x0003841C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 28586, RefRangeEnd = 28588, XrefRangeStart = 28579, XrefRangeEnd = 28586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression PrimaryExp(ScriptLoadingContext lcontext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression.NativeMethodInfoPtr_PrimaryExp_Internal_Static_Expression_ScriptLoadingContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0003A260 File Offset: 0x00038460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28596, RefRangeEnd = 28597, XrefRangeStart = 28588, XrefRangeEnd = 28596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression PrefixExp(ScriptLoadingContext lcontext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression.NativeMethodInfoPtr_PrefixExp_Private_Static_Expression_ScriptLoadingContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000046EA File Offset: 0x000028EA
		public Expression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendlyDebugName_Public_Virtual_New_String_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Abstract_Virtual_New_DynValue_ScriptExecutionContext_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_FindDynamic_Public_Virtual_New_SymbolRef_ScriptExecutionContext_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_ExprListAfterFirstExpr_Internal_Static_List_1_Expression_ScriptLoadingContext_Expression_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_ExprList_Internal_Static_List_1_Expression_ScriptLoadingContext_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_Expr_Internal_Static_Expression_ScriptLoadingContext_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_SubExpr_Internal_Static_Expression_ScriptLoadingContext_Boolean_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_SimpleExp_Internal_Static_Expression_ScriptLoadingContext_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_PrimaryExp_Internal_Static_Expression_ScriptLoadingContext_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_PrefixExp_Private_Static_Expression_ScriptLoadingContext_0;
	}
}
