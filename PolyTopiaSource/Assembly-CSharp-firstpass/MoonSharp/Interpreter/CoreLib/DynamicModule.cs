using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x0200010C RID: 268
	public class DynamicModule : Object
	{
		// Token: 0x06001422 RID: 5154 RVA: 0x0006863C File Offset: 0x0006683C
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicModule()
		{
			Il2CppClassPointerStore<DynamicModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "DynamicModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicModule>.NativeClassPtr);
			DynamicModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModule>.NativeClassPtr, 100666833);
			DynamicModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModule>.NativeClassPtr, 100666830);
			DynamicModule.NativeMethodInfoPtr_eval_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModule>.NativeClassPtr, 100666831);
			DynamicModule.NativeMethodInfoPtr_prepare_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModule>.NativeClassPtr, 100666832);
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x000686BC File Offset: 0x000668BC
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000686F8 File Offset: 0x000668F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47597, XrefRangeEnd = 47603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoonSharpInit(Table globalTable, Table stringTable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(globalTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stringTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00068740 File Offset: 0x00066940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47603, XrefRangeEnd = 47617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue eval(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicModule.NativeMethodInfoPtr_eval_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00068798 File Offset: 0x00066998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47617, XrefRangeEnd = 47632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue prepare(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicModule.NativeMethodInfoPtr_prepare_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0000817B File Offset: 0x0000637B
		public DynamicModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_eval_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_prepare_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x020001E9 RID: 489
		public class DynamicExprWrapper : Object
		{
			// Token: 0x06001D4C RID: 7500 RVA: 0x0008C2F8 File Offset: 0x0008A4F8
			// Note: this type is marked as 'beforefieldinit'.
			static DynamicExprWrapper()
			{
				Il2CppClassPointerStore<DynamicModule.DynamicExprWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicModule>.NativeClassPtr, "DynamicExprWrapper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicModule.DynamicExprWrapper>.NativeClassPtr);
				DynamicModule.DynamicExprWrapper.NativeFieldInfoPtr_Expr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicModule.DynamicExprWrapper>.NativeClassPtr, "Expr");
				DynamicModule.DynamicExprWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicModule.DynamicExprWrapper>.NativeClassPtr, 100666834);
			}

			// Token: 0x06001D4D RID: 7501 RVA: 0x0008C34C File Offset: 0x0008A54C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicExprWrapper()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicModule.DynamicExprWrapper>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicModule.DynamicExprWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D4E RID: 7502 RVA: 0x0000B99A File Offset: 0x00009B9A
			public DynamicExprWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x06001D4F RID: 7503 RVA: 0x0008C388 File Offset: 0x0008A588
			// (set) Token: 0x06001D50 RID: 7504 RVA: 0x0000B9A3 File Offset: 0x00009BA3
			public unsafe DynamicExpression Expr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicModule.DynamicExprWrapper.NativeFieldInfoPtr_Expr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicExpression>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicModule.DynamicExprWrapper.NativeFieldInfoPtr_Expr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400175F RID: 5983
			private static readonly IntPtr NativeFieldInfoPtr_Expr;

			// Token: 0x04001760 RID: 5984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
