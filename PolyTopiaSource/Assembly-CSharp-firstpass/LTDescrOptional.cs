using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000017 RID: 23
public class LTDescrOptional : global::Il2CppSystem.Object
{
	// Token: 0x06000452 RID: 1106 RVA: 0x00024524 File Offset: 0x00022724
	// Note: this type is marked as 'beforefieldinit'.
	static LTDescrOptional()
	{
		Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTDescrOptional");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr);
		LTDescrOptional.NativeFieldInfoPtr__toTrans_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<toTrans>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__point_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<point>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__axis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<axis>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__lastVal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<lastVal>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__origRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<origRotation>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<path>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__spline_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<spline>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr_animationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "animationCurve");
		LTDescrOptional.NativeFieldInfoPtr_initFrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "initFrameCount");
		LTDescrOptional.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "color");
		LTDescrOptional.NativeFieldInfoPtr__ltRect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<ltRect>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onUpdateFloat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateFloat>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateFloatRatio>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateFloatObject>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onUpdateVector2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateVector2>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateVector3>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateVector3Object>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onUpdateColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateColor>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onUpdateColorObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateColorObject>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onComplete_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onComplete>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onCompleteObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onCompleteObject>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onCompleteParam_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onCompleteParam>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onUpdateParam_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateParam>k__BackingField");
		LTDescrOptional.NativeFieldInfoPtr__onStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onStart>k__BackingField");
		LTDescrOptional.NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664099);
		LTDescrOptional.NativeMethodInfoPtr_set_toTrans_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664100);
		LTDescrOptional.NativeMethodInfoPtr_get_point_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664101);
		LTDescrOptional.NativeMethodInfoPtr_set_point_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664102);
		LTDescrOptional.NativeMethodInfoPtr_get_axis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664103);
		LTDescrOptional.NativeMethodInfoPtr_set_axis_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664104);
		LTDescrOptional.NativeMethodInfoPtr_get_lastVal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664105);
		LTDescrOptional.NativeMethodInfoPtr_set_lastVal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664106);
		LTDescrOptional.NativeMethodInfoPtr_get_origRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664107);
		LTDescrOptional.NativeMethodInfoPtr_set_origRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664108);
		LTDescrOptional.NativeMethodInfoPtr_get_path_Public_get_LTBezierPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664109);
		LTDescrOptional.NativeMethodInfoPtr_set_path_Public_set_Void_LTBezierPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664110);
		LTDescrOptional.NativeMethodInfoPtr_get_spline_Public_get_LTSpline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664111);
		LTDescrOptional.NativeMethodInfoPtr_set_spline_Public_set_Void_LTSpline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664112);
		LTDescrOptional.NativeMethodInfoPtr_get_ltRect_Public_get_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664113);
		LTDescrOptional.NativeMethodInfoPtr_set_ltRect_Public_set_Void_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664114);
		LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloat_Public_get_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664115);
		LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloat_Public_set_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664116);
		LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloatRatio_Public_get_Action_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664117);
		LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloatRatio_Public_set_Void_Action_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664118);
		LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloatObject_Public_get_Action_2_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664119);
		LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloatObject_Public_set_Void_Action_2_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664120);
		LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector2_Public_get_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664121);
		LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector2_Public_set_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664122);
		LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector3_Public_get_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664123);
		LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector3_Public_set_Void_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664124);
		LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector3Object_Public_get_Action_2_Vector3_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664125);
		LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector3Object_Public_set_Void_Action_2_Vector3_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664126);
		LTDescrOptional.NativeMethodInfoPtr_get_onUpdateColor_Public_get_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664127);
		LTDescrOptional.NativeMethodInfoPtr_set_onUpdateColor_Public_set_Void_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664128);
		LTDescrOptional.NativeMethodInfoPtr_get_onUpdateColorObject_Public_get_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664129);
		LTDescrOptional.NativeMethodInfoPtr_set_onUpdateColorObject_Public_set_Void_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664130);
		LTDescrOptional.NativeMethodInfoPtr_get_onComplete_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664131);
		LTDescrOptional.NativeMethodInfoPtr_set_onComplete_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664132);
		LTDescrOptional.NativeMethodInfoPtr_get_onCompleteObject_Public_get_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664133);
		LTDescrOptional.NativeMethodInfoPtr_set_onCompleteObject_Public_set_Void_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664134);
		LTDescrOptional.NativeMethodInfoPtr_get_onCompleteParam_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664135);
		LTDescrOptional.NativeMethodInfoPtr_set_onCompleteParam_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664136);
		LTDescrOptional.NativeMethodInfoPtr_get_onUpdateParam_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664137);
		LTDescrOptional.NativeMethodInfoPtr_set_onUpdateParam_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664138);
		LTDescrOptional.NativeMethodInfoPtr_get_onStart_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664139);
		LTDescrOptional.NativeMethodInfoPtr_set_onStart_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664140);
		LTDescrOptional.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664143);
		LTDescrOptional.NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664141);
		LTDescrOptional.NativeMethodInfoPtr_callOnUpdate_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100664142);
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000453 RID: 1107 RVA: 0x00024AB8 File Offset: 0x00022CB8
	// (set) Token: 0x06000454 RID: 1108 RVA: 0x00024AF8 File Offset: 0x00022CF8
	public unsafe Transform toTrans
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17917, XrefRangeEnd = 17918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_toTrans_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000455 RID: 1109 RVA: 0x00024B3C File Offset: 0x00022D3C
	// (set) Token: 0x06000456 RID: 1110 RVA: 0x00024B7C File Offset: 0x00022D7C
	public unsafe Vector3 point
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_point_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_point_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000457 RID: 1111 RVA: 0x00024BC0 File Offset: 0x00022DC0
	// (set) Token: 0x06000458 RID: 1112 RVA: 0x00024C00 File Offset: 0x00022E00
	public unsafe Vector3 axis
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_axis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_axis_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06000459 RID: 1113 RVA: 0x00024C44 File Offset: 0x00022E44
	// (set) Token: 0x0600045A RID: 1114 RVA: 0x00024C80 File Offset: 0x00022E80
	public unsafe float lastVal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_lastVal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 17918, RefRangeEnd = 17920, XrefRangeStart = 17918, XrefRangeEnd = 17918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_lastVal_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x0600045B RID: 1115 RVA: 0x00024CC0 File Offset: 0x00022EC0
	// (set) Token: 0x0600045C RID: 1116 RVA: 0x00024D00 File Offset: 0x00022F00
	public unsafe Quaternion origRotation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_origRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_origRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x0600045D RID: 1117 RVA: 0x00024D44 File Offset: 0x00022F44
	// (set) Token: 0x0600045E RID: 1118 RVA: 0x00024D84 File Offset: 0x00022F84
	public unsafe LTBezierPath path
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_path_Public_get_LTBezierPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTBezierPath>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17920, XrefRangeEnd = 17921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_path_Public_set_Void_LTBezierPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x0600045F RID: 1119 RVA: 0x00024DC8 File Offset: 0x00022FC8
	// (set) Token: 0x06000460 RID: 1120 RVA: 0x00024E08 File Offset: 0x00023008
	public unsafe LTSpline spline
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_spline_Public_get_LTSpline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSpline>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17921, XrefRangeEnd = 17922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_spline_Public_set_Void_LTSpline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000461 RID: 1121 RVA: 0x00024E4C File Offset: 0x0002304C
	// (set) Token: 0x06000462 RID: 1122 RVA: 0x00024E8C File Offset: 0x0002308C
	public unsafe LTRect ltRect
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_ltRect_Public_get_LTRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17922, XrefRangeEnd = 17923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_ltRect_Public_set_Void_LTRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000463 RID: 1123 RVA: 0x00024ED0 File Offset: 0x000230D0
	// (set) Token: 0x06000464 RID: 1124 RVA: 0x00024F10 File Offset: 0x00023110
	public unsafe Action<float> onUpdateFloat
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloat_Public_get_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17923, XrefRangeEnd = 17924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloat_Public_set_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000465 RID: 1125 RVA: 0x00024F54 File Offset: 0x00023154
	// (set) Token: 0x06000466 RID: 1126 RVA: 0x00024F94 File Offset: 0x00023194
	public unsafe Action<float, float> onUpdateFloatRatio
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloatRatio_Public_get_Action_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17924, XrefRangeEnd = 17925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloatRatio_Public_set_Void_Action_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000467 RID: 1127 RVA: 0x00024FD8 File Offset: 0x000231D8
	// (set) Token: 0x06000468 RID: 1128 RVA: 0x00025018 File Offset: 0x00023218
	public unsafe Action<float, global::Il2CppSystem.Object> onUpdateFloatObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateFloatObject_Public_get_Action_2_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<float, global::Il2CppSystem.Object>>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17925, XrefRangeEnd = 17926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateFloatObject_Public_set_Void_Action_2_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000469 RID: 1129 RVA: 0x0002505C File Offset: 0x0002325C
	// (set) Token: 0x0600046A RID: 1130 RVA: 0x0002509C File Offset: 0x0002329C
	public unsafe Action<Vector2> onUpdateVector2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector2_Public_get_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Vector2>>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17926, XrefRangeEnd = 17927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector2_Public_set_Void_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x0600046B RID: 1131 RVA: 0x000250E0 File Offset: 0x000232E0
	// (set) Token: 0x0600046C RID: 1132 RVA: 0x00025120 File Offset: 0x00023320
	public unsafe Action<Vector3> onUpdateVector3
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector3_Public_get_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Vector3>>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17927, XrefRangeEnd = 17928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector3_Public_set_Void_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x0600046D RID: 1133 RVA: 0x00025164 File Offset: 0x00023364
	// (set) Token: 0x0600046E RID: 1134 RVA: 0x000251A4 File Offset: 0x000233A4
	public unsafe Action<Vector3, global::Il2CppSystem.Object> onUpdateVector3Object
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateVector3Object_Public_get_Action_2_Vector3_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Vector3, global::Il2CppSystem.Object>>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateVector3Object_Public_set_Void_Action_2_Vector3_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x0600046F RID: 1135 RVA: 0x000251E8 File Offset: 0x000233E8
	// (set) Token: 0x06000470 RID: 1136 RVA: 0x00025228 File Offset: 0x00023428
	public unsafe Action<Color> onUpdateColor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateColor_Public_get_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Color>>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateColor_Public_set_Void_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06000471 RID: 1137 RVA: 0x0002526C File Offset: 0x0002346C
	// (set) Token: 0x06000472 RID: 1138 RVA: 0x000252AC File Offset: 0x000234AC
	public unsafe Action<Color, global::Il2CppSystem.Object> onUpdateColorObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateColorObject_Public_get_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Color, global::Il2CppSystem.Object>>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17928, XrefRangeEnd = 17929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateColorObject_Public_set_Void_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000473 RID: 1139 RVA: 0x000252F0 File Offset: 0x000234F0
	// (set) Token: 0x06000474 RID: 1140 RVA: 0x00025330 File Offset: 0x00023530
	public unsafe Action onComplete
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onComplete_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17929, XrefRangeEnd = 17930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onComplete_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06000475 RID: 1141 RVA: 0x00025374 File Offset: 0x00023574
	// (set) Token: 0x06000476 RID: 1142 RVA: 0x000253B4 File Offset: 0x000235B4
	public unsafe Action<global::Il2CppSystem.Object> onCompleteObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onCompleteObject_Public_get_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<global::Il2CppSystem.Object>>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17930, XrefRangeEnd = 17931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onCompleteObject_Public_set_Void_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06000477 RID: 1143 RVA: 0x000253F8 File Offset: 0x000235F8
	// (set) Token: 0x06000478 RID: 1144 RVA: 0x00025438 File Offset: 0x00023638
	public unsafe global::Il2CppSystem.Object onCompleteParam
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onCompleteParam_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17932, RefRangeEnd = 17933, XrefRangeStart = 17931, XrefRangeEnd = 17932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onCompleteParam_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x06000479 RID: 1145 RVA: 0x0002547C File Offset: 0x0002367C
	// (set) Token: 0x0600047A RID: 1146 RVA: 0x000254BC File Offset: 0x000236BC
	public unsafe global::Il2CppSystem.Object onUpdateParam
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onUpdateParam_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17933, XrefRangeEnd = 17934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onUpdateParam_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x0600047B RID: 1147 RVA: 0x00025500 File Offset: 0x00023700
	// (set) Token: 0x0600047C RID: 1148 RVA: 0x00025540 File Offset: 0x00023740
	public unsafe Action onStart
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_get_onStart_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17934, XrefRangeEnd = 17935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_set_onStart_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00025584 File Offset: 0x00023784
	[CallerCount(2275)]
	[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescrOptional()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x000255C0 File Offset: 0x000237C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17935, XrefRangeEnd = 17949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x000255F4 File Offset: 0x000237F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17949, XrefRangeEnd = 17951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void callOnUpdate(float val, float ratioPassed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref val;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratioPassed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTDescrOptional.NativeMethodInfoPtr_callOnUpdate_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00003013 File Offset: 0x00001213
	public LTDescrOptional(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000481 RID: 1153 RVA: 0x00025640 File Offset: 0x00023840
	// (set) Token: 0x06000482 RID: 1154 RVA: 0x0000301C File Offset: 0x0000121C
	public unsafe Transform _toTrans_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__toTrans_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__toTrans_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000483 RID: 1155 RVA: 0x00025670 File Offset: 0x00023870
	// (set) Token: 0x06000484 RID: 1156 RVA: 0x0000303B File Offset: 0x0000123B
	public unsafe Vector3 _point_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__point_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__point_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000485 RID: 1157 RVA: 0x000256A0 File Offset: 0x000238A0
	// (set) Token: 0x06000486 RID: 1158 RVA: 0x0000305A File Offset: 0x0000125A
	public unsafe Vector3 _axis_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__axis_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__axis_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000487 RID: 1159 RVA: 0x000256D0 File Offset: 0x000238D0
	// (set) Token: 0x06000488 RID: 1160 RVA: 0x00003079 File Offset: 0x00001279
	public unsafe float _lastVal_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__lastVal_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__lastVal_k__BackingField)) = value;
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06000489 RID: 1161 RVA: 0x000256F8 File Offset: 0x000238F8
	// (set) Token: 0x0600048A RID: 1162 RVA: 0x00003094 File Offset: 0x00001294
	public unsafe Quaternion _origRotation_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__origRotation_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__origRotation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x0600048B RID: 1163 RVA: 0x00025728 File Offset: 0x00023928
	// (set) Token: 0x0600048C RID: 1164 RVA: 0x000030B3 File Offset: 0x000012B3
	public unsafe LTBezierPath _path_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__path_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTBezierPath>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__path_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x0600048D RID: 1165 RVA: 0x00025758 File Offset: 0x00023958
	// (set) Token: 0x0600048E RID: 1166 RVA: 0x000030D2 File Offset: 0x000012D2
	public unsafe LTSpline _spline_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__spline_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTSpline>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__spline_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x0600048F RID: 1167 RVA: 0x00025788 File Offset: 0x00023988
	// (set) Token: 0x06000490 RID: 1168 RVA: 0x000030F1 File Offset: 0x000012F1
	public unsafe AnimationCurve animationCurve
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_animationCurve);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_animationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06000491 RID: 1169 RVA: 0x000257B8 File Offset: 0x000239B8
	// (set) Token: 0x06000492 RID: 1170 RVA: 0x00003110 File Offset: 0x00001310
	public unsafe int initFrameCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_initFrameCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_initFrameCount)) = value;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000493 RID: 1171 RVA: 0x000257E0 File Offset: 0x000239E0
	// (set) Token: 0x06000494 RID: 1172 RVA: 0x0000312B File Offset: 0x0000132B
	public unsafe Color color
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_color);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000495 RID: 1173 RVA: 0x00025810 File Offset: 0x00023A10
	// (set) Token: 0x06000496 RID: 1174 RVA: 0x0000314A File Offset: 0x0000134A
	public unsafe LTRect _ltRect_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__ltRect_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__ltRect_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000497 RID: 1175 RVA: 0x00025840 File Offset: 0x00023A40
	// (set) Token: 0x06000498 RID: 1176 RVA: 0x00003169 File Offset: 0x00001369
	public unsafe Action<float> _onUpdateFloat_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloat_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000499 RID: 1177 RVA: 0x00025870 File Offset: 0x00023A70
	// (set) Token: 0x0600049A RID: 1178 RVA: 0x00003188 File Offset: 0x00001388
	public unsafe Action<float, float> _onUpdateFloatRatio_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x0600049B RID: 1179 RVA: 0x000258A0 File Offset: 0x00023AA0
	// (set) Token: 0x0600049C RID: 1180 RVA: 0x000031A7 File Offset: 0x000013A7
	public unsafe Action<float, global::Il2CppSystem.Object> _onUpdateFloatObject_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, global::Il2CppSystem.Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x0600049D RID: 1181 RVA: 0x000258D0 File Offset: 0x00023AD0
	// (set) Token: 0x0600049E RID: 1182 RVA: 0x000031C6 File Offset: 0x000013C6
	public unsafe Action<Vector2> _onUpdateVector2_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector2_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector2_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x0600049F RID: 1183 RVA: 0x00025900 File Offset: 0x00023B00
	// (set) Token: 0x060004A0 RID: 1184 RVA: 0x000031E5 File Offset: 0x000013E5
	public unsafe Action<Vector3> _onUpdateVector3_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector3>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00025930 File Offset: 0x00023B30
	// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00003204 File Offset: 0x00001404
	public unsafe Action<Vector3, global::Il2CppSystem.Object> _onUpdateVector3Object_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector3, global::Il2CppSystem.Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00025960 File Offset: 0x00023B60
	// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00003223 File Offset: 0x00001423
	public unsafe Action<Color> _onUpdateColor_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateColor_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00025990 File Offset: 0x00023B90
	// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00003242 File Offset: 0x00001442
	public unsafe Action<Color, global::Il2CppSystem.Object> _onUpdateColorObject_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateColorObject_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, global::Il2CppSystem.Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateColorObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000259C0 File Offset: 0x00023BC0
	// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00003261 File Offset: 0x00001461
	public unsafe Action _onComplete_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onComplete_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onComplete_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000259F0 File Offset: 0x00023BF0
	// (set) Token: 0x060004AA RID: 1194 RVA: 0x00003280 File Offset: 0x00001480
	public unsafe Action<global::Il2CppSystem.Object> _onCompleteObject_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onCompleteObject_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<global::Il2CppSystem.Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onCompleteObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060004AB RID: 1195 RVA: 0x00025A20 File Offset: 0x00023C20
	// (set) Token: 0x060004AC RID: 1196 RVA: 0x0000329F File Offset: 0x0000149F
	public unsafe global::Il2CppSystem.Object _onCompleteParam_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onCompleteParam_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onCompleteParam_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060004AD RID: 1197 RVA: 0x00025A50 File Offset: 0x00023C50
	// (set) Token: 0x060004AE RID: 1198 RVA: 0x000032BE File Offset: 0x000014BE
	public unsafe global::Il2CppSystem.Object _onUpdateParam_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateParam_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onUpdateParam_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060004AF RID: 1199 RVA: 0x00025A80 File Offset: 0x00023C80
	// (set) Token: 0x060004B0 RID: 1200 RVA: 0x000032DD File Offset: 0x000014DD
	public unsafe Action _onStart_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onStart_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTDescrOptional.NativeFieldInfoPtr__onStart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040003EE RID: 1006
	private static readonly IntPtr NativeFieldInfoPtr__toTrans_k__BackingField;

	// Token: 0x040003EF RID: 1007
	private static readonly IntPtr NativeFieldInfoPtr__point_k__BackingField;

	// Token: 0x040003F0 RID: 1008
	private static readonly IntPtr NativeFieldInfoPtr__axis_k__BackingField;

	// Token: 0x040003F1 RID: 1009
	private static readonly IntPtr NativeFieldInfoPtr__lastVal_k__BackingField;

	// Token: 0x040003F2 RID: 1010
	private static readonly IntPtr NativeFieldInfoPtr__origRotation_k__BackingField;

	// Token: 0x040003F3 RID: 1011
	private static readonly IntPtr NativeFieldInfoPtr__path_k__BackingField;

	// Token: 0x040003F4 RID: 1012
	private static readonly IntPtr NativeFieldInfoPtr__spline_k__BackingField;

	// Token: 0x040003F5 RID: 1013
	private static readonly IntPtr NativeFieldInfoPtr_animationCurve;

	// Token: 0x040003F6 RID: 1014
	private static readonly IntPtr NativeFieldInfoPtr_initFrameCount;

	// Token: 0x040003F7 RID: 1015
	private static readonly IntPtr NativeFieldInfoPtr_color;

	// Token: 0x040003F8 RID: 1016
	private static readonly IntPtr NativeFieldInfoPtr__ltRect_k__BackingField;

	// Token: 0x040003F9 RID: 1017
	private static readonly IntPtr NativeFieldInfoPtr__onUpdateFloat_k__BackingField;

	// Token: 0x040003FA RID: 1018
	private static readonly IntPtr NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField;

	// Token: 0x040003FB RID: 1019
	private static readonly IntPtr NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField;

	// Token: 0x040003FC RID: 1020
	private static readonly IntPtr NativeFieldInfoPtr__onUpdateVector2_k__BackingField;

	// Token: 0x040003FD RID: 1021
	private static readonly IntPtr NativeFieldInfoPtr__onUpdateVector3_k__BackingField;

	// Token: 0x040003FE RID: 1022
	private static readonly IntPtr NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField;

	// Token: 0x040003FF RID: 1023
	private static readonly IntPtr NativeFieldInfoPtr__onUpdateColor_k__BackingField;

	// Token: 0x04000400 RID: 1024
	private static readonly IntPtr NativeFieldInfoPtr__onUpdateColorObject_k__BackingField;

	// Token: 0x04000401 RID: 1025
	private static readonly IntPtr NativeFieldInfoPtr__onComplete_k__BackingField;

	// Token: 0x04000402 RID: 1026
	private static readonly IntPtr NativeFieldInfoPtr__onCompleteObject_k__BackingField;

	// Token: 0x04000403 RID: 1027
	private static readonly IntPtr NativeFieldInfoPtr__onCompleteParam_k__BackingField;

	// Token: 0x04000404 RID: 1028
	private static readonly IntPtr NativeFieldInfoPtr__onUpdateParam_k__BackingField;

	// Token: 0x04000405 RID: 1029
	private static readonly IntPtr NativeFieldInfoPtr__onStart_k__BackingField;

	// Token: 0x04000406 RID: 1030
	private static readonly IntPtr NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0;

	// Token: 0x04000407 RID: 1031
	private static readonly IntPtr NativeMethodInfoPtr_set_toTrans_Public_set_Void_Transform_0;

	// Token: 0x04000408 RID: 1032
	private static readonly IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector3_0;

	// Token: 0x04000409 RID: 1033
	private static readonly IntPtr NativeMethodInfoPtr_set_point_Public_set_Void_Vector3_0;

	// Token: 0x0400040A RID: 1034
	private static readonly IntPtr NativeMethodInfoPtr_get_axis_Public_get_Vector3_0;

	// Token: 0x0400040B RID: 1035
	private static readonly IntPtr NativeMethodInfoPtr_set_axis_Public_set_Void_Vector3_0;

	// Token: 0x0400040C RID: 1036
	private static readonly IntPtr NativeMethodInfoPtr_get_lastVal_Public_get_Single_0;

	// Token: 0x0400040D RID: 1037
	private static readonly IntPtr NativeMethodInfoPtr_set_lastVal_Public_set_Void_Single_0;

	// Token: 0x0400040E RID: 1038
	private static readonly IntPtr NativeMethodInfoPtr_get_origRotation_Public_get_Quaternion_0;

	// Token: 0x0400040F RID: 1039
	private static readonly IntPtr NativeMethodInfoPtr_set_origRotation_Public_set_Void_Quaternion_0;

	// Token: 0x04000410 RID: 1040
	private static readonly IntPtr NativeMethodInfoPtr_get_path_Public_get_LTBezierPath_0;

	// Token: 0x04000411 RID: 1041
	private static readonly IntPtr NativeMethodInfoPtr_set_path_Public_set_Void_LTBezierPath_0;

	// Token: 0x04000412 RID: 1042
	private static readonly IntPtr NativeMethodInfoPtr_get_spline_Public_get_LTSpline_0;

	// Token: 0x04000413 RID: 1043
	private static readonly IntPtr NativeMethodInfoPtr_set_spline_Public_set_Void_LTSpline_0;

	// Token: 0x04000414 RID: 1044
	private static readonly IntPtr NativeMethodInfoPtr_get_ltRect_Public_get_LTRect_0;

	// Token: 0x04000415 RID: 1045
	private static readonly IntPtr NativeMethodInfoPtr_set_ltRect_Public_set_Void_LTRect_0;

	// Token: 0x04000416 RID: 1046
	private static readonly IntPtr NativeMethodInfoPtr_get_onUpdateFloat_Public_get_Action_1_Single_0;

	// Token: 0x04000417 RID: 1047
	private static readonly IntPtr NativeMethodInfoPtr_set_onUpdateFloat_Public_set_Void_Action_1_Single_0;

	// Token: 0x04000418 RID: 1048
	private static readonly IntPtr NativeMethodInfoPtr_get_onUpdateFloatRatio_Public_get_Action_2_Single_Single_0;

	// Token: 0x04000419 RID: 1049
	private static readonly IntPtr NativeMethodInfoPtr_set_onUpdateFloatRatio_Public_set_Void_Action_2_Single_Single_0;

	// Token: 0x0400041A RID: 1050
	private static readonly IntPtr NativeMethodInfoPtr_get_onUpdateFloatObject_Public_get_Action_2_Single_Object_0;

	// Token: 0x0400041B RID: 1051
	private static readonly IntPtr NativeMethodInfoPtr_set_onUpdateFloatObject_Public_set_Void_Action_2_Single_Object_0;

	// Token: 0x0400041C RID: 1052
	private static readonly IntPtr NativeMethodInfoPtr_get_onUpdateVector2_Public_get_Action_1_Vector2_0;

	// Token: 0x0400041D RID: 1053
	private static readonly IntPtr NativeMethodInfoPtr_set_onUpdateVector2_Public_set_Void_Action_1_Vector2_0;

	// Token: 0x0400041E RID: 1054
	private static readonly IntPtr NativeMethodInfoPtr_get_onUpdateVector3_Public_get_Action_1_Vector3_0;

	// Token: 0x0400041F RID: 1055
	private static readonly IntPtr NativeMethodInfoPtr_set_onUpdateVector3_Public_set_Void_Action_1_Vector3_0;

	// Token: 0x04000420 RID: 1056
	private static readonly IntPtr NativeMethodInfoPtr_get_onUpdateVector3Object_Public_get_Action_2_Vector3_Object_0;

	// Token: 0x04000421 RID: 1057
	private static readonly IntPtr NativeMethodInfoPtr_set_onUpdateVector3Object_Public_set_Void_Action_2_Vector3_Object_0;

	// Token: 0x04000422 RID: 1058
	private static readonly IntPtr NativeMethodInfoPtr_get_onUpdateColor_Public_get_Action_1_Color_0;

	// Token: 0x04000423 RID: 1059
	private static readonly IntPtr NativeMethodInfoPtr_set_onUpdateColor_Public_set_Void_Action_1_Color_0;

	// Token: 0x04000424 RID: 1060
	private static readonly IntPtr NativeMethodInfoPtr_get_onUpdateColorObject_Public_get_Action_2_Color_Object_0;

	// Token: 0x04000425 RID: 1061
	private static readonly IntPtr NativeMethodInfoPtr_set_onUpdateColorObject_Public_set_Void_Action_2_Color_Object_0;

	// Token: 0x04000426 RID: 1062
	private static readonly IntPtr NativeMethodInfoPtr_get_onComplete_Public_get_Action_0;

	// Token: 0x04000427 RID: 1063
	private static readonly IntPtr NativeMethodInfoPtr_set_onComplete_Public_set_Void_Action_0;

	// Token: 0x04000428 RID: 1064
	private static readonly IntPtr NativeMethodInfoPtr_get_onCompleteObject_Public_get_Action_1_Object_0;

	// Token: 0x04000429 RID: 1065
	private static readonly IntPtr NativeMethodInfoPtr_set_onCompleteObject_Public_set_Void_Action_1_Object_0;

	// Token: 0x0400042A RID: 1066
	private static readonly IntPtr NativeMethodInfoPtr_get_onCompleteParam_Public_get_Object_0;

	// Token: 0x0400042B RID: 1067
	private static readonly IntPtr NativeMethodInfoPtr_set_onCompleteParam_Public_set_Void_Object_0;

	// Token: 0x0400042C RID: 1068
	private static readonly IntPtr NativeMethodInfoPtr_get_onUpdateParam_Public_get_Object_0;

	// Token: 0x0400042D RID: 1069
	private static readonly IntPtr NativeMethodInfoPtr_set_onUpdateParam_Public_set_Void_Object_0;

	// Token: 0x0400042E RID: 1070
	private static readonly IntPtr NativeMethodInfoPtr_get_onStart_Public_get_Action_0;

	// Token: 0x0400042F RID: 1071
	private static readonly IntPtr NativeMethodInfoPtr_set_onStart_Public_set_Void_Action_0;

	// Token: 0x04000430 RID: 1072
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000431 RID: 1073
	private static readonly IntPtr NativeMethodInfoPtr_reset_Public_Void_0;

	// Token: 0x04000432 RID: 1074
	private static readonly IntPtr NativeMethodInfoPtr_callOnUpdate_Public_Void_Single_Single_0;
}
