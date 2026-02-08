using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000093 RID: 147
	public class ScriptLoaderBase : Object
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x0004535C File Offset: 0x0004355C
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptLoaderBase()
		{
			Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Loaders", "ScriptLoaderBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr);
			ScriptLoaderBase.NativeFieldInfoPtr__ModulePaths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, "<ModulePaths>k__BackingField");
			ScriptLoaderBase.NativeFieldInfoPtr__IgnoreLuaPathGlobal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, "<IgnoreLuaPathGlobal>k__BackingField");
			ScriptLoaderBase.NativeMethodInfoPtr_get_ModulePaths_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665403);
			ScriptLoaderBase.NativeMethodInfoPtr_set_ModulePaths_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665404);
			ScriptLoaderBase.NativeMethodInfoPtr_get_IgnoreLuaPathGlobal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665408);
			ScriptLoaderBase.NativeMethodInfoPtr_set_IgnoreLuaPathGlobal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665409);
			ScriptLoaderBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665410);
			ScriptLoaderBase.NativeMethodInfoPtr_ScriptFileExists_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665399);
			ScriptLoaderBase.NativeMethodInfoPtr_LoadFile_Public_Abstract_Virtual_New_Object_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665400);
			ScriptLoaderBase.NativeMethodInfoPtr_ResolveModuleName_Protected_Virtual_New_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665401);
			ScriptLoaderBase.NativeMethodInfoPtr_ResolveModuleName_Public_Virtual_New_String_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665402);
			ScriptLoaderBase.NativeMethodInfoPtr_UnpackStringPaths_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665405);
			ScriptLoaderBase.NativeMethodInfoPtr_GetDefaultEnvironmentPaths_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665406);
			ScriptLoaderBase.NativeMethodInfoPtr_ResolveFileName_Public_Virtual_New_String_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, 100665407);
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000454A4 File Offset: 0x000436A4
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x000454E4 File Offset: 0x000436E4
		public unsafe Il2CppStringArray ModulePaths
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.NativeMethodInfoPtr_get_ModulePaths_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.NativeMethodInfoPtr_set_ModulePaths_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00045528 File Offset: 0x00043728
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x00045564 File Offset: 0x00043764
		public unsafe bool IgnoreLuaPathGlobal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.NativeMethodInfoPtr_get_IgnoreLuaPathGlobal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.NativeMethodInfoPtr_set_IgnoreLuaPathGlobal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000455A4 File Offset: 0x000437A4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptLoaderBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000455E0 File Offset: 0x000437E0
		[CallerCount(0)]
		public unsafe virtual bool ScriptFileExists(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptLoaderBase.NativeMethodInfoPtr_ScriptFileExists_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00045638 File Offset: 0x00043838
		[CallerCount(0)]
		public unsafe virtual Object LoadFile(string file, Table globalContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptLoaderBase.NativeMethodInfoPtr_LoadFile_Public_Abstract_Virtual_New_Object_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x000456A8 File Offset: 0x000438A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32598, XrefRangeEnd = 32604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ResolveModuleName(string modname, Il2CppStringArray paths)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(modname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptLoaderBase.NativeMethodInfoPtr_ResolveModuleName_Protected_Virtual_New_String_String_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00045710 File Offset: 0x00043910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32604, XrefRangeEnd = 32610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ResolveModuleName(string modname, Table globalContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(modname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptLoaderBase.NativeMethodInfoPtr_ResolveModuleName_Public_Virtual_New_String_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00045778 File Offset: 0x00043978
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 32654, RefRangeEnd = 32663, XrefRangeStart = 32610, XrefRangeEnd = 32654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray UnpackStringPaths(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.NativeMethodInfoPtr_UnpackStringPaths_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000457BC File Offset: 0x000439BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32663, XrefRangeEnd = 32692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDefaultEnvironmentPaths()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.NativeMethodInfoPtr_GetDefaultEnvironmentPaths_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000457F0 File Offset: 0x000439F0
		[CallerCount(0)]
		public unsafe virtual string ResolveFileName(string filename, Table globalContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(globalContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptLoaderBase.NativeMethodInfoPtr_ResolveFileName_Public_Virtual_New_String_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00005A1A File Offset: 0x00003C1A
		public ScriptLoaderBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00045858 File Offset: 0x00043A58
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00005A23 File Offset: 0x00003C23
		public unsafe Il2CppStringArray _ModulePaths_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoaderBase.NativeFieldInfoPtr__ModulePaths_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoaderBase.NativeFieldInfoPtr__ModulePaths_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00045888 File Offset: 0x00043A88
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00005A42 File Offset: 0x00003C42
		public unsafe bool _IgnoreLuaPathGlobal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoaderBase.NativeFieldInfoPtr__IgnoreLuaPathGlobal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptLoaderBase.NativeFieldInfoPtr__IgnoreLuaPathGlobal_k__BackingField)) = value;
			}
		}

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr__ModulePaths_k__BackingField;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreLuaPathGlobal_k__BackingField;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_get_ModulePaths_Public_get_Il2CppStringArray_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_set_ModulePaths_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreLuaPathGlobal_Public_get_Boolean_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreLuaPathGlobal_Public_set_Void_Boolean_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_ScriptFileExists_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_LoadFile_Public_Abstract_Virtual_New_Object_String_Table_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_ResolveModuleName_Protected_Virtual_New_String_String_Il2CppStringArray_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_ResolveModuleName_Public_Virtual_New_String_String_Table_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_UnpackStringPaths_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultEnvironmentPaths_Public_Static_Il2CppStringArray_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_ResolveFileName_Public_Virtual_New_String_String_Table_0;

		// Token: 0x020001A8 RID: 424
		[ObfuscatedName("MoonSharp.Interpreter.Loaders.ScriptLoaderBase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AB5 RID: 6837 RVA: 0x00082278 File Offset: 0x00080478
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ScriptLoaderBase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptLoaderBase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptLoaderBase.__c>.NativeClassPtr);
				ScriptLoaderBase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoaderBase.__c>.NativeClassPtr, "<>9");
				ScriptLoaderBase.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoaderBase.__c>.NativeClassPtr, "<>9__8_0");
				ScriptLoaderBase.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptLoaderBase.__c>.NativeClassPtr, "<>9__8_1");
				ScriptLoaderBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase.__c>.NativeClassPtr, 100665412);
				ScriptLoaderBase.__c.NativeMethodInfoPtr__UnpackStringPaths_b__8_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase.__c>.NativeClassPtr, 100665413);
				ScriptLoaderBase.__c.NativeMethodInfoPtr__UnpackStringPaths_b__8_1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptLoaderBase.__c>.NativeClassPtr, 100665414);
			}

			// Token: 0x06001AB6 RID: 6838 RVA: 0x0008231C File Offset: 0x0008051C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptLoaderBase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AB7 RID: 6839 RVA: 0x00082358 File Offset: 0x00080558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32595, XrefRangeEnd = 32597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UnpackStringPaths_b__8_0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.__c.NativeMethodInfoPtr__UnpackStringPaths_b__8_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001AB8 RID: 6840 RVA: 0x000823A0 File Offset: 0x000805A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32597, XrefRangeEnd = 32598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UnpackStringPaths_b__8_1(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptLoaderBase.__c.NativeMethodInfoPtr__UnpackStringPaths_b__8_1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AB9 RID: 6841 RVA: 0x0000A909 File Offset: 0x00008B09
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x06001ABA RID: 6842 RVA: 0x000823F0 File Offset: 0x000805F0
			// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0000A912 File Offset: 0x00008B12
			public unsafe static ScriptLoaderBase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptLoaderBase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptLoaderBase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptLoaderBase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00082418 File Offset: 0x00080618
			// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0000A924 File Offset: 0x00008B24
			public unsafe static Func<string, string> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptLoaderBase.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptLoaderBase.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00082440 File Offset: 0x00080640
			// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0000A936 File Offset: 0x00008B36
			public unsafe static Func<string, bool> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptLoaderBase.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptLoaderBase.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015D4 RID: 5588
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015D5 RID: 5589
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040015D6 RID: 5590
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x040015D7 RID: 5591
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015D8 RID: 5592
			private static readonly IntPtr NativeMethodInfoPtr__UnpackStringPaths_b__8_0_Internal_String_String_0;

			// Token: 0x040015D9 RID: 5593
			private static readonly IntPtr NativeMethodInfoPtr__UnpackStringPaths_b__8_1_Internal_Boolean_String_0;
		}
	}
}
