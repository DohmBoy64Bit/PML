using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Execution;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000029 RID: 41
	public class Closure : RefIdObject
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x0002C420 File Offset: 0x0002A620
		// Note: this type is marked as 'beforefieldinit'.
		static Closure()
		{
			Il2CppClassPointerStore<Closure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "Closure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Closure>.NativeClassPtr);
			Closure.NativeFieldInfoPtr__EntryPointByteCodeLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Closure>.NativeClassPtr, "<EntryPointByteCodeLocation>k__BackingField");
			Closure.NativeFieldInfoPtr__OwnerScript_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Closure>.NativeClassPtr, "<OwnerScript>k__BackingField");
			Closure.NativeFieldInfoPtr_emptyClosure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Closure>.NativeClassPtr, "emptyClosure");
			Closure.NativeFieldInfoPtr__ClosureContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Closure>.NativeClassPtr, "<ClosureContext>k__BackingField");
			Closure.NativeMethodInfoPtr_get_EntryPointByteCodeLocation_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664456);
			Closure.NativeMethodInfoPtr_set_EntryPointByteCodeLocation_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664457);
			Closure.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664458);
			Closure.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664459);
			Closure.NativeMethodInfoPtr_get_ClosureContext_Internal_get_ClosureContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664460);
			Closure.NativeMethodInfoPtr_set_ClosureContext_Private_set_Void_ClosureContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664461);
			Closure.NativeMethodInfoPtr__ctor_Internal_Void_Script_Int32_Il2CppReferenceArray_1_SymbolRef_IEnumerable_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664462);
			Closure.NativeMethodInfoPtr_Call_Public_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664463);
			Closure.NativeMethodInfoPtr_Call_Public_DynValue_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664464);
			Closure.NativeMethodInfoPtr_Call_Public_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664465);
			Closure.NativeMethodInfoPtr_GetDelegate_Public_ScriptFunctionDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664466);
			Closure.NativeMethodInfoPtr_GetDelegate_Public_ScriptFunctionDelegate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664467);
			Closure.NativeMethodInfoPtr_GetUpvaluesCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664468);
			Closure.NativeMethodInfoPtr_GetUpvalueName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664469);
			Closure.NativeMethodInfoPtr_GetUpvalue_Public_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664470);
			Closure.NativeMethodInfoPtr_GetUpvaluesType_Public_UpvaluesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664471);
			Closure.NativeMethodInfoPtr__GetDelegate_b__18_0_Private_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664473);
			Closure.NativeMethodInfoPtr__GetDelegate_b__19_0_Private_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Closure>.NativeClassPtr, 100664474);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0002C608 File Offset: 0x0002A808
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0002C644 File Offset: 0x0002A844
		public unsafe int EntryPointByteCodeLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_get_EntryPointByteCodeLocation_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_set_EntryPointByteCodeLocation_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0002C684 File Offset: 0x0002A884
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0002C6C4 File Offset: 0x0002A8C4
		public unsafe virtual Script OwnerScript
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0002C708 File Offset: 0x0002A908
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x0002C748 File Offset: 0x0002A948
		public unsafe ClosureContext ClosureContext
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_get_ClosureContext_Internal_get_ClosureContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClosureContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_set_ClosureContext_Private_set_Void_ClosureContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0002C78C File Offset: 0x0002A98C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21400, RefRangeEnd = 21402, XrefRangeStart = 21385, XrefRangeEnd = 21400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Closure(Script script, int idx, Il2CppReferenceArray<SymbolRef> symbols, IEnumerable<DynValue> resolvedLocals)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Closure>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolvedLocals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr__ctor_Internal_Void_Script_Int32_Il2CppReferenceArray_1_SymbolRef_IEnumerable_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0002C80C File Offset: 0x0002AA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21402, XrefRangeEnd = 21411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_Call_Public_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0002C84C File Offset: 0x0002AA4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21413, RefRangeEnd = 21414, XrefRangeStart = 21411, XrefRangeEnd = 21413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_Call_Public_DynValue_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0002C8AC File Offset: 0x0002AAAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21413, RefRangeEnd = 21414, XrefRangeStart = 21413, XrefRangeEnd = 21414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call([Optional] Il2CppReferenceArray<DynValue> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<DynValue>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_Call_Public_DynValue_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0002C90C File Offset: 0x0002AB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21414, XrefRangeEnd = 21429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptFunctionDelegate GetDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_GetDelegate_Public_ScriptFunctionDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptFunctionDelegate>(intPtr3) : null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0002C94C File Offset: 0x0002AB4C
		[CallerCount(0)]
		public unsafe ScriptFunctionDelegate<T> GetDelegate<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.MethodInfoStoreGeneric_GetDelegate_Public_ScriptFunctionDelegate_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptFunctionDelegate<T>>(intPtr3) : null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0002C98C File Offset: 0x0002AB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21429, XrefRangeEnd = 21430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUpvaluesCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_GetUpvaluesCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0002C9C8 File Offset: 0x0002ABC8
		[CallerCount(0)]
		public unsafe string GetUpvalueName(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_GetUpvalueName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0002CA0C File Offset: 0x0002AC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21430, XrefRangeEnd = 21434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetUpvalue(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_GetUpvalue_Public_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0002CA58 File Offset: 0x0002AC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21434, XrefRangeEnd = 21438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Closure.UpvaluesType GetUpvaluesType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr_GetUpvaluesType_Public_UpvaluesType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0002CA94 File Offset: 0x0002AC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21438, XrefRangeEnd = 21449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _GetDelegate_b__18_0(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.NativeMethodInfoPtr__GetDelegate_b__18_0_Private_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		[CallerCount(0)]
		public unsafe T _GetDelegate_b__19_0<T>(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Closure.MethodInfoStoreGeneric__GetDelegate_b__19_0_Private_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000370E File Offset: 0x0000190E
		public DynValue Call(params Object[] args)
		{
			return this.Call(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000371C File Offset: 0x0000191C
		public DynValue Call(params DynValue[] args)
		{
			return this.Call(new Il2CppReferenceArray<DynValue>(args));
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0000372A File Offset: 0x0000192A
		public Closure(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0002CB30 File Offset: 0x0002AD30
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00003733 File Offset: 0x00001933
		public unsafe int _EntryPointByteCodeLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Closure.NativeFieldInfoPtr__EntryPointByteCodeLocation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Closure.NativeFieldInfoPtr__EntryPointByteCodeLocation_k__BackingField)) = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0002CB58 File Offset: 0x0002AD58
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x0000374E File Offset: 0x0000194E
		public unsafe Script _OwnerScript_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Closure.NativeFieldInfoPtr__OwnerScript_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Closure.NativeFieldInfoPtr__OwnerScript_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0002CB88 File Offset: 0x0002AD88
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x0000376D File Offset: 0x0000196D
		public unsafe static ClosureContext emptyClosure
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Closure.NativeFieldInfoPtr_emptyClosure, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClosureContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Closure.NativeFieldInfoPtr_emptyClosure, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x0000377F File Offset: 0x0000197F
		public unsafe ClosureContext _ClosureContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Closure.NativeFieldInfoPtr__ClosureContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClosureContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Closure.NativeFieldInfoPtr__ClosureContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr__EntryPointByteCodeLocation_k__BackingField;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr__OwnerScript_k__BackingField;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_emptyClosure;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr__ClosureContext_k__BackingField;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_get_EntryPointByteCodeLocation_Public_get_Int32_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_set_EntryPointByteCodeLocation_Private_set_Void_Int32_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_get_ClosureContext_Internal_get_ClosureContext_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_set_ClosureContext_Private_set_Void_ClosureContext_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Script_Int32_Il2CppReferenceArray_1_SymbolRef_IEnumerable_1_DynValue_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Public_ScriptFunctionDelegate_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Public_ScriptFunctionDelegate_1_T_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_GetUpvaluesCount_Public_Int32_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_GetUpvalueName_Public_String_Int32_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_GetUpvalue_Public_DynValue_Int32_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_GetUpvaluesType_Public_UpvaluesType_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr__GetDelegate_b__18_0_Private_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr__GetDelegate_b__19_0_Private_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0200017E RID: 382
		public enum UpvaluesType
		{
			// Token: 0x04001519 RID: 5401
			None,
			// Token: 0x0400151A RID: 5402
			Environment,
			// Token: 0x0400151B RID: 5403
			Closure
		}

		// Token: 0x0200017F RID: 383
		private sealed class MethodInfoStoreGeneric_GetDelegate_Public_ScriptFunctionDelegate_1_T_0<T>
		{
			// Token: 0x0400151C RID: 5404
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Closure.NativeMethodInfoPtr_GetDelegate_Public_ScriptFunctionDelegate_1_T_0, Il2CppClassPointerStore<Closure>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000180 RID: 384
		private sealed class MethodInfoStoreGeneric__GetDelegate_b__19_0_Private_T_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x0400151D RID: 5405
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Closure.NativeMethodInfoPtr__GetDelegate_b__19_0_Private_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<Closure>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
