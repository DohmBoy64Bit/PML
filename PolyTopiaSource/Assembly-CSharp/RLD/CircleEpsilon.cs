using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000161 RID: 353
	[StructLayout(2)]
	public struct CircleEpsilon
	{
		// Token: 0x06001DB3 RID: 7603 RVA: 0x00096BB4 File Offset: 0x00094DB4
		// Note: this type is marked as 'beforefieldinit'.
		static CircleEpsilon()
		{
			Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CircleEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr);
			CircleEpsilon.NativeFieldInfoPtr__radiusEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, "_radiusEps");
			CircleEpsilon.NativeFieldInfoPtr__extrudeEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, "_extrudeEps");
			CircleEpsilon.NativeFieldInfoPtr__wireEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, "_wireEps");
			CircleEpsilon.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, 100667804);
			CircleEpsilon.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, 100667805);
			CircleEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, 100667806);
			CircleEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, 100667807);
			CircleEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, 100667808);
			CircleEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, 100667809);
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00096C98 File Offset: 0x00094E98
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x00096CC8 File Offset: 0x00094EC8
		public unsafe float RadiusEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleEpsilon.NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleEpsilon.NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00096CFC File Offset: 0x00094EFC
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x00096D2C File Offset: 0x00094F2C
		public unsafe float ExtrudeEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00096D60 File Offset: 0x00094F60
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x00096D90 File Offset: 0x00094F90
		public unsafe float WireEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80247, RefRangeEnd = 80248, XrefRangeStart = 80247, XrefRangeEnd = 80248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0000C521 File Offset: 0x0000A721
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CircleEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeFieldInfoPtr__radiusEps;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeFieldInfoPtr__extrudeEps;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeFieldInfoPtr__wireEps;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeMethodInfoPtr_get_RadiusEps_Public_get_Single_0;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeMethodInfoPtr_set_RadiusEps_Public_set_Void_Single_0;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001716 RID: 5910
		[FieldOffset(0)]
		public float _radiusEps;

		// Token: 0x04001717 RID: 5911
		[FieldOffset(4)]
		public float _extrudeEps;

		// Token: 0x04001718 RID: 5912
		[FieldOffset(8)]
		public float _wireEps;
	}
}
