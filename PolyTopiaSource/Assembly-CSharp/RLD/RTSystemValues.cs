using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001AA RID: 426
	public static class RTSystemValues : global::Il2CppSystem.Object
	{
		// Token: 0x06002116 RID: 8470 RVA: 0x000A4CDC File Offset: 0x000A2EDC
		// Note: this type is marked as 'beforefieldinit'.
		static RTSystemValues()
		{
			Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTSystemValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr);
			RTSystemValues.NativeMethodInfoPtr_get_XAxisColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668321);
			RTSystemValues.NativeMethodInfoPtr_get_YAxisColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668322);
			RTSystemValues.NativeMethodInfoPtr_get_ZAxisColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668323);
			RTSystemValues.NativeMethodInfoPtr_get_GridLineColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668324);
			RTSystemValues.NativeMethodInfoPtr_get_HoveredAxisColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668325);
			RTSystemValues.NativeMethodInfoPtr_get_CenterAxisColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668326);
			RTSystemValues.NativeMethodInfoPtr_get_AxisAlpha_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668327);
			RTSystemValues.NativeMethodInfoPtr_get_CameraBkGradientFirstColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668328);
			RTSystemValues.NativeMethodInfoPtr_get_CameraBkGradientSecondColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668329);
			RTSystemValues.NativeMethodInfoPtr_get_GuideFillColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668330);
			RTSystemValues.NativeMethodInfoPtr_get_GuideBorderColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTSystemValues>.NativeClassPtr, 100668331);
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x000A4DE8 File Offset: 0x000A2FE8
		public unsafe static Color XAxisColor
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 85694, RefRangeEnd = 85713, XrefRangeStart = 85693, XrefRangeEnd = 85694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_XAxisColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x000A4E1C File Offset: 0x000A301C
		public unsafe static Color YAxisColor
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 85714, RefRangeEnd = 85729, XrefRangeStart = 85713, XrefRangeEnd = 85714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_YAxisColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x000A4E50 File Offset: 0x000A3050
		public unsafe static Color ZAxisColor
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 85730, RefRangeEnd = 85741, XrefRangeStart = 85729, XrefRangeEnd = 85730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_ZAxisColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x000A4E84 File Offset: 0x000A3084
		public unsafe static Color GridLineColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85741, XrefRangeEnd = 85742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_GridLineColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x000A4EB8 File Offset: 0x000A30B8
		public unsafe static Color HoveredAxisColor
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 85743, RefRangeEnd = 85784, XrefRangeStart = 85742, XrefRangeEnd = 85743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_HoveredAxisColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x000A4EEC File Offset: 0x000A30EC
		public unsafe static Color CenterAxisColor
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 85785, RefRangeEnd = 85792, XrefRangeStart = 85784, XrefRangeEnd = 85785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_CenterAxisColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x000A4F20 File Offset: 0x000A3120
		public unsafe static float AxisAlpha
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 85792, RefRangeEnd = 85806, XrefRangeStart = 85792, XrefRangeEnd = 85792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_AxisAlpha_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x000A4F50 File Offset: 0x000A3150
		public unsafe static Color CameraBkGradientFirstColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 85807, RefRangeEnd = 85809, XrefRangeStart = 85806, XrefRangeEnd = 85807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_CameraBkGradientFirstColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x000A4F84 File Offset: 0x000A3184
		public unsafe static Color CameraBkGradientSecondColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 85809, RefRangeEnd = 85811, XrefRangeStart = 85809, XrefRangeEnd = 85809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_CameraBkGradientSecondColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x000A4FB8 File Offset: 0x000A31B8
		public unsafe static Color GuideFillColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 85811, RefRangeEnd = 85813, XrefRangeStart = 85811, XrefRangeEnd = 85811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_GuideFillColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x000A4FEC File Offset: 0x000A31EC
		public unsafe static Color GuideBorderColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 85813, RefRangeEnd = 85815, XrefRangeStart = 85813, XrefRangeEnd = 85813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTSystemValues.NativeMethodInfoPtr_get_GuideBorderColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0000D82E File Offset: 0x0000BA2E
		public RTSystemValues(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeMethodInfoPtr_get_XAxisColor_Public_Static_get_Color_0;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeMethodInfoPtr_get_YAxisColor_Public_Static_get_Color_0;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeMethodInfoPtr_get_ZAxisColor_Public_Static_get_Color_0;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeMethodInfoPtr_get_GridLineColor_Public_Static_get_Color_0;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredAxisColor_Public_Static_get_Color_0;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterAxisColor_Public_Static_get_Color_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisAlpha_Public_Static_get_Single_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraBkGradientFirstColor_Public_Static_get_Color_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraBkGradientSecondColor_Public_Static_get_Color_0;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr_get_GuideFillColor_Public_Static_get_Color_0;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeMethodInfoPtr_get_GuideBorderColor_Public_Static_get_Color_0;
	}
}
