using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000086 RID: 134
	public class GizmoLineSlider2DCollection : global::Il2CppSystem.Object
	{
		// Token: 0x06000A82 RID: 2690 RVA: 0x0004A0C8 File Offset: 0x000482C8
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider2DCollection()
		{
			Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider2DCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr);
			GizmoLineSlider2DCollection.NativeFieldInfoPtr__sliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, "_sliders");
			GizmoLineSlider2DCollection.NativeFieldInfoPtr__handleIdToSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, "_handleIdToSlider");
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664870);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoLineSlider2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664871);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664884);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoLineSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664872);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664873);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_ContainsCapId_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664874);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoLineSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664875);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoLineSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664876);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_Make2DHoverPriorityLowerThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664877);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_Make2DHoverPriorityHigherThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664878);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664879);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664880);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_Set2DCapsVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664881);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_SetOffsetDragOrigin_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664882);
			GizmoLineSlider2DCollection.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, 100664883);
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0004A24C File Offset: 0x0004844C
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65545, XrefRangeEnd = 65546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039F RID: 927
		public unsafe GizmoLineSlider2D this[int id]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65546, XrefRangeEnd = 65550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoLineSlider2D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0004A2D4 File Offset: 0x000484D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65565, RefRangeEnd = 65567, XrefRangeStart = 65550, XrefRangeEnd = 65565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider2DCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0004A310 File Offset: 0x00048510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65567, XrefRangeEnd = 65572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(GizmoLineSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoLineSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0004A360 File Offset: 0x00048560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65576, RefRangeEnd = 65578, XrefRangeStart = 65572, XrefRangeEnd = 65576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(int sliderHandleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sliderHandleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0004A3AC File Offset: 0x000485AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65592, RefRangeEnd = 65594, XrefRangeStart = 65578, XrefRangeEnd = 65592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsCapId(int capHandleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capHandleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_ContainsCapId_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0004A3F8 File Offset: 0x000485F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 65607, RefRangeEnd = 65615, XrefRangeStart = 65594, XrefRangeEnd = 65607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(GizmoLineSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoLineSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0004A43C File Offset: 0x0004863C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65615, XrefRangeEnd = 65626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(GizmoLineSlider2D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoLineSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0004A480 File Offset: 0x00048680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65626, XrefRangeEnd = 65642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make2DHoverPriorityLowerThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_Make2DHoverPriorityLowerThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0004A4C4 File Offset: 0x000486C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65642, XrefRangeEnd = 65658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make2DHoverPriorityHigherThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_Make2DHoverPriorityHigherThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0004A508 File Offset: 0x00048708
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 65672, RefRangeEnd = 65676, XrefRangeStart = 65658, XrefRangeEnd = 65672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0004A548 File Offset: 0x00048748
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 65691, RefRangeEnd = 65694, XrefRangeStart = 65676, XrefRangeEnd = 65691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0004A588 File Offset: 0x00048788
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 65709, RefRangeEnd = 65712, XrefRangeStart = 65694, XrefRangeEnd = 65709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set2DCapsVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_Set2DCapsVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0004A5C8 File Offset: 0x000487C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65712, XrefRangeEnd = 65726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOffsetDragOrigin(Vector3 dragOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragOrigin);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_SetOffsetDragOrigin_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0004A60C File Offset: 0x0004880C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65740, RefRangeEnd = 65742, XrefRangeStart = 65726, XrefRangeEnd = 65740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00005A23 File Offset: 0x00003C23
		public GizmoLineSlider2DCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0004A650 File Offset: 0x00048850
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00005A2C File Offset: 0x00003C2C
		public unsafe List<GizmoLineSlider2D> _sliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DCollection.NativeFieldInfoPtr__sliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoLineSlider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DCollection.NativeFieldInfoPtr__sliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0004A680 File Offset: 0x00048880
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00005A4B File Offset: 0x00003C4B
		public unsafe Dictionary<int, GizmoLineSlider2D> _handleIdToSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DCollection.NativeFieldInfoPtr__handleIdToSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GizmoLineSlider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DCollection.NativeFieldInfoPtr__handleIdToSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr__sliders;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr__handleIdToSlider;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_GizmoLineSlider2D_Int32_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_GizmoLineSlider2D_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_ContainsCapId_Public_Boolean_Int32_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_GizmoLineSlider2D_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_GizmoLineSlider2D_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_Make2DHoverPriorityLowerThan_Public_Void_Priority_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_Make2DHoverPriorityHigherThan_Public_Void_Priority_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_Set2DCapsVisible_Public_Void_Boolean_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_SetOffsetDragOrigin_Public_Void_Vector3_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;

		// Token: 0x0200036B RID: 875
		[ObfuscatedName("RLD.GizmoLineSlider2DCollection+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049E2 RID: 18914 RVA: 0x00145E70 File Offset: 0x00144070
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<GizmoLineSlider2DCollection.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoLineSlider2DCollection>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider2DCollection.__c__DisplayClass8_0>.NativeClassPtr);
				GizmoLineSlider2DCollection.__c__DisplayClass8_0.NativeFieldInfoPtr_capHandleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2DCollection.__c__DisplayClass8_0>.NativeClassPtr, "capHandleId");
				GizmoLineSlider2DCollection.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection.__c__DisplayClass8_0>.NativeClassPtr, 100664885);
				GizmoLineSlider2DCollection.__c__DisplayClass8_0.NativeMethodInfoPtr__ContainsCapId_b__0_Internal_Boolean_GizmoLineSlider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2DCollection.__c__DisplayClass8_0>.NativeClassPtr, 100664886);
			}

			// Token: 0x060049E3 RID: 18915 RVA: 0x00145ED8 File Offset: 0x001440D8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider2DCollection.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049E4 RID: 18916 RVA: 0x00145F14 File Offset: 0x00144114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65544, XrefRangeEnd = 65545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ContainsCapId_b__0(GizmoLineSlider2D item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2DCollection.__c__DisplayClass8_0.NativeMethodInfoPtr__ContainsCapId_b__0_Internal_Boolean_GizmoLineSlider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049E5 RID: 18917 RVA: 0x0001B7F7 File Offset: 0x000199F7
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001906 RID: 6406
			// (get) Token: 0x060049E6 RID: 18918 RVA: 0x00145F64 File Offset: 0x00144164
			// (set) Token: 0x060049E7 RID: 18919 RVA: 0x0001B800 File Offset: 0x00019A00
			public unsafe int capHandleId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DCollection.__c__DisplayClass8_0.NativeFieldInfoPtr_capHandleId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2DCollection.__c__DisplayClass8_0.NativeFieldInfoPtr_capHandleId)) = value;
				}
			}

			// Token: 0x04003963 RID: 14691
			private static readonly IntPtr NativeFieldInfoPtr_capHandleId;

			// Token: 0x04003964 RID: 14692
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003965 RID: 14693
			private static readonly IntPtr NativeMethodInfoPtr__ContainsCapId_b__0_Internal_Boolean_GizmoLineSlider2D_0;
		}
	}
}
