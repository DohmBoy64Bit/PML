using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Mirror;
using MoonSharp.Interpreter;
using Unity.AI.Navigation;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000279 RID: 633
	public class Environment : Instance
	{
		// Token: 0x060031B1 RID: 12721 RVA: 0x000E3B64 File Offset: 0x000E1D64
		// Note: this type is marked as 'beforefieldinit'.
		static Environment()
		{
			Il2CppClassPointerStore<Environment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Environment");
			Environment.NativeFieldInfoPtr_skybox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "skybox");
			Environment.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "gravity");
			Environment.NativeFieldInfoPtr_fogEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "fogEnabled");
			Environment.NativeFieldInfoPtr_fogStartDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "fogStartDistance");
			Environment.NativeFieldInfoPtr_fogEndDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "fogEndDistance");
			Environment.NativeFieldInfoPtr_fogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "fogColor");
			Environment.NativeFieldInfoPtr_partDestroyHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "partDestroyHeight");
			Environment.NativeFieldInfoPtr_autoGenerateNavMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "autoGenerateNavMesh");
			Environment.NativeFieldInfoPtr_surface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "surface");
			Environment.NativeFieldInfoPtr_explosionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "explosionPrefab");
			Environment.NativeMethodInfoPtr_get_Skybox_Public_get_SkyboxPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670762);
			Environment.NativeMethodInfoPtr_set_Skybox_Public_set_Void_SkyboxPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670763);
			Environment.NativeMethodInfoPtr_get_Gravity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670764);
			Environment.NativeMethodInfoPtr_set_Gravity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670765);
			Environment.NativeMethodInfoPtr_get_FogEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670766);
			Environment.NativeMethodInfoPtr_set_FogEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670767);
			Environment.NativeMethodInfoPtr_get_FogStartDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670768);
			Environment.NativeMethodInfoPtr_set_FogStartDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670769);
			Environment.NativeMethodInfoPtr_get_FogEndDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670770);
			Environment.NativeMethodInfoPtr_set_FogEndDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670771);
			Environment.NativeMethodInfoPtr_get_FogColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670772);
			Environment.NativeMethodInfoPtr_set_FogColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670773);
			Environment.NativeMethodInfoPtr_get_PartDestroyHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670774);
			Environment.NativeMethodInfoPtr_set_PartDestroyHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670775);
			Environment.NativeMethodInfoPtr_get_AutoGenerateNavMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670776);
			Environment.NativeMethodInfoPtr_set_AutoGenerateNavMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670777);
			Environment.NativeMethodInfoPtr_get_Networkskybox_Public_get_SkyboxPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670799);
			Environment.NativeMethodInfoPtr_set_Networkskybox_Public_set_Void_SkyboxPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670800);
			Environment.NativeMethodInfoPtr_get_Networkgravity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670801);
			Environment.NativeMethodInfoPtr_set_Networkgravity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670802);
			Environment.NativeMethodInfoPtr_get_NetworkfogEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670803);
			Environment.NativeMethodInfoPtr_set_NetworkfogEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670804);
			Environment.NativeMethodInfoPtr_get_NetworkfogStartDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670805);
			Environment.NativeMethodInfoPtr_set_NetworkfogStartDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670806);
			Environment.NativeMethodInfoPtr_get_NetworkfogEndDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670807);
			Environment.NativeMethodInfoPtr_set_NetworkfogEndDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670808);
			Environment.NativeMethodInfoPtr_get_NetworkfogColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670809);
			Environment.NativeMethodInfoPtr_set_NetworkfogColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670810);
			Environment.NativeMethodInfoPtr_get_NetworkpartDestroyHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670811);
			Environment.NativeMethodInfoPtr_set_NetworkpartDestroyHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670812);
			Environment.NativeMethodInfoPtr_get_NetworkautoGenerateNavMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670813);
			Environment.NativeMethodInfoPtr_set_NetworkautoGenerateNavMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670814);
			Environment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670797);
			Environment.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670778);
			Environment.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_Single_Single_Boolean_DynValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670779);
			Environment.NativeMethodInfoPtr_ExplosionForce_Private_IEnumerator_Collider_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670780);
			Environment.NativeMethodInfoPtr_Raycast_Public_Nullable_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670781);
			Environment.NativeMethodInfoPtr_RaycastAll_Public_Il2CppReferenceArray_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670782);
			Environment.NativeMethodInfoPtr_OverlapSphere_Public_Il2CppReferenceArray_1_Instance_Vector3_Single_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670783);
			Environment.NativeMethodInfoPtr_OverlapBox_Public_Il2CppReferenceArray_1_Instance_Vector3_Vector3_Vector3_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670784);
			Environment.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670785);
			Environment.NativeMethodInfoPtr_RebuildNavMesh_Public_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670786);
			Environment.NativeMethodInfoPtr_GetPointOnNavMesh_Public_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670787);
			Environment.NativeMethodInfoPtr_RpcSetSkybox_Private_Void_SkyboxPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670788);
			Environment.NativeMethodInfoPtr_RpcExplode_Private_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670789);
			Environment.NativeMethodInfoPtr_AddPlrExplosionForce_Private_Void_Player_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670790);
			Environment.NativeMethodInfoPtr_ApplyForceTargetRpc_Private_Void_NetworkConnection_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670791);
			Environment.NativeMethodInfoPtr_RpcSetGravity_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670792);
			Environment.NativeMethodInfoPtr_RpcSetFogEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670793);
			Environment.NativeMethodInfoPtr_RpcSetFogStartDistance_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670794);
			Environment.NativeMethodInfoPtr_RpcSetFogEndDistance_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670795);
			Environment.NativeMethodInfoPtr_RpcSetFogColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670796);
			Environment.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670798);
			Environment.NativeMethodInfoPtr_UserCode_RpcSetSkybox__SkyboxPreset_Protected_Void_SkyboxPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670815);
			Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetSkybox__SkyboxPreset_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670816);
			Environment.NativeMethodInfoPtr_UserCode_RpcExplode__Vector3__Single_Protected_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670817);
			Environment.NativeMethodInfoPtr_InvokeUserCode_RpcExplode__Vector3__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670818);
			Environment.NativeMethodInfoPtr_UserCode_ApplyForceTargetRpc__NetworkConnection__Vector3_Protected_Void_NetworkConnection_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670819);
			Environment.NativeMethodInfoPtr_InvokeUserCode_ApplyForceTargetRpc__NetworkConnection__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670820);
			Environment.NativeMethodInfoPtr_UserCode_RpcSetGravity__Vector3_Protected_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670821);
			Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetGravity__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670822);
			Environment.NativeMethodInfoPtr_UserCode_RpcSetFogEnabled__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670823);
			Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetFogEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670824);
			Environment.NativeMethodInfoPtr_UserCode_RpcSetFogStartDistance__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670825);
			Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetFogStartDistance__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670826);
			Environment.NativeMethodInfoPtr_UserCode_RpcSetFogEndDistance__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670827);
			Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetFogEndDistance__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670828);
			Environment.NativeMethodInfoPtr_UserCode_RpcSetFogColor__Color_Protected_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670829);
			Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetFogColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670830);
			Environment.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670832);
			Environment.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100670833);
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x000E41E0 File Offset: 0x000E23E0
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x000E4220 File Offset: 0x000E2420
		public unsafe SkyboxPreset Skybox
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Skybox_Public_get_SkyboxPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyboxPreset>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 102315, RefRangeEnd = 102320, XrefRangeStart = 102272, XrefRangeEnd = 102315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_Skybox_Public_set_Void_SkyboxPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x000E4264 File Offset: 0x000E2464
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x000E42A4 File Offset: 0x000E24A4
		public unsafe Vector3 Gravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Gravity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 102341, RefRangeEnd = 102345, XrefRangeStart = 102320, XrefRangeEnd = 102341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_Gravity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x000E42E8 File Offset: 0x000E24E8
		// (set) Token: 0x060031B7 RID: 12727 RVA: 0x000E4324 File Offset: 0x000E2524
		public unsafe bool FogEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_FogEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 102372, RefRangeEnd = 102376, XrefRangeStart = 102345, XrefRangeEnd = 102372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_FogEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x000E4364 File Offset: 0x000E2564
		// (set) Token: 0x060031B9 RID: 12729 RVA: 0x000E43A0 File Offset: 0x000E25A0
		public unsafe float FogStartDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_FogStartDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 102399, RefRangeEnd = 102403, XrefRangeStart = 102376, XrefRangeEnd = 102399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_FogStartDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x000E43E0 File Offset: 0x000E25E0
		// (set) Token: 0x060031BB RID: 12731 RVA: 0x000E441C File Offset: 0x000E261C
		public unsafe float FogEndDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_FogEndDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 102426, RefRangeEnd = 102430, XrefRangeStart = 102403, XrefRangeEnd = 102426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_FogEndDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x000E445C File Offset: 0x000E265C
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x000E449C File Offset: 0x000E269C
		public unsafe Color FogColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_FogColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 102453, RefRangeEnd = 102457, XrefRangeStart = 102430, XrefRangeEnd = 102453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_FogColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x000E44E0 File Offset: 0x000E26E0
		// (set) Token: 0x060031BF RID: 12735 RVA: 0x000E451C File Offset: 0x000E271C
		public unsafe float PartDestroyHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_PartDestroyHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 102463, RefRangeEnd = 102464, XrefRangeStart = 102457, XrefRangeEnd = 102463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_PartDestroyHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x060031C0 RID: 12736 RVA: 0x000E455C File Offset: 0x000E275C
		// (set) Token: 0x060031C1 RID: 12737 RVA: 0x000E4598 File Offset: 0x000E2798
		public unsafe bool AutoGenerateNavMesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_AutoGenerateNavMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 102470, RefRangeEnd = 102471, XrefRangeStart = 102464, XrefRangeEnd = 102470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_AutoGenerateNavMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x000E45D8 File Offset: 0x000E27D8
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x000E4618 File Offset: 0x000E2818
		public unsafe SkyboxPreset Networkskybox
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Networkskybox_Public_get_SkyboxPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyboxPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102471, XrefRangeEnd = 102477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_Networkskybox_Public_set_Void_SkyboxPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x000E465C File Offset: 0x000E285C
		// (set) Token: 0x060031C5 RID: 12741 RVA: 0x000E469C File Offset: 0x000E289C
		public unsafe Vector3 Networkgravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Networkgravity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 102483, RefRangeEnd = 102485, XrefRangeStart = 102477, XrefRangeEnd = 102483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_Networkgravity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x000E46E0 File Offset: 0x000E28E0
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x000E471C File Offset: 0x000E291C
		public unsafe bool NetworkfogEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_NetworkfogEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102485, XrefRangeEnd = 102491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_NetworkfogEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x000E475C File Offset: 0x000E295C
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x000E4798 File Offset: 0x000E2998
		public unsafe float NetworkfogStartDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_NetworkfogStartDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102491, XrefRangeEnd = 102497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_NetworkfogStartDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x000E47D8 File Offset: 0x000E29D8
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x000E4814 File Offset: 0x000E2A14
		public unsafe float NetworkfogEndDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_NetworkfogEndDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102497, XrefRangeEnd = 102503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_NetworkfogEndDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x000E4854 File Offset: 0x000E2A54
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x000E4894 File Offset: 0x000E2A94
		public unsafe Color NetworkfogColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_NetworkfogColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102503, XrefRangeEnd = 102509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_NetworkfogColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x000E48D8 File Offset: 0x000E2AD8
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x000E4914 File Offset: 0x000E2B14
		public unsafe float NetworkpartDestroyHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_NetworkpartDestroyHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 102463, RefRangeEnd = 102464, XrefRangeStart = 102463, XrefRangeEnd = 102464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_NetworkpartDestroyHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x000E4954 File Offset: 0x000E2B54
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x000E4990 File Offset: 0x000E2B90
		public unsafe bool NetworkautoGenerateNavMesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_NetworkautoGenerateNavMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 102470, RefRangeEnd = 102471, XrefRangeStart = 102470, XrefRangeEnd = 102471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_set_NetworkautoGenerateNavMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x000E49D0 File Offset: 0x000E2BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102509, XrefRangeEnd = 102513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Environment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Environment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x000E4A0C File Offset: 0x000E2C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102513, XrefRangeEnd = 102523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Environment.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x000E4A48 File Offset: 0x000E2C48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102586, RefRangeEnd = 102587, XrefRangeStart = 102523, XrefRangeEnd = 102586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 position, float radius = 10f, float force = 5000f, bool affectKinematic = true, DynValue callback = null, float damage = 100000f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref affectKinematic;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_Single_Single_Boolean_DynValue_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000E4AD8 File Offset: 0x000E2CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102592, RefRangeEnd = 102593, XrefRangeStart = 102587, XrefRangeEnd = 102592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExplosionForce(Collider col, Vector3 position, float radius, float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_ExplosionForce_Private_IEnumerator_Collider_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000E4B58 File Offset: 0x000E2D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102638, RefRangeEnd = 102639, XrefRangeStart = 102593, XrefRangeEnd = 102638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<RayResult> Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, List<Instance> ignoreList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(origin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_Raycast_Public_Nullable_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Nullable<RayResult>>(intPtr3) : null;
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x000E4BDC File Offset: 0x000E2DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102688, RefRangeEnd = 102689, XrefRangeStart = 102639, XrefRangeEnd = 102688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RayResult> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, List<Instance> ignoreList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(origin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_RaycastAll_Public_Il2CppReferenceArray_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RayResult>>(intPtr3) : null;
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x000E4C60 File Offset: 0x000E2E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102733, RefRangeEnd = 102734, XrefRangeStart = 102689, XrefRangeEnd = 102733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Instance> OverlapSphere(Vector3 position, float radius, List<Instance> ignoreList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_OverlapSphere_Public_Il2CppReferenceArray_1_Instance_Vector3_Single_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instance>>(intPtr3) : null;
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000E4CD0 File Offset: 0x000E2ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102779, RefRangeEnd = 102780, XrefRangeStart = 102734, XrefRangeEnd = 102779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Instance> OverlapBox(Vector3 center, Vector3 size, Vector3 rotation, List<Instance> ignoreList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(center);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_OverlapBox_Public_Il2CppReferenceArray_1_Instance_Vector3_Vector3_Vector3_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instance>>(intPtr3) : null;
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000E4D58 File Offset: 0x000E2F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102780, XrefRangeEnd = 102828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Environment.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000E4D94 File Offset: 0x000E2F94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102860, RefRangeEnd = 102862, XrefRangeStart = 102828, XrefRangeEnd = 102860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildNavMesh(Instance root = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_RebuildNavMesh_Public_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000E4DD8 File Offset: 0x000E2FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102864, RefRangeEnd = 102865, XrefRangeStart = 102862, XrefRangeEnd = 102864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPointOnNavMesh(Vector3 position, float maxDistance = 100f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetPointOnNavMesh_Public_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x000E4E38 File Offset: 0x000E3038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102865, XrefRangeEnd = 102886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetSkybox(SkyboxPreset sky)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sky);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_RpcSetSkybox_Private_Void_SkyboxPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000E4E7C File Offset: 0x000E307C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102886, XrefRangeEnd = 102908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcExplode(Vector3 position, float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_RpcExplode_Private_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x000E4ECC File Offset: 0x000E30CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102938, RefRangeEnd = 102939, XrefRangeStart = 102908, XrefRangeEnd = 102938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlrExplosionForce(Player player, Vector3 position, float radius, float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_AddPlrExplosionForce_Private_Void_Player_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x000E4F3C File Offset: 0x000E313C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102939, XrefRangeEnd = 102960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyForceTargetRpc(NetworkConnection target, Vector3 force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(force);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_ApplyForceTargetRpc_Private_Void_NetworkConnection_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x000E4F90 File Offset: 0x000E3190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102960, XrefRangeEnd = 102981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetGravity(Vector3 g)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_RpcSetGravity_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x000E4FD4 File Offset: 0x000E31D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102981, XrefRangeEnd = 103002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetFogEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_RpcSetFogEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x000E5014 File Offset: 0x000E3214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103002, XrefRangeEnd = 103023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetFogStartDistance(float dist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dist;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_RpcSetFogStartDistance_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x000E5054 File Offset: 0x000E3254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103023, XrefRangeEnd = 103044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetFogEndDistance(float dist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dist;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_RpcSetFogEndDistance_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x000E5094 File Offset: 0x000E3294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103044, XrefRangeEnd = 103065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetFogColor(Color c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_RpcSetFogColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x000E50D8 File Offset: 0x000E32D8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Environment.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x000E5120 File Offset: 0x000E3320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103065, XrefRangeEnd = 103067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetSkybox__SkyboxPreset(SkyboxPreset sky)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sky);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UserCode_RpcSetSkybox__SkyboxPreset_Protected_Void_SkyboxPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000E5164 File Offset: 0x000E3364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103067, XrefRangeEnd = 103082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetSkybox__SkyboxPreset(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetSkybox__SkyboxPreset_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000E51C0 File Offset: 0x000E33C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103115, RefRangeEnd = 103116, XrefRangeStart = 103082, XrefRangeEnd = 103115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcExplode__Vector3__Single(Vector3 position, float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UserCode_RpcExplode__Vector3__Single_Protected_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x000E5210 File Offset: 0x000E3410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103116, XrefRangeEnd = 103127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcExplode__Vector3__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InvokeUserCode_RpcExplode__Vector3__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x000E526C File Offset: 0x000E346C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103127, XrefRangeEnd = 103150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_ApplyForceTargetRpc__NetworkConnection__Vector3(NetworkConnection target, Vector3 force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(force);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UserCode_ApplyForceTargetRpc__NetworkConnection__Vector3_Protected_Void_NetworkConnection_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x000E52C0 File Offset: 0x000E34C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103150, XrefRangeEnd = 103182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_ApplyForceTargetRpc__NetworkConnection__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InvokeUserCode_ApplyForceTargetRpc__NetworkConnection__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x000E531C File Offset: 0x000E351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103182, XrefRangeEnd = 103184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetGravity__Vector3(Vector3 g)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UserCode_RpcSetGravity__Vector3_Protected_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x000E5360 File Offset: 0x000E3560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103184, XrefRangeEnd = 103195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetGravity__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetGravity__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x000E53BC File Offset: 0x000E35BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103195, XrefRangeEnd = 103197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetFogEnabled__Boolean(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UserCode_RpcSetFogEnabled__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x000E53FC File Offset: 0x000E35FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103197, XrefRangeEnd = 103212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetFogEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetFogEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x000E5458 File Offset: 0x000E3658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103212, XrefRangeEnd = 103214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetFogStartDistance__Single(float dist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dist;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UserCode_RpcSetFogStartDistance__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x000E5498 File Offset: 0x000E3698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103214, XrefRangeEnd = 103225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetFogStartDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetFogStartDistance__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000E54F4 File Offset: 0x000E36F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103225, XrefRangeEnd = 103227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetFogEndDistance__Single(float dist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dist;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UserCode_RpcSetFogEndDistance__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x000E5534 File Offset: 0x000E3734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103227, XrefRangeEnd = 103238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetFogEndDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetFogEndDistance__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x000E5590 File Offset: 0x000E3790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103238, XrefRangeEnd = 103240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetFogColor__Color(Color c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UserCode_RpcSetFogColor__Color_Protected_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x000E55D4 File Offset: 0x000E37D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103240, XrefRangeEnd = 103251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetFogColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InvokeUserCode_RpcSetFogColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x000E5630 File Offset: 0x000E3830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103251, XrefRangeEnd = 103272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Environment.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x000E568C File Offset: 0x000E388C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103272, XrefRangeEnd = 103325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Environment.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00013C4E File Offset: 0x00011E4E
		public Environment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x000E56E8 File Offset: 0x000E38E8
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x00013C57 File Offset: 0x00011E57
		public unsafe SkyboxPreset skybox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_skybox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyboxPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_skybox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x000E5718 File Offset: 0x000E3918
		// (set) Token: 0x060031FD RID: 12797 RVA: 0x00013C76 File Offset: 0x00011E76
		public unsafe Vector3 gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_gravity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_gravity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x000E5748 File Offset: 0x000E3948
		// (set) Token: 0x060031FF RID: 12799 RVA: 0x00013C95 File Offset: 0x00011E95
		public unsafe bool fogEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_fogEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_fogEnabled)) = value;
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x000E5770 File Offset: 0x000E3970
		// (set) Token: 0x06003201 RID: 12801 RVA: 0x00013CB0 File Offset: 0x00011EB0
		public unsafe float fogStartDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_fogStartDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_fogStartDistance)) = value;
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06003202 RID: 12802 RVA: 0x000E5798 File Offset: 0x000E3998
		// (set) Token: 0x06003203 RID: 12803 RVA: 0x00013CCB File Offset: 0x00011ECB
		public unsafe float fogEndDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_fogEndDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_fogEndDistance)) = value;
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06003204 RID: 12804 RVA: 0x000E57C0 File Offset: 0x000E39C0
		// (set) Token: 0x06003205 RID: 12805 RVA: 0x00013CE6 File Offset: 0x00011EE6
		public unsafe Color fogColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_fogColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_fogColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x000E57F0 File Offset: 0x000E39F0
		// (set) Token: 0x06003207 RID: 12807 RVA: 0x00013D05 File Offset: 0x00011F05
		public unsafe float partDestroyHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_partDestroyHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_partDestroyHeight)) = value;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x000E5818 File Offset: 0x000E3A18
		// (set) Token: 0x06003209 RID: 12809 RVA: 0x00013D20 File Offset: 0x00011F20
		public unsafe bool autoGenerateNavMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_autoGenerateNavMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_autoGenerateNavMesh)) = value;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x000E5840 File Offset: 0x000E3A40
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x00013D3B File Offset: 0x00011F3B
		public unsafe NavMeshSurface surface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_surface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshSurface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_surface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x000E5870 File Offset: 0x000E3A70
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x00013D5A File Offset: 0x00011F5A
		public unsafe GameObject explosionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_explosionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment.NativeFieldInfoPtr_explosionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400260E RID: 9742
		private static readonly IntPtr NativeFieldInfoPtr_skybox;

		// Token: 0x0400260F RID: 9743
		private static readonly IntPtr NativeFieldInfoPtr_gravity;

		// Token: 0x04002610 RID: 9744
		private static readonly IntPtr NativeFieldInfoPtr_fogEnabled;

		// Token: 0x04002611 RID: 9745
		private static readonly IntPtr NativeFieldInfoPtr_fogStartDistance;

		// Token: 0x04002612 RID: 9746
		private static readonly IntPtr NativeFieldInfoPtr_fogEndDistance;

		// Token: 0x04002613 RID: 9747
		private static readonly IntPtr NativeFieldInfoPtr_fogColor;

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeFieldInfoPtr_partDestroyHeight;

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeFieldInfoPtr_autoGenerateNavMesh;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeFieldInfoPtr_surface;

		// Token: 0x04002617 RID: 9751
		private static readonly IntPtr NativeFieldInfoPtr_explosionPrefab;

		// Token: 0x04002618 RID: 9752
		private static readonly IntPtr NativeMethodInfoPtr_get_Skybox_Public_get_SkyboxPreset_0;

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeMethodInfoPtr_set_Skybox_Public_set_Void_SkyboxPreset_0;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeMethodInfoPtr_get_Gravity_Public_get_Vector3_0;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeMethodInfoPtr_set_Gravity_Public_set_Void_Vector3_0;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeMethodInfoPtr_get_FogEnabled_Public_get_Boolean_0;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeMethodInfoPtr_set_FogEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeMethodInfoPtr_get_FogStartDistance_Public_get_Single_0;

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeMethodInfoPtr_set_FogStartDistance_Public_set_Void_Single_0;

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeMethodInfoPtr_get_FogEndDistance_Public_get_Single_0;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeMethodInfoPtr_set_FogEndDistance_Public_set_Void_Single_0;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeMethodInfoPtr_get_FogColor_Public_get_Color_0;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeMethodInfoPtr_set_FogColor_Public_set_Void_Color_0;

		// Token: 0x04002624 RID: 9764
		private static readonly IntPtr NativeMethodInfoPtr_get_PartDestroyHeight_Public_get_Single_0;

		// Token: 0x04002625 RID: 9765
		private static readonly IntPtr NativeMethodInfoPtr_set_PartDestroyHeight_Public_set_Void_Single_0;

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoGenerateNavMesh_Public_get_Boolean_0;

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoGenerateNavMesh_Public_set_Void_Boolean_0;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkskybox_Public_get_SkyboxPreset_0;

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkskybox_Public_set_Void_SkyboxPreset_0;

		// Token: 0x0400262A RID: 9770
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkgravity_Public_get_Vector3_0;

		// Token: 0x0400262B RID: 9771
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkgravity_Public_set_Void_Vector3_0;

		// Token: 0x0400262C RID: 9772
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfogEnabled_Public_get_Boolean_0;

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfogEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfogStartDistance_Public_get_Single_0;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfogStartDistance_Public_set_Void_Single_0;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfogEndDistance_Public_get_Single_0;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfogEndDistance_Public_set_Void_Single_0;

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfogColor_Public_get_Color_0;

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfogColor_Public_set_Void_Color_0;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpartDestroyHeight_Public_get_Single_0;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpartDestroyHeight_Public_set_Void_Single_0;

		// Token: 0x04002636 RID: 9782
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkautoGenerateNavMesh_Public_get_Boolean_0;

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkautoGenerateNavMesh_Public_set_Void_Boolean_0;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002639 RID: 9785
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400263A RID: 9786
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_Single_Single_Boolean_DynValue_Single_0;

		// Token: 0x0400263B RID: 9787
		private static readonly IntPtr NativeMethodInfoPtr_ExplosionForce_Private_IEnumerator_Collider_Vector3_Single_Single_0;

		// Token: 0x0400263C RID: 9788
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Nullable_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0;

		// Token: 0x0400263D RID: 9789
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Il2CppReferenceArray_1_RayResult_Vector3_Vector3_Single_List_1_Instance_0;

		// Token: 0x0400263E RID: 9790
		private static readonly IntPtr NativeMethodInfoPtr_OverlapSphere_Public_Il2CppReferenceArray_1_Instance_Vector3_Single_List_1_Instance_0;

		// Token: 0x0400263F RID: 9791
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Public_Il2CppReferenceArray_1_Instance_Vector3_Vector3_Vector3_List_1_Instance_0;

		// Token: 0x04002640 RID: 9792
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002641 RID: 9793
		private static readonly IntPtr NativeMethodInfoPtr_RebuildNavMesh_Public_Void_Instance_0;

		// Token: 0x04002642 RID: 9794
		private static readonly IntPtr NativeMethodInfoPtr_GetPointOnNavMesh_Public_Vector3_Vector3_Single_0;

		// Token: 0x04002643 RID: 9795
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetSkybox_Private_Void_SkyboxPreset_0;

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeMethodInfoPtr_RpcExplode_Private_Void_Vector3_Single_0;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeMethodInfoPtr_AddPlrExplosionForce_Private_Void_Player_Vector3_Single_Single_0;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeMethodInfoPtr_ApplyForceTargetRpc_Private_Void_NetworkConnection_Vector3_0;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetGravity_Private_Void_Vector3_0;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetFogEnabled_Private_Void_Boolean_0;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetFogStartDistance_Private_Void_Single_0;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetFogEndDistance_Private_Void_Single_0;

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetFogColor_Private_Void_Color_0;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetSkybox__SkyboxPreset_Protected_Void_SkyboxPreset_0;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetSkybox__SkyboxPreset_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcExplode__Vector3__Single_Protected_Void_Vector3_Single_0;

		// Token: 0x04002650 RID: 9808
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcExplode__Vector3__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002651 RID: 9809
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_ApplyForceTargetRpc__NetworkConnection__Vector3_Protected_Void_NetworkConnection_Vector3_0;

		// Token: 0x04002652 RID: 9810
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_ApplyForceTargetRpc__NetworkConnection__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002653 RID: 9811
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetGravity__Vector3_Protected_Void_Vector3_0;

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetGravity__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetFogEnabled__Boolean_Protected_Void_Boolean_0;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetFogEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetFogStartDistance__Single_Protected_Void_Single_0;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetFogStartDistance__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetFogEndDistance__Single_Protected_Void_Single_0;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetFogEndDistance__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetFogColor__Color_Protected_Void_Color_0;

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetFogColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x0400265D RID: 9821
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x0400265E RID: 9822
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;

		// Token: 0x020003EE RID: 1006
		[ObfuscatedName("Polytoria.Datamodel.Environment+<ExplosionForce>d__36")]
		public sealed class _ExplosionForce_d__36 : global::Il2CppSystem.Object
		{
			// Token: 0x06004DC7 RID: 19911 RVA: 0x0015149C File Offset: 0x0014F69C
			// Note: this type is marked as 'beforefieldinit'.
			static _ExplosionForce_d__36()
			{
				Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Environment>.NativeClassPtr, "<ExplosionForce>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr);
				Environment._ExplosionForce_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, "<>1__state");
				Environment._ExplosionForce_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, "<>2__current");
				Environment._ExplosionForce_d__36.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, "col");
				Environment._ExplosionForce_d__36.NativeFieldInfoPtr_force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, "force");
				Environment._ExplosionForce_d__36.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, "position");
				Environment._ExplosionForce_d__36.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, "radius");
				Environment._ExplosionForce_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, 100670837);
				Environment._ExplosionForce_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, 100670839);
				Environment._ExplosionForce_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, 100670834);
				Environment._ExplosionForce_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, 100670835);
				Environment._ExplosionForce_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, 100670836);
				Environment._ExplosionForce_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr, 100670838);
			}

			// Token: 0x17001A38 RID: 6712
			// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x001515B8 File Offset: 0x0014F7B8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment._ExplosionForce_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A39 RID: 6713
			// (get) Token: 0x06004DC9 RID: 19913 RVA: 0x001515F8 File Offset: 0x0014F7F8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment._ExplosionForce_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DCA RID: 19914 RVA: 0x00151638 File Offset: 0x0014F838
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExplosionForce_d__36(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Environment._ExplosionForce_d__36>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment._ExplosionForce_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DCB RID: 19915 RVA: 0x00151680 File Offset: 0x0014F880
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment._ExplosionForce_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DCC RID: 19916 RVA: 0x001516B4 File Offset: 0x0014F8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102260, XrefRangeEnd = 102267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment._ExplosionForce_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004DCD RID: 19917 RVA: 0x001516F0 File Offset: 0x0014F8F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102267, XrefRangeEnd = 102272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment._ExplosionForce_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DCE RID: 19918 RVA: 0x0001D6D7 File Offset: 0x0001B8D7
			public _ExplosionForce_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A32 RID: 6706
			// (get) Token: 0x06004DCF RID: 19919 RVA: 0x00151724 File Offset: 0x0014F924
			// (set) Token: 0x06004DD0 RID: 19920 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A33 RID: 6707
			// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x0015174C File Offset: 0x0014F94C
			// (set) Token: 0x06004DD2 RID: 19922 RVA: 0x0001D6FB File Offset: 0x0001B8FB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A34 RID: 6708
			// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x0015177C File Offset: 0x0014F97C
			// (set) Token: 0x06004DD4 RID: 19924 RVA: 0x0001D71A File Offset: 0x0001B91A
			public unsafe Collider col
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr_col);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A35 RID: 6709
			// (get) Token: 0x06004DD5 RID: 19925 RVA: 0x001517AC File Offset: 0x0014F9AC
			// (set) Token: 0x06004DD6 RID: 19926 RVA: 0x0001D739 File Offset: 0x0001B939
			public unsafe float force
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr_force);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr_force)) = value;
				}
			}

			// Token: 0x17001A36 RID: 6710
			// (get) Token: 0x06004DD7 RID: 19927 RVA: 0x001517D4 File Offset: 0x0014F9D4
			// (set) Token: 0x06004DD8 RID: 19928 RVA: 0x0001D754 File Offset: 0x0001B954
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr_position);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr_position), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A37 RID: 6711
			// (get) Token: 0x06004DD9 RID: 19929 RVA: 0x00151804 File Offset: 0x0014FA04
			// (set) Token: 0x06004DDA RID: 19930 RVA: 0x0001D773 File Offset: 0x0001B973
			public unsafe float radius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr_radius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Environment._ExplosionForce_d__36.NativeFieldInfoPtr_radius)) = value;
				}
			}

			// Token: 0x04003C50 RID: 15440
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C51 RID: 15441
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C52 RID: 15442
			private static readonly IntPtr NativeFieldInfoPtr_col;

			// Token: 0x04003C53 RID: 15443
			private static readonly IntPtr NativeFieldInfoPtr_force;

			// Token: 0x04003C54 RID: 15444
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04003C55 RID: 15445
			private static readonly IntPtr NativeFieldInfoPtr_radius;

			// Token: 0x04003C56 RID: 15446
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C57 RID: 15447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C58 RID: 15448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C59 RID: 15449
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C5A RID: 15450
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C5B RID: 15451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
