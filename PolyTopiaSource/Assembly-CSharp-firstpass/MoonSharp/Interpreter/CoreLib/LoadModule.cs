using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000110 RID: 272
	public class LoadModule : Object
	{
		// Token: 0x06001451 RID: 5201 RVA: 0x00069718 File Offset: 0x00067918
		// Note: this type is marked as 'beforefieldinit'.
		static LoadModule()
		{
			Il2CppClassPointerStore<LoadModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "LoadModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadModule>.NativeClassPtr);
			LoadModule.NativeFieldInfoPtr_require = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, "require");
			LoadModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666883);
			LoadModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666873);
			LoadModule.NativeMethodInfoPtr_load_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666874);
			LoadModule.NativeMethodInfoPtr_loadsafe_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666875);
			LoadModule.NativeMethodInfoPtr_load_impl_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666876);
			LoadModule.NativeMethodInfoPtr_loadfile_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666877);
			LoadModule.NativeMethodInfoPtr_loadfilesafe_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666878);
			LoadModule.NativeMethodInfoPtr_loadfile_impl_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666879);
			LoadModule.NativeMethodInfoPtr_GetSafeDefaultEnv_Private_Static_Table_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666880);
			LoadModule.NativeMethodInfoPtr_dofile_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666881);
			LoadModule.NativeMethodInfoPtr___require_clr_impl_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadModule>.NativeClassPtr, 100666882);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00069838 File Offset: 0x00067A38
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00069874 File Offset: 0x00067A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48265, XrefRangeEnd = 48300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoonSharpInit(Table globalTable, Table ioTable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(globalTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ioTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000698BC File Offset: 0x00067ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48300, XrefRangeEnd = 48301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue load(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr_load_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00069914 File Offset: 0x00067B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48301, XrefRangeEnd = 48310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue loadsafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr_loadsafe_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0006996C File Offset: 0x00067B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48368, RefRangeEnd = 48370, XrefRangeStart = 48310, XrefRangeEnd = 48368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue load_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultEnv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr_load_impl_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x000699D4 File Offset: 0x00067BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48370, XrefRangeEnd = 48371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue loadfile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr_loadfile_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00069A2C File Offset: 0x00067C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48371, XrefRangeEnd = 48380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue loadfilesafe(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr_loadfilesafe_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00069A84 File Offset: 0x00067C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48402, RefRangeEnd = 48404, XrefRangeStart = 48380, XrefRangeEnd = 48402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue loadfile_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultEnv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr_loadfile_impl_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00069AEC File Offset: 0x00067CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48404, XrefRangeEnd = 48405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table GetSafeDefaultEnv(ScriptExecutionContext executionContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr_GetSafeDefaultEnv_Private_Static_Table_ScriptExecutionContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00069B30 File Offset: 0x00067D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48405, XrefRangeEnd = 48418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue dofile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr_dofile_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00069B88 File Offset: 0x00067D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48418, XrefRangeEnd = 48425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue __require_clr_impl(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadModule.NativeMethodInfoPtr___require_clr_impl_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0000819F File Offset: 0x0000639F
		public LoadModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00069BE0 File Offset: 0x00067DE0
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x000081A8 File Offset: 0x000063A8
		public unsafe static string require
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadModule.NativeFieldInfoPtr_require, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadModule.NativeFieldInfoPtr_require, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeFieldInfoPtr_require;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_load_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_loadsafe_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_load_impl_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_Table_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_loadfile_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_loadfilesafe_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_loadfile_impl_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_Table_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_GetSafeDefaultEnv_Private_Static_Table_ScriptExecutionContext_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_dofile_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr___require_clr_impl_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;
	}
}
