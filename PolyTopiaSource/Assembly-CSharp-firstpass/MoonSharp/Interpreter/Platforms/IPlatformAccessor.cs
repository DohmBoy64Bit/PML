using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x02000089 RID: 137
	public class IPlatformAccessor : Object
	{
		// Token: 0x06000BAC RID: 2988 RVA: 0x00042C04 File Offset: 0x00040E04
		// Note: this type is marked as 'beforefieldinit'.
		static IPlatformAccessor()
		{
			Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Platforms", "IPlatformAccessor");
			IPlatformAccessor.NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Abstract_Virtual_New_CoreModules_CoreModules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665304);
			IPlatformAccessor.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665305);
			IPlatformAccessor.NativeMethodInfoPtr_IsRunningOnAOT_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665306);
			IPlatformAccessor.NativeMethodInfoPtr_GetPlatformName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665307);
			IPlatformAccessor.NativeMethodInfoPtr_DefaultPrint_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665308);
			IPlatformAccessor.NativeMethodInfoPtr_DefaultInput_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665309);
			IPlatformAccessor.NativeMethodInfoPtr_IO_OpenFile_Public_Abstract_Virtual_New_Stream_Script_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665310);
			IPlatformAccessor.NativeMethodInfoPtr_IO_GetStandardStream_Public_Abstract_Virtual_New_Stream_StandardFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665311);
			IPlatformAccessor.NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665312);
			IPlatformAccessor.NativeMethodInfoPtr_OS_ExitFast_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665313);
			IPlatformAccessor.NativeMethodInfoPtr_OS_FileExists_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665314);
			IPlatformAccessor.NativeMethodInfoPtr_OS_FileDelete_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665315);
			IPlatformAccessor.NativeMethodInfoPtr_OS_FileMove_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665316);
			IPlatformAccessor.NativeMethodInfoPtr_OS_Execute_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformAccessor>.NativeClassPtr, 100665317);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00042D44 File Offset: 0x00040F44
		[CallerCount(0)]
		public unsafe virtual CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Abstract_Virtual_New_CoreModules_CoreModules_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CoreModules>(intPtr3) : null;
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00042DA0 File Offset: 0x00040FA0
		[CallerCount(0)]
		public unsafe virtual string GetEnvironmentVariable(string envvarname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(envvarname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00042DF4 File Offset: 0x00040FF4
		[CallerCount(0)]
		public unsafe virtual bool IsRunningOnAOT()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_IsRunningOnAOT_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00042E3C File Offset: 0x0004103C
		[CallerCount(0)]
		public unsafe virtual string GetPlatformName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_GetPlatformName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00042E80 File Offset: 0x00041080
		[CallerCount(0)]
		public unsafe virtual void DefaultPrint(string content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_DefaultPrint_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00042ED0 File Offset: 0x000410D0
		[CallerCount(0)]
		public unsafe virtual string DefaultInput(string prompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_DefaultInput_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00042F24 File Offset: 0x00041124
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_IO_OpenFile_Public_Abstract_Virtual_New_Stream_Script_String_Encoding_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00042FB8 File Offset: 0x000411B8
		[CallerCount(0)]
		public unsafe virtual Stream IO_GetStandardStream(StandardFileType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_IO_GetStandardStream_Public_Abstract_Virtual_New_Stream_StandardFileType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00043014 File Offset: 0x00041214
		[CallerCount(0)]
		public unsafe virtual string IO_OS_GetTempFilename()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00043058 File Offset: 0x00041258
		[CallerCount(0)]
		public unsafe virtual void OS_ExitFast(int exitCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_OS_ExitFast_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000430A4 File Offset: 0x000412A4
		[CallerCount(0)]
		public unsafe virtual bool OS_FileExists(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_OS_FileExists_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000430FC File Offset: 0x000412FC
		[CallerCount(0)]
		public unsafe virtual void OS_FileDelete(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_OS_FileDelete_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0004314C File Offset: 0x0004134C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_OS_FileMove_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000431AC File Offset: 0x000413AC
		[CallerCount(0)]
		public unsafe virtual int OS_Execute(string cmdline)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cmdline);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformAccessor.NativeMethodInfoPtr_OS_Execute_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x000058D9 File Offset: 0x00003AD9
		public IPlatformAccessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_FilterSupportedCoreModules_Public_Abstract_Virtual_New_CoreModules_CoreModules_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariable_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_IsRunningOnAOT_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformName_Public_Abstract_Virtual_New_String_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_DefaultPrint_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_DefaultInput_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_IO_OpenFile_Public_Abstract_Virtual_New_Stream_Script_String_Encoding_String_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_IO_GetStandardStream_Public_Abstract_Virtual_New_Stream_StandardFileType_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_IO_OS_GetTempFilename_Public_Abstract_Virtual_New_String_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_OS_ExitFast_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileExists_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileDelete_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_OS_FileMove_Public_Abstract_Virtual_New_Void_String_String_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_OS_Execute_Public_Abstract_Virtual_New_Int32_String_0;
	}
}
