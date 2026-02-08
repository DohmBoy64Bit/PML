using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000075 RID: 117
	public class ISceneGizmo : global::Il2CppSystem.Object
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x00043144 File Offset: 0x00041344
		// Note: this type is marked as 'beforefieldinit'.
		static ISceneGizmo()
		{
			Il2CppClassPointerStore<ISceneGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ISceneGizmo");
			ISceneGizmo.NativeMethodInfoPtr_get_OwnerGizmo_Public_Abstract_Virtual_New_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISceneGizmo>.NativeClassPtr, 100664617);
			ISceneGizmo.NativeMethodInfoPtr_get_SceneCamera_Public_Abstract_Virtual_New_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISceneGizmo>.NativeClassPtr, 100664618);
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x00043194 File Offset: 0x00041394
		public unsafe virtual Gizmo OwnerGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISceneGizmo.NativeMethodInfoPtr_get_OwnerGizmo_Public_Abstract_Virtual_New_get_Gizmo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x000431E0 File Offset: 0x000413E0
		public unsafe virtual Camera SceneCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISceneGizmo.NativeMethodInfoPtr_get_SceneCamera_Public_Abstract_Virtual_New_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00004E83 File Offset: 0x00003083
		public ISceneGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerGizmo_Public_Abstract_Virtual_New_get_Gizmo_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneCamera_Public_Abstract_Virtual_New_get_Camera_0;
	}
}
