using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x0200010F RID: 271
	public class JsonModule : Object
	{
		// Token: 0x0600144A RID: 5194 RVA: 0x000694E8 File Offset: 0x000676E8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonModule()
		{
			Il2CppClassPointerStore<JsonModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "JsonModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonModule>.NativeClassPtr);
			JsonModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonModule>.NativeClassPtr, 100666872);
			JsonModule.NativeMethodInfoPtr_parse_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonModule>.NativeClassPtr, 100666868);
			JsonModule.NativeMethodInfoPtr_serialize_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonModule>.NativeClassPtr, 100666869);
			JsonModule.NativeMethodInfoPtr_isnull_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonModule>.NativeClassPtr, 100666870);
			JsonModule.NativeMethodInfoPtr_null_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonModule>.NativeClassPtr, 100666871);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0006957C File Offset: 0x0006777C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000695B8 File Offset: 0x000677B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48236, XrefRangeEnd = 48246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue parse(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonModule.NativeMethodInfoPtr_parse_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00069610 File Offset: 0x00067810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48246, XrefRangeEnd = 48255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue serialize(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonModule.NativeMethodInfoPtr_serialize_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00069668 File Offset: 0x00067868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48255, XrefRangeEnd = 48264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue isnull(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonModule.NativeMethodInfoPtr_isnull_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000696C0 File Offset: 0x000678C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48264, XrefRangeEnd = 48265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue @null(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonModule.NativeMethodInfoPtr_null_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00008196 File Offset: 0x00006396
		public JsonModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_parse_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_serialize_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_isnull_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_null_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;
	}
}
