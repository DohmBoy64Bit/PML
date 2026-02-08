using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Diagnostics;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000057 RID: 87
	public class Script : Object
	{
		// Token: 0x060008B0 RID: 2224 RVA: 0x0003798C File Offset: 0x00035B8C
		// Note: this type is marked as 'beforefieldinit'.
		static Script()
		{
			Il2CppClassPointerStore<Script>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "Script");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script>.NativeClassPtr);
			Script.NativeFieldInfoPtr_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "VERSION");
			Script.NativeFieldInfoPtr_LUA_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "LUA_VERSION");
			Script.NativeFieldInfoPtr_m_MainProcessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "m_MainProcessor");
			Script.NativeFieldInfoPtr_m_ByteCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "m_ByteCode");
			Script.NativeFieldInfoPtr_m_Sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "m_Sources");
			Script.NativeFieldInfoPtr_m_GlobalTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "m_GlobalTable");
			Script.NativeFieldInfoPtr_m_Debugger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "m_Debugger");
			Script.NativeFieldInfoPtr_m_TypeMetatables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "m_TypeMetatables");
			Script.NativeFieldInfoPtr__DefaultOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "<DefaultOptions>k__BackingField");
			Script.NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "<Options>k__BackingField");
			Script.NativeFieldInfoPtr__GlobalOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "<GlobalOptions>k__BackingField");
			Script.NativeFieldInfoPtr__PerformanceStats_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "<PerformanceStats>k__BackingField");
			Script.NativeFieldInfoPtr__Registry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script>.NativeClassPtr, "<Registry>k__BackingField");
			Script.NativeMethodInfoPtr_get_DefaultOptions_Public_Static_get_ScriptOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664950);
			Script.NativeMethodInfoPtr_get_Options_Public_get_ScriptOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664951);
			Script.NativeMethodInfoPtr_set_Options_Private_set_Void_ScriptOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664952);
			Script.NativeMethodInfoPtr_get_GlobalOptions_Public_Static_get_ScriptGlobalOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664953);
			Script.NativeMethodInfoPtr_get_PerformanceStats_Public_get_PerformanceStatistics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664954);
			Script.NativeMethodInfoPtr_set_PerformanceStats_Private_set_Void_PerformanceStatistics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664955);
			Script.NativeMethodInfoPtr_get_Globals_Public_get_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664956);
			Script.NativeMethodInfoPtr_get_DebuggerEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664978);
			Script.NativeMethodInfoPtr_set_DebuggerEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664979);
			Script.NativeMethodInfoPtr_get_SourceCodeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664982);
			Script.NativeMethodInfoPtr_get_Registry_Public_get_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664990);
			Script.NativeMethodInfoPtr_set_Registry_Private_set_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664991);
			Script.NativeMethodInfoPtr_MoonSharp_Interpreter_IScriptPrivateResource_get_OwnerScript_Private_Virtual_Final_New_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664993);
			Script.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664948);
			Script.NativeMethodInfoPtr__ctor_Public_Void_CoreModules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664949);
			Script.NativeMethodInfoPtr_LoadFunction_Public_DynValue_String_Table_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664957);
			Script.NativeMethodInfoPtr_SignalByteCodeChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664958);
			Script.NativeMethodInfoPtr_SignalSourceCodeChange_Private_Void_SourceCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664959);
			Script.NativeMethodInfoPtr_LoadString_Public_DynValue_String_Table_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664960);
			Script.NativeMethodInfoPtr_LoadStream_Public_DynValue_Stream_Table_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664961);
			Script.NativeMethodInfoPtr_Dump_Public_Void_DynValue_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664962);
			Script.NativeMethodInfoPtr_LoadFile_Public_DynValue_String_Table_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664963);
			Script.NativeMethodInfoPtr_DoString_Public_DynValue_String_Table_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664964);
			Script.NativeMethodInfoPtr_DoStream_Public_DynValue_Stream_Table_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664965);
			Script.NativeMethodInfoPtr_DoFile_Public_DynValue_String_Table_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664966);
			Script.NativeMethodInfoPtr_RunFile_Public_Static_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664967);
			Script.NativeMethodInfoPtr_RunString_Public_Static_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664968);
			Script.NativeMethodInfoPtr_MakeClosure_Private_DynValue_Int32_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664969);
			Script.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664970);
			Script.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664971);
			Script.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664972);
			Script.NativeMethodInfoPtr_Call_Public_DynValue_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664973);
			Script.NativeMethodInfoPtr_Call_Public_DynValue_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664974);
			Script.NativeMethodInfoPtr_CreateCoroutine_Public_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664975);
			Script.NativeMethodInfoPtr_RecycleCoroutine_Public_DynValue_Coroutine_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664976);
			Script.NativeMethodInfoPtr_CreateCoroutine_Public_DynValue_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664977);
			Script.NativeMethodInfoPtr_AttachDebugger_Public_Void_IDebugger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664980);
			Script.NativeMethodInfoPtr_GetSourceCode_Public_SourceCode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664981);
			Script.NativeMethodInfoPtr_RequireModule_Public_DynValue_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664983);
			Script.NativeMethodInfoPtr_GetTypeMetatable_Public_Table_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664984);
			Script.NativeMethodInfoPtr_SetTypeMetatable_Public_Void_DataType_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664985);
			Script.NativeMethodInfoPtr_WarmUp_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664986);
			Script.NativeMethodInfoPtr_CreateDynamicExpression_Public_DynamicExpression_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664987);
			Script.NativeMethodInfoPtr_CreateConstantDynamicExpression_Public_DynamicExpression_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664988);
			Script.NativeMethodInfoPtr_CreateDynamicExecutionContext_Internal_ScriptExecutionContext_CallbackFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664989);
			Script.NativeMethodInfoPtr_GetBanner_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script>.NativeClassPtr, 100664992);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00037E58 File Offset: 0x00036058
		public unsafe static ScriptOptions DefaultOptions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26448, XrefRangeEnd = 26452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_get_DefaultOptions_Public_Static_get_ScriptOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptOptions>(intPtr3) : null;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00037E8C File Offset: 0x0003608C
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00037ECC File Offset: 0x000360CC
		public unsafe ScriptOptions Options
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_get_Options_Public_get_ScriptOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptOptions>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26453, XrefRangeEnd = 26454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_set_Options_Private_set_Void_ScriptOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00037F10 File Offset: 0x00036110
		public unsafe static ScriptGlobalOptions GlobalOptions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26454, XrefRangeEnd = 26458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_get_GlobalOptions_Public_Static_get_ScriptGlobalOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptGlobalOptions>(intPtr3) : null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00037F44 File Offset: 0x00036144
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00037F84 File Offset: 0x00036184
		public unsafe PerformanceStatistics PerformanceStats
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_get_PerformanceStats_Public_get_PerformanceStatistics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PerformanceStatistics>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_set_PerformanceStats_Private_set_Void_PerformanceStatistics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00037FC8 File Offset: 0x000361C8
		public unsafe Table Globals
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_get_Globals_Public_get_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00038008 File Offset: 0x00036208
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00038044 File Offset: 0x00036244
		public unsafe bool DebuggerEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26458, XrefRangeEnd = 26460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_get_DebuggerEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26460, XrefRangeEnd = 26462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_set_DebuggerEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00038084 File Offset: 0x00036284
		public unsafe int SourceCodeCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26462, XrefRangeEnd = 26463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_get_SourceCodeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x000380C0 File Offset: 0x000362C0
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00038100 File Offset: 0x00036300
		public unsafe Table Registry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_get_Registry_Public_get_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_set_Registry_Private_set_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00038144 File Offset: 0x00036344
		public unsafe virtual Script MoonSharp.Interpreter.IScriptPrivateResource.OwnerScript
		{
			[CallerCount(1334)]
			[CachedScanResults(RefRangeStart = 26463, RefRangeEnd = 27797, XrefRangeStart = 26463, XrefRangeEnd = 26463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_MoonSharp_Interpreter_IScriptPrivateResource_get_OwnerScript_Private_Virtual_Final_New_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00038184 File Offset: 0x00036384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27798, RefRangeEnd = 27799, XrefRangeStart = 27797, XrefRangeEnd = 27798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Script()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000381C0 File Offset: 0x000363C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 27855, RefRangeEnd = 27859, XrefRangeStart = 27799, XrefRangeEnd = 27855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Script(CoreModules coreModules)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coreModules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr__ctor_Public_Void_CoreModules_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0003820C File Offset: 0x0003640C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27883, RefRangeEnd = 27884, XrefRangeStart = 27859, XrefRangeEnd = 27883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue LoadFunction(string code, Table globalTable = null, string funcFriendlyName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(funcFriendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_LoadFunction_Public_DynValue_String_Table_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00038280 File Offset: 0x00036480
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 27908, RefRangeEnd = 27910, XrefRangeStart = 27884, XrefRangeEnd = 27908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SignalByteCodeChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_SignalByteCodeChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000382B4 File Offset: 0x000364B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 27913, RefRangeEnd = 27915, XrefRangeStart = 27910, XrefRangeEnd = 27913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SignalSourceCodeChange(SourceCode source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_SignalSourceCodeChange_Private_Void_SourceCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000382F8 File Offset: 0x000364F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 27938, RefRangeEnd = 27945, XrefRangeStart = 27915, XrefRangeEnd = 27938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue LoadString(string code, Table globalTable = null, string codeFriendlyName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(codeFriendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_LoadString_Public_DynValue_String_Table_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0003836C File Offset: 0x0003656C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 27965, RefRangeEnd = 27967, XrefRangeStart = 27945, XrefRangeEnd = 27965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue LoadStream(Stream stream, Table globalTable = null, string codeFriendlyName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(codeFriendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_LoadStream_Public_DynValue_Stream_Table_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000383E0 File Offset: 0x000365E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27983, RefRangeEnd = 27984, XrefRangeStart = 27967, XrefRangeEnd = 27983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump(DynValue function, Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_Dump_Public_Void_DynValue_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00038434 File Offset: 0x00036634
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 27998, RefRangeEnd = 28003, XrefRangeStart = 27984, XrefRangeEnd = 27998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue LoadFile(string filename, Table globalContext = null, string friendlyFilename = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyFilename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_LoadFile_Public_DynValue_String_Table_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000384A8 File Offset: 0x000366A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 28008, RefRangeEnd = 28010, XrefRangeStart = 28003, XrefRangeEnd = 28008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue DoString(string code, Table globalContext = null, string codeFriendlyName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(codeFriendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_DoString_Public_DynValue_String_Table_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0003851C File Offset: 0x0003671C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28010, XrefRangeEnd = 28015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue DoStream(Stream stream, Table globalContext = null, string codeFriendlyName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(codeFriendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_DoStream_Public_DynValue_Stream_Table_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00038590 File Offset: 0x00036790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28015, XrefRangeEnd = 28020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue DoFile(string filename, Table globalContext = null, string codeFriendlyName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(codeFriendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_DoFile_Public_DynValue_String_Table_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00038604 File Offset: 0x00036804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28020, XrefRangeEnd = 28030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue RunFile(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_RunFile_Public_Static_DynValue_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00038648 File Offset: 0x00036848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28030, XrefRangeEnd = 28040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue RunString(string code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_RunString_Public_Static_DynValue_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0003868C File Offset: 0x0003688C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28100, RefRangeEnd = 28101, XrefRangeStart = 28040, XrefRangeEnd = 28100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue MakeClosure(int address, Table envTable = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref address;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(envTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_MakeClosure_Private_DynValue_Int32_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000386EC File Offset: 0x000368EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 28105, RefRangeEnd = 28107, XrefRangeStart = 28101, XrefRangeEnd = 28105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call(DynValue function)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0003873C File Offset: 0x0003693C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 28125, RefRangeEnd = 28140, XrefRangeStart = 28107, XrefRangeEnd = 28125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call(DynValue function, [Optional] Il2CppReferenceArray<DynValue> args)
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
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000387AC File Offset: 0x000369AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28140, XrefRangeEnd = 28152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call(DynValue function, [Optional] Il2CppReferenceArray<Object> args)
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
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0003881C File Offset: 0x00036A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28152, XrefRangeEnd = 28160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call(Object function)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_Call_Public_DynValue_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0003886C File Offset: 0x00036A6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 28176, RefRangeEnd = 28181, XrefRangeStart = 28160, XrefRangeEnd = 28176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call(Object function, [Optional] Il2CppReferenceArray<Object> args)
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
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_Call_Public_DynValue_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000388DC File Offset: 0x00036ADC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 28207, RefRangeEnd = 28210, XrefRangeStart = 28181, XrefRangeEnd = 28207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue CreateCoroutine(DynValue function)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_CreateCoroutine_Public_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0003892C File Offset: 0x00036B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28210, XrefRangeEnd = 28237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue RecycleCoroutine(Coroutine coroutine, DynValue function)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_RecycleCoroutine_Public_DynValue_Coroutine_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00038990 File Offset: 0x00036B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28242, RefRangeEnd = 28243, XrefRangeStart = 28237, XrefRangeEnd = 28242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue CreateCoroutine(Object function)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_CreateCoroutine_Public_DynValue_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000389E0 File Offset: 0x00036BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28243, XrefRangeEnd = 28262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachDebugger(IDebugger debugger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(debugger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_AttachDebugger_Public_Void_IDebugger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00038A24 File Offset: 0x00036C24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 28266, RefRangeEnd = 28270, XrefRangeStart = 28262, XrefRangeEnd = 28266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceCode GetSourceCode(int sourceCodeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceCodeID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_GetSourceCode_Public_SourceCode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceCode>(intPtr3) : null;
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00038A70 File Offset: 0x00036C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28275, RefRangeEnd = 28276, XrefRangeStart = 28270, XrefRangeEnd = 28275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue RequireModule(string modname, Table globalContext = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(modname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_RequireModule_Public_DynValue_String_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00038AD4 File Offset: 0x00036CD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 28276, RefRangeEnd = 28279, XrefRangeStart = 28276, XrefRangeEnd = 28276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Table GetTypeMetatable(DataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_GetTypeMetatable_Public_Table_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00038B24 File Offset: 0x00036D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 28296, RefRangeEnd = 28298, XrefRangeStart = 28279, XrefRangeEnd = 28296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTypeMetatable(DataType type, Table metatable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metatable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_SetTypeMetatable_Public_Void_DataType_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00038B78 File Offset: 0x00036D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28298, XrefRangeEnd = 28305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WarmUp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_WarmUp_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00038BA0 File Offset: 0x00036DA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 28319, RefRangeEnd = 28323, XrefRangeStart = 28305, XrefRangeEnd = 28319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicExpression CreateDynamicExpression(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_CreateDynamicExpression_Public_DynamicExpression_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicExpression>(intPtr3) : null;
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00038BF0 File Offset: 0x00036DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28323, XrefRangeEnd = 28334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicExpression CreateConstantDynamicExpression(string code, DynValue constant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(constant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_CreateConstantDynamicExpression_Public_DynamicExpression_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicExpression>(intPtr3) : null;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00038C54 File Offset: 0x00036E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 28341, RefRangeEnd = 28343, XrefRangeStart = 28334, XrefRangeEnd = 28341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptExecutionContext CreateDynamicExecutionContext(CallbackFunction func = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_CreateDynamicExecutionContext_Internal_ScriptExecutionContext_CallbackFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptExecutionContext>(intPtr3) : null;
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00038CA4 File Offset: 0x00036EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28387, RefRangeEnd = 28388, XrefRangeStart = 28343, XrefRangeEnd = 28387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetBanner(string subproduct = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subproduct);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.NativeMethodInfoPtr_GetBanner_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00004382 File Offset: 0x00002582
		public DynValue Call(DynValue function, params DynValue[] args)
		{
			return this.Call(function, new Il2CppReferenceArray<DynValue>(args));
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00004391 File Offset: 0x00002591
		public DynValue Call(DynValue function, params Object[] args)
		{
			return this.Call(function, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000043A0 File Offset: 0x000025A0
		public DynValue Call(Object function, params Object[] args)
		{
			return this.Call(function, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000043AF File Offset: 0x000025AF
		public Script(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00038CE0 File Offset: 0x00036EE0
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x000043B8 File Offset: 0x000025B8
		public unsafe static string VERSION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Script.NativeFieldInfoPtr_VERSION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Script.NativeFieldInfoPtr_VERSION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00038D00 File Offset: 0x00036F00
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x000043CA File Offset: 0x000025CA
		public unsafe static string LUA_VERSION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Script.NativeFieldInfoPtr_LUA_VERSION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Script.NativeFieldInfoPtr_LUA_VERSION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00038D20 File Offset: 0x00036F20
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x000043DC File Offset: 0x000025DC
		public unsafe Processor m_MainProcessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_MainProcessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Processor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_MainProcessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00038D50 File Offset: 0x00036F50
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x000043FB File Offset: 0x000025FB
		public unsafe ByteCode m_ByteCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_ByteCode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ByteCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_ByteCode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00038D80 File Offset: 0x00036F80
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x0000441A File Offset: 0x0000261A
		public unsafe List<SourceCode> m_Sources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_Sources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SourceCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_Sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00038DB0 File Offset: 0x00036FB0
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00004439 File Offset: 0x00002639
		public unsafe Table m_GlobalTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_GlobalTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Table>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_GlobalTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00038DE0 File Offset: 0x00036FE0
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00004458 File Offset: 0x00002658
		public unsafe IDebugger m_Debugger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_Debugger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDebugger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_Debugger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00038E10 File Offset: 0x00037010
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00004477 File Offset: 0x00002677
		public unsafe Il2CppReferenceArray<Table> m_TypeMetatables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_TypeMetatables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Table>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr_m_TypeMetatables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00038E40 File Offset: 0x00037040
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00004496 File Offset: 0x00002696
		public unsafe static ScriptOptions _DefaultOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Script.NativeFieldInfoPtr__DefaultOptions_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptOptions>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Script.NativeFieldInfoPtr__DefaultOptions_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00038E68 File Offset: 0x00037068
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x000044A8 File Offset: 0x000026A8
		public unsafe ScriptOptions _Options_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr__Options_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr__Options_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00038E98 File Offset: 0x00037098
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x000044C7 File Offset: 0x000026C7
		public unsafe static ScriptGlobalOptions _GlobalOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Script.NativeFieldInfoPtr__GlobalOptions_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptGlobalOptions>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Script.NativeFieldInfoPtr__GlobalOptions_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00038EC0 File Offset: 0x000370C0
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x000044D9 File Offset: 0x000026D9
		public unsafe PerformanceStatistics _PerformanceStats_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr__PerformanceStats_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PerformanceStatistics>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr__PerformanceStats_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00038EF0 File Offset: 0x000370F0
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x000044F8 File Offset: 0x000026F8
		public unsafe Table _Registry_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr__Registry_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Table>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Script.NativeFieldInfoPtr__Registry_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_VERSION;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_LUA_VERSION;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_m_MainProcessor;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr_m_ByteCode;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_m_Sources;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalTable;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_m_Debugger;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_m_TypeMetatables;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr__DefaultOptions_k__BackingField;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeFieldInfoPtr__Options_k__BackingField;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeFieldInfoPtr__GlobalOptions_k__BackingField;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeFieldInfoPtr__PerformanceStats_k__BackingField;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeFieldInfoPtr__Registry_k__BackingField;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultOptions_Public_Static_get_ScriptOptions_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Public_get_ScriptOptions_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_set_Options_Private_set_Void_ScriptOptions_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalOptions_Public_Static_get_ScriptGlobalOptions_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_get_PerformanceStats_Public_get_PerformanceStatistics_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_set_PerformanceStats_Private_set_Void_PerformanceStatistics_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_get_Globals_Public_get_Table_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_get_DebuggerEnabled_Public_get_Boolean_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_set_DebuggerEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceCodeCount_Public_get_Int32_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_get_Registry_Public_get_Table_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_set_Registry_Private_set_Void_Table_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharp_Interpreter_IScriptPrivateResource_get_OwnerScript_Private_Virtual_Final_New_get_Script_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CoreModules_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_LoadFunction_Public_DynValue_String_Table_String_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_SignalByteCodeChange_Private_Void_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_SignalSourceCodeChange_Private_Void_SourceCode_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_LoadString_Public_DynValue_String_Table_String_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_LoadStream_Public_DynValue_Stream_Table_String_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_DynValue_Stream_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_LoadFile_Public_DynValue_String_Table_String_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_DoString_Public_DynValue_String_Table_String_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_DoStream_Public_DynValue_Stream_Table_String_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_DoFile_Public_DynValue_String_Table_String_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_RunFile_Public_Static_DynValue_String_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_RunString_Public_Static_DynValue_String_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_MakeClosure_Private_DynValue_Int32_Table_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_DynValue_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_Object_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_CreateCoroutine_Public_DynValue_DynValue_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_RecycleCoroutine_Public_DynValue_Coroutine_DynValue_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_CreateCoroutine_Public_DynValue_Object_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_AttachDebugger_Public_Void_IDebugger_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceCode_Public_SourceCode_Int32_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_RequireModule_Public_DynValue_String_Table_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeMetatable_Public_Table_DataType_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_SetTypeMetatable_Public_Void_DataType_Table_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_WarmUp_Public_Static_Void_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_CreateDynamicExpression_Public_DynamicExpression_String_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstantDynamicExpression_Public_DynamicExpression_String_DynValue_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_CreateDynamicExecutionContext_Internal_ScriptExecutionContext_CallbackFunction_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_GetBanner_Public_Static_String_String_0;

		// Token: 0x0200019E RID: 414
		[ObfuscatedName("MoonSharp.Interpreter.Script+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001A60 RID: 6752 RVA: 0x00081414 File Offset: 0x0007F614
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Script.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script.__c>.NativeClassPtr);
				Script.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script.__c>.NativeClassPtr, "<>9");
				Script.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script.__c>.NativeClassPtr, "<>9__27_0");
				Script.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script.__c>.NativeClassPtr, 100664996);
				Script.__c.NativeMethodInfoPtr__SignalByteCodeChange_b__27_0_Internal_String_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script.__c>.NativeClassPtr, 100664997);
				Script.__c.NativeMethodInfoPtr___cctor_b__68_0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script.__c>.NativeClassPtr, 100664998);
				Script.__c.NativeMethodInfoPtr___cctor_b__68_1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script.__c>.NativeClassPtr, 100664999);
			}

			// Token: 0x06001A61 RID: 6753 RVA: 0x000814B8 File Offset: 0x0007F6B8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A62 RID: 6754 RVA: 0x000814F4 File Offset: 0x0007F6F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SignalByteCodeChange_b__27_0(Instruction s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.__c.NativeMethodInfoPtr__SignalByteCodeChange_b__27_0_Internal_String_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001A63 RID: 6755 RVA: 0x0008153C File Offset: 0x0007F73C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26424, XrefRangeEnd = 26436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__68_0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.__c.NativeMethodInfoPtr___cctor_b__68_0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A64 RID: 6756 RVA: 0x00081580 File Offset: 0x0007F780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26436, XrefRangeEnd = 26448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __cctor_b__68_1(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Script.__c.NativeMethodInfoPtr___cctor_b__68_1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001A65 RID: 6757 RVA: 0x0000A66C File Offset: 0x0000886C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x06001A66 RID: 6758 RVA: 0x000815C8 File Offset: 0x0007F7C8
			// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0000A675 File Offset: 0x00008875
			public unsafe static Script.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Script.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Script.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x06001A68 RID: 6760 RVA: 0x000815F0 File Offset: 0x0007F7F0
			// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0000A687 File Offset: 0x00008887
			public unsafe static Func<Instruction, string> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Script.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Instruction, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Script.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001597 RID: 5527
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001598 RID: 5528
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04001599 RID: 5529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400159A RID: 5530
			private static readonly IntPtr NativeMethodInfoPtr__SignalByteCodeChange_b__27_0_Internal_String_Instruction_0;

			// Token: 0x0400159B RID: 5531
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__68_0_Internal_Void_String_0;

			// Token: 0x0400159C RID: 5532
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__68_1_Internal_String_String_0;
		}
	}
}
