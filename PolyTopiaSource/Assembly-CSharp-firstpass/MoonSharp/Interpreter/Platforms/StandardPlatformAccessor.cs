using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x0200008E RID: 142
	public class StandardPlatformAccessor : PlatformAccessorBase
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x00044540 File Offset: 0x00042740
		// Note: this type is marked as 'beforefieldinit'.
		static StandardPlatformAccessor()
		{
			Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Platforms", "StandardPlatformAccessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr);
			StandardPlatformAccessor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665384);
			StandardPlatformAccessor.NativeMethodInfoPtr_ParseFileAccess_Public_Static_FileAccess_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665370);
			StandardPlatformAccessor.NativeMethodInfoPtr_ParseFileMode_Public_Static_FileMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665371);
			StandardPlatformAccessor.NativeMethodInfoPtr_IO_OpenFile_Public_Virtual_Stream_Script_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665372);
			StandardPlatformAccessor.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665373);
			StandardPlatformAccessor.NativeMethodInfoPtr_IO_GetStandardStream_Public_Virtual_Stream_StandardFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665374);
			StandardPlatformAccessor.NativeMethodInfoPtr_DefaultPrint_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665375);
			StandardPlatformAccessor.NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665376);
			StandardPlatformAccessor.NativeMethodInfoPtr_OS_ExitFast_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665377);
			StandardPlatformAccessor.NativeMethodInfoPtr_OS_FileExists_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665378);
			StandardPlatformAccessor.NativeMethodInfoPtr_OS_FileDelete_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665379);
			StandardPlatformAccessor.NativeMethodInfoPtr_OS_FileMove_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665380);
			StandardPlatformAccessor.NativeMethodInfoPtr_OS_Execute_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665381);
			StandardPlatformAccessor.NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Virtual_CoreModules_CoreModules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665382);
			StandardPlatformAccessor.NativeMethodInfoPtr_GetPlatformNamePrefix_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr, 100665383);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0004469C File Offset: 0x0004289C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardPlatformAccessor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardPlatformAccessor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPlatformAccessor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000446D8 File Offset: 0x000428D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32415, XrefRangeEnd = 32432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileAccess ParseFileAccess(string mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPlatformAccessor.NativeMethodInfoPtr_ParseFileAccess_Public_Static_FileAccess_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileAccess>(intPtr3) : null;
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0004471C File Offset: 0x0004291C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32432, XrefRangeEnd = 32449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileMode ParseFileMode(string mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPlatformAccessor.NativeMethodInfoPtr_ParseFileMode_Public_Static_FileMode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileMode>(intPtr3) : null;
			}
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00044760 File Offset: 0x00042960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32449, XrefRangeEnd = 32492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_IO_OpenFile_Public_Virtual_Stream_Script_String_Encoding_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000447F4 File Offset: 0x000429F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32492, XrefRangeEnd = 32493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEnvironmentVariable(string envvarname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(envvarname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00044848 File Offset: 0x00042A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32493, XrefRangeEnd = 32509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream IO_GetStandardStream(StandardFileType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_IO_GetStandardStream_Public_Virtual_Stream_StandardFileType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000448A4 File Offset: 0x00042AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32509, XrefRangeEnd = 32513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DefaultPrint(string content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_DefaultPrint_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000448F4 File Offset: 0x00042AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32513, XrefRangeEnd = 32517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string IO_OS_GetTempFilename()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00044938 File Offset: 0x00042B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32517, XrefRangeEnd = 32518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OS_ExitFast(int exitCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_OS_ExitFast_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00044984 File Offset: 0x00042B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32518, XrefRangeEnd = 32519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OS_FileExists(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_OS_FileExists_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000449DC File Offset: 0x00042BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32519, XrefRangeEnd = 32520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OS_FileDelete(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_OS_FileDelete_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00044A2C File Offset: 0x00042C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32520, XrefRangeEnd = 32521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OS_FileMove(string src, string dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dst);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_OS_FileMove_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00044A8C File Offset: 0x00042C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32521, XrefRangeEnd = 32534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int OS_Execute(string cmdline)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cmdline);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_OS_Execute_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00044AE4 File Offset: 0x00042CE4
		[CallerCount(0)]
		public unsafe override CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Virtual_CoreModules_CoreModules_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CoreModules>(intPtr3) : null;
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00044B40 File Offset: 0x00042D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32534, XrefRangeEnd = 32536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetPlatformNamePrefix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPlatformAccessor.NativeMethodInfoPtr_GetPlatformNamePrefix_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00005971 File Offset: 0x00003B71
		public StandardPlatformAccessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_ParseFileAccess_Public_Static_FileAccess_String_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_ParseFileMode_Public_Static_FileMode_String_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_IO_OpenFile_Public_Virtual_Stream_Script_String_Encoding_String_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariable_Public_Virtual_String_String_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_IO_GetStandardStream_Public_Virtual_Stream_StandardFileType_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_DefaultPrint_Public_Virtual_Void_String_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Virtual_String_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_OS_ExitFast_Public_Virtual_Void_Int32_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileExists_Public_Virtual_Boolean_String_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileDelete_Public_Virtual_Void_String_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileMove_Public_Virtual_Void_String_String_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_OS_Execute_Public_Virtual_Int32_String_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Virtual_CoreModules_CoreModules_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformNamePrefix_Public_Virtual_String_0;
	}
}
