using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B8 RID: 440
	[Serializable]
	public class SceneLookAndFeel : Settings
	{
		// Token: 0x06002219 RID: 8729 RVA: 0x000A8A00 File Offset: 0x000A6C00
		// Note: this type is marked as 'beforefieldinit'.
		static SceneLookAndFeel()
		{
			Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr);
			SceneLookAndFeel.NativeFieldInfoPtr__drawLightIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, "_drawLightIcons");
			SceneLookAndFeel.NativeFieldInfoPtr__drawParticleSystemIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, "_drawParticleSystemIcons");
			SceneLookAndFeel.NativeFieldInfoPtr__drawCameraIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, "_drawCameraIcons");
			SceneLookAndFeel.NativeFieldInfoPtr__lightIconAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, "_lightIconAlpha");
			SceneLookAndFeel.NativeFieldInfoPtr__particleSystemIconAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, "_particleSystemIconAlpha");
			SceneLookAndFeel.NativeFieldInfoPtr__cameraIconAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, "_cameraIconAlpha");
			SceneLookAndFeel.NativeFieldInfoPtr__lightIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, "_lightIcon");
			SceneLookAndFeel.NativeFieldInfoPtr__particleSystemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, "_particleSystemIcon");
			SceneLookAndFeel.NativeFieldInfoPtr__cameraIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, "_cameraIcon");
			SceneLookAndFeel.NativeMethodInfoPtr_get_DrawLightIcons_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668455);
			SceneLookAndFeel.NativeMethodInfoPtr_set_DrawLightIcons_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668456);
			SceneLookAndFeel.NativeMethodInfoPtr_get_DrawParticleSystemIcons_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668457);
			SceneLookAndFeel.NativeMethodInfoPtr_set_DrawParticleSystemIcons_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668458);
			SceneLookAndFeel.NativeMethodInfoPtr_get_DrawCameraIcons_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668459);
			SceneLookAndFeel.NativeMethodInfoPtr_set_DrawCameraIcons_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668460);
			SceneLookAndFeel.NativeMethodInfoPtr_get_LightIconAlpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668461);
			SceneLookAndFeel.NativeMethodInfoPtr_set_LightIconAlpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668462);
			SceneLookAndFeel.NativeMethodInfoPtr_get_ParticleSystemIconAlpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668463);
			SceneLookAndFeel.NativeMethodInfoPtr_set_ParticleSystemIconAlpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668464);
			SceneLookAndFeel.NativeMethodInfoPtr_get_CameraIconAlpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668465);
			SceneLookAndFeel.NativeMethodInfoPtr_set_CameraIconAlpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668466);
			SceneLookAndFeel.NativeMethodInfoPtr_get_LightIcon_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668467);
			SceneLookAndFeel.NativeMethodInfoPtr_set_LightIcon_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668468);
			SceneLookAndFeel.NativeMethodInfoPtr_get_ParticleSystemIcon_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668469);
			SceneLookAndFeel.NativeMethodInfoPtr_set_ParticleSystemIcon_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668470);
			SceneLookAndFeel.NativeMethodInfoPtr_get_CameraIcon_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668471);
			SceneLookAndFeel.NativeMethodInfoPtr_set_CameraIcon_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668472);
			SceneLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr, 100668473);
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x000A8C60 File Offset: 0x000A6E60
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x000A8C9C File Offset: 0x000A6E9C
		public unsafe bool DrawLightIcons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_get_DrawLightIcons_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_set_DrawLightIcons_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x000A8CDC File Offset: 0x000A6EDC
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x000A8D18 File Offset: 0x000A6F18
		public unsafe bool DrawParticleSystemIcons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_get_DrawParticleSystemIcons_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_set_DrawParticleSystemIcons_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x000A8D58 File Offset: 0x000A6F58
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x000A8D94 File Offset: 0x000A6F94
		public unsafe bool DrawCameraIcons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_get_DrawCameraIcons_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_set_DrawCameraIcons_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x000A8DD4 File Offset: 0x000A6FD4
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x000A8E10 File Offset: 0x000A7010
		public unsafe float LightIconAlpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_get_LightIconAlpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_set_LightIconAlpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x000A8E50 File Offset: 0x000A7050
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x000A8E8C File Offset: 0x000A708C
		public unsafe float ParticleSystemIconAlpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_get_ParticleSystemIconAlpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_set_ParticleSystemIconAlpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x000A8ECC File Offset: 0x000A70CC
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x000A8F08 File Offset: 0x000A7108
		public unsafe float CameraIconAlpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_get_CameraIconAlpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_set_CameraIconAlpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000A8F48 File Offset: 0x000A7148
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x000A8F88 File Offset: 0x000A7188
		public unsafe Texture2D LightIcon
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_get_LightIcon_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_set_LightIcon_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x000A8FCC File Offset: 0x000A71CC
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x000A900C File Offset: 0x000A720C
		public unsafe Texture2D ParticleSystemIcon
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_get_ParticleSystemIcon_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_set_ParticleSystemIcon_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x000A9050 File Offset: 0x000A7250
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x000A9090 File Offset: 0x000A7290
		public unsafe Texture2D CameraIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_get_CameraIcon_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr_set_CameraIcon_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x000A90D4 File Offset: 0x000A72D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86982, XrefRangeEnd = 86983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
		public SceneLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000A9110 File Offset: 0x000A7310
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x0000DEE9 File Offset: 0x0000C0E9
		public unsafe bool _drawLightIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__drawLightIcons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__drawLightIcons)) = value;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x000A9138 File Offset: 0x000A7338
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x0000DF04 File Offset: 0x0000C104
		public unsafe bool _drawParticleSystemIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__drawParticleSystemIcons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__drawParticleSystemIcons)) = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x000A9160 File Offset: 0x000A7360
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x0000DF1F File Offset: 0x0000C11F
		public unsafe bool _drawCameraIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__drawCameraIcons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__drawCameraIcons)) = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x000A9188 File Offset: 0x000A7388
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x0000DF3A File Offset: 0x0000C13A
		public unsafe float _lightIconAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__lightIconAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__lightIconAlpha)) = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x000A91B0 File Offset: 0x000A73B0
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x0000DF55 File Offset: 0x0000C155
		public unsafe float _particleSystemIconAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__particleSystemIconAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__particleSystemIconAlpha)) = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x000A91D8 File Offset: 0x000A73D8
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x0000DF70 File Offset: 0x0000C170
		public unsafe float _cameraIconAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__cameraIconAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__cameraIconAlpha)) = value;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x000A9200 File Offset: 0x000A7400
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x0000DF8B File Offset: 0x0000C18B
		public unsafe Texture2D _lightIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__lightIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__lightIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x000A9230 File Offset: 0x000A7430
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x0000DFAA File Offset: 0x0000C1AA
		public unsafe Texture2D _particleSystemIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__particleSystemIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__particleSystemIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x000A9260 File Offset: 0x000A7460
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x0000DFC9 File Offset: 0x0000C1C9
		public unsafe Texture2D _cameraIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__cameraIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneLookAndFeel.NativeFieldInfoPtr__cameraIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeFieldInfoPtr__drawLightIcons;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeFieldInfoPtr__drawParticleSystemIcons;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeFieldInfoPtr__drawCameraIcons;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeFieldInfoPtr__lightIconAlpha;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeFieldInfoPtr__particleSystemIconAlpha;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeFieldInfoPtr__cameraIconAlpha;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeFieldInfoPtr__lightIcon;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeFieldInfoPtr__particleSystemIcon;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeFieldInfoPtr__cameraIcon;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawLightIcons_Public_get_Boolean_0;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawLightIcons_Public_set_Void_Boolean_0;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawParticleSystemIcons_Public_get_Boolean_0;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawParticleSystemIcons_Public_set_Void_Boolean_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawCameraIcons_Public_get_Boolean_0;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawCameraIcons_Public_set_Void_Boolean_0;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeMethodInfoPtr_get_LightIconAlpha_Public_get_Single_0;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeMethodInfoPtr_set_LightIconAlpha_Public_set_Void_Single_0;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeMethodInfoPtr_get_ParticleSystemIconAlpha_Public_get_Single_0;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeMethodInfoPtr_set_ParticleSystemIconAlpha_Public_set_Void_Single_0;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraIconAlpha_Public_get_Single_0;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraIconAlpha_Public_set_Void_Single_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_get_LightIcon_Public_get_Texture2D_0;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeMethodInfoPtr_set_LightIcon_Public_set_Void_Texture2D_0;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeMethodInfoPtr_get_ParticleSystemIcon_Public_get_Texture2D_0;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeMethodInfoPtr_set_ParticleSystemIcon_Public_set_Void_Texture2D_0;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraIcon_Public_get_Texture2D_0;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraIcon_Public_set_Void_Texture2D_0;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
