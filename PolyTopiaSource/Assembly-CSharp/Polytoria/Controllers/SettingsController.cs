using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace Polytoria.Controllers
{
	// Token: 0x02000339 RID: 825
	public class SettingsController : MonoBehaviour
	{
		// Token: 0x06004694 RID: 18068 RVA: 0x0013A198 File Offset: 0x00138398
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsController()
		{
			Il2CppClassPointerStore<SettingsController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "SettingsController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsController>.NativeClassPtr);
			SettingsController.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "instance");
			SettingsController.NativeFieldInfoPtr_audioContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "audioContainer");
			SettingsController.NativeFieldInfoPtr_graphicsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "graphicsContainer");
			SettingsController.NativeFieldInfoPtr_inputContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "inputContainer");
			SettingsController.NativeFieldInfoPtr_miscContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "miscContainer");
			SettingsController.NativeFieldInfoPtr_postProcessLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "postProcessLayer");
			SettingsController.NativeFieldInfoPtr_containers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "containers");
			SettingsController.NativeFieldInfoPtr_DefaultQualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "DefaultQualityLevel");
			SettingsController.NativeFieldInfoPtr_DefaultUISize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "DefaultUISize");
			SettingsController.NativeFieldInfoPtr_DefaultMouseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "DefaultMouseSensitivity");
			SettingsController.NativeFieldInfoPtr_DefaultMasterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, "DefaultMasterVolume");
			SettingsController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674497);
			SettingsController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674474);
			SettingsController.NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674475);
			SettingsController.NativeMethodInfoPtr_SetSettingsCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674476);
			SettingsController.NativeMethodInfoPtr_LoadSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674477);
			SettingsController.NativeMethodInfoPtr_ReloadControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674478);
			SettingsController.NativeMethodInfoPtr_ReloadInputControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674479);
			SettingsController.NativeMethodInfoPtr_ReloadMiscControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674480);
			SettingsController.NativeMethodInfoPtr_ReloadAudioControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674481);
			SettingsController.NativeMethodInfoPtr_ReloadGraphicsControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674482);
			SettingsController.NativeMethodInfoPtr_SetMouseSensitivity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674483);
			SettingsController.NativeMethodInfoPtr_SetDebugLogLength_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674484);
			SettingsController.NativeMethodInfoPtr_SetUISize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674485);
			SettingsController.NativeMethodInfoPtr_SetFullscreen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674486);
			SettingsController.NativeMethodInfoPtr_SetQualityLevel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674487);
			SettingsController.NativeMethodInfoPtr_SetPixelLightCount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674488);
			SettingsController.NativeMethodInfoPtr_SetShadowDistance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674489);
			SettingsController.NativeMethodInfoPtr_SetShadowResolution_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674490);
			SettingsController.NativeMethodInfoPtr_SetTextureQuality_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674491);
			SettingsController.NativeMethodInfoPtr_SetVSync_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674492);
			SettingsController.NativeMethodInfoPtr_SetAntiAliasing_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674493);
			SettingsController.NativeMethodInfoPtr_SetAnisotropicFiltering_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674494);
			SettingsController.NativeMethodInfoPtr_SetPostProcessing_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674495);
			SettingsController.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsController>.NativeClassPtr, 100674496);
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x0013A484 File Offset: 0x00138684
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x0013A4C0 File Offset: 0x001386C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136950, XrefRangeEnd = 136954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x0013A4F4 File Offset: 0x001386F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136969, RefRangeEnd = 136970, XrefRangeStart = 136954, XrefRangeEnd = 136969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x0013A528 File Offset: 0x00138728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136970, XrefRangeEnd = 136977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSettingsCategory(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetSettingsCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x0013A568 File Offset: 0x00138768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137118, RefRangeEnd = 137119, XrefRangeStart = 136977, XrefRangeEnd = 137118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_LoadSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x0013A59C File Offset: 0x0013879C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137160, RefRangeEnd = 137161, XrefRangeStart = 137119, XrefRangeEnd = 137160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_ReloadControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x0013A5D0 File Offset: 0x001387D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137161, XrefRangeEnd = 137172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadInputControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_ReloadInputControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x0013A604 File Offset: 0x00138804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137172, XrefRangeEnd = 137195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadMiscControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_ReloadMiscControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x0013A638 File Offset: 0x00138838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137195, XrefRangeEnd = 137203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadAudioControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_ReloadAudioControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x0013A66C File Offset: 0x0013886C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137274, RefRangeEnd = 137275, XrefRangeStart = 137203, XrefRangeEnd = 137274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadGraphicsControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_ReloadGraphicsControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x0013A6A0 File Offset: 0x001388A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137275, XrefRangeEnd = 137282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMouseSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sensitivity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetMouseSensitivity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x0013A6E0 File Offset: 0x001388E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137282, XrefRangeEnd = 137290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDebugLogLength(string slength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(slength);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetDebugLogLength_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x0013A724 File Offset: 0x00138924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137290, XrefRangeEnd = 137307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUISize(int sizeLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sizeLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetUISize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x0013A764 File Offset: 0x00138964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137307, XrefRangeEnd = 137319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFullscreen(bool fullscreen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fullscreen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetFullscreen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x0013A7A4 File Offset: 0x001389A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137319, XrefRangeEnd = 137323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQualityLevel(int qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref qualityLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetQualityLevel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x0013A7E4 File Offset: 0x001389E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137323, XrefRangeEnd = 137327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelLightCount(float pixelLightCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pixelLightCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetPixelLightCount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x0013A824 File Offset: 0x00138A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137327, XrefRangeEnd = 137331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShadowDistance(float shadowDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shadowDistance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetShadowDistance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x0013A864 File Offset: 0x00138A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137331, XrefRangeEnd = 137335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShadowResolution(int shadowResolution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shadowResolution;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetShadowResolution_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x0013A8A4 File Offset: 0x00138AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137335, XrefRangeEnd = 137339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureQuality(int textureQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref textureQuality;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetTextureQuality_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x0013A8E4 File Offset: 0x00138AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137339, XrefRangeEnd = 137343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVSync(int vSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vSync;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetVSync_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x0013A924 File Offset: 0x00138B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137343, XrefRangeEnd = 137347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAntiAliasing(int antiAliasing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref antiAliasing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetAntiAliasing_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x0013A964 File Offset: 0x00138B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137347, XrefRangeEnd = 137351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnisotropicFiltering(int anisotropicFiltering)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anisotropicFiltering;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetAnisotropicFiltering_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x0013A9A4 File Offset: 0x00138BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137351, XrefRangeEnd = 137359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPostProcessing(bool postProcessing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref postProcessing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetPostProcessing_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x0013A9E4 File Offset: 0x00138BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137359, XrefRangeEnd = 137363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMasterVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref volume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsController.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x0001A240 File Offset: 0x00018440
		public SettingsController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x0013AA24 File Offset: 0x00138C24
		// (set) Token: 0x060046AF RID: 18095 RVA: 0x0001A249 File Offset: 0x00018449
		public unsafe static SettingsController instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SettingsController.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsController.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x0013AA4C File Offset: 0x00138C4C
		// (set) Token: 0x060046B1 RID: 18097 RVA: 0x0001A25B File Offset: 0x0001845B
		public unsafe RectTransform audioContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_audioContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_audioContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x0013AA7C File Offset: 0x00138C7C
		// (set) Token: 0x060046B3 RID: 18099 RVA: 0x0001A27A File Offset: 0x0001847A
		public unsafe RectTransform graphicsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_graphicsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_graphicsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x0013AAAC File Offset: 0x00138CAC
		// (set) Token: 0x060046B5 RID: 18101 RVA: 0x0001A299 File Offset: 0x00018499
		public unsafe RectTransform inputContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_inputContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_inputContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x0013AADC File Offset: 0x00138CDC
		// (set) Token: 0x060046B7 RID: 18103 RVA: 0x0001A2B8 File Offset: 0x000184B8
		public unsafe RectTransform miscContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_miscContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_miscContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x0013AB0C File Offset: 0x00138D0C
		// (set) Token: 0x060046B9 RID: 18105 RVA: 0x0001A2D7 File Offset: 0x000184D7
		public unsafe PostProcessLayer postProcessLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_postProcessLayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessLayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_postProcessLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x0013AB3C File Offset: 0x00138D3C
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x0001A2F6 File Offset: 0x000184F6
		public unsafe Il2CppReferenceArray<RectTransform> containers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_containers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsController.NativeFieldInfoPtr_containers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x0013AB6C File Offset: 0x00138D6C
		// (set) Token: 0x060046BD RID: 18109 RVA: 0x0001A315 File Offset: 0x00018515
		public unsafe static int DefaultQualityLevel
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SettingsController.NativeFieldInfoPtr_DefaultQualityLevel, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsController.NativeFieldInfoPtr_DefaultQualityLevel, (void*)(&value));
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x0013AB88 File Offset: 0x00138D88
		// (set) Token: 0x060046BF RID: 18111 RVA: 0x0001A323 File Offset: 0x00018523
		public unsafe static int DefaultUISize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SettingsController.NativeFieldInfoPtr_DefaultUISize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsController.NativeFieldInfoPtr_DefaultUISize, (void*)(&value));
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x060046C0 RID: 18112 RVA: 0x0013ABA4 File Offset: 0x00138DA4
		// (set) Token: 0x060046C1 RID: 18113 RVA: 0x0001A331 File Offset: 0x00018531
		public unsafe static float DefaultMouseSensitivity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SettingsController.NativeFieldInfoPtr_DefaultMouseSensitivity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsController.NativeFieldInfoPtr_DefaultMouseSensitivity, (void*)(&value));
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x0013ABC0 File Offset: 0x00138DC0
		// (set) Token: 0x060046C3 RID: 18115 RVA: 0x0001A33F File Offset: 0x0001853F
		public unsafe static float DefaultMasterVolume
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SettingsController.NativeFieldInfoPtr_DefaultMasterVolume, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsController.NativeFieldInfoPtr_DefaultMasterVolume, (void*)(&value));
			}
		}

		// Token: 0x040036B7 RID: 14007
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040036B8 RID: 14008
		private static readonly IntPtr NativeFieldInfoPtr_audioContainer;

		// Token: 0x040036B9 RID: 14009
		private static readonly IntPtr NativeFieldInfoPtr_graphicsContainer;

		// Token: 0x040036BA RID: 14010
		private static readonly IntPtr NativeFieldInfoPtr_inputContainer;

		// Token: 0x040036BB RID: 14011
		private static readonly IntPtr NativeFieldInfoPtr_miscContainer;

		// Token: 0x040036BC RID: 14012
		private static readonly IntPtr NativeFieldInfoPtr_postProcessLayer;

		// Token: 0x040036BD RID: 14013
		private static readonly IntPtr NativeFieldInfoPtr_containers;

		// Token: 0x040036BE RID: 14014
		private static readonly IntPtr NativeFieldInfoPtr_DefaultQualityLevel;

		// Token: 0x040036BF RID: 14015
		private static readonly IntPtr NativeFieldInfoPtr_DefaultUISize;

		// Token: 0x040036C0 RID: 14016
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMouseSensitivity;

		// Token: 0x040036C1 RID: 14017
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMasterVolume;

		// Token: 0x040036C2 RID: 14018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040036C3 RID: 14019
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040036C4 RID: 14020
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

		// Token: 0x040036C5 RID: 14021
		private static readonly IntPtr NativeMethodInfoPtr_SetSettingsCategory_Public_Void_Int32_0;

		// Token: 0x040036C6 RID: 14022
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_0;

		// Token: 0x040036C7 RID: 14023
		private static readonly IntPtr NativeMethodInfoPtr_ReloadControls_Private_Void_0;

		// Token: 0x040036C8 RID: 14024
		private static readonly IntPtr NativeMethodInfoPtr_ReloadInputControls_Private_Void_0;

		// Token: 0x040036C9 RID: 14025
		private static readonly IntPtr NativeMethodInfoPtr_ReloadMiscControls_Private_Void_0;

		// Token: 0x040036CA RID: 14026
		private static readonly IntPtr NativeMethodInfoPtr_ReloadAudioControls_Private_Void_0;

		// Token: 0x040036CB RID: 14027
		private static readonly IntPtr NativeMethodInfoPtr_ReloadGraphicsControls_Private_Void_0;

		// Token: 0x040036CC RID: 14028
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseSensitivity_Public_Void_Single_0;

		// Token: 0x040036CD RID: 14029
		private static readonly IntPtr NativeMethodInfoPtr_SetDebugLogLength_Public_Void_String_0;

		// Token: 0x040036CE RID: 14030
		private static readonly IntPtr NativeMethodInfoPtr_SetUISize_Public_Void_Int32_0;

		// Token: 0x040036CF RID: 14031
		private static readonly IntPtr NativeMethodInfoPtr_SetFullscreen_Public_Void_Boolean_0;

		// Token: 0x040036D0 RID: 14032
		private static readonly IntPtr NativeMethodInfoPtr_SetQualityLevel_Public_Void_Int32_0;

		// Token: 0x040036D1 RID: 14033
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelLightCount_Public_Void_Single_0;

		// Token: 0x040036D2 RID: 14034
		private static readonly IntPtr NativeMethodInfoPtr_SetShadowDistance_Public_Void_Single_0;

		// Token: 0x040036D3 RID: 14035
		private static readonly IntPtr NativeMethodInfoPtr_SetShadowResolution_Public_Void_Int32_0;

		// Token: 0x040036D4 RID: 14036
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureQuality_Public_Void_Int32_0;

		// Token: 0x040036D5 RID: 14037
		private static readonly IntPtr NativeMethodInfoPtr_SetVSync_Public_Void_Int32_0;

		// Token: 0x040036D6 RID: 14038
		private static readonly IntPtr NativeMethodInfoPtr_SetAntiAliasing_Public_Void_Int32_0;

		// Token: 0x040036D7 RID: 14039
		private static readonly IntPtr NativeMethodInfoPtr_SetAnisotropicFiltering_Public_Void_Int32_0;

		// Token: 0x040036D8 RID: 14040
		private static readonly IntPtr NativeMethodInfoPtr_SetPostProcessing_Public_Void_Boolean_0;

		// Token: 0x040036D9 RID: 14041
		private static readonly IntPtr NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0;
	}
}
