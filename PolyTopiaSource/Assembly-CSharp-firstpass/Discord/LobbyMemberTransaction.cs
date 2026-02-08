using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000156 RID: 342
	public sealed class LobbyMemberTransaction : ValueType
	{
		// Token: 0x060016A5 RID: 5797 RVA: 0x000734B8 File Offset: 0x000716B8
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyMemberTransaction()
		{
			Il2CppClassPointerStore<LobbyMemberTransaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "LobbyMemberTransaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyMemberTransaction>.NativeClassPtr);
			LobbyMemberTransaction.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMemberTransaction>.NativeClassPtr, "MethodsPtr");
			LobbyMemberTransaction.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMemberTransaction>.NativeClassPtr, "MethodsStructure");
			LobbyMemberTransaction.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction>.NativeClassPtr, 100667348);
			LobbyMemberTransaction.NativeMethodInfoPtr_SetMetadata_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction>.NativeClassPtr, 100667349);
			LobbyMemberTransaction.NativeMethodInfoPtr_DeleteMetadata_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction>.NativeClassPtr, 100667350);
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x0007354C File Offset: 0x0007174C
		public unsafe LobbyMemberTransaction.FFIMethods Methods
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 52217, RefRangeEnd = 52219, XrefRangeStart = 52204, XrefRangeEnd = 52217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LobbyMemberTransaction.FFIMethods(intPtr);
			}
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00073588 File Offset: 0x00071788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52219, XrefRangeEnd = 52220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.NativeMethodInfoPtr_SetMetadata_Public_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000735E4 File Offset: 0x000717E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52220, XrefRangeEnd = 52221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteMetadata(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.NativeMethodInfoPtr_DeleteMetadata_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00008F07 File Offset: 0x00007107
		public LobbyMemberTransaction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00008F10 File Offset: 0x00007110
		public LobbyMemberTransaction()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyMemberTransaction>.NativeClassPtr))
		{
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x0007362C File Offset: 0x0007182C
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x00008F22 File Offset: 0x00007122
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyMemberTransaction.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyMemberTransaction.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00073654 File Offset: 0x00071854
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x00008F3D File Offset: 0x0000713D
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyMemberTransaction.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyMemberTransaction.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_SetMetadata_Public_Void_String_String_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_DeleteMetadata_Public_Void_String_0;

		// Token: 0x020001FE RID: 510
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001E54 RID: 7764 RVA: 0x0008F400 File Offset: 0x0008D600
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyMemberTransaction>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods>.NativeClassPtr);
				LobbyMemberTransaction.FFIMethods.NativeFieldInfoPtr_SetMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods>.NativeClassPtr, "SetMetadata");
				LobbyMemberTransaction.FFIMethods.NativeFieldInfoPtr_DeleteMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods>.NativeClassPtr, "DeleteMetadata");
			}

			// Token: 0x06001E55 RID: 7765 RVA: 0x0000C17D File Offset: 0x0000A37D
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E56 RID: 7766 RVA: 0x0000C186 File Offset: 0x0000A386
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x06001E57 RID: 7767 RVA: 0x0008F454 File Offset: 0x0008D654
			// (set) Token: 0x06001E58 RID: 7768 RVA: 0x0000C198 File Offset: 0x0000A398
			public unsafe LobbyMemberTransaction.FFIMethods.SetMetadataMethod SetMetadata
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyMemberTransaction.FFIMethods.NativeFieldInfoPtr_SetMetadata);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyMemberTransaction.FFIMethods.NativeFieldInfoPtr_SetMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x06001E59 RID: 7769 RVA: 0x0008F484 File Offset: 0x0008D684
			// (set) Token: 0x06001E5A RID: 7770 RVA: 0x0000C1B7 File Offset: 0x0000A3B7
			public unsafe LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyMemberTransaction.FFIMethods.NativeFieldInfoPtr_DeleteMetadata);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyMemberTransaction.FFIMethods.NativeFieldInfoPtr_DeleteMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E7 RID: 6119
			private static readonly IntPtr NativeFieldInfoPtr_SetMetadata;

			// Token: 0x040017E8 RID: 6120
			private static readonly IntPtr NativeFieldInfoPtr_DeleteMetadata;

			// Token: 0x02000267 RID: 615
			public sealed class SetMetadataMethod : MulticastDelegate
			{
				// Token: 0x0600223F RID: 8767 RVA: 0x0009B1CC File Offset: 0x000993CC
				// Note: this type is marked as 'beforefieldinit'.
				static SetMetadataMethod()
				{
					Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods>.NativeClassPtr, "SetMetadataMethod");
					LobbyMemberTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr, 100667351);
					LobbyMemberTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr, 100667352);
					LobbyMemberTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr, 100667353);
					LobbyMemberTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr, 100667354);
				}

				// Token: 0x06002240 RID: 8768 RVA: 0x0009B240 File Offset: 0x00099440
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetMetadataMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002241 RID: 8769 RVA: 0x0009B29C File Offset: 0x0009949C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002242 RID: 8770 RVA: 0x0009B30C File Offset: 0x0009950C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002243 RID: 8771 RVA: 0x0009B3A4 File Offset: 0x000995A4
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.FFIMethods.SetMetadataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002244 RID: 8772 RVA: 0x0000E3E4 File Offset: 0x0000C5E4
				public SetMetadataMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002245 RID: 8773 RVA: 0x0000E3ED File Offset: 0x0000C5ED
				public static implicit operator LobbyMemberTransaction.FFIMethods.SetMetadataMethod(Func<IntPtr, string, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>(A_0);
				}

				// Token: 0x06002246 RID: 8774 RVA: 0x0000E3F5 File Offset: 0x0000C5F5
				public static LobbyMemberTransaction.FFIMethods.SetMetadataMethod operator +(LobbyMemberTransaction.FFIMethods.SetMetadataMethod A_0, LobbyMemberTransaction.FFIMethods.SetMetadataMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>();
				}

				// Token: 0x06002247 RID: 8775 RVA: 0x0000E403 File Offset: 0x0000C603
				public static LobbyMemberTransaction.FFIMethods.SetMetadataMethod operator -(LobbyMemberTransaction.FFIMethods.SetMetadataMethod A_0, LobbyMemberTransaction.FFIMethods.SetMetadataMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyMemberTransaction.FFIMethods.SetMetadataMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019E1 RID: 6625
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019E2 RID: 6626
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_String_0;

				// Token: 0x040019E3 RID: 6627
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_String_AsyncCallback_Object_0;

				// Token: 0x040019E4 RID: 6628
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x02000268 RID: 616
			public sealed class DeleteMetadataMethod : MulticastDelegate
			{
				// Token: 0x06002248 RID: 8776 RVA: 0x0009B3F4 File Offset: 0x000995F4
				// Note: this type is marked as 'beforefieldinit'.
				static DeleteMetadataMethod()
				{
					Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods>.NativeClassPtr, "DeleteMetadataMethod");
					LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr, 100667355);
					LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr, 100667356);
					LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr, 100667357);
					LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr, 100667358);
				}

				// Token: 0x06002249 RID: 8777 RVA: 0x0009B468 File Offset: 0x00099668
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DeleteMetadataMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600224A RID: 8778 RVA: 0x0009B4C4 File Offset: 0x000996C4
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600224B RID: 8779 RVA: 0x0009B524 File Offset: 0x00099724
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600224C RID: 8780 RVA: 0x0009B5A8 File Offset: 0x000997A8
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600224D RID: 8781 RVA: 0x0000E414 File Offset: 0x0000C614
				public DeleteMetadataMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600224E RID: 8782 RVA: 0x0000E41D File Offset: 0x0000C61D
				public static implicit operator LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod(Func<IntPtr, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>(A_0);
				}

				// Token: 0x0600224F RID: 8783 RVA: 0x0000E425 File Offset: 0x0000C625
				public static LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod operator +(LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod A_0, LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>();
				}

				// Token: 0x06002250 RID: 8784 RVA: 0x0000E433 File Offset: 0x0000C633
				public static LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod operator -(LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod A_0, LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019E5 RID: 6629
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019E6 RID: 6630
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_0;

				// Token: 0x040019E7 RID: 6631
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_AsyncCallback_Object_0;

				// Token: 0x040019E8 RID: 6632
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}
		}
	}
}
