using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200015E RID: 350
	[StructLayout(2)]
	public struct PrismEpsilon
	{
		// Token: 0x06001DA3 RID: 7587 RVA: 0x00096804 File Offset: 0x00094A04
		// Note: this type is marked as 'beforefieldinit'.
		static PrismEpsilon()
		{
			Il2CppClassPointerStore<PrismEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrismEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrismEpsilon>.NativeClassPtr);
			PrismEpsilon.NativeFieldInfoPtr__ptContainEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrismEpsilon>.NativeClassPtr, "_ptContainEps");
			PrismEpsilon.NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrismEpsilon>.NativeClassPtr, 100667794);
			PrismEpsilon.NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrismEpsilon>.NativeClassPtr, 100667795);
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00096870 File Offset: 0x00094A70
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x000968A0 File Offset: 0x00094AA0
		public unsafe float PtContainEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrismEpsilon.NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 80206, RefRangeEnd = 80227, XrefRangeStart = 80206, XrefRangeEnd = 80227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrismEpsilon.NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x0000C4EB File Offset: 0x0000A6EB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrismEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr__ptContainEps;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeMethodInfoPtr_get_PtContainEps_Public_get_Single_0;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeMethodInfoPtr_set_PtContainEps_Public_set_Void_Single_0;

		// Token: 0x040016FC RID: 5884
		[FieldOffset(0)]
		public float _ptContainEps;
	}
}
