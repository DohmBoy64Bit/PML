using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000A0 RID: 160
	[Serializable]
	public class GizmoLineSlider3DSettings : Object
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x00054174 File Offset: 0x00052374
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider3DSettings()
		{
			Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider3DSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr);
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__lineHoverEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_lineHoverEps");
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__boxHoverEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_boxHoverEps");
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__cylinderHoverEps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_cylinderHoverEps");
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__offsetSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_offsetSnapStep");
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__rotationSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_rotationSnapStep");
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__rotationSnapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_rotationSnapMode");
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__scaleSnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_scaleSnapStep");
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__offsetSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_offsetSensitivity");
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__rotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_rotationSensitivity");
			GizmoLineSlider3DSettings.NativeFieldInfoPtr__scaleSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, "_scaleSensitivity");
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_LineHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665228);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_LineHoverEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665229);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_BoxHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665230);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_BoxHoverEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665231);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_CylinderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665232);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_CylinderHoverEps_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665233);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_OffsetSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665234);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_OffsetSnapStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665235);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_RotationSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665236);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_RotationSnapStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665237);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_RotationSnapMode_Public_get_GizmoSnapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665238);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_RotationSnapMode_Public_set_Void_GizmoSnapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665239);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_ScaleSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665240);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_ScaleSnapStep_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665241);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_OffsetSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665242);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_OffsetSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665243);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_RotationSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665244);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_RotationSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665245);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_ScaleSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665246);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_ScaleSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665247);
			GizmoLineSlider3DSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr, 100665248);
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00054410 File Offset: 0x00052610
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x0005444C File Offset: 0x0005264C
		public unsafe float LineHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_LineHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 65757, RefRangeEnd = 65770, XrefRangeStart = 65757, XrefRangeEnd = 65770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_LineHoverEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0005448C File Offset: 0x0005268C
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x000544C8 File Offset: 0x000526C8
		public unsafe float BoxHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_BoxHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 65770, RefRangeEnd = 65793, XrefRangeStart = 65770, XrefRangeEnd = 65793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_BoxHoverEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00054508 File Offset: 0x00052708
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00054544 File Offset: 0x00052744
		public unsafe float CylinderHoverEps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_CylinderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 57121, RefRangeEnd = 57146, XrefRangeStart = 57121, XrefRangeEnd = 57146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_CylinderHoverEps_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00054584 File Offset: 0x00052784
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x000545C0 File Offset: 0x000527C0
		public unsafe float OffsetSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_OffsetSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 65805, RefRangeEnd = 65832, XrefRangeStart = 65805, XrefRangeEnd = 65832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_OffsetSnapStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00054600 File Offset: 0x00052800
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x0005463C File Offset: 0x0005283C
		public unsafe float RotationSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57149, RefRangeEnd = 57150, XrefRangeStart = 57149, XrefRangeEnd = 57150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_RotationSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 66248, RefRangeEnd = 66251, XrefRangeStart = 66248, XrefRangeEnd = 66251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_RotationSnapStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0005467C File Offset: 0x0005287C
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x000546BC File Offset: 0x000528BC
		public unsafe GizmoSnapMode RotationSnapMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_RotationSnapMode_Public_get_GizmoSnapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_RotationSnapMode_Public_set_Void_GizmoSnapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00054700 File Offset: 0x00052900
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x0005473C File Offset: 0x0005293C
		public unsafe float ScaleSnapStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_ScaleSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_ScaleSnapStep_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0005477C File Offset: 0x0005297C
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x000547B8 File Offset: 0x000529B8
		public unsafe float OffsetSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_OffsetSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_OffsetSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000547F8 File Offset: 0x000529F8
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00054834 File Offset: 0x00052A34
		public unsafe float RotationSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_RotationSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_RotationSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00054874 File Offset: 0x00052A74
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x000548B0 File Offset: 0x00052AB0
		public unsafe float ScaleSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_get_ScaleSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 65089, RefRangeEnd = 65093, XrefRangeStart = 65089, XrefRangeEnd = 65093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr_set_ScaleSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000548F0 File Offset: 0x00052AF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 67333, RefRangeEnd = 67337, XrefRangeStart = 67332, XrefRangeEnd = 67333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider3DSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3DSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public GizmoLineSlider3DSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x0005492C File Offset: 0x00052B2C
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00006CC1 File Offset: 0x00004EC1
		public unsafe float _lineHoverEps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__lineHoverEps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__lineHoverEps)) = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00054954 File Offset: 0x00052B54
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00006CDC File Offset: 0x00004EDC
		public unsafe float _boxHoverEps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__boxHoverEps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__boxHoverEps)) = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x0005497C File Offset: 0x00052B7C
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00006CF7 File Offset: 0x00004EF7
		public unsafe float _cylinderHoverEps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__cylinderHoverEps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__cylinderHoverEps)) = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000549A4 File Offset: 0x00052BA4
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00006D12 File Offset: 0x00004F12
		public unsafe float _offsetSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__offsetSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__offsetSnapStep)) = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000549CC File Offset: 0x00052BCC
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00006D2D File Offset: 0x00004F2D
		public unsafe float _rotationSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__rotationSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__rotationSnapStep)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000549F4 File Offset: 0x00052BF4
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00006D48 File Offset: 0x00004F48
		public unsafe GizmoSnapMode _rotationSnapMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__rotationSnapMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSnapMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__rotationSnapMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00054A24 File Offset: 0x00052C24
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00006D67 File Offset: 0x00004F67
		public unsafe float _scaleSnapStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__scaleSnapStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__scaleSnapStep)) = value;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00054A4C File Offset: 0x00052C4C
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x00006D82 File Offset: 0x00004F82
		public unsafe float _offsetSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__offsetSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__offsetSensitivity)) = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x00054A74 File Offset: 0x00052C74
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00006D9D File Offset: 0x00004F9D
		public unsafe float _rotationSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__rotationSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__rotationSensitivity)) = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00054A9C File Offset: 0x00052C9C
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00006DB8 File Offset: 0x00004FB8
		public unsafe float _scaleSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__scaleSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DSettings.NativeFieldInfoPtr__scaleSensitivity)) = value;
			}
		}

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeFieldInfoPtr__lineHoverEps;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeFieldInfoPtr__boxHoverEps;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeFieldInfoPtr__cylinderHoverEps;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr__offsetSnapStep;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr__rotationSnapStep;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr__rotationSnapMode;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr__scaleSnapStep;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr__offsetSensitivity;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeFieldInfoPtr__rotationSensitivity;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeFieldInfoPtr__scaleSensitivity;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_get_LineHoverEps_Public_get_Single_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_set_LineHoverEps_Public_set_Void_Single_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxHoverEps_Public_get_Single_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_set_BoxHoverEps_Public_set_Void_Single_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_get_CylinderHoverEps_Public_get_Single_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_set_CylinderHoverEps_Public_set_Void_Single_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetSnapStep_Public_get_Single_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetSnapStep_Public_set_Void_Single_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSnapStep_Public_get_Single_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationSnapStep_Public_set_Void_Single_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSnapMode_Public_get_GizmoSnapMode_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationSnapMode_Public_set_Void_GizmoSnapMode_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleSnapStep_Public_get_Single_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleSnapStep_Public_set_Void_Single_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetSensitivity_Public_get_Single_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetSensitivity_Public_set_Void_Single_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSensitivity_Public_get_Single_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationSensitivity_Public_set_Void_Single_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleSensitivity_Public_get_Single_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleSensitivity_Public_set_Void_Single_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
