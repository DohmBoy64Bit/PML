using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000113 RID: 275
	public class OsSystemModule : Object
	{
		// Token: 0x06001492 RID: 5266 RVA: 0x0006AE5C File Offset: 0x0006905C
		// Note: this type is marked as 'beforefieldinit'.
		static OsSystemModule()
		{
			Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "OsSystemModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr);
			OsSystemModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr, 100666958);
			OsSystemModule.NativeMethodInfoPtr_execute_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr, 100666951);
			OsSystemModule.NativeMethodInfoPtr_exit_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr, 100666952);
			OsSystemModule.NativeMethodInfoPtr_getenv_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr, 100666953);
			OsSystemModule.NativeMethodInfoPtr_remove_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr, 100666954);
			OsSystemModule.NativeMethodInfoPtr_rename_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr, 100666955);
			OsSystemModule.NativeMethodInfoPtr_setlocale_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr, 100666956);
			OsSystemModule.NativeMethodInfoPtr_tmpname_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr, 100666957);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0006AF2C File Offset: 0x0006912C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OsSystemModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OsSystemModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsSystemModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0006AF68 File Offset: 0x00069168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49234, XrefRangeEnd = 49273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue execute(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsSystemModule.NativeMethodInfoPtr_execute_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0006AFC0 File Offset: 0x000691C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49273, XrefRangeEnd = 49295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue exit(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsSystemModule.NativeMethodInfoPtr_exit_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0006B018 File Offset: 0x00069218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49295, XrefRangeEnd = 49319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue getenv(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsSystemModule.NativeMethodInfoPtr_getenv_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0006B070 File Offset: 0x00069270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49319, XrefRangeEnd = 49384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsSystemModule.NativeMethodInfoPtr_remove_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0006B0C8 File Offset: 0x000692C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49384, XrefRangeEnd = 49452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue rename(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsSystemModule.NativeMethodInfoPtr_rename_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0006B120 File Offset: 0x00069320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49452, XrefRangeEnd = 49458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue setlocale(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsSystemModule.NativeMethodInfoPtr_setlocale_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0006B178 File Offset: 0x00069378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49458, XrefRangeEnd = 49473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue tmpname(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OsSystemModule.NativeMethodInfoPtr_tmpname_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x000081E8 File Offset: 0x000063E8
		public OsSystemModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_exit_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_getenv_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_remove_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_rename_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_setlocale_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_tmpname_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;
	}
}
