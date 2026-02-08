using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RLD
{
	// Token: 0x020001A2 RID: 418
	public class RTPrefabScrollView : MonoBehaviour
	{
		// Token: 0x0600203C RID: 8252 RVA: 0x000A1C9C File Offset: 0x0009FE9C
		// Note: this type is marked as 'beforefieldinit'.
		static RTPrefabScrollView()
		{
			Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTPrefabScrollView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr);
			RTPrefabScrollView.NativeFieldInfoPtr_PrefabPreviewClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "PrefabPreviewClicked");
			RTPrefabScrollView.NativeFieldInfoPtr_PrefabPreviewHoverEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "PrefabPreviewHoverEnter");
			RTPrefabScrollView.NativeFieldInfoPtr_PrefabPreviewHoverExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "PrefabPreviewHoverExit");
			RTPrefabScrollView.NativeFieldInfoPtr__previewButtonPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "_previewButtonPool");
			RTPrefabScrollView.NativeFieldInfoPtr__gridObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "_gridObject");
			RTPrefabScrollView.NativeFieldInfoPtr__gridLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "_gridLayoutGroup");
			RTPrefabScrollView.NativeFieldInfoPtr__activePreviewButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "_activePreviewButtons");
			RTPrefabScrollView.NativeFieldInfoPtr__prefabSearchNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "_prefabSearchNames");
			RTPrefabScrollView.NativeFieldInfoPtr__prefabSearchMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "_prefabSearchMatches");
			RTPrefabScrollView.NativeMethodInfoPtr_add_PrefabPreviewClicked_Public_add_Void_PrefabPreviewClickedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668217);
			RTPrefabScrollView.NativeMethodInfoPtr_remove_PrefabPreviewClicked_Public_rem_Void_PrefabPreviewClickedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668218);
			RTPrefabScrollView.NativeMethodInfoPtr_add_PrefabPreviewHoverEnter_Public_add_Void_PrefabPreviewHoverEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668219);
			RTPrefabScrollView.NativeMethodInfoPtr_remove_PrefabPreviewHoverEnter_Public_rem_Void_PrefabPreviewHoverEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668220);
			RTPrefabScrollView.NativeMethodInfoPtr_add_PrefabPreviewHoverExit_Public_add_Void_PrefabPreviewHoverExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668221);
			RTPrefabScrollView.NativeMethodInfoPtr_remove_PrefabPreviewHoverExit_Public_rem_Void_PrefabPreviewHoverExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668222);
			RTPrefabScrollView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668232);
			RTPrefabScrollView.NativeMethodInfoPtr_AddPrefabPreview_Public_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668223);
			RTPrefabScrollView.NativeMethodInfoPtr_FilterPrefabsByName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668224);
			RTPrefabScrollView.NativeMethodInfoPtr_ClearPreviews_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668225);
			RTPrefabScrollView.NativeMethodInfoPtr_SyncWithLib_Public_Void_RTPrefabLib_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668226);
			RTPrefabScrollView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668227);
			RTPrefabScrollView.NativeMethodInfoPtr_prefabNames_Private_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668228);
			RTPrefabScrollView.NativeMethodInfoPtr_OnPreviewButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668229);
			RTPrefabScrollView.NativeMethodInfoPtr_OnPrefabPreviewHoverEnter_Private_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668230);
			RTPrefabScrollView.NativeMethodInfoPtr_OnPrefabPreviewHoverExit_Private_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, 100668231);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000A1EC0 File Offset: 0x000A00C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84535, RefRangeEnd = 84536, XrefRangeStart = 84531, XrefRangeEnd = 84535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PrefabPreviewClicked(RTPrefabScrollView.PrefabPreviewClickedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_add_PrefabPreviewClicked_Public_add_Void_PrefabPreviewClickedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000A1F04 File Offset: 0x000A0104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84536, XrefRangeEnd = 84540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PrefabPreviewClicked(RTPrefabScrollView.PrefabPreviewClickedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_remove_PrefabPreviewClicked_Public_rem_Void_PrefabPreviewClickedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x000A1F48 File Offset: 0x000A0148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84544, RefRangeEnd = 84545, XrefRangeStart = 84540, XrefRangeEnd = 84544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PrefabPreviewHoverEnter(RTPrefabScrollView.PrefabPreviewHoverEnterHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_add_PrefabPreviewHoverEnter_Public_add_Void_PrefabPreviewHoverEnterHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000A1F8C File Offset: 0x000A018C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84545, XrefRangeEnd = 84549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PrefabPreviewHoverEnter(RTPrefabScrollView.PrefabPreviewHoverEnterHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_remove_PrefabPreviewHoverEnter_Public_rem_Void_PrefabPreviewHoverEnterHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x000A1FD0 File Offset: 0x000A01D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84553, RefRangeEnd = 84554, XrefRangeStart = 84549, XrefRangeEnd = 84553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PrefabPreviewHoverExit(RTPrefabScrollView.PrefabPreviewHoverExitHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_add_PrefabPreviewHoverExit_Public_add_Void_PrefabPreviewHoverExitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x000A2014 File Offset: 0x000A0214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84554, XrefRangeEnd = 84558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PrefabPreviewHoverExit(RTPrefabScrollView.PrefabPreviewHoverExitHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_remove_PrefabPreviewHoverExit_Public_rem_Void_PrefabPreviewHoverExitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000A2058 File Offset: 0x000A0258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84558, XrefRangeEnd = 84578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefabScrollView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000A2094 File Offset: 0x000A0294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84644, RefRangeEnd = 84646, XrefRangeStart = 84578, XrefRangeEnd = 84644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPrefabPreview(RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_AddPrefabPreview_Public_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000A20D8 File Offset: 0x000A02D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84681, RefRangeEnd = 84683, XrefRangeStart = 84646, XrefRangeEnd = 84681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterPrefabsByName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_FilterPrefabsByName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000A211C File Offset: 0x000A031C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84687, RefRangeEnd = 84689, XrefRangeStart = 84683, XrefRangeEnd = 84687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPreviews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_ClearPreviews_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000A2150 File Offset: 0x000A0350
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 84696, RefRangeEnd = 84701, XrefRangeStart = 84689, XrefRangeEnd = 84696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncWithLib(RTPrefabLib prefabLib)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefabLib);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_SyncWithLib_Public_Void_RTPrefabLib_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000A2194 File Offset: 0x000A0394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84701, XrefRangeEnd = 84722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000A21C8 File Offset: 0x000A03C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84744, RefRangeEnd = 84745, XrefRangeStart = 84722, XrefRangeEnd = 84744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void prefabNames(List<string> names)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_prefabNames_Private_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000A220C File Offset: 0x000A040C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84745, XrefRangeEnd = 84776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreviewButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_OnPreviewButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x000A2240 File Offset: 0x000A0440
		[CallerCount(0)]
		public unsafe void OnPrefabPreviewHoverEnter(RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_OnPrefabPreviewHoverEnter_Private_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000A2284 File Offset: 0x000A0484
		[CallerCount(0)]
		public unsafe void OnPrefabPreviewHoverExit(RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.NativeMethodInfoPtr_OnPrefabPreviewHoverExit_Private_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0000D127 File Offset: 0x0000B327
		public RTPrefabScrollView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x000A22C8 File Offset: 0x000A04C8
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x0000D130 File Offset: 0x0000B330
		public unsafe RTPrefabScrollView.PrefabPreviewClickedHandler PrefabPreviewClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr_PrefabPreviewClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefabScrollView.PrefabPreviewClickedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr_PrefabPreviewClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x000A22F8 File Offset: 0x000A04F8
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x0000D14F File Offset: 0x0000B34F
		public unsafe RTPrefabScrollView.PrefabPreviewHoverEnterHandler PrefabPreviewHoverEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr_PrefabPreviewHoverEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr_PrefabPreviewHoverEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x000A2328 File Offset: 0x000A0528
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x0000D16E File Offset: 0x0000B36E
		public unsafe RTPrefabScrollView.PrefabPreviewHoverExitHandler PrefabPreviewHoverExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr_PrefabPreviewHoverExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTPrefabScrollView.PrefabPreviewHoverExitHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr_PrefabPreviewHoverExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x000A2358 File Offset: 0x000A0558
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x0000D18D File Offset: 0x0000B38D
		public unsafe ObjectPool _previewButtonPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__previewButtonPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__previewButtonPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x000A2388 File Offset: 0x000A0588
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x0000D1AC File Offset: 0x0000B3AC
		public unsafe GameObject _gridObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__gridObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__gridObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x000A23B8 File Offset: 0x000A05B8
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x0000D1CB File Offset: 0x0000B3CB
		public unsafe GridLayoutGroup _gridLayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__gridLayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__gridLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x000A23E8 File Offset: 0x000A05E8
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x0000D1EA File Offset: 0x0000B3EA
		public unsafe List<RTPrefabPreviewButton> _activePreviewButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__activePreviewButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RTPrefabPreviewButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__activePreviewButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x000A2418 File Offset: 0x000A0618
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x0000D209 File Offset: 0x0000B409
		public unsafe List<string> _prefabSearchNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__prefabSearchNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__prefabSearchNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x000A2448 File Offset: 0x000A0648
		// (set) Token: 0x0600205F RID: 8287 RVA: 0x0000D228 File Offset: 0x0000B428
		public unsafe List<string> _prefabSearchMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__prefabSearchMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabScrollView.NativeFieldInfoPtr__prefabSearchMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeFieldInfoPtr_PrefabPreviewClicked;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeFieldInfoPtr_PrefabPreviewHoverEnter;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeFieldInfoPtr_PrefabPreviewHoverExit;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeFieldInfoPtr__previewButtonPool;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeFieldInfoPtr__gridObject;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeFieldInfoPtr__gridLayoutGroup;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeFieldInfoPtr__activePreviewButtons;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeFieldInfoPtr__prefabSearchNames;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeFieldInfoPtr__prefabSearchMatches;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeMethodInfoPtr_add_PrefabPreviewClicked_Public_add_Void_PrefabPreviewClickedHandler_0;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeMethodInfoPtr_remove_PrefabPreviewClicked_Public_rem_Void_PrefabPreviewClickedHandler_0;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_add_PrefabPreviewHoverEnter_Public_add_Void_PrefabPreviewHoverEnterHandler_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_remove_PrefabPreviewHoverEnter_Public_rem_Void_PrefabPreviewHoverEnterHandler_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_add_PrefabPreviewHoverExit_Public_add_Void_PrefabPreviewHoverExitHandler_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_remove_PrefabPreviewHoverExit_Public_rem_Void_PrefabPreviewHoverExitHandler_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr_AddPrefabPreview_Public_Void_RTPrefab_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr_FilterPrefabsByName_Public_Void_String_0;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_ClearPreviews_Public_Void_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr_SyncWithLib_Public_Void_RTPrefabLib_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_prefabNames_Private_Void_List_1_String_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_OnPreviewButtonClicked_Private_Void_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabPreviewHoverEnter_Private_Void_RTPrefab_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_OnPrefabPreviewHoverExit_Private_Void_RTPrefab_0;

		// Token: 0x020003A0 RID: 928
		public sealed class PrefabPreviewClickedHandler : MulticastDelegate
		{
			// Token: 0x06004B8D RID: 19341 RVA: 0x0014AE28 File Offset: 0x00149028
			// Note: this type is marked as 'beforefieldinit'.
			static PrefabPreviewClickedHandler()
			{
				Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewClickedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "PrefabPreviewClickedHandler");
				RTPrefabScrollView.PrefabPreviewClickedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewClickedHandler>.NativeClassPtr, 100668233);
				RTPrefabScrollView.PrefabPreviewClickedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewClickedHandler>.NativeClassPtr, 100668234);
				RTPrefabScrollView.PrefabPreviewClickedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewClickedHandler>.NativeClassPtr, 100668235);
				RTPrefabScrollView.PrefabPreviewClickedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewClickedHandler>.NativeClassPtr, 100668236);
			}

			// Token: 0x06004B8E RID: 19342 RVA: 0x0014AE9C File Offset: 0x0014909C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrefabPreviewClickedHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewClickedHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewClickedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B8F RID: 19343 RVA: 0x0014AEF8 File Offset: 0x001490F8
			[CallerCount(0)]
			public unsafe void Invoke(RTPrefab prefab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewClickedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B90 RID: 19344 RVA: 0x0014AF3C File Offset: 0x0014913C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewClickedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004B91 RID: 19345 RVA: 0x0014AFB0 File Offset: 0x001491B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewClickedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B92 RID: 19346 RVA: 0x0001C4B6 File Offset: 0x0001A6B6
			public PrefabPreviewClickedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004B93 RID: 19347 RVA: 0x0001C4BF File Offset: 0x0001A6BF
			public static implicit operator RTPrefabScrollView.PrefabPreviewClickedHandler(Action<RTPrefab> A_0)
			{
				return DelegateSupport.ConvertDelegate<RTPrefabScrollView.PrefabPreviewClickedHandler>(A_0);
			}

			// Token: 0x06004B94 RID: 19348 RVA: 0x0001C4C7 File Offset: 0x0001A6C7
			public static RTPrefabScrollView.PrefabPreviewClickedHandler operator +(RTPrefabScrollView.PrefabPreviewClickedHandler A_0, RTPrefabScrollView.PrefabPreviewClickedHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RTPrefabScrollView.PrefabPreviewClickedHandler>();
			}

			// Token: 0x06004B95 RID: 19349 RVA: 0x0001C4D5 File Offset: 0x0001A6D5
			public static RTPrefabScrollView.PrefabPreviewClickedHandler operator -(RTPrefabScrollView.PrefabPreviewClickedHandler A_0, RTPrefabScrollView.PrefabPreviewClickedHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RTPrefabScrollView.PrefabPreviewClickedHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003A93 RID: 14995
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003A94 RID: 14996
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0;

			// Token: 0x04003A95 RID: 14997
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0;

			// Token: 0x04003A96 RID: 14998
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003A1 RID: 929
		public sealed class PrefabPreviewHoverEnterHandler : MulticastDelegate
		{
			// Token: 0x06004B96 RID: 19350 RVA: 0x0014AFF4 File Offset: 0x001491F4
			// Note: this type is marked as 'beforefieldinit'.
			static PrefabPreviewHoverEnterHandler()
			{
				Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "PrefabPreviewHoverEnterHandler");
				RTPrefabScrollView.PrefabPreviewHoverEnterHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>.NativeClassPtr, 100668237);
				RTPrefabScrollView.PrefabPreviewHoverEnterHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>.NativeClassPtr, 100668238);
				RTPrefabScrollView.PrefabPreviewHoverEnterHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>.NativeClassPtr, 100668239);
				RTPrefabScrollView.PrefabPreviewHoverEnterHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>.NativeClassPtr, 100668240);
			}

			// Token: 0x06004B97 RID: 19351 RVA: 0x0014B068 File Offset: 0x00149268
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrefabPreviewHoverEnterHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewHoverEnterHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B98 RID: 19352 RVA: 0x0014B0C4 File Offset: 0x001492C4
			[CallerCount(0)]
			public unsafe void Invoke(RTPrefab prefab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewHoverEnterHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B99 RID: 19353 RVA: 0x0014B108 File Offset: 0x00149308
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewHoverEnterHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004B9A RID: 19354 RVA: 0x0014B17C File Offset: 0x0014937C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewHoverEnterHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B9B RID: 19355 RVA: 0x0001C4E6 File Offset: 0x0001A6E6
			public PrefabPreviewHoverEnterHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004B9C RID: 19356 RVA: 0x0001C4EF File Offset: 0x0001A6EF
			public static implicit operator RTPrefabScrollView.PrefabPreviewHoverEnterHandler(Action<RTPrefab> A_0)
			{
				return DelegateSupport.ConvertDelegate<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>(A_0);
			}

			// Token: 0x06004B9D RID: 19357 RVA: 0x0001C4F7 File Offset: 0x0001A6F7
			public static RTPrefabScrollView.PrefabPreviewHoverEnterHandler operator +(RTPrefabScrollView.PrefabPreviewHoverEnterHandler A_0, RTPrefabScrollView.PrefabPreviewHoverEnterHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>();
			}

			// Token: 0x06004B9E RID: 19358 RVA: 0x0001C505 File Offset: 0x0001A705
			public static RTPrefabScrollView.PrefabPreviewHoverEnterHandler operator -(RTPrefabScrollView.PrefabPreviewHoverEnterHandler A_0, RTPrefabScrollView.PrefabPreviewHoverEnterHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RTPrefabScrollView.PrefabPreviewHoverEnterHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003A97 RID: 14999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003A98 RID: 15000
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0;

			// Token: 0x04003A99 RID: 15001
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0;

			// Token: 0x04003A9A RID: 15002
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003A2 RID: 930
		public sealed class PrefabPreviewHoverExitHandler : MulticastDelegate
		{
			// Token: 0x06004B9F RID: 19359 RVA: 0x0014B1C0 File Offset: 0x001493C0
			// Note: this type is marked as 'beforefieldinit'.
			static PrefabPreviewHoverExitHandler()
			{
				Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverExitHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabScrollView>.NativeClassPtr, "PrefabPreviewHoverExitHandler");
				RTPrefabScrollView.PrefabPreviewHoverExitHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverExitHandler>.NativeClassPtr, 100668241);
				RTPrefabScrollView.PrefabPreviewHoverExitHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverExitHandler>.NativeClassPtr, 100668242);
				RTPrefabScrollView.PrefabPreviewHoverExitHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverExitHandler>.NativeClassPtr, 100668243);
				RTPrefabScrollView.PrefabPreviewHoverExitHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverExitHandler>.NativeClassPtr, 100668244);
			}

			// Token: 0x06004BA0 RID: 19360 RVA: 0x0014B234 File Offset: 0x00149434
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 59694, RefRangeEnd = 59767, XrefRangeStart = 59694, XrefRangeEnd = 59767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrefabPreviewHoverExitHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabScrollView.PrefabPreviewHoverExitHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewHoverExitHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BA1 RID: 19361 RVA: 0x0014B290 File Offset: 0x00149490
			[CallerCount(0)]
			public unsafe void Invoke(RTPrefab prefab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewHoverExitHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004BA2 RID: 19362 RVA: 0x0014B2D4 File Offset: 0x001494D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23449, RefRangeEnd = 23450, XrefRangeStart = 23449, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewHoverExitHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004BA3 RID: 19363 RVA: 0x0014B348 File Offset: 0x00149548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabScrollView.PrefabPreviewHoverExitHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004BA4 RID: 19364 RVA: 0x0001C516 File Offset: 0x0001A716
			public PrefabPreviewHoverExitHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004BA5 RID: 19365 RVA: 0x0001C51F File Offset: 0x0001A71F
			public static implicit operator RTPrefabScrollView.PrefabPreviewHoverExitHandler(Action<RTPrefab> A_0)
			{
				return DelegateSupport.ConvertDelegate<RTPrefabScrollView.PrefabPreviewHoverExitHandler>(A_0);
			}

			// Token: 0x06004BA6 RID: 19366 RVA: 0x0001C527 File Offset: 0x0001A727
			public static RTPrefabScrollView.PrefabPreviewHoverExitHandler operator +(RTPrefabScrollView.PrefabPreviewHoverExitHandler A_0, RTPrefabScrollView.PrefabPreviewHoverExitHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RTPrefabScrollView.PrefabPreviewHoverExitHandler>();
			}

			// Token: 0x06004BA7 RID: 19367 RVA: 0x0001C535 File Offset: 0x0001A735
			public static RTPrefabScrollView.PrefabPreviewHoverExitHandler operator -(RTPrefabScrollView.PrefabPreviewHoverExitHandler A_0, RTPrefabScrollView.PrefabPreviewHoverExitHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RTPrefabScrollView.PrefabPreviewHoverExitHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003A9B RID: 15003
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003A9C RID: 15004
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RTPrefab_0;

			// Token: 0x04003A9D RID: 15005
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RTPrefab_AsyncCallback_Object_0;

			// Token: 0x04003A9E RID: 15006
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
