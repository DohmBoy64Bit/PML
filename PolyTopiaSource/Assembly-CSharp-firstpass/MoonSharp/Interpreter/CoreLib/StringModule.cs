using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000115 RID: 277
	public class StringModule : Object
	{
		// Token: 0x060014AC RID: 5292 RVA: 0x0006B648 File Offset: 0x00069848
		// Note: this type is marked as 'beforefieldinit'.
		static StringModule()
		{
			Il2CppClassPointerStore<StringModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "StringModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringModule>.NativeClassPtr);
			StringModule.NativeFieldInfoPtr_BASE64_DUMP_HEADER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringModule>.NativeClassPtr, "BASE64_DUMP_HEADER");
			StringModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666992);
			StringModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666970);
			StringModule.NativeMethodInfoPtr_dump_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666971);
			StringModule.NativeMethodInfoPtr_char_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666972);
			StringModule.NativeMethodInfoPtr_byte_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666973);
			StringModule.NativeMethodInfoPtr_unicode_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666974);
			StringModule.NativeMethodInfoPtr_Unicode2Ascii_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666975);
			StringModule.NativeMethodInfoPtr_PerformByteLike_Private_Static_DynValue_DynValue_DynValue_DynValue_Func_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666976);
			StringModule.NativeMethodInfoPtr_AdjustIndex_Private_Static_Nullable_1_Int32_String_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666977);
			StringModule.NativeMethodInfoPtr_len_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666978);
			StringModule.NativeMethodInfoPtr_match_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666979);
			StringModule.NativeMethodInfoPtr_gmatch_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666980);
			StringModule.NativeMethodInfoPtr_gsub_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666981);
			StringModule.NativeMethodInfoPtr_find_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666982);
			StringModule.NativeMethodInfoPtr_lower_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666983);
			StringModule.NativeMethodInfoPtr_upper_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666984);
			StringModule.NativeMethodInfoPtr_rep_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666985);
			StringModule.NativeMethodInfoPtr_format_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666986);
			StringModule.NativeMethodInfoPtr_reverse_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666987);
			StringModule.NativeMethodInfoPtr_sub_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666988);
			StringModule.NativeMethodInfoPtr_startsWith_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666989);
			StringModule.NativeMethodInfoPtr_endsWith_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666990);
			StringModule.NativeMethodInfoPtr_contains_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule>.NativeClassPtr, 100666991);
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0006B858 File Offset: 0x00069A58
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0006B894 File Offset: 0x00069A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49836, XrefRangeEnd = 49849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0006B8DC File Offset: 0x00069ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49849, XrefRangeEnd = 49875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue dump(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_dump_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0006B934 File Offset: 0x00069B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49875, XrefRangeEnd = 49898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue @char(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_char_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0006B98C File Offset: 0x00069B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49898, XrefRangeEnd = 49921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue @byte(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_byte_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0006B9E4 File Offset: 0x00069BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49921, XrefRangeEnd = 49944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue unicode(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_unicode_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0006BA3C File Offset: 0x00069C3C
		[CallerCount(0)]
		public unsafe static int Unicode2Ascii(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_Unicode2Ascii_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0006BA7C File Offset: 0x00069C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49961, RefRangeEnd = 49963, XrefRangeStart = 49944, XrefRangeEnd = 49961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue PerformByteLike(DynValue vs, DynValue vi, DynValue vj, Func<int, int> filter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_PerformByteLike_Private_Static_DynValue_DynValue_DynValue_DynValue_Func_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0006BAF8 File Offset: 0x00069CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49963, XrefRangeEnd = 49974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> AdjustIndex(string s, DynValue vi, int defval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_AdjustIndex_Private_Static_Nullable_1_Int32_String_DynValue_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<int>>(intPtr3) : null;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0006BB5C File Offset: 0x00069D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49974, XrefRangeEnd = 49983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue len(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_len_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0006BBB4 File Offset: 0x00069DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49983, XrefRangeEnd = 49992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue match(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_match_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0006BC0C File Offset: 0x00069E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49992, XrefRangeEnd = 50001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue gmatch(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_gmatch_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0006BC64 File Offset: 0x00069E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50001, XrefRangeEnd = 50010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue gsub(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_gsub_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0006BCBC File Offset: 0x00069EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50010, XrefRangeEnd = 50019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue find(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_find_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0006BD14 File Offset: 0x00069F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50019, XrefRangeEnd = 50033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue lower(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_lower_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0006BD6C File Offset: 0x00069F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50033, XrefRangeEnd = 50047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue upper(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_upper_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0006BDC4 File Offset: 0x00069FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50047, XrefRangeEnd = 50080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue rep(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_rep_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0006BE1C File Offset: 0x0006A01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50080, XrefRangeEnd = 50089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue format(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_format_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0006BE74 File Offset: 0x0006A074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50089, XrefRangeEnd = 50110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue reverse(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_reverse_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0006BECC File Offset: 0x0006A0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50110, XrefRangeEnd = 50127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue sub(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_sub_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0006BF24 File Offset: 0x0006A124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50127, XrefRangeEnd = 50147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue startsWith(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_startsWith_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0006BF7C File Offset: 0x0006A17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50147, XrefRangeEnd = 50167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue endsWith(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_endsWith_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0006BFD4 File Offset: 0x0006A1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50167, XrefRangeEnd = 50187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue contains(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.NativeMethodInfoPtr_contains_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0000821E File Offset: 0x0000641E
		public StringModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x0006C02C File Offset: 0x0006A22C
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x00008227 File Offset: 0x00006427
		public unsafe static string BASE64_DUMP_HEADER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringModule.NativeFieldInfoPtr_BASE64_DUMP_HEADER, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringModule.NativeFieldInfoPtr_BASE64_DUMP_HEADER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeFieldInfoPtr_BASE64_DUMP_HEADER;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_dump_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_char_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_byte_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_unicode_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_Unicode2Ascii_Private_Static_Int32_Int32_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_PerformByteLike_Private_Static_DynValue_DynValue_DynValue_DynValue_Func_2_Int32_Int32_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_AdjustIndex_Private_Static_Nullable_1_Int32_String_DynValue_Int32_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_len_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_match_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_gmatch_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_gsub_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_find_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_lower_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_upper_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_rep_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_format_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_reverse_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_sub_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_startsWith_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_endsWith_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_contains_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x020001EC RID: 492
		[ObfuscatedName("MoonSharp.Interpreter.CoreLib.StringModule+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DA3 RID: 7587 RVA: 0x0008D420 File Offset: 0x0008B620
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StringModule.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StringModule>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringModule.__c>.NativeClassPtr);
				StringModule.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringModule.__c>.NativeClassPtr, "<>9");
				StringModule.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringModule.__c>.NativeClassPtr, "<>9__4_0");
				StringModule.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringModule.__c>.NativeClassPtr, "<>9__5_0");
				StringModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule.__c>.NativeClassPtr, 100666994);
				StringModule.__c.NativeMethodInfoPtr__byte_b__4_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule.__c>.NativeClassPtr, 100666995);
				StringModule.__c.NativeMethodInfoPtr__unicode_b__5_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringModule.__c>.NativeClassPtr, 100666996);
			}

			// Token: 0x06001DA4 RID: 7588 RVA: 0x0008D4C4 File Offset: 0x0008B6C4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringModule.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DA5 RID: 7589 RVA: 0x0008D500 File Offset: 0x0008B700
			[CallerCount(0)]
			public unsafe int _byte_b__4_0(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.__c.NativeMethodInfoPtr__byte_b__4_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DA6 RID: 7590 RVA: 0x0008D54C File Offset: 0x0008B74C
			[CallerCount(0)]
			public unsafe int _unicode_b__5_0(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringModule.__c.NativeMethodInfoPtr__unicode_b__5_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DA7 RID: 7591 RVA: 0x0000BBA8 File Offset: 0x00009DA8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D7 RID: 1751
			// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x0008D598 File Offset: 0x0008B798
			// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x0000BBB1 File Offset: 0x00009DB1
			public unsafe static StringModule.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StringModule.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringModule.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StringModule.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0008D5C0 File Offset: 0x0008B7C0
			// (set) Token: 0x06001DAB RID: 7595 RVA: 0x0000BBC3 File Offset: 0x00009DC3
			public unsafe static Func<int, int> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StringModule.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StringModule.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x06001DAC RID: 7596 RVA: 0x0008D5E8 File Offset: 0x0008B7E8
			// (set) Token: 0x06001DAD RID: 7597 RVA: 0x0000BBD5 File Offset: 0x00009DD5
			public unsafe static Func<int, int> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StringModule.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StringModule.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001795 RID: 6037
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001796 RID: 6038
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001797 RID: 6039
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001798 RID: 6040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001799 RID: 6041
			private static readonly IntPtr NativeMethodInfoPtr__byte_b__4_0_Internal_Int32_Int32_0;

			// Token: 0x0400179A RID: 6042
			private static readonly IntPtr NativeMethodInfoPtr__unicode_b__5_0_Internal_Int32_Int32_0;
		}
	}
}
