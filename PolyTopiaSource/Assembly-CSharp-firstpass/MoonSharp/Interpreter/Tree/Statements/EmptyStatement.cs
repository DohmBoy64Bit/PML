using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000068 RID: 104
	public class EmptyStatement : Statement
	{
		// Token: 0x060009F1 RID: 2545 RVA: 0x0003CA24 File Offset: 0x0003AC24
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyStatement()
		{
			Il2CppClassPointerStore<EmptyStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "EmptyStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyStatement>.NativeClassPtr);
			EmptyStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyStatement>.NativeClassPtr, 100665123);
			EmptyStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyStatement>.NativeClassPtr, 100665124);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0003CA7C File Offset: 0x0003AC7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29440, RefRangeEnd = 29441, XrefRangeStart = 29440, XrefRangeEnd = 29441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmptyStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmptyStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0003CAC8 File Offset: 0x0003ACC8
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmptyStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00004B32 File Offset: 0x00002D32
		public EmptyStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;
	}
}
