using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006F RID: 111
	public class LabelStatement : Statement
	{
		// Token: 0x06000A62 RID: 2658 RVA: 0x0003E004 File Offset: 0x0003C204
		// Note: this type is marked as 'beforefieldinit'.
		static LabelStatement()
		{
			Il2CppClassPointerStore<LabelStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "LabelStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr);
			LabelStatement.NativeFieldInfoPtr__Label_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, "<Label>k__BackingField");
			LabelStatement.NativeFieldInfoPtr__Address_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, "<Address>k__BackingField");
			LabelStatement.NativeFieldInfoPtr__SourceRef_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, "<SourceRef>k__BackingField");
			LabelStatement.NativeFieldInfoPtr__NameToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, "<NameToken>k__BackingField");
			LabelStatement.NativeFieldInfoPtr__DefinedVarsCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, "<DefinedVarsCount>k__BackingField");
			LabelStatement.NativeFieldInfoPtr__LastDefinedVarName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, "<LastDefinedVarName>k__BackingField");
			LabelStatement.NativeFieldInfoPtr_m_Gotos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, "m_Gotos");
			LabelStatement.NativeFieldInfoPtr_m_StackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, "m_StackFrame");
			LabelStatement.NativeMethodInfoPtr_get_Label_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665162);
			LabelStatement.NativeMethodInfoPtr_set_Label_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665163);
			LabelStatement.NativeMethodInfoPtr_get_Address_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665164);
			LabelStatement.NativeMethodInfoPtr_set_Address_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665165);
			LabelStatement.NativeMethodInfoPtr_get_SourceRef_Public_get_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665166);
			LabelStatement.NativeMethodInfoPtr_set_SourceRef_Private_set_Void_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665167);
			LabelStatement.NativeMethodInfoPtr_get_NameToken_Public_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665168);
			LabelStatement.NativeMethodInfoPtr_set_NameToken_Private_set_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665169);
			LabelStatement.NativeMethodInfoPtr_get_DefinedVarsCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665170);
			LabelStatement.NativeMethodInfoPtr_set_DefinedVarsCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665171);
			LabelStatement.NativeMethodInfoPtr_get_LastDefinedVarName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665172);
			LabelStatement.NativeMethodInfoPtr_set_LastDefinedVarName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665173);
			LabelStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665174);
			LabelStatement.NativeMethodInfoPtr_SetDefinedVars_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665175);
			LabelStatement.NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665176);
			LabelStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665177);
			LabelStatement.NativeMethodInfoPtr_SetScope_Internal_Void_RuntimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr, 100665178);
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0003E228 File Offset: 0x0003C428
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x0003E260 File Offset: 0x0003C460
		public unsafe string Label
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_get_Label_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_set_Label_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0003E2A4 File Offset: 0x0003C4A4
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x0003E2E0 File Offset: 0x0003C4E0
		public unsafe int Address
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_get_Address_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_set_Address_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0003E320 File Offset: 0x0003C520
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0003E360 File Offset: 0x0003C560
		public unsafe SourceRef SourceRef
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_get_SourceRef_Public_get_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21549, RefRangeEnd = 21556, XrefRangeStart = 21549, XrefRangeEnd = 21556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_set_SourceRef_Private_set_Void_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0003E3A4 File Offset: 0x0003C5A4
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0003E3E4 File Offset: 0x0003C5E4
		public unsafe Token NameToken
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_get_NameToken_Public_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Token>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_set_NameToken_Private_set_Void_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0003E428 File Offset: 0x0003C628
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0003E464 File Offset: 0x0003C664
		public unsafe int DefinedVarsCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_get_DefinedVarsCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_set_DefinedVarsCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0003E4A4 File Offset: 0x0003C6A4
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0003E4DC File Offset: 0x0003C6DC
		public unsafe string LastDefinedVarName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_get_LastDefinedVarName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_set_LastDefinedVarName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0003E520 File Offset: 0x0003C720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30418, RefRangeEnd = 30419, XrefRangeStart = 30394, XrefRangeEnd = 30418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0003E56C File Offset: 0x0003C76C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30420, RefRangeEnd = 30421, XrefRangeStart = 30419, XrefRangeEnd = 30420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref definedVarsCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastDefinedVarsName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_SetDefinedVars_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0003E5BC File Offset: 0x0003C7BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30427, RefRangeEnd = 30428, XrefRangeStart = 30421, XrefRangeEnd = 30427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterGoto(GotoStatement gotostat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gotostat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0003E600 File Offset: 0x0003C800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30428, XrefRangeEnd = 30444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0003E650 File Offset: 0x0003C850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30444, XrefRangeEnd = 30445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScope(RuntimeScopeBlock runtimeScopeBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runtimeScopeBlock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelStatement.NativeMethodInfoPtr_SetScope_Internal_Void_RuntimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00004F7F File Offset: 0x0000317F
		public LabelStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0003E694 File Offset: 0x0003C894
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00004F88 File Offset: 0x00003188
		public unsafe string _Label_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__Label_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__Label_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0003E6BC File Offset: 0x0003C8BC
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x00004FA7 File Offset: 0x000031A7
		public unsafe int _Address_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__Address_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__Address_k__BackingField)) = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0003E6E4 File Offset: 0x0003C8E4
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00004FC2 File Offset: 0x000031C2
		public unsafe SourceRef _SourceRef_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__SourceRef_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__SourceRef_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0003E714 File Offset: 0x0003C914
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00004FE1 File Offset: 0x000031E1
		public unsafe Token _NameToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__NameToken_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Token>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__NameToken_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0003E744 File Offset: 0x0003C944
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00005000 File Offset: 0x00003200
		public unsafe int _DefinedVarsCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__DefinedVarsCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__DefinedVarsCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0003E76C File Offset: 0x0003C96C
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x0000501B File Offset: 0x0000321B
		public unsafe string _LastDefinedVarName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__LastDefinedVarName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr__LastDefinedVarName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0003E794 File Offset: 0x0003C994
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0000503A File Offset: 0x0000323A
		public unsafe List<GotoStatement> m_Gotos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr_m_Gotos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GotoStatement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr_m_Gotos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0003E7C4 File Offset: 0x0003C9C4
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00005059 File Offset: 0x00003259
		public unsafe RuntimeScopeBlock m_StackFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr_m_StackFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelStatement.NativeFieldInfoPtr_m_StackFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr__Label_k__BackingField;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr__Address_k__BackingField;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr__SourceRef_k__BackingField;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr__NameToken_k__BackingField;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeFieldInfoPtr__DefinedVarsCount_k__BackingField;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr__LastDefinedVarName_k__BackingField;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_m_Gotos;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr_m_StackFrame;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_String_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_set_Label_Private_set_Void_String_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_Int32_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_set_Address_Private_set_Void_Int32_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceRef_Public_get_SourceRef_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceRef_Private_set_Void_SourceRef_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_get_NameToken_Public_get_Token_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_set_NameToken_Private_set_Void_Token_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_get_DefinedVarsCount_Internal_get_Int32_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_set_DefinedVarsCount_Private_set_Void_Int32_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_get_LastDefinedVarName_Internal_get_String_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_set_LastDefinedVarName_Private_set_Void_String_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_SetDefinedVars_Internal_Void_Int32_String_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_SetScope_Internal_Void_RuntimeScopeBlock_0;
	}
}
