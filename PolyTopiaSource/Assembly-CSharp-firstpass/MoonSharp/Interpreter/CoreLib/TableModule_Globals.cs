using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000118 RID: 280
	public class TableModule_Globals : Object
	{
		// Token: 0x060014DA RID: 5338 RVA: 0x0006C6E0 File Offset: 0x0006A8E0
		// Note: this type is marked as 'beforefieldinit'.
		static TableModule_Globals()
		{
			Il2CppClassPointerStore<TableModule_Globals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "TableModule_Globals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableModule_Globals>.NativeClassPtr);
			TableModule_Globals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule_Globals>.NativeClassPtr, 100667016);
			TableModule_Globals.NativeMethodInfoPtr_unpack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule_Globals>.NativeClassPtr, 100667014);
			TableModule_Globals.NativeMethodInfoPtr_pack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableModule_Globals>.NativeClassPtr, 100667015);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0006C74C File Offset: 0x0006A94C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TableModule_Globals()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableModule_Globals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule_Globals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0006C788 File Offset: 0x0006A988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50480, XrefRangeEnd = 50481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule_Globals.NativeMethodInfoPtr_unpack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0006C7E0 File Offset: 0x0006A9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableModule_Globals.NativeMethodInfoPtr_pack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0000824B File Offset: 0x0000644B
		public TableModule_Globals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_unpack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_pack_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;
	}
}
