using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001A0 RID: 416
	public class RTPrefabLibDbUI : MonoBehaviour
	{
		// Token: 0x06002012 RID: 8210 RVA: 0x000A12DC File Offset: 0x0009F4DC
		// Note: this type is marked as 'beforefieldinit'.
		static RTPrefabLibDbUI()
		{
			Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTPrefabLibDbUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr);
			RTPrefabLibDbUI.NativeFieldInfoPtr__activeLibDropDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, "_activeLibDropDown");
			RTPrefabLibDbUI.NativeFieldInfoPtr__prefabScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, "_prefabScrollView");
			RTPrefabLibDbUI.NativeFieldInfoPtr__hoveredPrefabNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, "_hoveredPrefabNameLabel");
			RTPrefabLibDbUI.NativeFieldInfoPtr__prefabSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, "_prefabSearch");
			RTPrefabLibDbUI.NativeMethodInfoPtr_get_ActiveLibDropDown_Public_get_RTActiveLibDropDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668187);
			RTPrefabLibDbUI.NativeMethodInfoPtr_get_PrefabScrollView_Public_get_RTPrefabScrollView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668188);
			RTPrefabLibDbUI.NativeMethodInfoPtr_get_HoveredPrefabNameLabel_Public_get_RTHoveredPrefabNameLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668189);
			RTPrefabLibDbUI.NativeMethodInfoPtr_get_PrefabSearch_Public_get_RTPrefabSearch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668190);
			RTPrefabLibDbUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668195);
			RTPrefabLibDbUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668191);
			RTPrefabLibDbUI.NativeMethodInfoPtr_OnPrefabPreviewHoverEnter_Private_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668192);
			RTPrefabLibDbUI.NativeMethodInfoPtr_OnPrefabPreviewHoverExit_Private_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668193);
			RTPrefabLibDbUI.NativeMethodInfoPtr_OnPrefabSearchFieldValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668194);
			RTPrefabLibDbUI.NativeMethodInfoPtr__Awake_b__12_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr, 100668196);
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x000A1424 File Offset: 0x0009F624
		public unsafe RTActiveLibDropDown ActiveLibDropDown
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr_get_ActiveLibDropDown_Public_get_RTActiveLibDropDown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTActiveLibDropDown>(intPtr3) : null;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x000A1464 File Offset: 0x0009F664
		public unsafe RTPrefabScrollView PrefabScrollView
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr_get_PrefabScrollView_Public_get_RTPrefabScrollView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefabScrollView>(intPtr3) : null;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x000A14A4 File Offset: 0x0009F6A4
		public unsafe RTHoveredPrefabNameLabel HoveredPrefabNameLabel
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr_get_HoveredPrefabNameLabel_Public_get_RTHoveredPrefabNameLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHoveredPrefabNameLabel>(intPtr3) : null;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x000A14E4 File Offset: 0x0009F6E4
		public unsafe RTPrefabSearch PrefabSearch
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr_get_PrefabSearch_Public_get_RTPrefabSearch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefabSearch>(intPtr3) : null;
			}
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000A1524 File Offset: 0x0009F724
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefabLibDbUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabLibDbUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000A1560 File Offset: 0x0009F760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84438, XrefRangeEnd = 84482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000A1594 File Offset: 0x0009F794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84482, XrefRangeEnd = 84489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrefabPreviewHoverEnter(RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr_OnPrefabPreviewHoverEnter_Private_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000A15D8 File Offset: 0x0009F7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84489, XrefRangeEnd = 84490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrefabPreviewHoverExit(RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr_OnPrefabPreviewHoverExit_Private_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x000A161C File Offset: 0x0009F81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84490, XrefRangeEnd = 84492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrefabSearchFieldValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr_OnPrefabSearchFieldValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000A1660 File Offset: 0x0009F860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__12_0(string p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLibDbUI.NativeMethodInfoPtr__Awake_b__12_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0000D01D File Offset: 0x0000B21D
		public RTPrefabLibDbUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x000A16A4 File Offset: 0x0009F8A4
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x0000D026 File Offset: 0x0000B226
		public unsafe RTActiveLibDropDown _activeLibDropDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDbUI.NativeFieldInfoPtr__activeLibDropDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTActiveLibDropDown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDbUI.NativeFieldInfoPtr__activeLibDropDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x000A16D4 File Offset: 0x0009F8D4
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x0000D045 File Offset: 0x0000B245
		public unsafe RTPrefabScrollView _prefabScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDbUI.NativeFieldInfoPtr__prefabScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefabScrollView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDbUI.NativeFieldInfoPtr__prefabScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x000A1704 File Offset: 0x0009F904
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x0000D064 File Offset: 0x0000B264
		public unsafe RTHoveredPrefabNameLabel _hoveredPrefabNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDbUI.NativeFieldInfoPtr__hoveredPrefabNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHoveredPrefabNameLabel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDbUI.NativeFieldInfoPtr__hoveredPrefabNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x000A1734 File Offset: 0x0009F934
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x0000D083 File Offset: 0x0000B283
		public unsafe RTPrefabSearch _prefabSearch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDbUI.NativeFieldInfoPtr__prefabSearch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefabSearch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLibDbUI.NativeFieldInfoPtr__prefabSearch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeFieldInfoPtr__activeLibDropDown;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeFieldInfoPtr__prefabScrollView;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeFieldInfoPtr__hoveredPrefabNameLabel;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeFieldInfoPtr__prefabSearch;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveLibDropDown_Public_get_RTActiveLibDropDown_0;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabScrollView_Public_get_RTPrefabScrollView_0;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredPrefabNameLabel_Public_get_RTHoveredPrefabNameLabel_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabSearch_Public_get_RTPrefabSearch_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabPreviewHoverEnter_Private_Void_RTPrefab_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabPreviewHoverExit_Private_Void_RTPrefab_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabSearchFieldValueChanged_Private_Void_String_0;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__12_0_Private_Void_String_0;
	}
}
