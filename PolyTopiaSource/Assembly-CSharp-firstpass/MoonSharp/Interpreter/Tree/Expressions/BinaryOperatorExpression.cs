using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000076 RID: 118
	public class BinaryOperatorExpression : Expression
	{
		// Token: 0x06000AC3 RID: 2755 RVA: 0x0003F450 File Offset: 0x0003D650
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryOperatorExpression()
		{
			Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "BinaryOperatorExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr);
			BinaryOperatorExpression.NativeFieldInfoPtr_POWER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "POWER");
			BinaryOperatorExpression.NativeFieldInfoPtr_MUL_DIV_MOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "MUL_DIV_MOD");
			BinaryOperatorExpression.NativeFieldInfoPtr_ADD_SUB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "ADD_SUB");
			BinaryOperatorExpression.NativeFieldInfoPtr_STRCAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "STRCAT");
			BinaryOperatorExpression.NativeFieldInfoPtr_COMPARES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "COMPARES");
			BinaryOperatorExpression.NativeFieldInfoPtr_LOGIC_AND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "LOGIC_AND");
			BinaryOperatorExpression.NativeFieldInfoPtr_LOGIC_OR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "LOGIC_OR");
			BinaryOperatorExpression.NativeFieldInfoPtr_m_Exp1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "m_Exp1");
			BinaryOperatorExpression.NativeFieldInfoPtr_m_Exp2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "m_Exp2");
			BinaryOperatorExpression.NativeFieldInfoPtr_m_Operator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "m_Operator");
			BinaryOperatorExpression.NativeMethodInfoPtr__ctor_Private_Void_Expression_Expression_Operator_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665205);
			BinaryOperatorExpression.NativeMethodInfoPtr_BeginOperatorChain_Public_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665195);
			BinaryOperatorExpression.NativeMethodInfoPtr_AddExpressionToChain_Public_Static_Void_Object_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665196);
			BinaryOperatorExpression.NativeMethodInfoPtr_AddOperatorToChain_Public_Static_Void_Object_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665197);
			BinaryOperatorExpression.NativeMethodInfoPtr_CommitOperatorChain_Public_Static_Expression_Object_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665198);
			BinaryOperatorExpression.NativeMethodInfoPtr_CreatePowerExpression_Public_Static_Expression_Expression_Expression_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665199);
			BinaryOperatorExpression.NativeMethodInfoPtr_AddNode_Private_Static_Void_LinkedList_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665200);
			BinaryOperatorExpression.NativeMethodInfoPtr_CreateSubTree_Private_Static_Expression_LinkedList_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665201);
			BinaryOperatorExpression.NativeMethodInfoPtr_PrioritizeLeftAssociative_Private_Static_Node_Node_ScriptLoadingContext_Operator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665202);
			BinaryOperatorExpression.NativeMethodInfoPtr_PrioritizeRightAssociative_Private_Static_Node_Node_ScriptLoadingContext_Operator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665203);
			BinaryOperatorExpression.NativeMethodInfoPtr_ParseBinaryOperator_Private_Static_Operator_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665204);
			BinaryOperatorExpression.NativeMethodInfoPtr_ShouldInvertBoolean_Private_Static_Boolean_Operator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665206);
			BinaryOperatorExpression.NativeMethodInfoPtr_OperatorToOpCode_Private_Static_OpCode_Operator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665207);
			BinaryOperatorExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665208);
			BinaryOperatorExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665209);
			BinaryOperatorExpression.NativeMethodInfoPtr_EvalArithmetic_Private_Double_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665210);
			BinaryOperatorExpression.NativeMethodInfoPtr_EvalComparison_Private_Boolean_DynValue_DynValue_Operator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, 100665211);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0003F69C File Offset: 0x0003D89C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30764, RefRangeEnd = 30766, XrefRangeStart = 30761, XrefRangeEnd = 30764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryOperatorExpression(Expression exp1, Expression exp2, BinaryOperatorExpression.Operator op, ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exp2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr__ctor_Private_Void_Expression_Expression_Operator_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0003F71C File Offset: 0x0003D91C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30770, RefRangeEnd = 30771, XrefRangeStart = 30766, XrefRangeEnd = 30770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object BeginOperatorChain()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_BeginOperatorChain_Public_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0003F750 File Offset: 0x0003D950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30785, RefRangeEnd = 30787, XrefRangeStart = 30771, XrefRangeEnd = 30785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddExpressionToChain(Object chain, Expression exp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_AddExpressionToChain_Public_Static_Void_Object_Expression_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0003F798 File Offset: 0x0003D998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30827, RefRangeEnd = 30828, XrefRangeStart = 30787, XrefRangeEnd = 30827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddOperatorToChain(Object chain, Token op)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_AddOperatorToChain_Public_Static_Void_Object_Token_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0003F7E0 File Offset: 0x0003D9E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30832, RefRangeEnd = 30833, XrefRangeStart = 30828, XrefRangeEnd = 30832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression CommitOperatorChain(Object chain, ScriptLoadingContext lcontext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_CommitOperatorChain_Public_Static_Expression_Object_ScriptLoadingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0003F838 File Offset: 0x0003DA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30839, RefRangeEnd = 30840, XrefRangeStart = 30833, XrefRangeEnd = 30839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression CreatePowerExpression(Expression op1, Expression op2, ScriptLoadingContext lcontext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_CreatePowerExpression_Public_Static_Expression_Expression_Expression_ScriptLoadingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0003F8A0 File Offset: 0x0003DAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30840, XrefRangeEnd = 30846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddNode(BinaryOperatorExpression.LinkedList list, BinaryOperatorExpression.Node node)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_AddNode_Private_Static_Void_LinkedList_Node_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0003F8E8 File Offset: 0x0003DAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30853, RefRangeEnd = 30854, XrefRangeStart = 30846, XrefRangeEnd = 30853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression CreateSubTree(BinaryOperatorExpression.LinkedList list, ScriptLoadingContext lcontext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_CreateSubTree_Private_Static_Expression_LinkedList_ScriptLoadingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0003F940 File Offset: 0x0003DB40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 30864, RefRangeEnd = 30869, XrefRangeStart = 30854, XrefRangeEnd = 30864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BinaryOperatorExpression.Node PrioritizeLeftAssociative(BinaryOperatorExpression.Node nodes, ScriptLoadingContext lcontext, BinaryOperatorExpression.Operator operatorsToFind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operatorsToFind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_PrioritizeLeftAssociative_Private_Static_Node_Node_ScriptLoadingContext_Operator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BinaryOperatorExpression.Node>(intPtr3) : null;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0003F9A4 File Offset: 0x0003DBA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30880, RefRangeEnd = 30882, XrefRangeStart = 30869, XrefRangeEnd = 30880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BinaryOperatorExpression.Node PrioritizeRightAssociative(BinaryOperatorExpression.Node nodes, ScriptLoadingContext lcontext, BinaryOperatorExpression.Operator operatorsToFind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operatorsToFind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_PrioritizeRightAssociative_Private_Static_Node_Node_ScriptLoadingContext_Operator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BinaryOperatorExpression.Node>(intPtr3) : null;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0003FA08 File Offset: 0x0003DC08
		[CallerCount(0)]
		public unsafe static BinaryOperatorExpression.Operator ParseBinaryOperator(Token token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_ParseBinaryOperator_Private_Static_Operator_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0003FA4C File Offset: 0x0003DC4C
		[CallerCount(0)]
		public unsafe static bool ShouldInvertBoolean(BinaryOperatorExpression.Operator op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_ShouldInvertBoolean_Private_Static_Boolean_Operator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003FA8C File Offset: 0x0003DC8C
		[CallerCount(0)]
		public unsafe static OpCode OperatorToOpCode(BinaryOperatorExpression.Operator op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_OperatorToOpCode_Private_Static_OpCode_Operator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OpCode>(intPtr3) : null;
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0003FACC File Offset: 0x0003DCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30882, XrefRangeEnd = 30893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryOperatorExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0003FB1C File Offset: 0x0003DD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30893, XrefRangeEnd = 30913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryOperatorExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0003FB78 File Offset: 0x0003DD78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30923, RefRangeEnd = 30924, XrefRangeStart = 30913, XrefRangeEnd = 30923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double EvalArithmetic(DynValue v1, DynValue v2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_EvalArithmetic_Private_Double_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0003FBD8 File Offset: 0x0003DDD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30925, RefRangeEnd = 30927, XrefRangeStart = 30924, XrefRangeEnd = 30925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EvalComparison(DynValue l, DynValue r, BinaryOperatorExpression.Operator op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.NativeMethodInfoPtr_EvalComparison_Private_Boolean_DynValue_DynValue_Operator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000052BD File Offset: 0x000034BD
		public BinaryOperatorExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0003FC48 File Offset: 0x0003DE48
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x000052C6 File Offset: 0x000034C6
		public unsafe static BinaryOperatorExpression.Operator POWER
		{
			get
			{
				BinaryOperatorExpression.Operator @operator;
				IL2CPP.il2cpp_field_static_get_value(BinaryOperatorExpression.NativeFieldInfoPtr_POWER, (void*)(&@operator));
				return @operator;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryOperatorExpression.NativeFieldInfoPtr_POWER, (void*)(&value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0003FC64 File Offset: 0x0003DE64
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x000052D4 File Offset: 0x000034D4
		public unsafe static BinaryOperatorExpression.Operator MUL_DIV_MOD
		{
			get
			{
				BinaryOperatorExpression.Operator @operator;
				IL2CPP.il2cpp_field_static_get_value(BinaryOperatorExpression.NativeFieldInfoPtr_MUL_DIV_MOD, (void*)(&@operator));
				return @operator;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryOperatorExpression.NativeFieldInfoPtr_MUL_DIV_MOD, (void*)(&value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0003FC80 File Offset: 0x0003DE80
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x000052E2 File Offset: 0x000034E2
		public unsafe static BinaryOperatorExpression.Operator ADD_SUB
		{
			get
			{
				BinaryOperatorExpression.Operator @operator;
				IL2CPP.il2cpp_field_static_get_value(BinaryOperatorExpression.NativeFieldInfoPtr_ADD_SUB, (void*)(&@operator));
				return @operator;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryOperatorExpression.NativeFieldInfoPtr_ADD_SUB, (void*)(&value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0003FC9C File Offset: 0x0003DE9C
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000052F0 File Offset: 0x000034F0
		public unsafe static BinaryOperatorExpression.Operator STRCAT
		{
			get
			{
				BinaryOperatorExpression.Operator @operator;
				IL2CPP.il2cpp_field_static_get_value(BinaryOperatorExpression.NativeFieldInfoPtr_STRCAT, (void*)(&@operator));
				return @operator;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryOperatorExpression.NativeFieldInfoPtr_STRCAT, (void*)(&value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0003FCB8 File Offset: 0x0003DEB8
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x000052FE File Offset: 0x000034FE
		public unsafe static BinaryOperatorExpression.Operator COMPARES
		{
			get
			{
				BinaryOperatorExpression.Operator @operator;
				IL2CPP.il2cpp_field_static_get_value(BinaryOperatorExpression.NativeFieldInfoPtr_COMPARES, (void*)(&@operator));
				return @operator;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryOperatorExpression.NativeFieldInfoPtr_COMPARES, (void*)(&value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0003FCD4 File Offset: 0x0003DED4
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x0000530C File Offset: 0x0000350C
		public unsafe static BinaryOperatorExpression.Operator LOGIC_AND
		{
			get
			{
				BinaryOperatorExpression.Operator @operator;
				IL2CPP.il2cpp_field_static_get_value(BinaryOperatorExpression.NativeFieldInfoPtr_LOGIC_AND, (void*)(&@operator));
				return @operator;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryOperatorExpression.NativeFieldInfoPtr_LOGIC_AND, (void*)(&value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0003FCF0 File Offset: 0x0003DEF0
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0000531A File Offset: 0x0000351A
		public unsafe static BinaryOperatorExpression.Operator LOGIC_OR
		{
			get
			{
				BinaryOperatorExpression.Operator @operator;
				IL2CPP.il2cpp_field_static_get_value(BinaryOperatorExpression.NativeFieldInfoPtr_LOGIC_OR, (void*)(&@operator));
				return @operator;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryOperatorExpression.NativeFieldInfoPtr_LOGIC_OR, (void*)(&value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x0003FD0C File Offset: 0x0003DF0C
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00005328 File Offset: 0x00003528
		public unsafe Expression m_Exp1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.NativeFieldInfoPtr_m_Exp1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.NativeFieldInfoPtr_m_Exp1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00005347 File Offset: 0x00003547
		public unsafe Expression m_Exp2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.NativeFieldInfoPtr_m_Exp2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.NativeFieldInfoPtr_m_Exp2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0003FD6C File Offset: 0x0003DF6C
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00005366 File Offset: 0x00003566
		public unsafe BinaryOperatorExpression.Operator m_Operator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.NativeFieldInfoPtr_m_Operator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.NativeFieldInfoPtr_m_Operator)) = value;
			}
		}

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_POWER;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_MUL_DIV_MOD;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr_ADD_SUB;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeFieldInfoPtr_STRCAT;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_COMPARES;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_LOGIC_AND;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_LOGIC_OR;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_m_Exp1;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_m_Exp2;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeFieldInfoPtr_m_Operator;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Expression_Expression_Operator_ScriptLoadingContext_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_BeginOperatorChain_Public_Static_Object_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_AddExpressionToChain_Public_Static_Void_Object_Expression_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_AddOperatorToChain_Public_Static_Void_Object_Token_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_CommitOperatorChain_Public_Static_Expression_Object_ScriptLoadingContext_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_CreatePowerExpression_Public_Static_Expression_Expression_Expression_ScriptLoadingContext_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Private_Static_Void_LinkedList_Node_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubTree_Private_Static_Expression_LinkedList_ScriptLoadingContext_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_PrioritizeLeftAssociative_Private_Static_Node_Node_ScriptLoadingContext_Operator_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_PrioritizeRightAssociative_Private_Static_Node_Node_ScriptLoadingContext_Operator_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_ParseBinaryOperator_Private_Static_Operator_Token_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_ShouldInvertBoolean_Private_Static_Boolean_Operator_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_OperatorToOpCode_Private_Static_OpCode_Operator_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_EvalArithmetic_Private_Double_DynValue_DynValue_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_EvalComparison_Private_Boolean_DynValue_DynValue_Operator_0;

		// Token: 0x020001A3 RID: 419
		[Flags]
		public enum Operator
		{
			// Token: 0x040015B1 RID: 5553
			NotAnOperator = 0,
			// Token: 0x040015B2 RID: 5554
			Or = 1,
			// Token: 0x040015B3 RID: 5555
			And = 2,
			// Token: 0x040015B4 RID: 5556
			Less = 4,
			// Token: 0x040015B5 RID: 5557
			Greater = 8,
			// Token: 0x040015B6 RID: 5558
			LessOrEqual = 16,
			// Token: 0x040015B7 RID: 5559
			GreaterOrEqual = 32,
			// Token: 0x040015B8 RID: 5560
			NotEqual = 64,
			// Token: 0x040015B9 RID: 5561
			Equal = 128,
			// Token: 0x040015BA RID: 5562
			StrConcat = 256,
			// Token: 0x040015BB RID: 5563
			Add = 512,
			// Token: 0x040015BC RID: 5564
			Sub = 1024,
			// Token: 0x040015BD RID: 5565
			Mul = 4096,
			// Token: 0x040015BE RID: 5566
			Div = 8192,
			// Token: 0x040015BF RID: 5567
			Mod = 16384,
			// Token: 0x040015C0 RID: 5568
			Power = 32768
		}

		// Token: 0x020001A4 RID: 420
		public class Node : Object
		{
			// Token: 0x06001A8E RID: 6798 RVA: 0x00081C78 File Offset: 0x0007FE78
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<BinaryOperatorExpression.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "Node");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryOperatorExpression.Node>.NativeClassPtr);
				BinaryOperatorExpression.Node.NativeFieldInfoPtr_Expr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression.Node>.NativeClassPtr, "Expr");
				BinaryOperatorExpression.Node.NativeFieldInfoPtr_Op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression.Node>.NativeClassPtr, "Op");
				BinaryOperatorExpression.Node.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression.Node>.NativeClassPtr, "Prev");
				BinaryOperatorExpression.Node.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression.Node>.NativeClassPtr, "Next");
				BinaryOperatorExpression.Node.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression.Node>.NativeClassPtr, 100665212);
			}

			// Token: 0x06001A8F RID: 6799 RVA: 0x00081D08 File Offset: 0x0007FF08
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryOperatorExpression.Node>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.Node.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A90 RID: 6800 RVA: 0x0000A7BA File Offset: 0x000089BA
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x06001A91 RID: 6801 RVA: 0x00081D44 File Offset: 0x0007FF44
			// (set) Token: 0x06001A92 RID: 6802 RVA: 0x0000A7C3 File Offset: 0x000089C3
			public unsafe Expression Expr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.Node.NativeFieldInfoPtr_Expr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.Node.NativeFieldInfoPtr_Expr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x06001A93 RID: 6803 RVA: 0x00081D74 File Offset: 0x0007FF74
			// (set) Token: 0x06001A94 RID: 6804 RVA: 0x0000A7E2 File Offset: 0x000089E2
			public unsafe BinaryOperatorExpression.Operator Op
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.Node.NativeFieldInfoPtr_Op);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.Node.NativeFieldInfoPtr_Op)) = value;
				}
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x06001A95 RID: 6805 RVA: 0x00081D9C File Offset: 0x0007FF9C
			// (set) Token: 0x06001A96 RID: 6806 RVA: 0x0000A7FD File Offset: 0x000089FD
			public unsafe BinaryOperatorExpression.Node Prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.Node.NativeFieldInfoPtr_Prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryOperatorExpression.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.Node.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x06001A97 RID: 6807 RVA: 0x00081DCC File Offset: 0x0007FFCC
			// (set) Token: 0x06001A98 RID: 6808 RVA: 0x0000A81C File Offset: 0x00008A1C
			public unsafe BinaryOperatorExpression.Node Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.Node.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryOperatorExpression.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.Node.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015C1 RID: 5569
			private static readonly IntPtr NativeFieldInfoPtr_Expr;

			// Token: 0x040015C2 RID: 5570
			private static readonly IntPtr NativeFieldInfoPtr_Op;

			// Token: 0x040015C3 RID: 5571
			private static readonly IntPtr NativeFieldInfoPtr_Prev;

			// Token: 0x040015C4 RID: 5572
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x040015C5 RID: 5573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A5 RID: 421
		public class LinkedList : Object
		{
			// Token: 0x06001A99 RID: 6809 RVA: 0x00081DFC File Offset: 0x0007FFFC
			// Note: this type is marked as 'beforefieldinit'.
			static LinkedList()
			{
				Il2CppClassPointerStore<BinaryOperatorExpression.LinkedList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryOperatorExpression>.NativeClassPtr, "LinkedList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryOperatorExpression.LinkedList>.NativeClassPtr);
				BinaryOperatorExpression.LinkedList.NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression.LinkedList>.NativeClassPtr, "Nodes");
				BinaryOperatorExpression.LinkedList.NativeFieldInfoPtr_Last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression.LinkedList>.NativeClassPtr, "Last");
				BinaryOperatorExpression.LinkedList.NativeFieldInfoPtr_OperatorMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperatorExpression.LinkedList>.NativeClassPtr, "OperatorMask");
				BinaryOperatorExpression.LinkedList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperatorExpression.LinkedList>.NativeClassPtr, 100665213);
			}

			// Token: 0x06001A9A RID: 6810 RVA: 0x00081E78 File Offset: 0x00080078
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LinkedList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryOperatorExpression.LinkedList>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperatorExpression.LinkedList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A9B RID: 6811 RVA: 0x0000A83B File Offset: 0x00008A3B
			public LinkedList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x06001A9C RID: 6812 RVA: 0x00081EB4 File Offset: 0x000800B4
			// (set) Token: 0x06001A9D RID: 6813 RVA: 0x0000A844 File Offset: 0x00008A44
			public unsafe BinaryOperatorExpression.Node Nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.LinkedList.NativeFieldInfoPtr_Nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryOperatorExpression.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.LinkedList.NativeFieldInfoPtr_Nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06001A9E RID: 6814 RVA: 0x00081EE4 File Offset: 0x000800E4
			// (set) Token: 0x06001A9F RID: 6815 RVA: 0x0000A863 File Offset: 0x00008A63
			public unsafe BinaryOperatorExpression.Node Last
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.LinkedList.NativeFieldInfoPtr_Last);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryOperatorExpression.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.LinkedList.NativeFieldInfoPtr_Last), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x00081F14 File Offset: 0x00080114
			// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0000A882 File Offset: 0x00008A82
			public unsafe BinaryOperatorExpression.Operator OperatorMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.LinkedList.NativeFieldInfoPtr_OperatorMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperatorExpression.LinkedList.NativeFieldInfoPtr_OperatorMask)) = value;
				}
			}

			// Token: 0x040015C6 RID: 5574
			private static readonly IntPtr NativeFieldInfoPtr_Nodes;

			// Token: 0x040015C7 RID: 5575
			private static readonly IntPtr NativeFieldInfoPtr_Last;

			// Token: 0x040015C8 RID: 5576
			private static readonly IntPtr NativeFieldInfoPtr_OperatorMask;

			// Token: 0x040015C9 RID: 5577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
