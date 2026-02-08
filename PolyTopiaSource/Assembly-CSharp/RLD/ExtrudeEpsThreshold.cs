using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000158 RID: 344
	public static class ExtrudeEpsThreshold : Object
	{
		// Token: 0x06001D80 RID: 7552 RVA: 0x0000C44F File Offset: 0x0000A64F
		// Note: this type is marked as 'beforefieldinit'.
		static ExtrudeEpsThreshold()
		{
			Il2CppClassPointerStore<ExtrudeEpsThreshold>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ExtrudeEpsThreshold");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtrudeEpsThreshold>.NativeClassPtr);
			ExtrudeEpsThreshold.NativeMethodInfoPtr_get_Get_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtrudeEpsThreshold>.NativeClassPtr, 100667771);
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00096038 File Offset: 0x00094238
		public unsafe static float Get
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 80196, RefRangeEnd = 80200, XrefRangeStart = 80196, XrefRangeEnd = 80196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtrudeEpsThreshold.NativeMethodInfoPtr_get_Get_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0000C488 File Offset: 0x0000A688
		public ExtrudeEpsThreshold(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_get_Get_Public_Static_get_Single_0;
	}
}
