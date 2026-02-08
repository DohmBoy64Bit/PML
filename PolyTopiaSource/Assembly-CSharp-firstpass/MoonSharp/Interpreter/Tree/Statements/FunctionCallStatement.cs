using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006B RID: 107
	public class FunctionCallStatement : Statement
	{
		// Token: 0x06000A1B RID: 2587 RVA: 0x0003D144 File Offset: 0x0003B344
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionCallStatement()
		{
			Il2CppClassPointerStore<FunctionCallStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "FunctionCallStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionCallStatement>.NativeClassPtr);
			FunctionCallStatement.NativeFieldInfoPtr_m_FunctionCallExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionCallStatement>.NativeClassPtr, "m_FunctionCallExpression");
			FunctionCallStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_FunctionCallExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionCallStatement>.NativeClassPtr, 100665132);
			FunctionCallStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionCallStatement>.NativeClassPtr, 100665133);
			FunctionCallStatement.NativeMethodInfoPtr_RemoveBreakpointStop_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionCallStatement>.NativeClassPtr, 100665134);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0003D1C4 File Offset: 0x0003B3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30054, XrefRangeEnd = 30063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionCallStatement(ScriptLoadingContext lcontext, FunctionCallExpression functionCallExpression)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionCallStatement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(functionCallExpression);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionCallStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_FunctionCallExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0003D224 File Offset: 0x0003B424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30063, XrefRangeEnd = 30072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionCallStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0003D274 File Offset: 0x0003B474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30072, XrefRangeEnd = 30074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBreakpointStop(Instruction instruction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionCallStatement.NativeMethodInfoPtr_RemoveBreakpointStop_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00004D1E File Offset: 0x00002F1E
		public FunctionCallStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0003D2B8 File Offset: 0x0003B4B8
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00004D27 File Offset: 0x00002F27
		public unsafe FunctionCallExpression m_FunctionCallExpression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallStatement.NativeFieldInfoPtr_m_FunctionCallExpression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionCallExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionCallStatement.NativeFieldInfoPtr_m_FunctionCallExpression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_m_FunctionCallExpression;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_FunctionCallExpression_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBreakpointStop_Private_Void_Instruction_0;
	}
}
