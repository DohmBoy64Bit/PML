using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200015D RID: 349
	[StructLayout(2)]
	public struct SegmentEpsilon
	{
		// Token: 0x06001D9D RID: 7581 RVA: 0x00096694 File Offset: 0x00094894
		// Note: this type is marked as 'beforefieldinit'.
		static SegmentEpsilon()
		{
			Il2CppClassPointerStore<SegmentEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SegmentEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SegmentEpsilon>.NativeClassPtr);
			SegmentEpsilon.NativeFieldInfoPtr__raycastEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentEpsilon>.NativeClassPtr, "_raycastEps");
			SegmentEpsilon.NativeFieldInfoPtr__ptOnSegmentEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentEpsilon>.NativeClassPtr, "_ptOnSegmentEps");
			SegmentEpsilon.NativeMethodInfoPtr_get_RaycastEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentEpsilon>.NativeClassPtr, 100667790);
			SegmentEpsilon.NativeMethodInfoPtr_set_RaycastEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentEpsilon>.NativeClassPtr, 100667791);
			SegmentEpsilon.NativeMethodInfoPtr_get_PtOnSegmentEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentEpsilon>.NativeClassPtr, 100667792);
			SegmentEpsilon.NativeMethodInfoPtr_set_PtOnSegmentEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentEpsilon>.NativeClassPtr, 100667793);
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0009673C File Offset: 0x0009493C
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0009676C File Offset: 0x0009496C
		public unsafe float RaycastEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentEpsilon.NativeMethodInfoPtr_get_RaycastEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentEpsilon.NativeMethodInfoPtr_set_RaycastEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x000967A0 File Offset: 0x000949A0
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x000967D0 File Offset: 0x000949D0
		public unsafe float PtOnSegmentEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentEpsilon.NativeMethodInfoPtr_get_PtOnSegmentEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 80233, RefRangeEnd = 80246, XrefRangeStart = 80233, XrefRangeEnd = 80246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentEpsilon.NativeMethodInfoPtr_set_PtOnSegmentEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0000C4D9 File Offset: 0x0000A6D9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SegmentEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeFieldInfoPtr__raycastEps;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr__ptOnSegmentEps;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr_get_RaycastEps_Public_get_Single_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_set_RaycastEps_Public_set_Void_Single_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr_get_PtOnSegmentEps_Public_get_Single_0;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeMethodInfoPtr_set_PtOnSegmentEps_Public_set_Void_Single_0;

		// Token: 0x040016F7 RID: 5879
		[FieldOffset(0)]
		public float _raycastEps;

		// Token: 0x040016F8 RID: 5880
		[FieldOffset(4)]
		public float _ptOnSegmentEps;
	}
}
