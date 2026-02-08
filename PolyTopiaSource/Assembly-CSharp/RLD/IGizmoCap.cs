using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000023 RID: 35
	public class IGizmoCap : global::Il2CppSystem.Object
	{
		// Token: 0x06000269 RID: 617 RVA: 0x0002A400 File Offset: 0x00028600
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoCap()
		{
			Il2CppClassPointerStore<IGizmoCap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoCap");
			IGizmoCap.NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap>.NativeClassPtr, 100663639);
			IGizmoCap.NativeMethodInfoPtr_get_HandleId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap>.NativeClassPtr, 100663640);
			IGizmoCap.NativeMethodInfoPtr_get_HoverPriority3D_Public_Abstract_Virtual_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap>.NativeClassPtr, 100663641);
			IGizmoCap.NativeMethodInfoPtr_get_HoverPriority2D_Public_Abstract_Virtual_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap>.NativeClassPtr, 100663642);
			IGizmoCap.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Abstract_Virtual_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap>.NativeClassPtr, 100663643);
			IGizmoCap.NativeMethodInfoPtr_SetHoverable_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap>.NativeClassPtr, 100663644);
			IGizmoCap.NativeMethodInfoPtr_SetVisible_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap>.NativeClassPtr, 100663645);
			IGizmoCap.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoCap>.NativeClassPtr, 100663646);
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0002A4C8 File Offset: 0x000286C8
		public unsafe virtual Gizmo Gizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap.NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0002A514 File Offset: 0x00028714
		public unsafe virtual int HandleId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap.NativeMethodInfoPtr_get_HandleId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0002A55C File Offset: 0x0002875C
		public unsafe virtual Priority HoverPriority3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap.NativeMethodInfoPtr_get_HoverPriority3D_Public_Abstract_Virtual_New_get_Priority_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0002A5A8 File Offset: 0x000287A8
		public unsafe virtual Priority HoverPriority2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap.NativeMethodInfoPtr_get_HoverPriority2D_Public_Abstract_Virtual_New_get_Priority_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0002A5F4 File Offset: 0x000287F4
		public unsafe virtual Priority GenericHoverPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Abstract_Virtual_New_get_Priority_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0002A640 File Offset: 0x00028840
		[CallerCount(0)]
		public unsafe virtual void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap.NativeMethodInfoPtr_SetHoverable_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0002A68C File Offset: 0x0002888C
		[CallerCount(0)]
		public unsafe virtual void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap.NativeMethodInfoPtr_SetVisible_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0002A6D8 File Offset: 0x000288D8
		[CallerCount(0)]
		public unsafe virtual void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoCap.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002E9D File Offset: 0x0000109D
		public IGizmoCap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority3D_Public_Abstract_Virtual_New_get_Priority_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority2D_Public_Abstract_Virtual_New_get_Priority_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericHoverPriority_Public_Abstract_Virtual_New_get_Priority_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0;
	}
}
