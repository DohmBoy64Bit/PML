using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000E6 RID: 230
	public class ByteCode : RefIdObject
	{
		// Token: 0x06001148 RID: 4424 RVA: 0x0005BA10 File Offset: 0x00059C10
		// Note: this type is marked as 'beforefieldinit'.
		static ByteCode()
		{
			Il2CppClassPointerStore<ByteCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution.VM", "ByteCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteCode>.NativeClassPtr);
			ByteCode.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, "Code");
			ByteCode.NativeFieldInfoPtr__Script_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, "<Script>k__BackingField");
			ByteCode.NativeFieldInfoPtr_m_SourceRefStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, "m_SourceRefStack");
			ByteCode.NativeFieldInfoPtr_m_CurrentSourceRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, "m_CurrentSourceRef");
			ByteCode.NativeFieldInfoPtr_LoopTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, "LoopTracker");
			ByteCode.NativeMethodInfoPtr_get_Script_Public_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666365);
			ByteCode.NativeMethodInfoPtr_set_Script_Private_set_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666366);
			ByteCode.NativeMethodInfoPtr__ctor_Public_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666367);
			ByteCode.NativeMethodInfoPtr_EnterSource_Public_IDisposable_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666368);
			ByteCode.NativeMethodInfoPtr_PushSourceRef_Public_Void_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666369);
			ByteCode.NativeMethodInfoPtr_PopSourceRef_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666370);
			ByteCode.NativeMethodInfoPtr_Dump_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666371);
			ByteCode.NativeMethodInfoPtr_GetJumpPointForNextInstruction_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666372);
			ByteCode.NativeMethodInfoPtr_GetJumpPointForLastInstruction_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666373);
			ByteCode.NativeMethodInfoPtr_GetLastInstruction_Public_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666374);
			ByteCode.NativeMethodInfoPtr_AppendInstruction_Private_Instruction_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666375);
			ByteCode.NativeMethodInfoPtr_Emit_Nop_Public_Instruction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666376);
			ByteCode.NativeMethodInfoPtr_Emit_Invalid_Public_Instruction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666377);
			ByteCode.NativeMethodInfoPtr_Emit_Pop_Public_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666378);
			ByteCode.NativeMethodInfoPtr_Emit_Call_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666379);
			ByteCode.NativeMethodInfoPtr_Emit_ThisCall_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666380);
			ByteCode.NativeMethodInfoPtr_Emit_Literal_Public_Instruction_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666381);
			ByteCode.NativeMethodInfoPtr_Emit_Jump_Public_Instruction_OpCode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666382);
			ByteCode.NativeMethodInfoPtr_Emit_MkTuple_Public_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666383);
			ByteCode.NativeMethodInfoPtr_Emit_Operator_Public_Instruction_OpCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666384);
			ByteCode.NativeMethodInfoPtr_Emit_Debug_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666385);
			ByteCode.NativeMethodInfoPtr_Emit_Enter_Public_Instruction_RuntimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666386);
			ByteCode.NativeMethodInfoPtr_Emit_Leave_Public_Instruction_RuntimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666387);
			ByteCode.NativeMethodInfoPtr_Emit_Exit_Public_Instruction_RuntimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666388);
			ByteCode.NativeMethodInfoPtr_Emit_Clean_Public_Instruction_RuntimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666389);
			ByteCode.NativeMethodInfoPtr_Emit_Closure_Public_Instruction_Il2CppReferenceArray_1_SymbolRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666390);
			ByteCode.NativeMethodInfoPtr_Emit_Args_Public_Instruction_Il2CppReferenceArray_1_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666391);
			ByteCode.NativeMethodInfoPtr_Emit_Ret_Public_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666392);
			ByteCode.NativeMethodInfoPtr_Emit_ToNum_Public_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666393);
			ByteCode.NativeMethodInfoPtr_Emit_Incr_Public_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666394);
			ByteCode.NativeMethodInfoPtr_Emit_NewTable_Public_Instruction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666395);
			ByteCode.NativeMethodInfoPtr_Emit_IterPrep_Public_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666396);
			ByteCode.NativeMethodInfoPtr_Emit_ExpTuple_Public_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666397);
			ByteCode.NativeMethodInfoPtr_Emit_IterUpd_Public_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666398);
			ByteCode.NativeMethodInfoPtr_Emit_Meta_Public_Instruction_String_OpCodeMetadataType_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666399);
			ByteCode.NativeMethodInfoPtr_Emit_BeginFn_Public_Instruction_RuntimeScopeFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666400);
			ByteCode.NativeMethodInfoPtr_Emit_Scalar_Public_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666401);
			ByteCode.NativeMethodInfoPtr_Emit_Load_Public_Int32_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666402);
			ByteCode.NativeMethodInfoPtr_Emit_Store_Public_Int32_SymbolRef_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666403);
			ByteCode.NativeMethodInfoPtr_Emit_TblInitN_Public_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666404);
			ByteCode.NativeMethodInfoPtr_Emit_TblInitI_Public_Instruction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666405);
			ByteCode.NativeMethodInfoPtr_Emit_Index_Public_Instruction_DynValue_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666406);
			ByteCode.NativeMethodInfoPtr_Emit_IndexSet_Public_Instruction_Int32_Int32_DynValue_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666407);
			ByteCode.NativeMethodInfoPtr_Emit_Copy_Public_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666408);
			ByteCode.NativeMethodInfoPtr_Emit_Swap_Public_Instruction_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, 100666409);
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0005BE28 File Offset: 0x0005A028
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x0005BE68 File Offset: 0x0005A068
		public unsafe Script Script
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_get_Script_Public_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_set_Script_Private_set_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0005BEAC File Offset: 0x0005A0AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43208, RefRangeEnd = 43209, XrefRangeStart = 43180, XrefRangeEnd = 43208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteCode(Script script)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteCode>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr__ctor_Public_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0005BEF8 File Offset: 0x0005A0F8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 43220, RefRangeEnd = 43234, XrefRangeStart = 43209, XrefRangeEnd = 43220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDisposable EnterSource(SourceRef sref)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_EnterSource_Public_IDisposable_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0005BF48 File Offset: 0x0005A148
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 43242, RefRangeEnd = 43252, XrefRangeStart = 43234, XrefRangeEnd = 43242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushSourceRef(SourceRef sref)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_PushSourceRef_Public_Void_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0005BF8C File Offset: 0x0005A18C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 43262, RefRangeEnd = 43272, XrefRangeStart = 43252, XrefRangeEnd = 43262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopSourceRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_PopSourceRef_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0005BFC0 File Offset: 0x0005A1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43272, XrefRangeEnd = 43297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Dump_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0005C004 File Offset: 0x0005A204
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 43298, RefRangeEnd = 43312, XrefRangeStart = 43297, XrefRangeEnd = 43298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetJumpPointForNextInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_GetJumpPointForNextInstruction_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0005C040 File Offset: 0x0005A240
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 43313, RefRangeEnd = 43320, XrefRangeStart = 43312, XrefRangeEnd = 43313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetJumpPointForLastInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_GetJumpPointForLastInstruction_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0005C07C File Offset: 0x0005A27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43320, XrefRangeEnd = 43325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction GetLastInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_GetLastInstruction_Public_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0005C0BC File Offset: 0x0005A2BC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 43328, RefRangeEnd = 43364, XrefRangeStart = 43325, XrefRangeEnd = 43328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction AppendInstruction(Instruction c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_AppendInstruction_Private_Instruction_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0005C10C File Offset: 0x0005A30C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 43371, RefRangeEnd = 43375, XrefRangeStart = 43364, XrefRangeEnd = 43371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Nop(string comment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(comment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Nop_Public_Instruction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0005C15C File Offset: 0x0005A35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43375, XrefRangeEnd = 43382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Invalid(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Invalid_Public_Instruction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0005C1AC File Offset: 0x0005A3AC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 43388, RefRangeEnd = 43398, XrefRangeStart = 43382, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Pop(int num = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Pop_Public_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0005C1F8 File Offset: 0x0005A3F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43405, RefRangeEnd = 43407, XrefRangeStart = 43398, XrefRangeEnd = 43405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit_Call(int argCount, string debugName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Call_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0005C248 File Offset: 0x0005A448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43407, XrefRangeEnd = 43414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit_ThisCall(int argCount, string debugName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_ThisCall_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0005C298 File Offset: 0x0005A498
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43421, RefRangeEnd = 43423, XrefRangeStart = 43414, XrefRangeEnd = 43421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Literal(DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Literal_Public_Instruction_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0005C2E8 File Offset: 0x0005A4E8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 43429, RefRangeEnd = 43441, XrefRangeStart = 43423, XrefRangeEnd = 43429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Jump(OpCode jumpOpCode, int idx, int optPar = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jumpOpCode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optPar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Jump_Public_Instruction_OpCode_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0005C354 File Offset: 0x0005A554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43447, RefRangeEnd = 43448, XrefRangeStart = 43441, XrefRangeEnd = 43447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_MkTuple(int cnt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cnt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_MkTuple_Public_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0005C3A0 File Offset: 0x0005A5A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43464, RefRangeEnd = 43467, XrefRangeStart = 43448, XrefRangeEnd = 43464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Operator(OpCode opcode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(opcode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Operator_Public_Instruction_OpCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0005C3F0 File Offset: 0x0005A5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43467, XrefRangeEnd = 43480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit_Debug(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Debug_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0005C434 File Offset: 0x0005A634
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 43487, RefRangeEnd = 43494, XrefRangeStart = 43480, XrefRangeEnd = 43487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Enter(RuntimeScopeBlock runtimeScopeBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runtimeScopeBlock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Enter_Public_Instruction_RuntimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0005C484 File Offset: 0x0005A684
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 43501, RefRangeEnd = 43509, XrefRangeStart = 43494, XrefRangeEnd = 43501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Leave(RuntimeScopeBlock runtimeScopeBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runtimeScopeBlock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Leave_Public_Instruction_RuntimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0005C4D4 File Offset: 0x0005A6D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43516, RefRangeEnd = 43517, XrefRangeStart = 43509, XrefRangeEnd = 43516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Exit(RuntimeScopeBlock runtimeScopeBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runtimeScopeBlock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Exit_Public_Instruction_RuntimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0005C524 File Offset: 0x0005A724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43524, RefRangeEnd = 43525, XrefRangeStart = 43517, XrefRangeEnd = 43524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Clean(RuntimeScopeBlock runtimeScopeBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runtimeScopeBlock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Clean_Public_Instruction_RuntimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0005C574 File Offset: 0x0005A774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43532, RefRangeEnd = 43533, XrefRangeStart = 43525, XrefRangeEnd = 43532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Closure(Il2CppReferenceArray<SymbolRef> symbols, int jmpnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jmpnum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Closure_Public_Instruction_Il2CppReferenceArray_1_SymbolRef_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0005C5D4 File Offset: 0x0005A7D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43540, RefRangeEnd = 43542, XrefRangeStart = 43533, XrefRangeEnd = 43540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Args([Optional] Il2CppReferenceArray<SymbolRef> symbols)
		{
			if (symbols == null)
			{
				symbols = new Il2CppReferenceArray<SymbolRef>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Args_Public_Instruction_Il2CppReferenceArray_1_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0005C634 File Offset: 0x0005A834
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 43548, RefRangeEnd = 43552, XrefRangeStart = 43542, XrefRangeEnd = 43548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Ret(int retvals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref retvals;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Ret_Public_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0005C680 File Offset: 0x0005A880
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43558, RefRangeEnd = 43561, XrefRangeStart = 43552, XrefRangeEnd = 43558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_ToNum(int stage = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_ToNum_Public_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0005C6CC File Offset: 0x0005A8CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43567, RefRangeEnd = 43568, XrefRangeStart = 43561, XrefRangeEnd = 43567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Incr(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Incr_Public_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0005C718 File Offset: 0x0005A918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43574, RefRangeEnd = 43575, XrefRangeStart = 43568, XrefRangeEnd = 43574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_NewTable(bool shared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shared;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_NewTable_Public_Instruction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0005C764 File Offset: 0x0005A964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43581, RefRangeEnd = 43582, XrefRangeStart = 43575, XrefRangeEnd = 43581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_IterPrep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_IterPrep_Public_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0005C7A4 File Offset: 0x0005A9A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43588, RefRangeEnd = 43589, XrefRangeStart = 43582, XrefRangeEnd = 43588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_ExpTuple(int stackOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stackOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_ExpTuple_Public_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0005C7F0 File Offset: 0x0005A9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43595, RefRangeEnd = 43596, XrefRangeStart = 43589, XrefRangeEnd = 43595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_IterUpd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_IterUpd_Public_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0005C830 File Offset: 0x0005AA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43604, RefRangeEnd = 43606, XrefRangeStart = 43596, XrefRangeEnd = 43604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Meta(string funcName, OpCodeMetadataType metaType, DynValue value = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metaType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Meta_Public_Instruction_String_OpCodeMetadataType_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0005C8A4 File Offset: 0x0005AAA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43618, RefRangeEnd = 43620, XrefRangeStart = 43606, XrefRangeEnd = 43618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_BeginFn(RuntimeScopeFrame stackFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stackFrame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_BeginFn_Public_Instruction_RuntimeScopeFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0005C8F4 File Offset: 0x0005AAF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43626, RefRangeEnd = 43627, XrefRangeStart = 43620, XrefRangeEnd = 43626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Scalar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Scalar_Public_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0005C934 File Offset: 0x0005AB34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 43639, RefRangeEnd = 43646, XrefRangeStart = 43627, XrefRangeEnd = 43639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Emit_Load(SymbolRef sym)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sym);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Load_Public_Int32_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0005C984 File Offset: 0x0005AB84
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 43666, RefRangeEnd = 43674, XrefRangeStart = 43646, XrefRangeEnd = 43666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Emit_Store(SymbolRef sym, int stackofs, int tupleidx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sym);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stackofs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tupleidx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Store_Public_Int32_SymbolRef_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0005C9F0 File Offset: 0x0005ABF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43680, RefRangeEnd = 43681, XrefRangeStart = 43674, XrefRangeEnd = 43680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_TblInitN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_TblInitN_Public_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0005CA30 File Offset: 0x0005AC30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43687, RefRangeEnd = 43688, XrefRangeStart = 43681, XrefRangeEnd = 43687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_TblInitI(bool lastpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lastpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_TblInitI_Public_Instruction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0005CA7C File Offset: 0x0005AC7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43696, RefRangeEnd = 43699, XrefRangeStart = 43688, XrefRangeEnd = 43696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Index(DynValue index = null, bool isNameIndex = false, bool isExpList = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(index);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNameIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isExpList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Index_Public_Instruction_DynValue_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0005CAE8 File Offset: 0x0005ACE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43707, RefRangeEnd = 43709, XrefRangeStart = 43699, XrefRangeEnd = 43707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_IndexSet(int stackofs, int tupleidx, DynValue index = null, bool isNameIndex = false, bool isExpList = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stackofs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tupleidx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNameIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isExpList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_IndexSet_Public_Instruction_Int32_Int32_DynValue_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0005CB70 File Offset: 0x0005AD70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43715, RefRangeEnd = 43716, XrefRangeStart = 43709, XrefRangeEnd = 43715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Copy(int numval)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numval;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Copy_Public_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0005CBBC File Offset: 0x0005ADBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43722, RefRangeEnd = 43723, XrefRangeStart = 43716, XrefRangeEnd = 43722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Emit_Swap(int p1, int p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.NativeMethodInfoPtr_Emit_Swap_Public_Instruction_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000072D5 File Offset: 0x000054D5
		public Instruction Emit_Args(params SymbolRef[] symbols)
		{
			return this.Emit_Args(new Il2CppReferenceArray<SymbolRef>(symbols));
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x000072E3 File Offset: 0x000054E3
		public ByteCode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x0005CC18 File Offset: 0x0005AE18
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x000072EC File Offset: 0x000054EC
		public unsafe List<Instruction> Code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr_Code);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Instruction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr_Code), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x0005CC48 File Offset: 0x0005AE48
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x0000730B File Offset: 0x0000550B
		public unsafe Script _Script_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr__Script_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr__Script_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x0005CC78 File Offset: 0x0005AE78
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x0000732A File Offset: 0x0000552A
		public unsafe List<SourceRef> m_SourceRefStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr_m_SourceRefStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SourceRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr_m_SourceRefStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x0005CCA8 File Offset: 0x0005AEA8
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x00007349 File Offset: 0x00005549
		public unsafe SourceRef m_CurrentSourceRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr_m_CurrentSourceRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr_m_CurrentSourceRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x0005CCD8 File Offset: 0x0005AED8
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x00007368 File Offset: 0x00005568
		public unsafe LoopTracker LoopTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr_LoopTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.NativeFieldInfoPtr_LoopTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeFieldInfoPtr_Code;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeFieldInfoPtr__Script_k__BackingField;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceRefStack;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSourceRef;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeFieldInfoPtr_LoopTracker;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_get_Script_Public_get_Script_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_set_Script_Private_set_Void_Script_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Script_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_EnterSource_Public_IDisposable_SourceRef_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_PushSourceRef_Public_Void_SourceRef_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_PopSourceRef_Public_Void_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_String_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_GetJumpPointForNextInstruction_Public_Int32_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_GetJumpPointForLastInstruction_Public_Int32_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_GetLastInstruction_Public_Instruction_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_AppendInstruction_Private_Instruction_Instruction_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Nop_Public_Instruction_String_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Invalid_Public_Instruction_String_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Pop_Public_Instruction_Int32_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Call_Public_Void_Int32_String_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_Emit_ThisCall_Public_Void_Int32_String_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Literal_Public_Instruction_DynValue_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Jump_Public_Instruction_OpCode_Int32_Int32_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_Emit_MkTuple_Public_Instruction_Int32_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Operator_Public_Instruction_OpCode_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Debug_Public_Void_String_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Enter_Public_Instruction_RuntimeScopeBlock_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Leave_Public_Instruction_RuntimeScopeBlock_0;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Exit_Public_Instruction_RuntimeScopeBlock_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Clean_Public_Instruction_RuntimeScopeBlock_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Closure_Public_Instruction_Il2CppReferenceArray_1_SymbolRef_Int32_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Args_Public_Instruction_Il2CppReferenceArray_1_SymbolRef_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Ret_Public_Instruction_Int32_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_Emit_ToNum_Public_Instruction_Int32_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Incr_Public_Instruction_Int32_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_Emit_NewTable_Public_Instruction_Boolean_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_Emit_IterPrep_Public_Instruction_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_Emit_ExpTuple_Public_Instruction_Int32_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_Emit_IterUpd_Public_Instruction_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Meta_Public_Instruction_String_OpCodeMetadataType_DynValue_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_Emit_BeginFn_Public_Instruction_RuntimeScopeFrame_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Scalar_Public_Instruction_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Load_Public_Int32_SymbolRef_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Store_Public_Int32_SymbolRef_Int32_Int32_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_Emit_TblInitN_Public_Instruction_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_Emit_TblInitI_Public_Instruction_Boolean_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Index_Public_Instruction_DynValue_Boolean_Boolean_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_Emit_IndexSet_Public_Instruction_Int32_Int32_DynValue_Boolean_Boolean_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Copy_Public_Instruction_Int32_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Swap_Public_Instruction_Int32_Int32_0;

		// Token: 0x020001DF RID: 479
		public class SourceCodeStackGuard : Object
		{
			// Token: 0x06001CE2 RID: 7394 RVA: 0x0008AF60 File Offset: 0x00089160
			// Note: this type is marked as 'beforefieldinit'.
			static SourceCodeStackGuard()
			{
				Il2CppClassPointerStore<ByteCode.SourceCodeStackGuard>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ByteCode>.NativeClassPtr, "SourceCodeStackGuard");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteCode.SourceCodeStackGuard>.NativeClassPtr);
				ByteCode.SourceCodeStackGuard.NativeFieldInfoPtr_m_Bc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteCode.SourceCodeStackGuard>.NativeClassPtr, "m_Bc");
				ByteCode.SourceCodeStackGuard.NativeMethodInfoPtr__ctor_Public_Void_SourceRef_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode.SourceCodeStackGuard>.NativeClassPtr, 100666410);
				ByteCode.SourceCodeStackGuard.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteCode.SourceCodeStackGuard>.NativeClassPtr, 100666411);
			}

			// Token: 0x06001CE3 RID: 7395 RVA: 0x0008AFC8 File Offset: 0x000891C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43160, XrefRangeEnd = 43170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SourceCodeStackGuard(SourceRef sref, ByteCode bc)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteCode.SourceCodeStackGuard>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sref);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.SourceCodeStackGuard.NativeMethodInfoPtr__ctor_Public_Void_SourceRef_ByteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CE4 RID: 7396 RVA: 0x0008B028 File Offset: 0x00089228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43170, XrefRangeEnd = 43180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteCode.SourceCodeStackGuard.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CE5 RID: 7397 RVA: 0x0000B65F File Offset: 0x0000985F
			public SourceCodeStackGuard(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x0008B05C File Offset: 0x0008925C
			// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0000B668 File Offset: 0x00009868
			public unsafe ByteCode m_Bc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.SourceCodeStackGuard.NativeFieldInfoPtr_m_Bc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ByteCode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteCode.SourceCodeStackGuard.NativeFieldInfoPtr_m_Bc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001716 RID: 5910
			private static readonly IntPtr NativeFieldInfoPtr_m_Bc;

			// Token: 0x04001717 RID: 5911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SourceRef_ByteCode_0;

			// Token: 0x04001718 RID: 5912
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}
	}
}
