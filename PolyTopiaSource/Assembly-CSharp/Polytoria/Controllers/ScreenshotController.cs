using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x02000337 RID: 823
	public class ScreenshotController : MonoBehaviour
	{
		// Token: 0x06004663 RID: 18019 RVA: 0x001398B8 File Offset: 0x00137AB8
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotController()
		{
			Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "ScreenshotController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr);
			ScreenshotController.NativeFieldInfoPtr__instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "<instance>k__BackingField");
			ScreenshotController.NativeFieldInfoPtr_toast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "toast");
			ScreenshotController.NativeFieldInfoPtr_publishModal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "publishModal");
			ScreenshotController.NativeFieldInfoPtr_captionInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "captionInput");
			ScreenshotController.NativeFieldInfoPtr_publishButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "publishButton");
			ScreenshotController.NativeFieldInfoPtr_publishError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "publishError");
			ScreenshotController.NativeFieldInfoPtr_toastDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "toastDuration");
			ScreenshotController.NativeFieldInfoPtr_toastTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "toastTimer");
			ScreenshotController.NativeFieldInfoPtr_toastActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "toastActive");
			ScreenshotController.NativeFieldInfoPtr_screenshotPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "screenshotPath");
			ScreenshotController.NativeFieldInfoPtr_lastScreenshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "lastScreenshot");
			ScreenshotController.NativeFieldInfoPtr_passphrase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "passphrase");
			ScreenshotController.NativeFieldInfoPtr_screenshotBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "screenshotBytes");
			ScreenshotController.NativeMethodInfoPtr_get_instance_Public_Static_get_ScreenshotController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674441);
			ScreenshotController.NativeMethodInfoPtr_set_instance_Private_Static_set_Void_ScreenshotController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674442);
			ScreenshotController.NativeMethodInfoPtr_get_Focused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674443);
			ScreenshotController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674454);
			ScreenshotController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674444);
			ScreenshotController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674445);
			ScreenshotController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674446);
			ScreenshotController.NativeMethodInfoPtr_HideToast_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674447);
			ScreenshotController.NativeMethodInfoPtr_ShowToast_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674448);
			ScreenshotController.NativeMethodInfoPtr_Screenshot_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674449);
			ScreenshotController.NativeMethodInfoPtr_DoScreenshot_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674450);
			ScreenshotController.NativeMethodInfoPtr_OpenScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674451);
			ScreenshotController.NativeMethodInfoPtr_PublishScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674452);
			ScreenshotController.NativeMethodInfoPtr_DoPublishScreenshot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674453);
			ScreenshotController.NativeMethodInfoPtr__Start_b__19_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, 100674455);
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x00139B18 File Offset: 0x00137D18
		// (set) Token: 0x06004665 RID: 18021 RVA: 0x00139B4C File Offset: 0x00137D4C
		public unsafe static ScreenshotController instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136569, XrefRangeEnd = 136571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_get_instance_Public_Static_get_ScreenshotController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScreenshotController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136571, XrefRangeEnd = 136575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_set_instance_Private_Static_set_Void_ScreenshotController_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06004666 RID: 18022 RVA: 0x00139B84 File Offset: 0x00137D84
		public unsafe bool Focused
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 136579, RefRangeEnd = 136580, XrefRangeStart = 136575, XrefRangeEnd = 136579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_get_Focused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00139BC0 File Offset: 0x00137DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136580, XrefRangeEnd = 136588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenshotController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00139BFC File Offset: 0x00137DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136588, XrefRangeEnd = 136592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x00139C30 File Offset: 0x00137E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136592, XrefRangeEnd = 136610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x00139C64 File Offset: 0x00137E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136610, XrefRangeEnd = 136619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x00139C98 File Offset: 0x00137E98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136630, RefRangeEnd = 136632, XrefRangeStart = 136619, XrefRangeEnd = 136630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideToast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_HideToast_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x00139CCC File Offset: 0x00137ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136647, RefRangeEnd = 136648, XrefRangeStart = 136632, XrefRangeEnd = 136647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowToast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_ShowToast_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00139D00 File Offset: 0x00137F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136648, XrefRangeEnd = 136655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Screenshot(bool hideUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hideUI;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_Screenshot_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x00139D40 File Offset: 0x00137F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136655, XrefRangeEnd = 136660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoScreenshot(bool hideUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hideUI;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_DoScreenshot_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00139D8C File Offset: 0x00137F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136660, XrefRangeEnd = 136667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_OpenScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x00139DC0 File Offset: 0x00137FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136667, XrefRangeEnd = 136677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PublishScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_PublishScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x00139DF4 File Offset: 0x00137FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136677, XrefRangeEnd = 136682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoPublishScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr_DoPublishScreenshot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x00139E34 File Offset: 0x00138034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136682, XrefRangeEnd = 136699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__19_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController.NativeMethodInfoPtr__Start_b__19_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x0001A0A2 File Offset: 0x000182A2
		public ScreenshotController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x00139E68 File Offset: 0x00138068
		// (set) Token: 0x06004675 RID: 18037 RVA: 0x0001A0AB File Offset: 0x000182AB
		public unsafe static ScreenshotController _instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotController.NativeFieldInfoPtr__instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenshotController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotController.NativeFieldInfoPtr__instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x00139E90 File Offset: 0x00138090
		// (set) Token: 0x06004677 RID: 18039 RVA: 0x0001A0BD File Offset: 0x000182BD
		public unsafe RectTransform toast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_toast);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_toast), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06004678 RID: 18040 RVA: 0x00139EC0 File Offset: 0x001380C0
		// (set) Token: 0x06004679 RID: 18041 RVA: 0x0001A0DC File Offset: 0x000182DC
		public unsafe RectTransform publishModal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_publishModal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_publishModal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x0600467A RID: 18042 RVA: 0x00139EF0 File Offset: 0x001380F0
		// (set) Token: 0x0600467B RID: 18043 RVA: 0x0001A0FB File Offset: 0x000182FB
		public unsafe TMP_InputField captionInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_captionInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_captionInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x0600467C RID: 18044 RVA: 0x00139F20 File Offset: 0x00138120
		// (set) Token: 0x0600467D RID: 18045 RVA: 0x0001A11A File Offset: 0x0001831A
		public unsafe Button publishButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_publishButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_publishButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x0600467E RID: 18046 RVA: 0x00139F50 File Offset: 0x00138150
		// (set) Token: 0x0600467F RID: 18047 RVA: 0x0001A139 File Offset: 0x00018339
		public unsafe TMP_Text publishError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_publishError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_publishError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06004680 RID: 18048 RVA: 0x00139F80 File Offset: 0x00138180
		// (set) Token: 0x06004681 RID: 18049 RVA: 0x0001A158 File Offset: 0x00018358
		public unsafe float toastDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_toastDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_toastDuration)) = value;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06004682 RID: 18050 RVA: 0x00139FA8 File Offset: 0x001381A8
		// (set) Token: 0x06004683 RID: 18051 RVA: 0x0001A173 File Offset: 0x00018373
		public unsafe float toastTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_toastTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_toastTimer)) = value;
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06004684 RID: 18052 RVA: 0x00139FD0 File Offset: 0x001381D0
		// (set) Token: 0x06004685 RID: 18053 RVA: 0x0001A18E File Offset: 0x0001838E
		public unsafe bool toastActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_toastActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_toastActive)) = value;
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x00139FF8 File Offset: 0x001381F8
		// (set) Token: 0x06004687 RID: 18055 RVA: 0x0001A1A9 File Offset: 0x000183A9
		public unsafe string screenshotPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_screenshotPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_screenshotPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x0013A020 File Offset: 0x00138220
		// (set) Token: 0x06004689 RID: 18057 RVA: 0x0001A1C8 File Offset: 0x000183C8
		public unsafe Sprite lastScreenshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_lastScreenshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_lastScreenshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x0013A050 File Offset: 0x00138250
		// (set) Token: 0x0600468B RID: 18059 RVA: 0x0001A1E7 File Offset: 0x000183E7
		public unsafe string passphrase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_passphrase);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_passphrase), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x0013A078 File Offset: 0x00138278
		// (set) Token: 0x0600468D RID: 18061 RVA: 0x0001A206 File Offset: 0x00018406
		public unsafe Il2CppStructArray<byte> screenshotBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_screenshotBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController.NativeFieldInfoPtr_screenshotBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003698 RID: 13976
		private static readonly IntPtr NativeFieldInfoPtr__instance_k__BackingField;

		// Token: 0x04003699 RID: 13977
		private static readonly IntPtr NativeFieldInfoPtr_toast;

		// Token: 0x0400369A RID: 13978
		private static readonly IntPtr NativeFieldInfoPtr_publishModal;

		// Token: 0x0400369B RID: 13979
		private static readonly IntPtr NativeFieldInfoPtr_captionInput;

		// Token: 0x0400369C RID: 13980
		private static readonly IntPtr NativeFieldInfoPtr_publishButton;

		// Token: 0x0400369D RID: 13981
		private static readonly IntPtr NativeFieldInfoPtr_publishError;

		// Token: 0x0400369E RID: 13982
		private static readonly IntPtr NativeFieldInfoPtr_toastDuration;

		// Token: 0x0400369F RID: 13983
		private static readonly IntPtr NativeFieldInfoPtr_toastTimer;

		// Token: 0x040036A0 RID: 13984
		private static readonly IntPtr NativeFieldInfoPtr_toastActive;

		// Token: 0x040036A1 RID: 13985
		private static readonly IntPtr NativeFieldInfoPtr_screenshotPath;

		// Token: 0x040036A2 RID: 13986
		private static readonly IntPtr NativeFieldInfoPtr_lastScreenshot;

		// Token: 0x040036A3 RID: 13987
		private static readonly IntPtr NativeFieldInfoPtr_passphrase;

		// Token: 0x040036A4 RID: 13988
		private static readonly IntPtr NativeFieldInfoPtr_screenshotBytes;

		// Token: 0x040036A5 RID: 13989
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_ScreenshotController_0;

		// Token: 0x040036A6 RID: 13990
		private static readonly IntPtr NativeMethodInfoPtr_set_instance_Private_Static_set_Void_ScreenshotController_0;

		// Token: 0x040036A7 RID: 13991
		private static readonly IntPtr NativeMethodInfoPtr_get_Focused_Public_get_Boolean_0;

		// Token: 0x040036A8 RID: 13992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040036A9 RID: 13993
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040036AA RID: 13994
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040036AB RID: 13995
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040036AC RID: 13996
		private static readonly IntPtr NativeMethodInfoPtr_HideToast_Private_Void_0;

		// Token: 0x040036AD RID: 13997
		private static readonly IntPtr NativeMethodInfoPtr_ShowToast_Private_Void_0;

		// Token: 0x040036AE RID: 13998
		private static readonly IntPtr NativeMethodInfoPtr_Screenshot_Public_Void_Boolean_0;

		// Token: 0x040036AF RID: 13999
		private static readonly IntPtr NativeMethodInfoPtr_DoScreenshot_Private_IEnumerator_Boolean_0;

		// Token: 0x040036B0 RID: 14000
		private static readonly IntPtr NativeMethodInfoPtr_OpenScreenshot_Public_Void_0;

		// Token: 0x040036B1 RID: 14001
		private static readonly IntPtr NativeMethodInfoPtr_PublishScreenshot_Public_Void_0;

		// Token: 0x040036B2 RID: 14002
		private static readonly IntPtr NativeMethodInfoPtr_DoPublishScreenshot_Private_IEnumerator_0;

		// Token: 0x040036B3 RID: 14003
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__19_0_Private_Void_0;

		// Token: 0x02000435 RID: 1077
		[ObfuscatedName("Polytoria.Controllers.ScreenshotController+<DoPublishScreenshot>d__27")]
		public sealed class _DoPublishScreenshot_d__27 : global::Il2CppSystem.Object
		{
			// Token: 0x06005283 RID: 21123 RVA: 0x0015F28C File Offset: 0x0015D48C
			// Note: this type is marked as 'beforefieldinit'.
			static _DoPublishScreenshot_d__27()
			{
				Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "<DoPublishScreenshot>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr);
				ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, "<>1__state");
				ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, "<>2__current");
				ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, "<>4__this");
				ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, "<uwr>5__2");
				ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, 100674460);
				ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, 100674462);
				ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, 100674456);
				ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, 100674457);
				ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, 100674458);
				ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, 100674459);
				ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr, 100674461);
			}

			// Token: 0x17001BDD RID: 7133
			// (get) Token: 0x06005284 RID: 21124 RVA: 0x0015F394 File Offset: 0x0015D594
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BDE RID: 7134
			// (get) Token: 0x06005285 RID: 21125 RVA: 0x0015F3D4 File Offset: 0x0015D5D4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005286 RID: 21126 RVA: 0x0015F414 File Offset: 0x0015D614
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoPublishScreenshot_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenshotController._DoPublishScreenshot_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005287 RID: 21127 RVA: 0x0015F45C File Offset: 0x0015D65C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136387, XrefRangeEnd = 136392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005288 RID: 21128 RVA: 0x0015F490 File Offset: 0x0015D690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136392, XrefRangeEnd = 136475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005289 RID: 21129 RVA: 0x0015F4CC File Offset: 0x0015D6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136475, XrefRangeEnd = 136478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600528A RID: 21130 RVA: 0x0015F500 File Offset: 0x0015D700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136478, XrefRangeEnd = 136483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoPublishScreenshot_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600528B RID: 21131 RVA: 0x0001FED8 File Offset: 0x0001E0D8
			public _DoPublishScreenshot_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BD9 RID: 7129
			// (get) Token: 0x0600528C RID: 21132 RVA: 0x0015F534 File Offset: 0x0015D734
			// (set) Token: 0x0600528D RID: 21133 RVA: 0x0001FEE1 File Offset: 0x0001E0E1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BDA RID: 7130
			// (get) Token: 0x0600528E RID: 21134 RVA: 0x0015F55C File Offset: 0x0015D75C
			// (set) Token: 0x0600528F RID: 21135 RVA: 0x0001FEFC File Offset: 0x0001E0FC
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BDB RID: 7131
			// (get) Token: 0x06005290 RID: 21136 RVA: 0x0015F58C File Offset: 0x0015D78C
			// (set) Token: 0x06005291 RID: 21137 RVA: 0x0001FF1B File Offset: 0x0001E11B
			public unsafe ScreenshotController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenshotController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BDC RID: 7132
			// (get) Token: 0x06005292 RID: 21138 RVA: 0x0015F5BC File Offset: 0x0015D7BC
			// (set) Token: 0x06005293 RID: 21139 RVA: 0x0001FF3A File Offset: 0x0001E13A
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoPublishScreenshot_d__27.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F29 RID: 16169
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F2A RID: 16170
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F2B RID: 16171
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F2C RID: 16172
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003F2D RID: 16173
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F2E RID: 16174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F2F RID: 16175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F30 RID: 16176
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F31 RID: 16177
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F32 RID: 16178
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003F33 RID: 16179
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000436 RID: 1078
		[ObfuscatedName("Polytoria.Controllers.ScreenshotController+<DoScreenshot>d__24")]
		public sealed class _DoScreenshot_d__24 : global::Il2CppSystem.Object
		{
			// Token: 0x06005294 RID: 21140 RVA: 0x0015F5EC File Offset: 0x0015D7EC
			// Note: this type is marked as 'beforefieldinit'.
			static _DoScreenshot_d__24()
			{
				Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenshotController>.NativeClassPtr, "<DoScreenshot>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr);
				ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, "<>1__state");
				ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, "<>2__current");
				ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr_hideUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, "hideUI");
				ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, "<>4__this");
				ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr__path_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, "<path>5__2");
				ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr__filename_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, "<filename>5__3");
				ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, 100674466);
				ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, 100674468);
				ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, 100674463);
				ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, 100674464);
				ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, 100674465);
				ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr, 100674467);
			}

			// Token: 0x17001BE5 RID: 7141
			// (get) Token: 0x06005295 RID: 21141 RVA: 0x0015F708 File Offset: 0x0015D908
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BE6 RID: 7142
			// (get) Token: 0x06005296 RID: 21142 RVA: 0x0015F748 File Offset: 0x0015D948
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005297 RID: 21143 RVA: 0x0015F788 File Offset: 0x0015D988
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoScreenshot_d__24(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenshotController._DoScreenshot_d__24>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005298 RID: 21144 RVA: 0x0015F7D0 File Offset: 0x0015D9D0
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005299 RID: 21145 RVA: 0x0015F804 File Offset: 0x0015DA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136483, XrefRangeEnd = 136564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600529A RID: 21146 RVA: 0x0015F840 File Offset: 0x0015DA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136564, XrefRangeEnd = 136569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotController._DoScreenshot_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600529B RID: 21147 RVA: 0x0001FF59 File Offset: 0x0001E159
			public _DoScreenshot_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BDF RID: 7135
			// (get) Token: 0x0600529C RID: 21148 RVA: 0x0015F874 File Offset: 0x0015DA74
			// (set) Token: 0x0600529D RID: 21149 RVA: 0x0001FF62 File Offset: 0x0001E162
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BE0 RID: 7136
			// (get) Token: 0x0600529E RID: 21150 RVA: 0x0015F89C File Offset: 0x0015DA9C
			// (set) Token: 0x0600529F RID: 21151 RVA: 0x0001FF7D File Offset: 0x0001E17D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BE1 RID: 7137
			// (get) Token: 0x060052A0 RID: 21152 RVA: 0x0015F8CC File Offset: 0x0015DACC
			// (set) Token: 0x060052A1 RID: 21153 RVA: 0x0001FF9C File Offset: 0x0001E19C
			public unsafe bool hideUI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr_hideUI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr_hideUI)) = value;
				}
			}

			// Token: 0x17001BE2 RID: 7138
			// (get) Token: 0x060052A2 RID: 21154 RVA: 0x0015F8F4 File Offset: 0x0015DAF4
			// (set) Token: 0x060052A3 RID: 21155 RVA: 0x0001FFB7 File Offset: 0x0001E1B7
			public unsafe ScreenshotController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenshotController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BE3 RID: 7139
			// (get) Token: 0x060052A4 RID: 21156 RVA: 0x0015F924 File Offset: 0x0015DB24
			// (set) Token: 0x060052A5 RID: 21157 RVA: 0x0001FFD6 File Offset: 0x0001E1D6
			public unsafe string _path_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr__path_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr__path_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001BE4 RID: 7140
			// (get) Token: 0x060052A6 RID: 21158 RVA: 0x0015F94C File Offset: 0x0015DB4C
			// (set) Token: 0x060052A7 RID: 21159 RVA: 0x0001FFF5 File Offset: 0x0001E1F5
			public unsafe string _filename_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr__filename_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotController._DoScreenshot_d__24.NativeFieldInfoPtr__filename_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003F34 RID: 16180
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F35 RID: 16181
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F36 RID: 16182
			private static readonly IntPtr NativeFieldInfoPtr_hideUI;

			// Token: 0x04003F37 RID: 16183
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F38 RID: 16184
			private static readonly IntPtr NativeFieldInfoPtr__path_5__2;

			// Token: 0x04003F39 RID: 16185
			private static readonly IntPtr NativeFieldInfoPtr__filename_5__3;

			// Token: 0x04003F3A RID: 16186
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F3B RID: 16187
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F3C RID: 16188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F3D RID: 16189
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F3E RID: 16190
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F3F RID: 16191
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
