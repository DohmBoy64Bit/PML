using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200019F RID: 415
	[Serializable]
	public class RTPrefabLibDb : MonoSingleton<RTPrefabLibDb>
	{
		// Token: 0x06001FD6 RID: 8150 RVA: 0x000A0318 File Offset: 0x0009E518
		// Note: this type is marked as 'beforefieldinit'.
		static RTPrefabLibDb()
		{
			Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTPrefabLibDb");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr);
			RTPrefabLibDb.NativeFieldInfoPtr__newLibName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "_newLibName");
			RTPrefabLibDb.NativeFieldInfoPtr__prefabScrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "_prefabScrollPos");
			RTPrefabLibDb.NativeFieldInfoPtr__numPrefabsPerRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "_numPrefabsPerRow");
			RTPrefabLibDb.NativeFieldInfoPtr_PrefabSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "PrefabSpawned");
			RTPrefabLibDb.NativeFieldInfoPtr__editorPrefabPreviewGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "_editorPrefabPreviewGen");
			RTPrefabLibDb.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "_settings");
			RTPrefabLibDb.NativeFieldInfoPtr__runtimeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "_runtimeUI");
			RTPrefabLibDb.NativeFieldInfoPtr__prefabPreviewLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "_prefabPreviewLookAndFeel");
			RTPrefabLibDb.NativeFieldInfoPtr__activeLibIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "_activeLibIndex");
			RTPrefabLibDb.NativeFieldInfoPtr__libs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "_libs");
			RTPrefabLibDb.NativeMethodInfoPtr_get_NumLibs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668144);
			RTPrefabLibDb.NativeMethodInfoPtr_get_ActiveLibIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668145);
			RTPrefabLibDb.NativeMethodInfoPtr_get_ActiveLib_Public_get_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668146);
			RTPrefabLibDb.NativeMethodInfoPtr_get_PrefabPreviewLookAndFeel_Public_get_PrefabPreviewLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668147);
			RTPrefabLibDb.NativeMethodInfoPtr_get_RuntimeUI_Public_get_RTPrefabLibDbUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668148);
			RTPrefabLibDb.NativeMethodInfoPtr_get_HasRuntimeUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668149);
			RTPrefabLibDb.NativeMethodInfoPtr_get_Settings_Public_get_PrefabLibDbSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668150);
			RTPrefabLibDb.NativeMethodInfoPtr_get_EditorPrefabPreviewGen_Public_get_EditorPrefabPreviewGen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668151);
			RTPrefabLibDb.NativeMethodInfoPtr_add_PrefabSpawned_Public_add_Void_PrefabLibDbPrefabSpawnedHander_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668142);
			RTPrefabLibDb.NativeMethodInfoPtr_remove_PrefabSpawned_Public_rem_Void_PrefabLibDbPrefabSpawnedHander_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668143);
			RTPrefabLibDb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668178);
			RTPrefabLibDb.NativeMethodInfoPtr_CreateLib_Public_RTPrefabLib_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668152);
			RTPrefabLibDb.NativeMethodInfoPtr_SortLibsByName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668153);
			RTPrefabLibDb.NativeMethodInfoPtr_SetLibName_Public_Boolean_RTPrefabLib_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668154);
			RTPrefabLibDb.NativeMethodInfoPtr_SetActiveLib_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668155);
			RTPrefabLibDb.NativeMethodInfoPtr_SetActiveLib_Public_Void_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668156);
			RTPrefabLibDb.NativeMethodInfoPtr_SetActiveLib_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668157);
			RTPrefabLibDb.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668158);
			RTPrefabLibDb.NativeMethodInfoPtr_Remove_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668159);
			RTPrefabLibDb.NativeMethodInfoPtr_Remove_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668160);
			RTPrefabLibDb.NativeMethodInfoPtr_Remove_Public_Void_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668161);
			RTPrefabLibDb.NativeMethodInfoPtr_Remove_Public_Void_List_1_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668162);
			RTPrefabLibDb.NativeMethodInfoPtr_GetEmptyLibs_Public_List_1_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668163);
			RTPrefabLibDb.NativeMethodInfoPtr_RemoveEmptyLibs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668164);
			RTPrefabLibDb.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668165);
			RTPrefabLibDb.NativeMethodInfoPtr_Contains_Public_Boolean_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668166);
			RTPrefabLibDb.NativeMethodInfoPtr_GetAllLibNames_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668167);
			RTPrefabLibDb.NativeMethodInfoPtr_GetLibIndex_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668168);
			RTPrefabLibDb.NativeMethodInfoPtr_GetLibIndex_Public_Int32_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668169);
			RTPrefabLibDb.NativeMethodInfoPtr_GetLib_Public_RTPrefabLib_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668170);
			RTPrefabLibDb.NativeMethodInfoPtr_GetLib_Public_RTPrefabLib_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668171);
			RTPrefabLibDb.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668172);
			RTPrefabLibDb.NativeMethodInfoPtr_OnActiveLibDropDownChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668173);
			RTPrefabLibDb.NativeMethodInfoPtr_OnPrefabCreatedInLib_Private_Void_RTPrefabLib_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668174);
			RTPrefabLibDb.NativeMethodInfoPtr_OnPrefabRemovedFromLib_Private_Void_RTPrefabLib_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668175);
			RTPrefabLibDb.NativeMethodInfoPtr_OnPrefabLibCleared_Private_Void_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668176);
			RTPrefabLibDb.NativeMethodInfoPtr_OnPrefabPreviewButtonClicked_Private_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668177);
			RTPrefabLibDb.NativeMethodInfoPtr__Start_b__48_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, 100668179);
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x000A0708 File Offset: 0x0009E908
		public unsafe int NumLibs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83951, XrefRangeEnd = 83952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_get_NumLibs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x000A0744 File Offset: 0x0009E944
		public unsafe int ActiveLibIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_get_ActiveLibIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x000A0780 File Offset: 0x0009E980
		public unsafe RTPrefabLib ActiveLib
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83955, RefRangeEnd = 83956, XrefRangeStart = 83952, XrefRangeEnd = 83955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_get_ActiveLib_Public_get_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefabLib>(intPtr3) : null;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x000A07C0 File Offset: 0x0009E9C0
		public unsafe PrefabPreviewLookAndFeel PrefabPreviewLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_get_PrefabPreviewLookAndFeel_Public_get_PrefabPreviewLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefabPreviewLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x000A0800 File Offset: 0x0009EA00
		public unsafe RTPrefabLibDbUI RuntimeUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_get_RuntimeUI_Public_get_RTPrefabLibDbUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefabLibDbUI>(intPtr3) : null;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x000A0840 File Offset: 0x0009EA40
		public unsafe bool HasRuntimeUI
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 83963, RefRangeEnd = 83974, XrefRangeStart = 83956, XrefRangeEnd = 83963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_get_HasRuntimeUI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x000A087C File Offset: 0x0009EA7C
		public unsafe PrefabLibDbSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_get_Settings_Public_get_PrefabLibDbSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefabLibDbSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x000A08BC File Offset: 0x0009EABC
		public unsafe EditorPrefabPreviewGen EditorPrefabPreviewGen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_get_EditorPrefabPreviewGen_Public_get_EditorPrefabPreviewGen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EditorPrefabPreviewGen>(intPtr3) : null;
			}
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x000A08FC File Offset: 0x0009EAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83974, XrefRangeEnd = 83978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PrefabSpawned(PrefabLibDbPrefabSpawnedHander value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_add_PrefabSpawned_Public_add_Void_PrefabLibDbPrefabSpawnedHander_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x000A0940 File Offset: 0x0009EB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83978, XrefRangeEnd = 83982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PrefabSpawned(PrefabLibDbPrefabSpawnedHander value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_remove_PrefabSpawned_Public_rem_Void_PrefabLibDbPrefabSpawnedHander_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x000A0984 File Offset: 0x0009EB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83982, XrefRangeEnd = 84012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefabLibDb()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x000A09C0 File Offset: 0x0009EBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84012, XrefRangeEnd = 84060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefabLib CreateLib(string libName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(libName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_CreateLib_Public_RTPrefabLib_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefabLib>(intPtr3) : null;
			}
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x000A0A10 File Offset: 0x0009EC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84060, XrefRangeEnd = 84086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortLibsByName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_SortLibsByName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x000A0A44 File Offset: 0x0009EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84086, XrefRangeEnd = 84100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLibName(RTPrefabLib lib, string newLibName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lib);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newLibName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_SetLibName_Public_Boolean_RTPrefabLib_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x000A0AA4 File Offset: 0x0009ECA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 84111, RefRangeEnd = 84115, XrefRangeStart = 84100, XrefRangeEnd = 84111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveLib(int libIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref libIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_SetActiveLib_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000A0AE4 File Offset: 0x0009ECE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84115, XrefRangeEnd = 84120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveLib(RTPrefabLib lib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lib);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_SetActiveLib_Public_Void_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x000A0B28 File Offset: 0x0009ED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84120, XrefRangeEnd = 84122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveLib(string libName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(libName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_SetActiveLib_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x000A0B6C File Offset: 0x0009ED6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84122, XrefRangeEnd = 84131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x000A0BA0 File Offset: 0x0009EDA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84151, RefRangeEnd = 84154, XrefRangeStart = 84131, XrefRangeEnd = 84151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(int libIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref libIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_Remove_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x000A0BE0 File Offset: 0x0009EDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84154, XrefRangeEnd = 84156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(string libName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(libName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_Remove_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x000A0C24 File Offset: 0x0009EE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84156, XrefRangeEnd = 84160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(RTPrefabLib lib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lib);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_Remove_Public_Void_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x000A0C68 File Offset: 0x0009EE68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84178, RefRangeEnd = 84179, XrefRangeStart = 84160, XrefRangeEnd = 84178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(List<RTPrefabLib> libs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(libs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_Remove_Public_Void_List_1_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x000A0CAC File Offset: 0x0009EEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84203, RefRangeEnd = 84204, XrefRangeStart = 84179, XrefRangeEnd = 84203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<RTPrefabLib> GetEmptyLibs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_GetEmptyLibs_Public_List_1_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RTPrefabLib>>(intPtr3) : null;
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000A0CEC File Offset: 0x0009EEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84204, XrefRangeEnd = 84206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEmptyLibs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_RemoveEmptyLibs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000A0D20 File Offset: 0x0009EF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84206, XrefRangeEnd = 84225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string libName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(libName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000A0D70 File Offset: 0x0009EF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84225, XrefRangeEnd = 84229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(RTPrefabLib lib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lib);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_Contains_Public_Boolean_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000A0DC0 File Offset: 0x0009EFC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84254, RefRangeEnd = 84257, XrefRangeStart = 84229, XrefRangeEnd = 84254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetAllLibNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_GetAllLibNames_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x000A0E00 File Offset: 0x0009F000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84272, RefRangeEnd = 84274, XrefRangeStart = 84257, XrefRangeEnd = 84272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLibIndex(string libName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(libName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_GetLibIndex_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x000A0E50 File Offset: 0x0009F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84274, XrefRangeEnd = 84278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLibIndex(RTPrefabLib lib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lib);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_GetLibIndex_Public_Int32_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000A0EA0 File Offset: 0x0009F0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84278, XrefRangeEnd = 84282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefabLib GetLib(int libIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref libIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_GetLib_Public_RTPrefabLib_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefabLib>(intPtr3) : null;
			}
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000A0EEC File Offset: 0x0009F0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84282, XrefRangeEnd = 84300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefabLib GetLib(string libName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(libName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_GetLib_Public_RTPrefabLib_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefabLib>(intPtr3) : null;
			}
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x000A0F3C File Offset: 0x0009F13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84300, XrefRangeEnd = 84382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000A0F70 File Offset: 0x0009F170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84382, XrefRangeEnd = 84388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnActiveLibDropDownChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_OnActiveLibDropDownChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000A0FA4 File Offset: 0x0009F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84388, XrefRangeEnd = 84398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrefabCreatedInLib(RTPrefabLib prefabLib, RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefabLib);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_OnPrefabCreatedInLib_Private_Void_RTPrefabLib_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000A0FF8 File Offset: 0x0009F1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84398, XrefRangeEnd = 84404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrefabRemovedFromLib(RTPrefabLib prefabLib, RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefabLib);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_OnPrefabRemovedFromLib_Private_Void_RTPrefabLib_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000A104C File Offset: 0x0009F24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84404, XrefRangeEnd = 84410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrefabLibCleared(RTPrefabLib prefabLib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefabLib);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_OnPrefabLibCleared_Private_Void_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000A1090 File Offset: 0x0009F290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84410, XrefRangeEnd = 84438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrefabPreviewButtonClicked(RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr_OnPrefabPreviewButtonClicked_Private_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000A10D4 File Offset: 0x0009F2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__48_0(int <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.NativeMethodInfoPtr__Start_b__48_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0000CEE6 File Offset: 0x0000B0E6
		public RTPrefabLibDb(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x000A1114 File Offset: 0x0009F314
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x0000CEEF File Offset: 0x0000B0EF
		public unsafe string _newLibName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__newLibName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__newLibName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x000A113C File Offset: 0x0009F33C
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x0000CF0E File Offset: 0x0000B10E
		public unsafe Vector2 _prefabScrollPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__prefabScrollPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__prefabScrollPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x000A116C File Offset: 0x0009F36C
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x0000CF2D File Offset: 0x0000B12D
		public unsafe int _numPrefabsPerRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__numPrefabsPerRow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__numPrefabsPerRow)) = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x000A1194 File Offset: 0x0009F394
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x0000CF48 File Offset: 0x0000B148
		public unsafe PrefabLibDbPrefabSpawnedHander PrefabSpawned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr_PrefabSpawned);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabLibDbPrefabSpawnedHander>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr_PrefabSpawned), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x000A11C4 File Offset: 0x0009F3C4
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x0000CF67 File Offset: 0x0000B167
		public unsafe EditorPrefabPreviewGen _editorPrefabPreviewGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__editorPrefabPreviewGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorPrefabPreviewGen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__editorPrefabPreviewGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x000A11F4 File Offset: 0x0009F3F4
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x0000CF86 File Offset: 0x0000B186
		public unsafe PrefabLibDbSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabLibDbSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x000A1224 File Offset: 0x0009F424
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x0000CFA5 File Offset: 0x0000B1A5
		public unsafe RTPrefabLibDbUI _runtimeUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__runtimeUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefabLibDbUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__runtimeUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x000A1254 File Offset: 0x0009F454
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x0000CFC4 File Offset: 0x0000B1C4
		public unsafe PrefabPreviewLookAndFeel _prefabPreviewLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__prefabPreviewLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabPreviewLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__prefabPreviewLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x000A1284 File Offset: 0x0009F484
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x0000CFE3 File Offset: 0x0000B1E3
		public unsafe int _activeLibIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__activeLibIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__activeLibIndex)) = value;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x000A12AC File Offset: 0x0009F4AC
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x0000CFFE File Offset: 0x0000B1FE
		public unsafe List<RTPrefabLib> _libs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__libs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RTPrefabLib>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.NativeFieldInfoPtr__libs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeFieldInfoPtr__newLibName;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeFieldInfoPtr__prefabScrollPos;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeFieldInfoPtr__numPrefabsPerRow;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeFieldInfoPtr_PrefabSpawned;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeFieldInfoPtr__editorPrefabPreviewGen;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeFieldInfoPtr__runtimeUI;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeFieldInfoPtr__prefabPreviewLookAndFeel;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeFieldInfoPtr__activeLibIndex;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeFieldInfoPtr__libs;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeMethodInfoPtr_get_NumLibs_Public_get_Int32_0;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveLibIndex_Public_get_Int32_0;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveLib_Public_get_RTPrefabLib_0;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabPreviewLookAndFeel_Public_get_PrefabPreviewLookAndFeel_0;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeMethodInfoPtr_get_RuntimeUI_Public_get_RTPrefabLibDbUI_0;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRuntimeUI_Public_get_Boolean_0;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_PrefabLibDbSettings_0;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeMethodInfoPtr_get_EditorPrefabPreviewGen_Public_get_EditorPrefabPreviewGen_0;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeMethodInfoPtr_add_PrefabSpawned_Public_add_Void_PrefabLibDbPrefabSpawnedHander_0;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeMethodInfoPtr_remove_PrefabSpawned_Public_rem_Void_PrefabLibDbPrefabSpawnedHander_0;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeMethodInfoPtr_CreateLib_Public_RTPrefabLib_String_0;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_SortLibsByName_Public_Void_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_SetLibName_Public_Boolean_RTPrefabLib_String_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveLib_Public_Void_Int32_0;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveLib_Public_Void_RTPrefabLib_0;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveLib_Public_Void_String_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Int32_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_String_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_RTPrefabLib_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_List_1_RTPrefabLib_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyLibs_Public_List_1_RTPrefabLib_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEmptyLibs_Public_Void_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_RTPrefabLib_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_GetAllLibNames_Public_List_1_String_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_GetLibIndex_Public_Int32_String_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_GetLibIndex_Public_Int32_RTPrefabLib_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_GetLib_Public_RTPrefabLib_Int32_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_GetLib_Public_RTPrefabLib_String_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveLibDropDownChanged_Private_Void_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabCreatedInLib_Private_Void_RTPrefabLib_RTPrefab_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabRemovedFromLib_Private_Void_RTPrefabLib_RTPrefab_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabLibCleared_Private_Void_RTPrefabLib_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabPreviewButtonClicked_Private_Void_RTPrefab_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__48_0_Private_Void_Int32_0;

		// Token: 0x0200039B RID: 923
		[ObfuscatedName("RLD.RTPrefabLibDb+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004B67 RID: 19303 RVA: 0x0014A6F0 File Offset: 0x001488F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RTPrefabLibDb.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabLibDb.__c>.NativeClassPtr);
				RTPrefabLibDb.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb.__c>.NativeClassPtr, "<>9");
				RTPrefabLibDb.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb.__c>.NativeClassPtr, "<>9__29_0");
				RTPrefabLibDb.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb.__c>.NativeClassPtr, 100668181);
				RTPrefabLibDb.__c.NativeMethodInfoPtr__SortLibsByName_b__29_0_Internal_Int32_RTPrefabLib_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb.__c>.NativeClassPtr, 100668182);
			}

			// Token: 0x06004B68 RID: 19304 RVA: 0x0014A76C File Offset: 0x0014896C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabLibDb.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B69 RID: 19305 RVA: 0x0014A7A8 File Offset: 0x001489A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83947, XrefRangeEnd = 83949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortLibsByName_b__29_0(RTPrefabLib l0, RTPrefabLib l1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(l1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.__c.NativeMethodInfoPtr__SortLibsByName_b__29_0_Internal_Int32_RTPrefabLib_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B6A RID: 19306 RVA: 0x0001C3D9 File Offset: 0x0001A5D9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001975 RID: 6517
			// (get) Token: 0x06004B6B RID: 19307 RVA: 0x0014A808 File Offset: 0x00148A08
			// (set) Token: 0x06004B6C RID: 19308 RVA: 0x0001C3E2 File Offset: 0x0001A5E2
			public unsafe static RTPrefabLibDb.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RTPrefabLibDb.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefabLibDb.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RTPrefabLibDb.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001976 RID: 6518
			// (get) Token: 0x06004B6D RID: 19309 RVA: 0x0014A830 File Offset: 0x00148A30
			// (set) Token: 0x06004B6E RID: 19310 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
			public unsafe static Comparison<RTPrefabLib> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RTPrefabLibDb.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RTPrefabLib>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RTPrefabLibDb.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A81 RID: 14977
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003A82 RID: 14978
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x04003A83 RID: 14979
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A84 RID: 14980
			private static readonly IntPtr NativeMethodInfoPtr__SortLibsByName_b__29_0_Internal_Int32_RTPrefabLib_RTPrefabLib_0;
		}

		// Token: 0x0200039C RID: 924
		[ObfuscatedName("RLD.RTPrefabLibDb+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004B6F RID: 19311 RVA: 0x0014A858 File Offset: 0x00148A58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass44_0>.NativeClassPtr);
				RTPrefabLibDb.__c__DisplayClass44_0.NativeFieldInfoPtr_libName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass44_0>.NativeClassPtr, "libName");
				RTPrefabLibDb.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass44_0>.NativeClassPtr, 100668183);
				RTPrefabLibDb.__c__DisplayClass44_0.NativeMethodInfoPtr__GetLibIndex_b__0_Internal_Boolean_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass44_0>.NativeClassPtr, 100668184);
			}

			// Token: 0x06004B70 RID: 19312 RVA: 0x0014A8C0 File Offset: 0x00148AC0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B71 RID: 19313 RVA: 0x0014A8FC File Offset: 0x00148AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83949, XrefRangeEnd = 83951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLibIndex_b__0(RTPrefabLib item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.__c__DisplayClass44_0.NativeMethodInfoPtr__GetLibIndex_b__0_Internal_Boolean_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B72 RID: 19314 RVA: 0x0001C406 File Offset: 0x0001A606
			public __c__DisplayClass44_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001977 RID: 6519
			// (get) Token: 0x06004B73 RID: 19315 RVA: 0x0014A94C File Offset: 0x00148B4C
			// (set) Token: 0x06004B74 RID: 19316 RVA: 0x0001C40F File Offset: 0x0001A60F
			public unsafe string libName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.__c__DisplayClass44_0.NativeFieldInfoPtr_libName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.__c__DisplayClass44_0.NativeFieldInfoPtr_libName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003A85 RID: 14981
			private static readonly IntPtr NativeFieldInfoPtr_libName;

			// Token: 0x04003A86 RID: 14982
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A87 RID: 14983
			private static readonly IntPtr NativeMethodInfoPtr__GetLibIndex_b__0_Internal_Boolean_RTPrefabLib_0;
		}

		// Token: 0x0200039D RID: 925
		[ObfuscatedName("RLD.RTPrefabLibDb+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004B75 RID: 19317 RVA: 0x0014A974 File Offset: 0x00148B74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabLibDb>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass47_0>.NativeClassPtr);
				RTPrefabLibDb.__c__DisplayClass47_0.NativeFieldInfoPtr_libName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass47_0>.NativeClassPtr, "libName");
				RTPrefabLibDb.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass47_0>.NativeClassPtr, 100668185);
				RTPrefabLibDb.__c__DisplayClass47_0.NativeMethodInfoPtr__GetLib_b__0_Internal_Boolean_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass47_0>.NativeClassPtr, 100668186);
			}

			// Token: 0x06004B76 RID: 19318 RVA: 0x0014A9DC File Offset: 0x00148BDC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabLibDb.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B77 RID: 19319 RVA: 0x0014AA18 File Offset: 0x00148C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLib_b__0(RTPrefabLib item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDb.__c__DisplayClass47_0.NativeMethodInfoPtr__GetLib_b__0_Internal_Boolean_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B78 RID: 19320 RVA: 0x0001C42E File Offset: 0x0001A62E
			public __c__DisplayClass47_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001978 RID: 6520
			// (get) Token: 0x06004B79 RID: 19321 RVA: 0x0014AA68 File Offset: 0x00148C68
			// (set) Token: 0x06004B7A RID: 19322 RVA: 0x0001C437 File Offset: 0x0001A637
			public unsafe string libName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.__c__DisplayClass47_0.NativeFieldInfoPtr_libName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDb.__c__DisplayClass47_0.NativeFieldInfoPtr_libName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003A88 RID: 14984
			private static readonly IntPtr NativeFieldInfoPtr_libName;

			// Token: 0x04003A89 RID: 14985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A8A RID: 14986
			private static readonly IntPtr NativeMethodInfoPtr__GetLib_b__0_Internal_Boolean_RTPrefabLib_0;
		}
	}
}
