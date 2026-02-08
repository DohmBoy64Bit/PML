using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200003C RID: 60
	public class GizmoObjectVertexSnapDrag3D : GizmoDragSession
	{
		// Token: 0x060003CF RID: 975 RVA: 0x0002FC68 File Offset: 0x0002DE68
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoObjectVertexSnapDrag3D()
		{
			Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoObjectVertexSnapDrag3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr);
			GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__targetObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, "_targetObjects");
			GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__snapPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, "_snapPivot");
			GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, "_isActive");
			GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__destinationObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, "_destinationObjects");
			GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, "_settings");
			GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__visibleObjectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, "_visibleObjectBuffer");
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_get_IsActive_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663851);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663852);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_get_SnapPivot_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663853);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_set_Settings_Public_set_Void_GizmoObjectVertexSnapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663854);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663864);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_SetTargetObjects_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663855);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_SelectSnapPivotPoint_Public_Boolean_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663856);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_DoBeginSession_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663857);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_DoUpdateSession_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663858);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_DoEndSession_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663859);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663860);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_GetWorldPointClosestToInputDevice_Protected_Boolean_Camera_IEnumerable_1_GameObject_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663861);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_CanUseObjectAsSnapDestination_Protected_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663862);
			GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_GatherDestinationObjects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, 100663863);
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0002FE28 File Offset: 0x0002E028
		public unsafe override bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_get_IsActive_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0002FE70 File Offset: 0x0002E070
		public unsafe override GizmoDragChannel DragChannel
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 20120, RefRangeEnd = 20124, XrefRangeStart = 20120, XrefRangeEnd = 20124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0002FEBC File Offset: 0x0002E0BC
		public unsafe Vector3 SnapPivot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_get_SnapPivot_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700014E RID: 334
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0002FEFC File Offset: 0x0002E0FC
		public unsafe GizmoObjectVertexSnapSettings Settings
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59166, RefRangeEnd = 59168, XrefRangeStart = 59165, XrefRangeEnd = 59166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_set_Settings_Public_set_Void_GizmoObjectVertexSnapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0002FF40 File Offset: 0x0002E140
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59186, RefRangeEnd = 59188, XrefRangeStart = 59168, XrefRangeEnd = 59186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoObjectVertexSnapDrag3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0002FF7C File Offset: 0x0002E17C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59189, RefRangeEnd = 59191, XrefRangeStart = 59188, XrefRangeEnd = 59189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetObjects(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_SetTargetObjects_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0002FFC0 File Offset: 0x0002E1C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59193, RefRangeEnd = 59194, XrefRangeStart = 59191, XrefRangeEnd = 59193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SelectSnapPivotPoint(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_SelectSnapPivotPoint_Public_Boolean_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00030010 File Offset: 0x0002E210
		[CallerCount(0)]
		public unsafe override bool DoBeginSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_DoBeginSession_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00030058 File Offset: 0x0002E258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59194, XrefRangeEnd = 59195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoUpdateSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_DoUpdateSession_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000300A0 File Offset: 0x0002E2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59195, XrefRangeEnd = 59197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DoEndSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_DoEndSession_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000300DC File Offset: 0x0002E2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59197, XrefRangeEnd = 59236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateDragValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00030118 File Offset: 0x0002E318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59327, RefRangeEnd = 59329, XrefRangeStart = 59236, XrefRangeEnd = 59327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetWorldPointClosestToInputDevice(Camera focusCamera, IEnumerable<GameObject> gameObjects, out Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusCamera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_GetWorldPointClosestToInputDevice_Protected_Boolean_Camera_IEnumerable_1_GameObject_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00030188 File Offset: 0x0002E388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59329, XrefRangeEnd = 59332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanUseObjectAsSnapDestination(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_CanUseObjectAsSnapDestination_Protected_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000301D8 File Offset: 0x0002E3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59408, RefRangeEnd = 59409, XrefRangeStart = 59332, XrefRangeEnd = 59408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GatherDestinationObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.NativeMethodInfoPtr_GatherDestinationObjects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00003608 File Offset: 0x00001808
		public GizmoObjectVertexSnapDrag3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0003020C File Offset: 0x0002E40C
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00003611 File Offset: 0x00001811
		public unsafe IEnumerable<GameObject> _targetObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__targetObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__targetObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0003023C File Offset: 0x0002E43C
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00003630 File Offset: 0x00001830
		public unsafe Vector3 _snapPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__snapPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__snapPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0003026C File Offset: 0x0002E46C
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0000364F File Offset: 0x0000184F
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00030294 File Offset: 0x0002E494
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x0000366A File Offset: 0x0000186A
		public unsafe List<GameObject> _destinationObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__destinationObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__destinationObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000302C4 File Offset: 0x0002E4C4
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00003689 File Offset: 0x00001889
		public unsafe GizmoObjectVertexSnapSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoObjectVertexSnapSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000302F4 File Offset: 0x0002E4F4
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x000036A8 File Offset: 0x000018A8
		public unsafe List<GameObject> _visibleObjectBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__visibleObjectBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.NativeFieldInfoPtr__visibleObjectBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr__targetObjects;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr__snapPivot;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr__destinationObjects;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr__visibleObjectBuffer;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Virtual_get_Boolean_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Virtual_get_GizmoDragChannel_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_get_SnapPivot_Public_get_Vector3_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_set_Settings_Public_set_Void_GizmoObjectVertexSnapSettings_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetObjects_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_SelectSnapPivotPoint_Public_Boolean_Gizmo_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_DoBeginSession_Protected_Virtual_Boolean_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdateSession_Protected_Virtual_Boolean_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_DoEndSession_Protected_Virtual_Void_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragValues_Protected_Virtual_Void_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldPointClosestToInputDevice_Protected_Boolean_Camera_IEnumerable_1_GameObject_byref_Vector3_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_CanUseObjectAsSnapDestination_Protected_Boolean_GameObject_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_GatherDestinationObjects_Private_Void_0;

		// Token: 0x02000354 RID: 852
		[ObfuscatedName("RLD.GizmoObjectVertexSnapDrag3D+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004985 RID: 18821 RVA: 0x00144C28 File Offset: 0x00142E28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0>.NativeClassPtr);
				GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_targetObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0>.NativeClassPtr, "targetObjects");
				GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_focusCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0>.NativeClassPtr, "focusCamera");
				GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_boundsQConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0>.NativeClassPtr, "boundsQConfig");
				GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_inputDevicePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0>.NativeClassPtr, "inputDevicePos");
				GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0>.NativeClassPtr, 100663865);
				GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeMethodInfoPtr__GatherDestinationObjects_b__0_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0>.NativeClassPtr, 100663866);
			}

			// Token: 0x06004986 RID: 18822 RVA: 0x00144CCC File Offset: 0x00142ECC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004987 RID: 18823 RVA: 0x00144D08 File Offset: 0x00142F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59131, XrefRangeEnd = 59161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GatherDestinationObjects_b__0(GameObject a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeMethodInfoPtr__GatherDestinationObjects_b__0_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004988 RID: 18824 RVA: 0x0001B549 File Offset: 0x00019749
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018F5 RID: 6389
			// (get) Token: 0x06004989 RID: 18825 RVA: 0x00144D58 File Offset: 0x00142F58
			// (set) Token: 0x0600498A RID: 18826 RVA: 0x0001B552 File Offset: 0x00019752
			public unsafe List<GameObject> targetObjects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_targetObjects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_targetObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018F6 RID: 6390
			// (get) Token: 0x0600498B RID: 18827 RVA: 0x00144D88 File Offset: 0x00142F88
			// (set) Token: 0x0600498C RID: 18828 RVA: 0x0001B571 File Offset: 0x00019771
			public unsafe Camera focusCamera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_focusCamera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_focusCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018F7 RID: 6391
			// (get) Token: 0x0600498D RID: 18829 RVA: 0x00144DB8 File Offset: 0x00142FB8
			// (set) Token: 0x0600498E RID: 18830 RVA: 0x0001B590 File Offset: 0x00019790
			public unsafe ObjectBounds.QueryConfig boundsQConfig
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_boundsQConfig);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_boundsQConfig)) = value;
				}
			}

			// Token: 0x170018F8 RID: 6392
			// (get) Token: 0x0600498F RID: 18831 RVA: 0x00144DE0 File Offset: 0x00142FE0
			// (set) Token: 0x06004990 RID: 18832 RVA: 0x0001B5AB File Offset: 0x000197AB
			public unsafe Vector2 inputDevicePos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_inputDevicePos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_0.NativeFieldInfoPtr_inputDevicePos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400390A RID: 14602
			private static readonly IntPtr NativeFieldInfoPtr_targetObjects;

			// Token: 0x0400390B RID: 14603
			private static readonly IntPtr NativeFieldInfoPtr_focusCamera;

			// Token: 0x0400390C RID: 14604
			private static readonly IntPtr NativeFieldInfoPtr_boundsQConfig;

			// Token: 0x0400390D RID: 14605
			private static readonly IntPtr NativeFieldInfoPtr_inputDevicePos;

			// Token: 0x0400390E RID: 14606
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400390F RID: 14607
			private static readonly IntPtr NativeMethodInfoPtr__GatherDestinationObjects_b__0_Internal_Boolean_GameObject_0;
		}

		// Token: 0x02000355 RID: 853
		[ObfuscatedName("RLD.GizmoObjectVertexSnapDrag3D+<>c__DisplayClass22_1")]
		public sealed class __c__DisplayClass22_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06004991 RID: 18833 RVA: 0x00144E10 File Offset: 0x00143010
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_1()
			{
				Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D>.NativeClassPtr, "<>c__DisplayClass22_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1>.NativeClassPtr);
				GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1>.NativeClassPtr, "a");
				GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1>.NativeClassPtr, 100663867);
				GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1.NativeMethodInfoPtr__GatherDestinationObjects_b__1_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1>.NativeClassPtr, 100663868);
			}

			// Token: 0x06004992 RID: 18834 RVA: 0x00144E78 File Offset: 0x00143078
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004993 RID: 18835 RVA: 0x00144EB4 File Offset: 0x001430B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59161, XrefRangeEnd = 59165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GatherDestinationObjects_b__1(GameObject b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1.NativeMethodInfoPtr__GatherDestinationObjects_b__1_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004994 RID: 18836 RVA: 0x0001B5CA File Offset: 0x000197CA
			public __c__DisplayClass22_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018F9 RID: 6393
			// (get) Token: 0x06004995 RID: 18837 RVA: 0x00144F04 File Offset: 0x00143104
			// (set) Token: 0x06004996 RID: 18838 RVA: 0x0001B5D3 File Offset: 0x000197D3
			public unsafe GameObject a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1.NativeFieldInfoPtr_a);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoObjectVertexSnapDrag3D.__c__DisplayClass22_1.NativeFieldInfoPtr_a), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003910 RID: 14608
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x04003911 RID: 14609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003912 RID: 14610
			private static readonly IntPtr NativeMethodInfoPtr__GatherDestinationObjects_b__1_Internal_Boolean_GameObject_0;
		}
	}
}
