using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.Converters
{
	// Token: 0x020000D2 RID: 210
	public static class StringConversions : Object
	{
		// Token: 0x06001050 RID: 4176 RVA: 0x000576A4 File Offset: 0x000558A4
		// Note: this type is marked as 'beforefieldinit'.
		static StringConversions()
		{
			Il2CppClassPointerStore<StringConversions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.Converters", "StringConversions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringConversions>.NativeClassPtr);
			StringConversions.NativeMethodInfoPtr_GetStringSubtype_Internal_Static_StringSubtype_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConversions>.NativeClassPtr, 100666198);
			StringConversions.NativeMethodInfoPtr_ConvertString_Internal_Static_Object_StringSubtype_String_Type_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConversions>.NativeClassPtr, 100666199);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x000576FC File Offset: 0x000558FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41708, RefRangeEnd = 41710, XrefRangeStart = 41692, XrefRangeEnd = 41708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringConversions.StringSubtype GetStringSubtype(Type desiredType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConversions.NativeMethodInfoPtr_GetStringSubtype_Internal_Static_StringSubtype_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00057740 File Offset: 0x00055940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41710, XrefRangeEnd = 41715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ConvertString(StringConversions.StringSubtype stringSubType, string str, Type desiredType, DataType dataType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringSubType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConversions.NativeMethodInfoPtr_ConvertString_Internal_Static_Object_StringSubtype_String_Type_DataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00006DCE File Offset: 0x00004FCE
		public StringConversions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_GetStringSubtype_Internal_Static_StringSubtype_Type_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_ConvertString_Internal_Static_Object_StringSubtype_String_Type_DataType_0;

		// Token: 0x020001D6 RID: 470
		public enum StringSubtype
		{
			// Token: 0x040016E9 RID: 5865
			None,
			// Token: 0x040016EA RID: 5866
			String,
			// Token: 0x040016EB RID: 5867
			StringBuilder,
			// Token: 0x040016EC RID: 5868
			Char
		}
	}
}
