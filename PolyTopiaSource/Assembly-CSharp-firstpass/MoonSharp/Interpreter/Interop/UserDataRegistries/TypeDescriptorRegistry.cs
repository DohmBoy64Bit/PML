using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Interop.RegistrationPolicies;

namespace MoonSharp.Interpreter.Interop.UserDataRegistries
{
	// Token: 0x020000BF RID: 191
	public static class TypeDescriptorRegistry : Object
	{
		// Token: 0x06000EE7 RID: 3815 RVA: 0x000517D0 File Offset: 0x0004F9D0
		// Note: this type is marked as 'beforefieldinit'.
		static TypeDescriptorRegistry()
		{
			Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.UserDataRegistries", "TypeDescriptorRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr);
			TypeDescriptorRegistry.NativeFieldInfoPtr_s_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, "s_Lock");
			TypeDescriptorRegistry.NativeFieldInfoPtr_s_TypeRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, "s_TypeRegistry");
			TypeDescriptorRegistry.NativeFieldInfoPtr_s_TypeRegistryHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, "s_TypeRegistryHistory");
			TypeDescriptorRegistry.NativeFieldInfoPtr_s_DefaultAccessMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, "s_DefaultAccessMode");
			TypeDescriptorRegistry.NativeFieldInfoPtr__RegistrationPolicy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, "<RegistrationPolicy>k__BackingField");
			TypeDescriptorRegistry.NativeMethodInfoPtr_get_DefaultAccessMode_Internal_Static_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665980);
			TypeDescriptorRegistry.NativeMethodInfoPtr_set_DefaultAccessMode_Internal_Static_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665981);
			TypeDescriptorRegistry.NativeMethodInfoPtr_get_RegisteredTypes_Public_Static_get_IEnumerable_1_KeyValuePair_2_Type_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665989);
			TypeDescriptorRegistry.NativeMethodInfoPtr_get_RegisteredTypesHistory_Public_Static_get_IEnumerable_1_KeyValuePair_2_Type_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665990);
			TypeDescriptorRegistry.NativeMethodInfoPtr_get_RegistrationPolicy_Internal_Static_get_IRegistrationPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665991);
			TypeDescriptorRegistry.NativeMethodInfoPtr_set_RegistrationPolicy_Internal_Static_set_Void_IRegistrationPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665992);
			TypeDescriptorRegistry.NativeMethodInfoPtr_RegisterAssembly_Internal_Static_Void_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665977);
			TypeDescriptorRegistry.NativeMethodInfoPtr_IsTypeRegistered_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665978);
			TypeDescriptorRegistry.NativeMethodInfoPtr_UnregisterType_Internal_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665979);
			TypeDescriptorRegistry.NativeMethodInfoPtr_RegisterProxyType_Impl_Internal_Static_IUserDataDescriptor_IProxyFactory_InteropAccessMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665982);
			TypeDescriptorRegistry.NativeMethodInfoPtr_RegisterType_Impl_Internal_Static_IUserDataDescriptor_Type_InteropAccessMode_String_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665983);
			TypeDescriptorRegistry.NativeMethodInfoPtr_PerformRegistration_Private_Static_IUserDataDescriptor_Type_IUserDataDescriptor_IUserDataDescriptor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665984);
			TypeDescriptorRegistry.NativeMethodInfoPtr_ResolveDefaultAccessModeForType_Internal_Static_InteropAccessMode_InteropAccessMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665985);
			TypeDescriptorRegistry.NativeMethodInfoPtr_GetDescriptorForType_Internal_Static_IUserDataDescriptor_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665986);
			TypeDescriptorRegistry.NativeMethodInfoPtr_FrameworkIsAssignableFrom_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665987);
			TypeDescriptorRegistry.NativeMethodInfoPtr_IsTypeBlacklisted_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, 100665988);
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x000519A4 File Offset: 0x0004FBA4
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x000519D8 File Offset: 0x0004FBD8
		public unsafe static InteropAccessMode DefaultAccessMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38891, XrefRangeEnd = 38895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_get_DefaultAccessMode_Internal_Static_get_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 38899, RefRangeEnd = 38901, XrefRangeStart = 38895, XrefRangeEnd = 38899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_set_DefaultAccessMode_Internal_Static_set_Void_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00051A10 File Offset: 0x0004FC10
		public unsafe static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 38915, RefRangeEnd = 38917, XrefRangeStart = 38901, XrefRangeEnd = 38915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_get_RegisteredTypes_Public_Static_get_IEnumerable_1_KeyValuePair_2_Type_IUserDataDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Type, IUserDataDescriptor>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00051A44 File Offset: 0x0004FC44
		public unsafe static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypesHistory
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 38931, RefRangeEnd = 38933, XrefRangeStart = 38917, XrefRangeEnd = 38931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_get_RegisteredTypesHistory_Public_Static_get_IEnumerable_1_KeyValuePair_2_Type_IUserDataDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Type, IUserDataDescriptor>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00051A78 File Offset: 0x0004FC78
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00051AAC File Offset: 0x0004FCAC
		public unsafe static IRegistrationPolicy RegistrationPolicy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38933, XrefRangeEnd = 38937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_get_RegistrationPolicy_Internal_Static_get_IRegistrationPolicy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRegistrationPolicy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38937, XrefRangeEnd = 38943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_set_RegistrationPolicy_Internal_Static_set_Void_IRegistrationPolicy_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00051AE4 File Offset: 0x0004FCE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39090, RefRangeEnd = 39091, XrefRangeStart = 38943, XrefRangeEnd = 39090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterAssembly(Assembly asm = null, bool includeExtensionTypes = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeExtensionTypes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_RegisterAssembly_Internal_Static_Void_Assembly_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00051B28 File Offset: 0x0004FD28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39105, RefRangeEnd = 39106, XrefRangeStart = 39091, XrefRangeEnd = 39105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTypeRegistered(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_IsTypeRegistered_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00051B6C File Offset: 0x0004FD6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39127, RefRangeEnd = 39128, XrefRangeStart = 39106, XrefRangeEnd = 39127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterType(Type t, bool deleteHistory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deleteHistory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_UnregisterType_Internal_Static_Void_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00051BB0 File Offset: 0x0004FDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39152, RefRangeEnd = 39153, XrefRangeStart = 39128, XrefRangeEnd = 39152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IUserDataDescriptor RegisterProxyType_Impl(IProxyFactory proxyFactory, InteropAccessMode accessMode, string friendlyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxyFactory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_RegisterProxyType_Impl_Internal_Static_IUserDataDescriptor_IProxyFactory_InteropAccessMode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00051C18 File Offset: 0x0004FE18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 39310, RefRangeEnd = 39316, XrefRangeStart = 39153, XrefRangeEnd = 39310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IUserDataDescriptor RegisterType_Impl(Type type, InteropAccessMode accessMode, string friendlyName, IUserDataDescriptor descriptor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_RegisterType_Impl_Internal_Static_IUserDataDescriptor_Type_InteropAccessMode_String_IUserDataDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00051C94 File Offset: 0x0004FE94
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 39347, RefRangeEnd = 39353, XrefRangeStart = 39316, XrefRangeEnd = 39347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IUserDataDescriptor PerformRegistration(Type type, IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor, bool deleteHistory = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newDescriptor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldDescriptor);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deleteHistory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_PerformRegistration_Private_Static_IUserDataDescriptor_Type_IUserDataDescriptor_IUserDataDescriptor_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00051D0C File Offset: 0x0004FF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39353, XrefRangeEnd = 39370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InteropAccessMode ResolveDefaultAccessModeForType(InteropAccessMode accessMode, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_ResolveDefaultAccessModeForType_Internal_Static_InteropAccessMode_InteropAccessMode_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr3) : null;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00051D64 File Offset: 0x0004FF64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 39517, RefRangeEnd = 39522, XrefRangeStart = 39370, XrefRangeEnd = 39517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchInterfaces;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_GetDescriptorForType_Internal_Static_IUserDataDescriptor_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00051DB8 File Offset: 0x0004FFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39522, XrefRangeEnd = 39527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FrameworkIsAssignableFrom(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_FrameworkIsAssignableFrom_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00051DFC File Offset: 0x0004FFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39527, XrefRangeEnd = 39548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTypeBlacklisted(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.NativeMethodInfoPtr_IsTypeBlacklisted_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0000685E File Offset: 0x00004A5E
		public TypeDescriptorRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00051E40 File Offset: 0x00050040
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00006867 File Offset: 0x00004A67
		public unsafe static Object s_Lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.NativeFieldInfoPtr_s_Lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.NativeFieldInfoPtr_s_Lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00051E68 File Offset: 0x00050068
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00006879 File Offset: 0x00004A79
		public unsafe static Dictionary<Type, IUserDataDescriptor> s_TypeRegistry
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.NativeFieldInfoPtr_s_TypeRegistry, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, IUserDataDescriptor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.NativeFieldInfoPtr_s_TypeRegistry, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00051E90 File Offset: 0x00050090
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x0000688B File Offset: 0x00004A8B
		public unsafe static Dictionary<Type, IUserDataDescriptor> s_TypeRegistryHistory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.NativeFieldInfoPtr_s_TypeRegistryHistory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, IUserDataDescriptor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.NativeFieldInfoPtr_s_TypeRegistryHistory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00051EB8 File Offset: 0x000500B8
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x0000689D File Offset: 0x00004A9D
		public unsafe static InteropAccessMode s_DefaultAccessMode
		{
			get
			{
				InteropAccessMode interopAccessMode;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.NativeFieldInfoPtr_s_DefaultAccessMode, (void*)(&interopAccessMode));
				return interopAccessMode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.NativeFieldInfoPtr_s_DefaultAccessMode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00051ED4 File Offset: 0x000500D4
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x000068AF File Offset: 0x00004AAF
		public unsafe static IRegistrationPolicy _RegistrationPolicy_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.NativeFieldInfoPtr__RegistrationPolicy_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRegistrationPolicy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.NativeFieldInfoPtr__RegistrationPolicy_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr_s_Lock;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeFieldInfoPtr_s_TypeRegistry;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeFieldInfoPtr_s_TypeRegistryHistory;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultAccessMode;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeFieldInfoPtr__RegistrationPolicy_k__BackingField;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAccessMode_Internal_Static_get_InteropAccessMode_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultAccessMode_Internal_Static_set_Void_InteropAccessMode_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisteredTypes_Public_Static_get_IEnumerable_1_KeyValuePair_2_Type_IUserDataDescriptor_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisteredTypesHistory_Public_Static_get_IEnumerable_1_KeyValuePair_2_Type_IUserDataDescriptor_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_get_RegistrationPolicy_Internal_Static_get_IRegistrationPolicy_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_set_RegistrationPolicy_Internal_Static_set_Void_IRegistrationPolicy_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_RegisterAssembly_Internal_Static_Void_Assembly_Boolean_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeRegistered_Internal_Static_Boolean_Type_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterType_Internal_Static_Void_Type_Boolean_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_RegisterProxyType_Impl_Internal_Static_IUserDataDescriptor_IProxyFactory_InteropAccessMode_String_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_RegisterType_Impl_Internal_Static_IUserDataDescriptor_Type_InteropAccessMode_String_IUserDataDescriptor_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_PerformRegistration_Private_Static_IUserDataDescriptor_Type_IUserDataDescriptor_IUserDataDescriptor_Boolean_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_ResolveDefaultAccessModeForType_Internal_Static_InteropAccessMode_InteropAccessMode_Type_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptorForType_Internal_Static_IUserDataDescriptor_Type_Boolean_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_FrameworkIsAssignableFrom_Private_Static_Boolean_Type_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeBlacklisted_Public_Static_Boolean_Type_0;

		// Token: 0x020001D4 RID: 468
		[ObfuscatedName("MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C79 RID: 7289 RVA: 0x00089B3C File Offset: 0x00087D3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr);
				TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, "<>9");
				TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, "<>9__4_3");
				TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, "<>9__4_4");
				TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, "<>9__4_5");
				TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, "<>9__4_0");
				TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, "<>9__4_1");
				TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, "<>9__4_2");
				TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, "<>9__11_0");
				TypeDescriptorRegistry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, 100665995);
				TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_3_Internal___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, 100665996);
				TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_4_Internal_Boolean___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, 100665997);
				TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_5_Internal___f__AnonymousType1_2_Il2CppReferenceArray_1_Attribute_Type___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, 100665998);
				TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_0_Internal___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, 100665999);
				TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_1_Internal_Boolean___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, 100666000);
				TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_2_Internal___f__AnonymousType1_2_Il2CppReferenceArray_1_Attribute_Type___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, 100666001);
				TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterType_Impl_b__11_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr, 100666002);
			}

			// Token: 0x06001C7A RID: 7290 RVA: 0x00089CA8 File Offset: 0x00087EA8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptorRegistry.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C7B RID: 7291 RVA: 0x00089CE4 File Offset: 0x00087EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38827, XrefRangeEnd = 38845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>> _RegisterAssembly_b__4_3(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_3_Internal___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7C RID: 7292 RVA: 0x00089D34 File Offset: 0x00087F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38845, XrefRangeEnd = 38846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RegisterAssembly_b__4_4(__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>> <>h__TransparentIdentifier0)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<>h__TransparentIdentifier0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_4_Internal_Boolean___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C7D RID: 7293 RVA: 0x00089D84 File Offset: 0x00087F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38846, XrefRangeEnd = 38854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType1<Il2CppReferenceArray<Attribute>, Type> _RegisterAssembly_b__4_5(__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>> <>h__TransparentIdentifier0)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<>h__TransparentIdentifier0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_5_Internal___f__AnonymousType1_2_Il2CppReferenceArray_1_Attribute_Type___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType1<Il2CppReferenceArray<Attribute>, Type>>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7E RID: 7294 RVA: 0x00089DD4 File Offset: 0x00087FD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38854, XrefRangeEnd = 38872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>> _RegisterAssembly_b__4_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_0_Internal___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7F RID: 7295 RVA: 0x00089E24 File Offset: 0x00088024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38872, XrefRangeEnd = 38873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RegisterAssembly_b__4_1(__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>> <>h__TransparentIdentifier0)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<>h__TransparentIdentifier0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_1_Internal_Boolean___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C80 RID: 7296 RVA: 0x00089E74 File Offset: 0x00088074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38873, XrefRangeEnd = 38881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType1<Il2CppReferenceArray<Attribute>, Type> _RegisterAssembly_b__4_2(__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>> <>h__TransparentIdentifier0)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<>h__TransparentIdentifier0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterAssembly_b__4_2_Internal___f__AnonymousType1_2_Il2CppReferenceArray_1_Attribute_Type___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType1<Il2CppReferenceArray<Attribute>, Type>>(intPtr3) : null;
				}
			}

			// Token: 0x06001C81 RID: 7297 RVA: 0x00089EC4 File Offset: 0x000880C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38881, XrefRangeEnd = 38887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RegisterType_Impl_b__11_0(Type ii)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ii);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c.NativeMethodInfoPtr__RegisterType_Impl_b__11_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C82 RID: 7298 RVA: 0x0000B38B File Offset: 0x0000958B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x06001C83 RID: 7299 RVA: 0x00089F14 File Offset: 0x00088114
			// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0000B394 File Offset: 0x00009594
			public unsafe static TypeDescriptorRegistry.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeDescriptorRegistry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x06001C85 RID: 7301 RVA: 0x00089F3C File Offset: 0x0008813C
			// (set) Token: 0x06001C86 RID: 7302 RVA: 0x0000B3A6 File Offset: 0x000095A6
			public unsafe static Func<Type, __f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, __f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00089F64 File Offset: 0x00088164
			// (set) Token: 0x06001C88 RID: 7304 RVA: 0x0000B3B8 File Offset: 0x000095B8
			public unsafe static Func<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>, bool> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00089F8C File Offset: 0x0008818C
			// (set) Token: 0x06001C8A RID: 7306 RVA: 0x0000B3CA File Offset: 0x000095CA
			public unsafe static Func<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>, __f__AnonymousType1<Il2CppReferenceArray<Attribute>, Type>> __9__4_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>, __f__AnonymousType1<Il2CppReferenceArray<Attribute>, Type>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00089FB4 File Offset: 0x000881B4
			// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0000B3DC File Offset: 0x000095DC
			public unsafe static Func<Type, __f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, __f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00089FDC File Offset: 0x000881DC
			// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0000B3EE File Offset: 0x000095EE
			public unsafe static Func<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x06001C8F RID: 7311 RVA: 0x0008A004 File Offset: 0x00088204
			// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0000B400 File Offset: 0x00009600
			public unsafe static Func<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>, __f__AnonymousType1<Il2CppReferenceArray<Attribute>, Type>> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<Type, Il2CppReferenceArray<Attribute>>, __f__AnonymousType1<Il2CppReferenceArray<Attribute>, Type>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x06001C91 RID: 7313 RVA: 0x0008A02C File Offset: 0x0008822C
			// (set) Token: 0x06001C92 RID: 7314 RVA: 0x0000B412 File Offset: 0x00009612
			public unsafe static Func<Type, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TypeDescriptorRegistry.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016D5 RID: 5845
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016D6 RID: 5846
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x040016D7 RID: 5847
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x040016D8 RID: 5848
			private static readonly IntPtr NativeFieldInfoPtr___9__4_5;

			// Token: 0x040016D9 RID: 5849
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040016DA RID: 5850
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040016DB RID: 5851
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x040016DC RID: 5852
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040016DD RID: 5853
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016DE RID: 5854
			private static readonly IntPtr NativeMethodInfoPtr__RegisterAssembly_b__4_3_Internal___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_Type_0;

			// Token: 0x040016DF RID: 5855
			private static readonly IntPtr NativeMethodInfoPtr__RegisterAssembly_b__4_4_Internal_Boolean___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0;

			// Token: 0x040016E0 RID: 5856
			private static readonly IntPtr NativeMethodInfoPtr__RegisterAssembly_b__4_5_Internal___f__AnonymousType1_2_Il2CppReferenceArray_1_Attribute_Type___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0;

			// Token: 0x040016E1 RID: 5857
			private static readonly IntPtr NativeMethodInfoPtr__RegisterAssembly_b__4_0_Internal___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_Type_0;

			// Token: 0x040016E2 RID: 5858
			private static readonly IntPtr NativeMethodInfoPtr__RegisterAssembly_b__4_1_Internal_Boolean___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0;

			// Token: 0x040016E3 RID: 5859
			private static readonly IntPtr NativeMethodInfoPtr__RegisterAssembly_b__4_2_Internal___f__AnonymousType1_2_Il2CppReferenceArray_1_Attribute_Type___f__AnonymousType0_2_Type_Il2CppReferenceArray_1_Attribute_0;

			// Token: 0x040016E4 RID: 5860
			private static readonly IntPtr NativeMethodInfoPtr__RegisterType_Impl_b__11_0_Internal_Boolean_Type_0;
		}

		// Token: 0x020001D5 RID: 469
		[ObfuscatedName("MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06001C93 RID: 7315 RVA: 0x0008A054 File Offset: 0x00088254
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<TypeDescriptorRegistry.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptorRegistry>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptorRegistry.__c__DisplayClass11_0>.NativeClassPtr);
				TypeDescriptorRegistry.__c__DisplayClass11_0.NativeFieldInfoPtr_udd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptorRegistry.__c__DisplayClass11_0>.NativeClassPtr, "udd");
				TypeDescriptorRegistry.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c__DisplayClass11_0>.NativeClassPtr, 100666003);
				TypeDescriptorRegistry.__c__DisplayClass11_0.NativeMethodInfoPtr__RegisterType_Impl_b__1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptorRegistry.__c__DisplayClass11_0>.NativeClassPtr, 100666004);
			}

			// Token: 0x06001C94 RID: 7316 RVA: 0x0008A0BC File Offset: 0x000882BC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptorRegistry.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C95 RID: 7317 RVA: 0x0008A0F8 File Offset: 0x000882F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38887, XrefRangeEnd = 38891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterType_Impl_b__1(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptorRegistry.__c__DisplayClass11_0.NativeMethodInfoPtr__RegisterType_Impl_b__1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C96 RID: 7318 RVA: 0x0000B424 File Offset: 0x00009624
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x06001C97 RID: 7319 RVA: 0x0008A13C File Offset: 0x0008833C
			// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0000B42D File Offset: 0x0000962D
			public unsafe StandardUserDataDescriptor udd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptorRegistry.__c__DisplayClass11_0.NativeFieldInfoPtr_udd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandardUserDataDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptorRegistry.__c__DisplayClass11_0.NativeFieldInfoPtr_udd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016E5 RID: 5861
			private static readonly IntPtr NativeFieldInfoPtr_udd;

			// Token: 0x040016E6 RID: 5862
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016E7 RID: 5863
			private static readonly IntPtr NativeMethodInfoPtr__RegisterType_Impl_b__1_Internal_Void_Object_0;
		}
	}
}
