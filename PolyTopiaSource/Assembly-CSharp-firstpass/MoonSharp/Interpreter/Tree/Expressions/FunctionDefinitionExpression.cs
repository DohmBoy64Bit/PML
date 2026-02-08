using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007A RID: 122
	public class FunctionDefinitionExpression : Expression
	{
		// Token: 0x06000B0B RID: 2827 RVA: 0x00040548 File Offset: 0x0003E748
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionDefinitionExpression()
		{
			Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "FunctionDefinitionExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr);
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_ParamNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_ParamNames");
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_Statement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_Statement");
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_StackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_StackFrame");
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_Closure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_Closure");
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_HasVarArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_HasVarArgs");
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_ClosureInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_ClosureInstruction");
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_UsesGlobalEnv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_UsesGlobalEnv");
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_Env = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_Env");
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_Begin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_Begin");
			FunctionDefinitionExpression.NativeFieldInfoPtr_m_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "m_End");
			FunctionDefinitionExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665227);
			FunctionDefinitionExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665228);
			FunctionDefinitionExpression.NativeMethodInfoPtr__ctor_Private_Void_ScriptLoadingContext_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665229);
			FunctionDefinitionExpression.NativeMethodInfoPtr_CreateLambdaBody_Private_Statement_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665230);
			FunctionDefinitionExpression.NativeMethodInfoPtr_CreateBody_Private_Statement_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665231);
			FunctionDefinitionExpression.NativeMethodInfoPtr_BuildParamList_Private_List_1_String_ScriptLoadingContext_Boolean_Token_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665232);
			FunctionDefinitionExpression.NativeMethodInfoPtr_DefineArguments_Private_Il2CppReferenceArray_1_SymbolRef_List_1_String_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665233);
			FunctionDefinitionExpression.NativeMethodInfoPtr_CreateUpvalue_Public_Virtual_Final_New_SymbolRef_BuildTimeScope_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665234);
			FunctionDefinitionExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665235);
			FunctionDefinitionExpression.NativeMethodInfoPtr_CompileBody_Public_Int32_ByteCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665236);
			FunctionDefinitionExpression.NativeMethodInfoPtr_Compile_Public_Int32_ByteCode_Func_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665237);
			FunctionDefinitionExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, 100665238);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00040730 File Offset: 0x0003E930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31039, XrefRangeEnd = 31040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool usesGlobalEnv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usesGlobalEnv;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0004078C File Offset: 0x0003E98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31040, XrefRangeEnd = 31041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool isLambda)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pushSelfParam;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLambda;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000407F4 File Offset: 0x0003E9F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31082, RefRangeEnd = 31086, XrefRangeStart = 31041, XrefRangeEnd = 31082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool pushSelfParam, bool usesGlobalEnv, bool isLambda)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pushSelfParam;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usesGlobalEnv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLambda;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr__ctor_Private_Void_ScriptLoadingContext_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0004086C File Offset: 0x0003EA6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31105, RefRangeEnd = 31106, XrefRangeStart = 31086, XrefRangeEnd = 31105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Statement CreateLambdaBody(ScriptLoadingContext lcontext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr_CreateLambdaBody_Private_Statement_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr3) : null;
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000408BC File Offset: 0x0003EABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31115, RefRangeEnd = 31116, XrefRangeStart = 31106, XrefRangeEnd = 31115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Statement CreateBody(ScriptLoadingContext lcontext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr_CreateBody_Private_Statement_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr3) : null;
			}
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0004090C File Offset: 0x0003EB0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31145, RefRangeEnd = 31146, XrefRangeStart = 31116, XrefRangeEnd = 31145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> BuildParamList(ScriptLoadingContext lcontext, bool pushSelfParam, Token openBracketToken, bool isLambda)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pushSelfParam;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(openBracketToken);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLambda;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr_BuildParamList_Private_List_1_String_ScriptLoadingContext_Boolean_Token_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0004098C File Offset: 0x0003EB8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31179, RefRangeEnd = 31180, XrefRangeStart = 31146, XrefRangeEnd = 31179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<SymbolRef> DefineArguments(List<string> paramnames, ScriptLoadingContext lcontext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paramnames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr_DefineArguments_Private_Il2CppReferenceArray_1_SymbolRef_List_1_String_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SymbolRef>>(intPtr3) : null;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000409F0 File Offset: 0x0003EBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31180, XrefRangeEnd = 31204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbol);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr_CreateUpvalue_Public_Virtual_Final_New_SymbolRef_BuildTimeScope_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00040A54 File Offset: 0x0003EC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31204, XrefRangeEnd = 31210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionDefinitionExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00040AB0 File Offset: 0x0003ECB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31249, RefRangeEnd = 31251, XrefRangeStart = 31210, XrefRangeEnd = 31249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompileBody(ByteCode bc, string friendlyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr_CompileBody_Public_Int32_ByteCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00040B10 File Offset: 0x0003ED10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31265, RefRangeEnd = 31269, XrefRangeStart = 31251, XrefRangeEnd = 31265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compile(ByteCode bc, Func<int> afterDecl, string friendlyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterDecl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.NativeMethodInfoPtr_Compile_Public_Int32_ByteCode_Func_1_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00040B84 File Offset: 0x0003ED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31269, XrefRangeEnd = 31285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionDefinitionExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00005475 File Offset: 0x00003675
		public FunctionDefinitionExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00040BD4 File Offset: 0x0003EDD4
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x0000547E File Offset: 0x0000367E
		public unsafe Il2CppReferenceArray<SymbolRef> m_ParamNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_ParamNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SymbolRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_ParamNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00040C04 File Offset: 0x0003EE04
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0000549D File Offset: 0x0000369D
		public unsafe Statement m_Statement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_Statement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_Statement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00040C34 File Offset: 0x0003EE34
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000054BC File Offset: 0x000036BC
		public unsafe RuntimeScopeFrame m_StackFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_StackFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeFrame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_StackFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00040C64 File Offset: 0x0003EE64
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x000054DB File Offset: 0x000036DB
		public unsafe List<SymbolRef> m_Closure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_Closure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SymbolRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_Closure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00040C94 File Offset: 0x0003EE94
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x000054FA File Offset: 0x000036FA
		public unsafe bool m_HasVarArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_HasVarArgs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_HasVarArgs)) = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00040CBC File Offset: 0x0003EEBC
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00005515 File Offset: 0x00003715
		public unsafe Instruction m_ClosureInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_ClosureInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_ClosureInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00040CEC File Offset: 0x0003EEEC
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x00005534 File Offset: 0x00003734
		public unsafe bool m_UsesGlobalEnv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_UsesGlobalEnv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_UsesGlobalEnv)) = value;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00040D14 File Offset: 0x0003EF14
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x0000554F File Offset: 0x0000374F
		public unsafe SymbolRef m_Env
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_Env);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_Env), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00040D44 File Offset: 0x0003EF44
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x0000556E File Offset: 0x0000376E
		public unsafe SourceRef m_Begin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_Begin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_Begin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00040D74 File Offset: 0x0003EF74
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x0000558D File Offset: 0x0000378D
		public unsafe SourceRef m_End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_End);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionExpression.NativeFieldInfoPtr_m_End), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_m_ParamNames;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_m_Statement;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_m_StackFrame;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_m_Closure;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_m_HasVarArgs;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosureInstruction;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_m_UsesGlobalEnv;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr_m_Env;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_m_Begin;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_m_End;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_Boolean_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ScriptLoadingContext_Boolean_Boolean_Boolean_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_CreateLambdaBody_Private_Statement_ScriptLoadingContext_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_CreateBody_Private_Statement_ScriptLoadingContext_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_BuildParamList_Private_List_1_String_ScriptLoadingContext_Boolean_Token_Boolean_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_DefineArguments_Private_Il2CppReferenceArray_1_SymbolRef_List_1_String_ScriptLoadingContext_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_CreateUpvalue_Public_Virtual_Final_New_SymbolRef_BuildTimeScope_SymbolRef_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_CompileBody_Public_Int32_ByteCode_String_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Int32_ByteCode_Func_1_Int32_String_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x020001A6 RID: 422
		[ObfuscatedName("MoonSharp.Interpreter.Tree.Expressions.FunctionDefinitionExpression+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AA2 RID: 6818 RVA: 0x00081F3C File Offset: 0x0008013C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FunctionDefinitionExpression.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FunctionDefinitionExpression>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionDefinitionExpression.__c>.NativeClassPtr);
				FunctionDefinitionExpression.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression.__c>.NativeClassPtr, "<>9");
				FunctionDefinitionExpression.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionExpression.__c>.NativeClassPtr, "<>9__21_0");
				FunctionDefinitionExpression.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression.__c>.NativeClassPtr, 100665240);
				FunctionDefinitionExpression.__c.NativeMethodInfoPtr__Compile_b__21_0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionExpression.__c>.NativeClassPtr, 100665241);
			}

			// Token: 0x06001AA3 RID: 6819 RVA: 0x00081FB8 File Offset: 0x000801B8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionDefinitionExpression.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AA4 RID: 6820 RVA: 0x00081FF4 File Offset: 0x000801F4
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Compile_b__21_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionExpression.__c.NativeMethodInfoPtr__Compile_b__21_0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001AA5 RID: 6821 RVA: 0x0000A89D File Offset: 0x00008A9D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x00082030 File Offset: 0x00080230
			// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0000A8A6 File Offset: 0x00008AA6
			public unsafe static FunctionDefinitionExpression.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FunctionDefinitionExpression.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionDefinitionExpression.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FunctionDefinitionExpression.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x00082058 File Offset: 0x00080258
			// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x0000A8B8 File Offset: 0x00008AB8
			public unsafe static Func<int> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FunctionDefinitionExpression.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FunctionDefinitionExpression.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015CA RID: 5578
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015CB RID: 5579
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x040015CC RID: 5580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015CD RID: 5581
			private static readonly IntPtr NativeMethodInfoPtr__Compile_b__21_0_Internal_Int32_0;
		}
	}
}
