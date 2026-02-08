using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000282 RID: 642
	public class Instance : NetworkBehaviour
	{
		// Token: 0x06003334 RID: 13108 RVA: 0x000E9F84 File Offset: 0x000E8184
		// Note: this type is marked as 'beforefieldinit'.
		static Instance()
		{
			Il2CppClassPointerStore<Instance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Instance");
			Instance.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "_transform");
			Instance.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "_name");
			Instance.NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "className");
			Instance.NativeFieldInfoPtr_canReparent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "canReparent");
			Instance.NativeFieldInfoPtr_hidesMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "hidesMembers");
			Instance.NativeFieldInfoPtr_clientSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "clientSpawned");
			Instance.NativeFieldInfoPtr_shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "shared");
			Instance.NativeFieldInfoPtr_ChildRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "ChildRemoved");
			Instance.NativeFieldInfoPtr_ChildAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "ChildAdded");
			Instance.NativeFieldInfoPtr_Touched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "Touched");
			Instance.NativeFieldInfoPtr_TouchEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "TouchEnded");
			Instance.NativeFieldInfoPtr_MouseHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "MouseHover");
			Instance.NativeFieldInfoPtr_MouseHoverEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "MouseHoverEnded");
			Instance.NativeFieldInfoPtr_Clicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "Clicked");
			Instance.NativeFieldInfoPtr_MouseEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "MouseEnter");
			Instance.NativeFieldInfoPtr_MouseExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "MouseExit");
			Instance.NativeFieldInfoPtr__DescendantAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "_DescendantAdded");
			Instance.NativeFieldInfoPtr__ParentChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "_ParentChanged");
			Instance.NativeFieldInfoPtr__Touched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "_Touched");
			Instance.NativeFieldInfoPtr_isHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "isHidden");
			Instance.NativeFieldInfoPtr_isMouseOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Instance>.NativeClassPtr, "isMouseOver");
			Instance.NativeMethodInfoPtr_get_ClientSpawned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671024);
			Instance.NativeMethodInfoPtr_get_CanReparent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671025);
			Instance.NativeMethodInfoPtr_get_DescendantLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671032);
			Instance.NativeMethodInfoPtr_get_Item_Public_get_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671033);
			Instance.NativeMethodInfoPtr_get_Item_Public_get_Instance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671034);
			Instance.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671035);
			Instance.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671036);
			Instance.NativeMethodInfoPtr_get_FullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671037);
			Instance.NativeMethodInfoPtr_get_ClassName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671038);
			Instance.NativeMethodInfoPtr_get_Shared_Public_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671039);
			Instance.NativeMethodInfoPtr_get_Parent_Public_get_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671040);
			Instance.NativeMethodInfoPtr_set_Parent_Public_set_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671041);
			Instance.NativeMethodInfoPtr_get_Network_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671084);
			Instance.NativeMethodInfoPtr_set_Network_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671085);
			Instance.NativeMethodInfoPtr_add__DescendantAdded_Public_add_Void_Action_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671026);
			Instance.NativeMethodInfoPtr_remove__DescendantAdded_Public_rem_Void_Action_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671027);
			Instance.NativeMethodInfoPtr_add__ParentChanged_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671028);
			Instance.NativeMethodInfoPtr_remove__ParentChanged_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671029);
			Instance.NativeMethodInfoPtr_add__Touched_Public_add_Void_Action_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671030);
			Instance.NativeMethodInfoPtr_remove__Touched_Public_rem_Void_Action_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671031);
			Instance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671082);
			Instance.NativeMethodInfoPtr_GetParent_Public_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671042);
			Instance.NativeMethodInfoPtr_SetParent_Public_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671043);
			Instance.NativeMethodInfoPtr_OnHide_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671044);
			Instance.NativeMethodInfoPtr_OnShow_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671045);
			Instance.NativeMethodInfoPtr_RpcSetParent_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671046);
			Instance.NativeMethodInfoPtr_FindChild_Public_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671047);
			Instance.NativeMethodInfoPtr_GetChildren_Public_Il2CppReferenceArray_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671048);
			Instance.NativeMethodInfoPtr_GetChildrenOfClass_Public_Il2CppReferenceArray_1_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671049);
			Instance.NativeMethodInfoPtr_GetChildrenOfType_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671050);
			Instance.NativeMethodInfoPtr_FindChildOfType_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671051);
			Instance.NativeMethodInfoPtr_FindChildByClass_Public_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671052);
			Instance.NativeMethodInfoPtr_IsA_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671053);
			Instance.NativeMethodInfoPtr_IsDescendantOf_Public_Boolean_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671054);
			Instance.NativeMethodInfoPtr_IsDescendantOfType_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671055);
			Instance.NativeMethodInfoPtr_Destroy_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671056);
			Instance.NativeMethodInfoPtr_Delete_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671057);
			Instance.NativeMethodInfoPtr_RpcSetName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671058);
			Instance.NativeMethodInfoPtr_RequestParent_Private_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671059);
			Instance.NativeMethodInfoPtr_SetParentTargetRpc_Private_Void_NetworkConnection_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671060);
			Instance.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671061);
			Instance.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671062);
			Instance.NativeMethodInfoPtr_OnNetworkStart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671063);
			Instance.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671064);
			Instance.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671065);
			Instance.NativeMethodInfoPtr_OnGameLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671066);
			Instance.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671067);
			Instance.NativeMethodInfoPtr_New_Public_Static_Instance_String_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671068);
			Instance.NativeMethodInfoPtr_OnCollisionEnter_Protected_Virtual_New_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671069);
			Instance.NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671070);
			Instance.NativeMethodInfoPtr_OnCollisionExit_Protected_Virtual_New_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671071);
			Instance.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671072);
			Instance.NativeMethodInfoPtr_GetDescendantLevel_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671073);
			Instance.NativeMethodInfoPtr_OnMouseDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671074);
			Instance.NativeMethodInfoPtr_OnMouseEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671075);
			Instance.NativeMethodInfoPtr_OnMouseExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671076);
			Instance.NativeMethodInfoPtr_CmdClicked_Private_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671077);
			Instance.NativeMethodInfoPtr_Clone_Public_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671078);
			Instance.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_New_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671079);
			Instance.NativeMethodInfoPtr_PostClone_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671080);
			Instance.NativeMethodInfoPtr_GetBounds_Public_Bounds_BoundsCalculationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671081);
			Instance.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671083);
			Instance.NativeMethodInfoPtr_UserCode_RpcSetParent__Transform_Protected_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671086);
			Instance.NativeMethodInfoPtr_InvokeUserCode_RpcSetParent__Transform_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671087);
			Instance.NativeMethodInfoPtr_UserCode_RpcSetName__String_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671088);
			Instance.NativeMethodInfoPtr_InvokeUserCode_RpcSetName__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671089);
			Instance.NativeMethodInfoPtr_UserCode_RequestParent__NetworkConnectionToClient_Protected_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671090);
			Instance.NativeMethodInfoPtr_InvokeUserCode_RequestParent__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671091);
			Instance.NativeMethodInfoPtr_UserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32_Protected_Void_NetworkConnection_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671092);
			Instance.NativeMethodInfoPtr_InvokeUserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671093);
			Instance.NativeMethodInfoPtr_UserCode_CmdClicked__NetworkConnectionToClient_Protected_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671094);
			Instance.NativeMethodInfoPtr_InvokeUserCode_CmdClicked__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671095);
			Instance.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671097);
			Instance.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instance>.NativeClassPtr, 100671098);
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x000EA718 File Offset: 0x000E8918
		public unsafe bool ClientSpawned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_ClientSpawned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x06003336 RID: 13110 RVA: 0x000EA754 File Offset: 0x000E8954
		public unsafe bool CanReparent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72888, RefRangeEnd = 72889, XrefRangeStart = 72888, XrefRangeEnd = 72889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_CanReparent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x000EA790 File Offset: 0x000E8990
		public unsafe int DescendantLevel
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 104539, RefRangeEnd = 104545, XrefRangeStart = 104528, XrefRangeEnd = 104539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_DescendantLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001200 RID: 4608
		public unsafe Instance this[string name]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 104556, RefRangeEnd = 104557, XrefRangeStart = 104545, XrefRangeEnd = 104556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_Item_Public_get_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17001201 RID: 4609
		public unsafe Instance this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 104558, RefRangeEnd = 104559, XrefRangeStart = 104557, XrefRangeEnd = 104558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_Item_Public_get_Instance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x0600333A RID: 13114 RVA: 0x000EA868 File Offset: 0x000E8A68
		// (set) Token: 0x0600333B RID: 13115 RVA: 0x000EA8A0 File Offset: 0x000E8AA0
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 104577, RefRangeEnd = 104615, XrefRangeStart = 104559, XrefRangeEnd = 104577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x0600333C RID: 13116 RVA: 0x000EA8E4 File Offset: 0x000E8AE4
		public unsafe string FullName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 104635, RefRangeEnd = 104637, XrefRangeStart = 104615, XrefRangeEnd = 104635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_FullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x000EA91C File Offset: 0x000E8B1C
		public unsafe string ClassName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_ClassName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x0600333E RID: 13118 RVA: 0x000EA954 File Offset: 0x000E8B54
		public unsafe DynValue Shared
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_Shared_Public_get_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x000EA994 File Offset: 0x000E8B94
		// (set) Token: 0x06003340 RID: 13120 RVA: 0x000EA9D4 File Offset: 0x000E8BD4
		public unsafe Instance Parent
		{
			[CallerCount(59)]
			[CachedScanResults(RefRangeStart = 104653, RefRangeEnd = 104712, XrefRangeStart = 104637, XrefRangeEnd = 104653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_Parent_Public_get_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 104713, RefRangeEnd = 104732, XrefRangeStart = 104712, XrefRangeEnd = 104713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_set_Parent_Public_set_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x000EAA18 File Offset: 0x000E8C18
		// (set) Token: 0x06003342 RID: 13122 RVA: 0x000EAA50 File Offset: 0x000E8C50
		public unsafe string Network_name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_get_Network_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 104738, RefRangeEnd = 104740, XrefRangeStart = 104732, XrefRangeEnd = 104738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_set_Network_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x000EAA94 File Offset: 0x000E8C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104745, RefRangeEnd = 104746, XrefRangeStart = 104740, XrefRangeEnd = 104745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__DescendantAdded(Action<Instance> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_add__DescendantAdded_Public_add_Void_Action_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x000EAAD8 File Offset: 0x000E8CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104746, XrefRangeEnd = 104751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__DescendantAdded(Action<Instance> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_remove__DescendantAdded_Public_rem_Void_Action_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x000EAB1C File Offset: 0x000E8D1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 104755, RefRangeEnd = 104759, XrefRangeStart = 104751, XrefRangeEnd = 104755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__ParentChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_add__ParentChanged_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x000EAB60 File Offset: 0x000E8D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104759, XrefRangeEnd = 104763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__ParentChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_remove__ParentChanged_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x000EABA4 File Offset: 0x000E8DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104768, RefRangeEnd = 104769, XrefRangeStart = 104763, XrefRangeEnd = 104768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__Touched(Action<Instance> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_add__Touched_Public_add_Void_Action_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000EABE8 File Offset: 0x000E8DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104769, XrefRangeEnd = 104774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__Touched(Action<Instance> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_remove__Touched_Public_rem_Void_Action_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x000EAC2C File Offset: 0x000E8E2C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 104817, RefRangeEnd = 104841, XrefRangeStart = 104774, XrefRangeEnd = 104817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Instance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x000EAC68 File Offset: 0x000E8E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104857, RefRangeEnd = 104858, XrefRangeStart = 104841, XrefRangeEnd = 104857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance GetParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_GetParent_Public_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x000EACA8 File Offset: 0x000E8EA8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 104921, RefRangeEnd = 104933, XrefRangeStart = 104858, XrefRangeEnd = 104921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Instance par)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(par);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_SetParent_Public_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x000EACEC File Offset: 0x000E8EEC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 104958, RefRangeEnd = 104975, XrefRangeStart = 104933, XrefRangeEnd = 104958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnHide_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x000EAD28 File Offset: 0x000E8F28
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 104996, RefRangeEnd = 105011, XrefRangeStart = 104975, XrefRangeEnd = 104996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnShow_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x000EAD64 File Offset: 0x000E8F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105011, XrefRangeEnd = 105032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetParent(Transform par)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(par);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_RpcSetParent_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x000EADA8 File Offset: 0x000E8FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105043, RefRangeEnd = 105045, XrefRangeStart = 105032, XrefRangeEnd = 105043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance FindChild(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_FindChild_Public_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x000EADF8 File Offset: 0x000E8FF8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 105076, RefRangeEnd = 105101, XrefRangeStart = 105045, XrefRangeEnd = 105076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Instance> GetChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_GetChildren_Public_Il2CppReferenceArray_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instance>>(intPtr3) : null;
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x000EAE38 File Offset: 0x000E9038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105126, RefRangeEnd = 105127, XrefRangeStart = 105101, XrefRangeEnd = 105126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Instance> GetChildrenOfClass(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_GetChildrenOfClass_Public_Il2CppReferenceArray_1_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instance>>(intPtr3) : null;
			}
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x000EAE88 File Offset: 0x000E9088
		[CallerCount(0)]
		public unsafe Il2CppArrayBase<T> GetChildrenOfType<T>() where T : Instance
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.MethodInfoStoreGeneric_GetChildrenOfType_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x000EAEC0 File Offset: 0x000E90C0
		[CallerCount(0)]
		public unsafe T FindChildOfType<T>() where T : Instance
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.MethodInfoStoreGeneric_FindChildOfType_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000EAEFC File Offset: 0x000E90FC
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 105130, RefRangeEnd = 105159, XrefRangeStart = 105127, XrefRangeEnd = 105130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance FindChildByClass(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_FindChildByClass_Public_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x000EAF4C File Offset: 0x000E914C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105162, RefRangeEnd = 105163, XrefRangeStart = 105159, XrefRangeEnd = 105162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsA(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_IsA_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x000EAF9C File Offset: 0x000E919C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 105165, RefRangeEnd = 105170, XrefRangeStart = 105163, XrefRangeEnd = 105165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDescendantOf(Instance other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_IsDescendantOf_Public_Boolean_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x000EAFEC File Offset: 0x000E91EC
		[CallerCount(0)]
		public unsafe bool IsDescendantOfType<T>() where T : Instance
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.MethodInfoStoreGeneric_IsDescendantOfType_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000EB028 File Offset: 0x000E9228
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 105186, RefRangeEnd = 105193, XrefRangeStart = 105170, XrefRangeEnd = 105186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy(float time = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_Destroy_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000EB068 File Offset: 0x000E9268
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 105186, RefRangeEnd = 105193, XrefRangeStart = 105186, XrefRangeEnd = 105193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete(float time = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_Delete_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x000EB0A8 File Offset: 0x000E92A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105193, XrefRangeEnd = 105214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetName(string n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_RpcSetName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x000EB0EC File Offset: 0x000E92EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105234, RefRangeEnd = 105236, XrefRangeStart = 105214, XrefRangeEnd = 105234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestParent(NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_RequestParent_Private_Void_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x000EB130 File Offset: 0x000E9330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105236, XrefRangeEnd = 105258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParentTargetRpc(NetworkConnection target, Transform par, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_SetParentTargetRpc_Private_Void_NetworkConnection_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x000EB194 File Offset: 0x000E9394
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 105264, RefRangeEnd = 105280, XrefRangeStart = 105258, XrefRangeEnd = 105264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x000EB1D0 File Offset: 0x000E93D0
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x000EB20C File Offset: 0x000E940C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105299, RefRangeEnd = 105301, XrefRangeStart = 105280, XrefRangeEnd = 105299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnNetworkStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnNetworkStart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x000EB248 File Offset: 0x000E9448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105324, RefRangeEnd = 105326, XrefRangeStart = 105301, XrefRangeEnd = 105324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000EB284 File Offset: 0x000E9484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105326, XrefRangeEnd = 105327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x000EB2C0 File Offset: 0x000E94C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105327, XrefRangeEnd = 105341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGameLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_OnGameLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x000EB2F4 File Offset: 0x000E94F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105361, RefRangeEnd = 105363, XrefRangeStart = 105341, XrefRangeEnd = 105361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x000EB330 File Offset: 0x000E9530
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 105458, RefRangeEnd = 105465, XrefRangeStart = 105363, XrefRangeEnd = 105458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instance New(string className, Instance parent = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_New_Public_Static_Instance_String_Instance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x000EB388 File Offset: 0x000E9588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105479, RefRangeEnd = 105480, XrefRangeStart = 105465, XrefRangeEnd = 105479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnCollisionEnter_Protected_Virtual_New_Void_Collision_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000EB3D8 File Offset: 0x000E95D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105494, RefRangeEnd = 105495, XrefRangeStart = 105480, XrefRangeEnd = 105494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerEnter(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x000EB428 File Offset: 0x000E9628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105495, XrefRangeEnd = 105509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCollisionExit(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnCollisionExit_Protected_Virtual_New_Void_Collision_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x000EB478 File Offset: 0x000E9678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105509, XrefRangeEnd = 105523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerExit(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x000EB4C8 File Offset: 0x000E96C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105523, XrefRangeEnd = 105534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDescendantLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_GetDescendantLevel_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x000EB504 File Offset: 0x000E9704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105534, XrefRangeEnd = 105575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_OnMouseDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x000EB538 File Offset: 0x000E9738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105575, XrefRangeEnd = 105583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_OnMouseEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x000EB56C File Offset: 0x000E976C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105583, XrefRangeEnd = 105591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_OnMouseExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x000EB5A0 File Offset: 0x000E97A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105591, XrefRangeEnd = 105611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdClicked(NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_CmdClicked_Private_Void_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x000EB5E4 File Offset: 0x000E97E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 105625, RefRangeEnd = 105630, XrefRangeStart = 105611, XrefRangeEnd = 105625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_Clone_Public_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x000EB624 File Offset: 0x000E9824
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 105632, RefRangeEnd = 105643, XrefRangeStart = 105630, XrefRangeEnd = 105632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_New_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x000EB674 File Offset: 0x000E9874
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_PostClone_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x000EB6B0 File Offset: 0x000E98B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105676, RefRangeEnd = 105677, XrefRangeStart = 105643, XrefRangeEnd = 105676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetBounds(BoundsCalculationMethod calculationMethod = BoundsCalculationMethod.Renderer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calculationMethod);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_GetBounds_Public_Bounds_BoundsCalculationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Bounds>(intPtr3) : null;
			}
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x000EB700 File Offset: 0x000E9900
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x000EB748 File Offset: 0x000E9948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105677, XrefRangeEnd = 105690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetParent__Transform(Transform par)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(par);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_UserCode_RpcSetParent__Transform_Protected_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x000EB78C File Offset: 0x000E998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105690, XrefRangeEnd = 105712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetParent__Transform(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_InvokeUserCode_RpcSetParent__Transform_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x000EB7E8 File Offset: 0x000E99E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105712, XrefRangeEnd = 105714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetName__String(string n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_UserCode_RpcSetName__String_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x000EB82C File Offset: 0x000E9A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105714, XrefRangeEnd = 105729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetName__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_InvokeUserCode_RpcSetName__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x000EB888 File Offset: 0x000E9A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105729, XrefRangeEnd = 105753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RequestParent__NetworkConnectionToClient(NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_UserCode_RequestParent__NetworkConnectionToClient_Protected_Void_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x000EB8CC File Offset: 0x000E9ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105753, XrefRangeEnd = 105793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RequestParent__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_InvokeUserCode_RequestParent__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x000EB928 File Offset: 0x000E9B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105793, XrefRangeEnd = 105809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32(NetworkConnection target, Transform par, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(par);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_UserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32_Protected_Void_NetworkConnection_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x000EB98C File Offset: 0x000E9B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105809, XrefRangeEnd = 105835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_InvokeUserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x000EB9E8 File Offset: 0x000E9BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105835, XrefRangeEnd = 105844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdClicked__NetworkConnectionToClient(NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_UserCode_CmdClicked__NetworkConnectionToClient_Protected_Void_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x000EBA2C File Offset: 0x000E9C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105844, XrefRangeEnd = 105864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdClicked__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instance.NativeMethodInfoPtr_InvokeUserCode_CmdClicked__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x000EBA88 File Offset: 0x000E9C88
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 105867, RefRangeEnd = 105882, XrefRangeStart = 105864, XrefRangeEnd = 105867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x000EBAE4 File Offset: 0x000E9CE4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 105888, RefRangeEnd = 105910, XrefRangeStart = 105882, XrefRangeEnd = 105888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instance.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x000143E8 File Offset: 0x000125E8
		public Instance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06003380 RID: 13184 RVA: 0x000EBB40 File Offset: 0x000E9D40
		// (set) Token: 0x06003381 RID: 13185 RVA: 0x000143F1 File Offset: 0x000125F1
		public unsafe Transform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06003382 RID: 13186 RVA: 0x000EBB70 File Offset: 0x000E9D70
		// (set) Token: 0x06003383 RID: 13187 RVA: 0x00014410 File Offset: 0x00012610
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x000EBB98 File Offset: 0x000E9D98
		// (set) Token: 0x06003385 RID: 13189 RVA: 0x0001442F File Offset: 0x0001262F
		public unsafe string className
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_className);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_className), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x000EBBC0 File Offset: 0x000E9DC0
		// (set) Token: 0x06003387 RID: 13191 RVA: 0x0001444E File Offset: 0x0001264E
		public unsafe bool canReparent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_canReparent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_canReparent)) = value;
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x000EBBE8 File Offset: 0x000E9DE8
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x00014469 File Offset: 0x00012669
		public unsafe bool hidesMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_hidesMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_hidesMembers)) = value;
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x000EBC10 File Offset: 0x000E9E10
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x00014484 File Offset: 0x00012684
		public unsafe bool clientSpawned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_clientSpawned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_clientSpawned)) = value;
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x000EBC38 File Offset: 0x000E9E38
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x0001449F File Offset: 0x0001269F
		public unsafe DynValue shared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_shared);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_shared), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x000EBC68 File Offset: 0x000E9E68
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x000144BE File Offset: 0x000126BE
		public unsafe LuaEvent ChildRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_ChildRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_ChildRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x000EBC98 File Offset: 0x000E9E98
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x000144DD File Offset: 0x000126DD
		public unsafe LuaEvent ChildAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_ChildAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_ChildAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x000EBCC8 File Offset: 0x000E9EC8
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x000144FC File Offset: 0x000126FC
		public unsafe LuaEvent Touched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_Touched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_Touched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x000EBCF8 File Offset: 0x000E9EF8
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x0001451B File Offset: 0x0001271B
		public unsafe LuaEvent TouchEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_TouchEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_TouchEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x000EBD28 File Offset: 0x000E9F28
		// (set) Token: 0x06003397 RID: 13207 RVA: 0x0001453A File Offset: 0x0001273A
		public unsafe LuaEvent MouseHover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_MouseHover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_MouseHover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06003398 RID: 13208 RVA: 0x000EBD58 File Offset: 0x000E9F58
		// (set) Token: 0x06003399 RID: 13209 RVA: 0x00014559 File Offset: 0x00012759
		public unsafe LuaEvent MouseHoverEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_MouseHoverEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_MouseHoverEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x0600339A RID: 13210 RVA: 0x000EBD88 File Offset: 0x000E9F88
		// (set) Token: 0x0600339B RID: 13211 RVA: 0x00014578 File Offset: 0x00012778
		public unsafe LuaEvent Clicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_Clicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_Clicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x000EBDB8 File Offset: 0x000E9FB8
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x00014597 File Offset: 0x00012797
		public unsafe LuaEvent MouseEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_MouseEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_MouseEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x000EBDE8 File Offset: 0x000E9FE8
		// (set) Token: 0x0600339F RID: 13215 RVA: 0x000145B6 File Offset: 0x000127B6
		public unsafe LuaEvent MouseExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_MouseExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_MouseExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x000EBE18 File Offset: 0x000EA018
		// (set) Token: 0x060033A1 RID: 13217 RVA: 0x000145D5 File Offset: 0x000127D5
		public unsafe Action<Instance> _DescendantAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__DescendantAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Instance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__DescendantAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x000EBE48 File Offset: 0x000EA048
		// (set) Token: 0x060033A3 RID: 13219 RVA: 0x000145F4 File Offset: 0x000127F4
		public unsafe Action _ParentChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__ParentChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__ParentChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x000EBE78 File Offset: 0x000EA078
		// (set) Token: 0x060033A5 RID: 13221 RVA: 0x00014613 File Offset: 0x00012813
		public unsafe Action<Instance> _Touched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__Touched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Instance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr__Touched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060033A6 RID: 13222 RVA: 0x000EBEA8 File Offset: 0x000EA0A8
		// (set) Token: 0x060033A7 RID: 13223 RVA: 0x00014632 File Offset: 0x00012832
		public unsafe bool isHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_isHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_isHidden)) = value;
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060033A8 RID: 13224 RVA: 0x000EBED0 File Offset: 0x000EA0D0
		// (set) Token: 0x060033A9 RID: 13225 RVA: 0x0001464D File Offset: 0x0001284D
		public unsafe bool isMouseOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_isMouseOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Instance.NativeFieldInfoPtr_isMouseOver)) = value;
			}
		}

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeFieldInfoPtr_className;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeFieldInfoPtr_canReparent;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeFieldInfoPtr_hidesMembers;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeFieldInfoPtr_clientSpawned;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeFieldInfoPtr_shared;

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeFieldInfoPtr_ChildRemoved;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeFieldInfoPtr_ChildAdded;

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeFieldInfoPtr_Touched;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeFieldInfoPtr_TouchEnded;

		// Token: 0x0400275E RID: 10078
		private static readonly IntPtr NativeFieldInfoPtr_MouseHover;

		// Token: 0x0400275F RID: 10079
		private static readonly IntPtr NativeFieldInfoPtr_MouseHoverEnded;

		// Token: 0x04002760 RID: 10080
		private static readonly IntPtr NativeFieldInfoPtr_Clicked;

		// Token: 0x04002761 RID: 10081
		private static readonly IntPtr NativeFieldInfoPtr_MouseEnter;

		// Token: 0x04002762 RID: 10082
		private static readonly IntPtr NativeFieldInfoPtr_MouseExit;

		// Token: 0x04002763 RID: 10083
		private static readonly IntPtr NativeFieldInfoPtr__DescendantAdded;

		// Token: 0x04002764 RID: 10084
		private static readonly IntPtr NativeFieldInfoPtr__ParentChanged;

		// Token: 0x04002765 RID: 10085
		private static readonly IntPtr NativeFieldInfoPtr__Touched;

		// Token: 0x04002766 RID: 10086
		private static readonly IntPtr NativeFieldInfoPtr_isHidden;

		// Token: 0x04002767 RID: 10087
		private static readonly IntPtr NativeFieldInfoPtr_isMouseOver;

		// Token: 0x04002768 RID: 10088
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientSpawned_Public_get_Boolean_0;

		// Token: 0x04002769 RID: 10089
		private static readonly IntPtr NativeMethodInfoPtr_get_CanReparent_Public_get_Boolean_0;

		// Token: 0x0400276A RID: 10090
		private static readonly IntPtr NativeMethodInfoPtr_get_DescendantLevel_Public_get_Int32_0;

		// Token: 0x0400276B RID: 10091
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Instance_String_0;

		// Token: 0x0400276C RID: 10092
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Instance_Int32_0;

		// Token: 0x0400276D RID: 10093
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400276E RID: 10094
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x0400276F RID: 10095
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_get_String_0;

		// Token: 0x04002770 RID: 10096
		private static readonly IntPtr NativeMethodInfoPtr_get_ClassName_Public_get_String_0;

		// Token: 0x04002771 RID: 10097
		private static readonly IntPtr NativeMethodInfoPtr_get_Shared_Public_get_DynValue_0;

		// Token: 0x04002772 RID: 10098
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_Instance_0;

		// Token: 0x04002773 RID: 10099
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Public_set_Void_Instance_0;

		// Token: 0x04002774 RID: 10100
		private static readonly IntPtr NativeMethodInfoPtr_get_Network_name_Public_get_String_0;

		// Token: 0x04002775 RID: 10101
		private static readonly IntPtr NativeMethodInfoPtr_set_Network_name_Public_set_Void_String_0;

		// Token: 0x04002776 RID: 10102
		private static readonly IntPtr NativeMethodInfoPtr_add__DescendantAdded_Public_add_Void_Action_1_Instance_0;

		// Token: 0x04002777 RID: 10103
		private static readonly IntPtr NativeMethodInfoPtr_remove__DescendantAdded_Public_rem_Void_Action_1_Instance_0;

		// Token: 0x04002778 RID: 10104
		private static readonly IntPtr NativeMethodInfoPtr_add__ParentChanged_Public_add_Void_Action_0;

		// Token: 0x04002779 RID: 10105
		private static readonly IntPtr NativeMethodInfoPtr_remove__ParentChanged_Public_rem_Void_Action_0;

		// Token: 0x0400277A RID: 10106
		private static readonly IntPtr NativeMethodInfoPtr_add__Touched_Public_add_Void_Action_1_Instance_0;

		// Token: 0x0400277B RID: 10107
		private static readonly IntPtr NativeMethodInfoPtr_remove__Touched_Public_rem_Void_Action_1_Instance_0;

		// Token: 0x0400277C RID: 10108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400277D RID: 10109
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Instance_0;

		// Token: 0x0400277E RID: 10110
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Instance_0;

		// Token: 0x0400277F RID: 10111
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_New_Void_0;

		// Token: 0x04002780 RID: 10112
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_New_Void_0;

		// Token: 0x04002781 RID: 10113
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetParent_Private_Void_Transform_0;

		// Token: 0x04002782 RID: 10114
		private static readonly IntPtr NativeMethodInfoPtr_FindChild_Public_Instance_String_0;

		// Token: 0x04002783 RID: 10115
		private static readonly IntPtr NativeMethodInfoPtr_GetChildren_Public_Il2CppReferenceArray_1_Instance_0;

		// Token: 0x04002784 RID: 10116
		private static readonly IntPtr NativeMethodInfoPtr_GetChildrenOfClass_Public_Il2CppReferenceArray_1_Instance_String_0;

		// Token: 0x04002785 RID: 10117
		private static readonly IntPtr NativeMethodInfoPtr_GetChildrenOfType_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04002786 RID: 10118
		private static readonly IntPtr NativeMethodInfoPtr_FindChildOfType_Public_T_0;

		// Token: 0x04002787 RID: 10119
		private static readonly IntPtr NativeMethodInfoPtr_FindChildByClass_Public_Instance_String_0;

		// Token: 0x04002788 RID: 10120
		private static readonly IntPtr NativeMethodInfoPtr_IsA_Public_Boolean_String_0;

		// Token: 0x04002789 RID: 10121
		private static readonly IntPtr NativeMethodInfoPtr_IsDescendantOf_Public_Boolean_Instance_0;

		// Token: 0x0400278A RID: 10122
		private static readonly IntPtr NativeMethodInfoPtr_IsDescendantOfType_Public_Boolean_0;

		// Token: 0x0400278B RID: 10123
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_Single_0;

		// Token: 0x0400278C RID: 10124
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_Single_0;

		// Token: 0x0400278D RID: 10125
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetName_Private_Void_String_0;

		// Token: 0x0400278E RID: 10126
		private static readonly IntPtr NativeMethodInfoPtr_RequestParent_Private_Void_NetworkConnectionToClient_0;

		// Token: 0x0400278F RID: 10127
		private static readonly IntPtr NativeMethodInfoPtr_SetParentTargetRpc_Private_Void_NetworkConnection_Transform_Int32_0;

		// Token: 0x04002790 RID: 10128
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04002791 RID: 10129
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002792 RID: 10130
		private static readonly IntPtr NativeMethodInfoPtr_OnNetworkStart_Protected_Virtual_New_Void_0;

		// Token: 0x04002793 RID: 10131
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04002794 RID: 10132
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04002795 RID: 10133
		private static readonly IntPtr NativeMethodInfoPtr_OnGameLoaded_Private_Void_0;

		// Token: 0x04002796 RID: 10134
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04002797 RID: 10135
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Instance_String_Instance_0;

		// Token: 0x04002798 RID: 10136
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Protected_Virtual_New_Void_Collision_0;

		// Token: 0x04002799 RID: 10137
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x0400279A RID: 10138
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionExit_Protected_Virtual_New_Void_Collision_0;

		// Token: 0x0400279B RID: 10139
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x0400279C RID: 10140
		private static readonly IntPtr NativeMethodInfoPtr_GetDescendantLevel_Private_Int32_0;

		// Token: 0x0400279D RID: 10141
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDown_Private_Void_0;

		// Token: 0x0400279E RID: 10142
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseEnter_Private_Void_0;

		// Token: 0x0400279F RID: 10143
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseExit_Private_Void_0;

		// Token: 0x040027A0 RID: 10144
		private static readonly IntPtr NativeMethodInfoPtr_CmdClicked_Private_Void_NetworkConnectionToClient_0;

		// Token: 0x040027A1 RID: 10145
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Instance_0;

		// Token: 0x040027A2 RID: 10146
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_New_Void_Instance_0;

		// Token: 0x040027A3 RID: 10147
		private static readonly IntPtr NativeMethodInfoPtr_PostClone_Protected_Virtual_New_Void_0;

		// Token: 0x040027A4 RID: 10148
		private static readonly IntPtr NativeMethodInfoPtr_GetBounds_Public_Bounds_BoundsCalculationMethod_0;

		// Token: 0x040027A5 RID: 10149
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040027A6 RID: 10150
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetParent__Transform_Protected_Void_Transform_0;

		// Token: 0x040027A7 RID: 10151
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetParent__Transform_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040027A8 RID: 10152
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetName__String_Protected_Void_String_0;

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetName__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040027AA RID: 10154
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RequestParent__NetworkConnectionToClient_Protected_Void_NetworkConnectionToClient_0;

		// Token: 0x040027AB RID: 10155
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RequestParent__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040027AC RID: 10156
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32_Protected_Void_NetworkConnection_Transform_Int32_0;

		// Token: 0x040027AD RID: 10157
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040027AE RID: 10158
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdClicked__NetworkConnectionToClient_Protected_Void_NetworkConnectionToClient_0;

		// Token: 0x040027AF RID: 10159
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdClicked__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040027B0 RID: 10160
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040027B1 RID: 10161
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;

		// Token: 0x020003F3 RID: 1011
		private sealed class MethodInfoStoreGeneric_GetChildrenOfType_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04003C85 RID: 15493
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Instance.NativeMethodInfoPtr_GetChildrenOfType_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Instance>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003F4 RID: 1012
		private sealed class MethodInfoStoreGeneric_FindChildOfType_Public_T_0<T>
		{
			// Token: 0x04003C86 RID: 15494
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Instance.NativeMethodInfoPtr_FindChildOfType_Public_T_0, Il2CppClassPointerStore<Instance>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020003F5 RID: 1013
		private sealed class MethodInfoStoreGeneric_IsDescendantOfType_Public_Boolean_0<T>
		{
			// Token: 0x04003C87 RID: 15495
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Instance.NativeMethodInfoPtr_IsDescendantOfType_Public_Boolean_0, Il2CppClassPointerStore<Instance>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
