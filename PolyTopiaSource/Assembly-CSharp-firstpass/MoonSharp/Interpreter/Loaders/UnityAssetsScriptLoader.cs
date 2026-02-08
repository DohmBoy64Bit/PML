using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000094 RID: 148
	public class UnityAssetsScriptLoader : ScriptLoaderBase
	{
		// Token: 0x06000C43 RID: 3139 RVA: 0x000458B0 File Offset: 0x00043AB0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAssetsScriptLoader()
		{
			Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Loaders", "UnityAssetsScriptLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr);
			UnityAssetsScriptLoader.NativeFieldInfoPtr_m_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr, "m_Resources");
			UnityAssetsScriptLoader.NativeFieldInfoPtr_DEFAULT_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr, "DEFAULT_PATH");
			UnityAssetsScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr, 100665415);
			UnityAssetsScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr, 100665416);
			UnityAssetsScriptLoader.NativeMethodInfoPtr_LoadResourcesWithReflection_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr, 100665417);
			UnityAssetsScriptLoader.NativeMethodInfoPtr_GetFileName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr, 100665418);
			UnityAssetsScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Virtual_Object_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr, 100665419);
			UnityAssetsScriptLoader.NativeMethodInfoPtr_ScriptFileExists_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr, 100665420);
			UnityAssetsScriptLoader.NativeMethodInfoPtr_GetLoadedScripts_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr, 100665421);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00045994 File Offset: 0x00043B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32692, XrefRangeEnd = 32703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAssetsScriptLoader(string assetsPath = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetsPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAssetsScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000459E0 File Offset: 0x00043BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32703, XrefRangeEnd = 32712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAssetsScriptLoader(Dictionary<string, string> scriptToCodeMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAssetsScriptLoader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scriptToCodeMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAssetsScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00045A2C File Offset: 0x00043C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32790, RefRangeEnd = 32791, XrefRangeStart = 32712, XrefRangeEnd = 32790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadResourcesWithReflection(string assetsPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetsPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAssetsScriptLoader.NativeMethodInfoPtr_LoadResourcesWithReflection_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00045A70 File Offset: 0x00043C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32791, XrefRangeEnd = 32798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFileName(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAssetsScriptLoader.NativeMethodInfoPtr_GetFileName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00045AB8 File Offset: 0x00043CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32798, XrefRangeEnd = 32820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityAssetsScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Virtual_Object_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00045B28 File Offset: 0x00043D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32820, XrefRangeEnd = 32831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ScriptFileExists(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityAssetsScriptLoader.NativeMethodInfoPtr_ScriptFileExists_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00045B80 File Offset: 0x00043D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32831, XrefRangeEnd = 32838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetLoadedScripts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAssetsScriptLoader.NativeMethodInfoPtr_GetLoadedScripts_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00005A5D File Offset: 0x00003C5D
		public UnityAssetsScriptLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00045BC0 File Offset: 0x00043DC0
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x00005A66 File Offset: 0x00003C66
		public unsafe Dictionary<string, string> m_Resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityAssetsScriptLoader.NativeFieldInfoPtr_m_Resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityAssetsScriptLoader.NativeFieldInfoPtr_m_Resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00045BF0 File Offset: 0x00043DF0
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x00005A85 File Offset: 0x00003C85
		public unsafe static string DEFAULT_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityAssetsScriptLoader.NativeFieldInfoPtr_DEFAULT_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityAssetsScriptLoader.NativeFieldInfoPtr_DEFAULT_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr_m_Resources;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_PATH;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_String_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_LoadResourcesWithReflection_Private_Void_String_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Private_String_String_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_LoadFile_Public_Virtual_Object_String_Table_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_ScriptFileExists_Public_Virtual_Boolean_String_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadedScripts_Public_Il2CppStringArray_0;
	}
}
