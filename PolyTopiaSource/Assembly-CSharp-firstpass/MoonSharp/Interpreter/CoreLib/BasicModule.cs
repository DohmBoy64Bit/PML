using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000108 RID: 264
	public class BasicModule : Object
	{
		// Token: 0x060013E8 RID: 5096 RVA: 0x00067198 File Offset: 0x00065398
		// Note: this type is marked as 'beforefieldinit'.
		static BasicModule()
		{
			Il2CppClassPointerStore<BasicModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "BasicModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicModule>.NativeClassPtr);
			BasicModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666784);
			BasicModule.NativeMethodInfoPtr_type_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666775);
			BasicModule.NativeMethodInfoPtr_assert_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666776);
			BasicModule.NativeMethodInfoPtr_collectgarbage_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666777);
			BasicModule.NativeMethodInfoPtr_error_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666778);
			BasicModule.NativeMethodInfoPtr_tostring_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666779);
			BasicModule.NativeMethodInfoPtr___tostring_continuation_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666780);
			BasicModule.NativeMethodInfoPtr_select_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666781);
			BasicModule.NativeMethodInfoPtr_tonumber_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666782);
			BasicModule.NativeMethodInfoPtr_print_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicModule>.NativeClassPtr, 100666783);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00067290 File Offset: 0x00065490
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x000672CC File Offset: 0x000654CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46694, XrefRangeEnd = 46705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue type(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr_type_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00067324 File Offset: 0x00065524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46705, XrefRangeEnd = 46729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue assert(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr_assert_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0006737C File Offset: 0x0006557C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46729, XrefRangeEnd = 46748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue collectgarbage(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr_collectgarbage_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000673D4 File Offset: 0x000655D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46748, XrefRangeEnd = 46791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue error(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr_error_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0006742C File Offset: 0x0006562C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46791, XrefRangeEnd = 46814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue tostring(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr_tostring_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00067484 File Offset: 0x00065684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46814, XrefRangeEnd = 46817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue __tostring_continuation(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr___tostring_continuation_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x000674DC File Offset: 0x000656DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46817, XrefRangeEnd = 46871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue select(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr_select_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00067534 File Offset: 0x00065734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46871, XrefRangeEnd = 46916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue tonumber(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr_tonumber_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0006758C File Offset: 0x0006578C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46916, XrefRangeEnd = 46939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue print(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicModule.NativeMethodInfoPtr_print_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00008145 File Offset: 0x00006345
		public BasicModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_type_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_assert_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_collectgarbage_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_error_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_tostring_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr___tostring_continuation_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_select_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_tonumber_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_print_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;
	}
}
