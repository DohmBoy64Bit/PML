using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000065 RID: 101
	public class IGizmoHandle : global::Il2CppSystem.Object
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x0003C0D0 File Offset: 0x0003A2D0
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoHandle()
		{
			Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoHandle");
			IGizmoHandle.NativeMethodInfoPtr_get_Id_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664330);
			IGizmoHandle.NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664331);
			IGizmoHandle.NativeMethodInfoPtr_get_DragSession_Public_Abstract_Virtual_New_get_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664332);
			IGizmoHandle.NativeMethodInfoPtr_set_DragSession_Public_Abstract_Virtual_New_set_Void_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664333);
			IGizmoHandle.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Abstract_Virtual_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664334);
			IGizmoHandle.NativeMethodInfoPtr_get_HoverPriority2D_Public_Abstract_Virtual_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664335);
			IGizmoHandle.NativeMethodInfoPtr_get_HoverPriority3D_Public_Abstract_Virtual_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664336);
			IGizmoHandle.NativeMethodInfoPtr_get_Num3DShapes_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664337);
			IGizmoHandle.NativeMethodInfoPtr_get_Num2DShapes_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664338);
			IGizmoHandle.NativeMethodInfoPtr_get_Has3DShapes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664339);
			IGizmoHandle.NativeMethodInfoPtr_get_Has2DShapes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664340);
			IGizmoHandle.NativeMethodInfoPtr_get_Is2DHoverable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664341);
			IGizmoHandle.NativeMethodInfoPtr_set_Is2DHoverable_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664342);
			IGizmoHandle.NativeMethodInfoPtr_get_Is3DHoverable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664343);
			IGizmoHandle.NativeMethodInfoPtr_set_Is3DHoverable_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664344);
			IGizmoHandle.NativeMethodInfoPtr_get_Is2DVisible_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664345);
			IGizmoHandle.NativeMethodInfoPtr_set_Is2DVisible_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664346);
			IGizmoHandle.NativeMethodInfoPtr_get_Is3DVisible_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664347);
			IGizmoHandle.NativeMethodInfoPtr_set_Is3DVisible_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664348);
			IGizmoHandle.NativeMethodInfoPtr_GetZoomFactor_Public_Abstract_Virtual_New_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664349);
			IGizmoHandle.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Abstract_Virtual_New_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664350);
			IGizmoHandle.NativeMethodInfoPtr_SetHoverable_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664351);
			IGizmoHandle.NativeMethodInfoPtr_SetVisible_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664352);
			IGizmoHandle.NativeMethodInfoPtr_Get3DShape_Public_Abstract_Virtual_New_Shape3D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664353);
			IGizmoHandle.NativeMethodInfoPtr_Get2DShape_Public_Abstract_Virtual_New_Shape2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664354);
			IGizmoHandle.NativeMethodInfoPtr_SetAll3DShapesVisible_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664355);
			IGizmoHandle.NativeMethodInfoPtr_Set3DShapeVisible_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664356);
			IGizmoHandle.NativeMethodInfoPtr_Set3DShapeHoverable_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664357);
			IGizmoHandle.NativeMethodInfoPtr_SetAll2DShapesVisible_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664358);
			IGizmoHandle.NativeMethodInfoPtr_Set2DShapeVisible_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664359);
			IGizmoHandle.NativeMethodInfoPtr_Set2DShapeHoverable_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664360);
			IGizmoHandle.NativeMethodInfoPtr_Is3DShapeVisible_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664361);
			IGizmoHandle.NativeMethodInfoPtr_Is2DShapeVisible_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664362);
			IGizmoHandle.NativeMethodInfoPtr_Contains3DShape_Public_Abstract_Virtual_New_Boolean_Shape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664363);
			IGizmoHandle.NativeMethodInfoPtr_Contains2DShape_Public_Abstract_Virtual_New_Boolean_Shape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664364);
			IGizmoHandle.NativeMethodInfoPtr_Add3DShape_Public_Abstract_Virtual_New_Int32_Shape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664365);
			IGizmoHandle.NativeMethodInfoPtr_Add2DShape_Public_Abstract_Virtual_New_Int32_Shape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664366);
			IGizmoHandle.NativeMethodInfoPtr_Remove3DShape_Public_Abstract_Virtual_New_Void_Shape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664367);
			IGizmoHandle.NativeMethodInfoPtr_Remove2DShape_Public_Abstract_Virtual_New_Void_Shape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664368);
			IGizmoHandle.NativeMethodInfoPtr_Render3DSolid_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664369);
			IGizmoHandle.NativeMethodInfoPtr_Render3DWire_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664370);
			IGizmoHandle.NativeMethodInfoPtr_Render3DSolid_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664371);
			IGizmoHandle.NativeMethodInfoPtr_Render3DWire_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664372);
			IGizmoHandle.NativeMethodInfoPtr_Render2DSolid_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664373);
			IGizmoHandle.NativeMethodInfoPtr_Render2DWire_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664374);
			IGizmoHandle.NativeMethodInfoPtr_Render2DSolid_Public_Abstract_Virtual_New_Void_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664375);
			IGizmoHandle.NativeMethodInfoPtr_Render2DWire_Public_Abstract_Virtual_New_Void_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664376);
			IGizmoHandle.NativeMethodInfoPtr_GetHoverData_Public_Abstract_Virtual_New_GizmoHandleHoverData_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoHandle>.NativeClassPtr, 100664377);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x0003C4B8 File Offset: 0x0003A6B8
		public unsafe virtual int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Id_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0003C500 File Offset: 0x0003A700
		public unsafe virtual Gizmo Gizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0003C54C File Offset: 0x0003A74C
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x0003C598 File Offset: 0x0003A798
		public unsafe virtual IGizmoDragSession DragSession
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_DragSession_Public_Abstract_Virtual_New_get_IGizmoDragSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_set_DragSession_Public_Abstract_Virtual_New_set_Void_IGizmoDragSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0003C5E8 File Offset: 0x0003A7E8
		public unsafe virtual Priority GenericHoverPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Abstract_Virtual_New_get_Priority_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0003C634 File Offset: 0x0003A834
		public unsafe virtual Priority HoverPriority2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_HoverPriority2D_Public_Abstract_Virtual_New_get_Priority_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0003C680 File Offset: 0x0003A880
		public unsafe virtual Priority HoverPriority3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_HoverPriority3D_Public_Abstract_Virtual_New_get_Priority_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0003C6CC File Offset: 0x0003A8CC
		public unsafe virtual int Num3DShapes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Num3DShapes_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0003C714 File Offset: 0x0003A914
		public unsafe virtual int Num2DShapes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Num2DShapes_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0003C75C File Offset: 0x0003A95C
		public unsafe virtual bool Has3DShapes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Has3DShapes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x0003C7A4 File Offset: 0x0003A9A4
		public unsafe virtual bool Has2DShapes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Has2DShapes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0003C7EC File Offset: 0x0003A9EC
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x0003C834 File Offset: 0x0003AA34
		public unsafe virtual bool Is2DHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Is2DHoverable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_set_Is2DHoverable_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0003C880 File Offset: 0x0003AA80
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x0003C8C8 File Offset: 0x0003AAC8
		public unsafe virtual bool Is3DHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Is3DHoverable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_set_Is3DHoverable_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0003C914 File Offset: 0x0003AB14
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x0003C95C File Offset: 0x0003AB5C
		public unsafe virtual bool Is2DVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Is2DVisible_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_set_Is2DVisible_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		public unsafe virtual bool Is3DVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_get_Is3DVisible_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_set_Is3DVisible_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0003CA3C File Offset: 0x0003AC3C
		[CallerCount(0)]
		public unsafe virtual float GetZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_GetZoomFactor_Public_Abstract_Virtual_New_Single_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0003CA94 File Offset: 0x0003AC94
		[CallerCount(0)]
		public unsafe virtual void SetZoomFactorTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Abstract_Virtual_New_Void_GizmoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0003CAE4 File Offset: 0x0003ACE4
		[CallerCount(0)]
		public unsafe virtual void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_SetHoverable_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0003CB30 File Offset: 0x0003AD30
		[CallerCount(0)]
		public unsafe virtual void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_SetVisible_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0003CB7C File Offset: 0x0003AD7C
		[CallerCount(0)]
		public unsafe virtual Shape3D Get3DShape(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Get3DShape_Public_Abstract_Virtual_New_Shape3D_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape3D>(intPtr3) : null;
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0003CBD4 File Offset: 0x0003ADD4
		[CallerCount(0)]
		public unsafe virtual Shape2D Get2DShape(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Get2DShape_Public_Abstract_Virtual_New_Shape2D_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0003CC2C File Offset: 0x0003AE2C
		[CallerCount(0)]
		public unsafe virtual void SetAll3DShapesVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_SetAll3DShapesVisible_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0003CC78 File Offset: 0x0003AE78
		[CallerCount(0)]
		public unsafe virtual void Set3DShapeVisible(int shapeIndex, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Set3DShapeVisible_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0003CCD0 File Offset: 0x0003AED0
		[CallerCount(0)]
		public unsafe virtual void Set3DShapeHoverable(int shapeIndex, bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHoverable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Set3DShapeHoverable_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0003CD28 File Offset: 0x0003AF28
		[CallerCount(0)]
		public unsafe virtual void SetAll2DShapesVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_SetAll2DShapesVisible_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0003CD74 File Offset: 0x0003AF74
		[CallerCount(0)]
		public unsafe virtual void Set2DShapeVisible(int shapeIndex, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Set2DShapeVisible_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0003CDCC File Offset: 0x0003AFCC
		[CallerCount(0)]
		public unsafe virtual void Set2DShapeHoverable(int shapeIndex, bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHoverable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Set2DShapeHoverable_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0003CE24 File Offset: 0x0003B024
		[CallerCount(0)]
		public unsafe virtual bool Is3DShapeVisible(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Is3DShapeVisible_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0003CE78 File Offset: 0x0003B078
		[CallerCount(0)]
		public unsafe virtual bool Is2DShapeVisible(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Is2DShapeVisible_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0003CECC File Offset: 0x0003B0CC
		[CallerCount(0)]
		public unsafe virtual bool Contains3DShape(Shape3D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Contains3DShape_Public_Abstract_Virtual_New_Boolean_Shape3D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0003CF24 File Offset: 0x0003B124
		[CallerCount(0)]
		public unsafe virtual bool Contains2DShape(Shape2D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Contains2DShape_Public_Abstract_Virtual_New_Boolean_Shape2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0003CF7C File Offset: 0x0003B17C
		[CallerCount(0)]
		public unsafe virtual int Add3DShape(Shape3D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Add3DShape_Public_Abstract_Virtual_New_Int32_Shape3D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0003CFD4 File Offset: 0x0003B1D4
		[CallerCount(0)]
		public unsafe virtual int Add2DShape(Shape2D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Add2DShape_Public_Abstract_Virtual_New_Int32_Shape2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0003D02C File Offset: 0x0003B22C
		[CallerCount(0)]
		public unsafe virtual void Remove3DShape(Shape3D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Remove3DShape_Public_Abstract_Virtual_New_Void_Shape3D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0003D07C File Offset: 0x0003B27C
		[CallerCount(0)]
		public unsafe virtual void Remove2DShape(Shape2D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Remove2DShape_Public_Abstract_Virtual_New_Void_Shape2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0003D0CC File Offset: 0x0003B2CC
		[CallerCount(0)]
		public unsafe virtual void Render3DSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Render3DSolid_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0003D108 File Offset: 0x0003B308
		[CallerCount(0)]
		public unsafe virtual void Render3DWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Render3DWire_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0003D144 File Offset: 0x0003B344
		[CallerCount(0)]
		public unsafe virtual void Render3DSolid(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Render3DSolid_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0003D190 File Offset: 0x0003B390
		[CallerCount(0)]
		public unsafe virtual void Render3DWire(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Render3DWire_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0003D1DC File Offset: 0x0003B3DC
		[CallerCount(0)]
		public unsafe virtual void Render2DSolid(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Render2DSolid_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0003D22C File Offset: 0x0003B42C
		[CallerCount(0)]
		public unsafe virtual void Render2DWire(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Render2DWire_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0003D27C File Offset: 0x0003B47C
		[CallerCount(0)]
		public unsafe virtual void Render2DSolid(Camera camera, int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shapeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Render2DSolid_Public_Abstract_Virtual_New_Void_Camera_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0003D2D8 File Offset: 0x0003B4D8
		[CallerCount(0)]
		public unsafe virtual void Render2DWire(Camera camera, int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shapeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_Render2DWire_Public_Abstract_Virtual_New_Void_Camera_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0003D334 File Offset: 0x0003B534
		[CallerCount(0)]
		public unsafe virtual GizmoHandleHoverData GetHoverData(Ray hoverRay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoverRay);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoHandle.NativeMethodInfoPtr_GetHoverData_Public_Abstract_Virtual_New_GizmoHandleHoverData_Ray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoHandleHoverData>(intPtr3) : null;
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00004740 File Offset: 0x00002940
		public IGizmoHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSession_Public_Abstract_Virtual_New_get_IGizmoDragSession_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_set_DragSession_Public_Abstract_Virtual_New_set_Void_IGizmoDragSession_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericHoverPriority_Public_Abstract_Virtual_New_get_Priority_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority2D_Public_Abstract_Virtual_New_get_Priority_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority3D_Public_Abstract_Virtual_New_get_Priority_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_get_Num3DShapes_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_get_Num2DShapes_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_get_Has3DShapes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_get_Has2DShapes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_get_Is2DHoverable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_set_Is2DHoverable_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_get_Is3DHoverable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_set_Is3DHoverable_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_get_Is2DVisible_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_set_Is2DVisible_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_get_Is3DVisible_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_set_Is3DVisible_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Abstract_Virtual_New_Single_Camera_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_SetZoomFactorTransform_Public_Abstract_Virtual_New_Void_GizmoTransform_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_Get3DShape_Public_Abstract_Virtual_New_Shape3D_Int32_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_Get2DShape_Public_Abstract_Virtual_New_Shape2D_Int32_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_SetAll3DShapesVisible_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_Set3DShapeVisible_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_Set3DShapeHoverable_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_SetAll2DShapesVisible_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_Set2DShapeVisible_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_Set2DShapeHoverable_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_Is3DShapeVisible_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_Is2DShapeVisible_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_Contains3DShape_Public_Abstract_Virtual_New_Boolean_Shape3D_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_Contains2DShape_Public_Abstract_Virtual_New_Boolean_Shape2D_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_Add3DShape_Public_Abstract_Virtual_New_Int32_Shape3D_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_Add2DShape_Public_Abstract_Virtual_New_Int32_Shape2D_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_Remove3DShape_Public_Abstract_Virtual_New_Void_Shape3D_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_Remove2DShape_Public_Abstract_Virtual_New_Void_Shape2D_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_Render3DSolid_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_Render3DWire_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_Render3DSolid_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_Render3DWire_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_Render2DSolid_Public_Abstract_Virtual_New_Void_Camera_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_Render2DWire_Public_Abstract_Virtual_New_Void_Camera_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_Render2DSolid_Public_Abstract_Virtual_New_Void_Camera_Int32_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_Render2DWire_Public_Abstract_Virtual_New_Void_Camera_Int32_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_GetHoverData_Public_Abstract_Virtual_New_GizmoHandleHoverData_Ray_0;
	}
}
