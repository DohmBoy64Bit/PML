using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SimpleJSON
{
	// Token: 0x02000024 RID: 36
	public static class JSON : Object
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x000035D2 File Offset: 0x000017D2
		// Note: this type is marked as 'beforefieldinit'.
		static JSON()
		{
			Il2CppClassPointerStore<JSON>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SimpleJSON", "JSON");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSON>.NativeClassPtr);
			JSON.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100664426);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0002B5CC File Offset: 0x000297CC
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 20826, RefRangeEnd = 20855, XrefRangeStart = 20825, XrefRangeEnd = 20826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode Parse(string aJSON)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aJSON);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000360B File Offset: 0x0000180B
		public JSON(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0;
	}
}
