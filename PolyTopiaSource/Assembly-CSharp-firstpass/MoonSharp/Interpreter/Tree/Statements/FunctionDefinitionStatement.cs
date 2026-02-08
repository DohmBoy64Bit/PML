using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006C RID: 108
	public class FunctionDefinitionStatement : Statement
	{
		// Token: 0x06000A22 RID: 2594 RVA: 0x0003D2E8 File Offset: 0x0003B4E8
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionDefinitionStatement()
		{
			Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "FunctionDefinitionStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr);
			FunctionDefinitionStatement.NativeFieldInfoPtr_m_FuncSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, "m_FuncSymbol");
			FunctionDefinitionStatement.NativeFieldInfoPtr_m_SourceRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, "m_SourceRef");
			FunctionDefinitionStatement.NativeFieldInfoPtr_m_Local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, "m_Local");
			FunctionDefinitionStatement.NativeFieldInfoPtr_m_IsMethodCallingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, "m_IsMethodCallingConvention");
			FunctionDefinitionStatement.NativeFieldInfoPtr_m_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, "m_MethodName");
			FunctionDefinitionStatement.NativeFieldInfoPtr_m_FriendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, "m_FriendlyName");
			FunctionDefinitionStatement.NativeFieldInfoPtr_m_TableAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, "m_TableAccessors");
			FunctionDefinitionStatement.NativeFieldInfoPtr_m_FuncDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, "m_FuncDef");
			FunctionDefinitionStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, 100665135);
			FunctionDefinitionStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, 100665136);
			FunctionDefinitionStatement.NativeMethodInfoPtr_SetMethod_Private_Int32_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, 100665137);
			FunctionDefinitionStatement.NativeMethodInfoPtr_SetFunction_Private_Int32_ByteCode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, 100665138);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0003D408 File Offset: 0x0003B608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30080, XrefRangeEnd = 30140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionDefinitionStatement(ScriptLoadingContext lcontext, bool local, Token localToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0003D474 File Offset: 0x0003B674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30140, XrefRangeEnd = 30186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionDefinitionStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0003D4C4 File Offset: 0x0003B6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30210, RefRangeEnd = 30211, XrefRangeStart = 30186, XrefRangeEnd = 30210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SetMethod(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionStatement.NativeMethodInfoPtr_SetMethod_Private_Int32_ByteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0003D514 File Offset: 0x0003B714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30211, XrefRangeEnd = 30213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SetFunction(ByteCode bc, int numPop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionStatement.NativeMethodInfoPtr_SetFunction_Private_Int32_ByteCode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00004D46 File Offset: 0x00002F46
		public FunctionDefinitionStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0003D570 File Offset: 0x0003B770
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00004D4F File Offset: 0x00002F4F
		public unsafe SymbolRef m_FuncSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_FuncSymbol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_FuncSymbol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0003D5A0 File Offset: 0x0003B7A0
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00004D6E File Offset: 0x00002F6E
		public unsafe SourceRef m_SourceRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_SourceRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_SourceRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0003D5D0 File Offset: 0x0003B7D0
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00004D8D File Offset: 0x00002F8D
		public unsafe bool m_Local
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_Local);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_Local)) = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0003D5F8 File Offset: 0x0003B7F8
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public unsafe bool m_IsMethodCallingConvention
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_IsMethodCallingConvention);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_IsMethodCallingConvention)) = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0003D620 File Offset: 0x0003B820
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00004DC3 File Offset: 0x00002FC3
		public unsafe string m_MethodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_MethodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_MethodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0003D648 File Offset: 0x0003B848
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00004DE2 File Offset: 0x00002FE2
		public unsafe string m_FriendlyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_FriendlyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_FriendlyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0003D670 File Offset: 0x0003B870
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00004E01 File Offset: 0x00003001
		public unsafe List<string> m_TableAccessors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_TableAccessors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_TableAccessors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0003D6A0 File Offset: 0x0003B8A0
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00004E20 File Offset: 0x00003020
		public unsafe FunctionDefinitionExpression m_FuncDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_FuncDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionDefinitionExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.NativeFieldInfoPtr_m_FuncDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_m_FuncSymbol;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceRef;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_m_Local;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMethodCallingConvention;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_m_MethodName;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_m_FriendlyName;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_m_TableAccessors;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_m_FuncDef;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_Boolean_Token_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_SetMethod_Private_Int32_ByteCode_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_SetFunction_Private_Int32_ByteCode_Int32_0;

		// Token: 0x020001A1 RID: 417
		[ObfuscatedName("MoonSharp.Interpreter.Tree.Statements.FunctionDefinitionStatement+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06001A79 RID: 6777 RVA: 0x000818F8 File Offset: 0x0007FAF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<FunctionDefinitionStatement.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FunctionDefinitionStatement>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionDefinitionStatement.__c__DisplayClass9_0>.NativeClassPtr);
				FunctionDefinitionStatement.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				FunctionDefinitionStatement.__c__DisplayClass9_0.NativeFieldInfoPtr_bc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionDefinitionStatement.__c__DisplayClass9_0>.NativeClassPtr, "bc");
				FunctionDefinitionStatement.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionStatement.__c__DisplayClass9_0>.NativeClassPtr, 100665139);
				FunctionDefinitionStatement.__c__DisplayClass9_0.NativeMethodInfoPtr__Compile_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionStatement.__c__DisplayClass9_0>.NativeClassPtr, 100665140);
				FunctionDefinitionStatement.__c__DisplayClass9_0.NativeMethodInfoPtr__Compile_b__1_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionStatement.__c__DisplayClass9_0>.NativeClassPtr, 100665141);
				FunctionDefinitionStatement.__c__DisplayClass9_0.NativeMethodInfoPtr__Compile_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionDefinitionStatement.__c__DisplayClass9_0>.NativeClassPtr, 100665142);
			}

			// Token: 0x06001A7A RID: 6778 RVA: 0x0008199C File Offset: 0x0007FB9C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionDefinitionStatement.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionStatement.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A7B RID: 6779 RVA: 0x000819D8 File Offset: 0x0007FBD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30074, XrefRangeEnd = 30076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Compile_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionStatement.__c__DisplayClass9_0.NativeMethodInfoPtr__Compile_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A7C RID: 6780 RVA: 0x00081A14 File Offset: 0x0007FC14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30076, XrefRangeEnd = 30078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Compile_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionStatement.__c__DisplayClass9_0.NativeMethodInfoPtr__Compile_b__1_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A7D RID: 6781 RVA: 0x00081A50 File Offset: 0x0007FC50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30078, XrefRangeEnd = 30080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Compile_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionDefinitionStatement.__c__DisplayClass9_0.NativeMethodInfoPtr__Compile_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A7E RID: 6782 RVA: 0x0000A6EE File Offset: 0x000088EE
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06001A7F RID: 6783 RVA: 0x00081A8C File Offset: 0x0007FC8C
			// (set) Token: 0x06001A80 RID: 6784 RVA: 0x0000A6F7 File Offset: 0x000088F7
			public unsafe FunctionDefinitionStatement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionDefinitionStatement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06001A81 RID: 6785 RVA: 0x00081ABC File Offset: 0x0007FCBC
			// (set) Token: 0x06001A82 RID: 6786 RVA: 0x0000A716 File Offset: 0x00008916
			public unsafe ByteCode bc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.__c__DisplayClass9_0.NativeFieldInfoPtr_bc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ByteCode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionDefinitionStatement.__c__DisplayClass9_0.NativeFieldInfoPtr_bc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015A5 RID: 5541
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015A6 RID: 5542
			private static readonly IntPtr NativeFieldInfoPtr_bc;

			// Token: 0x040015A7 RID: 5543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015A8 RID: 5544
			private static readonly IntPtr NativeMethodInfoPtr__Compile_b__0_Internal_Int32_0;

			// Token: 0x040015A9 RID: 5545
			private static readonly IntPtr NativeMethodInfoPtr__Compile_b__1_Internal_Int32_0;

			// Token: 0x040015AA RID: 5546
			private static readonly IntPtr NativeMethodInfoPtr__Compile_b__2_Internal_Int32_0;
		}
	}
}
