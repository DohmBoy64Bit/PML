using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000072 RID: 114
	public class ScopeBlockStatement : Statement
	{
		// Token: 0x06000A9C RID: 2716 RVA: 0x0003EC3C File Offset: 0x0003CE3C
		// Note: this type is marked as 'beforefieldinit'.
		static ScopeBlockStatement()
		{
			Il2CppClassPointerStore<ScopeBlockStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "ScopeBlockStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopeBlockStatement>.NativeClassPtr);
			ScopeBlockStatement.NativeFieldInfoPtr_m_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopeBlockStatement>.NativeClassPtr, "m_Block");
			ScopeBlockStatement.NativeFieldInfoPtr_m_StackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopeBlockStatement>.NativeClassPtr, "m_StackFrame");
			ScopeBlockStatement.NativeFieldInfoPtr_m_Do = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopeBlockStatement>.NativeClassPtr, "m_Do");
			ScopeBlockStatement.NativeFieldInfoPtr_m_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopeBlockStatement>.NativeClassPtr, "m_End");
			ScopeBlockStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeBlockStatement>.NativeClassPtr, 100665184);
			ScopeBlockStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeBlockStatement>.NativeClassPtr, 100665185);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0003ECE4 File Offset: 0x0003CEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30553, XrefRangeEnd = 30583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScopeBlockStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopeBlockStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeBlockStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0003ED30 File Offset: 0x0003CF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30583, XrefRangeEnd = 30598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScopeBlockStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00005163 File Offset: 0x00003363
		public ScopeBlockStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0003ED80 File Offset: 0x0003CF80
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x0000516C File Offset: 0x0000336C
		public unsafe Statement m_Block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeBlockStatement.NativeFieldInfoPtr_m_Block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeBlockStatement.NativeFieldInfoPtr_m_Block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0003EDB0 File Offset: 0x0003CFB0
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x0000518B File Offset: 0x0000338B
		public unsafe RuntimeScopeBlock m_StackFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeBlockStatement.NativeFieldInfoPtr_m_StackFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeBlockStatement.NativeFieldInfoPtr_m_StackFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0003EDE0 File Offset: 0x0003CFE0
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x000051AA File Offset: 0x000033AA
		public unsafe SourceRef m_Do
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeBlockStatement.NativeFieldInfoPtr_m_Do);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeBlockStatement.NativeFieldInfoPtr_m_Do), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0003EE10 File Offset: 0x0003D010
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x000051C9 File Offset: 0x000033C9
		public unsafe SourceRef m_End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeBlockStatement.NativeFieldInfoPtr_m_End);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeBlockStatement.NativeFieldInfoPtr_m_End), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr_m_Block;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr_m_StackFrame;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr_m_Do;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr_m_End;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;
	}
}
