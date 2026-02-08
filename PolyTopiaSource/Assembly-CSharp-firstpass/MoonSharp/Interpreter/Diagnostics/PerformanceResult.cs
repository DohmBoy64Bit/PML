using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Diagnostics
{
	// Token: 0x020000F2 RID: 242
	public class PerformanceResult : Object
	{
		// Token: 0x06001287 RID: 4743 RVA: 0x0006134C File Offset: 0x0005F54C
		// Note: this type is marked as 'beforefieldinit'.
		static PerformanceResult()
		{
			Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Diagnostics", "PerformanceResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr);
			PerformanceResult.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, "<Name>k__BackingField");
			PerformanceResult.NativeFieldInfoPtr__Counter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, "<Counter>k__BackingField");
			PerformanceResult.NativeFieldInfoPtr__Instances_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, "<Instances>k__BackingField");
			PerformanceResult.NativeFieldInfoPtr__Global_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, "<Global>k__BackingField");
			PerformanceResult.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, "<Type>k__BackingField");
			PerformanceResult.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666562);
			PerformanceResult.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666563);
			PerformanceResult.NativeMethodInfoPtr_get_Counter_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666564);
			PerformanceResult.NativeMethodInfoPtr_set_Counter_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666565);
			PerformanceResult.NativeMethodInfoPtr_get_Instances_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666566);
			PerformanceResult.NativeMethodInfoPtr_set_Instances_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666567);
			PerformanceResult.NativeMethodInfoPtr_get_Global_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666568);
			PerformanceResult.NativeMethodInfoPtr_set_Global_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666569);
			PerformanceResult.NativeMethodInfoPtr_get_Type_Public_get_PerformanceCounterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666570);
			PerformanceResult.NativeMethodInfoPtr_set_Type_Internal_set_Void_PerformanceCounterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666571);
			PerformanceResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666574);
			PerformanceResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666572);
			PerformanceResult.NativeMethodInfoPtr_PerformanceCounterTypeToString_Public_Static_String_PerformanceCounterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr, 100666573);
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x000614E4 File Offset: 0x0005F6E4
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x0006151C File Offset: 0x0005F71C
		public unsafe string Name
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x00061560 File Offset: 0x0005F760
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x0006159C File Offset: 0x0005F79C
		public unsafe long Counter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_get_Counter_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 46308, RefRangeEnd = 46317, XrefRangeStart = 46308, XrefRangeEnd = 46308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_set_Counter_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x000615DC File Offset: 0x0005F7DC
		// (set) Token: 0x0600128D RID: 4749 RVA: 0x00061618 File Offset: 0x0005F818
		public unsafe int Instances
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_get_Instances_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_set_Instances_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x00061658 File Offset: 0x0005F858
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x00061694 File Offset: 0x0005F894
		public unsafe bool Global
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_get_Global_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_set_Global_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x000616D4 File Offset: 0x0005F8D4
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x00061714 File Offset: 0x0005F914
		public unsafe PerformanceCounterType Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_get_Type_Public_get_PerformanceCounterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PerformanceCounterType>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_set_Type_Internal_set_Void_PerformanceCounterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00061758 File Offset: 0x0005F958
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerformanceResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformanceResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00061794 File Offset: 0x0005F994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46317, XrefRangeEnd = 46346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PerformanceResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x000617D8 File Offset: 0x0005F9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46346, XrefRangeEnd = 46349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PerformanceCounterTypeToString(PerformanceCounterType Type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceResult.NativeMethodInfoPtr_PerformanceCounterTypeToString_Public_Static_String_PerformanceCounterType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x000079D3 File Offset: 0x00005BD3
		public PerformanceResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00061814 File Offset: 0x0005FA14
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x000079DC File Offset: 0x00005BDC
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x0006183C File Offset: 0x0005FA3C
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x000079FB File Offset: 0x00005BFB
		public unsafe long _Counter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Counter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Counter_k__BackingField)) = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x00061864 File Offset: 0x0005FA64
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x00007A16 File Offset: 0x00005C16
		public unsafe int _Instances_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Instances_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Instances_k__BackingField)) = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x0006188C File Offset: 0x0005FA8C
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x00007A31 File Offset: 0x00005C31
		public unsafe bool _Global_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Global_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Global_k__BackingField)) = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x000618B4 File Offset: 0x0005FAB4
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x00007A4C File Offset: 0x00005C4C
		public unsafe PerformanceCounterType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PerformanceCounterType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceResult.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeFieldInfoPtr__Counter_k__BackingField;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeFieldInfoPtr__Instances_k__BackingField;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeFieldInfoPtr__Global_k__BackingField;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_get_Counter_Public_get_Int64_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_set_Counter_Internal_set_Void_Int64_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_get_Instances_Public_get_Int32_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_set_Instances_Internal_set_Void_Int32_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_get_Global_Public_get_Boolean_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_set_Global_Internal_set_Void_Boolean_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_PerformanceCounterType_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Internal_set_Void_PerformanceCounterType_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_PerformanceCounterTypeToString_Public_Static_String_PerformanceCounterType_0;
	}
}
