using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000297 RID: 663
	public class Part : DynamicInstance
	{
		// Token: 0x06003556 RID: 13654 RVA: 0x000F2CE4 File Offset: 0x000F0EE4
		// Note: this type is marked as 'beforefieldinit'.
		static Part()
		{
			Il2CppClassPointerStore<Part>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Part");
			Part.NativeFieldInfoPtr_MaterialUVScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "MaterialUVScale");
			Part.NativeFieldInfoPtr_isSpawnCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "isSpawnCached");
			Part.NativeFieldInfoPtr_isSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "isSpawn");
			Part.NativeFieldInfoPtr_anchored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "anchored");
			Part.NativeFieldInfoPtr_canCollide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "canCollide");
			Part.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "color");
			Part.NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "shape");
			Part.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "material");
			Part.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "velocity");
			Part.NativeFieldInfoPtr_castShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "castShadows");
			Part.NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "drag");
			Part.NativeFieldInfoPtr_angularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "angularDrag");
			Part.NativeFieldInfoPtr_useGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "useGravity");
			Part.NativeFieldInfoPtr_bounciness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "bounciness");
			Part.NativeFieldInfoPtr_friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "friction");
			Part.NativeFieldInfoPtr_frictionCombine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "frictionCombine");
			Part.NativeFieldInfoPtr_bounceCombine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "bounceCombine");
			Part.NativeFieldInfoPtr_materialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "materialPropertyBlock");
			Part.NativeFieldInfoPtr__renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_renderer");
			Part.NativeFieldInfoPtr_shapeMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "shapeMeshes");
			Part.NativeFieldInfoPtr_mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "mass");
			Part.NativeFieldInfoPtr_lastScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "lastScale");
			Part.NativeFieldInfoPtr_environment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "environment");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_isSpawn");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_anchored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_anchored");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_canCollide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_canCollide");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_color");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_shape");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_material");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_velocity");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_castShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_castShadows");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_drag");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_angularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_angularDrag");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_useGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_useGravity");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_bounciness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_bounciness");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_friction");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_frictionCombine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_frictionCombine");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_bounceCombine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_bounceCombine");
			Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_mass");
			Part.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671366);
			Part.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671367);
			Part.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671368);
			Part.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671369);
			Part.NativeMethodInfoPtr_get_CanCollide_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671370);
			Part.NativeMethodInfoPtr_set_CanCollide_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671371);
			Part.NativeMethodInfoPtr_get_IsSpawn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671372);
			Part.NativeMethodInfoPtr_set_IsSpawn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671373);
			Part.NativeMethodInfoPtr_get_Shape_Public_get_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671374);
			Part.NativeMethodInfoPtr_set_Shape_Public_set_Void_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671375);
			Part.NativeMethodInfoPtr_get_Material_Public_get_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671376);
			Part.NativeMethodInfoPtr_set_Material_Public_set_Void_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671377);
			Part.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671379);
			Part.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671380);
			Part.NativeMethodInfoPtr_get_Drag_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671381);
			Part.NativeMethodInfoPtr_set_Drag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671382);
			Part.NativeMethodInfoPtr_get_AngularDrag_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671383);
			Part.NativeMethodInfoPtr_set_AngularDrag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671384);
			Part.NativeMethodInfoPtr_get_Mass_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671385);
			Part.NativeMethodInfoPtr_set_Mass_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671386);
			Part.NativeMethodInfoPtr_get_AngularVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671387);
			Part.NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671388);
			Part.NativeMethodInfoPtr_get_UseGravity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671389);
			Part.NativeMethodInfoPtr_set_UseGravity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671390);
			Part.NativeMethodInfoPtr_get_Bounciness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671391);
			Part.NativeMethodInfoPtr_set_Bounciness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671392);
			Part.NativeMethodInfoPtr_get_Friction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671393);
			Part.NativeMethodInfoPtr_set_Friction_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671394);
			Part.NativeMethodInfoPtr_get_FrictionCombine_Public_get_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671395);
			Part.NativeMethodInfoPtr_set_FrictionCombine_Public_set_Void_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671396);
			Part.NativeMethodInfoPtr_get_BounceCombine_Public_get_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671397);
			Part.NativeMethodInfoPtr_set_BounceCombine_Public_set_Void_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671398);
			Part.NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671399);
			Part.NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671400);
			Part.NativeMethodInfoPtr_get_NetworkisSpawn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671445);
			Part.NativeMethodInfoPtr_set_NetworkisSpawn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671446);
			Part.NativeMethodInfoPtr_get_Networkanchored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671447);
			Part.NativeMethodInfoPtr_set_Networkanchored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671448);
			Part.NativeMethodInfoPtr_get_NetworkcanCollide_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671449);
			Part.NativeMethodInfoPtr_set_NetworkcanCollide_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671450);
			Part.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671451);
			Part.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671452);
			Part.NativeMethodInfoPtr_get_Networkshape_Public_get_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671453);
			Part.NativeMethodInfoPtr_set_Networkshape_Public_set_Void_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671454);
			Part.NativeMethodInfoPtr_get_Networkmaterial_Public_get_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671455);
			Part.NativeMethodInfoPtr_set_Networkmaterial_Public_set_Void_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671456);
			Part.NativeMethodInfoPtr_get_Networkvelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671457);
			Part.NativeMethodInfoPtr_set_Networkvelocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671458);
			Part.NativeMethodInfoPtr_get_NetworkcastShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671459);
			Part.NativeMethodInfoPtr_set_NetworkcastShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671460);
			Part.NativeMethodInfoPtr_get_Networkdrag_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671461);
			Part.NativeMethodInfoPtr_set_Networkdrag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671462);
			Part.NativeMethodInfoPtr_get_NetworkangularDrag_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671463);
			Part.NativeMethodInfoPtr_set_NetworkangularDrag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671464);
			Part.NativeMethodInfoPtr_get_NetworkuseGravity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671465);
			Part.NativeMethodInfoPtr_set_NetworkuseGravity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671466);
			Part.NativeMethodInfoPtr_get_Networkbounciness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671467);
			Part.NativeMethodInfoPtr_set_Networkbounciness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671468);
			Part.NativeMethodInfoPtr_get_Networkfriction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671469);
			Part.NativeMethodInfoPtr_set_Networkfriction_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671470);
			Part.NativeMethodInfoPtr_get_NetworkfrictionCombine_Public_get_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671471);
			Part.NativeMethodInfoPtr_set_NetworkfrictionCombine_Public_set_Void_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671472);
			Part.NativeMethodInfoPtr_get_NetworkbounceCombine_Public_get_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671473);
			Part.NativeMethodInfoPtr_set_NetworkbounceCombine_Public_set_Void_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671474);
			Part.NativeMethodInfoPtr_get_Networkmass_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671475);
			Part.NativeMethodInfoPtr_set_Networkmass_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671476);
			Part.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671442);
			Part.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671364);
			Part.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671365);
			Part.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671378);
			Part.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671401);
			Part.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671402);
			Part.NativeMethodInfoPtr_OnNetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671403);
			Part.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671404);
			Part.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671405);
			Part.NativeMethodInfoPtr_SetMass_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671406);
			Part.NativeMethodInfoPtr_SetVelocity_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671407);
			Part.NativeMethodInfoPtr_OnColorChange_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671408);
			Part.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671409);
			Part.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671410);
			Part.NativeMethodInfoPtr_MoveRotation_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671411);
			Part.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671412);
			Part.NativeMethodInfoPtr_AddTorque_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671413);
			Part.NativeMethodInfoPtr_AddForceAtPosition_Public_Void_Vector3_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671414);
			Part.NativeMethodInfoPtr_AddRelativeForce_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671415);
			Part.NativeMethodInfoPtr_AddRelativeTorque_Public_Void_Vector3_ForceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671416);
			Part.NativeMethodInfoPtr_RpcSetAnchored_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671417);
			Part.NativeMethodInfoPtr_RpcSetCanCollide_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671418);
			Part.NativeMethodInfoPtr_RpcSetSpawn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671419);
			Part.NativeMethodInfoPtr_RpcSetShape_Private_Void_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671420);
			Part.NativeMethodInfoPtr_RpcSetMaterial_Private_Void_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671421);
			Part.NativeMethodInfoPtr_RpcSetDrag_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671422);
			Part.NativeMethodInfoPtr_RpcSetAngularDrag_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671423);
			Part.NativeMethodInfoPtr_RpcSetUseGravity_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671424);
			Part.NativeMethodInfoPtr_RpcSetBounciness_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671425);
			Part.NativeMethodInfoPtr_RpcSetFriction_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671426);
			Part.NativeMethodInfoPtr_RpcSetFrictionCombine_Private_Void_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671427);
			Part.NativeMethodInfoPtr_RpcSetBounceCombine_Private_Void_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671428);
			Part.NativeMethodInfoPtr_OnCastShadowsChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671429);
			Part.NativeMethodInfoPtr_OnIsSpawnChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671430);
			Part.NativeMethodInfoPtr_OnAnchoredChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671431);
			Part.NativeMethodInfoPtr_OnCanCollideChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671432);
			Part.NativeMethodInfoPtr_OnShapeChange_Private_Void_PartShape_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671433);
			Part.NativeMethodInfoPtr_OnMaterialChange_Private_Void_PartMaterial_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671434);
			Part.NativeMethodInfoPtr_OnDragChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671435);
			Part.NativeMethodInfoPtr_OnAngularDragChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671436);
			Part.NativeMethodInfoPtr_OnUseGravityChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671437);
			Part.NativeMethodInfoPtr_OnBouncinessChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671438);
			Part.NativeMethodInfoPtr_OnFrictionChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671439);
			Part.NativeMethodInfoPtr_OnFrictionCombineChanged_Private_Void_PhysicsMaterialCombine_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671440);
			Part.NativeMethodInfoPtr_OnBounceCombineChanged_Private_Void_PhysicsMaterialCombine_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671441);
			Part.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671444);
			Part.NativeMethodInfoPtr_UserCode_RpcSetAnchored__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671477);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnchored__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671478);
			Part.NativeMethodInfoPtr_UserCode_RpcSetCanCollide__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671479);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetCanCollide__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671480);
			Part.NativeMethodInfoPtr_UserCode_RpcSetSpawn__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671481);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetSpawn__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671482);
			Part.NativeMethodInfoPtr_UserCode_RpcSetShape__PartShape_Protected_Void_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671483);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetShape__PartShape_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671484);
			Part.NativeMethodInfoPtr_UserCode_RpcSetMaterial__PartMaterial_Protected_Void_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671485);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetMaterial__PartMaterial_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671486);
			Part.NativeMethodInfoPtr_UserCode_RpcSetDrag__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671487);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetDrag__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671488);
			Part.NativeMethodInfoPtr_UserCode_RpcSetAngularDrag__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671489);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetAngularDrag__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671490);
			Part.NativeMethodInfoPtr_UserCode_RpcSetUseGravity__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671491);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetUseGravity__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671492);
			Part.NativeMethodInfoPtr_UserCode_RpcSetBounciness__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671493);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetBounciness__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671494);
			Part.NativeMethodInfoPtr_UserCode_RpcSetFriction__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671495);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetFriction__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671496);
			Part.NativeMethodInfoPtr_UserCode_RpcSetFrictionCombine__PhysicsMaterialCombine_Protected_Void_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671497);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetFrictionCombine__PhysicsMaterialCombine_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671498);
			Part.NativeMethodInfoPtr_UserCode_RpcSetBounceCombine__PhysicsMaterialCombine_Protected_Void_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671499);
			Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetBounceCombine__PhysicsMaterialCombine_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671500);
			Part.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671501);
			Part.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100671502);
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x000F3AE0 File Offset: 0x000F1CE0
		// (set) Token: 0x06003558 RID: 13656 RVA: 0x000F3B20 File Offset: 0x000F1D20
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 108691, RefRangeEnd = 108696, XrefRangeStart = 108672, XrefRangeEnd = 108691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x000F3B64 File Offset: 0x000F1D64
		// (set) Token: 0x0600355A RID: 13658 RVA: 0x000F3BA0 File Offset: 0x000F1DA0
		public unsafe bool Anchored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 108747, RefRangeEnd = 108755, XrefRangeStart = 108696, XrefRangeEnd = 108747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x000F3BE0 File Offset: 0x000F1DE0
		// (set) Token: 0x0600355C RID: 13660 RVA: 0x000F3C1C File Offset: 0x000F1E1C
		public unsafe bool CanCollide
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_CanCollide_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 108789, RefRangeEnd = 108794, XrefRangeStart = 108755, XrefRangeEnd = 108789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_CanCollide_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x0600355D RID: 13661 RVA: 0x000F3C5C File Offset: 0x000F1E5C
		// (set) Token: 0x0600355E RID: 13662 RVA: 0x000F3C98 File Offset: 0x000F1E98
		public unsafe bool IsSpawn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_IsSpawn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 108816, RefRangeEnd = 108821, XrefRangeStart = 108794, XrefRangeEnd = 108816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_IsSpawn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x0600355F RID: 13663 RVA: 0x000F3CD8 File Offset: 0x000F1ED8
		// (set) Token: 0x06003560 RID: 13664 RVA: 0x000F3D18 File Offset: 0x000F1F18
		public unsafe PartShape Shape
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Shape_Public_get_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartShape>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 108919, RefRangeEnd = 108926, XrefRangeStart = 108821, XrefRangeEnd = 108919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Shape_Public_set_Void_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06003561 RID: 13665 RVA: 0x000F3D5C File Offset: 0x000F1F5C
		// (set) Token: 0x06003562 RID: 13666 RVA: 0x000F3D9C File Offset: 0x000F1F9C
		public unsafe PartMaterial Material
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Material_Public_get_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartMaterial>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 108955, RefRangeEnd = 108961, XrefRangeStart = 108926, XrefRangeEnd = 108955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Material_Public_set_Void_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06003563 RID: 13667 RVA: 0x000F3DE0 File Offset: 0x000F1FE0
		// (set) Token: 0x06003564 RID: 13668 RVA: 0x000F3E20 File Offset: 0x000F2020
		public unsafe Vector3 Velocity
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 108973, RefRangeEnd = 108979, XrefRangeStart = 108961, XrefRangeEnd = 108973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 108990, RefRangeEnd = 108991, XrefRangeStart = 108979, XrefRangeEnd = 108990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06003565 RID: 13669 RVA: 0x000F3E64 File Offset: 0x000F2064
		// (set) Token: 0x06003566 RID: 13670 RVA: 0x000F3EA0 File Offset: 0x000F20A0
		public unsafe float Drag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 108998, RefRangeEnd = 109002, XrefRangeStart = 108991, XrefRangeEnd = 108998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Drag_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 109029, RefRangeEnd = 109034, XrefRangeStart = 109002, XrefRangeEnd = 109029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Drag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x000F3EE0 File Offset: 0x000F20E0
		// (set) Token: 0x06003568 RID: 13672 RVA: 0x000F3F1C File Offset: 0x000F211C
		public unsafe float AngularDrag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 109041, RefRangeEnd = 109045, XrefRangeStart = 109034, XrefRangeEnd = 109041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_AngularDrag_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 109072, RefRangeEnd = 109077, XrefRangeStart = 109045, XrefRangeEnd = 109072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_AngularDrag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x000F3F5C File Offset: 0x000F215C
		// (set) Token: 0x0600356A RID: 13674 RVA: 0x000F3F98 File Offset: 0x000F2198
		public unsafe float Mass
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 109084, RefRangeEnd = 109088, XrefRangeStart = 109077, XrefRangeEnd = 109084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Mass_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109099, RefRangeEnd = 109100, XrefRangeStart = 109088, XrefRangeEnd = 109099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Mass_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x0600356B RID: 13675 RVA: 0x000F3FD8 File Offset: 0x000F21D8
		// (set) Token: 0x0600356C RID: 13676 RVA: 0x000F4018 File Offset: 0x000F2218
		public unsafe Vector3 AngularVelocity
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 109111, RefRangeEnd = 109115, XrefRangeStart = 109100, XrefRangeEnd = 109111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_AngularVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109123, RefRangeEnd = 109124, XrefRangeStart = 109115, XrefRangeEnd = 109123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x0600356D RID: 13677 RVA: 0x000F405C File Offset: 0x000F225C
		// (set) Token: 0x0600356E RID: 13678 RVA: 0x000F4098 File Offset: 0x000F2298
		public unsafe bool UseGravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_UseGravity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 109151, RefRangeEnd = 109156, XrefRangeStart = 109124, XrefRangeEnd = 109151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_UseGravity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x0600356F RID: 13679 RVA: 0x000F40D8 File Offset: 0x000F22D8
		// (set) Token: 0x06003570 RID: 13680 RVA: 0x000F4114 File Offset: 0x000F2314
		public unsafe float Bounciness
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109166, RefRangeEnd = 109167, XrefRangeStart = 109156, XrefRangeEnd = 109166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Bounciness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 109202, RefRangeEnd = 109207, XrefRangeStart = 109167, XrefRangeEnd = 109202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Bounciness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06003571 RID: 13681 RVA: 0x000F4154 File Offset: 0x000F2354
		// (set) Token: 0x06003572 RID: 13682 RVA: 0x000F4190 File Offset: 0x000F2390
		public unsafe float Friction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109217, RefRangeEnd = 109218, XrefRangeStart = 109207, XrefRangeEnd = 109217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Friction_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 109254, RefRangeEnd = 109259, XrefRangeStart = 109218, XrefRangeEnd = 109254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Friction_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06003573 RID: 13683 RVA: 0x000F41D0 File Offset: 0x000F23D0
		// (set) Token: 0x06003574 RID: 13684 RVA: 0x000F4210 File Offset: 0x000F2410
		public unsafe PhysicsMaterialCombine FrictionCombine
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109259, XrefRangeEnd = 109269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_FrictionCombine_Public_get_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhysicsMaterialCombine>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 109304, RefRangeEnd = 109308, XrefRangeStart = 109269, XrefRangeEnd = 109304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_FrictionCombine_Public_set_Void_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x000F4254 File Offset: 0x000F2454
		// (set) Token: 0x06003576 RID: 13686 RVA: 0x000F4294 File Offset: 0x000F2494
		public unsafe PhysicsMaterialCombine BounceCombine
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109308, XrefRangeEnd = 109318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_BounceCombine_Public_get_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhysicsMaterialCombine>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 109353, RefRangeEnd = 109357, XrefRangeStart = 109318, XrefRangeEnd = 109353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_BounceCombine_Public_set_Void_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x000F42D8 File Offset: 0x000F24D8
		// (set) Token: 0x06003578 RID: 13688 RVA: 0x000F4314 File Offset: 0x000F2514
		public unsafe bool CastShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 109366, RefRangeEnd = 109369, XrefRangeStart = 109357, XrefRangeEnd = 109366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06003579 RID: 13689 RVA: 0x000F4354 File Offset: 0x000F2554
		// (set) Token: 0x0600357A RID: 13690 RVA: 0x000F4390 File Offset: 0x000F2590
		public unsafe bool NetworkisSpawn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_NetworkisSpawn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109369, XrefRangeEnd = 109372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_NetworkisSpawn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x000F43D0 File Offset: 0x000F25D0
		// (set) Token: 0x0600357C RID: 13692 RVA: 0x000F440C File Offset: 0x000F260C
		public unsafe bool Networkanchored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Networkanchored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109372, XrefRangeEnd = 109375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Networkanchored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x000F444C File Offset: 0x000F264C
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x000F4488 File Offset: 0x000F2688
		public unsafe bool NetworkcanCollide
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_NetworkcanCollide_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 109378, RefRangeEnd = 109380, XrefRangeStart = 109375, XrefRangeEnd = 109378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_NetworkcanCollide_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x000F44C8 File Offset: 0x000F26C8
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x000F4508 File Offset: 0x000F2708
		public unsafe Color Networkcolor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109380, XrefRangeEnd = 109383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x000F454C File Offset: 0x000F274C
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x000F458C File Offset: 0x000F278C
		public unsafe PartShape Networkshape
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Networkshape_Public_get_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartShape>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109386, RefRangeEnd = 109387, XrefRangeStart = 109383, XrefRangeEnd = 109386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Networkshape_Public_set_Void_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x000F45D0 File Offset: 0x000F27D0
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x000F4610 File Offset: 0x000F2810
		public unsafe PartMaterial Networkmaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Networkmaterial_Public_get_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartMaterial>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109387, XrefRangeEnd = 109390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Networkmaterial_Public_set_Void_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x000F4654 File Offset: 0x000F2854
		// (set) Token: 0x06003586 RID: 13702 RVA: 0x000F4694 File Offset: 0x000F2894
		public unsafe Vector3 Networkvelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Networkvelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109390, XrefRangeEnd = 109393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Networkvelocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x000F46D8 File Offset: 0x000F28D8
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x000F4714 File Offset: 0x000F2914
		public unsafe bool NetworkcastShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_NetworkcastShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109393, XrefRangeEnd = 109396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_NetworkcastShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x000F4754 File Offset: 0x000F2954
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x000F4790 File Offset: 0x000F2990
		public unsafe float Networkdrag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Networkdrag_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109396, XrefRangeEnd = 109399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Networkdrag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x000F47D0 File Offset: 0x000F29D0
		// (set) Token: 0x0600358C RID: 13708 RVA: 0x000F480C File Offset: 0x000F2A0C
		public unsafe float NetworkangularDrag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_NetworkangularDrag_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109399, XrefRangeEnd = 109402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_NetworkangularDrag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600358D RID: 13709 RVA: 0x000F484C File Offset: 0x000F2A4C
		// (set) Token: 0x0600358E RID: 13710 RVA: 0x000F4888 File Offset: 0x000F2A88
		public unsafe bool NetworkuseGravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_NetworkuseGravity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109402, XrefRangeEnd = 109405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_NetworkuseGravity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x000F48C8 File Offset: 0x000F2AC8
		// (set) Token: 0x06003590 RID: 13712 RVA: 0x000F4904 File Offset: 0x000F2B04
		public unsafe float Networkbounciness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Networkbounciness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109405, XrefRangeEnd = 109408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Networkbounciness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06003591 RID: 13713 RVA: 0x000F4944 File Offset: 0x000F2B44
		// (set) Token: 0x06003592 RID: 13714 RVA: 0x000F4980 File Offset: 0x000F2B80
		public unsafe float Networkfriction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Networkfriction_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109408, XrefRangeEnd = 109411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Networkfriction_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x000F49C0 File Offset: 0x000F2BC0
		// (set) Token: 0x06003594 RID: 13716 RVA: 0x000F4A00 File Offset: 0x000F2C00
		public unsafe PhysicsMaterialCombine NetworkfrictionCombine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_NetworkfrictionCombine_Public_get_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhysicsMaterialCombine>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109411, XrefRangeEnd = 109414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_NetworkfrictionCombine_Public_set_Void_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x000F4A44 File Offset: 0x000F2C44
		// (set) Token: 0x06003596 RID: 13718 RVA: 0x000F4A84 File Offset: 0x000F2C84
		public unsafe PhysicsMaterialCombine NetworkbounceCombine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_NetworkbounceCombine_Public_get_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhysicsMaterialCombine>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109414, XrefRangeEnd = 109417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_NetworkbounceCombine_Public_set_Void_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x000F4AC8 File Offset: 0x000F2CC8
		// (set) Token: 0x06003598 RID: 13720 RVA: 0x000F4B04 File Offset: 0x000F2D04
		public unsafe float Networkmass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_get_Networkmass_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109417, XrefRangeEnd = 109420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_set_Networkmass_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x000F4B44 File Offset: 0x000F2D44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109527, RefRangeEnd = 109530, XrefRangeStart = 109420, XrefRangeEnd = 109527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Part()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Part>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x000F4B80 File Offset: 0x000F2D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109558, RefRangeEnd = 109559, XrefRangeStart = 109530, XrefRangeEnd = 109558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x000F4BBC File Offset: 0x000F2DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109608, RefRangeEnd = 109609, XrefRangeStart = 109559, XrefRangeEnd = 109608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x000F4BF8 File Offset: 0x000F2DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109632, RefRangeEnd = 109634, XrefRangeStart = 109609, XrefRangeEnd = 109632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x000F4C2C File Offset: 0x000F2E2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109635, RefRangeEnd = 109637, XrefRangeStart = 109634, XrefRangeEnd = 109635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x000F4C68 File Offset: 0x000F2E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109640, RefRangeEnd = 109642, XrefRangeStart = 109637, XrefRangeEnd = 109640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x000F4CA4 File Offset: 0x000F2EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109642, XrefRangeEnd = 109650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnNetworkStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_OnNetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x000F4CE0 File Offset: 0x000F2EE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109664, RefRangeEnd = 109665, XrefRangeStart = 109650, XrefRangeEnd = 109664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x000F4D1C File Offset: 0x000F2F1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109767, RefRangeEnd = 109769, XrefRangeStart = 109665, XrefRangeEnd = 109767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x000F4D6C File Offset: 0x000F2F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109769, XrefRangeEnd = 109780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMass(float oldMass, float newMass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldMass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_SetMass_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x000F4DB8 File Offset: 0x000F2FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109780, XrefRangeEnd = 109792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVelocity(Vector3 oldVelocity, Vector3 newVelocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldVelocity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newVelocity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_SetVelocity_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x000F4E0C File Offset: 0x000F300C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109792, XrefRangeEnd = 109801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColorChange(Color oldColor, Color newColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldColor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newColor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnColorChange_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x000F4E60 File Offset: 0x000F3060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109801, XrefRangeEnd = 109803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x000F4E9C File Offset: 0x000F309C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109812, RefRangeEnd = 109813, XrefRangeStart = 109803, XrefRangeEnd = 109812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePosition(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x000F4EE0 File Offset: 0x000F30E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109823, RefRangeEnd = 109824, XrefRangeStart = 109813, XrefRangeEnd = 109823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRotation(Vector3 rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_MoveRotation_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x000F4F24 File Offset: 0x000F3124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109832, RefRangeEnd = 109833, XrefRangeStart = 109824, XrefRangeEnd = 109832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForce(Vector3 force, ForceMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(force);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x000F4F78 File Offset: 0x000F3178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109841, RefRangeEnd = 109842, XrefRangeStart = 109833, XrefRangeEnd = 109841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTorque(Vector3 torque, ForceMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(torque);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_AddTorque_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x000F4FCC File Offset: 0x000F31CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109850, RefRangeEnd = 109851, XrefRangeStart = 109842, XrefRangeEnd = 109850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(force);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_AddForceAtPosition_Public_Void_Vector3_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x000F5034 File Offset: 0x000F3234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109859, RefRangeEnd = 109860, XrefRangeStart = 109851, XrefRangeEnd = 109859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRelativeForce(Vector3 force, ForceMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(force);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_AddRelativeForce_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x000F5088 File Offset: 0x000F3288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109868, RefRangeEnd = 109869, XrefRangeStart = 109860, XrefRangeEnd = 109868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRelativeTorque(Vector3 torque, ForceMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(torque);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_AddRelativeTorque_Public_Void_Vector3_ForceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x000F50DC File Offset: 0x000F32DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109869, XrefRangeEnd = 109890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAnchored(bool anchored)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchored;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetAnchored_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x000F511C File Offset: 0x000F331C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109911, RefRangeEnd = 109913, XrefRangeStart = 109890, XrefRangeEnd = 109911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetCanCollide(bool canCollide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canCollide;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetCanCollide_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x000F515C File Offset: 0x000F335C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109913, XrefRangeEnd = 109934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetSpawn(bool spawn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref spawn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetSpawn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x000F519C File Offset: 0x000F339C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109934, XrefRangeEnd = 109955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetShape(PartShape shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetShape_Private_Void_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x000F51E0 File Offset: 0x000F33E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109955, XrefRangeEnd = 109976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetMaterial(PartMaterial material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetMaterial_Private_Void_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x000F5224 File Offset: 0x000F3424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109976, XrefRangeEnd = 109997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetDrag(float d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetDrag_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x000F5264 File Offset: 0x000F3464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109997, XrefRangeEnd = 110018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAngularDrag(float d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetAngularDrag_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x000F52A4 File Offset: 0x000F34A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110018, XrefRangeEnd = 110039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetUseGravity(bool g)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref g;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetUseGravity_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x000F52E4 File Offset: 0x000F34E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110039, XrefRangeEnd = 110060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetBounciness(float b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetBounciness_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x000F5324 File Offset: 0x000F3524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110060, XrefRangeEnd = 110081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetFriction(float f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetFriction_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x000F5364 File Offset: 0x000F3564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110081, XrefRangeEnd = 110102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetFrictionCombine(PhysicsMaterialCombine c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetFrictionCombine_Private_Void_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x000F53A8 File Offset: 0x000F35A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110102, XrefRangeEnd = 110123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetBounceCombine(PhysicsMaterialCombine c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_RpcSetBounceCombine_Private_Void_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x000F53EC File Offset: 0x000F35EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110123, XrefRangeEnd = 110125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCastShadowsChanged(bool old, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref old;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnCastShadowsChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x000F5438 File Offset: 0x000F3638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110125, XrefRangeEnd = 110127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnIsSpawnChanged(bool old, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref old;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnIsSpawnChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x000F5484 File Offset: 0x000F3684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110127, XrefRangeEnd = 110129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAnchoredChanged(bool old, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref old;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnAnchoredChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x000F54D0 File Offset: 0x000F36D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110129, XrefRangeEnd = 110131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanCollideChanged(bool old, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref old;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnCanCollideChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x000F551C File Offset: 0x000F371C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110131, XrefRangeEnd = 110133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShapeChange(PartShape old, PartShape value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(old);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnShapeChange_Private_Void_PartShape_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x000F5570 File Offset: 0x000F3770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110133, XrefRangeEnd = 110135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMaterialChange(PartMaterial old, PartMaterial value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(old);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnMaterialChange_Private_Void_PartMaterial_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x000F55C4 File Offset: 0x000F37C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110135, XrefRangeEnd = 110137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnDragChanged(float old, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref old;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnDragChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x000F5610 File Offset: 0x000F3810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110137, XrefRangeEnd = 110139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnAngularDragChanged(float old, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref old;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnAngularDragChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x000F565C File Offset: 0x000F385C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110139, XrefRangeEnd = 110141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnUseGravityChanged(bool old, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref old;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnUseGravityChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x000F56A8 File Offset: 0x000F38A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110141, XrefRangeEnd = 110143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBouncinessChanged(float old, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref old;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnBouncinessChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x000F56F4 File Offset: 0x000F38F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110143, XrefRangeEnd = 110145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFrictionChanged(float old, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref old;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnFrictionChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x000F5740 File Offset: 0x000F3940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110145, XrefRangeEnd = 110147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFrictionCombineChanged(PhysicsMaterialCombine old, PhysicsMaterialCombine value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(old);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnFrictionCombineChanged_Private_Void_PhysicsMaterialCombine_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x000F5794 File Offset: 0x000F3994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110147, XrefRangeEnd = 110149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBounceCombineChanged(PhysicsMaterialCombine old, PhysicsMaterialCombine value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(old);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_OnBounceCombineChanged_Private_Void_PhysicsMaterialCombine_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x000F57E8 File Offset: 0x000F39E8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x000F5830 File Offset: 0x000F3A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110149, XrefRangeEnd = 110151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAnchored__Boolean(bool anchored)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchored;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetAnchored__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x000F5870 File Offset: 0x000F3A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110151, XrefRangeEnd = 110166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnchored__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x000F58CC File Offset: 0x000F3ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110166, XrefRangeEnd = 110168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetCanCollide__Boolean(bool canCollide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canCollide;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetCanCollide__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x000F590C File Offset: 0x000F3B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110168, XrefRangeEnd = 110183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetCanCollide__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetCanCollide__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x000F5968 File Offset: 0x000F3B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110183, XrefRangeEnd = 110185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetSpawn__Boolean(bool spawn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref spawn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetSpawn__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x000F59A8 File Offset: 0x000F3BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110185, XrefRangeEnd = 110200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetSpawn__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetSpawn__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x000F5A04 File Offset: 0x000F3C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110200, XrefRangeEnd = 110202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetShape__PartShape(PartShape shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetShape__PartShape_Protected_Void_PartShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x000F5A48 File Offset: 0x000F3C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110202, XrefRangeEnd = 110217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetShape__PartShape(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetShape__PartShape_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x000F5AA4 File Offset: 0x000F3CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110217, XrefRangeEnd = 110219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetMaterial__PartMaterial(PartMaterial material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetMaterial__PartMaterial_Protected_Void_PartMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x000F5AE8 File Offset: 0x000F3CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110219, XrefRangeEnd = 110234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetMaterial__PartMaterial(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetMaterial__PartMaterial_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x000F5B44 File Offset: 0x000F3D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110234, XrefRangeEnd = 110236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetDrag__Single(float d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetDrag__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x000F5B84 File Offset: 0x000F3D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110236, XrefRangeEnd = 110247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetDrag__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x000F5BE0 File Offset: 0x000F3DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110247, XrefRangeEnd = 110249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAngularDrag__Single(float d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetAngularDrag__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x000F5C20 File Offset: 0x000F3E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110249, XrefRangeEnd = 110260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetAngularDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetAngularDrag__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x000F5C7C File Offset: 0x000F3E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110260, XrefRangeEnd = 110262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetUseGravity__Boolean(bool g)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref g;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetUseGravity__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x000F5CBC File Offset: 0x000F3EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110262, XrefRangeEnd = 110277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetUseGravity__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetUseGravity__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x000F5D18 File Offset: 0x000F3F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110277, XrefRangeEnd = 110279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetBounciness__Single(float b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetBounciness__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x000F5D58 File Offset: 0x000F3F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110279, XrefRangeEnd = 110290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetBounciness__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetBounciness__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x000F5DB4 File Offset: 0x000F3FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110290, XrefRangeEnd = 110292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetFriction__Single(float f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetFriction__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x000F5DF4 File Offset: 0x000F3FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110292, XrefRangeEnd = 110303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetFriction__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetFriction__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x000F5E50 File Offset: 0x000F4050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110303, XrefRangeEnd = 110305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetFrictionCombine__PhysicsMaterialCombine(PhysicsMaterialCombine c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetFrictionCombine__PhysicsMaterialCombine_Protected_Void_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x000F5E94 File Offset: 0x000F4094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110305, XrefRangeEnd = 110320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetFrictionCombine__PhysicsMaterialCombine(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetFrictionCombine__PhysicsMaterialCombine_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x000F5EF0 File Offset: 0x000F40F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110320, XrefRangeEnd = 110322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetBounceCombine__PhysicsMaterialCombine(PhysicsMaterialCombine c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_UserCode_RpcSetBounceCombine__PhysicsMaterialCombine_Protected_Void_PhysicsMaterialCombine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x000F5F34 File Offset: 0x000F4134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110322, XrefRangeEnd = 110337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetBounceCombine__PhysicsMaterialCombine(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Part.NativeMethodInfoPtr_InvokeUserCode_RpcSetBounceCombine__PhysicsMaterialCombine_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x000F5F90 File Offset: 0x000F4190
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110371, RefRangeEnd = 110374, XrefRangeStart = 110337, XrefRangeEnd = 110371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x000F5FEC File Offset: 0x000F41EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110477, RefRangeEnd = 110480, XrefRangeStart = 110374, XrefRangeEnd = 110477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Part.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x00014F9C File Offset: 0x0001319C
		public Part(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x060035E2 RID: 13794 RVA: 0x000F6048 File Offset: 0x000F4248
		// (set) Token: 0x060035E3 RID: 13795 RVA: 0x00014FA5 File Offset: 0x000131A5
		public unsafe static float MaterialUVScale
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Part.NativeFieldInfoPtr_MaterialUVScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Part.NativeFieldInfoPtr_MaterialUVScale, (void*)(&value));
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x000F6064 File Offset: 0x000F4264
		// (set) Token: 0x060035E5 RID: 13797 RVA: 0x00014FB3 File Offset: 0x000131B3
		public unsafe bool isSpawnCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_isSpawnCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_isSpawnCached)) = value;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x000F608C File Offset: 0x000F428C
		// (set) Token: 0x060035E7 RID: 13799 RVA: 0x00014FCE File Offset: 0x000131CE
		public unsafe bool isSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_isSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_isSpawn)) = value;
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x060035E8 RID: 13800 RVA: 0x000F60B4 File Offset: 0x000F42B4
		// (set) Token: 0x060035E9 RID: 13801 RVA: 0x00014FE9 File Offset: 0x000131E9
		public unsafe bool anchored
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_anchored);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_anchored)) = value;
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x060035EA RID: 13802 RVA: 0x000F60DC File Offset: 0x000F42DC
		// (set) Token: 0x060035EB RID: 13803 RVA: 0x00015004 File Offset: 0x00013204
		public unsafe bool canCollide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_canCollide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_canCollide)) = value;
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x060035EC RID: 13804 RVA: 0x000F6104 File Offset: 0x000F4304
		// (set) Token: 0x060035ED RID: 13805 RVA: 0x0001501F File Offset: 0x0001321F
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x060035EE RID: 13806 RVA: 0x000F6134 File Offset: 0x000F4334
		// (set) Token: 0x060035EF RID: 13807 RVA: 0x0001503E File Offset: 0x0001323E
		public unsafe PartShape shape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_shape);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartShape>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_shape), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x060035F0 RID: 13808 RVA: 0x000F6164 File Offset: 0x000F4364
		// (set) Token: 0x060035F1 RID: 13809 RVA: 0x0001505D File Offset: 0x0001325D
		public unsafe PartMaterial material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartMaterial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x000F6194 File Offset: 0x000F4394
		// (set) Token: 0x060035F3 RID: 13811 RVA: 0x0001507C File Offset: 0x0001327C
		public unsafe Vector3 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_velocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_velocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x000F61C4 File Offset: 0x000F43C4
		// (set) Token: 0x060035F5 RID: 13813 RVA: 0x0001509B File Offset: 0x0001329B
		public unsafe bool castShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_castShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_castShadows)) = value;
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x000F61EC File Offset: 0x000F43EC
		// (set) Token: 0x060035F7 RID: 13815 RVA: 0x000150B6 File Offset: 0x000132B6
		public unsafe float drag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_drag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_drag)) = value;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x000F6214 File Offset: 0x000F4414
		// (set) Token: 0x060035F9 RID: 13817 RVA: 0x000150D1 File Offset: 0x000132D1
		public unsafe float angularDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_angularDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_angularDrag)) = value;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x000F623C File Offset: 0x000F443C
		// (set) Token: 0x060035FB RID: 13819 RVA: 0x000150EC File Offset: 0x000132EC
		public unsafe bool useGravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_useGravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_useGravity)) = value;
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x000F6264 File Offset: 0x000F4464
		// (set) Token: 0x060035FD RID: 13821 RVA: 0x00015107 File Offset: 0x00013307
		public unsafe float bounciness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_bounciness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_bounciness)) = value;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x000F628C File Offset: 0x000F448C
		// (set) Token: 0x060035FF RID: 13823 RVA: 0x00015122 File Offset: 0x00013322
		public unsafe float friction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_friction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_friction)) = value;
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06003600 RID: 13824 RVA: 0x000F62B4 File Offset: 0x000F44B4
		// (set) Token: 0x06003601 RID: 13825 RVA: 0x0001513D File Offset: 0x0001333D
		public unsafe PhysicsMaterialCombine frictionCombine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_frictionCombine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterialCombine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_frictionCombine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06003602 RID: 13826 RVA: 0x000F62E4 File Offset: 0x000F44E4
		// (set) Token: 0x06003603 RID: 13827 RVA: 0x0001515C File Offset: 0x0001335C
		public unsafe PhysicsMaterialCombine bounceCombine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_bounceCombine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterialCombine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_bounceCombine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x000F6314 File Offset: 0x000F4514
		// (set) Token: 0x06003605 RID: 13829 RVA: 0x0001517B File Offset: 0x0001337B
		public unsafe MaterialPropertyBlock materialPropertyBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_materialPropertyBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_materialPropertyBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x000F6344 File Offset: 0x000F4544
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x0001519A File Offset: 0x0001339A
		public unsafe Renderer _renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x000F6374 File Offset: 0x000F4574
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x000151B9 File Offset: 0x000133B9
		public unsafe static Dictionary<PartShape, Mesh> shapeMeshes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Part.NativeFieldInfoPtr_shapeMeshes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PartShape, Mesh>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Part.NativeFieldInfoPtr_shapeMeshes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x000F639C File Offset: 0x000F459C
		// (set) Token: 0x0600360B RID: 13835 RVA: 0x000151CB File Offset: 0x000133CB
		public unsafe float mass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_mass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_mass)) = value;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x0600360C RID: 13836 RVA: 0x000F63C4 File Offset: 0x000F45C4
		// (set) Token: 0x0600360D RID: 13837 RVA: 0x000151E6 File Offset: 0x000133E6
		public unsafe Vector3 lastScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_lastScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_lastScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x0600360E RID: 13838 RVA: 0x000F63F4 File Offset: 0x000F45F4
		// (set) Token: 0x0600360F RID: 13839 RVA: 0x00015205 File Offset: 0x00013405
		public unsafe Environment environment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_environment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Environment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr_environment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06003610 RID: 13840 RVA: 0x000F6424 File Offset: 0x000F4624
		// (set) Token: 0x06003611 RID: 13841 RVA: 0x00015224 File Offset: 0x00013424
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_isSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06003612 RID: 13842 RVA: 0x000F6454 File Offset: 0x000F4654
		// (set) Token: 0x06003613 RID: 13843 RVA: 0x00015243 File Offset: 0x00013443
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_anchored
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_anchored);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_anchored), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06003614 RID: 13844 RVA: 0x000F6484 File Offset: 0x000F4684
		// (set) Token: 0x06003615 RID: 13845 RVA: 0x00015262 File Offset: 0x00013462
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_canCollide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_canCollide);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_canCollide), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06003616 RID: 13846 RVA: 0x000F64B4 File Offset: 0x000F46B4
		// (set) Token: 0x06003617 RID: 13847 RVA: 0x00015281 File Offset: 0x00013481
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06003618 RID: 13848 RVA: 0x000F64E4 File Offset: 0x000F46E4
		// (set) Token: 0x06003619 RID: 13849 RVA: 0x000152A0 File Offset: 0x000134A0
		public unsafe Action<PartShape, PartShape> _Mirror_SyncVarHookDelegate_shape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shape);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PartShape, PartShape>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shape), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x0600361A RID: 13850 RVA: 0x000F6514 File Offset: 0x000F4714
		// (set) Token: 0x0600361B RID: 13851 RVA: 0x000152BF File Offset: 0x000134BF
		public unsafe Action<PartMaterial, PartMaterial> _Mirror_SyncVarHookDelegate_material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PartMaterial, PartMaterial>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x0600361C RID: 13852 RVA: 0x000F6544 File Offset: 0x000F4744
		// (set) Token: 0x0600361D RID: 13853 RVA: 0x000152DE File Offset: 0x000134DE
		public unsafe Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_velocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_velocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x0600361E RID: 13854 RVA: 0x000F6574 File Offset: 0x000F4774
		// (set) Token: 0x0600361F RID: 13855 RVA: 0x000152FD File Offset: 0x000134FD
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_castShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_castShadows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_castShadows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x000F65A4 File Offset: 0x000F47A4
		// (set) Token: 0x06003621 RID: 13857 RVA: 0x0001531C File Offset: 0x0001351C
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_drag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_drag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_drag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x000F65D4 File Offset: 0x000F47D4
		// (set) Token: 0x06003623 RID: 13859 RVA: 0x0001533B File Offset: 0x0001353B
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_angularDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_angularDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_angularDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x000F6604 File Offset: 0x000F4804
		// (set) Token: 0x06003625 RID: 13861 RVA: 0x0001535A File Offset: 0x0001355A
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_useGravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_useGravity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_useGravity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x000F6634 File Offset: 0x000F4834
		// (set) Token: 0x06003627 RID: 13863 RVA: 0x00015379 File Offset: 0x00013579
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_bounciness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_bounciness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_bounciness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x000F6664 File Offset: 0x000F4864
		// (set) Token: 0x06003629 RID: 13865 RVA: 0x00015398 File Offset: 0x00013598
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_friction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_friction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_friction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x000F6694 File Offset: 0x000F4894
		// (set) Token: 0x0600362B RID: 13867 RVA: 0x000153B7 File Offset: 0x000135B7
		public unsafe Action<PhysicsMaterialCombine, PhysicsMaterialCombine> _Mirror_SyncVarHookDelegate_frictionCombine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_frictionCombine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhysicsMaterialCombine, PhysicsMaterialCombine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_frictionCombine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x0600362C RID: 13868 RVA: 0x000F66C4 File Offset: 0x000F48C4
		// (set) Token: 0x0600362D RID: 13869 RVA: 0x000153D6 File Offset: 0x000135D6
		public unsafe Action<PhysicsMaterialCombine, PhysicsMaterialCombine> _Mirror_SyncVarHookDelegate_bounceCombine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_bounceCombine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhysicsMaterialCombine, PhysicsMaterialCombine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_bounceCombine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x0600362E RID: 13870 RVA: 0x000F66F4 File Offset: 0x000F48F4
		// (set) Token: 0x0600362F RID: 13871 RVA: 0x000153F5 File Offset: 0x000135F5
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_mass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_mass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Part.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_mass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeFieldInfoPtr_MaterialUVScale;

		// Token: 0x04002903 RID: 10499
		private static readonly IntPtr NativeFieldInfoPtr_isSpawnCached;

		// Token: 0x04002904 RID: 10500
		private static readonly IntPtr NativeFieldInfoPtr_isSpawn;

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeFieldInfoPtr_anchored;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeFieldInfoPtr_canCollide;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeFieldInfoPtr_shape;

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeFieldInfoPtr_castShadows;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeFieldInfoPtr_drag;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeFieldInfoPtr_angularDrag;

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeFieldInfoPtr_useGravity;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeFieldInfoPtr_bounciness;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeFieldInfoPtr_friction;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeFieldInfoPtr_frictionCombine;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeFieldInfoPtr_bounceCombine;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeFieldInfoPtr_materialPropertyBlock;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeFieldInfoPtr__renderer;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeFieldInfoPtr_shapeMeshes;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeFieldInfoPtr_mass;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeFieldInfoPtr_lastScale;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeFieldInfoPtr_environment;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_isSpawn;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_anchored;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_canCollide;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shape;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_material;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_velocity;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_castShadows;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_drag;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_angularDrag;

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_useGravity;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_bounciness;

		// Token: 0x04002925 RID: 10533
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_friction;

		// Token: 0x04002926 RID: 10534
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_frictionCombine;

		// Token: 0x04002927 RID: 10535
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_bounceCombine;

		// Token: 0x04002928 RID: 10536
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_mass;

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0;

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0;

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeMethodInfoPtr_get_CanCollide_Public_get_Boolean_0;

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeMethodInfoPtr_set_CanCollide_Public_set_Void_Boolean_0;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpawn_Public_get_Boolean_0;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSpawn_Public_set_Void_Boolean_0;

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeMethodInfoPtr_get_Shape_Public_get_PartShape_0;

		// Token: 0x04002932 RID: 10546
		private static readonly IntPtr NativeMethodInfoPtr_set_Shape_Public_set_Void_PartShape_0;

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeMethodInfoPtr_get_Material_Public_get_PartMaterial_0;

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeMethodInfoPtr_set_Material_Public_set_Void_PartMaterial_0;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0;

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeMethodInfoPtr_get_Drag_Public_get_Single_0;

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeMethodInfoPtr_set_Drag_Public_set_Void_Single_0;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeMethodInfoPtr_get_AngularDrag_Public_get_Single_0;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeMethodInfoPtr_set_AngularDrag_Public_set_Void_Single_0;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeMethodInfoPtr_get_Mass_Public_get_Single_0;

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeMethodInfoPtr_set_Mass_Public_set_Void_Single_0;

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_get_AngularVelocity_Public_get_Vector3_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_Vector3_0;

		// Token: 0x0400293F RID: 10559
		private static readonly IntPtr NativeMethodInfoPtr_get_UseGravity_Public_get_Boolean_0;

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeMethodInfoPtr_set_UseGravity_Public_set_Void_Boolean_0;

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeMethodInfoPtr_get_Bounciness_Public_get_Single_0;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeMethodInfoPtr_set_Bounciness_Public_set_Void_Single_0;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr_get_Friction_Public_get_Single_0;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeMethodInfoPtr_set_Friction_Public_set_Void_Single_0;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeMethodInfoPtr_get_FrictionCombine_Public_get_PhysicsMaterialCombine_0;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeMethodInfoPtr_set_FrictionCombine_Public_set_Void_PhysicsMaterialCombine_0;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeMethodInfoPtr_get_BounceCombine_Public_get_PhysicsMaterialCombine_0;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeMethodInfoPtr_set_BounceCombine_Public_set_Void_PhysicsMaterialCombine_0;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0;

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkisSpawn_Public_get_Boolean_0;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkisSpawn_Public_set_Void_Boolean_0;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkanchored_Public_get_Boolean_0;

		// Token: 0x0400294E RID: 10574
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkanchored_Public_set_Void_Boolean_0;

		// Token: 0x0400294F RID: 10575
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkcanCollide_Public_get_Boolean_0;

		// Token: 0x04002950 RID: 10576
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkcanCollide_Public_set_Void_Boolean_0;

		// Token: 0x04002951 RID: 10577
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0;

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0;

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkshape_Public_get_PartShape_0;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkshape_Public_set_Void_PartShape_0;

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkmaterial_Public_get_PartMaterial_0;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkmaterial_Public_set_Void_PartMaterial_0;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkvelocity_Public_get_Vector3_0;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkvelocity_Public_set_Void_Vector3_0;

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkcastShadows_Public_get_Boolean_0;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkcastShadows_Public_set_Void_Boolean_0;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkdrag_Public_get_Single_0;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkdrag_Public_set_Void_Single_0;

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkangularDrag_Public_get_Single_0;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkangularDrag_Public_set_Void_Single_0;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkuseGravity_Public_get_Boolean_0;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkuseGravity_Public_set_Void_Boolean_0;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkbounciness_Public_get_Single_0;

		// Token: 0x04002962 RID: 10594
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkbounciness_Public_set_Void_Single_0;

		// Token: 0x04002963 RID: 10595
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkfriction_Public_get_Single_0;

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkfriction_Public_set_Void_Single_0;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfrictionCombine_Public_get_PhysicsMaterialCombine_0;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfrictionCombine_Public_set_Void_PhysicsMaterialCombine_0;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkbounceCombine_Public_get_PhysicsMaterialCombine_0;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkbounceCombine_Public_set_Void_PhysicsMaterialCombine_0;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkmass_Public_get_Single_0;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkmass_Public_set_Void_Single_0;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Private_Void_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002970 RID: 10608
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeMethodInfoPtr_OnNetworkStart_Protected_Virtual_Void_0;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04002973 RID: 10611
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002974 RID: 10612
		private static readonly IntPtr NativeMethodInfoPtr_SetMass_Private_Void_Single_Single_0;

		// Token: 0x04002975 RID: 10613
		private static readonly IntPtr NativeMethodInfoPtr_SetVelocity_Private_Void_Vector3_Vector3_0;

		// Token: 0x04002976 RID: 10614
		private static readonly IntPtr NativeMethodInfoPtr_OnColorChange_Private_Void_Color_Color_0;

		// Token: 0x04002977 RID: 10615
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04002978 RID: 10616
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0;

		// Token: 0x04002979 RID: 10617
		private static readonly IntPtr NativeMethodInfoPtr_MoveRotation_Public_Void_Vector3_0;

		// Token: 0x0400297A RID: 10618
		private static readonly IntPtr NativeMethodInfoPtr_AddForce_Public_Void_Vector3_ForceMode_0;

		// Token: 0x0400297B RID: 10619
		private static readonly IntPtr NativeMethodInfoPtr_AddTorque_Public_Void_Vector3_ForceMode_0;

		// Token: 0x0400297C RID: 10620
		private static readonly IntPtr NativeMethodInfoPtr_AddForceAtPosition_Public_Void_Vector3_Vector3_ForceMode_0;

		// Token: 0x0400297D RID: 10621
		private static readonly IntPtr NativeMethodInfoPtr_AddRelativeForce_Public_Void_Vector3_ForceMode_0;

		// Token: 0x0400297E RID: 10622
		private static readonly IntPtr NativeMethodInfoPtr_AddRelativeTorque_Public_Void_Vector3_ForceMode_0;

		// Token: 0x0400297F RID: 10623
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAnchored_Private_Void_Boolean_0;

		// Token: 0x04002980 RID: 10624
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetCanCollide_Protected_Void_Boolean_0;

		// Token: 0x04002981 RID: 10625
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetSpawn_Private_Void_Boolean_0;

		// Token: 0x04002982 RID: 10626
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetShape_Private_Void_PartShape_0;

		// Token: 0x04002983 RID: 10627
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetMaterial_Private_Void_PartMaterial_0;

		// Token: 0x04002984 RID: 10628
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetDrag_Private_Void_Single_0;

		// Token: 0x04002985 RID: 10629
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAngularDrag_Private_Void_Single_0;

		// Token: 0x04002986 RID: 10630
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetUseGravity_Private_Void_Boolean_0;

		// Token: 0x04002987 RID: 10631
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetBounciness_Private_Void_Single_0;

		// Token: 0x04002988 RID: 10632
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetFriction_Private_Void_Single_0;

		// Token: 0x04002989 RID: 10633
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetFrictionCombine_Private_Void_PhysicsMaterialCombine_0;

		// Token: 0x0400298A RID: 10634
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetBounceCombine_Private_Void_PhysicsMaterialCombine_0;

		// Token: 0x0400298B RID: 10635
		private static readonly IntPtr NativeMethodInfoPtr_OnCastShadowsChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400298C RID: 10636
		private static readonly IntPtr NativeMethodInfoPtr_OnIsSpawnChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400298D RID: 10637
		private static readonly IntPtr NativeMethodInfoPtr_OnAnchoredChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400298E RID: 10638
		private static readonly IntPtr NativeMethodInfoPtr_OnCanCollideChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400298F RID: 10639
		private static readonly IntPtr NativeMethodInfoPtr_OnShapeChange_Private_Void_PartShape_PartShape_0;

		// Token: 0x04002990 RID: 10640
		private static readonly IntPtr NativeMethodInfoPtr_OnMaterialChange_Private_Void_PartMaterial_PartMaterial_0;

		// Token: 0x04002991 RID: 10641
		private static readonly IntPtr NativeMethodInfoPtr_OnDragChanged_Private_Void_Single_Single_0;

		// Token: 0x04002992 RID: 10642
		private static readonly IntPtr NativeMethodInfoPtr_OnAngularDragChanged_Private_Void_Single_Single_0;

		// Token: 0x04002993 RID: 10643
		private static readonly IntPtr NativeMethodInfoPtr_OnUseGravityChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002994 RID: 10644
		private static readonly IntPtr NativeMethodInfoPtr_OnBouncinessChanged_Private_Void_Single_Single_0;

		// Token: 0x04002995 RID: 10645
		private static readonly IntPtr NativeMethodInfoPtr_OnFrictionChanged_Private_Void_Single_Single_0;

		// Token: 0x04002996 RID: 10646
		private static readonly IntPtr NativeMethodInfoPtr_OnFrictionCombineChanged_Private_Void_PhysicsMaterialCombine_PhysicsMaterialCombine_0;

		// Token: 0x04002997 RID: 10647
		private static readonly IntPtr NativeMethodInfoPtr_OnBounceCombineChanged_Private_Void_PhysicsMaterialCombine_PhysicsMaterialCombine_0;

		// Token: 0x04002998 RID: 10648
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002999 RID: 10649
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAnchored__Boolean_Protected_Void_Boolean_0;

		// Token: 0x0400299A RID: 10650
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAnchored__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x0400299B RID: 10651
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetCanCollide__Boolean_Protected_Void_Boolean_0;

		// Token: 0x0400299C RID: 10652
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetCanCollide__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x0400299D RID: 10653
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetSpawn__Boolean_Protected_Void_Boolean_0;

		// Token: 0x0400299E RID: 10654
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetSpawn__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x0400299F RID: 10655
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetShape__PartShape_Protected_Void_PartShape_0;

		// Token: 0x040029A0 RID: 10656
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetShape__PartShape_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040029A1 RID: 10657
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetMaterial__PartMaterial_Protected_Void_PartMaterial_0;

		// Token: 0x040029A2 RID: 10658
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetMaterial__PartMaterial_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040029A3 RID: 10659
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetDrag__Single_Protected_Void_Single_0;

		// Token: 0x040029A4 RID: 10660
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetDrag__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040029A5 RID: 10661
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAngularDrag__Single_Protected_Void_Single_0;

		// Token: 0x040029A6 RID: 10662
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAngularDrag__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040029A7 RID: 10663
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetUseGravity__Boolean_Protected_Void_Boolean_0;

		// Token: 0x040029A8 RID: 10664
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetUseGravity__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040029A9 RID: 10665
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetBounciness__Single_Protected_Void_Single_0;

		// Token: 0x040029AA RID: 10666
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetBounciness__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040029AB RID: 10667
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetFriction__Single_Protected_Void_Single_0;

		// Token: 0x040029AC RID: 10668
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetFriction__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040029AD RID: 10669
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetFrictionCombine__PhysicsMaterialCombine_Protected_Void_PhysicsMaterialCombine_0;

		// Token: 0x040029AE RID: 10670
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetFrictionCombine__PhysicsMaterialCombine_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040029AF RID: 10671
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetBounceCombine__PhysicsMaterialCombine_Protected_Void_PhysicsMaterialCombine_0;

		// Token: 0x040029B0 RID: 10672
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetBounceCombine__PhysicsMaterialCombine_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040029B1 RID: 10673
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040029B2 RID: 10674
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
