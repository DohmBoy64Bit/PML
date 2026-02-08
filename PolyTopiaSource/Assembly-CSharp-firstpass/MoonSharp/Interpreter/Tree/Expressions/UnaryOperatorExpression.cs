using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007F RID: 127
	public class UnaryOperatorExpression : Expression
	{
		// Token: 0x06000B5D RID: 2909 RVA: 0x000419FC File Offset: 0x0003FBFC
		// Note: this type is marked as 'beforefieldinit'.
		static UnaryOperatorExpression()
		{
			Il2CppClassPointerStore<UnaryOperatorExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "UnaryOperatorExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnaryOperatorExpression>.NativeClassPtr);
			UnaryOperatorExpression.NativeFieldInfoPtr_m_Exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnaryOperatorExpression>.NativeClassPtr, "m_Exp");
			UnaryOperatorExpression.NativeFieldInfoPtr_m_OpText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnaryOperatorExpression>.NativeClassPtr, "m_OpText");
			UnaryOperatorExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryOperatorExpression>.NativeClassPtr, 100665264);
			UnaryOperatorExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryOperatorExpression>.NativeClassPtr, 100665265);
			UnaryOperatorExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnaryOperatorExpression>.NativeClassPtr, 100665266);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00041A90 File Offset: 0x0003FC90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31549, RefRangeEnd = 31550, XrefRangeStart = 31545, XrefRangeEnd = 31549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnaryOperatorExpression(ScriptLoadingContext lcontext, Expression subExpression, Token unaryOpToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnaryOperatorExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subExpression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unaryOpToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnaryOperatorExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00041B00 File Offset: 0x0003FD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31550, XrefRangeEnd = 31574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnaryOperatorExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00041B50 File Offset: 0x0003FD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31574, XrefRangeEnd = 31587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnaryOperatorExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000056E3 File Offset: 0x000038E3
		public UnaryOperatorExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00041BAC File Offset: 0x0003FDAC
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x000056EC File Offset: 0x000038EC
		public unsafe Expression m_Exp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryOperatorExpression.NativeFieldInfoPtr_m_Exp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryOperatorExpression.NativeFieldInfoPtr_m_Exp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00041BDC File Offset: 0x0003FDDC
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0000570B File Offset: 0x0000390B
		public unsafe string m_OpText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryOperatorExpression.NativeFieldInfoPtr_m_OpText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnaryOperatorExpression.NativeFieldInfoPtr_m_OpText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeFieldInfoPtr_m_Exp;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeFieldInfoPtr_m_OpText;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_Token_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;
	}
}
