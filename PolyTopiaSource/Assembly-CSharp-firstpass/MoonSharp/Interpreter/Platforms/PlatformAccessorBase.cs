using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x0200008B RID: 139
	public class PlatformAccessorBase : Object
	{
		// Token: 0x06000BCB RID: 3019 RVA: 0x00043798 File Offset: 0x00041998
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformAccessorBase()
		{
			Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Platforms", "PlatformAccessorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr);
			PlatformAccessorBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665349);
			PlatformAccessorBase.NativeMethodInfoPtr_GetPlatformNamePrefix_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665331);
			PlatformAccessorBase.NativeMethodInfoPtr_GetPlatformName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665332);
			PlatformAccessorBase.NativeMethodInfoPtr_GetUnityRuntimeName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665333);
			PlatformAccessorBase.NativeMethodInfoPtr_GetUnityPlatformName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665334);
			PlatformAccessorBase.NativeMethodInfoPtr_DefaultPrint_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665335);
			PlatformAccessorBase.NativeMethodInfoPtr_DefaultInput_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665336);
			PlatformAccessorBase.NativeMethodInfoPtr_DefaultInput_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665337);
			PlatformAccessorBase.NativeMethodInfoPtr_IO_OpenFile_Public_Abstract_Virtual_New_Stream_Script_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665338);
			PlatformAccessorBase.NativeMethodInfoPtr_IO_GetStandardStream_Public_Abstract_Virtual_New_Stream_StandardFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665339);
			PlatformAccessorBase.NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665340);
			PlatformAccessorBase.NativeMethodInfoPtr_OS_ExitFast_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665341);
			PlatformAccessorBase.NativeMethodInfoPtr_OS_FileExists_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665342);
			PlatformAccessorBase.NativeMethodInfoPtr_OS_FileDelete_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665343);
			PlatformAccessorBase.NativeMethodInfoPtr_OS_FileMove_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665344);
			PlatformAccessorBase.NativeMethodInfoPtr_OS_Execute_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665345);
			PlatformAccessorBase.NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Abstract_Virtual_New_CoreModules_CoreModules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665346);
			PlatformAccessorBase.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665347);
			PlatformAccessorBase.NativeMethodInfoPtr_IsRunningOnAOT_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr, 100665348);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00043944 File Offset: 0x00041B44
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformAccessorBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformAccessorBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAccessorBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00043980 File Offset: 0x00041B80
		[CallerCount(0)]
		public unsafe virtual string GetPlatformNamePrefix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_GetPlatformNamePrefix_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000439C4 File Offset: 0x00041BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32235, XrefRangeEnd = 32285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetPlatformName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAccessorBase.NativeMethodInfoPtr_GetPlatformName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x000439FC File Offset: 0x00041BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32285, XrefRangeEnd = 32287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnityRuntimeName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAccessorBase.NativeMethodInfoPtr_GetUnityRuntimeName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00043A34 File Offset: 0x00041C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32287, XrefRangeEnd = 32289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnityPlatformName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformAccessorBase.NativeMethodInfoPtr_GetUnityPlatformName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00043A6C File Offset: 0x00041C6C
		[CallerCount(0)]
		public unsafe virtual void DefaultPrint(string content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_DefaultPrint_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00043ABC File Offset: 0x00041CBC
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string DefaultInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_DefaultInput_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00043B00 File Offset: 0x00041D00
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 32289, RefRangeEnd = 32304, XrefRangeStart = 32289, XrefRangeEnd = 32289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string DefaultInput(string prompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_DefaultInput_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00043B54 File Offset: 0x00041D54
		[CallerCount(0)]
		public unsafe virtual Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_IO_OpenFile_Public_Abstract_Virtual_New_Stream_Script_String_Encoding_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00043BE8 File Offset: 0x00041DE8
		[CallerCount(0)]
		public unsafe virtual Stream IO_GetStandardStream(StandardFileType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_IO_GetStandardStream_Public_Abstract_Virtual_New_Stream_StandardFileType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00043C44 File Offset: 0x00041E44
		[CallerCount(0)]
		public unsafe virtual string IO_OS_GetTempFilename()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00043C88 File Offset: 0x00041E88
		[CallerCount(0)]
		public unsafe virtual void OS_ExitFast(int exitCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_OS_ExitFast_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00043CD4 File Offset: 0x00041ED4
		[CallerCount(0)]
		public unsafe virtual bool OS_FileExists(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_OS_FileExists_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00043D2C File Offset: 0x00041F2C
		[CallerCount(0)]
		public unsafe virtual void OS_FileDelete(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_OS_FileDelete_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00043D7C File Offset: 0x00041F7C
		[CallerCount(0)]
		public unsafe virtual void OS_FileMove(string src, string dst)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_OS_FileMove_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00043DDC File Offset: 0x00041FDC
		[CallerCount(0)]
		public unsafe virtual int OS_Execute(string cmdline)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cmdline);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_OS_Execute_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00043E34 File Offset: 0x00042034
		[CallerCount(0)]
		public unsafe virtual CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Abstract_Virtual_New_CoreModules_CoreModules_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CoreModules>(intPtr3) : null;
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00043E90 File Offset: 0x00042090
		[CallerCount(0)]
		public unsafe virtual string GetEnvironmentVariable(string envvarname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(envvarname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00043EE4 File Offset: 0x000420E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRunningOnAOT()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformAccessorBase.NativeMethodInfoPtr_IsRunningOnAOT_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000058EB File Offset: 0x00003AEB
		public PlatformAccessorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformNamePrefix_Public_Abstract_Virtual_New_String_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformName_Public_Virtual_Final_New_String_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_GetUnityRuntimeName_Private_String_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_GetUnityPlatformName_Private_String_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_DefaultPrint_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_DefaultInput_Public_Virtual_New_String_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_DefaultInput_Public_Virtual_New_String_String_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_IO_OpenFile_Public_Abstract_Virtual_New_Stream_Script_String_Encoding_String_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_IO_GetStandardStream_Public_Abstract_Virtual_New_Stream_StandardFileType_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Abstract_Virtual_New_String_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_OS_ExitFast_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileExists_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileDelete_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileMove_Public_Abstract_Virtual_New_Void_String_String_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_OS_Execute_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Abstract_Virtual_New_CoreModules_CoreModules_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariable_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_IsRunningOnAOT_Public_Virtual_New_Boolean_0;
	}
}
