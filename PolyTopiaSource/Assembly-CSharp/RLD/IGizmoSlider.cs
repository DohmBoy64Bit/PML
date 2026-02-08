using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D8 RID: 216
	public class IGizmoSlider : global::Il2CppSystem.Object
	{
		// Token: 0x06001151 RID: 4433 RVA: 0x00061CC0 File Offset: 0x0005FEC0
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoSlider()
		{
			Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoSlider");
			IGizmoSlider.NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr, 100665655);
			IGizmoSlider.NativeMethodInfoPtr_get_HandleId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr, 100665656);
			IGizmoSlider.NativeMethodInfoPtr_get_HoverPriority3D_Public_Abstract_Virtual_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr, 100665657);
			IGizmoSlider.NativeMethodInfoPtr_get_HoverPriority2D_Public_Abstract_Virtual_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr, 100665658);
			IGizmoSlider.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Abstract_Virtual_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr, 100665659);
			IGizmoSlider.NativeMethodInfoPtr_SetHoverable_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr, 100665660);
			IGizmoSlider.NativeMethodInfoPtr_SetVisible_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr, 100665661);
			IGizmoSlider.NativeMethodInfoPtr_SetSnapEnabled_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr, 100665662);
			IGizmoSlider.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoSlider>.NativeClassPtr, 100665663);
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00061D9C File Offset: 0x0005FF9C
		public unsafe virtual Gizmo Gizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoSlider.NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00061DE8 File Offset: 0x0005FFE8
		public unsafe virtual int HandleId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoSlider.NativeMethodInfoPtr_get_HandleId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00061E30 File Offset: 0x00060030
		public unsafe virtual Priority HoverPriority3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoSlider.NativeMethodInfoPtr_get_HoverPriority3D_Public_Abstract_Virtual_New_get_Priority_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x00061E7C File Offset: 0x0006007C
		public unsafe virtual Priority HoverPriority2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoSlider.NativeMethodInfoPtr_get_HoverPriority2D_Public_Abstract_Virtual_New_get_Priority_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00061EC8 File Offset: 0x000600C8
		public unsafe virtual Priority GenericHoverPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoSlider.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Abstract_Virtual_New_get_Priority_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00061F14 File Offset: 0x00060114
		[CallerCount(0)]
		public unsafe virtual void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoSlider.NativeMethodInfoPtr_SetHoverable_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00061F60 File Offset: 0x00060160
		[CallerCount(0)]
		public unsafe virtual void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoSlider.NativeMethodInfoPtr_SetVisible_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00061FAC File Offset: 0x000601AC
		[CallerCount(0)]
		public unsafe virtual void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoSlider.NativeMethodInfoPtr_SetSnapEnabled_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00061FF8 File Offset: 0x000601F8
		[CallerCount(0)]
		public unsafe virtual void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoSlider.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00008C36 File Offset: 0x00006E36
		public IGizmoSlider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority3D_Public_Abstract_Virtual_New_get_Priority_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority2D_Public_Abstract_Virtual_New_get_Priority_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericHoverPriority_Public_Abstract_Virtual_New_get_Priority_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0;
	}
}
