using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000079 RID: 121
	public class FunctionCallExpression : Expression
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x000401D0 File Offset: 0x0003E3D0
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionCallExpression()
		{
			Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "FunctionCallExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr);
			FunctionCallExpression.NativeFieldInfoPtr_m_Arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, "m_Arguments");
			FunctionCallExpression.NativeFieldInfoPtr_m_Function = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, "m_Function");
			FunctionCallExpression.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, "m_Name");
			FunctionCallExpression.NativeFieldInfoPtr_m_DebugErr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, "m_DebugErr");
			FunctionCallExpression.NativeFieldInfoPtr__SourceRef_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, "<SourceRef>k__BackingField");
			FunctionCallExpression.NativeMethodInfoPtr_get_SourceRef_Internal_get_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, 100665222);
			FunctionCallExpression.NativeMethodInfoPtr_set_SourceRef_Private_set_Void_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, 100665223);
			FunctionCallExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, 100665224);
			FunctionCallExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, 100665225);
			FunctionCallExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr, 100665226);
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000402C8 File Offset: 0x0003E4C8
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00040308 File Offset: 0x0003E508
		public unsafe SourceRef SourceRef
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionCallExpression.NativeMethodInfoPtr_get_SourceRef_Internal_get_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionCallExpression.NativeMethodInfoPtr_set_SourceRef_Private_set_Void_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0004034C File Offset: 0x0003E54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30968, XrefRangeEnd = 31018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionCallExpression(ScriptLoadingContext lcontext, Expression function, Token thisCallName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionCallExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisCallName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionCallExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000403BC File Offset: 0x0003E5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31018, XrefRangeEnd = 31033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionCallExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0004040C File Offset: 0x0003E60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31033, XrefRangeEnd = 31039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionCallExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000053D1 File Offset: 0x000035D1
		public FunctionCallExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00040468 File Offset: 0x0003E668
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x000053DA File Offset: 0x000035DA
		public unsafe List<Expression> m_Arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr_m_Arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr_m_Arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00040498 File Offset: 0x0003E698
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x000053F9 File Offset: 0x000035F9
		public unsafe Expression m_Function
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr_m_Function);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr_m_Function), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x000404C8 File Offset: 0x0003E6C8
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00005418 File Offset: 0x00003618
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000404F0 File Offset: 0x0003E6F0
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00005437 File Offset: 0x00003637
		public unsafe string m_DebugErr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr_m_DebugErr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr_m_DebugErr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00040518 File Offset: 0x0003E718
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00005456 File Offset: 0x00003656
		public unsafe SourceRef _SourceRef_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr__SourceRef_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallExpression.NativeFieldInfoPtr__SourceRef_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr_m_Arguments;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_m_Function;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugErr;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr__SourceRef_k__BackingField;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceRef_Internal_get_SourceRef_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceRef_Private_set_Void_SourceRef_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Expression_Token_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;
	}
}
