using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000AF RID: 175
	public class IGizmoPlaneSlider3DController : Object
	{
		// Token: 0x06000EED RID: 3821 RVA: 0x0005A588 File Offset: 0x00058788
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoPlaneSlider3DController()
		{
			Il2CppClassPointerStore<IGizmoPlaneSlider3DController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoPlaneSlider3DController");
			IGizmoPlaneSlider3DController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoPlaneSlider3DController>.NativeClassPtr, 100665449);
			IGizmoPlaneSlider3DController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoPlaneSlider3DController>.NativeClassPtr, 100665450);
			IGizmoPlaneSlider3DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoPlaneSlider3DController>.NativeClassPtr, 100665451);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0005A5EC File Offset: 0x000587EC
		[CallerCount(0)]
		public unsafe virtual void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoPlaneSlider3DController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0005A628 File Offset: 0x00058828
		[CallerCount(0)]
		public unsafe virtual void UpdateTransforms(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoPlaneSlider3DController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0005A674 File Offset: 0x00058874
		[CallerCount(0)]
		public unsafe virtual void UpdateEpsilons(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoPlaneSlider3DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000077C2 File Offset: 0x000059C2
		public IGizmoPlaneSlider3DController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_Single_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_Single_0;
	}
}
