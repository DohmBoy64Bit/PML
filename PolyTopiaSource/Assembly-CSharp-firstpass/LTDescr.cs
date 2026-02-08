using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000016 RID: 22
public class LTDescr : global::Il2CppSystem.Object
{
	// Token: 0x060002B9 RID: 697 RVA: 0x0001D31C File Offset: 0x0001B51C
	// Note: this type is marked as 'beforefieldinit'.
	static LTDescr()
	{
		Il2CppClassPointerStore<LTDescr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTDescr");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTDescr>.NativeClassPtr);
		LTDescr.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "toggle");
		LTDescr.NativeFieldInfoPtr_useEstimatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "useEstimatedTime");
		LTDescr.NativeFieldInfoPtr_useFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "useFrames");
		LTDescr.NativeFieldInfoPtr_useManualTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "useManualTime");
		LTDescr.NativeFieldInfoPtr_usesNormalDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "usesNormalDt");
		LTDescr.NativeFieldInfoPtr_hasInitiliazed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "hasInitiliazed");
		LTDescr.NativeFieldInfoPtr_hasExtraOnCompletes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "hasExtraOnCompletes");
		LTDescr.NativeFieldInfoPtr_hasPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "hasPhysics");
		LTDescr.NativeFieldInfoPtr_onCompleteOnRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "onCompleteOnRepeat");
		LTDescr.NativeFieldInfoPtr_onCompleteOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "onCompleteOnStart");
		LTDescr.NativeFieldInfoPtr_useRecursion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "useRecursion");
		LTDescr.NativeFieldInfoPtr_ratioPassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "ratioPassed");
		LTDescr.NativeFieldInfoPtr_passed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "passed");
		LTDescr.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "delay");
		LTDescr.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "time");
		LTDescr.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "speed");
		LTDescr.NativeFieldInfoPtr_lastVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "lastVal");
		LTDescr.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "_id");
		LTDescr.NativeFieldInfoPtr_loopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "loopCount");
		LTDescr.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "counter");
		LTDescr.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "direction");
		LTDescr.NativeFieldInfoPtr_directionLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "directionLast");
		LTDescr.NativeFieldInfoPtr_overshoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "overshoot");
		LTDescr.NativeFieldInfoPtr_period = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "period");
		LTDescr.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "scale");
		LTDescr.NativeFieldInfoPtr_destroyOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "destroyOnComplete");
		LTDescr.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "trans");
		LTDescr.NativeFieldInfoPtr_fromInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "fromInternal");
		LTDescr.NativeFieldInfoPtr_toInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "toInternal");
		LTDescr.NativeFieldInfoPtr_diff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "diff");
		LTDescr.NativeFieldInfoPtr_diffDiv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "diffDiv2");
		LTDescr.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "type");
		LTDescr.NativeFieldInfoPtr_easeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "easeType");
		LTDescr.NativeFieldInfoPtr_loopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "loopType");
		LTDescr.NativeFieldInfoPtr_hasUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "hasUpdateCallback");
		LTDescr.NativeFieldInfoPtr_easeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "easeMethod");
		LTDescr.NativeFieldInfoPtr__easeInternal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "<easeInternal>k__BackingField");
		LTDescr.NativeFieldInfoPtr__initInternal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "<initInternal>k__BackingField");
		LTDescr.NativeFieldInfoPtr_spriteRen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "spriteRen");
		LTDescr.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "rectTransform");
		LTDescr.NativeFieldInfoPtr_uiText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "uiText");
		LTDescr.NativeFieldInfoPtr_uiImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "uiImage");
		LTDescr.NativeFieldInfoPtr_rawImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "rawImage");
		LTDescr.NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "sprites");
		LTDescr.NativeFieldInfoPtr__optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "_optional");
		LTDescr.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "val");
		LTDescr.NativeFieldInfoPtr_dt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "dt");
		LTDescr.NativeFieldInfoPtr_newVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "newVect");
		LTDescr.NativeMethodInfoPtr_get_from_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663776);
		LTDescr.NativeMethodInfoPtr_set_from_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663777);
		LTDescr.NativeMethodInfoPtr_get_to_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663778);
		LTDescr.NativeMethodInfoPtr_set_to_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663779);
		LTDescr.NativeMethodInfoPtr_get_easeInternal_Public_get_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663780);
		LTDescr.NativeMethodInfoPtr_set_easeInternal_Public_set_Void_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663781);
		LTDescr.NativeMethodInfoPtr_get_initInternal_Public_get_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663782);
		LTDescr.NativeMethodInfoPtr_set_initInternal_Public_set_Void_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663783);
		LTDescr.NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663784);
		LTDescr.NativeMethodInfoPtr_get_uniqueId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663788);
		LTDescr.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663789);
		LTDescr.NativeMethodInfoPtr_get_optional_Public_get_LTDescrOptional_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663790);
		LTDescr.NativeMethodInfoPtr_set_optional_Public_set_Void_LTDescrOptional_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663791);
		LTDescr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663786);
		LTDescr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663785);
		LTDescr.NativeMethodInfoPtr_cancel_Public_LTDescr_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663787);
		LTDescr.NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663792);
		LTDescr.NativeMethodInfoPtr_setFollow_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663793);
		LTDescr.NativeMethodInfoPtr_setMoveX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663794);
		LTDescr.NativeMethodInfoPtr_setMoveY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663795);
		LTDescr.NativeMethodInfoPtr_setMoveZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663796);
		LTDescr.NativeMethodInfoPtr_setMoveLocalX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663797);
		LTDescr.NativeMethodInfoPtr_setMoveLocalY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663798);
		LTDescr.NativeMethodInfoPtr_setMoveLocalZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663799);
		LTDescr.NativeMethodInfoPtr_initFromInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663800);
		LTDescr.NativeMethodInfoPtr_setOffset_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663801);
		LTDescr.NativeMethodInfoPtr_setMoveCurved_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663802);
		LTDescr.NativeMethodInfoPtr_setMoveCurvedLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663803);
		LTDescr.NativeMethodInfoPtr_setMoveSpline_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663804);
		LTDescr.NativeMethodInfoPtr_setMoveSplineLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663805);
		LTDescr.NativeMethodInfoPtr_setScaleX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663806);
		LTDescr.NativeMethodInfoPtr_setScaleY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663807);
		LTDescr.NativeMethodInfoPtr_setScaleZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663808);
		LTDescr.NativeMethodInfoPtr_setRotateX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663809);
		LTDescr.NativeMethodInfoPtr_setRotateY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663810);
		LTDescr.NativeMethodInfoPtr_setRotateZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663811);
		LTDescr.NativeMethodInfoPtr_setRotateAround_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663812);
		LTDescr.NativeMethodInfoPtr_setRotateAroundLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663813);
		LTDescr.NativeMethodInfoPtr_setAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663814);
		LTDescr.NativeMethodInfoPtr_setTextAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663815);
		LTDescr.NativeMethodInfoPtr_setAlphaVertex_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663816);
		LTDescr.NativeMethodInfoPtr_setColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663817);
		LTDescr.NativeMethodInfoPtr_setCallbackColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663818);
		LTDescr.NativeMethodInfoPtr_setTextColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663819);
		LTDescr.NativeMethodInfoPtr_setCanvasAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663820);
		LTDescr.NativeMethodInfoPtr_setCanvasGroupAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663821);
		LTDescr.NativeMethodInfoPtr_setCanvasColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663822);
		LTDescr.NativeMethodInfoPtr_setCanvasMoveX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663823);
		LTDescr.NativeMethodInfoPtr_setCanvasMoveY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663824);
		LTDescr.NativeMethodInfoPtr_setCanvasMoveZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663825);
		LTDescr.NativeMethodInfoPtr_initCanvasRotateAround_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663826);
		LTDescr.NativeMethodInfoPtr_setCanvasRotateAround_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663827);
		LTDescr.NativeMethodInfoPtr_setCanvasRotateAroundLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663828);
		LTDescr.NativeMethodInfoPtr_setCanvasPlaySprite_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663829);
		LTDescr.NativeMethodInfoPtr_setCanvasMove_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663830);
		LTDescr.NativeMethodInfoPtr_setCanvasScale_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663831);
		LTDescr.NativeMethodInfoPtr_setCanvasSizeDelta_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663832);
		LTDescr.NativeMethodInfoPtr_callback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663833);
		LTDescr.NativeMethodInfoPtr_setCallback_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663834);
		LTDescr.NativeMethodInfoPtr_setValue3_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663835);
		LTDescr.NativeMethodInfoPtr_setMove_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663836);
		LTDescr.NativeMethodInfoPtr_setMoveLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663837);
		LTDescr.NativeMethodInfoPtr_setMoveToTransform_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663838);
		LTDescr.NativeMethodInfoPtr_setRotate_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663839);
		LTDescr.NativeMethodInfoPtr_setRotateLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663840);
		LTDescr.NativeMethodInfoPtr_setScale_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663841);
		LTDescr.NativeMethodInfoPtr_setGUIMove_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663842);
		LTDescr.NativeMethodInfoPtr_setGUIMoveMargin_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663843);
		LTDescr.NativeMethodInfoPtr_setGUIScale_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663844);
		LTDescr.NativeMethodInfoPtr_setGUIAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663845);
		LTDescr.NativeMethodInfoPtr_setGUIRotate_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663846);
		LTDescr.NativeMethodInfoPtr_setDelayedSound_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663847);
		LTDescr.NativeMethodInfoPtr_setTarget_Public_LTDescr_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663848);
		LTDescr.NativeMethodInfoPtr_init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663849);
		LTDescr.NativeMethodInfoPtr_initSpeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663850);
		LTDescr.NativeMethodInfoPtr_updateNow_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663851);
		LTDescr.NativeMethodInfoPtr_updateInternal_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663852);
		LTDescr.NativeMethodInfoPtr_callOnCompletes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663853);
		LTDescr.NativeMethodInfoPtr_setFromColor_Public_LTDescr_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663854);
		LTDescr.NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_Transform_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663855);
		LTDescr.NativeMethodInfoPtr_colorRecursive_Private_Static_Void_Transform_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663856);
		LTDescr.NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_RectTransform_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663857);
		LTDescr.NativeMethodInfoPtr_alphaRecursiveSprite_Private_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663858);
		LTDescr.NativeMethodInfoPtr_colorRecursiveSprite_Private_Static_Void_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663859);
		LTDescr.NativeMethodInfoPtr_colorRecursive_Private_Static_Void_RectTransform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663860);
		LTDescr.NativeMethodInfoPtr_textAlphaChildrenRecursive_Private_Static_Void_Transform_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663861);
		LTDescr.NativeMethodInfoPtr_textAlphaRecursive_Private_Static_Void_Transform_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663862);
		LTDescr.NativeMethodInfoPtr_textColorRecursive_Private_Static_Void_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663863);
		LTDescr.NativeMethodInfoPtr_tweenColor_Private_Static_Color_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663864);
		LTDescr.NativeMethodInfoPtr_pause_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663865);
		LTDescr.NativeMethodInfoPtr_resume_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663866);
		LTDescr.NativeMethodInfoPtr_setAxis_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663867);
		LTDescr.NativeMethodInfoPtr_setDelay_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663868);
		LTDescr.NativeMethodInfoPtr_setEase_Public_LTDescr_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663869);
		LTDescr.NativeMethodInfoPtr_setEaseLinear_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663870);
		LTDescr.NativeMethodInfoPtr_setEaseSpring_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663871);
		LTDescr.NativeMethodInfoPtr_setEaseInQuad_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663872);
		LTDescr.NativeMethodInfoPtr_setEaseOutQuad_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663873);
		LTDescr.NativeMethodInfoPtr_setEaseInOutQuad_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663874);
		LTDescr.NativeMethodInfoPtr_setEaseInCubic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663875);
		LTDescr.NativeMethodInfoPtr_setEaseOutCubic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663876);
		LTDescr.NativeMethodInfoPtr_setEaseInOutCubic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663877);
		LTDescr.NativeMethodInfoPtr_setEaseInQuart_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663878);
		LTDescr.NativeMethodInfoPtr_setEaseOutQuart_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663879);
		LTDescr.NativeMethodInfoPtr_setEaseInOutQuart_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663880);
		LTDescr.NativeMethodInfoPtr_setEaseInQuint_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663881);
		LTDescr.NativeMethodInfoPtr_setEaseOutQuint_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663882);
		LTDescr.NativeMethodInfoPtr_setEaseInOutQuint_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663883);
		LTDescr.NativeMethodInfoPtr_setEaseInSine_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663884);
		LTDescr.NativeMethodInfoPtr_setEaseOutSine_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663885);
		LTDescr.NativeMethodInfoPtr_setEaseInOutSine_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663886);
		LTDescr.NativeMethodInfoPtr_setEaseInExpo_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663887);
		LTDescr.NativeMethodInfoPtr_setEaseOutExpo_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663888);
		LTDescr.NativeMethodInfoPtr_setEaseInOutExpo_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663889);
		LTDescr.NativeMethodInfoPtr_setEaseInCirc_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663890);
		LTDescr.NativeMethodInfoPtr_setEaseOutCirc_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663891);
		LTDescr.NativeMethodInfoPtr_setEaseInOutCirc_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663892);
		LTDescr.NativeMethodInfoPtr_setEaseInBounce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663893);
		LTDescr.NativeMethodInfoPtr_setEaseOutBounce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663894);
		LTDescr.NativeMethodInfoPtr_setEaseInOutBounce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663895);
		LTDescr.NativeMethodInfoPtr_setEaseInBack_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663896);
		LTDescr.NativeMethodInfoPtr_setEaseOutBack_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663897);
		LTDescr.NativeMethodInfoPtr_setEaseInOutBack_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663898);
		LTDescr.NativeMethodInfoPtr_setEaseInElastic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663899);
		LTDescr.NativeMethodInfoPtr_setEaseOutElastic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663900);
		LTDescr.NativeMethodInfoPtr_setEaseInOutElastic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663901);
		LTDescr.NativeMethodInfoPtr_setEasePunch_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663902);
		LTDescr.NativeMethodInfoPtr_setEaseShake_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663903);
		LTDescr.NativeMethodInfoPtr_tweenOnCurve_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663904);
		LTDescr.NativeMethodInfoPtr_easeInOutQuad_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663905);
		LTDescr.NativeMethodInfoPtr_easeInQuad_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663906);
		LTDescr.NativeMethodInfoPtr_easeOutQuad_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663907);
		LTDescr.NativeMethodInfoPtr_easeLinear_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663908);
		LTDescr.NativeMethodInfoPtr_easeSpring_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663909);
		LTDescr.NativeMethodInfoPtr_easeInCubic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663910);
		LTDescr.NativeMethodInfoPtr_easeOutCubic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663911);
		LTDescr.NativeMethodInfoPtr_easeInOutCubic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663912);
		LTDescr.NativeMethodInfoPtr_easeInQuart_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663913);
		LTDescr.NativeMethodInfoPtr_easeOutQuart_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663914);
		LTDescr.NativeMethodInfoPtr_easeInOutQuart_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663915);
		LTDescr.NativeMethodInfoPtr_easeInQuint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663916);
		LTDescr.NativeMethodInfoPtr_easeOutQuint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663917);
		LTDescr.NativeMethodInfoPtr_easeInOutQuint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663918);
		LTDescr.NativeMethodInfoPtr_easeInSine_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663919);
		LTDescr.NativeMethodInfoPtr_easeOutSine_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663920);
		LTDescr.NativeMethodInfoPtr_easeInOutSine_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663921);
		LTDescr.NativeMethodInfoPtr_easeInExpo_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663922);
		LTDescr.NativeMethodInfoPtr_easeOutExpo_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663923);
		LTDescr.NativeMethodInfoPtr_easeInOutExpo_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663924);
		LTDescr.NativeMethodInfoPtr_easeInCirc_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663925);
		LTDescr.NativeMethodInfoPtr_easeOutCirc_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663926);
		LTDescr.NativeMethodInfoPtr_easeInOutCirc_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663927);
		LTDescr.NativeMethodInfoPtr_easeInBounce_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663928);
		LTDescr.NativeMethodInfoPtr_easeOutBounce_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663929);
		LTDescr.NativeMethodInfoPtr_easeInOutBounce_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663930);
		LTDescr.NativeMethodInfoPtr_easeInBack_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663931);
		LTDescr.NativeMethodInfoPtr_easeOutBack_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663932);
		LTDescr.NativeMethodInfoPtr_easeInOutBack_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663933);
		LTDescr.NativeMethodInfoPtr_easeInElastic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663934);
		LTDescr.NativeMethodInfoPtr_easeOutElastic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663935);
		LTDescr.NativeMethodInfoPtr_easeInOutElastic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663936);
		LTDescr.NativeMethodInfoPtr_setOvershoot_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663937);
		LTDescr.NativeMethodInfoPtr_setPeriod_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663938);
		LTDescr.NativeMethodInfoPtr_setScale_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663939);
		LTDescr.NativeMethodInfoPtr_setEase_Public_LTDescr_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663940);
		LTDescr.NativeMethodInfoPtr_setTo_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663941);
		LTDescr.NativeMethodInfoPtr_setTo_Public_LTDescr_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663942);
		LTDescr.NativeMethodInfoPtr_setFrom_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663943);
		LTDescr.NativeMethodInfoPtr_setFrom_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663944);
		LTDescr.NativeMethodInfoPtr_setDiff_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663945);
		LTDescr.NativeMethodInfoPtr_setHasInitialized_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663946);
		LTDescr.NativeMethodInfoPtr_setId_Public_LTDescr_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663947);
		LTDescr.NativeMethodInfoPtr_setPassed_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663948);
		LTDescr.NativeMethodInfoPtr_setTime_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663949);
		LTDescr.NativeMethodInfoPtr_setSpeed_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663950);
		LTDescr.NativeMethodInfoPtr_setRepeat_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663951);
		LTDescr.NativeMethodInfoPtr_setLoopType_Public_LTDescr_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663952);
		LTDescr.NativeMethodInfoPtr_setUseEstimatedTime_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663953);
		LTDescr.NativeMethodInfoPtr_setIgnoreTimeScale_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663954);
		LTDescr.NativeMethodInfoPtr_setUseFrames_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663955);
		LTDescr.NativeMethodInfoPtr_setUseManualTime_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663956);
		LTDescr.NativeMethodInfoPtr_setLoopCount_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663957);
		LTDescr.NativeMethodInfoPtr_setLoopOnce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663958);
		LTDescr.NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663959);
		LTDescr.NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663960);
		LTDescr.NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663961);
		LTDescr.NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663962);
		LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663963);
		LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663964);
		LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663965);
		LTDescr.NativeMethodInfoPtr_setOnCompleteParam_Public_LTDescr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663966);
		LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663967);
		LTDescr.NativeMethodInfoPtr_setOnUpdateRatio_Public_LTDescr_Action_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663968);
		LTDescr.NativeMethodInfoPtr_setOnUpdateObject_Public_LTDescr_Action_2_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663969);
		LTDescr.NativeMethodInfoPtr_setOnUpdateVector2_Public_LTDescr_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663970);
		LTDescr.NativeMethodInfoPtr_setOnUpdateVector3_Public_LTDescr_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663971);
		LTDescr.NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663972);
		LTDescr.NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663973);
		LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663974);
		LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663975);
		LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Single_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663976);
		LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Vector3_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663977);
		LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector2_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663978);
		LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector3_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663979);
		LTDescr.NativeMethodInfoPtr_setOnUpdateParam_Public_LTDescr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663980);
		LTDescr.NativeMethodInfoPtr_setOrientToPath_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663981);
		LTDescr.NativeMethodInfoPtr_setOrientToPath2d_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663982);
		LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663983);
		LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663984);
		LTDescr.NativeMethodInfoPtr_setPath_Public_LTDescr_LTBezierPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663985);
		LTDescr.NativeMethodInfoPtr_setPoint_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663986);
		LTDescr.NativeMethodInfoPtr_setDestroyOnComplete_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663987);
		LTDescr.NativeMethodInfoPtr_setAudio_Public_LTDescr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663988);
		LTDescr.NativeMethodInfoPtr_setOnCompleteOnRepeat_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663989);
		LTDescr.NativeMethodInfoPtr_setOnCompleteOnStart_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663990);
		LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663991);
		LTDescr.NativeMethodInfoPtr_setSprites_Public_LTDescr_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663992);
		LTDescr.NativeMethodInfoPtr_setFrameRate_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663993);
		LTDescr.NativeMethodInfoPtr_setOnStart_Public_LTDescr_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663994);
		LTDescr.NativeMethodInfoPtr_setDirection_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663995);
		LTDescr.NativeMethodInfoPtr_setRecursive_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663996);
		LTDescr.NativeMethodInfoPtr__setMoveX_b__73_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663997);
		LTDescr.NativeMethodInfoPtr__setMoveX_b__73_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663998);
		LTDescr.NativeMethodInfoPtr__setMoveY_b__74_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663999);
		LTDescr.NativeMethodInfoPtr__setMoveY_b__74_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664000);
		LTDescr.NativeMethodInfoPtr__setMoveZ_b__75_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664001);
		LTDescr.NativeMethodInfoPtr__setMoveZ_b__75_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664002);
		LTDescr.NativeMethodInfoPtr__setMoveLocalX_b__76_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664003);
		LTDescr.NativeMethodInfoPtr__setMoveLocalX_b__76_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664004);
		LTDescr.NativeMethodInfoPtr__setMoveLocalY_b__77_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664005);
		LTDescr.NativeMethodInfoPtr__setMoveLocalY_b__77_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664006);
		LTDescr.NativeMethodInfoPtr__setMoveLocalZ_b__78_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664007);
		LTDescr.NativeMethodInfoPtr__setMoveLocalZ_b__78_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664008);
		LTDescr.NativeMethodInfoPtr__setMoveCurved_b__81_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664009);
		LTDescr.NativeMethodInfoPtr__setMoveCurvedLocal_b__82_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664010);
		LTDescr.NativeMethodInfoPtr__setMoveSpline_b__83_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664011);
		LTDescr.NativeMethodInfoPtr__setMoveSplineLocal_b__84_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664012);
		LTDescr.NativeMethodInfoPtr__setScaleX_b__85_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664013);
		LTDescr.NativeMethodInfoPtr__setScaleX_b__85_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664014);
		LTDescr.NativeMethodInfoPtr__setScaleY_b__86_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664015);
		LTDescr.NativeMethodInfoPtr__setScaleY_b__86_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664016);
		LTDescr.NativeMethodInfoPtr__setScaleZ_b__87_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664017);
		LTDescr.NativeMethodInfoPtr__setScaleZ_b__87_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664018);
		LTDescr.NativeMethodInfoPtr__setRotateX_b__88_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664019);
		LTDescr.NativeMethodInfoPtr__setRotateX_b__88_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664020);
		LTDescr.NativeMethodInfoPtr__setRotateY_b__89_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664021);
		LTDescr.NativeMethodInfoPtr__setRotateY_b__89_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664022);
		LTDescr.NativeMethodInfoPtr__setRotateZ_b__90_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664023);
		LTDescr.NativeMethodInfoPtr__setRotateZ_b__90_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664024);
		LTDescr.NativeMethodInfoPtr__setRotateAround_b__91_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664025);
		LTDescr.NativeMethodInfoPtr__setRotateAround_b__91_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664026);
		LTDescr.NativeMethodInfoPtr__setRotateAroundLocal_b__92_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664027);
		LTDescr.NativeMethodInfoPtr__setRotateAroundLocal_b__92_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664028);
		LTDescr.NativeMethodInfoPtr__setAlpha_b__93_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664029);
		LTDescr.NativeMethodInfoPtr__setAlpha_b__93_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664030);
		LTDescr.NativeMethodInfoPtr__setAlpha_b__93_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664031);
		LTDescr.NativeMethodInfoPtr__setTextAlpha_b__94_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664032);
		LTDescr.NativeMethodInfoPtr__setTextAlpha_b__94_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664033);
		LTDescr.NativeMethodInfoPtr__setAlphaVertex_b__95_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664034);
		LTDescr.NativeMethodInfoPtr__setAlphaVertex_b__95_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664035);
		LTDescr.NativeMethodInfoPtr__setColor_b__96_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664036);
		LTDescr.NativeMethodInfoPtr__setColor_b__96_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664037);
		LTDescr.NativeMethodInfoPtr__setCallbackColor_b__97_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664038);
		LTDescr.NativeMethodInfoPtr__setCallbackColor_b__97_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664039);
		LTDescr.NativeMethodInfoPtr__setTextColor_b__98_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664040);
		LTDescr.NativeMethodInfoPtr__setTextColor_b__98_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664041);
		LTDescr.NativeMethodInfoPtr__setCanvasAlpha_b__99_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664042);
		LTDescr.NativeMethodInfoPtr__setCanvasAlpha_b__99_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664043);
		LTDescr.NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664044);
		LTDescr.NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664045);
		LTDescr.NativeMethodInfoPtr__setCanvasColor_b__101_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664046);
		LTDescr.NativeMethodInfoPtr__setCanvasColor_b__101_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664047);
		LTDescr.NativeMethodInfoPtr__setCanvasMoveX_b__102_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664048);
		LTDescr.NativeMethodInfoPtr__setCanvasMoveX_b__102_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664049);
		LTDescr.NativeMethodInfoPtr__setCanvasMoveY_b__103_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664050);
		LTDescr.NativeMethodInfoPtr__setCanvasMoveY_b__103_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664051);
		LTDescr.NativeMethodInfoPtr__setCanvasMoveZ_b__104_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664052);
		LTDescr.NativeMethodInfoPtr__setCanvasMoveZ_b__104_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664053);
		LTDescr.NativeMethodInfoPtr__setCanvasRotateAround_b__106_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664054);
		LTDescr.NativeMethodInfoPtr__setCanvasRotateAroundLocal_b__107_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664055);
		LTDescr.NativeMethodInfoPtr__setCanvasPlaySprite_b__108_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664056);
		LTDescr.NativeMethodInfoPtr__setCanvasPlaySprite_b__108_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664057);
		LTDescr.NativeMethodInfoPtr__setCanvasMove_b__109_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664058);
		LTDescr.NativeMethodInfoPtr__setCanvasMove_b__109_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664059);
		LTDescr.NativeMethodInfoPtr__setCanvasScale_b__110_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664060);
		LTDescr.NativeMethodInfoPtr__setCanvasScale_b__110_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664061);
		LTDescr.NativeMethodInfoPtr__setCanvasSizeDelta_b__111_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664062);
		LTDescr.NativeMethodInfoPtr__setCanvasSizeDelta_b__111_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664063);
		LTDescr.NativeMethodInfoPtr__setMove_b__115_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664064);
		LTDescr.NativeMethodInfoPtr__setMove_b__115_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664065);
		LTDescr.NativeMethodInfoPtr__setMoveLocal_b__116_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664066);
		LTDescr.NativeMethodInfoPtr__setMoveLocal_b__116_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664067);
		LTDescr.NativeMethodInfoPtr__setMoveToTransform_b__117_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664068);
		LTDescr.NativeMethodInfoPtr__setMoveToTransform_b__117_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664069);
		LTDescr.NativeMethodInfoPtr__setRotate_b__118_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664070);
		LTDescr.NativeMethodInfoPtr__setRotate_b__118_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664071);
		LTDescr.NativeMethodInfoPtr__setRotateLocal_b__119_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664072);
		LTDescr.NativeMethodInfoPtr__setRotateLocal_b__119_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664073);
		LTDescr.NativeMethodInfoPtr__setScale_b__120_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664074);
		LTDescr.NativeMethodInfoPtr__setScale_b__120_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664075);
		LTDescr.NativeMethodInfoPtr__setGUIMove_b__121_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664076);
		LTDescr.NativeMethodInfoPtr__setGUIMove_b__121_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664077);
		LTDescr.NativeMethodInfoPtr__setGUIMoveMargin_b__122_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664078);
		LTDescr.NativeMethodInfoPtr__setGUIMoveMargin_b__122_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664079);
		LTDescr.NativeMethodInfoPtr__setGUIScale_b__123_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664080);
		LTDescr.NativeMethodInfoPtr__setGUIScale_b__123_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664081);
		LTDescr.NativeMethodInfoPtr__setGUIAlpha_b__124_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664082);
		LTDescr.NativeMethodInfoPtr__setGUIAlpha_b__124_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664083);
		LTDescr.NativeMethodInfoPtr__setGUIRotate_b__125_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664084);
		LTDescr.NativeMethodInfoPtr__setGUIRotate_b__125_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664085);
		LTDescr.NativeMethodInfoPtr__setDelayedSound_b__126_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100664086);
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060002BA RID: 698 RVA: 0x0001EF58 File Offset: 0x0001D158
	// (set) Token: 0x060002BB RID: 699 RVA: 0x0001EF98 File Offset: 0x0001D198
	public unsafe Vector3 from
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_from_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_from_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060002BC RID: 700 RVA: 0x0001EFDC File Offset: 0x0001D1DC
	// (set) Token: 0x060002BD RID: 701 RVA: 0x0001F01C File Offset: 0x0001D21C
	public unsafe Vector3 to
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_to_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_to_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060002BE RID: 702 RVA: 0x0001F060 File Offset: 0x0001D260
	// (set) Token: 0x060002BF RID: 703 RVA: 0x0001F0A0 File Offset: 0x0001D2A0
	public unsafe LTDescr.ActionMethodDelegate easeInternal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_easeInternal_Public_get_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr.ActionMethodDelegate>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14877, XrefRangeEnd = 14878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_easeInternal_Public_set_Void_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060002C0 RID: 704 RVA: 0x0001F0E4 File Offset: 0x0001D2E4
	// (set) Token: 0x060002C1 RID: 705 RVA: 0x0001F124 File Offset: 0x0001D324
	public unsafe LTDescr.ActionMethodDelegate initInternal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_initInternal_Public_get_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr.ActionMethodDelegate>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14878, XrefRangeEnd = 14879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_initInternal_Public_set_Void_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060002C2 RID: 706 RVA: 0x0001F168 File Offset: 0x0001D368
	public unsafe Transform toTrans
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 14879, RefRangeEnd = 14919, XrefRangeStart = 14879, XrefRangeEnd = 14879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060002C3 RID: 707 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
	public unsafe int uniqueId
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 14919, RefRangeEnd = 14930, XrefRangeStart = 14919, XrefRangeEnd = 14919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_uniqueId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060002C4 RID: 708 RVA: 0x0001F1E4 File Offset: 0x0001D3E4
	public unsafe int id
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 14919, RefRangeEnd = 14930, XrefRangeStart = 14919, XrefRangeEnd = 14930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060002C5 RID: 709 RVA: 0x0001F220 File Offset: 0x0001D420
	// (set) Token: 0x060002C6 RID: 710 RVA: 0x0001F260 File Offset: 0x0001D460
	public unsafe LTDescrOptional optional
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_get_optional_Public_get_LTDescrOptional_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescrOptional>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14930, XrefRangeEnd = 14931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_set_optional_Public_set_Void_LTDescrOptional_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14937, RefRangeEnd = 14938, XrefRangeStart = 14931, XrefRangeEnd = 14937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescr>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0001F2E0 File Offset: 0x0001D4E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14938, XrefRangeEnd = 15026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LTDescr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0001F324 File Offset: 0x0001D524
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15026, XrefRangeEnd = 15035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr cancel(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_cancel_Public_LTDescr_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x060002CA RID: 714 RVA: 0x0001F374 File Offset: 0x0001D574
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15035, XrefRangeEnd = 15062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002CB RID: 715 RVA: 0x0001F3A8 File Offset: 0x0001D5A8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 15062, RefRangeEnd = 15066, XrefRangeStart = 15062, XrefRangeEnd = 15062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setFollow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFollow_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0001F3E8 File Offset: 0x0001D5E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15082, RefRangeEnd = 15083, XrefRangeStart = 15066, XrefRangeEnd = 15082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0001F428 File Offset: 0x0001D628
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15099, RefRangeEnd = 15100, XrefRangeStart = 15083, XrefRangeEnd = 15099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0001F468 File Offset: 0x0001D668
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15116, RefRangeEnd = 15117, XrefRangeStart = 15100, XrefRangeEnd = 15116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15133, RefRangeEnd = 15134, XrefRangeStart = 15117, XrefRangeEnd = 15133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveLocalX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveLocalX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15150, RefRangeEnd = 15151, XrefRangeStart = 15134, XrefRangeEnd = 15150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveLocalY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveLocalY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0001F528 File Offset: 0x0001D728
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15167, RefRangeEnd = 15168, XrefRangeStart = 15151, XrefRangeEnd = 15167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveLocalZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveLocalZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0001F568 File Offset: 0x0001D768
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 15168, RefRangeEnd = 15175, XrefRangeStart = 15168, XrefRangeEnd = 15168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initFromInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_initFromInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0001F59C File Offset: 0x0001D79C
	[CallerCount(0)]
	public unsafe LTDescr setOffset(Vector3 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(offset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOffset_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0001F5EC File Offset: 0x0001D7EC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15191, RefRangeEnd = 15193, XrefRangeStart = 15175, XrefRangeEnd = 15191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveCurved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveCurved_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0001F62C File Offset: 0x0001D82C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15209, RefRangeEnd = 15211, XrefRangeStart = 15193, XrefRangeEnd = 15209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveCurvedLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveCurvedLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0001F66C File Offset: 0x0001D86C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 15227, RefRangeEnd = 15230, XrefRangeStart = 15211, XrefRangeEnd = 15227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveSpline()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveSpline_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0001F6AC File Offset: 0x0001D8AC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15246, RefRangeEnd = 15248, XrefRangeStart = 15230, XrefRangeEnd = 15246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveSplineLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveSplineLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0001F6EC File Offset: 0x0001D8EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15264, RefRangeEnd = 15265, XrefRangeStart = 15248, XrefRangeEnd = 15264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setScaleX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScaleX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0001F72C File Offset: 0x0001D92C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15281, RefRangeEnd = 15282, XrefRangeStart = 15265, XrefRangeEnd = 15281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setScaleY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScaleY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0001F76C File Offset: 0x0001D96C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15298, RefRangeEnd = 15299, XrefRangeStart = 15282, XrefRangeEnd = 15298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setScaleZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScaleZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0001F7AC File Offset: 0x0001D9AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15315, RefRangeEnd = 15316, XrefRangeStart = 15299, XrefRangeEnd = 15315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0001F7EC File Offset: 0x0001D9EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15332, RefRangeEnd = 15333, XrefRangeStart = 15316, XrefRangeEnd = 15332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0001F82C File Offset: 0x0001DA2C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15349, RefRangeEnd = 15350, XrefRangeStart = 15333, XrefRangeEnd = 15349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0001F86C File Offset: 0x0001DA6C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15366, RefRangeEnd = 15367, XrefRangeStart = 15350, XrefRangeEnd = 15366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateAround()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateAround_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0001F8AC File Offset: 0x0001DAAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15383, RefRangeEnd = 15384, XrefRangeStart = 15367, XrefRangeEnd = 15383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateAroundLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateAroundLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0001F8EC File Offset: 0x0001DAEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15400, RefRangeEnd = 15401, XrefRangeStart = 15384, XrefRangeEnd = 15400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0001F92C File Offset: 0x0001DB2C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15417, RefRangeEnd = 15419, XrefRangeStart = 15401, XrefRangeEnd = 15417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setTextAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTextAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x0001F96C File Offset: 0x0001DB6C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15435, RefRangeEnd = 15436, XrefRangeStart = 15419, XrefRangeEnd = 15435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setAlphaVertex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setAlphaVertex_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0001F9AC File Offset: 0x0001DBAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15452, RefRangeEnd = 15453, XrefRangeStart = 15436, XrefRangeEnd = 15452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0001F9EC File Offset: 0x0001DBEC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 15469, RefRangeEnd = 15472, XrefRangeStart = 15453, XrefRangeEnd = 15469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCallbackColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCallbackColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0001FA2C File Offset: 0x0001DC2C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15488, RefRangeEnd = 15490, XrefRangeStart = 15472, XrefRangeEnd = 15488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setTextColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTextColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0001FA6C File Offset: 0x0001DC6C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15506, RefRangeEnd = 15507, XrefRangeStart = 15490, XrefRangeEnd = 15506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x0001FAAC File Offset: 0x0001DCAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15523, RefRangeEnd = 15524, XrefRangeStart = 15507, XrefRangeEnd = 15523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasGroupAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasGroupAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0001FAEC File Offset: 0x0001DCEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15540, RefRangeEnd = 15541, XrefRangeStart = 15524, XrefRangeEnd = 15540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0001FB2C File Offset: 0x0001DD2C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15557, RefRangeEnd = 15558, XrefRangeStart = 15541, XrefRangeEnd = 15557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasMoveX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasMoveX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0001FB6C File Offset: 0x0001DD6C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15574, RefRangeEnd = 15575, XrefRangeStart = 15558, XrefRangeEnd = 15574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasMoveY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasMoveY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002EB RID: 747 RVA: 0x0001FBAC File Offset: 0x0001DDAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15591, RefRangeEnd = 15592, XrefRangeStart = 15575, XrefRangeEnd = 15591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasMoveZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasMoveZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002EC RID: 748 RVA: 0x0001FBEC File Offset: 0x0001DDEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15592, XrefRangeEnd = 15593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initCanvasRotateAround()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_initCanvasRotateAround_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002ED RID: 749 RVA: 0x0001FC20 File Offset: 0x0001DE20
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 15609, RefRangeEnd = 15612, XrefRangeStart = 15593, XrefRangeEnd = 15609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasRotateAround()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasRotateAround_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002EE RID: 750 RVA: 0x0001FC60 File Offset: 0x0001DE60
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15628, RefRangeEnd = 15629, XrefRangeStart = 15612, XrefRangeEnd = 15628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasRotateAroundLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasRotateAroundLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002EF RID: 751 RVA: 0x0001FCA0 File Offset: 0x0001DEA0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15645, RefRangeEnd = 15646, XrefRangeStart = 15629, XrefRangeEnd = 15645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasPlaySprite()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasPlaySprite_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15662, RefRangeEnd = 15663, XrefRangeStart = 15646, XrefRangeEnd = 15662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasMove_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x0001FD20 File Offset: 0x0001DF20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15679, RefRangeEnd = 15680, XrefRangeStart = 15663, XrefRangeEnd = 15679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasScale_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x0001FD60 File Offset: 0x0001DF60
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15696, RefRangeEnd = 15697, XrefRangeStart = 15680, XrefRangeEnd = 15696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasSizeDelta()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCanvasSizeDelta_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15697, XrefRangeEnd = 15700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void callback()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_callback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0001FDD4 File Offset: 0x0001DFD4
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 15725, RefRangeEnd = 15735, XrefRangeStart = 15700, XrefRangeEnd = 15725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCallback()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setCallback_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0001FE14 File Offset: 0x0001E014
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 15760, RefRangeEnd = 15764, XrefRangeStart = 15735, XrefRangeEnd = 15760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setValue3()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setValue3_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x0001FE54 File Offset: 0x0001E054
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15780, RefRangeEnd = 15782, XrefRangeStart = 15764, XrefRangeEnd = 15780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMove_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0001FE94 File Offset: 0x0001E094
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15798, RefRangeEnd = 15799, XrefRangeStart = 15782, XrefRangeEnd = 15798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0001FED4 File Offset: 0x0001E0D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15815, RefRangeEnd = 15816, XrefRangeStart = 15799, XrefRangeEnd = 15815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveToTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setMoveToTransform_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x0001FF14 File Offset: 0x0001E114
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15832, RefRangeEnd = 15833, XrefRangeStart = 15816, XrefRangeEnd = 15832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotate_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0001FF54 File Offset: 0x0001E154
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15849, RefRangeEnd = 15850, XrefRangeStart = 15833, XrefRangeEnd = 15849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRotateLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002FB RID: 763 RVA: 0x0001FF94 File Offset: 0x0001E194
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15866, RefRangeEnd = 15867, XrefRangeStart = 15850, XrefRangeEnd = 15866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScale_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15883, RefRangeEnd = 15884, XrefRangeStart = 15867, XrefRangeEnd = 15883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIMove_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00020014 File Offset: 0x0001E214
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15900, RefRangeEnd = 15901, XrefRangeStart = 15884, XrefRangeEnd = 15900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIMoveMargin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIMoveMargin_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00020054 File Offset: 0x0001E254
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15917, RefRangeEnd = 15918, XrefRangeStart = 15901, XrefRangeEnd = 15917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIScale_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00020094 File Offset: 0x0001E294
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15934, RefRangeEnd = 15935, XrefRangeStart = 15918, XrefRangeEnd = 15934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000300 RID: 768 RVA: 0x000200D4 File Offset: 0x0001E2D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15951, RefRangeEnd = 15952, XrefRangeStart = 15935, XrefRangeEnd = 15951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIRotate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setGUIRotate_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00020114 File Offset: 0x0001E314
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15968, RefRangeEnd = 15970, XrefRangeStart = 15952, XrefRangeEnd = 15968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setDelayedSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDelayedSound_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00020154 File Offset: 0x0001E354
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 15971, RefRangeEnd = 15976, XrefRangeStart = 15970, XrefRangeEnd = 15971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setTarget(Transform trans)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTarget_Public_LTDescr_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000303 RID: 771 RVA: 0x000201A4 File Offset: 0x0001E3A4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 15982, RefRangeEnd = 15985, XrefRangeStart = 15976, XrefRangeEnd = 15982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000304 RID: 772 RVA: 0x000201D8 File Offset: 0x0001E3D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15990, RefRangeEnd = 15992, XrefRangeStart = 15985, XrefRangeEnd = 15990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_initSpeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0002020C File Offset: 0x0001E40C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15992, XrefRangeEnd = 15993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr updateNow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_updateNow_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0002024C File Offset: 0x0001E44C
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 16037, RefRangeEnd = 16049, XrefRangeStart = 15993, XrefRangeEnd = 16037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool updateInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_updateInternal_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00020288 File Offset: 0x0001E488
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 16052, RefRangeEnd = 16055, XrefRangeStart = 16049, XrefRangeEnd = 16052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void callOnCompletes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_callOnCompletes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000308 RID: 776 RVA: 0x000202BC File Offset: 0x0001E4BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16055, RefRangeEnd = 16056, XrefRangeStart = 16055, XrefRangeEnd = 16055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setFromColor(Color col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFromColor_Public_LTDescr_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000309 RID: 777 RVA: 0x0002030C File Offset: 0x0001E50C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 16101, RefRangeEnd = 16104, XrefRangeStart = 16056, XrefRangeEnd = 16101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useRecursion;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_Transform_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00020360 File Offset: 0x0001E560
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 16135, RefRangeEnd = 16138, XrefRangeStart = 16104, XrefRangeEnd = 16135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toColor);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useRecursion;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_colorRecursive_Private_Static_Void_Transform_Color_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600030B RID: 779 RVA: 0x000203B8 File Offset: 0x0001E5B8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16172, RefRangeEnd = 16174, XrefRangeStart = 16138, XrefRangeEnd = 16172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursiveLevel;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_RectTransform_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600030C RID: 780 RVA: 0x0002040C File Offset: 0x0001E60C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16205, RefRangeEnd = 16206, XrefRangeStart = 16174, XrefRangeEnd = 16205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void alphaRecursiveSprite(Transform transform, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_alphaRecursiveSprite_Private_Static_Void_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00020450 File Offset: 0x0001E650
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 16237, RefRangeEnd = 16240, XrefRangeStart = 16206, XrefRangeEnd = 16237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void colorRecursiveSprite(Transform transform, Color toColor)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toColor);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_colorRecursiveSprite_Private_Static_Void_Transform_Color_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00020498 File Offset: 0x0001E698
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16274, RefRangeEnd = 16276, XrefRangeStart = 16240, XrefRangeEnd = 16274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toColor);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_colorRecursive_Private_Static_Void_RectTransform_Color_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600030F RID: 783 RVA: 0x000204E0 File Offset: 0x0001E6E0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16303, RefRangeEnd = 16305, XrefRangeStart = 16276, XrefRangeEnd = 16303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useRecursion;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_textAlphaChildrenRecursive_Private_Static_Void_Transform_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00020534 File Offset: 0x0001E734
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16332, RefRangeEnd = 16334, XrefRangeStart = 16305, XrefRangeEnd = 16332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useRecursion;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_textAlphaRecursive_Private_Static_Void_Transform_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00020588 File Offset: 0x0001E788
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16361, RefRangeEnd = 16363, XrefRangeStart = 16334, XrefRangeEnd = 16361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void textColorRecursive(Transform trans, Color toColor)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toColor);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_textColorRecursive_Private_Static_Void_Transform_Color_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000312 RID: 786 RVA: 0x000205D0 File Offset: 0x0001E7D0
	[CallerCount(0)]
	public unsafe static Color tweenColor(LTDescr tween, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_tweenColor_Private_Static_Color_LTDescr_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00020624 File Offset: 0x0001E824
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 16363, RefRangeEnd = 16367, XrefRangeStart = 16363, XrefRangeEnd = 16363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_pause_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00020664 File Offset: 0x0001E864
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 16367, RefRangeEnd = 16371, XrefRangeStart = 16367, XrefRangeEnd = 16367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr resume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_resume_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x000206A4 File Offset: 0x0001E8A4
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 16371, RefRangeEnd = 16379, XrefRangeStart = 16371, XrefRangeEnd = 16371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setAxis(Vector3 axis)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setAxis_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000316 RID: 790 RVA: 0x000206F4 File Offset: 0x0001E8F4
	[CallerCount(0)]
	public unsafe LTDescr setDelay(float delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDelay_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00020740 File Offset: 0x0001E940
	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 16649, RefRangeEnd = 16675, XrefRangeStart = 16379, XrefRangeEnd = 16649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEase(LeanTweenType easeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(easeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEase_Public_LTDescr_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00020790 File Offset: 0x0001E990
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16684, RefRangeEnd = 16685, XrefRangeStart = 16675, XrefRangeEnd = 16684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseLinear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseLinear_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x000207D0 File Offset: 0x0001E9D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16685, XrefRangeEnd = 16694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseSpring()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseSpring_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00020810 File Offset: 0x0001EA10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16694, XrefRangeEnd = 16703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInQuad_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00020850 File Offset: 0x0001EA50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16703, XrefRangeEnd = 16712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutQuad_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00020890 File Offset: 0x0001EA90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16712, XrefRangeEnd = 16721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutQuad_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x000208D0 File Offset: 0x0001EAD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16721, XrefRangeEnd = 16730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInCubic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00020910 File Offset: 0x0001EB10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16730, XrefRangeEnd = 16739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutCubic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x00020950 File Offset: 0x0001EB50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16739, XrefRangeEnd = 16748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutCubic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00020990 File Offset: 0x0001EB90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16748, XrefRangeEnd = 16757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInQuart_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000321 RID: 801 RVA: 0x000209D0 File Offset: 0x0001EBD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16757, XrefRangeEnd = 16766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutQuart_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00020A10 File Offset: 0x0001EC10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16766, XrefRangeEnd = 16775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutQuart_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00020A50 File Offset: 0x0001EC50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16775, XrefRangeEnd = 16784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInQuint_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00020A90 File Offset: 0x0001EC90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16784, XrefRangeEnd = 16793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutQuint_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00020AD0 File Offset: 0x0001ECD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16793, XrefRangeEnd = 16802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutQuint_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00020B10 File Offset: 0x0001ED10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16802, XrefRangeEnd = 16811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInSine_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00020B50 File Offset: 0x0001ED50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16811, XrefRangeEnd = 16820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutSine_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00020B90 File Offset: 0x0001ED90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16820, XrefRangeEnd = 16829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutSine_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00020BD0 File Offset: 0x0001EDD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16829, XrefRangeEnd = 16838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInExpo_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600032A RID: 810 RVA: 0x00020C10 File Offset: 0x0001EE10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16838, XrefRangeEnd = 16847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutExpo_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00020C50 File Offset: 0x0001EE50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16847, XrefRangeEnd = 16856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutExpo_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x00020C90 File Offset: 0x0001EE90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16856, XrefRangeEnd = 16865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInCirc_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00020CD0 File Offset: 0x0001EED0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16865, XrefRangeEnd = 16874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutCirc_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00020D10 File Offset: 0x0001EF10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16874, XrefRangeEnd = 16883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutCirc_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00020D50 File Offset: 0x0001EF50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16883, XrefRangeEnd = 16892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInBounce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00020D90 File Offset: 0x0001EF90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16892, XrefRangeEnd = 16901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutBounce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00020DD0 File Offset: 0x0001EFD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16901, XrefRangeEnd = 16910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutBounce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00020E10 File Offset: 0x0001F010
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16910, XrefRangeEnd = 16919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInBack_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00020E50 File Offset: 0x0001F050
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16919, XrefRangeEnd = 16928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutBack_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00020E90 File Offset: 0x0001F090
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16928, XrefRangeEnd = 16937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutBack_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00020ED0 File Offset: 0x0001F0D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16937, XrefRangeEnd = 16946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInElastic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00020F10 File Offset: 0x0001F110
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16946, XrefRangeEnd = 16955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseOutElastic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00020F50 File Offset: 0x0001F150
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16955, XrefRangeEnd = 16964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseInOutElastic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x00020F90 File Offset: 0x0001F190
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16964, XrefRangeEnd = 16978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEasePunch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEasePunch_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00020FD0 File Offset: 0x0001F1D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16978, XrefRangeEnd = 16992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseShake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEaseShake_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600033A RID: 826 RVA: 0x00021010 File Offset: 0x0001F210
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16992, XrefRangeEnd = 16995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 tweenOnCurve()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_tweenOnCurve_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600033B RID: 827 RVA: 0x00021050 File Offset: 0x0001F250
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16995, XrefRangeEnd = 17001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutQuad_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00021090 File Offset: 0x0001F290
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17001, XrefRangeEnd = 17004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInQuad_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600033D RID: 829 RVA: 0x000210D0 File Offset: 0x0001F2D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17004, XrefRangeEnd = 17008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutQuad_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00021110 File Offset: 0x0001F310
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17008, XrefRangeEnd = 17011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeLinear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeLinear_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00021150 File Offset: 0x0001F350
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17011, XrefRangeEnd = 17018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeSpring()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeSpring_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00021190 File Offset: 0x0001F390
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17018, XrefRangeEnd = 17021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInCubic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000341 RID: 833 RVA: 0x000211D0 File Offset: 0x0001F3D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17021, XrefRangeEnd = 17025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutCubic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00021210 File Offset: 0x0001F410
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17025, XrefRangeEnd = 17031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutCubic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00021250 File Offset: 0x0001F450
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17031, XrefRangeEnd = 17034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInQuart_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00021290 File Offset: 0x0001F490
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17034, XrefRangeEnd = 17038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutQuart_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000345 RID: 837 RVA: 0x000212D0 File Offset: 0x0001F4D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17038, XrefRangeEnd = 17042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutQuart_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00021310 File Offset: 0x0001F510
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17042, XrefRangeEnd = 17046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInQuint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00021350 File Offset: 0x0001F550
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17046, XrefRangeEnd = 17050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutQuint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00021390 File Offset: 0x0001F590
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17050, XrefRangeEnd = 17056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutQuint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000349 RID: 841 RVA: 0x000213D0 File Offset: 0x0001F5D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17056, XrefRangeEnd = 17064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInSine_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00021410 File Offset: 0x0001F610
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17064, XrefRangeEnd = 17072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutSine_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00021450 File Offset: 0x0001F650
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17072, XrefRangeEnd = 17076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutSine_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00021490 File Offset: 0x0001F690
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17076, XrefRangeEnd = 17080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInExpo_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600034D RID: 845 RVA: 0x000214D0 File Offset: 0x0001F6D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17080, XrefRangeEnd = 17084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutExpo_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00021510 File Offset: 0x0001F710
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17084, XrefRangeEnd = 17091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutExpo_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00021550 File Offset: 0x0001F750
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17091, XrefRangeEnd = 17096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInCirc_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00021590 File Offset: 0x0001F790
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17096, XrefRangeEnd = 17102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutCirc_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000351 RID: 849 RVA: 0x000215D0 File Offset: 0x0001F7D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17102, XrefRangeEnd = 17112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutCirc_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00021610 File Offset: 0x0001F810
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17112, XrefRangeEnd = 17124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInBounce_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00021650 File Offset: 0x0001F850
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17124, XrefRangeEnd = 17134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutBounce_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00021690 File Offset: 0x0001F890
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17134, XrefRangeEnd = 17154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutBounce_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000355 RID: 853 RVA: 0x000216D0 File Offset: 0x0001F8D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17154, XrefRangeEnd = 17157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInBack_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00021710 File Offset: 0x0001F910
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17157, XrefRangeEnd = 17161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutBack_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00021750 File Offset: 0x0001F950
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17161, XrefRangeEnd = 17166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutBack_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00021790 File Offset: 0x0001F990
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17166, XrefRangeEnd = 17172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInElastic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x000217D0 File Offset: 0x0001F9D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17172, XrefRangeEnd = 17178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeOutElastic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00021810 File Offset: 0x0001FA10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17178, XrefRangeEnd = 17184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_easeInOutElastic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00021850 File Offset: 0x0001FA50
	[CallerCount(0)]
	public unsafe LTDescr setOvershoot(float overshoot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref overshoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOvershoot_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600035C RID: 860 RVA: 0x0002189C File Offset: 0x0001FA9C
	[CallerCount(0)]
	public unsafe LTDescr setPeriod(float period)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setPeriod_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600035D RID: 861 RVA: 0x000218E8 File Offset: 0x0001FAE8
	[CallerCount(0)]
	public unsafe LTDescr setScale(float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setScale_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00021934 File Offset: 0x0001FB34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17184, XrefRangeEnd = 17194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEase(AnimationCurve easeCurve)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(easeCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setEase_Public_LTDescr_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00021984 File Offset: 0x0001FB84
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 17194, RefRangeEnd = 17202, XrefRangeStart = 17194, XrefRangeEnd = 17194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setTo(Vector3 to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTo_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000360 RID: 864 RVA: 0x000219D4 File Offset: 0x0001FBD4
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 15971, RefRangeEnd = 15976, XrefRangeStart = 15971, XrefRangeEnd = 15976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setTo(Transform to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTo_Public_LTDescr_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00021A24 File Offset: 0x0001FC24
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 17207, RefRangeEnd = 17220, XrefRangeStart = 17202, XrefRangeEnd = 17207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setFrom(Vector3 from)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFrom_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00021A74 File Offset: 0x0001FC74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17220, XrefRangeEnd = 17225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setFrom(float from)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref from;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFrom_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00021AC0 File Offset: 0x0001FCC0
	[CallerCount(0)]
	public unsafe LTDescr setDiff(Vector3 diff)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(diff);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDiff_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00021B10 File Offset: 0x0001FD10
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 17225, RefRangeEnd = 17228, XrefRangeStart = 17225, XrefRangeEnd = 17225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setHasInitialized(bool has)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref has;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setHasInitialized_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00021B5C File Offset: 0x0001FD5C
	[CallerCount(0)]
	public unsafe LTDescr setId(uint id, uint global_counter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref global_counter;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setId_Public_LTDescr_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00021BB8 File Offset: 0x0001FDB8
	[CallerCount(0)]
	public unsafe LTDescr setPassed(float passed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref passed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setPassed_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00021C04 File Offset: 0x0001FE04
	[CallerCount(0)]
	public unsafe LTDescr setTime(float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setTime_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00021C50 File Offset: 0x0001FE50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17228, XrefRangeEnd = 17229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setSpeed(float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setSpeed_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00021C9C File Offset: 0x0001FE9C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17229, RefRangeEnd = 17230, XrefRangeStart = 17229, XrefRangeEnd = 17229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRepeat(int repeat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref repeat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRepeat_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00021CE8 File Offset: 0x0001FEE8
	[CallerCount(0)]
	public unsafe LTDescr setLoopType(LeanTweenType loopType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loopType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopType_Public_LTDescr_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00021D38 File Offset: 0x0001FF38
	[CallerCount(0)]
	public unsafe LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref useEstimatedTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setUseEstimatedTime_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00021D84 File Offset: 0x0001FF84
	[CallerCount(0)]
	public unsafe LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref useUnScaledTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setIgnoreTimeScale_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600036D RID: 877 RVA: 0x00021DD0 File Offset: 0x0001FFD0
	[CallerCount(0)]
	public unsafe LTDescr setUseFrames(bool useFrames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref useFrames;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setUseFrames_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00021E1C File Offset: 0x0002001C
	[CallerCount(0)]
	public unsafe LTDescr setUseManualTime(bool useManualTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref useManualTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setUseManualTime_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00021E68 File Offset: 0x00020068
	[CallerCount(0)]
	public unsafe LTDescr setLoopCount(int loopCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref loopCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopCount_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00021EB4 File Offset: 0x000200B4
	[CallerCount(0)]
	public unsafe LTDescr setLoopOnce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopOnce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00021EF4 File Offset: 0x000200F4
	[CallerCount(0)]
	public unsafe LTDescr setLoopClamp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00021F34 File Offset: 0x00020134
	[CallerCount(0)]
	public unsafe LTDescr setLoopClamp(int loops)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref loops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00021F80 File Offset: 0x00020180
	[CallerCount(0)]
	public unsafe LTDescr setLoopPingPong()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00021FC0 File Offset: 0x000201C0
	[CallerCount(0)]
	public unsafe LTDescr setLoopPingPong(int loops)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref loops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000375 RID: 885 RVA: 0x0002200C File Offset: 0x0002020C
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 17231, RefRangeEnd = 17246, XrefRangeStart = 17230, XrefRangeEnd = 17231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnComplete(Action onComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000376 RID: 886 RVA: 0x0002205C File Offset: 0x0002025C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 17247, RefRangeEnd = 17249, XrefRangeStart = 17246, XrefRangeEnd = 17247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnComplete(Action<global::Il2CppSystem.Object> onComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000377 RID: 887 RVA: 0x000220AC File Offset: 0x000202AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17249, XrefRangeEnd = 17251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnComplete(Action<global::Il2CppSystem.Object> onComplete, global::Il2CppSystem.Object onCompleteParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCompleteParam);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00022110 File Offset: 0x00020310
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17251, XrefRangeEnd = 17252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnCompleteParam(global::Il2CppSystem.Object onCompleteParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onCompleteParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnCompleteParam_Public_LTDescr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00022160 File Offset: 0x00020360
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 17253, RefRangeEnd = 17261, XrefRangeStart = 17252, XrefRangeEnd = 17253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdate(Action<float> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600037A RID: 890 RVA: 0x000221B0 File Offset: 0x000203B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17262, RefRangeEnd = 17263, XrefRangeStart = 17261, XrefRangeEnd = 17262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateRatio_Public_LTDescr_Action_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00022200 File Offset: 0x00020400
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17263, XrefRangeEnd = 17264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdateObject(Action<float, global::Il2CppSystem.Object> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateObject_Public_LTDescr_Action_2_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00022250 File Offset: 0x00020450
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17265, RefRangeEnd = 17266, XrefRangeStart = 17264, XrefRangeEnd = 17265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateVector2_Public_LTDescr_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600037D RID: 893 RVA: 0x000222A0 File Offset: 0x000204A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17267, RefRangeEnd = 17268, XrefRangeStart = 17266, XrefRangeEnd = 17267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateVector3_Public_LTDescr_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600037E RID: 894 RVA: 0x000222F0 File Offset: 0x000204F0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 17269, RefRangeEnd = 17271, XrefRangeStart = 17268, XrefRangeEnd = 17269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00022340 File Offset: 0x00020540
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17272, RefRangeEnd = 17273, XrefRangeStart = 17271, XrefRangeEnd = 17272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdateColor(Action<Color, global::Il2CppSystem.Object> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000380 RID: 896 RVA: 0x00022390 File Offset: 0x00020590
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 17269, RefRangeEnd = 17271, XrefRangeStart = 17269, XrefRangeEnd = 17271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000381 RID: 897 RVA: 0x000223E0 File Offset: 0x000205E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17272, RefRangeEnd = 17273, XrefRangeStart = 17272, XrefRangeEnd = 17273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdate(Action<Color, global::Il2CppSystem.Object> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00022430 File Offset: 0x00020630
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17275, RefRangeEnd = 17276, XrefRangeStart = 17273, XrefRangeEnd = 17275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdate(Action<float, global::Il2CppSystem.Object> onUpdate, global::Il2CppSystem.Object onUpdateParam = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Single_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00022494 File Offset: 0x00020694
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17276, XrefRangeEnd = 17278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdate(Action<Vector3, global::Il2CppSystem.Object> onUpdate, global::Il2CppSystem.Object onUpdateParam = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Vector3_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000384 RID: 900 RVA: 0x000224F8 File Offset: 0x000206F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17280, RefRangeEnd = 17281, XrefRangeStart = 17278, XrefRangeEnd = 17280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdate(Action<Vector2> onUpdate, global::Il2CppSystem.Object onUpdateParam = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector2_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000385 RID: 901 RVA: 0x0002255C File Offset: 0x0002075C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17283, RefRangeEnd = 17284, XrefRangeStart = 17281, XrefRangeEnd = 17283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdate(Action<Vector3> onUpdate, global::Il2CppSystem.Object onUpdateParam = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector3_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000386 RID: 902 RVA: 0x000225C0 File Offset: 0x000207C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17284, XrefRangeEnd = 17285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdateParam(global::Il2CppSystem.Object onUpdateParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnUpdateParam_Public_LTDescr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00022610 File Offset: 0x00020810
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17285, XrefRangeEnd = 17286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOrientToPath(bool doesOrient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref doesOrient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOrientToPath_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000388 RID: 904 RVA: 0x0002265C File Offset: 0x0002085C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17286, XrefRangeEnd = 17292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref doesOrient2d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOrientToPath2d_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000389 RID: 905 RVA: 0x000226A8 File Offset: 0x000208A8
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 17293, RefRangeEnd = 17299, XrefRangeStart = 17292, XrefRangeEnd = 17293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRect(LTRect rect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_LTRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600038A RID: 906 RVA: 0x000226F8 File Offset: 0x000208F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17299, XrefRangeEnd = 17304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRect(Rect rect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00022748 File Offset: 0x00020948
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17304, XrefRangeEnd = 17305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setPath(LTBezierPath path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setPath_Public_LTDescr_LTBezierPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00022798 File Offset: 0x00020998
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 17305, RefRangeEnd = 17312, XrefRangeStart = 17305, XrefRangeEnd = 17305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setPoint(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setPoint_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600038D RID: 909 RVA: 0x000227E8 File Offset: 0x000209E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17312, RefRangeEnd = 17313, XrefRangeStart = 17312, XrefRangeEnd = 17312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref doesDestroy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDestroyOnComplete_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00022834 File Offset: 0x00020A34
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 17314, RefRangeEnd = 17316, XrefRangeStart = 17313, XrefRangeEnd = 17314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setAudio(global::Il2CppSystem.Object audio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setAudio_Public_LTDescr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00022884 File Offset: 0x00020A84
	[CallerCount(0)]
	public unsafe LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnCompleteOnRepeat_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000390 RID: 912 RVA: 0x000228D0 File Offset: 0x00020AD0
	[CallerCount(0)]
	public unsafe LTDescr setOnCompleteOnStart(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnCompleteOnStart_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000391 RID: 913 RVA: 0x0002291C File Offset: 0x00020B1C
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 17317, RefRangeEnd = 17329, XrefRangeStart = 17316, XrefRangeEnd = 17317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRect(RectTransform rect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRect_Public_LTDescr_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0002296C File Offset: 0x00020B6C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17330, RefRangeEnd = 17331, XrefRangeStart = 17329, XrefRangeEnd = 17330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setSprites(Il2CppReferenceArray<Sprite> sprites)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprites);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setSprites_Public_LTDescr_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000393 RID: 915 RVA: 0x000229BC File Offset: 0x00020BBC
	[CallerCount(0)]
	public unsafe LTDescr setFrameRate(float frameRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref frameRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setFrameRate_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00022A08 File Offset: 0x00020C08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17331, XrefRangeEnd = 17332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnStart(Action onStart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onStart);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setOnStart_Public_LTDescr_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00022A58 File Offset: 0x00020C58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17332, XrefRangeEnd = 17349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setDirection(float direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setDirection_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00022AA4 File Offset: 0x00020CA4
	[CallerCount(0)]
	public unsafe LTDescr setRecursive(bool useRecursion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref useRecursion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr_setRecursive_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
		}
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00022AF0 File Offset: 0x00020CF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17349, XrefRangeEnd = 17350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveX_b__73_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveX_b__73_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00022B24 File Offset: 0x00020D24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17350, XrefRangeEnd = 17353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveX_b__73_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveX_b__73_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00022B58 File Offset: 0x00020D58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17353, XrefRangeEnd = 17354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveY_b__74_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveY_b__74_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00022B8C File Offset: 0x00020D8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17354, XrefRangeEnd = 17357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveY_b__74_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveY_b__74_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00022BC0 File Offset: 0x00020DC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17357, XrefRangeEnd = 17358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveZ_b__75_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveZ_b__75_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00022BF4 File Offset: 0x00020DF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17358, XrefRangeEnd = 17361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveZ_b__75_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveZ_b__75_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00022C28 File Offset: 0x00020E28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17361, XrefRangeEnd = 17362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalX_b__76_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalX_b__76_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00022C5C File Offset: 0x00020E5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17362, XrefRangeEnd = 17365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalX_b__76_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalX_b__76_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00022C90 File Offset: 0x00020E90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17365, XrefRangeEnd = 17366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalY_b__77_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalY_b__77_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00022CC4 File Offset: 0x00020EC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17366, XrefRangeEnd = 17369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalY_b__77_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalY_b__77_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00022CF8 File Offset: 0x00020EF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17369, XrefRangeEnd = 17370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalZ_b__78_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalZ_b__78_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00022D2C File Offset: 0x00020F2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17370, XrefRangeEnd = 17373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalZ_b__78_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocalZ_b__78_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00022D60 File Offset: 0x00020F60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17373, XrefRangeEnd = 17379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveCurved_b__81_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveCurved_b__81_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00022D94 File Offset: 0x00020F94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17379, XrefRangeEnd = 17385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveCurvedLocal_b__82_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveCurvedLocal_b__82_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00022DC8 File Offset: 0x00020FC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17385, XrefRangeEnd = 17391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveSpline_b__83_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveSpline_b__83_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00022DFC File Offset: 0x00020FFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17391, XrefRangeEnd = 17397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveSplineLocal_b__84_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveSplineLocal_b__84_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00022E30 File Offset: 0x00021030
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17397, XrefRangeEnd = 17398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleX_b__85_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleX_b__85_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00022E64 File Offset: 0x00021064
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17398, XrefRangeEnd = 17401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleX_b__85_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleX_b__85_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00022E98 File Offset: 0x00021098
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17401, XrefRangeEnd = 17402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleY_b__86_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleY_b__86_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00022ECC File Offset: 0x000210CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17402, XrefRangeEnd = 17405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleY_b__86_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleY_b__86_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00022F00 File Offset: 0x00021100
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17405, XrefRangeEnd = 17406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleZ_b__87_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleZ_b__87_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00022F34 File Offset: 0x00021134
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17406, XrefRangeEnd = 17409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleZ_b__87_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScaleZ_b__87_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00022F68 File Offset: 0x00021168
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17409, XrefRangeEnd = 17414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateX_b__88_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateX_b__88_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00022F9C File Offset: 0x0002119C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17414, XrefRangeEnd = 17417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateX_b__88_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateX_b__88_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00022FD0 File Offset: 0x000211D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17417, XrefRangeEnd = 17422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateY_b__89_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateY_b__89_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00023004 File Offset: 0x00021204
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17422, XrefRangeEnd = 17425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateY_b__89_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateY_b__89_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00023038 File Offset: 0x00021238
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17425, XrefRangeEnd = 17430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateZ_b__90_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateZ_b__90_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x0002306C File Offset: 0x0002126C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17430, XrefRangeEnd = 17433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateZ_b__90_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateZ_b__90_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x000230A0 File Offset: 0x000212A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17433, XrefRangeEnd = 17434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateAround_b__91_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateAround_b__91_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x000230D4 File Offset: 0x000212D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17434, XrefRangeEnd = 17447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateAround_b__91_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateAround_b__91_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00023108 File Offset: 0x00021308
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17447, XrefRangeEnd = 17448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateAroundLocal_b__92_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateAroundLocal_b__92_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x0002313C File Offset: 0x0002133C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17448, XrefRangeEnd = 17463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateAroundLocal_b__92_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateAroundLocal_b__92_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00023170 File Offset: 0x00021370
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17463, XrefRangeEnd = 17545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlpha_b__93_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlpha_b__93_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x000231A4 File Offset: 0x000213A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17545, XrefRangeEnd = 17553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlpha_b__93_2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlpha_b__93_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x000231D8 File Offset: 0x000213D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17553, XrefRangeEnd = 17562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlpha_b__93_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlpha_b__93_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003BA RID: 954 RVA: 0x0002320C File Offset: 0x0002140C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17562, XrefRangeEnd = 17570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setTextAlpha_b__94_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setTextAlpha_b__94_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00023240 File Offset: 0x00021440
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17570, XrefRangeEnd = 17572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setTextAlpha_b__94_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setTextAlpha_b__94_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00023274 File Offset: 0x00021474
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17572, XrefRangeEnd = 17577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlphaVertex_b__95_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlphaVertex_b__95_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003BD RID: 957 RVA: 0x000232A8 File Offset: 0x000214A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17577, XrefRangeEnd = 17600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlphaVertex_b__95_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setAlphaVertex_b__95_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003BE RID: 958 RVA: 0x000232DC File Offset: 0x000214DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17600, XrefRangeEnd = 17673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setColor_b__96_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setColor_b__96_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00023310 File Offset: 0x00021510
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17673, XrefRangeEnd = 17686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setColor_b__96_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setColor_b__96_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00023344 File Offset: 0x00021544
	[CallerCount(0)]
	public unsafe void _setCallbackColor_b__97_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCallbackColor_b__97_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00023378 File Offset: 0x00021578
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17686, XrefRangeEnd = 17699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCallbackColor_b__97_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCallbackColor_b__97_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x000233AC File Offset: 0x000215AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17699, XrefRangeEnd = 17708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setTextColor_b__98_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setTextColor_b__98_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x000233E0 File Offset: 0x000215E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17708, XrefRangeEnd = 17715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setTextColor_b__98_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setTextColor_b__98_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00023414 File Offset: 0x00021614
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17715, XrefRangeEnd = 17730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasAlpha_b__99_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasAlpha_b__99_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00023448 File Offset: 0x00021648
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17730, XrefRangeEnd = 17747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasAlpha_b__99_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasAlpha_b__99_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x0002347C File Offset: 0x0002167C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17747, XrefRangeEnd = 17751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasGroupAlpha_b__100_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x000234B0 File Offset: 0x000216B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17751, XrefRangeEnd = 17756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasGroupAlpha_b__100_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x000234E4 File Offset: 0x000216E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17756, XrefRangeEnd = 17773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasColor_b__101_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasColor_b__101_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00023518 File Offset: 0x00021718
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17773, XrefRangeEnd = 17787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasColor_b__101_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasColor_b__101_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003CA RID: 970 RVA: 0x0002354C File Offset: 0x0002174C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17787, XrefRangeEnd = 17788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveX_b__102_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveX_b__102_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00023580 File Offset: 0x00021780
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17788, XrefRangeEnd = 17790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveX_b__102_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveX_b__102_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003CC RID: 972 RVA: 0x000235B4 File Offset: 0x000217B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17790, XrefRangeEnd = 17791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveY_b__103_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveY_b__103_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003CD RID: 973 RVA: 0x000235E8 File Offset: 0x000217E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17791, XrefRangeEnd = 17793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveY_b__103_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveY_b__103_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003CE RID: 974 RVA: 0x0002361C File Offset: 0x0002181C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17793, XrefRangeEnd = 17794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveZ_b__104_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveZ_b__104_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00023650 File Offset: 0x00021850
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17794, XrefRangeEnd = 17796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveZ_b__104_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMoveZ_b__104_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00023684 File Offset: 0x00021884
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17796, XrefRangeEnd = 17809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasRotateAround_b__106_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasRotateAround_b__106_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x000236B8 File Offset: 0x000218B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17809, XrefRangeEnd = 17824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasRotateAroundLocal_b__107_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasRotateAroundLocal_b__107_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x000236EC File Offset: 0x000218EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17824, XrefRangeEnd = 17828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasPlaySprite_b__108_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasPlaySprite_b__108_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00023720 File Offset: 0x00021920
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17828, XrefRangeEnd = 17836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasPlaySprite_b__108_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasPlaySprite_b__108_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00023754 File Offset: 0x00021954
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17836, XrefRangeEnd = 17837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMove_b__109_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMove_b__109_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00023788 File Offset: 0x00021988
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17837, XrefRangeEnd = 17838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMove_b__109_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasMove_b__109_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x000237BC File Offset: 0x000219BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17838, XrefRangeEnd = 17839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasScale_b__110_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasScale_b__110_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x000237F0 File Offset: 0x000219F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17839, XrefRangeEnd = 17840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasScale_b__110_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasScale_b__110_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00023824 File Offset: 0x00021A24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17840, XrefRangeEnd = 17841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasSizeDelta_b__111_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasSizeDelta_b__111_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00023858 File Offset: 0x00021A58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17841, XrefRangeEnd = 17843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasSizeDelta_b__111_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setCanvasSizeDelta_b__111_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003DA RID: 986 RVA: 0x0002388C File Offset: 0x00021A8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17843, XrefRangeEnd = 17844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMove_b__115_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMove_b__115_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003DB RID: 987 RVA: 0x000238C0 File Offset: 0x00021AC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17844, XrefRangeEnd = 17848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMove_b__115_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMove_b__115_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003DC RID: 988 RVA: 0x000238F4 File Offset: 0x00021AF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17848, XrefRangeEnd = 17849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocal_b__116_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocal_b__116_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00023928 File Offset: 0x00021B28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17849, XrefRangeEnd = 17853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocal_b__116_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveLocal_b__116_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003DE RID: 990 RVA: 0x0002395C File Offset: 0x00021B5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveToTransform_b__117_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveToTransform_b__117_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00023990 File Offset: 0x00021B90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17853, XrefRangeEnd = 17858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveToTransform_b__117_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setMoveToTransform_b__117_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x000239C4 File Offset: 0x00021BC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17858, XrefRangeEnd = 17865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotate_b__118_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotate_b__118_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x000239F8 File Offset: 0x00021BF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17865, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotate_b__118_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotate_b__118_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00023A2C File Offset: 0x00021C2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17869, XrefRangeEnd = 17876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateLocal_b__119_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateLocal_b__119_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00023A60 File Offset: 0x00021C60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17876, XrefRangeEnd = 17880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateLocal_b__119_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setRotateLocal_b__119_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00023A94 File Offset: 0x00021C94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17880, XrefRangeEnd = 17881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScale_b__120_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScale_b__120_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00023AC8 File Offset: 0x00021CC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17881, XrefRangeEnd = 17885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScale_b__120_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setScale_b__120_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00023AFC File Offset: 0x00021CFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17885, XrefRangeEnd = 17890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIMove_b__121_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIMove_b__121_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00023B30 File Offset: 0x00021D30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17890, XrefRangeEnd = 17895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIMove_b__121_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIMove_b__121_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00023B64 File Offset: 0x00021D64
	[CallerCount(0)]
	public unsafe void _setGUIMoveMargin_b__122_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIMoveMargin_b__122_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00023B98 File Offset: 0x00021D98
	[CallerCount(0)]
	public unsafe void _setGUIMoveMargin_b__122_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIMoveMargin_b__122_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00023BCC File Offset: 0x00021DCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17895, XrefRangeEnd = 17900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIScale_b__123_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIScale_b__123_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00023C00 File Offset: 0x00021E00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17900, XrefRangeEnd = 17905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIScale_b__123_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIScale_b__123_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00023C34 File Offset: 0x00021E34
	[CallerCount(0)]
	public unsafe void _setGUIAlpha_b__124_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIAlpha_b__124_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00023C68 File Offset: 0x00021E68
	[CallerCount(0)]
	public unsafe void _setGUIAlpha_b__124_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIAlpha_b__124_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00023C9C File Offset: 0x00021E9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17905, XrefRangeEnd = 17906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIRotate_b__125_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIRotate_b__125_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00023CD0 File Offset: 0x00021ED0
	[CallerCount(0)]
	public unsafe void _setGUIRotate_b__125_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setGUIRotate_b__125_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00023D04 File Offset: 0x00021F04
	[CallerCount(0)]
	public unsafe void _setDelayedSound_b__126_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.NativeMethodInfoPtr__setDelayedSound_b__126_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00002AD5 File Offset: 0x00000CD5
	public LTDescr(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00023D38 File Offset: 0x00021F38
	// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00002ADE File Offset: 0x00000CDE
	public unsafe bool toggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_toggle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_toggle)) = value;
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00023D60 File Offset: 0x00021F60
	// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00002AF9 File Offset: 0x00000CF9
	public unsafe bool useEstimatedTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useEstimatedTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useEstimatedTime)) = value;
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00023D88 File Offset: 0x00021F88
	// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00002B14 File Offset: 0x00000D14
	public unsafe bool useFrames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useFrames);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useFrames)) = value;
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00023DB0 File Offset: 0x00021FB0
	// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00002B2F File Offset: 0x00000D2F
	public unsafe bool useManualTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useManualTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useManualTime)) = value;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060003FA RID: 1018 RVA: 0x00023DD8 File Offset: 0x00021FD8
	// (set) Token: 0x060003FB RID: 1019 RVA: 0x00002B4A File Offset: 0x00000D4A
	public unsafe bool usesNormalDt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_usesNormalDt);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_usesNormalDt)) = value;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060003FC RID: 1020 RVA: 0x00023E00 File Offset: 0x00022000
	// (set) Token: 0x060003FD RID: 1021 RVA: 0x00002B65 File Offset: 0x00000D65
	public unsafe bool hasInitiliazed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasInitiliazed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasInitiliazed)) = value;
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060003FE RID: 1022 RVA: 0x00023E28 File Offset: 0x00022028
	// (set) Token: 0x060003FF RID: 1023 RVA: 0x00002B80 File Offset: 0x00000D80
	public unsafe bool hasExtraOnCompletes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasExtraOnCompletes);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasExtraOnCompletes)) = value;
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000400 RID: 1024 RVA: 0x00023E50 File Offset: 0x00022050
	// (set) Token: 0x06000401 RID: 1025 RVA: 0x00002B9B File Offset: 0x00000D9B
	public unsafe bool hasPhysics
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasPhysics);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasPhysics)) = value;
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000402 RID: 1026 RVA: 0x00023E78 File Offset: 0x00022078
	// (set) Token: 0x06000403 RID: 1027 RVA: 0x00002BB6 File Offset: 0x00000DB6
	public unsafe bool onCompleteOnRepeat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_onCompleteOnRepeat);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_onCompleteOnRepeat)) = value;
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000404 RID: 1028 RVA: 0x00023EA0 File Offset: 0x000220A0
	// (set) Token: 0x06000405 RID: 1029 RVA: 0x00002BD1 File Offset: 0x00000DD1
	public unsafe bool onCompleteOnStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_onCompleteOnStart);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_onCompleteOnStart)) = value;
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000406 RID: 1030 RVA: 0x00023EC8 File Offset: 0x000220C8
	// (set) Token: 0x06000407 RID: 1031 RVA: 0x00002BEC File Offset: 0x00000DEC
	public unsafe bool useRecursion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useRecursion);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_useRecursion)) = value;
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000408 RID: 1032 RVA: 0x00023EF0 File Offset: 0x000220F0
	// (set) Token: 0x06000409 RID: 1033 RVA: 0x00002C07 File Offset: 0x00000E07
	public unsafe float ratioPassed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_ratioPassed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_ratioPassed)) = value;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600040A RID: 1034 RVA: 0x00023F18 File Offset: 0x00022118
	// (set) Token: 0x0600040B RID: 1035 RVA: 0x00002C22 File Offset: 0x00000E22
	public unsafe float passed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_passed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_passed)) = value;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600040C RID: 1036 RVA: 0x00023F40 File Offset: 0x00022140
	// (set) Token: 0x0600040D RID: 1037 RVA: 0x00002C3D File Offset: 0x00000E3D
	public unsafe float delay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_delay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_delay)) = value;
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x0600040E RID: 1038 RVA: 0x00023F68 File Offset: 0x00022168
	// (set) Token: 0x0600040F RID: 1039 RVA: 0x00002C58 File Offset: 0x00000E58
	public unsafe float time
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_time);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_time)) = value;
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000410 RID: 1040 RVA: 0x00023F90 File Offset: 0x00022190
	// (set) Token: 0x06000411 RID: 1041 RVA: 0x00002C73 File Offset: 0x00000E73
	public unsafe float speed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_speed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_speed)) = value;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000412 RID: 1042 RVA: 0x00023FB8 File Offset: 0x000221B8
	// (set) Token: 0x06000413 RID: 1043 RVA: 0x00002C8E File Offset: 0x00000E8E
	public unsafe float lastVal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_lastVal);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_lastVal)) = value;
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000414 RID: 1044 RVA: 0x00023FE0 File Offset: 0x000221E0
	// (set) Token: 0x06000415 RID: 1045 RVA: 0x00002CA9 File Offset: 0x00000EA9
	public unsafe uint _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__id)) = value;
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000416 RID: 1046 RVA: 0x00024008 File Offset: 0x00022208
	// (set) Token: 0x06000417 RID: 1047 RVA: 0x00002CC4 File Offset: 0x00000EC4
	public unsafe int loopCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_loopCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_loopCount)) = value;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000418 RID: 1048 RVA: 0x00024030 File Offset: 0x00022230
	// (set) Token: 0x06000419 RID: 1049 RVA: 0x00002CDF File Offset: 0x00000EDF
	public unsafe uint counter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_counter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_counter)) = value;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x0600041A RID: 1050 RVA: 0x00024058 File Offset: 0x00022258
	// (set) Token: 0x0600041B RID: 1051 RVA: 0x00002CFA File Offset: 0x00000EFA
	public unsafe float direction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_direction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_direction)) = value;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x00024080 File Offset: 0x00022280
	// (set) Token: 0x0600041D RID: 1053 RVA: 0x00002D15 File Offset: 0x00000F15
	public unsafe float directionLast
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_directionLast);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_directionLast)) = value;
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x0600041E RID: 1054 RVA: 0x000240A8 File Offset: 0x000222A8
	// (set) Token: 0x0600041F RID: 1055 RVA: 0x00002D30 File Offset: 0x00000F30
	public unsafe float overshoot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_overshoot);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_overshoot)) = value;
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000420 RID: 1056 RVA: 0x000240D0 File Offset: 0x000222D0
	// (set) Token: 0x06000421 RID: 1057 RVA: 0x00002D4B File Offset: 0x00000F4B
	public unsafe float period
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_period);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_period)) = value;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000422 RID: 1058 RVA: 0x000240F8 File Offset: 0x000222F8
	// (set) Token: 0x06000423 RID: 1059 RVA: 0x00002D66 File Offset: 0x00000F66
	public unsafe float scale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_scale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_scale)) = value;
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000424 RID: 1060 RVA: 0x00024120 File Offset: 0x00022320
	// (set) Token: 0x06000425 RID: 1061 RVA: 0x00002D81 File Offset: 0x00000F81
	public unsafe bool destroyOnComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_destroyOnComplete);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_destroyOnComplete)) = value;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000426 RID: 1062 RVA: 0x00024148 File Offset: 0x00022348
	// (set) Token: 0x06000427 RID: 1063 RVA: 0x00002D9C File Offset: 0x00000F9C
	public unsafe Transform trans
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_trans);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000428 RID: 1064 RVA: 0x00024178 File Offset: 0x00022378
	// (set) Token: 0x06000429 RID: 1065 RVA: 0x00002DBB File Offset: 0x00000FBB
	public unsafe Vector3 fromInternal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_fromInternal);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_fromInternal), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x0600042A RID: 1066 RVA: 0x000241A8 File Offset: 0x000223A8
	// (set) Token: 0x0600042B RID: 1067 RVA: 0x00002DDA File Offset: 0x00000FDA
	public unsafe Vector3 toInternal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_toInternal);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_toInternal), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x0600042C RID: 1068 RVA: 0x000241D8 File Offset: 0x000223D8
	// (set) Token: 0x0600042D RID: 1069 RVA: 0x00002DF9 File Offset: 0x00000FF9
	public unsafe Vector3 diff
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_diff);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_diff), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x0600042E RID: 1070 RVA: 0x00024208 File Offset: 0x00022408
	// (set) Token: 0x0600042F RID: 1071 RVA: 0x00002E18 File Offset: 0x00001018
	public unsafe Vector3 diffDiv2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_diffDiv2);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_diffDiv2), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000430 RID: 1072 RVA: 0x00024238 File Offset: 0x00022438
	// (set) Token: 0x06000431 RID: 1073 RVA: 0x00002E37 File Offset: 0x00001037
	public unsafe TweenAction type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_type);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000432 RID: 1074 RVA: 0x00024268 File Offset: 0x00022468
	// (set) Token: 0x06000433 RID: 1075 RVA: 0x00002E56 File Offset: 0x00001056
	public unsafe LeanTweenType easeType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_easeType);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeanTweenType>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_easeType), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000434 RID: 1076 RVA: 0x00024298 File Offset: 0x00022498
	// (set) Token: 0x06000435 RID: 1077 RVA: 0x00002E75 File Offset: 0x00001075
	public unsafe LeanTweenType loopType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_loopType);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeanTweenType>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_loopType), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000436 RID: 1078 RVA: 0x000242C8 File Offset: 0x000224C8
	// (set) Token: 0x06000437 RID: 1079 RVA: 0x00002E94 File Offset: 0x00001094
	public unsafe bool hasUpdateCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasUpdateCallback);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_hasUpdateCallback)) = value;
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000438 RID: 1080 RVA: 0x000242F0 File Offset: 0x000224F0
	// (set) Token: 0x06000439 RID: 1081 RVA: 0x00002EAF File Offset: 0x000010AF
	public unsafe LTDescr.EaseTypeDelegate easeMethod
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_easeMethod);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr.EaseTypeDelegate>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_easeMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x0600043A RID: 1082 RVA: 0x00024320 File Offset: 0x00022520
	// (set) Token: 0x0600043B RID: 1083 RVA: 0x00002ECE File Offset: 0x000010CE
	public unsafe LTDescr.ActionMethodDelegate _easeInternal_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__easeInternal_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr.ActionMethodDelegate>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__easeInternal_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x0600043C RID: 1084 RVA: 0x00024350 File Offset: 0x00022550
	// (set) Token: 0x0600043D RID: 1085 RVA: 0x00002EED File Offset: 0x000010ED
	public unsafe LTDescr.ActionMethodDelegate _initInternal_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__initInternal_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr.ActionMethodDelegate>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__initInternal_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x0600043E RID: 1086 RVA: 0x00024380 File Offset: 0x00022580
	// (set) Token: 0x0600043F RID: 1087 RVA: 0x00002F0C File Offset: 0x0000110C
	public unsafe SpriteRenderer spriteRen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_spriteRen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_spriteRen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000440 RID: 1088 RVA: 0x000243B0 File Offset: 0x000225B0
	// (set) Token: 0x06000441 RID: 1089 RVA: 0x00002F2B File Offset: 0x0000112B
	public unsafe RectTransform rectTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_rectTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000442 RID: 1090 RVA: 0x000243E0 File Offset: 0x000225E0
	// (set) Token: 0x06000443 RID: 1091 RVA: 0x00002F4A File Offset: 0x0000114A
	public unsafe Text uiText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_uiText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_uiText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06000444 RID: 1092 RVA: 0x00024410 File Offset: 0x00022610
	// (set) Token: 0x06000445 RID: 1093 RVA: 0x00002F69 File Offset: 0x00001169
	public unsafe Image uiImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_uiImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_uiImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000446 RID: 1094 RVA: 0x00024440 File Offset: 0x00022640
	// (set) Token: 0x06000447 RID: 1095 RVA: 0x00002F88 File Offset: 0x00001188
	public unsafe RawImage rawImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_rawImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RawImage>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_rawImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000448 RID: 1096 RVA: 0x00024470 File Offset: 0x00022670
	// (set) Token: 0x06000449 RID: 1097 RVA: 0x00002FA7 File Offset: 0x000011A7
	public unsafe Il2CppReferenceArray<Sprite> sprites
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_sprites);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600044A RID: 1098 RVA: 0x000244A0 File Offset: 0x000226A0
	// (set) Token: 0x0600044B RID: 1099 RVA: 0x00002FC6 File Offset: 0x000011C6
	public unsafe LTDescrOptional _optional
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__optional);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescrOptional>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescr.NativeFieldInfoPtr__optional), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600044C RID: 1100 RVA: 0x000244D0 File Offset: 0x000226D0
	// (set) Token: 0x0600044D RID: 1101 RVA: 0x00002FE5 File Offset: 0x000011E5
	public unsafe static float val
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LTDescr.NativeFieldInfoPtr_val, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTDescr.NativeFieldInfoPtr_val, (void*)(&value));
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x0600044E RID: 1102 RVA: 0x000244EC File Offset: 0x000226EC
	// (set) Token: 0x0600044F RID: 1103 RVA: 0x00002FF3 File Offset: 0x000011F3
	public unsafe static float dt
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LTDescr.NativeFieldInfoPtr_dt, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTDescr.NativeFieldInfoPtr_dt, (void*)(&value));
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000450 RID: 1104 RVA: 0x00024508 File Offset: 0x00022708
	// (set) Token: 0x06000451 RID: 1105 RVA: 0x00003001 File Offset: 0x00001201
	public unsafe static Vector3 newVect
	{
		get
		{
			Vector3 vector;
			IL2CPP.il2cpp_field_static_get_value(LTDescr.NativeFieldInfoPtr_newVect, (void*)(&vector));
			return vector;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTDescr.NativeFieldInfoPtr_newVect, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000287 RID: 647
	private static readonly IntPtr NativeFieldInfoPtr_toggle;

	// Token: 0x04000288 RID: 648
	private static readonly IntPtr NativeFieldInfoPtr_useEstimatedTime;

	// Token: 0x04000289 RID: 649
	private static readonly IntPtr NativeFieldInfoPtr_useFrames;

	// Token: 0x0400028A RID: 650
	private static readonly IntPtr NativeFieldInfoPtr_useManualTime;

	// Token: 0x0400028B RID: 651
	private static readonly IntPtr NativeFieldInfoPtr_usesNormalDt;

	// Token: 0x0400028C RID: 652
	private static readonly IntPtr NativeFieldInfoPtr_hasInitiliazed;

	// Token: 0x0400028D RID: 653
	private static readonly IntPtr NativeFieldInfoPtr_hasExtraOnCompletes;

	// Token: 0x0400028E RID: 654
	private static readonly IntPtr NativeFieldInfoPtr_hasPhysics;

	// Token: 0x0400028F RID: 655
	private static readonly IntPtr NativeFieldInfoPtr_onCompleteOnRepeat;

	// Token: 0x04000290 RID: 656
	private static readonly IntPtr NativeFieldInfoPtr_onCompleteOnStart;

	// Token: 0x04000291 RID: 657
	private static readonly IntPtr NativeFieldInfoPtr_useRecursion;

	// Token: 0x04000292 RID: 658
	private static readonly IntPtr NativeFieldInfoPtr_ratioPassed;

	// Token: 0x04000293 RID: 659
	private static readonly IntPtr NativeFieldInfoPtr_passed;

	// Token: 0x04000294 RID: 660
	private static readonly IntPtr NativeFieldInfoPtr_delay;

	// Token: 0x04000295 RID: 661
	private static readonly IntPtr NativeFieldInfoPtr_time;

	// Token: 0x04000296 RID: 662
	private static readonly IntPtr NativeFieldInfoPtr_speed;

	// Token: 0x04000297 RID: 663
	private static readonly IntPtr NativeFieldInfoPtr_lastVal;

	// Token: 0x04000298 RID: 664
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x04000299 RID: 665
	private static readonly IntPtr NativeFieldInfoPtr_loopCount;

	// Token: 0x0400029A RID: 666
	private static readonly IntPtr NativeFieldInfoPtr_counter;

	// Token: 0x0400029B RID: 667
	private static readonly IntPtr NativeFieldInfoPtr_direction;

	// Token: 0x0400029C RID: 668
	private static readonly IntPtr NativeFieldInfoPtr_directionLast;

	// Token: 0x0400029D RID: 669
	private static readonly IntPtr NativeFieldInfoPtr_overshoot;

	// Token: 0x0400029E RID: 670
	private static readonly IntPtr NativeFieldInfoPtr_period;

	// Token: 0x0400029F RID: 671
	private static readonly IntPtr NativeFieldInfoPtr_scale;

	// Token: 0x040002A0 RID: 672
	private static readonly IntPtr NativeFieldInfoPtr_destroyOnComplete;

	// Token: 0x040002A1 RID: 673
	private static readonly IntPtr NativeFieldInfoPtr_trans;

	// Token: 0x040002A2 RID: 674
	private static readonly IntPtr NativeFieldInfoPtr_fromInternal;

	// Token: 0x040002A3 RID: 675
	private static readonly IntPtr NativeFieldInfoPtr_toInternal;

	// Token: 0x040002A4 RID: 676
	private static readonly IntPtr NativeFieldInfoPtr_diff;

	// Token: 0x040002A5 RID: 677
	private static readonly IntPtr NativeFieldInfoPtr_diffDiv2;

	// Token: 0x040002A6 RID: 678
	private static readonly IntPtr NativeFieldInfoPtr_type;

	// Token: 0x040002A7 RID: 679
	private static readonly IntPtr NativeFieldInfoPtr_easeType;

	// Token: 0x040002A8 RID: 680
	private static readonly IntPtr NativeFieldInfoPtr_loopType;

	// Token: 0x040002A9 RID: 681
	private static readonly IntPtr NativeFieldInfoPtr_hasUpdateCallback;

	// Token: 0x040002AA RID: 682
	private static readonly IntPtr NativeFieldInfoPtr_easeMethod;

	// Token: 0x040002AB RID: 683
	private static readonly IntPtr NativeFieldInfoPtr__easeInternal_k__BackingField;

	// Token: 0x040002AC RID: 684
	private static readonly IntPtr NativeFieldInfoPtr__initInternal_k__BackingField;

	// Token: 0x040002AD RID: 685
	private static readonly IntPtr NativeFieldInfoPtr_spriteRen;

	// Token: 0x040002AE RID: 686
	private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

	// Token: 0x040002AF RID: 687
	private static readonly IntPtr NativeFieldInfoPtr_uiText;

	// Token: 0x040002B0 RID: 688
	private static readonly IntPtr NativeFieldInfoPtr_uiImage;

	// Token: 0x040002B1 RID: 689
	private static readonly IntPtr NativeFieldInfoPtr_rawImage;

	// Token: 0x040002B2 RID: 690
	private static readonly IntPtr NativeFieldInfoPtr_sprites;

	// Token: 0x040002B3 RID: 691
	private static readonly IntPtr NativeFieldInfoPtr__optional;

	// Token: 0x040002B4 RID: 692
	private static readonly IntPtr NativeFieldInfoPtr_val;

	// Token: 0x040002B5 RID: 693
	private static readonly IntPtr NativeFieldInfoPtr_dt;

	// Token: 0x040002B6 RID: 694
	private static readonly IntPtr NativeFieldInfoPtr_newVect;

	// Token: 0x040002B7 RID: 695
	private static readonly IntPtr NativeMethodInfoPtr_get_from_Public_get_Vector3_0;

	// Token: 0x040002B8 RID: 696
	private static readonly IntPtr NativeMethodInfoPtr_set_from_Public_set_Void_Vector3_0;

	// Token: 0x040002B9 RID: 697
	private static readonly IntPtr NativeMethodInfoPtr_get_to_Public_get_Vector3_0;

	// Token: 0x040002BA RID: 698
	private static readonly IntPtr NativeMethodInfoPtr_set_to_Public_set_Void_Vector3_0;

	// Token: 0x040002BB RID: 699
	private static readonly IntPtr NativeMethodInfoPtr_get_easeInternal_Public_get_ActionMethodDelegate_0;

	// Token: 0x040002BC RID: 700
	private static readonly IntPtr NativeMethodInfoPtr_set_easeInternal_Public_set_Void_ActionMethodDelegate_0;

	// Token: 0x040002BD RID: 701
	private static readonly IntPtr NativeMethodInfoPtr_get_initInternal_Public_get_ActionMethodDelegate_0;

	// Token: 0x040002BE RID: 702
	private static readonly IntPtr NativeMethodInfoPtr_set_initInternal_Public_set_Void_ActionMethodDelegate_0;

	// Token: 0x040002BF RID: 703
	private static readonly IntPtr NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0;

	// Token: 0x040002C0 RID: 704
	private static readonly IntPtr NativeMethodInfoPtr_get_uniqueId_Public_get_Int32_0;

	// Token: 0x040002C1 RID: 705
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

	// Token: 0x040002C2 RID: 706
	private static readonly IntPtr NativeMethodInfoPtr_get_optional_Public_get_LTDescrOptional_0;

	// Token: 0x040002C3 RID: 707
	private static readonly IntPtr NativeMethodInfoPtr_set_optional_Public_set_Void_LTDescrOptional_0;

	// Token: 0x040002C4 RID: 708
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040002C5 RID: 709
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	// Token: 0x040002C6 RID: 710
	private static readonly IntPtr NativeMethodInfoPtr_cancel_Public_LTDescr_GameObject_0;

	// Token: 0x040002C7 RID: 711
	private static readonly IntPtr NativeMethodInfoPtr_reset_Public_Void_0;

	// Token: 0x040002C8 RID: 712
	private static readonly IntPtr NativeMethodInfoPtr_setFollow_Public_LTDescr_0;

	// Token: 0x040002C9 RID: 713
	private static readonly IntPtr NativeMethodInfoPtr_setMoveX_Public_LTDescr_0;

	// Token: 0x040002CA RID: 714
	private static readonly IntPtr NativeMethodInfoPtr_setMoveY_Public_LTDescr_0;

	// Token: 0x040002CB RID: 715
	private static readonly IntPtr NativeMethodInfoPtr_setMoveZ_Public_LTDescr_0;

	// Token: 0x040002CC RID: 716
	private static readonly IntPtr NativeMethodInfoPtr_setMoveLocalX_Public_LTDescr_0;

	// Token: 0x040002CD RID: 717
	private static readonly IntPtr NativeMethodInfoPtr_setMoveLocalY_Public_LTDescr_0;

	// Token: 0x040002CE RID: 718
	private static readonly IntPtr NativeMethodInfoPtr_setMoveLocalZ_Public_LTDescr_0;

	// Token: 0x040002CF RID: 719
	private static readonly IntPtr NativeMethodInfoPtr_initFromInternal_Private_Void_0;

	// Token: 0x040002D0 RID: 720
	private static readonly IntPtr NativeMethodInfoPtr_setOffset_Public_LTDescr_Vector3_0;

	// Token: 0x040002D1 RID: 721
	private static readonly IntPtr NativeMethodInfoPtr_setMoveCurved_Public_LTDescr_0;

	// Token: 0x040002D2 RID: 722
	private static readonly IntPtr NativeMethodInfoPtr_setMoveCurvedLocal_Public_LTDescr_0;

	// Token: 0x040002D3 RID: 723
	private static readonly IntPtr NativeMethodInfoPtr_setMoveSpline_Public_LTDescr_0;

	// Token: 0x040002D4 RID: 724
	private static readonly IntPtr NativeMethodInfoPtr_setMoveSplineLocal_Public_LTDescr_0;

	// Token: 0x040002D5 RID: 725
	private static readonly IntPtr NativeMethodInfoPtr_setScaleX_Public_LTDescr_0;

	// Token: 0x040002D6 RID: 726
	private static readonly IntPtr NativeMethodInfoPtr_setScaleY_Public_LTDescr_0;

	// Token: 0x040002D7 RID: 727
	private static readonly IntPtr NativeMethodInfoPtr_setScaleZ_Public_LTDescr_0;

	// Token: 0x040002D8 RID: 728
	private static readonly IntPtr NativeMethodInfoPtr_setRotateX_Public_LTDescr_0;

	// Token: 0x040002D9 RID: 729
	private static readonly IntPtr NativeMethodInfoPtr_setRotateY_Public_LTDescr_0;

	// Token: 0x040002DA RID: 730
	private static readonly IntPtr NativeMethodInfoPtr_setRotateZ_Public_LTDescr_0;

	// Token: 0x040002DB RID: 731
	private static readonly IntPtr NativeMethodInfoPtr_setRotateAround_Public_LTDescr_0;

	// Token: 0x040002DC RID: 732
	private static readonly IntPtr NativeMethodInfoPtr_setRotateAroundLocal_Public_LTDescr_0;

	// Token: 0x040002DD RID: 733
	private static readonly IntPtr NativeMethodInfoPtr_setAlpha_Public_LTDescr_0;

	// Token: 0x040002DE RID: 734
	private static readonly IntPtr NativeMethodInfoPtr_setTextAlpha_Public_LTDescr_0;

	// Token: 0x040002DF RID: 735
	private static readonly IntPtr NativeMethodInfoPtr_setAlphaVertex_Public_LTDescr_0;

	// Token: 0x040002E0 RID: 736
	private static readonly IntPtr NativeMethodInfoPtr_setColor_Public_LTDescr_0;

	// Token: 0x040002E1 RID: 737
	private static readonly IntPtr NativeMethodInfoPtr_setCallbackColor_Public_LTDescr_0;

	// Token: 0x040002E2 RID: 738
	private static readonly IntPtr NativeMethodInfoPtr_setTextColor_Public_LTDescr_0;

	// Token: 0x040002E3 RID: 739
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasAlpha_Public_LTDescr_0;

	// Token: 0x040002E4 RID: 740
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasGroupAlpha_Public_LTDescr_0;

	// Token: 0x040002E5 RID: 741
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasColor_Public_LTDescr_0;

	// Token: 0x040002E6 RID: 742
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasMoveX_Public_LTDescr_0;

	// Token: 0x040002E7 RID: 743
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasMoveY_Public_LTDescr_0;

	// Token: 0x040002E8 RID: 744
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasMoveZ_Public_LTDescr_0;

	// Token: 0x040002E9 RID: 745
	private static readonly IntPtr NativeMethodInfoPtr_initCanvasRotateAround_Private_Void_0;

	// Token: 0x040002EA RID: 746
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasRotateAround_Public_LTDescr_0;

	// Token: 0x040002EB RID: 747
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasRotateAroundLocal_Public_LTDescr_0;

	// Token: 0x040002EC RID: 748
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasPlaySprite_Public_LTDescr_0;

	// Token: 0x040002ED RID: 749
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasMove_Public_LTDescr_0;

	// Token: 0x040002EE RID: 750
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasScale_Public_LTDescr_0;

	// Token: 0x040002EF RID: 751
	private static readonly IntPtr NativeMethodInfoPtr_setCanvasSizeDelta_Public_LTDescr_0;

	// Token: 0x040002F0 RID: 752
	private static readonly IntPtr NativeMethodInfoPtr_callback_Private_Void_0;

	// Token: 0x040002F1 RID: 753
	private static readonly IntPtr NativeMethodInfoPtr_setCallback_Public_LTDescr_0;

	// Token: 0x040002F2 RID: 754
	private static readonly IntPtr NativeMethodInfoPtr_setValue3_Public_LTDescr_0;

	// Token: 0x040002F3 RID: 755
	private static readonly IntPtr NativeMethodInfoPtr_setMove_Public_LTDescr_0;

	// Token: 0x040002F4 RID: 756
	private static readonly IntPtr NativeMethodInfoPtr_setMoveLocal_Public_LTDescr_0;

	// Token: 0x040002F5 RID: 757
	private static readonly IntPtr NativeMethodInfoPtr_setMoveToTransform_Public_LTDescr_0;

	// Token: 0x040002F6 RID: 758
	private static readonly IntPtr NativeMethodInfoPtr_setRotate_Public_LTDescr_0;

	// Token: 0x040002F7 RID: 759
	private static readonly IntPtr NativeMethodInfoPtr_setRotateLocal_Public_LTDescr_0;

	// Token: 0x040002F8 RID: 760
	private static readonly IntPtr NativeMethodInfoPtr_setScale_Public_LTDescr_0;

	// Token: 0x040002F9 RID: 761
	private static readonly IntPtr NativeMethodInfoPtr_setGUIMove_Public_LTDescr_0;

	// Token: 0x040002FA RID: 762
	private static readonly IntPtr NativeMethodInfoPtr_setGUIMoveMargin_Public_LTDescr_0;

	// Token: 0x040002FB RID: 763
	private static readonly IntPtr NativeMethodInfoPtr_setGUIScale_Public_LTDescr_0;

	// Token: 0x040002FC RID: 764
	private static readonly IntPtr NativeMethodInfoPtr_setGUIAlpha_Public_LTDescr_0;

	// Token: 0x040002FD RID: 765
	private static readonly IntPtr NativeMethodInfoPtr_setGUIRotate_Public_LTDescr_0;

	// Token: 0x040002FE RID: 766
	private static readonly IntPtr NativeMethodInfoPtr_setDelayedSound_Public_LTDescr_0;

	// Token: 0x040002FF RID: 767
	private static readonly IntPtr NativeMethodInfoPtr_setTarget_Public_LTDescr_Transform_0;

	// Token: 0x04000300 RID: 768
	private static readonly IntPtr NativeMethodInfoPtr_init_Private_Void_0;

	// Token: 0x04000301 RID: 769
	private static readonly IntPtr NativeMethodInfoPtr_initSpeed_Private_Void_0;

	// Token: 0x04000302 RID: 770
	private static readonly IntPtr NativeMethodInfoPtr_updateNow_Public_LTDescr_0;

	// Token: 0x04000303 RID: 771
	private static readonly IntPtr NativeMethodInfoPtr_updateInternal_Public_Boolean_0;

	// Token: 0x04000304 RID: 772
	private static readonly IntPtr NativeMethodInfoPtr_callOnCompletes_Public_Void_0;

	// Token: 0x04000305 RID: 773
	private static readonly IntPtr NativeMethodInfoPtr_setFromColor_Public_LTDescr_Color_0;

	// Token: 0x04000306 RID: 774
	private static readonly IntPtr NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_Transform_Single_Boolean_0;

	// Token: 0x04000307 RID: 775
	private static readonly IntPtr NativeMethodInfoPtr_colorRecursive_Private_Static_Void_Transform_Color_Boolean_0;

	// Token: 0x04000308 RID: 776
	private static readonly IntPtr NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_RectTransform_Single_Int32_0;

	// Token: 0x04000309 RID: 777
	private static readonly IntPtr NativeMethodInfoPtr_alphaRecursiveSprite_Private_Static_Void_Transform_Single_0;

	// Token: 0x0400030A RID: 778
	private static readonly IntPtr NativeMethodInfoPtr_colorRecursiveSprite_Private_Static_Void_Transform_Color_0;

	// Token: 0x0400030B RID: 779
	private static readonly IntPtr NativeMethodInfoPtr_colorRecursive_Private_Static_Void_RectTransform_Color_0;

	// Token: 0x0400030C RID: 780
	private static readonly IntPtr NativeMethodInfoPtr_textAlphaChildrenRecursive_Private_Static_Void_Transform_Single_Boolean_0;

	// Token: 0x0400030D RID: 781
	private static readonly IntPtr NativeMethodInfoPtr_textAlphaRecursive_Private_Static_Void_Transform_Single_Boolean_0;

	// Token: 0x0400030E RID: 782
	private static readonly IntPtr NativeMethodInfoPtr_textColorRecursive_Private_Static_Void_Transform_Color_0;

	// Token: 0x0400030F RID: 783
	private static readonly IntPtr NativeMethodInfoPtr_tweenColor_Private_Static_Color_LTDescr_Single_0;

	// Token: 0x04000310 RID: 784
	private static readonly IntPtr NativeMethodInfoPtr_pause_Public_LTDescr_0;

	// Token: 0x04000311 RID: 785
	private static readonly IntPtr NativeMethodInfoPtr_resume_Public_LTDescr_0;

	// Token: 0x04000312 RID: 786
	private static readonly IntPtr NativeMethodInfoPtr_setAxis_Public_LTDescr_Vector3_0;

	// Token: 0x04000313 RID: 787
	private static readonly IntPtr NativeMethodInfoPtr_setDelay_Public_LTDescr_Single_0;

	// Token: 0x04000314 RID: 788
	private static readonly IntPtr NativeMethodInfoPtr_setEase_Public_LTDescr_LeanTweenType_0;

	// Token: 0x04000315 RID: 789
	private static readonly IntPtr NativeMethodInfoPtr_setEaseLinear_Public_LTDescr_0;

	// Token: 0x04000316 RID: 790
	private static readonly IntPtr NativeMethodInfoPtr_setEaseSpring_Public_LTDescr_0;

	// Token: 0x04000317 RID: 791
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInQuad_Public_LTDescr_0;

	// Token: 0x04000318 RID: 792
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutQuad_Public_LTDescr_0;

	// Token: 0x04000319 RID: 793
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutQuad_Public_LTDescr_0;

	// Token: 0x0400031A RID: 794
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInCubic_Public_LTDescr_0;

	// Token: 0x0400031B RID: 795
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutCubic_Public_LTDescr_0;

	// Token: 0x0400031C RID: 796
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutCubic_Public_LTDescr_0;

	// Token: 0x0400031D RID: 797
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInQuart_Public_LTDescr_0;

	// Token: 0x0400031E RID: 798
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutQuart_Public_LTDescr_0;

	// Token: 0x0400031F RID: 799
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutQuart_Public_LTDescr_0;

	// Token: 0x04000320 RID: 800
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInQuint_Public_LTDescr_0;

	// Token: 0x04000321 RID: 801
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutQuint_Public_LTDescr_0;

	// Token: 0x04000322 RID: 802
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutQuint_Public_LTDescr_0;

	// Token: 0x04000323 RID: 803
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInSine_Public_LTDescr_0;

	// Token: 0x04000324 RID: 804
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutSine_Public_LTDescr_0;

	// Token: 0x04000325 RID: 805
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutSine_Public_LTDescr_0;

	// Token: 0x04000326 RID: 806
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInExpo_Public_LTDescr_0;

	// Token: 0x04000327 RID: 807
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutExpo_Public_LTDescr_0;

	// Token: 0x04000328 RID: 808
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutExpo_Public_LTDescr_0;

	// Token: 0x04000329 RID: 809
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInCirc_Public_LTDescr_0;

	// Token: 0x0400032A RID: 810
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutCirc_Public_LTDescr_0;

	// Token: 0x0400032B RID: 811
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutCirc_Public_LTDescr_0;

	// Token: 0x0400032C RID: 812
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInBounce_Public_LTDescr_0;

	// Token: 0x0400032D RID: 813
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutBounce_Public_LTDescr_0;

	// Token: 0x0400032E RID: 814
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutBounce_Public_LTDescr_0;

	// Token: 0x0400032F RID: 815
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInBack_Public_LTDescr_0;

	// Token: 0x04000330 RID: 816
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutBack_Public_LTDescr_0;

	// Token: 0x04000331 RID: 817
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutBack_Public_LTDescr_0;

	// Token: 0x04000332 RID: 818
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInElastic_Public_LTDescr_0;

	// Token: 0x04000333 RID: 819
	private static readonly IntPtr NativeMethodInfoPtr_setEaseOutElastic_Public_LTDescr_0;

	// Token: 0x04000334 RID: 820
	private static readonly IntPtr NativeMethodInfoPtr_setEaseInOutElastic_Public_LTDescr_0;

	// Token: 0x04000335 RID: 821
	private static readonly IntPtr NativeMethodInfoPtr_setEasePunch_Public_LTDescr_0;

	// Token: 0x04000336 RID: 822
	private static readonly IntPtr NativeMethodInfoPtr_setEaseShake_Public_LTDescr_0;

	// Token: 0x04000337 RID: 823
	private static readonly IntPtr NativeMethodInfoPtr_tweenOnCurve_Private_Vector3_0;

	// Token: 0x04000338 RID: 824
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuad_Private_Vector3_0;

	// Token: 0x04000339 RID: 825
	private static readonly IntPtr NativeMethodInfoPtr_easeInQuad_Private_Vector3_0;

	// Token: 0x0400033A RID: 826
	private static readonly IntPtr NativeMethodInfoPtr_easeOutQuad_Private_Vector3_0;

	// Token: 0x0400033B RID: 827
	private static readonly IntPtr NativeMethodInfoPtr_easeLinear_Private_Vector3_0;

	// Token: 0x0400033C RID: 828
	private static readonly IntPtr NativeMethodInfoPtr_easeSpring_Private_Vector3_0;

	// Token: 0x0400033D RID: 829
	private static readonly IntPtr NativeMethodInfoPtr_easeInCubic_Private_Vector3_0;

	// Token: 0x0400033E RID: 830
	private static readonly IntPtr NativeMethodInfoPtr_easeOutCubic_Private_Vector3_0;

	// Token: 0x0400033F RID: 831
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutCubic_Private_Vector3_0;

	// Token: 0x04000340 RID: 832
	private static readonly IntPtr NativeMethodInfoPtr_easeInQuart_Private_Vector3_0;

	// Token: 0x04000341 RID: 833
	private static readonly IntPtr NativeMethodInfoPtr_easeOutQuart_Private_Vector3_0;

	// Token: 0x04000342 RID: 834
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuart_Private_Vector3_0;

	// Token: 0x04000343 RID: 835
	private static readonly IntPtr NativeMethodInfoPtr_easeInQuint_Private_Vector3_0;

	// Token: 0x04000344 RID: 836
	private static readonly IntPtr NativeMethodInfoPtr_easeOutQuint_Private_Vector3_0;

	// Token: 0x04000345 RID: 837
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutQuint_Private_Vector3_0;

	// Token: 0x04000346 RID: 838
	private static readonly IntPtr NativeMethodInfoPtr_easeInSine_Private_Vector3_0;

	// Token: 0x04000347 RID: 839
	private static readonly IntPtr NativeMethodInfoPtr_easeOutSine_Private_Vector3_0;

	// Token: 0x04000348 RID: 840
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutSine_Private_Vector3_0;

	// Token: 0x04000349 RID: 841
	private static readonly IntPtr NativeMethodInfoPtr_easeInExpo_Private_Vector3_0;

	// Token: 0x0400034A RID: 842
	private static readonly IntPtr NativeMethodInfoPtr_easeOutExpo_Private_Vector3_0;

	// Token: 0x0400034B RID: 843
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutExpo_Private_Vector3_0;

	// Token: 0x0400034C RID: 844
	private static readonly IntPtr NativeMethodInfoPtr_easeInCirc_Private_Vector3_0;

	// Token: 0x0400034D RID: 845
	private static readonly IntPtr NativeMethodInfoPtr_easeOutCirc_Private_Vector3_0;

	// Token: 0x0400034E RID: 846
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutCirc_Private_Vector3_0;

	// Token: 0x0400034F RID: 847
	private static readonly IntPtr NativeMethodInfoPtr_easeInBounce_Private_Vector3_0;

	// Token: 0x04000350 RID: 848
	private static readonly IntPtr NativeMethodInfoPtr_easeOutBounce_Private_Vector3_0;

	// Token: 0x04000351 RID: 849
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutBounce_Private_Vector3_0;

	// Token: 0x04000352 RID: 850
	private static readonly IntPtr NativeMethodInfoPtr_easeInBack_Private_Vector3_0;

	// Token: 0x04000353 RID: 851
	private static readonly IntPtr NativeMethodInfoPtr_easeOutBack_Private_Vector3_0;

	// Token: 0x04000354 RID: 852
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutBack_Private_Vector3_0;

	// Token: 0x04000355 RID: 853
	private static readonly IntPtr NativeMethodInfoPtr_easeInElastic_Private_Vector3_0;

	// Token: 0x04000356 RID: 854
	private static readonly IntPtr NativeMethodInfoPtr_easeOutElastic_Private_Vector3_0;

	// Token: 0x04000357 RID: 855
	private static readonly IntPtr NativeMethodInfoPtr_easeInOutElastic_Private_Vector3_0;

	// Token: 0x04000358 RID: 856
	private static readonly IntPtr NativeMethodInfoPtr_setOvershoot_Public_LTDescr_Single_0;

	// Token: 0x04000359 RID: 857
	private static readonly IntPtr NativeMethodInfoPtr_setPeriod_Public_LTDescr_Single_0;

	// Token: 0x0400035A RID: 858
	private static readonly IntPtr NativeMethodInfoPtr_setScale_Public_LTDescr_Single_0;

	// Token: 0x0400035B RID: 859
	private static readonly IntPtr NativeMethodInfoPtr_setEase_Public_LTDescr_AnimationCurve_0;

	// Token: 0x0400035C RID: 860
	private static readonly IntPtr NativeMethodInfoPtr_setTo_Public_LTDescr_Vector3_0;

	// Token: 0x0400035D RID: 861
	private static readonly IntPtr NativeMethodInfoPtr_setTo_Public_LTDescr_Transform_0;

	// Token: 0x0400035E RID: 862
	private static readonly IntPtr NativeMethodInfoPtr_setFrom_Public_LTDescr_Vector3_0;

	// Token: 0x0400035F RID: 863
	private static readonly IntPtr NativeMethodInfoPtr_setFrom_Public_LTDescr_Single_0;

	// Token: 0x04000360 RID: 864
	private static readonly IntPtr NativeMethodInfoPtr_setDiff_Public_LTDescr_Vector3_0;

	// Token: 0x04000361 RID: 865
	private static readonly IntPtr NativeMethodInfoPtr_setHasInitialized_Public_LTDescr_Boolean_0;

	// Token: 0x04000362 RID: 866
	private static readonly IntPtr NativeMethodInfoPtr_setId_Public_LTDescr_UInt32_UInt32_0;

	// Token: 0x04000363 RID: 867
	private static readonly IntPtr NativeMethodInfoPtr_setPassed_Public_LTDescr_Single_0;

	// Token: 0x04000364 RID: 868
	private static readonly IntPtr NativeMethodInfoPtr_setTime_Public_LTDescr_Single_0;

	// Token: 0x04000365 RID: 869
	private static readonly IntPtr NativeMethodInfoPtr_setSpeed_Public_LTDescr_Single_0;

	// Token: 0x04000366 RID: 870
	private static readonly IntPtr NativeMethodInfoPtr_setRepeat_Public_LTDescr_Int32_0;

	// Token: 0x04000367 RID: 871
	private static readonly IntPtr NativeMethodInfoPtr_setLoopType_Public_LTDescr_LeanTweenType_0;

	// Token: 0x04000368 RID: 872
	private static readonly IntPtr NativeMethodInfoPtr_setUseEstimatedTime_Public_LTDescr_Boolean_0;

	// Token: 0x04000369 RID: 873
	private static readonly IntPtr NativeMethodInfoPtr_setIgnoreTimeScale_Public_LTDescr_Boolean_0;

	// Token: 0x0400036A RID: 874
	private static readonly IntPtr NativeMethodInfoPtr_setUseFrames_Public_LTDescr_Boolean_0;

	// Token: 0x0400036B RID: 875
	private static readonly IntPtr NativeMethodInfoPtr_setUseManualTime_Public_LTDescr_Boolean_0;

	// Token: 0x0400036C RID: 876
	private static readonly IntPtr NativeMethodInfoPtr_setLoopCount_Public_LTDescr_Int32_0;

	// Token: 0x0400036D RID: 877
	private static readonly IntPtr NativeMethodInfoPtr_setLoopOnce_Public_LTDescr_0;

	// Token: 0x0400036E RID: 878
	private static readonly IntPtr NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_0;

	// Token: 0x0400036F RID: 879
	private static readonly IntPtr NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_Int32_0;

	// Token: 0x04000370 RID: 880
	private static readonly IntPtr NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_0;

	// Token: 0x04000371 RID: 881
	private static readonly IntPtr NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_Int32_0;

	// Token: 0x04000372 RID: 882
	private static readonly IntPtr NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_0;

	// Token: 0x04000373 RID: 883
	private static readonly IntPtr NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_0;

	// Token: 0x04000374 RID: 884
	private static readonly IntPtr NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_Object_0;

	// Token: 0x04000375 RID: 885
	private static readonly IntPtr NativeMethodInfoPtr_setOnCompleteParam_Public_LTDescr_Object_0;

	// Token: 0x04000376 RID: 886
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Single_0;

	// Token: 0x04000377 RID: 887
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdateRatio_Public_LTDescr_Action_2_Single_Single_0;

	// Token: 0x04000378 RID: 888
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdateObject_Public_LTDescr_Action_2_Single_Object_0;

	// Token: 0x04000379 RID: 889
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdateVector2_Public_LTDescr_Action_1_Vector2_0;

	// Token: 0x0400037A RID: 890
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdateVector3_Public_LTDescr_Action_1_Vector3_0;

	// Token: 0x0400037B RID: 891
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_1_Color_0;

	// Token: 0x0400037C RID: 892
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_2_Color_Object_0;

	// Token: 0x0400037D RID: 893
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Color_0;

	// Token: 0x0400037E RID: 894
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Color_Object_0;

	// Token: 0x0400037F RID: 895
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Single_Object_Object_0;

	// Token: 0x04000380 RID: 896
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Vector3_Object_Object_0;

	// Token: 0x04000381 RID: 897
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector2_Object_0;

	// Token: 0x04000382 RID: 898
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector3_Object_0;

	// Token: 0x04000383 RID: 899
	private static readonly IntPtr NativeMethodInfoPtr_setOnUpdateParam_Public_LTDescr_Object_0;

	// Token: 0x04000384 RID: 900
	private static readonly IntPtr NativeMethodInfoPtr_setOrientToPath_Public_LTDescr_Boolean_0;

	// Token: 0x04000385 RID: 901
	private static readonly IntPtr NativeMethodInfoPtr_setOrientToPath2d_Public_LTDescr_Boolean_0;

	// Token: 0x04000386 RID: 902
	private static readonly IntPtr NativeMethodInfoPtr_setRect_Public_LTDescr_LTRect_0;

	// Token: 0x04000387 RID: 903
	private static readonly IntPtr NativeMethodInfoPtr_setRect_Public_LTDescr_Rect_0;

	// Token: 0x04000388 RID: 904
	private static readonly IntPtr NativeMethodInfoPtr_setPath_Public_LTDescr_LTBezierPath_0;

	// Token: 0x04000389 RID: 905
	private static readonly IntPtr NativeMethodInfoPtr_setPoint_Public_LTDescr_Vector3_0;

	// Token: 0x0400038A RID: 906
	private static readonly IntPtr NativeMethodInfoPtr_setDestroyOnComplete_Public_LTDescr_Boolean_0;

	// Token: 0x0400038B RID: 907
	private static readonly IntPtr NativeMethodInfoPtr_setAudio_Public_LTDescr_Object_0;

	// Token: 0x0400038C RID: 908
	private static readonly IntPtr NativeMethodInfoPtr_setOnCompleteOnRepeat_Public_LTDescr_Boolean_0;

	// Token: 0x0400038D RID: 909
	private static readonly IntPtr NativeMethodInfoPtr_setOnCompleteOnStart_Public_LTDescr_Boolean_0;

	// Token: 0x0400038E RID: 910
	private static readonly IntPtr NativeMethodInfoPtr_setRect_Public_LTDescr_RectTransform_0;

	// Token: 0x0400038F RID: 911
	private static readonly IntPtr NativeMethodInfoPtr_setSprites_Public_LTDescr_Il2CppReferenceArray_1_Sprite_0;

	// Token: 0x04000390 RID: 912
	private static readonly IntPtr NativeMethodInfoPtr_setFrameRate_Public_LTDescr_Single_0;

	// Token: 0x04000391 RID: 913
	private static readonly IntPtr NativeMethodInfoPtr_setOnStart_Public_LTDescr_Action_0;

	// Token: 0x04000392 RID: 914
	private static readonly IntPtr NativeMethodInfoPtr_setDirection_Public_LTDescr_Single_0;

	// Token: 0x04000393 RID: 915
	private static readonly IntPtr NativeMethodInfoPtr_setRecursive_Public_LTDescr_Boolean_0;

	// Token: 0x04000394 RID: 916
	private static readonly IntPtr NativeMethodInfoPtr__setMoveX_b__73_0_Private_Void_0;

	// Token: 0x04000395 RID: 917
	private static readonly IntPtr NativeMethodInfoPtr__setMoveX_b__73_1_Private_Void_0;

	// Token: 0x04000396 RID: 918
	private static readonly IntPtr NativeMethodInfoPtr__setMoveY_b__74_0_Private_Void_0;

	// Token: 0x04000397 RID: 919
	private static readonly IntPtr NativeMethodInfoPtr__setMoveY_b__74_1_Private_Void_0;

	// Token: 0x04000398 RID: 920
	private static readonly IntPtr NativeMethodInfoPtr__setMoveZ_b__75_0_Private_Void_0;

	// Token: 0x04000399 RID: 921
	private static readonly IntPtr NativeMethodInfoPtr__setMoveZ_b__75_1_Private_Void_0;

	// Token: 0x0400039A RID: 922
	private static readonly IntPtr NativeMethodInfoPtr__setMoveLocalX_b__76_0_Private_Void_0;

	// Token: 0x0400039B RID: 923
	private static readonly IntPtr NativeMethodInfoPtr__setMoveLocalX_b__76_1_Private_Void_0;

	// Token: 0x0400039C RID: 924
	private static readonly IntPtr NativeMethodInfoPtr__setMoveLocalY_b__77_0_Private_Void_0;

	// Token: 0x0400039D RID: 925
	private static readonly IntPtr NativeMethodInfoPtr__setMoveLocalY_b__77_1_Private_Void_0;

	// Token: 0x0400039E RID: 926
	private static readonly IntPtr NativeMethodInfoPtr__setMoveLocalZ_b__78_0_Private_Void_0;

	// Token: 0x0400039F RID: 927
	private static readonly IntPtr NativeMethodInfoPtr__setMoveLocalZ_b__78_1_Private_Void_0;

	// Token: 0x040003A0 RID: 928
	private static readonly IntPtr NativeMethodInfoPtr__setMoveCurved_b__81_0_Private_Void_0;

	// Token: 0x040003A1 RID: 929
	private static readonly IntPtr NativeMethodInfoPtr__setMoveCurvedLocal_b__82_0_Private_Void_0;

	// Token: 0x040003A2 RID: 930
	private static readonly IntPtr NativeMethodInfoPtr__setMoveSpline_b__83_0_Private_Void_0;

	// Token: 0x040003A3 RID: 931
	private static readonly IntPtr NativeMethodInfoPtr__setMoveSplineLocal_b__84_0_Private_Void_0;

	// Token: 0x040003A4 RID: 932
	private static readonly IntPtr NativeMethodInfoPtr__setScaleX_b__85_0_Private_Void_0;

	// Token: 0x040003A5 RID: 933
	private static readonly IntPtr NativeMethodInfoPtr__setScaleX_b__85_1_Private_Void_0;

	// Token: 0x040003A6 RID: 934
	private static readonly IntPtr NativeMethodInfoPtr__setScaleY_b__86_0_Private_Void_0;

	// Token: 0x040003A7 RID: 935
	private static readonly IntPtr NativeMethodInfoPtr__setScaleY_b__86_1_Private_Void_0;

	// Token: 0x040003A8 RID: 936
	private static readonly IntPtr NativeMethodInfoPtr__setScaleZ_b__87_0_Private_Void_0;

	// Token: 0x040003A9 RID: 937
	private static readonly IntPtr NativeMethodInfoPtr__setScaleZ_b__87_1_Private_Void_0;

	// Token: 0x040003AA RID: 938
	private static readonly IntPtr NativeMethodInfoPtr__setRotateX_b__88_0_Private_Void_0;

	// Token: 0x040003AB RID: 939
	private static readonly IntPtr NativeMethodInfoPtr__setRotateX_b__88_1_Private_Void_0;

	// Token: 0x040003AC RID: 940
	private static readonly IntPtr NativeMethodInfoPtr__setRotateY_b__89_0_Private_Void_0;

	// Token: 0x040003AD RID: 941
	private static readonly IntPtr NativeMethodInfoPtr__setRotateY_b__89_1_Private_Void_0;

	// Token: 0x040003AE RID: 942
	private static readonly IntPtr NativeMethodInfoPtr__setRotateZ_b__90_0_Private_Void_0;

	// Token: 0x040003AF RID: 943
	private static readonly IntPtr NativeMethodInfoPtr__setRotateZ_b__90_1_Private_Void_0;

	// Token: 0x040003B0 RID: 944
	private static readonly IntPtr NativeMethodInfoPtr__setRotateAround_b__91_0_Private_Void_0;

	// Token: 0x040003B1 RID: 945
	private static readonly IntPtr NativeMethodInfoPtr__setRotateAround_b__91_1_Private_Void_0;

	// Token: 0x040003B2 RID: 946
	private static readonly IntPtr NativeMethodInfoPtr__setRotateAroundLocal_b__92_0_Private_Void_0;

	// Token: 0x040003B3 RID: 947
	private static readonly IntPtr NativeMethodInfoPtr__setRotateAroundLocal_b__92_1_Private_Void_0;

	// Token: 0x040003B4 RID: 948
	private static readonly IntPtr NativeMethodInfoPtr__setAlpha_b__93_0_Private_Void_0;

	// Token: 0x040003B5 RID: 949
	private static readonly IntPtr NativeMethodInfoPtr__setAlpha_b__93_2_Private_Void_0;

	// Token: 0x040003B6 RID: 950
	private static readonly IntPtr NativeMethodInfoPtr__setAlpha_b__93_1_Private_Void_0;

	// Token: 0x040003B7 RID: 951
	private static readonly IntPtr NativeMethodInfoPtr__setTextAlpha_b__94_0_Private_Void_0;

	// Token: 0x040003B8 RID: 952
	private static readonly IntPtr NativeMethodInfoPtr__setTextAlpha_b__94_1_Private_Void_0;

	// Token: 0x040003B9 RID: 953
	private static readonly IntPtr NativeMethodInfoPtr__setAlphaVertex_b__95_0_Private_Void_0;

	// Token: 0x040003BA RID: 954
	private static readonly IntPtr NativeMethodInfoPtr__setAlphaVertex_b__95_1_Private_Void_0;

	// Token: 0x040003BB RID: 955
	private static readonly IntPtr NativeMethodInfoPtr__setColor_b__96_0_Private_Void_0;

	// Token: 0x040003BC RID: 956
	private static readonly IntPtr NativeMethodInfoPtr__setColor_b__96_1_Private_Void_0;

	// Token: 0x040003BD RID: 957
	private static readonly IntPtr NativeMethodInfoPtr__setCallbackColor_b__97_0_Private_Void_0;

	// Token: 0x040003BE RID: 958
	private static readonly IntPtr NativeMethodInfoPtr__setCallbackColor_b__97_1_Private_Void_0;

	// Token: 0x040003BF RID: 959
	private static readonly IntPtr NativeMethodInfoPtr__setTextColor_b__98_0_Private_Void_0;

	// Token: 0x040003C0 RID: 960
	private static readonly IntPtr NativeMethodInfoPtr__setTextColor_b__98_1_Private_Void_0;

	// Token: 0x040003C1 RID: 961
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasAlpha_b__99_0_Private_Void_0;

	// Token: 0x040003C2 RID: 962
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasAlpha_b__99_1_Private_Void_0;

	// Token: 0x040003C3 RID: 963
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_0_Private_Void_0;

	// Token: 0x040003C4 RID: 964
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasGroupAlpha_b__100_1_Private_Void_0;

	// Token: 0x040003C5 RID: 965
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasColor_b__101_0_Private_Void_0;

	// Token: 0x040003C6 RID: 966
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasColor_b__101_1_Private_Void_0;

	// Token: 0x040003C7 RID: 967
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasMoveX_b__102_0_Private_Void_0;

	// Token: 0x040003C8 RID: 968
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasMoveX_b__102_1_Private_Void_0;

	// Token: 0x040003C9 RID: 969
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasMoveY_b__103_0_Private_Void_0;

	// Token: 0x040003CA RID: 970
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasMoveY_b__103_1_Private_Void_0;

	// Token: 0x040003CB RID: 971
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasMoveZ_b__104_0_Private_Void_0;

	// Token: 0x040003CC RID: 972
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasMoveZ_b__104_1_Private_Void_0;

	// Token: 0x040003CD RID: 973
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasRotateAround_b__106_0_Private_Void_0;

	// Token: 0x040003CE RID: 974
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasRotateAroundLocal_b__107_0_Private_Void_0;

	// Token: 0x040003CF RID: 975
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasPlaySprite_b__108_0_Private_Void_0;

	// Token: 0x040003D0 RID: 976
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasPlaySprite_b__108_1_Private_Void_0;

	// Token: 0x040003D1 RID: 977
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasMove_b__109_0_Private_Void_0;

	// Token: 0x040003D2 RID: 978
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasMove_b__109_1_Private_Void_0;

	// Token: 0x040003D3 RID: 979
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasScale_b__110_0_Private_Void_0;

	// Token: 0x040003D4 RID: 980
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasScale_b__110_1_Private_Void_0;

	// Token: 0x040003D5 RID: 981
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasSizeDelta_b__111_0_Private_Void_0;

	// Token: 0x040003D6 RID: 982
	private static readonly IntPtr NativeMethodInfoPtr__setCanvasSizeDelta_b__111_1_Private_Void_0;

	// Token: 0x040003D7 RID: 983
	private static readonly IntPtr NativeMethodInfoPtr__setMove_b__115_0_Private_Void_0;

	// Token: 0x040003D8 RID: 984
	private static readonly IntPtr NativeMethodInfoPtr__setMove_b__115_1_Private_Void_0;

	// Token: 0x040003D9 RID: 985
	private static readonly IntPtr NativeMethodInfoPtr__setMoveLocal_b__116_0_Private_Void_0;

	// Token: 0x040003DA RID: 986
	private static readonly IntPtr NativeMethodInfoPtr__setMoveLocal_b__116_1_Private_Void_0;

	// Token: 0x040003DB RID: 987
	private static readonly IntPtr NativeMethodInfoPtr__setMoveToTransform_b__117_0_Private_Void_0;

	// Token: 0x040003DC RID: 988
	private static readonly IntPtr NativeMethodInfoPtr__setMoveToTransform_b__117_1_Private_Void_0;

	// Token: 0x040003DD RID: 989
	private static readonly IntPtr NativeMethodInfoPtr__setRotate_b__118_0_Private_Void_0;

	// Token: 0x040003DE RID: 990
	private static readonly IntPtr NativeMethodInfoPtr__setRotate_b__118_1_Private_Void_0;

	// Token: 0x040003DF RID: 991
	private static readonly IntPtr NativeMethodInfoPtr__setRotateLocal_b__119_0_Private_Void_0;

	// Token: 0x040003E0 RID: 992
	private static readonly IntPtr NativeMethodInfoPtr__setRotateLocal_b__119_1_Private_Void_0;

	// Token: 0x040003E1 RID: 993
	private static readonly IntPtr NativeMethodInfoPtr__setScale_b__120_0_Private_Void_0;

	// Token: 0x040003E2 RID: 994
	private static readonly IntPtr NativeMethodInfoPtr__setScale_b__120_1_Private_Void_0;

	// Token: 0x040003E3 RID: 995
	private static readonly IntPtr NativeMethodInfoPtr__setGUIMove_b__121_0_Private_Void_0;

	// Token: 0x040003E4 RID: 996
	private static readonly IntPtr NativeMethodInfoPtr__setGUIMove_b__121_1_Private_Void_0;

	// Token: 0x040003E5 RID: 997
	private static readonly IntPtr NativeMethodInfoPtr__setGUIMoveMargin_b__122_0_Private_Void_0;

	// Token: 0x040003E6 RID: 998
	private static readonly IntPtr NativeMethodInfoPtr__setGUIMoveMargin_b__122_1_Private_Void_0;

	// Token: 0x040003E7 RID: 999
	private static readonly IntPtr NativeMethodInfoPtr__setGUIScale_b__123_0_Private_Void_0;

	// Token: 0x040003E8 RID: 1000
	private static readonly IntPtr NativeMethodInfoPtr__setGUIScale_b__123_1_Private_Void_0;

	// Token: 0x040003E9 RID: 1001
	private static readonly IntPtr NativeMethodInfoPtr__setGUIAlpha_b__124_0_Private_Void_0;

	// Token: 0x040003EA RID: 1002
	private static readonly IntPtr NativeMethodInfoPtr__setGUIAlpha_b__124_1_Private_Void_0;

	// Token: 0x040003EB RID: 1003
	private static readonly IntPtr NativeMethodInfoPtr__setGUIRotate_b__125_0_Private_Void_0;

	// Token: 0x040003EC RID: 1004
	private static readonly IntPtr NativeMethodInfoPtr__setGUIRotate_b__125_1_Private_Void_0;

	// Token: 0x040003ED RID: 1005
	private static readonly IntPtr NativeMethodInfoPtr__setDelayedSound_b__126_0_Private_Void_0;

	// Token: 0x0200016E RID: 366
	public sealed class EaseTypeDelegate : MulticastDelegate
	{
		// Token: 0x060018EF RID: 6383 RVA: 0x0007C7CC File Offset: 0x0007A9CC
		// Note: this type is marked as 'beforefieldinit'.
		static EaseTypeDelegate()
		{
			Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "EaseTypeDelegate");
			LTDescr.EaseTypeDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr, 100664087);
			LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr, 100664088);
			LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr, 100664089);
			LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr, 100664090);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0007C840 File Offset: 0x0007AA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14616, XrefRangeEnd = 14619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EaseTypeDelegate(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescr.EaseTypeDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.EaseTypeDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0007C89C File Offset: 0x0007AA9C
		[CallerCount(0)]
		public unsafe Vector3 Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0007C8DC File Offset: 0x0007AADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14619, XrefRangeEnd = 14620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0007C940 File Offset: 0x0007AB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14620, XrefRangeEnd = 14622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.EaseTypeDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00009D1C File Offset: 0x00007F1C
		public EaseTypeDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00009D25 File Offset: 0x00007F25
		public static implicit operator LTDescr.EaseTypeDelegate(Func<Vector3> A_0)
		{
			return DelegateSupport.ConvertDelegate<LTDescr.EaseTypeDelegate>(A_0);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00009D2D File Offset: 0x00007F2D
		public static LTDescr.EaseTypeDelegate operator +(LTDescr.EaseTypeDelegate A_0, LTDescr.EaseTypeDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<LTDescr.EaseTypeDelegate>();
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00009D3B File Offset: 0x00007F3B
		public static LTDescr.EaseTypeDelegate operator -(LTDescr.EaseTypeDelegate A_0, LTDescr.EaseTypeDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<LTDescr.EaseTypeDelegate>();
			}
			return delegate2;
		}

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0;
	}

	// Token: 0x0200016F RID: 367
	public sealed class ActionMethodDelegate : MulticastDelegate
	{
		// Token: 0x060018F8 RID: 6392 RVA: 0x0007C990 File Offset: 0x0007AB90
		// Note: this type is marked as 'beforefieldinit'.
		static ActionMethodDelegate()
		{
			Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "ActionMethodDelegate");
			LTDescr.ActionMethodDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr, 100664091);
			LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr, 100664092);
			LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr, 100664093);
			LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr, 100664094);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0007CA04 File Offset: 0x0007AC04
		[CallerCount(247)]
		[CachedScanResults(RefRangeStart = 14625, RefRangeEnd = 14872, XrefRangeStart = 14622, XrefRangeEnd = 14625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionMethodDelegate(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescr.ActionMethodDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.ActionMethodDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0007CA60 File Offset: 0x0007AC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14872, XrefRangeEnd = 14876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0007CA94 File Offset: 0x0007AC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0007CAF8 File Offset: 0x0007ACF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14876, XrefRangeEnd = 14877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.ActionMethodDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00009D4C File Offset: 0x00007F4C
		public ActionMethodDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00009D55 File Offset: 0x00007F55
		public static implicit operator LTDescr.ActionMethodDelegate(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<LTDescr.ActionMethodDelegate>(A_0);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00009D5D File Offset: 0x00007F5D
		public static LTDescr.ActionMethodDelegate operator +(LTDescr.ActionMethodDelegate A_0, LTDescr.ActionMethodDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<LTDescr.ActionMethodDelegate>();
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00009D6B File Offset: 0x00007F6B
		public static LTDescr.ActionMethodDelegate operator -(LTDescr.ActionMethodDelegate A_0, LTDescr.ActionMethodDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<LTDescr.ActionMethodDelegate>();
			}
			return delegate2;
		}

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x02000170 RID: 368
	[ObfuscatedName("LTDescr+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06001901 RID: 6401 RVA: 0x0007CB3C File Offset: 0x0007AD3C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr);
			LTDescr.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, "<>9");
			LTDescr.__c.NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, "<>9__113_0");
			LTDescr.__c.NativeFieldInfoPtr___9__114_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, "<>9__114_0");
			LTDescr.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, 100664096);
			LTDescr.__c.NativeMethodInfoPtr__setCallback_b__113_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, 100664097);
			LTDescr.__c.NativeMethodInfoPtr__setValue3_b__114_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr, 100664098);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0007CBE0 File Offset: 0x0007ADE0
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescr.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0007CC1C File Offset: 0x0007AE1C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _setCallback_b__113_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.__c.NativeMethodInfoPtr__setCallback_b__113_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0007CC50 File Offset: 0x0007AE50
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _setValue3_b__114_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescr.__c.NativeMethodInfoPtr__setValue3_b__114_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00009D7C File Offset: 0x00007F7C
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x0007CC84 File Offset: 0x0007AE84
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00009D85 File Offset: 0x00007F85
		public unsafe static LTDescr.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LTDescr.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LTDescr.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0007CCAC File Offset: 0x0007AEAC
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x00009D97 File Offset: 0x00007F97
		public unsafe static LTDescr.ActionMethodDelegate __9__113_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LTDescr.__c.NativeFieldInfoPtr___9__113_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr.ActionMethodDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LTDescr.__c.NativeFieldInfoPtr___9__113_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0007CCD4 File Offset: 0x0007AED4
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x00009DA9 File Offset: 0x00007FA9
		public unsafe static LTDescr.ActionMethodDelegate __9__114_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LTDescr.__c.NativeFieldInfoPtr___9__114_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr.ActionMethodDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LTDescr.__c.NativeFieldInfoPtr___9__114_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeFieldInfoPtr___9__113_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeFieldInfoPtr___9__114_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr__setCallback_b__113_0_Internal_Void_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr__setValue3_b__114_0_Internal_Void_0;
	}
}
