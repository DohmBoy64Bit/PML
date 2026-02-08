using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.CoreLib.IO
{
	// Token: 0x0200011E RID: 286
	public class FileUserDataBase : RefIdObject
	{
		// Token: 0x06001531 RID: 5425 RVA: 0x0006E03C File Offset: 0x0006C23C
		// Note: this type is marked as 'beforefieldinit'.
		static FileUserDataBase()
		{
			Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib.IO", "FileUserDataBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr);
			FileUserDataBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667091);
			FileUserDataBase.NativeMethodInfoPtr_lines_Public_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667073);
			FileUserDataBase.NativeMethodInfoPtr_read_Public_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667074);
			FileUserDataBase.NativeMethodInfoPtr_write_Public_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667075);
			FileUserDataBase.NativeMethodInfoPtr_close_Public_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667076);
			FileUserDataBase.NativeMethodInfoPtr_ReadNumber_Private_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667077);
			FileUserDataBase.NativeMethodInfoPtr_IsNumericChar_Private_Boolean_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667078);
			FileUserDataBase.NativeMethodInfoPtr_Eof_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667079);
			FileUserDataBase.NativeMethodInfoPtr_ReadLine_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667080);
			FileUserDataBase.NativeMethodInfoPtr_ReadBuffer_Protected_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667081);
			FileUserDataBase.NativeMethodInfoPtr_ReadToEnd_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667082);
			FileUserDataBase.NativeMethodInfoPtr_Peek_Protected_Abstract_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667083);
			FileUserDataBase.NativeMethodInfoPtr_Write_Protected_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667084);
			FileUserDataBase.NativeMethodInfoPtr_isopen_FamOrAssem_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667085);
			FileUserDataBase.NativeMethodInfoPtr_Close_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667086);
			FileUserDataBase.NativeMethodInfoPtr_flush_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667087);
			FileUserDataBase.NativeMethodInfoPtr_seek_Public_Abstract_Virtual_New_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667088);
			FileUserDataBase.NativeMethodInfoPtr_setvbuf_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667089);
			FileUserDataBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, 100667090);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0006E1E8 File Offset: 0x0006C3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51372, XrefRangeEnd = 51373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileUserDataBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserDataBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0006E224 File Offset: 0x0006C424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51373, XrefRangeEnd = 51411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserDataBase.NativeMethodInfoPtr_lines_Public_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0006E288 File Offset: 0x0006C488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51483, RefRangeEnd = 51485, XrefRangeStart = 51411, XrefRangeEnd = 51483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue read(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserDataBase.NativeMethodInfoPtr_read_Public_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0006E2EC File Offset: 0x0006C4EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51504, RefRangeEnd = 51505, XrefRangeStart = 51485, XrefRangeEnd = 51504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue write(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserDataBase.NativeMethodInfoPtr_write_Public_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0006E350 File Offset: 0x0006C550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51536, RefRangeEnd = 51537, XrefRangeStart = 51505, XrefRangeEnd = 51536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue close(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserDataBase.NativeMethodInfoPtr_close_Public_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0006E3B4 File Offset: 0x0006C5B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51552, RefRangeEnd = 51553, XrefRangeStart = 51537, XrefRangeEnd = 51552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<double> ReadNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserDataBase.NativeMethodInfoPtr_ReadNumber_Private_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<double>>(intPtr3) : null;
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0006E3F4 File Offset: 0x0006C5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51560, RefRangeEnd = 51561, XrefRangeStart = 51553, XrefRangeEnd = 51560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNumericChar(char c, string numAsFar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(numAsFar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserDataBase.NativeMethodInfoPtr_IsNumericChar_Private_Boolean_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0006E450 File Offset: 0x0006C650
		[CallerCount(0)]
		public unsafe virtual bool Eof()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_Eof_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0006E498 File Offset: 0x0006C698
		[CallerCount(0)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_ReadLine_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0006E4DC File Offset: 0x0006C6DC
		[CallerCount(0)]
		public unsafe virtual string ReadBuffer(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_ReadBuffer_Protected_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0006E52C File Offset: 0x0006C72C
		[CallerCount(0)]
		public unsafe virtual string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_ReadToEnd_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0006E570 File Offset: 0x0006C770
		[CallerCount(0)]
		public unsafe virtual char Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_Peek_Protected_Abstract_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0006E5B8 File Offset: 0x0006C7B8
		[CallerCount(0)]
		public unsafe virtual void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_Write_Protected_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0006E608 File Offset: 0x0006C808
		[CallerCount(0)]
		public unsafe virtual bool isopen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_isopen_FamOrAssem_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0006E650 File Offset: 0x0006C850
		[CallerCount(0)]
		public unsafe virtual string Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_Close_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0006E694 File Offset: 0x0006C894
		[CallerCount(0)]
		public unsafe virtual bool flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_flush_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0006E6DC File Offset: 0x0006C8DC
		[CallerCount(0)]
		public unsafe virtual long seek(string whence, long offset = 0L)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(whence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_seek_Public_Abstract_Virtual_New_Int64_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0006E744 File Offset: 0x0006C944
		[CallerCount(0)]
		public unsafe virtual bool setvbuf(string mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_setvbuf_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0006E79C File Offset: 0x0006C99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51561, XrefRangeEnd = 51564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileUserDataBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0000839B File Offset: 0x0000659B
		public FileUserDataBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_lines_Public_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_read_Public_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_write_Public_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_close_Public_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_ReadNumber_Private_Nullable_1_Double_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_IsNumericChar_Private_Boolean_Char_String_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_Eof_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Protected_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Protected_Abstract_Virtual_New_Char_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_Write_Protected_Abstract_Virtual_New_Void_String_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_isopen_FamOrAssem_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_flush_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeMethodInfoPtr_seek_Public_Abstract_Virtual_New_Int64_String_Int64_0;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeMethodInfoPtr_setvbuf_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020001F1 RID: 497
		[ObfuscatedName("MoonSharp.Interpreter.CoreLib.IO.FileUserDataBase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DD6 RID: 7638 RVA: 0x0008DC2C File Offset: 0x0008BE2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FileUserDataBase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileUserDataBase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileUserDataBase.__c>.NativeClassPtr);
				FileUserDataBase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserDataBase.__c>.NativeClassPtr, "<>9");
				FileUserDataBase.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserDataBase.__c>.NativeClassPtr, "<>9__0_0");
				FileUserDataBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase.__c>.NativeClassPtr, 100667093);
				FileUserDataBase.__c.NativeMethodInfoPtr__lines_b__0_0_Internal_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserDataBase.__c>.NativeClassPtr, 100667094);
			}

			// Token: 0x06001DD7 RID: 7639 RVA: 0x0008DCA8 File Offset: 0x0008BEA8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileUserDataBase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserDataBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DD8 RID: 7640 RVA: 0x0008DCE4 File Offset: 0x0008BEE4
			[CallerCount(0)]
			public unsafe DynValue _lines_b__0_0(DynValue s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserDataBase.__c.NativeMethodInfoPtr__lines_b__0_0_Internal_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x06001DD9 RID: 7641 RVA: 0x0000BD8E File Offset: 0x00009F8E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0008DD34 File Offset: 0x0008BF34
			// (set) Token: 0x06001DDB RID: 7643 RVA: 0x0000BD97 File Offset: 0x00009F97
			public unsafe static FileUserDataBase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FileUserDataBase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileUserDataBase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FileUserDataBase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x06001DDC RID: 7644 RVA: 0x0008DD5C File Offset: 0x0008BF5C
			// (set) Token: 0x06001DDD RID: 7645 RVA: 0x0000BDA9 File Offset: 0x00009FA9
			public unsafe static Func<DynValue, DynValue> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FileUserDataBase.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FileUserDataBase.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017AE RID: 6062
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040017AF RID: 6063
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x040017B0 RID: 6064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017B1 RID: 6065
			private static readonly IntPtr NativeMethodInfoPtr__lines_b__0_0_Internal_DynValue_DynValue_0;
		}
	}
}
