using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000D7 RID: 215
	public class GizmoSlider : global::Il2CppSystem.Object
	{
		// Token: 0x06001137 RID: 4407 RVA: 0x00061630 File Offset: 0x0005F830
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoSlider()
		{
			Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr);
			GizmoSlider.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, "_handle");
			GizmoSlider.NativeFieldInfoPtr__gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, "_gizmo");
			GizmoSlider.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, "_isVisible");
			GizmoSlider.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, "_isHoverable");
			GizmoSlider.NativeMethodInfoPtr_get_Handle_Protected_get_GizmoHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665639);
			GizmoSlider.NativeMethodInfoPtr_get_Gizmo_Public_Virtual_Final_New_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665640);
			GizmoSlider.NativeMethodInfoPtr_get_HandleId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665641);
			GizmoSlider.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665642);
			GizmoSlider.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665643);
			GizmoSlider.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665644);
			GizmoSlider.NativeMethodInfoPtr_get_HoverPriority3D_Public_Virtual_Final_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665645);
			GizmoSlider.NativeMethodInfoPtr_get_HoverPriority2D_Public_Virtual_Final_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665646);
			GizmoSlider.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Virtual_Final_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665647);
			GizmoSlider.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665648);
			GizmoSlider.NativeMethodInfoPtr_SetVisible_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665649);
			GizmoSlider.NativeMethodInfoPtr_SetHoverable_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665650);
			GizmoSlider.NativeMethodInfoPtr_SetSnapEnabled_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665651);
			GizmoSlider.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665652);
			GizmoSlider.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665653);
			GizmoSlider.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr, 100665654);
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x000617F0 File Offset: 0x0005F9F0
		public unsafe GizmoHandle Handle
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_get_Handle_Protected_get_GizmoHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00061830 File Offset: 0x0005FA30
		public unsafe virtual Gizmo Gizmo
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_get_Gizmo_Public_Virtual_Final_New_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00061870 File Offset: 0x0005FA70
		public unsafe virtual int HandleId
		{
			[CallerCount(68)]
			[CachedScanResults(RefRangeStart = 69429, RefRangeEnd = 69497, XrefRangeStart = 69429, XrefRangeEnd = 69429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_get_HandleId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x000618AC File Offset: 0x0005FAAC
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x000618E8 File Offset: 0x0005FAE8
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x00061924 File Offset: 0x0005FB24
		public unsafe bool IsHovered
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 69498, RefRangeEnd = 69499, XrefRangeStart = 69497, XrefRangeEnd = 69498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x00061960 File Offset: 0x0005FB60
		public unsafe virtual Priority HoverPriority3D
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 69499, RefRangeEnd = 69511, XrefRangeStart = 69499, XrefRangeEnd = 69499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_get_HoverPriority3D_Public_Virtual_Final_New_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x000619A0 File Offset: 0x0005FBA0
		public unsafe virtual Priority HoverPriority2D
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 25777, RefRangeEnd = 25826, XrefRangeStart = 25777, XrefRangeEnd = 25826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_get_HoverPriority2D_Public_Virtual_Final_New_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000619E0 File Offset: 0x0005FBE0
		public unsafe virtual Priority GenericHoverPriority
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 69511, RefRangeEnd = 69513, XrefRangeStart = 69511, XrefRangeEnd = 69511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Virtual_Final_New_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00061A20 File Offset: 0x0005FC20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 69518, RefRangeEnd = 69522, XrefRangeStart = 69513, XrefRangeEnd = 69518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoSlider(Gizmo gizmo, int handleId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoSlider>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00061A7C File Offset: 0x0005FC7C
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 69522, RefRangeEnd = 69556, XrefRangeStart = 69522, XrefRangeEnd = 69522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_SetVisible_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00061ABC File Offset: 0x0005FCBC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 69556, RefRangeEnd = 69570, XrefRangeStart = 69556, XrefRangeEnd = 69556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSlider.NativeMethodInfoPtr_SetHoverable_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00061AFC File Offset: 0x0005FCFC
		[CallerCount(0)]
		public unsafe virtual void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSlider.NativeMethodInfoPtr_SetSnapEnabled_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00061B48 File Offset: 0x0005FD48
		[CallerCount(0)]
		public unsafe virtual void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSlider.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00061B98 File Offset: 0x0005FD98
		[CallerCount(0)]
		public unsafe virtual void OnVisibilityStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSlider.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00061BD4 File Offset: 0x0005FDD4
		[CallerCount(0)]
		public unsafe virtual void OnHoverableStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSlider.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00008BB9 File Offset: 0x00006DB9
		public GizmoSlider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00061C10 File Offset: 0x0005FE10
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x00008BC2 File Offset: 0x00006DC2
		public unsafe GizmoHandle _handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSlider.NativeFieldInfoPtr__handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSlider.NativeFieldInfoPtr__handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00061C40 File Offset: 0x0005FE40
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x00008BE1 File Offset: 0x00006DE1
		public unsafe Gizmo _gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSlider.NativeFieldInfoPtr__gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSlider.NativeFieldInfoPtr__gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00061C70 File Offset: 0x0005FE70
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x00008C00 File Offset: 0x00006E00
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSlider.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSlider.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00061C98 File Offset: 0x0005FE98
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00008C1B File Offset: 0x00006E1B
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSlider.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSlider.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeFieldInfoPtr__handle;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeFieldInfoPtr__gizmo;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Protected_get_GizmoHandle_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_Virtual_Final_New_get_Gizmo_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleId_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority3D_Public_Virtual_Final_New_get_Priority_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority2D_Public_Virtual_Final_New_get_Priority_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericHoverPriority_Public_Virtual_Final_New_get_Priority_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Abstract_Virtual_New_Void_0;
	}
}
