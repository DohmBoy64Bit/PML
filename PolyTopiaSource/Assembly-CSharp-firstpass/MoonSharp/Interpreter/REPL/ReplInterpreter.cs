using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.REPL
{
	// Token: 0x02000086 RID: 134
	public class ReplInterpreter : Object
	{
		// Token: 0x06000B93 RID: 2963 RVA: 0x000426BC File Offset: 0x000408BC
		// Note: this type is marked as 'beforefieldinit'.
		static ReplInterpreter()
		{
			Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.REPL", "ReplInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr);
			ReplInterpreter.NativeFieldInfoPtr_m_Script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, "m_Script");
			ReplInterpreter.NativeFieldInfoPtr_m_CurrentCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, "m_CurrentCommand");
			ReplInterpreter.NativeFieldInfoPtr__HandleDynamicExprs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, "<HandleDynamicExprs>k__BackingField");
			ReplInterpreter.NativeFieldInfoPtr__HandleClassicExprsSyntax_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, "<HandleClassicExprsSyntax>k__BackingField");
			ReplInterpreter.NativeMethodInfoPtr_get_HandleDynamicExprs_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, 100665294);
			ReplInterpreter.NativeMethodInfoPtr_set_HandleDynamicExprs_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, 100665295);
			ReplInterpreter.NativeMethodInfoPtr_get_HandleClassicExprsSyntax_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, 100665296);
			ReplInterpreter.NativeMethodInfoPtr_set_HandleClassicExprsSyntax_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, 100665297);
			ReplInterpreter.NativeMethodInfoPtr_get_HasPendingCommand_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, 100665298);
			ReplInterpreter.NativeMethodInfoPtr_get_CurrentPendingCommand_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, 100665299);
			ReplInterpreter.NativeMethodInfoPtr_get_ClassicPrompt_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, 100665300);
			ReplInterpreter.NativeMethodInfoPtr__ctor_Public_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, 100665293);
			ReplInterpreter.NativeMethodInfoPtr_Evaluate_Public_Virtual_New_DynValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr, 100665301);
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x000427F0 File Offset: 0x000409F0
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0004282C File Offset: 0x00040A2C
		public unsafe bool HandleDynamicExprs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplInterpreter.NativeMethodInfoPtr_get_HandleDynamicExprs_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplInterpreter.NativeMethodInfoPtr_set_HandleDynamicExprs_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0004286C File Offset: 0x00040A6C
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x000428A8 File Offset: 0x00040AA8
		public unsafe bool HandleClassicExprsSyntax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplInterpreter.NativeMethodInfoPtr_get_HandleClassicExprsSyntax_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplInterpreter.NativeMethodInfoPtr_set_HandleClassicExprsSyntax_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x000428E8 File Offset: 0x00040AE8
		public unsafe virtual bool HasPendingCommand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplInterpreter.NativeMethodInfoPtr_get_HasPendingCommand_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00042930 File Offset: 0x00040B30
		public unsafe virtual string CurrentPendingCommand
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplInterpreter.NativeMethodInfoPtr_get_CurrentPendingCommand_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00042974 File Offset: 0x00040B74
		public unsafe virtual string ClassicPrompt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32110, XrefRangeEnd = 32114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplInterpreter.NativeMethodInfoPtr_get_ClassicPrompt_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000429B8 File Offset: 0x00040BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32118, RefRangeEnd = 32119, XrefRangeStart = 32114, XrefRangeEnd = 32118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplInterpreter(Script script)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplInterpreter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplInterpreter.NativeMethodInfoPtr__ctor_Public_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00042A04 File Offset: 0x00040C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32152, RefRangeEnd = 32153, XrefRangeStart = 32119, XrefRangeEnd = 32152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue Evaluate(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplInterpreter.NativeMethodInfoPtr_Evaluate_Public_Virtual_New_DynValue_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00005825 File Offset: 0x00003A25
		public ReplInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00042A60 File Offset: 0x00040C60
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x0000582E File Offset: 0x00003A2E
		public unsafe Script m_Script
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplInterpreter.NativeFieldInfoPtr_m_Script);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplInterpreter.NativeFieldInfoPtr_m_Script), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00042A90 File Offset: 0x00040C90
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0000584D File Offset: 0x00003A4D
		public unsafe string m_CurrentCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplInterpreter.NativeFieldInfoPtr_m_CurrentCommand);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplInterpreter.NativeFieldInfoPtr_m_CurrentCommand), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00042AB8 File Offset: 0x00040CB8
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0000586C File Offset: 0x00003A6C
		public unsafe bool _HandleDynamicExprs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplInterpreter.NativeFieldInfoPtr__HandleDynamicExprs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplInterpreter.NativeFieldInfoPtr__HandleDynamicExprs_k__BackingField)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00042AE0 File Offset: 0x00040CE0
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00005887 File Offset: 0x00003A87
		public unsafe bool _HandleClassicExprsSyntax_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplInterpreter.NativeFieldInfoPtr__HandleClassicExprsSyntax_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplInterpreter.NativeFieldInfoPtr__HandleClassicExprsSyntax_k__BackingField)) = value;
			}
		}

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeFieldInfoPtr_m_Script;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCommand;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeFieldInfoPtr__HandleDynamicExprs_k__BackingField;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeFieldInfoPtr__HandleClassicExprsSyntax_k__BackingField;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleDynamicExprs_Public_get_Boolean_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_set_HandleDynamicExprs_Public_set_Void_Boolean_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleClassicExprsSyntax_Public_get_Boolean_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_set_HandleClassicExprsSyntax_Public_set_Void_Boolean_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPendingCommand_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPendingCommand_Public_Virtual_New_get_String_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_get_ClassicPrompt_Public_Virtual_New_get_String_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Script_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_New_DynValue_String_0;
	}
}
