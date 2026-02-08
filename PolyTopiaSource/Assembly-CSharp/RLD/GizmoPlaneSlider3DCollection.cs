using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000A6 RID: 166
	public class GizmoPlaneSlider3DCollection : global::Il2CppSystem.Object
	{
		// Token: 0x06000DF6 RID: 3574 RVA: 0x00056F08 File Offset: 0x00055108
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPlaneSlider3DCollection()
		{
			Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPlaneSlider3DCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr);
			GizmoPlaneSlider3DCollection.NativeFieldInfoPtr__sliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, "_sliders");
			GizmoPlaneSlider3DCollection.NativeFieldInfoPtr__handleIdToSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, "_handleIdToSlider");
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665330);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoPlaneSlider3D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665331);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665346);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoPlaneSlider3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665332);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665333);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoPlaneSlider3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665334);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoPlaneSlider3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665335);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665336);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665337);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityLowerThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665338);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityHigherThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665339);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665340);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665341);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetBorderVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665342);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665343);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetBorderHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665344);
			GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_GetRenderSortedSliders_Public_List_1_GizmoPlaneSlider3D_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, 100665345);
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x000570B4 File Offset: 0x000552B4
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67851, XrefRangeEnd = 67852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FD RID: 1277
		public unsafe GizmoPlaneSlider3D this[int id]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67852, XrefRangeEnd = 67856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoPlaneSlider3D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0005713C File Offset: 0x0005533C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 67871, RefRangeEnd = 67876, XrefRangeStart = 67856, XrefRangeEnd = 67871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPlaneSlider3DCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00057178 File Offset: 0x00055378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67876, XrefRangeEnd = 67881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(GizmoPlaneSlider3D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoPlaneSlider3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x000571C8 File Offset: 0x000553C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 67885, RefRangeEnd = 67891, XrefRangeStart = 67881, XrefRangeEnd = 67885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(int sliderHandleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sliderHandleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00057214 File Offset: 0x00055414
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 67904, RefRangeEnd = 67919, XrefRangeStart = 67891, XrefRangeEnd = 67904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(GizmoPlaneSlider3D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoPlaneSlider3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00057258 File Offset: 0x00055458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67919, XrefRangeEnd = 67930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(GizmoPlaneSlider3D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoPlaneSlider3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0005729C File Offset: 0x0005549C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 67949, RefRangeEnd = 67954, XrefRangeStart = 67930, XrefRangeEnd = 67949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x000572E0 File Offset: 0x000554E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67954, XrefRangeEnd = 67969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZoomFactorTransform(GizmoTransform zoomFactorTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(zoomFactorTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00057324 File Offset: 0x00055524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67969, XrefRangeEnd = 67985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make3DHoverPriorityLowerThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityLowerThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00057368 File Offset: 0x00055568
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68001, RefRangeEnd = 68004, XrefRangeStart = 67985, XrefRangeEnd = 68001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make3DHoverPriorityHigherThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityHigherThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000573AC File Offset: 0x000555AC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 68018, RefRangeEnd = 68028, XrefRangeStart = 68004, XrefRangeEnd = 68018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000573EC File Offset: 0x000555EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 68055, RefRangeEnd = 68063, XrefRangeStart = 68028, XrefRangeEnd = 68055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool isVisible, bool includeBorder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeBorder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00057438 File Offset: 0x00055638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68078, RefRangeEnd = 68079, XrefRangeStart = 68063, XrefRangeEnd = 68078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBorderVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetBorderVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00057478 File Offset: 0x00055678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68079, XrefRangeEnd = 68108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverable(bool isHoverable, bool includeBorder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeBorder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000574C4 File Offset: 0x000556C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68108, XrefRangeEnd = 68125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBorderHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_SetBorderHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00057504 File Offset: 0x00055704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68125, XrefRangeEnd = 68146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GizmoPlaneSlider3D> GetRenderSortedSliders(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.NativeMethodInfoPtr_GetRenderSortedSliders_Public_List_1_GizmoPlaneSlider3D_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GizmoPlaneSlider3D>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00007101 File Offset: 0x00005301
		public GizmoPlaneSlider3DCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00057554 File Offset: 0x00055754
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x0000710A File Offset: 0x0000530A
		public unsafe List<GizmoPlaneSlider3D> _sliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DCollection.NativeFieldInfoPtr__sliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoPlaneSlider3D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DCollection.NativeFieldInfoPtr__sliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00057584 File Offset: 0x00055784
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00007129 File Offset: 0x00005329
		public unsafe Dictionary<int, GizmoPlaneSlider3D> _handleIdToSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DCollection.NativeFieldInfoPtr__handleIdToSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GizmoPlaneSlider3D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DCollection.NativeFieldInfoPtr__handleIdToSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr__sliders;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr__handleIdToSlider;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_GizmoPlaneSlider3D_Int32_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_GizmoPlaneSlider3D_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_GizmoPlaneSlider3D_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_GizmoPlaneSlider3D_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_Make3DHoverPriorityLowerThan_Public_Void_Priority_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_Make3DHoverPriorityHigherThan_Public_Void_Priority_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_SetBorderVisible_Public_Void_Boolean_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_SetBorderHoverable_Public_Void_Boolean_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderSortedSliders_Public_List_1_GizmoPlaneSlider3D_Camera_0;

		// Token: 0x02000371 RID: 881
		[ObfuscatedName("RLD.GizmoPlaneSlider3DCollection+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A08 RID: 18952 RVA: 0x00146574 File Offset: 0x00144774
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<GizmoPlaneSlider3DCollection.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection.__c__DisplayClass19_0>.NativeClassPtr);
				GizmoPlaneSlider3DCollection.__c__DisplayClass19_0.NativeFieldInfoPtr_cameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection.__c__DisplayClass19_0>.NativeClassPtr, "cameraPos");
				GizmoPlaneSlider3DCollection.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection.__c__DisplayClass19_0>.NativeClassPtr, 100665347);
				GizmoPlaneSlider3DCollection.__c__DisplayClass19_0.NativeMethodInfoPtr__GetRenderSortedSliders_b__0_Internal_Int32_GizmoPlaneSlider3D_GizmoPlaneSlider3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection.__c__DisplayClass19_0>.NativeClassPtr, 100665348);
			}

			// Token: 0x06004A09 RID: 18953 RVA: 0x001465DC File Offset: 0x001447DC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPlaneSlider3DCollection.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A0A RID: 18954 RVA: 0x00146618 File Offset: 0x00144818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67850, XrefRangeEnd = 67851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetRenderSortedSliders_b__0(GizmoPlaneSlider3D s0, GizmoPlaneSlider3D s1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3DCollection.__c__DisplayClass19_0.NativeMethodInfoPtr__GetRenderSortedSliders_b__0_Internal_Int32_GizmoPlaneSlider3D_GizmoPlaneSlider3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A0B RID: 18955 RVA: 0x0001B8F2 File Offset: 0x00019AF2
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700190D RID: 6413
			// (get) Token: 0x06004A0C RID: 18956 RVA: 0x00146678 File Offset: 0x00144878
			// (set) Token: 0x06004A0D RID: 18957 RVA: 0x0001B8FB File Offset: 0x00019AFB
			public unsafe Vector3 cameraPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DCollection.__c__DisplayClass19_0.NativeFieldInfoPtr_cameraPos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3DCollection.__c__DisplayClass19_0.NativeFieldInfoPtr_cameraPos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003976 RID: 14710
			private static readonly IntPtr NativeFieldInfoPtr_cameraPos;

			// Token: 0x04003977 RID: 14711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003978 RID: 14712
			private static readonly IntPtr NativeMethodInfoPtr__GetRenderSortedSliders_b__0_Internal_Int32_GizmoPlaneSlider3D_GizmoPlaneSlider3D_0;
		}
	}
}
