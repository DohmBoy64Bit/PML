using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001C1 RID: 449
	public class InputDevicePlaneDragSession3D : global::Il2CppSystem.Object
	{
		// Token: 0x0600229E RID: 8862 RVA: 0x000AAA6C File Offset: 0x000A8C6C
		// Note: this type is marked as 'beforefieldinit'.
		static InputDevicePlaneDragSession3D()
		{
			Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "InputDevicePlaneDragSession3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr);
			InputDevicePlaneDragSession3D.NativeFieldInfoPtr__plane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, "_plane");
			InputDevicePlaneDragSession3D.NativeFieldInfoPtr__raycastCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, "_raycastCamera");
			InputDevicePlaneDragSession3D.NativeFieldInfoPtr__dragPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, "_dragPoint");
			InputDevicePlaneDragSession3D.NativeFieldInfoPtr__dragDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, "_dragDelta");
			InputDevicePlaneDragSession3D.NativeFieldInfoPtr__accumDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, "_accumDrag");
			InputDevicePlaneDragSession3D.NativeFieldInfoPtr__inputDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, "_inputDevice");
			InputDevicePlaneDragSession3D.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, "_isActive");
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668527);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_set_Plane_Public_set_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668528);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_RaycastCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668529);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_set_RaycastCamera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668530);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_DragPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668531);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_DragDelta_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668532);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_AccumDrag_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668533);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668534);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr__ctor_Public_Void_IInputDevice_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668535);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_Begin_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668536);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668537);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_Update_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668538);
			InputDevicePlaneDragSession3D.NativeMethodInfoPtr_UpdateDragPoint_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr, 100668539);
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x000AAC2C File Offset: 0x000A8E2C
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x000AAC6C File Offset: 0x000A8E6C
		public unsafe Plane Plane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87475, RefRangeEnd = 87476, XrefRangeStart = 87475, XrefRangeEnd = 87475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_set_Plane_Public_set_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x000AACB0 File Offset: 0x000A8EB0
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x000AACF0 File Offset: 0x000A8EF0
		public unsafe Camera RaycastCamera
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_RaycastCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87476, XrefRangeEnd = 87477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_set_RaycastCamera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x000AAD34 File Offset: 0x000A8F34
		public unsafe Vector3 DragPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_DragPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x000AAD74 File Offset: 0x000A8F74
		public unsafe Vector3 DragDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_DragDelta_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x000AADB4 File Offset: 0x000A8FB4
		public unsafe Vector3 AccumDrag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_AccumDrag_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x000AADF4 File Offset: 0x000A8FF4
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x000AAE30 File Offset: 0x000A9030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87480, RefRangeEnd = 87481, XrefRangeStart = 87477, XrefRangeEnd = 87480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDevicePlaneDragSession3D(IInputDevice inputDevice, Camera raycastCamera)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDevicePlaneDragSession3D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr__ctor_Public_Void_IInputDevice_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x000AAE90 File Offset: 0x000A9090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87486, RefRangeEnd = 87487, XrefRangeStart = 87481, XrefRangeEnd = 87486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_Begin_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000AAECC File Offset: 0x000A90CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87493, RefRangeEnd = 87494, XrefRangeStart = 87487, XrefRangeEnd = 87493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000AAF00 File Offset: 0x000A9100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87495, RefRangeEnd = 87496, XrefRangeStart = 87494, XrefRangeEnd = 87495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_Update_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x000AAF3C File Offset: 0x000A913C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87500, RefRangeEnd = 87502, XrefRangeStart = 87496, XrefRangeEnd = 87500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateDragPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevicePlaneDragSession3D.NativeMethodInfoPtr_UpdateDragPoint_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x0000E221 File Offset: 0x0000C421
		public InputDevicePlaneDragSession3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x000AAF78 File Offset: 0x000A9178
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x0000E22A File Offset: 0x0000C42A
		public unsafe Plane _plane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__plane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__plane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x000AAFA8 File Offset: 0x000A91A8
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x0000E249 File Offset: 0x0000C449
		public unsafe Camera _raycastCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__raycastCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__raycastCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x000AAFD8 File Offset: 0x000A91D8
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x0000E268 File Offset: 0x0000C468
		public unsafe Vector3 _dragPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__dragPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__dragPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x000AB008 File Offset: 0x000A9208
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x0000E287 File Offset: 0x0000C487
		public unsafe Vector3 _dragDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__dragDelta);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__dragDelta), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x000AB038 File Offset: 0x000A9238
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x0000E2A6 File Offset: 0x0000C4A6
		public unsafe Vector3 _accumDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__accumDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__accumDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x000AB068 File Offset: 0x000A9268
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x0000E2C5 File Offset: 0x0000C4C5
		public unsafe IInputDevice _inputDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__inputDevice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IInputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__inputDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x000AB098 File Offset: 0x000A9298
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDevicePlaneDragSession3D.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeFieldInfoPtr__plane;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeFieldInfoPtr__raycastCamera;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeFieldInfoPtr__dragPoint;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeFieldInfoPtr__dragDelta;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeFieldInfoPtr__accumDrag;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeFieldInfoPtr__inputDevice;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr_get_Plane_Public_get_Plane_0;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr_set_Plane_Public_set_Void_Plane_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_get_RaycastCamera_Public_get_Camera_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_set_RaycastCamera_Public_set_Void_Camera_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_get_DragPoint_Public_get_Vector3_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_get_DragDelta_Public_get_Vector3_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_get_AccumDrag_Public_get_Vector3_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IInputDevice_Camera_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Boolean_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Boolean_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDragPoint_Private_Boolean_0;
	}
}
