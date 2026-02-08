using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000082 RID: 130
	[Serializable]
	public class BoxGizmoLookAndFeel3D : Settings
	{
		// Token: 0x060009DB RID: 2523 RVA: 0x00047740 File Offset: 0x00045940
		// Note: this type is marked as 'beforefieldinit'.
		static BoxGizmoLookAndFeel3D()
		{
			Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "BoxGizmoLookAndFeel3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr);
			BoxGizmoLookAndFeel3D.NativeFieldInfoPtr__boxWireColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, "_boxWireColor");
			BoxGizmoLookAndFeel3D.NativeFieldInfoPtr__tickLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, "_tickLookAndFeel");
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxWireColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664773);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XTickColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664774);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YTickColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664775);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZTickColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664776);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664777);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickHoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664778);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickHoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664779);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickType_Public_get_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664780);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickQuadWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664781);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickQuadHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664782);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickCircleRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664783);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664784);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_GetAllowedTickTypes_Public_List_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664785);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_IsTickTypeAllowed_Public_Boolean_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664786);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxWireColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664787);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisTickColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664788);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664789);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickHoveredColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664790);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickHoveredBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664791);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickType_Public_Void_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664792);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickQuadWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664793);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickQuadHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664794);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickCircleRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664795);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectTickLookAndFeel_Public_Void_GizmoCap2D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664796);
			BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_GetTickLookAndFeel_Private_GizmoCap2DLookAndFeel_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr, 100664797);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0004798C File Offset: 0x00045B8C
		public unsafe Color BoxWireColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxWireColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x000479CC File Offset: 0x00045BCC
		public unsafe Color XTickColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XTickColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00047A0C File Offset: 0x00045C0C
		public unsafe Color YTickColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YTickColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00047A4C File Offset: 0x00045C4C
		public unsafe Color ZTickColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZTickColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00047A8C File Offset: 0x00045C8C
		public unsafe Color TickBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00047ACC File Offset: 0x00045CCC
		public unsafe Color TickHoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickHoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x00047B0C File Offset: 0x00045D0C
		public unsafe Color TickHoveredBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickHoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00047B4C File Offset: 0x00045D4C
		public unsafe GizmoCap2DType TickType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickType_Public_get_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2DType>(intPtr3) : null;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00047B8C File Offset: 0x00045D8C
		public unsafe float TickQuadWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickQuadWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00047BC8 File Offset: 0x00045DC8
		public unsafe float TickQuadHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickQuadHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00047C04 File Offset: 0x00045E04
		public unsafe float TickCircleRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_get_TickCircleRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00047C40 File Offset: 0x00045E40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64995, RefRangeEnd = 64998, XrefRangeStart = 64967, XrefRangeEnd = 64995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxGizmoLookAndFeel3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoxGizmoLookAndFeel3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00047C7C File Offset: 0x00045E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64998, XrefRangeEnd = 65016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Enum> GetAllowedTickTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_GetAllowedTickTypes_Public_List_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Enum>>(intPtr3) : null;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00047CBC File Offset: 0x00045EBC
		[CallerCount(0)]
		public unsafe bool IsTickTypeAllowed(GizmoCap2DType tickType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tickType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_IsTickTypeAllowed_Public_Boolean_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00047D0C File Offset: 0x00045F0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 58119, RefRangeEnd = 58122, XrefRangeStart = 58119, XrefRangeEnd = 58122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxWireColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxWireColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00047D50 File Offset: 0x00045F50
		[CallerCount(0)]
		public unsafe void SetAxisTickColor(int axisIndex, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisTickColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00047DA0 File Offset: 0x00045FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65016, XrefRangeEnd = 65017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTickBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00047DE4 File Offset: 0x00045FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65017, XrefRangeEnd = 65018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTickHoveredColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickHoveredColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00047E28 File Offset: 0x00046028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65018, XrefRangeEnd = 65019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTickHoveredBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickHoveredBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00047E6C File Offset: 0x0004606C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65019, XrefRangeEnd = 65020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTickType(GizmoCap2DType tickType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tickType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickType_Public_Void_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00047EB0 File Offset: 0x000460B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65020, XrefRangeEnd = 65022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTickQuadWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickQuadWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00047EF0 File Offset: 0x000460F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65022, XrefRangeEnd = 65024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTickQuadHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickQuadHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00047F30 File Offset: 0x00046130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65024, XrefRangeEnd = 65025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTickCircleRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_SetTickCircleRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00047F70 File Offset: 0x00046170
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 65029, RefRangeEnd = 65035, XrefRangeStart = 65025, XrefRangeEnd = 65029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectTickLookAndFeel(GizmoCap2D tick, int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tick);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectTickLookAndFeel_Public_Void_GizmoCap2D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00047FD4 File Offset: 0x000461D4
		[CallerCount(0)]
		public unsafe GizmoCap2DLookAndFeel GetTickLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoxGizmoLookAndFeel3D.NativeMethodInfoPtr_GetTickLookAndFeel_Private_GizmoCap2DLookAndFeel_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2DLookAndFeel>(intPtr3) : null;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0000565A File Offset: 0x0000385A
		public BoxGizmoLookAndFeel3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00048034 File Offset: 0x00046234
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00005663 File Offset: 0x00003863
		public unsafe Color _boxWireColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoLookAndFeel3D.NativeFieldInfoPtr__boxWireColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoLookAndFeel3D.NativeFieldInfoPtr__boxWireColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00048064 File Offset: 0x00046264
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x00005682 File Offset: 0x00003882
		public unsafe Il2CppReferenceArray<GizmoCap2DLookAndFeel> _tickLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoLookAndFeel3D.NativeFieldInfoPtr__tickLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoCap2DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoxGizmoLookAndFeel3D.NativeFieldInfoPtr__tickLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeFieldInfoPtr__boxWireColor;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr__tickLookAndFeel;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxWireColor_Public_get_Color_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_get_XTickColor_Public_get_Color_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_get_YTickColor_Public_get_Color_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_get_ZTickColor_Public_get_Color_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_get_TickBorderColor_Public_get_Color_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_get_TickHoveredColor_Public_get_Color_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_get_TickHoveredBorderColor_Public_get_Color_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_get_TickType_Public_get_GizmoCap2DType_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_get_TickQuadWidth_Public_get_Single_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_get_TickQuadHeight_Public_get_Single_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_get_TickCircleRadius_Public_get_Single_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_GetAllowedTickTypes_Public_List_1_Enum_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_IsTickTypeAllowed_Public_Boolean_GizmoCap2DType_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxWireColor_Public_Void_Color_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisTickColor_Public_Void_Int32_Color_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_SetTickBorderColor_Public_Void_Color_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_SetTickHoveredColor_Public_Void_Color_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_SetTickHoveredBorderColor_Public_Void_Color_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_SetTickType_Public_Void_GizmoCap2DType_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_SetTickQuadWidth_Public_Void_Single_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_SetTickQuadHeight_Public_Void_Single_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_SetTickCircleRadius_Public_Void_Single_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_ConnectTickLookAndFeel_Public_Void_GizmoCap2D_Int32_AxisSign_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_GetTickLookAndFeel_Private_GizmoCap2DLookAndFeel_Int32_AxisSign_0;
	}
}
