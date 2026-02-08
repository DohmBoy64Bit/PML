using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AE RID: 174
	public class DynValueMemberDescriptor : Object
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x0004A2E4 File Offset: 0x000484E4
		// Note: this type is marked as 'beforefieldinit'.
		static DynValueMemberDescriptor()
		{
			Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "DynValueMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr);
			DynValueMemberDescriptor.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, "m_Value");
			DynValueMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, "<Name>k__BackingField");
			DynValueMemberDescriptor.NativeFieldInfoPtr__MemberAccess_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, "<MemberAccess>k__BackingField");
			DynValueMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665589);
			DynValueMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665590);
			DynValueMemberDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665591);
			DynValueMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665592);
			DynValueMemberDescriptor.NativeMethodInfoPtr_set_MemberAccess_Private_set_Void_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665593);
			DynValueMemberDescriptor.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665594);
			DynValueMemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665586);
			DynValueMemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665587);
			DynValueMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665588);
			DynValueMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665595);
			DynValueMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665596);
			DynValueMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr, 100665597);
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0004A440 File Offset: 0x00048640
		public unsafe virtual bool IsStatic
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0004A47C File Offset: 0x0004867C
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x0004A4B4 File Offset: 0x000486B4
		public unsafe virtual string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0004A4F8 File Offset: 0x000486F8
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x0004A538 File Offset: 0x00048738
		public unsafe virtual MemberDescriptorAccess MemberAccess
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberDescriptorAccess>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr_set_MemberAccess_Private_set_Void_MemberDescriptorAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0004A57C File Offset: 0x0004877C
		public unsafe virtual DynValue Value
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynValueMemberDescriptor.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_DynValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0004A5C8 File Offset: 0x000487C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33975, XrefRangeEnd = 33986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValueMemberDescriptor(string name, string serializedTableValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(serializedTableValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0004A628 File Offset: 0x00048828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33986, XrefRangeEnd = 33989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValueMemberDescriptor(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0004A674 File Offset: 0x00048874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33992, RefRangeEnd = 33993, XrefRangeStart = 33989, XrefRangeEnd = 33992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValueMemberDescriptor(string name, DynValue value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynValueMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0004A6D4 File Offset: 0x000488D4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 33993, RefRangeEnd = 34014, XrefRangeStart = 33993, XrefRangeEnd = 33993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue GetValue(Script script, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0004A738 File Offset: 0x00048938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34014, XrefRangeEnd = 34026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(Script script, Object obj, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0004A7A0 File Offset: 0x000489A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34026, XrefRangeEnd = 34089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareForWiring(Table t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynValueMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00005ED9 File Offset: 0x000040D9
		public DynValueMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0004A7E4 File Offset: 0x000489E4
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x00005EE2 File Offset: 0x000040E2
		public unsafe DynValue m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValueMemberDescriptor.NativeFieldInfoPtr_m_Value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValueMemberDescriptor.NativeFieldInfoPtr_m_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0004A814 File Offset: 0x00048A14
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x00005F01 File Offset: 0x00004101
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValueMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValueMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0004A83C File Offset: 0x00048A3C
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x00005F20 File Offset: 0x00004120
		public unsafe MemberDescriptorAccess _MemberAccess_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValueMemberDescriptor.NativeFieldInfoPtr__MemberAccess_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberDescriptorAccess>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynValueMemberDescriptor.NativeFieldInfoPtr__MemberAccess_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeFieldInfoPtr__MemberAccess_k__BackingField;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberAccess_Private_set_Void_MemberDescriptorAccess_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_DynValue_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DynValue_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0;
	}
}
