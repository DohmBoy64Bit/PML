using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004C RID: 76
	public class AutoDescribingUserDataDescriptor : Object
	{
		// Token: 0x06000879 RID: 2169 RVA: 0x00036BB8 File Offset: 0x00034DB8
		// Note: this type is marked as 'beforefieldinit'.
		static AutoDescribingUserDataDescriptor()
		{
			Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "AutoDescribingUserDataDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr);
			AutoDescribingUserDataDescriptor.NativeFieldInfoPtr_m_FriendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, "m_FriendlyName");
			AutoDescribingUserDataDescriptor.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, "m_Type");
			AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, 100664902);
			AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, 100664903);
			AutoDescribingUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, 100664901);
			AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, 100664904);
			AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, 100664905);
			AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, 100664906);
			AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, 100664907);
			AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr, 100664908);
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00036CB0 File Offset: 0x00034EB0
		public unsafe virtual string Name
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00036CE8 File Offset: 0x00034EE8
		public unsafe virtual Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00036D28 File Offset: 0x00034F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25914, RefRangeEnd = 25915, XrefRangeStart = 25911, XrefRangeEnd = 25914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoDescribingUserDataDescriptor(Type type, string friendlyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoDescribingUserDataDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDescribingUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00036D88 File Offset: 0x00034F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25915, XrefRangeEnd = 25918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00036E0C File Offset: 0x0003500C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25918, XrefRangeEnd = 25921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00036EA0 File Offset: 0x000350A0
		[CallerCount(0)]
		public unsafe virtual string AsString(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00036EE8 File Offset: 0x000350E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25921, XrefRangeEnd = 25924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00036F5C File Offset: 0x0003515C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25924, XrefRangeEnd = 25932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoDescribingUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00004241 File Offset: 0x00002441
		public AutoDescribingUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00036FBC File Offset: 0x000351BC
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x0000424A File Offset: 0x0000244A
		public unsafe string m_FriendlyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoDescribingUserDataDescriptor.NativeFieldInfoPtr_m_FriendlyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoDescribingUserDataDescriptor.NativeFieldInfoPtr_m_FriendlyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00036FE4 File Offset: 0x000351E4
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00004269 File Offset: 0x00002469
		public unsafe Type m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoDescribingUserDataDescriptor.NativeFieldInfoPtr_m_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoDescribingUserDataDescriptor.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr_m_FriendlyName;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0;
	}
}
