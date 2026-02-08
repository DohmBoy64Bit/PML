using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using MoonSharp.Interpreter.CoreLib.IO;
using MoonSharp.Interpreter.Platforms;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x0200010E RID: 270
	public class IoModule : Object
	{
		// Token: 0x06001431 RID: 5169 RVA: 0x00068B18 File Offset: 0x00066D18
		// Note: this type is marked as 'beforefieldinit'.
		static IoModule()
		{
			Il2CppClassPointerStore<IoModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib", "IoModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IoModule>.NativeClassPtr);
			IoModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666864);
			IoModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666842);
			IoModule.NativeMethodInfoPtr___index_callback_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666843);
			IoModule.NativeMethodInfoPtr_GetStandardFile_Private_Static_DynValue_Script_StandardFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666844);
			IoModule.NativeMethodInfoPtr_SetStandardFile_Private_Static_Void_Script_StandardFileType_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666845);
			IoModule.NativeMethodInfoPtr_GetDefaultFile_Private_Static_FileUserDataBase_ScriptExecutionContext_StandardFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666846);
			IoModule.NativeMethodInfoPtr_SetDefaultFile_Private_Static_Void_ScriptExecutionContext_StandardFileType_FileUserDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666847);
			IoModule.NativeMethodInfoPtr_SetDefaultFile_Internal_Static_Void_Script_StandardFileType_FileUserDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666848);
			IoModule.NativeMethodInfoPtr_SetDefaultFile_Public_Static_Void_Script_StandardFileType_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666849);
			IoModule.NativeMethodInfoPtr_close_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666850);
			IoModule.NativeMethodInfoPtr_flush_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666851);
			IoModule.NativeMethodInfoPtr_input_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666852);
			IoModule.NativeMethodInfoPtr_output_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666853);
			IoModule.NativeMethodInfoPtr_HandleDefaultStreamSetter_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_StandardFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666854);
			IoModule.NativeMethodInfoPtr_GetUTF8Encoding_Private_Static_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666855);
			IoModule.NativeMethodInfoPtr_lines_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666856);
			IoModule.NativeMethodInfoPtr_open_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666857);
			IoModule.NativeMethodInfoPtr_IoExceptionToLuaMessage_Public_Static_String_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666858);
			IoModule.NativeMethodInfoPtr_type_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666859);
			IoModule.NativeMethodInfoPtr_read_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666860);
			IoModule.NativeMethodInfoPtr_write_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666861);
			IoModule.NativeMethodInfoPtr_tmpfile_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666862);
			IoModule.NativeMethodInfoPtr_Open_Private_Static_FileUserDataBase_ScriptExecutionContext_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule>.NativeClassPtr, 100666863);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00068D14 File Offset: 0x00066F14
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IoModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IoModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00068D50 File Offset: 0x00066F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47737, XrefRangeEnd = 47835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoonSharpInit(Table globalTable, Table ioTable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(globalTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ioTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00068D98 File Offset: 0x00066F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47835, XrefRangeEnd = 47862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue __index_callback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr___index_callback_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00068DF0 File Offset: 0x00066FF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 47869, RefRangeEnd = 47872, XrefRangeStart = 47862, XrefRangeEnd = 47869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue GetStandardFile(Script S, StandardFileType file)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(S);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(file);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_GetStandardFile_Private_Static_DynValue_Script_StandardFileType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00068E48 File Offset: 0x00067048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47872, XrefRangeEnd = 47897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStandardFile(Script S, StandardFileType file, Stream optionsStream)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(S);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(file);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionsStream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_SetStandardFile_Private_Static_Void_Script_StandardFileType_Stream_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00068EA4 File Offset: 0x000670A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 47918, RefRangeEnd = 47923, XrefRangeStart = 47897, XrefRangeEnd = 47918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileUserDataBase GetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(file);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_GetDefaultFile_Private_Static_FileUserDataBase_ScriptExecutionContext_StandardFileType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileUserDataBase>(intPtr3) : null;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00068EFC File Offset: 0x000670FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47923, XrefRangeEnd = 47926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file, FileUserDataBase fileHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(file);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fileHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_SetDefaultFile_Private_Static_Void_ScriptExecutionContext_StandardFileType_FileUserDataBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00068F58 File Offset: 0x00067158
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 47937, RefRangeEnd = 47940, XrefRangeStart = 47926, XrefRangeEnd = 47937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultFile(Script script, StandardFileType file, FileUserDataBase fileHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(file);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fileHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_SetDefaultFile_Internal_Static_Void_Script_StandardFileType_FileUserDataBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00068FB4 File Offset: 0x000671B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47940, XrefRangeEnd = 47944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultFile(Script script, StandardFileType file, Stream stream)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(file);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_SetDefaultFile_Public_Static_Void_Script_StandardFileType_Stream_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00069010 File Offset: 0x00067210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47944, XrefRangeEnd = 47952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue close(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_close_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00069068 File Offset: 0x00067268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47952, XrefRangeEnd = 47965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue flush(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_flush_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000690C0 File Offset: 0x000672C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47965, XrefRangeEnd = 47966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue input(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_input_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00069118 File Offset: 0x00067318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47966, XrefRangeEnd = 47967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue output(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_output_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00069170 File Offset: 0x00067370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47999, RefRangeEnd = 48001, XrefRangeStart = 47967, XrefRangeEnd = 47999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue HandleDefaultStreamSetter(ScriptExecutionContext executionContext, CallbackArguments args, StandardFileType defaultFiles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultFiles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_HandleDefaultStreamSetter_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_StandardFileType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000691D8 File Offset: 0x000673D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48005, RefRangeEnd = 48006, XrefRangeStart = 48001, XrefRangeEnd = 48005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetUTF8Encoding()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_GetUTF8Encoding_Private_Static_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0006920C File Offset: 0x0006740C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48006, XrefRangeEnd = 48088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_lines_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00069264 File Offset: 0x00067464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48088, XrefRangeEnd = 48170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue open(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_open_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000692BC File Offset: 0x000674BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48176, RefRangeEnd = 48177, XrefRangeStart = 48170, XrefRangeEnd = 48176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IoExceptionToLuaMessage(Exception ex, string filename)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_IoExceptionToLuaMessage_Public_Static_String_Exception_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0006930C File Offset: 0x0006750C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48177, XrefRangeEnd = 48198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue type(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_type_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00069364 File Offset: 0x00067564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48198, XrefRangeEnd = 48201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue read(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_read_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000693BC File Offset: 0x000675BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48201, XrefRangeEnd = 48204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue write(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_write_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00069414 File Offset: 0x00067614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48204, XrefRangeEnd = 48230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue tmpfile(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_tmpfile_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0006946C File Offset: 0x0006766C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48235, RefRangeEnd = 48236, XrefRangeStart = 48230, XrefRangeEnd = 48235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileUserDataBase Open(ScriptExecutionContext executionContext, string filename, Encoding encoding, string mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.NativeMethodInfoPtr_Open_Private_Static_FileUserDataBase_ScriptExecutionContext_String_Encoding_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileUserDataBase>(intPtr3) : null;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0000818D File Offset: 0x0000638D
		public IoModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharpInit_Public_Static_Void_Table_Table_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr___index_callback_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardFile_Private_Static_DynValue_Script_StandardFileType_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_SetStandardFile_Private_Static_Void_Script_StandardFileType_Stream_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultFile_Private_Static_FileUserDataBase_ScriptExecutionContext_StandardFileType_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFile_Private_Static_Void_ScriptExecutionContext_StandardFileType_FileUserDataBase_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFile_Internal_Static_Void_Script_StandardFileType_FileUserDataBase_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFile_Public_Static_Void_Script_StandardFileType_Stream_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_close_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_flush_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_input_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_output_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_HandleDefaultStreamSetter_Private_Static_DynValue_ScriptExecutionContext_CallbackArguments_StandardFileType_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF8Encoding_Private_Static_Encoding_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_lines_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_open_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_IoExceptionToLuaMessage_Public_Static_String_Exception_String_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_type_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_read_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_write_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_tmpfile_Public_Static_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Static_FileUserDataBase_ScriptExecutionContext_String_Encoding_String_0;

		// Token: 0x020001EA RID: 490
		[ObfuscatedName("MoonSharp.Interpreter.CoreLib.IoModule+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D51 RID: 7505 RVA: 0x0008C3B8 File Offset: 0x0008A5B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IoModule.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IoModule>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IoModule.__c>.NativeClassPtr);
				IoModule.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IoModule.__c>.NativeClassPtr, "<>9");
				IoModule.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IoModule.__c>.NativeClassPtr, "<>9__14_0");
				IoModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule.__c>.NativeClassPtr, 100666866);
				IoModule.__c.NativeMethodInfoPtr__lines_b__14_0_Internal_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IoModule.__c>.NativeClassPtr, 100666867);
			}

			// Token: 0x06001D52 RID: 7506 RVA: 0x0008C434 File Offset: 0x0008A634
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IoModule.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D53 RID: 7507 RVA: 0x0008C470 File Offset: 0x0008A670
			[CallerCount(0)]
			public unsafe DynValue _lines_b__14_0(DynValue s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IoModule.__c.NativeMethodInfoPtr__lines_b__14_0_Internal_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
				}
			}

			// Token: 0x06001D54 RID: 7508 RVA: 0x0000B9C2 File Offset: 0x00009BC2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0008C4C0 File Offset: 0x0008A6C0
			// (set) Token: 0x06001D56 RID: 7510 RVA: 0x0000B9CB File Offset: 0x00009BCB
			public unsafe static IoModule.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IoModule.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IoModule.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IoModule.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x06001D57 RID: 7511 RVA: 0x0008C4E8 File Offset: 0x0008A6E8
			// (set) Token: 0x06001D58 RID: 7512 RVA: 0x0000B9DD File Offset: 0x00009BDD
			public unsafe static Func<DynValue, DynValue> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IoModule.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynValue, DynValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IoModule.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001761 RID: 5985
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001762 RID: 5986
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04001763 RID: 5987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001764 RID: 5988
			private static readonly IntPtr NativeMethodInfoPtr__lines_b__14_0_Internal_DynValue_DynValue_0;
		}
	}
}
