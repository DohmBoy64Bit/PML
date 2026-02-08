using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001B3 RID: 435
	public class IHoverableSceneEntityContainer : Object
	{
		// Token: 0x060021C0 RID: 8640 RVA: 0x0000DC18 File Offset: 0x0000BE18
		// Note: this type is marked as 'beforefieldinit'.
		static IHoverableSceneEntityContainer()
		{
			Il2CppClassPointerStore<IHoverableSceneEntityContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IHoverableSceneEntityContainer");
			IHoverableSceneEntityContainer.NativeMethodInfoPtr_get_HasHoveredSceneEntity_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHoverableSceneEntityContainer>.NativeClassPtr, 100668414);
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x000A7568 File Offset: 0x000A5768
		public unsafe virtual bool HasHoveredSceneEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHoverableSceneEntityContainer.NativeMethodInfoPtr_get_HasHoveredSceneEntity_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0000DC47 File Offset: 0x0000BE47
		public IHoverableSceneEntityContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr_get_HasHoveredSceneEntity_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
