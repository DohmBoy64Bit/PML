using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x0200010D RID: 269
	public class ErrorHandlingModule : Object
	{
		// Token: 0x06001428 RID: 5160 RVA: 0x000687F0 File Offset: 0x000669F0
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorHandlingModule()
		{
			Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "ErrorHandlingModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr);
			ErrorHandlingModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr, 100666841);
			ErrorHandlingModule.NativeMethodInfoPtr_pcall_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr, 100666835);
			ErrorHandlingModule.NativeMethodInfoPtr_SetErrorHandlerStrategy_Private_Static_DynValue_String_ScriptExecutionContext_CallbackArguments_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr, 100666836);
			ErrorHandlingModule.NativeMethodInfoPtr_MakeReturnTuple_Private_Static_DynValue_Boolean_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr, 100666837);
			ErrorHandlingModule.NativeMethodInfoPtr_pcall_continuation_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr, 100666838);
			ErrorHandlingModule.NativeMethodInfoPtr_pcall_onerror_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr, 100666839);
			ErrorHandlingModule.NativeMethodInfoPtr_xpcall_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr, 100666840);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000688AC File Offset: 0x00066AAC
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorHandlingModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorHandlingModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorHandlingModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000688E8 File Offset: 0x00066AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47632, XrefRangeEnd = 47635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue pcall(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorHandlingModule.NativeMethodInfoPtr_pcall_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00068940 File Offset: 0x00066B40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47692, RefRangeEnd = 47694, XrefRangeStart = 47635, XrefRangeEnd = 47692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue SetErrorHandlerStrategy(string funcName, ScriptExecutionContext executionContext, CallbackArguments args, DynValue handlerBeforeUnwind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handlerBeforeUnwind);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorHandlingModule.NativeMethodInfoPtr_SetErrorHandlerStrategy_Private_Static_DynValue_String_ScriptExecutionContext_CallbackArguments_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x000689BC File Offset: 0x00066BBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47708, RefRangeEnd = 47710, XrefRangeStart = 47694, XrefRangeEnd = 47708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue MakeReturnTuple(bool retstatus, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref retstatus;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorHandlingModule.NativeMethodInfoPtr_MakeReturnTuple_Private_Static_DynValue_Boolean_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00068A10 File Offset: 0x00066C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47710, XrefRangeEnd = 47711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue pcall_continuation(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorHandlingModule.NativeMethodInfoPtr_pcall_continuation_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00068A68 File Offset: 0x00066C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47711, XrefRangeEnd = 47712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue pcall_onerror(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorHandlingModule.NativeMethodInfoPtr_pcall_onerror_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00068AC0 File Offset: 0x00066CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47712, XrefRangeEnd = 47737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue xpcall(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorHandlingModule.NativeMethodInfoPtr_xpcall_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00008184 File Offset: 0x00006384
		public ErrorHandlingModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_pcall_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_SetErrorHandlerStrategy_Private_Static_DynValue_String_ScriptExecutionContext_CallbackArguments_DynValue_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_MakeReturnTuple_Private_Static_DynValue_Boolean_CallbackArguments_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_pcall_continuation_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_pcall_onerror_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_xpcall_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;
	}
}
