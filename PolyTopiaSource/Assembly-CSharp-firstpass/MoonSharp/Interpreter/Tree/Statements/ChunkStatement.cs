using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000066 RID: 102
	public class ChunkStatement : Statement
	{
		// Token: 0x060009DE RID: 2526 RVA: 0x0003C670 File Offset: 0x0003A870
		// Note: this type is marked as 'beforefieldinit'.
		static ChunkStatement()
		{
			Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "ChunkStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr);
			ChunkStatement.NativeFieldInfoPtr_m_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr, "m_Block");
			ChunkStatement.NativeFieldInfoPtr_m_StackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr, "m_StackFrame");
			ChunkStatement.NativeFieldInfoPtr_m_Env = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr, "m_Env");
			ChunkStatement.NativeFieldInfoPtr_m_VarArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr, "m_VarArgs");
			ChunkStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr, 100665118);
			ChunkStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr, 100665119);
			ChunkStatement.NativeMethodInfoPtr_CreateUpvalue_Public_Virtual_Final_New_SymbolRef_BuildTimeScope_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr, 100665120);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0003C72C File Offset: 0x0003A92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29749, RefRangeEnd = 29750, XrefRangeStart = 29708, XrefRangeEnd = 29749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChunkStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChunkStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0003C778 File Offset: 0x0003A978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29750, XrefRangeEnd = 29772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChunkStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0003C7C8 File Offset: 0x0003A9C8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChunkStatement.NativeMethodInfoPtr_CreateUpvalue_Public_Virtual_Final_New_SymbolRef_BuildTimeScope_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00004A85 File Offset: 0x00002C85
		public ChunkStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0003C82C File Offset: 0x0003AA2C
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00004A8E File Offset: 0x00002C8E
		public unsafe Statement m_Block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkStatement.NativeFieldInfoPtr_m_Block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkStatement.NativeFieldInfoPtr_m_Block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0003C85C File Offset: 0x0003AA5C
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00004AAD File Offset: 0x00002CAD
		public unsafe RuntimeScopeFrame m_StackFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkStatement.NativeFieldInfoPtr_m_StackFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeFrame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkStatement.NativeFieldInfoPtr_m_StackFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0003C88C File Offset: 0x0003AA8C
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x00004ACC File Offset: 0x00002CCC
		public unsafe SymbolRef m_Env
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkStatement.NativeFieldInfoPtr_m_Env);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkStatement.NativeFieldInfoPtr_m_Env), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0003C8BC File Offset: 0x0003AABC
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00004AEB File Offset: 0x00002CEB
		public unsafe SymbolRef m_VarArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkStatement.NativeFieldInfoPtr_m_VarArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkStatement.NativeFieldInfoPtr_m_VarArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeFieldInfoPtr_m_Block;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeFieldInfoPtr_m_StackFrame;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeFieldInfoPtr_m_Env;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeFieldInfoPtr_m_VarArgs;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_CreateUpvalue_Public_Virtual_Final_New_SymbolRef_BuildTimeScope_SymbolRef_0;
	}
}
