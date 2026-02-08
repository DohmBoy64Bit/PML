using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000134 RID: 308
	[Serializable]
	public class Hotkeys : global::Il2CppSystem.Object
	{
		// Token: 0x06001BDD RID: 7133 RVA: 0x0008E2E0 File Offset: 0x0008C4E0
		// Note: this type is marked as 'beforefieldinit'.
		static Hotkeys()
		{
			Il2CppClassPointerStore<Hotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Hotkeys");
			Hotkeys.NativeFieldInfoPtr__availableKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_availableKeys");
			Hotkeys.NativeFieldInfoPtr__availableKeyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_availableKeyNames");
			Hotkeys.NativeFieldInfoPtr__maxNumberOfKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_maxNumberOfKeys");
			Hotkeys.NativeFieldInfoPtr__isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_isEnabled");
			Hotkeys.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_key");
			Hotkeys.NativeFieldInfoPtr__lCtrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_lCtrl");
			Hotkeys.NativeFieldInfoPtr__lCmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_lCmd");
			Hotkeys.NativeFieldInfoPtr__lAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_lAlt");
			Hotkeys.NativeFieldInfoPtr__lShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_lShift");
			Hotkeys.NativeFieldInfoPtr__useStrictModifierCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_useStrictModifierCheck");
			Hotkeys.NativeFieldInfoPtr__lMouseBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_lMouseBtn");
			Hotkeys.NativeFieldInfoPtr__rMouseBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_rMouseBtn");
			Hotkeys.NativeFieldInfoPtr__mMouseBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_mMouseBtn");
			Hotkeys.NativeFieldInfoPtr__useStrictMouseCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_useStrictMouseCheck");
			Hotkeys.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_name");
			Hotkeys.NativeFieldInfoPtr__potentialOverlaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_potentialOverlaps");
			Hotkeys.NativeFieldInfoPtr__staticData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, "_staticData");
			Hotkeys.NativeMethodInfoPtr_get_AvailableKeys_Public_Static_get_List_1_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667486);
			Hotkeys.NativeMethodInfoPtr_get_AvailableKeyNames_Public_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667487);
			Hotkeys.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667488);
			Hotkeys.NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667489);
			Hotkeys.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667490);
			Hotkeys.NativeMethodInfoPtr_get_Key_Public_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667491);
			Hotkeys.NativeMethodInfoPtr_set_Key_Public_set_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667492);
			Hotkeys.NativeMethodInfoPtr_get_LCtrl_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667493);
			Hotkeys.NativeMethodInfoPtr_set_LCtrl_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667494);
			Hotkeys.NativeMethodInfoPtr_get_LCmd_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667495);
			Hotkeys.NativeMethodInfoPtr_set_LCmd_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667496);
			Hotkeys.NativeMethodInfoPtr_get_LAlt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667497);
			Hotkeys.NativeMethodInfoPtr_set_LAlt_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667498);
			Hotkeys.NativeMethodInfoPtr_get_LShift_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667499);
			Hotkeys.NativeMethodInfoPtr_set_LShift_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667500);
			Hotkeys.NativeMethodInfoPtr_get_LMouseButton_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667501);
			Hotkeys.NativeMethodInfoPtr_set_LMouseButton_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667502);
			Hotkeys.NativeMethodInfoPtr_get_RMouseButton_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667503);
			Hotkeys.NativeMethodInfoPtr_set_RMouseButton_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667504);
			Hotkeys.NativeMethodInfoPtr_get_MMouseButton_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667505);
			Hotkeys.NativeMethodInfoPtr_set_MMouseButton_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667506);
			Hotkeys.NativeMethodInfoPtr_get_UseStrictMouseCheck_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667507);
			Hotkeys.NativeMethodInfoPtr_set_UseStrictMouseCheck_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667508);
			Hotkeys.NativeMethodInfoPtr_get_UseStrictModifierCheck_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667509);
			Hotkeys.NativeMethodInfoPtr_set_UseStrictModifierCheck_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667510);
			Hotkeys.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667511);
			Hotkeys.NativeMethodInfoPtr__ctor_Public_Void_String_HotkeysStaticData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667512);
			Hotkeys.NativeMethodInfoPtr_EstablishPotentialOverlaps_Public_Static_Void_List_1_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667513);
			Hotkeys.NativeMethodInfoPtr_GetNumModifiers_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667514);
			Hotkeys.NativeMethodInfoPtr_GetNumMouseButtons_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667515);
			Hotkeys.NativeMethodInfoPtr_GetAllUsedMouseButtons_Public_List_1_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667516);
			Hotkeys.NativeMethodInfoPtr_UsesMouseButtons_Public_Boolean_List_1_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667517);
			Hotkeys.NativeMethodInfoPtr_GetAllUsedModifiers_Public_List_1_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667518);
			Hotkeys.NativeMethodInfoPtr_UsesModifiers_Public_Boolean_List_1_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667519);
			Hotkeys.NativeMethodInfoPtr_AddPotentialOverlap_Public_Void_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667520);
			Hotkeys.NativeMethodInfoPtr_ContainsPotentialOverlap_Public_Boolean_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667521);
			Hotkeys.NativeMethodInfoPtr_IsOverlappedBy_Public_Boolean_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667522);
			Hotkeys.NativeMethodInfoPtr_IsActive_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667523);
			Hotkeys.NativeMethodInfoPtr_IsActiveInFrame_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667524);
			Hotkeys.NativeMethodInfoPtr_HasNoKeys_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667525);
			Hotkeys.NativeMethodInfoPtr_HasNoModifiers_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667526);
			Hotkeys.NativeMethodInfoPtr_HasNoMouseButtons_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667527);
			Hotkeys.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667528);
			Hotkeys.NativeMethodInfoPtr_IsAnyModifierKeyPressed_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667529);
			Hotkeys.NativeMethodInfoPtr_IsAnyMouseButtonPressed_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr, 100667530);
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x0008E7E0 File Offset: 0x0008C9E0
		public unsafe static List<KeyCode> AvailableKeys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78139, XrefRangeEnd = 78149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_AvailableKeys_Public_Static_get_List_1_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<KeyCode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x0008E814 File Offset: 0x0008CA14
		public unsafe static List<string> AvailableKeyNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78149, XrefRangeEnd = 78159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_AvailableKeyNames_Public_Static_get_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x0008E848 File Offset: 0x0008CA48
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0008E884 File Offset: 0x0008CA84
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20587, RefRangeEnd = 20588, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x0008E8C4 File Offset: 0x0008CAC4
		public unsafe string Name
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x0008E8FC File Offset: 0x0008CAFC
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x0008E93C File Offset: 0x0008CB3C
		public unsafe KeyCode Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_Key_Public_get_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyCode>(intPtr3) : null;
			}
			[CallerCount(52)]
			[CachedScanResults(RefRangeStart = 78166, RefRangeEnd = 78218, XrefRangeStart = 78159, XrefRangeEnd = 78166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_Key_Public_set_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0008E980 File Offset: 0x0008CB80
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0008E9BC File Offset: 0x0008CBBC
		public unsafe bool LCtrl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_LCtrl_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_LCtrl_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0008E9FC File Offset: 0x0008CBFC
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0008EA38 File Offset: 0x0008CC38
		public unsafe bool LCmd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_LCmd_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_LCmd_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0008EA78 File Offset: 0x0008CC78
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0008EAB4 File Offset: 0x0008CCB4
		public unsafe bool LAlt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_LAlt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_LAlt_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0008EAF4 File Offset: 0x0008CCF4
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0008EB30 File Offset: 0x0008CD30
		public unsafe bool LShift
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_LShift_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_LShift_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0008EB70 File Offset: 0x0008CD70
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0008EBAC File Offset: 0x0008CDAC
		public unsafe bool LMouseButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_LMouseButton_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_LMouseButton_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0008EBEC File Offset: 0x0008CDEC
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x0008EC28 File Offset: 0x0008CE28
		public unsafe bool RMouseButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_RMouseButton_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_RMouseButton_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x0008EC68 File Offset: 0x0008CE68
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x0008ECA4 File Offset: 0x0008CEA4
		public unsafe bool MMouseButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_MMouseButton_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_MMouseButton_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x0008ECE4 File Offset: 0x0008CEE4
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0008ED20 File Offset: 0x0008CF20
		public unsafe bool UseStrictMouseCheck
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_UseStrictMouseCheck_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_UseStrictMouseCheck_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0008ED60 File Offset: 0x0008CF60
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0008ED9C File Offset: 0x0008CF9C
		public unsafe bool UseStrictModifierCheck
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_get_UseStrictModifierCheck_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_set_UseStrictModifierCheck_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0008EDDC File Offset: 0x0008CFDC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 78231, RefRangeEnd = 78241, XrefRangeStart = 78218, XrefRangeEnd = 78231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hotkeys(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0008EE28 File Offset: 0x0008D028
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 78254, RefRangeEnd = 78310, XrefRangeStart = 78241, XrefRangeEnd = 78254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hotkeys(string name, HotkeysStaticData staticData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hotkeys>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(staticData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr__ctor_Public_Void_String_HotkeysStaticData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0008EE88 File Offset: 0x0008D088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78335, RefRangeEnd = 78336, XrefRangeStart = 78310, XrefRangeEnd = 78335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EstablishPotentialOverlaps(List<Hotkeys> hotkeysCollection)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hotkeysCollection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_EstablishPotentialOverlaps_Public_Static_Void_List_1_Hotkeys_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0008EEC0 File Offset: 0x0008D0C0
		[CallerCount(0)]
		public unsafe int GetNumModifiers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_GetNumModifiers_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0008EEFC File Offset: 0x0008D0FC
		[CallerCount(0)]
		public unsafe int GetNumMouseButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_GetNumMouseButtons_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0008EF38 File Offset: 0x0008D138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78352, RefRangeEnd = 78354, XrefRangeStart = 78336, XrefRangeEnd = 78352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MouseButton> GetAllUsedMouseButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_GetAllUsedMouseButtons_Public_List_1_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MouseButton>>(intPtr3) : null;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0008EF78 File Offset: 0x0008D178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78368, RefRangeEnd = 78369, XrefRangeStart = 78354, XrefRangeEnd = 78368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UsesMouseButtons(List<MouseButton> buttons)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttons);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_UsesMouseButtons_Public_Boolean_List_1_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0008EFC8 File Offset: 0x0008D1C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78385, RefRangeEnd = 78387, XrefRangeStart = 78369, XrefRangeEnd = 78385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<KeyCode> GetAllUsedModifiers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_GetAllUsedModifiers_Public_List_1_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<KeyCode>>(intPtr3) : null;
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0008F008 File Offset: 0x0008D208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78401, RefRangeEnd = 78402, XrefRangeStart = 78387, XrefRangeEnd = 78401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UsesModifiers(List<KeyCode> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_UsesModifiers_Public_Boolean_List_1_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0008F058 File Offset: 0x0008D258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78408, RefRangeEnd = 78409, XrefRangeStart = 78402, XrefRangeEnd = 78408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPotentialOverlap(Hotkeys hotkeys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hotkeys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_AddPotentialOverlap_Public_Void_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0008F09C File Offset: 0x0008D29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78409, XrefRangeEnd = 78413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPotentialOverlap(Hotkeys hotkeys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hotkeys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_ContainsPotentialOverlap_Public_Boolean_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0008F0EC File Offset: 0x0008D2EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78417, RefRangeEnd = 78419, XrefRangeStart = 78413, XrefRangeEnd = 78417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOverlappedBy(Hotkeys hotkeys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hotkeys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_IsOverlappedBy_Public_Boolean_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0008F13C File Offset: 0x0008D33C
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 78456, RefRangeEnd = 78498, XrefRangeStart = 78419, XrefRangeEnd = 78456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActive(bool checkForOverlaps = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref checkForOverlaps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_IsActive_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0008F188 File Offset: 0x0008D388
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 78527, RefRangeEnd = 78550, XrefRangeStart = 78498, XrefRangeEnd = 78527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActiveInFrame(bool checkForOverlaps = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref checkForOverlaps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_IsActiveInFrame_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0008F1D4 File Offset: 0x0008D3D4
		[CallerCount(0)]
		public unsafe bool HasNoKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_HasNoKeys_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0008F210 File Offset: 0x0008D410
		[CallerCount(0)]
		public unsafe bool HasNoModifiers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_HasNoModifiers_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0008F24C File Offset: 0x0008D44C
		[CallerCount(0)]
		public unsafe bool HasNoMouseButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_HasNoMouseButtons_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0008F288 File Offset: 0x0008D488
		[CallerCount(0)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0008F2C4 File Offset: 0x0008D4C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78554, RefRangeEnd = 78556, XrefRangeStart = 78550, XrefRangeEnd = 78554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnyModifierKeyPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_IsAnyModifierKeyPressed_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0008F300 File Offset: 0x0008D500
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78559, RefRangeEnd = 78561, XrefRangeStart = 78556, XrefRangeEnd = 78559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnyMouseButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hotkeys.NativeMethodInfoPtr_IsAnyMouseButtonPressed_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0000BE3C File Offset: 0x0000A03C
		public Hotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x0008F33C File Offset: 0x0008D53C
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x0000BE45 File Offset: 0x0000A045
		public unsafe static List<KeyCode> _availableKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hotkeys.NativeFieldInfoPtr__availableKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hotkeys.NativeFieldInfoPtr__availableKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x0008F364 File Offset: 0x0008D564
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x0000BE57 File Offset: 0x0000A057
		public unsafe static List<string> _availableKeyNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hotkeys.NativeFieldInfoPtr__availableKeyNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hotkeys.NativeFieldInfoPtr__availableKeyNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x0008F38C File Offset: 0x0008D58C
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x0000BE69 File Offset: 0x0000A069
		public unsafe static int _maxNumberOfKeys
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hotkeys.NativeFieldInfoPtr__maxNumberOfKeys, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hotkeys.NativeFieldInfoPtr__maxNumberOfKeys, (void*)(&value));
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0008F3A8 File Offset: 0x0008D5A8
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x0000BE77 File Offset: 0x0000A077
		public unsafe bool _isEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__isEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__isEnabled)) = value;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x0008F3D0 File Offset: 0x0008D5D0
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x0000BE92 File Offset: 0x0000A092
		public unsafe KeyCode _key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x0008F400 File Offset: 0x0008D600
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x0000BEB1 File Offset: 0x0000A0B1
		public unsafe bool _lCtrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lCtrl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lCtrl)) = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0008F428 File Offset: 0x0008D628
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x0000BECC File Offset: 0x0000A0CC
		public unsafe bool _lCmd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lCmd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lCmd)) = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0008F450 File Offset: 0x0008D650
		// (set) Token: 0x06001C1B RID: 7195 RVA: 0x0000BEE7 File Offset: 0x0000A0E7
		public unsafe bool _lAlt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lAlt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lAlt)) = value;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0008F478 File Offset: 0x0008D678
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x0000BF02 File Offset: 0x0000A102
		public unsafe bool _lShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lShift)) = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0008F4A0 File Offset: 0x0008D6A0
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x0000BF1D File Offset: 0x0000A11D
		public unsafe bool _useStrictModifierCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__useStrictModifierCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__useStrictModifierCheck)) = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x0008F4C8 File Offset: 0x0008D6C8
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x0000BF38 File Offset: 0x0000A138
		public unsafe bool _lMouseBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lMouseBtn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__lMouseBtn)) = value;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x0008F4F0 File Offset: 0x0008D6F0
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x0000BF53 File Offset: 0x0000A153
		public unsafe bool _rMouseBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__rMouseBtn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__rMouseBtn)) = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0008F518 File Offset: 0x0008D718
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x0000BF6E File Offset: 0x0000A16E
		public unsafe bool _mMouseBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__mMouseBtn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__mMouseBtn)) = value;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0008F540 File Offset: 0x0008D740
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x0000BF89 File Offset: 0x0000A189
		public unsafe bool _useStrictMouseCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__useStrictMouseCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__useStrictMouseCheck)) = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x0008F568 File Offset: 0x0008D768
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0008F590 File Offset: 0x0008D790
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0000BFC3 File Offset: 0x0000A1C3
		public unsafe List<Hotkeys> _potentialOverlaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__potentialOverlaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Hotkeys>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__potentialOverlaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x0008F5C0 File Offset: 0x0008D7C0
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x0000BFE2 File Offset: 0x0000A1E2
		public unsafe HotkeysStaticData _staticData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__staticData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotkeysStaticData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hotkeys.NativeFieldInfoPtr__staticData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeFieldInfoPtr__availableKeys;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeFieldInfoPtr__availableKeyNames;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeFieldInfoPtr__maxNumberOfKeys;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeFieldInfoPtr__lCtrl;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeFieldInfoPtr__lCmd;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeFieldInfoPtr__lAlt;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeFieldInfoPtr__lShift;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeFieldInfoPtr__useStrictModifierCheck;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeFieldInfoPtr__lMouseBtn;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeFieldInfoPtr__rMouseBtn;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeFieldInfoPtr__mMouseBtn;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeFieldInfoPtr__useStrictMouseCheck;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeFieldInfoPtr__potentialOverlaps;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeFieldInfoPtr__staticData;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableKeys_Public_Static_get_List_1_KeyCode_0;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableKeyNames_Public_Static_get_List_1_String_0;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_KeyCode_0;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_KeyCode_0;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeMethodInfoPtr_get_LCtrl_Public_get_Boolean_0;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeMethodInfoPtr_set_LCtrl_Public_set_Void_Boolean_0;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeMethodInfoPtr_get_LCmd_Public_get_Boolean_0;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeMethodInfoPtr_set_LCmd_Public_set_Void_Boolean_0;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr_get_LAlt_Public_get_Boolean_0;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr_set_LAlt_Public_set_Void_Boolean_0;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr_get_LShift_Public_get_Boolean_0;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr_set_LShift_Public_set_Void_Boolean_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_get_LMouseButton_Public_get_Boolean_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr_set_LMouseButton_Public_set_Void_Boolean_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr_get_RMouseButton_Public_get_Boolean_0;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeMethodInfoPtr_set_RMouseButton_Public_set_Void_Boolean_0;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeMethodInfoPtr_get_MMouseButton_Public_get_Boolean_0;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_set_MMouseButton_Public_set_Void_Boolean_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_get_UseStrictMouseCheck_Public_get_Boolean_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr_set_UseStrictMouseCheck_Public_set_Void_Boolean_0;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeMethodInfoPtr_get_UseStrictModifierCheck_Public_get_Boolean_0;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeMethodInfoPtr_set_UseStrictModifierCheck_Public_set_Void_Boolean_0;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_HotkeysStaticData_0;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeMethodInfoPtr_EstablishPotentialOverlaps_Public_Static_Void_List_1_Hotkeys_0;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeMethodInfoPtr_GetNumModifiers_Public_Int32_0;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeMethodInfoPtr_GetNumMouseButtons_Public_Int32_0;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_GetAllUsedMouseButtons_Public_List_1_MouseButton_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_UsesMouseButtons_Public_Boolean_List_1_MouseButton_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_GetAllUsedModifiers_Public_List_1_KeyCode_0;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeMethodInfoPtr_UsesModifiers_Public_Boolean_List_1_KeyCode_0;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeMethodInfoPtr_AddPotentialOverlap_Public_Void_Hotkeys_0;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPotentialOverlap_Public_Boolean_Hotkeys_0;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeMethodInfoPtr_IsOverlappedBy_Public_Boolean_Hotkeys_0;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Boolean_Boolean_0;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_IsActiveInFrame_Public_Boolean_Boolean_0;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr_HasNoKeys_Public_Boolean_0;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_HasNoModifiers_Public_Boolean_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_HasNoMouseButtons_Public_Boolean_0;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyModifierKeyPressed_Private_Boolean_0;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyMouseButtonPressed_Private_Boolean_0;
	}
}
