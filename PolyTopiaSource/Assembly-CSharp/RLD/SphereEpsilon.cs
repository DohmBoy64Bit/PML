using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000159 RID: 345
	[StructLayout(2)]
	public struct SphereEpsilon
	{
		// Token: 0x06001D83 RID: 7555 RVA: 0x00096068 File Offset: 0x00094268
		// Note: this type is marked as 'beforefieldinit'.
		static SphereEpsilon()
		{
			Il2CppClassPointerStore<SphereEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SphereEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphereEpsilon>.NativeClassPtr);
			SphereEpsilon.NativeFieldInfoPtr__radiusEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphereEpsilon>.NativeClassPtr, "_radiusEps");
			SphereEpsilon.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereEpsilon>.NativeClassPtr, 100667772);
			SphereEpsilon.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphereEpsilon>.NativeClassPtr, 100667773);
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x000960D4 File Offset: 0x000942D4
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x00096104 File Offset: 0x00094304
		public unsafe float RadiusEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereEpsilon.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 80206, RefRangeEnd = 80227, XrefRangeStart = 80206, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SphereEpsilon.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0000C491 File Offset: 0x0000A691
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SphereEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeFieldInfoPtr__radiusEps;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0;

		// Token: 0x040016D6 RID: 5846
		[FieldOffset(0)]
		public float _radiusEps;
	}
}
