using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200000D RID: 13
public class LeanTween : MonoBehaviour
{
	// Token: 0x06000087 RID: 135 RVA: 0x00012468 File Offset: 0x00010668
	// Note: this type is marked as 'beforefieldinit'.
	static LeanTween()
	{
		Il2CppClassPointerStore<LeanTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanTween");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween>.NativeClassPtr);
		LeanTween.NativeFieldInfoPtr_throwErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "throwErrors");
		LeanTween.NativeFieldInfoPtr_tau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tau");
		LeanTween.NativeFieldInfoPtr_PI_DIV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "PI_DIV2");
		LeanTween.NativeFieldInfoPtr_sequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "sequences");
		LeanTween.NativeFieldInfoPtr_tweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tweens");
		LeanTween.NativeFieldInfoPtr_tweensFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tweensFinished");
		LeanTween.NativeFieldInfoPtr_tweensFinishedIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tweensFinishedIds");
		LeanTween.NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tween");
		LeanTween.NativeFieldInfoPtr_tweenMaxSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tweenMaxSearch");
		LeanTween.NativeFieldInfoPtr_maxTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "maxTweens");
		LeanTween.NativeFieldInfoPtr_maxSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "maxSequences");
		LeanTween.NativeFieldInfoPtr_frameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "frameRendered");
		LeanTween.NativeFieldInfoPtr__tweenEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "_tweenEmpty");
		LeanTween.NativeFieldInfoPtr_dtEstimated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "dtEstimated");
		LeanTween.NativeFieldInfoPtr_dtManual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "dtManual");
		LeanTween.NativeFieldInfoPtr_dtActual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "dtActual");
		LeanTween.NativeFieldInfoPtr_global_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "global_counter");
		LeanTween.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "i");
		LeanTween.NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "j");
		LeanTween.NativeFieldInfoPtr_finishedCnt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "finishedCnt");
		LeanTween.NativeFieldInfoPtr_punch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "punch");
		LeanTween.NativeFieldInfoPtr_shake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "shake");
		LeanTween.NativeFieldInfoPtr_maxTweenReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "maxTweenReached");
		LeanTween.NativeFieldInfoPtr_startSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "startSearch");
		LeanTween.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "d");
		LeanTween.NativeFieldInfoPtr_eventListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "eventListeners");
		LeanTween.NativeFieldInfoPtr_goListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "goListeners");
		LeanTween.NativeFieldInfoPtr_eventsMaxSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "eventsMaxSearch");
		LeanTween.NativeFieldInfoPtr_EVENTS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "EVENTS_MAX");
		LeanTween.NativeFieldInfoPtr_LISTENERS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "LISTENERS_MAX");
		LeanTween.NativeFieldInfoPtr_INIT_LISTENERS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "INIT_LISTENERS_MAX");
		LeanTween.NativeMethodInfoPtr_get_maxSearch_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663370);
		LeanTween.NativeMethodInfoPtr_get_maxSimulataneousTweens_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663371);
		LeanTween.NativeMethodInfoPtr_get_tweensRunning_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663372);
		LeanTween.NativeMethodInfoPtr_get_tweenEmpty_Public_Static_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663415);
		LeanTween.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663544);
		LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663369);
		LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663373);
		LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663374);
		LeanTween.NativeMethodInfoPtr_reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663375);
		LeanTween.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663376);
		LeanTween.NativeMethodInfoPtr_onLevelWasLoaded54_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663377);
		LeanTween.NativeMethodInfoPtr_internalOnLevelWasLoaded_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663378);
		LeanTween.NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663379);
		LeanTween.NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663380);
		LeanTween.NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663381);
		LeanTween.NativeMethodInfoPtr_add_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663382);
		LeanTween.NativeMethodInfoPtr_closestRot_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663383);
		LeanTween.NativeMethodInfoPtr_cancelAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663384);
		LeanTween.NativeMethodInfoPtr_cancelAll_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663385);
		LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663386);
		LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663387);
		LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663388);
		LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663389);
		LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_LTRect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663390);
		LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663391);
		LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663392);
		LeanTween.NativeMethodInfoPtr_descr_Public_Static_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663393);
		LeanTween.NativeMethodInfoPtr_description_Public_Static_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663394);
		LeanTween.NativeMethodInfoPtr_descriptions_Public_Static_Il2CppReferenceArray_1_LTDescr_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663395);
		LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663396);
		LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663397);
		LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663398);
		LeanTween.NativeMethodInfoPtr_pauseAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663399);
		LeanTween.NativeMethodInfoPtr_resumeAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663400);
		LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663401);
		LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663402);
		LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663403);
		LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663404);
		LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663405);
		LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663406);
		LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663407);
		LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663408);
		LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663409);
		LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663410);
		LeanTween.NativeMethodInfoPtr_drawBezierPath_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663411);
		LeanTween.NativeMethodInfoPtr_logError_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663412);
		LeanTween.NativeMethodInfoPtr_options_Public_Static_LTDescr_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663413);
		LeanTween.NativeMethodInfoPtr_options_Public_Static_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663414);
		LeanTween.NativeMethodInfoPtr_pushNewTween_Private_Static_LTDescr_GameObject_Vector3_Single_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663416);
		LeanTween.NativeMethodInfoPtr_play_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663417);
		LeanTween.NativeMethodInfoPtr_sequence_Public_Static_LTSeq_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663418);
		LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663419);
		LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_LTRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663420);
		LeanTween.NativeMethodInfoPtr_textAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663421);
		LeanTween.NativeMethodInfoPtr_alphaText_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663422);
		LeanTween.NativeMethodInfoPtr_alphaCanvas_Public_Static_LTDescr_CanvasGroup_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663423);
		LeanTween.NativeMethodInfoPtr_alphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663424);
		LeanTween.NativeMethodInfoPtr_color_Public_Static_LTDescr_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663425);
		LeanTween.NativeMethodInfoPtr_textColor_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663426);
		LeanTween.NativeMethodInfoPtr_colorText_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663427);
		LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663428);
		LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663429);
		LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663430);
		LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663431);
		LeanTween.NativeMethodInfoPtr_destroyAfter_Public_Static_LTDescr_LTRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663432);
		LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663433);
		LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663434);
		LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663435);
		LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663436);
		LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663437);
		LeanTween.NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663438);
		LeanTween.NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663439);
		LeanTween.NativeMethodInfoPtr_moveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663440);
		LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663441);
		LeanTween.NativeMethodInfoPtr_moveMargin_Public_Static_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663442);
		LeanTween.NativeMethodInfoPtr_moveX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663443);
		LeanTween.NativeMethodInfoPtr_moveY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663444);
		LeanTween.NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663445);
		LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663446);
		LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663447);
		LeanTween.NativeMethodInfoPtr_moveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663448);
		LeanTween.NativeMethodInfoPtr_moveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663449);
		LeanTween.NativeMethodInfoPtr_moveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663450);
		LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663451);
		LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663452);
		LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663453);
		LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663454);
		LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_LTRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663455);
		LeanTween.NativeMethodInfoPtr_rotateLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663456);
		LeanTween.NativeMethodInfoPtr_rotateX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663457);
		LeanTween.NativeMethodInfoPtr_rotateY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663458);
		LeanTween.NativeMethodInfoPtr_rotateZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663459);
		LeanTween.NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663460);
		LeanTween.NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663461);
		LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663462);
		LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663463);
		LeanTween.NativeMethodInfoPtr_scaleX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663464);
		LeanTween.NativeMethodInfoPtr_scaleY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663465);
		LeanTween.NativeMethodInfoPtr_scaleZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663466);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663467);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663468);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663469);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663470);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663471);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663472);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663473);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663474);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Color_Object_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663475);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663476);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663477);
		LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663478);
		LeanTween.NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663479);
		LeanTween.NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_GameObject_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663480);
		LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663481);
		LeanTween.NativeMethodInfoPtr_moveX_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663482);
		LeanTween.NativeMethodInfoPtr_moveY_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663483);
		LeanTween.NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663484);
		LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663485);
		LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663486);
		LeanTween.NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663487);
		LeanTween.NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663488);
		LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663489);
		LeanTween.NativeMethodInfoPtr_size_Public_Static_LTDescr_RectTransform_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663490);
		LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663491);
		LeanTween.NativeMethodInfoPtr_color_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663492);
		LeanTween.NativeMethodInfoPtr_tweenOnCurve_Public_Static_Single_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663493);
		LeanTween.NativeMethodInfoPtr_tweenOnCurveVector_Public_Static_Vector3_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663494);
		LeanTween.NativeMethodInfoPtr_easeOutQuadOpt_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663495);
		LeanTween.NativeMethodInfoPtr_easeInQuadOpt_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663496);
		LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663497);
		LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663498);
		LeanTween.NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663499);
		LeanTween.NativeMethodInfoPtr_clerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663500);
		LeanTween.NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663501);
		LeanTween.NativeMethodInfoPtr_easeInQuad_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663502);
		LeanTween.NativeMethodInfoPtr_easeOutQuad_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663503);
		LeanTween.NativeMethodInfoPtr_easeInOutQuad_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663504);
		LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt2_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663505);
		LeanTween.NativeMethodInfoPtr_easeInCubic_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663506);
		LeanTween.NativeMethodInfoPtr_easeOutCubic_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663507);
		LeanTween.NativeMethodInfoPtr_easeInOutCubic_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663508);
		LeanTween.NativeMethodInfoPtr_easeInQuart_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663509);
		LeanTween.NativeMethodInfoPtr_easeOutQuart_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663510);
		LeanTween.NativeMethodInfoPtr_easeInOutQuart_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663511);
		LeanTween.NativeMethodInfoPtr_easeInQuint_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663512);
		LeanTween.NativeMethodInfoPtr_easeOutQuint_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663513);
		LeanTween.NativeMethodInfoPtr_easeInOutQuint_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663514);
		LeanTween.NativeMethodInfoPtr_easeInSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663515);
		LeanTween.NativeMethodInfoPtr_easeOutSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663516);
		LeanTween.NativeMethodInfoPtr_easeInOutSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663517);
		LeanTween.NativeMethodInfoPtr_easeInExpo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663518);
		LeanTween.NativeMethodInfoPtr_easeOutExpo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663519);
		LeanTween.NativeMethodInfoPtr_easeInOutExpo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663520);
		LeanTween.NativeMethodInfoPtr_easeInCirc_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663521);
		LeanTween.NativeMethodInfoPtr_easeOutCirc_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663522);
		LeanTween.NativeMethodInfoPtr_easeInOutCirc_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663523);
		LeanTween.NativeMethodInfoPtr_easeInBounce_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663524);
		LeanTween.NativeMethodInfoPtr_easeOutBounce_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663525);
		LeanTween.NativeMethodInfoPtr_easeInOutBounce_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663526);
		LeanTween.NativeMethodInfoPtr_easeInBack_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663527);
		LeanTween.NativeMethodInfoPtr_easeOutBack_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663528);
		LeanTween.NativeMethodInfoPtr_easeInOutBack_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663529);
		LeanTween.NativeMethodInfoPtr_easeInElastic_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663530);
		LeanTween.NativeMethodInfoPtr_easeOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663531);
		LeanTween.NativeMethodInfoPtr_easeInOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663532);
		LeanTween.NativeMethodInfoPtr_followDamp_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663533);
		LeanTween.NativeMethodInfoPtr_followSpring_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663534);
		LeanTween.NativeMethodInfoPtr_followBounceOut_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663535);
		LeanTween.NativeMethodInfoPtr_followLinear_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663536);
		LeanTween.NativeMethodInfoPtr_addListener_Public_Static_Void_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663537);
		LeanTween.NativeMethodInfoPtr_addListener_Public_Static_Void_GameObject_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663538);
		LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663539);
		LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663540);
		LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_GameObject_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663541);
		LeanTween.NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663542);
		LeanTween.NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663543);
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000088 RID: 136 RVA: 0x000134C4 File Offset: 0x000116C4
	public unsafe static int maxSearch
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10750, XrefRangeEnd = 10754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_get_maxSearch_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000089 RID: 137 RVA: 0x000134F4 File Offset: 0x000116F4
	public unsafe static int maxSimulataneousTweens
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10754, XrefRangeEnd = 10758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_get_maxSimulataneousTweens_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600008A RID: 138 RVA: 0x00013524 File Offset: 0x00011724
	public unsafe static int tweensRunning
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10758, XrefRangeEnd = 10765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_get_tweensRunning_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x0600008B RID: 139 RVA: 0x00013554 File Offset: 0x00011754
	public unsafe static GameObject tweenEmpty
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 10775, RefRangeEnd = 10787, XrefRangeStart = 10765, XrefRangeEnd = 10775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_get_tweenEmpty_Public_Static_get_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00013588 File Offset: 0x00011788
	[CallerCount(61)]
	[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10787, XrefRangeEnd = 10788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeanTween()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000135C4 File Offset: 0x000117C4
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 10858, RefRangeEnd = 10868, XrefRangeStart = 10849, XrefRangeEnd = 10858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000135EC File Offset: 0x000117EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10868, XrefRangeEnd = 10873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init(int maxSimultaneousTweens)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref maxSimultaneousTweens;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00013620 File Offset: 0x00011820
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 10965, RefRangeEnd = 10979, XrefRangeStart = 10873, XrefRangeEnd = 10965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref maxSimultaneousTweens;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSimultaneousSequences;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_init_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00013660 File Offset: 0x00011860
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10979, XrefRangeEnd = 11002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void reset()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_reset_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00013688 File Offset: 0x00011888
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11002, XrefRangeEnd = 11052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x000136BC File Offset: 0x000118BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11052, XrefRangeEnd = 11079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(scene);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_onLevelWasLoaded54_Private_Static_Void_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00013704 File Offset: 0x00011904
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11079, XrefRangeEnd = 11102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void internalOnLevelWasLoaded(int lvl)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref lvl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_internalOnLevelWasLoaded_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00013738 File Offset: 0x00011938
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11175, RefRangeEnd = 11176, XrefRangeStart = 11102, XrefRangeEnd = 11175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_update_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00013760 File Offset: 0x00011960
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11184, RefRangeEnd = 11185, XrefRangeStart = 11176, XrefRangeEnd = 11184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void removeTween(int i, int uniqueId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref i;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uniqueId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000096 RID: 150 RVA: 0x000137A0 File Offset: 0x000119A0
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 11229, RefRangeEnd = 11235, XrefRangeStart = 11185, XrefRangeEnd = 11229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void removeTween(int i)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000137D4 File Offset: 0x000119D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11235, XrefRangeEnd = 11249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> add(Il2CppStructArray<Vector3> a, Vector3 b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_add_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0001382C File Offset: 0x00011A2C
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 11249, RefRangeEnd = 11258, XrefRangeStart = 11249, XrefRangeEnd = 11249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float closestRot(float from, float to)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref from;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_closestRot_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00013878 File Offset: 0x00011A78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11258, XrefRangeEnd = 11262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancelAll()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancelAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000138A0 File Offset: 0x00011AA0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11284, RefRangeEnd = 11287, XrefRangeStart = 11262, XrefRangeEnd = 11284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancelAll(bool callComplete)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref callComplete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancelAll_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600009B RID: 155 RVA: 0x000138D4 File Offset: 0x00011AD4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11291, RefRangeEnd = 11292, XrefRangeStart = 11287, XrefRangeEnd = 11291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(GameObject gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0001390C File Offset: 0x00011B0C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11310, RefRangeEnd = 11313, XrefRangeStart = 11292, XrefRangeEnd = 11310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(GameObject gameObject, bool callOnComplete)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callOnComplete;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00013950 File Offset: 0x00011B50
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11319, RefRangeEnd = 11320, XrefRangeStart = 11313, XrefRangeEnd = 11319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(RectTransform rect)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00013988 File Offset: 0x00011B88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11339, RefRangeEnd = 11340, XrefRangeStart = 11320, XrefRangeEnd = 11339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uniqueId;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callOnComplete;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x000139DC File Offset: 0x00011BDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11340, XrefRangeEnd = 11349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(LTRect ltRect, int uniqueId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uniqueId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_LTRect_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00013A20 File Offset: 0x00011C20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11349, XrefRangeEnd = 11353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(int uniqueId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref uniqueId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00013A54 File Offset: 0x00011C54
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11367, RefRangeEnd = 11370, XrefRangeStart = 11353, XrefRangeEnd = 11367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(int uniqueId, bool callOnComplete)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref uniqueId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callOnComplete;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00013A94 File Offset: 0x00011C94
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11383, RefRangeEnd = 11384, XrefRangeStart = 11370, XrefRangeEnd = 11383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr descr(int uniqueId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref uniqueId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_descr_Public_Static_LTDescr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00013AD4 File Offset: 0x00011CD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11384, XrefRangeEnd = 11388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr description(int uniqueId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref uniqueId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_description_Public_Static_LTDescr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00013B14 File Offset: 0x00011D14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11388, XrefRangeEnd = 11421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<LTDescr> descriptions(GameObject gameObject = null)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_descriptions_Public_Static_Il2CppReferenceArray_1_LTDescr_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LTDescr>>(intPtr3) : null;
		}
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00013B58 File Offset: 0x00011D58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11421, XrefRangeEnd = 11432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void pause(GameObject gameObject, int uniqueId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uniqueId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00013B9C File Offset: 0x00011D9C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11439, RefRangeEnd = 11441, XrefRangeStart = 11432, XrefRangeEnd = 11439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void pause(int uniqueId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref uniqueId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00013BD0 File Offset: 0x00011DD0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11457, RefRangeEnd = 11458, XrefRangeStart = 11441, XrefRangeEnd = 11457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void pause(GameObject gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00013C08 File Offset: 0x00011E08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11458, XrefRangeEnd = 11469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void pauseAll()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pauseAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00013C30 File Offset: 0x00011E30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11469, XrefRangeEnd = 11480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resumeAll()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_resumeAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00013C58 File Offset: 0x00011E58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11480, XrefRangeEnd = 11491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resume(GameObject gameObject, int uniqueId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uniqueId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00013C9C File Offset: 0x00011E9C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11498, RefRangeEnd = 11500, XrefRangeStart = 11491, XrefRangeEnd = 11498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resume(int uniqueId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref uniqueId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00013CD0 File Offset: 0x00011ED0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11516, RefRangeEnd = 11517, XrefRangeStart = 11500, XrefRangeEnd = 11516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resume(GameObject gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00013D08 File Offset: 0x00011F08
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11552, RefRangeEnd = 11553, XrefRangeStart = 11517, XrefRangeEnd = 11552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPaused(GameObject gameObject = null)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00013D4C File Offset: 0x00011F4C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11559, RefRangeEnd = 11560, XrefRangeStart = 11553, XrefRangeEnd = 11559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPaused(RectTransform rect)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00013D90 File Offset: 0x00011F90
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11573, RefRangeEnd = 11575, XrefRangeStart = 11560, XrefRangeEnd = 11573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPaused(int uniqueId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref uniqueId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isPaused_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00013DD0 File Offset: 0x00011FD0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11603, XrefRangeStart = 11575, XrefRangeEnd = 11600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isTweening(GameObject gameObject = null)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00013E14 File Offset: 0x00012014
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11603, XrefRangeEnd = 11609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isTweening(RectTransform rect)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00013E58 File Offset: 0x00012058
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11609, XrefRangeEnd = 11617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isTweening(int uniqueId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref uniqueId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00013E98 File Offset: 0x00012098
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11617, XrefRangeEnd = 11626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isTweening(LTRect ltRect)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_isTweening_Public_Static_Boolean_LTRect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00013EDC File Offset: 0x000120DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11626, XrefRangeEnd = 11627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, Transform arrowTransform = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrowSize;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrowTransform);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_drawBezierPath_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00013F6C File Offset: 0x0001216C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11635, RefRangeEnd = 11638, XrefRangeStart = 11627, XrefRangeEnd = 11635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static global::Il2CppSystem.Object logError(string error)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_logError_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
		}
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00013FB0 File Offset: 0x000121B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11638, XrefRangeEnd = 11644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr options(LTDescr seed)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_options_Public_Static_LTDescr_LTDescr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00013FF4 File Offset: 0x000121F4
	[CallerCount(79)]
	[CachedScanResults(RefRangeStart = 11688, RefRangeEnd = 11767, XrefRangeStart = 11644, XrefRangeEnd = 11688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr options()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_options_Public_Static_LTDescr_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00014028 File Offset: 0x00012228
	[CallerCount(70)]
	[CachedScanResults(RefRangeStart = 11784, RefRangeEnd = 11854, XrefRangeStart = 11767, XrefRangeEnd = 11784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tween);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_pushNewTween_Private_Static_LTDescr_GameObject_Vector3_Single_LTDescr_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x000140A0 File Offset: 0x000122A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11863, RefRangeEnd = 11864, XrefRangeStart = 11854, XrefRangeEnd = 11863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr play(RectTransform rectTransform, Il2CppReferenceArray<Sprite> sprites)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprites);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_play_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x000140F8 File Offset: 0x000122F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11886, RefRangeEnd = 11887, XrefRangeStart = 11864, XrefRangeEnd = 11886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTSeq sequence(bool initSequence = true)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref initSequence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_sequence_Public_Static_LTSeq_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
		}
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00014138 File Offset: 0x00012338
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11897, RefRangeEnd = 11898, XrefRangeStart = 11887, XrefRangeEnd = 11897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00014198 File Offset: 0x00012398
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11898, XrefRangeEnd = 11906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_LTRect_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x000141F8 File Offset: 0x000123F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11906, XrefRangeEnd = 11913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_textAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00014258 File Offset: 0x00012458
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11920, RefRangeEnd = 11921, XrefRangeStart = 11913, XrefRangeEnd = 11920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alphaText_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x000142B8 File Offset: 0x000124B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11928, RefRangeEnd = 11929, XrefRangeStart = 11921, XrefRangeEnd = 11928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alphaCanvas_Public_Static_LTDescr_CanvasGroup_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00014318 File Offset: 0x00012518
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11935, RefRangeEnd = 11936, XrefRangeStart = 11929, XrefRangeEnd = 11935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00014378 File Offset: 0x00012578
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11947, RefRangeEnd = 11948, XrefRangeStart = 11936, XrefRangeEnd = 11947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr color(GameObject gameObject, Color to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_color_Public_Static_LTDescr_GameObject_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x000143DC File Offset: 0x000125DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11948, XrefRangeEnd = 11956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_textColor_Public_Static_LTDescr_RectTransform_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00014440 File Offset: 0x00012640
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11964, RefRangeEnd = 11965, XrefRangeStart = 11956, XrefRangeEnd = 11964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_colorText_Public_Static_LTDescr_RectTransform_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x000144A4 File Offset: 0x000126A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11975, RefRangeEnd = 11976, XrefRangeStart = 11965, XrefRangeEnd = 11975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedCall(float delayTime, Action callback)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delayTime;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x000144F8 File Offset: 0x000126F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11986, RefRangeEnd = 11987, XrefRangeStart = 11976, XrefRangeEnd = 11986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedCall(float delayTime, Action<global::Il2CppSystem.Object> callback)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delayTime;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0001454C File Offset: 0x0001274C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11996, RefRangeEnd = 11998, XrefRangeStart = 11987, XrefRangeEnd = 11996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayTime;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000145B0 File Offset: 0x000127B0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12007, RefRangeEnd = 12009, XrefRangeStart = 11998, XrefRangeEnd = 12007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<global::Il2CppSystem.Object> callback)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayTime;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00014614 File Offset: 0x00012814
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12009, XrefRangeEnd = 12020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_destroyAfter_Public_Static_LTDescr_LTRect_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00014668 File Offset: 0x00012868
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12026, RefRangeEnd = 12029, XrefRangeStart = 12020, XrefRangeEnd = 12026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x000146CC File Offset: 0x000128CC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12037, RefRangeEnd = 12039, XrefRangeStart = 12029, XrefRangeEnd = 12037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00014730 File Offset: 0x00012930
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12080, RefRangeEnd = 12082, XrefRangeStart = 12039, XrefRangeEnd = 12080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00014794 File Offset: 0x00012994
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12109, RefRangeEnd = 12111, XrefRangeStart = 12082, XrefRangeEnd = 12109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000147F8 File Offset: 0x000129F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12138, RefRangeEnd = 12140, XrefRangeStart = 12111, XrefRangeEnd = 12138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTSpline_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0001485C File Offset: 0x00012A5C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12173, RefRangeEnd = 12175, XrefRangeStart = 12140, XrefRangeEnd = 12173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveSpline(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000CF RID: 207 RVA: 0x000148C0 File Offset: 0x00012AC0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12202, RefRangeEnd = 12204, XrefRangeStart = 12175, XrefRangeEnd = 12202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00014924 File Offset: 0x00012B24
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12237, RefRangeEnd = 12239, XrefRangeStart = 12204, XrefRangeEnd = 12237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveSplineLocal(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00014988 File Offset: 0x00012B88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12239, XrefRangeEnd = 12247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_LTRect_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x000149EC File Offset: 0x00012BEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12247, XrefRangeEnd = 12255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveMargin_Public_Static_LTDescr_LTRect_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00014A50 File Offset: 0x00012C50
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 12261, RefRangeEnd = 12265, XrefRangeStart = 12255, XrefRangeEnd = 12261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveX_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00014AB0 File Offset: 0x00012CB0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12271, RefRangeEnd = 12273, XrefRangeStart = 12265, XrefRangeEnd = 12271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveY_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00014B10 File Offset: 0x00012D10
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12279, RefRangeEnd = 12281, XrefRangeStart = 12273, XrefRangeEnd = 12279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00014B70 File Offset: 0x00012D70
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12287, RefRangeEnd = 12289, XrefRangeStart = 12281, XrefRangeEnd = 12287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00014BD4 File Offset: 0x00012DD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12289, XrefRangeEnd = 12330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocal(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00014C38 File Offset: 0x00012E38
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12336, RefRangeEnd = 12338, XrefRangeStart = 12330, XrefRangeEnd = 12336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00014C98 File Offset: 0x00012E98
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12344, RefRangeEnd = 12346, XrefRangeStart = 12338, XrefRangeEnd = 12344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00014CF8 File Offset: 0x00012EF8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12352, RefRangeEnd = 12354, XrefRangeStart = 12346, XrefRangeEnd = 12352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00014D58 File Offset: 0x00012F58
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12381, RefRangeEnd = 12383, XrefRangeStart = 12354, XrefRangeEnd = 12381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00014DBC File Offset: 0x00012FBC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12410, RefRangeEnd = 12412, XrefRangeStart = 12383, XrefRangeEnd = 12410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00014E20 File Offset: 0x00013020
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12412, XrefRangeEnd = 12421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00014E84 File Offset: 0x00013084
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12427, RefRangeEnd = 12430, XrefRangeStart = 12421, XrefRangeEnd = 12427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00014EE8 File Offset: 0x000130E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12430, XrefRangeEnd = 12438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_LTRect_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00014F48 File Offset: 0x00013148
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12438, XrefRangeEnd = 12444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00014FAC File Offset: 0x000131AC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12450, RefRangeEnd = 12452, XrefRangeStart = 12444, XrefRangeEnd = 12450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateX_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0001500C File Offset: 0x0001320C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12458, RefRangeEnd = 12460, XrefRangeStart = 12452, XrefRangeEnd = 12458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateY_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0001506C File Offset: 0x0001326C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12466, RefRangeEnd = 12468, XrefRangeStart = 12460, XrefRangeEnd = 12466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateZ_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x000150CC File Offset: 0x000132CC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12475, RefRangeEnd = 12477, XrefRangeStart = 12468, XrefRangeEnd = 12475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00015140 File Offset: 0x00013340
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12484, RefRangeEnd = 12486, XrefRangeStart = 12477, XrefRangeEnd = 12484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x000151B4 File Offset: 0x000133B4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12492, RefRangeEnd = 12495, XrefRangeStart = 12486, XrefRangeEnd = 12492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00015218 File Offset: 0x00013418
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12495, XrefRangeEnd = 12503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_LTRect_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x0001527C File Offset: 0x0001347C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12509, RefRangeEnd = 12511, XrefRangeStart = 12503, XrefRangeEnd = 12509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scaleX_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x000152DC File Offset: 0x000134DC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12517, RefRangeEnd = 12519, XrefRangeStart = 12511, XrefRangeEnd = 12517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scaleY_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x0001533C File Offset: 0x0001353C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12525, RefRangeEnd = 12527, XrefRangeStart = 12519, XrefRangeEnd = 12525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scaleZ_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x0001539C File Offset: 0x0001359C
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 12534, RefRangeEnd = 12540, XrefRangeStart = 12527, XrefRangeEnd = 12534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0001540C File Offset: 0x0001360C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12548, RefRangeEnd = 12550, XrefRangeStart = 12540, XrefRangeEnd = 12548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(float from, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref from;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00015468 File Offset: 0x00013668
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12558, RefRangeEnd = 12560, XrefRangeStart = 12550, XrefRangeEnd = 12558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x000154E0 File Offset: 0x000136E0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12567, RefRangeEnd = 12569, XrefRangeStart = 12560, XrefRangeEnd = 12567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00015558 File Offset: 0x00013758
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12582, RefRangeEnd = 12584, XrefRangeStart = 12569, XrefRangeEnd = 12582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x000155D0 File Offset: 0x000137D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12593, RefRangeEnd = 12594, XrefRangeStart = 12584, XrefRangeEnd = 12593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00015650 File Offset: 0x00013850
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12603, RefRangeEnd = 12604, XrefRangeStart = 12594, XrefRangeEnd = 12603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdateRatio);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000156D0 File Offset: 0x000138D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12615, RefRangeEnd = 12616, XrefRangeStart = 12604, XrefRangeEnd = 12615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00015758 File Offset: 0x00013958
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12616, XrefRangeEnd = 12627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Action<Color, global::Il2CppSystem.Object> callOnUpdate, Color from, Color to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Color_Object_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x000157E0 File Offset: 0x000139E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12636, RefRangeEnd = 12637, XrefRangeStart = 12627, XrefRangeEnd = 12636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00015868 File Offset: 0x00013A68
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12646, RefRangeEnd = 12647, XrefRangeStart = 12637, XrefRangeEnd = 12646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x000158F0 File Offset: 0x00013AF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12656, RefRangeEnd = 12657, XrefRangeStart = 12647, XrefRangeEnd = 12656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Action<float, global::Il2CppSystem.Object> callOnUpdate, float from, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00015970 File Offset: 0x00013B70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12657, XrefRangeEnd = 12667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_AudioClip_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x000159D4 File Offset: 0x00013BD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12667, XrefRangeEnd = 12676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(audio);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pos);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_GameObject_AudioClip_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00015A4C File Offset: 0x00013C4C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12684, RefRangeEnd = 12685, XrefRangeStart = 12676, XrefRangeEnd = 12684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_move_Public_Static_LTDescr_RectTransform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00015AB0 File Offset: 0x00013CB0
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 12693, RefRangeEnd = 12702, XrefRangeStart = 12685, XrefRangeEnd = 12693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveX_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00015B10 File Offset: 0x00013D10
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 12710, RefRangeEnd = 12718, XrefRangeStart = 12702, XrefRangeEnd = 12710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveY_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00015B70 File Offset: 0x00013D70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12726, RefRangeEnd = 12727, XrefRangeStart = 12718, XrefRangeEnd = 12726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00015BD0 File Offset: 0x00013DD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12727, XrefRangeEnd = 12738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00015C30 File Offset: 0x00013E30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12750, XrefRangeStart = 12738, XrefRangeEnd = 12749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00015C94 File Offset: 0x00013E94
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12759, RefRangeEnd = 12760, XrefRangeStart = 12750, XrefRangeEnd = 12759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00015D08 File Offset: 0x00013F08
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12769, RefRangeEnd = 12770, XrefRangeStart = 12760, XrefRangeEnd = 12769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00015D7C File Offset: 0x00013F7C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12778, RefRangeEnd = 12779, XrefRangeStart = 12770, XrefRangeEnd = 12778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_scale_Public_Static_LTDescr_RectTransform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00015DE0 File Offset: 0x00013FE0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12787, RefRangeEnd = 12789, XrefRangeStart = 12779, XrefRangeEnd = 12787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_size_Public_Static_LTDescr_RectTransform_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00015E44 File Offset: 0x00014044
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12797, RefRangeEnd = 12798, XrefRangeStart = 12789, XrefRangeEnd = 12797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_alpha_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00015EA4 File Offset: 0x000140A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12798, XrefRangeEnd = 12807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_color_Public_Static_LTDescr_RectTransform_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00015F08 File Offset: 0x00014108
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12807, XrefRangeEnd = 12808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tweenDescr);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratioPassed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_tweenOnCurve_Public_Static_Single_LTDescr_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00015F58 File Offset: 0x00014158
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12808, XrefRangeEnd = 12811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tweenDescr);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratioPassed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_tweenOnCurveVector_Public_Static_Vector3_LTDescr_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00015FAC File Offset: 0x000141AC
	[CallerCount(0)]
	public unsafe static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref diff;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratioPassed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutQuadOpt_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00016008 File Offset: 0x00014208
	[CallerCount(0)]
	public unsafe static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref diff;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratioPassed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInQuadOpt_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00016064 File Offset: 0x00014264
	[CallerCount(0)]
	public unsafe static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref diff;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratioPassed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600010A RID: 266 RVA: 0x000160C0 File Offset: 0x000142C0
	[CallerCount(0)]
	public unsafe static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(diff);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratioPassed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00016124 File Offset: 0x00014324
	[CallerCount(0)]
	public unsafe static float linear(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00016180 File Offset: 0x00014380
	[CallerCount(0)]
	public unsafe static float clerp(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_clerp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600010D RID: 269 RVA: 0x000161DC File Offset: 0x000143DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12811, XrefRangeEnd = 12814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float spring(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00016238 File Offset: 0x00014438
	[CallerCount(0)]
	public unsafe static float easeInQuad(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInQuad_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00016294 File Offset: 0x00014494
	[CallerCount(0)]
	public unsafe static float easeOutQuad(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutQuad_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000162F0 File Offset: 0x000144F0
	[CallerCount(0)]
	public unsafe static float easeInOutQuad(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuad_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0001634C File Offset: 0x0001454C
	[CallerCount(0)]
	public unsafe static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref diffBy2;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuadOpt2_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000112 RID: 274 RVA: 0x000163B4 File Offset: 0x000145B4
	[CallerCount(0)]
	public unsafe static float easeInCubic(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInCubic_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00016410 File Offset: 0x00014610
	[CallerCount(0)]
	public unsafe static float easeOutCubic(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutCubic_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0001646C File Offset: 0x0001466C
	[CallerCount(0)]
	public unsafe static float easeInOutCubic(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutCubic_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000115 RID: 277 RVA: 0x000164C8 File Offset: 0x000146C8
	[CallerCount(0)]
	public unsafe static float easeInQuart(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInQuart_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00016524 File Offset: 0x00014724
	[CallerCount(0)]
	public unsafe static float easeOutQuart(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutQuart_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00016580 File Offset: 0x00014780
	[CallerCount(0)]
	public unsafe static float easeInOutQuart(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuart_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000118 RID: 280 RVA: 0x000165DC File Offset: 0x000147DC
	[CallerCount(0)]
	public unsafe static float easeInQuint(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInQuint_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00016638 File Offset: 0x00014838
	[CallerCount(0)]
	public unsafe static float easeOutQuint(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutQuint_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00016694 File Offset: 0x00014894
	[CallerCount(0)]
	public unsafe static float easeInOutQuint(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutQuint_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600011B RID: 283 RVA: 0x000166F0 File Offset: 0x000148F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12814, XrefRangeEnd = 12815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInSine(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInSine_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0001674C File Offset: 0x0001494C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12815, XrefRangeEnd = 12816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutSine(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutSine_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x000167A8 File Offset: 0x000149A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12816, XrefRangeEnd = 12817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutSine(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutSine_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00016804 File Offset: 0x00014A04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12817, XrefRangeEnd = 12818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInExpo(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInExpo_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00016860 File Offset: 0x00014A60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12818, XrefRangeEnd = 12819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutExpo(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutExpo_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000168BC File Offset: 0x00014ABC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12819, XrefRangeEnd = 12822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutExpo(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutExpo_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00016918 File Offset: 0x00014B18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12822, XrefRangeEnd = 12824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInCirc(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInCirc_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00016974 File Offset: 0x00014B74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12824, XrefRangeEnd = 12826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutCirc(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutCirc_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x000169D0 File Offset: 0x00014BD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12826, XrefRangeEnd = 12831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutCirc(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutCirc_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00016A2C File Offset: 0x00014C2C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12835, RefRangeEnd = 12838, XrefRangeStart = 12831, XrefRangeEnd = 12835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInBounce(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInBounce_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00016A88 File Offset: 0x00014C88
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 12838, RefRangeEnd = 12847, XrefRangeStart = 12838, XrefRangeEnd = 12838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutBounce(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutBounce_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00016AE4 File Offset: 0x00014CE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12847, XrefRangeEnd = 12857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutBounce(float start, float end, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutBounce_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00016B40 File Offset: 0x00014D40
	[CallerCount(0)]
	public unsafe static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInBack_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00016BA8 File Offset: 0x00014DA8
	[CallerCount(0)]
	public unsafe static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutBack_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00016C10 File Offset: 0x00014E10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12857, XrefRangeEnd = 12858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutBack_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00016C78 File Offset: 0x00014E78
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12861, RefRangeEnd = 12864, XrefRangeStart = 12858, XrefRangeEnd = 12861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInElastic_Public_Static_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00016CF0 File Offset: 0x00014EF0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12867, RefRangeEnd = 12870, XrefRangeStart = 12864, XrefRangeEnd = 12867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00016D68 File Offset: 0x00014F68
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12877, RefRangeEnd = 12880, XrefRangeStart = 12870, XrefRangeEnd = 12877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overshoot;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_easeInOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00016DE0 File Offset: 0x00014FE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12880, XrefRangeEnd = 12949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr followDamp(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prop);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_followDamp_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00016E64 File Offset: 0x00015064
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12949, XrefRangeEnd = 13018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr followSpring(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prop);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friction;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accelRate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_followSpring_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00016F04 File Offset: 0x00015104
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13018, XrefRangeEnd = 13086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr followBounceOut(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prop);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friction;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accelRate;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitDamping;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_followBounceOut_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00016FB4 File Offset: 0x000151B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13086, XrefRangeEnd = 13154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr followLinear(Transform trans, Transform target, LeanProp prop, float moveSpeed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prop);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_followLinear_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0001702C File Offset: 0x0001522C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13154, XrefRangeEnd = 13159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addListener(int eventId, Action<LTEvent> callback)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_addListener_Public_Static_Void_Int32_Action_1_LTEvent_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00017070 File Offset: 0x00015270
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13226, RefRangeEnd = 13227, XrefRangeStart = 13159, XrefRangeEnd = 13226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(caller);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_addListener_Public_Static_Void_GameObject_Int32_Action_1_LTEvent_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000133 RID: 307 RVA: 0x000170C8 File Offset: 0x000152C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13227, XrefRangeEnd = 13232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_Action_1_LTEvent_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00017118 File Offset: 0x00015318
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13232, XrefRangeEnd = 13239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool removeListener(int eventId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00017158 File Offset: 0x00015358
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13267, RefRangeEnd = 13268, XrefRangeStart = 13239, XrefRangeEnd = 13267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(caller);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventId;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_removeListener_Public_Static_Boolean_GameObject_Int32_Action_1_LTEvent_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000136 RID: 310 RVA: 0x000171BC File Offset: 0x000153BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13268, XrefRangeEnd = 13272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void dispatchEvent(int eventId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000137 RID: 311 RVA: 0x000171F0 File Offset: 0x000153F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13298, RefRangeEnd = 13299, XrefRangeStart = 13272, XrefRangeEnd = 13298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void dispatchEvent(int eventId, global::Il2CppSystem.Object data)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002292 File Offset: 0x00000492
	public LeanTween(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000139 RID: 313 RVA: 0x00017234 File Offset: 0x00015434
	// (set) Token: 0x0600013A RID: 314 RVA: 0x0000229B File Offset: 0x0000049B
	public unsafe static bool throwErrors
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_throwErrors, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_throwErrors, (void*)(&value));
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600013B RID: 315 RVA: 0x00017250 File Offset: 0x00015450
	// (set) Token: 0x0600013C RID: 316 RVA: 0x000022A9 File Offset: 0x000004A9
	public unsafe static float tau
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tau, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tau, (void*)(&value));
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x0600013D RID: 317 RVA: 0x0001726C File Offset: 0x0001546C
	// (set) Token: 0x0600013E RID: 318 RVA: 0x000022B7 File Offset: 0x000004B7
	public unsafe static float PI_DIV2
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_PI_DIV2, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_PI_DIV2, (void*)(&value));
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600013F RID: 319 RVA: 0x00017288 File Offset: 0x00015488
	// (set) Token: 0x06000140 RID: 320 RVA: 0x000022C5 File Offset: 0x000004C5
	public unsafe static Il2CppReferenceArray<LTSeq> sequences
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_sequences, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LTSeq>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_sequences, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000141 RID: 321 RVA: 0x000172B0 File Offset: 0x000154B0
	// (set) Token: 0x06000142 RID: 322 RVA: 0x000022D7 File Offset: 0x000004D7
	public unsafe static Il2CppReferenceArray<LTDescr> tweens
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tweens, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LTDescr>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tweens, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000143 RID: 323 RVA: 0x000172D8 File Offset: 0x000154D8
	// (set) Token: 0x06000144 RID: 324 RVA: 0x000022E9 File Offset: 0x000004E9
	public unsafe static Il2CppStructArray<int> tweensFinished
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tweensFinished, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tweensFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000145 RID: 325 RVA: 0x00017300 File Offset: 0x00015500
	// (set) Token: 0x06000146 RID: 326 RVA: 0x000022FB File Offset: 0x000004FB
	public unsafe static Il2CppStructArray<int> tweensFinishedIds
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tweensFinishedIds, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tweensFinishedIds, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000147 RID: 327 RVA: 0x00017328 File Offset: 0x00015528
	// (set) Token: 0x06000148 RID: 328 RVA: 0x0000230D File Offset: 0x0000050D
	public unsafe static LTDescr tween
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tween, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tween, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000149 RID: 329 RVA: 0x00017350 File Offset: 0x00015550
	// (set) Token: 0x0600014A RID: 330 RVA: 0x0000231F File Offset: 0x0000051F
	public unsafe static int tweenMaxSearch
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_tweenMaxSearch, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_tweenMaxSearch, (void*)(&value));
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x0600014B RID: 331 RVA: 0x0001736C File Offset: 0x0001556C
	// (set) Token: 0x0600014C RID: 332 RVA: 0x0000232D File Offset: 0x0000052D
	public unsafe static int maxTweens
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_maxTweens, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_maxTweens, (void*)(&value));
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x0600014D RID: 333 RVA: 0x00017388 File Offset: 0x00015588
	// (set) Token: 0x0600014E RID: 334 RVA: 0x0000233B File Offset: 0x0000053B
	public unsafe static int maxSequences
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_maxSequences, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_maxSequences, (void*)(&value));
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600014F RID: 335 RVA: 0x000173A4 File Offset: 0x000155A4
	// (set) Token: 0x06000150 RID: 336 RVA: 0x00002349 File Offset: 0x00000549
	public unsafe static int frameRendered
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_frameRendered, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_frameRendered, (void*)(&value));
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000151 RID: 337 RVA: 0x000173C0 File Offset: 0x000155C0
	// (set) Token: 0x06000152 RID: 338 RVA: 0x00002357 File Offset: 0x00000557
	public unsafe static GameObject _tweenEmpty
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr__tweenEmpty, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr__tweenEmpty, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000153 RID: 339 RVA: 0x000173E8 File Offset: 0x000155E8
	// (set) Token: 0x06000154 RID: 340 RVA: 0x00002369 File Offset: 0x00000569
	public unsafe static float dtEstimated
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_dtEstimated, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_dtEstimated, (void*)(&value));
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000155 RID: 341 RVA: 0x00017404 File Offset: 0x00015604
	// (set) Token: 0x06000156 RID: 342 RVA: 0x00002377 File Offset: 0x00000577
	public unsafe static float dtManual
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_dtManual, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_dtManual, (void*)(&value));
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000157 RID: 343 RVA: 0x00017420 File Offset: 0x00015620
	// (set) Token: 0x06000158 RID: 344 RVA: 0x00002385 File Offset: 0x00000585
	public unsafe static float dtActual
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_dtActual, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_dtActual, (void*)(&value));
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000159 RID: 345 RVA: 0x0001743C File Offset: 0x0001563C
	// (set) Token: 0x0600015A RID: 346 RVA: 0x00002393 File Offset: 0x00000593
	public unsafe static uint global_counter
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_global_counter, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_global_counter, (void*)(&value));
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x0600015B RID: 347 RVA: 0x00017458 File Offset: 0x00015658
	// (set) Token: 0x0600015C RID: 348 RVA: 0x000023A1 File Offset: 0x000005A1
	public unsafe static int i
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_i, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_i, (void*)(&value));
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x0600015D RID: 349 RVA: 0x00017474 File Offset: 0x00015674
	// (set) Token: 0x0600015E RID: 350 RVA: 0x000023AF File Offset: 0x000005AF
	public unsafe static int j
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_j, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_j, (void*)(&value));
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x0600015F RID: 351 RVA: 0x00017490 File Offset: 0x00015690
	// (set) Token: 0x06000160 RID: 352 RVA: 0x000023BD File Offset: 0x000005BD
	public unsafe static int finishedCnt
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_finishedCnt, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_finishedCnt, (void*)(&value));
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000161 RID: 353 RVA: 0x000174AC File Offset: 0x000156AC
	// (set) Token: 0x06000162 RID: 354 RVA: 0x000023CB File Offset: 0x000005CB
	public unsafe static AnimationCurve punch
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_punch, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_punch, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000163 RID: 355 RVA: 0x000174D4 File Offset: 0x000156D4
	// (set) Token: 0x06000164 RID: 356 RVA: 0x000023DD File Offset: 0x000005DD
	public unsafe static AnimationCurve shake
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_shake, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_shake, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000165 RID: 357 RVA: 0x000174FC File Offset: 0x000156FC
	// (set) Token: 0x06000166 RID: 358 RVA: 0x000023EF File Offset: 0x000005EF
	public unsafe static int maxTweenReached
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_maxTweenReached, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_maxTweenReached, (void*)(&value));
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000167 RID: 359 RVA: 0x00017518 File Offset: 0x00015718
	// (set) Token: 0x06000168 RID: 360 RVA: 0x000023FD File Offset: 0x000005FD
	public unsafe static int startSearch
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_startSearch, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_startSearch, (void*)(&value));
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000169 RID: 361 RVA: 0x00017534 File Offset: 0x00015734
	// (set) Token: 0x0600016A RID: 362 RVA: 0x0000240B File Offset: 0x0000060B
	public unsafe static LTDescr d
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_d, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_d, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600016B RID: 363 RVA: 0x0001755C File Offset: 0x0001575C
	// (set) Token: 0x0600016C RID: 364 RVA: 0x0000241D File Offset: 0x0000061D
	public unsafe static Il2CppReferenceArray<Action<LTEvent>> eventListeners
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_eventListeners, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Action<LTEvent>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_eventListeners, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600016D RID: 365 RVA: 0x00017584 File Offset: 0x00015784
	// (set) Token: 0x0600016E RID: 366 RVA: 0x0000242F File Offset: 0x0000062F
	public unsafe static Il2CppReferenceArray<GameObject> goListeners
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_goListeners, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_goListeners, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x0600016F RID: 367 RVA: 0x000175AC File Offset: 0x000157AC
	// (set) Token: 0x06000170 RID: 368 RVA: 0x00002441 File Offset: 0x00000641
	public unsafe static int eventsMaxSearch
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_eventsMaxSearch, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_eventsMaxSearch, (void*)(&value));
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000171 RID: 369 RVA: 0x000175C8 File Offset: 0x000157C8
	// (set) Token: 0x06000172 RID: 370 RVA: 0x0000244F File Offset: 0x0000064F
	public unsafe static int EVENTS_MAX
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_EVENTS_MAX, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_EVENTS_MAX, (void*)(&value));
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000173 RID: 371 RVA: 0x000175E4 File Offset: 0x000157E4
	// (set) Token: 0x06000174 RID: 372 RVA: 0x0000245D File Offset: 0x0000065D
	public unsafe static int LISTENERS_MAX
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_LISTENERS_MAX, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_LISTENERS_MAX, (void*)(&value));
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000175 RID: 373 RVA: 0x00017600 File Offset: 0x00015800
	// (set) Token: 0x06000176 RID: 374 RVA: 0x0000246B File Offset: 0x0000066B
	public unsafe static int INIT_LISTENERS_MAX
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTween.NativeFieldInfoPtr_INIT_LISTENERS_MAX, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTween.NativeFieldInfoPtr_INIT_LISTENERS_MAX, (void*)(&value));
		}
	}

	// Token: 0x040000C3 RID: 195
	private static readonly IntPtr NativeFieldInfoPtr_throwErrors;

	// Token: 0x040000C4 RID: 196
	private static readonly IntPtr NativeFieldInfoPtr_tau;

	// Token: 0x040000C5 RID: 197
	private static readonly IntPtr NativeFieldInfoPtr_PI_DIV2;

	// Token: 0x040000C6 RID: 198
	private static readonly IntPtr NativeFieldInfoPtr_sequences;

	// Token: 0x040000C7 RID: 199
	private static readonly IntPtr NativeFieldInfoPtr_tweens;

	// Token: 0x040000C8 RID: 200
	private static readonly IntPtr NativeFieldInfoPtr_tweensFinished;

	// Token: 0x040000C9 RID: 201
	private static readonly IntPtr NativeFieldInfoPtr_tweensFinishedIds;

	// Token: 0x040000CA RID: 202
	private static readonly IntPtr NativeFieldInfoPtr_tween;

	// Token: 0x040000CB RID: 203
	private static readonly IntPtr NativeFieldInfoPtr_tweenMaxSearch;

	// Token: 0x040000CC RID: 204
	private static readonly IntPtr NativeFieldInfoPtr_maxTweens;

	// Token: 0x040000CD RID: 205
	private static readonly IntPtr NativeFieldInfoPtr_maxSequences;

	// Token: 0x040000CE RID: 206
	private static readonly IntPtr NativeFieldInfoPtr_frameRendered;

	// Token: 0x040000CF RID: 207
	private static readonly IntPtr NativeFieldInfoPtr__tweenEmpty;

	// Token: 0x040000D0 RID: 208
	private static readonly IntPtr NativeFieldInfoPtr_dtEstimated;

	// Token: 0x040000D1 RID: 209
	private static readonly IntPtr NativeFieldInfoPtr_dtManual;

	// Token: 0x040000D2 RID: 210
	private static readonly IntPtr NativeFieldInfoPtr_dtActual;

	// Token: 0x040000D3 RID: 211
	private static readonly IntPtr NativeFieldInfoPtr_global_counter;

	// Token: 0x040000D4 RID: 212
	private static readonly IntPtr NativeFieldInfoPtr_i;

	// Token: 0x040000D5 RID: 213
	private static readonly IntPtr NativeFieldInfoPtr_j;

	// Token: 0x040000D6 RID: 214
	private static readonly IntPtr NativeFieldInfoPtr_finishedCnt;

	// Token: 0x040000D7 RID: 215
	private static readonly IntPtr NativeFieldInfoPtr_punch;

	// Token: 0x040000D8 RID: 216
	private static readonly IntPtr NativeFieldInfoPtr_shake;

	// Token: 0x040000D9 RID: 217
	private static readonly IntPtr NativeFieldInfoPtr_maxTweenReached;

	// Token: 0x040000DA RID: 218
	private static readonly IntPtr NativeFieldInfoPtr_startSearch;

	// Token: 0x040000DB RID: 219
	private static readonly IntPtr NativeFieldInfoPtr_d;

	// Token: 0x040000DC RID: 220
	private static readonly IntPtr NativeFieldInfoPtr_eventListeners;

	// Token: 0x040000DD RID: 221
	private static readonly IntPtr NativeFieldInfoPtr_goListeners;

	// Token: 0x040000DE RID: 222
	private static readonly IntPtr NativeFieldInfoPtr_eventsMaxSearch;

	// Token: 0x040000DF RID: 223
	private static readonly IntPtr NativeFieldInfoPtr_EVENTS_MAX;

	// Token: 0x040000E0 RID: 224
	private static readonly IntPtr NativeFieldInfoPtr_LISTENERS_MAX;

	// Token: 0x040000E1 RID: 225
	private static readonly IntPtr NativeFieldInfoPtr_INIT_LISTENERS_MAX;

	// Token: 0x040000E2 RID: 226
	private static readonly IntPtr NativeMethodInfoPtr_get_maxSearch_Public_Static_get_Int32_0;

	// Token: 0x040000E3 RID: 227
	private static readonly IntPtr NativeMethodInfoPtr_get_maxSimulataneousTweens_Public_Static_get_Int32_0;

	// Token: 0x040000E4 RID: 228
	private static readonly IntPtr NativeMethodInfoPtr_get_tweensRunning_Public_Static_get_Int32_0;

	// Token: 0x040000E5 RID: 229
	private static readonly IntPtr NativeMethodInfoPtr_get_tweenEmpty_Public_Static_get_GameObject_0;

	// Token: 0x040000E6 RID: 230
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040000E7 RID: 231
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	// Token: 0x040000E8 RID: 232
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Static_Void_Int32_0;

	// Token: 0x040000E9 RID: 233
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Static_Void_Int32_Int32_0;

	// Token: 0x040000EA RID: 234
	private static readonly IntPtr NativeMethodInfoPtr_reset_Public_Static_Void_0;

	// Token: 0x040000EB RID: 235
	private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	// Token: 0x040000EC RID: 236
	private static readonly IntPtr NativeMethodInfoPtr_onLevelWasLoaded54_Private_Static_Void_Scene_LoadSceneMode_0;

	// Token: 0x040000ED RID: 237
	private static readonly IntPtr NativeMethodInfoPtr_internalOnLevelWasLoaded_Private_Static_Void_Int32_0;

	// Token: 0x040000EE RID: 238
	private static readonly IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	// Token: 0x040000EF RID: 239
	private static readonly IntPtr NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_Int32_0;

	// Token: 0x040000F0 RID: 240
	private static readonly IntPtr NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_0;

	// Token: 0x040000F1 RID: 241
	private static readonly IntPtr NativeMethodInfoPtr_add_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Vector3_0;

	// Token: 0x040000F2 RID: 242
	private static readonly IntPtr NativeMethodInfoPtr_closestRot_Public_Static_Single_Single_Single_0;

	// Token: 0x040000F3 RID: 243
	private static readonly IntPtr NativeMethodInfoPtr_cancelAll_Public_Static_Void_0;

	// Token: 0x040000F4 RID: 244
	private static readonly IntPtr NativeMethodInfoPtr_cancelAll_Public_Static_Void_Boolean_0;

	// Token: 0x040000F5 RID: 245
	private static readonly IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_0;

	// Token: 0x040000F6 RID: 246
	private static readonly IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Boolean_0;

	// Token: 0x040000F7 RID: 247
	private static readonly IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_RectTransform_0;

	// Token: 0x040000F8 RID: 248
	private static readonly IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Int32_Boolean_0;

	// Token: 0x040000F9 RID: 249
	private static readonly IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_LTRect_Int32_0;

	// Token: 0x040000FA RID: 250
	private static readonly IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_0;

	// Token: 0x040000FB RID: 251
	private static readonly IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_Boolean_0;

	// Token: 0x040000FC RID: 252
	private static readonly IntPtr NativeMethodInfoPtr_descr_Public_Static_LTDescr_Int32_0;

	// Token: 0x040000FD RID: 253
	private static readonly IntPtr NativeMethodInfoPtr_description_Public_Static_LTDescr_Int32_0;

	// Token: 0x040000FE RID: 254
	private static readonly IntPtr NativeMethodInfoPtr_descriptions_Public_Static_Il2CppReferenceArray_1_LTDescr_GameObject_0;

	// Token: 0x040000FF RID: 255
	private static readonly IntPtr NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_Int32_0;

	// Token: 0x04000100 RID: 256
	private static readonly IntPtr NativeMethodInfoPtr_pause_Public_Static_Void_Int32_0;

	// Token: 0x04000101 RID: 257
	private static readonly IntPtr NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_0;

	// Token: 0x04000102 RID: 258
	private static readonly IntPtr NativeMethodInfoPtr_pauseAll_Public_Static_Void_0;

	// Token: 0x04000103 RID: 259
	private static readonly IntPtr NativeMethodInfoPtr_resumeAll_Public_Static_Void_0;

	// Token: 0x04000104 RID: 260
	private static readonly IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_Int32_0;

	// Token: 0x04000105 RID: 261
	private static readonly IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_Int32_0;

	// Token: 0x04000106 RID: 262
	private static readonly IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_0;

	// Token: 0x04000107 RID: 263
	private static readonly IntPtr NativeMethodInfoPtr_isPaused_Public_Static_Boolean_GameObject_0;

	// Token: 0x04000108 RID: 264
	private static readonly IntPtr NativeMethodInfoPtr_isPaused_Public_Static_Boolean_RectTransform_0;

	// Token: 0x04000109 RID: 265
	private static readonly IntPtr NativeMethodInfoPtr_isPaused_Public_Static_Boolean_Int32_0;

	// Token: 0x0400010A RID: 266
	private static readonly IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_GameObject_0;

	// Token: 0x0400010B RID: 267
	private static readonly IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_RectTransform_0;

	// Token: 0x0400010C RID: 268
	private static readonly IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_Int32_0;

	// Token: 0x0400010D RID: 269
	private static readonly IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_LTRect_0;

	// Token: 0x0400010E RID: 270
	private static readonly IntPtr NativeMethodInfoPtr_drawBezierPath_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0;

	// Token: 0x0400010F RID: 271
	private static readonly IntPtr NativeMethodInfoPtr_logError_Public_Static_Object_String_0;

	// Token: 0x04000110 RID: 272
	private static readonly IntPtr NativeMethodInfoPtr_options_Public_Static_LTDescr_LTDescr_0;

	// Token: 0x04000111 RID: 273
	private static readonly IntPtr NativeMethodInfoPtr_options_Public_Static_LTDescr_0;

	// Token: 0x04000112 RID: 274
	private static readonly IntPtr NativeMethodInfoPtr_pushNewTween_Private_Static_LTDescr_GameObject_Vector3_Single_LTDescr_0;

	// Token: 0x04000113 RID: 275
	private static readonly IntPtr NativeMethodInfoPtr_play_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0;

	// Token: 0x04000114 RID: 276
	private static readonly IntPtr NativeMethodInfoPtr_sequence_Public_Static_LTSeq_Boolean_0;

	// Token: 0x04000115 RID: 277
	private static readonly IntPtr NativeMethodInfoPtr_alpha_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000116 RID: 278
	private static readonly IntPtr NativeMethodInfoPtr_alpha_Public_Static_LTDescr_LTRect_Single_Single_0;

	// Token: 0x04000117 RID: 279
	private static readonly IntPtr NativeMethodInfoPtr_textAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000118 RID: 280
	private static readonly IntPtr NativeMethodInfoPtr_alphaText_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000119 RID: 281
	private static readonly IntPtr NativeMethodInfoPtr_alphaCanvas_Public_Static_LTDescr_CanvasGroup_Single_Single_0;

	// Token: 0x0400011A RID: 282
	private static readonly IntPtr NativeMethodInfoPtr_alphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x0400011B RID: 283
	private static readonly IntPtr NativeMethodInfoPtr_color_Public_Static_LTDescr_GameObject_Color_Single_0;

	// Token: 0x0400011C RID: 284
	private static readonly IntPtr NativeMethodInfoPtr_textColor_Public_Static_LTDescr_RectTransform_Color_Single_0;

	// Token: 0x0400011D RID: 285
	private static readonly IntPtr NativeMethodInfoPtr_colorText_Public_Static_LTDescr_RectTransform_Color_Single_0;

	// Token: 0x0400011E RID: 286
	private static readonly IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_0;

	// Token: 0x0400011F RID: 287
	private static readonly IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_1_Object_0;

	// Token: 0x04000120 RID: 288
	private static readonly IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_0;

	// Token: 0x04000121 RID: 289
	private static readonly IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0;

	// Token: 0x04000122 RID: 290
	private static readonly IntPtr NativeMethodInfoPtr_destroyAfter_Public_Static_LTDescr_LTRect_Single_0;

	// Token: 0x04000123 RID: 291
	private static readonly IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	// Token: 0x04000124 RID: 292
	private static readonly IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector2_Single_0;

	// Token: 0x04000125 RID: 293
	private static readonly IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x04000126 RID: 294
	private static readonly IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;

	// Token: 0x04000127 RID: 295
	private static readonly IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTSpline_Single_0;

	// Token: 0x04000128 RID: 296
	private static readonly IntPtr NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x04000129 RID: 297
	private static readonly IntPtr NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0;

	// Token: 0x0400012A RID: 298
	private static readonly IntPtr NativeMethodInfoPtr_moveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x0400012B RID: 299
	private static readonly IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_LTRect_Vector2_Single_0;

	// Token: 0x0400012C RID: 300
	private static readonly IntPtr NativeMethodInfoPtr_moveMargin_Public_Static_LTDescr_LTRect_Vector2_Single_0;

	// Token: 0x0400012D RID: 301
	private static readonly IntPtr NativeMethodInfoPtr_moveX_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x0400012E RID: 302
	private static readonly IntPtr NativeMethodInfoPtr_moveY_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x0400012F RID: 303
	private static readonly IntPtr NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000130 RID: 304
	private static readonly IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	// Token: 0x04000131 RID: 305
	private static readonly IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x04000132 RID: 306
	private static readonly IntPtr NativeMethodInfoPtr_moveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000133 RID: 307
	private static readonly IntPtr NativeMethodInfoPtr_moveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000134 RID: 308
	private static readonly IntPtr NativeMethodInfoPtr_moveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000135 RID: 309
	private static readonly IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;

	// Token: 0x04000136 RID: 310
	private static readonly IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0;

	// Token: 0x04000137 RID: 311
	private static readonly IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Transform_Single_0;

	// Token: 0x04000138 RID: 312
	private static readonly IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	// Token: 0x04000139 RID: 313
	private static readonly IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_LTRect_Single_Single_0;

	// Token: 0x0400013A RID: 314
	private static readonly IntPtr NativeMethodInfoPtr_rotateLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	// Token: 0x0400013B RID: 315
	private static readonly IntPtr NativeMethodInfoPtr_rotateX_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x0400013C RID: 316
	private static readonly IntPtr NativeMethodInfoPtr_rotateY_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x0400013D RID: 317
	private static readonly IntPtr NativeMethodInfoPtr_rotateZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x0400013E RID: 318
	private static readonly IntPtr NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;

	// Token: 0x0400013F RID: 319
	private static readonly IntPtr NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;

	// Token: 0x04000140 RID: 320
	private static readonly IntPtr NativeMethodInfoPtr_scale_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	// Token: 0x04000141 RID: 321
	private static readonly IntPtr NativeMethodInfoPtr_scale_Public_Static_LTDescr_LTRect_Vector2_Single_0;

	// Token: 0x04000142 RID: 322
	private static readonly IntPtr NativeMethodInfoPtr_scaleX_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000143 RID: 323
	private static readonly IntPtr NativeMethodInfoPtr_scaleY_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000144 RID: 324
	private static readonly IntPtr NativeMethodInfoPtr_scaleZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000145 RID: 325
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Single_Single_Single_0;

	// Token: 0x04000146 RID: 326
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_Single_Single_Single_0;

	// Token: 0x04000147 RID: 327
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0;

	// Token: 0x04000148 RID: 328
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0;

	// Token: 0x04000149 RID: 329
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Color_Color_Single_0;

	// Token: 0x0400014A RID: 330
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0;

	// Token: 0x0400014B RID: 331
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0;

	// Token: 0x0400014C RID: 332
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0;

	// Token: 0x0400014D RID: 333
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Color_Object_Color_Color_Single_0;

	// Token: 0x0400014E RID: 334
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0;

	// Token: 0x0400014F RID: 335
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0;

	// Token: 0x04000150 RID: 336
	private static readonly IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0;

	// Token: 0x04000151 RID: 337
	private static readonly IntPtr NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_AudioClip_Vector3_Single_0;

	// Token: 0x04000152 RID: 338
	private static readonly IntPtr NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_GameObject_AudioClip_Vector3_Single_0;

	// Token: 0x04000153 RID: 339
	private static readonly IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_RectTransform_Vector3_Single_0;

	// Token: 0x04000154 RID: 340
	private static readonly IntPtr NativeMethodInfoPtr_moveX_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000155 RID: 341
	private static readonly IntPtr NativeMethodInfoPtr_moveY_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000156 RID: 342
	private static readonly IntPtr NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000157 RID: 343
	private static readonly IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000158 RID: 344
	private static readonly IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0;

	// Token: 0x04000159 RID: 345
	private static readonly IntPtr NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;

	// Token: 0x0400015A RID: 346
	private static readonly IntPtr NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;

	// Token: 0x0400015B RID: 347
	private static readonly IntPtr NativeMethodInfoPtr_scale_Public_Static_LTDescr_RectTransform_Vector3_Single_0;

	// Token: 0x0400015C RID: 348
	private static readonly IntPtr NativeMethodInfoPtr_size_Public_Static_LTDescr_RectTransform_Vector2_Single_0;

	// Token: 0x0400015D RID: 349
	private static readonly IntPtr NativeMethodInfoPtr_alpha_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x0400015E RID: 350
	private static readonly IntPtr NativeMethodInfoPtr_color_Public_Static_LTDescr_RectTransform_Color_Single_0;

	// Token: 0x0400015F RID: 351
	private static readonly IntPtr NativeMethodInfoPtr_tweenOnCurve_Public_Static_Single_LTDescr_Single_0;

	// Token: 0x04000160 RID: 352
	private static readonly IntPtr NativeMethodInfoPtr_tweenOnCurveVector_Public_Static_Vector3_LTDescr_Single_0;

	// Token: 0x04000161 RID: 353
	private static readonly IntPtr NativeMethodInfoPtr_easeOutQuadOpt_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000162 RID: 354
	private static readonly IntPtr NativeMethodInfoPtr_easeInQuadOpt_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000163 RID: 355
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000164 RID: 356
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Vector3_Vector3_Vector3_Single_0;

	// Token: 0x04000165 RID: 357
	private static readonly IntPtr NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000166 RID: 358
	private static readonly IntPtr NativeMethodInfoPtr_clerp_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000167 RID: 359
	private static readonly IntPtr NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000168 RID: 360
	private static readonly IntPtr NativeMethodInfoPtr_easeInQuad_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000169 RID: 361
	private static readonly IntPtr NativeMethodInfoPtr_easeOutQuad_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400016A RID: 362
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuad_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400016B RID: 363
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuadOpt2_Public_Static_Single_Single_Single_Single_Single_0;

	// Token: 0x0400016C RID: 364
	private static readonly IntPtr NativeMethodInfoPtr_easeInCubic_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400016D RID: 365
	private static readonly IntPtr NativeMethodInfoPtr_easeOutCubic_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400016E RID: 366
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutCubic_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400016F RID: 367
	private static readonly IntPtr NativeMethodInfoPtr_easeInQuart_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000170 RID: 368
	private static readonly IntPtr NativeMethodInfoPtr_easeOutQuart_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000171 RID: 369
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuart_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000172 RID: 370
	private static readonly IntPtr NativeMethodInfoPtr_easeInQuint_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000173 RID: 371
	private static readonly IntPtr NativeMethodInfoPtr_easeOutQuint_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000174 RID: 372
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuint_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000175 RID: 373
	private static readonly IntPtr NativeMethodInfoPtr_easeInSine_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000176 RID: 374
	private static readonly IntPtr NativeMethodInfoPtr_easeOutSine_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000177 RID: 375
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutSine_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000178 RID: 376
	private static readonly IntPtr NativeMethodInfoPtr_easeInExpo_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000179 RID: 377
	private static readonly IntPtr NativeMethodInfoPtr_easeOutExpo_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400017A RID: 378
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutExpo_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400017B RID: 379
	private static readonly IntPtr NativeMethodInfoPtr_easeInCirc_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400017C RID: 380
	private static readonly IntPtr NativeMethodInfoPtr_easeOutCirc_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400017D RID: 381
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutCirc_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400017E RID: 382
	private static readonly IntPtr NativeMethodInfoPtr_easeInBounce_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x0400017F RID: 383
	private static readonly IntPtr NativeMethodInfoPtr_easeOutBounce_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000180 RID: 384
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutBounce_Public_Static_Single_Single_Single_Single_0;

	// Token: 0x04000181 RID: 385
	private static readonly IntPtr NativeMethodInfoPtr_easeInBack_Public_Static_Single_Single_Single_Single_Single_0;

	// Token: 0x04000182 RID: 386
	private static readonly IntPtr NativeMethodInfoPtr_easeOutBack_Public_Static_Single_Single_Single_Single_Single_0;

	// Token: 0x04000183 RID: 387
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutBack_Public_Static_Single_Single_Single_Single_Single_0;

	// Token: 0x04000184 RID: 388
	private static readonly IntPtr NativeMethodInfoPtr_easeInElastic_Public_Static_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04000185 RID: 389
	private static readonly IntPtr NativeMethodInfoPtr_easeOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04000186 RID: 390
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04000187 RID: 391
	private static readonly IntPtr NativeMethodInfoPtr_followDamp_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_0;

	// Token: 0x04000188 RID: 392
	private static readonly IntPtr NativeMethodInfoPtr_followSpring_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_0;

	// Token: 0x04000189 RID: 393
	private static readonly IntPtr NativeMethodInfoPtr_followBounceOut_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_Single_Single_Single_Single_0;

	// Token: 0x0400018A RID: 394
	private static readonly IntPtr NativeMethodInfoPtr_followLinear_Public_Static_LTDescr_Transform_Transform_LeanProp_Single_0;

	// Token: 0x0400018B RID: 395
	private static readonly IntPtr NativeMethodInfoPtr_addListener_Public_Static_Void_Int32_Action_1_LTEvent_0;

	// Token: 0x0400018C RID: 396
	private static readonly IntPtr NativeMethodInfoPtr_addListener_Public_Static_Void_GameObject_Int32_Action_1_LTEvent_0;

	// Token: 0x0400018D RID: 397
	private static readonly IntPtr NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_Action_1_LTEvent_0;

	// Token: 0x0400018E RID: 398
	private static readonly IntPtr NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_0;

	// Token: 0x0400018F RID: 399
	private static readonly IntPtr NativeMethodInfoPtr_removeListener_Public_Static_Boolean_GameObject_Int32_Action_1_LTEvent_0;

	// Token: 0x04000190 RID: 400
	private static readonly IntPtr NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_0;

	// Token: 0x04000191 RID: 401
	private static readonly IntPtr NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_Object_0;

	// Token: 0x02000169 RID: 361
	[ObfuscatedName("LeanTween+<>c__DisplayClass193_0")]
	public sealed class __c__DisplayClass193_0 : global::Il2CppSystem.Object
	{
		// Token: 0x0600189B RID: 6299 RVA: 0x0007B6BC File Offset: 0x000798BC
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass193_0()
		{
			Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "<>c__DisplayClass193_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr);
			LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, "d");
			LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, "smoothTime");
			LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, "maxSpeed");
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663546);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663547);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663548);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663549);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663550);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663551);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663552);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663553);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663554);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663555);
			LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr, 100663556);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0007B800 File Offset: 0x00079A00
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass193_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween.__c__DisplayClass193_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0007B83C File Offset: 0x00079A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10463, XrefRangeEnd = 10470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0007B870 File Offset: 0x00079A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10470, XrefRangeEnd = 10477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0007B8A4 File Offset: 0x00079AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10477, XrefRangeEnd = 10484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0007B8D8 File Offset: 0x00079AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10484, XrefRangeEnd = 10491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0007B90C File Offset: 0x00079B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10491, XrefRangeEnd = 10498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0007B940 File Offset: 0x00079B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10498, XrefRangeEnd = 10505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0007B974 File Offset: 0x00079B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10505, XrefRangeEnd = 10512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0007B9A8 File Offset: 0x00079BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10512, XrefRangeEnd = 10519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0007B9DC File Offset: 0x00079BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10519, XrefRangeEnd = 10527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0007BA10 File Offset: 0x00079C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10527, XrefRangeEnd = 10540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followDamp_b__9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass193_0.NativeMethodInfoPtr__followDamp_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00009B38 File Offset: 0x00007D38
		public __c__DisplayClass193_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x0007BA44 File Offset: 0x00079C44
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x00009B41 File Offset: 0x00007D41
		public unsafe LTDescr d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x0007BA74 File Offset: 0x00079C74
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x00009B60 File Offset: 0x00007D60
		public unsafe float smoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_smoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_smoothTime)) = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x0007BA9C File Offset: 0x00079C9C
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x00009B7B File Offset: 0x00007D7B
		public unsafe float maxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_maxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass193_0.NativeFieldInfoPtr_maxSpeed)) = value;
			}
		}

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeFieldInfoPtr_smoothTime;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeFieldInfoPtr_maxSpeed;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__0_Internal_Void_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__1_Internal_Void_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__2_Internal_Void_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__3_Internal_Void_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__4_Internal_Void_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__5_Internal_Void_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__6_Internal_Void_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__7_Internal_Void_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__8_Internal_Void_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr__followDamp_b__9_Internal_Void_0;
	}

	// Token: 0x0200016A RID: 362
	[ObfuscatedName("LeanTween+<>c__DisplayClass194_0")]
	public sealed class __c__DisplayClass194_0 : global::Il2CppSystem.Object
	{
		// Token: 0x060018AE RID: 6318 RVA: 0x0007BAC4 File Offset: 0x00079CC4
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass194_0()
		{
			Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "<>c__DisplayClass194_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr);
			LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, "d");
			LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, "smoothTime");
			LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, "maxSpeed");
			LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, "friction");
			LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_accelRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, "accelRate");
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663557);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663558);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663559);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663560);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663561);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663562);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663563);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663564);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663565);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663566);
			LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr, 100663567);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0007BC30 File Offset: 0x00079E30
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass194_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween.__c__DisplayClass194_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0007BC6C File Offset: 0x00079E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10540, XrefRangeEnd = 10545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0007BCA0 File Offset: 0x00079EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10545, XrefRangeEnd = 10550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0007BCD4 File Offset: 0x00079ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10550, XrefRangeEnd = 10557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0007BD08 File Offset: 0x00079F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10557, XrefRangeEnd = 10564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0007BD3C File Offset: 0x00079F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10564, XrefRangeEnd = 10571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0007BD70 File Offset: 0x00079F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10571, XrefRangeEnd = 10578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0007BDA4 File Offset: 0x00079FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10578, XrefRangeEnd = 10585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0007BDD8 File Offset: 0x00079FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10585, XrefRangeEnd = 10592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0007BE0C File Offset: 0x0007A00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10592, XrefRangeEnd = 10598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0007BE40 File Offset: 0x0007A040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10598, XrefRangeEnd = 10611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followSpring_b__9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass194_0.NativeMethodInfoPtr__followSpring_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00009B96 File Offset: 0x00007D96
		public __c__DisplayClass194_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0007BE74 File Offset: 0x0007A074
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x00009B9F File Offset: 0x00007D9F
		public unsafe LTDescr d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x0007BEA4 File Offset: 0x0007A0A4
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x00009BBE File Offset: 0x00007DBE
		public unsafe float smoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_smoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_smoothTime)) = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x0007BECC File Offset: 0x0007A0CC
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x00009BD9 File Offset: 0x00007DD9
		public unsafe float maxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_maxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_maxSpeed)) = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0007BEF4 File Offset: 0x0007A0F4
		// (set) Token: 0x060018C2 RID: 6338 RVA: 0x00009BF4 File Offset: 0x00007DF4
		public unsafe float friction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_friction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_friction)) = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0007BF1C File Offset: 0x0007A11C
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x00009C0F File Offset: 0x00007E0F
		public unsafe float accelRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_accelRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass194_0.NativeFieldInfoPtr_accelRate)) = value;
			}
		}

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeFieldInfoPtr_smoothTime;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr_maxSpeed;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeFieldInfoPtr_friction;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeFieldInfoPtr_accelRate;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__0_Internal_Void_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__1_Internal_Void_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__2_Internal_Void_0;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__3_Internal_Void_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__4_Internal_Void_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__5_Internal_Void_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__6_Internal_Void_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__7_Internal_Void_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__8_Internal_Void_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr__followSpring_b__9_Internal_Void_0;
	}

	// Token: 0x0200016B RID: 363
	[ObfuscatedName("LeanTween+<>c__DisplayClass195_0")]
	public sealed class __c__DisplayClass195_0 : global::Il2CppSystem.Object
	{
		// Token: 0x060018C5 RID: 6341 RVA: 0x0007BF44 File Offset: 0x0007A144
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass195_0()
		{
			Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "<>c__DisplayClass195_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr);
			LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, "d");
			LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, "smoothTime");
			LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, "maxSpeed");
			LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, "friction");
			LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_accelRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, "accelRate");
			LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_hitDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, "hitDamping");
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663568);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663569);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663570);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663571);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663572);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663573);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663574);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663575);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663576);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663577);
			LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr, 100663578);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0007C0C4 File Offset: 0x0007A2C4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass195_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween.__c__DisplayClass195_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0007C100 File Offset: 0x0007A300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10611, XrefRangeEnd = 10616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0007C134 File Offset: 0x0007A334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10616, XrefRangeEnd = 10621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0007C168 File Offset: 0x0007A368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10621, XrefRangeEnd = 10628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0007C19C File Offset: 0x0007A39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10628, XrefRangeEnd = 10635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0007C1D0 File Offset: 0x0007A3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10635, XrefRangeEnd = 10642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0007C204 File Offset: 0x0007A404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10642, XrefRangeEnd = 10649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0007C238 File Offset: 0x0007A438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10649, XrefRangeEnd = 10656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0007C26C File Offset: 0x0007A46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10656, XrefRangeEnd = 10663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0007C2A0 File Offset: 0x0007A4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10663, XrefRangeEnd = 10669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0007C2D4 File Offset: 0x0007A4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10669, XrefRangeEnd = 10682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followBounceOut_b__9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass195_0.NativeMethodInfoPtr__followBounceOut_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00009C2A File Offset: 0x00007E2A
		public __c__DisplayClass195_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0007C308 File Offset: 0x0007A508
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x00009C33 File Offset: 0x00007E33
		public unsafe LTDescr d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0007C338 File Offset: 0x0007A538
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x00009C52 File Offset: 0x00007E52
		public unsafe float smoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_smoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_smoothTime)) = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x0007C360 File Offset: 0x0007A560
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x00009C6D File Offset: 0x00007E6D
		public unsafe float maxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_maxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_maxSpeed)) = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0007C388 File Offset: 0x0007A588
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00009C88 File Offset: 0x00007E88
		public unsafe float friction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_friction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_friction)) = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0007C3B0 File Offset: 0x0007A5B0
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x00009CA3 File Offset: 0x00007EA3
		public unsafe float accelRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_accelRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_accelRate)) = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x0007C3D8 File Offset: 0x0007A5D8
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x00009CBE File Offset: 0x00007EBE
		public unsafe float hitDamping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_hitDamping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass195_0.NativeFieldInfoPtr_hitDamping)) = value;
			}
		}

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeFieldInfoPtr_smoothTime;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeFieldInfoPtr_maxSpeed;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeFieldInfoPtr_friction;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeFieldInfoPtr_accelRate;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeFieldInfoPtr_hitDamping;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__0_Internal_Void_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__1_Internal_Void_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__2_Internal_Void_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__3_Internal_Void_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__4_Internal_Void_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__5_Internal_Void_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__6_Internal_Void_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__7_Internal_Void_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__8_Internal_Void_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr__followBounceOut_b__9_Internal_Void_0;
	}

	// Token: 0x0200016C RID: 364
	[ObfuscatedName("LeanTween+<>c__DisplayClass196_0")]
	public sealed class __c__DisplayClass196_0 : global::Il2CppSystem.Object
	{
		// Token: 0x060018DE RID: 6366 RVA: 0x0007C400 File Offset: 0x0007A600
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass196_0()
		{
			Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "<>c__DisplayClass196_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr);
			LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, "d");
			LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, "moveSpeed");
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663579);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663580);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663581);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663582);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663583);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663584);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663585);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663586);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663587);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663588);
			LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr, 100663589);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0007C530 File Offset: 0x0007A730
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass196_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween.__c__DisplayClass196_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0007C56C File Offset: 0x0007A76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10682, XrefRangeEnd = 10688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0007C5A0 File Offset: 0x0007A7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10688, XrefRangeEnd = 10695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0007C5D4 File Offset: 0x0007A7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10695, XrefRangeEnd = 10701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0007C608 File Offset: 0x0007A808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10701, XrefRangeEnd = 10707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0007C63C File Offset: 0x0007A83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10707, XrefRangeEnd = 10713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0007C670 File Offset: 0x0007A870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10713, XrefRangeEnd = 10719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0007C6A4 File Offset: 0x0007A8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10719, XrefRangeEnd = 10725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0007C6D8 File Offset: 0x0007A8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10725, XrefRangeEnd = 10731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0007C70C File Offset: 0x0007A90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10731, XrefRangeEnd = 10738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0007C740 File Offset: 0x0007A940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10738, XrefRangeEnd = 10750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _followLinear_b__9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTween.__c__DisplayClass196_0.NativeMethodInfoPtr__followLinear_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00009CD9 File Offset: 0x00007ED9
		public __c__DisplayClass196_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0007C774 File Offset: 0x0007A974
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x00009CE2 File Offset: 0x00007EE2
		public unsafe LTDescr d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0007C7A4 File Offset: 0x0007A9A4
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x00009D01 File Offset: 0x00007F01
		public unsafe float moveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_moveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTween.__c__DisplayClass196_0.NativeFieldInfoPtr_moveSpeed)) = value;
			}
		}

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__0_Internal_Void_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__1_Internal_Void_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__2_Internal_Void_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__3_Internal_Void_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__4_Internal_Void_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__5_Internal_Void_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__6_Internal_Void_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__7_Internal_Void_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__8_Internal_Void_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr__followLinear_b__9_Internal_Void_0;
	}
}
