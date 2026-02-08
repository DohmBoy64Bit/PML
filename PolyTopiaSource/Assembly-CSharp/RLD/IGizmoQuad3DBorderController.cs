using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000CC RID: 204
	public class IGizmoQuad3DBorderController : Object
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x0005F7AC File Offset: 0x0005D9AC
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoQuad3DBorderController()
		{
			Il2CppClassPointerStore<IGizmoQuad3DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoQuad3DBorderController");
			IGizmoQuad3DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoQuad3DBorderController>.NativeClassPtr, 100665578);
			IGizmoQuad3DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoQuad3DBorderController>.NativeClassPtr, 100665579);
			IGizmoQuad3DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoQuad3DBorderController>.NativeClassPtr, 100665580);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0005F810 File Offset: 0x0005DA10
		[CallerCount(0)]
		public unsafe virtual void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoQuad3DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0005F84C File Offset: 0x0005DA4C
		[CallerCount(0)]
		public unsafe virtual void UpdateEpsilons(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoQuad3DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0005F898 File Offset: 0x0005DA98
		[CallerCount(0)]
		public unsafe virtual void UpdateTransforms(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoQuad3DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x000087DD File Offset: 0x000069DD
		public IGizmoQuad3DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_Single_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_Single_0;
	}
}
