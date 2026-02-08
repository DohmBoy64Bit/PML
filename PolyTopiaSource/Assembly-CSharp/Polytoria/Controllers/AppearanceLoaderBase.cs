using System;
using System.Runtime.InteropServices;
using GLTFast;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using Mirror;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000323 RID: 803
	public class AppearanceLoaderBase : NetworkBehaviour
	{
		// Token: 0x0600448B RID: 17547 RVA: 0x0013322C File Offset: 0x0013142C
		// Note: this type is marked as 'beforefieldinit'.
		static AppearanceLoaderBase()
		{
			Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "AppearanceLoaderBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr);
			AppearanceLoaderBase.NativeFieldInfoPtr_playerAppearanceCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "playerAppearanceCache");
			AppearanceLoaderBase.NativeFieldInfoPtr_headObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "headObj");
			AppearanceLoaderBase.NativeFieldInfoPtr_torsoObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "torsoObj");
			AppearanceLoaderBase.NativeFieldInfoPtr_defaultTorsoMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "defaultTorsoMesh");
			AppearanceLoaderBase.NativeFieldInfoPtr_currentlyLoadingUserID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "currentlyLoadingUserID");
			AppearanceLoaderBase.NativeFieldInfoPtr_headColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "headColor");
			AppearanceLoaderBase.NativeFieldInfoPtr_torsoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "torsoColor");
			AppearanceLoaderBase.NativeFieldInfoPtr_leftArmColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "leftArmColor");
			AppearanceLoaderBase.NativeFieldInfoPtr_rightArmColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "rightArmColor");
			AppearanceLoaderBase.NativeFieldInfoPtr_leftLegColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "leftLegColor");
			AppearanceLoaderBase.NativeFieldInfoPtr_rightLegColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "rightLegColor");
			AppearanceLoaderBase.NativeFieldInfoPtr_faceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "faceID");
			AppearanceLoaderBase.NativeFieldInfoPtr_shirtID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "shirtID");
			AppearanceLoaderBase.NativeFieldInfoPtr_pantsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "pantsID");
			AppearanceLoaderBase.NativeFieldInfoPtr_torsoID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "torsoID");
			AppearanceLoaderBase.NativeFieldInfoPtr_hatUrls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "hatUrls");
			AppearanceLoaderBase.NativeFieldInfoPtr_torsoUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "torsoUrl");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_headColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_headColor");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_torsoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_torsoColor");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_leftArmColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_leftArmColor");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rightArmColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_rightArmColor");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_leftLegColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_leftLegColor");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rightLegColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_rightLegColor");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_faceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_faceID");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shirtID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_shirtID");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_pantsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_pantsID");
			AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_torsoUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_torsoUrl");
			AppearanceLoaderBase.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674146);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674147);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674148);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674149);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674150);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674151);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674152);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674153);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674154);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674155);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674156);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674157);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674158);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674159);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674160);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674161);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674162);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674163);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_TorsoID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674164);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_TorsoID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674165);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkheadColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674186);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkheadColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674187);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworktorsoColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674188);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworktorsoColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674189);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkleftArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674190);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkleftArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674191);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkrightArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674192);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkrightArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674193);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkleftLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674194);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkleftLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674195);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkrightLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674196);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkrightLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674197);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkfaceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674198);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkfaceID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674199);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkshirtID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674200);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkshirtID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674201);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkpantsID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674202);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkpantsID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674203);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworktorsoID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674204);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworktorsoID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674205);
			AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworktorsoUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674206);
			AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworktorsoUrl_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674207);
			AppearanceLoaderBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674183);
			AppearanceLoaderBase.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674166);
			AppearanceLoaderBase.NativeMethodInfoPtr_HatsChanged_Private_Void_Operation_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674167);
			AppearanceLoaderBase.NativeMethodInfoPtr_ColorChanged_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674168);
			AppearanceLoaderBase.NativeMethodInfoPtr_ClothingChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674169);
			AppearanceLoaderBase.NativeMethodInfoPtr_BodyChanged_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674170);
			AppearanceLoaderBase.NativeMethodInfoPtr_UpdateColors_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674171);
			AppearanceLoaderBase.NativeMethodInfoPtr_UpdateClothing_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674172);
			AppearanceLoaderBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674173);
			AppearanceLoaderBase.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674174);
			AppearanceLoaderBase.NativeMethodInfoPtr_ClearAppearance_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674175);
			AppearanceLoaderBase.NativeMethodInfoPtr_ProcessAppearance_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674176);
			AppearanceLoaderBase.NativeMethodInfoPtr_ApplyAppearance_Private_Void_AppearanceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674177);
			AppearanceLoaderBase.NativeMethodInfoPtr_UpdateHats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674178);
			AppearanceLoaderBase.NativeMethodInfoPtr_ApplyHats_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674179);
			AppearanceLoaderBase.NativeMethodInfoPtr_UpdateBodyParts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674180);
			AppearanceLoaderBase.NativeMethodInfoPtr_ApplyBodyParts_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674181);
			AppearanceLoaderBase.NativeMethodInfoPtr_HatLoaded_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674182);
			AppearanceLoaderBase.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674185);
			AppearanceLoaderBase.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674208);
			AppearanceLoaderBase.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, 100674209);
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x0600448C RID: 17548 RVA: 0x00133964 File Offset: 0x00131B64
		// (set) Token: 0x0600448D RID: 17549 RVA: 0x001339A4 File Offset: 0x00131BA4
		public unsafe Color HeadColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131346, RefRangeEnd = 131350, XrefRangeStart = 131343, XrefRangeEnd = 131346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x0600448E RID: 17550 RVA: 0x001339E8 File Offset: 0x00131BE8
		// (set) Token: 0x0600448F RID: 17551 RVA: 0x00133A28 File Offset: 0x00131C28
		public unsafe Color TorsoColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131353, RefRangeEnd = 131357, XrefRangeStart = 131350, XrefRangeEnd = 131353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x00133A6C File Offset: 0x00131C6C
		// (set) Token: 0x06004491 RID: 17553 RVA: 0x00133AAC File Offset: 0x00131CAC
		public unsafe Color LeftArmColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131360, RefRangeEnd = 131364, XrefRangeStart = 131357, XrefRangeEnd = 131360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x00133AF0 File Offset: 0x00131CF0
		// (set) Token: 0x06004493 RID: 17555 RVA: 0x00133B30 File Offset: 0x00131D30
		public unsafe Color RightArmColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131367, RefRangeEnd = 131371, XrefRangeStart = 131364, XrefRangeEnd = 131367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06004494 RID: 17556 RVA: 0x00133B74 File Offset: 0x00131D74
		// (set) Token: 0x06004495 RID: 17557 RVA: 0x00133BB4 File Offset: 0x00131DB4
		public unsafe Color LeftLegColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131374, RefRangeEnd = 131378, XrefRangeStart = 131371, XrefRangeEnd = 131374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x00133BF8 File Offset: 0x00131DF8
		// (set) Token: 0x06004497 RID: 17559 RVA: 0x00133C38 File Offset: 0x00131E38
		public unsafe Color RightLegColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 131381, RefRangeEnd = 131384, XrefRangeStart = 131378, XrefRangeEnd = 131381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06004498 RID: 17560 RVA: 0x00133C7C File Offset: 0x00131E7C
		// (set) Token: 0x06004499 RID: 17561 RVA: 0x00133CB8 File Offset: 0x00131EB8
		public unsafe int FaceID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59929, RefRangeEnd = 59932, XrefRangeStart = 59929, XrefRangeEnd = 59932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 131387, RefRangeEnd = 131389, XrefRangeStart = 131384, XrefRangeEnd = 131387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x0600449A RID: 17562 RVA: 0x00133CF8 File Offset: 0x00131EF8
		// (set) Token: 0x0600449B RID: 17563 RVA: 0x00133D34 File Offset: 0x00131F34
		public unsafe int ShirtID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 131392, RefRangeEnd = 131394, XrefRangeStart = 131389, XrefRangeEnd = 131392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x0600449C RID: 17564 RVA: 0x00133D74 File Offset: 0x00131F74
		// (set) Token: 0x0600449D RID: 17565 RVA: 0x00133DB0 File Offset: 0x00131FB0
		public unsafe int PantsID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 131397, RefRangeEnd = 131399, XrefRangeStart = 131394, XrefRangeEnd = 131397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x0600449E RID: 17566 RVA: 0x00133DF0 File Offset: 0x00131FF0
		// (set) Token: 0x0600449F RID: 17567 RVA: 0x00133E2C File Offset: 0x0013202C
		public unsafe int TorsoID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_TorsoID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131399, XrefRangeEnd = 131405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_TorsoID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x060044A0 RID: 17568 RVA: 0x00133E6C File Offset: 0x0013206C
		// (set) Token: 0x060044A1 RID: 17569 RVA: 0x00133EAC File Offset: 0x001320AC
		public unsafe Color NetworkheadColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkheadColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131346, RefRangeEnd = 131350, XrefRangeStart = 131346, XrefRangeEnd = 131350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkheadColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x060044A2 RID: 17570 RVA: 0x00133EF0 File Offset: 0x001320F0
		// (set) Token: 0x060044A3 RID: 17571 RVA: 0x00133F30 File Offset: 0x00132130
		public unsafe Color NetworktorsoColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworktorsoColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131353, RefRangeEnd = 131357, XrefRangeStart = 131353, XrefRangeEnd = 131357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworktorsoColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x060044A4 RID: 17572 RVA: 0x00133F74 File Offset: 0x00132174
		// (set) Token: 0x060044A5 RID: 17573 RVA: 0x00133FB4 File Offset: 0x001321B4
		public unsafe Color NetworkleftArmColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkleftArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131360, RefRangeEnd = 131364, XrefRangeStart = 131360, XrefRangeEnd = 131364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkleftArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x00133FF8 File Offset: 0x001321F8
		// (set) Token: 0x060044A7 RID: 17575 RVA: 0x00134038 File Offset: 0x00132238
		public unsafe Color NetworkrightArmColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkrightArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131367, RefRangeEnd = 131371, XrefRangeStart = 131367, XrefRangeEnd = 131371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkrightArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x0013407C File Offset: 0x0013227C
		// (set) Token: 0x060044A9 RID: 17577 RVA: 0x001340BC File Offset: 0x001322BC
		public unsafe Color NetworkleftLegColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkleftLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 131374, RefRangeEnd = 131378, XrefRangeStart = 131374, XrefRangeEnd = 131378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkleftLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x00134100 File Offset: 0x00132300
		// (set) Token: 0x060044AB RID: 17579 RVA: 0x00134140 File Offset: 0x00132340
		public unsafe Color NetworkrightLegColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkrightLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 131381, RefRangeEnd = 131384, XrefRangeStart = 131381, XrefRangeEnd = 131384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkrightLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x00134184 File Offset: 0x00132384
		// (set) Token: 0x060044AD RID: 17581 RVA: 0x001341C0 File Offset: 0x001323C0
		public unsafe int NetworkfaceID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59929, RefRangeEnd = 59932, XrefRangeStart = 59929, XrefRangeEnd = 59932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkfaceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 131387, RefRangeEnd = 131389, XrefRangeStart = 131387, XrefRangeEnd = 131389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkfaceID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x00134200 File Offset: 0x00132400
		// (set) Token: 0x060044AF RID: 17583 RVA: 0x0013423C File Offset: 0x0013243C
		public unsafe int NetworkshirtID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkshirtID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 131392, RefRangeEnd = 131394, XrefRangeStart = 131392, XrefRangeEnd = 131394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkshirtID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x060044B0 RID: 17584 RVA: 0x0013427C File Offset: 0x0013247C
		// (set) Token: 0x060044B1 RID: 17585 RVA: 0x001342B8 File Offset: 0x001324B8
		public unsafe int NetworkpantsID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworkpantsID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 131397, RefRangeEnd = 131399, XrefRangeStart = 131397, XrefRangeEnd = 131399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworkpantsID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x060044B2 RID: 17586 RVA: 0x001342F8 File Offset: 0x001324F8
		// (set) Token: 0x060044B3 RID: 17587 RVA: 0x00134334 File Offset: 0x00132534
		public unsafe int NetworktorsoID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworktorsoID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworktorsoID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x060044B4 RID: 17588 RVA: 0x00134374 File Offset: 0x00132574
		// (set) Token: 0x060044B5 RID: 17589 RVA: 0x001343AC File Offset: 0x001325AC
		public unsafe string NetworktorsoUrl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_get_NetworktorsoUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131405, XrefRangeEnd = 131417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_set_NetworktorsoUrl_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x001343F0 File Offset: 0x001325F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131484, RefRangeEnd = 131486, XrefRangeStart = 131417, XrefRangeEnd = 131484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppearanceLoaderBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x0013442C File Offset: 0x0013262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131486, XrefRangeEnd = 131504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceLoaderBase.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x00134468 File Offset: 0x00132668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131504, XrefRangeEnd = 131506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HatsChanged(SyncList<string>.Operation op, int itemIndex, string oldItem, string newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldItem);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_HatsChanged_Private_Void_Operation_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x001344E0 File Offset: 0x001326E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131506, XrefRangeEnd = 131507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorChanged(Color oldColor, Color newColor)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_ColorChanged_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00134534 File Offset: 0x00132734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131507, XrefRangeEnd = 131508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClothingChanged(int oldClothing, int newClothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldClothing;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newClothing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_ClothingChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x00134580 File Offset: 0x00132780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131508, XrefRangeEnd = 131510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyChanged(string oldBody, string newBody)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldBody);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newBody);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_BodyChanged_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x001345D4 File Offset: 0x001327D4
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceLoaderBase.NativeMethodInfoPtr_UpdateColors_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x00134610 File Offset: 0x00132810
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateClothing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceLoaderBase.NativeMethodInfoPtr_UpdateClothing_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x0013464C File Offset: 0x0013284C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceLoaderBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x00134688 File Offset: 0x00132888
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131517, RefRangeEnd = 131521, XrefRangeStart = 131510, XrefRangeEnd = 131517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAppearance(int userID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x001346C8 File Offset: 0x001328C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131549, RefRangeEnd = 131551, XrefRangeStart = 131521, XrefRangeEnd = 131549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceLoaderBase.NativeMethodInfoPtr_ClearAppearance_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00134704 File Offset: 0x00132904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131551, XrefRangeEnd = 131556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessAppearance(int userID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_ProcessAppearance_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x00134750 File Offset: 0x00132950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131613, RefRangeEnd = 131615, XrefRangeStart = 131556, XrefRangeEnd = 131613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAppearance(AppearanceData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_ApplyAppearance_Private_Void_AppearanceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x00134794 File Offset: 0x00132994
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131626, RefRangeEnd = 131629, XrefRangeStart = 131615, XrefRangeEnd = 131626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_UpdateHats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x001347C8 File Offset: 0x001329C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131629, XrefRangeEnd = 131634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ApplyHats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_ApplyHats_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00134808 File Offset: 0x00132A08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131645, RefRangeEnd = 131647, XrefRangeStart = 131634, XrefRangeEnd = 131645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBodyParts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_UpdateBodyParts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x0013483C File Offset: 0x00132A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131647, XrefRangeEnd = 131652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ApplyBodyParts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase.NativeMethodInfoPtr_ApplyBodyParts_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x0013487C File Offset: 0x00132A7C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HatLoaded(GameObject hat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceLoaderBase.NativeMethodInfoPtr_HatLoaded_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x001348CC File Offset: 0x00132ACC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceLoaderBase.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00134914 File Offset: 0x00132B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131652, XrefRangeEnd = 131676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceLoaderBase.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x00134970 File Offset: 0x00132B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131676, XrefRangeEnd = 131745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearanceLoaderBase.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x000193E4 File Offset: 0x000175E4
		public AppearanceLoaderBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x001349CC File Offset: 0x00132BCC
		// (set) Token: 0x060044CD RID: 17613 RVA: 0x000193ED File Offset: 0x000175ED
		public unsafe static Dictionary<int, AppearanceData> playerAppearanceCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppearanceLoaderBase.NativeFieldInfoPtr_playerAppearanceCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, AppearanceData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppearanceLoaderBase.NativeFieldInfoPtr_playerAppearanceCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x001349F4 File Offset: 0x00132BF4
		// (set) Token: 0x060044CF RID: 17615 RVA: 0x000193FF File Offset: 0x000175FF
		public unsafe Transform headObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_headObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_headObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x00134A24 File Offset: 0x00132C24
		// (set) Token: 0x060044D1 RID: 17617 RVA: 0x0001941E File Offset: 0x0001761E
		public unsafe Transform torsoObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_torsoObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_torsoObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x00134A54 File Offset: 0x00132C54
		// (set) Token: 0x060044D3 RID: 17619 RVA: 0x0001943D File Offset: 0x0001763D
		public unsafe Mesh defaultTorsoMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_defaultTorsoMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_defaultTorsoMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x00134A84 File Offset: 0x00132C84
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x0001945C File Offset: 0x0001765C
		public unsafe int currentlyLoadingUserID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_currentlyLoadingUserID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_currentlyLoadingUserID)) = value;
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x00134AAC File Offset: 0x00132CAC
		// (set) Token: 0x060044D7 RID: 17623 RVA: 0x00019477 File Offset: 0x00017677
		public unsafe Color headColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_headColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_headColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x00134ADC File Offset: 0x00132CDC
		// (set) Token: 0x060044D9 RID: 17625 RVA: 0x00019496 File Offset: 0x00017696
		public unsafe Color torsoColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_torsoColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_torsoColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x00134B0C File Offset: 0x00132D0C
		// (set) Token: 0x060044DB RID: 17627 RVA: 0x000194B5 File Offset: 0x000176B5
		public unsafe Color leftArmColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_leftArmColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_leftArmColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x00134B3C File Offset: 0x00132D3C
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x000194D4 File Offset: 0x000176D4
		public unsafe Color rightArmColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_rightArmColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_rightArmColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x00134B6C File Offset: 0x00132D6C
		// (set) Token: 0x060044DF RID: 17631 RVA: 0x000194F3 File Offset: 0x000176F3
		public unsafe Color leftLegColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_leftLegColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_leftLegColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x00134B9C File Offset: 0x00132D9C
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x00019512 File Offset: 0x00017712
		public unsafe Color rightLegColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_rightLegColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_rightLegColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x00134BCC File Offset: 0x00132DCC
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x00019531 File Offset: 0x00017731
		public unsafe int faceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_faceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_faceID)) = value;
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x00134BF4 File Offset: 0x00132DF4
		// (set) Token: 0x060044E5 RID: 17637 RVA: 0x0001954C File Offset: 0x0001774C
		public unsafe int shirtID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_shirtID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_shirtID)) = value;
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x00134C1C File Offset: 0x00132E1C
		// (set) Token: 0x060044E7 RID: 17639 RVA: 0x00019567 File Offset: 0x00017767
		public unsafe int pantsID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_pantsID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_pantsID)) = value;
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x00134C44 File Offset: 0x00132E44
		// (set) Token: 0x060044E9 RID: 17641 RVA: 0x00019582 File Offset: 0x00017782
		public unsafe int torsoID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_torsoID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_torsoID)) = value;
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x00134C6C File Offset: 0x00132E6C
		// (set) Token: 0x060044EB RID: 17643 RVA: 0x0001959D File Offset: 0x0001779D
		public unsafe SyncList<string> hatUrls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_hatUrls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_hatUrls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x00134C9C File Offset: 0x00132E9C
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x000195BC File Offset: 0x000177BC
		public unsafe string torsoUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_torsoUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr_torsoUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x00134CC4 File Offset: 0x00132EC4
		// (set) Token: 0x060044EF RID: 17647 RVA: 0x000195DB File Offset: 0x000177DB
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_headColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_headColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_headColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x00134CF4 File Offset: 0x00132EF4
		// (set) Token: 0x060044F1 RID: 17649 RVA: 0x000195FA File Offset: 0x000177FA
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_torsoColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_torsoColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_torsoColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x00134D24 File Offset: 0x00132F24
		// (set) Token: 0x060044F3 RID: 17651 RVA: 0x00019619 File Offset: 0x00017819
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_leftArmColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_leftArmColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_leftArmColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x00134D54 File Offset: 0x00132F54
		// (set) Token: 0x060044F5 RID: 17653 RVA: 0x00019638 File Offset: 0x00017838
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_rightArmColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rightArmColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rightArmColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x00134D84 File Offset: 0x00132F84
		// (set) Token: 0x060044F7 RID: 17655 RVA: 0x00019657 File Offset: 0x00017857
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_leftLegColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_leftLegColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_leftLegColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x00134DB4 File Offset: 0x00132FB4
		// (set) Token: 0x060044F9 RID: 17657 RVA: 0x00019676 File Offset: 0x00017876
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_rightLegColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rightLegColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rightLegColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x00134DE4 File Offset: 0x00132FE4
		// (set) Token: 0x060044FB RID: 17659 RVA: 0x00019695 File Offset: 0x00017895
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_faceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_faceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_faceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x00134E14 File Offset: 0x00133014
		// (set) Token: 0x060044FD RID: 17661 RVA: 0x000196B4 File Offset: 0x000178B4
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_shirtID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shirtID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shirtID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x00134E44 File Offset: 0x00133044
		// (set) Token: 0x060044FF RID: 17663 RVA: 0x000196D3 File Offset: 0x000178D3
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_pantsID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_pantsID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_pantsID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06004500 RID: 17664 RVA: 0x00134E74 File Offset: 0x00133074
		// (set) Token: 0x06004501 RID: 17665 RVA: 0x000196F2 File Offset: 0x000178F2
		public unsafe Action<string, string> _Mirror_SyncVarHookDelegate_torsoUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_torsoUrl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_torsoUrl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400354E RID: 13646
		private static readonly IntPtr NativeFieldInfoPtr_playerAppearanceCache;

		// Token: 0x0400354F RID: 13647
		private static readonly IntPtr NativeFieldInfoPtr_headObj;

		// Token: 0x04003550 RID: 13648
		private static readonly IntPtr NativeFieldInfoPtr_torsoObj;

		// Token: 0x04003551 RID: 13649
		private static readonly IntPtr NativeFieldInfoPtr_defaultTorsoMesh;

		// Token: 0x04003552 RID: 13650
		private static readonly IntPtr NativeFieldInfoPtr_currentlyLoadingUserID;

		// Token: 0x04003553 RID: 13651
		private static readonly IntPtr NativeFieldInfoPtr_headColor;

		// Token: 0x04003554 RID: 13652
		private static readonly IntPtr NativeFieldInfoPtr_torsoColor;

		// Token: 0x04003555 RID: 13653
		private static readonly IntPtr NativeFieldInfoPtr_leftArmColor;

		// Token: 0x04003556 RID: 13654
		private static readonly IntPtr NativeFieldInfoPtr_rightArmColor;

		// Token: 0x04003557 RID: 13655
		private static readonly IntPtr NativeFieldInfoPtr_leftLegColor;

		// Token: 0x04003558 RID: 13656
		private static readonly IntPtr NativeFieldInfoPtr_rightLegColor;

		// Token: 0x04003559 RID: 13657
		private static readonly IntPtr NativeFieldInfoPtr_faceID;

		// Token: 0x0400355A RID: 13658
		private static readonly IntPtr NativeFieldInfoPtr_shirtID;

		// Token: 0x0400355B RID: 13659
		private static readonly IntPtr NativeFieldInfoPtr_pantsID;

		// Token: 0x0400355C RID: 13660
		private static readonly IntPtr NativeFieldInfoPtr_torsoID;

		// Token: 0x0400355D RID: 13661
		private static readonly IntPtr NativeFieldInfoPtr_hatUrls;

		// Token: 0x0400355E RID: 13662
		private static readonly IntPtr NativeFieldInfoPtr_torsoUrl;

		// Token: 0x0400355F RID: 13663
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_headColor;

		// Token: 0x04003560 RID: 13664
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_torsoColor;

		// Token: 0x04003561 RID: 13665
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_leftArmColor;

		// Token: 0x04003562 RID: 13666
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rightArmColor;

		// Token: 0x04003563 RID: 13667
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_leftLegColor;

		// Token: 0x04003564 RID: 13668
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rightLegColor;

		// Token: 0x04003565 RID: 13669
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_faceID;

		// Token: 0x04003566 RID: 13670
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shirtID;

		// Token: 0x04003567 RID: 13671
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_pantsID;

		// Token: 0x04003568 RID: 13672
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_torsoUrl;

		// Token: 0x04003569 RID: 13673
		private static readonly IntPtr NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0;

		// Token: 0x0400356A RID: 13674
		private static readonly IntPtr NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0;

		// Token: 0x0400356B RID: 13675
		private static readonly IntPtr NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0;

		// Token: 0x0400356C RID: 13676
		private static readonly IntPtr NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0;

		// Token: 0x0400356D RID: 13677
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0;

		// Token: 0x0400356E RID: 13678
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0;

		// Token: 0x0400356F RID: 13679
		private static readonly IntPtr NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0;

		// Token: 0x04003570 RID: 13680
		private static readonly IntPtr NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0;

		// Token: 0x04003571 RID: 13681
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0;

		// Token: 0x04003572 RID: 13682
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0;

		// Token: 0x04003573 RID: 13683
		private static readonly IntPtr NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0;

		// Token: 0x04003574 RID: 13684
		private static readonly IntPtr NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0;

		// Token: 0x04003575 RID: 13685
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0;

		// Token: 0x04003576 RID: 13686
		private static readonly IntPtr NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0;

		// Token: 0x04003577 RID: 13687
		private static readonly IntPtr NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0;

		// Token: 0x04003578 RID: 13688
		private static readonly IntPtr NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0;

		// Token: 0x04003579 RID: 13689
		private static readonly IntPtr NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0;

		// Token: 0x0400357A RID: 13690
		private static readonly IntPtr NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0;

		// Token: 0x0400357B RID: 13691
		private static readonly IntPtr NativeMethodInfoPtr_get_TorsoID_Public_get_Int32_0;

		// Token: 0x0400357C RID: 13692
		private static readonly IntPtr NativeMethodInfoPtr_set_TorsoID_Public_set_Void_Int32_0;

		// Token: 0x0400357D RID: 13693
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkheadColor_Public_get_Color_0;

		// Token: 0x0400357E RID: 13694
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkheadColor_Public_set_Void_Color_0;

		// Token: 0x0400357F RID: 13695
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworktorsoColor_Public_get_Color_0;

		// Token: 0x04003580 RID: 13696
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworktorsoColor_Public_set_Void_Color_0;

		// Token: 0x04003581 RID: 13697
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkleftArmColor_Public_get_Color_0;

		// Token: 0x04003582 RID: 13698
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkleftArmColor_Public_set_Void_Color_0;

		// Token: 0x04003583 RID: 13699
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkrightArmColor_Public_get_Color_0;

		// Token: 0x04003584 RID: 13700
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkrightArmColor_Public_set_Void_Color_0;

		// Token: 0x04003585 RID: 13701
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkleftLegColor_Public_get_Color_0;

		// Token: 0x04003586 RID: 13702
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkleftLegColor_Public_set_Void_Color_0;

		// Token: 0x04003587 RID: 13703
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkrightLegColor_Public_get_Color_0;

		// Token: 0x04003588 RID: 13704
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkrightLegColor_Public_set_Void_Color_0;

		// Token: 0x04003589 RID: 13705
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfaceID_Public_get_Int32_0;

		// Token: 0x0400358A RID: 13706
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfaceID_Public_set_Void_Int32_0;

		// Token: 0x0400358B RID: 13707
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkshirtID_Public_get_Int32_0;

		// Token: 0x0400358C RID: 13708
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkshirtID_Public_set_Void_Int32_0;

		// Token: 0x0400358D RID: 13709
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpantsID_Public_get_Int32_0;

		// Token: 0x0400358E RID: 13710
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpantsID_Public_set_Void_Int32_0;

		// Token: 0x0400358F RID: 13711
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworktorsoID_Public_get_Int32_0;

		// Token: 0x04003590 RID: 13712
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworktorsoID_Public_set_Void_Int32_0;

		// Token: 0x04003591 RID: 13713
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworktorsoUrl_Public_get_String_0;

		// Token: 0x04003592 RID: 13714
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworktorsoUrl_Public_set_Void_String_0;

		// Token: 0x04003593 RID: 13715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003594 RID: 13716
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04003595 RID: 13717
		private static readonly IntPtr NativeMethodInfoPtr_HatsChanged_Private_Void_Operation_String_Int32_String_String_0;

		// Token: 0x04003596 RID: 13718
		private static readonly IntPtr NativeMethodInfoPtr_ColorChanged_Private_Void_Color_Color_0;

		// Token: 0x04003597 RID: 13719
		private static readonly IntPtr NativeMethodInfoPtr_ClothingChanged_Private_Void_Int32_Int32_0;

		// Token: 0x04003598 RID: 13720
		private static readonly IntPtr NativeMethodInfoPtr_BodyChanged_Private_Void_String_String_0;

		// Token: 0x04003599 RID: 13721
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColors_Protected_Virtual_New_Void_0;

		// Token: 0x0400359A RID: 13722
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClothing_Protected_Virtual_New_Void_0;

		// Token: 0x0400359B RID: 13723
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400359C RID: 13724
		private static readonly IntPtr NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0;

		// Token: 0x0400359D RID: 13725
		private static readonly IntPtr NativeMethodInfoPtr_ClearAppearance_Public_Virtual_New_Void_0;

		// Token: 0x0400359E RID: 13726
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAppearance_Private_IEnumerator_Int32_0;

		// Token: 0x0400359F RID: 13727
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAppearance_Private_Void_AppearanceData_0;

		// Token: 0x040035A0 RID: 13728
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHats_Private_Void_0;

		// Token: 0x040035A1 RID: 13729
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHats_Private_IEnumerator_0;

		// Token: 0x040035A2 RID: 13730
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBodyParts_Private_Void_0;

		// Token: 0x040035A3 RID: 13731
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBodyParts_Private_IEnumerator_0;

		// Token: 0x040035A4 RID: 13732
		private static readonly IntPtr NativeMethodInfoPtr_HatLoaded_Protected_Virtual_New_Void_GameObject_0;

		// Token: 0x040035A5 RID: 13733
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040035A6 RID: 13734
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040035A7 RID: 13735
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;

		// Token: 0x02000422 RID: 1058
		[ObfuscatedName("Polytoria.Controllers.AppearanceLoaderBase+<ApplyBodyParts>d__62")]
		public sealed class _ApplyBodyParts_d__62 : global::Il2CppSystem.Object
		{
			// Token: 0x06005155 RID: 20821 RVA: 0x0015BE34 File Offset: 0x0015A034
			// Note: this type is marked as 'beforefieldinit'.
			static _ApplyBodyParts_d__62()
			{
				Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "<ApplyBodyParts>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr);
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, "<>1__state");
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, "<>2__current");
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, "<>4__this");
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__go_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, "<go>5__2");
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__gltf_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, "<gltf>5__3");
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, "<t>5__4");
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__task_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, "<task>5__5");
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, 100674213);
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, 100674215);
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, 100674210);
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, 100674211);
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, 100674212);
				AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr, 100674214);
			}

			// Token: 0x17001B74 RID: 7028
			// (get) Token: 0x06005156 RID: 20822 RVA: 0x0015BF64 File Offset: 0x0015A164
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001B75 RID: 7029
			// (get) Token: 0x06005157 RID: 20823 RVA: 0x0015BFA4 File Offset: 0x0015A1A4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005158 RID: 20824 RVA: 0x0015BFE4 File Offset: 0x0015A1E4
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ApplyBodyParts_d__62(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyBodyParts_d__62>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005159 RID: 20825 RVA: 0x0015C02C File Offset: 0x0015A22C
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600515A RID: 20826 RVA: 0x0015C060 File Offset: 0x0015A260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131002, XrefRangeEnd = 131040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600515B RID: 20827 RVA: 0x0015C09C File Offset: 0x0015A29C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131040, XrefRangeEnd = 131045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600515C RID: 20828 RVA: 0x0001F402 File Offset: 0x0001D602
			public _ApplyBodyParts_d__62(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B6D RID: 7021
			// (get) Token: 0x0600515D RID: 20829 RVA: 0x0015C0D0 File Offset: 0x0015A2D0
			// (set) Token: 0x0600515E RID: 20830 RVA: 0x0001F40B File Offset: 0x0001D60B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B6E RID: 7022
			// (get) Token: 0x0600515F RID: 20831 RVA: 0x0015C0F8 File Offset: 0x0015A2F8
			// (set) Token: 0x06005160 RID: 20832 RVA: 0x0001F426 File Offset: 0x0001D626
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B6F RID: 7023
			// (get) Token: 0x06005161 RID: 20833 RVA: 0x0015C128 File Offset: 0x0015A328
			// (set) Token: 0x06005162 RID: 20834 RVA: 0x0001F445 File Offset: 0x0001D645
			public unsafe AppearanceLoaderBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppearanceLoaderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B70 RID: 7024
			// (get) Token: 0x06005163 RID: 20835 RVA: 0x0015C158 File Offset: 0x0015A358
			// (set) Token: 0x06005164 RID: 20836 RVA: 0x0001F464 File Offset: 0x0001D664
			public unsafe GameObject _go_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__go_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__go_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B71 RID: 7025
			// (get) Token: 0x06005165 RID: 20837 RVA: 0x0015C188 File Offset: 0x0015A388
			// (set) Token: 0x06005166 RID: 20838 RVA: 0x0001F483 File Offset: 0x0001D683
			public unsafe GltfImport _gltf_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__gltf_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GltfImport>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__gltf_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B72 RID: 7026
			// (get) Token: 0x06005167 RID: 20839 RVA: 0x0015C1B8 File Offset: 0x0015A3B8
			// (set) Token: 0x06005168 RID: 20840 RVA: 0x0001F4A2 File Offset: 0x0001D6A2
			public unsafe Task<bool> _t_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__t_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__t_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B73 RID: 7027
			// (get) Token: 0x06005169 RID: 20841 RVA: 0x0015C1E8 File Offset: 0x0015A3E8
			// (set) Token: 0x0600516A RID: 20842 RVA: 0x0001F4C1 File Offset: 0x0001D6C1
			public unsafe Task<bool> _task_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__task_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyBodyParts_d__62.NativeFieldInfoPtr__task_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E7D RID: 15997
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E7E RID: 15998
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E7F RID: 15999
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E80 RID: 16000
			private static readonly IntPtr NativeFieldInfoPtr__go_5__2;

			// Token: 0x04003E81 RID: 16001
			private static readonly IntPtr NativeFieldInfoPtr__gltf_5__3;

			// Token: 0x04003E82 RID: 16002
			private static readonly IntPtr NativeFieldInfoPtr__t_5__4;

			// Token: 0x04003E83 RID: 16003
			private static readonly IntPtr NativeFieldInfoPtr__task_5__5;

			// Token: 0x04003E84 RID: 16004
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E85 RID: 16005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E86 RID: 16006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E87 RID: 16007
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E88 RID: 16008
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E89 RID: 16009
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000423 RID: 1059
		[ObfuscatedName("Polytoria.Controllers.AppearanceLoaderBase+<ApplyHats>d__60")]
		public sealed class _ApplyHats_d__60 : global::Il2CppSystem.Object
		{
			// Token: 0x0600516B RID: 20843 RVA: 0x0015C218 File Offset: 0x0015A418
			// Note: this type is marked as 'beforefieldinit'.
			static _ApplyHats_d__60()
			{
				Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "<ApplyHats>d__60");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr);
				AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, "<>1__state");
				AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, "<>2__current");
				AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, "<>4__this");
				AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, "<>7__wrap1");
				AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__url_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, "<url>5__3");
				AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__hat_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, "<hat>5__4");
				AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__gltf_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, "<gltf>5__5");
				AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__t_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, "<t>5__6");
				AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__task_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, "<task>5__7");
				AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, 100674220);
				AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, 100674222);
				AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, 100674216);
				AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, 100674217);
				AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, 100674218);
				AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, 100674219);
				AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr, 100674221);
			}

			// Token: 0x17001B7F RID: 7039
			// (get) Token: 0x0600516C RID: 20844 RVA: 0x0015C384 File Offset: 0x0015A584
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001B80 RID: 7040
			// (get) Token: 0x0600516D RID: 20845 RVA: 0x0015C3C4 File Offset: 0x0015A5C4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600516E RID: 20846 RVA: 0x0015C404 File Offset: 0x0015A604
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ApplyHats_d__60(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppearanceLoaderBase._ApplyHats_d__60>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600516F RID: 20847 RVA: 0x0015C44C File Offset: 0x0015A64C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131045, XrefRangeEnd = 131050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005170 RID: 20848 RVA: 0x0015C480 File Offset: 0x0015A680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131050, XrefRangeEnd = 131151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005171 RID: 20849 RVA: 0x0015C4BC File Offset: 0x0015A6BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131151, XrefRangeEnd = 131154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005172 RID: 20850 RVA: 0x0015C4F0 File Offset: 0x0015A6F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131154, XrefRangeEnd = 131159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ApplyHats_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005173 RID: 20851 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
			public _ApplyHats_d__60(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B76 RID: 7030
			// (get) Token: 0x06005174 RID: 20852 RVA: 0x0015C524 File Offset: 0x0015A724
			// (set) Token: 0x06005175 RID: 20853 RVA: 0x0001F4E9 File Offset: 0x0001D6E9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B77 RID: 7031
			// (get) Token: 0x06005176 RID: 20854 RVA: 0x0015C54C File Offset: 0x0015A74C
			// (set) Token: 0x06005177 RID: 20855 RVA: 0x0001F504 File Offset: 0x0001D704
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B78 RID: 7032
			// (get) Token: 0x06005178 RID: 20856 RVA: 0x0015C57C File Offset: 0x0015A77C
			// (set) Token: 0x06005179 RID: 20857 RVA: 0x0001F523 File Offset: 0x0001D723
			public unsafe AppearanceLoaderBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppearanceLoaderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B79 RID: 7033
			// (get) Token: 0x0600517A RID: 20858 RVA: 0x0015C5AC File Offset: 0x0015A7AC
			// (set) Token: 0x0600517B RID: 20859 RVA: 0x0001F542 File Offset: 0x0001D742
			public unsafe SyncList<string>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncList<string>.Enumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B7A RID: 7034
			// (get) Token: 0x0600517C RID: 20860 RVA: 0x0015C5DC File Offset: 0x0015A7DC
			// (set) Token: 0x0600517D RID: 20861 RVA: 0x0001F561 File Offset: 0x0001D761
			public unsafe string _url_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__url_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__url_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001B7B RID: 7035
			// (get) Token: 0x0600517E RID: 20862 RVA: 0x0015C604 File Offset: 0x0015A804
			// (set) Token: 0x0600517F RID: 20863 RVA: 0x0001F580 File Offset: 0x0001D780
			public unsafe GameObject _hat_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__hat_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__hat_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B7C RID: 7036
			// (get) Token: 0x06005180 RID: 20864 RVA: 0x0015C634 File Offset: 0x0015A834
			// (set) Token: 0x06005181 RID: 20865 RVA: 0x0001F59F File Offset: 0x0001D79F
			public unsafe GltfImport _gltf_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__gltf_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GltfImport>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__gltf_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B7D RID: 7037
			// (get) Token: 0x06005182 RID: 20866 RVA: 0x0015C664 File Offset: 0x0015A864
			// (set) Token: 0x06005183 RID: 20867 RVA: 0x0001F5BE File Offset: 0x0001D7BE
			public unsafe Task<bool> _t_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__t_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__t_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B7E RID: 7038
			// (get) Token: 0x06005184 RID: 20868 RVA: 0x0015C694 File Offset: 0x0015A894
			// (set) Token: 0x06005185 RID: 20869 RVA: 0x0001F5DD File Offset: 0x0001D7DD
			public unsafe Task<bool> _task_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__task_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ApplyHats_d__60.NativeFieldInfoPtr__task_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E8A RID: 16010
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E8B RID: 16011
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E8C RID: 16012
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E8D RID: 16013
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04003E8E RID: 16014
			private static readonly IntPtr NativeFieldInfoPtr__url_5__3;

			// Token: 0x04003E8F RID: 16015
			private static readonly IntPtr NativeFieldInfoPtr__hat_5__4;

			// Token: 0x04003E90 RID: 16016
			private static readonly IntPtr NativeFieldInfoPtr__gltf_5__5;

			// Token: 0x04003E91 RID: 16017
			private static readonly IntPtr NativeFieldInfoPtr__t_5__6;

			// Token: 0x04003E92 RID: 16018
			private static readonly IntPtr NativeFieldInfoPtr__task_5__7;

			// Token: 0x04003E93 RID: 16019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E94 RID: 16020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E95 RID: 16021
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E96 RID: 16022
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E97 RID: 16023
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E98 RID: 16024
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003E99 RID: 16025
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000424 RID: 1060
		[ObfuscatedName("Polytoria.Controllers.AppearanceLoaderBase+<ProcessAppearance>d__57")]
		public sealed class _ProcessAppearance_d__57 : global::Il2CppSystem.Object
		{
			// Token: 0x06005186 RID: 20870 RVA: 0x0015C6C4 File Offset: 0x0015A8C4
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessAppearance_d__57()
			{
				Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppearanceLoaderBase>.NativeClassPtr, "<ProcessAppearance>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr);
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, "<>1__state");
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, "<>2__current");
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, "userID");
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, "<>4__this");
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, "<uwr>5__2");
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, 100674227);
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, 100674229);
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, 100674223);
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, 100674224);
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, 100674225);
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, 100674226);
				AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr, 100674228);
			}

			// Token: 0x17001B86 RID: 7046
			// (get) Token: 0x06005187 RID: 20871 RVA: 0x0015C7E0 File Offset: 0x0015A9E0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001B87 RID: 7047
			// (get) Token: 0x06005188 RID: 20872 RVA: 0x0015C820 File Offset: 0x0015AA20
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005189 RID: 20873 RVA: 0x0015C860 File Offset: 0x0015AA60
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessAppearance_d__57(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppearanceLoaderBase._ProcessAppearance_d__57>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600518A RID: 20874 RVA: 0x0015C8A8 File Offset: 0x0015AAA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131159, XrefRangeEnd = 131164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600518B RID: 20875 RVA: 0x0015C8DC File Offset: 0x0015AADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131164, XrefRangeEnd = 131335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600518C RID: 20876 RVA: 0x0015C918 File Offset: 0x0015AB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131335, XrefRangeEnd = 131338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600518D RID: 20877 RVA: 0x0015C94C File Offset: 0x0015AB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131338, XrefRangeEnd = 131343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearanceLoaderBase._ProcessAppearance_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600518E RID: 20878 RVA: 0x0001F5FC File Offset: 0x0001D7FC
			public _ProcessAppearance_d__57(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B81 RID: 7041
			// (get) Token: 0x0600518F RID: 20879 RVA: 0x0015C980 File Offset: 0x0015AB80
			// (set) Token: 0x06005190 RID: 20880 RVA: 0x0001F605 File Offset: 0x0001D805
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B82 RID: 7042
			// (get) Token: 0x06005191 RID: 20881 RVA: 0x0015C9A8 File Offset: 0x0015ABA8
			// (set) Token: 0x06005192 RID: 20882 RVA: 0x0001F620 File Offset: 0x0001D820
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B83 RID: 7043
			// (get) Token: 0x06005193 RID: 20883 RVA: 0x0015C9D8 File Offset: 0x0015ABD8
			// (set) Token: 0x06005194 RID: 20884 RVA: 0x0001F63F File Offset: 0x0001D83F
			public unsafe int userID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr_userID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr_userID)) = value;
				}
			}

			// Token: 0x17001B84 RID: 7044
			// (get) Token: 0x06005195 RID: 20885 RVA: 0x0015CA00 File Offset: 0x0015AC00
			// (set) Token: 0x06005196 RID: 20886 RVA: 0x0001F65A File Offset: 0x0001D85A
			public unsafe AppearanceLoaderBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppearanceLoaderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B85 RID: 7045
			// (get) Token: 0x06005197 RID: 20887 RVA: 0x0015CA30 File Offset: 0x0015AC30
			// (set) Token: 0x06005198 RID: 20888 RVA: 0x0001F679 File Offset: 0x0001D879
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearanceLoaderBase._ProcessAppearance_d__57.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E9A RID: 16026
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E9B RID: 16027
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E9C RID: 16028
			private static readonly IntPtr NativeFieldInfoPtr_userID;

			// Token: 0x04003E9D RID: 16029
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E9E RID: 16030
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003E9F RID: 16031
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EA0 RID: 16032
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EA1 RID: 16033
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003EA2 RID: 16034
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003EA3 RID: 16035
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003EA4 RID: 16036
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003EA5 RID: 16037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
