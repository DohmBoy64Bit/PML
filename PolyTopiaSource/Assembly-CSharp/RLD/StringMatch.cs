using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x02000211 RID: 529
	public static class StringMatch : Object
	{
		// Token: 0x060029DF RID: 10719 RVA: 0x000107E9 File Offset: 0x0000E9E9
		// Note: this type is marked as 'beforefieldinit'.
		static StringMatch()
		{
			Il2CppClassPointerStore<StringMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "StringMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringMatch>.NativeClassPtr);
			StringMatch.NativeMethodInfoPtr_Match_Public_Static_Void_List_1_String_String_Case_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringMatch>.NativeClassPtr, 100669697);
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000C7398 File Offset: 0x000C5598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93112, RefRangeEnd = 93113, XrefRangeStart = 93076, XrefRangeEnd = 93112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Match(List<string> strings, string stringToMatch, StringMatch.Case matchCase, List<string> matches)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringToMatch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matches);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringMatch.NativeMethodInfoPtr_Match_Public_Static_Void_List_1_String_String_Case_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x00010822 File Offset: 0x0000EA22
		public StringMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Static_Void_List_1_String_String_Case_List_1_String_0;

		// Token: 0x020003D2 RID: 978
		public enum Case
		{
			// Token: 0x04003BB2 RID: 15282
			Sensitive,
			// Token: 0x04003BB3 RID: 15283
			Insensitive
		}
	}
}
