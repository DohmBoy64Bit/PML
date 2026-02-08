using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using Polytoria.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B7 RID: 695
	public class UIImage : UIField
	{
		// Token: 0x06003CBF RID: 15551 RVA: 0x001120E8 File Offset: 0x001102E8
		// Note: this type is marked as 'beforefieldinit'.
		static UIImage()
		{
			Il2CppClassPointerStore<UIImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "UIImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIImage>.NativeClassPtr);
			UIImage.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "image");
			UIImage.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "color");
			UIImage.NativeFieldInfoPtr_imageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "imageID");
			UIImage.NativeFieldInfoPtr_imageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "imageType");
			UIImage.NativeFieldInfoPtr_clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "clickable");
			UIImage.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "loading");
			UIImage.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "texture");
			UIImage.NativeFieldInfoPtr_lastCacheKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "lastCacheKey");
			UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_color");
			UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_imageID");
			UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_imageType");
			UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImage>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_clickable");
			UIImage.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672653);
			UIImage.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672654);
			UIImage.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672655);
			UIImage.NativeMethodInfoPtr_get_ImageID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672656);
			UIImage.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672657);
			UIImage.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672658);
			UIImage.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672659);
			UIImage.NativeMethodInfoPtr_get_Clickable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672660);
			UIImage.NativeMethodInfoPtr_set_Clickable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672661);
			UIImage.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672676);
			UIImage.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672677);
			UIImage.NativeMethodInfoPtr_get_NetworkimageID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672678);
			UIImage.NativeMethodInfoPtr_set_NetworkimageID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672679);
			UIImage.NativeMethodInfoPtr_get_NetworkimageType_Public_get_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672680);
			UIImage.NativeMethodInfoPtr_set_NetworkimageType_Public_set_Void_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672681);
			UIImage.NativeMethodInfoPtr_get_Networkclickable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672682);
			UIImage.NativeMethodInfoPtr_set_Networkclickable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672683);
			UIImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672673);
			UIImage.NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672662);
			UIImage.NativeMethodInfoPtr_SetImage_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672663);
			UIImage.NativeMethodInfoPtr_SetImageType_Private_Void_ImageType_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672664);
			UIImage.NativeMethodInfoPtr_SyncSetClickable_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672665);
			UIImage.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672666);
			UIImage.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672667);
			UIImage.NativeMethodInfoPtr_LoadFallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672668);
			UIImage.NativeMethodInfoPtr_GetImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672669);
			UIImage.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672670);
			UIImage.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672671);
			UIImage.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672672);
			UIImage.NativeMethodInfoPtr__GetImage_b__29_0_Private_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672674);
			UIImage.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672675);
			UIImage.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672684);
			UIImage.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImage>.NativeClassPtr, 100672685);
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06003CC0 RID: 15552 RVA: 0x0011249C File Offset: 0x0011069C
		// (set) Token: 0x06003CC1 RID: 15553 RVA: 0x001124DC File Offset: 0x001106DC
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122046, RefRangeEnd = 122047, XrefRangeStart = 122043, XrefRangeEnd = 122046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06003CC2 RID: 15554 RVA: 0x00112520 File Offset: 0x00110720
		public unsafe bool Loading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x0011255C File Offset: 0x0011075C
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x00112594 File Offset: 0x00110794
		public unsafe string ImageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_get_ImageID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 122051, RefRangeEnd = 122054, XrefRangeStart = 122047, XrefRangeEnd = 122051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x001125D8 File Offset: 0x001107D8
		// (set) Token: 0x06003CC6 RID: 15558 RVA: 0x00112618 File Offset: 0x00110818
		public unsafe ImageType ImageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 122058, RefRangeEnd = 122060, XrefRangeStart = 122054, XrefRangeEnd = 122058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x0011265C File Offset: 0x0011085C
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x00112698 File Offset: 0x00110898
		public unsafe bool Clickable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_get_Clickable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 122064, RefRangeEnd = 122067, XrefRangeStart = 122060, XrefRangeEnd = 122064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_set_Clickable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x001126D8 File Offset: 0x001108D8
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x00112718 File Offset: 0x00110918
		public unsafe Color Networkcolor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122067, XrefRangeEnd = 122070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x0011275C File Offset: 0x0011095C
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x00112794 File Offset: 0x00110994
		public unsafe string NetworkimageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_get_NetworkimageID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122070, XrefRangeEnd = 122073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_set_NetworkimageID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x001127D8 File Offset: 0x001109D8
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x00112818 File Offset: 0x00110A18
		public unsafe ImageType NetworkimageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_get_NetworkimageType_Public_get_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122073, XrefRangeEnd = 122076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_set_NetworkimageType_Public_set_Void_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x0011285C File Offset: 0x00110A5C
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x00112898 File Offset: 0x00110A98
		public unsafe bool Networkclickable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_get_Networkclickable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122076, XrefRangeEnd = 122079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_set_Networkclickable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x001128D8 File Offset: 0x00110AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122079, XrefRangeEnd = 122112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIImage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x00112914 File Offset: 0x00110B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122112, XrefRangeEnd = 122116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetColor(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x00112968 File Offset: 0x00110B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122116, XrefRangeEnd = 122118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetImage(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_SetImage_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x001129BC File Offset: 0x00110BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122118, XrefRangeEnd = 122120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetImageType(ImageType oldValue, ImageType newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_SetImageType_Private_Void_ImageType_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00112A10 File Offset: 0x00110C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122120, XrefRangeEnd = 122122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSetClickable(bool oldValue, bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_SyncSetClickable_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x00112A5C File Offset: 0x00110C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122122, XrefRangeEnd = 122132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIImage.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x00112A98 File Offset: 0x00110C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIImage.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x00112AD4 File Offset: 0x00110CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122132, XrefRangeEnd = 122139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_LoadFallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00112B08 File Offset: 0x00110D08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 122161, RefRangeEnd = 122164, XrefRangeStart = 122139, XrefRangeEnd = 122161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr_GetImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x00112B3C File Offset: 0x00110D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122164, XrefRangeEnd = 122167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIImage.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x00112B78 File Offset: 0x00110D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122167, XrefRangeEnd = 122169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIImage.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x00112BB4 File Offset: 0x00110DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122169, XrefRangeEnd = 122183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIImage.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x00112C04 File Offset: 0x00110E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122183, XrefRangeEnd = 122191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetImage_b__29_0(ImageCacheKey key, ImageCacheEntry entry)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImage.NativeMethodInfoPtr__GetImage_b__29_0_Private_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00112C58 File Offset: 0x00110E58
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIImage.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x00112CA0 File Offset: 0x00110EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122191, XrefRangeEnd = 122201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIImage.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00112CFC File Offset: 0x00110EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122201, XrefRangeEnd = 122229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIImage.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x0001748A File Offset: 0x0001568A
		public UIImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x00112D58 File Offset: 0x00110F58
		// (set) Token: 0x06003CE3 RID: 15587 RVA: 0x00017493 File Offset: 0x00015693
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x00112D88 File Offset: 0x00110F88
		// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x000174B2 File Offset: 0x000156B2
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x00112DB8 File Offset: 0x00110FB8
		// (set) Token: 0x06003CE7 RID: 15591 RVA: 0x000174D1 File Offset: 0x000156D1
		public unsafe string imageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_imageID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_imageID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06003CE8 RID: 15592 RVA: 0x00112DE0 File Offset: 0x00110FE0
		// (set) Token: 0x06003CE9 RID: 15593 RVA: 0x000174F0 File Offset: 0x000156F0
		public unsafe ImageType imageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_imageType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_imageType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06003CEA RID: 15594 RVA: 0x00112E10 File Offset: 0x00111010
		// (set) Token: 0x06003CEB RID: 15595 RVA: 0x0001750F File Offset: 0x0001570F
		public unsafe bool clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_clickable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_clickable)) = value;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x00112E38 File Offset: 0x00111038
		// (set) Token: 0x06003CED RID: 15597 RVA: 0x0001752A File Offset: 0x0001572A
		public unsafe bool loading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_loading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_loading)) = value;
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06003CEE RID: 15598 RVA: 0x00112E60 File Offset: 0x00111060
		// (set) Token: 0x06003CEF RID: 15599 RVA: 0x00017545 File Offset: 0x00015745
		public unsafe Texture2D texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x00112E90 File Offset: 0x00111090
		// (set) Token: 0x06003CF1 RID: 15601 RVA: 0x00017564 File Offset: 0x00015764
		public unsafe ImageCacheKey lastCacheKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_lastCacheKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr_lastCacheKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06003CF2 RID: 15602 RVA: 0x00112EC0 File Offset: 0x001110C0
		// (set) Token: 0x06003CF3 RID: 15603 RVA: 0x00017583 File Offset: 0x00015783
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06003CF4 RID: 15604 RVA: 0x00112EF0 File Offset: 0x001110F0
		// (set) Token: 0x06003CF5 RID: 15605 RVA: 0x000175A2 File Offset: 0x000157A2
		public unsafe Action<string, string> _Mirror_SyncVarHookDelegate_imageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x00112F20 File Offset: 0x00111120
		// (set) Token: 0x06003CF7 RID: 15607 RVA: 0x000175C1 File Offset: 0x000157C1
		public unsafe Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ImageType, ImageType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x00112F50 File Offset: 0x00111150
		// (set) Token: 0x06003CF9 RID: 15609 RVA: 0x000175E0 File Offset: 0x000157E0
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImage.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F32 RID: 12082
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04002F33 RID: 12083
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04002F34 RID: 12084
		private static readonly IntPtr NativeFieldInfoPtr_imageID;

		// Token: 0x04002F35 RID: 12085
		private static readonly IntPtr NativeFieldInfoPtr_imageType;

		// Token: 0x04002F36 RID: 12086
		private static readonly IntPtr NativeFieldInfoPtr_clickable;

		// Token: 0x04002F37 RID: 12087
		private static readonly IntPtr NativeFieldInfoPtr_loading;

		// Token: 0x04002F38 RID: 12088
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x04002F39 RID: 12089
		private static readonly IntPtr NativeFieldInfoPtr_lastCacheKey;

		// Token: 0x04002F3A RID: 12090
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color;

		// Token: 0x04002F3B RID: 12091
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID;

		// Token: 0x04002F3C RID: 12092
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType;

		// Token: 0x04002F3D RID: 12093
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_clickable;

		// Token: 0x04002F3E RID: 12094
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04002F3F RID: 12095
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04002F40 RID: 12096
		private static readonly IntPtr NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0;

		// Token: 0x04002F41 RID: 12097
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageID_Public_get_String_0;

		// Token: 0x04002F42 RID: 12098
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0;

		// Token: 0x04002F43 RID: 12099
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0;

		// Token: 0x04002F44 RID: 12100
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0;

		// Token: 0x04002F45 RID: 12101
		private static readonly IntPtr NativeMethodInfoPtr_get_Clickable_Public_get_Boolean_0;

		// Token: 0x04002F46 RID: 12102
		private static readonly IntPtr NativeMethodInfoPtr_set_Clickable_Public_set_Void_Boolean_0;

		// Token: 0x04002F47 RID: 12103
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkcolor_Public_get_Color_0;

		// Token: 0x04002F48 RID: 12104
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_Color_0;

		// Token: 0x04002F49 RID: 12105
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkimageID_Public_get_String_0;

		// Token: 0x04002F4A RID: 12106
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkimageID_Public_set_Void_String_0;

		// Token: 0x04002F4B RID: 12107
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkimageType_Public_get_ImageType_0;

		// Token: 0x04002F4C RID: 12108
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkimageType_Public_set_Void_ImageType_0;

		// Token: 0x04002F4D RID: 12109
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkclickable_Public_get_Boolean_0;

		// Token: 0x04002F4E RID: 12110
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkclickable_Public_set_Void_Boolean_0;

		// Token: 0x04002F4F RID: 12111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F50 RID: 12112
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetColor_Private_Void_Color_Color_0;

		// Token: 0x04002F51 RID: 12113
		private static readonly IntPtr NativeMethodInfoPtr_SetImage_Private_Void_String_String_0;

		// Token: 0x04002F52 RID: 12114
		private static readonly IntPtr NativeMethodInfoPtr_SetImageType_Private_Void_ImageType_ImageType_0;

		// Token: 0x04002F53 RID: 12115
		private static readonly IntPtr NativeMethodInfoPtr_SyncSetClickable_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002F54 RID: 12116
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002F55 RID: 12117
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002F56 RID: 12118
		private static readonly IntPtr NativeMethodInfoPtr_LoadFallback_Private_Void_0;

		// Token: 0x04002F57 RID: 12119
		private static readonly IntPtr NativeMethodInfoPtr_GetImage_Private_Void_0;

		// Token: 0x04002F58 RID: 12120
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002F59 RID: 12121
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002F5A RID: 12122
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002F5B RID: 12123
		private static readonly IntPtr NativeMethodInfoPtr__GetImage_b__29_0_Private_Void_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x04002F5C RID: 12124
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002F5D RID: 12125
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002F5E RID: 12126
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
