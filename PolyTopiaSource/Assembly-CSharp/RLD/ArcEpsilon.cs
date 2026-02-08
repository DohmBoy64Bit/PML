using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000160 RID: 352
	[StructLayout(2)]
	public struct ArcEpsilon
	{
		// Token: 0x06001DAB RID: 7595 RVA: 0x000969A4 File Offset: 0x00094BA4
		// Note: this type is marked as 'beforefieldinit'.
		static ArcEpsilon()
		{
			Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ArcEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr);
			ArcEpsilon.NativeFieldInfoPtr__areaEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, "_areaEps");
			ArcEpsilon.NativeFieldInfoPtr__extrudeEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, "_extrudeEps");
			ArcEpsilon.NativeFieldInfoPtr__wireEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, "_wireEps");
			ArcEpsilon.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, 100667798);
			ArcEpsilon.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, 100667799);
			ArcEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, 100667800);
			ArcEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, 100667801);
			ArcEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, 100667802);
			ArcEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, 100667803);
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00096A88 File Offset: 0x00094C88
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x00096AB8 File Offset: 0x00094CB8
		public unsafe float AreaEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcEpsilon.NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcEpsilon.NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x00096AEC File Offset: 0x00094CEC
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x00096B1C File Offset: 0x00094D1C
		public unsafe float ExtrudeEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00096B50 File Offset: 0x00094D50
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x00096B80 File Offset: 0x00094D80
		public unsafe float WireEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80247, RefRangeEnd = 80248, XrefRangeStart = 80247, XrefRangeEnd = 80248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArcEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0000C50F File Offset: 0x0000A70F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArcEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeFieldInfoPtr__areaEps;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeFieldInfoPtr__extrudeEps;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeFieldInfoPtr__wireEps;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr_get_AreaEps_Public_get_Single_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr_set_AreaEps_Public_set_Void_Single_0;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x0400170A RID: 5898
		[FieldOffset(0)]
		public float _areaEps;

		// Token: 0x0400170B RID: 5899
		[FieldOffset(4)]
		public float _extrudeEps;

		// Token: 0x0400170C RID: 5900
		[FieldOffset(8)]
		public float _wireEps;
	}
}
