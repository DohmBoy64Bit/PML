using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000044 RID: 68
	public class IGizmoDragSession : global::Il2CppSystem.Object
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x00032114 File Offset: 0x00030314
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoDragSession()
		{
			Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoDragSession");
			IGizmoDragSession.NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663933);
			IGizmoDragSession.NativeMethodInfoPtr_get_DragChannel_Public_Abstract_Virtual_New_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663934);
			IGizmoDragSession.NativeMethodInfoPtr_get_TotalDragOffset_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663935);
			IGizmoDragSession.NativeMethodInfoPtr_get_TotalDragRotation_Public_Abstract_Virtual_New_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663936);
			IGizmoDragSession.NativeMethodInfoPtr_get_TotalDragScale_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663937);
			IGizmoDragSession.NativeMethodInfoPtr_get_RelativeDragOffset_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663938);
			IGizmoDragSession.NativeMethodInfoPtr_get_RelativeDragRotation_Public_Abstract_Virtual_New_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663939);
			IGizmoDragSession.NativeMethodInfoPtr_get_RelativeDragScale_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663940);
			IGizmoDragSession.NativeMethodInfoPtr_ContainsTargetTransform_Public_Abstract_Virtual_New_Boolean_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663941);
			IGizmoDragSession.NativeMethodInfoPtr_AddTargetTransform_Public_Abstract_Virtual_New_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663942);
			IGizmoDragSession.NativeMethodInfoPtr_RemoveTargetTransform_Public_Abstract_Virtual_New_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663943);
			IGizmoDragSession.NativeMethodInfoPtr_Begin_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663944);
			IGizmoDragSession.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663945);
			IGizmoDragSession.NativeMethodInfoPtr_End_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoDragSession>.NativeClassPtr, 100663946);
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00032254 File Offset: 0x00030454
		public unsafe virtual bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0003229C File Offset: 0x0003049C
		public unsafe virtual GizmoDragChannel DragChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_get_DragChannel_Public_Abstract_Virtual_New_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000322E8 File Offset: 0x000304E8
		public unsafe virtual Vector3 TotalDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_get_TotalDragOffset_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00032334 File Offset: 0x00030534
		public unsafe virtual Quaternion TotalDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_get_TotalDragRotation_Public_Abstract_Virtual_New_get_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00032380 File Offset: 0x00030580
		public unsafe virtual Vector3 TotalDragScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_get_TotalDragScale_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x000323CC File Offset: 0x000305CC
		public unsafe virtual Vector3 RelativeDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_get_RelativeDragOffset_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00032418 File Offset: 0x00030618
		public unsafe virtual Quaternion RelativeDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_get_RelativeDragRotation_Public_Abstract_Virtual_New_get_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00032464 File Offset: 0x00030664
		public unsafe virtual Vector3 RelativeDragScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_get_RelativeDragScale_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000324B0 File Offset: 0x000306B0
		[CallerCount(0)]
		public unsafe virtual bool ContainsTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_ContainsTargetTransform_Public_Abstract_Virtual_New_Boolean_GizmoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00032508 File Offset: 0x00030708
		[CallerCount(0)]
		public unsafe virtual void AddTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_AddTargetTransform_Public_Abstract_Virtual_New_Void_GizmoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00032558 File Offset: 0x00030758
		[CallerCount(0)]
		public unsafe virtual void RemoveTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_RemoveTargetTransform_Public_Abstract_Virtual_New_Void_GizmoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000325A8 File Offset: 0x000307A8
		[CallerCount(0)]
		public unsafe virtual bool Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_Begin_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000325F0 File Offset: 0x000307F0
		[CallerCount(0)]
		public unsafe virtual bool Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00032638 File Offset: 0x00030838
		[CallerCount(0)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoDragSession.NativeMethodInfoPtr_End_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00003A67 File Offset: 0x00001C67
		public IGizmoDragSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Abstract_Virtual_New_get_GizmoDragChannel_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragOffset_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragRotation_Public_Abstract_Virtual_New_get_Quaternion_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragScale_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragOffset_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragRotation_Public_Abstract_Virtual_New_get_Quaternion_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragScale_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_ContainsTargetTransform_Public_Abstract_Virtual_New_Boolean_GizmoTransform_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Abstract_Virtual_New_Void_GizmoTransform_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Abstract_Virtual_New_Void_GizmoTransform_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Abstract_Virtual_New_Void_0;
	}
}
