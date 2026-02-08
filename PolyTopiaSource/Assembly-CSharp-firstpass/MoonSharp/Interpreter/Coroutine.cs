using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002A RID: 42
	public class Coroutine : RefIdObject
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
		// Note: this type is marked as 'beforefieldinit'.
		static Coroutine()
		{
			Il2CppClassPointerStore<Coroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "Coroutine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coroutine>.NativeClassPtr);
			Coroutine.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "<Type>k__BackingField");
			Coroutine.NativeFieldInfoPtr_m_ClrCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "m_ClrCallback");
			Coroutine.NativeFieldInfoPtr_m_Processor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "m_Processor");
			Coroutine.NativeFieldInfoPtr__OwnerScript_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "<OwnerScript>k__BackingField");
			Coroutine.NativeMethodInfoPtr_get_Type_Public_get_CoroutineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664475);
			Coroutine.NativeMethodInfoPtr_set_Type_Private_set_Void_CoroutineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664476);
			Coroutine.NativeMethodInfoPtr_get_State_Public_get_CoroutineState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664491);
			Coroutine.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664493);
			Coroutine.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664494);
			Coroutine.NativeMethodInfoPtr_get_AutoYieldCounter_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664495);
			Coroutine.NativeMethodInfoPtr_set_AutoYieldCounter_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664496);
			Coroutine.NativeMethodInfoPtr__ctor_Internal_Void_CallbackFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664477);
			Coroutine.NativeMethodInfoPtr__ctor_Internal_Void_Processor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664478);
			Coroutine.NativeMethodInfoPtr_MarkClrCallbackAsDead_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664479);
			Coroutine.NativeMethodInfoPtr_Recycle_Internal_DynValue_Processor_Closure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664480);
			Coroutine.NativeMethodInfoPtr_AsTypedEnumerable_Public_IEnumerable_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664481);
			Coroutine.NativeMethodInfoPtr_AsEnumerable_Public_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664482);
			Coroutine.NativeMethodInfoPtr_AsEnumerable_Public_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664483);
			Coroutine.NativeMethodInfoPtr_AsUnityCoroutine_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664484);
			Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664485);
			Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_ScriptExecutionContext_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664486);
			Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664487);
			Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664488);
			Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664489);
			Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_ScriptExecutionContext_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664490);
			Coroutine.NativeMethodInfoPtr_GetStackTrace_Public_Il2CppReferenceArray_1_WatchItem_Int32_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, 100664492);
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0002CE18 File Offset: 0x0002B018
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0002CE54 File Offset: 0x0002B054
		public unsafe Coroutine.CoroutineType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_get_Type_Public_get_CoroutineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_set_Type_Private_set_Void_CoroutineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0002CE94 File Offset: 0x0002B094
		public unsafe CoroutineState State
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 21532, RefRangeEnd = 21537, XrefRangeStart = 21532, XrefRangeEnd = 21532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_get_State_Public_get_CoroutineState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CoroutineState>(intPtr3) : null;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0002CED4 File Offset: 0x0002B0D4
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0002CF14 File Offset: 0x0002B114
		public unsafe virtual Script OwnerScript
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21549, RefRangeEnd = 21556, XrefRangeStart = 21548, XrefRangeEnd = 21549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0002CF58 File Offset: 0x0002B158
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x0002CF94 File Offset: 0x0002B194
		public unsafe long AutoYieldCounter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_get_AutoYieldCounter_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21556, RefRangeEnd = 21557, XrefRangeStart = 21556, XrefRangeEnd = 21556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_set_AutoYieldCounter_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0002CFD4 File Offset: 0x0002B1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21557, XrefRangeEnd = 21562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine(CallbackFunction function)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coroutine>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr__ctor_Internal_Void_CallbackFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0002D020 File Offset: 0x0002B220
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21569, RefRangeEnd = 21572, XrefRangeStart = 21562, XrefRangeEnd = 21569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine(Processor proc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coroutine>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr__ctor_Internal_Void_Processor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0002D06C File Offset: 0x0002B26C
		[CallerCount(0)]
		public unsafe void MarkClrCallbackAsDead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_MarkClrCallbackAsDead_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0002D0A0 File Offset: 0x0002B2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21572, XrefRangeEnd = 21574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Recycle(Processor mainProcessor, Closure closure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mainProcessor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(closure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Recycle_Internal_DynValue_Processor_Closure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0002D104 File Offset: 0x0002B304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21580, RefRangeEnd = 21582, XrefRangeStart = 21574, XrefRangeEnd = 21580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<DynValue> AsTypedEnumerable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_AsTypedEnumerable_Public_IEnumerable_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DynValue>>(intPtr3) : null;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0002D144 File Offset: 0x0002B344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21582, XrefRangeEnd = 21588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Object> AsEnumerable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_AsEnumerable_Public_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0002D184 File Offset: 0x0002B384
		[CallerCount(0)]
		public unsafe IEnumerable<T> AsEnumerable<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.MethodInfoStoreGeneric_AsEnumerable_Public_IEnumerable_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0002D1C4 File Offset: 0x0002B3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21588, XrefRangeEnd = 21593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AsUnityCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_AsUnityCoroutine_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0002D204 File Offset: 0x0002B404
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 21602, RefRangeEnd = 21606, XrefRangeStart = 21593, XrefRangeEnd = 21602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Resume([Optional] Il2CppReferenceArray<DynValue> args)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0002D264 File Offset: 0x0002B464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21614, RefRangeEnd = 21616, XrefRangeStart = 21606, XrefRangeEnd = 21614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Resume(ScriptExecutionContext context, [Optional] Il2CppReferenceArray<DynValue> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<DynValue>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_ScriptExecutionContext_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0002D2D4 File Offset: 0x0002B4D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21620, RefRangeEnd = 21621, XrefRangeStart = 21616, XrefRangeEnd = 21620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0002D314 File Offset: 0x0002B514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21621, XrefRangeEnd = 21625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Resume(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_ScriptExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0002D364 File Offset: 0x0002B564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21650, RefRangeEnd = 21651, XrefRangeStart = 21625, XrefRangeEnd = 21650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Resume([Optional] Il2CppReferenceArray<Object> args)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0002D3C4 File Offset: 0x0002B5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21651, XrefRangeEnd = 21663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Resume(ScriptExecutionContext context, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_Resume_Public_DynValue_ScriptExecutionContext_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0002D434 File Offset: 0x0002B634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21672, RefRangeEnd = 21673, XrefRangeStart = 21663, XrefRangeEnd = 21672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<WatchItem> GetStackTrace(int skip, SourceRef entrySourceRef = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entrySourceRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine.NativeMethodInfoPtr_GetStackTrace_Public_Il2CppReferenceArray_1_WatchItem_Int32_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WatchItem>>(intPtr3) : null;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000379E File Offset: 0x0000199E
		public DynValue Resume(params DynValue[] args)
		{
			return this.Resume(new Il2CppReferenceArray<DynValue>(args));
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000037AC File Offset: 0x000019AC
		public DynValue Resume(ScriptExecutionContext context, params DynValue[] args)
		{
			return this.Resume(context, new Il2CppReferenceArray<DynValue>(args));
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000037BB File Offset: 0x000019BB
		public DynValue Resume(params Object[] args)
		{
			return this.Resume(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000037C9 File Offset: 0x000019C9
		public DynValue Resume(ScriptExecutionContext context, params Object[] args)
		{
			return this.Resume(context, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000037D8 File Offset: 0x000019D8
		public Coroutine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0002D494 File Offset: 0x0002B694
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x000037E1 File Offset: 0x000019E1
		public unsafe Coroutine.CoroutineType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0002D4BC File Offset: 0x0002B6BC
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x000037FC File Offset: 0x000019FC
		public unsafe CallbackFunction m_ClrCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_ClrCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_ClrCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0002D4EC File Offset: 0x0002B6EC
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x0000381B File Offset: 0x00001A1B
		public unsafe Processor m_Processor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_Processor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Processor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr_m_Processor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0002D51C File Offset: 0x0002B71C
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x0000383A File Offset: 0x00001A3A
		public unsafe Script _OwnerScript_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr__OwnerScript_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine.NativeFieldInfoPtr__OwnerScript_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_m_ClrCallback;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr_m_Processor;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr__OwnerScript_k__BackingField;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_CoroutineType_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_CoroutineType_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_CoroutineState_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnerScript_Private_set_Void_Script_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoYieldCounter_Public_get_Int64_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoYieldCounter_Public_set_Void_Int64_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CallbackFunction_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Processor_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_MarkClrCallbackAsDead_Internal_Void_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_Recycle_Internal_DynValue_Processor_Closure_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_AsTypedEnumerable_Public_IEnumerable_1_DynValue_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_AsEnumerable_Public_IEnumerable_1_Object_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_AsEnumerable_Public_IEnumerable_1_T_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_AsUnityCoroutine_Public_IEnumerator_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_DynValue_ScriptExecutionContext_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_DynValue_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_DynValue_ScriptExecutionContext_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_DynValue_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_DynValue_ScriptExecutionContext_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_GetStackTrace_Public_Il2CppReferenceArray_1_WatchItem_Int32_SourceRef_0;

		// Token: 0x02000181 RID: 385
		public enum CoroutineType
		{
			// Token: 0x0400151F RID: 5407
			Coroutine,
			// Token: 0x04001520 RID: 5408
			ClrCallback,
			// Token: 0x04001521 RID: 5409
			ClrCallbackDead,
			// Token: 0x04001522 RID: 5410
			Recycled
		}

		// Token: 0x02000182 RID: 386
		[ObfuscatedName("MoonSharp.Interpreter.Coroutine+<AsEnumerable>d__12")]
		public sealed class _AsEnumerable_d__12 : Object
		{
			// Token: 0x060019A8 RID: 6568 RVA: 0x0007ED64 File Offset: 0x0007CF64
			// Note: this type is marked as 'beforefieldinit'.
			static _AsEnumerable_d__12()
			{
				Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "<AsEnumerable>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr);
				Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, "<>1__state");
				Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, "<>2__current");
				Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, "<>l__initialThreadId");
				Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, "<>4__this");
				Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, "<>7__wrap1");
				Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, 100664501);
				Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, 100664503);
				Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, 100664497);
				Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, 100664498);
				Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, 100664499);
				Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, 100664500);
				Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, 100664502);
				Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, 100664504);
				Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr, 100664505);
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x060019A9 RID: 6569 RVA: 0x0007EEA8 File Offset: 0x0007D0A8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x060019AA RID: 6570 RVA: 0x0007EEE8 File Offset: 0x0007D0E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019AB RID: 6571 RVA: 0x0007EF28 File Offset: 0x0007D128
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 18122, RefRangeEnd = 18124, XrefRangeStart = 18122, XrefRangeEnd = 18124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AsEnumerable_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019AC RID: 6572 RVA: 0x0007EF70 File Offset: 0x0007D170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21449, XrefRangeEnd = 21454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019AD RID: 6573 RVA: 0x0007EFA4 File Offset: 0x0007D1A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21454, XrefRangeEnd = 21476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019AE RID: 6574 RVA: 0x0007EFE0 File Offset: 0x0007D1E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21476, XrefRangeEnd = 21479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019AF RID: 6575 RVA: 0x0007F014 File Offset: 0x0007D214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21479, XrefRangeEnd = 21484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019B0 RID: 6576 RVA: 0x0007F048 File Offset: 0x0007D248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21484, XrefRangeEnd = 21486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Object> System_Collections_Generic_IEnumerable_System_Object__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Object>>(intPtr3) : null;
			}

			// Token: 0x060019B1 RID: 6577 RVA: 0x0007F088 File Offset: 0x0007D288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060019B2 RID: 6578 RVA: 0x0000A23A File Offset: 0x0000843A
			public _AsEnumerable_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005DC RID: 1500
			// (get) Token: 0x060019B3 RID: 6579 RVA: 0x0007F0C8 File Offset: 0x0007D2C8
			// (set) Token: 0x060019B4 RID: 6580 RVA: 0x0000A243 File Offset: 0x00008443
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x060019B5 RID: 6581 RVA: 0x0007F0F0 File Offset: 0x0007D2F0
			// (set) Token: 0x060019B6 RID: 6582 RVA: 0x0000A25E File Offset: 0x0000845E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x060019B7 RID: 6583 RVA: 0x0007F120 File Offset: 0x0007D320
			// (set) Token: 0x060019B8 RID: 6584 RVA: 0x0000A27D File Offset: 0x0000847D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005DF RID: 1503
			// (get) Token: 0x060019B9 RID: 6585 RVA: 0x0007F148 File Offset: 0x0007D348
			// (set) Token: 0x060019BA RID: 6586 RVA: 0x0000A298 File Offset: 0x00008498
			public unsafe Coroutine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x060019BB RID: 6587 RVA: 0x0007F178 File Offset: 0x0007D378
			// (set) Token: 0x060019BC RID: 6588 RVA: 0x0000A2B7 File Offset: 0x000084B7
			public unsafe IEnumerator<DynValue> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<DynValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__12.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001523 RID: 5411
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001524 RID: 5412
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001525 RID: 5413
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001526 RID: 5414
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001527 RID: 5415
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001528 RID: 5416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001529 RID: 5417
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400152A RID: 5418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400152B RID: 5419
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400152C RID: 5420
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400152D RID: 5421
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400152E RID: 5422
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400152F RID: 5423
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0;

			// Token: 0x04001530 RID: 5424
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000183 RID: 387
		[ObfuscatedName("MoonSharp.Interpreter.Coroutine+<AsEnumerable>d__13`1")]
		public sealed class _AsEnumerable_d__13<T> : Object
		{
			// Token: 0x060019BD RID: 6589 RVA: 0x0007F1A8 File Offset: 0x0007D3A8
			// Note: this type is marked as 'beforefieldinit'.
			static _AsEnumerable_d__13()
			{
				Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "<AsEnumerable>d__13`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr);
				Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, "<>1__state");
				Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, "<>2__current");
				Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, "<>l__initialThreadId");
				Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, "<>4__this");
				Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, "<>7__wrap1");
				Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, 100664510);
				Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, 100664512);
				Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, 100664506);
				Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, 100664507);
				Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, 100664508);
				Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, 100664509);
				Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, 100664511);
				Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, 100664513);
				Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr, 100664514);
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x060019BE RID: 6590 RVA: 0x0007F328 File Offset: 0x0007D528
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x060019BF RID: 6591 RVA: 0x0007F364 File Offset: 0x0007D564
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019C0 RID: 6592 RVA: 0x0007F3A4 File Offset: 0x0007D5A4
			[CallerCount(0)]
			public unsafe _AsEnumerable_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coroutine._AsEnumerable_d__13<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019C1 RID: 6593 RVA: 0x0007F3EC File Offset: 0x0007D5EC
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019C2 RID: 6594 RVA: 0x0007F420 File Offset: 0x0007D620
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019C3 RID: 6595 RVA: 0x0007F45C File Offset: 0x0007D65C
			[CallerCount(0)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019C4 RID: 6596 RVA: 0x0007F490 File Offset: 0x0007D690
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019C5 RID: 6597 RVA: 0x0007F4C4 File Offset: 0x0007D6C4
			[CallerCount(0)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060019C6 RID: 6598 RVA: 0x0007F504 File Offset: 0x0007D704
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsEnumerable_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060019C7 RID: 6599 RVA: 0x0000A2D6 File Offset: 0x000084D6
			public _AsEnumerable_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0007F544 File Offset: 0x0007D744
			// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0000A2DF File Offset: 0x000084DF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x060019CA RID: 6602 RVA: 0x0007F56C File Offset: 0x0007D76C
			// (set) Token: 0x060019CB RID: 6603 RVA: 0x0007F594 File Offset: 0x0007D794
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170005E5 RID: 1509
			// (get) Token: 0x060019CC RID: 6604 RVA: 0x0007F63C File Offset: 0x0007D83C
			// (set) Token: 0x060019CD RID: 6605 RVA: 0x0000A2FA File Offset: 0x000084FA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x060019CE RID: 6606 RVA: 0x0007F664 File Offset: 0x0007D864
			// (set) Token: 0x060019CF RID: 6607 RVA: 0x0000A315 File Offset: 0x00008515
			public unsafe Coroutine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0007F694 File Offset: 0x0007D894
			// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0000A334 File Offset: 0x00008534
			public unsafe IEnumerator<DynValue> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<DynValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsEnumerable_d__13<T>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001531 RID: 5425
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001532 RID: 5426
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001533 RID: 5427
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001534 RID: 5428
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001535 RID: 5429
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001536 RID: 5430
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04001537 RID: 5431
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001538 RID: 5432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001539 RID: 5433
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400153A RID: 5434
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400153B RID: 5435
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400153C RID: 5436
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400153D RID: 5437
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x0400153E RID: 5438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000184 RID: 388
		[ObfuscatedName("MoonSharp.Interpreter.Coroutine+<AsTypedEnumerable>d__11")]
		public sealed class _AsTypedEnumerable_d__11 : Object
		{
			// Token: 0x060019D2 RID: 6610 RVA: 0x0007F6C4 File Offset: 0x0007D8C4
			// Note: this type is marked as 'beforefieldinit'.
			static _AsTypedEnumerable_d__11()
			{
				Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "<AsTypedEnumerable>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr);
				Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, "<>1__state");
				Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, "<>2__current");
				Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, "<>l__initialThreadId");
				Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, "<>4__this");
				Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_MoonSharp_Interpreter_DynValue__get_Current_Private_Virtual_Final_New_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, 100664518);
				Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, 100664520);
				Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, 100664515);
				Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, 100664516);
				Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, 100664517);
				Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, 100664519);
				Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_MoonSharp_Interpreter_DynValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, 100664521);
				Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr, 100664522);
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0007F7E0 File Offset: 0x0007D9E0
			public unsafe DynValue System.Collections.Generic.IEnumerator<MoonSharp.Interpreter.DynValue>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_MoonSharp_Interpreter_DynValue__get_Current_Private_Virtual_Final_New_get_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x060019D4 RID: 6612 RVA: 0x0007F820 File Offset: 0x0007DA20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019D5 RID: 6613 RVA: 0x0007F860 File Offset: 0x0007DA60
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 18122, RefRangeEnd = 18124, XrefRangeStart = 18122, XrefRangeEnd = 18124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AsTypedEnumerable_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coroutine._AsTypedEnumerable_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019D6 RID: 6614 RVA: 0x0007F8A8 File Offset: 0x0007DAA8
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019D7 RID: 6615 RVA: 0x0007F8DC File Offset: 0x0007DADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21486, XrefRangeEnd = 21492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019D8 RID: 6616 RVA: 0x0007F918 File Offset: 0x0007DB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21492, XrefRangeEnd = 21497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019D9 RID: 6617 RVA: 0x0007F94C File Offset: 0x0007DB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21497, XrefRangeEnd = 21499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<DynValue> System_Collections_Generic_IEnumerable_MoonSharp_Interpreter_DynValue__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_MoonSharp_Interpreter_DynValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<DynValue>>(intPtr3) : null;
			}

			// Token: 0x060019DA RID: 6618 RVA: 0x0007F98C File Offset: 0x0007DB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsTypedEnumerable_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060019DB RID: 6619 RVA: 0x0000A353 File Offset: 0x00008553
			public _AsTypedEnumerable_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005EA RID: 1514
			// (get) Token: 0x060019DC RID: 6620 RVA: 0x0007F9CC File Offset: 0x0007DBCC
			// (set) Token: 0x060019DD RID: 6621 RVA: 0x0000A35C File Offset: 0x0000855C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x060019DE RID: 6622 RVA: 0x0007F9F4 File Offset: 0x0007DBF4
			// (set) Token: 0x060019DF RID: 6623 RVA: 0x0000A377 File Offset: 0x00008577
			public unsafe DynValue __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0007FA24 File Offset: 0x0007DC24
			// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0000A396 File Offset: 0x00008596
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0007FA4C File Offset: 0x0007DC4C
			// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0000A3B1 File Offset: 0x000085B1
			public unsafe Coroutine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsTypedEnumerable_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400153F RID: 5439
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001540 RID: 5440
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001541 RID: 5441
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001542 RID: 5442
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001543 RID: 5443
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_MoonSharp_Interpreter_DynValue__get_Current_Private_Virtual_Final_New_get_DynValue_0;

			// Token: 0x04001544 RID: 5444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001545 RID: 5445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001546 RID: 5446
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001547 RID: 5447
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001548 RID: 5448
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001549 RID: 5449
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_MoonSharp_Interpreter_DynValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DynValue_0;

			// Token: 0x0400154A RID: 5450
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000185 RID: 389
		[ObfuscatedName("MoonSharp.Interpreter.Coroutine+<AsUnityCoroutine>d__14")]
		public sealed class _AsUnityCoroutine_d__14 : Object
		{
			// Token: 0x060019E4 RID: 6628 RVA: 0x0007FA7C File Offset: 0x0007DC7C
			// Note: this type is marked as 'beforefieldinit'.
			static _AsUnityCoroutine_d__14()
			{
				Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Coroutine>.NativeClassPtr, "<AsUnityCoroutine>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr);
				Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, "<>1__state");
				Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, "<>2__current");
				Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, "<>4__this");
				Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, "<>7__wrap1");
				Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, 100664527);
				Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, 100664529);
				Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, 100664523);
				Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, 100664524);
				Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, 100664525);
				Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, 100664526);
				Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr, 100664528);
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0007FB84 File Offset: 0x0007DD84
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x060019E6 RID: 6630 RVA: 0x0007FBC4 File Offset: 0x0007DDC4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019E7 RID: 6631 RVA: 0x0007FC04 File Offset: 0x0007DE04
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AsUnityCoroutine_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coroutine._AsUnityCoroutine_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019E8 RID: 6632 RVA: 0x0007FC4C File Offset: 0x0007DE4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21499, XrefRangeEnd = 21504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019E9 RID: 6633 RVA: 0x0007FC80 File Offset: 0x0007DE80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21504, XrefRangeEnd = 21524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019EA RID: 6634 RVA: 0x0007FCBC File Offset: 0x0007DEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21524, XrefRangeEnd = 21527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019EB RID: 6635 RVA: 0x0007FCF0 File Offset: 0x0007DEF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21527, XrefRangeEnd = 21532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coroutine._AsUnityCoroutine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019EC RID: 6636 RVA: 0x0000A3D0 File Offset: 0x000085D0
			public _AsUnityCoroutine_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x060019ED RID: 6637 RVA: 0x0007FD24 File Offset: 0x0007DF24
			// (set) Token: 0x060019EE RID: 6638 RVA: 0x0000A3D9 File Offset: 0x000085D9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x060019EF RID: 6639 RVA: 0x0007FD4C File Offset: 0x0007DF4C
			// (set) Token: 0x060019F0 RID: 6640 RVA: 0x0000A3F4 File Offset: 0x000085F4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x060019F1 RID: 6641 RVA: 0x0007FD7C File Offset: 0x0007DF7C
			// (set) Token: 0x060019F2 RID: 6642 RVA: 0x0000A413 File Offset: 0x00008613
			public unsafe Coroutine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0007FDAC File Offset: 0x0007DFAC
			// (set) Token: 0x060019F4 RID: 6644 RVA: 0x0000A432 File Offset: 0x00008632
			public unsafe IEnumerator<DynValue> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<DynValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coroutine._AsUnityCoroutine_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400154B RID: 5451
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400154C RID: 5452
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400154D RID: 5453
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400154E RID: 5454
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400154F RID: 5455
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001550 RID: 5456
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001551 RID: 5457
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001552 RID: 5458
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001553 RID: 5459
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001554 RID: 5460
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001555 RID: 5461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000186 RID: 390
		private sealed class MethodInfoStoreGeneric_AsEnumerable_Public_IEnumerable_1_T_0<T>
		{
			// Token: 0x04001556 RID: 5462
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Coroutine.NativeMethodInfoPtr_AsEnumerable_Public_IEnumerable_1_T_0, Il2CppClassPointerStore<Coroutine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
