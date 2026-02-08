using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace RLD
{
	// Token: 0x020000AE RID: 174
	public class GizmoRATrianglePlaneSlider3DController : GizmoPlaneSlider3DController
	{
		// Token: 0x06000EE7 RID: 3815 RVA: 0x0005A3E8 File Offset: 0x000585E8
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoRATrianglePlaneSlider3DController()
		{
			Il2CppClassPointerStore<GizmoRATrianglePlaneSlider3DController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoRATrianglePlaneSlider3DController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoRATrianglePlaneSlider3DController>.NativeClassPtr);
			GizmoRATrianglePlaneSlider3DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3DControllerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATrianglePlaneSlider3DController>.NativeClassPtr, 100665445);
			GizmoRATrianglePlaneSlider3DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATrianglePlaneSlider3DController>.NativeClassPtr, 100665446);
			GizmoRATrianglePlaneSlider3DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATrianglePlaneSlider3DController>.NativeClassPtr, 100665447);
			GizmoRATrianglePlaneSlider3DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoRATrianglePlaneSlider3DController>.NativeClassPtr, 100665448);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0005A468 File Offset: 0x00058668
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoRATrianglePlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoRATrianglePlaneSlider3DController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoRATrianglePlaneSlider3DController.NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3DControllerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0005A4B4 File Offset: 0x000586B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68204, XrefRangeEnd = 68211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoRATrianglePlaneSlider3DController.NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0005A4F0 File Offset: 0x000586F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68211, XrefRangeEnd = 68214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateEpsilons(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoRATrianglePlaneSlider3DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0005A53C File Offset: 0x0005873C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68214, XrefRangeEnd = 68218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTransforms(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoRATrianglePlaneSlider3DController.NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x000077B9 File Offset: 0x000059B9
		public GizmoRATrianglePlaneSlider3DController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GizmoPlaneSlider3DControllerData_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Virtual_Void_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Virtual_Void_Single_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Virtual_Void_Single_0;
	}
}
