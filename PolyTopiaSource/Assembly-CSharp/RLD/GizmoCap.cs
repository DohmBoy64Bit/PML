using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000022 RID: 34
	public class GizmoCap : global::Il2CppSystem.Object
	{
		// Token: 0x06000250 RID: 592 RVA: 0x00029DD0 File Offset: 0x00027FD0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCap()
		{
			Il2CppClassPointerStore<GizmoCap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr);
			GizmoCap.NativeFieldInfoPtr__gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, "_gizmo");
			GizmoCap.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, "_handle");
			GizmoCap.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, "_isVisible");
			GizmoCap.NativeFieldInfoPtr__isHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, "_isHoverable");
			GizmoCap.NativeMethodInfoPtr_get_Handle_Protected_get_GizmoHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663624);
			GizmoCap.NativeMethodInfoPtr_get_Gizmo_Public_Virtual_Final_New_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663625);
			GizmoCap.NativeMethodInfoPtr_get_HandleId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663626);
			GizmoCap.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663627);
			GizmoCap.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663628);
			GizmoCap.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663629);
			GizmoCap.NativeMethodInfoPtr_get_HoverPriority3D_Public_Virtual_Final_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663630);
			GizmoCap.NativeMethodInfoPtr_get_HoverPriority2D_Public_Virtual_Final_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663631);
			GizmoCap.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Virtual_Final_New_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663632);
			GizmoCap.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663633);
			GizmoCap.NativeMethodInfoPtr_SetVisible_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663634);
			GizmoCap.NativeMethodInfoPtr_SetHoverable_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663635);
			GizmoCap.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663636);
			GizmoCap.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663637);
			GizmoCap.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr, 100663638);
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00029F7C File Offset: 0x0002817C
		public unsafe GizmoHandle Handle
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_get_Handle_Protected_get_GizmoHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr3) : null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00029FBC File Offset: 0x000281BC
		public unsafe virtual Gizmo Gizmo
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_get_Gizmo_Public_Virtual_Final_New_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00029FFC File Offset: 0x000281FC
		public unsafe virtual int HandleId
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 57996, RefRangeEnd = 58044, XrefRangeStart = 57996, XrefRangeEnd = 57996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_get_HandleId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0002A038 File Offset: 0x00028238
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0002A074 File Offset: 0x00028274
		public unsafe bool IsHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0002A0B0 File Offset: 0x000282B0
		public unsafe bool IsHovered
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 58045, RefRangeEnd = 58046, XrefRangeStart = 58044, XrefRangeEnd = 58045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0002A0EC File Offset: 0x000282EC
		public unsafe virtual Priority HoverPriority3D
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 58046, RefRangeEnd = 58052, XrefRangeStart = 58046, XrefRangeEnd = 58046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_get_HoverPriority3D_Public_Virtual_Final_New_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0002A12C File Offset: 0x0002832C
		public unsafe virtual Priority HoverPriority2D
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58052, RefRangeEnd = 58054, XrefRangeStart = 58052, XrefRangeEnd = 58052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_get_HoverPriority2D_Public_Virtual_Final_New_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0002A16C File Offset: 0x0002836C
		public unsafe virtual Priority GenericHoverPriority
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58054, RefRangeEnd = 58056, XrefRangeStart = 58054, XrefRangeEnd = 58054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_get_GenericHoverPriority_Public_Virtual_Final_New_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0002A1AC File Offset: 0x000283AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58056, XrefRangeEnd = 58061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCap(Gizmo gizmo, int handleId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0002A208 File Offset: 0x00028408
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 58061, RefRangeEnd = 58097, XrefRangeStart = 58061, XrefRangeEnd = 58061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_SetVisible_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0002A248 File Offset: 0x00028448
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 58097, RefRangeEnd = 58106, XrefRangeStart = 58097, XrefRangeEnd = 58097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap.NativeMethodInfoPtr_SetHoverable_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0002A288 File Offset: 0x00028488
		[CallerCount(0)]
		public unsafe virtual void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCap.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0002A2D8 File Offset: 0x000284D8
		[CallerCount(0)]
		public unsafe virtual void OnVisibilityStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCap.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0002A314 File Offset: 0x00028514
		[CallerCount(0)]
		public unsafe virtual void OnHoverableStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoCap.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002E20 File Offset: 0x00001020
		public GizmoCap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0002A350 File Offset: 0x00028550
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00002E29 File Offset: 0x00001029
		public unsafe Gizmo _gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap.NativeFieldInfoPtr__gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap.NativeFieldInfoPtr__gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0002A380 File Offset: 0x00028580
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00002E48 File Offset: 0x00001048
		public unsafe GizmoHandle _handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap.NativeFieldInfoPtr__handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap.NativeFieldInfoPtr__handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0002A3B0 File Offset: 0x000285B0
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002E67 File Offset: 0x00001067
		public unsafe bool _isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap.NativeFieldInfoPtr__isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap.NativeFieldInfoPtr__isVisible)) = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0002A3D8 File Offset: 0x000285D8
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00002E82 File Offset: 0x00001082
		public unsafe bool _isHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap.NativeFieldInfoPtr__isHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap.NativeFieldInfoPtr__isHoverable)) = value;
			}
		}

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr__gizmo;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr__handle;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr__isVisible;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr__isHoverable;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Protected_get_GizmoHandle_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_Virtual_Final_New_get_Gizmo_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleId_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoverable_Public_get_Boolean_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority3D_Public_Virtual_Final_New_get_Priority_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority2D_Public_Virtual_Final_New_get_Priority_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericHoverPriority_Public_Virtual_Final_New_get_Priority_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_Camera_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Abstract_Virtual_New_Void_0;
	}
}
