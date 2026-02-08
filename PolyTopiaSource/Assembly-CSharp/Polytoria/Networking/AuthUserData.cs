using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Polytoria.Networking
{
	// Token: 0x02000260 RID: 608
	public sealed class AuthUserData : ValueType
	{
		// Token: 0x06002F1B RID: 12059 RVA: 0x000D9318 File Offset: 0x000D7518
		// Note: this type is marked as 'beforefieldinit'.
		static AuthUserData()
		{
			Il2CppClassPointerStore<AuthUserData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Networking", "AuthUserData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr);
			AuthUserData.NativeFieldInfoPtr__ID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, "<ID>k__BackingField");
			AuthUserData.NativeFieldInfoPtr__Username_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, "<Username>k__BackingField");
			AuthUserData.NativeFieldInfoPtr__Token_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, "<Token>k__BackingField");
			AuthUserData.NativeFieldInfoPtr__CanChat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, "<CanChat>k__BackingField");
			AuthUserData.NativeFieldInfoPtr__IsAgeRestricted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, "<IsAgeRestricted>k__BackingField");
			AuthUserData.NativeMethodInfoPtr_get_ID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670369);
			AuthUserData.NativeMethodInfoPtr_set_ID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670370);
			AuthUserData.NativeMethodInfoPtr_get_Username_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670371);
			AuthUserData.NativeMethodInfoPtr_set_Username_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670372);
			AuthUserData.NativeMethodInfoPtr_get_Token_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670373);
			AuthUserData.NativeMethodInfoPtr_set_Token_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670374);
			AuthUserData.NativeMethodInfoPtr_get_CanChat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670375);
			AuthUserData.NativeMethodInfoPtr_set_CanChat_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670376);
			AuthUserData.NativeMethodInfoPtr_get_IsAgeRestricted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670377);
			AuthUserData.NativeMethodInfoPtr_set_IsAgeRestricted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670378);
			AuthUserData.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr, 100670379);
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06002F1C RID: 12060 RVA: 0x000D9488 File Offset: 0x000D7688
		// (set) Token: 0x06002F1D RID: 12061 RVA: 0x000D94CC File Offset: 0x000D76CC
		public unsafe int ID
		{
			[CallerCount(63)]
			[CachedScanResults(RefRangeStart = 33677, RefRangeEnd = 33740, XrefRangeStart = 33677, XrefRangeEnd = 33740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_get_ID_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 33740, RefRangeEnd = 33751, XrefRangeStart = 33740, XrefRangeEnd = 33751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_set_ID_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06002F1E RID: 12062 RVA: 0x000D9510 File Offset: 0x000D7710
		// (set) Token: 0x06002F1F RID: 12063 RVA: 0x000D954C File Offset: 0x000D774C
		public unsafe string Username
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_get_Username_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_set_Username_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x000D9594 File Offset: 0x000D7794
		// (set) Token: 0x06002F21 RID: 12065 RVA: 0x000D95D0 File Offset: 0x000D77D0
		public unsafe string Token
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_get_Token_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_set_Token_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x000D9618 File Offset: 0x000D7818
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x000D965C File Offset: 0x000D785C
		public unsafe bool CanChat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_get_CanChat_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_set_CanChat_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000D96A0 File Offset: 0x000D78A0
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x000D96E4 File Offset: 0x000D78E4
		public unsafe bool IsAgeRestricted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_get_IsAgeRestricted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr_set_IsAgeRestricted_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x000D9728 File Offset: 0x000D7928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99973, XrefRangeEnd = 99975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthUserData(int id, string username, string token, bool canChat, bool isAgeRestricted)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(token);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canChat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAgeRestricted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthUserData.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00012E1F File Offset: 0x0001101F
		public AuthUserData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00012E28 File Offset: 0x00011028
		public AuthUserData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthUserData>.NativeClassPtr))
		{
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x000D97B4 File Offset: 0x000D79B4
		// (set) Token: 0x06002F2A RID: 12074 RVA: 0x00012E3A File Offset: 0x0001103A
		public unsafe int _ID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__ID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__ID_k__BackingField)) = value;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x000D97DC File Offset: 0x000D79DC
		// (set) Token: 0x06002F2C RID: 12076 RVA: 0x00012E55 File Offset: 0x00011055
		public unsafe string _Username_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__Username_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__Username_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000D9804 File Offset: 0x000D7A04
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x00012E74 File Offset: 0x00011074
		public unsafe string _Token_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__Token_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__Token_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x000D982C File Offset: 0x000D7A2C
		// (set) Token: 0x06002F30 RID: 12080 RVA: 0x00012E93 File Offset: 0x00011093
		public unsafe bool _CanChat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__CanChat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__CanChat_k__BackingField)) = value;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000D9854 File Offset: 0x000D7A54
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x00012EAE File Offset: 0x000110AE
		public unsafe bool _IsAgeRestricted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__IsAgeRestricted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthUserData.NativeFieldInfoPtr__IsAgeRestricted_k__BackingField)) = value;
			}
		}

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeFieldInfoPtr__ID_k__BackingField;

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeFieldInfoPtr__Username_k__BackingField;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeFieldInfoPtr__Token_k__BackingField;

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeFieldInfoPtr__CanChat_k__BackingField;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeFieldInfoPtr__IsAgeRestricted_k__BackingField;

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_get_Int32_0;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeMethodInfoPtr_set_ID_Public_set_Void_Int32_0;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_get_Username_Public_get_String_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_set_Username_Public_set_Void_String_0;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Public_get_String_0;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Public_set_Void_String_0;

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeMethodInfoPtr_get_CanChat_Public_get_Boolean_0;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeMethodInfoPtr_set_CanChat_Public_set_Void_Boolean_0;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAgeRestricted_Public_get_Boolean_0;

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAgeRestricted_Public_set_Void_Boolean_0;

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Boolean_Boolean_0;
	}
}
