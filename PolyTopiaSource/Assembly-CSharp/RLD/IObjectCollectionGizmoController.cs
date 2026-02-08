using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000213 RID: 531
	public class IObjectCollectionGizmoController : global::Il2CppSystem.Object
	{
		// Token: 0x060029E5 RID: 10725 RVA: 0x0001086D File Offset: 0x0000EA6D
		// Note: this type is marked as 'beforefieldinit'.
		static IObjectCollectionGizmoController()
		{
			Il2CppClassPointerStore<IObjectCollectionGizmoController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IObjectCollectionGizmoController");
			IObjectCollectionGizmoController.NativeMethodInfoPtr_SetTargetObjectCollection_Public_Abstract_Virtual_New_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectCollectionGizmoController>.NativeClassPtr, 100669699);
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000C7450 File Offset: 0x000C5650
		[CallerCount(0)]
		public unsafe virtual void SetTargetObjectCollection(IEnumerable<GameObject> targetObjectCollection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjectCollection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectCollectionGizmoController.NativeMethodInfoPtr_SetTargetObjectCollection_Public_Abstract_Virtual_New_Void_IEnumerable_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x0001089C File Offset: 0x0000EA9C
		public IObjectCollectionGizmoController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetObjectCollection_Public_Abstract_Virtual_New_Void_IEnumerable_1_GameObject_0;
	}
}
