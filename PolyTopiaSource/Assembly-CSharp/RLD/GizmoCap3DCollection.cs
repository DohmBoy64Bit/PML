using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000018 RID: 24
	public class GizmoCap3DCollection : global::Il2CppSystem.Object
	{
		// Token: 0x0600018F RID: 399 RVA: 0x00026F50 File Offset: 0x00025150
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCap3DCollection()
		{
			Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCap3DCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr);
			GizmoCap3DCollection.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, "_caps");
			GizmoCap3DCollection.NativeFieldInfoPtr__handleIdToCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, "_handleIdToCap");
			GizmoCap3DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663523);
			GizmoCap3DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoCap3D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663524);
			GizmoCap3DCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663535);
			GizmoCap3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoCap3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663525);
			GizmoCap3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663526);
			GizmoCap3DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoCap3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663527);
			GizmoCap3DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoCap3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663528);
			GizmoCap3DCollection.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663529);
			GizmoCap3DCollection.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663530);
			GizmoCap3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityLowerThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663531);
			GizmoCap3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityHigherThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663532);
			GizmoCap3DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663533);
			GizmoCap3DCollection.NativeMethodInfoPtr_GetRenderSortedCaps_Public_List_1_GizmoCap3D_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, 100663534);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000270AC File Offset: 0x000252AC
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57596, XrefRangeEnd = 57597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000070 RID: 112
		public unsafe GizmoCap3D this[int id]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57597, XrefRangeEnd = 57601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoCap3D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3D>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00027134 File Offset: 0x00025334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57601, XrefRangeEnd = 57616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCap3DCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00027170 File Offset: 0x00025370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57616, XrefRangeEnd = 57620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(GizmoCap3D cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoCap3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000271C0 File Offset: 0x000253C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57620, XrefRangeEnd = 57624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(int capHandleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capHandleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0002720C File Offset: 0x0002540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57624, XrefRangeEnd = 57635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(GizmoCap3D cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoCap3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00027250 File Offset: 0x00025450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57635, XrefRangeEnd = 57644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(GizmoCap3D cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoCap3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00027294 File Offset: 0x00025494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57644, XrefRangeEnd = 57663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000272D8 File Offset: 0x000254D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57663, XrefRangeEnd = 57678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZoomFactorTransform(GizmoTransform zoomFactorTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(zoomFactorTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0002731C File Offset: 0x0002551C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57678, XrefRangeEnd = 57693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make3DHoverPriorityLowerThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityLowerThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00027360 File Offset: 0x00025560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57693, XrefRangeEnd = 57708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make3DHoverPriorityHigherThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_Make3DHoverPriorityHigherThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000273A4 File Offset: 0x000255A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57708, XrefRangeEnd = 57722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000273E4 File Offset: 0x000255E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57722, XrefRangeEnd = 57743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GizmoCap3D> GetRenderSortedCaps(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.NativeMethodInfoPtr_GetRenderSortedCaps_Public_List_1_GizmoCap3D_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GizmoCap3D>>(intPtr3) : null;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002989 File Offset: 0x00000B89
		public GizmoCap3DCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00027434 File Offset: 0x00025634
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002992 File Offset: 0x00000B92
		public unsafe List<GizmoCap3D> _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DCollection.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoCap3D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DCollection.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00027464 File Offset: 0x00025664
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x000029B1 File Offset: 0x00000BB1
		public unsafe Dictionary<int, GizmoCap3D> _handleIdToCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DCollection.NativeFieldInfoPtr__handleIdToCap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GizmoCap3D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DCollection.NativeFieldInfoPtr__handleIdToCap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr__handleIdToCap;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_GizmoCap3D_Int32_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_GizmoCap3D_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_GizmoCap3D_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_GizmoCap3D_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_Make3DHoverPriorityLowerThan_Public_Void_Priority_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_Make3DHoverPriorityHigherThan_Public_Void_Priority_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderSortedCaps_Public_List_1_GizmoCap3D_Camera_0;

		// Token: 0x0200034E RID: 846
		[ObfuscatedName("RLD.GizmoCap3DCollection+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004976 RID: 18806 RVA: 0x0014485C File Offset: 0x00142A5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<GizmoCap3DCollection.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoCap3DCollection>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap3DCollection.__c__DisplayClass15_0>.NativeClassPtr);
				GizmoCap3DCollection.__c__DisplayClass15_0.NativeFieldInfoPtr_cameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap3DCollection.__c__DisplayClass15_0>.NativeClassPtr, "cameraPos");
				GizmoCap3DCollection.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection.__c__DisplayClass15_0>.NativeClassPtr, 100663536);
				GizmoCap3DCollection.__c__DisplayClass15_0.NativeMethodInfoPtr__GetRenderSortedCaps_b__0_Internal_Int32_GizmoCap3D_GizmoCap3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap3DCollection.__c__DisplayClass15_0>.NativeClassPtr, 100663537);
			}

			// Token: 0x06004977 RID: 18807 RVA: 0x001448C4 File Offset: 0x00142AC4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap3DCollection.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004978 RID: 18808 RVA: 0x00144900 File Offset: 0x00142B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57595, XrefRangeEnd = 57596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetRenderSortedCaps_b__0(GizmoCap3D c0, GizmoCap3D c1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap3DCollection.__c__DisplayClass15_0.NativeMethodInfoPtr__GetRenderSortedCaps_b__0_Internal_Int32_GizmoCap3D_GizmoCap3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004979 RID: 18809 RVA: 0x0001B4D9 File Offset: 0x000196D9
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018F4 RID: 6388
			// (get) Token: 0x0600497A RID: 18810 RVA: 0x00144960 File Offset: 0x00142B60
			// (set) Token: 0x0600497B RID: 18811 RVA: 0x0001B4E2 File Offset: 0x000196E2
			public unsafe Vector3 cameraPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DCollection.__c__DisplayClass15_0.NativeFieldInfoPtr_cameraPos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap3DCollection.__c__DisplayClass15_0.NativeFieldInfoPtr_cameraPos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040038DB RID: 14555
			private static readonly IntPtr NativeFieldInfoPtr_cameraPos;

			// Token: 0x040038DC RID: 14556
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040038DD RID: 14557
			private static readonly IntPtr NativeMethodInfoPtr__GetRenderSortedCaps_b__0_Internal_Int32_GizmoCap3D_GizmoCap3D_0;
		}
	}
}
