using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200005F RID: 95
	public class GizmoHandle : global::Il2CppSystem.Object
	{
		// Token: 0x06000633 RID: 1587 RVA: 0x00038BCC File Offset: 0x00036DCC
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoHandle()
		{
			Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr);
			GizmoHandle.NativeFieldInfoPtr_CanHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "CanHover");
			GizmoHandle.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "_id");
			GizmoHandle.NativeFieldInfoPtr__gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "_gizmo");
			GizmoHandle.NativeFieldInfoPtr__zoomFactorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "_zoomFactorTransform");
			GizmoHandle.NativeFieldInfoPtr__genericHoverPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "_genericHoverPriority");
			GizmoHandle.NativeFieldInfoPtr__hoverPriority2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "_hoverPriority2D");
			GizmoHandle.NativeFieldInfoPtr__hoverPriority3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "_hoverPriority3D");
			GizmoHandle.NativeFieldInfoPtr__3DShapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "_3DShapes");
			GizmoHandle.NativeFieldInfoPtr__2DShapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "_2DShapes");
			GizmoHandle.NativeFieldInfoPtr__DragSession_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "<DragSession>k__BackingField");
			GizmoHandle.NativeFieldInfoPtr__Is2DHoverable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "<Is2DHoverable>k__BackingField");
			GizmoHandle.NativeFieldInfoPtr__Is3DHoverable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "<Is3DHoverable>k__BackingField");
			GizmoHandle.NativeFieldInfoPtr__Is2DVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "<Is2DVisible>k__BackingField");
			GizmoHandle.NativeFieldInfoPtr__Is3DVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "<Is3DVisible>k__BackingField");
			GizmoHandle.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664179);
			GizmoHandle.NativeMethodInfoPtr_get_Gizmo_Public_Virtual_Final_New_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664180);
			GizmoHandle.NativeMethodInfoPtr_get_DragSession_Public_Virtual_Final_New_get_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664181);
			GizmoHandle.NativeMethodInfoPtr_set_DragSession_Public_Virtual_Final_New_set_Void_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664182);
			GizmoHandle.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Virtual_Final_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664183);
			GizmoHandle.NativeMethodInfoPtr_get_HoverPriority2D_Public_Virtual_Final_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664184);
			GizmoHandle.NativeMethodInfoPtr_get_HoverPriority3D_Public_Virtual_Final_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664185);
			GizmoHandle.NativeMethodInfoPtr_get_Num3DShapes_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664186);
			GizmoHandle.NativeMethodInfoPtr_get_Num2DShapes_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664187);
			GizmoHandle.NativeMethodInfoPtr_get_Has3DShapes_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664188);
			GizmoHandle.NativeMethodInfoPtr_get_Has2DShapes_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664189);
			GizmoHandle.NativeMethodInfoPtr_get_Is2DHoverable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664190);
			GizmoHandle.NativeMethodInfoPtr_set_Is2DHoverable_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664191);
			GizmoHandle.NativeMethodInfoPtr_get_Is3DHoverable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664192);
			GizmoHandle.NativeMethodInfoPtr_set_Is3DHoverable_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664193);
			GizmoHandle.NativeMethodInfoPtr_get_Is2DVisible_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664194);
			GizmoHandle.NativeMethodInfoPtr_set_Is2DVisible_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664195);
			GizmoHandle.NativeMethodInfoPtr_get_Is3DVisible_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664196);
			GizmoHandle.NativeMethodInfoPtr_set_Is3DVisible_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664197);
			GizmoHandle.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664198);
			GizmoHandle.NativeMethodInfoPtr_GetZoomFactor_Public_Virtual_Final_New_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664199);
			GizmoHandle.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Virtual_Final_New_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664200);
			GizmoHandle.NativeMethodInfoPtr_SetHoverable_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664201);
			GizmoHandle.NativeMethodInfoPtr_SetVisible_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664202);
			GizmoHandle.NativeMethodInfoPtr_Get3DShape_Public_Virtual_Final_New_Shape3D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664203);
			GizmoHandle.NativeMethodInfoPtr_Get2DShape_Public_Virtual_Final_New_Shape2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664204);
			GizmoHandle.NativeMethodInfoPtr_SetAll3DShapesVisible_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664205);
			GizmoHandle.NativeMethodInfoPtr_Set3DShapeVisible_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664206);
			GizmoHandle.NativeMethodInfoPtr_Is3DShapeVisible_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664207);
			GizmoHandle.NativeMethodInfoPtr_Set3DShapeHoverable_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664208);
			GizmoHandle.NativeMethodInfoPtr_SetAll2DShapesVisible_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664209);
			GizmoHandle.NativeMethodInfoPtr_Set2DShapeVisible_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664210);
			GizmoHandle.NativeMethodInfoPtr_Is2DShapeVisible_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664211);
			GizmoHandle.NativeMethodInfoPtr_Set2DShapeHoverable_Public_Virtual_Final_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664212);
			GizmoHandle.NativeMethodInfoPtr_Contains3DShape_Public_Virtual_Final_New_Boolean_Shape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664213);
			GizmoHandle.NativeMethodInfoPtr_Contains2DShape_Public_Virtual_Final_New_Boolean_Shape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664214);
			GizmoHandle.NativeMethodInfoPtr_Add3DShape_Public_Virtual_Final_New_Int32_Shape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664215);
			GizmoHandle.NativeMethodInfoPtr_Add2DShape_Public_Virtual_Final_New_Int32_Shape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664216);
			GizmoHandle.NativeMethodInfoPtr_Remove3DShape_Public_Virtual_Final_New_Void_Shape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664217);
			GizmoHandle.NativeMethodInfoPtr_Remove2DShape_Public_Virtual_Final_New_Void_Shape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664218);
			GizmoHandle.NativeMethodInfoPtr_Render3DSolid_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664219);
			GizmoHandle.NativeMethodInfoPtr_Render3DWire_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664220);
			GizmoHandle.NativeMethodInfoPtr_Render3DSolid_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664221);
			GizmoHandle.NativeMethodInfoPtr_Render3DWire_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664222);
			GizmoHandle.NativeMethodInfoPtr_Render2DSolid_Public_Virtual_Final_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664223);
			GizmoHandle.NativeMethodInfoPtr_Render2DWire_Public_Virtual_Final_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664224);
			GizmoHandle.NativeMethodInfoPtr_Render2DSolid_Public_Virtual_Final_New_Void_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664225);
			GizmoHandle.NativeMethodInfoPtr_Render2DWire_Public_Virtual_Final_New_Void_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664226);
			GizmoHandle.NativeMethodInfoPtr_GetHoverData_Public_Virtual_Final_New_GizmoHandleHoverData_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, 100664227);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x000390E8 File Offset: 0x000372E8
		public unsafe virtual int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00039124 File Offset: 0x00037324
		public unsafe virtual Gizmo Gizmo
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Gizmo_Public_Virtual_Final_New_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00039164 File Offset: 0x00037364
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x000391A4 File Offset: 0x000373A4
		public unsafe virtual IGizmoDragSession DragSession
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_DragSession_Public_Virtual_Final_New_get_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_set_DragSession_Public_Virtual_Final_New_set_Void_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x000391E8 File Offset: 0x000373E8
		public unsafe virtual Priority GenericHoverPriority
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Virtual_Final_New_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00039228 File Offset: 0x00037428
		public unsafe virtual Priority HoverPriority2D
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_HoverPriority2D_Public_Virtual_Final_New_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00039268 File Offset: 0x00037468
		public unsafe virtual Priority HoverPriority3D
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_HoverPriority3D_Public_Virtual_Final_New_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x000392A8 File Offset: 0x000374A8
		public unsafe virtual int Num3DShapes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60874, XrefRangeEnd = 60875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Num3DShapes_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x000392E4 File Offset: 0x000374E4
		public unsafe virtual int Num2DShapes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60875, XrefRangeEnd = 60876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Num2DShapes_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00039320 File Offset: 0x00037520
		public unsafe virtual bool Has3DShapes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60876, XrefRangeEnd = 60877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Has3DShapes_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0003935C File Offset: 0x0003755C
		public unsafe virtual bool Has2DShapes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60877, XrefRangeEnd = 60878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Has2DShapes_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00039398 File Offset: 0x00037598
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x000393D4 File Offset: 0x000375D4
		public unsafe virtual bool Is2DHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Is2DHoverable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_set_Is2DHoverable_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00039414 File Offset: 0x00037614
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00039450 File Offset: 0x00037650
		public unsafe virtual bool Is3DHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Is3DHoverable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_set_Is3DHoverable_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00039490 File Offset: 0x00037690
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x000394CC File Offset: 0x000376CC
		public unsafe virtual bool Is2DVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Is2DVisible_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_set_Is2DVisible_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0003950C File Offset: 0x0003770C
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00039548 File Offset: 0x00037748
		public unsafe virtual bool Is3DVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_get_Is3DVisible_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_set_Is3DVisible_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00039588 File Offset: 0x00037788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60878, XrefRangeEnd = 60908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoHandle(Gizmo gizmo, int id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000395E4 File Offset: 0x000377E4
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 60912, RefRangeEnd = 60941, XrefRangeStart = 60908, XrefRangeEnd = 60912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_GetZoomFactor_Public_Virtual_Final_New_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00039634 File Offset: 0x00037834
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 60943, RefRangeEnd = 60950, XrefRangeStart = 60941, XrefRangeEnd = 60943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetZoomFactorTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Virtual_Final_New_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00039678 File Offset: 0x00037878
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 60950, RefRangeEnd = 60954, XrefRangeStart = 60950, XrefRangeEnd = 60950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_SetHoverable_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000396B8 File Offset: 0x000378B8
		[CallerCount(0)]
		public unsafe virtual void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_SetVisible_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000396F8 File Offset: 0x000378F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60957, RefRangeEnd = 60959, XrefRangeStart = 60954, XrefRangeEnd = 60957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Shape3D Get3DShape(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Get3DShape_Public_Virtual_Final_New_Shape3D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape3D>(intPtr3) : null;
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00039744 File Offset: 0x00037944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60959, XrefRangeEnd = 60962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Shape2D Get2DShape(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Get2DShape_Public_Virtual_Final_New_Shape2D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shape2D>(intPtr3) : null;
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00039790 File Offset: 0x00037990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60962, XrefRangeEnd = 60976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAll3DShapesVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_SetAll3DShapesVisible_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000397D0 File Offset: 0x000379D0
		[CallerCount(78)]
		[CachedScanResults(RefRangeStart = 60979, RefRangeEnd = 61057, XrefRangeStart = 60976, XrefRangeEnd = 60979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Set3DShapeVisible_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0003981C File Offset: 0x00037A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61057, XrefRangeEnd = 61060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Is3DShapeVisible(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Is3DShapeVisible_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00039868 File Offset: 0x00037A68
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 61063, RefRangeEnd = 61072, XrefRangeStart = 61060, XrefRangeEnd = 61063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Set3DShapeHoverable_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000398B4 File Offset: 0x00037AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61072, XrefRangeEnd = 61086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAll2DShapesVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_SetAll2DShapesVisible_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000398F4 File Offset: 0x00037AF4
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 61089, RefRangeEnd = 61117, XrefRangeStart = 61086, XrefRangeEnd = 61089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Set2DShapeVisible_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00039940 File Offset: 0x00037B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61117, XrefRangeEnd = 61120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Is2DShapeVisible(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Is2DShapeVisible_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0003998C File Offset: 0x00037B8C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 61123, RefRangeEnd = 61130, XrefRangeStart = 61120, XrefRangeEnd = 61123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Set2DShapeHoverable_Public_Virtual_Final_New_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000399D8 File Offset: 0x00037BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61130, XrefRangeEnd = 61145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains3DShape(Shape3D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Contains3DShape_Public_Virtual_Final_New_Boolean_Shape3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00039A28 File Offset: 0x00037C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61145, XrefRangeEnd = 61160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains2DShape(Shape2D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Contains2DShape_Public_Virtual_Final_New_Boolean_Shape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00039A78 File Offset: 0x00037C78
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 61178, RefRangeEnd = 61202, XrefRangeStart = 61160, XrefRangeEnd = 61178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Add3DShape(Shape3D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Add3DShape_Public_Virtual_Final_New_Int32_Shape3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00039AC8 File Offset: 0x00037CC8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 61220, RefRangeEnd = 61234, XrefRangeStart = 61202, XrefRangeEnd = 61220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Add2DShape(Shape2D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Add2DShape_Public_Virtual_Final_New_Int32_Shape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00039B18 File Offset: 0x00037D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61234, XrefRangeEnd = 61249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove3DShape(Shape3D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Remove3DShape_Public_Virtual_Final_New_Void_Shape3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00039B5C File Offset: 0x00037D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61249, XrefRangeEnd = 61264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove2DShape(Shape2D shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Remove2DShape_Public_Virtual_Final_New_Void_Shape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00039BA0 File Offset: 0x00037DA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61278, RefRangeEnd = 61280, XrefRangeStart = 61264, XrefRangeEnd = 61278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Render3DSolid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Render3DSolid_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00039BD4 File Offset: 0x00037DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61294, RefRangeEnd = 61296, XrefRangeStart = 61280, XrefRangeEnd = 61294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Render3DWire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Render3DWire_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00039C08 File Offset: 0x00037E08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61299, RefRangeEnd = 61301, XrefRangeStart = 61296, XrefRangeEnd = 61299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Render3DSolid(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Render3DSolid_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00039C48 File Offset: 0x00037E48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 61304, RefRangeEnd = 61308, XrefRangeStart = 61301, XrefRangeEnd = 61304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Render3DWire(int shapeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shapeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Render3DWire_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00039C88 File Offset: 0x00037E88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 61322, RefRangeEnd = 61325, XrefRangeStart = 61308, XrefRangeEnd = 61322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Render2DSolid(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Render2DSolid_Public_Virtual_Final_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00039CCC File Offset: 0x00037ECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61339, RefRangeEnd = 61341, XrefRangeStart = 61325, XrefRangeEnd = 61339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Render2DWire(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Render2DWire_Public_Virtual_Final_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00039D10 File Offset: 0x00037F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61341, XrefRangeEnd = 61344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Render2DSolid_Public_Virtual_Final_New_Void_Camera_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00039D60 File Offset: 0x00037F60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 61347, RefRangeEnd = 61350, XrefRangeStart = 61344, XrefRangeEnd = 61347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_Render2DWire_Public_Virtual_Final_New_Void_Camera_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00039DB0 File Offset: 0x00037FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61350, XrefRangeEnd = 61409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GizmoHandleHoverData GetHoverData(Ray hoverRay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoverRay);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.NativeMethodInfoPtr_GetHoverData_Public_Virtual_Final_New_GizmoHandleHoverData_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoHandleHoverData>(intPtr3) : null;
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000043B3 File Offset: 0x000025B3
		public GizmoHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00039E00 File Offset: 0x00038000
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x000043BC File Offset: 0x000025BC
		public unsafe GizmoHandleCanHoverHandler CanHover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr_CanHover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandleCanHoverHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr_CanHover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00039E30 File Offset: 0x00038030
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x000043DB File Offset: 0x000025DB
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00039E58 File Offset: 0x00038058
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x000043F6 File Offset: 0x000025F6
		public unsafe Gizmo _gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00039E88 File Offset: 0x00038088
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00004415 File Offset: 0x00002615
		public unsafe GizmoTransform _zoomFactorTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__zoomFactorTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__zoomFactorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00039EB8 File Offset: 0x000380B8
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00004434 File Offset: 0x00002634
		public unsafe Priority _genericHoverPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__genericHoverPriority);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__genericHoverPriority), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00039EE8 File Offset: 0x000380E8
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00004453 File Offset: 0x00002653
		public unsafe Priority _hoverPriority2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__hoverPriority2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__hoverPriority2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00039F18 File Offset: 0x00038118
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00004472 File Offset: 0x00002672
		public unsafe Priority _hoverPriority3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__hoverPriority3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__hoverPriority3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00039F48 File Offset: 0x00038148
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00004491 File Offset: 0x00002691
		public unsafe List<GizmoHandleShape3D> _3DShapes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__3DShapes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoHandleShape3D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__3DShapes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00039F78 File Offset: 0x00038178
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x000044B0 File Offset: 0x000026B0
		public unsafe List<GizmoHandleShape2D> _2DShapes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__2DShapes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoHandleShape2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__2DShapes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00039FA8 File Offset: 0x000381A8
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x000044CF File Offset: 0x000026CF
		public unsafe IGizmoDragSession _DragSession_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__DragSession_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__DragSession_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00039FD8 File Offset: 0x000381D8
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x000044EE File Offset: 0x000026EE
		public unsafe bool _Is2DHoverable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__Is2DHoverable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__Is2DHoverable_k__BackingField)) = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0003A000 File Offset: 0x00038200
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00004509 File Offset: 0x00002709
		public unsafe bool _Is3DHoverable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__Is3DHoverable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__Is3DHoverable_k__BackingField)) = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0003A028 File Offset: 0x00038228
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00004524 File Offset: 0x00002724
		public unsafe bool _Is2DVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__Is2DVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__Is2DVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0003A050 File Offset: 0x00038250
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x0000453F File Offset: 0x0000273F
		public unsafe bool _Is3DVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__Is3DVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.NativeFieldInfoPtr__Is3DVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr_CanHover;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeFieldInfoPtr__gizmo;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr__zoomFactorTransform;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr__genericHoverPriority;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr__hoverPriority2D;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeFieldInfoPtr__hoverPriority3D;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr__3DShapes;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr__2DShapes;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeFieldInfoPtr__DragSession_k__BackingField;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr__Is2DHoverable_k__BackingField;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr__Is3DHoverable_k__BackingField;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr__Is2DVisible_k__BackingField;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr__Is3DVisible_k__BackingField;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_Virtual_Final_New_get_Gizmo_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSession_Public_Virtual_Final_New_get_IGizmoDragSession_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_set_DragSession_Public_Virtual_Final_New_set_Void_IGizmoDragSession_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericHoverPriority_Public_Virtual_Final_New_get_Priority_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority2D_Public_Virtual_Final_New_get_Priority_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority3D_Public_Virtual_Final_New_get_Priority_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_get_Num3DShapes_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_get_Num2DShapes_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_get_Has3DShapes_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_get_Has2DShapes_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_get_Is2DHoverable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_set_Is2DHoverable_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_get_Is3DHoverable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_set_Is3DHoverable_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_get_Is2DVisible_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_set_Is2DVisible_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_get_Is3DVisible_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_set_Is3DVisible_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Virtual_Final_New_Single_Camera_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_SetZoomFactorTransform_Public_Virtual_Final_New_Void_GizmoTransform_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_Get3DShape_Public_Virtual_Final_New_Shape3D_Int32_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_Get2DShape_Public_Virtual_Final_New_Shape2D_Int32_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_SetAll3DShapesVisible_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_Set3DShapeVisible_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_Is3DShapeVisible_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_Set3DShapeHoverable_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_SetAll2DShapesVisible_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_Set2DShapeVisible_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_Is2DShapeVisible_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_Set2DShapeHoverable_Public_Virtual_Final_New_Void_Int32_Boolean_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_Contains3DShape_Public_Virtual_Final_New_Boolean_Shape3D_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_Contains2DShape_Public_Virtual_Final_New_Boolean_Shape2D_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_Add3DShape_Public_Virtual_Final_New_Int32_Shape3D_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_Add2DShape_Public_Virtual_Final_New_Int32_Shape2D_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_Remove3DShape_Public_Virtual_Final_New_Void_Shape3D_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_Remove2DShape_Public_Virtual_Final_New_Void_Shape2D_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_Render3DSolid_Public_Virtual_Final_New_Void_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_Render3DWire_Public_Virtual_Final_New_Void_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_Render3DSolid_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_Render3DWire_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_Render2DSolid_Public_Virtual_Final_New_Void_Camera_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_Render2DWire_Public_Virtual_Final_New_Void_Camera_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_Render2DSolid_Public_Virtual_Final_New_Void_Camera_Int32_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_Render2DWire_Public_Virtual_Final_New_Void_Camera_Int32_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_GetHoverData_Public_Virtual_Final_New_GizmoHandleHoverData_Ray_0;

		// Token: 0x0200035F RID: 863
		[ObfuscatedName("RLD.GizmoHandle+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049A4 RID: 18852 RVA: 0x001452C8 File Offset: 0x001434C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass62_0>.NativeClassPtr);
				GizmoHandle.__c__DisplayClass62_0.NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass62_0>.NativeClassPtr, "shape");
				GizmoHandle.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass62_0>.NativeClassPtr, 100664228);
				GizmoHandle.__c__DisplayClass62_0.NativeMethodInfoPtr__Contains3DShape_b__0_Internal_Boolean_GizmoHandleShape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass62_0>.NativeClassPtr, 100664229);
			}

			// Token: 0x060049A5 RID: 18853 RVA: 0x00145330 File Offset: 0x00143530
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049A6 RID: 18854 RVA: 0x0014536C File Offset: 0x0014356C
			[CallerCount(0)]
			public unsafe bool _Contains3DShape_b__0(GizmoHandleShape3D item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.__c__DisplayClass62_0.NativeMethodInfoPtr__Contains3DShape_b__0_Internal_Boolean_GizmoHandleShape3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049A7 RID: 18855 RVA: 0x0001B63A File Offset: 0x0001983A
			public __c__DisplayClass62_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018FA RID: 6394
			// (get) Token: 0x060049A8 RID: 18856 RVA: 0x001453BC File Offset: 0x001435BC
			// (set) Token: 0x060049A9 RID: 18857 RVA: 0x0001B643 File Offset: 0x00019843
			public unsafe Shape3D shape
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.__c__DisplayClass62_0.NativeFieldInfoPtr_shape);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape3D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.__c__DisplayClass62_0.NativeFieldInfoPtr_shape), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003938 RID: 14648
			private static readonly IntPtr NativeFieldInfoPtr_shape;

			// Token: 0x04003939 RID: 14649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400393A RID: 14650
			private static readonly IntPtr NativeMethodInfoPtr__Contains3DShape_b__0_Internal_Boolean_GizmoHandleShape3D_0;
		}

		// Token: 0x02000360 RID: 864
		[ObfuscatedName("RLD.GizmoHandle+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049AA RID: 18858 RVA: 0x001453EC File Offset: 0x001435EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass63_0>.NativeClassPtr);
				GizmoHandle.__c__DisplayClass63_0.NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass63_0>.NativeClassPtr, "shape");
				GizmoHandle.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass63_0>.NativeClassPtr, 100664230);
				GizmoHandle.__c__DisplayClass63_0.NativeMethodInfoPtr__Contains2DShape_b__0_Internal_Boolean_GizmoHandleShape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass63_0>.NativeClassPtr, 100664231);
			}

			// Token: 0x060049AB RID: 18859 RVA: 0x00145454 File Offset: 0x00143654
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049AC RID: 18860 RVA: 0x00145490 File Offset: 0x00143690
			[CallerCount(0)]
			public unsafe bool _Contains2DShape_b__0(GizmoHandleShape2D item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.__c__DisplayClass63_0.NativeMethodInfoPtr__Contains2DShape_b__0_Internal_Boolean_GizmoHandleShape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049AD RID: 18861 RVA: 0x0001B662 File Offset: 0x00019862
			public __c__DisplayClass63_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018FB RID: 6395
			// (get) Token: 0x060049AE RID: 18862 RVA: 0x001454E0 File Offset: 0x001436E0
			// (set) Token: 0x060049AF RID: 18863 RVA: 0x0001B66B File Offset: 0x0001986B
			public unsafe Shape2D shape
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.__c__DisplayClass63_0.NativeFieldInfoPtr_shape);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.__c__DisplayClass63_0.NativeFieldInfoPtr_shape), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400393B RID: 14651
			private static readonly IntPtr NativeFieldInfoPtr_shape;

			// Token: 0x0400393C RID: 14652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400393D RID: 14653
			private static readonly IntPtr NativeMethodInfoPtr__Contains2DShape_b__0_Internal_Boolean_GizmoHandleShape2D_0;
		}

		// Token: 0x02000361 RID: 865
		[ObfuscatedName("RLD.GizmoHandle+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049B0 RID: 18864 RVA: 0x00145510 File Offset: 0x00143710
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass66_0>.NativeClassPtr);
				GizmoHandle.__c__DisplayClass66_0.NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass66_0>.NativeClassPtr, "shape");
				GizmoHandle.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass66_0>.NativeClassPtr, 100664232);
				GizmoHandle.__c__DisplayClass66_0.NativeMethodInfoPtr__Remove3DShape_b__0_Internal_Boolean_GizmoHandleShape3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass66_0>.NativeClassPtr, 100664233);
			}

			// Token: 0x060049B1 RID: 18865 RVA: 0x00145578 File Offset: 0x00143778
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049B2 RID: 18866 RVA: 0x001455B4 File Offset: 0x001437B4
			[CallerCount(0)]
			public unsafe bool _Remove3DShape_b__0(GizmoHandleShape3D item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.__c__DisplayClass66_0.NativeMethodInfoPtr__Remove3DShape_b__0_Internal_Boolean_GizmoHandleShape3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049B3 RID: 18867 RVA: 0x0001B68A File Offset: 0x0001988A
			public __c__DisplayClass66_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018FC RID: 6396
			// (get) Token: 0x060049B4 RID: 18868 RVA: 0x00145604 File Offset: 0x00143804
			// (set) Token: 0x060049B5 RID: 18869 RVA: 0x0001B693 File Offset: 0x00019893
			public unsafe Shape3D shape
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.__c__DisplayClass66_0.NativeFieldInfoPtr_shape);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape3D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.__c__DisplayClass66_0.NativeFieldInfoPtr_shape), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400393E RID: 14654
			private static readonly IntPtr NativeFieldInfoPtr_shape;

			// Token: 0x0400393F RID: 14655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003940 RID: 14656
			private static readonly IntPtr NativeMethodInfoPtr__Remove3DShape_b__0_Internal_Boolean_GizmoHandleShape3D_0;
		}

		// Token: 0x02000362 RID: 866
		[ObfuscatedName("RLD.GizmoHandle+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049B6 RID: 18870 RVA: 0x00145634 File Offset: 0x00143834
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoHandle>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass67_0>.NativeClassPtr);
				GizmoHandle.__c__DisplayClass67_0.NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass67_0>.NativeClassPtr, "shape");
				GizmoHandle.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass67_0>.NativeClassPtr, 100664234);
				GizmoHandle.__c__DisplayClass67_0.NativeMethodInfoPtr__Remove2DShape_b__0_Internal_Boolean_GizmoHandleShape2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass67_0>.NativeClassPtr, 100664235);
			}

			// Token: 0x060049B7 RID: 18871 RVA: 0x0014569C File Offset: 0x0014389C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoHandle.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049B8 RID: 18872 RVA: 0x001456D8 File Offset: 0x001438D8
			[CallerCount(0)]
			public unsafe bool _Remove2DShape_b__0(GizmoHandleShape2D item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoHandle.__c__DisplayClass67_0.NativeMethodInfoPtr__Remove2DShape_b__0_Internal_Boolean_GizmoHandleShape2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049B9 RID: 18873 RVA: 0x0001B6B2 File Offset: 0x000198B2
			public __c__DisplayClass67_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018FD RID: 6397
			// (get) Token: 0x060049BA RID: 18874 RVA: 0x00145728 File Offset: 0x00143928
			// (set) Token: 0x060049BB RID: 18875 RVA: 0x0001B6BB File Offset: 0x000198BB
			public unsafe Shape2D shape
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.__c__DisplayClass67_0.NativeFieldInfoPtr_shape);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shape2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoHandle.__c__DisplayClass67_0.NativeFieldInfoPtr_shape), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003941 RID: 14657
			private static readonly IntPtr NativeFieldInfoPtr_shape;

			// Token: 0x04003942 RID: 14658
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003943 RID: 14659
			private static readonly IntPtr NativeMethodInfoPtr__Remove2DShape_b__0_Internal_Boolean_GizmoHandleShape2D_0;
		}
	}
}
