using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B6 RID: 694
	public class UIHVLayout : UIField
	{
		// Token: 0x06003C3F RID: 15423 RVA: 0x001101C4 File Offset: 0x0010E3C4
		// Note: this type is marked as 'beforefieldinit'.
		static UIHVLayout()
		{
			Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "UIHVLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr);
			UIHVLayout.NativeFieldInfoPtr_layoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "layoutGroup");
			UIHVLayout.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "spacing");
			UIHVLayout.NativeFieldInfoPtr_childControlWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "childControlWidth");
			UIHVLayout.NativeFieldInfoPtr_childControlHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "childControlHeight");
			UIHVLayout.NativeFieldInfoPtr_childScaleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "childScaleWidth");
			UIHVLayout.NativeFieldInfoPtr_childScaleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "childScaleHeight");
			UIHVLayout.NativeFieldInfoPtr_childForceExpandWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "childForceExpandWidth");
			UIHVLayout.NativeFieldInfoPtr_childForceExpandHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "childForceExpandHeight");
			UIHVLayout.NativeFieldInfoPtr_paddingLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "paddingLeft");
			UIHVLayout.NativeFieldInfoPtr_paddingRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "paddingRight");
			UIHVLayout.NativeFieldInfoPtr_paddingTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "paddingTop");
			UIHVLayout.NativeFieldInfoPtr_paddingBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "paddingBottom");
			UIHVLayout.NativeFieldInfoPtr_childAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "childAlignment");
			UIHVLayout.NativeFieldInfoPtr_reverseAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "reverseAlignment");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_spacing");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childControlWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_childControlWidth");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childControlHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_childControlHeight");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childScaleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_childScaleWidth");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childScaleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_childScaleHeight");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childForceExpandWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_childForceExpandWidth");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childForceExpandHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_childForceExpandHeight");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_paddingLeft");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_paddingRight");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_paddingTop");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_paddingBottom");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_childAlignment");
			UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_reverseAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_reverseAlignment");
			UIHVLayout.NativeMethodInfoPtr_get_Spacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672581);
			UIHVLayout.NativeMethodInfoPtr_set_Spacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672582);
			UIHVLayout.NativeMethodInfoPtr_get_ChildControlWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672583);
			UIHVLayout.NativeMethodInfoPtr_set_ChildControlWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672584);
			UIHVLayout.NativeMethodInfoPtr_get_ChildControlHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672585);
			UIHVLayout.NativeMethodInfoPtr_set_ChildControlHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672586);
			UIHVLayout.NativeMethodInfoPtr_get_ChildScaleWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672587);
			UIHVLayout.NativeMethodInfoPtr_set_ChildScaleWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672588);
			UIHVLayout.NativeMethodInfoPtr_get_ChildScaleHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672589);
			UIHVLayout.NativeMethodInfoPtr_set_ChildScaleHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672590);
			UIHVLayout.NativeMethodInfoPtr_get_ChildForceExpandWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672591);
			UIHVLayout.NativeMethodInfoPtr_set_ChildForceExpandWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672592);
			UIHVLayout.NativeMethodInfoPtr_get_ChildForceExpandHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672593);
			UIHVLayout.NativeMethodInfoPtr_set_ChildForceExpandHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672594);
			UIHVLayout.NativeMethodInfoPtr_get_PaddingLeft_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672595);
			UIHVLayout.NativeMethodInfoPtr_set_PaddingLeft_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672596);
			UIHVLayout.NativeMethodInfoPtr_get_PaddingRight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672597);
			UIHVLayout.NativeMethodInfoPtr_set_PaddingRight_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672598);
			UIHVLayout.NativeMethodInfoPtr_get_PaddingTop_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672599);
			UIHVLayout.NativeMethodInfoPtr_set_PaddingTop_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672600);
			UIHVLayout.NativeMethodInfoPtr_get_PaddingBottom_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672601);
			UIHVLayout.NativeMethodInfoPtr_set_PaddingBottom_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672602);
			UIHVLayout.NativeMethodInfoPtr_get_ChildAlignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672603);
			UIHVLayout.NativeMethodInfoPtr_set_ChildAlignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672604);
			UIHVLayout.NativeMethodInfoPtr_get_ReverseAlignment_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672605);
			UIHVLayout.NativeMethodInfoPtr_set_ReverseAlignment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672606);
			UIHVLayout.NativeMethodInfoPtr_get_Networkspacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672625);
			UIHVLayout.NativeMethodInfoPtr_set_Networkspacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672626);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkchildControlWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672627);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkchildControlWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672628);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkchildControlHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672629);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkchildControlHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672630);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkchildScaleWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672631);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkchildScaleWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672632);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkchildScaleHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672633);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkchildScaleHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672634);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkchildForceExpandWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672635);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkchildForceExpandWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672636);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkchildForceExpandHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672637);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkchildForceExpandHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672638);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkpaddingLeft_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672639);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkpaddingLeft_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672640);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkpaddingRight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672641);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkpaddingRight_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672642);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkpaddingTop_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672643);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkpaddingTop_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672644);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkpaddingBottom_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672645);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkpaddingBottom_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672646);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkchildAlignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672647);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkchildAlignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672648);
			UIHVLayout.NativeMethodInfoPtr_get_NetworkreverseAlignment_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672649);
			UIHVLayout.NativeMethodInfoPtr_set_NetworkreverseAlignment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672650);
			UIHVLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672623);
			UIHVLayout.NativeMethodInfoPtr_SyncSpacing_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672607);
			UIHVLayout.NativeMethodInfoPtr_SyncChildControlWidth_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672608);
			UIHVLayout.NativeMethodInfoPtr_SyncChildControlHeight_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672609);
			UIHVLayout.NativeMethodInfoPtr_SyncChildScaleWidth_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672610);
			UIHVLayout.NativeMethodInfoPtr_SyncChildScaleHeight_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672611);
			UIHVLayout.NativeMethodInfoPtr_SyncChildForceExpandWidth_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672612);
			UIHVLayout.NativeMethodInfoPtr_SyncChildForceExpandHeight_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672613);
			UIHVLayout.NativeMethodInfoPtr_SyncPaddingLeft_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672614);
			UIHVLayout.NativeMethodInfoPtr_SyncPaddingRight_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672615);
			UIHVLayout.NativeMethodInfoPtr_SyncPaddingTop_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672616);
			UIHVLayout.NativeMethodInfoPtr_SyncPaddingBottom_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672617);
			UIHVLayout.NativeMethodInfoPtr_SyncChildAlignment_Private_Void_TextAnchor_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672618);
			UIHVLayout.NativeMethodInfoPtr_SyncReverseAlignment_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672619);
			UIHVLayout.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672620);
			UIHVLayout.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672621);
			UIHVLayout.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672622);
			UIHVLayout.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672624);
			UIHVLayout.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672651);
			UIHVLayout.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr, 100672652);
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06003C40 RID: 15424 RVA: 0x001109B0 File Offset: 0x0010EBB0
		// (set) Token: 0x06003C41 RID: 15425 RVA: 0x001109EC File Offset: 0x0010EBEC
		public unsafe float Spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_Spacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121671, RefRangeEnd = 121674, XrefRangeStart = 121666, XrefRangeEnd = 121671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_Spacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06003C42 RID: 15426 RVA: 0x00110A2C File Offset: 0x0010EC2C
		// (set) Token: 0x06003C43 RID: 15427 RVA: 0x00110A68 File Offset: 0x0010EC68
		public unsafe bool ChildControlWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_ChildControlWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121679, RefRangeEnd = 121682, XrefRangeStart = 121674, XrefRangeEnd = 121679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_ChildControlWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x00110AA8 File Offset: 0x0010ECA8
		// (set) Token: 0x06003C45 RID: 15429 RVA: 0x00110AE4 File Offset: 0x0010ECE4
		public unsafe bool ChildControlHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_ChildControlHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121687, RefRangeEnd = 121690, XrefRangeStart = 121682, XrefRangeEnd = 121687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_ChildControlHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x00110B24 File Offset: 0x0010ED24
		// (set) Token: 0x06003C47 RID: 15431 RVA: 0x00110B60 File Offset: 0x0010ED60
		public unsafe bool ChildScaleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_ChildScaleWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121695, RefRangeEnd = 121698, XrefRangeStart = 121690, XrefRangeEnd = 121695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_ChildScaleWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x00110BA0 File Offset: 0x0010EDA0
		// (set) Token: 0x06003C49 RID: 15433 RVA: 0x00110BDC File Offset: 0x0010EDDC
		public unsafe bool ChildScaleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_ChildScaleHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121703, RefRangeEnd = 121706, XrefRangeStart = 121698, XrefRangeEnd = 121703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_ChildScaleHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x00110C1C File Offset: 0x0010EE1C
		// (set) Token: 0x06003C4B RID: 15435 RVA: 0x00110C58 File Offset: 0x0010EE58
		public unsafe bool ChildForceExpandWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_ChildForceExpandWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121711, RefRangeEnd = 121714, XrefRangeStart = 121706, XrefRangeEnd = 121711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_ChildForceExpandWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x00110C98 File Offset: 0x0010EE98
		// (set) Token: 0x06003C4D RID: 15437 RVA: 0x00110CD4 File Offset: 0x0010EED4
		public unsafe bool ChildForceExpandHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_ChildForceExpandHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121719, RefRangeEnd = 121722, XrefRangeStart = 121714, XrefRangeEnd = 121719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_ChildForceExpandHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06003C4E RID: 15438 RVA: 0x00110D14 File Offset: 0x0010EF14
		// (set) Token: 0x06003C4F RID: 15439 RVA: 0x00110D50 File Offset: 0x0010EF50
		public unsafe int PaddingLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_PaddingLeft_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121727, RefRangeEnd = 121730, XrefRangeStart = 121722, XrefRangeEnd = 121727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_PaddingLeft_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x00110D90 File Offset: 0x0010EF90
		// (set) Token: 0x06003C51 RID: 15441 RVA: 0x00110DCC File Offset: 0x0010EFCC
		public unsafe int PaddingRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_PaddingRight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121735, RefRangeEnd = 121738, XrefRangeStart = 121730, XrefRangeEnd = 121735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_PaddingRight_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06003C52 RID: 15442 RVA: 0x00110E0C File Offset: 0x0010F00C
		// (set) Token: 0x06003C53 RID: 15443 RVA: 0x00110E48 File Offset: 0x0010F048
		public unsafe int PaddingTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_PaddingTop_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121743, RefRangeEnd = 121746, XrefRangeStart = 121738, XrefRangeEnd = 121743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_PaddingTop_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x00110E88 File Offset: 0x0010F088
		// (set) Token: 0x06003C55 RID: 15445 RVA: 0x00110EC4 File Offset: 0x0010F0C4
		public unsafe int PaddingBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_PaddingBottom_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121751, RefRangeEnd = 121754, XrefRangeStart = 121746, XrefRangeEnd = 121751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_PaddingBottom_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x00110F04 File Offset: 0x0010F104
		// (set) Token: 0x06003C57 RID: 15447 RVA: 0x00110F44 File Offset: 0x0010F144
		public unsafe TextAnchor ChildAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_ChildAlignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAnchor>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121759, RefRangeEnd = 121762, XrefRangeStart = 121754, XrefRangeEnd = 121759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_ChildAlignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06003C58 RID: 15448 RVA: 0x00110F88 File Offset: 0x0010F188
		// (set) Token: 0x06003C59 RID: 15449 RVA: 0x00110FC4 File Offset: 0x0010F1C4
		public unsafe bool ReverseAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_ReverseAlignment_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 121767, RefRangeEnd = 121770, XrefRangeStart = 121762, XrefRangeEnd = 121767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_ReverseAlignment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x00111004 File Offset: 0x0010F204
		// (set) Token: 0x06003C5B RID: 15451 RVA: 0x00111040 File Offset: 0x0010F240
		public unsafe float Networkspacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_Networkspacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121770, XrefRangeEnd = 121773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_Networkspacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06003C5C RID: 15452 RVA: 0x00111080 File Offset: 0x0010F280
		// (set) Token: 0x06003C5D RID: 15453 RVA: 0x001110BC File Offset: 0x0010F2BC
		public unsafe bool NetworkchildControlWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkchildControlWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121773, XrefRangeEnd = 121776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkchildControlWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06003C5E RID: 15454 RVA: 0x001110FC File Offset: 0x0010F2FC
		// (set) Token: 0x06003C5F RID: 15455 RVA: 0x00111138 File Offset: 0x0010F338
		public unsafe bool NetworkchildControlHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkchildControlHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121776, XrefRangeEnd = 121779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkchildControlHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06003C60 RID: 15456 RVA: 0x00111178 File Offset: 0x0010F378
		// (set) Token: 0x06003C61 RID: 15457 RVA: 0x001111B4 File Offset: 0x0010F3B4
		public unsafe bool NetworkchildScaleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkchildScaleWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121779, XrefRangeEnd = 121782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkchildScaleWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06003C62 RID: 15458 RVA: 0x001111F4 File Offset: 0x0010F3F4
		// (set) Token: 0x06003C63 RID: 15459 RVA: 0x00111230 File Offset: 0x0010F430
		public unsafe bool NetworkchildScaleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkchildScaleHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121782, XrefRangeEnd = 121785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkchildScaleHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06003C64 RID: 15460 RVA: 0x00111270 File Offset: 0x0010F470
		// (set) Token: 0x06003C65 RID: 15461 RVA: 0x001112AC File Offset: 0x0010F4AC
		public unsafe bool NetworkchildForceExpandWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkchildForceExpandWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121785, XrefRangeEnd = 121788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkchildForceExpandWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06003C66 RID: 15462 RVA: 0x001112EC File Offset: 0x0010F4EC
		// (set) Token: 0x06003C67 RID: 15463 RVA: 0x00111328 File Offset: 0x0010F528
		public unsafe bool NetworkchildForceExpandHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkchildForceExpandHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121788, XrefRangeEnd = 121791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkchildForceExpandHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06003C68 RID: 15464 RVA: 0x00111368 File Offset: 0x0010F568
		// (set) Token: 0x06003C69 RID: 15465 RVA: 0x001113A4 File Offset: 0x0010F5A4
		public unsafe int NetworkpaddingLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkpaddingLeft_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121791, XrefRangeEnd = 121794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkpaddingLeft_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06003C6A RID: 15466 RVA: 0x001113E4 File Offset: 0x0010F5E4
		// (set) Token: 0x06003C6B RID: 15467 RVA: 0x00111420 File Offset: 0x0010F620
		public unsafe int NetworkpaddingRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkpaddingRight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121794, XrefRangeEnd = 121797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkpaddingRight_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06003C6C RID: 15468 RVA: 0x00111460 File Offset: 0x0010F660
		// (set) Token: 0x06003C6D RID: 15469 RVA: 0x0011149C File Offset: 0x0010F69C
		public unsafe int NetworkpaddingTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkpaddingTop_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121797, XrefRangeEnd = 121800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkpaddingTop_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06003C6E RID: 15470 RVA: 0x001114DC File Offset: 0x0010F6DC
		// (set) Token: 0x06003C6F RID: 15471 RVA: 0x00111518 File Offset: 0x0010F718
		public unsafe int NetworkpaddingBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkpaddingBottom_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121800, XrefRangeEnd = 121803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkpaddingBottom_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06003C70 RID: 15472 RVA: 0x00111558 File Offset: 0x0010F758
		// (set) Token: 0x06003C71 RID: 15473 RVA: 0x00111598 File Offset: 0x0010F798
		public unsafe TextAnchor NetworkchildAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkchildAlignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAnchor>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121803, XrefRangeEnd = 121806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkchildAlignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06003C72 RID: 15474 RVA: 0x001115DC File Offset: 0x0010F7DC
		// (set) Token: 0x06003C73 RID: 15475 RVA: 0x00111618 File Offset: 0x0010F818
		public unsafe bool NetworkreverseAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_get_NetworkreverseAlignment_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121806, XrefRangeEnd = 121809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_set_NetworkreverseAlignment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x00111658 File Offset: 0x0010F858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121892, RefRangeEnd = 121894, XrefRangeStart = 121809, XrefRangeEnd = 121892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIHVLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHVLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x00111694 File Offset: 0x0010F894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121894, XrefRangeEnd = 121895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSpacing(float oldValue, float newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncSpacing_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x001116E0 File Offset: 0x0010F8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121895, XrefRangeEnd = 121896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncChildControlWidth(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncChildControlWidth_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x0011172C File Offset: 0x0010F92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121896, XrefRangeEnd = 121897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncChildControlHeight(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncChildControlHeight_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x00111778 File Offset: 0x0010F978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121897, XrefRangeEnd = 121898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncChildScaleWidth(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncChildScaleWidth_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x001117C4 File Offset: 0x0010F9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121898, XrefRangeEnd = 121899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncChildScaleHeight(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncChildScaleHeight_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x00111810 File Offset: 0x0010FA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121899, XrefRangeEnd = 121900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncChildForceExpandWidth(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncChildForceExpandWidth_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x0011185C File Offset: 0x0010FA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121900, XrefRangeEnd = 121901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncChildForceExpandHeight(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncChildForceExpandHeight_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x001118A8 File Offset: 0x0010FAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121901, XrefRangeEnd = 121902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncPaddingLeft(int oldValue, int newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncPaddingLeft_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x001118F4 File Offset: 0x0010FAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121902, XrefRangeEnd = 121903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncPaddingRight(int oldValue, int newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncPaddingRight_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x00111940 File Offset: 0x0010FB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121903, XrefRangeEnd = 121904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncPaddingTop(int oldValue, int newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncPaddingTop_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x0011198C File Offset: 0x0010FB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121904, XrefRangeEnd = 121905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncPaddingBottom(int oldValue, int newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncPaddingBottom_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x001119D8 File Offset: 0x0010FBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121905, XrefRangeEnd = 121906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncChildAlignment(TextAnchor oldValue, TextAnchor newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncChildAlignment_Private_Void_TextAnchor_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x00111A2C File Offset: 0x0010FC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121906, XrefRangeEnd = 121907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncReverseAlignment(bool oldValue, bool newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_SyncReverseAlignment_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00111A78 File Offset: 0x0010FC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHVLayout.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00111AB4 File Offset: 0x0010FCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121907, XrefRangeEnd = 121915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHVLayout.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x00111AE8 File Offset: 0x0010FCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121915, XrefRangeEnd = 121933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHVLayout.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x00111B38 File Offset: 0x0010FD38
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHVLayout.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00111B80 File Offset: 0x0010FD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121933, XrefRangeEnd = 121961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHVLayout.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x00111BDC File Offset: 0x0010FDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121961, XrefRangeEnd = 122043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHVLayout.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x0001716C File Offset: 0x0001536C
		public UIHVLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x00111C38 File Offset: 0x0010FE38
		// (set) Token: 0x06003C8A RID: 15498 RVA: 0x00017175 File Offset: 0x00015375
		public unsafe HorizontalOrVerticalLayoutGroup layoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_layoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HorizontalOrVerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_layoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x00111C68 File Offset: 0x0010FE68
		// (set) Token: 0x06003C8C RID: 15500 RVA: 0x00017194 File Offset: 0x00015394
		public unsafe float spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_spacing)) = value;
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06003C8D RID: 15501 RVA: 0x00111C90 File Offset: 0x0010FE90
		// (set) Token: 0x06003C8E RID: 15502 RVA: 0x000171AF File Offset: 0x000153AF
		public unsafe bool childControlWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childControlWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childControlWidth)) = value;
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x00111CB8 File Offset: 0x0010FEB8
		// (set) Token: 0x06003C90 RID: 15504 RVA: 0x000171CA File Offset: 0x000153CA
		public unsafe bool childControlHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childControlHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childControlHeight)) = value;
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x00111CE0 File Offset: 0x0010FEE0
		// (set) Token: 0x06003C92 RID: 15506 RVA: 0x000171E5 File Offset: 0x000153E5
		public unsafe bool childScaleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childScaleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childScaleWidth)) = value;
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x00111D08 File Offset: 0x0010FF08
		// (set) Token: 0x06003C94 RID: 15508 RVA: 0x00017200 File Offset: 0x00015400
		public unsafe bool childScaleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childScaleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childScaleHeight)) = value;
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x00111D30 File Offset: 0x0010FF30
		// (set) Token: 0x06003C96 RID: 15510 RVA: 0x0001721B File Offset: 0x0001541B
		public unsafe bool childForceExpandWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childForceExpandWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childForceExpandWidth)) = value;
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06003C97 RID: 15511 RVA: 0x00111D58 File Offset: 0x0010FF58
		// (set) Token: 0x06003C98 RID: 15512 RVA: 0x00017236 File Offset: 0x00015436
		public unsafe bool childForceExpandHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childForceExpandHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childForceExpandHeight)) = value;
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x00111D80 File Offset: 0x0010FF80
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x00017251 File Offset: 0x00015451
		public unsafe int paddingLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_paddingLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_paddingLeft)) = value;
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x00111DA8 File Offset: 0x0010FFA8
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x0001726C File Offset: 0x0001546C
		public unsafe int paddingRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_paddingRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_paddingRight)) = value;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x00111DD0 File Offset: 0x0010FFD0
		// (set) Token: 0x06003C9E RID: 15518 RVA: 0x00017287 File Offset: 0x00015487
		public unsafe int paddingTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_paddingTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_paddingTop)) = value;
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x00111DF8 File Offset: 0x0010FFF8
		// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x000172A2 File Offset: 0x000154A2
		public unsafe int paddingBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_paddingBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_paddingBottom)) = value;
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x00111E20 File Offset: 0x00110020
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x000172BD File Offset: 0x000154BD
		public unsafe TextAnchor childAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAnchor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_childAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x00111E50 File Offset: 0x00110050
		// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x000172DC File Offset: 0x000154DC
		public unsafe bool reverseAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_reverseAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr_reverseAlignment)) = value;
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x00111E78 File Offset: 0x00110078
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x000172F7 File Offset: 0x000154F7
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_spacing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_spacing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x00111EA8 File Offset: 0x001100A8
		// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x00017316 File Offset: 0x00015516
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_childControlWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childControlWidth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childControlWidth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x00111ED8 File Offset: 0x001100D8
		// (set) Token: 0x06003CAA RID: 15530 RVA: 0x00017335 File Offset: 0x00015535
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_childControlHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childControlHeight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childControlHeight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06003CAB RID: 15531 RVA: 0x00111F08 File Offset: 0x00110108
		// (set) Token: 0x06003CAC RID: 15532 RVA: 0x00017354 File Offset: 0x00015554
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_childScaleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childScaleWidth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childScaleWidth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x00111F38 File Offset: 0x00110138
		// (set) Token: 0x06003CAE RID: 15534 RVA: 0x00017373 File Offset: 0x00015573
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_childScaleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childScaleHeight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childScaleHeight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x00111F68 File Offset: 0x00110168
		// (set) Token: 0x06003CB0 RID: 15536 RVA: 0x00017392 File Offset: 0x00015592
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_childForceExpandWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childForceExpandWidth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childForceExpandWidth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x00111F98 File Offset: 0x00110198
		// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x000173B1 File Offset: 0x000155B1
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_childForceExpandHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childForceExpandHeight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childForceExpandHeight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x00111FC8 File Offset: 0x001101C8
		// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x000173D0 File Offset: 0x000155D0
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_paddingLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06003CB5 RID: 15541 RVA: 0x00111FF8 File Offset: 0x001101F8
		// (set) Token: 0x06003CB6 RID: 15542 RVA: 0x000173EF File Offset: 0x000155EF
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_paddingRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x00112028 File Offset: 0x00110228
		// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x0001740E File Offset: 0x0001560E
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_paddingTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingTop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingTop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x00112058 File Offset: 0x00110258
		// (set) Token: 0x06003CBA RID: 15546 RVA: 0x0001742D File Offset: 0x0001562D
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_paddingBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingBottom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingBottom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x00112088 File Offset: 0x00110288
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x0001744C File Offset: 0x0001564C
		public unsafe Action<TextAnchor, TextAnchor> _Mirror_SyncVarHookDelegate_childAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextAnchor, TextAnchor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x001120B8 File Offset: 0x001102B8
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x0001746B File Offset: 0x0001566B
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_reverseAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_reverseAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHVLayout.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_reverseAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002ECF RID: 11983
		private static readonly IntPtr NativeFieldInfoPtr_layoutGroup;

		// Token: 0x04002ED0 RID: 11984
		private static readonly IntPtr NativeFieldInfoPtr_spacing;

		// Token: 0x04002ED1 RID: 11985
		private static readonly IntPtr NativeFieldInfoPtr_childControlWidth;

		// Token: 0x04002ED2 RID: 11986
		private static readonly IntPtr NativeFieldInfoPtr_childControlHeight;

		// Token: 0x04002ED3 RID: 11987
		private static readonly IntPtr NativeFieldInfoPtr_childScaleWidth;

		// Token: 0x04002ED4 RID: 11988
		private static readonly IntPtr NativeFieldInfoPtr_childScaleHeight;

		// Token: 0x04002ED5 RID: 11989
		private static readonly IntPtr NativeFieldInfoPtr_childForceExpandWidth;

		// Token: 0x04002ED6 RID: 11990
		private static readonly IntPtr NativeFieldInfoPtr_childForceExpandHeight;

		// Token: 0x04002ED7 RID: 11991
		private static readonly IntPtr NativeFieldInfoPtr_paddingLeft;

		// Token: 0x04002ED8 RID: 11992
		private static readonly IntPtr NativeFieldInfoPtr_paddingRight;

		// Token: 0x04002ED9 RID: 11993
		private static readonly IntPtr NativeFieldInfoPtr_paddingTop;

		// Token: 0x04002EDA RID: 11994
		private static readonly IntPtr NativeFieldInfoPtr_paddingBottom;

		// Token: 0x04002EDB RID: 11995
		private static readonly IntPtr NativeFieldInfoPtr_childAlignment;

		// Token: 0x04002EDC RID: 11996
		private static readonly IntPtr NativeFieldInfoPtr_reverseAlignment;

		// Token: 0x04002EDD RID: 11997
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_spacing;

		// Token: 0x04002EDE RID: 11998
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childControlWidth;

		// Token: 0x04002EDF RID: 11999
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childControlHeight;

		// Token: 0x04002EE0 RID: 12000
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childScaleWidth;

		// Token: 0x04002EE1 RID: 12001
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childScaleHeight;

		// Token: 0x04002EE2 RID: 12002
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childForceExpandWidth;

		// Token: 0x04002EE3 RID: 12003
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childForceExpandHeight;

		// Token: 0x04002EE4 RID: 12004
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingLeft;

		// Token: 0x04002EE5 RID: 12005
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingRight;

		// Token: 0x04002EE6 RID: 12006
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingTop;

		// Token: 0x04002EE7 RID: 12007
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_paddingBottom;

		// Token: 0x04002EE8 RID: 12008
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_childAlignment;

		// Token: 0x04002EE9 RID: 12009
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_reverseAlignment;

		// Token: 0x04002EEA RID: 12010
		private static readonly IntPtr NativeMethodInfoPtr_get_Spacing_Public_get_Single_0;

		// Token: 0x04002EEB RID: 12011
		private static readonly IntPtr NativeMethodInfoPtr_set_Spacing_Public_set_Void_Single_0;

		// Token: 0x04002EEC RID: 12012
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildControlWidth_Public_get_Boolean_0;

		// Token: 0x04002EED RID: 12013
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildControlWidth_Public_set_Void_Boolean_0;

		// Token: 0x04002EEE RID: 12014
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildControlHeight_Public_get_Boolean_0;

		// Token: 0x04002EEF RID: 12015
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildControlHeight_Public_set_Void_Boolean_0;

		// Token: 0x04002EF0 RID: 12016
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildScaleWidth_Public_get_Boolean_0;

		// Token: 0x04002EF1 RID: 12017
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildScaleWidth_Public_set_Void_Boolean_0;

		// Token: 0x04002EF2 RID: 12018
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildScaleHeight_Public_get_Boolean_0;

		// Token: 0x04002EF3 RID: 12019
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildScaleHeight_Public_set_Void_Boolean_0;

		// Token: 0x04002EF4 RID: 12020
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildForceExpandWidth_Public_get_Boolean_0;

		// Token: 0x04002EF5 RID: 12021
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildForceExpandWidth_Public_set_Void_Boolean_0;

		// Token: 0x04002EF6 RID: 12022
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildForceExpandHeight_Public_get_Boolean_0;

		// Token: 0x04002EF7 RID: 12023
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildForceExpandHeight_Public_set_Void_Boolean_0;

		// Token: 0x04002EF8 RID: 12024
		private static readonly IntPtr NativeMethodInfoPtr_get_PaddingLeft_Public_get_Int32_0;

		// Token: 0x04002EF9 RID: 12025
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingLeft_Public_set_Void_Int32_0;

		// Token: 0x04002EFA RID: 12026
		private static readonly IntPtr NativeMethodInfoPtr_get_PaddingRight_Public_get_Int32_0;

		// Token: 0x04002EFB RID: 12027
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingRight_Public_set_Void_Int32_0;

		// Token: 0x04002EFC RID: 12028
		private static readonly IntPtr NativeMethodInfoPtr_get_PaddingTop_Public_get_Int32_0;

		// Token: 0x04002EFD RID: 12029
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingTop_Public_set_Void_Int32_0;

		// Token: 0x04002EFE RID: 12030
		private static readonly IntPtr NativeMethodInfoPtr_get_PaddingBottom_Public_get_Int32_0;

		// Token: 0x04002EFF RID: 12031
		private static readonly IntPtr NativeMethodInfoPtr_set_PaddingBottom_Public_set_Void_Int32_0;

		// Token: 0x04002F00 RID: 12032
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildAlignment_Public_get_TextAnchor_0;

		// Token: 0x04002F01 RID: 12033
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildAlignment_Public_set_Void_TextAnchor_0;

		// Token: 0x04002F02 RID: 12034
		private static readonly IntPtr NativeMethodInfoPtr_get_ReverseAlignment_Public_get_Boolean_0;

		// Token: 0x04002F03 RID: 12035
		private static readonly IntPtr NativeMethodInfoPtr_set_ReverseAlignment_Public_set_Void_Boolean_0;

		// Token: 0x04002F04 RID: 12036
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkspacing_Public_get_Single_0;

		// Token: 0x04002F05 RID: 12037
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkspacing_Public_set_Void_Single_0;

		// Token: 0x04002F06 RID: 12038
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkchildControlWidth_Public_get_Boolean_0;

		// Token: 0x04002F07 RID: 12039
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkchildControlWidth_Public_set_Void_Boolean_0;

		// Token: 0x04002F08 RID: 12040
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkchildControlHeight_Public_get_Boolean_0;

		// Token: 0x04002F09 RID: 12041
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkchildControlHeight_Public_set_Void_Boolean_0;

		// Token: 0x04002F0A RID: 12042
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkchildScaleWidth_Public_get_Boolean_0;

		// Token: 0x04002F0B RID: 12043
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkchildScaleWidth_Public_set_Void_Boolean_0;

		// Token: 0x04002F0C RID: 12044
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkchildScaleHeight_Public_get_Boolean_0;

		// Token: 0x04002F0D RID: 12045
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkchildScaleHeight_Public_set_Void_Boolean_0;

		// Token: 0x04002F0E RID: 12046
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkchildForceExpandWidth_Public_get_Boolean_0;

		// Token: 0x04002F0F RID: 12047
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkchildForceExpandWidth_Public_set_Void_Boolean_0;

		// Token: 0x04002F10 RID: 12048
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkchildForceExpandHeight_Public_get_Boolean_0;

		// Token: 0x04002F11 RID: 12049
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkchildForceExpandHeight_Public_set_Void_Boolean_0;

		// Token: 0x04002F12 RID: 12050
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpaddingLeft_Public_get_Int32_0;

		// Token: 0x04002F13 RID: 12051
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpaddingLeft_Public_set_Void_Int32_0;

		// Token: 0x04002F14 RID: 12052
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpaddingRight_Public_get_Int32_0;

		// Token: 0x04002F15 RID: 12053
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpaddingRight_Public_set_Void_Int32_0;

		// Token: 0x04002F16 RID: 12054
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpaddingTop_Public_get_Int32_0;

		// Token: 0x04002F17 RID: 12055
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpaddingTop_Public_set_Void_Int32_0;

		// Token: 0x04002F18 RID: 12056
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkpaddingBottom_Public_get_Int32_0;

		// Token: 0x04002F19 RID: 12057
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkpaddingBottom_Public_set_Void_Int32_0;

		// Token: 0x04002F1A RID: 12058
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkchildAlignment_Public_get_TextAnchor_0;

		// Token: 0x04002F1B RID: 12059
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkchildAlignment_Public_set_Void_TextAnchor_0;

		// Token: 0x04002F1C RID: 12060
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkreverseAlignment_Public_get_Boolean_0;

		// Token: 0x04002F1D RID: 12061
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkreverseAlignment_Public_set_Void_Boolean_0;

		// Token: 0x04002F1E RID: 12062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F1F RID: 12063
		private static readonly IntPtr NativeMethodInfoPtr_SyncSpacing_Private_Void_Single_Single_0;

		// Token: 0x04002F20 RID: 12064
		private static readonly IntPtr NativeMethodInfoPtr_SyncChildControlWidth_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002F21 RID: 12065
		private static readonly IntPtr NativeMethodInfoPtr_SyncChildControlHeight_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002F22 RID: 12066
		private static readonly IntPtr NativeMethodInfoPtr_SyncChildScaleWidth_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002F23 RID: 12067
		private static readonly IntPtr NativeMethodInfoPtr_SyncChildScaleHeight_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002F24 RID: 12068
		private static readonly IntPtr NativeMethodInfoPtr_SyncChildForceExpandWidth_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002F25 RID: 12069
		private static readonly IntPtr NativeMethodInfoPtr_SyncChildForceExpandHeight_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002F26 RID: 12070
		private static readonly IntPtr NativeMethodInfoPtr_SyncPaddingLeft_Private_Void_Int32_Int32_0;

		// Token: 0x04002F27 RID: 12071
		private static readonly IntPtr NativeMethodInfoPtr_SyncPaddingRight_Private_Void_Int32_Int32_0;

		// Token: 0x04002F28 RID: 12072
		private static readonly IntPtr NativeMethodInfoPtr_SyncPaddingTop_Private_Void_Int32_Int32_0;

		// Token: 0x04002F29 RID: 12073
		private static readonly IntPtr NativeMethodInfoPtr_SyncPaddingBottom_Private_Void_Int32_Int32_0;

		// Token: 0x04002F2A RID: 12074
		private static readonly IntPtr NativeMethodInfoPtr_SyncChildAlignment_Private_Void_TextAnchor_TextAnchor_0;

		// Token: 0x04002F2B RID: 12075
		private static readonly IntPtr NativeMethodInfoPtr_SyncReverseAlignment_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002F2C RID: 12076
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002F2D RID: 12077
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04002F2E RID: 12078
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002F2F RID: 12079
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002F30 RID: 12080
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002F31 RID: 12081
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
