using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200009C RID: 156
	public class GizmoLineSlider3DCollection : global::Il2CppSystem.Object
	{
		// Token: 0x06000CCF RID: 3279 RVA: 0x000528C0 File Offset: 0x00050AC0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider3DCollection()
		{
			Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider3DCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr);
			GizmoLineSlider3DCollection.NativeFieldInfoPtr__sliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, "_sliders");
			GizmoLineSlider3DCollection.NativeFieldInfoPtr__handleIdToSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, "_handleIdToSlider");
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665173);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoLineSlider3D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665174);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665190);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoLineSlider3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665175);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665176);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_ContainsCapId_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665177);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoLineSlider3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665178);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoLineSlider3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665179);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665180);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665181);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityLowerThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665182);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityHigherThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665183);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665184);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665185);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_Set3DCapsVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665186);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665187);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_RegisterScalerHandle_Public_Void_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665188);
			GizmoLineSlider3DCollection.NativeMethodInfoPtr_GetRenderSortedSliders_Public_List_1_GizmoLineSlider3D_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, 100665189);
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00052A80 File Offset: 0x00050C80
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66973, XrefRangeEnd = 66974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000488 RID: 1160
		public unsafe GizmoLineSlider3D this[int id]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66974, XrefRangeEnd = 66978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoLineSlider3D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00052B08 File Offset: 0x00050D08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 66993, RefRangeEnd = 66997, XrefRangeStart = 66978, XrefRangeEnd = 66993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider3DCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00052B44 File Offset: 0x00050D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66997, XrefRangeEnd = 67002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(GizmoLineSlider3D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoLineSlider3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00052B94 File Offset: 0x00050D94
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 67006, RefRangeEnd = 67014, XrefRangeStart = 67002, XrefRangeEnd = 67006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(int sliderHandleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sliderHandleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00052BE0 File Offset: 0x00050DE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 67028, RefRangeEnd = 67035, XrefRangeStart = 67014, XrefRangeEnd = 67028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsCapId(int capHandleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capHandleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_ContainsCapId_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00052C2C File Offset: 0x00050E2C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 67048, RefRangeEnd = 67072, XrefRangeStart = 67035, XrefRangeEnd = 67048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(GizmoLineSlider3D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoLineSlider3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00052C70 File Offset: 0x00050E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67072, XrefRangeEnd = 67083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(GizmoLineSlider3D slider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoLineSlider3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00052CB4 File Offset: 0x00050EB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 67106, RefRangeEnd = 67110, XrefRangeStart = 67083, XrefRangeEnd = 67106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00052CF8 File Offset: 0x00050EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67110, XrefRangeEnd = 67125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZoomFactorTransform(GizmoTransform zoomFactorTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(zoomFactorTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00052D3C File Offset: 0x00050F3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 67141, RefRangeEnd = 67148, XrefRangeStart = 67125, XrefRangeEnd = 67141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make3DHoverPriorityLowerThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityLowerThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00052D80 File Offset: 0x00050F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67164, RefRangeEnd = 67165, XrefRangeStart = 67148, XrefRangeEnd = 67164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make3DHoverPriorityHigherThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityHigherThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00052DC4 File Offset: 0x00050FC4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 67179, RefRangeEnd = 67186, XrefRangeStart = 67165, XrefRangeEnd = 67179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00052E04 File Offset: 0x00051004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67201, RefRangeEnd = 67202, XrefRangeStart = 67186, XrefRangeEnd = 67201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00052E44 File Offset: 0x00051044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67217, RefRangeEnd = 67218, XrefRangeStart = 67202, XrefRangeEnd = 67217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set3DCapsVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_Set3DCapsVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00052E84 File Offset: 0x00051084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67218, XrefRangeEnd = 67238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragChannel(GizmoDragChannel dragChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragChannel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00052EC8 File Offset: 0x000510C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 67275, RefRangeEnd = 67279, XrefRangeStart = 67238, XrefRangeEnd = 67275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scaleDragAxisIndices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_RegisterScalerHandle_Public_Void_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00052F18 File Offset: 0x00051118
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 67301, RefRangeEnd = 67305, XrefRangeStart = 67279, XrefRangeEnd = 67301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GizmoLineSlider3D> GetRenderSortedSliders(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.NativeMethodInfoPtr_GetRenderSortedSliders_Public_List_1_GizmoLineSlider3D_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GizmoLineSlider3D>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00006996 File Offset: 0x00004B96
		public GizmoLineSlider3DCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00052F68 File Offset: 0x00051168
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x0000699F File Offset: 0x00004B9F
		public unsafe List<GizmoLineSlider3D> _sliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.NativeFieldInfoPtr__sliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoLineSlider3D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.NativeFieldInfoPtr__sliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00052F98 File Offset: 0x00051198
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x000069BE File Offset: 0x00004BBE
		public unsafe Dictionary<int, GizmoLineSlider3D> _handleIdToSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.NativeFieldInfoPtr__handleIdToSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GizmoLineSlider3D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.NativeFieldInfoPtr__handleIdToSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeFieldInfoPtr__sliders;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeFieldInfoPtr__handleIdToSlider;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_GizmoLineSlider3D_Int32_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_GizmoLineSlider3D_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_ContainsCapId_Public_Boolean_Int32_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_GizmoLineSlider3D_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_GizmoLineSlider3D_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_Make3DHoverPriorityLowerThan_Public_Void_Priority_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_Make3DHoverPriorityHigherThan_Public_Void_Priority_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_Set3DCapsVisible_Public_Void_Boolean_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_RegisterScalerHandle_Public_Void_Int32_IEnumerable_1_Int32_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderSortedSliders_Public_List_1_GizmoLineSlider3D_Camera_0;

		// Token: 0x0200036F RID: 879
		[ObfuscatedName("RLD.GizmoLineSlider3DCollection+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049FA RID: 18938 RVA: 0x001462E0 File Offset: 0x001444E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass20_0>.NativeClassPtr);
				GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeFieldInfoPtr_renderCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass20_0>.NativeClassPtr, "renderCamera");
				GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeFieldInfoPtr_cameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass20_0>.NativeClassPtr, "cameraPos");
				GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass20_0>.NativeClassPtr, 100665191);
				GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeMethodInfoPtr__GetRenderSortedSliders_b__0_Internal_Int32_GizmoLineSlider3D_GizmoLineSlider3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass20_0>.NativeClassPtr, 100665192);
			}

			// Token: 0x060049FB RID: 18939 RVA: 0x0014635C File Offset: 0x0014455C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049FC RID: 18940 RVA: 0x00146398 File Offset: 0x00144598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66967, XrefRangeEnd = 66973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetRenderSortedSliders_b__0(GizmoLineSlider3D s0, GizmoLineSlider3D s1)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeMethodInfoPtr__GetRenderSortedSliders_b__0_Internal_Int32_GizmoLineSlider3D_GizmoLineSlider3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060049FD RID: 18941 RVA: 0x0001B887 File Offset: 0x00019A87
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700190A RID: 6410
			// (get) Token: 0x060049FE RID: 18942 RVA: 0x001463F8 File Offset: 0x001445F8
			// (set) Token: 0x060049FF RID: 18943 RVA: 0x0001B890 File Offset: 0x00019A90
			public unsafe Camera renderCamera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeFieldInfoPtr_renderCamera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeFieldInfoPtr_renderCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700190B RID: 6411
			// (get) Token: 0x06004A00 RID: 18944 RVA: 0x00146428 File Offset: 0x00144628
			// (set) Token: 0x06004A01 RID: 18945 RVA: 0x0001B8AF File Offset: 0x00019AAF
			public unsafe Vector3 cameraPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeFieldInfoPtr_cameraPos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.__c__DisplayClass20_0.NativeFieldInfoPtr_cameraPos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400396F RID: 14703
			private static readonly IntPtr NativeFieldInfoPtr_renderCamera;

			// Token: 0x04003970 RID: 14704
			private static readonly IntPtr NativeFieldInfoPtr_cameraPos;

			// Token: 0x04003971 RID: 14705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003972 RID: 14706
			private static readonly IntPtr NativeMethodInfoPtr__GetRenderSortedSliders_b__0_Internal_Int32_GizmoLineSlider3D_GizmoLineSlider3D_0;
		}

		// Token: 0x02000370 RID: 880
		[ObfuscatedName("RLD.GizmoLineSlider3DCollection+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A02 RID: 18946 RVA: 0x00146458 File Offset: 0x00144658
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoLineSlider3DCollection>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass8_0>.NativeClassPtr);
				GizmoLineSlider3DCollection.__c__DisplayClass8_0.NativeFieldInfoPtr_capHandleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass8_0>.NativeClassPtr, "capHandleId");
				GizmoLineSlider3DCollection.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass8_0>.NativeClassPtr, 100665193);
				GizmoLineSlider3DCollection.__c__DisplayClass8_0.NativeMethodInfoPtr__ContainsCapId_b__0_Internal_Boolean_GizmoLineSlider3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass8_0>.NativeClassPtr, 100665194);
			}

			// Token: 0x06004A03 RID: 18947 RVA: 0x001464C0 File Offset: 0x001446C0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3DCollection.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A04 RID: 18948 RVA: 0x001464FC File Offset: 0x001446FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ContainsCapId_b__0(GizmoLineSlider3D item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3DCollection.__c__DisplayClass8_0.NativeMethodInfoPtr__ContainsCapId_b__0_Internal_Boolean_GizmoLineSlider3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A05 RID: 18949 RVA: 0x0001B8CE File Offset: 0x00019ACE
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700190C RID: 6412
			// (get) Token: 0x06004A06 RID: 18950 RVA: 0x0014654C File Offset: 0x0014474C
			// (set) Token: 0x06004A07 RID: 18951 RVA: 0x0001B8D7 File Offset: 0x00019AD7
			public unsafe int capHandleId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.__c__DisplayClass8_0.NativeFieldInfoPtr_capHandleId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3DCollection.__c__DisplayClass8_0.NativeFieldInfoPtr_capHandleId)) = value;
				}
			}

			// Token: 0x04003973 RID: 14707
			private static readonly IntPtr NativeFieldInfoPtr_capHandleId;

			// Token: 0x04003974 RID: 14708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003975 RID: 14709
			private static readonly IntPtr NativeMethodInfoPtr__ContainsCapId_b__0_Internal_Boolean_GizmoLineSlider3D_0;
		}
	}
}
