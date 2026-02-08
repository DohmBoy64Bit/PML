using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000065 RID: 101
	public class BreakStatement : Statement
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x0003C538 File Offset: 0x0003A738
		// Note: this type is marked as 'beforefieldinit'.
		static BreakStatement()
		{
			Il2CppClassPointerStore<BreakStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "BreakStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BreakStatement>.NativeClassPtr);
			BreakStatement.NativeFieldInfoPtr_m_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreakStatement>.NativeClassPtr, "m_Ref");
			BreakStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreakStatement>.NativeClassPtr, 100665116);
			BreakStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreakStatement>.NativeClassPtr, 100665117);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0003C5A4 File Offset: 0x0003A7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29678, XrefRangeEnd = 29691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BreakStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BreakStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BreakStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0003C5F0 File Offset: 0x0003A7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29691, XrefRangeEnd = 29708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BreakStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00004A5D File Offset: 0x00002C5D
		public BreakStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0003C640 File Offset: 0x0003A840
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x00004A66 File Offset: 0x00002C66
		public unsafe SourceRef m_Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BreakStatement.NativeFieldInfoPtr_m_Ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BreakStatement.NativeFieldInfoPtr_m_Ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeFieldInfoPtr_m_Ref;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;
	}
}
