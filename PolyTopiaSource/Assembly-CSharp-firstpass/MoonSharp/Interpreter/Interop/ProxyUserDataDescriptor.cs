using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B1 RID: 177
	public sealed class ProxyUserDataDescriptor : Object
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x0004B78C File Offset: 0x0004998C
		// Note: this type is marked as 'beforefieldinit'.
		static ProxyUserDataDescriptor()
		{
			Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "ProxyUserDataDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr);
			ProxyUserDataDescriptor.NativeFieldInfoPtr_m_ProxyDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, "m_ProxyDescriptor");
			ProxyUserDataDescriptor.NativeFieldInfoPtr_m_ProxyFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, "m_ProxyFactory");
			ProxyUserDataDescriptor.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, "<Name>k__BackingField");
			ProxyUserDataDescriptor.NativeMethodInfoPtr_get_InnerDescriptor_Public_get_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665637);
			ProxyUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665638);
			ProxyUserDataDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665639);
			ProxyUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665640);
			ProxyUserDataDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_IProxyFactory_IUserDataDescriptor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665636);
			ProxyUserDataDescriptor.NativeMethodInfoPtr_Proxy_Private_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665641);
			ProxyUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665642);
			ProxyUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665643);
			ProxyUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665644);
			ProxyUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665645);
			ProxyUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr, 100665646);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x0004B8D4 File Offset: 0x00049AD4
		public unsafe IUserDataDescriptor InnerDescriptor
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_get_InnerDescriptor_Public_get_IUserDataDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0004B914 File Offset: 0x00049B14
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x0004B94C File Offset: 0x00049B4C
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0004B990 File Offset: 0x00049B90
		public unsafe Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34363, XrefRangeEnd = 34367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0004B9D0 File Offset: 0x00049BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34367, XrefRangeEnd = 34378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProxyUserDataDescriptor(IProxyFactory proxyFactory, IUserDataDescriptor proxyDescriptor, string friendlyName = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProxyUserDataDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxyFactory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxyDescriptor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_IProxyFactory_IUserDataDescriptor_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0004BA40 File Offset: 0x00049C40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 34382, RefRangeEnd = 34386, XrefRangeStart = 34378, XrefRangeEnd = 34382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Proxy(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_Proxy_Private_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0004BA90 File Offset: 0x00049C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34386, XrefRangeEnd = 34390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue Index(Script script, Object obj, DynValue index, bool isDirectIndexing)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0004BB14 File Offset: 0x00049D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34390, XrefRangeEnd = 34394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetIndex(Script script, Object obj, DynValue index, DynValue value, bool isDirectIndexing)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0004BBA8 File Offset: 0x00049DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34394, XrefRangeEnd = 34400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AsString(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0004BBF0 File Offset: 0x00049DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34400, XrefRangeEnd = 34404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue MetaIndex(Script script, Object obj, string metaname)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0004BC64 File Offset: 0x00049E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34404, XrefRangeEnd = 34412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTypeCompatible(Type type, Object obj)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00006045 File Offset: 0x00004245
		public ProxyUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0004BCC4 File Offset: 0x00049EC4
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x0000604E File Offset: 0x0000424E
		public unsafe IUserDataDescriptor m_ProxyDescriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProxyUserDataDescriptor.NativeFieldInfoPtr_m_ProxyDescriptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProxyUserDataDescriptor.NativeFieldInfoPtr_m_ProxyDescriptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0004BCF4 File Offset: 0x00049EF4
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x0000606D File Offset: 0x0000426D
		public unsafe IProxyFactory m_ProxyFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProxyUserDataDescriptor.NativeFieldInfoPtr_m_ProxyFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IProxyFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProxyUserDataDescriptor.NativeFieldInfoPtr_m_ProxyFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0004BD24 File Offset: 0x00049F24
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x0000608C File Offset: 0x0000428C
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProxyUserDataDescriptor.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProxyUserDataDescriptor.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_m_ProxyDescriptor;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeFieldInfoPtr_m_ProxyFactory;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerDescriptor_Public_get_IUserDataDescriptor_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IProxyFactory_IUserDataDescriptor_String_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_Proxy_Private_Object_Object_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0;
	}
}
