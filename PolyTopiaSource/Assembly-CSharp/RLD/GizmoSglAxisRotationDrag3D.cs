using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000041 RID: 65
	public class GizmoSglAxisRotationDrag3D : GizmoScreenDrag
	{
		// Token: 0x0600042F RID: 1071 RVA: 0x0003132C File Offset: 0x0002F52C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoSglAxisRotationDrag3D()
		{
			Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoSglAxisRotationDrag3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr);
			GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__accumSnapDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, "_accumSnapDrag");
			GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__rotationPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, "_rotationPlane");
			GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__screenDragCircleTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, "_screenDragCircleTangent");
			GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__workData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, "_workData");
			GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__adjustRotationForAbsSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, "_adjustRotationForAbsSnap");
			GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__relativeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, "_relativeRotation");
			GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__totalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, "_totalRotation");
			GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, 100663907);
			GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_get_RelativeRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, 100663908);
			GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_get_TotalRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, 100663909);
			GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_get_RotationPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, 100663910);
			GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, 100663915);
			GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, 100663911);
			GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, 100663912);
			GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_OnSessionBegin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, 100663913);
			GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, 100663914);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0003149C File Offset: 0x0002F69C
		public unsafe override GizmoDragChannel DragChannel
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 20318, RefRangeEnd = 20320, XrefRangeStart = 20318, XrefRangeEnd = 20320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x000314E8 File Offset: 0x0002F6E8
		public unsafe float RelativeRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_get_RelativeRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00031524 File Offset: 0x0002F724
		public unsafe float TotalRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_get_TotalRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00031560 File Offset: 0x0002F760
		public unsafe Plane RotationPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_get_RotationPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000315A0 File Offset: 0x0002F7A0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 58933, RefRangeEnd = 58943, XrefRangeStart = 58933, XrefRangeEnd = 58943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoSglAxisRotationDrag3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000315DC File Offset: 0x0002F7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59487, XrefRangeEnd = 59489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorkData(GizmoSglAxisRotationDrag3D.WorkData workData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref workData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0003161C File Offset: 0x0002F81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59489, XrefRangeEnd = 59500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateDragValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00031658 File Offset: 0x0002F858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59500, XrefRangeEnd = 59523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSessionBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_OnSessionBegin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00031694 File Offset: 0x0002F894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59523, XrefRangeEnd = 59525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoSglAxisRotationDrag3D.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000381C File Offset: 0x00001A1C
		public GizmoSglAxisRotationDrag3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x000316D0 File Offset: 0x0002F8D0
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00003825 File Offset: 0x00001A25
		public unsafe float _accumSnapDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__accumSnapDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__accumSnapDrag)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000316F8 File Offset: 0x0002F8F8
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00003840 File Offset: 0x00001A40
		public unsafe Plane _rotationPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__rotationPlane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__rotationPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00031728 File Offset: 0x0002F928
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0000385F File Offset: 0x00001A5F
		public unsafe Vector3 _screenDragCircleTangent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__screenDragCircleTangent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__screenDragCircleTangent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00031758 File Offset: 0x0002F958
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x0000387E File Offset: 0x00001A7E
		public unsafe GizmoSglAxisRotationDrag3D.WorkData _workData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__workData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__workData)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00031780 File Offset: 0x0002F980
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003899 File Offset: 0x00001A99
		public unsafe bool _adjustRotationForAbsSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__adjustRotationForAbsSnap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__adjustRotationForAbsSnap)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000317A8 File Offset: 0x0002F9A8
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x000038B4 File Offset: 0x00001AB4
		public unsafe float _relativeRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__relativeRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__relativeRotation)) = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x000317D0 File Offset: 0x0002F9D0
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x000038CF File Offset: 0x00001ACF
		public unsafe float _totalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__totalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoSglAxisRotationDrag3D.NativeFieldInfoPtr__totalRotation)) = value;
			}
		}

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr__accumSnapDrag;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr__rotationPlane;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr__screenDragCircleTangent;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr__workData;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr__adjustRotationForAbsSnap;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr__relativeRotation;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr__totalRotation;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeRotation_Public_get_Single_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalRotation_Public_get_Single_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationPlane_Public_get_Plane_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkData_Public_Void_WorkData_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionBegin_Protected_Virtual_Void_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_Void_0;

		// Token: 0x02000357 RID: 855
		[StructLayout(2)]
		public struct WorkData
		{
			// Token: 0x06004999 RID: 18841 RVA: 0x00144F9C File Offset: 0x0014319C
			// Note: this type is marked as 'beforefieldinit'.
			static WorkData()
			{
				Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D.WorkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D>.NativeClassPtr, "WorkData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D.WorkData>.NativeClassPtr);
				GizmoSglAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_RotationPlanePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D.WorkData>.NativeClassPtr, "RotationPlanePos");
				GizmoSglAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D.WorkData>.NativeClassPtr, "Axis");
				GizmoSglAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_SnapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D.WorkData>.NativeClassPtr, "SnapMode");
				GizmoSglAxisRotationDrag3D.WorkData.NativeFieldInfoPtr_SnapStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D.WorkData>.NativeClassPtr, "SnapStep");
			}

			// Token: 0x0600499A RID: 18842 RVA: 0x0001B604 File Offset: 0x00019804
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoSglAxisRotationDrag3D.WorkData>.NativeClassPtr, ref this));
			}

			// Token: 0x04003919 RID: 14617
			private static readonly IntPtr NativeFieldInfoPtr_RotationPlanePos;

			// Token: 0x0400391A RID: 14618
			private static readonly IntPtr NativeFieldInfoPtr_Axis;

			// Token: 0x0400391B RID: 14619
			private static readonly IntPtr NativeFieldInfoPtr_SnapMode;

			// Token: 0x0400391C RID: 14620
			private static readonly IntPtr NativeFieldInfoPtr_SnapStep;

			// Token: 0x0400391D RID: 14621
			[FieldOffset(0)]
			public IntPtr RotationPlanePos;

			// Token: 0x0400391E RID: 14622
			[FieldOffset(12)]
			public IntPtr Axis;

			// Token: 0x0400391F RID: 14623
			[FieldOffset(24)]
			public IntPtr SnapMode;

			// Token: 0x04003920 RID: 14624
			[FieldOffset(28)]
			public float SnapStep;
		}
	}
}
