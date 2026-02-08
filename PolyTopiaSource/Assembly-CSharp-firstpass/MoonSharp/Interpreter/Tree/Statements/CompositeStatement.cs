using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000067 RID: 103
	public class CompositeStatement : Statement
	{
		// Token: 0x060009EB RID: 2539 RVA: 0x0003C8EC File Offset: 0x0003AAEC
		// Note: this type is marked as 'beforefieldinit'.
		static CompositeStatement()
		{
			Il2CppClassPointerStore<CompositeStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "CompositeStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeStatement>.NativeClassPtr);
			CompositeStatement.NativeFieldInfoPtr_m_Statements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeStatement>.NativeClassPtr, "m_Statements");
			CompositeStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeStatement>.NativeClassPtr, 100665121);
			CompositeStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeStatement>.NativeClassPtr, 100665122);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0003C958 File Offset: 0x0003AB58
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 29791, RefRangeEnd = 29800, XrefRangeStart = 29772, XrefRangeEnd = 29791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0003C9A4 File Offset: 0x0003ABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29800, XrefRangeEnd = 29814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00004B0A File Offset: 0x00002D0A
		public CompositeStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0003C9F4 File Offset: 0x0003ABF4
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00004B13 File Offset: 0x00002D13
		public unsafe List<Statement> m_Statements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeStatement.NativeFieldInfoPtr_m_Statements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Statement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeStatement.NativeFieldInfoPtr_m_Statements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeFieldInfoPtr_m_Statements;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;
	}
}
