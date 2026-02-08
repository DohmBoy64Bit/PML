using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000288 RID: 648
	public class IToolHolder : global::Il2CppSystem.Object
	{
		// Token: 0x060033C5 RID: 13253 RVA: 0x000EC458 File Offset: 0x000EA658
		// Note: this type is marked as 'beforefieldinit'.
		static IToolHolder()
		{
			Il2CppClassPointerStore<IToolHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "IToolHolder");
			IToolHolder.NativeMethodInfoPtr_get_ToolAttachmentPoint_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolHolder>.NativeClassPtr, 100671112);
			IToolHolder.NativeMethodInfoPtr_PlayAnim_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolHolder>.NativeClassPtr, 100671113);
			IToolHolder.NativeMethodInfoPtr_PlayAnimTargetRpc_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolHolder>.NativeClassPtr, 100671114);
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060033C6 RID: 13254 RVA: 0x000EC4BC File Offset: 0x000EA6BC
		public unsafe virtual Transform ToolAttachmentPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IToolHolder.NativeMethodInfoPtr_get_ToolAttachmentPoint_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x000EC508 File Offset: 0x000EA708
		[CallerCount(0)]
		public unsafe virtual void PlayAnim(string animationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IToolHolder.NativeMethodInfoPtr_PlayAnim_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x000EC558 File Offset: 0x000EA758
		[CallerCount(0)]
		public unsafe virtual void PlayAnimTargetRpc(string animationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IToolHolder.NativeMethodInfoPtr_PlayAnimTargetRpc_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00014794 File Offset: 0x00012994
		public IToolHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027C5 RID: 10181
		private static readonly IntPtr NativeMethodInfoPtr_get_ToolAttachmentPoint_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040027C6 RID: 10182
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnim_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040027C7 RID: 10183
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnimTargetRpc_Public_Abstract_Virtual_New_Void_String_0;
	}
}
