using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B9 RID: 185
	public class StandardEnumUserDataDescriptor : DispatchingUserDataDescriptor
	{
		// Token: 0x06000E87 RID: 3719 RVA: 0x0004FBA8 File Offset: 0x0004DDA8
		// Note: this type is marked as 'beforefieldinit'.
		static StandardEnumUserDataDescriptor()
		{
			Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "StandardEnumUserDataDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr);
			StandardEnumUserDataDescriptor.NativeFieldInfoPtr__UnderlyingType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "<UnderlyingType>k__BackingField");
			StandardEnumUserDataDescriptor.NativeFieldInfoPtr__IsUnsigned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "<IsUnsigned>k__BackingField");
			StandardEnumUserDataDescriptor.NativeFieldInfoPtr__IsFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "<IsFlags>k__BackingField");
			StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_EnumToULong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "m_EnumToULong");
			StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_ULongToEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "m_ULongToEnum");
			StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_EnumToLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "m_EnumToLong");
			StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_LongToEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "m_LongToEnum");
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_get_UnderlyingType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665877);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_set_UnderlyingType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665878);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_get_IsUnsigned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665879);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_set_IsUnsigned_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665880);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_get_IsFlags_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665881);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_set_IsFlags_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665882);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppStringArray_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665883);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_FillMemberList_Private_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665884);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_AddEnumMethod_Private_Void_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665885);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_GetValueSigned_Private_Int64_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665886);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_GetValueUnsigned_Private_UInt64_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665887);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_CreateValueSigned_Private_DynValue_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665888);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_CreateValueUnsigned_Private_DynValue_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665889);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_CreateSignedConversionFunctions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665890);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_CreateUnsignedConversionFunctions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665891);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformBinaryOperationS_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_Int64_Int64_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665892);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformBinaryOperationU_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_UInt64_UInt64_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665893);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformBinaryOperationS_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665894);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformBinaryOperationU_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665895);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformUnaryOperationS_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_2_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665896);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformUnaryOperationU_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_2_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665897);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_Or_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665898);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_And_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665899);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_Xor_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665900);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_BwNot_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665901);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_HasAll_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665902);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_HasAny_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665903);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665904);
			StandardEnumUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, 100665905);
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0004FEA8 File Offset: 0x0004E0A8
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x0004FEE8 File Offset: 0x0004E0E8
		public unsafe Type UnderlyingType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_get_UnderlyingType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_set_UnderlyingType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0004FF2C File Offset: 0x0004E12C
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x0004FF68 File Offset: 0x0004E168
		public unsafe bool IsUnsigned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_get_IsUnsigned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_set_IsUnsigned_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0004FFA8 File Offset: 0x0004E1A8
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x0004FFE4 File Offset: 0x0004E1E4
		public unsafe bool IsFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_get_IsFlags_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_set_IsFlags_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00050024 File Offset: 0x0004E224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37428, RefRangeEnd = 37429, XrefRangeStart = 37375, XrefRangeEnd = 37428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardEnumUserDataDescriptor(Type enumType, string friendlyName = null, Il2CppStringArray names = null, Il2CppReferenceArray<Object> values = null, Type underlyingType = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppStringArray_Il2CppReferenceArray_1_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x000500BC File Offset: 0x0004E2BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37429, XrefRangeEnd = 37506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillMemberList(Il2CppStringArray names, Il2CppReferenceArray<Object> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_FillMemberList_Private_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00050110 File Offset: 0x0004E310
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 37516, RefRangeEnd = 37522, XrefRangeStart = 37507, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEnumMethod(string name, DynValue dynValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dynValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_AddEnumMethod_Private_Void_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00050164 File Offset: 0x0004E364
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 37526, RefRangeEnd = 37530, XrefRangeStart = 37522, XrefRangeEnd = 37526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetValueSigned(DynValue dv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dv);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_GetValueSigned_Private_Int64_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x000501B4 File Offset: 0x0004E3B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37534, RefRangeEnd = 37537, XrefRangeStart = 37530, XrefRangeEnd = 37534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetValueUnsigned(DynValue dv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dv);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_GetValueUnsigned_Private_UInt64_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00050204 File Offset: 0x0004E404
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37543, RefRangeEnd = 37546, XrefRangeStart = 37537, XrefRangeEnd = 37543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue CreateValueSigned(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_CreateValueSigned_Private_DynValue_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00050250 File Offset: 0x0004E450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37552, RefRangeEnd = 37554, XrefRangeStart = 37546, XrefRangeEnd = 37552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue CreateValueUnsigned(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_CreateValueUnsigned_Private_DynValue_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0005029C File Offset: 0x0004E49C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37686, RefRangeEnd = 37688, XrefRangeStart = 37554, XrefRangeEnd = 37686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSignedConversionFunctions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_CreateSignedConversionFunctions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000502D0 File Offset: 0x0004E4D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37820, RefRangeEnd = 37822, XrefRangeStart = 37688, XrefRangeEnd = 37820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUnsignedConversionFunctions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_CreateUnsignedConversionFunctions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00050304 File Offset: 0x0004E504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37838, RefRangeEnd = 37841, XrefRangeStart = 37822, XrefRangeEnd = 37838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, DynValue> operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformBinaryOperationS_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_Int64_Int64_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0005038C File Offset: 0x0004E58C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37857, RefRangeEnd = 37860, XrefRangeStart = 37841, XrefRangeEnd = 37857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, DynValue> operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformBinaryOperationU_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_UInt64_UInt64_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00050414 File Offset: 0x0004E614
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37874, RefRangeEnd = 37877, XrefRangeStart = 37860, XrefRangeEnd = 37874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, long> operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformBinaryOperationS_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0005049C File Offset: 0x0004E69C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37891, RefRangeEnd = 37894, XrefRangeStart = 37877, XrefRangeEnd = 37891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, ulong> operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformBinaryOperationU_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_UInt64_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00050524 File Offset: 0x0004E724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37894, XrefRangeEnd = 37909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue PerformUnaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long> operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformUnaryOperationS_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_2_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x000505AC File Offset: 0x0004E7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37909, XrefRangeEnd = 37924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue PerformUnaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong> operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_PerformUnaryOperationU_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_2_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00050634 File Offset: 0x0004E834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37924, XrefRangeEnd = 37958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Callback_Or(ScriptExecutionContext ctx, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_Or_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00050698 File Offset: 0x0004E898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37958, XrefRangeEnd = 37992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Callback_And(ScriptExecutionContext ctx, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_And_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000506FC File Offset: 0x0004E8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37992, XrefRangeEnd = 38026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Callback_Xor(ScriptExecutionContext ctx, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_Xor_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00050760 File Offset: 0x0004E960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38026, XrefRangeEnd = 38048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Callback_BwNot(ScriptExecutionContext ctx, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_BwNot_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000507C4 File Offset: 0x0004E9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38048, XrefRangeEnd = 38082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Callback_HasAll(ScriptExecutionContext ctx, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_HasAll_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00050828 File Offset: 0x0004EA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38082, XrefRangeEnd = 38116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Callback_HasAny(ScriptExecutionContext ctx, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.NativeMethodInfoPtr_Callback_HasAny_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0005088C File Offset: 0x0004EA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38116, XrefRangeEnd = 38120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsTypeCompatible(Type type, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardEnumUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Boolean_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000508F8 File Offset: 0x0004EAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38120, XrefRangeEnd = 38133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynValue MetaIndex(Script script, Object obj, string metaname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(metaname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardEnumUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_DynValue_Script_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0000667B File Offset: 0x0000487B
		public StandardEnumUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00050978 File Offset: 0x0004EB78
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x00006684 File Offset: 0x00004884
		public unsafe Type _UnderlyingType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr__UnderlyingType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr__UnderlyingType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x000509A8 File Offset: 0x0004EBA8
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x000066A3 File Offset: 0x000048A3
		public unsafe bool _IsUnsigned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr__IsUnsigned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr__IsUnsigned_k__BackingField)) = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x000509D0 File Offset: 0x0004EBD0
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x000066BE File Offset: 0x000048BE
		public unsafe bool _IsFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr__IsFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr__IsFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x000509F8 File Offset: 0x0004EBF8
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x000066D9 File Offset: 0x000048D9
		public unsafe Func<Object, ulong> m_EnumToULong
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_EnumToULong);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_EnumToULong), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00050A28 File Offset: 0x0004EC28
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x000066F8 File Offset: 0x000048F8
		public unsafe Func<ulong, Object> m_ULongToEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_ULongToEnum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_ULongToEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00050A58 File Offset: 0x0004EC58
		// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x00006717 File Offset: 0x00004917
		public unsafe Func<Object, long> m_EnumToLong
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_EnumToLong);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_EnumToLong), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00050A88 File Offset: 0x0004EC88
		// (set) Token: 0x06000EB3 RID: 3763 RVA: 0x00006736 File Offset: 0x00004936
		public unsafe Func<long, Object> m_LongToEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_LongToEnum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.NativeFieldInfoPtr_m_LongToEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr__UnderlyingType_k__BackingField;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeFieldInfoPtr__IsUnsigned_k__BackingField;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeFieldInfoPtr__IsFlags_k__BackingField;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeFieldInfoPtr_m_EnumToULong;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeFieldInfoPtr_m_ULongToEnum;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr_m_EnumToLong;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeFieldInfoPtr_m_LongToEnum;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingType_Public_get_Type_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_set_UnderlyingType_Private_set_Void_Type_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnsigned_Public_get_Boolean_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnsigned_Private_set_Void_Boolean_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFlags_Public_get_Boolean_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFlags_Private_set_Void_Boolean_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppStringArray_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_FillMemberList_Private_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr_AddEnumMethod_Private_Void_String_DynValue_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_GetValueSigned_Private_Int64_DynValue_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_GetValueUnsigned_Private_UInt64_DynValue_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueSigned_Private_DynValue_Int64_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueUnsigned_Private_DynValue_UInt64_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_CreateSignedConversionFunctions_Private_Void_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnsignedConversionFunctions_Private_Void_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_PerformBinaryOperationS_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_Int64_Int64_DynValue_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_PerformBinaryOperationU_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_UInt64_UInt64_DynValue_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_PerformBinaryOperationS_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_Int64_Int64_Int64_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_PerformBinaryOperationU_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_3_UInt64_UInt64_UInt64_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_PerformUnaryOperationS_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_2_Int64_Int64_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_PerformUnaryOperationU_Private_DynValue_String_ScriptExecutionContext_CallbackArguments_Func_2_UInt64_UInt64_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_Callback_Or_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_Callback_And_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_Callback_Xor_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_Callback_BwNot_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_Callback_HasAll_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_Callback_HasAny_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Boolean_Type_Object_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Virtual_DynValue_Script_Object_String_0;

		// Token: 0x020001CD RID: 461
		[ObfuscatedName("MoonSharp.Interpreter.Interop.StandardEnumUserDataDescriptor+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001BF1 RID: 7153 RVA: 0x000880AC File Offset: 0x000862AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr);
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__23_0");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__23_1");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__23_2");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__23_3");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__23_4");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__23_5");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__23_6");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__23_7");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__24_0");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__24_1");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__24_2");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__24_3");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__24_4");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__24_5");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__24_6");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__24_7");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__31_0");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__31_1");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__32_0");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__32_1");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__33_0");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__33_1");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__34_0");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__34_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__34_1");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__35_0");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__35_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__35_1");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__36_0");
				StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__36_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, "<>9__36_1");
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665907);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_0_Internal_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665908);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_1_Internal_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665909);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_2_Internal_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665910);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_3_Internal_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665911);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_4_Internal_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665912);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_5_Internal_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665913);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_6_Internal_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665914);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_7_Internal_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665915);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_0_Internal_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665916);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_1_Internal_Object_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665917);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_2_Internal_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665918);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_3_Internal_Object_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665919);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_4_Internal_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665920);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_5_Internal_Object_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665921);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_6_Internal_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665922);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_7_Internal_Object_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665923);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_Or_b__31_0_Internal_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665924);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_Or_b__31_1_Internal_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665925);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_And_b__32_0_Internal_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665926);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_And_b__32_1_Internal_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665927);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_Xor_b__33_0_Internal_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665928);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_Xor_b__33_1_Internal_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665929);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_BwNot_b__34_0_Internal_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665930);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_BwNot_b__34_1_Internal_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665931);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_HasAll_b__35_0_Internal_DynValue_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665932);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_HasAll_b__35_1_Internal_DynValue_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665933);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_HasAny_b__36_0_Internal_DynValue_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665934);
				StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_HasAny_b__36_1_Internal_DynValue_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr, 100665935);
			}

			// Token: 0x06001BF2 RID: 7154 RVA: 0x00088560 File Offset: 0x00086760
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BF3 RID: 7155 RVA: 0x0008859C File Offset: 0x0008679C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37323, XrefRangeEnd = 37325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long _CreateSignedConversionFunctions_b__23_0(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_0_Internal_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BF4 RID: 7156 RVA: 0x000885EC File Offset: 0x000867EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37325, XrefRangeEnd = 37327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateSignedConversionFunctions_b__23_1(long o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref o;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_1_Internal_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BF5 RID: 7157 RVA: 0x00088638 File Offset: 0x00086838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37327, XrefRangeEnd = 37329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long _CreateSignedConversionFunctions_b__23_2(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_2_Internal_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BF6 RID: 7158 RVA: 0x00088688 File Offset: 0x00086888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37329, XrefRangeEnd = 37331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateSignedConversionFunctions_b__23_3(long o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref o;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_3_Internal_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BF7 RID: 7159 RVA: 0x000886D4 File Offset: 0x000868D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37331, XrefRangeEnd = 37333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long _CreateSignedConversionFunctions_b__23_4(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_4_Internal_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BF8 RID: 7160 RVA: 0x00088724 File Offset: 0x00086924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37333, XrefRangeEnd = 37335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateSignedConversionFunctions_b__23_5(long o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref o;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_5_Internal_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BF9 RID: 7161 RVA: 0x00088770 File Offset: 0x00086970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37335, XrefRangeEnd = 37337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long _CreateSignedConversionFunctions_b__23_6(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_6_Internal_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BFA RID: 7162 RVA: 0x000887C0 File Offset: 0x000869C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37337, XrefRangeEnd = 37339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateSignedConversionFunctions_b__23_7(long o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref o;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_7_Internal_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BFB RID: 7163 RVA: 0x0008880C File Offset: 0x00086A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37339, XrefRangeEnd = 37341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong _CreateUnsignedConversionFunctions_b__24_0(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_0_Internal_UInt64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BFC RID: 7164 RVA: 0x0008885C File Offset: 0x00086A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37341, XrefRangeEnd = 37343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateUnsignedConversionFunctions_b__24_1(ulong o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref o;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_1_Internal_Object_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BFD RID: 7165 RVA: 0x000888A8 File Offset: 0x00086AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37343, XrefRangeEnd = 37345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong _CreateUnsignedConversionFunctions_b__24_2(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_2_Internal_UInt64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BFE RID: 7166 RVA: 0x000888F8 File Offset: 0x00086AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37345, XrefRangeEnd = 37347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateUnsignedConversionFunctions_b__24_3(ulong o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref o;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_3_Internal_Object_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BFF RID: 7167 RVA: 0x00088944 File Offset: 0x00086B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37347, XrefRangeEnd = 37349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong _CreateUnsignedConversionFunctions_b__24_4(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_4_Internal_UInt64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C00 RID: 7168 RVA: 0x00088994 File Offset: 0x00086B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37349, XrefRangeEnd = 37351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateUnsignedConversionFunctions_b__24_5(ulong o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref o;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_5_Internal_Object_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C01 RID: 7169 RVA: 0x000889E0 File Offset: 0x00086BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37351, XrefRangeEnd = 37353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong _CreateUnsignedConversionFunctions_b__24_6(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_6_Internal_UInt64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C02 RID: 7170 RVA: 0x00088A30 File Offset: 0x00086C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37353, XrefRangeEnd = 37355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateUnsignedConversionFunctions_b__24_7(ulong o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref o;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_7_Internal_Object_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C03 RID: 7171 RVA: 0x00088A7C File Offset: 0x00086C7C
			[CallerCount(0)]
			public unsafe ulong _Callback_Or_b__31_0(ulong v1, ulong v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_Or_b__31_0_Internal_UInt64_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C04 RID: 7172 RVA: 0x00088AD4 File Offset: 0x00086CD4
			[CallerCount(0)]
			public unsafe long _Callback_Or_b__31_1(long v1, long v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_Or_b__31_1_Internal_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C05 RID: 7173 RVA: 0x00088B2C File Offset: 0x00086D2C
			[CallerCount(0)]
			public unsafe ulong _Callback_And_b__32_0(ulong v1, ulong v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_And_b__32_0_Internal_UInt64_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C06 RID: 7174 RVA: 0x00088B84 File Offset: 0x00086D84
			[CallerCount(0)]
			public unsafe long _Callback_And_b__32_1(long v1, long v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_And_b__32_1_Internal_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C07 RID: 7175 RVA: 0x00088BDC File Offset: 0x00086DDC
			[CallerCount(0)]
			public unsafe ulong _Callback_Xor_b__33_0(ulong v1, ulong v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_Xor_b__33_0_Internal_UInt64_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C08 RID: 7176 RVA: 0x00088C34 File Offset: 0x00086E34
			[CallerCount(0)]
			public unsafe long _Callback_Xor_b__33_1(long v1, long v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_Xor_b__33_1_Internal_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C09 RID: 7177 RVA: 0x00088C8C File Offset: 0x00086E8C
			[CallerCount(0)]
			public unsafe ulong _Callback_BwNot_b__34_0(ulong v1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_BwNot_b__34_0_Internal_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C0A RID: 7178 RVA: 0x00088CD8 File Offset: 0x00086ED8
			[CallerCount(0)]
			public unsafe long _Callback_BwNot_b__34_1(long v1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_BwNot_b__34_1_Internal_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C0B RID: 7179 RVA: 0x00088D24 File Offset: 0x00086F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37355, XrefRangeEnd = 37359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _Callback_HasAll_b__35_0(ulong v1, ulong v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_HasAll_b__35_0_Internal_DynValue_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001C0C RID: 7180 RVA: 0x00088D80 File Offset: 0x00086F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37359, XrefRangeEnd = 37363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _Callback_HasAll_b__35_1(long v1, long v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_HasAll_b__35_1_Internal_DynValue_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001C0D RID: 7181 RVA: 0x00088DDC File Offset: 0x00086FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37363, XrefRangeEnd = 37367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _Callback_HasAny_b__36_0(ulong v1, ulong v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_HasAny_b__36_0_Internal_DynValue_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001C0E RID: 7182 RVA: 0x00088E38 File Offset: 0x00087038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37367, XrefRangeEnd = 37371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _Callback_HasAny_b__36_1(long v1, long v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c.NativeMethodInfoPtr__Callback_HasAny_b__36_1_Internal_DynValue_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001C0F RID: 7183 RVA: 0x0000B002 File Offset: 0x00009202
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00088E94 File Offset: 0x00087094
			// (set) Token: 0x06001C11 RID: 7185 RVA: 0x0000B00B File Offset: 0x0000920B
			public unsafe static StandardEnumUserDataDescriptor.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandardEnumUserDataDescriptor.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00088EBC File Offset: 0x000870BC
			// (set) Token: 0x06001C13 RID: 7187 RVA: 0x0000B01D File Offset: 0x0000921D
			public unsafe static Func<Object, long> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x06001C14 RID: 7188 RVA: 0x00088EE4 File Offset: 0x000870E4
			// (set) Token: 0x06001C15 RID: 7189 RVA: 0x0000B02F File Offset: 0x0000922F
			public unsafe static Func<long, Object> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00088F0C File Offset: 0x0008710C
			// (set) Token: 0x06001C17 RID: 7191 RVA: 0x0000B041 File Offset: 0x00009241
			public unsafe static Func<Object, long> __9__23_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x06001C18 RID: 7192 RVA: 0x00088F34 File Offset: 0x00087134
			// (set) Token: 0x06001C19 RID: 7193 RVA: 0x0000B053 File Offset: 0x00009253
			public unsafe static Func<long, Object> __9__23_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x06001C1A RID: 7194 RVA: 0x00088F5C File Offset: 0x0008715C
			// (set) Token: 0x06001C1B RID: 7195 RVA: 0x0000B065 File Offset: 0x00009265
			public unsafe static Func<Object, long> __9__23_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00088F84 File Offset: 0x00087184
			// (set) Token: 0x06001C1D RID: 7197 RVA: 0x0000B077 File Offset: 0x00009277
			public unsafe static Func<long, Object> __9__23_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00088FAC File Offset: 0x000871AC
			// (set) Token: 0x06001C1F RID: 7199 RVA: 0x0000B089 File Offset: 0x00009289
			public unsafe static Func<Object, long> __9__23_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00088FD4 File Offset: 0x000871D4
			// (set) Token: 0x06001C21 RID: 7201 RVA: 0x0000B09B File Offset: 0x0000929B
			public unsafe static Func<long, Object> __9__23_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__23_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00088FFC File Offset: 0x000871FC
			// (set) Token: 0x06001C23 RID: 7203 RVA: 0x0000B0AD File Offset: 0x000092AD
			public unsafe static Func<Object, ulong> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00089024 File Offset: 0x00087224
			// (set) Token: 0x06001C25 RID: 7205 RVA: 0x0000B0BF File Offset: 0x000092BF
			public unsafe static Func<ulong, Object> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0008904C File Offset: 0x0008724C
			// (set) Token: 0x06001C27 RID: 7207 RVA: 0x0000B0D1 File Offset: 0x000092D1
			public unsafe static Func<Object, ulong> __9__24_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00089074 File Offset: 0x00087274
			// (set) Token: 0x06001C29 RID: 7209 RVA: 0x0000B0E3 File Offset: 0x000092E3
			public unsafe static Func<ulong, Object> __9__24_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0008909C File Offset: 0x0008729C
			// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0000B0F5 File Offset: 0x000092F5
			public unsafe static Func<Object, ulong> __9__24_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x06001C2C RID: 7212 RVA: 0x000890C4 File Offset: 0x000872C4
			// (set) Token: 0x06001C2D RID: 7213 RVA: 0x0000B107 File Offset: 0x00009307
			public unsafe static Func<ulong, Object> __9__24_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x06001C2E RID: 7214 RVA: 0x000890EC File Offset: 0x000872EC
			// (set) Token: 0x06001C2F RID: 7215 RVA: 0x0000B119 File Offset: 0x00009319
			public unsafe static Func<Object, ulong> __9__24_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00089114 File Offset: 0x00087314
			// (set) Token: 0x06001C31 RID: 7217 RVA: 0x0000B12B File Offset: 0x0000932B
			public unsafe static Func<ulong, Object> __9__24_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__24_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0008913C File Offset: 0x0008733C
			// (set) Token: 0x06001C33 RID: 7219 RVA: 0x0000B13D File Offset: 0x0000933D
			public unsafe static Func<ulong, ulong, ulong> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, ulong, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00089164 File Offset: 0x00087364
			// (set) Token: 0x06001C35 RID: 7221 RVA: 0x0000B14F File Offset: 0x0000934F
			public unsafe static Func<long, long, long> __9__31_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__31_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, long, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__31_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x06001C36 RID: 7222 RVA: 0x0008918C File Offset: 0x0008738C
			// (set) Token: 0x06001C37 RID: 7223 RVA: 0x0000B161 File Offset: 0x00009361
			public unsafe static Func<ulong, ulong, ulong> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, ulong, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x06001C38 RID: 7224 RVA: 0x000891B4 File Offset: 0x000873B4
			// (set) Token: 0x06001C39 RID: 7225 RVA: 0x0000B173 File Offset: 0x00009373
			public unsafe static Func<long, long, long> __9__32_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__32_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, long, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__32_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x06001C3A RID: 7226 RVA: 0x000891DC File Offset: 0x000873DC
			// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0000B185 File Offset: 0x00009385
			public unsafe static Func<ulong, ulong, ulong> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, ulong, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00089204 File Offset: 0x00087404
			// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0000B197 File Offset: 0x00009397
			public unsafe static Func<long, long, long> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, long, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x06001C3E RID: 7230 RVA: 0x0008922C File Offset: 0x0008742C
			// (set) Token: 0x06001C3F RID: 7231 RVA: 0x0000B1A9 File Offset: 0x000093A9
			public unsafe static Func<ulong, ulong> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00089254 File Offset: 0x00087454
			// (set) Token: 0x06001C41 RID: 7233 RVA: 0x0000B1BB File Offset: 0x000093BB
			public unsafe static Func<long, long> __9__34_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__34_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__34_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0008927C File Offset: 0x0008747C
			// (set) Token: 0x06001C43 RID: 7235 RVA: 0x0000B1CD File Offset: 0x000093CD
			public unsafe static Func<ulong, ulong, DynValue> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, ulong, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x06001C44 RID: 7236 RVA: 0x000892A4 File Offset: 0x000874A4
			// (set) Token: 0x06001C45 RID: 7237 RVA: 0x0000B1DF File Offset: 0x000093DF
			public unsafe static Func<long, long, DynValue> __9__35_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__35_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, long, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__35_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x06001C46 RID: 7238 RVA: 0x000892CC File Offset: 0x000874CC
			// (set) Token: 0x06001C47 RID: 7239 RVA: 0x0000B1F1 File Offset: 0x000093F1
			public unsafe static Func<ulong, ulong, DynValue> __9__36_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, ulong, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__36_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x06001C48 RID: 7240 RVA: 0x000892F4 File Offset: 0x000874F4
			// (set) Token: 0x06001C49 RID: 7241 RVA: 0x0000B203 File Offset: 0x00009403
			public unsafe static Func<long, long, DynValue> __9__36_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__36_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, long, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardEnumUserDataDescriptor.__c.NativeFieldInfoPtr___9__36_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001684 RID: 5764
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001685 RID: 5765
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04001686 RID: 5766
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x04001687 RID: 5767
			private static readonly IntPtr NativeFieldInfoPtr___9__23_2;

			// Token: 0x04001688 RID: 5768
			private static readonly IntPtr NativeFieldInfoPtr___9__23_3;

			// Token: 0x04001689 RID: 5769
			private static readonly IntPtr NativeFieldInfoPtr___9__23_4;

			// Token: 0x0400168A RID: 5770
			private static readonly IntPtr NativeFieldInfoPtr___9__23_5;

			// Token: 0x0400168B RID: 5771
			private static readonly IntPtr NativeFieldInfoPtr___9__23_6;

			// Token: 0x0400168C RID: 5772
			private static readonly IntPtr NativeFieldInfoPtr___9__23_7;

			// Token: 0x0400168D RID: 5773
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400168E RID: 5774
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x0400168F RID: 5775
			private static readonly IntPtr NativeFieldInfoPtr___9__24_2;

			// Token: 0x04001690 RID: 5776
			private static readonly IntPtr NativeFieldInfoPtr___9__24_3;

			// Token: 0x04001691 RID: 5777
			private static readonly IntPtr NativeFieldInfoPtr___9__24_4;

			// Token: 0x04001692 RID: 5778
			private static readonly IntPtr NativeFieldInfoPtr___9__24_5;

			// Token: 0x04001693 RID: 5779
			private static readonly IntPtr NativeFieldInfoPtr___9__24_6;

			// Token: 0x04001694 RID: 5780
			private static readonly IntPtr NativeFieldInfoPtr___9__24_7;

			// Token: 0x04001695 RID: 5781
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x04001696 RID: 5782
			private static readonly IntPtr NativeFieldInfoPtr___9__31_1;

			// Token: 0x04001697 RID: 5783
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x04001698 RID: 5784
			private static readonly IntPtr NativeFieldInfoPtr___9__32_1;

			// Token: 0x04001699 RID: 5785
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x0400169A RID: 5786
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x0400169B RID: 5787
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x0400169C RID: 5788
			private static readonly IntPtr NativeFieldInfoPtr___9__34_1;

			// Token: 0x0400169D RID: 5789
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x0400169E RID: 5790
			private static readonly IntPtr NativeFieldInfoPtr___9__35_1;

			// Token: 0x0400169F RID: 5791
			private static readonly IntPtr NativeFieldInfoPtr___9__36_0;

			// Token: 0x040016A0 RID: 5792
			private static readonly IntPtr NativeFieldInfoPtr___9__36_1;

			// Token: 0x040016A1 RID: 5793
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016A2 RID: 5794
			private static readonly IntPtr NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_0_Internal_Int64_Object_0;

			// Token: 0x040016A3 RID: 5795
			private static readonly IntPtr NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_1_Internal_Object_Int64_0;

			// Token: 0x040016A4 RID: 5796
			private static readonly IntPtr NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_2_Internal_Int64_Object_0;

			// Token: 0x040016A5 RID: 5797
			private static readonly IntPtr NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_3_Internal_Object_Int64_0;

			// Token: 0x040016A6 RID: 5798
			private static readonly IntPtr NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_4_Internal_Int64_Object_0;

			// Token: 0x040016A7 RID: 5799
			private static readonly IntPtr NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_5_Internal_Object_Int64_0;

			// Token: 0x040016A8 RID: 5800
			private static readonly IntPtr NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_6_Internal_Int64_Object_0;

			// Token: 0x040016A9 RID: 5801
			private static readonly IntPtr NativeMethodInfoPtr__CreateSignedConversionFunctions_b__23_7_Internal_Object_Int64_0;

			// Token: 0x040016AA RID: 5802
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_0_Internal_UInt64_Object_0;

			// Token: 0x040016AB RID: 5803
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_1_Internal_Object_UInt64_0;

			// Token: 0x040016AC RID: 5804
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_2_Internal_UInt64_Object_0;

			// Token: 0x040016AD RID: 5805
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_3_Internal_Object_UInt64_0;

			// Token: 0x040016AE RID: 5806
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_4_Internal_UInt64_Object_0;

			// Token: 0x040016AF RID: 5807
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_5_Internal_Object_UInt64_0;

			// Token: 0x040016B0 RID: 5808
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_6_Internal_UInt64_Object_0;

			// Token: 0x040016B1 RID: 5809
			private static readonly IntPtr NativeMethodInfoPtr__CreateUnsignedConversionFunctions_b__24_7_Internal_Object_UInt64_0;

			// Token: 0x040016B2 RID: 5810
			private static readonly IntPtr NativeMethodInfoPtr__Callback_Or_b__31_0_Internal_UInt64_UInt64_UInt64_0;

			// Token: 0x040016B3 RID: 5811
			private static readonly IntPtr NativeMethodInfoPtr__Callback_Or_b__31_1_Internal_Int64_Int64_Int64_0;

			// Token: 0x040016B4 RID: 5812
			private static readonly IntPtr NativeMethodInfoPtr__Callback_And_b__32_0_Internal_UInt64_UInt64_UInt64_0;

			// Token: 0x040016B5 RID: 5813
			private static readonly IntPtr NativeMethodInfoPtr__Callback_And_b__32_1_Internal_Int64_Int64_Int64_0;

			// Token: 0x040016B6 RID: 5814
			private static readonly IntPtr NativeMethodInfoPtr__Callback_Xor_b__33_0_Internal_UInt64_UInt64_UInt64_0;

			// Token: 0x040016B7 RID: 5815
			private static readonly IntPtr NativeMethodInfoPtr__Callback_Xor_b__33_1_Internal_Int64_Int64_Int64_0;

			// Token: 0x040016B8 RID: 5816
			private static readonly IntPtr NativeMethodInfoPtr__Callback_BwNot_b__34_0_Internal_UInt64_UInt64_0;

			// Token: 0x040016B9 RID: 5817
			private static readonly IntPtr NativeMethodInfoPtr__Callback_BwNot_b__34_1_Internal_Int64_Int64_0;

			// Token: 0x040016BA RID: 5818
			private static readonly IntPtr NativeMethodInfoPtr__Callback_HasAll_b__35_0_Internal_DynValue_UInt64_UInt64_0;

			// Token: 0x040016BB RID: 5819
			private static readonly IntPtr NativeMethodInfoPtr__Callback_HasAll_b__35_1_Internal_DynValue_Int64_Int64_0;

			// Token: 0x040016BC RID: 5820
			private static readonly IntPtr NativeMethodInfoPtr__Callback_HasAny_b__36_0_Internal_DynValue_UInt64_UInt64_0;

			// Token: 0x040016BD RID: 5821
			private static readonly IntPtr NativeMethodInfoPtr__Callback_HasAny_b__36_1_Internal_DynValue_Int64_Int64_0;
		}

		// Token: 0x020001CE RID: 462
		[ObfuscatedName("MoonSharp.Interpreter.Interop.StandardEnumUserDataDescriptor+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Object
		{
			// Token: 0x06001C4A RID: 7242 RVA: 0x0008931C File Offset: 0x0008751C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass27_0>.NativeClassPtr);
				StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass27_0>.NativeClassPtr, "operation");
				StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass27_0>.NativeClassPtr, 100665936);
				StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeMethodInfoPtr__PerformBinaryOperationS_b__0_Internal_DynValue_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass27_0>.NativeClassPtr, 100665937);
			}

			// Token: 0x06001C4B RID: 7243 RVA: 0x00089398 File Offset: 0x00087598
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C4C RID: 7244 RVA: 0x000893D4 File Offset: 0x000875D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37371, XrefRangeEnd = 37373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _PerformBinaryOperationS_b__0(long v1, long v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeMethodInfoPtr__PerformBinaryOperationS_b__0_Internal_DynValue_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001C4D RID: 7245 RVA: 0x0000B215 File Offset: 0x00009415
			public __c__DisplayClass27_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00089430 File Offset: 0x00087630
			// (set) Token: 0x06001C4F RID: 7247 RVA: 0x0000B21E File Offset: 0x0000941E
			public unsafe StandardEnumUserDataDescriptor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandardEnumUserDataDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00089460 File Offset: 0x00087660
			// (set) Token: 0x06001C51 RID: 7249 RVA: 0x0000B23D File Offset: 0x0000943D
			public unsafe Func<long, long, long> operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<long, long, long>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.__c__DisplayClass27_0.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016BE RID: 5822
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016BF RID: 5823
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x040016C0 RID: 5824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016C1 RID: 5825
			private static readonly IntPtr NativeMethodInfoPtr__PerformBinaryOperationS_b__0_Internal_DynValue_Int64_Int64_0;
		}

		// Token: 0x020001CF RID: 463
		[ObfuscatedName("MoonSharp.Interpreter.Interop.StandardEnumUserDataDescriptor+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Object
		{
			// Token: 0x06001C52 RID: 7250 RVA: 0x00089490 File Offset: 0x00087690
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandardEnumUserDataDescriptor>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass28_0>.NativeClassPtr);
				StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass28_0>.NativeClassPtr, "operation");
				StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass28_0>.NativeClassPtr, 100665938);
				StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeMethodInfoPtr__PerformBinaryOperationU_b__0_Internal_DynValue_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass28_0>.NativeClassPtr, 100665939);
			}

			// Token: 0x06001C53 RID: 7251 RVA: 0x0008950C File Offset: 0x0008770C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardEnumUserDataDescriptor.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C54 RID: 7252 RVA: 0x00089548 File Offset: 0x00087748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37373, XrefRangeEnd = 37375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _PerformBinaryOperationU_b__0(ulong v1, ulong v2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeMethodInfoPtr__PerformBinaryOperationU_b__0_Internal_DynValue_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001C55 RID: 7253 RVA: 0x0000B25C File Offset: 0x0000945C
			public __c__DisplayClass28_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x06001C56 RID: 7254 RVA: 0x000895A4 File Offset: 0x000877A4
			// (set) Token: 0x06001C57 RID: 7255 RVA: 0x0000B265 File Offset: 0x00009465
			public unsafe StandardEnumUserDataDescriptor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandardEnumUserDataDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x06001C58 RID: 7256 RVA: 0x000895D4 File Offset: 0x000877D4
			// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0000B284 File Offset: 0x00009484
			public unsafe Func<ulong, ulong, ulong> operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, ulong, ulong>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardEnumUserDataDescriptor.__c__DisplayClass28_0.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016C2 RID: 5826
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016C3 RID: 5827
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x040016C4 RID: 5828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016C5 RID: 5829
			private static readonly IntPtr NativeMethodInfoPtr__PerformBinaryOperationU_b__0_Internal_DynValue_UInt64_UInt64_0;
		}
	}
}
