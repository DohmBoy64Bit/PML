using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000162 RID: 354
	[StructLayout(2)]
	public struct PolygonEpsilon
	{
		// Token: 0x06001DBB RID: 7611 RVA: 0x00096DC4 File Offset: 0x00094FC4
		// Note: this type is marked as 'beforefieldinit'.
		static PolygonEpsilon()
		{
			Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PolygonEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr);
			PolygonEpsilon.NativeFieldInfoPtr__areaEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, "_areaEps");
			PolygonEpsilon.NativeFieldInfoPtr__extrudeEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, "_extrudeEps");
			PolygonEpsilon.NativeFieldInfoPtr__wireEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, "_wireEps");
			PolygonEpsilon.NativeFieldInfoPtr__thickWireEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, "_thickWireEps");
			PolygonEpsilon.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, 100667810);
			PolygonEpsilon.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, 100667811);
			PolygonEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, 100667812);
			PolygonEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, 100667813);
			PolygonEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, 100667814);
			PolygonEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, 100667815);
			PolygonEpsilon.NativeMethodInfoPtr_get_ThickWireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, 100667816);
			PolygonEpsilon.NativeMethodInfoPtr_set_ThickWireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, 100667817);
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00096EE4 File Offset: 0x000950E4
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x00096F14 File Offset: 0x00095114
		public unsafe float AreaEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonEpsilon.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonEpsilon.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x00096F48 File Offset: 0x00095148
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x00096F78 File Offset: 0x00095178
		public unsafe float ExtrudeEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x00096FAC File Offset: 0x000951AC
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x00096FDC File Offset: 0x000951DC
		public unsafe float WireEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80247, RefRangeEnd = 80248, XrefRangeStart = 80247, XrefRangeEnd = 80248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00097010 File Offset: 0x00095210
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x00097040 File Offset: 0x00095240
		public unsafe float ThickWireEps
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonEpsilon.NativeMethodInfoPtr_get_ThickWireEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80257, RefRangeEnd = 80260, XrefRangeStart = 80257, XrefRangeEnd = 80257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonEpsilon.NativeMethodInfoPtr_set_ThickWireEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0000C533 File Offset: 0x0000A733
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PolygonEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr__areaEps;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeFieldInfoPtr__extrudeEps;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeFieldInfoPtr__wireEps;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeFieldInfoPtr__thickWireEps;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeMethodInfoPtr_get_ThickWireEps_Public_get_Single_0;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr_set_ThickWireEps_Public_set_Void_Single_0;

		// Token: 0x04001725 RID: 5925
		[FieldOffset(0)]
		public float _areaEps;

		// Token: 0x04001726 RID: 5926
		[FieldOffset(4)]
		public float _extrudeEps;

		// Token: 0x04001727 RID: 5927
		[FieldOffset(8)]
		public float _wireEps;

		// Token: 0x04001728 RID: 5928
		[FieldOffset(12)]
		public float _thickWireEps;
	}
}
