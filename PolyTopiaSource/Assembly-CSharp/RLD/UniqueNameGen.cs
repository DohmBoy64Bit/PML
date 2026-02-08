using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x02000212 RID: 530
	public static class UniqueNameGen : Object
	{
		// Token: 0x060029E2 RID: 10722 RVA: 0x0001082B File Offset: 0x0000EA2B
		// Note: this type is marked as 'beforefieldinit'.
		static UniqueNameGen()
		{
			Il2CppClassPointerStore<UniqueNameGen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "UniqueNameGen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniqueNameGen>.NativeClassPtr);
			UniqueNameGen.NativeMethodInfoPtr_Generate_Public_Static_String_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueNameGen>.NativeClassPtr, 100669698);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000C7400 File Offset: 0x000C5600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93137, RefRangeEnd = 93139, XrefRangeStart = 93113, XrefRangeEnd = 93137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Generate(string desiredName, IEnumerable<string> existingNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(desiredName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueNameGen.NativeMethodInfoPtr_Generate_Public_Static_String_String_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00010864 File Offset: 0x0000EA64
		public UniqueNameGen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Static_String_String_IEnumerable_1_String_0;
	}
}
