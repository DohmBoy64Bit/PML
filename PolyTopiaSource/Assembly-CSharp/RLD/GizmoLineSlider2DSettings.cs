using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x0200008A RID: 138
	[Serializable]
	public class GizmoLineSlider2DSettings : Object
	{
		// Token: 0x06000AE1 RID: 2785 RVA: 0x0004B590 File Offset: 0x00049790
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider2DSettings()
		{
			Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider2DSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr);
			GizmoLineSlider2DSettings.NativeFieldInfoPtr__lineHoverEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, "_lineHoverEps");
			GizmoLineSlider2DSettings.NativeFieldInfoPtr__boxHoverEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, "_boxHoverEps");
			GizmoLineSlider2DSettings.NativeFieldInfoPtr__offsetSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, "_offsetSnapStep");
			GizmoLineSlider2DSettings.NativeFieldInfoPtr__rotationSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, "_rotationSnapStep");
			GizmoLineSlider2DSettings.NativeFieldInfoPtr__rotationSnapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, "_rotationSnapMode");
			GizmoLineSlider2DSettings.NativeFieldInfoPtr__scaleSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, "_scaleSnapStep");
			GizmoLineSlider2DSettings.NativeFieldInfoPtr__offsetSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, "_offsetSensitivity");
			GizmoLineSlider2DSettings.NativeFieldInfoPtr__rotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, "_rotationSensitivity");
			GizmoLineSlider2DSettings.NativeFieldInfoPtr__scaleSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, "_scaleSensitivity");
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_LineHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664915);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_LineHoverEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664916);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_BoxHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664917);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_BoxHoverEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664918);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_OffsetSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664919);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_OffsetSnapStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664920);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_RotationSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664921);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_RotationSnapStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664922);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_RotationSnapMode_Public_get_GizmoSnapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664923);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_RotationSnapMode_Public_set_Void_GizmoSnapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664924);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_ScaleSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664925);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_ScaleSnapStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664926);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_OffsetSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664927);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_OffsetSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664928);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_RotationSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664929);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_RotationSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664930);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_ScaleSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664931);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_ScaleSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664932);
			GizmoLineSlider2DSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr, 100664933);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0004B7F0 File Offset: 0x000499F0
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0004B82C File Offset: 0x00049A2C
		public unsafe float LineHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_LineHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 65757, RefRangeEnd = 65770, XrefRangeStart = 65757, XrefRangeEnd = 65757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_LineHoverEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x0004B86C File Offset: 0x00049A6C
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x0004B8A8 File Offset: 0x00049AA8
		public unsafe float BoxHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_BoxHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 65770, RefRangeEnd = 65793, XrefRangeStart = 65770, XrefRangeEnd = 65770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_BoxHoverEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0004B8E8 File Offset: 0x00049AE8
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x0004B924 File Offset: 0x00049B24
		public unsafe float OffsetSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_OffsetSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 65793, RefRangeEnd = 65805, XrefRangeStart = 65793, XrefRangeEnd = 65793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_OffsetSnapStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0004B964 File Offset: 0x00049B64
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x0004B9A0 File Offset: 0x00049BA0
		public unsafe float RotationSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_RotationSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 65805, RefRangeEnd = 65832, XrefRangeStart = 65805, XrefRangeEnd = 65805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_RotationSnapStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0004B9E0 File Offset: 0x00049BE0
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x0004BA20 File Offset: 0x00049C20
		public unsafe GizmoSnapMode RotationSnapMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_RotationSnapMode_Public_get_GizmoSnapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoSnapMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_RotationSnapMode_Public_set_Void_GizmoSnapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0004BA64 File Offset: 0x00049C64
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x0004BAA0 File Offset: 0x00049CA0
		public unsafe float ScaleSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57178, RefRangeEnd = 57179, XrefRangeStart = 57178, XrefRangeEnd = 57179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_ScaleSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 65832, RefRangeEnd = 65835, XrefRangeStart = 65832, XrefRangeEnd = 65832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_ScaleSnapStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0004BAE0 File Offset: 0x00049CE0
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x0004BB1C File Offset: 0x00049D1C
		public unsafe float OffsetSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_OffsetSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65070, XrefRangeStart = 65039, XrefRangeEnd = 65070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_OffsetSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0004BB5C File Offset: 0x00049D5C
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x0004BB98 File Offset: 0x00049D98
		public unsafe float RotationSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_RotationSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 65070, RefRangeEnd = 65083, XrefRangeStart = 65070, XrefRangeEnd = 65083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_RotationSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0004BBD8 File Offset: 0x00049DD8
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x0004BC14 File Offset: 0x00049E14
		public unsafe float ScaleSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_get_ScaleSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 65083, RefRangeEnd = 65089, XrefRangeStart = 65083, XrefRangeEnd = 65089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr_set_ScaleSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0004BC54 File Offset: 0x00049E54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 65836, RefRangeEnd = 65839, XrefRangeStart = 65835, XrefRangeEnd = 65836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider2DSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider2DSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00005CD9 File Offset: 0x00003ED9
		public GizmoLineSlider2DSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0004BC90 File Offset: 0x00049E90
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00005CE2 File Offset: 0x00003EE2
		public unsafe float _lineHoverEps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__lineHoverEps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__lineHoverEps)) = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0004BCB8 File Offset: 0x00049EB8
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00005CFD File Offset: 0x00003EFD
		public unsafe float _boxHoverEps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__boxHoverEps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__boxHoverEps)) = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0004BCE0 File Offset: 0x00049EE0
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00005D18 File Offset: 0x00003F18
		public unsafe float _offsetSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__offsetSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__offsetSnapStep)) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0004BD08 File Offset: 0x00049F08
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00005D33 File Offset: 0x00003F33
		public unsafe float _rotationSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__rotationSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__rotationSnapStep)) = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0004BD30 File Offset: 0x00049F30
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x00005D4E File Offset: 0x00003F4E
		public unsafe GizmoSnapMode _rotationSnapMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__rotationSnapMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSnapMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__rotationSnapMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0004BD60 File Offset: 0x00049F60
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x00005D6D File Offset: 0x00003F6D
		public unsafe float _scaleSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__scaleSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__scaleSnapStep)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0004BD88 File Offset: 0x00049F88
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00005D88 File Offset: 0x00003F88
		public unsafe float _offsetSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__offsetSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__offsetSensitivity)) = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0004BDB0 File Offset: 0x00049FB0
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00005DA3 File Offset: 0x00003FA3
		public unsafe float _rotationSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__rotationSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__rotationSensitivity)) = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0004BDD8 File Offset: 0x00049FD8
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00005DBE File Offset: 0x00003FBE
		public unsafe float _scaleSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__scaleSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DSettings.NativeFieldInfoPtr__scaleSensitivity)) = value;
			}
		}

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr__lineHoverEps;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr__boxHoverEps;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr__offsetSnapStep;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr__rotationSnapStep;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr__rotationSnapMode;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr__scaleSnapStep;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeFieldInfoPtr__offsetSensitivity;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeFieldInfoPtr__rotationSensitivity;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr__scaleSensitivity;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_get_LineHoverEps_Public_get_Single_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_set_LineHoverEps_Public_set_Void_Single_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxHoverEps_Public_get_Single_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_set_BoxHoverEps_Public_set_Void_Single_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetSnapStep_Public_get_Single_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetSnapStep_Public_set_Void_Single_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSnapStep_Public_get_Single_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationSnapStep_Public_set_Void_Single_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSnapMode_Public_get_GizmoSnapMode_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationSnapMode_Public_set_Void_GizmoSnapMode_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleSnapStep_Public_get_Single_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleSnapStep_Public_set_Void_Single_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetSensitivity_Public_get_Single_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetSensitivity_Public_set_Void_Single_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSensitivity_Public_get_Single_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationSensitivity_Public_set_Void_Single_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleSensitivity_Public_get_Single_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleSensitivity_Public_set_Void_Single_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
