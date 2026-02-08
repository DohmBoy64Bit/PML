using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000013 RID: 19
	public class GizmoCircleCap2DController : GizmoCap2DController
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00025298 File Offset: 0x00023498
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCircleCap2DController()
		{
			Il2CppClassPointerStore<GizmoCircleCap2DController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCircleCap2DController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCircleCap2DController>.NativeClassPtr);
			GizmoCircleCap2DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoCap2DControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircleCap2DController>.NativeClassPtr, 100663459);
			GizmoCircleCap2DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircleCap2DController>.NativeClassPtr, 100663460);
			GizmoCircleCap2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircleCap2DController>.NativeClassPtr, 100663461);
			GizmoCircleCap2DController.NativeMethodInfoPtr_CapSlider2D_Public_Virtual_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircleCap2DController>.NativeClassPtr, 100663462);
			GizmoCircleCap2DController.NativeMethodInfoPtr_CapSlider2DInvert_Public_Virtual_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircleCap2DController>.NativeClassPtr, 100663463);
			GizmoCircleCap2DController.NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCircleCap2DController>.NativeClassPtr, 100663464);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00025340 File Offset: 0x00023540
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCircleCap2DController(GizmoCap2DControllerData controllerData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCircleCap2DController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCircleCap2DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoCap2DControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0002538C File Offset: 0x0002358C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57228, XrefRangeEnd = 57232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCircleCap2DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000253C8 File Offset: 0x000235C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57232, XrefRangeEnd = 57233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCircleCap2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00025404 File Offset: 0x00023604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57233, XrefRangeEnd = 57238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCircleCap2DController.NativeMethodInfoPtr_CapSlider2D_Public_Virtual_Void_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00025464 File Offset: 0x00023664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57238, XrefRangeEnd = 57243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCircleCap2DController.NativeMethodInfoPtr_CapSlider2DInvert_Public_Virtual_Void_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000254C4 File Offset: 0x000236C4
		[CallerCount(0)]
		public unsafe override float GetSliderAlignedRealLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCircleCap2DController.NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002780 File Offset: 0x00000980
		public GizmoCircleCap2DController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoCap2DControllerData_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider2D_Public_Virtual_Void_Vector2_Vector2_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_CapSlider2DInvert_Public_Virtual_Void_Vector2_Vector2_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_GetSliderAlignedRealLength_Public_Virtual_Single_0;
	}
}
