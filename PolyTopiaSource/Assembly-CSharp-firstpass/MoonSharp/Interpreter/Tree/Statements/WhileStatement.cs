using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000073 RID: 115
	public class WhileStatement : Statement
	{
		// Token: 0x06000AA8 RID: 2728 RVA: 0x0003EE40 File Offset: 0x0003D040
		// Note: this type is marked as 'beforefieldinit'.
		static WhileStatement()
		{
			Il2CppClassPointerStore<WhileStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "WhileStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhileStatement>.NativeClassPtr);
			WhileStatement.NativeFieldInfoPtr_m_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileStatement>.NativeClassPtr, "m_Condition");
			WhileStatement.NativeFieldInfoPtr_m_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileStatement>.NativeClassPtr, "m_Block");
			WhileStatement.NativeFieldInfoPtr_m_StackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileStatement>.NativeClassPtr, "m_StackFrame");
			WhileStatement.NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileStatement>.NativeClassPtr, "m_Start");
			WhileStatement.NativeFieldInfoPtr_m_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileStatement>.NativeClassPtr, "m_End");
			WhileStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileStatement>.NativeClassPtr, 100665186);
			WhileStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileStatement>.NativeClassPtr, 100665187);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0003EEFC File Offset: 0x0003D0FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30631, RefRangeEnd = 30632, XrefRangeStart = 30598, XrefRangeEnd = 30631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WhileStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhileStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhileStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0003EF48 File Offset: 0x0003D148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30632, XrefRangeEnd = 30667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WhileStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000051E8 File Offset: 0x000033E8
		public WhileStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0003EF98 File Offset: 0x0003D198
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x000051F1 File Offset: 0x000033F1
		public unsafe Expression m_Condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_Condition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_Condition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0003EFC8 File Offset: 0x0003D1C8
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00005210 File Offset: 0x00003410
		public unsafe Statement m_Block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_Block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_Block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0003EFF8 File Offset: 0x0003D1F8
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x0000522F File Offset: 0x0000342F
		public unsafe RuntimeScopeBlock m_StackFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_StackFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_StackFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0003F028 File Offset: 0x0003D228
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x0000524E File Offset: 0x0000344E
		public unsafe SourceRef m_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_Start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_Start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0003F058 File Offset: 0x0003D258
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x0000526D File Offset: 0x0000346D
		public unsafe SourceRef m_End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_End);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileStatement.NativeFieldInfoPtr_m_End), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr_m_Condition;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_m_Block;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr_m_StackFrame;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_m_Start;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_m_End;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;
	}
}
