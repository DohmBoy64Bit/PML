using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AF RID: 175
	public class FunctionMemberDescriptorBase : Object
	{
		// Token: 0x06000D56 RID: 3414 RVA: 0x0004A86C File Offset: 0x00048A6C
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionMemberDescriptorBase()
		{
			Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "FunctionMemberDescriptorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr);
			FunctionMemberDescriptorBase.NativeFieldInfoPtr__IsStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, "<IsStatic>k__BackingField");
			FunctionMemberDescriptorBase.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, "<Name>k__BackingField");
			FunctionMemberDescriptorBase.NativeFieldInfoPtr__SortDiscriminant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, "<SortDiscriminant>k__BackingField");
			FunctionMemberDescriptorBase.NativeFieldInfoPtr__Parameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, "<Parameters>k__BackingField");
			FunctionMemberDescriptorBase.NativeFieldInfoPtr__ExtensionMethodType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, "<ExtensionMethodType>k__BackingField");
			FunctionMemberDescriptorBase.NativeFieldInfoPtr__VarArgsArrayType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, "<VarArgsArrayType>k__BackingField");
			FunctionMemberDescriptorBase.NativeFieldInfoPtr__VarArgsElementType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, "<VarArgsElementType>k__BackingField");
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665598);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665599);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665600);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665601);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_SortDiscriminant_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665602);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_SortDiscriminant_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665603);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_Parameters_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_ParameterDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665604);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_Parameters_Private_set_Void_Il2CppReferenceArray_1_ParameterDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665605);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_ExtensionMethodType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665606);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_ExtensionMethodType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665607);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_VarArgsArrayType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665608);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_VarArgsArrayType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665609);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_VarArgsElementType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665610);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_VarArgsElementType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665611);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665620);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665623);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_Initialize_Protected_Void_String_Boolean_Il2CppReferenceArray_1_ParameterDescriptor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665612);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_GetCallback_Public_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665613);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_GetCallbackFunction_Public_CallbackFunction_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665614);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_GetCallbackAsDynValue_Public_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665615);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_CreateCallbackDynValue_Public_Static_DynValue_Script_MethodInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665616);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_BuildArgumentList_Protected_Virtual_New_Il2CppReferenceArray_1_Object_Script_Object_ScriptExecutionContext_CallbackArguments_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665617);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_BuildReturnValue_Protected_Static_DynValue_Script_List_1_Int32_Il2CppReferenceArray_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665618);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665619);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_GetValue_Public_Virtual_New_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665621);
			FunctionMemberDescriptorBase.NativeMethodInfoPtr_SetValue_Public_Virtual_New_Void_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, 100665622);
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0004AB30 File Offset: 0x00048D30
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x0004AB6C File Offset: 0x00048D6C
		public unsafe virtual bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20587, RefRangeEnd = 20588, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x0004ABAC File Offset: 0x00048DAC
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x0004ABE4 File Offset: 0x00048DE4
		public unsafe virtual string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0004AC28 File Offset: 0x00048E28
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x0004AC60 File Offset: 0x00048E60
		public unsafe virtual string SortDiscriminant
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_SortDiscriminant_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_SortDiscriminant_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0004ACA4 File Offset: 0x00048EA4
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x0004ACE4 File Offset: 0x00048EE4
		public unsafe virtual Il2CppReferenceArray<ParameterDescriptor> Parameters
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_Parameters_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_ParameterDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterDescriptor>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_Parameters_Private_set_Void_Il2CppReferenceArray_1_ParameterDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0004AD28 File Offset: 0x00048F28
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x0004AD68 File Offset: 0x00048F68
		public unsafe virtual Type ExtensionMethodType
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_ExtensionMethodType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_ExtensionMethodType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x0004ADAC File Offset: 0x00048FAC
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x0004ADEC File Offset: 0x00048FEC
		public unsafe virtual Type VarArgsArrayType
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_VarArgsArrayType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_VarArgsArrayType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x0004AE30 File Offset: 0x00049030
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x0004AE70 File Offset: 0x00049070
		public unsafe virtual Type VarArgsElementType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_VarArgsElementType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_set_VarArgsElementType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x0004AEB4 File Offset: 0x000490B4
		public unsafe virtual MemberDescriptorAccess MemberAccess
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20601, RefRangeEnd = 20602, XrefRangeStart = 20601, XrefRangeEnd = 20602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberDescriptorAccess>(intPtr3) : null;
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0004AEF4 File Offset: 0x000490F4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionMemberDescriptorBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0004AF30 File Offset: 0x00049130
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 34122, RefRangeEnd = 34131, XrefRangeStart = 34090, XrefRangeEnd = 34122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string funcName, bool isStatic, Il2CppReferenceArray<ParameterDescriptor> parameters, bool isExtensionMethod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(funcName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isExtensionMethod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_Initialize_Protected_Void_String_Boolean_Il2CppReferenceArray_1_ParameterDescriptor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0004AFA0 File Offset: 0x000491A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34131, XrefRangeEnd = 34144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, Object obj = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_GetCallback_Public_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ScriptExecutionContext, CallbackArguments, DynValue>>(intPtr3) : null;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0004B004 File Offset: 0x00049204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34161, RefRangeEnd = 34163, XrefRangeStart = 34144, XrefRangeEnd = 34161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallbackFunction GetCallbackFunction(Script script, Object obj = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_GetCallbackFunction_Public_CallbackFunction_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr3) : null;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0004B068 File Offset: 0x00049268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34185, RefRangeEnd = 34187, XrefRangeStart = 34163, XrefRangeEnd = 34185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetCallbackAsDynValue(Script script, Object obj = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_GetCallbackAsDynValue_Public_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0004B0CC File Offset: 0x000492CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34187, XrefRangeEnd = 34193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue CreateCallbackDynValue(Script script, MethodInfo mi, Object obj = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_CreateCallbackDynValue_Public_Static_DynValue_Script_MethodInfo_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0004B134 File Offset: 0x00049334
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34284, RefRangeEnd = 34286, XrefRangeStart = 34193, XrefRangeEnd = 34284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> BuildArgumentList(Script script, Object obj, ScriptExecutionContext context, CallbackArguments args, out List<int> outParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionMemberDescriptorBase.NativeMethodInfoPtr_BuildArgumentList_Protected_Virtual_New_Il2CppReferenceArray_1_Object_Script_Object_ScriptExecutionContext_CallbackArguments_byref_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outParams = ((intPtr4 == 0) ? null : new List<int>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr5) : null;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0004B1EC File Offset: 0x000493EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34286, XrefRangeEnd = 34315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue BuildReturnValue(Script script, List<int> outParams, Il2CppReferenceArray<Object> pars, Object retv)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outParams);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pars);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.NativeMethodInfoPtr_BuildReturnValue_Protected_Static_DynValue_Script_List_1_Int32_Il2CppReferenceArray_1_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0004B268 File Offset: 0x00049468
		[CallerCount(0)]
		public unsafe virtual DynValue Execute(Script script, Object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionMemberDescriptorBase.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0004B2FC File Offset: 0x000494FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34315, XrefRangeEnd = 34317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionMemberDescriptorBase.NativeMethodInfoPtr_GetValue_Public_Virtual_New_DynValue_Script_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0004B36C File Offset: 0x0004956C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34317, XrefRangeEnd = 34318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(Script script, Object obj, DynValue v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionMemberDescriptorBase.NativeMethodInfoPtr_SetValue_Public_Virtual_New_Void_Script_Object_DynValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00005F3F File Offset: 0x0000413F
		public FunctionMemberDescriptorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0004B3E0 File Offset: 0x000495E0
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x00005F48 File Offset: 0x00004148
		public unsafe bool _IsStatic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__IsStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__IsStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x0004B408 File Offset: 0x00049608
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x00005F63 File Offset: 0x00004163
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0004B430 File Offset: 0x00049630
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00005F82 File Offset: 0x00004182
		public unsafe string _SortDiscriminant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__SortDiscriminant_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__SortDiscriminant_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0004B458 File Offset: 0x00049658
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00005FA1 File Offset: 0x000041A1
		public unsafe Il2CppReferenceArray<ParameterDescriptor> _Parameters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__Parameters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__Parameters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0004B488 File Offset: 0x00049688
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00005FC0 File Offset: 0x000041C0
		public unsafe Type _ExtensionMethodType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__ExtensionMethodType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__ExtensionMethodType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0004B4B8 File Offset: 0x000496B8
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00005FDF File Offset: 0x000041DF
		public unsafe Type _VarArgsArrayType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__VarArgsArrayType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__VarArgsArrayType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0004B4E8 File Offset: 0x000496E8
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00005FFE File Offset: 0x000041FE
		public unsafe Type _VarArgsElementType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__VarArgsElementType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.NativeFieldInfoPtr__VarArgsElementType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr__IsStatic_k__BackingField;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeFieldInfoPtr__SortDiscriminant_k__BackingField;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeFieldInfoPtr__Parameters_k__BackingField;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeFieldInfoPtr__ExtensionMethodType_k__BackingField;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeFieldInfoPtr__VarArgsArrayType_k__BackingField;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeFieldInfoPtr__VarArgsElementType_k__BackingField;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_get_SortDiscriminant_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_set_SortDiscriminant_Private_set_Void_String_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_get_Parameters_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_ParameterDescriptor_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_set_Parameters_Private_set_Void_Il2CppReferenceArray_1_ParameterDescriptor_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtensionMethodType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtensionMethodType_Private_set_Void_Type_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_get_VarArgsArrayType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_set_VarArgsArrayType_Private_set_Void_Type_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_get_VarArgsElementType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_set_VarArgsElementType_Private_set_Void_Type_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_String_Boolean_Il2CppReferenceArray_1_ParameterDescriptor_Boolean_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_GetCallback_Public_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_Script_Object_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackFunction_Public_CallbackFunction_Script_Object_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackAsDynValue_Public_DynValue_Script_Object_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_CreateCallbackDynValue_Public_Static_DynValue_Script_MethodInfo_Object_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_BuildArgumentList_Protected_Virtual_New_Il2CppReferenceArray_1_Object_Script_Object_ScriptExecutionContext_CallbackArguments_byref_List_1_Int32_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_BuildReturnValue_Protected_Static_DynValue_Script_List_1_Int32_Il2CppReferenceArray_1_Object_Object_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_New_DynValue_Script_Object_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_New_Void_Script_Object_DynValue_0;

		// Token: 0x020001B1 RID: 433
		[ObfuscatedName("MoonSharp.Interpreter.Interop.FunctionMemberDescriptorBase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AF7 RID: 6903 RVA: 0x00082F80 File Offset: 0x00081180
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c>.NativeClassPtr);
				FunctionMemberDescriptorBase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c>.NativeClassPtr, "<>9");
				FunctionMemberDescriptorBase.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c>.NativeClassPtr, "<>9__28_0");
				FunctionMemberDescriptorBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c>.NativeClassPtr, 100665625);
				FunctionMemberDescriptorBase.__c.NativeMethodInfoPtr__Initialize_b__28_0_Internal_String_ParameterDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c>.NativeClassPtr, 100665626);
			}

			// Token: 0x06001AF8 RID: 6904 RVA: 0x00082FFC File Offset: 0x000811FC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AF9 RID: 6905 RVA: 0x00083038 File Offset: 0x00081238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34089, XrefRangeEnd = 34090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Initialize_b__28_0(ParameterDescriptor pi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.__c.NativeMethodInfoPtr__Initialize_b__28_0_Internal_String_ParameterDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001AFA RID: 6906 RVA: 0x0000AAE2 File Offset: 0x00008CE2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x06001AFB RID: 6907 RVA: 0x00083080 File Offset: 0x00081280
			// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0000AAEB File Offset: 0x00008CEB
			public unsafe static FunctionMemberDescriptorBase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FunctionMemberDescriptorBase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionMemberDescriptorBase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FunctionMemberDescriptorBase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000830A8 File Offset: 0x000812A8
			// (set) Token: 0x06001AFE RID: 6910 RVA: 0x0000AAFD File Offset: 0x00008CFD
			public unsafe static Func<ParameterDescriptor, string> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FunctionMemberDescriptorBase.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParameterDescriptor, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FunctionMemberDescriptorBase.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015FA RID: 5626
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015FB RID: 5627
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x040015FC RID: 5628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015FD RID: 5629
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__28_0_Internal_String_ParameterDescriptor_0;
		}

		// Token: 0x020001B2 RID: 434
		[ObfuscatedName("MoonSharp.Interpreter.Interop.FunctionMemberDescriptorBase+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Object
		{
			// Token: 0x06001AFF RID: 6911 RVA: 0x000830D0 File Offset: 0x000812D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FunctionMemberDescriptorBase>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c__DisplayClass29_0>.NativeClassPtr);
				FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeFieldInfoPtr_script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c__DisplayClass29_0>.NativeClassPtr, "script");
				FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c__DisplayClass29_0>.NativeClassPtr, "obj");
				FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c__DisplayClass29_0>.NativeClassPtr, 100665627);
				FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeMethodInfoPtr__GetCallback_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c__DisplayClass29_0>.NativeClassPtr, 100665628);
			}

			// Token: 0x06001B00 RID: 6912 RVA: 0x00083160 File Offset: 0x00081360
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionMemberDescriptorBase.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B01 RID: 6913 RVA: 0x0008319C File Offset: 0x0008139C
			[CallerCount(0)]
			public unsafe DynValue _GetCallback_b__0(ScriptExecutionContext c, CallbackArguments a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeMethodInfoPtr__GetCallback_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001B02 RID: 6914 RVA: 0x0000AB0F File Offset: 0x00008D0F
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x06001B03 RID: 6915 RVA: 0x00083200 File Offset: 0x00081400
			// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0000AB18 File Offset: 0x00008D18
			public unsafe FunctionMemberDescriptorBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionMemberDescriptorBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x06001B05 RID: 6917 RVA: 0x00083230 File Offset: 0x00081430
			// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0000AB37 File Offset: 0x00008D37
			public unsafe Script script
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeFieldInfoPtr_script);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeFieldInfoPtr_script), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00083260 File Offset: 0x00081460
			// (set) Token: 0x06001B08 RID: 6920 RVA: 0x0000AB56 File Offset: 0x00008D56
			public unsafe Object obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionMemberDescriptorBase.__c__DisplayClass29_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015FE RID: 5630
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015FF RID: 5631
			private static readonly IntPtr NativeFieldInfoPtr_script;

			// Token: 0x04001600 RID: 5632
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x04001601 RID: 5633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001602 RID: 5634
			private static readonly IntPtr NativeMethodInfoPtr__GetCallback_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;
		}
	}
}
