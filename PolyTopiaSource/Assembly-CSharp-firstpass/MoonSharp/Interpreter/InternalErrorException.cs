using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	public class InternalErrorException : InterpreterException
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x00032E98 File Offset: 0x00031098
		// Note: this type is marked as 'beforefieldinit'.
		static InternalErrorException()
		{
			Il2CppClassPointerStore<InternalErrorException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "InternalErrorException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalErrorException>.NativeClassPtr);
			InternalErrorException.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalErrorException>.NativeClassPtr, 100664759);
			InternalErrorException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalErrorException>.NativeClassPtr, 100664760);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00032EF0 File Offset: 0x000310F0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 24653, RefRangeEnd = 24672, XrefRangeStart = 24649, XrefRangeEnd = 24653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalErrorException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalErrorException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalErrorException.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00032F3C File Offset: 0x0003113C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 24673, RefRangeEnd = 24691, XrefRangeStart = 24672, XrefRangeEnd = 24673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalErrorException(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalErrorException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalErrorException.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00003EBF File Offset: 0x000020BF
		public InternalErrorException(string format, params Object[] args)
			: this(format, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00003ECE File Offset: 0x000020CE
		public InternalErrorException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppReferenceArray_1_Object_0;
	}
}
