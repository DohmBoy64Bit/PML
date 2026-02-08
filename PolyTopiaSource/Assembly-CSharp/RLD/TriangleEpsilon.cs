using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000164 RID: 356
	[StructLayout(2)]
	public struct TriangleEpsilon
	{
		// Token: 0x06001DD1 RID: 7633 RVA: 0x000973A4 File Offset: 0x000955A4
		// Note: this type is marked as 'beforefieldinit'.
		static TriangleEpsilon()
		{
			Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TriangleEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr);
			TriangleEpsilon.NativeFieldInfoPtr__areaEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, "_areaEps");
			TriangleEpsilon.NativeFieldInfoPtr__extrudeEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, "_extrudeEps");
			TriangleEpsilon.NativeFieldInfoPtr__wireEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, "_wireEps");
			TriangleEpsilon.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, 100667828);
			TriangleEpsilon.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, 100667829);
			TriangleEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, 100667830);
			TriangleEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, 100667831);
			TriangleEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, 100667832);
			TriangleEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, 100667833);
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00097488 File Offset: 0x00095688
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x000974B8 File Offset: 0x000956B8
		public unsafe float AreaEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleEpsilon.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleEpsilon.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x000974EC File Offset: 0x000956EC
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0009751C File Offset: 0x0009571C
		public unsafe float ExtrudeEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00097550 File Offset: 0x00095750
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x00097580 File Offset: 0x00095780
		public unsafe float WireEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80247, RefRangeEnd = 80248, XrefRangeStart = 80247, XrefRangeEnd = 80248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 80248, RefRangeEnd = 80257, XrefRangeStart = 80248, XrefRangeEnd = 80257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriangleEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0000C557 File Offset: 0x0000A757
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriangleEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeFieldInfoPtr__areaEps;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeFieldInfoPtr__extrudeEps;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeFieldInfoPtr__wireEps;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001742 RID: 5954
		[FieldOffset(0)]
		public float _areaEps;

		// Token: 0x04001743 RID: 5955
		[FieldOffset(4)]
		public float _extrudeEps;

		// Token: 0x04001744 RID: 5956
		[FieldOffset(8)]
		public float _wireEps;
	}
}
