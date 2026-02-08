using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000098 RID: 152
	public class IGizmoPlaneSlider2DController : global::Il2CppSystem.Object
	{
		// Token: 0x06000C41 RID: 3137 RVA: 0x000503E4 File Offset: 0x0004E5E4
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoPlaneSlider2DController()
		{
			Il2CppClassPointerStore<IGizmoPlaneSlider2DController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoPlaneSlider2DController");
			IGizmoPlaneSlider2DController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoPlaneSlider2DController>.NativeClassPtr, 100665083);
			IGizmoPlaneSlider2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoPlaneSlider2DController>.NativeClassPtr, 100665084);
			IGizmoPlaneSlider2DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoPlaneSlider2DController>.NativeClassPtr, 100665085);
			IGizmoPlaneSlider2DController.NativeMethodInfoPtr_GetRealExtentPoint_Public_Abstract_Virtual_New_Vector2_Shape2DExtentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoPlaneSlider2DController>.NativeClassPtr, 100665086);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0005045C File Offset: 0x0004E65C
		[CallerCount(0)]
		public unsafe virtual void UpdateHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoPlaneSlider2DController.NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00050498 File Offset: 0x0004E698
		[CallerCount(0)]
		public unsafe virtual void UpdateTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoPlaneSlider2DController.NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000504D4 File Offset: 0x0004E6D4
		[CallerCount(0)]
		public unsafe virtual void UpdateEpsilons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoPlaneSlider2DController.NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00050510 File Offset: 0x0004E710
		[CallerCount(0)]
		public unsafe virtual Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extentPt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoPlaneSlider2DController.NativeMethodInfoPtr_GetRealExtentPoint_Public_Abstract_Virtual_New_Vector2_Shape2DExtentPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0000667B File Offset: 0x0000487B
		public IGizmoPlaneSlider2DController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandles_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransforms_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEpsilons_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_GetRealExtentPoint_Public_Abstract_Virtual_New_Vector2_Shape2DExtentPoint_0;
	}
}
