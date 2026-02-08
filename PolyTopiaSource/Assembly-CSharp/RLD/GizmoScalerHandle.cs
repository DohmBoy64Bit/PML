using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x02000074 RID: 116
	public class GizmoScalerHandle : Object
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x00042F20 File Offset: 0x00041120
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoScalerHandle()
		{
			Il2CppClassPointerStore<GizmoScalerHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoScalerHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoScalerHandle>.NativeClassPtr);
			GizmoScalerHandle.NativeFieldInfoPtr__handleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScalerHandle>.NativeClassPtr, "_handleId");
			GizmoScalerHandle.NativeFieldInfoPtr__scaleDragAxisIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoScalerHandle>.NativeClassPtr, "_scaleDragAxisIndices");
			GizmoScalerHandle.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScalerHandle>.NativeClassPtr, 100664613);
			GizmoScalerHandle.NativeMethodInfoPtr_get_ScaleDragAxisIndices_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScalerHandle>.NativeClassPtr, 100664614);
			GizmoScalerHandle.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScalerHandle>.NativeClassPtr, 100664615);
			GizmoScalerHandle.NativeMethodInfoPtr_ContainsScaleDragAxisIndex_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoScalerHandle>.NativeClassPtr, 100664616);
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00042FC8 File Offset: 0x000411C8
		public unsafe int HandleId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScalerHandle.NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00043004 File Offset: 0x00041204
		public unsafe List<int> ScaleDragAxisIndices
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63698, XrefRangeEnd = 63704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScalerHandle.NativeMethodInfoPtr_get_ScaleDragAxisIndices_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00043044 File Offset: 0x00041244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63718, RefRangeEnd = 63720, XrefRangeStart = 63704, XrefRangeEnd = 63718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoScalerHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scaleDragAxisIndices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScalerHandle.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000430A0 File Offset: 0x000412A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63724, RefRangeEnd = 63725, XrefRangeStart = 63720, XrefRangeEnd = 63724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsScaleDragAxisIndex(int scaleDragAxisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleDragAxisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoScalerHandle.NativeMethodInfoPtr_ContainsScaleDragAxisIndex_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00004E40 File Offset: 0x00003040
		public GizmoScalerHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x000430EC File Offset: 0x000412EC
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00004E49 File Offset: 0x00003049
		public unsafe int _handleId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScalerHandle.NativeFieldInfoPtr__handleId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScalerHandle.NativeFieldInfoPtr__handleId)) = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00043114 File Offset: 0x00041314
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00004E64 File Offset: 0x00003064
		public unsafe List<int> _scaleDragAxisIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScalerHandle.NativeFieldInfoPtr__scaleDragAxisIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoScalerHandle.NativeFieldInfoPtr__scaleDragAxisIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeFieldInfoPtr__handleId;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragAxisIndices;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleId_Public_get_Int32_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleDragAxisIndices_Public_get_List_1_Int32_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEnumerable_1_Int32_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_ContainsScaleDragAxisIndex_Public_Boolean_Int32_0;
	}
}
