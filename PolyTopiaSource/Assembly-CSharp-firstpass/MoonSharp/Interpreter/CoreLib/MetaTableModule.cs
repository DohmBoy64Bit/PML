using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000112 RID: 274
	public class MetaTableModule : Object
	{
		// Token: 0x06001489 RID: 5257 RVA: 0x0006AB54 File Offset: 0x00068D54
		// Note: this type is marked as 'beforefieldinit'.
		static MetaTableModule()
		{
			Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "MetaTableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr);
			MetaTableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr, 100666950);
			MetaTableModule.NativeMethodInfoPtr_setmetatable_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr, 100666944);
			MetaTableModule.NativeMethodInfoPtr_getmetatable_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr, 100666945);
			MetaTableModule.NativeMethodInfoPtr_rawget_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr, 100666946);
			MetaTableModule.NativeMethodInfoPtr_rawset_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr, 100666947);
			MetaTableModule.NativeMethodInfoPtr_rawequal_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr, 100666948);
			MetaTableModule.NativeMethodInfoPtr_rawlen_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr, 100666949);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0006AC10 File Offset: 0x00068E10
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaTableModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaTableModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0006AC4C File Offset: 0x00068E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49167, XrefRangeEnd = 49178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue setmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTableModule.NativeMethodInfoPtr_setmetatable_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x0006ACA4 File Offset: 0x00068EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49178, XrefRangeEnd = 49198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue getmetatable(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTableModule.NativeMethodInfoPtr_getmetatable_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0006ACFC File Offset: 0x00068EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49198, XrefRangeEnd = 49205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue rawget(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTableModule.NativeMethodInfoPtr_rawget_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0006AD54 File Offset: 0x00068F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49205, XrefRangeEnd = 49212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue rawset(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTableModule.NativeMethodInfoPtr_rawset_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0006ADAC File Offset: 0x00068FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49212, XrefRangeEnd = 49219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue rawequal(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTableModule.NativeMethodInfoPtr_rawequal_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0006AE04 File Offset: 0x00069004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49219, XrefRangeEnd = 49234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue rawlen(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaTableModule.NativeMethodInfoPtr_rawlen_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x000081DF File Offset: 0x000063DF
		public MetaTableModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_setmetatable_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_getmetatable_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_rawget_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_rawset_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_rawequal_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_rawlen_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;
	}
}
