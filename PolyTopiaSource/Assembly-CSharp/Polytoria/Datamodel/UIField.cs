using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using Polytoria.Lua;
using SoftMasking;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B4 RID: 692
	public class UIField : Instance
	{
		// Token: 0x06003BD2 RID: 15314 RVA: 0x0010E6F0 File Offset: 0x0010C8F0
		// Note: this type is marked as 'beforefieldinit'.
		static UIField()
		{
			Il2CppClassPointerStore<UIField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "UIField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIField>.NativeClassPtr);
			UIField.NativeFieldInfoPtr_MouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "MouseUp");
			UIField.NativeFieldInfoPtr_MouseDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "MouseDown");
			UIField.NativeFieldInfoPtr_positionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "positionOffset");
			UIField.NativeFieldInfoPtr_sizeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "sizeOffset");
			UIField.NativeFieldInfoPtr_positionRelative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "positionRelative");
			UIField.NativeFieldInfoPtr_sizeRelative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "sizeRelative");
			UIField.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "rotation");
			UIField.NativeFieldInfoPtr_pivotPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "pivotPoint");
			UIField.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "visible");
			UIField.NativeFieldInfoPtr_clipDescendants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "clipDescendants");
			UIField.NativeFieldInfoPtr_parentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "parentRect");
			UIField.NativeFieldInfoPtr_recttransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "recttransform");
			UIField.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "mask");
			UIField.NativeFieldInfoPtr_hasHVLayoutParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "hasHVLayoutParent");
			UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_positionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_positionOffset");
			UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sizeOffset");
			UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_positionRelative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_positionRelative");
			UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeRelative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sizeRelative");
			UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_rotation");
			UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_pivotPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_pivotPoint");
			UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_visible");
			UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_clipDescendants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIField>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_clipDescendants");
			UIField.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672520);
			UIField.NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672521);
			UIField.NativeMethodInfoPtr_get_PositionRelative_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672522);
			UIField.NativeMethodInfoPtr_set_PositionRelative_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672523);
			UIField.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672524);
			UIField.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672525);
			UIField.NativeMethodInfoPtr_get_SizeOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672526);
			UIField.NativeMethodInfoPtr_set_SizeOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672527);
			UIField.NativeMethodInfoPtr_get_SizeRelative_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672528);
			UIField.NativeMethodInfoPtr_set_SizeRelative_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672529);
			UIField.NativeMethodInfoPtr_get_PivotPoint_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672530);
			UIField.NativeMethodInfoPtr_set_PivotPoint_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672531);
			UIField.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672532);
			UIField.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672533);
			UIField.NativeMethodInfoPtr_get_ClipDescendants_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672534);
			UIField.NativeMethodInfoPtr_set_ClipDescendants_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672535);
			UIField.NativeMethodInfoPtr_get_NetworkpositionOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672558);
			UIField.NativeMethodInfoPtr_set_NetworkpositionOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672559);
			UIField.NativeMethodInfoPtr_get_NetworksizeOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672560);
			UIField.NativeMethodInfoPtr_set_NetworksizeOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672561);
			UIField.NativeMethodInfoPtr_get_NetworkpositionRelative_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672562);
			UIField.NativeMethodInfoPtr_set_NetworkpositionRelative_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672563);
			UIField.NativeMethodInfoPtr_get_NetworksizeRelative_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672564);
			UIField.NativeMethodInfoPtr_set_NetworksizeRelative_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672565);
			UIField.NativeMethodInfoPtr_get_Networkrotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672566);
			UIField.NativeMethodInfoPtr_set_Networkrotation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672567);
			UIField.NativeMethodInfoPtr_get_NetworkpivotPoint_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672568);
			UIField.NativeMethodInfoPtr_set_NetworkpivotPoint_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672569);
			UIField.NativeMethodInfoPtr_get_Networkvisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672570);
			UIField.NativeMethodInfoPtr_set_Networkvisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672571);
			UIField.NativeMethodInfoPtr_get_NetworkclipDescendants_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672572);
			UIField.NativeMethodInfoPtr_set_NetworkclipDescendants_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672573);
			UIField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672555);
			UIField.NativeMethodInfoPtr_SyncSetPositionOffset_Private_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672536);
			UIField.NativeMethodInfoPtr_SyncSetSizeOffset_Private_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672537);
			UIField.NativeMethodInfoPtr_SyncSetPositionRelative_Private_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672538);
			UIField.NativeMethodInfoPtr_SyncSetSizeRelative_Private_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672539);
			UIField.NativeMethodInfoPtr_SyncSetRotation_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672540);
			UIField.NativeMethodInfoPtr_SyncSetPivotPoint_Private_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672541);
			UIField.NativeMethodInfoPtr_SyncSetVisible_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672542);
			UIField.NativeMethodInfoPtr_SyncSetClipDescendants_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672543);
			UIField.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672544);
			UIField.NativeMethodInfoPtr_UpdateVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672545);
			UIField.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672546);
			UIField.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672547);
			UIField.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672548);
			UIField.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672549);
			UIField.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672550);
			UIField.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672551);
			UIField.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672552);
			UIField.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672553);
			UIField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672554);
			UIField.NativeMethodInfoPtr__Awake_b__46_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672556);
			UIField.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672557);
			UIField.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672574);
			UIField.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIField>.NativeClassPtr, 100672575);
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x0010ED38 File Offset: 0x0010CF38
		// (set) Token: 0x06003BD4 RID: 15316 RVA: 0x0010ED78 File Offset: 0x0010CF78
		public unsafe Vector2 PositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121303, RefRangeEnd = 121304, XrefRangeStart = 121300, XrefRangeEnd = 121303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06003BD5 RID: 15317 RVA: 0x0010EDBC File Offset: 0x0010CFBC
		// (set) Token: 0x06003BD6 RID: 15318 RVA: 0x0010EDFC File Offset: 0x0010CFFC
		public unsafe Vector2 PositionRelative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_PositionRelative_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121307, RefRangeEnd = 121308, XrefRangeStart = 121304, XrefRangeEnd = 121307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_PositionRelative_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06003BD7 RID: 15319 RVA: 0x0010EE40 File Offset: 0x0010D040
		// (set) Token: 0x06003BD8 RID: 15320 RVA: 0x0010EE7C File Offset: 0x0010D07C
		public unsafe float Rotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121310, RefRangeEnd = 121311, XrefRangeStart = 121308, XrefRangeEnd = 121310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121316, RefRangeEnd = 121319, XrefRangeStart = 121311, XrefRangeEnd = 121316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x0010EEBC File Offset: 0x0010D0BC
		// (set) Token: 0x06003BDA RID: 15322 RVA: 0x0010EEFC File Offset: 0x0010D0FC
		public unsafe Vector2 SizeOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_SizeOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121322, RefRangeEnd = 121323, XrefRangeStart = 121319, XrefRangeEnd = 121322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_SizeOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x0010EF40 File Offset: 0x0010D140
		// (set) Token: 0x06003BDC RID: 15324 RVA: 0x0010EF80 File Offset: 0x0010D180
		public unsafe Vector2 SizeRelative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_SizeRelative_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121326, RefRangeEnd = 121327, XrefRangeStart = 121323, XrefRangeEnd = 121326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_SizeRelative_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x0010EFC4 File Offset: 0x0010D1C4
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x0010F004 File Offset: 0x0010D204
		public unsafe Vector2 PivotPoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121328, RefRangeEnd = 121329, XrefRangeStart = 121327, XrefRangeEnd = 121328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_PivotPoint_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121334, RefRangeEnd = 121337, XrefRangeStart = 121329, XrefRangeEnd = 121334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_PivotPoint_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x0010F048 File Offset: 0x0010D248
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x0010F084 File Offset: 0x0010D284
		public unsafe bool Visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 121341, RefRangeEnd = 121349, XrefRangeStart = 121337, XrefRangeEnd = 121341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x0010F0C4 File Offset: 0x0010D2C4
		// (set) Token: 0x06003BE2 RID: 15330 RVA: 0x0010F100 File Offset: 0x0010D300
		public unsafe bool ClipDescendants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_ClipDescendants_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121357, RefRangeEnd = 121360, XrefRangeStart = 121349, XrefRangeEnd = 121357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_ClipDescendants_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x0010F140 File Offset: 0x0010D340
		// (set) Token: 0x06003BE4 RID: 15332 RVA: 0x0010F180 File Offset: 0x0010D380
		public unsafe Vector2 NetworkpositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_NetworkpositionOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121303, RefRangeEnd = 121304, XrefRangeStart = 121303, XrefRangeEnd = 121304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_NetworkpositionOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x0010F1C4 File Offset: 0x0010D3C4
		// (set) Token: 0x06003BE6 RID: 15334 RVA: 0x0010F204 File Offset: 0x0010D404
		public unsafe Vector2 NetworksizeOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_NetworksizeOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121322, RefRangeEnd = 121323, XrefRangeStart = 121322, XrefRangeEnd = 121323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_NetworksizeOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x0010F248 File Offset: 0x0010D448
		// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x0010F288 File Offset: 0x0010D488
		public unsafe Vector2 NetworkpositionRelative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_NetworkpositionRelative_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121307, RefRangeEnd = 121308, XrefRangeStart = 121307, XrefRangeEnd = 121308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_NetworkpositionRelative_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x0010F2CC File Offset: 0x0010D4CC
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x0010F30C File Offset: 0x0010D50C
		public unsafe Vector2 NetworksizeRelative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_NetworksizeRelative_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 121326, RefRangeEnd = 121327, XrefRangeStart = 121326, XrefRangeEnd = 121327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_NetworksizeRelative_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x0010F350 File Offset: 0x0010D550
		// (set) Token: 0x06003BEC RID: 15340 RVA: 0x0010F38C File Offset: 0x0010D58C
		public unsafe float Networkrotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_Networkrotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121360, XrefRangeEnd = 121363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_Networkrotation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x0010F3CC File Offset: 0x0010D5CC
		// (set) Token: 0x06003BEE RID: 15342 RVA: 0x0010F40C File Offset: 0x0010D60C
		public unsafe Vector2 NetworkpivotPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_NetworkpivotPoint_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121363, XrefRangeEnd = 121366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_NetworkpivotPoint_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x0010F450 File Offset: 0x0010D650
		// (set) Token: 0x06003BF0 RID: 15344 RVA: 0x0010F48C File Offset: 0x0010D68C
		public unsafe bool Networkvisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_Networkvisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121366, XrefRangeEnd = 121369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_Networkvisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x0010F4CC File Offset: 0x0010D6CC
		// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x0010F508 File Offset: 0x0010D708
		public unsafe bool NetworkclipDescendants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_get_NetworkclipDescendants_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121369, XrefRangeEnd = 121372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_set_NetworkclipDescendants_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x0010F548 File Offset: 0x0010D748
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 121440, RefRangeEnd = 121443, XrefRangeStart = 121372, XrefRangeEnd = 121440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x0010F584 File Offset: 0x0010D784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121443, XrefRangeEnd = 121446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetPositionOffset(Vector2 oldValue, Vector2 newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_SyncSetPositionOffset_Private_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x0010F5D8 File Offset: 0x0010D7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121446, XrefRangeEnd = 121449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetSizeOffset(Vector2 oldValue, Vector2 newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_SyncSetSizeOffset_Private_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x0010F62C File Offset: 0x0010D82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121449, XrefRangeEnd = 121452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetPositionRelative(Vector2 oldValue, Vector2 newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_SyncSetPositionRelative_Private_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x0010F680 File Offset: 0x0010D880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121452, XrefRangeEnd = 121455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetSizeRelative(Vector2 oldValue, Vector2 newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_SyncSetSizeRelative_Private_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x0010F6D4 File Offset: 0x0010D8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121455, XrefRangeEnd = 121456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetRotation(float oldValue, float newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_SyncSetRotation_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x0010F720 File Offset: 0x0010D920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121456, XrefRangeEnd = 121457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetPivotPoint(Vector2 oldValue, Vector2 newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_SyncSetPivotPoint_Private_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x0010F774 File Offset: 0x0010D974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121457, XrefRangeEnd = 121458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetVisible(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_SyncSetVisible_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x0010F7C0 File Offset: 0x0010D9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121458, XrefRangeEnd = 121459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetClipDescendants(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_SyncSetClipDescendants_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x0010F80C File Offset: 0x0010DA0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 121481, RefRangeEnd = 121485, XrefRangeStart = 121459, XrefRangeEnd = 121481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIField.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x0010F848 File Offset: 0x0010DA48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121489, RefRangeEnd = 121491, XrefRangeStart = 121485, XrefRangeEnd = 121489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_UpdateVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x0010F87C File Offset: 0x0010DA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121491, XrefRangeEnd = 121493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIField.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x0010F8B8 File Offset: 0x0010DAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121493, XrefRangeEnd = 121513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x0010F8EC File Offset: 0x0010DAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIField.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x0010F928 File Offset: 0x0010DB28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121517, RefRangeEnd = 121519, XrefRangeStart = 121513, XrefRangeEnd = 121517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIField.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x0010F964 File Offset: 0x0010DB64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 121544, RefRangeEnd = 121547, XrefRangeStart = 121519, XrefRangeEnd = 121544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIField.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x0010F9B4 File Offset: 0x0010DBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121547, XrefRangeEnd = 121552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x0010F9F8 File Offset: 0x0010DBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121552, XrefRangeEnd = 121557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x0010FA3C File Offset: 0x0010DC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121557, XrefRangeEnd = 121562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x0010FA80 File Offset: 0x0010DC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121562, XrefRangeEnd = 121567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x0010FAC4 File Offset: 0x0010DCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121567, XrefRangeEnd = 121578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__46_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIField.NativeMethodInfoPtr__Awake_b__46_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x0010FAF8 File Offset: 0x0010DCF8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIField.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x0010FB40 File Offset: 0x0010DD40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 121596, RefRangeEnd = 121599, XrefRangeStart = 121578, XrefRangeEnd = 121596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIField.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x0010FB9C File Offset: 0x0010DD9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 121650, RefRangeEnd = 121653, XrefRangeStart = 121599, XrefRangeEnd = 121650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIField.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x00016EC0 File Offset: 0x000150C0
		public UIField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06003C0C RID: 15372 RVA: 0x0010FBF8 File Offset: 0x0010DDF8
		// (set) Token: 0x06003C0D RID: 15373 RVA: 0x00016EC9 File Offset: 0x000150C9
		public unsafe LuaEvent MouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_MouseUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_MouseUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06003C0E RID: 15374 RVA: 0x0010FC28 File Offset: 0x0010DE28
		// (set) Token: 0x06003C0F RID: 15375 RVA: 0x00016EE8 File Offset: 0x000150E8
		public unsafe LuaEvent MouseDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_MouseDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_MouseDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06003C10 RID: 15376 RVA: 0x0010FC58 File Offset: 0x0010DE58
		// (set) Token: 0x06003C11 RID: 15377 RVA: 0x00016F07 File Offset: 0x00015107
		public unsafe Vector2 positionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_positionOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_positionOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06003C12 RID: 15378 RVA: 0x0010FC88 File Offset: 0x0010DE88
		// (set) Token: 0x06003C13 RID: 15379 RVA: 0x00016F26 File Offset: 0x00015126
		public unsafe Vector2 sizeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_sizeOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_sizeOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x0010FCB8 File Offset: 0x0010DEB8
		// (set) Token: 0x06003C15 RID: 15381 RVA: 0x00016F45 File Offset: 0x00015145
		public unsafe Vector2 positionRelative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_positionRelative);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_positionRelative), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x0010FCE8 File Offset: 0x0010DEE8
		// (set) Token: 0x06003C17 RID: 15383 RVA: 0x00016F64 File Offset: 0x00015164
		public unsafe Vector2 sizeRelative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_sizeRelative);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_sizeRelative), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06003C18 RID: 15384 RVA: 0x0010FD18 File Offset: 0x0010DF18
		// (set) Token: 0x06003C19 RID: 15385 RVA: 0x00016F83 File Offset: 0x00015183
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06003C1A RID: 15386 RVA: 0x0010FD40 File Offset: 0x0010DF40
		// (set) Token: 0x06003C1B RID: 15387 RVA: 0x00016F9E File Offset: 0x0001519E
		public unsafe Vector2 pivotPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_pivotPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_pivotPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x0010FD70 File Offset: 0x0010DF70
		// (set) Token: 0x06003C1D RID: 15389 RVA: 0x00016FBD File Offset: 0x000151BD
		public unsafe bool visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_visible)) = value;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x0010FD98 File Offset: 0x0010DF98
		// (set) Token: 0x06003C1F RID: 15391 RVA: 0x00016FD8 File Offset: 0x000151D8
		public unsafe bool clipDescendants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_clipDescendants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_clipDescendants)) = value;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06003C20 RID: 15392 RVA: 0x0010FDC0 File Offset: 0x0010DFC0
		// (set) Token: 0x06003C21 RID: 15393 RVA: 0x00016FF3 File Offset: 0x000151F3
		public unsafe RectTransform parentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_parentRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_parentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06003C22 RID: 15394 RVA: 0x0010FDF0 File Offset: 0x0010DFF0
		// (set) Token: 0x06003C23 RID: 15395 RVA: 0x00017012 File Offset: 0x00015212
		public unsafe RectTransform recttransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_recttransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_recttransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x0010FE20 File Offset: 0x0010E020
		// (set) Token: 0x06003C25 RID: 15397 RVA: 0x00017031 File Offset: 0x00015231
		public unsafe SoftMask mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_mask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoftMask>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_mask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x0010FE50 File Offset: 0x0010E050
		// (set) Token: 0x06003C27 RID: 15399 RVA: 0x00017050 File Offset: 0x00015250
		public unsafe bool hasHVLayoutParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_hasHVLayoutParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr_hasHVLayoutParent)) = value;
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06003C28 RID: 15400 RVA: 0x0010FE78 File Offset: 0x0010E078
		// (set) Token: 0x06003C29 RID: 15401 RVA: 0x0001706B File Offset: 0x0001526B
		public unsafe Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_positionOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_positionOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06003C2A RID: 15402 RVA: 0x0010FEA8 File Offset: 0x0010E0A8
		// (set) Token: 0x06003C2B RID: 15403 RVA: 0x0001708A File Offset: 0x0001528A
		public unsafe Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06003C2C RID: 15404 RVA: 0x0010FED8 File Offset: 0x0010E0D8
		// (set) Token: 0x06003C2D RID: 15405 RVA: 0x000170A9 File Offset: 0x000152A9
		public unsafe Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionRelative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_positionRelative);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_positionRelative), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x0010FF08 File Offset: 0x0010E108
		// (set) Token: 0x06003C2F RID: 15407 RVA: 0x000170C8 File Offset: 0x000152C8
		public unsafe Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeRelative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeRelative);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeRelative), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x0010FF38 File Offset: 0x0010E138
		// (set) Token: 0x06003C31 RID: 15409 RVA: 0x000170E7 File Offset: 0x000152E7
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06003C32 RID: 15410 RVA: 0x0010FF68 File Offset: 0x0010E168
		// (set) Token: 0x06003C33 RID: 15411 RVA: 0x00017106 File Offset: 0x00015306
		public unsafe Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_pivotPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_pivotPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_pivotPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x0010FF98 File Offset: 0x0010E198
		// (set) Token: 0x06003C35 RID: 15413 RVA: 0x00017125 File Offset: 0x00015325
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_visible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_visible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06003C36 RID: 15414 RVA: 0x0010FFC8 File Offset: 0x0010E1C8
		// (set) Token: 0x06003C37 RID: 15415 RVA: 0x00017144 File Offset: 0x00015344
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_clipDescendants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_clipDescendants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIField.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_clipDescendants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeFieldInfoPtr_MouseUp;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeFieldInfoPtr_MouseDown;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeFieldInfoPtr_positionOffset;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeFieldInfoPtr_sizeOffset;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeFieldInfoPtr_positionRelative;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeFieldInfoPtr_sizeRelative;

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeFieldInfoPtr_pivotPoint;

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeFieldInfoPtr_visible;

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeFieldInfoPtr_clipDescendants;

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeFieldInfoPtr_parentRect;

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeFieldInfoPtr_recttransform;

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeFieldInfoPtr_hasHVLayoutParent;

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_positionOffset;

		// Token: 0x04002E8B RID: 11915
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeOffset;

		// Token: 0x04002E8C RID: 11916
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_positionRelative;

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeRelative;

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_rotation;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_pivotPoint;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_visible;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_clipDescendants;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector2_0;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector2_0;

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionRelative_Public_get_Vector2_0;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionRelative_Public_set_Void_Vector2_0;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Single_0;

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Single_0;

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeOffset_Public_get_Vector2_0;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeOffset_Public_set_Void_Vector2_0;

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeRelative_Public_get_Vector2_0;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeRelative_Public_set_Void_Vector2_0;

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotPoint_Public_get_Vector2_0;

		// Token: 0x04002E9D RID: 11933
		private static readonly IntPtr NativeMethodInfoPtr_set_PivotPoint_Public_set_Void_Vector2_0;

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeMethodInfoPtr_get_ClipDescendants_Public_get_Boolean_0;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeMethodInfoPtr_set_ClipDescendants_Public_set_Void_Boolean_0;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpositionOffset_Public_get_Vector2_0;

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpositionOffset_Public_set_Void_Vector2_0;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksizeOffset_Public_get_Vector2_0;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksizeOffset_Public_set_Void_Vector2_0;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpositionRelative_Public_get_Vector2_0;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpositionRelative_Public_set_Void_Vector2_0;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksizeRelative_Public_get_Vector2_0;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksizeRelative_Public_set_Void_Vector2_0;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkrotation_Public_get_Single_0;

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkrotation_Public_set_Void_Single_0;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpivotPoint_Public_get_Vector2_0;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpivotPoint_Public_set_Void_Vector2_0;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkvisible_Public_get_Boolean_0;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkvisible_Public_set_Void_Boolean_0;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkclipDescendants_Public_get_Boolean_0;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkclipDescendants_Public_set_Void_Boolean_0;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetPositionOffset_Private_Void_Vector2_Vector2_0;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetSizeOffset_Private_Void_Vector2_Vector2_0;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetPositionRelative_Private_Void_Vector2_Vector2_0;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetSizeRelative_Private_Void_Vector2_Vector2_0;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetRotation_Private_Void_Single_Single_0;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetPivotPoint_Private_Void_Vector2_Vector2_0;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetVisible_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetClipDescendants_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002EBC RID: 11964
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibility_Private_Void_0;

		// Token: 0x04002EBD RID: 11965
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002EBE RID: 11966
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002EC0 RID: 11968
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002EC1 RID: 11969
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002EC2 RID: 11970
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04002EC3 RID: 11971
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04002EC4 RID: 11972
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04002EC5 RID: 11973
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04002EC6 RID: 11974
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__46_0_Private_Void_0;

		// Token: 0x04002EC7 RID: 11975
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002EC8 RID: 11976
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002EC9 RID: 11977
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
