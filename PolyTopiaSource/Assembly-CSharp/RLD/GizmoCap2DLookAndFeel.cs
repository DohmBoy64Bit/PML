using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class GizmoCap2DLookAndFeel : global::Il2CppSystem.Object
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00024738 File Offset: 0x00022938
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCap2DLookAndFeel()
		{
			Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCap2DLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr);
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__fillMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_fillMode");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__capType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_capType");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_scale");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__circleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_circleRadius");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__quadWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_quadWidth");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__quadHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_quadHeight");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__arrowBaseRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_arrowBaseRadius");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__arrowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_arrowHeight");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_color");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__hoveredColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_hoveredColor");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__borderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_borderColor");
			GizmoCap2DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, "_hoveredBorderColor");
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663434);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663435);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_CapType_Public_get_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663436);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_CapType_Public_set_Void_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663437);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663438);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663439);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_CircleRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663440);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_CircleRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663441);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_QuadWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663442);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_QuadWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663443);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_QuadHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663444);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_QuadHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663445);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_ArrowBaseRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663446);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_ArrowBaseRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663447);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_ArrowHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663448);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_ArrowHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663449);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663450);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663451);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663452);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663453);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663454);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663455);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663456);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663457);
			GizmoCap2DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr, 100663458);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00024A4C File Offset: 0x00022C4C
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00024A8C File Offset: 0x00022C8C
		public unsafe GizmoFillMode2D FillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00024AD0 File Offset: 0x00022CD0
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00024B10 File Offset: 0x00022D10
		public unsafe GizmoCap2DType CapType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_CapType_Public_get_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2DType>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43069, RefRangeEnd = 43073, XrefRangeStart = 43069, XrefRangeEnd = 43073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_CapType_Public_set_Void_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00024B54 File Offset: 0x00022D54
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00024B90 File Offset: 0x00022D90
		public unsafe float Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 57121, RefRangeEnd = 57146, XrefRangeStart = 57121, XrefRangeEnd = 57121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00024BD0 File Offset: 0x00022DD0
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00024C0C File Offset: 0x00022E0C
		public unsafe float CircleRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_CircleRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57146, RefRangeEnd = 57149, XrefRangeStart = 57146, XrefRangeEnd = 57146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_CircleRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00024C4C File Offset: 0x00022E4C
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00024C88 File Offset: 0x00022E88
		public unsafe float QuadWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_QuadWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 57150, RefRangeEnd = 57178, XrefRangeStart = 57150, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_QuadWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00024CC8 File Offset: 0x00022EC8
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00024D04 File Offset: 0x00022F04
		public unsafe float QuadHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_QuadHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 57179, RefRangeEnd = 57194, XrefRangeStart = 57179, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_QuadHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00024D44 File Offset: 0x00022F44
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00024D80 File Offset: 0x00022F80
		public unsafe float ArrowBaseRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_ArrowBaseRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 57194, RefRangeEnd = 57207, XrefRangeStart = 57194, XrefRangeEnd = 57194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_ArrowBaseRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00024DC0 File Offset: 0x00022FC0
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00024DFC File Offset: 0x00022FFC
		public unsafe float ArrowHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_ArrowHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 57207, RefRangeEnd = 57220, XrefRangeStart = 57207, XrefRangeEnd = 57207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_ArrowHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00024E3C File Offset: 0x0002303C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00024E7C File Offset: 0x0002307C
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00024EC0 File Offset: 0x000230C0
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00024F00 File Offset: 0x00023100
		public unsafe Color HoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00024F44 File Offset: 0x00023144
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00024F84 File Offset: 0x00023184
		public unsafe Color BorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00024FC8 File Offset: 0x000231C8
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00025008 File Offset: 0x00023208
		public unsafe Color HoveredBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0002504C File Offset: 0x0002324C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 57223, RefRangeEnd = 57228, XrefRangeStart = 57220, XrefRangeEnd = 57223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCap2DLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap2DLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000261B File Offset: 0x0000081B
		public GizmoCap2DLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00025088 File Offset: 0x00023288
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002624 File Offset: 0x00000824
		public unsafe GizmoFillMode2D _fillMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__fillMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__fillMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000250B8 File Offset: 0x000232B8
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002643 File Offset: 0x00000843
		public unsafe GizmoCap2DType _capType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__capType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2DType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__capType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000250E8 File Offset: 0x000232E8
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002662 File Offset: 0x00000862
		public unsafe float _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__scale)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00025110 File Offset: 0x00023310
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000267D File Offset: 0x0000087D
		public unsafe float _circleRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__circleRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__circleRadius)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00025138 File Offset: 0x00023338
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002698 File Offset: 0x00000898
		public unsafe float _quadWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__quadWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__quadWidth)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00025160 File Offset: 0x00023360
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000026B3 File Offset: 0x000008B3
		public unsafe float _quadHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__quadHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__quadHeight)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00025188 File Offset: 0x00023388
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000026CE File Offset: 0x000008CE
		public unsafe float _arrowBaseRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__arrowBaseRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__arrowBaseRadius)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000251B0 File Offset: 0x000233B0
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000026E9 File Offset: 0x000008E9
		public unsafe float _arrowHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__arrowHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__arrowHeight)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000251D8 File Offset: 0x000233D8
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00002704 File Offset: 0x00000904
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00025208 File Offset: 0x00023408
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002723 File Offset: 0x00000923
		public unsafe Color _hoveredColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__hoveredColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__hoveredColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00025238 File Offset: 0x00023438
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002742 File Offset: 0x00000942
		public unsafe Color _borderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__borderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__borderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00025268 File Offset: 0x00023468
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002761 File Offset: 0x00000961
		public unsafe Color _hoveredBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DLookAndFeel.NativeFieldInfoPtr__hoveredBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr__fillMode;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr__capType;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr__circleRadius;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr__quadWidth;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr__quadHeight;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr__arrowBaseRadius;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr__arrowHeight;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr__hoveredColor;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr__borderColor;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr__hoveredBorderColor;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_get_FillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_set_FillMode_Public_set_Void_GizmoFillMode2D_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_CapType_Public_get_GizmoCap2DType_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_set_CapType_Public_set_Void_GizmoCap2DType_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_set_Scale_Public_set_Void_Single_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_get_CircleRadius_Public_get_Single_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_set_CircleRadius_Public_set_Void_Single_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_QuadWidth_Public_get_Single_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_set_QuadWidth_Public_set_Void_Single_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_get_QuadHeight_Public_get_Single_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_set_QuadHeight_Public_set_Void_Single_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_ArrowBaseRadius_Public_get_Single_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_set_ArrowBaseRadius_Public_set_Void_Single_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_get_ArrowHeight_Public_get_Single_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_set_ArrowHeight_Public_set_Void_Single_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredColor_Public_set_Void_Color_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredBorderColor_Public_get_Color_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredBorderColor_Public_set_Void_Color_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
