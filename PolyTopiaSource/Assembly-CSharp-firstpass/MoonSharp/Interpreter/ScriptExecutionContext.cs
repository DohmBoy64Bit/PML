using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Interop.LuaStateInterop;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000045 RID: 69
	public class ScriptExecutionContext : Object
	{
		// Token: 0x06000838 RID: 2104 RVA: 0x00035BB8 File Offset: 0x00033DB8
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptExecutionContext()
		{
			Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "ScriptExecutionContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr);
			ScriptExecutionContext.NativeFieldInfoPtr_m_Processor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, "m_Processor");
			ScriptExecutionContext.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, "m_Callback");
			ScriptExecutionContext.NativeFieldInfoPtr__IsDynamicExecution_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, "<IsDynamicExecution>k__BackingField");
			ScriptExecutionContext.NativeFieldInfoPtr__CallingLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, "<CallingLocation>k__BackingField");
			ScriptExecutionContext.NativeMethodInfoPtr_get_IsDynamicExecution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664867);
			ScriptExecutionContext.NativeMethodInfoPtr_set_IsDynamicExecution_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664868);
			ScriptExecutionContext.NativeMethodInfoPtr_get_CallingLocation_Public_get_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664869);
			ScriptExecutionContext.NativeMethodInfoPtr_set_CallingLocation_Private_set_Void_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664870);
			ScriptExecutionContext.NativeMethodInfoPtr_get_AdditionalData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664871);
			ScriptExecutionContext.NativeMethodInfoPtr_set_AdditionalData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664872);
			ScriptExecutionContext.NativeMethodInfoPtr_get_CurrentGlobalEnv_Public_get_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664884);
			ScriptExecutionContext.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664886);
			ScriptExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_Processor_CallbackFunction_SourceRef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664866);
			ScriptExecutionContext.NativeMethodInfoPtr_GetMetatable_Public_Table_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664873);
			ScriptExecutionContext.NativeMethodInfoPtr_GetMetamethod_Public_DynValue_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664874);
			ScriptExecutionContext.NativeMethodInfoPtr_GetMetamethodTailCall_Public_DynValue_DynValue_String_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664875);
			ScriptExecutionContext.NativeMethodInfoPtr_GetBinaryMetamethod_Public_DynValue_DynValue_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664876);
			ScriptExecutionContext.NativeMethodInfoPtr_GetScript_Public_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664877);
			ScriptExecutionContext.NativeMethodInfoPtr_GetCallingCoroutine_Public_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664878);
			ScriptExecutionContext.NativeMethodInfoPtr_EmulateClassicCall_Public_DynValue_CallbackArguments_String_Func_2_LuaState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664879);
			ScriptExecutionContext.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664880);
			ScriptExecutionContext.NativeMethodInfoPtr_EvaluateSymbol_Public_DynValue_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664881);
			ScriptExecutionContext.NativeMethodInfoPtr_EvaluateSymbolByName_Public_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664882);
			ScriptExecutionContext.NativeMethodInfoPtr_FindSymbolByName_Public_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664883);
			ScriptExecutionContext.NativeMethodInfoPtr_PerformMessageDecorationBeforeUnwind_Public_Void_DynValue_ScriptRuntimeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr, 100664885);
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00035DDC File Offset: 0x00033FDC
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00035E18 File Offset: 0x00034018
		public unsafe bool IsDynamicExecution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_get_IsDynamicExecution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_set_IsDynamicExecution_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00035E58 File Offset: 0x00034058
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00035E98 File Offset: 0x00034098
		public unsafe SourceRef CallingLocation
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_get_CallingLocation_Public_get_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_set_CallingLocation_Private_set_Void_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00035EDC File Offset: 0x000340DC
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00035F1C File Offset: 0x0003411C
		public unsafe Object AdditionalData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 25752, RefRangeEnd = 25754, XrefRangeStart = 25752, XrefRangeEnd = 25752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_get_AdditionalData_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25754, XrefRangeEnd = 25761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_set_AdditionalData_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00035F60 File Offset: 0x00034160
		public unsafe Table CurrentGlobalEnv
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 25774, RefRangeEnd = 25777, XrefRangeStart = 25761, XrefRangeEnd = 25774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_get_CurrentGlobalEnv_Public_get_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00035FA0 File Offset: 0x000341A0
		public unsafe virtual Script OwnerScript
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 25777, RefRangeEnd = 25826, XrefRangeStart = 25777, XrefRangeEnd = 25777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00035FE0 File Offset: 0x000341E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 25830, RefRangeEnd = 25833, XrefRangeStart = 25826, XrefRangeEnd = 25830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptExecutionContext(Processor p, CallbackFunction callBackFunction, SourceRef sourceRef, bool isDynamic = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptExecutionContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBackFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceRef);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDynamic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_Processor_CallbackFunction_SourceRef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00036060 File Offset: 0x00034260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25833, XrefRangeEnd = 25835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Table GetMetatable(DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_GetMetatable_Public_Table_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000360B0 File Offset: 0x000342B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25837, RefRangeEnd = 25839, XrefRangeStart = 25835, XrefRangeEnd = 25837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetMetamethod(DynValue value, string metamethod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(metamethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_GetMetamethod_Public_DynValue_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00036114 File Offset: 0x00034314
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 25858, RefRangeEnd = 25861, XrefRangeStart = 25839, XrefRangeEnd = 25858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetMetamethodTailCall(DynValue value, string metamethod, [Optional] Il2CppReferenceArray<DynValue> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<DynValue>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(metamethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_GetMetamethodTailCall_Public_DynValue_DynValue_String_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00036198 File Offset: 0x00034398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25861, XrefRangeEnd = 25863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_GetBinaryMetamethod_Public_DynValue_DynValue_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0003620C File Offset: 0x0003440C
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 25777, RefRangeEnd = 25826, XrefRangeStart = 25777, XrefRangeEnd = 25826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Script GetScript()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_GetScript_Public_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0003624C File Offset: 0x0003444C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 25863, RefRangeEnd = 25867, XrefRangeStart = 25863, XrefRangeEnd = 25863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine GetCallingCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_GetCallingCoroutine_Public_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0003628C File Offset: 0x0003448C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 25873, RefRangeEnd = 25879, XrefRangeStart = 25867, XrefRangeEnd = 25873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue EmulateClassicCall(CallbackArguments args, string functionName, Func<LuaState, int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(functionName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_EmulateClassicCall_Public_DynValue_CallbackArguments_String_Func_2_LuaState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00036300 File Offset: 0x00034500
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25883, RefRangeEnd = 25885, XrefRangeStart = 25879, XrefRangeEnd = 25883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call(DynValue func, [Optional] Il2CppReferenceArray<DynValue> args)
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
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00036370 File Offset: 0x00034570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25885, XrefRangeEnd = 25893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue EvaluateSymbol(SymbolRef symref)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_EvaluateSymbol_Public_DynValue_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000363C0 File Offset: 0x000345C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25902, RefRangeEnd = 25903, XrefRangeStart = 25893, XrefRangeEnd = 25902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue EvaluateSymbolByName(string symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(symbol);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_EvaluateSymbolByName_Public_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00036410 File Offset: 0x00034610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25905, RefRangeEnd = 25906, XrefRangeStart = 25903, XrefRangeEnd = 25905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef FindSymbolByName(string symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(symbol);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_FindSymbolByName_Public_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00036460 File Offset: 0x00034660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25906, XrefRangeEnd = 25910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformMessageDecorationBeforeUnwind(DynValue messageHandler, ScriptRuntimeException exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageHandler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptExecutionContext.NativeMethodInfoPtr_PerformMessageDecorationBeforeUnwind_Public_Void_DynValue_ScriptRuntimeException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000040BF File Offset: 0x000022BF
		public DynValue GetMetamethodTailCall(DynValue value, string metamethod, params DynValue[] args)
		{
			return this.GetMetamethodTailCall(value, metamethod, new Il2CppReferenceArray<DynValue>(args));
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000040CF File Offset: 0x000022CF
		public DynValue Call(DynValue func, params DynValue[] args)
		{
			return this.Call(func, new Il2CppReferenceArray<DynValue>(args));
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000040DE File Offset: 0x000022DE
		public ScriptExecutionContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x000364B4 File Offset: 0x000346B4
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x000040E7 File Offset: 0x000022E7
		public unsafe Processor m_Processor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptExecutionContext.NativeFieldInfoPtr_m_Processor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Processor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptExecutionContext.NativeFieldInfoPtr_m_Processor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x000364E4 File Offset: 0x000346E4
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00004106 File Offset: 0x00002306
		public unsafe CallbackFunction m_Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptExecutionContext.NativeFieldInfoPtr_m_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptExecutionContext.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00036514 File Offset: 0x00034714
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00004125 File Offset: 0x00002325
		public unsafe bool _IsDynamicExecution_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptExecutionContext.NativeFieldInfoPtr__IsDynamicExecution_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptExecutionContext.NativeFieldInfoPtr__IsDynamicExecution_k__BackingField)) = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0003653C File Offset: 0x0003473C
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00004140 File Offset: 0x00002340
		public unsafe SourceRef _CallingLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptExecutionContext.NativeFieldInfoPtr__CallingLocation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptExecutionContext.NativeFieldInfoPtr__CallingLocation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_m_Processor;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr__IsDynamicExecution_k__BackingField;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr__CallingLocation_k__BackingField;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDynamicExecution_Public_get_Boolean_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDynamicExecution_Private_set_Void_Boolean_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_get_CallingLocation_Public_get_SourceRef_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_set_CallingLocation_Private_set_Void_SourceRef_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalData_Public_get_Object_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_set_AdditionalData_Public_set_Void_Object_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGlobalEnv_Public_get_Table_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerScript_Public_Virtual_Final_New_get_Script_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Processor_CallbackFunction_SourceRef_Boolean_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_GetMetatable_Public_Table_DynValue_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_GetMetamethod_Public_DynValue_DynValue_String_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_GetMetamethodTailCall_Public_DynValue_DynValue_String_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_GetBinaryMetamethod_Public_DynValue_DynValue_DynValue_String_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_GetScript_Public_Script_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_GetCallingCoroutine_Public_Coroutine_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_EmulateClassicCall_Public_DynValue_CallbackArguments_String_Func_2_LuaState_Int32_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateSymbol_Public_DynValue_SymbolRef_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateSymbolByName_Public_DynValue_String_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_FindSymbolByName_Public_SymbolRef_String_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_PerformMessageDecorationBeforeUnwind_Public_Void_DynValue_ScriptRuntimeException_0;
	}
}
