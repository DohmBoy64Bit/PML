using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;
using MoonSharp.Interpreter.Interop.RegistrationPolicies;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003A RID: 58
	public class UserData : RefIdObject
	{
		// Token: 0x06000761 RID: 1889 RVA: 0x00031CD8 File Offset: 0x0002FED8
		// Note: this type is marked as 'beforefieldinit'.
		static UserData()
		{
			Il2CppClassPointerStore<UserData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "UserData");
			UserData.NativeFieldInfoPtr__UserValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "<UserValue>k__BackingField");
			UserData.NativeFieldInfoPtr__Object_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "<Object>k__BackingField");
			UserData.NativeFieldInfoPtr__Descriptor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "<Descriptor>k__BackingField");
			UserData.NativeFieldInfoPtr_m_MetaTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData>.NativeClassPtr, "m_MetaTable");
			UserData.NativeMethodInfoPtr_get_UserValue_Public_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664713);
			UserData.NativeMethodInfoPtr_set_UserValue_Public_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664714);
			UserData.NativeMethodInfoPtr_get_Object_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664715);
			UserData.NativeMethodInfoPtr_set_Object_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664716);
			UserData.NativeMethodInfoPtr_get_Descriptor_Public_get_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664717);
			UserData.NativeMethodInfoPtr_set_Descriptor_Private_set_Void_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664718);
			UserData.NativeMethodInfoPtr_get_MetaTable_Public_get_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664720);
			UserData.NativeMethodInfoPtr_set_MetaTable_Public_set_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664721);
			UserData.NativeMethodInfoPtr_get_RegistrationPolicy_Public_Static_get_IRegistrationPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664739);
			UserData.NativeMethodInfoPtr_set_RegistrationPolicy_Public_Static_set_Void_IRegistrationPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664740);
			UserData.NativeMethodInfoPtr_get_DefaultAccessMode_Public_Static_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664741);
			UserData.NativeMethodInfoPtr_set_DefaultAccessMode_Public_Static_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664742);
			UserData.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664712);
			UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_InteropAccessMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664722);
			UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_Type_InteropAccessMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664723);
			UserData.NativeMethodInfoPtr_RegisterProxyType_Public_Static_IUserDataDescriptor_IProxyFactory_InteropAccessMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664724);
			UserData.NativeMethodInfoPtr_RegisterProxyType_Public_Static_IUserDataDescriptor_Func_2_TTarget_TProxy_InteropAccessMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664725);
			UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664726);
			UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_Type_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664727);
			UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664728);
			UserData.NativeMethodInfoPtr_RegisterAssembly_Public_Static_Void_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664729);
			UserData.NativeMethodInfoPtr_IsTypeRegistered_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664730);
			UserData.NativeMethodInfoPtr_IsTypeRegistered_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664731);
			UserData.NativeMethodInfoPtr_UnregisterType_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664732);
			UserData.NativeMethodInfoPtr_UnregisterType_Public_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664733);
			UserData.NativeMethodInfoPtr_Create_Public_Static_DynValue_Object_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664734);
			UserData.NativeMethodInfoPtr_Create_Public_Static_DynValue_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664735);
			UserData.NativeMethodInfoPtr_CreateStatic_Public_Static_DynValue_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664736);
			UserData.NativeMethodInfoPtr_CreateStatic_Public_Static_DynValue_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664737);
			UserData.NativeMethodInfoPtr_CreateStatic_Public_Static_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664738);
			UserData.NativeMethodInfoPtr_RegisterExtensionType_Public_Static_Void_Type_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664743);
			UserData.NativeMethodInfoPtr_GetExtensionMethodsByNameAndType_Public_Static_List_1_IOverloadableMemberDescriptor_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664744);
			UserData.NativeMethodInfoPtr_GetExtensionMethodsChangeVersion_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664745);
			UserData.NativeMethodInfoPtr_GetDescriptorForType_Public_Static_IUserDataDescriptor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664746);
			UserData.NativeMethodInfoPtr_GetDescriptorForType_Public_Static_IUserDataDescriptor_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664747);
			UserData.NativeMethodInfoPtr_GetDescriptorForObject_Public_Static_IUserDataDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664748);
			UserData.NativeMethodInfoPtr_GetDescriptionOfRegisteredTypes_Public_Static_Table_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664749);
			UserData.NativeMethodInfoPtr_GetRegisteredTypes_Public_Static_IEnumerable_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData>.NativeClassPtr, 100664750);
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00032048 File Offset: 0x00030248
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00032088 File Offset: 0x00030288
		public unsafe DynValue UserValue
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_get_UserValue_Public_get_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_set_UserValue_Public_set_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x000320CC File Offset: 0x000302CC
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0003210C File Offset: 0x0003030C
		public unsafe Object Object
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_get_Object_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_set_Object_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00032150 File Offset: 0x00030350
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00032190 File Offset: 0x00030390
		public unsafe IUserDataDescriptor Descriptor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_get_Descriptor_Public_get_IUserDataDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_set_Descriptor_Private_set_Void_IUserDataDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000321D4 File Offset: 0x000303D4
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00032214 File Offset: 0x00030414
		public unsafe Table MetaTable
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_get_MetaTable_Public_get_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_set_MetaTable_Public_set_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00032258 File Offset: 0x00030458
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x0003228C File Offset: 0x0003048C
		public unsafe static IRegistrationPolicy RegistrationPolicy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24334, XrefRangeEnd = 24342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_get_RegistrationPolicy_Public_Static_get_IRegistrationPolicy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRegistrationPolicy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24342, XrefRangeEnd = 24351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_set_RegistrationPolicy_Public_Static_set_Void_IRegistrationPolicy_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x000322C4 File Offset: 0x000304C4
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x000322F8 File Offset: 0x000304F8
		public unsafe static InteropAccessMode DefaultAccessMode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 24359, RefRangeEnd = 24363, XrefRangeStart = 24351, XrefRangeEnd = 24359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_get_DefaultAccessMode_Public_Static_get_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24363, XrefRangeEnd = 24367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_set_DefaultAccessMode_Public_Static_set_Void_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00032330 File Offset: 0x00030530
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 23215, RefRangeEnd = 23222, XrefRangeStart = 23215, XrefRangeEnd = 23222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0003236C File Offset: 0x0003056C
		[CallerCount(0)]
		public unsafe static IUserDataDescriptor RegisterType<T>(InteropAccessMode accessMode = InteropAccessMode.Default, string friendlyName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.MethodInfoStoreGeneric_RegisterType_Public_Static_IUserDataDescriptor_InteropAccessMode_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000323C4 File Offset: 0x000305C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 24371, RefRangeEnd = 24374, XrefRangeStart = 24367, XrefRangeEnd = 24371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IUserDataDescriptor RegisterType(Type type, InteropAccessMode accessMode = InteropAccessMode.Default, string friendlyName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_Type_InteropAccessMode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0003242C File Offset: 0x0003062C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24374, XrefRangeEnd = 24378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IUserDataDescriptor RegisterProxyType(IProxyFactory proxyFactory, InteropAccessMode accessMode = InteropAccessMode.Default, string friendlyName = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_RegisterProxyType_Public_Static_IUserDataDescriptor_IProxyFactory_InteropAccessMode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00032494 File Offset: 0x00030694
		[CallerCount(0)]
		public unsafe static IUserDataDescriptor RegisterProxyType<TProxy, TTarget>(Func<TTarget, TProxy> wrapDelegate, InteropAccessMode accessMode = InteropAccessMode.Default, string friendlyName = null) where TProxy : class where TTarget : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapDelegate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.MethodInfoStoreGeneric_RegisterProxyType_Public_Static_IUserDataDescriptor_Func_2_TTarget_TProxy_InteropAccessMode_String_0<TProxy, TTarget>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000324FC File Offset: 0x000306FC
		[CallerCount(0)]
		public unsafe static IUserDataDescriptor RegisterType<T>(IUserDataDescriptor customDescriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customDescriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.MethodInfoStoreGeneric_RegisterType_Public_Static_IUserDataDescriptor_IUserDataDescriptor_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00032540 File Offset: 0x00030740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24378, XrefRangeEnd = 24382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IUserDataDescriptor RegisterType(Type type, IUserDataDescriptor customDescriptor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customDescriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_Type_IUserDataDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00032598 File Offset: 0x00030798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24382, XrefRangeEnd = 24389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IUserDataDescriptor RegisterType(IUserDataDescriptor customDescriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customDescriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_IUserDataDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000325DC File Offset: 0x000307DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24389, XrefRangeEnd = 24395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_RegisterAssembly_Public_Static_Void_Assembly_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00032620 File Offset: 0x00030820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24399, RefRangeEnd = 24400, XrefRangeStart = 24395, XrefRangeEnd = 24399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTypeRegistered(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_IsTypeRegistered_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00032664 File Offset: 0x00030864
		[CallerCount(0)]
		public unsafe static bool IsTypeRegistered<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.MethodInfoStoreGeneric_IsTypeRegistered_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00032694 File Offset: 0x00030894
		[CallerCount(0)]
		public unsafe static void UnregisterType<T>(bool deleteHistory = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deleteHistory;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.MethodInfoStoreGeneric_UnregisterType_Public_Static_Void_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000326C8 File Offset: 0x000308C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24400, XrefRangeEnd = 24430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_UnregisterType_Public_Static_Void_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0003270C File Offset: 0x0003090C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 24442, RefRangeEnd = 24445, XrefRangeStart = 24430, XrefRangeEnd = 24442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue Create(Object o, IUserDataDescriptor descr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_Create_Public_Static_DynValue_Object_IUserDataDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00032764 File Offset: 0x00030964
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 24490, RefRangeEnd = 24504, XrefRangeStart = 24445, XrefRangeEnd = 24490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue Create(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_Create_Public_Static_DynValue_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000327A8 File Offset: 0x000309A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24504, XrefRangeEnd = 24516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue CreateStatic(IUserDataDescriptor descr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_CreateStatic_Public_Static_DynValue_IUserDataDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000327EC File Offset: 0x000309EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24535, RefRangeEnd = 24537, XrefRangeStart = 24516, XrefRangeEnd = 24535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue CreateStatic(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_CreateStatic_Public_Static_DynValue_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00032830 File Offset: 0x00030A30
		[CallerCount(0)]
		public unsafe static DynValue CreateStatic<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.MethodInfoStoreGeneric_CreateStatic_Public_Static_DynValue_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00032864 File Offset: 0x00030A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24541, RefRangeEnd = 24542, XrefRangeStart = 24537, XrefRangeEnd = 24541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterExtensionType(Type type, InteropAccessMode mode = InteropAccessMode.Default)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_RegisterExtensionType_Public_Static_Void_Type_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000328AC File Offset: 0x00030AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24546, RefRangeEnd = 24547, XrefRangeStart = 24542, XrefRangeEnd = 24546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extendedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_GetExtensionMethodsByNameAndType_Public_Static_List_1_IOverloadableMemberDescriptor_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IOverloadableMemberDescriptor>>(intPtr3) : null;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00032904 File Offset: 0x00030B04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24555, RefRangeEnd = 24557, XrefRangeStart = 24547, XrefRangeEnd = 24555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetExtensionMethodsChangeVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_GetExtensionMethodsChangeVersion_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00032934 File Offset: 0x00030B34
		[CallerCount(0)]
		public unsafe static IUserDataDescriptor GetDescriptorForType<T>(bool searchInterfaces)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref searchInterfaces;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.MethodInfoStoreGeneric_GetDescriptorForType_Public_Static_IUserDataDescriptor_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00032974 File Offset: 0x00030B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24557, XrefRangeEnd = 24561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_GetDescriptorForType_Public_Static_IUserDataDescriptor_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000329C8 File Offset: 0x00030BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24561, XrefRangeEnd = 24567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IUserDataDescriptor GetDescriptorForObject(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_GetDescriptorForObject_Public_Static_IUserDataDescriptor_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00032A0C File Offset: 0x00030C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24567, XrefRangeEnd = 24610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Table GetDescriptionOfRegisteredTypes(bool useHistoricalData = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useHistoricalData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_GetDescriptionOfRegisteredTypes_Public_Static_Table_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Table>(intPtr3) : null;
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00032A4C File Offset: 0x00030C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24610, XrefRangeEnd = 24635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetRegisteredTypes(bool useHistoricalData = false)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useHistoricalData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.NativeMethodInfoPtr_GetRegisteredTypes_Public_Static_IEnumerable_1_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00003DB2 File Offset: 0x00001FB2
		public UserData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00032A8C File Offset: 0x00030C8C
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00003DBB File Offset: 0x00001FBB
		public unsafe DynValue _UserValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserData.NativeFieldInfoPtr__UserValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserData.NativeFieldInfoPtr__UserValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00032ABC File Offset: 0x00030CBC
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00003DDA File Offset: 0x00001FDA
		public unsafe Object _Object_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserData.NativeFieldInfoPtr__Object_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserData.NativeFieldInfoPtr__Object_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00032AEC File Offset: 0x00030CEC
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00003DF9 File Offset: 0x00001FF9
		public unsafe IUserDataDescriptor _Descriptor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserData.NativeFieldInfoPtr__Descriptor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserData.NativeFieldInfoPtr__Descriptor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00032B1C File Offset: 0x00030D1C
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x00003E18 File Offset: 0x00002018
		public unsafe Table m_MetaTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserData.NativeFieldInfoPtr_m_MetaTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Table>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserData.NativeFieldInfoPtr_m_MetaTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeFieldInfoPtr__UserValue_k__BackingField;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeFieldInfoPtr__Object_k__BackingField;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr__Descriptor_k__BackingField;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr_m_MetaTable;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_get_UserValue_Public_get_DynValue_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_set_UserValue_Public_set_Void_DynValue_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_get_Object_Public_get_Object_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_set_Object_Private_set_Void_Object_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_get_Descriptor_Public_get_IUserDataDescriptor_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_set_Descriptor_Private_set_Void_IUserDataDescriptor_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_get_MetaTable_Public_get_Table_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_set_MetaTable_Public_set_Void_Table_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_get_RegistrationPolicy_Public_Static_get_IRegistrationPolicy_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_set_RegistrationPolicy_Public_Static_set_Void_IRegistrationPolicy_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAccessMode_Public_Static_get_InteropAccessMode_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultAccessMode_Public_Static_set_Void_InteropAccessMode_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_InteropAccessMode_String_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_Type_InteropAccessMode_String_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_RegisterProxyType_Public_Static_IUserDataDescriptor_IProxyFactory_InteropAccessMode_String_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_RegisterProxyType_Public_Static_IUserDataDescriptor_Func_2_TTarget_TProxy_InteropAccessMode_String_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_IUserDataDescriptor_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_Type_IUserDataDescriptor_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_IUserDataDescriptor_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_RegisterAssembly_Public_Static_Void_Assembly_Boolean_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeRegistered_Public_Static_Boolean_Type_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeRegistered_Public_Static_Boolean_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterType_Public_Static_Void_Boolean_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterType_Public_Static_Void_Type_Boolean_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DynValue_Object_IUserDataDescriptor_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DynValue_Object_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_CreateStatic_Public_Static_DynValue_IUserDataDescriptor_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_CreateStatic_Public_Static_DynValue_Type_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_CreateStatic_Public_Static_DynValue_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_RegisterExtensionType_Public_Static_Void_Type_InteropAccessMode_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_GetExtensionMethodsByNameAndType_Public_Static_List_1_IOverloadableMemberDescriptor_String_Type_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_GetExtensionMethodsChangeVersion_Public_Static_Int32_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptorForType_Public_Static_IUserDataDescriptor_Boolean_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptorForType_Public_Static_IUserDataDescriptor_Type_Boolean_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptorForObject_Public_Static_IUserDataDescriptor_Object_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionOfRegisteredTypes_Public_Static_Table_Boolean_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredTypes_Public_Static_IEnumerable_1_Type_Boolean_0;

		// Token: 0x0200018D RID: 397
		[ObfuscatedName("MoonSharp.Interpreter.UserData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001A1C RID: 6684 RVA: 0x000805D0 File Offset: 0x0007E7D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UserData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserData.__c>.NativeClassPtr);
				UserData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData.__c>.NativeClassPtr, "<>9");
				UserData.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserData.__c>.NativeClassPtr, "<>9__48_0");
				UserData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData.__c>.NativeClassPtr, 100664752);
				UserData.__c.NativeMethodInfoPtr__GetRegisteredTypes_b__48_0_Internal_Type_KeyValuePair_2_Type_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserData.__c>.NativeClassPtr, 100664753);
			}

			// Token: 0x06001A1D RID: 6685 RVA: 0x0008064C File Offset: 0x0007E84C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A1E RID: 6686 RVA: 0x00080688 File Offset: 0x0007E888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24329, XrefRangeEnd = 24334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type _GetRegisteredTypes_b__48_0(KeyValuePair<Type, IUserDataDescriptor> p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserData.__c.NativeMethodInfoPtr__GetRegisteredTypes_b__48_0_Internal_Type_KeyValuePair_2_Type_IUserDataDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06001A1F RID: 6687 RVA: 0x0000A517 File Offset: 0x00008717
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x06001A20 RID: 6688 RVA: 0x000806D8 File Offset: 0x0007E8D8
			// (set) Token: 0x06001A21 RID: 6689 RVA: 0x0000A520 File Offset: 0x00008720
			public unsafe static UserData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UserData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UserData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00080700 File Offset: 0x0007E900
			// (set) Token: 0x06001A23 RID: 6691 RVA: 0x0000A532 File Offset: 0x00008732
			public unsafe static Func<KeyValuePair<Type, IUserDataDescriptor>, Type> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UserData.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Type, IUserDataDescriptor>, Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UserData.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400156F RID: 5487
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001570 RID: 5488
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x04001571 RID: 5489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001572 RID: 5490
			private static readonly IntPtr NativeMethodInfoPtr__GetRegisteredTypes_b__48_0_Internal_Type_KeyValuePair_2_Type_IUserDataDescriptor_0;
		}

		// Token: 0x0200018E RID: 398
		private sealed class MethodInfoStoreGeneric_RegisterType_Public_Static_IUserDataDescriptor_InteropAccessMode_String_0<T>
		{
			// Token: 0x04001573 RID: 5491
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_InteropAccessMode_String_0, Il2CppClassPointerStore<UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200018F RID: 399
		private sealed class MethodInfoStoreGeneric_RegisterProxyType_Public_Static_IUserDataDescriptor_Func_2_TTarget_TProxy_InteropAccessMode_String_0<TProxy, TTarget>
		{
			// Token: 0x04001574 RID: 5492
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UserData.NativeMethodInfoPtr_RegisterProxyType_Public_Static_IUserDataDescriptor_Func_2_TTarget_TProxy_InteropAccessMode_String_0, Il2CppClassPointerStore<UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TProxy>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTarget>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000190 RID: 400
		private sealed class MethodInfoStoreGeneric_RegisterType_Public_Static_IUserDataDescriptor_IUserDataDescriptor_0<T>
		{
			// Token: 0x04001575 RID: 5493
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UserData.NativeMethodInfoPtr_RegisterType_Public_Static_IUserDataDescriptor_IUserDataDescriptor_0, Il2CppClassPointerStore<UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000191 RID: 401
		private sealed class MethodInfoStoreGeneric_IsTypeRegistered_Public_Static_Boolean_0<T>
		{
			// Token: 0x04001576 RID: 5494
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UserData.NativeMethodInfoPtr_IsTypeRegistered_Public_Static_Boolean_0, Il2CppClassPointerStore<UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000192 RID: 402
		private sealed class MethodInfoStoreGeneric_UnregisterType_Public_Static_Void_Boolean_0<T>
		{
			// Token: 0x04001577 RID: 5495
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UserData.NativeMethodInfoPtr_UnregisterType_Public_Static_Void_Boolean_0, Il2CppClassPointerStore<UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000193 RID: 403
		private sealed class MethodInfoStoreGeneric_CreateStatic_Public_Static_DynValue_0<T>
		{
			// Token: 0x04001578 RID: 5496
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UserData.NativeMethodInfoPtr_CreateStatic_Public_Static_DynValue_0, Il2CppClassPointerStore<UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000194 RID: 404
		private sealed class MethodInfoStoreGeneric_GetDescriptorForType_Public_Static_IUserDataDescriptor_Boolean_0<T>
		{
			// Token: 0x04001579 RID: 5497
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UserData.NativeMethodInfoPtr_GetDescriptorForType_Public_Static_IUserDataDescriptor_Boolean_0, Il2CppClassPointerStore<UserData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
