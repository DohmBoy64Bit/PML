using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000043 RID: 67
	public class GizmoUniformScaleDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x00031C48 File Offset: 0x0002FE48
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoUniformScaleDrag3D()
		{
			Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoUniformScaleDrag3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr);
			GizmoUniformScaleDrag3D.NativeFieldInfoPtr__workData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, "_workData");
			GizmoUniformScaleDrag3D.NativeFieldInfoPtr__planeAxis0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, "_planeAxis0");
			GizmoUniformScaleDrag3D.NativeFieldInfoPtr__planeAxis1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, "_planeAxis1");
			GizmoUniformScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, "_accumSnapDrag");
			GizmoUniformScaleDrag3D.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, "_scale");
			GizmoUniformScaleDrag3D.NativeFieldInfoPtr__relativeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, "_relativeScale");
			GizmoUniformScaleDrag3D.NativeFieldInfoPtr__totalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, "_totalScale");
			GizmoUniformScaleDrag3D.NativeFieldInfoPtr__scaleDragAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, "_scaleDragAxis");
			GizmoUniformScaleDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, 100663925);
			GizmoUniformScaleDrag3D.NativeMethodInfoPtr_get_TotalScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, 100663926);
			GizmoUniformScaleDrag3D.NativeMethodInfoPtr_get_RelativeScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, 100663927);
			GizmoUniformScaleDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, 100663932);
			GizmoUniformScaleDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, 100663928);
			GizmoUniformScaleDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, 100663929);
			GizmoUniformScaleDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, 100663930);
			GizmoUniformScaleDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, 100663931);
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00031DB8 File Offset: 0x0002FFB8
		public unsafe override GizmoDragChannel DragChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoUniformScaleDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00031E04 File Offset: 0x00030004
		public unsafe float TotalScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoUniformScaleDrag3D.NativeMethodInfoPtr_get_TotalScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00031E40 File Offset: 0x00030040
		public unsafe float RelativeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoUniformScaleDrag3D.NativeMethodInfoPtr_get_RelativeScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00031E7C File Offset: 0x0003007C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59550, RefRangeEnd = 59552, XrefRangeStart = 59549, XrefRangeEnd = 59550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoUniformScaleDrag3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoUniformScaleDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00031EB8 File Offset: 0x000300B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59556, RefRangeEnd = 59558, XrefRangeStart = 59552, XrefRangeEnd = 59556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorkData(GizmoUniformScaleDrag3D.WorkData workData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref workData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoUniformScaleDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00031EF8 File Offset: 0x000300F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59558, XrefRangeEnd = 59564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Plane CalculateDragPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoUniformScaleDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00031F44 File Offset: 0x00030144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59564, XrefRangeEnd = 59573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateDragValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoUniformScaleDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00031F80 File Offset: 0x00030180
		[CallerCount(0)]
		public unsafe override void OnSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoUniformScaleDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000397A File Offset: 0x00001B7A
		public GizmoUniformScaleDrag3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00031FBC File Offset: 0x000301BC
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00003983 File Offset: 0x00001B83
		public unsafe GizmoUniformScaleDrag3D.WorkData _workData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__workData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__workData)) = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00031FE4 File Offset: 0x000301E4
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x0000399E File Offset: 0x00001B9E
		public unsafe Vector3 _planeAxis0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__planeAxis0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__planeAxis0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00032014 File Offset: 0x00030214
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x000039BD File Offset: 0x00001BBD
		public unsafe Vector3 _planeAxis1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__planeAxis1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__planeAxis1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00032044 File Offset: 0x00030244
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x000039DC File Offset: 0x00001BDC
		public unsafe float _accumSnapDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0003206C File Offset: 0x0003026C
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x000039F7 File Offset: 0x00001BF7
		public unsafe float _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__scale)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00032094 File Offset: 0x00030294
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00003A12 File Offset: 0x00001C12
		public unsafe float _relativeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__relativeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__relativeScale)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000320BC File Offset: 0x000302BC
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00003A2D File Offset: 0x00001C2D
		public unsafe float _totalScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__totalScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__totalScale)) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000320E4 File Offset: 0x000302E4
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00003A48 File Offset: 0x00001C48
		public unsafe Vector3 _scaleDragAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__scaleDragAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoUniformScaleDrag3D.NativeFieldInfoPtr__scaleDragAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr__workData;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr__planeAxis0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr__planeAxis1;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr__relativeScale;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr__totalScale;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragAxis;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalScale_Public_get_Single_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeScale_Public_get_Single_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0;

		// Token: 0x02000359 RID: 857
		[StructLayout(2)]
		public struct WorkData
		{
			// Token: 0x0600499D RID: 18845 RVA: 0x001450A8 File Offset: 0x001432A8
			// Note: this type is marked as 'beforefieldinit'.
			static WorkData()
			{
				Il2CppClassPointerStore<GizmoUniformScaleDrag3D.WorkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoUniformScaleDrag3D>.NativeClassPtr, "WorkData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoUniformScaleDrag3D.WorkData>.NativeClassPtr);
				GizmoUniformScaleDrag3D.WorkData.NativeFieldInfoPtr_CameraRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D.WorkData>.NativeClassPtr, "CameraRight");
				GizmoUniformScaleDrag3D.WorkData.NativeFieldInfoPtr_CameraUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D.WorkData>.NativeClassPtr, "CameraUp");
				GizmoUniformScaleDrag3D.WorkData.NativeFieldInfoPtr_DragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D.WorkData>.NativeClassPtr, "DragOrigin");
				GizmoUniformScaleDrag3D.WorkData.NativeFieldInfoPtr_SnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoUniformScaleDrag3D.WorkData>.NativeClassPtr, "SnapStep");
			}

			// Token: 0x0600499E RID: 18846 RVA: 0x0001B628 File Offset: 0x00019828
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoUniformScaleDrag3D.WorkData>.NativeClassPtr, ref this));
			}

			// Token: 0x0400392B RID: 14635
			private static readonly IntPtr NativeFieldInfoPtr_CameraRight;

			// Token: 0x0400392C RID: 14636
			private static readonly IntPtr NativeFieldInfoPtr_CameraUp;

			// Token: 0x0400392D RID: 14637
			private static readonly IntPtr NativeFieldInfoPtr_DragOrigin;

			// Token: 0x0400392E RID: 14638
			private static readonly IntPtr NativeFieldInfoPtr_SnapStep;

			// Token: 0x0400392F RID: 14639
			[FieldOffset(0)]
			public IntPtr CameraRight;

			// Token: 0x04003930 RID: 14640
			[FieldOffset(12)]
			public IntPtr CameraUp;

			// Token: 0x04003931 RID: 14641
			[FieldOffset(24)]
			public IntPtr DragOrigin;

			// Token: 0x04003932 RID: 14642
			[FieldOffset(36)]
			public float SnapStep;
		}
	}
}
