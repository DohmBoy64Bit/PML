using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200012E RID: 302
	public static class StringEx : Object
	{
		// Token: 0x06001BA5 RID: 7077 RVA: 0x0008D0C0 File Offset: 0x0008B2C0
		// Note: this type is marked as 'beforefieldinit'.
		static StringEx()
		{
			Il2CppClassPointerStore<StringEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "StringEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringEx>.NativeClassPtr);
			StringEx.NativeMethodInfoPtr_RemoveTrailingSlashes_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEx>.NativeClassPtr, 100667441);
			StringEx.NativeMethodInfoPtr_LastChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEx>.NativeClassPtr, 100667442);
			StringEx.NativeMethodInfoPtr_LastCharIndex_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEx>.NativeClassPtr, 100667443);
			StringEx.NativeMethodInfoPtr_ContainsOnlyWhiteSpace_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEx>.NativeClassPtr, 100667444);
			StringEx.NativeMethodInfoPtr_IsSingleDigit_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEx>.NativeClassPtr, 100667445);
			StringEx.NativeMethodInfoPtr_IsSingleLetter_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEx>.NativeClassPtr, 100667446);
			StringEx.NativeMethodInfoPtr_IsSingleChar_Public_Static_Boolean_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEx>.NativeClassPtr, 100667447);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0008D17C File Offset: 0x0008B37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77743, XrefRangeEnd = 77747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveTrailingSlashes(this string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEx.NativeMethodInfoPtr_RemoveTrailingSlashes_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0008D1B8 File Offset: 0x0008B3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77747, XrefRangeEnd = 77749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char LastChar(this string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEx.NativeMethodInfoPtr_LastChar_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0008D1FC File Offset: 0x0008B3FC
		[CallerCount(0)]
		public unsafe static int LastCharIndex(this string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEx.NativeMethodInfoPtr_LastCharIndex_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0008D240 File Offset: 0x0008B440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77749, XrefRangeEnd = 77754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsOnlyWhiteSpace(this string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEx.NativeMethodInfoPtr_ContainsOnlyWhiteSpace_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0008D284 File Offset: 0x0008B484
		[CallerCount(0)]
		public unsafe static bool IsSingleDigit(this string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEx.NativeMethodInfoPtr_IsSingleDigit_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0008D2C8 File Offset: 0x0008B4C8
		[CallerCount(0)]
		public unsafe static bool IsSingleLetter(this string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEx.NativeMethodInfoPtr_IsSingleLetter_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0008D30C File Offset: 0x0008B50C
		[CallerCount(0)]
		public unsafe static bool IsSingleChar(this string str, char character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref character;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEx.NativeMethodInfoPtr_IsSingleChar_Public_Static_Boolean_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0000BD8B File Offset: 0x00009F8B
		public StringEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrailingSlashes_Public_Static_String_String_0;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeMethodInfoPtr_LastChar_Public_Static_Char_String_0;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_LastCharIndex_Public_Static_Int32_String_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_ContainsOnlyWhiteSpace_Public_Static_Boolean_String_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_IsSingleDigit_Public_Static_Boolean_String_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_IsSingleLetter_Public_Static_Boolean_String_0;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_IsSingleChar_Public_Static_Boolean_String_Char_0;
	}
}
