using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006E RID: 110
	public class IfStatement : Statement
	{
		// Token: 0x06000A56 RID: 2646 RVA: 0x0003DD7C File Offset: 0x0003BF7C
		// Note: this type is marked as 'beforefieldinit'.
		static IfStatement()
		{
			Il2CppClassPointerStore<IfStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "IfStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IfStatement>.NativeClassPtr);
			IfStatement.NativeFieldInfoPtr_m_Ifs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfStatement>.NativeClassPtr, "m_Ifs");
			IfStatement.NativeFieldInfoPtr_m_Else = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfStatement>.NativeClassPtr, "m_Else");
			IfStatement.NativeFieldInfoPtr_m_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfStatement>.NativeClassPtr, "m_End");
			IfStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IfStatement>.NativeClassPtr, 100665157);
			IfStatement.NativeMethodInfoPtr_CreateIfBlock_Private_IfBlock_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IfStatement>.NativeClassPtr, 100665158);
			IfStatement.NativeMethodInfoPtr_CreateElseBlock_Private_IfBlock_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IfStatement>.NativeClassPtr, 100665159);
			IfStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IfStatement>.NativeClassPtr, 100665160);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0003DE38 File Offset: 0x0003C038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30235, XrefRangeEnd = 30266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IfStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IfStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IfStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0003DE84 File Offset: 0x0003C084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30294, RefRangeEnd = 30295, XrefRangeStart = 30266, XrefRangeEnd = 30294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IfStatement.IfBlock CreateIfBlock(ScriptLoadingContext lcontext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IfStatement.NativeMethodInfoPtr_CreateIfBlock_Private_IfBlock_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IfStatement.IfBlock>(intPtr3) : null;
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0003DED4 File Offset: 0x0003C0D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30316, RefRangeEnd = 30317, XrefRangeStart = 30295, XrefRangeEnd = 30316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IfStatement.IfBlock CreateElseBlock(ScriptLoadingContext lcontext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IfStatement.NativeMethodInfoPtr_CreateElseBlock_Private_IfBlock_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IfStatement.IfBlock>(intPtr3) : null;
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0003DF24 File Offset: 0x0003C124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30317, XrefRangeEnd = 30388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IfStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00004F19 File Offset: 0x00003119
		public IfStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0003DF74 File Offset: 0x0003C174
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00004F22 File Offset: 0x00003122
		public unsafe List<IfStatement.IfBlock> m_Ifs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.NativeFieldInfoPtr_m_Ifs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IfStatement.IfBlock>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.NativeFieldInfoPtr_m_Ifs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0003DFA4 File Offset: 0x0003C1A4
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00004F41 File Offset: 0x00003141
		public unsafe IfStatement.IfBlock m_Else
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.NativeFieldInfoPtr_m_Else);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IfStatement.IfBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.NativeFieldInfoPtr_m_Else), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0003DFD4 File Offset: 0x0003C1D4
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00004F60 File Offset: 0x00003160
		public unsafe SourceRef m_End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.NativeFieldInfoPtr_m_End);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.NativeFieldInfoPtr_m_End), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr_m_Ifs;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_m_Else;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_m_End;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr_CreateIfBlock_Private_IfBlock_ScriptLoadingContext_0;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr_CreateElseBlock_Private_IfBlock_ScriptLoadingContext_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x020001A2 RID: 418
		public class IfBlock : Object
		{
			// Token: 0x06001A83 RID: 6787 RVA: 0x00081AEC File Offset: 0x0007FCEC
			// Note: this type is marked as 'beforefieldinit'.
			static IfBlock()
			{
				Il2CppClassPointerStore<IfStatement.IfBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IfStatement>.NativeClassPtr, "IfBlock");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IfStatement.IfBlock>.NativeClassPtr);
				IfStatement.IfBlock.NativeFieldInfoPtr_Exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfStatement.IfBlock>.NativeClassPtr, "Exp");
				IfStatement.IfBlock.NativeFieldInfoPtr_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfStatement.IfBlock>.NativeClassPtr, "Block");
				IfStatement.IfBlock.NativeFieldInfoPtr_StackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfStatement.IfBlock>.NativeClassPtr, "StackFrame");
				IfStatement.IfBlock.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfStatement.IfBlock>.NativeClassPtr, "Source");
				IfStatement.IfBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IfStatement.IfBlock>.NativeClassPtr, 100665161);
			}

			// Token: 0x06001A84 RID: 6788 RVA: 0x00081B7C File Offset: 0x0007FD7C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IfBlock()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IfStatement.IfBlock>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IfStatement.IfBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A85 RID: 6789 RVA: 0x0000A735 File Offset: 0x00008935
			public IfBlock(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x06001A86 RID: 6790 RVA: 0x00081BB8 File Offset: 0x0007FDB8
			// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0000A73E File Offset: 0x0000893E
			public unsafe Expression Exp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.IfBlock.NativeFieldInfoPtr_Exp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.IfBlock.NativeFieldInfoPtr_Exp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00081BE8 File Offset: 0x0007FDE8
			// (set) Token: 0x06001A89 RID: 6793 RVA: 0x0000A75D File Offset: 0x0000895D
			public unsafe Statement Block
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.IfBlock.NativeFieldInfoPtr_Block);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Statement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.IfBlock.NativeFieldInfoPtr_Block), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x06001A8A RID: 6794 RVA: 0x00081C18 File Offset: 0x0007FE18
			// (set) Token: 0x06001A8B RID: 6795 RVA: 0x0000A77C File Offset: 0x0000897C
			public unsafe RuntimeScopeBlock StackFrame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.IfBlock.NativeFieldInfoPtr_StackFrame);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.IfBlock.NativeFieldInfoPtr_StackFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x06001A8C RID: 6796 RVA: 0x00081C48 File Offset: 0x0007FE48
			// (set) Token: 0x06001A8D RID: 6797 RVA: 0x0000A79B File Offset: 0x0000899B
			public unsafe SourceRef Source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.IfBlock.NativeFieldInfoPtr_Source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IfStatement.IfBlock.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015AB RID: 5547
			private static readonly IntPtr NativeFieldInfoPtr_Exp;

			// Token: 0x040015AC RID: 5548
			private static readonly IntPtr NativeFieldInfoPtr_Block;

			// Token: 0x040015AD RID: 5549
			private static readonly IntPtr NativeFieldInfoPtr_StackFrame;

			// Token: 0x040015AE RID: 5550
			private static readonly IntPtr NativeFieldInfoPtr_Source;

			// Token: 0x040015AF RID: 5551
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
