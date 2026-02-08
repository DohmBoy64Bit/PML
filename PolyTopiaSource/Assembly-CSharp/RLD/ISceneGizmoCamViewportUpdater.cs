using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000076 RID: 118
	public class ISceneGizmoCamViewportUpdater : Object
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x00004E8C File Offset: 0x0000308C
		// Note: this type is marked as 'beforefieldinit'.
		static ISceneGizmoCamViewportUpdater()
		{
			Il2CppClassPointerStore<ISceneGizmoCamViewportUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ISceneGizmoCamViewportUpdater");
			ISceneGizmoCamViewportUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_RTSceneGizmoCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISceneGizmoCamViewportUpdater>.NativeClassPtr, 100664619);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0004322C File Offset: 0x0004142C
		[CallerCount(0)]
		public unsafe virtual void Update(RTSceneGizmoCamera sceneGizmoCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneGizmoCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISceneGizmoCamViewportUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_RTSceneGizmoCamera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00004EBB File Offset: 0x000030BB
		public ISceneGizmoCamViewportUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_RTSceneGizmoCamera_0;
	}
}
