using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000073 RID: 115
	[Serializable]
	public class GizmoScaleGuideLookAndFeel : global::Il2CppSystem.Object
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x00042A10 File Offset: 0x00040C10
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoScaleGuideLookAndFeel()
		{
			Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoScaleGuideLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr);
			GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__useZoomFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, "_useZoomFactor");
			GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__xAxisColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, "_xAxisColor");
			GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__yAxisColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, "_yAxisColor");
			GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__zAxisColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, "_zAxisColor");
			GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__axisLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, "_axisLength");
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664602);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664603);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_XAxisColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664604);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_XAxisColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664605);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_YAxisColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664606);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_YAxisColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664607);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_ZAxisColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664608);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_ZAxisColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664609);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_AxisLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664610);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_AxisLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664611);
			GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr, 100664612);
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00042B80 File Offset: 0x00040D80
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00042BBC File Offset: 0x00040DBC
		public unsafe bool UseZoomFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20587, RefRangeEnd = 20588, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00042BFC File Offset: 0x00040DFC
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00042C3C File Offset: 0x00040E3C
		public unsafe Color XAxisColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_XAxisColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_XAxisColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00042C80 File Offset: 0x00040E80
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00042CC0 File Offset: 0x00040EC0
		public unsafe Color YAxisColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_YAxisColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_YAxisColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00042D04 File Offset: 0x00040F04
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00042D44 File Offset: 0x00040F44
		public unsafe Color ZAxisColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_ZAxisColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_ZAxisColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00042D88 File Offset: 0x00040F88
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00042DC4 File Offset: 0x00040FC4
		public unsafe float AxisLength
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57861, RefRangeEnd = 57864, XrefRangeStart = 57861, XrefRangeEnd = 57864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_get_AxisLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 63686, RefRangeEnd = 63692, XrefRangeStart = 63686, XrefRangeEnd = 63686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr_set_AxisLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00042E04 File Offset: 0x00041004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63696, RefRangeEnd = 63698, XrefRangeStart = 63692, XrefRangeEnd = 63696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoScaleGuideLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoScaleGuideLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScaleGuideLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00004DA4 File Offset: 0x00002FA4
		public GizmoScaleGuideLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00042E40 File Offset: 0x00041040
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00004DAD File Offset: 0x00002FAD
		public unsafe bool _useZoomFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__useZoomFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__useZoomFactor)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00042E68 File Offset: 0x00041068
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00004DC8 File Offset: 0x00002FC8
		public unsafe Color _xAxisColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__xAxisColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__xAxisColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00042E98 File Offset: 0x00041098
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00004DE7 File Offset: 0x00002FE7
		public unsafe Color _yAxisColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__yAxisColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__yAxisColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00042EC8 File Offset: 0x000410C8
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00004E06 File Offset: 0x00003006
		public unsafe Color _zAxisColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__zAxisColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__zAxisColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00042EF8 File Offset: 0x000410F8
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00004E25 File Offset: 0x00003025
		public unsafe float _axisLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__axisLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScaleGuideLookAndFeel.NativeFieldInfoPtr__axisLength)) = value;
			}
		}

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr__useZoomFactor;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeFieldInfoPtr__xAxisColor;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr__yAxisColor;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr__zAxisColor;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeFieldInfoPtr__axisLength;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_set_UseZoomFactor_Public_set_Void_Boolean_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_get_XAxisColor_Public_get_Color_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_set_XAxisColor_Public_set_Void_Color_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_get_YAxisColor_Public_get_Color_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_set_YAxisColor_Public_set_Void_Color_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_get_ZAxisColor_Public_get_Color_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_set_ZAxisColor_Public_set_Void_Color_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisLength_Public_get_Single_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_set_AxisLength_Public_set_Void_Single_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
