using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200028D RID: 653
	public class MeshPart : Part
	{
		// Token: 0x06003400 RID: 13312 RVA: 0x000ED4D0 File Offset: 0x000EB6D0
		// Note: this type is marked as 'beforefieldinit'.
		static MeshPart()
		{
			Il2CppClassPointerStore<MeshPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "MeshPart");
			MeshPart.NativeFieldInfoPtr_assetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, "assetID");
			MeshPart.NativeFieldInfoPtr_playAnimationOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, "playAnimationOnStart");
			MeshPart.NativeFieldInfoPtr_collisionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, "collisionType");
			MeshPart.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, "anim");
			MeshPart.NativeFieldInfoPtr_animationsByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, "animationsByName");
			MeshPart.NativeFieldInfoPtr_defaultBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, "defaultBounds");
			MeshPart.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_assetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_assetID");
			MeshPart.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_playAnimationOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_playAnimationOnStart");
			MeshPart.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_collisionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_collisionType");
			MeshPart.NativeMethodInfoPtr_get_AssetID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671154);
			MeshPart.NativeMethodInfoPtr_set_AssetID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671155);
			MeshPart.NativeMethodInfoPtr_get_CollisionType_Public_get_CollisionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671156);
			MeshPart.NativeMethodInfoPtr_set_CollisionType_Public_set_Void_CollisionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671157);
			MeshPart.NativeMethodInfoPtr_get_Shape_Public_get_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671158);
			MeshPart.NativeMethodInfoPtr_get_Material_Public_get_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671159);
			MeshPart.NativeMethodInfoPtr_get_CurrentAnimation_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671160);
			MeshPart.NativeMethodInfoPtr_get_IsAnimationPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671161);
			MeshPart.NativeMethodInfoPtr_get_PlayAnimationOnStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671162);
			MeshPart.NativeMethodInfoPtr_set_PlayAnimationOnStart_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671163);
			MeshPart.NativeMethodInfoPtr_get_CanCollide_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671164);
			MeshPart.NativeMethodInfoPtr_set_CanCollide_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671165);
			MeshPart.NativeMethodInfoPtr_get_NetworkassetID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671188);
			MeshPart.NativeMethodInfoPtr_set_NetworkassetID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671189);
			MeshPart.NativeMethodInfoPtr_get_NetworkplayAnimationOnStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671190);
			MeshPart.NativeMethodInfoPtr_set_NetworkplayAnimationOnStart_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671191);
			MeshPart.NativeMethodInfoPtr_get_NetworkcollisionType_Public_get_CollisionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671192);
			MeshPart.NativeMethodInfoPtr_set_NetworkcollisionType_Public_set_Void_CollisionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671193);
			MeshPart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671185);
			MeshPart.NativeMethodInfoPtr_UpdateColliders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671166);
			MeshPart.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671167);
			MeshPart.NativeMethodInfoPtr_LoadMesh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671168);
			MeshPart.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671169);
			MeshPart.NativeMethodInfoPtr_RefreshAnimationComponents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671170);
			MeshPart.NativeMethodInfoPtr_PlayAnimation_Public_Void_String_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671171);
			MeshPart.NativeMethodInfoPtr_StopAnimation_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671172);
			MeshPart.NativeMethodInfoPtr_StopAllAnimations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671173);
			MeshPart.NativeMethodInfoPtr_GetAnimations_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671174);
			MeshPart.NativeMethodInfoPtr_GetAnimationSources_Public_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671175);
			MeshPart.NativeMethodInfoPtr_GetAnimationInfo_Public_Il2CppReferenceArray_1_AnimationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671176);
			MeshPart.NativeMethodInfoPtr_GetRelativePath_Private_String_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671177);
			MeshPart.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671178);
			MeshPart.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671179);
			MeshPart.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671180);
			MeshPart.NativeMethodInfoPtr_RpcSetAssetID_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671181);
			MeshPart.NativeMethodInfoPtr_PlayAnimationOnStartChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671182);
			MeshPart.NativeMethodInfoPtr_CollisionTypeChanged_Private_Void_CollisionType_CollisionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671183);
			MeshPart.NativeMethodInfoPtr_AssetIDChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671184);
			MeshPart.NativeMethodInfoPtr__LoadMesh_b__28_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671186);
			MeshPart.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671187);
			MeshPart.NativeMethodInfoPtr_UserCode_RpcSetAssetID__Int32_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671194);
			MeshPart.NativeMethodInfoPtr_InvokeUserCode_RpcSetAssetID__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671195);
			MeshPart.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671197);
			MeshPart.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPart>.NativeClassPtr, 100671198);
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06003401 RID: 13313 RVA: 0x000ED91C File Offset: 0x000EBB1C
		// (set) Token: 0x06003402 RID: 13314 RVA: 0x000ED958 File Offset: 0x000EBB58
		public unsafe int AssetID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_AssetID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 106274, RefRangeEnd = 106279, XrefRangeStart = 106245, XrefRangeEnd = 106274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_set_AssetID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x000ED998 File Offset: 0x000EBB98
		// (set) Token: 0x06003404 RID: 13316 RVA: 0x000ED9D8 File Offset: 0x000EBBD8
		public unsafe CollisionType CollisionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_CollisionType_Public_get_CollisionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollisionType>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 106283, RefRangeEnd = 106285, XrefRangeStart = 106279, XrefRangeEnd = 106283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_set_CollisionType_Public_set_Void_CollisionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06003405 RID: 13317 RVA: 0x000EDA1C File Offset: 0x000EBC1C
		public new unsafe PartShape Shape
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_Shape_Public_get_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartShape>(intPtr3) : null;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x000EDA5C File Offset: 0x000EBC5C
		public new unsafe PartMaterial Material
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_Material_Public_get_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartMaterial>(intPtr3) : null;
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06003407 RID: 13319 RVA: 0x000EDA9C File Offset: 0x000EBC9C
		public unsafe string CurrentAnimation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106305, RefRangeEnd = 106306, XrefRangeStart = 106285, XrefRangeEnd = 106305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_CurrentAnimation_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06003408 RID: 13320 RVA: 0x000EDAD4 File Offset: 0x000EBCD4
		public unsafe bool IsAnimationPlaying
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 106320, RefRangeEnd = 106322, XrefRangeStart = 106306, XrefRangeEnd = 106320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_IsAnimationPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06003409 RID: 13321 RVA: 0x000EDB10 File Offset: 0x000EBD10
		// (set) Token: 0x0600340A RID: 13322 RVA: 0x000EDB4C File Offset: 0x000EBD4C
		public unsafe bool PlayAnimationOnStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_PlayAnimationOnStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 106339, RefRangeEnd = 106342, XrefRangeStart = 106322, XrefRangeEnd = 106339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_set_PlayAnimationOnStart_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x000EDB8C File Offset: 0x000EBD8C
		// (set) Token: 0x0600340C RID: 13324 RVA: 0x000EDBC8 File Offset: 0x000EBDC8
		public new unsafe bool CanCollide
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_CanCollide_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106342, XrefRangeEnd = 106349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_set_CanCollide_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x000EDC08 File Offset: 0x000EBE08
		// (set) Token: 0x0600340E RID: 13326 RVA: 0x000EDC44 File Offset: 0x000EBE44
		public unsafe int NetworkassetID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_NetworkassetID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106349, XrefRangeEnd = 106352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_set_NetworkassetID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x000EDC84 File Offset: 0x000EBE84
		// (set) Token: 0x06003410 RID: 13328 RVA: 0x000EDCC0 File Offset: 0x000EBEC0
		public unsafe bool NetworkplayAnimationOnStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_NetworkplayAnimationOnStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106352, XrefRangeEnd = 106355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_set_NetworkplayAnimationOnStart_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06003411 RID: 13329 RVA: 0x000EDD00 File Offset: 0x000EBF00
		// (set) Token: 0x06003412 RID: 13330 RVA: 0x000EDD40 File Offset: 0x000EBF40
		public unsafe CollisionType NetworkcollisionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_get_NetworkcollisionType_Public_get_CollisionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollisionType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106355, XrefRangeEnd = 106358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_set_NetworkcollisionType_Public_set_Void_CollisionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x000EDD84 File Offset: 0x000EBF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106358, XrefRangeEnd = 106390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshPart()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x000EDDC0 File Offset: 0x000EBFC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 106416, RefRangeEnd = 106419, XrefRangeStart = 106390, XrefRangeEnd = 106416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColliders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_UpdateColliders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x000EDDF4 File Offset: 0x000EBFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106419, XrefRangeEnd = 106424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshPart.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x000EDE30 File Offset: 0x000EC030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106424, XrefRangeEnd = 106434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_LoadMesh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x000EDE64 File Offset: 0x000EC064
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 106434, RefRangeEnd = 106439, XrefRangeStart = 106434, XrefRangeEnd = 106434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x000EDE98 File Offset: 0x000EC098
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 106517, RefRangeEnd = 106522, XrefRangeStart = 106439, XrefRangeEnd = 106517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshAnimationComponents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_RefreshAnimationComponents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x000EDECC File Offset: 0x000EC0CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106552, RefRangeEnd = 106554, XrefRangeStart = 106522, XrefRangeEnd = 106552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAnimation(string name, string objectPath = "", float speed = 1f, bool loop = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_PlayAnimation_Public_Void_String_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000EDF3C File Offset: 0x000EC13C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106577, RefRangeEnd = 106578, XrefRangeStart = 106554, XrefRangeEnd = 106577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAnimation(string name = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_StopAnimation_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000EDF80 File Offset: 0x000EC180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106633, RefRangeEnd = 106635, XrefRangeStart = 106578, XrefRangeEnd = 106633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_StopAllAnimations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000EDFB4 File Offset: 0x000EC1B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106642, RefRangeEnd = 106643, XrefRangeStart = 106635, XrefRangeEnd = 106642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_GetAnimations_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x000EDFF4 File Offset: 0x000EC1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106683, RefRangeEnd = 106684, XrefRangeStart = 106643, XrefRangeEnd = 106683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAnimationSources(string animationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_GetAnimationSources_Public_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000EE044 File Offset: 0x000EC244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106756, RefRangeEnd = 106757, XrefRangeStart = 106684, XrefRangeEnd = 106756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<AnimationInfo> GetAnimationInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_GetAnimationInfo_Public_Il2CppReferenceArray_1_AnimationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationInfo>>(intPtr3) : null;
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x000EE084 File Offset: 0x000EC284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106775, RefRangeEnd = 106777, XrefRangeStart = 106757, XrefRangeEnd = 106775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRelativePath(Transform root, Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_GetRelativePath_Private_String_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x000EE0E0 File Offset: 0x000EC2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106777, XrefRangeEnd = 106803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshPart.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x000EE11C File Offset: 0x000EC31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106803, XrefRangeEnd = 106826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshPart.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000EE158 File Offset: 0x000EC358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106826, XrefRangeEnd = 106837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshPart.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x000EE1A8 File Offset: 0x000EC3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106837, XrefRangeEnd = 106858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAssetID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_RpcSetAssetID_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x000EE1E8 File Offset: 0x000EC3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106858, XrefRangeEnd = 106860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAnimationOnStartChanged(bool oldValue, bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_PlayAnimationOnStartChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x000EE234 File Offset: 0x000EC434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106860, XrefRangeEnd = 106862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollisionTypeChanged(CollisionType oldValue, CollisionType newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_CollisionTypeChanged_Private_Void_CollisionType_CollisionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x000EE288 File Offset: 0x000EC488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106862, XrefRangeEnd = 106864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssetIDChanged(int oldValue, int newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_AssetIDChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x000EE2D4 File Offset: 0x000EC4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106864, XrefRangeEnd = 106865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _LoadMesh_b__28_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr__LoadMesh_b__28_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x000EE308 File Offset: 0x000EC508
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshPart.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000EE350 File Offset: 0x000EC550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106865, XrefRangeEnd = 106867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAssetID__Int32(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_UserCode_RpcSetAssetID__Int32_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000EE390 File Offset: 0x000EC590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106867, XrefRangeEnd = 106882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetAssetID__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPart.NativeMethodInfoPtr_InvokeUserCode_RpcSetAssetID__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x000EE3EC File Offset: 0x000EC5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106882, XrefRangeEnd = 106890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshPart.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x000EE448 File Offset: 0x000EC648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106890, XrefRangeEnd = 106911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshPart.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x0001484F File Offset: 0x00012A4F
		public MeshPart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x000EE4A4 File Offset: 0x000EC6A4
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x00014858 File Offset: 0x00012A58
		public unsafe int assetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_assetID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_assetID)) = value;
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x000EE4CC File Offset: 0x000EC6CC
		// (set) Token: 0x06003431 RID: 13361 RVA: 0x00014873 File Offset: 0x00012A73
		public unsafe bool playAnimationOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_playAnimationOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_playAnimationOnStart)) = value;
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06003432 RID: 13362 RVA: 0x000EE4F4 File Offset: 0x000EC6F4
		// (set) Token: 0x06003433 RID: 13363 RVA: 0x0001488E File Offset: 0x00012A8E
		public unsafe CollisionType collisionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_collisionType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollisionType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_collisionType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x000EE524 File Offset: 0x000EC724
		// (set) Token: 0x06003435 RID: 13365 RVA: 0x000148AD File Offset: 0x00012AAD
		public unsafe Animation anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x000EE554 File Offset: 0x000EC754
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x000148CC File Offset: 0x00012ACC
		public unsafe Dictionary<string, List<Animation>> animationsByName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_animationsByName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<Animation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_animationsByName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x000EE584 File Offset: 0x000EC784
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x000148EB File Offset: 0x00012AEB
		public unsafe Bounds defaultBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_defaultBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bounds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr_defaultBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x000EE5B4 File Offset: 0x000EC7B4
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x0001490A File Offset: 0x00012B0A
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_assetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_assetID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_assetID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x000EE5E4 File Offset: 0x000EC7E4
		// (set) Token: 0x0600343D RID: 13373 RVA: 0x00014929 File Offset: 0x00012B29
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_playAnimationOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_playAnimationOnStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_playAnimationOnStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x000EE614 File Offset: 0x000EC814
		// (set) Token: 0x0600343F RID: 13375 RVA: 0x00014948 File Offset: 0x00012B48
		public unsafe Action<CollisionType, CollisionType> _Mirror_SyncVarHookDelegate_collisionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_collisionType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CollisionType, CollisionType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPart.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_collisionType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027F6 RID: 10230
		private static readonly IntPtr NativeFieldInfoPtr_assetID;

		// Token: 0x040027F7 RID: 10231
		private static readonly IntPtr NativeFieldInfoPtr_playAnimationOnStart;

		// Token: 0x040027F8 RID: 10232
		private static readonly IntPtr NativeFieldInfoPtr_collisionType;

		// Token: 0x040027F9 RID: 10233
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040027FA RID: 10234
		private static readonly IntPtr NativeFieldInfoPtr_animationsByName;

		// Token: 0x040027FB RID: 10235
		private static readonly IntPtr NativeFieldInfoPtr_defaultBounds;

		// Token: 0x040027FC RID: 10236
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_assetID;

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_playAnimationOnStart;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_collisionType;

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetID_Public_get_Int32_0;

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeMethodInfoPtr_set_AssetID_Public_set_Void_Int32_0;

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeMethodInfoPtr_get_CollisionType_Public_get_CollisionType_0;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeMethodInfoPtr_set_CollisionType_Public_set_Void_CollisionType_0;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeMethodInfoPtr_get_Shape_Public_get_PartShape_0;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeMethodInfoPtr_get_Material_Public_get_PartMaterial_0;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAnimation_Public_get_String_0;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAnimationPlaying_Public_get_Boolean_0;

		// Token: 0x04002807 RID: 10247
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayAnimationOnStart_Public_get_Boolean_0;

		// Token: 0x04002808 RID: 10248
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayAnimationOnStart_Public_set_Void_Boolean_0;

		// Token: 0x04002809 RID: 10249
		private static readonly IntPtr NativeMethodInfoPtr_get_CanCollide_Public_get_Boolean_0;

		// Token: 0x0400280A RID: 10250
		private static readonly IntPtr NativeMethodInfoPtr_set_CanCollide_Public_set_Void_Boolean_0;

		// Token: 0x0400280B RID: 10251
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkassetID_Public_get_Int32_0;

		// Token: 0x0400280C RID: 10252
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkassetID_Public_set_Void_Int32_0;

		// Token: 0x0400280D RID: 10253
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkplayAnimationOnStart_Public_get_Boolean_0;

		// Token: 0x0400280E RID: 10254
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkplayAnimationOnStart_Public_set_Void_Boolean_0;

		// Token: 0x0400280F RID: 10255
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkcollisionType_Public_get_CollisionType_0;

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkcollisionType_Public_set_Void_CollisionType_0;

		// Token: 0x04002811 RID: 10257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002812 RID: 10258
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColliders_Public_Void_0;

		// Token: 0x04002813 RID: 10259
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002814 RID: 10260
		private static readonly IntPtr NativeMethodInfoPtr_LoadMesh_Private_Void_0;

		// Token: 0x04002815 RID: 10261
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04002816 RID: 10262
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAnimationComponents_Private_Void_0;

		// Token: 0x04002817 RID: 10263
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnimation_Public_Void_String_String_Single_Boolean_0;

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeMethodInfoPtr_StopAnimation_Public_Void_String_0;

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeMethodInfoPtr_StopAllAnimations_Private_Void_0;

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimations_Public_Il2CppStringArray_0;

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationSources_Public_Il2CppStringArray_String_0;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationInfo_Public_Il2CppReferenceArray_1_AnimationInfo_0;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativePath_Private_String_Transform_Transform_0;

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAssetID_Private_Void_Int32_0;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnimationOnStartChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeMethodInfoPtr_CollisionTypeChanged_Private_Void_CollisionType_CollisionType_0;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeMethodInfoPtr_AssetIDChanged_Private_Void_Int32_Int32_0;

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeMethodInfoPtr__LoadMesh_b__28_0_Private_Void_0;

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAssetID__Int32_Protected_Void_Int32_0;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAssetID__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002829 RID: 10281
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x0400282A RID: 10282
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
