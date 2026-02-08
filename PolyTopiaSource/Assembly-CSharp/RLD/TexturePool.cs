using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001A8 RID: 424
	public class TexturePool : Singleton<TexturePool>
	{
		// Token: 0x060020FB RID: 8443 RVA: 0x000A479C File Offset: 0x000A299C
		// Note: this type is marked as 'beforefieldinit'.
		static TexturePool()
		{
			Il2CppClassPointerStore<TexturePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "TexturePool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePool>.NativeClassPtr);
			TexturePool.NativeFieldInfoPtr__mainLightIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, "_mainLightIcon");
			TexturePool.NativeFieldInfoPtr__mainParticleSystemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, "_mainParticleSystemIcon");
			TexturePool.NativeFieldInfoPtr__cameraIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, "_cameraIcon");
			TexturePool.NativeFieldInfoPtr__xAxisLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, "_xAxisLabel");
			TexturePool.NativeFieldInfoPtr__yAxisLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, "_yAxisLabel");
			TexturePool.NativeFieldInfoPtr__zAxisLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, "_zAxisLabel");
			TexturePool.NativeFieldInfoPtr__camPerspMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, "_camPerspMode");
			TexturePool.NativeFieldInfoPtr__camOrthoMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, "_camOrthoMode");
			TexturePool.NativeMethodInfoPtr_get_MainLightIcon_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100668312);
			TexturePool.NativeMethodInfoPtr_get_MainParticleSystemIcon_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100668313);
			TexturePool.NativeMethodInfoPtr_get_CameraIcon_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100668314);
			TexturePool.NativeMethodInfoPtr_get_XAxisLabel_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100668315);
			TexturePool.NativeMethodInfoPtr_get_YAxisLabel_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100668316);
			TexturePool.NativeMethodInfoPtr_get_ZAxisLabel_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100668317);
			TexturePool.NativeMethodInfoPtr_get_CamPerspMode_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100668318);
			TexturePool.NativeMethodInfoPtr_get_CamOrthoMode_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100668319);
			TexturePool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePool>.NativeClassPtr, 100668320);
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x000A4920 File Offset: 0x000A2B20
		public unsafe Texture2D MainLightIcon
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85580, XrefRangeEnd = 85592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr_get_MainLightIcon_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x000A4960 File Offset: 0x000A2B60
		public unsafe Texture2D MainParticleSystemIcon
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85592, XrefRangeEnd = 85604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr_get_MainParticleSystemIcon_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x000A49A0 File Offset: 0x000A2BA0
		public unsafe Texture2D CameraIcon
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85604, XrefRangeEnd = 85616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr_get_CameraIcon_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x000A49E0 File Offset: 0x000A2BE0
		public unsafe Texture2D XAxisLabel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85628, RefRangeEnd = 85629, XrefRangeStart = 85616, XrefRangeEnd = 85628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr_get_XAxisLabel_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x000A4A20 File Offset: 0x000A2C20
		public unsafe Texture2D YAxisLabel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85641, RefRangeEnd = 85642, XrefRangeStart = 85629, XrefRangeEnd = 85641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr_get_YAxisLabel_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x000A4A60 File Offset: 0x000A2C60
		public unsafe Texture2D ZAxisLabel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85654, RefRangeEnd = 85655, XrefRangeStart = 85642, XrefRangeEnd = 85654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr_get_ZAxisLabel_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x000A4AA0 File Offset: 0x000A2CA0
		public unsafe Texture2D CamPerspMode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 85667, RefRangeEnd = 85671, XrefRangeStart = 85655, XrefRangeEnd = 85667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr_get_CamPerspMode_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x000A4AE0 File Offset: 0x000A2CE0
		public unsafe Texture2D CamOrthoMode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 85683, RefRangeEnd = 85687, XrefRangeStart = 85671, XrefRangeEnd = 85683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr_get_CamOrthoMode_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000A4B20 File Offset: 0x000A2D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85687, XrefRangeEnd = 85693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TexturePool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TexturePool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x0000D72D File Offset: 0x0000B92D
		public TexturePool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x000A4B5C File Offset: 0x000A2D5C
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x0000D736 File Offset: 0x0000B936
		public unsafe Texture2D _mainLightIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__mainLightIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__mainLightIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x000A4B8C File Offset: 0x000A2D8C
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x0000D755 File Offset: 0x0000B955
		public unsafe Texture2D _mainParticleSystemIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__mainParticleSystemIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__mainParticleSystemIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x000A4BBC File Offset: 0x000A2DBC
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x0000D774 File Offset: 0x0000B974
		public unsafe Texture2D _cameraIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__cameraIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__cameraIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x000A4BEC File Offset: 0x000A2DEC
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x0000D793 File Offset: 0x0000B993
		public unsafe Texture2D _xAxisLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__xAxisLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__xAxisLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x000A4C1C File Offset: 0x000A2E1C
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x0000D7B2 File Offset: 0x0000B9B2
		public unsafe Texture2D _yAxisLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__yAxisLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__yAxisLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x000A4C4C File Offset: 0x000A2E4C
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x0000D7D1 File Offset: 0x0000B9D1
		public unsafe Texture2D _zAxisLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__zAxisLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__zAxisLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x000A4C7C File Offset: 0x000A2E7C
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
		public unsafe Texture2D _camPerspMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__camPerspMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__camPerspMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x000A4CAC File Offset: 0x000A2EAC
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x0000D80F File Offset: 0x0000BA0F
		public unsafe Texture2D _camOrthoMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__camOrthoMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TexturePool.NativeFieldInfoPtr__camOrthoMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeFieldInfoPtr__mainLightIcon;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeFieldInfoPtr__mainParticleSystemIcon;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeFieldInfoPtr__cameraIcon;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeFieldInfoPtr__xAxisLabel;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeFieldInfoPtr__yAxisLabel;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeFieldInfoPtr__zAxisLabel;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeFieldInfoPtr__camPerspMode;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeFieldInfoPtr__camOrthoMode;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr_get_MainLightIcon_Public_get_Texture2D_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr_get_MainParticleSystemIcon_Public_get_Texture2D_0;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraIcon_Public_get_Texture2D_0;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeMethodInfoPtr_get_XAxisLabel_Public_get_Texture2D_0;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeMethodInfoPtr_get_YAxisLabel_Public_get_Texture2D_0;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeMethodInfoPtr_get_ZAxisLabel_Public_get_Texture2D_0;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeMethodInfoPtr_get_CamPerspMode_Public_get_Texture2D_0;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeMethodInfoPtr_get_CamOrthoMode_Public_get_Texture2D_0;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
