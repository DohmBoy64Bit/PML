using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000B4 RID: 180
	public class IGizmoCircle2DBorderController : Object
	{
		// Token: 0x06000F2D RID: 3885 RVA: 0x0005B198 File Offset: 0x00059398
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoCircle2DBorderController()
		{
			Il2CppClassPointerStore<IGizmoCircle2DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoCircle2DBorderController");
			IGizmoCircle2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCircle2DBorderController>.NativeClassPtr, 100665469);
			IGizmoCircle2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCircle2DBorderController>.NativeClassPtr, 100665470);
			IGizmoCircle2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCircle2DBorderController>.NativeClassPtr, 100665471);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0005B1FC File Offset: 0x000593FC
		[CallerCount(0)]
		public unsafe virtual void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCircle2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0005B238 File Offset: 0x00059438
		[CallerCount(0)]
		public unsafe virtual void UpdateEpsilons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCircle2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0005B274 File Offset: 0x00059474
		[CallerCount(0)]
		public unsafe virtual void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCircle2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x000079EE File Offset: 0x00005BEE
		public IGizmoCircle2DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0;
	}
}
