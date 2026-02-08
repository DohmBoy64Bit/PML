using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200003B RID: 59
	public class GizmoDragSession : global::Il2CppSystem.Object
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x0002F270 File Offset: 0x0002D470
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoDragSession()
		{
			Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoDragSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr);
			GizmoDragSession.NativeFieldInfoPtr__targetTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, "_targetTransforms");
			GizmoDragSession.NativeFieldInfoPtr__totalDragOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, "_totalDragOffset");
			GizmoDragSession.NativeFieldInfoPtr__totalDragRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, "_totalDragRotation");
			GizmoDragSession.NativeFieldInfoPtr__totalDragScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, "_totalDragScale");
			GizmoDragSession.NativeFieldInfoPtr__relativeDragOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, "_relativeDragOffset");
			GizmoDragSession.NativeFieldInfoPtr__relativeDragRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, "_relativeDragRotation");
			GizmoDragSession.NativeFieldInfoPtr__relativeDragScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, "_relativeDragScale");
			GizmoDragSession.NativeMethodInfoPtr_get_NumTargetTransforms_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663827);
			GizmoDragSession.NativeMethodInfoPtr_get_TotalDragOffset_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663828);
			GizmoDragSession.NativeMethodInfoPtr_get_TotalDragRotation_Public_Virtual_Final_New_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663829);
			GizmoDragSession.NativeMethodInfoPtr_get_TotalDragScale_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663830);
			GizmoDragSession.NativeMethodInfoPtr_get_RelativeDragOffset_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663831);
			GizmoDragSession.NativeMethodInfoPtr_get_RelativeDragRotation_Public_Virtual_Final_New_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663832);
			GizmoDragSession.NativeMethodInfoPtr_get_RelativeDragScale_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663833);
			GizmoDragSession.NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663834);
			GizmoDragSession.NativeMethodInfoPtr_get_DragChannel_Public_Abstract_Virtual_New_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663835);
			GizmoDragSession.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663850);
			GizmoDragSession.NativeMethodInfoPtr_ContainsTargetTransform_Public_Virtual_Final_New_Boolean_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663836);
			GizmoDragSession.NativeMethodInfoPtr_AddTargetTransform_Public_Virtual_Final_New_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663837);
			GizmoDragSession.NativeMethodInfoPtr_RemoveTargetTransform_Public_Virtual_Final_New_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663838);
			GizmoDragSession.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663839);
			GizmoDragSession.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663840);
			GizmoDragSession.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663841);
			GizmoDragSession.NativeMethodInfoPtr_DoBeginSession_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663842);
			GizmoDragSession.NativeMethodInfoPtr_DoUpdateSession_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663843);
			GizmoDragSession.NativeMethodInfoPtr_DoEndSession_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663844);
			GizmoDragSession.NativeMethodInfoPtr_CalculateDragValues_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663845);
			GizmoDragSession.NativeMethodInfoPtr_ApplyDrag_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663846);
			GizmoDragSession.NativeMethodInfoPtr_CanBegin_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663847);
			GizmoDragSession.NativeMethodInfoPtr_OnSessionBegin_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663848);
			GizmoDragSession.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr, 100663849);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0002F50C File Offset: 0x0002D70C
		public unsafe int NumTargetTransforms
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59000, XrefRangeEnd = 59001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_get_NumTargetTransforms_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0002F548 File Offset: 0x0002D748
		public unsafe virtual Vector3 TotalDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_get_TotalDragOffset_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0002F588 File Offset: 0x0002D788
		public unsafe virtual Quaternion TotalDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_get_TotalDragRotation_Public_Virtual_Final_New_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0002F5C8 File Offset: 0x0002D7C8
		public unsafe virtual Vector3 TotalDragScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_get_TotalDragScale_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0002F608 File Offset: 0x0002D808
		public unsafe virtual Vector3 RelativeDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_get_RelativeDragOffset_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0002F648 File Offset: 0x0002D848
		public unsafe virtual Quaternion RelativeDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_get_RelativeDragRotation_Public_Virtual_Final_New_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0002F688 File Offset: 0x0002D888
		public unsafe virtual Vector3 RelativeDragScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_get_RelativeDragScale_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0002F6C8 File Offset: 0x0002D8C8
		public unsafe virtual bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDragSession.NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0002F710 File Offset: 0x0002D910
		public unsafe virtual GizmoDragChannel DragChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDragSession.NativeMethodInfoPtr_get_DragChannel_Public_Abstract_Virtual_New_get_GizmoDragChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0002F75C File Offset: 0x0002D95C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 59013, RefRangeEnd = 59023, XrefRangeStart = 59001, XrefRangeEnd = 59013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoDragSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoDragSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0002F798 File Offset: 0x0002D998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59023, XrefRangeEnd = 59027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_ContainsTargetTransform_Public_Virtual_Final_New_Boolean_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 59033, RefRangeEnd = 59077, XrefRangeStart = 59027, XrefRangeEnd = 59033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_AddTargetTransform_Public_Virtual_Final_New_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0002F82C File Offset: 0x0002DA2C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 59080, RefRangeEnd = 59096, XrefRangeStart = 59077, XrefRangeEnd = 59080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_RemoveTargetTransform_Public_Virtual_Final_New_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0002F870 File Offset: 0x0002DA70
		[CallerCount(0)]
		public unsafe virtual bool Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0002F8AC File Offset: 0x0002DAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59096, XrefRangeEnd = 59097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0002F8E8 File Offset: 0x0002DAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59097, XrefRangeEnd = 59103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0002F91C File Offset: 0x0002DB1C
		[CallerCount(0)]
		public unsafe virtual bool DoBeginSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDragSession.NativeMethodInfoPtr_DoBeginSession_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0002F964 File Offset: 0x0002DB64
		[CallerCount(0)]
		public unsafe virtual bool DoUpdateSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDragSession.NativeMethodInfoPtr_DoUpdateSession_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0002F9AC File Offset: 0x0002DBAC
		[CallerCount(0)]
		public unsafe virtual void DoEndSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDragSession.NativeMethodInfoPtr_DoEndSession_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0002F9E8 File Offset: 0x0002DBE8
		[CallerCount(0)]
		public unsafe virtual void CalculateDragValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDragSession.NativeMethodInfoPtr_CalculateDragValues_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0002FA24 File Offset: 0x0002DC24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59130, RefRangeEnd = 59131, XrefRangeStart = 59103, XrefRangeEnd = 59130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoDragSession.NativeMethodInfoPtr_ApplyDrag_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0002FA58 File Offset: 0x0002DC58
		[CallerCount(0)]
		public unsafe virtual bool CanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDragSession.NativeMethodInfoPtr_CanBegin_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0002FAA0 File Offset: 0x0002DCA0
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSessionBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDragSession.NativeMethodInfoPtr_OnSessionBegin_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0002FADC File Offset: 0x0002DCDC
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoDragSession.NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00003526 File Offset: 0x00001726
		public GizmoDragSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0002FB18 File Offset: 0x0002DD18
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x0000352F File Offset: 0x0000172F
		public unsafe List<GizmoTransform> _targetTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__targetTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__targetTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0002FB48 File Offset: 0x0002DD48
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0000354E File Offset: 0x0000174E
		public unsafe Vector3 _totalDragOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__totalDragOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__totalDragOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0002FB78 File Offset: 0x0002DD78
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0000356D File Offset: 0x0000176D
		public unsafe Quaternion _totalDragRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__totalDragRotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__totalDragRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0002FBA8 File Offset: 0x0002DDA8
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0000358C File Offset: 0x0000178C
		public unsafe Vector3 _totalDragScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__totalDragScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__totalDragScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0002FBD8 File Offset: 0x0002DDD8
		// (set) Token: 0x060003CA RID: 970 RVA: 0x000035AB File Offset: 0x000017AB
		public unsafe Vector3 _relativeDragOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__relativeDragOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__relativeDragOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0002FC08 File Offset: 0x0002DE08
		// (set) Token: 0x060003CC RID: 972 RVA: 0x000035CA File Offset: 0x000017CA
		public unsafe Quaternion _relativeDragRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__relativeDragRotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__relativeDragRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0002FC38 File Offset: 0x0002DE38
		// (set) Token: 0x060003CE RID: 974 RVA: 0x000035E9 File Offset: 0x000017E9
		public unsafe Vector3 _relativeDragScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__relativeDragScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoDragSession.NativeFieldInfoPtr__relativeDragScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr__targetTransforms;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr__totalDragOffset;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr__totalDragRotation;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr__totalDragScale;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr__relativeDragOffset;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr__relativeDragRotation;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr__relativeDragScale;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_get_NumTargetTransforms_Public_get_Int32_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragOffset_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragRotation_Public_Virtual_Final_New_get_Quaternion_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragScale_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragOffset_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragRotation_Public_Virtual_Final_New_get_Quaternion_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragScale_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_Abstract_Virtual_New_get_GizmoDragChannel_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_ContainsTargetTransform_Public_Virtual_Final_New_Boolean_GizmoTransform_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Virtual_Final_New_Void_GizmoTransform_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Virtual_Final_New_Void_GizmoTransform_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_DoBeginSession_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdateSession_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_DoEndSession_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDragValues_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDrag_Protected_Void_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_CanBegin_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionBegin_Protected_Virtual_New_Void_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_OnSessionEnd_Protected_Virtual_New_Void_0;
	}
}
