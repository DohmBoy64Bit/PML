using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Mirror;
using Polytoria.Lua;
using UnityEngine;
using UnityEngine.Animations;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B1 RID: 689
	public class Tool : DynamicInstance
	{
		// Token: 0x06003B65 RID: 15205 RVA: 0x0010C8DC File Offset: 0x0010AADC
		// Note: this type is marked as 'beforefieldinit'.
		static Tool()
		{
			Il2CppClassPointerStore<Tool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Tool");
			Tool.NativeFieldInfoPtr__renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "_renderer");
			Tool.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "col");
			Tool.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "rb");
			Tool.NativeFieldInfoPtr_parentConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "parentConstraint");
			Tool.NativeFieldInfoPtr_Activated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "Activated");
			Tool.NativeFieldInfoPtr_Deactivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "Deactivated");
			Tool.NativeFieldInfoPtr_Equipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "Equipped");
			Tool.NativeFieldInfoPtr_Unequipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "Unequipped");
			Tool.NativeFieldInfoPtr_pickupCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "pickupCooldown");
			Tool.NativeFieldInfoPtr_droppable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tool>.NativeClassPtr, "droppable");
			Tool.NativeMethodInfoPtr_get_Droppable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672442);
			Tool.NativeMethodInfoPtr_set_Droppable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672443);
			Tool.NativeMethodInfoPtr_get_DoTransformSync_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672444);
			Tool.NativeMethodInfoPtr_get_Networkdroppable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672479);
			Tool.NativeMethodInfoPtr_set_Networkdroppable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672480);
			Tool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672477);
			Tool.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672445);
			Tool.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672446);
			Tool.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672447);
			Tool.NativeMethodInfoPtr_OnParentChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672448);
			Tool.NativeMethodInfoPtr_FixChildTransforms_Private_Void_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672449);
			Tool.NativeMethodInfoPtr_RpcUpdateChildTransform_Private_Void_DynamicInstance_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672450);
			Tool.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672451);
			Tool.NativeMethodInfoPtr_OnTouched_Private_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672452);
			Tool.NativeMethodInfoPtr_CollectTool_Private_Void_IToolHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672453);
			Tool.NativeMethodInfoPtr_RpcLinkTool_Private_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672454);
			Tool.NativeMethodInfoPtr_DoLinkTool_Private_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672455);
			Tool.NativeMethodInfoPtr_OnDescendantAdded_Private_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672456);
			Tool.NativeMethodInfoPtr_RecalculateBounds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672457);
			Tool.NativeMethodInfoPtr_InvokeActivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672458);
			Tool.NativeMethodInfoPtr_CmdActivate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672459);
			Tool.NativeMethodInfoPtr_DoActivate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672460);
			Tool.NativeMethodInfoPtr_RpcActivate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672461);
			Tool.NativeMethodInfoPtr_InvokeDeactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672462);
			Tool.NativeMethodInfoPtr_CmdDeactivate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672463);
			Tool.NativeMethodInfoPtr_DoDeactivate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672464);
			Tool.NativeMethodInfoPtr_RpcDeactivate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672465);
			Tool.NativeMethodInfoPtr_InvokeEquip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672466);
			Tool.NativeMethodInfoPtr_CmdEquip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672467);
			Tool.NativeMethodInfoPtr_DoEquip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672468);
			Tool.NativeMethodInfoPtr_RpcEquip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672469);
			Tool.NativeMethodInfoPtr_InvokeUnequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672470);
			Tool.NativeMethodInfoPtr_CmdUnequip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672471);
			Tool.NativeMethodInfoPtr_DoUnequip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672472);
			Tool.NativeMethodInfoPtr_RpcUnequip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672473);
			Tool.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672474);
			Tool.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672475);
			Tool.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672476);
			Tool.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672478);
			Tool.NativeMethodInfoPtr_UserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3_Protected_Void_DynamicInstance_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672481);
			Tool.NativeMethodInfoPtr_InvokeUserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672482);
			Tool.NativeMethodInfoPtr_UserCode_RpcLinkTool__Instance_Protected_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672483);
			Tool.NativeMethodInfoPtr_InvokeUserCode_RpcLinkTool__Instance_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672484);
			Tool.NativeMethodInfoPtr_UserCode_CmdActivate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672485);
			Tool.NativeMethodInfoPtr_InvokeUserCode_CmdActivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672486);
			Tool.NativeMethodInfoPtr_UserCode_RpcActivate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672487);
			Tool.NativeMethodInfoPtr_InvokeUserCode_RpcActivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672488);
			Tool.NativeMethodInfoPtr_UserCode_CmdDeactivate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672489);
			Tool.NativeMethodInfoPtr_InvokeUserCode_CmdDeactivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672490);
			Tool.NativeMethodInfoPtr_UserCode_RpcDeactivate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672491);
			Tool.NativeMethodInfoPtr_InvokeUserCode_RpcDeactivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672492);
			Tool.NativeMethodInfoPtr_UserCode_CmdEquip_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672493);
			Tool.NativeMethodInfoPtr_InvokeUserCode_CmdEquip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672494);
			Tool.NativeMethodInfoPtr_UserCode_RpcEquip_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672495);
			Tool.NativeMethodInfoPtr_InvokeUserCode_RpcEquip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672496);
			Tool.NativeMethodInfoPtr_UserCode_CmdUnequip_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672497);
			Tool.NativeMethodInfoPtr_InvokeUserCode_CmdUnequip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672498);
			Tool.NativeMethodInfoPtr_UserCode_RpcUnequip_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672499);
			Tool.NativeMethodInfoPtr_InvokeUserCode_RpcUnequip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672500);
			Tool.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672502);
			Tool.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tool>.NativeClassPtr, 100672503);
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x0010CE90 File Offset: 0x0010B090
		// (set) Token: 0x06003B67 RID: 15207 RVA: 0x0010CECC File Offset: 0x0010B0CC
		public unsafe bool Droppable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_get_Droppable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 120273, RefRangeEnd = 120274, XrefRangeStart = 120267, XrefRangeEnd = 120273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_set_Droppable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x0010CF0C File Offset: 0x0010B10C
		public unsafe override bool DoTransformSync
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120274, XrefRangeEnd = 120278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_get_DoTransformSync_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06003B69 RID: 15209 RVA: 0x0010CF54 File Offset: 0x0010B154
		// (set) Token: 0x06003B6A RID: 15210 RVA: 0x0010CF90 File Offset: 0x0010B190
		public unsafe bool Networkdroppable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_get_Networkdroppable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 120273, RefRangeEnd = 120274, XrefRangeStart = 120273, XrefRangeEnd = 120274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_set_Networkdroppable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x0010CFD0 File Offset: 0x0010B1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120278, XrefRangeEnd = 120299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x0010D00C File Offset: 0x0010B20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120299, XrefRangeEnd = 120340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x0010D048 File Offset: 0x0010B248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120340, XrefRangeEnd = 120349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x0010D084 File Offset: 0x0010B284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120356, RefRangeEnd = 120357, XrefRangeStart = 120349, XrefRangeEnd = 120356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x0010D0C8 File Offset: 0x0010B2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120357, XrefRangeEnd = 120377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParentChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_OnParentChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x0010D0FC File Offset: 0x0010B2FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120406, RefRangeEnd = 120408, XrefRangeStart = 120377, XrefRangeEnd = 120406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixChildTransforms(DynamicInstance i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_FixChildTransforms_Private_Void_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x0010D140 File Offset: 0x0010B340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120408, XrefRangeEnd = 120432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcUpdateChildTransform(DynamicInstance i, Vector3 pos, Quaternion rot, Vector3 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rot);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_RpcUpdateChildTransform_Private_Void_DynamicInstance_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x0010D1BC File Offset: 0x0010B3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120432, XrefRangeEnd = 120434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x0010D1F8 File Offset: 0x0010B3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120434, XrefRangeEnd = 120439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTouched(Instance obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_OnTouched_Private_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x0010D23C File Offset: 0x0010B43C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120465, RefRangeEnd = 120466, XrefRangeStart = 120439, XrefRangeEnd = 120465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollectTool(IToolHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_CollectTool_Private_Void_IToolHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x0010D280 File Offset: 0x0010B480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120466, XrefRangeEnd = 120487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLinkTool(Instance par)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(par);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_RpcLinkTool_Private_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x0010D2C4 File Offset: 0x0010B4C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120583, RefRangeEnd = 120586, XrefRangeStart = 120487, XrefRangeEnd = 120583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoLinkTool(Instance par)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(par);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_DoLinkTool_Private_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x0010D308 File Offset: 0x0010B508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120608, RefRangeEnd = 120610, XrefRangeStart = 120586, XrefRangeEnd = 120608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDescendantAdded(Instance obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_OnDescendantAdded_Private_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x0010D34C File Offset: 0x0010B54C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120625, RefRangeEnd = 120626, XrefRangeStart = 120610, XrefRangeEnd = 120625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_RecalculateBounds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x0010D380 File Offset: 0x0010B580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120626, XrefRangeEnd = 120648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeActivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x0010D3B4 File Offset: 0x0010B5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120648, XrefRangeEnd = 120668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_CmdActivate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x0010D3E8 File Offset: 0x0010B5E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 120687, RefRangeEnd = 120692, XrefRangeStart = 120668, XrefRangeEnd = 120687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_DoActivate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x0010D41C File Offset: 0x0010B61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120692, XrefRangeEnd = 120712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_RpcActivate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x0010D450 File Offset: 0x0010B650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120712, XrefRangeEnd = 120734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeDeactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x0010D484 File Offset: 0x0010B684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120734, XrefRangeEnd = 120754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_CmdDeactivate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x0010D4B8 File Offset: 0x0010B6B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 120773, RefRangeEnd = 120778, XrefRangeStart = 120754, XrefRangeEnd = 120773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_DoDeactivate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x0010D4EC File Offset: 0x0010B6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120778, XrefRangeEnd = 120798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_RpcDeactivate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x0010D520 File Offset: 0x0010B720
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120820, RefRangeEnd = 120823, XrefRangeStart = 120798, XrefRangeEnd = 120820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeEquip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeEquip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x0010D554 File Offset: 0x0010B754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120823, XrefRangeEnd = 120843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdEquip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_CmdEquip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x0010D588 File Offset: 0x0010B788
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 120862, RefRangeEnd = 120867, XrefRangeStart = 120843, XrefRangeEnd = 120862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoEquip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_DoEquip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x0010D5BC File Offset: 0x0010B7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120867, XrefRangeEnd = 120887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcEquip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_RpcEquip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x0010D5F0 File Offset: 0x0010B7F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120909, RefRangeEnd = 120912, XrefRangeStart = 120887, XrefRangeEnd = 120909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeUnequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUnequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x0010D624 File Offset: 0x0010B824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120912, XrefRangeEnd = 120932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdUnequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_CmdUnequip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x0010D658 File Offset: 0x0010B858
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 120951, RefRangeEnd = 120956, XrefRangeStart = 120932, XrefRangeEnd = 120951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoUnequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_DoUnequip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x0010D68C File Offset: 0x0010B88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120956, XrefRangeEnd = 120976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcUnequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_RpcUnequip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x0010D6C0 File Offset: 0x0010B8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120976, XrefRangeEnd = 120985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x0010D710 File Offset: 0x0010B910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120985, XrefRangeEnd = 120995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x0010D74C File Offset: 0x0010B94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120995, XrefRangeEnd = 121012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x0010D788 File Offset: 0x0010B988
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x0010D7D0 File Offset: 0x0010B9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121012, XrefRangeEnd = 121018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3(DynamicInstance i, Vector3 pos, Quaternion rot, Vector3 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rot);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3_Protected_Void_DynamicInstance_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x0010D84C File Offset: 0x0010BA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121018, XrefRangeEnd = 121038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x0010D8A8 File Offset: 0x0010BAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121038, XrefRangeEnd = 121039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcLinkTool__Instance(Instance par)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(par);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_RpcLinkTool__Instance_Protected_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x0010D8EC File Offset: 0x0010BAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121039, XrefRangeEnd = 121057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcLinkTool__Instance(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_RpcLinkTool__Instance_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x0010D948 File Offset: 0x0010BB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121057, XrefRangeEnd = 121058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_CmdActivate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x0010D97C File Offset: 0x0010BB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121058, XrefRangeEnd = 121076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdActivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_CmdActivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x0010D9D8 File Offset: 0x0010BBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121076, XrefRangeEnd = 121078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_RpcActivate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x0010DA0C File Offset: 0x0010BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121078, XrefRangeEnd = 121092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcActivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_RpcActivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x0010DA68 File Offset: 0x0010BC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121092, XrefRangeEnd = 121093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_CmdDeactivate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x0010DA9C File Offset: 0x0010BC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121093, XrefRangeEnd = 121111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdDeactivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_CmdDeactivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x0010DAF8 File Offset: 0x0010BCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121111, XrefRangeEnd = 121113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_RpcDeactivate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x0010DB2C File Offset: 0x0010BD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121113, XrefRangeEnd = 121127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcDeactivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_RpcDeactivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x0010DB88 File Offset: 0x0010BD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121127, XrefRangeEnd = 121128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdEquip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_CmdEquip_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x0010DBBC File Offset: 0x0010BDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121128, XrefRangeEnd = 121146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdEquip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_CmdEquip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x0010DC18 File Offset: 0x0010BE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121146, XrefRangeEnd = 121148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcEquip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_RpcEquip_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x0010DC4C File Offset: 0x0010BE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121148, XrefRangeEnd = 121162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcEquip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_RpcEquip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x0010DCA8 File Offset: 0x0010BEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121162, XrefRangeEnd = 121163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdUnequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_CmdUnequip_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x0010DCDC File Offset: 0x0010BEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121163, XrefRangeEnd = 121181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdUnequip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_CmdUnequip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x0010DD38 File Offset: 0x0010BF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121181, XrefRangeEnd = 121183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcUnequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_UserCode_RpcUnequip_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x0010DD6C File Offset: 0x0010BF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121183, XrefRangeEnd = 121197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcUnequip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tool.NativeMethodInfoPtr_InvokeUserCode_RpcUnequip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x0010DDC8 File Offset: 0x0010BFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121197, XrefRangeEnd = 121200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x0010DE24 File Offset: 0x0010C024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121200, XrefRangeEnd = 121206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tool.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x00016D1E File Offset: 0x00014F1E
		public Tool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x0010DE80 File Offset: 0x0010C080
		// (set) Token: 0x06003BA5 RID: 15269 RVA: 0x00016D27 File Offset: 0x00014F27
		public unsafe Renderer _renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr__renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr__renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x0010DEB0 File Offset: 0x0010C0B0
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x00016D46 File Offset: 0x00014F46
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x0010DEE0 File Offset: 0x0010C0E0
		// (set) Token: 0x06003BA9 RID: 15273 RVA: 0x00016D65 File Offset: 0x00014F65
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x0010DF10 File Offset: 0x0010C110
		// (set) Token: 0x06003BAB RID: 15275 RVA: 0x00016D84 File Offset: 0x00014F84
		public unsafe ParentConstraint parentConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_parentConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParentConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_parentConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x0010DF40 File Offset: 0x0010C140
		// (set) Token: 0x06003BAD RID: 15277 RVA: 0x00016DA3 File Offset: 0x00014FA3
		public unsafe LuaEvent Activated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_Activated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_Activated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x0010DF70 File Offset: 0x0010C170
		// (set) Token: 0x06003BAF RID: 15279 RVA: 0x00016DC2 File Offset: 0x00014FC2
		public unsafe LuaEvent Deactivated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_Deactivated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_Deactivated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x0010DFA0 File Offset: 0x0010C1A0
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x00016DE1 File Offset: 0x00014FE1
		public unsafe LuaEvent Equipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_Equipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_Equipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x0010DFD0 File Offset: 0x0010C1D0
		// (set) Token: 0x06003BB3 RID: 15283 RVA: 0x00016E00 File Offset: 0x00015000
		public unsafe LuaEvent Unequipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_Unequipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_Unequipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x0010E000 File Offset: 0x0010C200
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x00016E1F File Offset: 0x0001501F
		public unsafe float pickupCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_pickupCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_pickupCooldown)) = value;
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x0010E028 File Offset: 0x0010C228
		// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x00016E3A File Offset: 0x0001503A
		public unsafe bool droppable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_droppable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tool.NativeFieldInfoPtr_droppable)) = value;
			}
		}

		// Token: 0x04002E22 RID: 11810
		private static readonly IntPtr NativeFieldInfoPtr__renderer;

		// Token: 0x04002E23 RID: 11811
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04002E24 RID: 11812
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04002E25 RID: 11813
		private static readonly IntPtr NativeFieldInfoPtr_parentConstraint;

		// Token: 0x04002E26 RID: 11814
		private static readonly IntPtr NativeFieldInfoPtr_Activated;

		// Token: 0x04002E27 RID: 11815
		private static readonly IntPtr NativeFieldInfoPtr_Deactivated;

		// Token: 0x04002E28 RID: 11816
		private static readonly IntPtr NativeFieldInfoPtr_Equipped;

		// Token: 0x04002E29 RID: 11817
		private static readonly IntPtr NativeFieldInfoPtr_Unequipped;

		// Token: 0x04002E2A RID: 11818
		private static readonly IntPtr NativeFieldInfoPtr_pickupCooldown;

		// Token: 0x04002E2B RID: 11819
		private static readonly IntPtr NativeFieldInfoPtr_droppable;

		// Token: 0x04002E2C RID: 11820
		private static readonly IntPtr NativeMethodInfoPtr_get_Droppable_Public_get_Boolean_0;

		// Token: 0x04002E2D RID: 11821
		private static readonly IntPtr NativeMethodInfoPtr_set_Droppable_Public_set_Void_Boolean_0;

		// Token: 0x04002E2E RID: 11822
		private static readonly IntPtr NativeMethodInfoPtr_get_DoTransformSync_Protected_Virtual_get_Boolean_0;

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkdroppable_Public_get_Boolean_0;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkdroppable_Public_set_Void_Boolean_0;

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeMethodInfoPtr_OnParentChange_Private_Void_0;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeMethodInfoPtr_FixChildTransforms_Private_Void_DynamicInstance_0;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeMethodInfoPtr_RpcUpdateChildTransform_Private_Void_DynamicInstance_Vector3_Quaternion_Vector3_0;

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeMethodInfoPtr_OnTouched_Private_Void_Instance_0;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeMethodInfoPtr_CollectTool_Private_Void_IToolHolder_0;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeMethodInfoPtr_RpcLinkTool_Private_Void_Instance_0;

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeMethodInfoPtr_DoLinkTool_Private_Void_Instance_0;

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeMethodInfoPtr_OnDescendantAdded_Private_Void_Instance_0;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Private_Void_0;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeMethodInfoPtr_InvokeActivate_Public_Void_0;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeMethodInfoPtr_CmdActivate_Private_Void_0;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeMethodInfoPtr_DoActivate_Private_Void_0;

		// Token: 0x04002E42 RID: 11842
		private static readonly IntPtr NativeMethodInfoPtr_RpcActivate_Private_Void_0;

		// Token: 0x04002E43 RID: 11843
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDeactivate_Public_Void_0;

		// Token: 0x04002E44 RID: 11844
		private static readonly IntPtr NativeMethodInfoPtr_CmdDeactivate_Private_Void_0;

		// Token: 0x04002E45 RID: 11845
		private static readonly IntPtr NativeMethodInfoPtr_DoDeactivate_Private_Void_0;

		// Token: 0x04002E46 RID: 11846
		private static readonly IntPtr NativeMethodInfoPtr_RpcDeactivate_Private_Void_0;

		// Token: 0x04002E47 RID: 11847
		private static readonly IntPtr NativeMethodInfoPtr_InvokeEquip_Public_Void_0;

		// Token: 0x04002E48 RID: 11848
		private static readonly IntPtr NativeMethodInfoPtr_CmdEquip_Private_Void_0;

		// Token: 0x04002E49 RID: 11849
		private static readonly IntPtr NativeMethodInfoPtr_DoEquip_Private_Void_0;

		// Token: 0x04002E4A RID: 11850
		private static readonly IntPtr NativeMethodInfoPtr_RpcEquip_Private_Void_0;

		// Token: 0x04002E4B RID: 11851
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUnequip_Public_Void_0;

		// Token: 0x04002E4C RID: 11852
		private static readonly IntPtr NativeMethodInfoPtr_CmdUnequip_Private_Void_0;

		// Token: 0x04002E4D RID: 11853
		private static readonly IntPtr NativeMethodInfoPtr_DoUnequip_Private_Void_0;

		// Token: 0x04002E4E RID: 11854
		private static readonly IntPtr NativeMethodInfoPtr_RpcUnequip_Private_Void_0;

		// Token: 0x04002E4F RID: 11855
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002E50 RID: 11856
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002E51 RID: 11857
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002E52 RID: 11858
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002E53 RID: 11859
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3_Protected_Void_DynamicInstance_Vector3_Quaternion_Vector3_0;

		// Token: 0x04002E54 RID: 11860
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E55 RID: 11861
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcLinkTool__Instance_Protected_Void_Instance_0;

		// Token: 0x04002E56 RID: 11862
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcLinkTool__Instance_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E57 RID: 11863
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdActivate_Protected_Void_0;

		// Token: 0x04002E58 RID: 11864
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdActivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E59 RID: 11865
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcActivate_Protected_Void_0;

		// Token: 0x04002E5A RID: 11866
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcActivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E5B RID: 11867
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdDeactivate_Protected_Void_0;

		// Token: 0x04002E5C RID: 11868
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdDeactivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E5D RID: 11869
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcDeactivate_Protected_Void_0;

		// Token: 0x04002E5E RID: 11870
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcDeactivate_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E5F RID: 11871
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdEquip_Protected_Void_0;

		// Token: 0x04002E60 RID: 11872
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdEquip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E61 RID: 11873
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcEquip_Protected_Void_0;

		// Token: 0x04002E62 RID: 11874
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcEquip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E63 RID: 11875
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdUnequip_Protected_Void_0;

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdUnequip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcUnequip_Protected_Void_0;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcUnequip_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
