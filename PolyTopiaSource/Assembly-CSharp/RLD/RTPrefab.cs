using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000199 RID: 409
	[Serializable]
	public class RTPrefab : global::Il2CppSystem.Object
	{
		// Token: 0x06001F80 RID: 8064 RVA: 0x0009EE2C File Offset: 0x0009D02C
		// Note: this type is marked as 'beforefieldinit'.
		static RTPrefab()
		{
			Il2CppClassPointerStore<RTPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTPrefab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr);
			RTPrefab.NativeFieldInfoPtr__unityPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, "_unityPrefab");
			RTPrefab.NativeFieldInfoPtr__previewTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, "_previewTexture");
			RTPrefab.NativeFieldInfoPtr__previewSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, "_previewSprite");
			RTPrefab.NativeMethodInfoPtr_get_UnityPrefab_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, 100668092);
			RTPrefab.NativeMethodInfoPtr_set_UnityPrefab_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, 100668093);
			RTPrefab.NativeMethodInfoPtr_get_PreviewTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, 100668094);
			RTPrefab.NativeMethodInfoPtr_set_PreviewTexture_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, 100668095);
			RTPrefab.NativeMethodInfoPtr_get_PreviewSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, 100668096);
			RTPrefab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, 100668100);
			RTPrefab.NativeMethodInfoPtr_Instantiate_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, 100668097);
			RTPrefab.NativeMethodInfoPtr_Instantiate_Public_GameObject_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, 100668098);
			RTPrefab.NativeMethodInfoPtr_Instantiate_Public_GameObject_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr, 100668099);
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0009EF4C File Offset: 0x0009D14C
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0009EF8C File Offset: 0x0009D18C
		public unsafe GameObject UnityPrefab
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefab.NativeMethodInfoPtr_get_UnityPrefab_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefab.NativeMethodInfoPtr_set_UnityPrefab_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0009EFD0 File Offset: 0x0009D1D0
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x0009F010 File Offset: 0x0009D210
		public unsafe Texture2D PreviewTexture
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefab.NativeMethodInfoPtr_get_PreviewTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefab.NativeMethodInfoPtr_set_PreviewTexture_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x0009F054 File Offset: 0x0009D254
		public unsafe Sprite PreviewSprite
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83600, RefRangeEnd = 83601, XrefRangeStart = 83591, XrefRangeEnd = 83600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefab.NativeMethodInfoPtr_get_PreviewSprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0009F094 File Offset: 0x0009D294
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefab()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefab>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0009F0D0 File Offset: 0x0009D2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83601, XrefRangeEnd = 83610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefab.NativeMethodInfoPtr_Instantiate_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0009F110 File Offset: 0x0009D310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83610, XrefRangeEnd = 83620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject Instantiate(Vector3 worldPos, Quaternion worldRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(worldPos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefab.NativeMethodInfoPtr_Instantiate_Public_GameObject_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0009F174 File Offset: 0x0009D374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83620, XrefRangeEnd = 83632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject Instantiate(Vector3 worldPos, Quaternion worldRotation, Vector3 worldScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(worldPos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldRotation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldScale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefab.NativeMethodInfoPtr_Instantiate_Public_GameObject_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		public RTPrefab(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0009F1E8 File Offset: 0x0009D3E8
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x0000CD25 File Offset: 0x0000AF25
		public unsafe GameObject _unityPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefab.NativeFieldInfoPtr__unityPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefab.NativeFieldInfoPtr__unityPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x0009F218 File Offset: 0x0009D418
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x0000CD44 File Offset: 0x0000AF44
		public unsafe Texture2D _previewTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefab.NativeFieldInfoPtr__previewTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefab.NativeFieldInfoPtr__previewTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0009F248 File Offset: 0x0009D448
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x0000CD63 File Offset: 0x0000AF63
		public unsafe Sprite _previewSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefab.NativeFieldInfoPtr__previewSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefab.NativeFieldInfoPtr__previewSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeFieldInfoPtr__unityPrefab;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeFieldInfoPtr__previewTexture;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeFieldInfoPtr__previewSprite;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_get_UnityPrefab_Public_get_GameObject_0;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeMethodInfoPtr_set_UnityPrefab_Public_set_Void_GameObject_0;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviewTexture_Public_get_Texture2D_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_set_PreviewTexture_Public_set_Void_Texture2D_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviewSprite_Public_get_Sprite_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_GameObject_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_GameObject_Vector3_Quaternion_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_GameObject_Vector3_Quaternion_Vector3_0;
	}
}
