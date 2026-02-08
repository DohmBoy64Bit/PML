using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using Polytoria.Controllers;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000275 RID: 629
	public class Decal : DynamicInstance
	{
		// Token: 0x060030BF RID: 12479 RVA: 0x000E005C File Offset: 0x000DE25C
		// Note: this type is marked as 'beforefieldinit'.
		static Decal()
		{
			Il2CppClassPointerStore<Decal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Decal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decal>.NativeClassPtr);
			Decal.NativeFieldInfoPtr_imageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "imageID");
			Decal.NativeFieldInfoPtr_imageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "imageType");
			Decal.NativeFieldInfoPtr_textureScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "textureScale");
			Decal.NativeFieldInfoPtr_textureOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "textureOffset");
			Decal.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "color");
			Decal.NativeFieldInfoPtr_castShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "castShadows");
			Decal.NativeFieldInfoPtr_lastCacheKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "lastCacheKey");
			Decal.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "col");
			Decal.NativeFieldInfoPtr_meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "meshRenderer");
			Decal.NativeFieldInfoPtr_currentEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "currentEntry");
			Decal.NativeFieldInfoPtr_transparentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "transparentMaterial");
			Decal.NativeFieldInfoPtr_cutoutMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "cutoutMaterial");
			Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_imageID");
			Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_imageType");
			Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textureScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_textureScale");
			Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textureOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_textureOffset");
			Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_color");
			Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_castShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_castShadows");
			Decal.NativeMethodInfoPtr_get_ImageID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670635);
			Decal.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670636);
			Decal.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670637);
			Decal.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670638);
			Decal.NativeMethodInfoPtr_get_TextureScale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670639);
			Decal.NativeMethodInfoPtr_set_TextureScale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670640);
			Decal.NativeMethodInfoPtr_get_TextureOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670641);
			Decal.NativeMethodInfoPtr_set_TextureOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670642);
			Decal.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670643);
			Decal.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670644);
			Decal.NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670645);
			Decal.NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670646);
			Decal.NativeMethodInfoPtr_get_NetworkimageID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670663);
			Decal.NativeMethodInfoPtr_set_NetworkimageID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670664);
			Decal.NativeMethodInfoPtr_get_NetworkimageType_Public_get_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670665);
			Decal.NativeMethodInfoPtr_set_NetworkimageType_Public_set_Void_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670666);
			Decal.NativeMethodInfoPtr_get_NetworktextureScale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670667);
			Decal.NativeMethodInfoPtr_set_NetworktextureScale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670668);
			Decal.NativeMethodInfoPtr_get_NetworktextureOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670669);
			Decal.NativeMethodInfoPtr_set_NetworktextureOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670670);
			Decal.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670671);
			Decal.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670672);
			Decal.NativeMethodInfoPtr_get_NetworkcastShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670673);
			Decal.NativeMethodInfoPtr_set_NetworkcastShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670674);
			Decal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670660);
			Decal.NativeMethodInfoPtr_SetTextureScale_Private_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670647);
			Decal.NativeMethodInfoPtr_SetTextureOffset_Private_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670648);
			Decal.NativeMethodInfoPtr_SetCastShadows_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670649);
			Decal.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670650);
			Decal.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670651);
			Decal.NativeMethodInfoPtr_SetImage_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670652);
			Decal.NativeMethodInfoPtr_SetImageType_Private_Void_ImageType_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670653);
			Decal.NativeMethodInfoPtr_SetColor_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670654);
			Decal.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670655);
			Decal.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670656);
			Decal.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670657);
			Decal.NativeMethodInfoPtr_GetImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670658);
			Decal.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670659);
			Decal.NativeMethodInfoPtr__GetImage_b__41_0_Private_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670661);
			Decal.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670662);
			Decal.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670675);
			Decal.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100670676);
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x000E053C File Offset: 0x000DE73C
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x000E0574 File Offset: 0x000DE774
		public unsafe string ImageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_ImageID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101190, RefRangeEnd = 101193, XrefRangeStart = 101186, XrefRangeEnd = 101190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x000E05B8 File Offset: 0x000DE7B8
		// (set) Token: 0x060030C3 RID: 12483 RVA: 0x000E05F8 File Offset: 0x000DE7F8
		public unsafe ImageType ImageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101206, RefRangeEnd = 101209, XrefRangeStart = 101193, XrefRangeEnd = 101206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x000E063C File Offset: 0x000DE83C
		// (set) Token: 0x060030C5 RID: 12485 RVA: 0x000E067C File Offset: 0x000DE87C
		public unsafe Vector2 TextureScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_TextureScale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101215, RefRangeEnd = 101218, XrefRangeStart = 101209, XrefRangeEnd = 101215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_TextureScale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x000E06C0 File Offset: 0x000DE8C0
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x000E0700 File Offset: 0x000DE900
		public unsafe Vector2 TextureOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_TextureOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101224, RefRangeEnd = 101227, XrefRangeStart = 101218, XrefRangeEnd = 101224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_TextureOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x000E0744 File Offset: 0x000DE944
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x000E0784 File Offset: 0x000DE984
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 101248, RefRangeEnd = 101252, XrefRangeStart = 101227, XrefRangeEnd = 101248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x000E07C8 File Offset: 0x000DE9C8
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x000E0804 File Offset: 0x000DEA04
		public unsafe bool CastShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101257, RefRangeEnd = 101260, XrefRangeStart = 101252, XrefRangeEnd = 101257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x000E0844 File Offset: 0x000DEA44
		// (set) Token: 0x060030CD RID: 12493 RVA: 0x000E087C File Offset: 0x000DEA7C
		public unsafe string NetworkimageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_NetworkimageID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101260, XrefRangeEnd = 101263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_NetworkimageID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x060030CE RID: 12494 RVA: 0x000E08C0 File Offset: 0x000DEAC0
		// (set) Token: 0x060030CF RID: 12495 RVA: 0x000E0900 File Offset: 0x000DEB00
		public unsafe ImageType NetworkimageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_NetworkimageType_Public_get_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101263, XrefRangeEnd = 101275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_NetworkimageType_Public_set_Void_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x000E0944 File Offset: 0x000DEB44
		// (set) Token: 0x060030D1 RID: 12497 RVA: 0x000E0984 File Offset: 0x000DEB84
		public unsafe Vector2 NetworktextureScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_NetworktextureScale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101275, XrefRangeEnd = 101278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_NetworktextureScale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x060030D2 RID: 12498 RVA: 0x000E09C8 File Offset: 0x000DEBC8
		// (set) Token: 0x060030D3 RID: 12499 RVA: 0x000E0A08 File Offset: 0x000DEC08
		public unsafe Vector2 NetworktextureOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_NetworktextureOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101278, XrefRangeEnd = 101281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_NetworktextureOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x000E0A4C File Offset: 0x000DEC4C
		// (set) Token: 0x060030D5 RID: 12501 RVA: 0x000E0A8C File Offset: 0x000DEC8C
		public unsafe Color Networkcolor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101281, XrefRangeEnd = 101284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x000E0AD0 File Offset: 0x000DECD0
		// (set) Token: 0x060030D7 RID: 12503 RVA: 0x000E0B0C File Offset: 0x000DED0C
		public unsafe bool NetworkcastShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_get_NetworkcastShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101284, XrefRangeEnd = 101287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_set_NetworkcastShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x000E0B4C File Offset: 0x000DED4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101287, XrefRangeEnd = 101340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Decal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x000E0B88 File Offset: 0x000DED88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101340, XrefRangeEnd = 101342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureScale(Vector2 oldScale, Vector2 newScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldScale);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newScale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_SetTextureScale_Private_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x000E0BDC File Offset: 0x000DEDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101342, XrefRangeEnd = 101344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureOffset(Vector2 oldOffset, Vector2 newOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldOffset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newOffset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_SetTextureOffset_Private_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x000E0C30 File Offset: 0x000DEE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101344, XrefRangeEnd = 101346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCastShadows(bool oldShadows, bool newShadows)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldShadows;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newShadows;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_SetCastShadows_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x000E0C7C File Offset: 0x000DEE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101346, XrefRangeEnd = 101352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000E0CB8 File Offset: 0x000DEEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101352, XrefRangeEnd = 101358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x000E0CF4 File Offset: 0x000DEEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101358, XrefRangeEnd = 101360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetImage(string oldId, string newId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_SetImage_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x000E0D48 File Offset: 0x000DEF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101360, XrefRangeEnd = 101362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetImageType(ImageType oldType, ImageType newType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_SetImageType_Private_Void_ImageType_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x000E0D9C File Offset: 0x000DEF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101362, XrefRangeEnd = 101364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color oldColor, Color newColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldColor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newColor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_SetColor_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x000E0DF0 File Offset: 0x000DEFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101364, XrefRangeEnd = 101384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x000E0E2C File Offset: 0x000DF02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101384, XrefRangeEnd = 101391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x000E0E68 File Offset: 0x000DF068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101391, XrefRangeEnd = 101392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000E0EA4 File Offset: 0x000DF0A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101408, RefRangeEnd = 101410, XrefRangeStart = 101392, XrefRangeEnd = 101408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_GetImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x000E0ED8 File Offset: 0x000DF0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101410, XrefRangeEnd = 101431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x000E0F28 File Offset: 0x000DF128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101431, XrefRangeEnd = 101437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetImage_b__41_0(ImageCacheKey key, ImageCacheEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr__GetImage_b__41_0_Private_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000E0F7C File Offset: 0x000DF17C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x000E0FC4 File Offset: 0x000DF1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101437, XrefRangeEnd = 101464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x000E1020 File Offset: 0x000DF220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101464, XrefRangeEnd = 101505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000135DE File Offset: 0x000117DE
		public Decal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x000E107C File Offset: 0x000DF27C
		// (set) Token: 0x060030EC RID: 12524 RVA: 0x000135E7 File Offset: 0x000117E7
		public unsafe string imageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_imageID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_imageID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x000E10A4 File Offset: 0x000DF2A4
		// (set) Token: 0x060030EE RID: 12526 RVA: 0x00013606 File Offset: 0x00011806
		public unsafe ImageType imageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_imageType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_imageType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x000E10D4 File Offset: 0x000DF2D4
		// (set) Token: 0x060030F0 RID: 12528 RVA: 0x00013625 File Offset: 0x00011825
		public unsafe Vector2 textureScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_textureScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_textureScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x000E1104 File Offset: 0x000DF304
		// (set) Token: 0x060030F2 RID: 12530 RVA: 0x00013644 File Offset: 0x00011844
		public unsafe Vector2 textureOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_textureOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_textureOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x060030F3 RID: 12531 RVA: 0x000E1134 File Offset: 0x000DF334
		// (set) Token: 0x060030F4 RID: 12532 RVA: 0x00013663 File Offset: 0x00011863
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x060030F5 RID: 12533 RVA: 0x000E1164 File Offset: 0x000DF364
		// (set) Token: 0x060030F6 RID: 12534 RVA: 0x00013682 File Offset: 0x00011882
		public unsafe bool castShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_castShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_castShadows)) = value;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x060030F7 RID: 12535 RVA: 0x000E118C File Offset: 0x000DF38C
		// (set) Token: 0x060030F8 RID: 12536 RVA: 0x0001369D File Offset: 0x0001189D
		public unsafe ImageCacheKey lastCacheKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_lastCacheKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_lastCacheKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x000E11BC File Offset: 0x000DF3BC
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x000136BC File Offset: 0x000118BC
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x000E11EC File Offset: 0x000DF3EC
		// (set) Token: 0x060030FC RID: 12540 RVA: 0x000136DB File Offset: 0x000118DB
		public unsafe MeshRenderer meshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_meshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_meshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x000E121C File Offset: 0x000DF41C
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x000136FA File Offset: 0x000118FA
		public unsafe ImageCacheEntry currentEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_currentEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_currentEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x000E124C File Offset: 0x000DF44C
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x00013719 File Offset: 0x00011919
		public unsafe Material transparentMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_transparentMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_transparentMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x000E127C File Offset: 0x000DF47C
		// (set) Token: 0x06003102 RID: 12546 RVA: 0x00013738 File Offset: 0x00011938
		public unsafe Material cutoutMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_cutoutMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_cutoutMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x000E12AC File Offset: 0x000DF4AC
		// (set) Token: 0x06003104 RID: 12548 RVA: 0x00013757 File Offset: 0x00011957
		public unsafe Action<string, string> _Mirror_SyncVarHookDelegate_imageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x000E12DC File Offset: 0x000DF4DC
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x00013776 File Offset: 0x00011976
		public unsafe Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ImageType, ImageType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x000E130C File Offset: 0x000DF50C
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x00013795 File Offset: 0x00011995
		public unsafe Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textureScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textureScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000E133C File Offset: 0x000DF53C
		// (set) Token: 0x0600310A RID: 12554 RVA: 0x000137B4 File Offset: 0x000119B4
		public unsafe Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textureOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textureOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x000E136C File Offset: 0x000DF56C
		// (set) Token: 0x0600310C RID: 12556 RVA: 0x000137D3 File Offset: 0x000119D3
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x000E139C File Offset: 0x000DF59C
		// (set) Token: 0x0600310E RID: 12558 RVA: 0x000137F2 File Offset: 0x000119F2
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_castShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_castShadows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_castShadows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeFieldInfoPtr_imageID;

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeFieldInfoPtr_imageType;

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeFieldInfoPtr_textureScale;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeFieldInfoPtr_textureOffset;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeFieldInfoPtr_castShadows;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeFieldInfoPtr_lastCacheKey;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeFieldInfoPtr_meshRenderer;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeFieldInfoPtr_currentEntry;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeFieldInfoPtr_transparentMaterial;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeFieldInfoPtr_cutoutMaterial;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textureScale;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_textureOffset;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_castShadows;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageID_Public_get_String_0;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeMethodInfoPtr_get_TextureScale_Public_get_Vector2_0;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeMethodInfoPtr_set_TextureScale_Public_set_Void_Vector2_0;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeMethodInfoPtr_get_TextureOffset_Public_get_Vector2_0;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_set_TextureOffset_Public_set_Void_Vector2_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeMethodInfoPtr_get_CastShadows_Public_get_Boolean_0;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeMethodInfoPtr_set_CastShadows_Public_set_Void_Boolean_0;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkimageID_Public_get_String_0;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkimageID_Public_set_Void_String_0;

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkimageType_Public_get_ImageType_0;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkimageType_Public_set_Void_ImageType_0;

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworktextureScale_Public_get_Vector2_0;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworktextureScale_Public_set_Void_Vector2_0;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworktextureOffset_Public_get_Vector2_0;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworktextureOffset_Public_set_Void_Vector2_0;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkcastShadows_Public_get_Boolean_0;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkcastShadows_Public_set_Void_Boolean_0;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureScale_Private_Void_Vector2_Vector2_0;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureOffset_Private_Void_Vector2_Vector2_0;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeMethodInfoPtr_SetCastShadows_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeMethodInfoPtr_SetImage_Private_Void_String_String_0;

		// Token: 0x04002578 RID: 9592
		private static readonly IntPtr NativeMethodInfoPtr_SetImageType_Private_Void_ImageType_ImageType_0;

		// Token: 0x04002579 RID: 9593
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Private_Void_Color_Color_0;

		// Token: 0x0400257A RID: 9594
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400257B RID: 9595
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400257C RID: 9596
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeMethodInfoPtr_GetImage_Private_Void_0;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeMethodInfoPtr__GetImage_b__41_0_Private_Void_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
