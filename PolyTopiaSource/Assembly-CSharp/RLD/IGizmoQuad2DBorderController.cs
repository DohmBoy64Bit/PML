using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000BF RID: 191
	public class IGizmoQuad2DBorderController : Object
	{
		// Token: 0x06000FBB RID: 4027 RVA: 0x0005CBF8 File Offset: 0x0005ADF8
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoQuad2DBorderController()
		{
			Il2CppClassPointerStore<IGizmoQuad2DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoQuad2DBorderController");
			IGizmoQuad2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoQuad2DBorderController>.NativeClassPtr, 100665513);
			IGizmoQuad2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoQuad2DBorderController>.NativeClassPtr, 100665514);
			IGizmoQuad2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoQuad2DBorderController>.NativeClassPtr, 100665515);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0005CC5C File Offset: 0x0005AE5C
		[CallerCount(0)]
		public unsafe virtual void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoQuad2DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0005CC98 File Offset: 0x0005AE98
		[CallerCount(0)]
		public unsafe virtual void UpdateEpsilons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoQuad2DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0005CCD4 File Offset: 0x0005AED4
		[CallerCount(0)]
		public unsafe virtual void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoQuad2DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00007EC3 File Offset: 0x000060C3
		public IGizmoQuad2DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0;
	}
}
