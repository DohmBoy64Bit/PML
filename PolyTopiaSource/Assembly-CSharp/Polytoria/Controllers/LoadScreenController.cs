using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x02000330 RID: 816
	public class LoadScreenController : MonoBehaviour
	{
		// Token: 0x060045EF RID: 17903 RVA: 0x00137FA8 File Offset: 0x001361A8
		// Note: this type is marked as 'beforefieldinit'.
		static LoadScreenController()
		{
			Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "LoadScreenController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr);
			LoadScreenController.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, "singleton");
			LoadScreenController.NativeFieldInfoPtr_progressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, "progressBar");
			LoadScreenController.NativeFieldInfoPtr_progressBarContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, "progressBarContainer");
			LoadScreenController.NativeFieldInfoPtr_gameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, "gameName");
			LoadScreenController.NativeFieldInfoPtr_loadingStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, "loadingStatus");
			LoadScreenController.NativeFieldInfoPtr__IsLoadingMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, "<IsLoadingMap>k__BackingField");
			LoadScreenController.NativeMethodInfoPtr_get_IsLoadingMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, 100674369);
			LoadScreenController.NativeMethodInfoPtr_set_IsLoadingMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, 100674370);
			LoadScreenController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, 100674377);
			LoadScreenController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, 100674371);
			LoadScreenController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, 100674372);
			LoadScreenController.NativeMethodInfoPtr_GameLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, 100674373);
			LoadScreenController.NativeMethodInfoPtr_SetStatus_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, 100674374);
			LoadScreenController.NativeMethodInfoPtr_SetGameInfo_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, 100674375);
			LoadScreenController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr, 100674376);
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x060045F0 RID: 17904 RVA: 0x00138104 File Offset: 0x00136304
		// (set) Token: 0x060045F1 RID: 17905 RVA: 0x00138140 File Offset: 0x00136340
		public unsafe bool IsLoadingMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadScreenController.NativeMethodInfoPtr_get_IsLoadingMap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadScreenController.NativeMethodInfoPtr_set_IsLoadingMap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00138180 File Offset: 0x00136380
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadScreenController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadScreenController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadScreenController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x001381BC File Offset: 0x001363BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135231, XrefRangeEnd = 135235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadScreenController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x001381F0 File Offset: 0x001363F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135235, XrefRangeEnd = 135253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadScreenController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x00138224 File Offset: 0x00136424
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135256, RefRangeEnd = 135258, XrefRangeStart = 135253, XrefRangeEnd = 135256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadScreenController.NativeMethodInfoPtr_GameLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x00138258 File Offset: 0x00136458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135259, RefRangeEnd = 135261, XrefRangeStart = 135258, XrefRangeEnd = 135259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatus(string status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadScreenController.NativeMethodInfoPtr_SetStatus_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x0013829C File Offset: 0x0013649C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135261, XrefRangeEnd = 135262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameInfo(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadScreenController.NativeMethodInfoPtr_SetGameInfo_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x001382E0 File Offset: 0x001364E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135262, XrefRangeEnd = 135282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadScreenController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00019DAD File Offset: 0x00017FAD
		public LoadScreenController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x00138314 File Offset: 0x00136514
		// (set) Token: 0x060045FB RID: 17915 RVA: 0x00019DB6 File Offset: 0x00017FB6
		public unsafe static LoadScreenController singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadScreenController.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadScreenController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadScreenController.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x060045FC RID: 17916 RVA: 0x0013833C File Offset: 0x0013653C
		// (set) Token: 0x060045FD RID: 17917 RVA: 0x00019DC8 File Offset: 0x00017FC8
		public unsafe Image progressBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr_progressBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr_progressBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x060045FE RID: 17918 RVA: 0x0013836C File Offset: 0x0013656C
		// (set) Token: 0x060045FF RID: 17919 RVA: 0x00019DE7 File Offset: 0x00017FE7
		public unsafe GameObject progressBarContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr_progressBarContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr_progressBarContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06004600 RID: 17920 RVA: 0x0013839C File Offset: 0x0013659C
		// (set) Token: 0x06004601 RID: 17921 RVA: 0x00019E06 File Offset: 0x00018006
		public unsafe TMP_Text gameName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr_gameName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr_gameName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06004602 RID: 17922 RVA: 0x001383CC File Offset: 0x001365CC
		// (set) Token: 0x06004603 RID: 17923 RVA: 0x00019E25 File Offset: 0x00018025
		public unsafe TMP_Text loadingStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr_loadingStatus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr_loadingStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06004604 RID: 17924 RVA: 0x001383FC File Offset: 0x001365FC
		// (set) Token: 0x06004605 RID: 17925 RVA: 0x00019E44 File Offset: 0x00018044
		public unsafe bool _IsLoadingMap_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr__IsLoadingMap_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadScreenController.NativeFieldInfoPtr__IsLoadingMap_k__BackingField)) = value;
			}
		}

		// Token: 0x0400364B RID: 13899
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x0400364C RID: 13900
		private static readonly IntPtr NativeFieldInfoPtr_progressBar;

		// Token: 0x0400364D RID: 13901
		private static readonly IntPtr NativeFieldInfoPtr_progressBarContainer;

		// Token: 0x0400364E RID: 13902
		private static readonly IntPtr NativeFieldInfoPtr_gameName;

		// Token: 0x0400364F RID: 13903
		private static readonly IntPtr NativeFieldInfoPtr_loadingStatus;

		// Token: 0x04003650 RID: 13904
		private static readonly IntPtr NativeFieldInfoPtr__IsLoadingMap_k__BackingField;

		// Token: 0x04003651 RID: 13905
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoadingMap_Public_get_Boolean_0;

		// Token: 0x04003652 RID: 13906
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLoadingMap_Public_set_Void_Boolean_0;

		// Token: 0x04003653 RID: 13907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003654 RID: 13908
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003655 RID: 13909
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003656 RID: 13910
		private static readonly IntPtr NativeMethodInfoPtr_GameLoaded_Public_Void_0;

		// Token: 0x04003657 RID: 13911
		private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Public_Void_String_0;

		// Token: 0x04003658 RID: 13912
		private static readonly IntPtr NativeMethodInfoPtr_SetGameInfo_Public_Void_String_0;

		// Token: 0x04003659 RID: 13913
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
	}
}
