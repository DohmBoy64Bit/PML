using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020000D1 RID: 209
	public class IGizmoRATriangle3DBorderController : Object
	{
		// Token: 0x060010EC RID: 4332 RVA: 0x000604B4 File Offset: 0x0005E6B4
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoRATriangle3DBorderController()
		{
			Il2CppClassPointerStore<IGizmoRATriangle3DBorderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoRATriangle3DBorderController");
			IGizmoRATriangle3DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoRATriangle3DBorderController>.NativeClassPtr, 100665600);
			IGizmoRATriangle3DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoRATriangle3DBorderController>.NativeClassPtr, 100665601);
			IGizmoRATriangle3DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoRATriangle3DBorderController>.NativeClassPtr, 100665602);
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00060518 File Offset: 0x0005E718
		[CallerCount(0)]
		public unsafe virtual void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoRATriangle3DBorderController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00060554 File Offset: 0x0005E754
		[CallerCount(0)]
		public unsafe virtual void UpdateEpsilons(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoRATriangle3DBorderController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000605A0 File Offset: 0x0005E7A0
		[CallerCount(0)]
		public unsafe virtual void UpdateTransforms(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoRATriangle3DBorderController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00008A09 File Offset: 0x00006C09
		public IGizmoRATriangle3DBorderController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_Single_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_Single_0;
	}
}
