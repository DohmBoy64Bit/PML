using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000070 RID: 112
	public class RepeatStatement : Statement
	{
		// Token: 0x06000A85 RID: 2693 RVA: 0x0003E7F4 File Offset: 0x0003C9F4
		// Note: this type is marked as 'beforefieldinit'.
		static RepeatStatement()
		{
			Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "RepeatStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr);
			RepeatStatement.NativeFieldInfoPtr_m_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr, "m_Condition");
			RepeatStatement.NativeFieldInfoPtr_m_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr, "m_Block");
			RepeatStatement.NativeFieldInfoPtr_m_StackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr, "m_StackFrame");
			RepeatStatement.NativeFieldInfoPtr_m_Repeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr, "m_Repeat");
			RepeatStatement.NativeFieldInfoPtr_m_Until = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr, "m_Until");
			RepeatStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr, 100665179);
			RepeatStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr, 100665180);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0003E8B0 File Offset: 0x0003CAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30445, XrefRangeEnd = 30476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RepeatStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepeatStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepeatStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0003E8FC File Offset: 0x0003CAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30476, XrefRangeEnd = 30510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RepeatStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00005078 File Offset: 0x00003278
		public RepeatStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0003E94C File Offset: 0x0003CB4C
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00005081 File Offset: 0x00003281
		public unsafe Expression m_Condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_Condition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_Condition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0003E97C File Offset: 0x0003CB7C
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x000050A0 File Offset: 0x000032A0
		public unsafe Statement m_Block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_Block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_Block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0003E9AC File Offset: 0x0003CBAC
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x000050BF File Offset: 0x000032BF
		public unsafe RuntimeScopeBlock m_StackFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_StackFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_StackFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0003E9DC File Offset: 0x0003CBDC
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x000050DE File Offset: 0x000032DE
		public unsafe SourceRef m_Repeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_Repeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_Repeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0003EA0C File Offset: 0x0003CC0C
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x000050FD File Offset: 0x000032FD
		public unsafe SourceRef m_Until
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_Until);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepeatStatement.NativeFieldInfoPtr_m_Until), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_m_Condition;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_m_Block;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_m_StackFrame;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_m_Repeat;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_m_Until;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;
	}
}
