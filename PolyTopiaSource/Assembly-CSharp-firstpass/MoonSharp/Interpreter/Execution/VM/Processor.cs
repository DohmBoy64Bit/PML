using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000ED RID: 237
	public sealed class Processor : Object
	{
		// Token: 0x060011C5 RID: 4549 RVA: 0x0005D910 File Offset: 0x0005BB10
		// Note: this type is marked as 'beforefieldinit'.
		static Processor()
		{
			Il2CppClassPointerStore<Processor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution.VM", "Processor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Processor>.NativeClassPtr);
			Processor.NativeFieldInfoPtr_STACK_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "STACK_SIZE");
			Processor.NativeFieldInfoPtr_m_RootChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_RootChunk");
			Processor.NativeFieldInfoPtr_m_ValueStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_ValueStack");
			Processor.NativeFieldInfoPtr_m_ExecutionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_ExecutionStack");
			Processor.NativeFieldInfoPtr_m_CoroutinesStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_CoroutinesStack");
			Processor.NativeFieldInfoPtr_m_GlobalTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_GlobalTable");
			Processor.NativeFieldInfoPtr_m_Script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_Script");
			Processor.NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_Parent");
			Processor.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_State");
			Processor.NativeFieldInfoPtr_m_CanYield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_CanYield");
			Processor.NativeFieldInfoPtr_m_SavedInstructionPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_SavedInstructionPtr");
			Processor.NativeFieldInfoPtr_m_Debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_Debug");
			Processor.NativeFieldInfoPtr_m_OwningThreadID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_OwningThreadID");
			Processor.NativeFieldInfoPtr_m_ExecutionNesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "m_ExecutionNesting");
			Processor.NativeFieldInfoPtr_DUMP_CHUNK_MAGIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "DUMP_CHUNK_MAGIC");
			Processor.NativeFieldInfoPtr_DUMP_CHUNK_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "DUMP_CHUNK_VERSION");
			Processor.NativeFieldInfoPtr__AssociatedCoroutine_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "<AssociatedCoroutine>k__BackingField");
			Processor.NativeFieldInfoPtr_YIELD_SPECIAL_TRAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "YIELD_SPECIAL_TRAP");
			Processor.NativeFieldInfoPtr_AutoYieldCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor>.NativeClassPtr, "AutoYieldCounter");
			Processor.NativeMethodInfoPtr_get_State_Public_get_CoroutineState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666443);
			Processor.NativeMethodInfoPtr_get_AssociatedCoroutine_Public_get_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666444);
			Processor.NativeMethodInfoPtr_set_AssociatedCoroutine_Public_set_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666445);
			Processor.NativeMethodInfoPtr_get_DebuggerEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666449);
			Processor.NativeMethodInfoPtr_set_DebuggerEnabled_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666450);
			Processor.NativeMethodInfoPtr__ctor_Public_Void_Script_Table_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666428);
			Processor.NativeMethodInfoPtr__ctor_Private_Void_Processor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666429);
			Processor.NativeMethodInfoPtr__ctor_Internal_Void_Processor_Processor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666430);
			Processor.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666431);
			Processor.NativeMethodInfoPtr_PushClrToScriptStackFrame_Private_Int32_CallStackItemFlags_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666432);
			Processor.NativeMethodInfoPtr_LeaveProcessor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666433);
			Processor.NativeMethodInfoPtr_GetThreadId_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666434);
			Processor.NativeMethodInfoPtr_EnterProcessor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666435);
			Processor.NativeMethodInfoPtr_GetCoroutineSuspendedLocation_Internal_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666436);
			Processor.NativeMethodInfoPtr_IsDumpStream_Internal_Static_Boolean_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666437);
			Processor.NativeMethodInfoPtr_Dump_Internal_Int32_Stream_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666438);
			Processor.NativeMethodInfoPtr_AddSymbolToMap_Private_Void_Dictionary_2_SymbolRef_Int32_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666439);
			Processor.NativeMethodInfoPtr_Undump_Internal_Int32_Stream_Int32_Table_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666440);
			Processor.NativeMethodInfoPtr_Coroutine_Create_Public_DynValue_Closure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666441);
			Processor.NativeMethodInfoPtr_Coroutine_Recycle_Public_DynValue_Processor_Closure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666442);
			Processor.NativeMethodInfoPtr_Coroutine_Resume_Public_DynValue_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666446);
			Processor.NativeMethodInfoPtr_FindMeta_Internal_Instruction_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666447);
			Processor.NativeMethodInfoPtr_AttachDebugger_Internal_Void_IDebugger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666448);
			Processor.NativeMethodInfoPtr_ListenDebugger_Private_Void_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666451);
			Processor.NativeMethodInfoPtr_ResetBreakPoints_Private_Void_DebuggerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666452);
			Processor.NativeMethodInfoPtr_ResetBreakPoints_Internal_HashSet_1_Int32_SourceCode_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666453);
			Processor.NativeMethodInfoPtr_ToggleBreakPoint_Private_Boolean_DebuggerAction_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666454);
			Processor.NativeMethodInfoPtr_RefreshDebugger_Private_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666455);
			Processor.NativeMethodInfoPtr_Debugger_RefreshThreads_Private_List_1_WatchItem_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666456);
			Processor.NativeMethodInfoPtr_Debugger_RefreshVStack_Private_List_1_WatchItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666457);
			Processor.NativeMethodInfoPtr_Debugger_RefreshWatches_Private_List_1_WatchItem_ScriptExecutionContext_List_1_DynamicExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666458);
			Processor.NativeMethodInfoPtr_Debugger_RefreshLocals_Private_List_1_WatchItem_ScriptExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666459);
			Processor.NativeMethodInfoPtr_Debugger_RefreshWatch_Private_WatchItem_ScriptExecutionContext_DynamicExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666460);
			Processor.NativeMethodInfoPtr_Debugger_GetCallStack_Internal_List_1_WatchItem_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666461);
			Processor.NativeMethodInfoPtr_GetCurrentSourceRef_Private_SourceRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666462);
			Processor.NativeMethodInfoPtr_FillDebugData_Private_Void_InterpreterException_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666463);
			Processor.NativeMethodInfoPtr_GetMetatable_Internal_Table_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666464);
			Processor.NativeMethodInfoPtr_GetBinaryMetamethod_Internal_DynValue_DynValue_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666465);
			Processor.NativeMethodInfoPtr_GetMetamethod_Internal_DynValue_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666466);
			Processor.NativeMethodInfoPtr_GetMetamethodRaw_Internal_DynValue_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666467);
			Processor.NativeMethodInfoPtr_GetScript_Internal_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666468);
			Processor.NativeMethodInfoPtr_Processing_Loop_Private_DynValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666469);
			Processor.NativeMethodInfoPtr_PerformMessageDecorationBeforeUnwind_Internal_String_DynValue_String_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666470);
			Processor.NativeMethodInfoPtr_AssignLocal_Private_Void_SymbolRef_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666471);
			Processor.NativeMethodInfoPtr_ExecStoreLcl_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666472);
			Processor.NativeMethodInfoPtr_ExecStoreUpv_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666473);
			Processor.NativeMethodInfoPtr_ExecSwap_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666474);
			Processor.NativeMethodInfoPtr_GetStoreValue_Private_DynValue_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666475);
			Processor.NativeMethodInfoPtr_ExecClosure_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666476);
			Processor.NativeMethodInfoPtr_GetUpvalueSymbol_Private_DynValue_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666477);
			Processor.NativeMethodInfoPtr_ExecMkTuple_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666478);
			Processor.NativeMethodInfoPtr_ExecToNum_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666479);
			Processor.NativeMethodInfoPtr_ExecIterUpd_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666480);
			Processor.NativeMethodInfoPtr_ExecExpTuple_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666481);
			Processor.NativeMethodInfoPtr_ExecIterPrep_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666482);
			Processor.NativeMethodInfoPtr_ExecJFor_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666483);
			Processor.NativeMethodInfoPtr_ExecIncr_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666484);
			Processor.NativeMethodInfoPtr_ExecCNot_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666485);
			Processor.NativeMethodInfoPtr_ExecNot_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666486);
			Processor.NativeMethodInfoPtr_ExecBeginFn_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666487);
			Processor.NativeMethodInfoPtr_PopToBasePointer_Private_CallStackItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666488);
			Processor.NativeMethodInfoPtr_PopExecStackAndCheckVStack_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666489);
			Processor.NativeMethodInfoPtr_CreateArgsListForFunctionCall_Private_IList_1_DynValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666490);
			Processor.NativeMethodInfoPtr_ExecArgs_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666491);
			Processor.NativeMethodInfoPtr_Internal_ExecCall_Private_Int32_Int32_Int32_CallbackFunction_CallbackFunction_Boolean_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666492);
			Processor.NativeMethodInfoPtr_PerformTCO_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666493);
			Processor.NativeMethodInfoPtr_ExecRet_Private_Int32_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666494);
			Processor.NativeMethodInfoPtr_Internal_CheckForTailRequests_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666495);
			Processor.NativeMethodInfoPtr_JumpBool_Private_Int32_Instruction_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666496);
			Processor.NativeMethodInfoPtr_ExecShortCircuitingOperator_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666497);
			Processor.NativeMethodInfoPtr_ExecAdd_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666498);
			Processor.NativeMethodInfoPtr_ExecSub_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666499);
			Processor.NativeMethodInfoPtr_ExecMul_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666500);
			Processor.NativeMethodInfoPtr_ExecMod_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666501);
			Processor.NativeMethodInfoPtr_ExecDiv_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666502);
			Processor.NativeMethodInfoPtr_ExecPower_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666503);
			Processor.NativeMethodInfoPtr_ExecNeg_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666504);
			Processor.NativeMethodInfoPtr_ExecEq_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666505);
			Processor.NativeMethodInfoPtr_ExecLess_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666506);
			Processor.NativeMethodInfoPtr_ExecLessEq_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666507);
			Processor.NativeMethodInfoPtr_ExecLen_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666508);
			Processor.NativeMethodInfoPtr_ExecConcat_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666509);
			Processor.NativeMethodInfoPtr_ExecTblInitI_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666510);
			Processor.NativeMethodInfoPtr_ExecTblInitN_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666511);
			Processor.NativeMethodInfoPtr_ExecIndexSet_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666512);
			Processor.NativeMethodInfoPtr_ExecIndex_Private_Int32_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666513);
			Processor.NativeMethodInfoPtr_ClearBlockData_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666514);
			Processor.NativeMethodInfoPtr_GetGenericSymbol_Public_DynValue_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666515);
			Processor.NativeMethodInfoPtr_GetGlobalSymbol_Private_DynValue_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666516);
			Processor.NativeMethodInfoPtr_SetGlobalSymbol_Private_Void_DynValue_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666517);
			Processor.NativeMethodInfoPtr_AssignGenericSymbol_Public_Void_SymbolRef_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666518);
			Processor.NativeMethodInfoPtr_GetTopNonClrFunction_Private_CallStackItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666519);
			Processor.NativeMethodInfoPtr_FindSymbolByName_Public_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666520);
			Processor.NativeMethodInfoPtr_Internal_AdjustTuple_Private_Il2CppReferenceArray_1_DynValue_IList_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666521);
			Processor.NativeMethodInfoPtr_Internal_InvokeUnaryMetaMethod_Private_Int32_DynValue_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666522);
			Processor.NativeMethodInfoPtr_Internal_InvokeBinaryMetaMethod_Private_Int32_DynValue_DynValue_String_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666523);
			Processor.NativeMethodInfoPtr_StackTopToArray_Private_Il2CppReferenceArray_1_DynValue_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666524);
			Processor.NativeMethodInfoPtr_StackTopToArrayReverse_Private_Il2CppReferenceArray_1_DynValue_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666525);
			Processor.NativeMethodInfoPtr__ExecClosure_b__71_0_Private_DynValue_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor>.NativeClassPtr, 100666526);
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0005E278 File Offset: 0x0005C478
		public unsafe CoroutineState State
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 28415, RefRangeEnd = 28418, XrefRangeStart = 28415, XrefRangeEnd = 28418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_get_State_Public_get_CoroutineState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CoroutineState>(intPtr3) : null;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x0005E2B8 File Offset: 0x0005C4B8
		// (set) Token: 0x060011C8 RID: 4552 RVA: 0x0005E2F8 File Offset: 0x0005C4F8
		public unsafe Coroutine AssociatedCoroutine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_get_AssociatedCoroutine_Public_get_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43937, XrefRangeEnd = 43938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_set_AssociatedCoroutine_Public_set_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x0005E33C File Offset: 0x0005C53C
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x0005E378 File Offset: 0x0005C578
		public unsafe bool DebuggerEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43938, RefRangeEnd = 43939, XrefRangeStart = 43938, XrefRangeEnd = 43938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_get_DebuggerEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 43939, RefRangeEnd = 43941, XrefRangeStart = 43939, XrefRangeEnd = 43939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_set_DebuggerEnabled_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0005E3B8 File Offset: 0x0005C5B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43979, RefRangeEnd = 43980, XrefRangeStart = 43941, XrefRangeEnd = 43979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Processor(Script script, Table globalContext, ByteCode byteCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Processor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byteCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr__ctor_Public_Void_Script_Table_ByteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0005E428 File Offset: 0x0005C628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43980, XrefRangeEnd = 44000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Processor(Processor parentProcessor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Processor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentProcessor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr__ctor_Private_Void_Processor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0005E474 File Offset: 0x0005C674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44000, XrefRangeEnd = 44008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Processor(Processor parentProcessor, Processor recycleProcessor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Processor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentProcessor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recycleProcessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr__ctor_Internal_Void_Processor_Processor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0005E4D4 File Offset: 0x0005C6D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 44017, RefRangeEnd = 44020, XrefRangeStart = 44008, XrefRangeEnd = 44017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Call(DynValue function, Il2CppReferenceArray<DynValue> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0005E538 File Offset: 0x0005C738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44051, RefRangeEnd = 44052, XrefRangeStart = 44020, XrefRangeEnd = 44051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PushClrToScriptStackFrame(CallStackItemFlags flags, DynValue function, Il2CppReferenceArray<DynValue> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flags);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_PushClrToScriptStackFrame_Private_Int32_CallStackItemFlags_DynValue_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0005E5AC File Offset: 0x0005C7AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 44059, RefRangeEnd = 44063, XrefRangeStart = 44052, XrefRangeEnd = 44059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveProcessor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_LeaveProcessor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0005E5E0 File Offset: 0x0005C7E0
		[CallerCount(131)]
		[CachedScanResults(RefRangeStart = 44066, RefRangeEnd = 44197, XrefRangeStart = 44063, XrefRangeEnd = 44066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetThreadId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetThreadId_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0005E61C File Offset: 0x0005C81C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44202, RefRangeEnd = 44203, XrefRangeStart = 44197, XrefRangeEnd = 44202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterProcessor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_EnterProcessor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0005E650 File Offset: 0x0005C850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44204, RefRangeEnd = 44205, XrefRangeStart = 44203, XrefRangeEnd = 44204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceRef GetCoroutineSuspendedLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetCoroutineSuspendedLocation_Internal_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0005E690 File Offset: 0x0005C890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44213, RefRangeEnd = 44214, XrefRangeStart = 44205, XrefRangeEnd = 44213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDumpStream(Stream stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_IsDumpStream_Internal_Static_Boolean_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0005E6D4 File Offset: 0x0005C8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44291, RefRangeEnd = 44292, XrefRangeStart = 44214, XrefRangeEnd = 44291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Dump(Stream stream, int baseAddress, bool hasUpvalues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseAddress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUpvalues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Dump_Internal_Int32_Stream_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0005E740 File Offset: 0x0005C940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 44301, RefRangeEnd = 44304, XrefRangeStart = 44292, XrefRangeEnd = 44301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSymbolToMap(Dictionary<SymbolRef, int> symbolMap, SymbolRef s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbolMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_AddSymbolToMap_Private_Void_Dictionary_2_SymbolRef_Int32_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0005E794 File Offset: 0x0005C994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44304, XrefRangeEnd = 44339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Undump(Stream stream, int sourceID, Table envTable, out bool hasUpvalues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(envTable);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasUpvalues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Undump_Internal_Int32_Stream_Int32_Table_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0005E810 File Offset: 0x0005CA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44339, XrefRangeEnd = 44375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Coroutine_Create(Closure closure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(closure);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Coroutine_Create_Public_DynValue_Closure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0005E860 File Offset: 0x0005CA60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44405, RefRangeEnd = 44407, XrefRangeStart = 44375, XrefRangeEnd = 44405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Coroutine_Recycle(Processor mainProcessor, Closure closure)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Coroutine_Recycle_Public_DynValue_Processor_Closure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0005E8C4 File Offset: 0x0005CAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44431, RefRangeEnd = 44433, XrefRangeStart = 44407, XrefRangeEnd = 44431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Coroutine_Resume(Il2CppReferenceArray<DynValue> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Coroutine_Resume_Public_DynValue_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0005E914 File Offset: 0x0005CB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44439, RefRangeEnd = 44440, XrefRangeStart = 44433, XrefRangeEnd = 44439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction FindMeta(ref int baseAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &baseAddress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_FindMeta_Internal_Instruction_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0005E960 File Offset: 0x0005CB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44452, RefRangeEnd = 44453, XrefRangeStart = 44440, XrefRangeEnd = 44452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachDebugger(IDebugger debugger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(debugger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_AttachDebugger_Internal_Void_IDebugger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0005E9A4 File Offset: 0x0005CBA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44488, RefRangeEnd = 44489, XrefRangeStart = 44453, XrefRangeEnd = 44488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListenDebugger(Instruction instr, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ListenDebugger_Private_Void_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0005E9F4 File Offset: 0x0005CBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44489, XrefRangeEnd = 44498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBreakPoints(DebuggerAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ResetBreakPoints_Private_Void_DebuggerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0005EA38 File Offset: 0x0005CC38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 44524, RefRangeEnd = 44527, XrefRangeStart = 44498, XrefRangeEnd = 44524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lines);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ResetBreakPoints_Internal_HashSet_1_Int32_SourceCode_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr3) : null;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0005EA9C File Offset: 0x0005CC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44566, RefRangeEnd = 44567, XrefRangeStart = 44527, XrefRangeEnd = 44566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ToggleBreakPoint(DebuggerAction action, Nullable<bool> state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ToggleBreakPoint_Private_Boolean_DebuggerAction_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0005EAFC File Offset: 0x0005CCFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44631, RefRangeEnd = 44633, XrefRangeStart = 44567, XrefRangeEnd = 44631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDebugger(bool hard, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hard;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_RefreshDebugger_Private_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0005EB48 File Offset: 0x0005CD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44633, XrefRangeEnd = 44655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WatchItem> Debugger_RefreshThreads(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Debugger_RefreshThreads_Private_List_1_WatchItem_ScriptExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WatchItem>>(intPtr3) : null;
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0005EB98 File Offset: 0x0005CD98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44680, RefRangeEnd = 44681, XrefRangeStart = 44655, XrefRangeEnd = 44680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WatchItem> Debugger_RefreshVStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Debugger_RefreshVStack_Private_List_1_WatchItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WatchItem>>(intPtr3) : null;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0005EBD8 File Offset: 0x0005CDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44681, XrefRangeEnd = 44700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WatchItem> Debugger_RefreshWatches(ScriptExecutionContext context, List<DynamicExpression> watchList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(watchList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Debugger_RefreshWatches_Private_List_1_WatchItem_ScriptExecutionContext_List_1_DynamicExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WatchItem>>(intPtr3) : null;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0005EC3C File Offset: 0x0005CE3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44725, RefRangeEnd = 44726, XrefRangeStart = 44700, XrefRangeEnd = 44725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WatchItem> Debugger_RefreshLocals(ScriptExecutionContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Debugger_RefreshLocals_Private_List_1_WatchItem_ScriptExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WatchItem>>(intPtr3) : null;
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0005EC8C File Offset: 0x0005CE8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44745, RefRangeEnd = 44746, XrefRangeStart = 44726, XrefRangeEnd = 44745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WatchItem Debugger_RefreshWatch(ScriptExecutionContext context, DynamicExpression dynExpr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dynExpr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Debugger_RefreshWatch_Private_WatchItem_ScriptExecutionContext_DynamicExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WatchItem>(intPtr3) : null;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0005ECF0 File Offset: 0x0005CEF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 44782, RefRangeEnd = 44785, XrefRangeStart = 44746, XrefRangeEnd = 44782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WatchItem> Debugger_GetCallStack(SourceRef startingRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startingRef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Debugger_GetCallStack_Internal_List_1_WatchItem_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WatchItem>>(intPtr3) : null;
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0005ED40 File Offset: 0x0005CF40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 44789, RefRangeEnd = 44792, XrefRangeStart = 44785, XrefRangeEnd = 44789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SourceRef GetCurrentSourceRef(int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instructionPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetCurrentSourceRef_Private_SourceRef_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0005ED8C File Offset: 0x0005CF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44792, XrefRangeEnd = 44798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillDebugData(InterpreterException ex, int ip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_FillDebugData_Private_Void_InterpreterException_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0005EDDC File Offset: 0x0005CFDC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 44799, RefRangeEnd = 44807, XrefRangeStart = 44798, XrefRangeEnd = 44799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Table GetMetatable(DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetMetatable_Internal_Table_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0005EE2C File Offset: 0x0005D02C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 44823, RefRangeEnd = 44825, XrefRangeStart = 44807, XrefRangeEnd = 44823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetBinaryMetamethod_Internal_DynValue_DynValue_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0005EEA0 File Offset: 0x0005D0A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 44833, RefRangeEnd = 44840, XrefRangeStart = 44825, XrefRangeEnd = 44833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetMetamethod_Internal_DynValue_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0005EF04 File Offset: 0x0005D104
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 44843, RefRangeEnd = 44849, XrefRangeStart = 44840, XrefRangeEnd = 44843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetMetamethodRaw(DynValue value, string metamethod)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetMetamethodRaw_Internal_DynValue_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0005EF68 File Offset: 0x0005D168
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Script GetScript()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetScript_Internal_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0005EFA8 File Offset: 0x0005D1A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44921, RefRangeEnd = 44922, XrefRangeStart = 44849, XrefRangeEnd = 44921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Processing_Loop(int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instructionPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Processing_Loop_Private_DynValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0005EFF4 File Offset: 0x0005D1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44943, RefRangeEnd = 44944, XrefRangeStart = 44922, XrefRangeEnd = 44943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PerformMessageDecorationBeforeUnwind(DynValue messageHandler, string decoratedMessage, SourceRef sourceRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageHandler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(decoratedMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_PerformMessageDecorationBeforeUnwind_Internal_String_DynValue_String_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0005F060 File Offset: 0x0005D260
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 44955, RefRangeEnd = 44958, XrefRangeStart = 44944, XrefRangeEnd = 44955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignLocal(SymbolRef symref, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symref);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_AssignLocal_Private_Void_SymbolRef_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0005F0B4 File Offset: 0x0005D2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44958, XrefRangeEnd = 44961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecStoreLcl(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecStoreLcl_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44977, RefRangeEnd = 44978, XrefRangeStart = 44961, XrefRangeEnd = 44977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecStoreUpv(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecStoreUpv_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0005F13C File Offset: 0x0005D33C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44989, RefRangeEnd = 44990, XrefRangeStart = 44978, XrefRangeEnd = 44989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecSwap(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecSwap_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0005F180 File Offset: 0x0005D380
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 44997, RefRangeEnd = 45001, XrefRangeStart = 44990, XrefRangeEnd = 44997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetStoreValue(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetStoreValue_Private_DynValue_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0005F1D0 File Offset: 0x0005D3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45025, RefRangeEnd = 45026, XrefRangeStart = 45001, XrefRangeEnd = 45025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecClosure(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecClosure_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0005F214 File Offset: 0x0005D414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45026, XrefRangeEnd = 45034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetUpvalueSymbol(SymbolRef s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetUpvalueSymbol_Private_DynValue_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0005F264 File Offset: 0x0005D464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45034, XrefRangeEnd = 45053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecMkTuple(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecMkTuple_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0005F2A8 File Offset: 0x0005D4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45053, XrefRangeEnd = 45069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecToNum(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecToNum_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0005F2EC File Offset: 0x0005D4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45069, XrefRangeEnd = 45078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecIterUpd(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecIterUpd_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0005F330 File Offset: 0x0005D530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45078, XrefRangeEnd = 45084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecExpTuple(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecExpTuple_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0005F374 File Offset: 0x0005D574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45084, XrefRangeEnd = 45186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecIterPrep(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecIterPrep_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0005F3B8 File Offset: 0x0005D5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45186, XrefRangeEnd = 45194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecJFor(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecJFor_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0005F414 File Offset: 0x0005D614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45194, XrefRangeEnd = 45208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecIncr(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecIncr_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0005F458 File Offset: 0x0005D658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45208, XrefRangeEnd = 45235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecCNot(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecCNot_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0005F49C File Offset: 0x0005D69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45235, XrefRangeEnd = 45248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecNot(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecNot_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0005F4E0 File Offset: 0x0005D6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45260, RefRangeEnd = 45261, XrefRangeStart = 45248, XrefRangeEnd = 45260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecBeginFn(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecBeginFn_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0005F524 File Offset: 0x0005D724
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45267, RefRangeEnd = 45269, XrefRangeStart = 45261, XrefRangeEnd = 45267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallStackItem PopToBasePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_PopToBasePointer_Private_CallStackItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallStackItem>(intPtr3) : null;
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0005F564 File Offset: 0x0005D764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45269, XrefRangeEnd = 45272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PopExecStackAndCheckVStack(int vstackguard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vstackguard;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_PopExecStackAndCheckVStack_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0005F5B0 File Offset: 0x0005D7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45300, RefRangeEnd = 45301, XrefRangeStart = 45272, XrefRangeEnd = 45300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<DynValue> CreateArgsListForFunctionCall(int numargs, int offsFromTop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numargs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsFromTop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_CreateArgsListForFunctionCall_Private_IList_1_DynValue_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DynValue>>(intPtr3) : null;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0005F60C File Offset: 0x0005D80C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45338, RefRangeEnd = 45339, XrefRangeStart = 45301, XrefRangeEnd = 45338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecArgs(Instruction I)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(I);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecArgs_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0005F650 File Offset: 0x0005D850
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45375, RefRangeEnd = 45378, XrefRangeStart = 45339, XrefRangeEnd = 45375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_ExecCall(int argsCount, int instructionPtr, CallbackFunction handler = null, CallbackFunction continuation = null, bool thisCall = false, string debugText = null, DynValue unwindHandler = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argsCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thisCall;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugText);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unwindHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Internal_ExecCall_Private_Int32_Int32_Int32_CallbackFunction_CallbackFunction_Boolean_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0005F700 File Offset: 0x0005D900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45399, RefRangeEnd = 45400, XrefRangeStart = 45378, XrefRangeEnd = 45399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PerformTCO(int instructionPtr, int argsCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instructionPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_PerformTCO_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0005F758 File Offset: 0x0005D958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45441, RefRangeEnd = 45442, XrefRangeStart = 45400, XrefRangeEnd = 45441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecRet(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecRet_Private_Int32_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0005F7A8 File Offset: 0x0005D9A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45447, RefRangeEnd = 45448, XrefRangeStart = 45442, XrefRangeEnd = 45447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_CheckForTailRequests(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Internal_CheckForTailRequests_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0005F804 File Offset: 0x0005DA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45448, XrefRangeEnd = 45453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int JumpBool(Instruction i, bool expectedValueForJump, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectedValueForJump;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_JumpBool_Private_Int32_Instruction_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0005F870 File Offset: 0x0005DA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45453, XrefRangeEnd = 45461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecShortCircuitingOperator(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecShortCircuitingOperator_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0005F8CC File Offset: 0x0005DACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45461, XrefRangeEnd = 45484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecAdd(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecAdd_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0005F928 File Offset: 0x0005DB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45484, XrefRangeEnd = 45507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecSub(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecSub_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0005F984 File Offset: 0x0005DB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45507, XrefRangeEnd = 45530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecMul(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecMul_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0005F9E0 File Offset: 0x0005DBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45530, XrefRangeEnd = 45559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecMod(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecMod_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0005FA3C File Offset: 0x0005DC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45559, XrefRangeEnd = 45582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecDiv(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecDiv_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0005FA98 File Offset: 0x0005DC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45582, XrefRangeEnd = 45609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecPower(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecPower_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0005FAF4 File Offset: 0x0005DCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45609, XrefRangeEnd = 45629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecNeg(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecNeg_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0005FB50 File Offset: 0x0005DD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45629, XrefRangeEnd = 45657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecEq(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecEq_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45657, XrefRangeEnd = 45679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecLess(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecLess_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0005FC08 File Offset: 0x0005DE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45679, XrefRangeEnd = 45710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecLessEq(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecLessEq_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0005FC64 File Offset: 0x0005DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45710, XrefRangeEnd = 45728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecLen(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecLen_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0005FCC0 File Offset: 0x0005DEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45728, XrefRangeEnd = 45746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecConcat(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecConcat_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0005FD1C File Offset: 0x0005DF1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45766, RefRangeEnd = 45767, XrefRangeStart = 45746, XrefRangeEnd = 45766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecTblInitI(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecTblInitI_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0005FD60 File Offset: 0x0005DF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45790, RefRangeEnd = 45791, XrefRangeStart = 45767, XrefRangeEnd = 45790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecTblInitN(Instruction i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecTblInitN_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0005FDA4 File Offset: 0x0005DFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45822, RefRangeEnd = 45823, XrefRangeStart = 45791, XrefRangeEnd = 45822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecIndexSet(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecIndexSet_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0005FE00 File Offset: 0x0005E000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45857, RefRangeEnd = 45858, XrefRangeStart = 45823, XrefRangeEnd = 45857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExecIndex(Instruction i, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ExecIndex_Private_Int32_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0005FE5C File Offset: 0x0005E05C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45862, RefRangeEnd = 45863, XrefRangeStart = 45858, XrefRangeEnd = 45862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBlockData(Instruction I)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(I);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_ClearBlockData_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0005FEA0 File Offset: 0x0005E0A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 45875, RefRangeEnd = 45880, XrefRangeStart = 45863, XrefRangeEnd = 45875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetGenericSymbol(SymbolRef symref)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetGenericSymbol_Public_DynValue_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0005FEF0 File Offset: 0x0005E0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45880, XrefRangeEnd = 45894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetGlobalSymbol(DynValue dynValue, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetGlobalSymbol_Private_DynValue_DynValue_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0005FF54 File Offset: 0x0005E154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45894, XrefRangeEnd = 45915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalSymbol(DynValue dynValue, string name, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_SetGlobalSymbol_Private_Void_DynValue_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0005FFBC File Offset: 0x0005E1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45915, XrefRangeEnd = 45929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignGenericSymbol(SymbolRef symref, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symref);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_AssignGenericSymbol_Public_Void_SymbolRef_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00060010 File Offset: 0x0005E210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45934, RefRangeEnd = 45936, XrefRangeStart = 45929, XrefRangeEnd = 45934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallStackItem GetTopNonClrFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_GetTopNonClrFunction_Private_CallStackItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallStackItem>(intPtr3) : null;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00060050 File Offset: 0x0005E250
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45947, RefRangeEnd = 45950, XrefRangeStart = 45936, XrefRangeEnd = 45947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef FindSymbolByName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_FindSymbolByName_Public_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x000600A0 File Offset: 0x0005E2A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45972, RefRangeEnd = 45975, XrefRangeStart = 45950, XrefRangeEnd = 45972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DynValue> Internal_AdjustTuple(IList<DynValue> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Internal_AdjustTuple_Private_Il2CppReferenceArray_1_DynValue_IList_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000600F0 File Offset: 0x0005E2F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45989, RefRangeEnd = 45991, XrefRangeStart = 45975, XrefRangeEnd = 45989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_InvokeUnaryMetaMethod(DynValue op1, string eventName, int instructionPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Internal_InvokeUnaryMetaMethod_Private_Int32_DynValue_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00060160 File Offset: 0x0005E360
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45993, RefRangeEnd = 45995, XrefRangeStart = 45991, XrefRangeEnd = 45993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_InvokeBinaryMetaMethod(DynValue l, DynValue r, string eventName, int instructionPtr, DynValue extraPush = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraPush);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_Internal_InvokeBinaryMetaMethod_Private_Int32_DynValue_DynValue_String_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000601F4 File Offset: 0x0005E3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45995, XrefRangeEnd = 46004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DynValue> StackTopToArray(int items, bool pop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref items;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_StackTopToArray_Private_Il2CppReferenceArray_1_DynValue_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr3) : null;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00060250 File Offset: 0x0005E450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46004, XrefRangeEnd = 46013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DynValue> StackTopToArrayReverse(int items, bool pop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref items;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr_StackTopToArrayReverse_Private_Il2CppReferenceArray_1_DynValue_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr3) : null;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x000602AC File Offset: 0x0005E4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue _ExecClosure_b__71_0(SymbolRef s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.NativeMethodInfoPtr__ExecClosure_b__71_0_Private_DynValue_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00007672 File Offset: 0x00005872
		public Processor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000602FC File Offset: 0x0005E4FC
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x0000767B File Offset: 0x0000587B
		public unsafe static int STACK_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Processor.NativeFieldInfoPtr_STACK_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Processor.NativeFieldInfoPtr_STACK_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00060318 File Offset: 0x0005E518
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x00007689 File Offset: 0x00005889
		public unsafe ByteCode m_RootChunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_RootChunk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ByteCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_RootChunk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00060348 File Offset: 0x0005E548
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x000076A8 File Offset: 0x000058A8
		public unsafe FastStack<DynValue> m_ValueStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_ValueStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastStack<DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_ValueStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00060378 File Offset: 0x0005E578
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x000076C7 File Offset: 0x000058C7
		public unsafe FastStack<CallStackItem> m_ExecutionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_ExecutionStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastStack<CallStackItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_ExecutionStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x000603A8 File Offset: 0x0005E5A8
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x000076E6 File Offset: 0x000058E6
		public unsafe List<Processor> m_CoroutinesStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_CoroutinesStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Processor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_CoroutinesStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x000603D8 File Offset: 0x0005E5D8
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x00007705 File Offset: 0x00005905
		public unsafe Table m_GlobalTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_GlobalTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Table>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_GlobalTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00060408 File Offset: 0x0005E608
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x00007724 File Offset: 0x00005924
		public unsafe Script m_Script
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_Script);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_Script), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00060438 File Offset: 0x0005E638
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x00007743 File Offset: 0x00005943
		public unsafe Processor m_Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_Parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Processor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00060468 File Offset: 0x0005E668
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x00007762 File Offset: 0x00005962
		public unsafe CoroutineState m_State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoroutineState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00060498 File Offset: 0x0005E698
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x00007781 File Offset: 0x00005981
		public unsafe bool m_CanYield
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_CanYield);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_CanYield)) = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x000604C0 File Offset: 0x0005E6C0
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x0000779C File Offset: 0x0000599C
		public unsafe int m_SavedInstructionPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_SavedInstructionPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_SavedInstructionPtr)) = value;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x000604E8 File Offset: 0x0005E6E8
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x000077B7 File Offset: 0x000059B7
		public unsafe Processor.DebugContext m_Debug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_Debug);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Processor.DebugContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_Debug), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00060518 File Offset: 0x0005E718
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x000077D6 File Offset: 0x000059D6
		public unsafe int m_OwningThreadID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_OwningThreadID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_OwningThreadID)) = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00060540 File Offset: 0x0005E740
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x000077F1 File Offset: 0x000059F1
		public unsafe int m_ExecutionNesting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_ExecutionNesting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_m_ExecutionNesting)) = value;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00060568 File Offset: 0x0005E768
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x0000780C File Offset: 0x00005A0C
		public unsafe static ulong DUMP_CHUNK_MAGIC
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(Processor.NativeFieldInfoPtr_DUMP_CHUNK_MAGIC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Processor.NativeFieldInfoPtr_DUMP_CHUNK_MAGIC, (void*)(&value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00060584 File Offset: 0x0005E784
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x0000781A File Offset: 0x00005A1A
		public unsafe static int DUMP_CHUNK_VERSION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Processor.NativeFieldInfoPtr_DUMP_CHUNK_VERSION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Processor.NativeFieldInfoPtr_DUMP_CHUNK_VERSION, (void*)(&value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x000605A0 File Offset: 0x0005E7A0
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x00007828 File Offset: 0x00005A28
		public unsafe Coroutine _AssociatedCoroutine_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr__AssociatedCoroutine_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr__AssociatedCoroutine_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x000605D0 File Offset: 0x0005E7D0
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x00007847 File Offset: 0x00005A47
		public unsafe static int YIELD_SPECIAL_TRAP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Processor.NativeFieldInfoPtr_YIELD_SPECIAL_TRAP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Processor.NativeFieldInfoPtr_YIELD_SPECIAL_TRAP, (void*)(&value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x000605EC File Offset: 0x0005E7EC
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x00007855 File Offset: 0x00005A55
		public unsafe long AutoYieldCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_AutoYieldCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.NativeFieldInfoPtr_AutoYieldCounter)) = value;
			}
		}

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeFieldInfoPtr_STACK_SIZE;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeFieldInfoPtr_m_RootChunk;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr_m_ValueStack;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionStack;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr_m_CoroutinesStack;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalTable;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeFieldInfoPtr_m_Script;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeFieldInfoPtr_m_Parent;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeFieldInfoPtr_m_State;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeFieldInfoPtr_m_CanYield;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedInstructionPtr;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeFieldInfoPtr_m_Debug;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeFieldInfoPtr_m_OwningThreadID;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionNesting;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeFieldInfoPtr_DUMP_CHUNK_MAGIC;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeFieldInfoPtr_DUMP_CHUNK_VERSION;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeFieldInfoPtr__AssociatedCoroutine_k__BackingField;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeFieldInfoPtr_YIELD_SPECIAL_TRAP;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeFieldInfoPtr_AutoYieldCounter;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_CoroutineState_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_get_AssociatedCoroutine_Public_get_Coroutine_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_set_AssociatedCoroutine_Public_set_Void_Coroutine_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_get_DebuggerEnabled_Internal_get_Boolean_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_set_DebuggerEnabled_Internal_set_Void_Boolean_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Script_Table_ByteCode_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Processor_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Processor_Processor_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_DynValue_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_PushClrToScriptStackFrame_Private_Int32_CallStackItemFlags_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_LeaveProcessor_Private_Void_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_GetThreadId_Private_Int32_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_EnterProcessor_Private_Void_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_GetCoroutineSuspendedLocation_Internal_SourceRef_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_IsDumpStream_Internal_Static_Boolean_Stream_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Internal_Int32_Stream_Int32_Boolean_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_AddSymbolToMap_Private_Void_Dictionary_2_SymbolRef_Int32_SymbolRef_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_Undump_Internal_Int32_Stream_Int32_Table_byref_Boolean_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_Coroutine_Create_Public_DynValue_Closure_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_Coroutine_Recycle_Public_DynValue_Processor_Closure_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_Coroutine_Resume_Public_DynValue_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_FindMeta_Internal_Instruction_byref_Int32_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_AttachDebugger_Internal_Void_IDebugger_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_ListenDebugger_Private_Void_Instruction_Int32_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_ResetBreakPoints_Private_Void_DebuggerAction_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_ResetBreakPoints_Internal_HashSet_1_Int32_SourceCode_HashSet_1_Int32_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_ToggleBreakPoint_Private_Boolean_DebuggerAction_Nullable_1_Boolean_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDebugger_Private_Void_Boolean_Int32_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_Debugger_RefreshThreads_Private_List_1_WatchItem_ScriptExecutionContext_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_Debugger_RefreshVStack_Private_List_1_WatchItem_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_Debugger_RefreshWatches_Private_List_1_WatchItem_ScriptExecutionContext_List_1_DynamicExpression_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_Debugger_RefreshLocals_Private_List_1_WatchItem_ScriptExecutionContext_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_Debugger_RefreshWatch_Private_WatchItem_ScriptExecutionContext_DynamicExpression_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_Debugger_GetCallStack_Internal_List_1_WatchItem_SourceRef_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentSourceRef_Private_SourceRef_Int32_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_FillDebugData_Private_Void_InterpreterException_Int32_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_GetMetatable_Internal_Table_DynValue_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_GetBinaryMetamethod_Internal_DynValue_DynValue_DynValue_String_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_GetMetamethod_Internal_DynValue_DynValue_String_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_GetMetamethodRaw_Internal_DynValue_DynValue_String_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_GetScript_Internal_Script_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_Processing_Loop_Private_DynValue_Int32_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_PerformMessageDecorationBeforeUnwind_Internal_String_DynValue_String_SourceRef_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_AssignLocal_Private_Void_SymbolRef_DynValue_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_ExecStoreLcl_Private_Void_Instruction_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_ExecStoreUpv_Private_Void_Instruction_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_ExecSwap_Private_Void_Instruction_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_GetStoreValue_Private_DynValue_Instruction_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_ExecClosure_Private_Void_Instruction_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_GetUpvalueSymbol_Private_DynValue_SymbolRef_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_ExecMkTuple_Private_Void_Instruction_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_ExecToNum_Private_Void_Instruction_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_ExecIterUpd_Private_Void_Instruction_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_ExecExpTuple_Private_Void_Instruction_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_ExecIterPrep_Private_Void_Instruction_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_ExecJFor_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_ExecIncr_Private_Void_Instruction_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_ExecCNot_Private_Void_Instruction_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_ExecNot_Private_Void_Instruction_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_ExecBeginFn_Private_Void_Instruction_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_PopToBasePointer_Private_CallStackItem_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_PopExecStackAndCheckVStack_Private_Int32_Int32_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgsListForFunctionCall_Private_IList_1_DynValue_Int32_Int32_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_ExecArgs_Private_Void_Instruction_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ExecCall_Private_Int32_Int32_Int32_CallbackFunction_CallbackFunction_Boolean_String_DynValue_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_PerformTCO_Private_Int32_Int32_Int32_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_ExecRet_Private_Int32_Instruction_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CheckForTailRequests_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_JumpBool_Private_Int32_Instruction_Boolean_Int32_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_ExecShortCircuitingOperator_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_ExecAdd_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_ExecSub_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_ExecMul_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_ExecMod_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_ExecDiv_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_ExecPower_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_ExecNeg_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_ExecEq_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_ExecLess_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_ExecLessEq_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_ExecLen_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_ExecConcat_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_ExecTblInitI_Private_Void_Instruction_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_ExecTblInitN_Private_Void_Instruction_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_ExecIndexSet_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr_ExecIndex_Private_Int32_Instruction_Int32_0;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeMethodInfoPtr_ClearBlockData_Private_Void_Instruction_0;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericSymbol_Public_DynValue_SymbolRef_0;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalSymbol_Private_DynValue_DynValue_String_0;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalSymbol_Private_Void_DynValue_String_DynValue_0;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr_AssignGenericSymbol_Public_Void_SymbolRef_DynValue_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr_GetTopNonClrFunction_Private_CallStackItem_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_FindSymbolByName_Public_SymbolRef_String_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_Internal_AdjustTuple_Private_Il2CppReferenceArray_1_DynValue_IList_1_DynValue_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InvokeUnaryMetaMethod_Private_Int32_DynValue_String_Int32_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InvokeBinaryMetaMethod_Private_Int32_DynValue_DynValue_String_Int32_DynValue_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_StackTopToArray_Private_Il2CppReferenceArray_1_DynValue_Int32_Boolean_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_StackTopToArrayReverse_Private_Il2CppReferenceArray_1_DynValue_Int32_Boolean_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr__ExecClosure_b__71_0_Private_DynValue_SymbolRef_0;

		// Token: 0x020001E1 RID: 481
		public class DebugContext : Object
		{
			// Token: 0x06001CF0 RID: 7408 RVA: 0x0008B1DC File Offset: 0x000893DC
			// Note: this type is marked as 'beforefieldinit'.
			static DebugContext()
			{
				Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Processor>.NativeClassPtr, "DebugContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr);
				Processor.DebugContext.NativeFieldInfoPtr_DebuggerEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr, "DebuggerEnabled");
				Processor.DebugContext.NativeFieldInfoPtr_DebuggerAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr, "DebuggerAttached");
				Processor.DebugContext.NativeFieldInfoPtr_DebuggerCurrentAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr, "DebuggerCurrentAction");
				Processor.DebugContext.NativeFieldInfoPtr_DebuggerCurrentActionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr, "DebuggerCurrentActionTarget");
				Processor.DebugContext.NativeFieldInfoPtr_LastHlRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr, "LastHlRef");
				Processor.DebugContext.NativeFieldInfoPtr_ExStackDepthAtStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr, "ExStackDepthAtStep");
				Processor.DebugContext.NativeFieldInfoPtr_BreakPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr, "BreakPoints");
				Processor.DebugContext.NativeFieldInfoPtr_LineBasedBreakPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr, "LineBasedBreakPoints");
				Processor.DebugContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr, 100666527);
			}

			// Token: 0x06001CF1 RID: 7409 RVA: 0x0008B2BC File Offset: 0x000894BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43890, RefRangeEnd = 43891, XrefRangeStart = 43882, XrefRangeEnd = 43890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebugContext()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Processor.DebugContext>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.DebugContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CF2 RID: 7410 RVA: 0x0000B6B4 File Offset: 0x000098B4
			public DebugContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0008B2F8 File Offset: 0x000894F8
			// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x0000B6BD File Offset: 0x000098BD
			public unsafe bool DebuggerEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_DebuggerEnabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_DebuggerEnabled)) = value;
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0008B320 File Offset: 0x00089520
			// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x0000B6D8 File Offset: 0x000098D8
			public unsafe IDebugger DebuggerAttached
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_DebuggerAttached);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDebugger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_DebuggerAttached), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0008B350 File Offset: 0x00089550
			// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x0000B6F7 File Offset: 0x000098F7
			public unsafe DebuggerAction.ActionType DebuggerCurrentAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_DebuggerCurrentAction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_DebuggerCurrentAction)) = value;
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0008B378 File Offset: 0x00089578
			// (set) Token: 0x06001CFA RID: 7418 RVA: 0x0000B712 File Offset: 0x00009912
			public unsafe int DebuggerCurrentActionTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_DebuggerCurrentActionTarget);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_DebuggerCurrentActionTarget)) = value;
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0008B3A0 File Offset: 0x000895A0
			// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0000B72D File Offset: 0x0000992D
			public unsafe SourceRef LastHlRef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_LastHlRef);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_LastHlRef), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0008B3D0 File Offset: 0x000895D0
			// (set) Token: 0x06001CFE RID: 7422 RVA: 0x0000B74C File Offset: 0x0000994C
			public unsafe int ExStackDepthAtStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_ExStackDepthAtStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_ExStackDepthAtStep)) = value;
				}
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0008B3F8 File Offset: 0x000895F8
			// (set) Token: 0x06001D00 RID: 7424 RVA: 0x0000B767 File Offset: 0x00009967
			public unsafe List<SourceRef> BreakPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_BreakPoints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SourceRef>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_BreakPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0008B428 File Offset: 0x00089628
			// (set) Token: 0x06001D02 RID: 7426 RVA: 0x0000B786 File Offset: 0x00009986
			public unsafe bool LineBasedBreakPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_LineBasedBreakPoints);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.DebugContext.NativeFieldInfoPtr_LineBasedBreakPoints)) = value;
				}
			}

			// Token: 0x0400171D RID: 5917
			private static readonly IntPtr NativeFieldInfoPtr_DebuggerEnabled;

			// Token: 0x0400171E RID: 5918
			private static readonly IntPtr NativeFieldInfoPtr_DebuggerAttached;

			// Token: 0x0400171F RID: 5919
			private static readonly IntPtr NativeFieldInfoPtr_DebuggerCurrentAction;

			// Token: 0x04001720 RID: 5920
			private static readonly IntPtr NativeFieldInfoPtr_DebuggerCurrentActionTarget;

			// Token: 0x04001721 RID: 5921
			private static readonly IntPtr NativeFieldInfoPtr_LastHlRef;

			// Token: 0x04001722 RID: 5922
			private static readonly IntPtr NativeFieldInfoPtr_ExStackDepthAtStep;

			// Token: 0x04001723 RID: 5923
			private static readonly IntPtr NativeFieldInfoPtr_BreakPoints;

			// Token: 0x04001724 RID: 5924
			private static readonly IntPtr NativeFieldInfoPtr_LineBasedBreakPoints;

			// Token: 0x04001725 RID: 5925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001E2 RID: 482
		[ObfuscatedName("MoonSharp.Interpreter.Execution.VM.Processor+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D03 RID: 7427 RVA: 0x0008B450 File Offset: 0x00089650
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Processor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Processor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Processor.__c>.NativeClassPtr);
				Processor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.__c>.NativeClassPtr, "<>9");
				Processor.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.__c>.NativeClassPtr, "<>9__49_0");
				Processor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor.__c>.NativeClassPtr, 100666529);
				Processor.__c.NativeMethodInfoPtr__Debugger_RefreshThreads_b__49_0_Internal_WatchItem_Processor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor.__c>.NativeClassPtr, 100666530);
			}

			// Token: 0x06001D04 RID: 7428 RVA: 0x0008B4CC File Offset: 0x000896CC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Processor.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D05 RID: 7429 RVA: 0x0008B508 File Offset: 0x00089708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43891, XrefRangeEnd = 43900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WatchItem _Debugger_RefreshThreads_b__49_0(Processor c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.__c.NativeMethodInfoPtr__Debugger_RefreshThreads_b__49_0_Internal_WatchItem_Processor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WatchItem>(intPtr3) : null;
				}
			}

			// Token: 0x06001D06 RID: 7430 RVA: 0x0000B7A1 File Offset: 0x000099A1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0008B558 File Offset: 0x00089758
			// (set) Token: 0x06001D08 RID: 7432 RVA: 0x0000B7AA File Offset: 0x000099AA
			public unsafe static Processor.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Processor.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Processor.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Processor.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0008B580 File Offset: 0x00089780
			// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0000B7BC File Offset: 0x000099BC
			public unsafe static Func<Processor, WatchItem> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Processor.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Processor, WatchItem>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Processor.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001726 RID: 5926
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001727 RID: 5927
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x04001728 RID: 5928
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001729 RID: 5929
			private static readonly IntPtr NativeMethodInfoPtr__Debugger_RefreshThreads_b__49_0_Internal_WatchItem_Processor_0;
		}

		// Token: 0x020001E3 RID: 483
		[ObfuscatedName("MoonSharp.Interpreter.Execution.VM.Processor+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Object
		{
			// Token: 0x06001D0B RID: 7435 RVA: 0x0008B5A8 File Offset: 0x000897A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<Processor.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Processor>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Processor.__c__DisplayClass51_0>.NativeClassPtr);
				Processor.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.__c__DisplayClass51_0>.NativeClassPtr, "<>4__this");
				Processor.__c__DisplayClass51_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Processor.__c__DisplayClass51_0>.NativeClassPtr, "context");
				Processor.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor.__c__DisplayClass51_0>.NativeClassPtr, 100666531);
				Processor.__c__DisplayClass51_0.NativeMethodInfoPtr__Debugger_RefreshWatches_b__0_Internal_WatchItem_DynamicExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Processor.__c__DisplayClass51_0>.NativeClassPtr, 100666532);
			}

			// Token: 0x06001D0C RID: 7436 RVA: 0x0008B624 File Offset: 0x00089824
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Processor.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D0D RID: 7437 RVA: 0x0008B660 File Offset: 0x00089860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43900, XrefRangeEnd = 43937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WatchItem _Debugger_RefreshWatches_b__0(DynamicExpression w)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Processor.__c__DisplayClass51_0.NativeMethodInfoPtr__Debugger_RefreshWatches_b__0_Internal_WatchItem_DynamicExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WatchItem>(intPtr3) : null;
				}
			}

			// Token: 0x06001D0E RID: 7438 RVA: 0x0000B7CE File Offset: 0x000099CE
			public __c__DisplayClass51_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0008B6B0 File Offset: 0x000898B0
			// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0000B7D7 File Offset: 0x000099D7
			public unsafe Processor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Processor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0008B6E0 File Offset: 0x000898E0
			// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0000B7F6 File Offset: 0x000099F6
			public unsafe ScriptExecutionContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.__c__DisplayClass51_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Processor.__c__DisplayClass51_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400172A RID: 5930
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400172B RID: 5931
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400172C RID: 5932
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400172D RID: 5933
			private static readonly IntPtr NativeMethodInfoPtr__Debugger_RefreshWatches_b__0_Internal_WatchItem_DynamicExpression_0;
		}
	}
}
