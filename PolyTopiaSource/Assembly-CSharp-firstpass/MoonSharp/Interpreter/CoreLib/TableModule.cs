using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000117 RID: 279
	public class TableModule : Object
	{
		// Token: 0x060014CE RID: 5326 RVA: 0x0006C27C File Offset: 0x0006A47C
		// Note: this type is marked as 'beforefieldinit'.
		static TableModule()
		{
			Il2CppClassPointerStore<TableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "TableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableModule>.NativeClassPtr);
			TableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667011);
			TableModule.NativeMethodInfoPtr_unpack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667002);
			TableModule.NativeMethodInfoPtr_pack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667003);
			TableModule.NativeMethodInfoPtr_sort_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667004);
			TableModule.NativeMethodInfoPtr_SortComparer_Private_Static_Int32_ScriptExecutionContext_DynValue_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667005);
			TableModule.NativeMethodInfoPtr_LuaComparerToClrComparer_Private_Static_Int32_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667006);
			TableModule.NativeMethodInfoPtr_insert_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667007);
			TableModule.NativeMethodInfoPtr_remove_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667008);
			TableModule.NativeMethodInfoPtr_concat_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667009);
			TableModule.NativeMethodInfoPtr_GetTableLength_Private_Static_Int32_ScriptExecutionContext_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule>.NativeClassPtr, 100667010);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0006C374 File Offset: 0x0006A574
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TableModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0006C3B0 File Offset: 0x0006A5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50294, RefRangeEnd = 50295, XrefRangeStart = 50271, XrefRangeEnd = 50294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue unpack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr_unpack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0006C408 File Offset: 0x0006A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50295, XrefRangeEnd = 50313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue pack(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr_pack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0006C460 File Offset: 0x0006A660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50313, XrefRangeEnd = 50358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue sort(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr_sort_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0006C4B8 File Offset: 0x0006A6B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50375, RefRangeEnd = 50376, XrefRangeStart = 50358, XrefRangeEnd = 50375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SortComparer(ScriptExecutionContext executionContext, DynValue a, DynValue b, DynValue lt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr_SortComparer_Private_Static_Int32_ScriptExecutionContext_DynValue_DynValue_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0006C530 File Offset: 0x0006A730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50376, XrefRangeEnd = 50378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LuaComparerToClrComparer(DynValue dynValue1, DynValue dynValue2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynValue1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dynValue2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr_LuaComparerToClrComparer_Private_Static_Int32_DynValue_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0006C584 File Offset: 0x0006A784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50378, XrefRangeEnd = 50394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue insert(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr_insert_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0006C5DC File Offset: 0x0006A7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50394, XrefRangeEnd = 50414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue remove(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr_remove_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0006C634 File Offset: 0x0006A834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50414, XrefRangeEnd = 50467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue concat(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr_concat_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0006C68C File Offset: 0x0006A88C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 50475, RefRangeEnd = 50480, XrefRangeStart = 50467, XrefRangeEnd = 50475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetTableLength(ScriptExecutionContext executionContext, DynValue vlist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vlist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.NativeMethodInfoPtr_GetTableLength_Private_Static_Int32_ScriptExecutionContext_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00008242 File Offset: 0x00006442
		public TableModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_unpack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_pack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_sort_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_SortComparer_Private_Static_Int32_ScriptExecutionContext_DynValue_DynValue_DynValue_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_LuaComparerToClrComparer_Private_Static_Int32_DynValue_DynValue_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_insert_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_remove_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_concat_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_GetTableLength_Private_Static_Int32_ScriptExecutionContext_DynValue_0;

		// Token: 0x020001ED RID: 493
		[ObfuscatedName("MoonSharp.Interpreter.CoreLib.TableModule+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06001DAE RID: 7598 RVA: 0x0008D610 File Offset: 0x0008B810
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<TableModule.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TableModule>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableModule.__c__DisplayClass2_0>.NativeClassPtr);
				TableModule.__c__DisplayClass2_0.NativeFieldInfoPtr_executionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableModule.__c__DisplayClass2_0>.NativeClassPtr, "executionContext");
				TableModule.__c__DisplayClass2_0.NativeFieldInfoPtr_lt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableModule.__c__DisplayClass2_0>.NativeClassPtr, "lt");
				TableModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule.__c__DisplayClass2_0>.NativeClassPtr, 100667012);
				TableModule.__c__DisplayClass2_0.NativeMethodInfoPtr__sort_b__0_Internal_Int32_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule.__c__DisplayClass2_0>.NativeClassPtr, 100667013);
			}

			// Token: 0x06001DAF RID: 7599 RVA: 0x0008D68C File Offset: 0x0008B88C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableModule.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DB0 RID: 7600 RVA: 0x0008D6C8 File Offset: 0x0008B8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50270, XrefRangeEnd = 50271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _sort_b__0(DynValue a, DynValue b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule.__c__DisplayClass2_0.NativeMethodInfoPtr__sort_b__0_Internal_Int32_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001DB1 RID: 7601 RVA: 0x0000BBE7 File Offset: 0x00009DE7
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x0008D728 File Offset: 0x0008B928
			// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x0000BBF0 File Offset: 0x00009DF0
			public unsafe ScriptExecutionContext executionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableModule.__c__DisplayClass2_0.NativeFieldInfoPtr_executionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableModule.__c__DisplayClass2_0.NativeFieldInfoPtr_executionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0008D758 File Offset: 0x0008B958
			// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x0000BC0F File Offset: 0x00009E0F
			public unsafe DynValue lt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableModule.__c__DisplayClass2_0.NativeFieldInfoPtr_lt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableModule.__c__DisplayClass2_0.NativeFieldInfoPtr_lt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400179B RID: 6043
			private static readonly IntPtr NativeFieldInfoPtr_executionContext;

			// Token: 0x0400179C RID: 6044
			private static readonly IntPtr NativeFieldInfoPtr_lt;

			// Token: 0x0400179D RID: 6045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400179E RID: 6046
			private static readonly IntPtr NativeMethodInfoPtr__sort_b__0_Internal_Int32_DynValue_DynValue_0;
		}
	}
}
