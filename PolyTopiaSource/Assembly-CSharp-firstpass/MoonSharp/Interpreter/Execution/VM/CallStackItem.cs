using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000E7 RID: 231
	public class CallStackItem : Object
	{
		// Token: 0x06001182 RID: 4482 RVA: 0x0005CD08 File Offset: 0x0005AF08
		// Note: this type is marked as 'beforefieldinit'.
		static CallStackItem()
		{
			Il2CppClassPointerStore<CallStackItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution.VM", "CallStackItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr);
			CallStackItem.NativeFieldInfoPtr_Debug_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "Debug_EntryPoint");
			CallStackItem.NativeFieldInfoPtr_Debug_Symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "Debug_Symbols");
			CallStackItem.NativeFieldInfoPtr_CallingSourceRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "CallingSourceRef");
			CallStackItem.NativeFieldInfoPtr_ClrFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "ClrFunction");
			CallStackItem.NativeFieldInfoPtr_Continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "Continuation");
			CallStackItem.NativeFieldInfoPtr_ErrorHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "ErrorHandler");
			CallStackItem.NativeFieldInfoPtr_ErrorHandlerBeforeUnwind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "ErrorHandlerBeforeUnwind");
			CallStackItem.NativeFieldInfoPtr_BasePointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "BasePointer");
			CallStackItem.NativeFieldInfoPtr_ReturnAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "ReturnAddress");
			CallStackItem.NativeFieldInfoPtr_LocalScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "LocalScope");
			CallStackItem.NativeFieldInfoPtr_ClosureScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "ClosureScope");
			CallStackItem.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, "Flags");
			CallStackItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr, 100666412);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0005CE3C File Offset: 0x0005B03C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallStackItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallStackItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallStackItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00007387 File Offset: 0x00005587
		public CallStackItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0005CE78 File Offset: 0x0005B078
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x00007390 File Offset: 0x00005590
		public unsafe int Debug_EntryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_Debug_EntryPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_Debug_EntryPoint)) = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x0005CEA0 File Offset: 0x0005B0A0
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x000073AB File Offset: 0x000055AB
		public unsafe Il2CppReferenceArray<SymbolRef> Debug_Symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_Debug_Symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SymbolRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_Debug_Symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0005CED0 File Offset: 0x0005B0D0
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x000073CA File Offset: 0x000055CA
		public unsafe SourceRef CallingSourceRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_CallingSourceRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_CallingSourceRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x0005CF00 File Offset: 0x0005B100
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x000073E9 File Offset: 0x000055E9
		public unsafe CallbackFunction ClrFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ClrFunction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ClrFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x0005CF30 File Offset: 0x0005B130
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x00007408 File Offset: 0x00005608
		public unsafe CallbackFunction Continuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_Continuation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_Continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x0005CF60 File Offset: 0x0005B160
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x00007427 File Offset: 0x00005627
		public unsafe CallbackFunction ErrorHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ErrorHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ErrorHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x0005CF90 File Offset: 0x0005B190
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x00007446 File Offset: 0x00005646
		public unsafe DynValue ErrorHandlerBeforeUnwind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ErrorHandlerBeforeUnwind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ErrorHandlerBeforeUnwind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x0005CFC0 File Offset: 0x0005B1C0
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x00007465 File Offset: 0x00005665
		public unsafe int BasePointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_BasePointer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_BasePointer)) = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0005CFE8 File Offset: 0x0005B1E8
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x00007480 File Offset: 0x00005680
		public unsafe int ReturnAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ReturnAddress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ReturnAddress)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0005D010 File Offset: 0x0005B210
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x0000749B File Offset: 0x0000569B
		public unsafe Il2CppReferenceArray<DynValue> LocalScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_LocalScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_LocalScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0005D040 File Offset: 0x0005B240
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x000074BA File Offset: 0x000056BA
		public unsafe ClosureContext ClosureScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ClosureScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClosureContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_ClosureScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0005D070 File Offset: 0x0005B270
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x000074D9 File Offset: 0x000056D9
		public unsafe CallStackItemFlags Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_Flags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallStackItemFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallStackItem.NativeFieldInfoPtr_Flags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeFieldInfoPtr_Debug_EntryPoint;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeFieldInfoPtr_Debug_Symbols;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeFieldInfoPtr_CallingSourceRef;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeFieldInfoPtr_ClrFunction;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeFieldInfoPtr_Continuation;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeFieldInfoPtr_ErrorHandler;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeFieldInfoPtr_ErrorHandlerBeforeUnwind;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeFieldInfoPtr_BasePointer;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeFieldInfoPtr_ReturnAddress;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr_LocalScope;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr_ClosureScope;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
