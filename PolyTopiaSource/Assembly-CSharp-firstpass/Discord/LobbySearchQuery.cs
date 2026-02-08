using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000157 RID: 343
	public sealed class LobbySearchQuery : ValueType
	{
		// Token: 0x060016AF RID: 5807 RVA: 0x00073684 File Offset: 0x00071884
		// Note: this type is marked as 'beforefieldinit'.
		static LobbySearchQuery()
		{
			Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "LobbySearchQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr);
			LobbySearchQuery.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr, "MethodsPtr");
			LobbySearchQuery.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr, "MethodsStructure");
			LobbySearchQuery.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr, 100667359);
			LobbySearchQuery.NativeMethodInfoPtr_Filter_Public_Void_String_LobbySearchComparison_LobbySearchCast_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr, 100667360);
			LobbySearchQuery.NativeMethodInfoPtr_Sort_Public_Void_String_LobbySearchCast_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr, 100667361);
			LobbySearchQuery.NativeMethodInfoPtr_Limit_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr, 100667362);
			LobbySearchQuery.NativeMethodInfoPtr_Distance_Public_Void_LobbySearchDistance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr, 100667363);
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x00073740 File Offset: 0x00071940
		public unsafe LobbySearchQuery.FFIMethods Methods
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 52261, RefRangeEnd = 52265, XrefRangeStart = 52248, XrefRangeEnd = 52261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LobbySearchQuery.FFIMethods(intPtr);
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0007377C File Offset: 0x0007197C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52265, XrefRangeEnd = 52266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparison);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cast);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.NativeMethodInfoPtr_Filter_Public_Void_String_LobbySearchComparison_LobbySearchCast_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x000737FC File Offset: 0x000719FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52266, XrefRangeEnd = 52267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(string key, LobbySearchCast cast, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cast);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.NativeMethodInfoPtr_Sort_Public_Void_String_LobbySearchCast_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00073868 File Offset: 0x00071A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52267, XrefRangeEnd = 52268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Limit(uint limit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref limit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.NativeMethodInfoPtr_Limit_Public_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000738AC File Offset: 0x00071AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52268, XrefRangeEnd = 52269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Distance(LobbySearchDistance distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(distance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.NativeMethodInfoPtr_Distance_Public_Void_LobbySearchDistance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00008F5C File Offset: 0x0000715C
		public LobbySearchQuery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00008F65 File Offset: 0x00007165
		public LobbySearchQuery()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr))
		{
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x000738F4 File Offset: 0x00071AF4
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x00008F77 File Offset: 0x00007177
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0007391C File Offset: 0x00071B1C
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x00008F92 File Offset: 0x00007192
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_Filter_Public_Void_String_LobbySearchComparison_LobbySearchCast_String_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_String_LobbySearchCast_String_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_Limit_Public_Void_UInt32_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Void_LobbySearchDistance_0;

		// Token: 0x020001FF RID: 511
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001E5B RID: 7771 RVA: 0x0008F4B4 File Offset: 0x0008D6B4
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbySearchQuery>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr);
				LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr, "Filter");
				LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Sort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr, "Sort");
				LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr, "Limit");
				LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr, "Distance");
			}

			// Token: 0x06001E5C RID: 7772 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E5D RID: 7773 RVA: 0x0000C1DF File Offset: 0x0000A3DF
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0008F530 File Offset: 0x0008D730
			// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0000C1F1 File Offset: 0x0000A3F1
			public unsafe LobbySearchQuery.FFIMethods.FilterMethod Filter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Filter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySearchQuery.FFIMethods.FilterMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Filter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0008F560 File Offset: 0x0008D760
			// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0000C210 File Offset: 0x0000A410
			public unsafe LobbySearchQuery.FFIMethods.SortMethod Sort
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Sort);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySearchQuery.FFIMethods.SortMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Sort), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0008F590 File Offset: 0x0008D790
			// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0000C22F File Offset: 0x0000A42F
			public unsafe LobbySearchQuery.FFIMethods.LimitMethod Limit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Limit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySearchQuery.FFIMethods.LimitMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Limit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0008F5C0 File Offset: 0x0008D7C0
			// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0000C24E File Offset: 0x0000A44E
			public unsafe LobbySearchQuery.FFIMethods.DistanceMethod Distance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Distance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySearchQuery.FFIMethods.DistanceMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbySearchQuery.FFIMethods.NativeFieldInfoPtr_Distance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E9 RID: 6121
			private static readonly IntPtr NativeFieldInfoPtr_Filter;

			// Token: 0x040017EA RID: 6122
			private static readonly IntPtr NativeFieldInfoPtr_Sort;

			// Token: 0x040017EB RID: 6123
			private static readonly IntPtr NativeFieldInfoPtr_Limit;

			// Token: 0x040017EC RID: 6124
			private static readonly IntPtr NativeFieldInfoPtr_Distance;

			// Token: 0x02000269 RID: 617
			public sealed class FilterMethod : MulticastDelegate
			{
				// Token: 0x06002251 RID: 8785 RVA: 0x0009B5F8 File Offset: 0x000997F8
				// Note: this type is marked as 'beforefieldinit'.
				static FilterMethod()
				{
					Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.FilterMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr, "FilterMethod");
					LobbySearchQuery.FFIMethods.FilterMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.FilterMethod>.NativeClassPtr, 100667364);
					LobbySearchQuery.FFIMethods.FilterMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_LobbySearchComparison_LobbySearchCast_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.FilterMethod>.NativeClassPtr, 100667365);
					LobbySearchQuery.FFIMethods.FilterMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_LobbySearchComparison_LobbySearchCast_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.FilterMethod>.NativeClassPtr, 100667366);
					LobbySearchQuery.FFIMethods.FilterMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.FilterMethod>.NativeClassPtr, 100667367);
				}

				// Token: 0x06002252 RID: 8786 RVA: 0x0009B66C File Offset: 0x0009986C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52221, XrefRangeEnd = 52224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FilterMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.FilterMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.FilterMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002253 RID: 8787 RVA: 0x0009B6C8 File Offset: 0x000998C8
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparison);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cast);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.FilterMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_LobbySearchComparison_LobbySearchCast_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002254 RID: 8788 RVA: 0x0009B760 File Offset: 0x00099960
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52224, XrefRangeEnd = 52233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparison);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cast);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.FilterMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_LobbySearchComparison_LobbySearchCast_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002255 RID: 8789 RVA: 0x0009B81C File Offset: 0x00099A1C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.FilterMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002256 RID: 8790 RVA: 0x0000E444 File Offset: 0x0000C644
				public FilterMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002257 RID: 8791 RVA: 0x0000E44D File Offset: 0x0000C64D
				public static implicit operator LobbySearchQuery.FFIMethods.FilterMethod(Func<IntPtr, string, LobbySearchComparison, LobbySearchCast, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbySearchQuery.FFIMethods.FilterMethod>(A_0);
				}

				// Token: 0x06002258 RID: 8792 RVA: 0x0000E455 File Offset: 0x0000C655
				public static LobbySearchQuery.FFIMethods.FilterMethod operator +(LobbySearchQuery.FFIMethods.FilterMethod A_0, LobbySearchQuery.FFIMethods.FilterMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbySearchQuery.FFIMethods.FilterMethod>();
				}

				// Token: 0x06002259 RID: 8793 RVA: 0x0000E463 File Offset: 0x0000C663
				public static LobbySearchQuery.FFIMethods.FilterMethod operator -(LobbySearchQuery.FFIMethods.FilterMethod A_0, LobbySearchQuery.FFIMethods.FilterMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbySearchQuery.FFIMethods.FilterMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019E9 RID: 6633
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019EA RID: 6634
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_LobbySearchComparison_LobbySearchCast_String_0;

				// Token: 0x040019EB RID: 6635
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_LobbySearchComparison_LobbySearchCast_String_AsyncCallback_Object_0;

				// Token: 0x040019EC RID: 6636
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x0200026A RID: 618
			public sealed class SortMethod : MulticastDelegate
			{
				// Token: 0x0600225A RID: 8794 RVA: 0x0009B86C File Offset: 0x00099A6C
				// Note: this type is marked as 'beforefieldinit'.
				static SortMethod()
				{
					Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.SortMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr, "SortMethod");
					LobbySearchQuery.FFIMethods.SortMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.SortMethod>.NativeClassPtr, 100667368);
					LobbySearchQuery.FFIMethods.SortMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_LobbySearchCast_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.SortMethod>.NativeClassPtr, 100667369);
					LobbySearchQuery.FFIMethods.SortMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_LobbySearchCast_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.SortMethod>.NativeClassPtr, 100667370);
					LobbySearchQuery.FFIMethods.SortMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.SortMethod>.NativeClassPtr, 100667371);
				}

				// Token: 0x0600225B RID: 8795 RVA: 0x0009B8E0 File Offset: 0x00099AE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52233, XrefRangeEnd = 52236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SortMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.SortMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.SortMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600225C RID: 8796 RVA: 0x0009B93C File Offset: 0x00099B3C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, string key, LobbySearchCast cast, string value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cast);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.SortMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_LobbySearchCast_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600225D RID: 8797 RVA: 0x0009B9C0 File Offset: 0x00099BC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52236, XrefRangeEnd = 52242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, LobbySearchCast cast, string value, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cast);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.SortMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_LobbySearchCast_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600225E RID: 8798 RVA: 0x0009BA6C File Offset: 0x00099C6C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.SortMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600225F RID: 8799 RVA: 0x0000E474 File Offset: 0x0000C674
				public SortMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002260 RID: 8800 RVA: 0x0000E47D File Offset: 0x0000C67D
				public static implicit operator LobbySearchQuery.FFIMethods.SortMethod(Func<IntPtr, string, LobbySearchCast, string, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbySearchQuery.FFIMethods.SortMethod>(A_0);
				}

				// Token: 0x06002261 RID: 8801 RVA: 0x0000E485 File Offset: 0x0000C685
				public static LobbySearchQuery.FFIMethods.SortMethod operator +(LobbySearchQuery.FFIMethods.SortMethod A_0, LobbySearchQuery.FFIMethods.SortMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbySearchQuery.FFIMethods.SortMethod>();
				}

				// Token: 0x06002262 RID: 8802 RVA: 0x0000E493 File Offset: 0x0000C693
				public static LobbySearchQuery.FFIMethods.SortMethod operator -(LobbySearchQuery.FFIMethods.SortMethod A_0, LobbySearchQuery.FFIMethods.SortMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbySearchQuery.FFIMethods.SortMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019ED RID: 6637
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019EE RID: 6638
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_String_LobbySearchCast_String_0;

				// Token: 0x040019EF RID: 6639
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_LobbySearchCast_String_AsyncCallback_Object_0;

				// Token: 0x040019F0 RID: 6640
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x0200026B RID: 619
			public sealed class LimitMethod : MulticastDelegate
			{
				// Token: 0x06002263 RID: 8803 RVA: 0x0009BABC File Offset: 0x00099CBC
				// Note: this type is marked as 'beforefieldinit'.
				static LimitMethod()
				{
					Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.LimitMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr, "LimitMethod");
					LobbySearchQuery.FFIMethods.LimitMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.LimitMethod>.NativeClassPtr, 100667372);
					LobbySearchQuery.FFIMethods.LimitMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.LimitMethod>.NativeClassPtr, 100667373);
					LobbySearchQuery.FFIMethods.LimitMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.LimitMethod>.NativeClassPtr, 100667374);
					LobbySearchQuery.FFIMethods.LimitMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.LimitMethod>.NativeClassPtr, 100667375);
				}

				// Token: 0x06002264 RID: 8804 RVA: 0x0009BB30 File Offset: 0x00099D30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe LimitMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.LimitMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.LimitMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002265 RID: 8805 RVA: 0x0009BB8C File Offset: 0x00099D8C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, uint limit)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref limit;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.LimitMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002266 RID: 8806 RVA: 0x0009BBE8 File Offset: 0x00099DE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, uint limit, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref limit;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.LimitMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002267 RID: 8807 RVA: 0x0009BC68 File Offset: 0x00099E68
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.LimitMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002268 RID: 8808 RVA: 0x0000E4A4 File Offset: 0x0000C6A4
				public LimitMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002269 RID: 8809 RVA: 0x0000E4AD File Offset: 0x0000C6AD
				public static implicit operator LobbySearchQuery.FFIMethods.LimitMethod(Func<IntPtr, uint, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbySearchQuery.FFIMethods.LimitMethod>(A_0);
				}

				// Token: 0x0600226A RID: 8810 RVA: 0x0000E4B5 File Offset: 0x0000C6B5
				public static LobbySearchQuery.FFIMethods.LimitMethod operator +(LobbySearchQuery.FFIMethods.LimitMethod A_0, LobbySearchQuery.FFIMethods.LimitMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbySearchQuery.FFIMethods.LimitMethod>();
				}

				// Token: 0x0600226B RID: 8811 RVA: 0x0000E4C3 File Offset: 0x0000C6C3
				public static LobbySearchQuery.FFIMethods.LimitMethod operator -(LobbySearchQuery.FFIMethods.LimitMethod A_0, LobbySearchQuery.FFIMethods.LimitMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbySearchQuery.FFIMethods.LimitMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019F1 RID: 6641
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019F2 RID: 6642
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_UInt32_0;

				// Token: 0x040019F3 RID: 6643
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_UInt32_AsyncCallback_Object_0;

				// Token: 0x040019F4 RID: 6644
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x0200026C RID: 620
			public sealed class DistanceMethod : MulticastDelegate
			{
				// Token: 0x0600226C RID: 8812 RVA: 0x0009BCB8 File Offset: 0x00099EB8
				// Note: this type is marked as 'beforefieldinit'.
				static DistanceMethod()
				{
					Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.DistanceMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods>.NativeClassPtr, "DistanceMethod");
					LobbySearchQuery.FFIMethods.DistanceMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.DistanceMethod>.NativeClassPtr, 100667376);
					LobbySearchQuery.FFIMethods.DistanceMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_LobbySearchDistance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.DistanceMethod>.NativeClassPtr, 100667377);
					LobbySearchQuery.FFIMethods.DistanceMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LobbySearchDistance_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.DistanceMethod>.NativeClassPtr, 100667378);
					LobbySearchQuery.FFIMethods.DistanceMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.DistanceMethod>.NativeClassPtr, 100667379);
				}

				// Token: 0x0600226D RID: 8813 RVA: 0x0009BD2C File Offset: 0x00099F2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DistanceMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbySearchQuery.FFIMethods.DistanceMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.DistanceMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600226E RID: 8814 RVA: 0x0009BD88 File Offset: 0x00099F88
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, LobbySearchDistance distance)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(distance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.DistanceMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_LobbySearchDistance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600226F RID: 8815 RVA: 0x0009BDE8 File Offset: 0x00099FE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52242, XrefRangeEnd = 52248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, LobbySearchDistance distance, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(distance);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.DistanceMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LobbySearchDistance_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002270 RID: 8816 RVA: 0x0009BE6C File Offset: 0x0009A06C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbySearchQuery.FFIMethods.DistanceMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002271 RID: 8817 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
				public DistanceMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002272 RID: 8818 RVA: 0x0000E4DD File Offset: 0x0000C6DD
				public static implicit operator LobbySearchQuery.FFIMethods.DistanceMethod(Func<IntPtr, LobbySearchDistance, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbySearchQuery.FFIMethods.DistanceMethod>(A_0);
				}

				// Token: 0x06002273 RID: 8819 RVA: 0x0000E4E5 File Offset: 0x0000C6E5
				public static LobbySearchQuery.FFIMethods.DistanceMethod operator +(LobbySearchQuery.FFIMethods.DistanceMethod A_0, LobbySearchQuery.FFIMethods.DistanceMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbySearchQuery.FFIMethods.DistanceMethod>();
				}

				// Token: 0x06002274 RID: 8820 RVA: 0x0000E4F3 File Offset: 0x0000C6F3
				public static LobbySearchQuery.FFIMethods.DistanceMethod operator -(LobbySearchQuery.FFIMethods.DistanceMethod A_0, LobbySearchQuery.FFIMethods.DistanceMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbySearchQuery.FFIMethods.DistanceMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019F5 RID: 6645
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019F6 RID: 6646
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_LobbySearchDistance_0;

				// Token: 0x040019F7 RID: 6647
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LobbySearchDistance_AsyncCallback_Object_0;

				// Token: 0x040019F8 RID: 6648
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}
		}
	}
}
