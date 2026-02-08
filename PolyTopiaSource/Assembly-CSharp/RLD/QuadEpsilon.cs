using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000163 RID: 355
	[StructLayout(2)]
	public struct QuadEpsilon
	{
		// Token: 0x06001DC5 RID: 7621 RVA: 0x00097074 File Offset: 0x00095274
		// Note: this type is marked as 'beforefieldinit'.
		static QuadEpsilon()
		{
			Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "QuadEpsilon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr);
			QuadEpsilon.NativeFieldInfoPtr__sizeEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, "_sizeEps");
			QuadEpsilon.NativeFieldInfoPtr__extrudeEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, "_extrudeEps");
			QuadEpsilon.NativeFieldInfoPtr__wireEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, "_wireEps");
			QuadEpsilon.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667818);
			QuadEpsilon.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667819);
			QuadEpsilon.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667820);
			QuadEpsilon.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667821);
			QuadEpsilon.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667822);
			QuadEpsilon.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667823);
			QuadEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667824);
			QuadEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667825);
			QuadEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667826);
			QuadEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, 100667827);
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x000971A8 File Offset: 0x000953A8
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x000971DC File Offset: 0x000953DC
		public unsafe Vector2 SizeEps
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_get_SizeEps_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 80260, RefRangeEnd = 80262, XrefRangeStart = 80260, XrefRangeEnd = 80260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x00097214 File Offset: 0x00095414
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x00097244 File Offset: 0x00095444
		public unsafe float WidthEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80200, RefRangeEnd = 80206, XrefRangeStart = 80200, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00097278 File Offset: 0x00095478
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x000972A8 File Offset: 0x000954A8
		public unsafe float HeightEps
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80233, XrefRangeStart = 80227, XrefRangeEnd = 80233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x000972DC File Offset: 0x000954DC
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0009730C File Offset: 0x0009550C
		public unsafe float ExtrudeEps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80247, RefRangeEnd = 80248, XrefRangeStart = 80247, XrefRangeEnd = 80248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x00097340 File Offset: 0x00095540
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x00097370 File Offset: 0x00095570
		public unsafe float WireEps
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_get_WireEps_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80257, RefRangeEnd = 80260, XrefRangeStart = 80257, XrefRangeEnd = 80260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuadEpsilon.NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0000C545 File Offset: 0x0000A745
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QuadEpsilon>.NativeClassPtr, ref this));
		}

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeFieldInfoPtr__sizeEps;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeFieldInfoPtr__extrudeEps;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeFieldInfoPtr__wireEps;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeEps_Public_get_Vector2_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeEps_Public_set_Void_Vector2_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_get_WidthEps_Public_get_Single_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_set_WidthEps_Public_set_Void_Single_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_get_HeightEps_Public_get_Single_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_set_HeightEps_Public_set_Void_Single_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeEps_Public_get_Single_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtrudeEps_Public_set_Void_Single_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr_get_WireEps_Public_get_Single_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_set_WireEps_Public_set_Void_Single_0;

		// Token: 0x04001736 RID: 5942
		[FieldOffset(0)]
		public IntPtr _sizeEps;

		// Token: 0x04001737 RID: 5943
		[FieldOffset(8)]
		public float _extrudeEps;

		// Token: 0x04001738 RID: 5944
		[FieldOffset(12)]
		public float _wireEps;
	}
}
