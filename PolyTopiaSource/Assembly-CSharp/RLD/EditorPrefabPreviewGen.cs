using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200020F RID: 527
	public class EditorPrefabPreviewGen : global::Il2CppSystem.Object
	{
		// Token: 0x060029B1 RID: 10673 RVA: 0x000C6A84 File Offset: 0x000C4C84
		// Note: this type is marked as 'beforefieldinit'.
		static EditorPrefabPreviewGen()
		{
			Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "EditorPrefabPreviewGen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr);
			EditorPrefabPreviewGen.NativeFieldInfoPtr__previewLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, "_previewLookAndFeel");
			EditorPrefabPreviewGen.NativeFieldInfoPtr__boundsQConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, "_boundsQConfig");
			EditorPrefabPreviewGen.NativeFieldInfoPtr__previewLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, "_previewLight");
			EditorPrefabPreviewGen.NativeFieldInfoPtr__renderCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, "_renderCamera");
			EditorPrefabPreviewGen.NativeFieldInfoPtr__isGenSessionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, "_isGenSessionActive");
			EditorPrefabPreviewGen.NativeFieldInfoPtr__lightToState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, "_lightToState");
			EditorPrefabPreviewGen.NativeFieldInfoPtr__nonMeshPreviewObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, "_nonMeshPreviewObject");
			EditorPrefabPreviewGen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, 100669678);
			EditorPrefabPreviewGen.NativeMethodInfoPtr_BeginGenSession_Public_Boolean_PrefabPreviewLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, 100669679);
			EditorPrefabPreviewGen.NativeMethodInfoPtr_EndGenSession_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, 100669680);
			EditorPrefabPreviewGen.NativeMethodInfoPtr_Generate_Public_Texture2D_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, 100669681);
			EditorPrefabPreviewGen.NativeMethodInfoPtr_CreateRenderCamera_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, 100669682);
			EditorPrefabPreviewGen.NativeMethodInfoPtr_CreatePreviewLight_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, 100669683);
			EditorPrefabPreviewGen.NativeMethodInfoPtr_CreateNonMeshPreviewObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, 100669684);
			EditorPrefabPreviewGen.NativeMethodInfoPtr_DisableSceneLights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, 100669685);
			EditorPrefabPreviewGen.NativeMethodInfoPtr_RestoreSceneLights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr, 100669686);
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000C6BF4 File Offset: 0x000C4DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92765, RefRangeEnd = 92766, XrefRangeStart = 92749, XrefRangeEnd = 92765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditorPrefabPreviewGen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorPrefabPreviewGen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPrefabPreviewGen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x000C6C30 File Offset: 0x000C4E30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92824, RefRangeEnd = 92826, XrefRangeStart = 92766, XrefRangeEnd = 92824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BeginGenSession(PrefabPreviewLookAndFeel previewLookAndFeel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previewLookAndFeel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPrefabPreviewGen.NativeMethodInfoPtr_BeginGenSession_Public_Boolean_PrefabPreviewLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000C6C80 File Offset: 0x000C4E80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92854, RefRangeEnd = 92856, XrefRangeStart = 92826, XrefRangeEnd = 92854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGenSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPrefabPreviewGen.NativeMethodInfoPtr_EndGenSession_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000C6CB4 File Offset: 0x000C4EB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92963, RefRangeEnd = 92965, XrefRangeStart = 92856, XrefRangeEnd = 92963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D Generate(GameObject unityPrefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityPrefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPrefabPreviewGen.NativeMethodInfoPtr_Generate_Public_Texture2D_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000C6D04 File Offset: 0x000C4F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92990, RefRangeEnd = 92991, XrefRangeStart = 92965, XrefRangeEnd = 92990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreateRenderCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPrefabPreviewGen.NativeMethodInfoPtr_CreateRenderCamera_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000C6D40 File Offset: 0x000C4F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92991, XrefRangeEnd = 93003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreatePreviewLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPrefabPreviewGen.NativeMethodInfoPtr_CreatePreviewLight_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000C6D7C File Offset: 0x000C4F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93003, XrefRangeEnd = 93033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateNonMeshPreviewObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPrefabPreviewGen.NativeMethodInfoPtr_CreateNonMeshPreviewObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000C6DB0 File Offset: 0x000C4FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93033, XrefRangeEnd = 93048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSceneLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPrefabPreviewGen.NativeMethodInfoPtr_DisableSceneLights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x000C6DE4 File Offset: 0x000C4FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93069, RefRangeEnd = 93070, XrefRangeStart = 93048, XrefRangeEnd = 93069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreSceneLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPrefabPreviewGen.NativeMethodInfoPtr_RestoreSceneLights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x00010688 File Offset: 0x0000E888
		public EditorPrefabPreviewGen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x000C6E18 File Offset: 0x000C5018
		// (set) Token: 0x060029BD RID: 10685 RVA: 0x00010691 File Offset: 0x0000E891
		public unsafe PrefabPreviewLookAndFeel _previewLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__previewLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabPreviewLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__previewLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x000C6E48 File Offset: 0x000C5048
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x000106B0 File Offset: 0x0000E8B0
		public unsafe ObjectBounds.QueryConfig _boundsQConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__boundsQConfig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__boundsQConfig)) = value;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x000C6E70 File Offset: 0x000C5070
		// (set) Token: 0x060029C1 RID: 10689 RVA: 0x000106CB File Offset: 0x0000E8CB
		public unsafe Light _previewLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__previewLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__previewLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x000C6EA0 File Offset: 0x000C50A0
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x000106EA File Offset: 0x0000E8EA
		public unsafe Camera _renderCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__renderCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__renderCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000C6ED0 File Offset: 0x000C50D0
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x00010709 File Offset: 0x0000E909
		public unsafe bool _isGenSessionActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__isGenSessionActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__isGenSessionActive)) = value;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x000C6EF8 File Offset: 0x000C50F8
		// (set) Token: 0x060029C7 RID: 10695 RVA: 0x00010724 File Offset: 0x0000E924
		public unsafe Dictionary<Light, bool> _lightToState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__lightToState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Light, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__lightToState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000C6F28 File Offset: 0x000C5128
		// (set) Token: 0x060029C9 RID: 10697 RVA: 0x00010743 File Offset: 0x0000E943
		public unsafe GameObject _nonMeshPreviewObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__nonMeshPreviewObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorPrefabPreviewGen.NativeFieldInfoPtr__nonMeshPreviewObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeFieldInfoPtr__previewLookAndFeel;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeFieldInfoPtr__boundsQConfig;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeFieldInfoPtr__previewLight;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeFieldInfoPtr__renderCamera;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeFieldInfoPtr__isGenSessionActive;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeFieldInfoPtr__lightToState;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeFieldInfoPtr__nonMeshPreviewObject;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_BeginGenSession_Public_Boolean_PrefabPreviewLookAndFeel_0;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr_EndGenSession_Public_Void_0;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Texture2D_GameObject_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderCamera_Private_Boolean_0;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeMethodInfoPtr_CreatePreviewLight_Private_Boolean_0;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeMethodInfoPtr_CreateNonMeshPreviewObject_Private_Void_0;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr_DisableSceneLights_Private_Void_0;

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeMethodInfoPtr_RestoreSceneLights_Private_Void_0;

		// Token: 0x020003D1 RID: 977
		public enum PreviewObjectType
		{
			// Token: 0x04003BAC RID: 15276
			Mesh = 1,
			// Token: 0x04003BAD RID: 15277
			Sprite,
			// Token: 0x04003BAE RID: 15278
			Light,
			// Token: 0x04003BAF RID: 15279
			ParticleSystem,
			// Token: 0x04003BB0 RID: 15280
			Other
		}
	}
}
