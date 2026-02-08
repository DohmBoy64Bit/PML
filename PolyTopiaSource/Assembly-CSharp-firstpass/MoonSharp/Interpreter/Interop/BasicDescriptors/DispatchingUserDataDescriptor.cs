using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D4 RID: 212
	public class DispatchingUserDataDescriptor : Object
	{
		// Token: 0x0600105F RID: 4191 RVA: 0x00057C04 File Offset: 0x00055E04
		// Note: this type is marked as 'beforefieldinit'.
		static DispatchingUserDataDescriptor()
		{
			Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.BasicDescriptors", "DispatchingUserDataDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr);
			DispatchingUserDataDescriptor.NativeFieldInfoPtr_m_ExtMethodsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "m_ExtMethodsVersion");
			DispatchingUserDataDescriptor.NativeFieldInfoPtr_m_MetaMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "m_MetaMembers");
			DispatchingUserDataDescriptor.NativeFieldInfoPtr_m_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "m_Members");
			DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_INDEXER_GET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "SPECIALNAME_INDEXER_GET");
			DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_INDEXER_SET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "SPECIALNAME_INDEXER_SET");
			DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_CAST_EXPLICIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "SPECIALNAME_CAST_EXPLICIT");
			DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_CAST_IMPLICIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "SPECIALNAME_CAST_IMPLICIT");
			DispatchingUserDataDescriptor.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "<Name>k__BackingField");
			DispatchingUserDataDescriptor.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "<Type>k__BackingField");
			DispatchingUserDataDescriptor.NativeFieldInfoPtr__FriendlyName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "<FriendlyName>k__BackingField");
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666219);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666220);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666221);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_set_Type_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666222);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666223);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_set_FriendlyName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666224);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_MemberNames_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666229);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_Members_Public_get_IEnumerable_1_KeyValuePair_2_String_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666230);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_MetaMemberNames_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666233);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_MetaMembers_Public_get_IEnumerable_1_KeyValuePair_2_String_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666234);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666225);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_AddMetaMember_Public_Void_String_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666226);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_AddDynValue_Public_Void_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666227);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_AddMember_Public_Void_String_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666228);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_FindMember_Public_IMemberDescriptor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666231);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_RemoveMember_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666232);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_FindMetaMember_Public_IMemberDescriptor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666235);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_RemoveMetaMember_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666236);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_AddMemberTo_Private_Void_Dictionary_2_String_IMemberDescriptor_String_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666237);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_New_DynValue_Script_Object_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666238);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryIndexOnExtMethod_Private_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666239);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_HasMember_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666240);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_HasMetaMember_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666241);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryIndex_Protected_Virtual_New_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666242);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666243);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_TrySetIndex_Protected_Virtual_New_Boolean_Script_Object_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666244);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666245);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_Camelify_Protected_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666246);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_UpperFirstLetter_Protected_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666247);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666248);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_ExecuteIndexer_Protected_Virtual_New_DynValue_IMemberDescriptor_Script_Object_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666249);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_New_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666250);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_PerformComparison_Private_Int32_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666251);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_MultiDispatchLessThanOrEqual_Private_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666252);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_MultiDispatchLessThan_Private_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666253);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryDispatchLength_Private_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666254);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_MultiDispatchEqual_Private_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666255);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_CheckEquality_Private_Boolean_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666256);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_DispatchMetaOnMethod_Private_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666257);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryDispatchToNumber_Private_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666258);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryDispatchToBool_Private_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666259);
			DispatchingUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, 100666260);
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x00058044 File Offset: 0x00056244
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x0005807C File Offset: 0x0005627C
		public unsafe virtual string Name
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x000580C0 File Offset: 0x000562C0
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x00058100 File Offset: 0x00056300
		public unsafe virtual Type Type
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_set_Type_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00058144 File Offset: 0x00056344
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x0005817C File Offset: 0x0005637C
		public unsafe string FriendlyName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_set_FriendlyName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x000581C0 File Offset: 0x000563C0
		public unsafe IEnumerable<string> MemberNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42251, XrefRangeEnd = 42255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_MemberNames_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00058200 File Offset: 0x00056400
		public unsafe IEnumerable<KeyValuePair<string, IMemberDescriptor>> Members
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_Members_Public_get_IEnumerable_1_KeyValuePair_2_String_IMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, IMemberDescriptor>>>(intPtr3) : null;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00058240 File Offset: 0x00056440
		public unsafe IEnumerable<string> MetaMemberNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42255, XrefRangeEnd = 42259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_MetaMemberNames_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x00058280 File Offset: 0x00056480
		public unsafe IEnumerable<KeyValuePair<string, IMemberDescriptor>> MetaMembers
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_get_MetaMembers_Public_get_IEnumerable_1_KeyValuePair_2_String_IMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, IMemberDescriptor>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x000582C0 File Offset: 0x000564C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42276, RefRangeEnd = 42279, XrefRangeStart = 42259, XrefRangeEnd = 42276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DispatchingUserDataDescriptor(Type type, string friendlyName = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00058320 File Offset: 0x00056520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42280, RefRangeEnd = 42282, XrefRangeStart = 42279, XrefRangeEnd = 42280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMetaMember(string name, IMemberDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_AddMetaMember_Public_Void_String_IMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00058374 File Offset: 0x00056574
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 42287, RefRangeEnd = 42291, XrefRangeStart = 42282, XrefRangeEnd = 42287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDynValue(string name, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_AddDynValue_Public_Void_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000583C8 File Offset: 0x000565C8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 42292, RefRangeEnd = 42302, XrefRangeStart = 42291, XrefRangeEnd = 42292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMember(string name, IMemberDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_AddMember_Public_Void_String_IMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0005841C File Offset: 0x0005661C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42302, XrefRangeEnd = 42305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMemberDescriptor FindMember(string memberName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_FindMember_Public_IMemberDescriptor_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMemberDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0005846C File Offset: 0x0005666C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42305, XrefRangeEnd = 42309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveMember(string memberName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_RemoveMember_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x000584B0 File Offset: 0x000566B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42309, XrefRangeEnd = 42312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMemberDescriptor FindMetaMember(string memberName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_FindMetaMember_Public_IMemberDescriptor_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMemberDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00058500 File Offset: 0x00056700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42312, XrefRangeEnd = 42316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveMetaMember(string memberName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_RemoveMetaMember_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00058544 File Offset: 0x00056744
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42327, RefRangeEnd = 42330, XrefRangeStart = 42316, XrefRangeEnd = 42327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMemberTo(Dictionary<string, IMemberDescriptor> members, string name, IMemberDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_AddMemberTo_Private_Void_Dictionary_2_String_IMemberDescriptor_String_IMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x000585AC File Offset: 0x000567AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42330, XrefRangeEnd = 42340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue Index(Script script, Object obj, DynValue index, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DispatchingUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_New_DynValue_Script_Object_DynValue_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0005863C File Offset: 0x0005683C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42340, XrefRangeEnd = 42361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue TryIndexOnExtMethod(Script script, Object obj, string indexName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(indexName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryIndexOnExtMethod_Private_DynValue_Script_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000586B0 File Offset: 0x000568B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42365, RefRangeEnd = 42367, XrefRangeStart = 42361, XrefRangeEnd = 42365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMember(string exactName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(exactName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_HasMember_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00058700 File Offset: 0x00056900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42367, XrefRangeEnd = 42371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMetaMember(string exactName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(exactName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_HasMetaMember_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00058750 File Offset: 0x00056950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42371, XrefRangeEnd = 42375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue TryIndex(Script script, Object obj, string indexName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(indexName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryIndex_Protected_Virtual_New_DynValue_Script_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000587D0 File Offset: 0x000569D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42375, XrefRangeEnd = 42406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SetIndex(Script script, Object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DispatchingUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00058870 File Offset: 0x00056A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42406, XrefRangeEnd = 42413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TrySetIndex(Script script, Object obj, string indexName, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(indexName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DispatchingUserDataDescriptor.NativeMethodInfoPtr_TrySetIndex_Protected_Virtual_New_Boolean_Script_Object_String_DynValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00058900 File Offset: 0x00056B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42413, XrefRangeEnd = 42461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00058934 File Offset: 0x00056B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42461, XrefRangeEnd = 42462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Camelify(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_Camelify_Protected_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00058970 File Offset: 0x00056B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42462, XrefRangeEnd = 42463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UpperFirstLetter(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_UpperFirstLetter_Protected_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000589AC File Offset: 0x00056BAC
		[CallerCount(0)]
		public unsafe virtual string AsString(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DispatchingUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00058A00 File Offset: 0x00056C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42463, XrefRangeEnd = 42516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue ExecuteIndexer(IMemberDescriptor mdesc, Script script, Object obj, DynValue index, DynValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mdesc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(script);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DispatchingUserDataDescriptor.NativeMethodInfoPtr_ExecuteIndexer_Protected_Virtual_New_DynValue_IMemberDescriptor_Script_Object_DynValue_DynValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00058AA8 File Offset: 0x00056CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42516, XrefRangeEnd = 42549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue MetaIndex(Script script, Object obj, string metaname)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DispatchingUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_New_DynValue_Script_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00058B28 File Offset: 0x00056D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42554, RefRangeEnd = 42556, XrefRangeStart = 42549, XrefRangeEnd = 42554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PerformComparison(Object obj, Object p1, Object p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_PerformComparison_Private_Int32_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00058B9C File Offset: 0x00056D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42556, XrefRangeEnd = 42568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue MultiDispatchLessThanOrEqual(Script script, Object obj)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_MultiDispatchLessThanOrEqual_Private_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00058C00 File Offset: 0x00056E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42568, XrefRangeEnd = 42580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue MultiDispatchLessThan(Script script, Object obj)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_MultiDispatchLessThan_Private_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00058C64 File Offset: 0x00056E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42580, XrefRangeEnd = 42603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue TryDispatchLength(Script script, Object obj)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryDispatchLength_Private_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00058CC8 File Offset: 0x00056EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42603, XrefRangeEnd = 42620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue MultiDispatchEqual(Script script, Object obj)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_MultiDispatchEqual_Private_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00058D2C File Offset: 0x00056F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42620, XrefRangeEnd = 42622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckEquality(Object obj, Object p1, Object p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_CheckEquality_Private_Boolean_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00058DA0 File Offset: 0x00056FA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 42629, RefRangeEnd = 42633, XrefRangeStart = 42622, XrefRangeEnd = 42629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue DispatchMetaOnMethod(Script script, Object obj, string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_DispatchMetaOnMethod_Private_DynValue_Script_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00058E14 File Offset: 0x00057014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42633, XrefRangeEnd = 42640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue TryDispatchToNumber(Script script, Object obj)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryDispatchToNumber_Private_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00058E78 File Offset: 0x00057078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42640, XrefRangeEnd = 42649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue TryDispatchToBool(Script script, Object obj)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.NativeMethodInfoPtr_TryDispatchToBool_Private_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00058EDC File Offset: 0x000570DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42657, RefRangeEnd = 42658, XrefRangeStart = 42649, XrefRangeEnd = 42657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsTypeCompatible(Type type, Object obj)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DispatchingUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_New_Boolean_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00006DE0 File Offset: 0x00004FE0
		public DispatchingUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00058F48 File Offset: 0x00057148
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00006DE9 File Offset: 0x00004FE9
		public unsafe int m_ExtMethodsVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr_m_ExtMethodsVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr_m_ExtMethodsVersion)) = value;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00058F70 File Offset: 0x00057170
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00006E04 File Offset: 0x00005004
		public unsafe Dictionary<string, IMemberDescriptor> m_MetaMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr_m_MetaMembers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IMemberDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr_m_MetaMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x00058FA0 File Offset: 0x000571A0
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x00006E23 File Offset: 0x00005023
		public unsafe Dictionary<string, IMemberDescriptor> m_Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr_m_Members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IMemberDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr_m_Members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x00058FD0 File Offset: 0x000571D0
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x00006E42 File Offset: 0x00005042
		public unsafe static string SPECIALNAME_INDEXER_GET
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_INDEXER_GET, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_INDEXER_GET, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x00058FF0 File Offset: 0x000571F0
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00006E54 File Offset: 0x00005054
		public unsafe static string SPECIALNAME_INDEXER_SET
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_INDEXER_SET, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_INDEXER_SET, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x00059010 File Offset: 0x00057210
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x00006E66 File Offset: 0x00005066
		public unsafe static string SPECIALNAME_CAST_EXPLICIT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_CAST_EXPLICIT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_CAST_EXPLICIT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00059030 File Offset: 0x00057230
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x00006E78 File Offset: 0x00005078
		public unsafe static string SPECIALNAME_CAST_IMPLICIT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_CAST_IMPLICIT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DispatchingUserDataDescriptor.NativeFieldInfoPtr_SPECIALNAME_CAST_IMPLICIT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00059050 File Offset: 0x00057250
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x00006E8A File Offset: 0x0000508A
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00059078 File Offset: 0x00057278
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x00006EA9 File Offset: 0x000050A9
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x000590A8 File Offset: 0x000572A8
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x00006EC8 File Offset: 0x000050C8
		public unsafe string _FriendlyName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr__FriendlyName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.NativeFieldInfoPtr__FriendlyName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtMethodsVersion;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeFieldInfoPtr_m_MetaMembers;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeFieldInfoPtr_m_Members;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeFieldInfoPtr_SPECIALNAME_INDEXER_GET;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeFieldInfoPtr_SPECIALNAME_INDEXER_SET;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeFieldInfoPtr_SPECIALNAME_CAST_EXPLICIT;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeFieldInfoPtr_SPECIALNAME_CAST_IMPLICIT;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeFieldInfoPtr__FriendlyName_k__BackingField;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_Type_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_get_FriendlyName_Public_get_String_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_set_FriendlyName_Private_set_Void_String_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberNames_Public_get_IEnumerable_1_String_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_get_Members_Public_get_IEnumerable_1_KeyValuePair_2_String_IMemberDescriptor_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_get_MetaMemberNames_Public_get_IEnumerable_1_String_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_get_MetaMembers_Public_get_IEnumerable_1_KeyValuePair_2_String_IMemberDescriptor_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_String_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_AddMetaMember_Public_Void_String_IMemberDescriptor_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_AddDynValue_Public_Void_String_DynValue_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_AddMember_Public_Void_String_IMemberDescriptor_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_FindMember_Public_IMemberDescriptor_String_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMember_Public_Void_String_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_FindMetaMember_Public_IMemberDescriptor_String_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMetaMember_Public_Void_String_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_AddMemberTo_Private_Void_Dictionary_2_String_IMemberDescriptor_String_IMemberDescriptor_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_Index_Public_Virtual_New_DynValue_Script_Object_DynValue_Boolean_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_TryIndexOnExtMethod_Private_DynValue_Script_Object_String_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_HasMember_Public_Boolean_String_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_HasMetaMember_Public_Boolean_String_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_TryIndex_Protected_Virtual_New_DynValue_Script_Object_String_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Virtual_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_TrySetIndex_Protected_Virtual_New_Boolean_Script_Object_String_DynValue_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_Camelify_Protected_Static_String_String_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_UpperFirstLetter_Protected_Static_String_String_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_AsString_Public_Virtual_New_String_Object_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteIndexer_Protected_Virtual_New_DynValue_IMemberDescriptor_Script_Object_DynValue_DynValue_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Virtual_New_DynValue_Script_Object_String_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_PerformComparison_Private_Int32_Object_Object_Object_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_MultiDispatchLessThanOrEqual_Private_DynValue_Script_Object_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_MultiDispatchLessThan_Private_DynValue_Script_Object_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_TryDispatchLength_Private_DynValue_Script_Object_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_MultiDispatchEqual_Private_DynValue_Script_Object_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_CheckEquality_Private_Boolean_Object_Object_Object_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_DispatchMetaOnMethod_Private_DynValue_Script_Object_String_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_TryDispatchToNumber_Private_DynValue_Script_Object_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_TryDispatchToBool_Private_DynValue_Script_Object_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_New_Boolean_Type_Object_0;

		// Token: 0x020001DA RID: 474
		[ObfuscatedName("MoonSharp.Interpreter.Interop.BasicDescriptors.DispatchingUserDataDescriptor+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Object
		{
			// Token: 0x06001CB8 RID: 7352 RVA: 0x0008A7DC File Offset: 0x000889DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass50_0>.NativeClassPtr);
				DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass50_0>.NativeClassPtr, "obj");
				DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass50_0>.NativeClassPtr, 100666261);
				DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeMethodInfoPtr__MultiDispatchLessThanOrEqual_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass50_0>.NativeClassPtr, 100666262);
			}

			// Token: 0x06001CB9 RID: 7353 RVA: 0x0008A858 File Offset: 0x00088A58
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CBA RID: 7354 RVA: 0x0008A894 File Offset: 0x00088A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42194, XrefRangeEnd = 42204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _MultiDispatchLessThanOrEqual_b__0(ScriptExecutionContext context, CallbackArguments args)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeMethodInfoPtr__MultiDispatchLessThanOrEqual_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001CBB RID: 7355 RVA: 0x0000B4F7 File Offset: 0x000096F7
			public __c__DisplayClass50_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0008A8F8 File Offset: 0x00088AF8
			// (set) Token: 0x06001CBD RID: 7357 RVA: 0x0000B500 File Offset: 0x00009700
			public unsafe DispatchingUserDataDescriptor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DispatchingUserDataDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0008A928 File Offset: 0x00088B28
			// (set) Token: 0x06001CBF RID: 7359 RVA: 0x0000B51F File Offset: 0x0000971F
			public unsafe Object obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass50_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001701 RID: 5889
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001702 RID: 5890
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x04001703 RID: 5891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001704 RID: 5892
			private static readonly IntPtr NativeMethodInfoPtr__MultiDispatchLessThanOrEqual_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;
		}

		// Token: 0x020001DB RID: 475
		[ObfuscatedName("MoonSharp.Interpreter.Interop.BasicDescriptors.DispatchingUserDataDescriptor+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Object
		{
			// Token: 0x06001CC0 RID: 7360 RVA: 0x0008A958 File Offset: 0x00088B58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass51_0>.NativeClassPtr);
				DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass51_0>.NativeClassPtr, "<>4__this");
				DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass51_0>.NativeClassPtr, "obj");
				DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass51_0>.NativeClassPtr, 100666263);
				DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeMethodInfoPtr__MultiDispatchLessThan_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass51_0>.NativeClassPtr, 100666264);
			}

			// Token: 0x06001CC1 RID: 7361 RVA: 0x0008A9D4 File Offset: 0x00088BD4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CC2 RID: 7362 RVA: 0x0008AA10 File Offset: 0x00088C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42204, XrefRangeEnd = 42214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _MultiDispatchLessThan_b__0(ScriptExecutionContext context, CallbackArguments args)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeMethodInfoPtr__MultiDispatchLessThan_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001CC3 RID: 7363 RVA: 0x0000B53E File Offset: 0x0000973E
			public __c__DisplayClass51_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0008AA74 File Offset: 0x00088C74
			// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x0000B547 File Offset: 0x00009747
			public unsafe DispatchingUserDataDescriptor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DispatchingUserDataDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0008AAA4 File Offset: 0x00088CA4
			// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0000B566 File Offset: 0x00009766
			public unsafe Object obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass51_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001705 RID: 5893
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001706 RID: 5894
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x04001707 RID: 5895
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001708 RID: 5896
			private static readonly IntPtr NativeMethodInfoPtr__MultiDispatchLessThan_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;
		}

		// Token: 0x020001DC RID: 476
		[ObfuscatedName("MoonSharp.Interpreter.Interop.BasicDescriptors.DispatchingUserDataDescriptor+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Object
		{
			// Token: 0x06001CC8 RID: 7368 RVA: 0x0008AAD4 File Offset: 0x00088CD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DispatchingUserDataDescriptor>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass53_0>.NativeClassPtr);
				DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass53_0>.NativeClassPtr, "<>4__this");
				DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass53_0>.NativeClassPtr, "obj");
				DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass53_0>.NativeClassPtr, 100666265);
				DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeMethodInfoPtr__MultiDispatchEqual_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass53_0>.NativeClassPtr, 100666266);
			}

			// Token: 0x06001CC9 RID: 7369 RVA: 0x0008AB50 File Offset: 0x00088D50
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DispatchingUserDataDescriptor.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CCA RID: 7370 RVA: 0x0008AB8C File Offset: 0x00088D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42214, XrefRangeEnd = 42251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _MultiDispatchEqual_b__0(ScriptExecutionContext context, CallbackArguments args)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeMethodInfoPtr__MultiDispatchEqual_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001CCB RID: 7371 RVA: 0x0000B585 File Offset: 0x00009785
			public __c__DisplayClass53_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0008ABF0 File Offset: 0x00088DF0
			// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0000B58E File Offset: 0x0000978E
			public unsafe DispatchingUserDataDescriptor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DispatchingUserDataDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0008AC20 File Offset: 0x00088E20
			// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0000B5AD File Offset: 0x000097AD
			public unsafe Object obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DispatchingUserDataDescriptor.__c__DisplayClass53_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001709 RID: 5897
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400170A RID: 5898
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x0400170B RID: 5899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400170C RID: 5900
			private static readonly IntPtr NativeMethodInfoPtr__MultiDispatchEqual_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;
		}
	}
}
