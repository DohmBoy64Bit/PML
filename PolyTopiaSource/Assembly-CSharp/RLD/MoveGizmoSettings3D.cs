using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000DF RID: 223
	[Serializable]
	public class MoveGizmoSettings3D : Settings
	{
		// Token: 0x060012D7 RID: 4823 RVA: 0x000687CC File Offset: 0x000669CC
		// Note: this type is marked as 'beforefieldinit'.
		static MoveGizmoSettings3D()
		{
			Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MoveGizmoSettings3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr);
			MoveGizmoSettings3D.NativeFieldInfoPtr__vertexSnapSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, "_vertexSnapSettings");
			MoveGizmoSettings3D.NativeFieldInfoPtr__sglSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, "_sglSliderSettings");
			MoveGizmoSettings3D.NativeFieldInfoPtr__dblSliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, "_dblSliderSettings");
			MoveGizmoSettings3D.NativeMethodInfoPtr_get_VertexSnapSettings_Public_get_GizmoObjectVertexSnapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665925);
			MoveGizmoSettings3D.NativeMethodInfoPtr_get_LineSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665926);
			MoveGizmoSettings3D.NativeMethodInfoPtr_get_BoxSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665927);
			MoveGizmoSettings3D.NativeMethodInfoPtr_get_CylinderSliderHoverEps_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665928);
			MoveGizmoSettings3D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665929);
			MoveGizmoSettings3D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665930);
			MoveGizmoSettings3D.NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665931);
			MoveGizmoSettings3D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665932);
			MoveGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665933);
			MoveGizmoSettings3D.NativeMethodInfoPtr_SetLineSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665934);
			MoveGizmoSettings3D.NativeMethodInfoPtr_SetBoxSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665935);
			MoveGizmoSettings3D.NativeMethodInfoPtr_SetCylinderSliderHoverEps_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665936);
			MoveGizmoSettings3D.NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665937);
			MoveGizmoSettings3D.NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665938);
			MoveGizmoSettings3D.NativeMethodInfoPtr_SetZSnapStep_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665939);
			MoveGizmoSettings3D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665940);
			MoveGizmoSettings3D.NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665941);
			MoveGizmoSettings3D.NativeMethodInfoPtr_ConnectDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665942);
			MoveGizmoSettings3D.NativeMethodInfoPtr_GetSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665943);
			MoveGizmoSettings3D.NativeMethodInfoPtr_GetDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr, 100665944);
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x000689C8 File Offset: 0x00066BC8
		public unsafe GizmoObjectVertexSnapSettings VertexSnapSettings
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_get_VertexSnapSettings_Public_get_GizmoObjectVertexSnapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoObjectVertexSnapSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00068A08 File Offset: 0x00066C08
		public unsafe float LineSliderHoverEps
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70425, RefRangeEnd = 70428, XrefRangeStart = 70425, XrefRangeEnd = 70428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_get_LineSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x00068A44 File Offset: 0x00066C44
		public unsafe float BoxSliderHoverEps
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70428, RefRangeEnd = 70431, XrefRangeStart = 70428, XrefRangeEnd = 70431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_get_BoxSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00068A80 File Offset: 0x00066C80
		public unsafe float CylinderSliderHoverEps
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 70033, RefRangeEnd = 70037, XrefRangeStart = 70033, XrefRangeEnd = 70037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_get_CylinderSliderHoverEps_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00068ABC File Offset: 0x00066CBC
		public unsafe float XSnapStep
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70031, RefRangeEnd = 70033, XrefRangeStart = 70031, XrefRangeEnd = 70033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00068AF8 File Offset: 0x00066CF8
		public unsafe float YSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70475, RefRangeEnd = 70476, XrefRangeStart = 70475, XrefRangeEnd = 70475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00068B34 File Offset: 0x00066D34
		public unsafe float ZSnapStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70476, RefRangeEnd = 70477, XrefRangeStart = 70476, XrefRangeEnd = 70476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00068B70 File Offset: 0x00066D70
		public unsafe float DragSensitivity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70477, RefRangeEnd = 70478, XrefRangeStart = 70477, XrefRangeEnd = 70477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00068BAC File Offset: 0x00066DAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70509, RefRangeEnd = 70511, XrefRangeStart = 70478, XrefRangeEnd = 70509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveGizmoSettings3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveGizmoSettings3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00068BE8 File Offset: 0x00066DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLineSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_SetLineSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00068C28 File Offset: 0x00066E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_SetBoxSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00068C68 File Offset: 0x00066E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCylinderSliderHoverEps(float eps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_SetCylinderSliderHoverEps_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00068CA8 File Offset: 0x00066EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70517, RefRangeEnd = 70518, XrefRangeStart = 70511, XrefRangeEnd = 70517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetXSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00068CE8 File Offset: 0x00066EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70524, RefRangeEnd = 70525, XrefRangeStart = 70518, XrefRangeEnd = 70524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetYSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00068D28 File Offset: 0x00066F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70531, RefRangeEnd = 70532, XrefRangeStart = 70525, XrefRangeEnd = 70531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZSnapStep(float snapStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snapStep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_SetZSnapStep_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00068D68 File Offset: 0x00066F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70532, XrefRangeEnd = 70536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00068DA8 File Offset: 0x00066FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70536, XrefRangeEnd = 70540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00068E0C File Offset: 0x0006700C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70540, XrefRangeEnd = 70543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dblSlider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_ConnectDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00068E60 File Offset: 0x00067060
		[CallerCount(0)]
		public unsafe GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_GetSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DSettings>(intPtr3) : null;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00068EC0 File Offset: 0x000670C0
		[CallerCount(0)]
		public unsafe GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoSettings3D.NativeMethodInfoPtr_GetDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000092DA File Offset: 0x000074DA
		public MoveGizmoSettings3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00068F10 File Offset: 0x00067110
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x000092E3 File Offset: 0x000074E3
		public unsafe GizmoObjectVertexSnapSettings _vertexSnapSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings3D.NativeFieldInfoPtr__vertexSnapSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoObjectVertexSnapSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings3D.NativeFieldInfoPtr__vertexSnapSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00068F40 File Offset: 0x00067140
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x00009302 File Offset: 0x00007502
		public unsafe Il2CppReferenceArray<GizmoLineSlider3DSettings> _sglSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings3D.NativeFieldInfoPtr__sglSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings3D.NativeFieldInfoPtr__sglSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00068F70 File Offset: 0x00067170
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x00009321 File Offset: 0x00007521
		public unsafe Il2CppReferenceArray<GizmoPlaneSlider3DSettings> _dblSliderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings3D.NativeFieldInfoPtr__dblSliderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoPlaneSlider3DSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoSettings3D.NativeFieldInfoPtr__dblSliderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeFieldInfoPtr__vertexSnapSettings;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderSettings;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeFieldInfoPtr__dblSliderSettings;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_get_VertexSnapSettings_Public_get_GizmoObjectVertexSnapSettings_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_get_LineSliderHoverEps_Public_get_Single_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxSliderHoverEps_Public_get_Single_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_get_CylinderSliderHoverEps_Public_get_Single_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_get_XSnapStep_Public_get_Single_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_get_YSnapStep_Public_get_Single_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_get_ZSnapStep_Public_get_Single_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSensitivity_Public_get_Single_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_SetLineSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_SetCylinderSliderHoverEps_Public_Void_Single_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_SetXSnapStep_Public_Void_Single_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_SetYSnapStep_Public_Void_Single_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_SetZSnapStep_Public_Void_Single_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_SetDragSensitivity_Public_Void_Single_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSliderSettings_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_ConnectDblSliderSettings_Public_Void_GizmoPlaneSlider3D_PlaneId_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_GetSglSliderSettings_Private_GizmoLineSlider3DSettings_Int32_AxisSign_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_GetDblSliderSettings_Private_GizmoPlaneSlider3DSettings_PlaneId_0;
	}
}
