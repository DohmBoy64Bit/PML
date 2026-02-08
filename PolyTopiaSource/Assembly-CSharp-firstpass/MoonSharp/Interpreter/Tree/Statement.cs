using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Execution;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x02000063 RID: 99
	public class Statement : NodeBase
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x0003C118 File Offset: 0x0003A318
		// Note: this type is marked as 'beforefieldinit'.
		static Statement()
		{
			Il2CppClassPointerStore<Statement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree", "Statement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Statement>.NativeClassPtr);
			Statement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statement>.NativeClassPtr, 100665109);
			Statement.NativeMethodInfoPtr_CreateStatement_Protected_Static_Statement_ScriptLoadingContext_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statement>.NativeClassPtr, 100665110);
			Statement.NativeMethodInfoPtr_DispatchForLoopStatement_Private_Static_Statement_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statement>.NativeClassPtr, 100665111);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0003C184 File Offset: 0x0003A384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29440, RefRangeEnd = 29441, XrefRangeStart = 29440, XrefRangeEnd = 29441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Statement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Statement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0003C1D0 File Offset: 0x0003A3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29506, RefRangeEnd = 29507, XrefRangeStart = 29479, XrefRangeEnd = 29506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Statement CreateStatement(ScriptLoadingContext lcontext, out bool forceLast)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &forceLast;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statement.NativeMethodInfoPtr_CreateStatement_Protected_Static_Statement_ScriptLoadingContext_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr3) : null;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0003C224 File Offset: 0x0003A424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29507, XrefRangeEnd = 29517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Statement DispatchForLoopStatement(ScriptLoadingContext lcontext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statement.NativeMethodInfoPtr_DispatchForLoopStatement_Private_Static_Statement_ScriptLoadingContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr3) : null;
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000049EE File Offset: 0x00002BEE
		public Statement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_CreateStatement_Protected_Static_Statement_ScriptLoadingContext_byref_Boolean_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_DispatchForLoopStatement_Private_Static_Statement_ScriptLoadingContext_0;
	}
}
