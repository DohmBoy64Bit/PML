using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000042 RID: 66
	public class GizmoSglAxisScaleDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x000317F8 File Offset: 0x0002F9F8
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoSglAxisScaleDrag3D()
		{
			Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoSglAxisScaleDrag3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr);
			GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, "_accumSnapDrag");
			GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__workData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, "_workData");
			GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, "_scale");
			GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__relativeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, "_relativeScale");
			GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__totalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, "_totalScale");
			GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, 100663916);
			GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_get_AxisIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, 100663917);
			GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_get_RelativeScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, 100663918);
			GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_get_TotalScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, 100663919);
			GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, 100663924);
			GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, 100663920);
			GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, 100663921);
			GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, 100663922);
			GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, 100663923);
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00031940 File Offset: 0x0002FB40
		public unsafe override GizmoDragChannel DragChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0003198C File Offset: 0x0002FB8C
		public unsafe int AxisIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_get_AxisIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000319C8 File Offset: 0x0002FBC8
		public unsafe float RelativeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_get_RelativeScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00031A04 File Offset: 0x0002FC04
		public unsafe float TotalScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_get_TotalScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00031A40 File Offset: 0x0002FC40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 59526, RefRangeEnd = 59530, XrefRangeStart = 59525, XrefRangeEnd = 59526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoSglAxisScaleDrag3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00031A7C File Offset: 0x0002FC7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 59530, RefRangeEnd = 59533, XrefRangeStart = 59530, XrefRangeEnd = 59530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorkData(GizmoSglAxisScaleDrag3D.WorkData workData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref workData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00031ABC File Offset: 0x0002FCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59533, XrefRangeEnd = 59540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Plane CalculateDragPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00031B08 File Offset: 0x0002FD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59540, XrefRangeEnd = 59549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateDragValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00031B44 File Offset: 0x0002FD44
		[CallerCount(0)]
		public unsafe override void OnSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisScaleDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000038EA File Offset: 0x00001AEA
		public GizmoSglAxisScaleDrag3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00031B80 File Offset: 0x0002FD80
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x000038F3 File Offset: 0x00001AF3
		public unsafe float _accumSnapDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__accumSnapDrag)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00031BA8 File Offset: 0x0002FDA8
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0000390E File Offset: 0x00001B0E
		public unsafe GizmoSglAxisScaleDrag3D.WorkData _workData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__workData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__workData)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00031BD0 File Offset: 0x0002FDD0
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00003929 File Offset: 0x00001B29
		public unsafe float _scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__scale)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00031BF8 File Offset: 0x0002FDF8
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00003944 File Offset: 0x00001B44
		public unsafe float _relativeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__relativeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__relativeScale)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00031C20 File Offset: 0x0002FE20
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0000395F File Offset: 0x00001B5F
		public unsafe float _totalScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__totalScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisScaleDrag3D.NativeFieldInfoPtr__totalScale)) = value;
			}
		}

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeFieldInfoPtr__workData;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr__scale;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr__relativeScale;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr__totalScale;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisIndex_Public_get_Int32_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeScale_Public_get_Single_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalScale_Public_get_Single_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0;

		// Token: 0x02000358 RID: 856
		[StructLayout(2)]
		public struct WorkData
		{
			// Token: 0x0600499B RID: 18843 RVA: 0x00145018 File Offset: 0x00143218
			// Note: this type is marked as 'beforefieldinit'.
			static WorkData()
			{
				Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D.WorkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D>.NativeClassPtr, "WorkData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D.WorkData>.NativeClassPtr);
				GizmoSglAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_AxisIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D.WorkData>.NativeClassPtr, "AxisIndex");
				GizmoSglAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_DragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D.WorkData>.NativeClassPtr, "DragOrigin");
				GizmoSglAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D.WorkData>.NativeClassPtr, "Axis");
				GizmoSglAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_SnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D.WorkData>.NativeClassPtr, "SnapStep");
				GizmoSglAxisScaleDrag3D.WorkData.NativeFieldInfoPtr_EntityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D.WorkData>.NativeClassPtr, "EntityScale");
			}

			// Token: 0x0600499C RID: 18844 RVA: 0x0001B616 File Offset: 0x00019816
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoSglAxisScaleDrag3D.WorkData>.NativeClassPtr, ref this));
			}

			// Token: 0x04003921 RID: 14625
			private static readonly IntPtr NativeFieldInfoPtr_AxisIndex;

			// Token: 0x04003922 RID: 14626
			private static readonly IntPtr NativeFieldInfoPtr_DragOrigin;

			// Token: 0x04003923 RID: 14627
			private static readonly IntPtr NativeFieldInfoPtr_Axis;

			// Token: 0x04003924 RID: 14628
			private static readonly IntPtr NativeFieldInfoPtr_SnapStep;

			// Token: 0x04003925 RID: 14629
			private static readonly IntPtr NativeFieldInfoPtr_EntityScale;

			// Token: 0x04003926 RID: 14630
			[FieldOffset(0)]
			public int AxisIndex;

			// Token: 0x04003927 RID: 14631
			[FieldOffset(4)]
			public IntPtr DragOrigin;

			// Token: 0x04003928 RID: 14632
			[FieldOffset(16)]
			public IntPtr Axis;

			// Token: 0x04003929 RID: 14633
			[FieldOffset(28)]
			public float SnapStep;

			// Token: 0x0400392A RID: 14634
			[FieldOffset(32)]
			public float EntityScale;
		}
	}
}
