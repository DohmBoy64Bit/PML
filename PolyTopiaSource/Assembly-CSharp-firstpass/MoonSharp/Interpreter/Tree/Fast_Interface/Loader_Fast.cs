using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter.Tree.Fast_Interface
{
	// Token: 0x02000074 RID: 116
	public static class Loader_Fast : Object
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x0003F088 File Offset: 0x0003D288
		// Note: this type is marked as 'beforefieldinit'.
		static Loader_Fast()
		{
			Il2CppClassPointerStore<Loader_Fast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Fast_Interface", "Loader_Fast");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader_Fast>.NativeClassPtr);
			Loader_Fast.NativeMethodInfoPtr_LoadDynamicExpr_Internal_Static_DynamicExprExpression_Script_SourceCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader_Fast>.NativeClassPtr, 100665188);
			Loader_Fast.NativeMethodInfoPtr_CreateLoadingContext_Private_Static_ScriptLoadingContext_Script_SourceCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader_Fast>.NativeClassPtr, 100665189);
			Loader_Fast.NativeMethodInfoPtr_LoadChunk_Internal_Static_Int32_Script_SourceCode_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader_Fast>.NativeClassPtr, 100665190);
			Loader_Fast.NativeMethodInfoPtr_LoadFunction_Internal_Static_Int32_Script_SourceCode_ByteCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader_Fast>.NativeClassPtr, 100665191);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0003F108 File Offset: 0x0003D308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30681, RefRangeEnd = 30682, XrefRangeStart = 30667, XrefRangeEnd = 30681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynamicExprExpression LoadDynamicExpr(Script script, SourceCode source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader_Fast.NativeMethodInfoPtr_LoadDynamicExpr_Internal_Static_DynamicExprExpression_Script_SourceCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicExprExpression>(intPtr3) : null;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0003F160 File Offset: 0x0003D360
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 30697, RefRangeEnd = 30700, XrefRangeStart = 30682, XrefRangeEnd = 30697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptLoadingContext CreateLoadingContext(Script script, SourceCode source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader_Fast.NativeMethodInfoPtr_CreateLoadingContext_Private_Static_ScriptLoadingContext_Script_SourceCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptLoadingContext>(intPtr3) : null;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30700, XrefRangeEnd = 30727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LoadChunk(Script script, SourceCode source, ByteCode bytecode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytecode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader_Fast.NativeMethodInfoPtr_LoadChunk_Internal_Static_Int32_Script_SourceCode_ByteCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0003F220 File Offset: 0x0003D420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30754, RefRangeEnd = 30755, XrefRangeStart = 30727, XrefRangeEnd = 30754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LoadFunction(Script script, SourceCode source, ByteCode bytecode, bool usesGlobalEnv)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytecode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usesGlobalEnv;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader_Fast.NativeMethodInfoPtr_LoadFunction_Internal_Static_Int32_Script_SourceCode_ByteCode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0000528C File Offset: 0x0000348C
		public Loader_Fast(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_LoadDynamicExpr_Internal_Static_DynamicExprExpression_Script_SourceCode_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_CreateLoadingContext_Private_Static_ScriptLoadingContext_Script_SourceCode_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_LoadChunk_Internal_Static_Int32_Script_SourceCode_ByteCode_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_LoadFunction_Internal_Static_Int32_Script_SourceCode_ByteCode_Boolean_0;
	}
}
