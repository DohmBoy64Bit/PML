using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x0200008A RID: 138
	public class LimitedPlatformAccessor : PlatformAccessorBase
	{
		// Token: 0x06000BBC RID: 3004 RVA: 0x00043204 File Offset: 0x00041404
		// Note: this type is marked as 'beforefieldinit'.
		static LimitedPlatformAccessor()
		{
			Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Platforms", "LimitedPlatformAccessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr);
			LimitedPlatformAccessor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665330);
			LimitedPlatformAccessor.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665318);
			LimitedPlatformAccessor.NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Virtual_CoreModules_CoreModules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665319);
			LimitedPlatformAccessor.NativeMethodInfoPtr_IO_OpenFile_Public_Virtual_Stream_Script_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665320);
			LimitedPlatformAccessor.NativeMethodInfoPtr_IO_GetStandardStream_Public_Virtual_Stream_StandardFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665321);
			LimitedPlatformAccessor.NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665322);
			LimitedPlatformAccessor.NativeMethodInfoPtr_OS_ExitFast_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665323);
			LimitedPlatformAccessor.NativeMethodInfoPtr_OS_FileExists_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665324);
			LimitedPlatformAccessor.NativeMethodInfoPtr_OS_FileDelete_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665325);
			LimitedPlatformAccessor.NativeMethodInfoPtr_OS_FileMove_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665326);
			LimitedPlatformAccessor.NativeMethodInfoPtr_OS_Execute_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665327);
			LimitedPlatformAccessor.NativeMethodInfoPtr_GetPlatformNamePrefix_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665328);
			LimitedPlatformAccessor.NativeMethodInfoPtr_DefaultPrint_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr, 100665329);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00043338 File Offset: 0x00041538
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LimitedPlatformAccessor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LimitedPlatformAccessor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LimitedPlatformAccessor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00043374 File Offset: 0x00041574
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEnvironmentVariable(string envvarname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(envvarname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x000433C8 File Offset: 0x000415C8
		[CallerCount(0)]
		public unsafe override CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Virtual_CoreModules_CoreModules_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CoreModules>(intPtr3) : null;
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00043424 File Offset: 0x00041624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32185, XrefRangeEnd = 32191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_IO_OpenFile_Public_Virtual_Stream_Script_String_Encoding_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000434B8 File Offset: 0x000416B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32191, XrefRangeEnd = 32197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream IO_GetStandardStream(StandardFileType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_IO_GetStandardStream_Public_Virtual_Stream_StandardFileType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00043514 File Offset: 0x00041714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32197, XrefRangeEnd = 32203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string IO_OS_GetTempFilename()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00043558 File Offset: 0x00041758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32203, XrefRangeEnd = 32209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OS_ExitFast(int exitCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_OS_ExitFast_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000435A4 File Offset: 0x000417A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32209, XrefRangeEnd = 32215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OS_FileExists(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_OS_FileExists_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000435FC File Offset: 0x000417FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32215, XrefRangeEnd = 32221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OS_FileDelete(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_OS_FileDelete_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0004364C File Offset: 0x0004184C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32221, XrefRangeEnd = 32227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_OS_FileMove_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000436AC File Offset: 0x000418AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32227, XrefRangeEnd = 32233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int OS_Execute(string cmdline)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cmdline);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_OS_Execute_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00043704 File Offset: 0x00041904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32233, XrefRangeEnd = 32235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetPlatformNamePrefix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_GetPlatformNamePrefix_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00043748 File Offset: 0x00041948
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DefaultPrint(string content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LimitedPlatformAccessor.NativeMethodInfoPtr_DefaultPrint_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000058E2 File Offset: 0x00003AE2
		public LimitedPlatformAccessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariable_Public_Virtual_String_String_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Virtual_CoreModules_CoreModules_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_IO_OpenFile_Public_Virtual_Stream_Script_String_Encoding_String_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_IO_GetStandardStream_Public_Virtual_Stream_StandardFileType_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Virtual_String_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_OS_ExitFast_Public_Virtual_Void_Int32_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileExists_Public_Virtual_Boolean_String_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileDelete_Public_Virtual_Void_String_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileMove_Public_Virtual_Void_String_String_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_OS_Execute_Public_Virtual_Int32_String_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformNamePrefix_Public_Virtual_String_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_DefaultPrint_Public_Virtual_Void_String_0;
	}
}
