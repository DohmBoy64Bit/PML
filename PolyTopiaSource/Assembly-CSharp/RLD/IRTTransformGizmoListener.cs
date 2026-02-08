using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000066 RID: 102
	public class IRTTransformGizmoListener : Object
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x0003D390 File Offset: 0x0003B590
		// Note: this type is marked as 'beforefieldinit'.
		static IRTTransformGizmoListener()
		{
			Il2CppClassPointerStore<IRTTransformGizmoListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IRTTransformGizmoListener");
			IRTTransformGizmoListener.NativeMethodInfoPtr_OnCanBeTransformed_Public_Abstract_Virtual_New_Boolean_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRTTransformGizmoListener>.NativeClassPtr, 100664378);
			IRTTransformGizmoListener.NativeMethodInfoPtr_OnTransformed_Public_Abstract_Virtual_New_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRTTransformGizmoListener>.NativeClassPtr, 100664379);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0003D3E0 File Offset: 0x0003B5E0
		[CallerCount(0)]
		public unsafe virtual bool OnCanBeTransformed(Gizmo transformGizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformGizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRTTransformGizmoListener.NativeMethodInfoPtr_OnCanBeTransformed_Public_Abstract_Virtual_New_Boolean_Gizmo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0003D438 File Offset: 0x0003B638
		[CallerCount(0)]
		public unsafe virtual void OnTransformed(Gizmo transformGizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformGizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRTTransformGizmoListener.NativeMethodInfoPtr_OnTransformed_Public_Abstract_Virtual_New_Void_Gizmo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00004749 File Offset: 0x00002949
		public IRTTransformGizmoListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_OnCanBeTransformed_Public_Abstract_Virtual_New_Boolean_Gizmo_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformed_Public_Abstract_Virtual_New_Void_Gizmo_0;
	}
}
