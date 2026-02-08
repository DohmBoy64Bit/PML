using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200000C RID: 12
	public class GizmoArrowCap2DController : GizmoCap2DController
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00022C30 File Offset: 0x00020E30
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoArrowCap2DController()
		{
			Il2CppClassPointerStore<GizmoArrowCap2DController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoArrowCap2DController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoArrowCap2DController>.NativeClassPtr);
			GizmoArrowCap2DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoCap2DControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoArrowCap2DController>.NativeClassPtr, 100663378);
			GizmoArrowCap2DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoArrowCap2DController>.NativeClassPtr, 100663379);
			GizmoArrowCap2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoArrowCap2DController>.NativeClassPtr, 100663380);
			GizmoArrowCap2DController.NativeMethodInfoPtr_CapSlider2D_Public_Virtual_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoArrowCap2DController>.NativeClassPtr, 100663381);
			GizmoArrowCap2DController.NativeMethodInfoPtr_CapSlider2DInvert_Public_Virtual_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoArrowCap2DController>.NativeClassPtr, 100663382);
			GizmoArrowCap2DController.NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoArrowCap2DController>.NativeClassPtr, 100663383);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00022CD8 File Offset: 0x00020ED8
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoArrowCap2DController(GizmoCap2DControllerData controllerData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoArrowCap2DController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoArrowCap2DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoCap2DControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00022D24 File Offset: 0x00020F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56729, XrefRangeEnd = 56733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoArrowCap2DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00022D60 File Offset: 0x00020F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56733, XrefRangeEnd = 56736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoArrowCap2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00022D9C File Offset: 0x00020F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56736, XrefRangeEnd = 56742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sliderDirection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sliderEndPt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoArrowCap2DController.NativeMethodInfoPtr_CapSlider2D_Public_Virtual_Void_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00022DFC File Offset: 0x00020FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56742, XrefRangeEnd = 56747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sliderDirection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sliderEndPt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoArrowCap2DController.NativeMethodInfoPtr_CapSlider2DInvert_Public_Virtual_Void_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00022E5C File Offset: 0x0002105C
		[CallerCount(0)]
		public unsafe override float GetSliderAlignedRealLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoArrowCap2DController.NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000022FF File Offset: 0x000004FF
		public GizmoArrowCap2DController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoCap2DControllerData_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider2D_Public_Virtual_Void_Vector2_Vector2_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider2DInvert_Public_Virtual_Void_Vector2_Vector2_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Virtual_Single_0;
	}
}
