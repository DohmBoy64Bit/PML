using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000048 RID: 72
	public class IGizmoBehaviour : global::Il2CppSystem.Object
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x00033434 File Offset: 0x00031634
		// Note: this type is marked as 'beforefieldinit'.
		static IGizmoBehaviour()
		{
			Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IGizmoBehaviour");
			IGizmoBehaviour.NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663983);
			IGizmoBehaviour.NativeMethodInfoPtr_get_IsEnabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663984);
			IGizmoBehaviour.NativeMethodInfoPtr_Init_SystemCall_Public_Abstract_Virtual_New_Void_GizmoBehaviorInitParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663985);
			IGizmoBehaviour.NativeMethodInfoPtr_SetEnabled_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663986);
			IGizmoBehaviour.NativeMethodInfoPtr_OnAttached_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663987);
			IGizmoBehaviour.NativeMethodInfoPtr_OnDetached_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663988);
			IGizmoBehaviour.NativeMethodInfoPtr_OnEnabled_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663989);
			IGizmoBehaviour.NativeMethodInfoPtr_OnDisabled_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663990);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoEnabled_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663991);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoDisabled_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663992);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoHandlePicked_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663993);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoCanBeginDrag_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663994);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663995);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoHoverEnter_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663996);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoHoverExit_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663997);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoDragBegin_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663998);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100663999);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100664000);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100664001);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoUpdateEnd_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100664002);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGUI_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100664003);
			IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoRender_Public_Abstract_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGizmoBehaviour>.NativeClassPtr, 100664004);
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00033614 File Offset: 0x00031814
		public unsafe virtual Gizmo Gizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00033660 File Offset: 0x00031860
		public unsafe virtual bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_get_IsEnabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000336A8 File Offset: 0x000318A8
		[CallerCount(0)]
		public unsafe virtual void Init_SystemCall(GizmoBehaviorInitParams initParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initParams);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_Init_SystemCall_Public_Abstract_Virtual_New_Void_GizmoBehaviorInitParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000336F8 File Offset: 0x000318F8
		[CallerCount(0)]
		public unsafe virtual void SetEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_SetEnabled_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00033744 File Offset: 0x00031944
		[CallerCount(0)]
		public unsafe virtual void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnAttached_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00033780 File Offset: 0x00031980
		[CallerCount(0)]
		public unsafe virtual void OnDetached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnDetached_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000337BC File Offset: 0x000319BC
		[CallerCount(0)]
		public unsafe virtual void OnEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnEnabled_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000337F8 File Offset: 0x000319F8
		[CallerCount(0)]
		public unsafe virtual void OnDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnDisabled_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00033834 File Offset: 0x00031A34
		[CallerCount(0)]
		public unsafe virtual void OnGizmoEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoEnabled_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00033870 File Offset: 0x00031A70
		[CallerCount(0)]
		public unsafe virtual void OnGizmoDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoDisabled_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000338AC File Offset: 0x00031AAC
		[CallerCount(0)]
		public unsafe virtual void OnGizmoHandlePicked(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoHandlePicked_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000338F8 File Offset: 0x00031AF8
		[CallerCount(0)]
		public unsafe virtual bool OnGizmoCanBeginDrag(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoCanBeginDrag_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0003394C File Offset: 0x00031B4C
		[CallerCount(0)]
		public unsafe virtual void OnGizmoAttemptHandleDragBegin(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00033998 File Offset: 0x00031B98
		[CallerCount(0)]
		public unsafe virtual void OnGizmoHoverEnter(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoHoverEnter_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000339E4 File Offset: 0x00031BE4
		[CallerCount(0)]
		public unsafe virtual void OnGizmoHoverExit(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoHoverExit_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00033A30 File Offset: 0x00031C30
		[CallerCount(0)]
		public unsafe virtual void OnGizmoDragBegin(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoDragBegin_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00033A7C File Offset: 0x00031C7C
		[CallerCount(0)]
		public unsafe virtual void OnGizmoDragUpdate(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00033AC8 File Offset: 0x00031CC8
		[CallerCount(0)]
		public unsafe virtual void OnGizmoDragEnd(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00033B14 File Offset: 0x00031D14
		[CallerCount(0)]
		public unsafe virtual void OnGizmoUpdateBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00033B50 File Offset: 0x00031D50
		[CallerCount(0)]
		public unsafe virtual void OnGizmoUpdateEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoUpdateEnd_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00033B8C File Offset: 0x00031D8C
		[CallerCount(0)]
		public unsafe virtual void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGUI_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00033BC8 File Offset: 0x00031DC8
		[CallerCount(0)]
		public unsafe virtual void OnGizmoRender(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGizmoBehaviour.NativeMethodInfoPtr_OnGizmoRender_Public_Abstract_Virtual_New_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00003B4E File Offset: 0x00001D4E
		public IGizmoBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_Abstract_Virtual_New_get_Gizmo_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_Init_SystemCall_Public_Abstract_Virtual_New_Void_GizmoBehaviorInitParams_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_OnDetached_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabled_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_OnDisabled_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoEnabled_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDisabled_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandlePicked_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoCanBeginDrag_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHoverEnter_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHoverExit_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragBegin_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragEnd_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoUpdateEnd_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoRender_Public_Abstract_Virtual_New_Void_Camera_0;
	}
}
