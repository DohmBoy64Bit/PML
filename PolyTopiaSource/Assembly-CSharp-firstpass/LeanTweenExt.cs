using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000015 RID: 21
public static class LeanTweenExt : global::Il2CppSystem.Object
{
	// Token: 0x06000254 RID: 596 RVA: 0x0001A5C8 File Offset: 0x000187C8
	// Note: this type is marked as 'beforefieldinit'.
	static LeanTweenExt()
	{
		Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanTweenExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr);
		LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663677);
		LeanTweenExt.NativeMethodInfoPtr_LeanAlphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663678);
		LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663679);
		LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_CanvasGroup_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663680);
		LeanTweenExt.NativeMethodInfoPtr_LeanAlphaText_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663681);
		LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663682);
		LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663683);
		LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663684);
		LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663685);
		LeanTweenExt.NativeMethodInfoPtr_LeanColor_Public_Static_LTDescr_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663686);
		LeanTweenExt.NativeMethodInfoPtr_LeanColorText_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663687);
		LeanTweenExt.NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663688);
		LeanTweenExt.NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663689);
		LeanTweenExt.NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663690);
		LeanTweenExt.NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663691);
		LeanTweenExt.NativeMethodInfoPtr_LeanIsTweening_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663692);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663693);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663694);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663695);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663696);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663697);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663698);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663699);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663700);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663701);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663702);
		LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663703);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663704);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663705);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663706);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663707);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663708);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663709);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663710);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663711);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663712);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663713);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663714);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663715);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663716);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663717);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663718);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663719);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663720);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663721);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663722);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663723);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663724);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663725);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663726);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663727);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663728);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663729);
		LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663730);
		LeanTweenExt.NativeMethodInfoPtr_LeanPause_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663731);
		LeanTweenExt.NativeMethodInfoPtr_LeanPlay_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663732);
		LeanTweenExt.NativeMethodInfoPtr_LeanResume_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663733);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663734);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663735);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663736);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663737);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_Transform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663738);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663739);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663740);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_Transform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663741);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663742);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663743);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663744);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663745);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663746);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663747);
		LeanTweenExt.NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663748);
		LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663749);
		LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663750);
		LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663751);
		LeanTweenExt.NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663752);
		LeanTweenExt.NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663753);
		LeanTweenExt.NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663754);
		LeanTweenExt.NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663755);
		LeanTweenExt.NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663756);
		LeanTweenExt.NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663757);
		LeanTweenExt.NativeMethodInfoPtr_LeanSize_Public_Static_LTDescr_RectTransform_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663758);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663759);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663760);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663761);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663762);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663763);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663764);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663765);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663766);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663767);
		LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663768);
		LeanTweenExt.NativeMethodInfoPtr_LeanSetPosX_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663769);
		LeanTweenExt.NativeMethodInfoPtr_LeanSetPosY_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663770);
		LeanTweenExt.NativeMethodInfoPtr_LeanSetPosZ_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663771);
		LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosX_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663772);
		LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosY_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663773);
		LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosZ_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663774);
		LeanTweenExt.NativeMethodInfoPtr_LeanColor_Public_Static_Color_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTweenExt>.NativeClassPtr, 100663775);
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0001ADB4 File Offset: 0x00018FB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14145, XrefRangeEnd = 14149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanAlpha(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000256 RID: 598 RVA: 0x0001AE14 File Offset: 0x00019014
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14149, XrefRangeEnd = 14153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanAlphaVertex(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x0001AE74 File Offset: 0x00019074
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14153, XrefRangeEnd = 14157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanAlpha(this RectTransform rectTransform, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x0001AED4 File Offset: 0x000190D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14157, XrefRangeEnd = 14161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanAlpha(this CanvasGroup canvas, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_CanvasGroup_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0001AF34 File Offset: 0x00019134
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14161, XrefRangeEnd = 14165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanAlphaText(this RectTransform rectTransform, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanAlphaText_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600025A RID: 602 RVA: 0x0001AF94 File Offset: 0x00019194
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14165, XrefRangeEnd = 14169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanCancel(this GameObject gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600025B RID: 603 RVA: 0x0001AFCC File Offset: 0x000191CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14169, XrefRangeEnd = 14173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanCancel(this GameObject gameObject, bool callOnComplete)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callOnComplete;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600025C RID: 604 RVA: 0x0001B010 File Offset: 0x00019210
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14173, XrefRangeEnd = 14177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanCancel(this GameObject gameObject, int uniqueId, bool callOnComplete = false)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0001B064 File Offset: 0x00019264
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14177, XrefRangeEnd = 14181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanCancel(this RectTransform rectTransform)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanCancel_Public_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0001B09C File Offset: 0x0001929C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14181, XrefRangeEnd = 14185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanColor(this GameObject gameObject, Color to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanColor_Public_Static_LTDescr_GameObject_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0001B100 File Offset: 0x00019300
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14185, XrefRangeEnd = 14189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanColorText(this RectTransform rectTransform, Color to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanColorText_Public_Static_LTDescr_RectTransform_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0001B164 File Offset: 0x00019364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14189, XrefRangeEnd = 14193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanDelayedCall(this GameObject gameObject, float delayTime, Action callback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0001B1C8 File Offset: 0x000193C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14193, XrefRangeEnd = 14197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanDelayedCall(this GameObject gameObject, float delayTime, Action<global::Il2CppSystem.Object> callback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0001B22C File Offset: 0x0001942C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14197, XrefRangeEnd = 14201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LeanIsPaused(this GameObject gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0001B270 File Offset: 0x00019470
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14201, XrefRangeEnd = 14205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LeanIsPaused(this RectTransform rectTransform)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0001B2B4 File Offset: 0x000194B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14205, XrefRangeEnd = 14209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LeanIsTweening(this GameObject gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanIsTweening_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0001B2F8 File Offset: 0x000194F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14209, XrefRangeEnd = 14213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this GameObject gameObject, Vector3 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000266 RID: 614 RVA: 0x0001B35C File Offset: 0x0001955C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14213, XrefRangeEnd = 14218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this Transform transform, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000267 RID: 615 RVA: 0x0001B3C0 File Offset: 0x000195C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14218, XrefRangeEnd = 14222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this RectTransform rectTransform, Vector3 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_RectTransform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000268 RID: 616 RVA: 0x0001B424 File Offset: 0x00019624
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14222, XrefRangeEnd = 14226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this GameObject gameObject, Vector2 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000269 RID: 617 RVA: 0x0001B488 File Offset: 0x00019688
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14226, XrefRangeEnd = 14232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this Transform transform, Vector2 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x0001B4EC File Offset: 0x000196EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14232, XrefRangeEnd = 14236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x0001B550 File Offset: 0x00019750
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14236, XrefRangeEnd = 14240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this GameObject gameObject, LTBezierPath to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0001B5B4 File Offset: 0x000197B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14240, XrefRangeEnd = 14244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this GameObject gameObject, LTSpline to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTSpline_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0001B618 File Offset: 0x00019818
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14244, XrefRangeEnd = 14250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this Transform transform, Il2CppStructArray<Vector3> to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0001B67C File Offset: 0x0001987C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14250, XrefRangeEnd = 14256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this Transform transform, LTBezierPath to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTBezierPath_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0001B6E0 File Offset: 0x000198E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14256, XrefRangeEnd = 14262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMove(this Transform transform, LTSpline to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTSpline_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0001B744 File Offset: 0x00019944
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14262, XrefRangeEnd = 14266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocal(this GameObject gameObject, Vector3 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0001B7A8 File Offset: 0x000199A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14266, XrefRangeEnd = 14270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocal(this GameObject gameObject, LTBezierPath to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0001B80C File Offset: 0x00019A0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14270, XrefRangeEnd = 14274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocal(this GameObject gameObject, LTSpline to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0001B870 File Offset: 0x00019A70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14274, XrefRangeEnd = 14279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocal(this Transform transform, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000274 RID: 628 RVA: 0x0001B8D4 File Offset: 0x00019AD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14279, XrefRangeEnd = 14285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocal(this Transform transform, LTBezierPath to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTBezierPath_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0001B938 File Offset: 0x00019B38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14285, XrefRangeEnd = 14291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocal(this Transform transform, LTSpline to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTSpline_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0001B99C File Offset: 0x00019B9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14291, XrefRangeEnd = 14295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocalX(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000277 RID: 631 RVA: 0x0001B9FC File Offset: 0x00019BFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14295, XrefRangeEnd = 14299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocalY(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0001BA5C File Offset: 0x00019C5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14299, XrefRangeEnd = 14303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocalZ(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0001BABC File Offset: 0x00019CBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14303, XrefRangeEnd = 14309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocalX(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0001BB1C File Offset: 0x00019D1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14309, XrefRangeEnd = 14315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocalY(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0001BB7C File Offset: 0x00019D7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14315, XrefRangeEnd = 14321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveLocalZ(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0001BBDC File Offset: 0x00019DDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14321, XrefRangeEnd = 14325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveSpline(this GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0001BC40 File Offset: 0x00019E40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14325, XrefRangeEnd = 14329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveSpline(this GameObject gameObject, LTSpline to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x0001BCA4 File Offset: 0x00019EA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14329, XrefRangeEnd = 14335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveSpline(this Transform transform, Il2CppStructArray<Vector3> to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600027F RID: 639 RVA: 0x0001BD08 File Offset: 0x00019F08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14335, XrefRangeEnd = 14341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveSpline(this Transform transform, LTSpline to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_LTSpline_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0001BD6C File Offset: 0x00019F6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14341, XrefRangeEnd = 14345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveSplineLocal(this GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0001BDD0 File Offset: 0x00019FD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14345, XrefRangeEnd = 14351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveSplineLocal(this Transform transform, Il2CppStructArray<Vector3> to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0001BE34 File Offset: 0x0001A034
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14351, XrefRangeEnd = 14355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveX(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x0001BE94 File Offset: 0x0001A094
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14355, XrefRangeEnd = 14361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveX(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0001BEF4 File Offset: 0x0001A0F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14361, XrefRangeEnd = 14365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveX(this RectTransform rectTransform, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000285 RID: 645 RVA: 0x0001BF54 File Offset: 0x0001A154
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14365, XrefRangeEnd = 14369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveY(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0001BFB4 File Offset: 0x0001A1B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14369, XrefRangeEnd = 14375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveY(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000287 RID: 647 RVA: 0x0001C014 File Offset: 0x0001A214
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14375, XrefRangeEnd = 14379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveY(this RectTransform rectTransform, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x0001C074 File Offset: 0x0001A274
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14379, XrefRangeEnd = 14383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveZ(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000289 RID: 649 RVA: 0x0001C0D4 File Offset: 0x0001A2D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14383, XrefRangeEnd = 14389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveZ(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600028A RID: 650 RVA: 0x0001C134 File Offset: 0x0001A334
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14389, XrefRangeEnd = 14393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanMoveZ(this RectTransform rectTransform, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600028B RID: 651 RVA: 0x0001C194 File Offset: 0x0001A394
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14393, XrefRangeEnd = 14397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanPause(this GameObject gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanPause_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600028C RID: 652 RVA: 0x0001C1CC File Offset: 0x0001A3CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14397, XrefRangeEnd = 14401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanPlay(this RectTransform rectTransform, Il2CppReferenceArray<Sprite> sprites)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprites);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanPlay_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0001C224 File Offset: 0x0001A424
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14401, XrefRangeEnd = 14405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanResume(this GameObject gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanResume_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0001C25C File Offset: 0x0001A45C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14405, XrefRangeEnd = 14409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotate(this GameObject gameObject, Vector3 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600028F RID: 655 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14409, XrefRangeEnd = 14414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotate(this Transform transform, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_Transform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0001C324 File Offset: 0x0001A524
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14414, XrefRangeEnd = 14418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotate(this RectTransform rectTransform, Vector3 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0001C388 File Offset: 0x0001A588
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14418, XrefRangeEnd = 14422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateAround(this GameObject gameObject, Vector3 axis, float add, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000292 RID: 658 RVA: 0x0001C3FC File Offset: 0x0001A5FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14422, XrefRangeEnd = 14427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateAround(this Transform transform, Vector3 axis, float add, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_Transform_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000293 RID: 659 RVA: 0x0001C470 File Offset: 0x0001A670
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14427, XrefRangeEnd = 14431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateAround(this RectTransform rectTransform, Vector3 axis, float add, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000294 RID: 660 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14431, XrefRangeEnd = 14435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateAroundLocal(this GameObject gameObject, Vector3 axis, float add, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000295 RID: 661 RVA: 0x0001C558 File Offset: 0x0001A758
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14435, XrefRangeEnd = 14440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateAroundLocal(this Transform transform, Vector3 axis, float add, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_Transform_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0001C5CC File Offset: 0x0001A7CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14440, XrefRangeEnd = 14444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateAroundLocal(this RectTransform rectTransform, Vector3 axis, float add, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000297 RID: 663 RVA: 0x0001C640 File Offset: 0x0001A840
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14444, XrefRangeEnd = 14448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateX(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14448, XrefRangeEnd = 14454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateX(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x06000299 RID: 665 RVA: 0x0001C700 File Offset: 0x0001A900
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14454, XrefRangeEnd = 14458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateY(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600029A RID: 666 RVA: 0x0001C760 File Offset: 0x0001A960
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14458, XrefRangeEnd = 14464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateY(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600029B RID: 667 RVA: 0x0001C7C0 File Offset: 0x0001A9C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14464, XrefRangeEnd = 14468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateZ(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600029C RID: 668 RVA: 0x0001C820 File Offset: 0x0001AA20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14468, XrefRangeEnd = 14474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanRotateZ(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0001C880 File Offset: 0x0001AA80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14474, XrefRangeEnd = 14478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanScale(this GameObject gameObject, Vector3 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_GameObject_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600029E RID: 670 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14478, XrefRangeEnd = 14483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanScale(this Transform transform, Vector3 to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_Transform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x0600029F RID: 671 RVA: 0x0001C948 File Offset: 0x0001AB48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14483, XrefRangeEnd = 14487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanScale(this RectTransform rectTransform, Vector3 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_RectTransform_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x0001C9AC File Offset: 0x0001ABAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14487, XrefRangeEnd = 14491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanScaleX(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0001CA0C File Offset: 0x0001AC0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14491, XrefRangeEnd = 14497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanScaleX(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0001CA6C File Offset: 0x0001AC6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14497, XrefRangeEnd = 14501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanScaleY(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0001CACC File Offset: 0x0001ACCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14501, XrefRangeEnd = 14507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanScaleY(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0001CB2C File Offset: 0x0001AD2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14507, XrefRangeEnd = 14511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanScaleZ(this GameObject gameObject, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_GameObject_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0001CB8C File Offset: 0x0001AD8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14511, XrefRangeEnd = 14517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanScaleZ(this Transform transform, float to, float time)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0001CBEC File Offset: 0x0001ADEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14517, XrefRangeEnd = 14521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanSize(this RectTransform rectTransform, Vector2 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSize_Public_Static_LTDescr_RectTransform_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0001CC50 File Offset: 0x0001AE50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14521, XrefRangeEnd = 14525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, Color from, Color to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x0001CCC8 File Offset: 0x0001AEC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14525, XrefRangeEnd = 14529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, float from, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0001CD38 File Offset: 0x0001AF38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14529, XrefRangeEnd = 14533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, Vector2 from, Vector2 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0001CDB0 File Offset: 0x0001AFB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14533, XrefRangeEnd = 14537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, Vector3 from, Vector3 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0001CE28 File Offset: 0x0001B028
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14537, XrefRangeEnd = 14541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14541, XrefRangeEnd = 14545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, Action<float, float> callOnUpdate, float from, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0001CF28 File Offset: 0x0001B128
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14545, XrefRangeEnd = 14549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, Action<float, global::Il2CppSystem.Object> callOnUpdate, float from, float to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002AE RID: 686 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14549, XrefRangeEnd = 14553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0001D030 File Offset: 0x0001B230
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14553, XrefRangeEnd = 14557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14557, XrefRangeEnd = 14561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr LeanValue(this GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr3) : null;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0001D140 File Offset: 0x0001B340
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14564, RefRangeEnd = 14568, XrefRangeStart = 14561, XrefRangeEnd = 14564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanSetPosX(this Transform transform, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetPosX_Public_Static_Void_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x0001D184 File Offset: 0x0001B384
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14571, RefRangeEnd = 14575, XrefRangeStart = 14568, XrefRangeEnd = 14571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanSetPosY(this Transform transform, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetPosY_Public_Static_Void_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x0001D1C8 File Offset: 0x0001B3C8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14578, RefRangeEnd = 14582, XrefRangeStart = 14575, XrefRangeEnd = 14578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanSetPosZ(this Transform transform, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetPosZ_Public_Static_Void_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x0001D20C File Offset: 0x0001B40C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14585, RefRangeEnd = 14589, XrefRangeStart = 14582, XrefRangeEnd = 14585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanSetLocalPosX(this Transform transform, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosX_Public_Static_Void_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0001D250 File Offset: 0x0001B450
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14592, RefRangeEnd = 14596, XrefRangeStart = 14589, XrefRangeEnd = 14592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanSetLocalPosY(this Transform transform, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosY_Public_Static_Void_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0001D294 File Offset: 0x0001B494
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14599, RefRangeEnd = 14603, XrefRangeStart = 14596, XrefRangeEnd = 14599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LeanSetLocalPosZ(this Transform transform, float val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanSetLocalPosZ_Public_Static_Void_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x0001D2D8 File Offset: 0x0001B4D8
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 14608, RefRangeEnd = 14616, XrefRangeStart = 14603, XrefRangeEnd = 14608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color LeanColor(this Transform transform)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTweenExt.NativeMethodInfoPtr_LeanColor_Public_Static_Color_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
		}
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00002ACC File Offset: 0x00000CCC
	public LeanTweenExt(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000224 RID: 548
	private static readonly IntPtr NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000225 RID: 549
	private static readonly IntPtr NativeMethodInfoPtr_LeanAlphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000226 RID: 550
	private static readonly IntPtr NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000227 RID: 551
	private static readonly IntPtr NativeMethodInfoPtr_LeanAlpha_Public_Static_LTDescr_CanvasGroup_Single_Single_0;

	// Token: 0x04000228 RID: 552
	private static readonly IntPtr NativeMethodInfoPtr_LeanAlphaText_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000229 RID: 553
	private static readonly IntPtr NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_0;

	// Token: 0x0400022A RID: 554
	private static readonly IntPtr NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Boolean_0;

	// Token: 0x0400022B RID: 555
	private static readonly IntPtr NativeMethodInfoPtr_LeanCancel_Public_Static_Void_GameObject_Int32_Boolean_0;

	// Token: 0x0400022C RID: 556
	private static readonly IntPtr NativeMethodInfoPtr_LeanCancel_Public_Static_Void_RectTransform_0;

	// Token: 0x0400022D RID: 557
	private static readonly IntPtr NativeMethodInfoPtr_LeanColor_Public_Static_LTDescr_GameObject_Color_Single_0;

	// Token: 0x0400022E RID: 558
	private static readonly IntPtr NativeMethodInfoPtr_LeanColorText_Public_Static_LTDescr_RectTransform_Color_Single_0;

	// Token: 0x0400022F RID: 559
	private static readonly IntPtr NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_0;

	// Token: 0x04000230 RID: 560
	private static readonly IntPtr NativeMethodInfoPtr_LeanDelayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0;

	// Token: 0x04000231 RID: 561
	private static readonly IntPtr NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_GameObject_0;

	// Token: 0x04000232 RID: 562
	private static readonly IntPtr NativeMethodInfoPtr_LeanIsPaused_Public_Static_Boolean_RectTransform_0;

	// Token: 0x04000233 RID: 563
	private static readonly IntPtr NativeMethodInfoPtr_LeanIsTweening_Public_Static_Boolean_GameObject_0;

	// Token: 0x04000234 RID: 564
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	// Token: 0x04000235 RID: 565
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector3_Single_0;

	// Token: 0x04000236 RID: 566
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_RectTransform_Vector3_Single_0;

	// Token: 0x04000237 RID: 567
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Vector2_Single_0;

	// Token: 0x04000238 RID: 568
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Vector2_Single_0;

	// Token: 0x04000239 RID: 569
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x0400023A RID: 570
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;

	// Token: 0x0400023B RID: 571
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_GameObject_LTSpline_Single_0;

	// Token: 0x0400023C RID: 572
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x0400023D RID: 573
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTBezierPath_Single_0;

	// Token: 0x0400023E RID: 574
	private static readonly IntPtr NativeMethodInfoPtr_LeanMove_Public_Static_LTDescr_Transform_LTSpline_Single_0;

	// Token: 0x0400023F RID: 575
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	// Token: 0x04000240 RID: 576
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;

	// Token: 0x04000241 RID: 577
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0;

	// Token: 0x04000242 RID: 578
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_Vector3_Single_0;

	// Token: 0x04000243 RID: 579
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTBezierPath_Single_0;

	// Token: 0x04000244 RID: 580
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocal_Public_Static_LTDescr_Transform_LTSpline_Single_0;

	// Token: 0x04000245 RID: 581
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000246 RID: 582
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000247 RID: 583
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000248 RID: 584
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocalX_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x04000249 RID: 585
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocalY_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x0400024A RID: 586
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveLocalZ_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x0400024B RID: 587
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x0400024C RID: 588
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0;

	// Token: 0x0400024D RID: 589
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x0400024E RID: 590
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveSpline_Public_Static_LTDescr_Transform_LTSpline_Single_0;

	// Token: 0x0400024F RID: 591
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_GameObject_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x04000250 RID: 592
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveSplineLocal_Public_Static_LTDescr_Transform_Il2CppStructArray_1_Vector3_Single_0;

	// Token: 0x04000251 RID: 593
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000252 RID: 594
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x04000253 RID: 595
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveX_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000254 RID: 596
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000255 RID: 597
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x04000256 RID: 598
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveY_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x04000257 RID: 599
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000258 RID: 600
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x04000259 RID: 601
	private static readonly IntPtr NativeMethodInfoPtr_LeanMoveZ_Public_Static_LTDescr_RectTransform_Single_Single_0;

	// Token: 0x0400025A RID: 602
	private static readonly IntPtr NativeMethodInfoPtr_LeanPause_Public_Static_Void_GameObject_0;

	// Token: 0x0400025B RID: 603
	private static readonly IntPtr NativeMethodInfoPtr_LeanPlay_Public_Static_LTDescr_RectTransform_Il2CppReferenceArray_1_Sprite_0;

	// Token: 0x0400025C RID: 604
	private static readonly IntPtr NativeMethodInfoPtr_LeanResume_Public_Static_Void_GameObject_0;

	// Token: 0x0400025D RID: 605
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	// Token: 0x0400025E RID: 606
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_Transform_Vector3_Single_0;

	// Token: 0x0400025F RID: 607
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotate_Public_Static_LTDescr_RectTransform_Vector3_Single_0;

	// Token: 0x04000260 RID: 608
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;

	// Token: 0x04000261 RID: 609
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_Transform_Vector3_Single_Single_0;

	// Token: 0x04000262 RID: 610
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;

	// Token: 0x04000263 RID: 611
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;

	// Token: 0x04000264 RID: 612
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_Transform_Vector3_Single_Single_0;

	// Token: 0x04000265 RID: 613
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;

	// Token: 0x04000266 RID: 614
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000267 RID: 615
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateX_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x04000268 RID: 616
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000269 RID: 617
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateY_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x0400026A RID: 618
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x0400026B RID: 619
	private static readonly IntPtr NativeMethodInfoPtr_LeanRotateZ_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x0400026C RID: 620
	private static readonly IntPtr NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	// Token: 0x0400026D RID: 621
	private static readonly IntPtr NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_Transform_Vector3_Single_0;

	// Token: 0x0400026E RID: 622
	private static readonly IntPtr NativeMethodInfoPtr_LeanScale_Public_Static_LTDescr_RectTransform_Vector3_Single_0;

	// Token: 0x0400026F RID: 623
	private static readonly IntPtr NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000270 RID: 624
	private static readonly IntPtr NativeMethodInfoPtr_LeanScaleX_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x04000271 RID: 625
	private static readonly IntPtr NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000272 RID: 626
	private static readonly IntPtr NativeMethodInfoPtr_LeanScaleY_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x04000273 RID: 627
	private static readonly IntPtr NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	// Token: 0x04000274 RID: 628
	private static readonly IntPtr NativeMethodInfoPtr_LeanScaleZ_Public_Static_LTDescr_Transform_Single_Single_0;

	// Token: 0x04000275 RID: 629
	private static readonly IntPtr NativeMethodInfoPtr_LeanSize_Public_Static_LTDescr_RectTransform_Vector2_Single_0;

	// Token: 0x04000276 RID: 630
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Color_Color_Single_0;

	// Token: 0x04000277 RID: 631
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Single_Single_Single_0;

	// Token: 0x04000278 RID: 632
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0;

	// Token: 0x04000279 RID: 633
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0;

	// Token: 0x0400027A RID: 634
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0;

	// Token: 0x0400027B RID: 635
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0;

	// Token: 0x0400027C RID: 636
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0;

	// Token: 0x0400027D RID: 637
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0;

	// Token: 0x0400027E RID: 638
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0;

	// Token: 0x0400027F RID: 639
	private static readonly IntPtr NativeMethodInfoPtr_LeanValue_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0;

	// Token: 0x04000280 RID: 640
	private static readonly IntPtr NativeMethodInfoPtr_LeanSetPosX_Public_Static_Void_Transform_Single_0;

	// Token: 0x04000281 RID: 641
	private static readonly IntPtr NativeMethodInfoPtr_LeanSetPosY_Public_Static_Void_Transform_Single_0;

	// Token: 0x04000282 RID: 642
	private static readonly IntPtr NativeMethodInfoPtr_LeanSetPosZ_Public_Static_Void_Transform_Single_0;

	// Token: 0x04000283 RID: 643
	private static readonly IntPtr NativeMethodInfoPtr_LeanSetLocalPosX_Public_Static_Void_Transform_Single_0;

	// Token: 0x04000284 RID: 644
	private static readonly IntPtr NativeMethodInfoPtr_LeanSetLocalPosY_Public_Static_Void_Transform_Single_0;

	// Token: 0x04000285 RID: 645
	private static readonly IntPtr NativeMethodInfoPtr_LeanSetLocalPosZ_Public_Static_Void_Transform_Single_0;

	// Token: 0x04000286 RID: 646
	private static readonly IntPtr NativeMethodInfoPtr_LeanColor_Public_Static_Color_Transform_0;
}
