using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x0200007D RID: 125
	public class SymbolRefExpression : Expression
	{
		// Token: 0x06000B43 RID: 2883 RVA: 0x0004136C File Offset: 0x0003F56C
		// Note: this type is marked as 'beforefieldinit'.
		static SymbolRefExpression()
		{
			Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Expressions", "SymbolRefExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr);
			SymbolRefExpression.NativeFieldInfoPtr_m_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr, "m_Ref");
			SymbolRefExpression.NativeFieldInfoPtr_m_VarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr, "m_VarName");
			SymbolRefExpression.NativeMethodInfoPtr__ctor_Public_Void_Token_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr, 100665252);
			SymbolRefExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr, 100665253);
			SymbolRefExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr, 100665254);
			SymbolRefExpression.NativeMethodInfoPtr_CompileAssignment_Public_Virtual_Final_New_Void_ByteCode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr, 100665255);
			SymbolRefExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr, 100665256);
			SymbolRefExpression.NativeMethodInfoPtr_FindDynamic_Public_Virtual_SymbolRef_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr, 100665257);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0004143C File Offset: 0x0003F63C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31397, RefRangeEnd = 31399, XrefRangeStart = 31373, XrefRangeEnd = 31397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRefExpression(Token T, ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(T);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRefExpression.NativeMethodInfoPtr__ctor_Public_Void_Token_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0004149C File Offset: 0x0003F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31399, XrefRangeEnd = 31401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRefExpression(ScriptLoadingContext lcontext, SymbolRef refr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymbolRefExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRefExpression.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000414FC File Offset: 0x0003F6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31401, XrefRangeEnd = 31403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymbolRefExpression.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0004154C File Offset: 0x0003F74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31403, XrefRangeEnd = 31405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompileAssignment(ByteCode bc, int stackofs, int tupleidx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stackofs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tupleidx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRefExpression.NativeMethodInfoPtr_CompileAssignment_Public_Virtual_Final_New_Void_ByteCode_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000415AC File Offset: 0x0003F7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31405, XrefRangeEnd = 31407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue Eval(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymbolRefExpression.NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00041608 File Offset: 0x0003F808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31407, XrefRangeEnd = 31409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SymbolRef FindDynamic(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymbolRefExpression.NativeMethodInfoPtr_FindDynamic_Public_Virtual_SymbolRef_ScriptExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0000563A File Offset: 0x0000383A
		public SymbolRefExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00041664 File Offset: 0x0003F864
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00005643 File Offset: 0x00003843
		public unsafe SymbolRef m_Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRefExpression.NativeFieldInfoPtr_m_Ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRefExpression.NativeFieldInfoPtr_m_Ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00041694 File Offset: 0x0003F894
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00005662 File Offset: 0x00003862
		public unsafe string m_VarName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRefExpression.NativeFieldInfoPtr_m_VarName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRefExpression.NativeFieldInfoPtr_m_VarName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeFieldInfoPtr_m_Ref;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeFieldInfoPtr_m_VarName;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_ScriptLoadingContext_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_SymbolRef_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_CompileAssignment_Public_Virtual_Final_New_Void_ByteCode_Int32_Int32_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Public_Virtual_DynValue_ScriptExecutionContext_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_FindDynamic_Public_Virtual_SymbolRef_ScriptExecutionContext_0;
	}
}
