using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000155 RID: 341
	public sealed class LobbyTransaction : ValueType
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00073188 File Offset: 0x00071388
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyTransaction()
		{
			Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "LobbyTransaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr);
			LobbyTransaction.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, "MethodsPtr");
			LobbyTransaction.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, "MethodsStructure");
			LobbyTransaction.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, 100667317);
			LobbyTransaction.NativeMethodInfoPtr_SetType_Public_Void_LobbyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, 100667318);
			LobbyTransaction.NativeMethodInfoPtr_SetOwner_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, 100667319);
			LobbyTransaction.NativeMethodInfoPtr_SetCapacity_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, 100667320);
			LobbyTransaction.NativeMethodInfoPtr_SetMetadata_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, 100667321);
			LobbyTransaction.NativeMethodInfoPtr_DeleteMetadata_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, 100667322);
			LobbyTransaction.NativeMethodInfoPtr_SetLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, 100667323);
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x0007326C File Offset: 0x0007146C
		public unsafe LobbyTransaction.FFIMethods Methods
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 52192, RefRangeEnd = 52198, XrefRangeStart = 52179, XrefRangeEnd = 52192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LobbyTransaction.FFIMethods(intPtr);
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x000732A8 File Offset: 0x000714A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52198, XrefRangeEnd = 52199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType(LobbyType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.NativeMethodInfoPtr_SetType_Public_Void_LobbyType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000732F0 File Offset: 0x000714F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52199, XrefRangeEnd = 52200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOwner(long ownerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ownerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.NativeMethodInfoPtr_SetOwner_Public_Void_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00073334 File Offset: 0x00071534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52200, XrefRangeEnd = 52201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapacity(uint capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.NativeMethodInfoPtr_SetCapacity_Public_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00073378 File Offset: 0x00071578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52201, XrefRangeEnd = 52202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMetadata(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.NativeMethodInfoPtr_SetMetadata_Public_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000733D4 File Offset: 0x000715D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52202, XrefRangeEnd = 52203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteMetadata(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.NativeMethodInfoPtr_DeleteMetadata_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0007341C File Offset: 0x0007161C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52203, XrefRangeEnd = 52204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locked;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.NativeMethodInfoPtr_SetLocked_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00008EB2 File Offset: 0x000070B2
		public LobbyTransaction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00008EBB File Offset: 0x000070BB
		public LobbyTransaction()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr))
		{
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x00073460 File Offset: 0x00071660
		// (set) Token: 0x060016A2 RID: 5794 RVA: 0x00008ECD File Offset: 0x000070CD
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00073488 File Offset: 0x00071688
		// (set) Token: 0x060016A4 RID: 5796 RVA: 0x00008EE8 File Offset: 0x000070E8
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Public_Void_LobbyType_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_SetOwner_Public_Void_Int64_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Void_UInt32_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_SetMetadata_Public_Void_String_String_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_DeleteMetadata_Public_Void_String_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_SetLocked_Public_Void_Boolean_0;

		// Token: 0x020001FD RID: 509
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001E45 RID: 7749 RVA: 0x0008F23C File Offset: 0x0008D43C
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyTransaction>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr);
				LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetType");
				LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetOwner");
				LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetCapacity");
				LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetMetadata");
				LobbyTransaction.FFIMethods.NativeFieldInfoPtr_DeleteMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "DeleteMetadata");
				LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetLocked");
			}

			// Token: 0x06001E46 RID: 7750 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E47 RID: 7751 RVA: 0x0000C0B1 File Offset: 0x0000A2B1
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0008F2E0 File Offset: 0x0008D4E0
			// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0000C0C3 File Offset: 0x0000A2C3
			public unsafe LobbyTransaction.FFIMethods.SetTypeMethod SetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyTransaction.FFIMethods.SetTypeMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0008F310 File Offset: 0x0008D510
			// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0000C0E2 File Offset: 0x0000A2E2
			public unsafe LobbyTransaction.FFIMethods.SetOwnerMethod SetOwner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetOwner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyTransaction.FFIMethods.SetOwnerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetOwner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06001E4C RID: 7756 RVA: 0x0008F340 File Offset: 0x0008D540
			// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0000C101 File Offset: 0x0000A301
			public unsafe LobbyTransaction.FFIMethods.SetCapacityMethod SetCapacity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetCapacity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyTransaction.FFIMethods.SetCapacityMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetCapacity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x06001E4E RID: 7758 RVA: 0x0008F370 File Offset: 0x0008D570
			// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0000C120 File Offset: 0x0000A320
			public unsafe LobbyTransaction.FFIMethods.SetMetadataMethod SetMetadata
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetMetadata);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyTransaction.FFIMethods.SetMetadataMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x06001E50 RID: 7760 RVA: 0x0008F3A0 File Offset: 0x0008D5A0
			// (set) Token: 0x06001E51 RID: 7761 RVA: 0x0000C13F File Offset: 0x0000A33F
			public unsafe LobbyTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_DeleteMetadata);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyTransaction.FFIMethods.DeleteMetadataMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_DeleteMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x06001E52 RID: 7762 RVA: 0x0008F3D0 File Offset: 0x0008D5D0
			// (set) Token: 0x06001E53 RID: 7763 RVA: 0x0000C15E File Offset: 0x0000A35E
			public unsafe LobbyTransaction.FFIMethods.SetLockedMethod SetLocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetLocked);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyTransaction.FFIMethods.SetLockedMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyTransaction.FFIMethods.NativeFieldInfoPtr_SetLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E1 RID: 6113
			private static readonly IntPtr NativeFieldInfoPtr_SetType;

			// Token: 0x040017E2 RID: 6114
			private static readonly IntPtr NativeFieldInfoPtr_SetOwner;

			// Token: 0x040017E3 RID: 6115
			private static readonly IntPtr NativeFieldInfoPtr_SetCapacity;

			// Token: 0x040017E4 RID: 6116
			private static readonly IntPtr NativeFieldInfoPtr_SetMetadata;

			// Token: 0x040017E5 RID: 6117
			private static readonly IntPtr NativeFieldInfoPtr_DeleteMetadata;

			// Token: 0x040017E6 RID: 6118
			private static readonly IntPtr NativeFieldInfoPtr_SetLocked;

			// Token: 0x02000261 RID: 609
			public sealed class SetTypeMethod : MulticastDelegate
			{
				// Token: 0x06002209 RID: 8713 RVA: 0x0009A5A8 File Offset: 0x000987A8
				// Note: this type is marked as 'beforefieldinit'.
				static SetTypeMethod()
				{
					Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetTypeMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetTypeMethod");
					LobbyTransaction.FFIMethods.SetTypeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetTypeMethod>.NativeClassPtr, 100667324);
					LobbyTransaction.FFIMethods.SetTypeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_LobbyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetTypeMethod>.NativeClassPtr, 100667325);
					LobbyTransaction.FFIMethods.SetTypeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LobbyType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetTypeMethod>.NativeClassPtr, 100667326);
					LobbyTransaction.FFIMethods.SetTypeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetTypeMethod>.NativeClassPtr, 100667327);
				}

				// Token: 0x0600220A RID: 8714 RVA: 0x0009A61C File Offset: 0x0009881C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetTypeMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetTypeMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetTypeMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600220B RID: 8715 RVA: 0x0009A678 File Offset: 0x00098878
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, LobbyType type)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetTypeMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_LobbyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600220C RID: 8716 RVA: 0x0009A6D8 File Offset: 0x000988D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52154, XrefRangeEnd = 52160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, LobbyType type, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetTypeMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LobbyType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600220D RID: 8717 RVA: 0x0009A75C File Offset: 0x0009895C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetTypeMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600220E RID: 8718 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
				public SetTypeMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600220F RID: 8719 RVA: 0x0000E2CD File Offset: 0x0000C4CD
				public static implicit operator LobbyTransaction.FFIMethods.SetTypeMethod(Func<IntPtr, LobbyType, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyTransaction.FFIMethods.SetTypeMethod>(A_0);
				}

				// Token: 0x06002210 RID: 8720 RVA: 0x0000E2D5 File Offset: 0x0000C4D5
				public static LobbyTransaction.FFIMethods.SetTypeMethod operator +(LobbyTransaction.FFIMethods.SetTypeMethod A_0, LobbyTransaction.FFIMethods.SetTypeMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyTransaction.FFIMethods.SetTypeMethod>();
				}

				// Token: 0x06002211 RID: 8721 RVA: 0x0000E2E3 File Offset: 0x0000C4E3
				public static LobbyTransaction.FFIMethods.SetTypeMethod operator -(LobbyTransaction.FFIMethods.SetTypeMethod A_0, LobbyTransaction.FFIMethods.SetTypeMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyTransaction.FFIMethods.SetTypeMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019C9 RID: 6601
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019CA RID: 6602
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_LobbyType_0;

				// Token: 0x040019CB RID: 6603
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LobbyType_AsyncCallback_Object_0;

				// Token: 0x040019CC RID: 6604
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000262 RID: 610
			public sealed class SetOwnerMethod : MulticastDelegate
			{
				// Token: 0x06002212 RID: 8722 RVA: 0x0009A7AC File Offset: 0x000989AC
				// Note: this type is marked as 'beforefieldinit'.
				static SetOwnerMethod()
				{
					Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetOwnerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetOwnerMethod");
					LobbyTransaction.FFIMethods.SetOwnerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetOwnerMethod>.NativeClassPtr, 100667328);
					LobbyTransaction.FFIMethods.SetOwnerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetOwnerMethod>.NativeClassPtr, 100667329);
					LobbyTransaction.FFIMethods.SetOwnerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetOwnerMethod>.NativeClassPtr, 100667330);
					LobbyTransaction.FFIMethods.SetOwnerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetOwnerMethod>.NativeClassPtr, 100667331);
				}

				// Token: 0x06002213 RID: 8723 RVA: 0x0009A820 File Offset: 0x00098A20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetOwnerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetOwnerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetOwnerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002214 RID: 8724 RVA: 0x0009A87C File Offset: 0x00098A7C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long ownerId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownerId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetOwnerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002215 RID: 8725 RVA: 0x0009A8D8 File Offset: 0x00098AD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52160, XrefRangeEnd = 52165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long ownerId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownerId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetOwnerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002216 RID: 8726 RVA: 0x0009A958 File Offset: 0x00098B58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetOwnerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002217 RID: 8727 RVA: 0x0000E2F4 File Offset: 0x0000C4F4
				public SetOwnerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002218 RID: 8728 RVA: 0x0000E2FD File Offset: 0x0000C4FD
				public static implicit operator LobbyTransaction.FFIMethods.SetOwnerMethod(Func<IntPtr, long, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyTransaction.FFIMethods.SetOwnerMethod>(A_0);
				}

				// Token: 0x06002219 RID: 8729 RVA: 0x0000E305 File Offset: 0x0000C505
				public static LobbyTransaction.FFIMethods.SetOwnerMethod operator +(LobbyTransaction.FFIMethods.SetOwnerMethod A_0, LobbyTransaction.FFIMethods.SetOwnerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyTransaction.FFIMethods.SetOwnerMethod>();
				}

				// Token: 0x0600221A RID: 8730 RVA: 0x0000E313 File Offset: 0x0000C513
				public static LobbyTransaction.FFIMethods.SetOwnerMethod operator -(LobbyTransaction.FFIMethods.SetOwnerMethod A_0, LobbyTransaction.FFIMethods.SetOwnerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyTransaction.FFIMethods.SetOwnerMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019CD RID: 6605
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019CE RID: 6606
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_0;

				// Token: 0x040019CF RID: 6607
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0;

				// Token: 0x040019D0 RID: 6608
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000263 RID: 611
			public sealed class SetCapacityMethod : MulticastDelegate
			{
				// Token: 0x0600221B RID: 8731 RVA: 0x0009A9A8 File Offset: 0x00098BA8
				// Note: this type is marked as 'beforefieldinit'.
				static SetCapacityMethod()
				{
					Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetCapacityMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetCapacityMethod");
					LobbyTransaction.FFIMethods.SetCapacityMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetCapacityMethod>.NativeClassPtr, 100667332);
					LobbyTransaction.FFIMethods.SetCapacityMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetCapacityMethod>.NativeClassPtr, 100667333);
					LobbyTransaction.FFIMethods.SetCapacityMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetCapacityMethod>.NativeClassPtr, 100667334);
					LobbyTransaction.FFIMethods.SetCapacityMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetCapacityMethod>.NativeClassPtr, 100667335);
				}

				// Token: 0x0600221C RID: 8732 RVA: 0x0009AA1C File Offset: 0x00098C1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetCapacityMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetCapacityMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetCapacityMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600221D RID: 8733 RVA: 0x0009AA78 File Offset: 0x00098C78
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, uint capacity)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetCapacityMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600221E RID: 8734 RVA: 0x0009AAD4 File Offset: 0x00098CD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, uint capacity, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetCapacityMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600221F RID: 8735 RVA: 0x0009AB54 File Offset: 0x00098D54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetCapacityMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002220 RID: 8736 RVA: 0x0000E324 File Offset: 0x0000C524
				public SetCapacityMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002221 RID: 8737 RVA: 0x0000E32D File Offset: 0x0000C52D
				public static implicit operator LobbyTransaction.FFIMethods.SetCapacityMethod(Func<IntPtr, uint, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyTransaction.FFIMethods.SetCapacityMethod>(A_0);
				}

				// Token: 0x06002222 RID: 8738 RVA: 0x0000E335 File Offset: 0x0000C535
				public static LobbyTransaction.FFIMethods.SetCapacityMethod operator +(LobbyTransaction.FFIMethods.SetCapacityMethod A_0, LobbyTransaction.FFIMethods.SetCapacityMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyTransaction.FFIMethods.SetCapacityMethod>();
				}

				// Token: 0x06002223 RID: 8739 RVA: 0x0000E343 File Offset: 0x0000C543
				public static LobbyTransaction.FFIMethods.SetCapacityMethod operator -(LobbyTransaction.FFIMethods.SetCapacityMethod A_0, LobbyTransaction.FFIMethods.SetCapacityMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyTransaction.FFIMethods.SetCapacityMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019D1 RID: 6609
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019D2 RID: 6610
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_0;

				// Token: 0x040019D3 RID: 6611
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_AsyncCallback_Object_0;

				// Token: 0x040019D4 RID: 6612
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000264 RID: 612
			public sealed class SetMetadataMethod : MulticastDelegate
			{
				// Token: 0x06002224 RID: 8740 RVA: 0x0009ABA4 File Offset: 0x00098DA4
				// Note: this type is marked as 'beforefieldinit'.
				static SetMetadataMethod()
				{
					Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetMetadataMethod");
					LobbyTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr, 100667336);
					LobbyTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr, 100667337);
					LobbyTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr, 100667338);
					LobbyTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr, 100667339);
				}

				// Token: 0x06002225 RID: 8741 RVA: 0x0009AC18 File Offset: 0x00098E18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52165, XrefRangeEnd = 52168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetMetadataMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002226 RID: 8742 RVA: 0x0009AC74 File Offset: 0x00098E74
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string key, string value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002227 RID: 8743 RVA: 0x0009ACE4 File Offset: 0x00098EE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52168, XrefRangeEnd = 52171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, string value, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002228 RID: 8744 RVA: 0x0009AD7C File Offset: 0x00098F7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002229 RID: 8745 RVA: 0x0000E354 File Offset: 0x0000C554
				public SetMetadataMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600222A RID: 8746 RVA: 0x0000E35D File Offset: 0x0000C55D
				public static implicit operator LobbyTransaction.FFIMethods.SetMetadataMethod(Func<IntPtr, string, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyTransaction.FFIMethods.SetMetadataMethod>(A_0);
				}

				// Token: 0x0600222B RID: 8747 RVA: 0x0000E365 File Offset: 0x0000C565
				public static LobbyTransaction.FFIMethods.SetMetadataMethod operator +(LobbyTransaction.FFIMethods.SetMetadataMethod A_0, LobbyTransaction.FFIMethods.SetMetadataMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyTransaction.FFIMethods.SetMetadataMethod>();
				}

				// Token: 0x0600222C RID: 8748 RVA: 0x0000E373 File Offset: 0x0000C573
				public static LobbyTransaction.FFIMethods.SetMetadataMethod operator -(LobbyTransaction.FFIMethods.SetMetadataMethod A_0, LobbyTransaction.FFIMethods.SetMetadataMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyTransaction.FFIMethods.SetMetadataMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019D5 RID: 6613
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019D6 RID: 6614
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_String_0;

				// Token: 0x040019D7 RID: 6615
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_String_AsyncCallback_Object_0;

				// Token: 0x040019D8 RID: 6616
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000265 RID: 613
			public sealed class DeleteMetadataMethod : MulticastDelegate
			{
				// Token: 0x0600222D RID: 8749 RVA: 0x0009ADCC File Offset: 0x00098FCC
				// Note: this type is marked as 'beforefieldinit'.
				static DeleteMetadataMethod()
				{
					Il2CppClassPointerStore<LobbyTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "DeleteMetadataMethod");
					LobbyTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr, 100667340);
					LobbyTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr, 100667341);
					LobbyTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr, 100667342);
					LobbyTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr, 100667343);
				}

				// Token: 0x0600222E RID: 8750 RVA: 0x0009AE40 File Offset: 0x00099040
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DeleteMetadataMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600222F RID: 8751 RVA: 0x0009AE9C File Offset: 0x0009909C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string key)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002230 RID: 8752 RVA: 0x0009AEFC File Offset: 0x000990FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002231 RID: 8753 RVA: 0x0009AF80 File Offset: 0x00099180
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002232 RID: 8754 RVA: 0x0000E384 File Offset: 0x0000C584
				public DeleteMetadataMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002233 RID: 8755 RVA: 0x0000E38D File Offset: 0x0000C58D
				public static implicit operator LobbyTransaction.FFIMethods.DeleteMetadataMethod(Func<IntPtr, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyTransaction.FFIMethods.DeleteMetadataMethod>(A_0);
				}

				// Token: 0x06002234 RID: 8756 RVA: 0x0000E395 File Offset: 0x0000C595
				public static LobbyTransaction.FFIMethods.DeleteMetadataMethod operator +(LobbyTransaction.FFIMethods.DeleteMetadataMethod A_0, LobbyTransaction.FFIMethods.DeleteMetadataMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyTransaction.FFIMethods.DeleteMetadataMethod>();
				}

				// Token: 0x06002235 RID: 8757 RVA: 0x0000E3A3 File Offset: 0x0000C5A3
				public static LobbyTransaction.FFIMethods.DeleteMetadataMethod operator -(LobbyTransaction.FFIMethods.DeleteMetadataMethod A_0, LobbyTransaction.FFIMethods.DeleteMetadataMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyTransaction.FFIMethods.DeleteMetadataMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019D9 RID: 6617
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019DA RID: 6618
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0;

				// Token: 0x040019DB RID: 6619
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0;

				// Token: 0x040019DC RID: 6620
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000266 RID: 614
			public sealed class SetLockedMethod : MulticastDelegate
			{
				// Token: 0x06002236 RID: 8758 RVA: 0x0009AFD0 File Offset: 0x000991D0
				// Note: this type is marked as 'beforefieldinit'.
				static SetLockedMethod()
				{
					Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetLockedMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyTransaction.FFIMethods>.NativeClassPtr, "SetLockedMethod");
					LobbyTransaction.FFIMethods.SetLockedMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetLockedMethod>.NativeClassPtr, 100667344);
					LobbyTransaction.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetLockedMethod>.NativeClassPtr, 100667345);
					LobbyTransaction.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetLockedMethod>.NativeClassPtr, 100667346);
					LobbyTransaction.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetLockedMethod>.NativeClassPtr, 100667347);
				}

				// Token: 0x06002237 RID: 8759 RVA: 0x0009B044 File Offset: 0x00099244
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52171, XrefRangeEnd = 52174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetLockedMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyTransaction.FFIMethods.SetLockedMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetLockedMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002238 RID: 8760 RVA: 0x0009B0A0 File Offset: 0x000992A0
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, bool locked)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002239 RID: 8761 RVA: 0x0009B0FC File Offset: 0x000992FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52174, XrefRangeEnd = 52179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, bool locked, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600223A RID: 8762 RVA: 0x0009B17C File Offset: 0x0009937C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyTransaction.FFIMethods.SetLockedMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600223B RID: 8763 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
				public SetLockedMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600223C RID: 8764 RVA: 0x0000E3BD File Offset: 0x0000C5BD
				public static implicit operator LobbyTransaction.FFIMethods.SetLockedMethod(Func<IntPtr, bool, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyTransaction.FFIMethods.SetLockedMethod>(A_0);
				}

				// Token: 0x0600223D RID: 8765 RVA: 0x0000E3C5 File Offset: 0x0000C5C5
				public static LobbyTransaction.FFIMethods.SetLockedMethod operator +(LobbyTransaction.FFIMethods.SetLockedMethod A_0, LobbyTransaction.FFIMethods.SetLockedMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyTransaction.FFIMethods.SetLockedMethod>();
				}

				// Token: 0x0600223E RID: 8766 RVA: 0x0000E3D3 File Offset: 0x0000C5D3
				public static LobbyTransaction.FFIMethods.SetLockedMethod operator -(LobbyTransaction.FFIMethods.SetLockedMethod A_0, LobbyTransaction.FFIMethods.SetLockedMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyTransaction.FFIMethods.SetLockedMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019DD RID: 6621
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019DE RID: 6622
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Boolean_0;

				// Token: 0x040019DF RID: 6623
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Boolean_AsyncCallback_Object_0;

				// Token: 0x040019E0 RID: 6624
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}
		}
	}
}
