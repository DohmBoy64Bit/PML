using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class DynamicExpressionException : ScriptRuntimeException
	{
		// Token: 0x060007A0 RID: 1952 RVA: 0x00032D88 File Offset: 0x00030F88
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicExpressionException()
		{
			Il2CppClassPointerStore<DynamicExpressionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "DynamicExpressionException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicExpressionException>.NativeClassPtr);
			DynamicExpressionException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpressionException>.NativeClassPtr, 100664757);
			DynamicExpressionException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicExpressionException>.NativeClassPtr, 100664758);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00032DE0 File Offset: 0x00030FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24635, XrefRangeEnd = 24639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicExpressionException(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicExpressionException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExpressionException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00032E4C File Offset: 0x0003104C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 24646, RefRangeEnd = 24649, XrefRangeStart = 24639, XrefRangeEnd = 24646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicExpressionException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicExpressionException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicExpressionException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00003EA7 File Offset: 0x000020A7
		public DynamicExpressionException(string format, params Object[] args)
			: this(format, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00003EB6 File Offset: 0x000020B6
		public DynamicExpressionException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
