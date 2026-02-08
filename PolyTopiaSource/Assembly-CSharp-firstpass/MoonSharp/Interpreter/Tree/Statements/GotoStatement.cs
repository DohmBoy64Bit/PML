using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006D RID: 109
	public class GotoStatement : Statement
	{
		// Token: 0x06000A38 RID: 2616 RVA: 0x0003D6D0 File Offset: 0x0003B8D0
		// Note: this type is marked as 'beforefieldinit'.
		static GotoStatement()
		{
			Il2CppClassPointerStore<GotoStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree.Statements", "GotoStatement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr);
			GotoStatement.NativeFieldInfoPtr__SourceRef_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, "<SourceRef>k__BackingField");
			GotoStatement.NativeFieldInfoPtr__GotoToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, "<GotoToken>k__BackingField");
			GotoStatement.NativeFieldInfoPtr__Label_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, "<Label>k__BackingField");
			GotoStatement.NativeFieldInfoPtr__DefinedVarsCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, "<DefinedVarsCount>k__BackingField");
			GotoStatement.NativeFieldInfoPtr__LastDefinedVarName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, "<LastDefinedVarName>k__BackingField");
			GotoStatement.NativeFieldInfoPtr_m_Jump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, "m_Jump");
			GotoStatement.NativeFieldInfoPtr_m_LabelAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, "m_LabelAddress");
			GotoStatement.NativeMethodInfoPtr_get_SourceRef_Internal_get_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665143);
			GotoStatement.NativeMethodInfoPtr_set_SourceRef_Private_set_Void_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665144);
			GotoStatement.NativeMethodInfoPtr_get_GotoToken_Internal_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665145);
			GotoStatement.NativeMethodInfoPtr_set_GotoToken_Private_set_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665146);
			GotoStatement.NativeMethodInfoPtr_get_Label_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665147);
			GotoStatement.NativeMethodInfoPtr_set_Label_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665148);
			GotoStatement.NativeMethodInfoPtr_get_DefinedVarsCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665149);
			GotoStatement.NativeMethodInfoPtr_set_DefinedVarsCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665150);
			GotoStatement.NativeMethodInfoPtr_get_LastDefinedVarName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665151);
			GotoStatement.NativeMethodInfoPtr_set_LastDefinedVarName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665152);
			GotoStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665153);
			GotoStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665154);
			GotoStatement.NativeMethodInfoPtr_SetDefinedVars_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665155);
			GotoStatement.NativeMethodInfoPtr_SetAddress_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr, 100665156);
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0003D8A4 File Offset: 0x0003BAA4
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0003D8E4 File Offset: 0x0003BAE4
		public unsafe SourceRef SourceRef
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_get_SourceRef_Internal_get_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_set_SourceRef_Private_set_Void_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0003D928 File Offset: 0x0003BB28
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0003D968 File Offset: 0x0003BB68
		public unsafe Token GotoToken
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_get_GotoToken_Internal_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_set_GotoToken_Private_set_Void_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0003D9AC File Offset: 0x0003BBAC
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x0003D9E4 File Offset: 0x0003BBE4
		public unsafe string Label
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_get_Label_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21549, RefRangeEnd = 21556, XrefRangeStart = 21549, XrefRangeEnd = 21556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_set_Label_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0003DA28 File Offset: 0x0003BC28
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0003DA64 File Offset: 0x0003BC64
		public unsafe int DefinedVarsCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_get_DefinedVarsCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_set_DefinedVarsCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0003DAA4 File Offset: 0x0003BCA4
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0003DADC File Offset: 0x0003BCDC
		public unsafe string LastDefinedVarName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_get_LastDefinedVarName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_set_LastDefinedVarName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0003DB20 File Offset: 0x0003BD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30213, XrefRangeEnd = 30230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GotoStatement(ScriptLoadingContext lcontext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GotoStatement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lcontext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0003DB6C File Offset: 0x0003BD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30230, XrefRangeEnd = 30233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Compile(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GotoStatement.NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0003DBBC File Offset: 0x0003BDBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30234, RefRangeEnd = 30235, XrefRangeStart = 30233, XrefRangeEnd = 30234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_SetDefinedVars_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0003DC0C File Offset: 0x0003BE0C
		[CallerCount(0)]
		public unsafe void SetAddress(int labelAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelAddress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GotoStatement.NativeMethodInfoPtr_SetAddress_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00004E3F File Offset: 0x0000303F
		public GotoStatement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0003DC4C File Offset: 0x0003BE4C
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00004E48 File Offset: 0x00003048
		public unsafe SourceRef _SourceRef_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__SourceRef_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__SourceRef_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0003DC7C File Offset: 0x0003BE7C
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x00004E67 File Offset: 0x00003067
		public unsafe Token _GotoToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__GotoToken_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Token>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__GotoToken_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0003DCAC File Offset: 0x0003BEAC
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x00004E86 File Offset: 0x00003086
		public unsafe string _Label_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__Label_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__Label_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0003DCD4 File Offset: 0x0003BED4
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x00004EA5 File Offset: 0x000030A5
		public unsafe int _DefinedVarsCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__DefinedVarsCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__DefinedVarsCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0003DCFC File Offset: 0x0003BEFC
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00004EC0 File Offset: 0x000030C0
		public unsafe string _LastDefinedVarName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__LastDefinedVarName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr__LastDefinedVarName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0003DD24 File Offset: 0x0003BF24
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00004EDF File Offset: 0x000030DF
		public unsafe Instruction m_Jump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr_m_Jump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr_m_Jump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0003DD54 File Offset: 0x0003BF54
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00004EFE File Offset: 0x000030FE
		public unsafe int m_LabelAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr_m_LabelAddress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GotoStatement.NativeFieldInfoPtr_m_LabelAddress)) = value;
			}
		}

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr__SourceRef_k__BackingField;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr__GotoToken_k__BackingField;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr__Label_k__BackingField;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr__DefinedVarsCount_k__BackingField;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr__LastDefinedVarName_k__BackingField;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeFieldInfoPtr_m_Jump;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeFieldInfoPtr_m_LabelAddress;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceRef_Internal_get_SourceRef_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceRef_Private_set_Void_SourceRef_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_get_GotoToken_Internal_get_Token_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_set_GotoToken_Private_set_Void_Token_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_String_0;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_set_Label_Private_set_Void_String_0;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeMethodInfoPtr_get_DefinedVarsCount_Internal_get_Int32_0;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeMethodInfoPtr_set_DefinedVarsCount_Private_set_Void_Int32_0;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeMethodInfoPtr_get_LastDefinedVarName_Internal_get_String_0;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeMethodInfoPtr_set_LastDefinedVarName_Private_set_Void_String_0;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptLoadingContext_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Public_Virtual_Void_ByteCode_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_SetDefinedVars_Internal_Void_Int32_String_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_SetAddress_Internal_Void_Int32_0;
	}
}
