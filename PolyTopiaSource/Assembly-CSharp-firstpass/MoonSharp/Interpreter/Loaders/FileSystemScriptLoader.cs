using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000090 RID: 144
	public class FileSystemScriptLoader : ScriptLoaderBase
	{
		// Token: 0x06000C1F RID: 3103 RVA: 0x00044E24 File Offset: 0x00043024
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemScriptLoader()
		{
			Il2CppClassPointerStore<FileSystemScriptLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Loaders", "FileSystemScriptLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemScriptLoader>.NativeClassPtr);
			FileSystemScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemScriptLoader>.NativeClassPtr, 100665391);
			FileSystemScriptLoader.NativeMethodInfoPtr_ScriptFileExists_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemScriptLoader>.NativeClassPtr, 100665389);
			FileSystemScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Virtual_Object_String_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemScriptLoader>.NativeClassPtr, 100665390);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00044E90 File Offset: 0x00043090
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemScriptLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemScriptLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemScriptLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00044ECC File Offset: 0x000430CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ScriptFileExists(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemScriptLoader.NativeMethodInfoPtr_ScriptFileExists_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00044F24 File Offset: 0x00043124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32574, XrefRangeEnd = 32578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemScriptLoader.NativeMethodInfoPtr_LoadFile_Public_Virtual_Object_String_Table_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000059E0 File Offset: 0x00003BE0
		public FileSystemScriptLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_ScriptFileExists_Public_Virtual_Boolean_String_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_LoadFile_Public_Virtual_Object_String_Table_0;
	}
}
