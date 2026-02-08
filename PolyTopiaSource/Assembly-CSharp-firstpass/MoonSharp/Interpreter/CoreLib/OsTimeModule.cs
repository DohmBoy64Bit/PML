using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000114 RID: 276
	public class OsTimeModule : Object
	{
		// Token: 0x0600149C RID: 5276 RVA: 0x0006B1D0 File Offset: 0x000693D0
		// Note: this type is marked as 'beforefieldinit'.
		static OsTimeModule()
		{
			Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "OsTimeModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr);
			OsTimeModule.NativeFieldInfoPtr_Time0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, "Time0");
			OsTimeModule.NativeFieldInfoPtr_Epoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, "Epoch");
			OsTimeModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666968);
			OsTimeModule.NativeMethodInfoPtr_GetUnixTime_Private_Static_DynValue_DateTime_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666959);
			OsTimeModule.NativeMethodInfoPtr_FromUnixTime_Private_Static_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666960);
			OsTimeModule.NativeMethodInfoPtr_clock_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666961);
			OsTimeModule.NativeMethodInfoPtr_difftime_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666962);
			OsTimeModule.NativeMethodInfoPtr_time_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666963);
			OsTimeModule.NativeMethodInfoPtr_ParseTimeTable_Private_Static_DateTime_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666964);
			OsTimeModule.NativeMethodInfoPtr_GetTimeTableField_Private_Static_Nullable_1_Int32_Table_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666965);
			OsTimeModule.NativeMethodInfoPtr_date_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666966);
			OsTimeModule.NativeMethodInfoPtr_StrFTime_Private_Static_String_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr, 100666967);
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0006B2F0 File Offset: 0x000694F0
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OsTimeModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OsTimeModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0006B32C File Offset: 0x0006952C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49492, RefRangeEnd = 49494, XrefRangeStart = 49473, XrefRangeEnd = 49492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue GetUnixTime(DateTime dateTime, Nullable<DateTime> epoch = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dateTime);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(epoch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr_GetUnixTime_Private_Static_DynValue_DateTime_Nullable_1_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0006B384 File Offset: 0x00069584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49494, XrefRangeEnd = 49506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromUnixTime(double unixtime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unixtime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr_FromUnixTime_Private_Static_DateTime_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTime>(intPtr3) : null;
			}
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0006B3C4 File Offset: 0x000695C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49506, XrefRangeEnd = 49520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue clock(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr_clock_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0006B41C File Offset: 0x0006961C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49520, XrefRangeEnd = 49533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue difftime(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr_difftime_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x0006B474 File Offset: 0x00069674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49533, XrefRangeEnd = 49548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue time(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr_time_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0006B4CC File Offset: 0x000696CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49582, RefRangeEnd = 49583, XrefRangeStart = 49548, XrefRangeEnd = 49582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseTimeTable(Table t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr_ParseTimeTable_Private_Static_DateTime_Table_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTime>(intPtr3) : null;
			}
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0006B510 File Offset: 0x00069710
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 49588, RefRangeEnd = 49594, XrefRangeStart = 49583, XrefRangeEnd = 49588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> GetTimeTableField(Table t, string key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr_GetTimeTableField_Private_Static_Nullable_1_Int32_Table_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<int>>(intPtr3) : null;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0006B568 File Offset: 0x00069768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49594, XrefRangeEnd = 49658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue date(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr_date_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0006B5C0 File Offset: 0x000697C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49835, RefRangeEnd = 49836, XrefRangeStart = 49658, XrefRangeEnd = 49835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StrFTime(string format, DateTime d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsTimeModule.NativeMethodInfoPtr_StrFTime_Private_Static_String_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000081F1 File Offset: 0x000063F1
		public OsTimeModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0006B610 File Offset: 0x00069810
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x000081FA File Offset: 0x000063FA
		public unsafe static DateTime Time0
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(OsTimeModule.NativeFieldInfoPtr_Time0, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OsTimeModule.NativeFieldInfoPtr_Time0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x0006B62C File Offset: 0x0006982C
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x0000820C File Offset: 0x0000640C
		public unsafe static DateTime Epoch
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(OsTimeModule.NativeFieldInfoPtr_Epoch, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OsTimeModule.NativeFieldInfoPtr_Epoch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr_Time0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr_Epoch;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_GetUnixTime_Private_Static_DynValue_DateTime_Nullable_1_DateTime_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_FromUnixTime_Private_Static_DateTime_Double_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_clock_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_difftime_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_time_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeTable_Private_Static_DateTime_Table_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeTableField_Private_Static_Nullable_1_Int32_Table_String_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_date_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_StrFTime_Private_Static_String_String_DateTime_0;
	}
}
