using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;

namespace MoonSharp.Interpreter.CoreLib.IO
{
	// Token: 0x0200011D RID: 285
	public class FileUserData : StreamFileUserDataBase
	{
		// Token: 0x0600152E RID: 5422 RVA: 0x00008359 File Offset: 0x00006559
		// Note: this type is marked as 'beforefieldinit'.
		static FileUserData()
		{
			Il2CppClassPointerStore<FileUserData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib.IO", "FileUserData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileUserData>.NativeClassPtr);
			FileUserData.NativeMethodInfoPtr__ctor_Public_Void_Script_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserData>.NativeClassPtr, 100667072);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0006DFB8 File Offset: 0x0006C1B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 51369, RefRangeEnd = 51372, XrefRangeStart = 51344, XrefRangeEnd = 51369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileUserData(Script script, string filename, Encoding encoding, string mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileUserData>.NativeClassPtr))
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileUserData.NativeMethodInfoPtr__ctor_Public_Void_Script_String_Encoding_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00008392 File Offset: 0x00006592
		public FileUserData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Script_String_Encoding_String_0;
	}
}
