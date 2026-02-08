using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B6 RID: 182
	public class OverloadedMethodMemberDescriptor : Object
	{
		// Token: 0x06000E18 RID: 3608 RVA: 0x0004DD90 File Offset: 0x0004BF90
		// Note: this type is marked as 'beforefieldinit'.
		static OverloadedMethodMemberDescriptor()
		{
			Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "OverloadedMethodMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr);
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_CACHE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "CACHE_SIZE");
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_Overloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "m_Overloads");
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_ExtOverloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "m_ExtOverloads");
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_Unsorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "m_Unsorted");
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "m_Cache");
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_CacheHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "m_CacheHits");
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_ExtensionMethodVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "m_ExtensionMethodVersion");
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr__IgnoreExtensionMethods_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "<IgnoreExtensionMethods>k__BackingField");
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "<Name>k__BackingField");
			OverloadedMethodMemberDescriptor.NativeFieldInfoPtr__DeclaringType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "<DeclaringType>k__BackingField");
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_IgnoreExtensionMethods_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665806);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_set_IgnoreExtensionMethods_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665807);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665812);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665813);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_DeclaringType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665814);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_set_DeclaringType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665815);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_OverloadCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665817);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665826);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665827);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665808);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_IOverloadableMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665809);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_IEnumerable_1_IOverloadableMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665810);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_SetExtensionMethodsSnapshot_Internal_Void_Int32_List_1_IOverloadableMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665811);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_AddOverload_Public_Void_IOverloadableMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665816);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_PerformOverloadedCall_Private_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665818);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_Cache_Private_Void_Boolean_CallbackArguments_IOverloadableMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665819);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_CheckMatch_Private_Boolean_Boolean_CallbackArguments_OverloadCacheItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665820);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_CalcScoreForOverload_Private_Int32_ScriptExecutionContext_CallbackArguments_IOverloadableMemberDescriptor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665821);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_CalcScoreForSingleArgument_Private_Static_Int32_ParameterDescriptor_Type_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665822);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_GetCallback_Public_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665823);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665824);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_GetCallbackFunction_Public_CallbackFunction_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665825);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665828);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665829);
			OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, 100665830);
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0004E07C File Offset: 0x0004C27C
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x0004E0B8 File Offset: 0x0004C2B8
		public unsafe bool IgnoreExtensionMethods
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_IgnoreExtensionMethods_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_set_IgnoreExtensionMethods_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0004E0F8 File Offset: 0x0004C2F8
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x0004E130 File Offset: 0x0004C330
		public unsafe virtual string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0004E174 File Offset: 0x0004C374
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x0004E1B4 File Offset: 0x0004C3B4
		public unsafe Type DeclaringType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_DeclaringType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_set_DeclaringType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0004E1F8 File Offset: 0x0004C3F8
		public unsafe int OverloadCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36568, XrefRangeEnd = 36569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_OverloadCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0004E234 File Offset: 0x0004C434
		public unsafe virtual bool IsStatic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36569, XrefRangeEnd = 36587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0004E270 File Offset: 0x0004C470
		public unsafe virtual MemberDescriptorAccess MemberAccess
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20601, RefRangeEnd = 20602, XrefRangeStart = 20601, XrefRangeEnd = 20602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberDescriptorAccess>(intPtr3) : null;
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0004E2B0 File Offset: 0x0004C4B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36606, RefRangeEnd = 36609, XrefRangeStart = 36587, XrefRangeEnd = 36606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverloadedMethodMemberDescriptor(string name, Type declaringType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0004E310 File Offset: 0x0004C510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36609, XrefRangeEnd = 36613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverloadedMethodMemberDescriptor(string name, Type declaringType, IOverloadableMemberDescriptor descriptor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_IOverloadableMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0004E380 File Offset: 0x0004C580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36613, XrefRangeEnd = 36618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverloadedMethodMemberDescriptor(string name, Type declaringType, IEnumerable<IOverloadableMemberDescriptor> descriptors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descriptors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_IEnumerable_1_IOverloadableMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0004E3F0 File Offset: 0x0004C5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36619, RefRangeEnd = 36620, XrefRangeStart = 36618, XrefRangeEnd = 36619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExtensionMethodsSnapshot(int version, List<IOverloadableMemberDescriptor> extMethods)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extMethods);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_SetExtensionMethodsSnapshot_Internal_Void_Int32_List_1_IOverloadableMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0004E440 File Offset: 0x0004C640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36620, XrefRangeEnd = 36623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverload(IOverloadableMemberDescriptor overload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(overload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_AddOverload_Public_Void_IOverloadableMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0004E484 File Offset: 0x0004C684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36644, RefRangeEnd = 36645, XrefRangeStart = 36623, XrefRangeEnd = 36644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue PerformOverloadedCall(Script script, Object obj, ScriptExecutionContext context, CallbackArguments args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_PerformOverloadedCall_Private_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0004E50C File Offset: 0x0004C70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36645, XrefRangeEnd = 36707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cache(bool hasObject, CallbackArguments args, IOverloadableMemberDescriptor bestOverload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasObject;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bestOverload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_Cache_Private_Void_Boolean_CallbackArguments_IOverloadableMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0004E570 File Offset: 0x0004C770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36725, RefRangeEnd = 36726, XrefRangeStart = 36707, XrefRangeEnd = 36725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckMatch(bool hasObject, CallbackArguments args, OverloadedMethodMemberDescriptor.OverloadCacheItem overloadCacheItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasObject;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overloadCacheItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_CheckMatch_Private_Boolean_Boolean_CallbackArguments_OverloadCacheItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0004E5E0 File Offset: 0x0004C7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36726, XrefRangeEnd = 36806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalcScoreForOverload(ScriptExecutionContext context, CallbackArguments args, IOverloadableMemberDescriptor method, bool isExtMethod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isExtMethod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_CalcScoreForOverload_Private_Int32_ScriptExecutionContext_CallbackArguments_IOverloadableMemberDescriptor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0004E660 File Offset: 0x0004C860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36812, RefRangeEnd = 36814, XrefRangeStart = 36806, XrefRangeEnd = 36812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CalcScoreForSingleArgument(ParameterDescriptor desc, Type parameterType, DynValue arg, bool isOptional)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameterType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOptional;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_CalcScoreForSingleArgument_Private_Static_Int32_ParameterDescriptor_Type_DynValue_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0004E6D4 File Offset: 0x0004C8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36827, RefRangeEnd = 36828, XrefRangeStart = 36814, XrefRangeEnd = 36827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, Object obj)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_GetCallback_Public_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ScriptExecutionContext, CallbackArguments, DynValue>>(intPtr3) : null;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0004E738 File Offset: 0x0004C938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36828, XrefRangeEnd = 36852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0004E76C File Offset: 0x0004C96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36852, XrefRangeEnd = 36869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_GetCallbackFunction_Public_CallbackFunction_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr3) : null;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0004E7D0 File Offset: 0x0004C9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36869, XrefRangeEnd = 36891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0004E834 File Offset: 0x0004CA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0004E89C File Offset: 0x0004CA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36891, XrefRangeEnd = 36948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareForWiring(Table t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000063FA File Offset: 0x000045FA
		public OverloadedMethodMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x0004E8E0 File Offset: 0x0004CAE0
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x00006403 File Offset: 0x00004603
		public unsafe static int CACHE_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_CACHE_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_CACHE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x0004E8FC File Offset: 0x0004CAFC
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x00006411 File Offset: 0x00004611
		public unsafe List<IOverloadableMemberDescriptor> m_Overloads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_Overloads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IOverloadableMemberDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_Overloads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0004E92C File Offset: 0x0004CB2C
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00006430 File Offset: 0x00004630
		public unsafe List<IOverloadableMemberDescriptor> m_ExtOverloads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_ExtOverloads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IOverloadableMemberDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_ExtOverloads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x0004E95C File Offset: 0x0004CB5C
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x0000644F File Offset: 0x0000464F
		public unsafe bool m_Unsorted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_Unsorted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_Unsorted)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x0004E984 File Offset: 0x0004CB84
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x0000646A File Offset: 0x0000466A
		public unsafe Il2CppReferenceArray<OverloadedMethodMemberDescriptor.OverloadCacheItem> m_Cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_Cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OverloadedMethodMemberDescriptor.OverloadCacheItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_Cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x0004E9B4 File Offset: 0x0004CBB4
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x00006489 File Offset: 0x00004689
		public unsafe int m_CacheHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_CacheHits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_CacheHits)) = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x0004E9DC File Offset: 0x0004CBDC
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x000064A4 File Offset: 0x000046A4
		public unsafe int m_ExtensionMethodVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_ExtensionMethodVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr_m_ExtensionMethodVersion)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0004EA04 File Offset: 0x0004CC04
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x000064BF File Offset: 0x000046BF
		public unsafe bool _IgnoreExtensionMethods_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr__IgnoreExtensionMethods_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr__IgnoreExtensionMethods_k__BackingField)) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0004EA2C File Offset: 0x0004CC2C
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x000064DA File Offset: 0x000046DA
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0004EA54 File Offset: 0x0004CC54
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x000064F9 File Offset: 0x000046F9
		public unsafe Type _DeclaringType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr__DeclaringType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.NativeFieldInfoPtr__DeclaringType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeFieldInfoPtr_CACHE_SIZE;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeFieldInfoPtr_m_Overloads;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtOverloads;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeFieldInfoPtr_m_Unsorted;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeFieldInfoPtr_m_Cache;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheHits;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtensionMethodVersion;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreExtensionMethods_k__BackingField;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeFieldInfoPtr__DeclaringType_k__BackingField;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreExtensionMethods_Public_get_Boolean_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreExtensionMethods_Public_set_Void_Boolean_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_get_Type_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaringType_Private_set_Void_Type_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_get_OverloadCount_Public_get_Int32_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_IOverloadableMemberDescriptor_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_IEnumerable_1_IOverloadableMemberDescriptor_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_SetExtensionMethodsSnapshot_Internal_Void_Int32_List_1_IOverloadableMemberDescriptor_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_AddOverload_Public_Void_IOverloadableMemberDescriptor_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_PerformOverloadedCall_Private_DynValue_Script_Object_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_Cache_Private_Void_Boolean_CallbackArguments_IOverloadableMemberDescriptor_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_CheckMatch_Private_Boolean_Boolean_CallbackArguments_OverloadCacheItem_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_CalcScoreForOverload_Private_Int32_ScriptExecutionContext_CallbackArguments_IOverloadableMemberDescriptor_Boolean_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_CalcScoreForSingleArgument_Private_Static_Int32_ParameterDescriptor_Type_DynValue_Boolean_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_GetCallback_Public_Func_3_ScriptExecutionContext_CallbackArguments_DynValue_Script_Object_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackFunction_Public_CallbackFunction_Script_Object_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0;

		// Token: 0x020001C9 RID: 457
		public class OverloadableMemberDescriptorComparer : Object
		{
			// Token: 0x06001BCE RID: 7118 RVA: 0x00087AE4 File Offset: 0x00085CE4
			// Note: this type is marked as 'beforefieldinit'.
			static OverloadableMemberDescriptorComparer()
			{
				Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "OverloadableMemberDescriptorComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer>.NativeClassPtr);
				OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer>.NativeClassPtr, 100665832);
				OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IOverloadableMemberDescriptor_IOverloadableMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer>.NativeClassPtr, 100665831);
			}

			// Token: 0x06001BCF RID: 7119 RVA: 0x00087B38 File Offset: 0x00085D38
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OverloadableMemberDescriptorComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BD0 RID: 7120 RVA: 0x00087B74 File Offset: 0x00085D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36556, XrefRangeEnd = 36563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(IOverloadableMemberDescriptor x, IOverloadableMemberDescriptor y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.OverloadableMemberDescriptorComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IOverloadableMemberDescriptor_IOverloadableMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001BD1 RID: 7121 RVA: 0x0000AECA File Offset: 0x000090CA
			public OverloadableMemberDescriptorComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001673 RID: 5747
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001674 RID: 5748
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IOverloadableMemberDescriptor_IOverloadableMemberDescriptor_0;
		}

		// Token: 0x020001CA RID: 458
		public class OverloadCacheItem : Object
		{
			// Token: 0x06001BD2 RID: 7122 RVA: 0x00087BD4 File Offset: 0x00085DD4
			// Note: this type is marked as 'beforefieldinit'.
			static OverloadCacheItem()
			{
				Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadCacheItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "OverloadCacheItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadCacheItem>.NativeClassPtr);
				OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_HasObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadCacheItem>.NativeClassPtr, "HasObject");
				OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_Method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadCacheItem>.NativeClassPtr, "Method");
				OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_ArgsDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadCacheItem>.NativeClassPtr, "ArgsDataType");
				OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_ArgsUserDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadCacheItem>.NativeClassPtr, "ArgsUserDataType");
				OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_HitIndexAtLastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadCacheItem>.NativeClassPtr, "HitIndexAtLastHit");
				OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadCacheItem>.NativeClassPtr, 100665833);
			}

			// Token: 0x06001BD3 RID: 7123 RVA: 0x00087C78 File Offset: 0x00085E78
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OverloadCacheItem()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.OverloadCacheItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BD4 RID: 7124 RVA: 0x0000AED3 File Offset: 0x000090D3
			public OverloadCacheItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x00087CB4 File Offset: 0x00085EB4
			// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x0000AEDC File Offset: 0x000090DC
			public unsafe bool HasObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_HasObject);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_HasObject)) = value;
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x00087CDC File Offset: 0x00085EDC
			// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x0000AEF7 File Offset: 0x000090F7
			public unsafe IOverloadableMemberDescriptor Method
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_Method);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOverloadableMemberDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_Method), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00087D0C File Offset: 0x00085F0C
			// (set) Token: 0x06001BDA RID: 7130 RVA: 0x0000AF16 File Offset: 0x00009116
			public unsafe List<DataType> ArgsDataType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_ArgsDataType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_ArgsDataType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x06001BDB RID: 7131 RVA: 0x00087D3C File Offset: 0x00085F3C
			// (set) Token: 0x06001BDC RID: 7132 RVA: 0x0000AF35 File Offset: 0x00009135
			public unsafe List<Type> ArgsUserDataType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_ArgsUserDataType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_ArgsUserDataType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x06001BDD RID: 7133 RVA: 0x00087D6C File Offset: 0x00085F6C
			// (set) Token: 0x06001BDE RID: 7134 RVA: 0x0000AF54 File Offset: 0x00009154
			public unsafe int HitIndexAtLastHit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_HitIndexAtLastHit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.OverloadCacheItem.NativeFieldInfoPtr_HitIndexAtLastHit)) = value;
				}
			}

			// Token: 0x04001675 RID: 5749
			private static readonly IntPtr NativeFieldInfoPtr_HasObject;

			// Token: 0x04001676 RID: 5750
			private static readonly IntPtr NativeFieldInfoPtr_Method;

			// Token: 0x04001677 RID: 5751
			private static readonly IntPtr NativeFieldInfoPtr_ArgsDataType;

			// Token: 0x04001678 RID: 5752
			private static readonly IntPtr NativeFieldInfoPtr_ArgsUserDataType;

			// Token: 0x04001679 RID: 5753
			private static readonly IntPtr NativeFieldInfoPtr_HitIndexAtLastHit;

			// Token: 0x0400167A RID: 5754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001CB RID: 459
		[ObfuscatedName("MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001BDF RID: 7135 RVA: 0x00087D94 File Offset: 0x00085F94
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c>.NativeClassPtr);
				OverloadedMethodMemberDescriptor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c>.NativeClassPtr, "<>9");
				OverloadedMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c>.NativeClassPtr, "<>9__37_0");
				OverloadedMethodMemberDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c>.NativeClassPtr, 100665835);
				OverloadedMethodMemberDescriptor.__c.NativeMethodInfoPtr__get_IsStatic_b__37_0_Internal_Boolean_IOverloadableMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c>.NativeClassPtr, 100665836);
			}

			// Token: 0x06001BE0 RID: 7136 RVA: 0x00087E10 File Offset: 0x00086010
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BE1 RID: 7137 RVA: 0x00087E4C File Offset: 0x0008604C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36563, XrefRangeEnd = 36567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_IsStatic_b__37_0(IOverloadableMemberDescriptor o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.__c.NativeMethodInfoPtr__get_IsStatic_b__37_0_Internal_Boolean_IOverloadableMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BE2 RID: 7138 RVA: 0x0000AF6F File Offset: 0x0000916F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x00087E9C File Offset: 0x0008609C
			// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x0000AF78 File Offset: 0x00009178
			public unsafe static OverloadedMethodMemberDescriptor.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OverloadedMethodMemberDescriptor.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverloadedMethodMemberDescriptor.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OverloadedMethodMemberDescriptor.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x00087EC4 File Offset: 0x000860C4
			// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0000AF8A File Offset: 0x0000918A
			public unsafe static Func<IOverloadableMemberDescriptor, bool> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OverloadedMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IOverloadableMemberDescriptor, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OverloadedMethodMemberDescriptor.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400167B RID: 5755
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400167C RID: 5756
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x0400167D RID: 5757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400167E RID: 5758
			private static readonly IntPtr NativeMethodInfoPtr__get_IsStatic_b__37_0_Internal_Boolean_IOverloadableMemberDescriptor_0;
		}

		// Token: 0x020001CC RID: 460
		[ObfuscatedName("MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Object
		{
			// Token: 0x06001BE7 RID: 7143 RVA: 0x00087EEC File Offset: 0x000860EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c__DisplayClass33_0>.NativeClassPtr);
				OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeFieldInfoPtr_script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c__DisplayClass33_0>.NativeClassPtr, "script");
				OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c__DisplayClass33_0>.NativeClassPtr, "obj");
				OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c__DisplayClass33_0>.NativeClassPtr, 100665837);
				OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeMethodInfoPtr__GetCallback_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c__DisplayClass33_0>.NativeClassPtr, 100665838);
			}

			// Token: 0x06001BE8 RID: 7144 RVA: 0x00087F7C File Offset: 0x0008617C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverloadedMethodMemberDescriptor.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BE9 RID: 7145 RVA: 0x00087FB8 File Offset: 0x000861B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36567, XrefRangeEnd = 36568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _GetCallback_b__0(ScriptExecutionContext context, CallbackArguments args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeMethodInfoPtr__GetCallback_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001BEA RID: 7146 RVA: 0x0000AF9C File Offset: 0x0000919C
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0008801C File Offset: 0x0008621C
			// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0000AFA5 File Offset: 0x000091A5
			public unsafe OverloadedMethodMemberDescriptor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverloadedMethodMemberDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x06001BED RID: 7149 RVA: 0x0008804C File Offset: 0x0008624C
			// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0000AFC4 File Offset: 0x000091C4
			public unsafe Script script
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeFieldInfoPtr_script);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeFieldInfoPtr_script), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0008807C File Offset: 0x0008627C
			// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x0000AFE3 File Offset: 0x000091E3
			public unsafe Object obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverloadedMethodMemberDescriptor.__c__DisplayClass33_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400167F RID: 5759
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001680 RID: 5760
			private static readonly IntPtr NativeFieldInfoPtr_script;

			// Token: 0x04001681 RID: 5761
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x04001682 RID: 5762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001683 RID: 5763
			private static readonly IntPtr NativeMethodInfoPtr__GetCallback_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;
		}
	}
}
