using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000F9 RID: 249
	public class DebuggerAction : Object
	{
		// Token: 0x060012D9 RID: 4825 RVA: 0x000623D4 File Offset: 0x000605D4
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerAction()
		{
			Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Debugging", "DebuggerAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr);
			DebuggerAction.NativeFieldInfoPtr__Action_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, "<Action>k__BackingField");
			DebuggerAction.NativeFieldInfoPtr__TimeStampUTC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, "<TimeStampUTC>k__BackingField");
			DebuggerAction.NativeFieldInfoPtr__SourceID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, "<SourceID>k__BackingField");
			DebuggerAction.NativeFieldInfoPtr__SourceLine_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, "<SourceLine>k__BackingField");
			DebuggerAction.NativeFieldInfoPtr__SourceCol_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, "<SourceCol>k__BackingField");
			DebuggerAction.NativeFieldInfoPtr__Lines_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, "<Lines>k__BackingField");
			DebuggerAction.NativeMethodInfoPtr_get_Action_Public_get_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666600);
			DebuggerAction.NativeMethodInfoPtr_set_Action_Public_set_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666601);
			DebuggerAction.NativeMethodInfoPtr_get_TimeStampUTC_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666602);
			DebuggerAction.NativeMethodInfoPtr_set_TimeStampUTC_Private_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666603);
			DebuggerAction.NativeMethodInfoPtr_get_SourceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666604);
			DebuggerAction.NativeMethodInfoPtr_set_SourceID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666605);
			DebuggerAction.NativeMethodInfoPtr_get_SourceLine_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666606);
			DebuggerAction.NativeMethodInfoPtr_set_SourceLine_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666607);
			DebuggerAction.NativeMethodInfoPtr_get_SourceCol_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666608);
			DebuggerAction.NativeMethodInfoPtr_set_SourceCol_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666609);
			DebuggerAction.NativeMethodInfoPtr_get_Lines_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666610);
			DebuggerAction.NativeMethodInfoPtr_set_Lines_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666611);
			DebuggerAction.NativeMethodInfoPtr_get_Age_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666613);
			DebuggerAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666612);
			DebuggerAction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr, 100666614);
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000625A8 File Offset: 0x000607A8
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x000625E4 File Offset: 0x000607E4
		public unsafe DebuggerAction.ActionType Action
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_get_Action_Public_get_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_set_Action_Public_set_Void_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00062624 File Offset: 0x00060824
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x00062664 File Offset: 0x00060864
		public unsafe DateTime TimeStampUTC
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_get_TimeStampUTC_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTime>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 46308, RefRangeEnd = 46317, XrefRangeStart = 46308, XrefRangeEnd = 46317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_set_TimeStampUTC_Private_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x000626A8 File Offset: 0x000608A8
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x000626E4 File Offset: 0x000608E4
		public unsafe int SourceID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_get_SourceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_set_SourceID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x00062724 File Offset: 0x00060924
		// (set) Token: 0x060012E1 RID: 4833 RVA: 0x00062760 File Offset: 0x00060960
		public unsafe int SourceLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_get_SourceLine_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_set_SourceLine_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x000627A0 File Offset: 0x000609A0
		// (set) Token: 0x060012E3 RID: 4835 RVA: 0x000627DC File Offset: 0x000609DC
		public unsafe int SourceCol
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_get_SourceCol_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_set_SourceCol_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x0006281C File Offset: 0x00060A1C
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x0006285C File Offset: 0x00060A5C
		public unsafe Il2CppStructArray<int> Lines
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_get_Lines_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_set_Lines_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x000628A0 File Offset: 0x00060AA0
		public unsafe TimeSpan Age
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46480, XrefRangeEnd = 46485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr_get_Age_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeSpan>(intPtr3) : null;
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000628E0 File Offset: 0x00060AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46485, XrefRangeEnd = 46490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0006291C File Offset: 0x00060B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46490, XrefRangeEnd = 46495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebuggerAction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00007C0C File Offset: 0x00005E0C
		public DebuggerAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x00062960 File Offset: 0x00060B60
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x00007C15 File Offset: 0x00005E15
		public unsafe DebuggerAction.ActionType _Action_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__Action_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__Action_k__BackingField)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00062988 File Offset: 0x00060B88
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x00007C30 File Offset: 0x00005E30
		public unsafe DateTime _TimeStampUTC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__TimeStampUTC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__TimeStampUTC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000629B8 File Offset: 0x00060BB8
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x00007C4F File Offset: 0x00005E4F
		public unsafe int _SourceID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__SourceID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__SourceID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000629E0 File Offset: 0x00060BE0
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x00007C6A File Offset: 0x00005E6A
		public unsafe int _SourceLine_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__SourceLine_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__SourceLine_k__BackingField)) = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x00062A08 File Offset: 0x00060C08
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x00007C85 File Offset: 0x00005E85
		public unsafe int _SourceCol_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__SourceCol_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__SourceCol_k__BackingField)) = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00062A30 File Offset: 0x00060C30
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x00007CA0 File Offset: 0x00005EA0
		public unsafe Il2CppStructArray<int> _Lines_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__Lines_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerAction.NativeFieldInfoPtr__Lines_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeFieldInfoPtr__Action_k__BackingField;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeFieldInfoPtr__TimeStampUTC_k__BackingField;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeFieldInfoPtr__SourceID_k__BackingField;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeFieldInfoPtr__SourceLine_k__BackingField;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeFieldInfoPtr__SourceCol_k__BackingField;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeFieldInfoPtr__Lines_k__BackingField;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_get_Action_Public_get_ActionType_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_set_Action_Public_set_Void_ActionType_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeStampUTC_Public_get_DateTime_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeStampUTC_Private_set_Void_DateTime_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceID_Public_get_Int32_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceID_Public_set_Void_Int32_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceLine_Public_get_Int32_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceLine_Public_set_Void_Int32_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceCol_Public_get_Int32_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceCol_Public_set_Void_Int32_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_get_Lines_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_set_Lines_Public_set_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_get_Age_Public_get_TimeSpan_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020001E5 RID: 485
		public enum ActionType
		{
			// Token: 0x04001733 RID: 5939
			ByteCodeStepIn,
			// Token: 0x04001734 RID: 5940
			ByteCodeStepOver,
			// Token: 0x04001735 RID: 5941
			ByteCodeStepOut,
			// Token: 0x04001736 RID: 5942
			StepIn,
			// Token: 0x04001737 RID: 5943
			StepOver,
			// Token: 0x04001738 RID: 5944
			StepOut,
			// Token: 0x04001739 RID: 5945
			Run,
			// Token: 0x0400173A RID: 5946
			ToggleBreakpoint,
			// Token: 0x0400173B RID: 5947
			SetBreakpoint,
			// Token: 0x0400173C RID: 5948
			ClearBreakpoint,
			// Token: 0x0400173D RID: 5949
			ResetBreakpoints,
			// Token: 0x0400173E RID: 5950
			Refresh,
			// Token: 0x0400173F RID: 5951
			HardRefresh,
			// Token: 0x04001740 RID: 5952
			None
		}
	}
}
