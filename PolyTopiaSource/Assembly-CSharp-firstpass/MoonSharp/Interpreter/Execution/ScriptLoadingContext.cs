using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Tree;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E5 RID: 229
	public class ScriptLoadingContext : Object
	{
		// Token: 0x0600112D RID: 4397 RVA: 0x0005B400 File Offset: 0x00059600
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptLoadingContext()
		{
			Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution", "ScriptLoadingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr);
			ScriptLoadingContext.NativeFieldInfoPtr__Script_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, "<Script>k__BackingField");
			ScriptLoadingContext.NativeFieldInfoPtr__Scope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, "<Scope>k__BackingField");
			ScriptLoadingContext.NativeFieldInfoPtr__Source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, "<Source>k__BackingField");
			ScriptLoadingContext.NativeFieldInfoPtr__Anonymous_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, "<Anonymous>k__BackingField");
			ScriptLoadingContext.NativeFieldInfoPtr__IsDynamicExpression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, "<IsDynamicExpression>k__BackingField");
			ScriptLoadingContext.NativeFieldInfoPtr__Lexer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, "<Lexer>k__BackingField");
			ScriptLoadingContext.NativeMethodInfoPtr_get_Script_Public_get_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666352);
			ScriptLoadingContext.NativeMethodInfoPtr_set_Script_Private_set_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666353);
			ScriptLoadingContext.NativeMethodInfoPtr_get_Scope_Public_get_BuildTimeScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666354);
			ScriptLoadingContext.NativeMethodInfoPtr_set_Scope_Public_set_Void_BuildTimeScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666355);
			ScriptLoadingContext.NativeMethodInfoPtr_get_Source_Public_get_SourceCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666356);
			ScriptLoadingContext.NativeMethodInfoPtr_set_Source_Public_set_Void_SourceCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666357);
			ScriptLoadingContext.NativeMethodInfoPtr_get_Anonymous_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666358);
			ScriptLoadingContext.NativeMethodInfoPtr_set_Anonymous_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666359);
			ScriptLoadingContext.NativeMethodInfoPtr_get_IsDynamicExpression_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666360);
			ScriptLoadingContext.NativeMethodInfoPtr_set_IsDynamicExpression_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666361);
			ScriptLoadingContext.NativeMethodInfoPtr_get_Lexer_Public_get_Lexer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666362);
			ScriptLoadingContext.NativeMethodInfoPtr_set_Lexer_Public_set_Void_Lexer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666363);
			ScriptLoadingContext.NativeMethodInfoPtr__ctor_Public_Void_Script_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr, 100666364);
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0005B5AC File Offset: 0x000597AC
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x0005B5EC File Offset: 0x000597EC
		public unsafe Script Script
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_get_Script_Public_get_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Script>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_set_Script_Private_set_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0005B630 File Offset: 0x00059830
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x0005B670 File Offset: 0x00059870
		public unsafe BuildTimeScope Scope
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_get_Scope_Public_get_BuildTimeScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildTimeScope>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_set_Scope_Public_set_Void_BuildTimeScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0005B6B4 File Offset: 0x000598B4
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x0005B6F4 File Offset: 0x000598F4
		public unsafe SourceCode Source
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_get_Source_Public_get_SourceCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceCode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_set_Source_Public_set_Void_SourceCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x0005B738 File Offset: 0x00059938
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x0005B774 File Offset: 0x00059974
		public unsafe bool Anonymous
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_get_Anonymous_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_set_Anonymous_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0005B7B4 File Offset: 0x000599B4
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x0005B7F0 File Offset: 0x000599F0
		public unsafe bool IsDynamicExpression
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_get_IsDynamicExpression_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_set_IsDynamicExpression_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0005B830 File Offset: 0x00059A30
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x0005B870 File Offset: 0x00059A70
		public unsafe Lexer Lexer
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_get_Lexer_Public_get_Lexer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lexer>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr_set_Lexer_Public_set_Void_Lexer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0005B8B4 File Offset: 0x00059AB4
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43098, XrefRangeEnd = 43100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptLoadingContext(Script s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptLoadingContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoadingContext.NativeMethodInfoPtr__ctor_Public_Void_Script_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0000721A File Offset: 0x0000541A
		public ScriptLoadingContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0005B900 File Offset: 0x00059B00
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x00007223 File Offset: 0x00005423
		public unsafe Script _Script_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Script_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Script_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0005B930 File Offset: 0x00059B30
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x00007242 File Offset: 0x00005442
		public unsafe BuildTimeScope _Scope_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Scope_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildTimeScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Scope_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0005B960 File Offset: 0x00059B60
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x00007261 File Offset: 0x00005461
		public unsafe SourceCode _Source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0005B990 File Offset: 0x00059B90
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x00007280 File Offset: 0x00005480
		public unsafe bool _Anonymous_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Anonymous_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Anonymous_k__BackingField)) = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x0005B9B8 File Offset: 0x00059BB8
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x0000729B File Offset: 0x0000549B
		public unsafe bool _IsDynamicExpression_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__IsDynamicExpression_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__IsDynamicExpression_k__BackingField)) = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x0005B9E0 File Offset: 0x00059BE0
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x000072B6 File Offset: 0x000054B6
		public unsafe Lexer _Lexer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Lexer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lexer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoadingContext.NativeFieldInfoPtr__Lexer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeFieldInfoPtr__Script_k__BackingField;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeFieldInfoPtr__Scope_k__BackingField;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeFieldInfoPtr__Source_k__BackingField;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeFieldInfoPtr__Anonymous_k__BackingField;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeFieldInfoPtr__IsDynamicExpression_k__BackingField;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeFieldInfoPtr__Lexer_k__BackingField;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_get_Script_Public_get_Script_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_set_Script_Private_set_Void_Script_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_get_Scope_Public_get_BuildTimeScope_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_set_Scope_Public_set_Void_BuildTimeScope_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_get_SourceCode_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_set_Void_SourceCode_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_get_Anonymous_Public_get_Boolean_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_set_Anonymous_Public_set_Void_Boolean_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDynamicExpression_Public_get_Boolean_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDynamicExpression_Public_set_Void_Boolean_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_get_Lexer_Public_get_Lexer_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_set_Lexer_Public_set_Void_Lexer_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Script_0;
	}
}
