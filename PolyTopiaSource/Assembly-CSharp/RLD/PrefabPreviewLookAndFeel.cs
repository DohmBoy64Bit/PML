using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000210 RID: 528
	[Serializable]
	public class PrefabPreviewLookAndFeel : Settings
	{
		// Token: 0x060029CA RID: 10698 RVA: 0x000C6F58 File Offset: 0x000C5158
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabPreviewLookAndFeel()
		{
			Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "PrefabPreviewLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr);
			PrefabPreviewLookAndFeel.NativeFieldInfoPtr__minBkAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, "_minBkAlpha");
			PrefabPreviewLookAndFeel.NativeFieldInfoPtr__bkColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, "_bkColor");
			PrefabPreviewLookAndFeel.NativeFieldInfoPtr__previewWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, "_previewWidth");
			PrefabPreviewLookAndFeel.NativeFieldInfoPtr__previewHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, "_previewHeight");
			PrefabPreviewLookAndFeel.NativeFieldInfoPtr__lightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, "_lightIntensity");
			PrefabPreviewLookAndFeel.NativeMethodInfoPtr_get_BkColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, 100669687);
			PrefabPreviewLookAndFeel.NativeMethodInfoPtr_set_BkColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, 100669688);
			PrefabPreviewLookAndFeel.NativeMethodInfoPtr_get_PreviewWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, 100669689);
			PrefabPreviewLookAndFeel.NativeMethodInfoPtr_set_PreviewWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, 100669690);
			PrefabPreviewLookAndFeel.NativeMethodInfoPtr_get_PreviewHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, 100669691);
			PrefabPreviewLookAndFeel.NativeMethodInfoPtr_set_PreviewHeight_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, 100669692);
			PrefabPreviewLookAndFeel.NativeMethodInfoPtr_get_LightIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, 100669693);
			PrefabPreviewLookAndFeel.NativeMethodInfoPtr_set_LightIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, 100669694);
			PrefabPreviewLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr, 100669695);
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x000C70A0 File Offset: 0x000C52A0
		// (set) Token: 0x060029CC RID: 10700 RVA: 0x000C70E0 File Offset: 0x000C52E0
		public unsafe Color BkColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPreviewLookAndFeel.NativeMethodInfoPtr_get_BkColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93070, XrefRangeEnd = 93074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPreviewLookAndFeel.NativeMethodInfoPtr_set_BkColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x000C7124 File Offset: 0x000C5324
		// (set) Token: 0x060029CE RID: 10702 RVA: 0x000C7160 File Offset: 0x000C5360
		public unsafe int PreviewWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPreviewLookAndFeel.NativeMethodInfoPtr_get_PreviewWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPreviewLookAndFeel.NativeMethodInfoPtr_set_PreviewWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x000C71A0 File Offset: 0x000C53A0
		// (set) Token: 0x060029D0 RID: 10704 RVA: 0x000C71DC File Offset: 0x000C53DC
		public unsafe int PreviewHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPreviewLookAndFeel.NativeMethodInfoPtr_get_PreviewHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPreviewLookAndFeel.NativeMethodInfoPtr_set_PreviewHeight_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x000C721C File Offset: 0x000C541C
		// (set) Token: 0x060029D2 RID: 10706 RVA: 0x000C7258 File Offset: 0x000C5458
		public unsafe float LightIntensity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57846, RefRangeEnd = 57847, XrefRangeStart = 57846, XrefRangeEnd = 57847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPreviewLookAndFeel.NativeMethodInfoPtr_get_LightIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 66275, RefRangeEnd = 66284, XrefRangeStart = 66275, XrefRangeEnd = 66284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPreviewLookAndFeel.NativeMethodInfoPtr_set_LightIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000C7298 File Offset: 0x000C5498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93075, RefRangeEnd = 93076, XrefRangeStart = 93074, XrefRangeEnd = 93075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabPreviewLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabPreviewLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPreviewLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00010762 File Offset: 0x0000E962
		public PrefabPreviewLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x000C72D4 File Offset: 0x000C54D4
		// (set) Token: 0x060029D6 RID: 10710 RVA: 0x0001076B File Offset: 0x0000E96B
		public unsafe static float _minBkAlpha
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__minBkAlpha, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__minBkAlpha, (void*)(&value));
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000C72F0 File Offset: 0x000C54F0
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x00010779 File Offset: 0x0000E979
		public unsafe Color _bkColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__bkColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__bkColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000C7320 File Offset: 0x000C5520
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x00010798 File Offset: 0x0000E998
		public unsafe int _previewWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__previewWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__previewWidth)) = value;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x000C7348 File Offset: 0x000C5548
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x000107B3 File Offset: 0x0000E9B3
		public unsafe int _previewHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__previewHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__previewHeight)) = value;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x000C7370 File Offset: 0x000C5570
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x000107CE File Offset: 0x0000E9CE
		public unsafe float _lightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__lightIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPreviewLookAndFeel.NativeFieldInfoPtr__lightIntensity)) = value;
			}
		}

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr__minBkAlpha;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeFieldInfoPtr__bkColor;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr__previewWidth;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeFieldInfoPtr__previewHeight;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeFieldInfoPtr__lightIntensity;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeMethodInfoPtr_get_BkColor_Public_get_Color_0;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeMethodInfoPtr_set_BkColor_Public_set_Void_Color_0;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviewWidth_Public_get_Int32_0;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeMethodInfoPtr_set_PreviewWidth_Public_set_Void_Int32_0;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviewHeight_Public_get_Int32_0;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeMethodInfoPtr_set_PreviewHeight_Public_set_Void_Int32_0;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeMethodInfoPtr_get_LightIntensity_Public_get_Single_0;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeMethodInfoPtr_set_LightIntensity_Public_set_Void_Single_0;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
