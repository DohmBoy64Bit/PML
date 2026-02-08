using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000040 RID: 64
	public class GizmoSglAxisOffsetDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x06000422 RID: 1058 RVA: 0x0003102C File Offset: 0x0002F22C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoSglAxisOffsetDrag3D()
		{
			Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoSglAxisOffsetDrag3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr);
			GizmoSglAxisOffsetDrag3D.NativeFieldInfoPtr__accumSnapDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, "_accumSnapDrag");
			GizmoSglAxisOffsetDrag3D.NativeFieldInfoPtr__workData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, "_workData");
			GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_get_Axis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, 100663900);
			GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, 100663901);
			GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, 100663906);
			GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, 100663902);
			GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, 100663903);
			GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, 100663904);
			GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, 100663905);
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00031110 File Offset: 0x0002F310
		public unsafe Vector3 Axis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_get_Axis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00031150 File Offset: 0x0002F350
		public unsafe override GizmoDragChannel DragChannel
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 20120, RefRangeEnd = 20124, XrefRangeStart = 20120, XrefRangeEnd = 20124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0003119C File Offset: 0x0002F39C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 58933, RefRangeEnd = 58943, XrefRangeStart = 58933, XrefRangeEnd = 58943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoSglAxisOffsetDrag3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000311D8 File Offset: 0x0002F3D8
		[CallerCount(0)]
		public unsafe void SetWorkData(GizmoSglAxisOffsetDrag3D.WorkData workData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref workData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00031218 File Offset: 0x0002F418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59474, XrefRangeEnd = 59481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Plane CalculateDragPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00031264 File Offset: 0x0002F464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59481, XrefRangeEnd = 59487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateDragValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000312A0 File Offset: 0x0002F4A0
		[CallerCount(0)]
		public unsafe override void OnSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisOffsetDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000037DD File Offset: 0x000019DD
		public GizmoSglAxisOffsetDrag3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x000312DC File Offset: 0x0002F4DC
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x000037E6 File Offset: 0x000019E6
		public unsafe float _accumSnapDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisOffsetDrag3D.NativeFieldInfoPtr__accumSnapDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisOffsetDrag3D.NativeFieldInfoPtr__accumSnapDrag)) = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00031304 File Offset: 0x0002F504
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00003801 File Offset: 0x00001A01
		public unsafe GizmoSglAxisOffsetDrag3D.WorkData _workData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisOffsetDrag3D.NativeFieldInfoPtr__workData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisOffsetDrag3D.NativeFieldInfoPtr__workData)) = value;
			}
		}

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr__workData;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_get_Axis_Public_get_Vector3_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragPlane_Protected_Virtual_Plane_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0;

		// Token: 0x02000356 RID: 854
		[StructLayout(2)]
		public struct WorkData
		{
			// Token: 0x06004997 RID: 18839 RVA: 0x00144F34 File Offset: 0x00143134
			// Note: this type is marked as 'beforefieldinit'.
			static WorkData()
			{
				Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D.WorkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D>.NativeClassPtr, "WorkData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D.WorkData>.NativeClassPtr);
				GizmoSglAxisOffsetDrag3D.WorkData.NativeFieldInfoPtr_DragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D.WorkData>.NativeClassPtr, "DragOrigin");
				GizmoSglAxisOffsetDrag3D.WorkData.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D.WorkData>.NativeClassPtr, "Axis");
				GizmoSglAxisOffsetDrag3D.WorkData.NativeFieldInfoPtr_SnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D.WorkData>.NativeClassPtr, "SnapStep");
			}

			// Token: 0x06004998 RID: 18840 RVA: 0x0001B5F2 File Offset: 0x000197F2
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoSglAxisOffsetDrag3D.WorkData>.NativeClassPtr, ref this));
			}

			// Token: 0x04003913 RID: 14611
			private static readonly IntPtr NativeFieldInfoPtr_DragOrigin;

			// Token: 0x04003914 RID: 14612
			private static readonly IntPtr NativeFieldInfoPtr_Axis;

			// Token: 0x04003915 RID: 14613
			private static readonly IntPtr NativeFieldInfoPtr_SnapStep;

			// Token: 0x04003916 RID: 14614
			[FieldOffset(0)]
			public IntPtr DragOrigin;

			// Token: 0x04003917 RID: 14615
			[FieldOffset(12)]
			public IntPtr Axis;

			// Token: 0x04003918 RID: 14616
			[FieldOffset(24)]
			public float SnapStep;
		}
	}
}
