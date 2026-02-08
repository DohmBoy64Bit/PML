using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop.UserDataRegistries
{
	// Token: 0x020000BE RID: 190
	public class ExtensionMethodsRegistry : Object
	{
		// Token: 0x06000ED5 RID: 3797 RVA: 0x000513C4 File Offset: 0x0004F5C4
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionMethodsRegistry()
		{
			Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.UserDataRegistries", "ExtensionMethodsRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr);
			ExtensionMethodsRegistry.NativeFieldInfoPtr_s_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, "s_Lock");
			ExtensionMethodsRegistry.NativeFieldInfoPtr_s_Registry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, "s_Registry");
			ExtensionMethodsRegistry.NativeFieldInfoPtr_s_UnresolvedGenericsRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, "s_UnresolvedGenericsRegistry");
			ExtensionMethodsRegistry.NativeFieldInfoPtr_s_ExtensionMethodChangeVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, "s_ExtensionMethodChangeVersion");
			ExtensionMethodsRegistry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, 100665969);
			ExtensionMethodsRegistry.NativeMethodInfoPtr_RegisterExtensionType_Public_Static_Void_Type_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, 100665962);
			ExtensionMethodsRegistry.NativeMethodInfoPtr_FrameworkGetMethods_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, 100665963);
			ExtensionMethodsRegistry.NativeMethodInfoPtr_GetExtensionMethodsByName_Public_Static_IEnumerable_1_IOverloadableMemberDescriptor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, 100665964);
			ExtensionMethodsRegistry.NativeMethodInfoPtr_GetExtensionMethodsChangeVersion_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, 100665965);
			ExtensionMethodsRegistry.NativeMethodInfoPtr_GetExtensionMethodsByNameAndType_Public_Static_List_1_IOverloadableMemberDescriptor_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, 100665966);
			ExtensionMethodsRegistry.NativeMethodInfoPtr_InstantiateMethodInfo_Private_Static_MethodInfo_MethodInfo_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, 100665967);
			ExtensionMethodsRegistry.NativeMethodInfoPtr_GetGenericMatch_Private_Static_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, 100665968);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x000514E4 File Offset: 0x0004F6E4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionMethodsRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00051520 File Offset: 0x0004F720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38685, RefRangeEnd = 38686, XrefRangeStart = 38602, XrefRangeEnd = 38685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.NativeMethodInfoPtr_RegisterExtensionType_Public_Static_Void_Type_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00051568 File Offset: 0x0004F768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38686, XrefRangeEnd = 38691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FrameworkGetMethods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.NativeMethodInfoPtr_FrameworkGetMethods_Private_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0005159C File Offset: 0x0004F79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38691, XrefRangeEnd = 38711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IOverloadableMemberDescriptor> GetExtensionMethodsByName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.NativeMethodInfoPtr_GetExtensionMethodsByName_Public_Static_IEnumerable_1_IOverloadableMemberDescriptor_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IOverloadableMemberDescriptor>>(intPtr3) : null;
			}
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000515E0 File Offset: 0x0004F7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38711, XrefRangeEnd = 38715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetExtensionMethodsChangeVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.NativeMethodInfoPtr_GetExtensionMethodsChangeVersion_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00051610 File Offset: 0x0004F810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38794, RefRangeEnd = 38795, XrefRangeStart = 38715, XrefRangeEnd = 38794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.NativeMethodInfoPtr_GetExtensionMethodsByNameAndType_Public_Static_List_1_IOverloadableMemberDescriptor_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IOverloadableMemberDescriptor>>(intPtr3) : null;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00051668 File Offset: 0x0004F868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38802, RefRangeEnd = 38803, XrefRangeStart = 38795, XrefRangeEnd = 38802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo InstantiateMethodInfo(MethodInfo mi, Type extensionType, Type genericType, Type extendedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensionType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extendedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.NativeMethodInfoPtr_InstantiateMethodInfo_Private_Static_MethodInfo_MethodInfo_Type_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000516E4 File Offset: 0x0004F8E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38826, RefRangeEnd = 38827, XrefRangeStart = 38803, XrefRangeEnd = 38826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetGenericMatch(Type extensionType, Type extendedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extensionType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extendedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.NativeMethodInfoPtr_GetGenericMatch_Private_Static_Type_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00006811 File Offset: 0x00004A11
		public ExtensionMethodsRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0005173C File Offset: 0x0004F93C
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x0000681A File Offset: 0x00004A1A
		public unsafe static Object s_Lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExtensionMethodsRegistry.NativeFieldInfoPtr_s_Lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExtensionMethodsRegistry.NativeFieldInfoPtr_s_Lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00051764 File Offset: 0x0004F964
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x0000682C File Offset: 0x00004A2C
		public unsafe static MultiDictionary<string, IOverloadableMemberDescriptor> s_Registry
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExtensionMethodsRegistry.NativeFieldInfoPtr_s_Registry, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiDictionary<string, IOverloadableMemberDescriptor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExtensionMethodsRegistry.NativeFieldInfoPtr_s_Registry, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x0005178C File Offset: 0x0004F98C
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x0000683E File Offset: 0x00004A3E
		public unsafe static MultiDictionary<string, ExtensionMethodsRegistry.UnresolvedGenericMethod> s_UnresolvedGenericsRegistry
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExtensionMethodsRegistry.NativeFieldInfoPtr_s_UnresolvedGenericsRegistry, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiDictionary<string, ExtensionMethodsRegistry.UnresolvedGenericMethod>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExtensionMethodsRegistry.NativeFieldInfoPtr_s_UnresolvedGenericsRegistry, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x000517B4 File Offset: 0x0004F9B4
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00006850 File Offset: 0x00004A50
		public unsafe static int s_ExtensionMethodChangeVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ExtensionMethodsRegistry.NativeFieldInfoPtr_s_ExtensionMethodChangeVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExtensionMethodsRegistry.NativeFieldInfoPtr_s_ExtensionMethodChangeVersion, (void*)(&value));
			}
		}

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeFieldInfoPtr_s_Lock;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeFieldInfoPtr_s_Registry;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeFieldInfoPtr_s_UnresolvedGenericsRegistry;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeFieldInfoPtr_s_ExtensionMethodChangeVersion;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_RegisterExtensionType_Public_Static_Void_Type_InteropAccessMode_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_FrameworkGetMethods_Private_Static_Object_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_GetExtensionMethodsByName_Public_Static_IEnumerable_1_IOverloadableMemberDescriptor_String_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_GetExtensionMethodsChangeVersion_Public_Static_Int32_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_GetExtensionMethodsByNameAndType_Public_Static_List_1_IOverloadableMemberDescriptor_String_Type_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateMethodInfo_Private_Static_MethodInfo_MethodInfo_Type_Type_Type_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericMatch_Private_Static_Type_Type_Type_0;

		// Token: 0x020001D1 RID: 465
		public class UnresolvedGenericMethod : Object
		{
			// Token: 0x06001C62 RID: 7266 RVA: 0x00089754 File Offset: 0x00087954
			// Note: this type is marked as 'beforefieldinit'.
			static UnresolvedGenericMethod()
			{
				Il2CppClassPointerStore<ExtensionMethodsRegistry.UnresolvedGenericMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, "UnresolvedGenericMethod");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionMethodsRegistry.UnresolvedGenericMethod>.NativeClassPtr);
				ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeFieldInfoPtr_Method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry.UnresolvedGenericMethod>.NativeClassPtr, "Method");
				ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeFieldInfoPtr_AccessMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry.UnresolvedGenericMethod>.NativeClassPtr, "AccessMode");
				ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeFieldInfoPtr_AlreadyAddedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry.UnresolvedGenericMethod>.NativeClassPtr, "AlreadyAddedTypes");
				ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry.UnresolvedGenericMethod>.NativeClassPtr, 100665971);
			}

			// Token: 0x06001C63 RID: 7267 RVA: 0x000897D0 File Offset: 0x000879D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38594, RefRangeEnd = 38595, XrefRangeStart = 38585, XrefRangeEnd = 38594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnresolvedGenericMethod(MethodInfo mi, InteropAccessMode mode)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionMethodsRegistry.UnresolvedGenericMethod>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C64 RID: 7268 RVA: 0x0000B2D0 File Offset: 0x000094D0
			public UnresolvedGenericMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00089830 File Offset: 0x00087A30
			// (set) Token: 0x06001C66 RID: 7270 RVA: 0x0000B2D9 File Offset: 0x000094D9
			public unsafe MethodInfo Method
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeFieldInfoPtr_Method);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeFieldInfoPtr_Method), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00089860 File Offset: 0x00087A60
			// (set) Token: 0x06001C68 RID: 7272 RVA: 0x0000B2F8 File Offset: 0x000094F8
			public unsafe InteropAccessMode AccessMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeFieldInfoPtr_AccessMode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeFieldInfoPtr_AccessMode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00089890 File Offset: 0x00087A90
			// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0000B317 File Offset: 0x00009517
			public unsafe HashSet<Type> AlreadyAddedTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeFieldInfoPtr_AlreadyAddedTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionMethodsRegistry.UnresolvedGenericMethod.NativeFieldInfoPtr_AlreadyAddedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016CA RID: 5834
			private static readonly IntPtr NativeFieldInfoPtr_Method;

			// Token: 0x040016CB RID: 5835
			private static readonly IntPtr NativeFieldInfoPtr_AccessMode;

			// Token: 0x040016CC RID: 5836
			private static readonly IntPtr NativeFieldInfoPtr_AlreadyAddedTypes;

			// Token: 0x040016CD RID: 5837
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_InteropAccessMode_0;
		}

		// Token: 0x020001D2 RID: 466
		[ObfuscatedName("MoonSharp.Interpreter.Interop.UserDataRegistries.ExtensionMethodsRegistry+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C6B RID: 7275 RVA: 0x000898C0 File Offset: 0x00087AC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ExtensionMethodsRegistry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c>.NativeClassPtr);
				ExtensionMethodsRegistry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c>.NativeClassPtr, "<>9");
				ExtensionMethodsRegistry.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c>.NativeClassPtr, "<>9__5_0");
				ExtensionMethodsRegistry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c>.NativeClassPtr, 100665973);
				ExtensionMethodsRegistry.__c.NativeMethodInfoPtr__RegisterExtensionType_b__5_0_Internal_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c>.NativeClassPtr, 100665974);
			}

			// Token: 0x06001C6C RID: 7276 RVA: 0x0008993C File Offset: 0x00087B3C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C6D RID: 7277 RVA: 0x00089978 File Offset: 0x00087B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RegisterExtensionType_b__5_0(MethodInfo _mi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_mi);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.__c.NativeMethodInfoPtr__RegisterExtensionType_b__5_0_Internal_Boolean_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C6E RID: 7278 RVA: 0x0000B336 File Offset: 0x00009536
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x06001C6F RID: 7279 RVA: 0x000899C8 File Offset: 0x00087BC8
			// (set) Token: 0x06001C70 RID: 7280 RVA: 0x0000B33F File Offset: 0x0000953F
			public unsafe static ExtensionMethodsRegistry.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExtensionMethodsRegistry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExtensionMethodsRegistry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExtensionMethodsRegistry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x06001C71 RID: 7281 RVA: 0x000899F0 File Offset: 0x00087BF0
			// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0000B351 File Offset: 0x00009551
			public unsafe static Func<MethodInfo, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExtensionMethodsRegistry.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MethodInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExtensionMethodsRegistry.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016CE RID: 5838
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016CF RID: 5839
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040016D0 RID: 5840
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016D1 RID: 5841
			private static readonly IntPtr NativeMethodInfoPtr__RegisterExtensionType_b__5_0_Internal_Boolean_MethodInfo_0;
		}

		// Token: 0x020001D3 RID: 467
		[ObfuscatedName("MoonSharp.Interpreter.Interop.UserDataRegistries.ExtensionMethodsRegistry+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06001C73 RID: 7283 RVA: 0x00089A18 File Offset: 0x00087C18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ExtensionMethodsRegistry.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExtensionMethodsRegistry>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c__DisplayClass9_0>.NativeClassPtr);
				ExtensionMethodsRegistry.__c__DisplayClass9_0.NativeFieldInfoPtr_extendedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c__DisplayClass9_0>.NativeClassPtr, "extendedType");
				ExtensionMethodsRegistry.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c__DisplayClass9_0>.NativeClassPtr, 100665975);
				ExtensionMethodsRegistry.__c__DisplayClass9_0.NativeMethodInfoPtr__GetExtensionMethodsByNameAndType_b__0_Internal_Boolean_IOverloadableMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c__DisplayClass9_0>.NativeClassPtr, 100665976);
			}

			// Token: 0x06001C74 RID: 7284 RVA: 0x00089A80 File Offset: 0x00087C80
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionMethodsRegistry.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C75 RID: 7285 RVA: 0x00089ABC File Offset: 0x00087CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38595, XrefRangeEnd = 38602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetExtensionMethodsByNameAndType_b__0(IOverloadableMemberDescriptor d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionMethodsRegistry.__c__DisplayClass9_0.NativeMethodInfoPtr__GetExtensionMethodsByNameAndType_b__0_Internal_Boolean_IOverloadableMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C76 RID: 7286 RVA: 0x0000B363 File Offset: 0x00009563
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00089B0C File Offset: 0x00087D0C
			// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0000B36C File Offset: 0x0000956C
			public unsafe Type extendedType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionMethodsRegistry.__c__DisplayClass9_0.NativeFieldInfoPtr_extendedType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtensionMethodsRegistry.__c__DisplayClass9_0.NativeFieldInfoPtr_extendedType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016D2 RID: 5842
			private static readonly IntPtr NativeFieldInfoPtr_extendedType;

			// Token: 0x040016D3 RID: 5843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016D4 RID: 5844
			private static readonly IntPtr NativeMethodInfoPtr__GetExtensionMethodsByNameAndType_b__0_Internal_Boolean_IOverloadableMemberDescriptor_0;
		}
	}
}
