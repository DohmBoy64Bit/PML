using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DentedPixel
{
	// Token: 0x02000128 RID: 296
	public class LeanDummy : Object
	{
		// Token: 0x060015C0 RID: 5568 RVA: 0x0000851B File Offset: 0x0000671B
		// Note: this type is marked as 'beforefieldinit'.
		static LeanDummy()
		{
			Il2CppClassPointerStore<LeanDummy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "DentedPixel", "LeanDummy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanDummy>.NativeClassPtr);
			LeanDummy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanDummy>.NativeClassPtr, 100667186);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0007116C File Offset: 0x0006F36C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeanDummy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanDummy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanDummy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00008554 File Offset: 0x00006754
		public LeanDummy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
