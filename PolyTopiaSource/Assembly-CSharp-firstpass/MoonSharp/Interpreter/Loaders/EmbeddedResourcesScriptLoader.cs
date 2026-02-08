using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x0200008F RID: 143
	public class EmbeddedResourcesScriptLoader : ScriptLoaderBase
	{
		// Token: 0x06000C13 RID: 3091 RVA: 0x00044B84 File Offset: 0x00042D84
		// Note: this type is marked as 'beforefieldinit'.
		static EmbeddedResourcesScriptLoader()
		{
			Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Loaders", "EmbeddedResourcesScriptLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr);
			EmbeddedResourcesScriptLoader.NativeFieldInfoPtr_m_ResourceAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr, "m_ResourceAssembly");
			EmbeddedResourcesScriptLoader.NativeFieldInfoPtr_m_ResourceNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr, "m_ResourceNames");
			EmbeddedResourcesScriptLoader.NativeFieldInfoPtr_m_Namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr, "m_Namespace");
			EmbeddedResourcesScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr, 100665385);
			EmbeddedResourcesScriptLoader.NativeMethodInfoPtr_FileNameToResource_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr, 100665386);
			EmbeddedResourcesScriptLoader.NativeMethodInfoPtr_ScriptFileExists_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr, 100665387);
			EmbeddedResourcesScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Virtual_Object_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr, 100665388);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00044C40 File Offset: 0x00042E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32536, XrefRangeEnd = 32553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmbeddedResourcesScriptLoader(Assembly resourceAssembly = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmbeddedResourcesScriptLoader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceAssembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedResourcesScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00044C8C File Offset: 0x00042E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32553, XrefRangeEnd = 32559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FileNameToResource(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedResourcesScriptLoader.NativeMethodInfoPtr_FileNameToResource_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00044CD4 File Offset: 0x00042ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32559, XrefRangeEnd = 32568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ScriptFileExists(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedResourcesScriptLoader.NativeMethodInfoPtr_ScriptFileExists_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00044D2C File Offset: 0x00042F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32568, XrefRangeEnd = 32574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object LoadFile(string file, Table globalContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedResourcesScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Virtual_Object_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0000597A File Offset: 0x00003B7A
		public EmbeddedResourcesScriptLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00044D9C File Offset: 0x00042F9C
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00005983 File Offset: 0x00003B83
		public unsafe Assembly m_ResourceAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedResourcesScriptLoader.NativeFieldInfoPtr_m_ResourceAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedResourcesScriptLoader.NativeFieldInfoPtr_m_ResourceAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00044DCC File Offset: 0x00042FCC
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x000059A2 File Offset: 0x00003BA2
		public unsafe HashSet<string> m_ResourceNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedResourcesScriptLoader.NativeFieldInfoPtr_m_ResourceNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedResourcesScriptLoader.NativeFieldInfoPtr_m_ResourceNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00044DFC File Offset: 0x00042FFC
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x000059C1 File Offset: 0x00003BC1
		public unsafe string m_Namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedResourcesScriptLoader.NativeFieldInfoPtr_m_Namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedResourcesScriptLoader.NativeFieldInfoPtr_m_Namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceAssembly;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceNames;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_m_Namespace;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_FileNameToResource_Private_String_String_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_ScriptFileExists_Public_Virtual_Boolean_String_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_LoadFile_Public_Virtual_Object_String_Table_0;
	}
}
