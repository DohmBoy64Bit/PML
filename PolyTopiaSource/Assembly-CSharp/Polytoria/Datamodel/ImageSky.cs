using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Mirror;
using UnityEngine.Networking;

namespace Polytoria.Datamodel
{
	// Token: 0x02000281 RID: 641
	public class ImageSky : SkyBase
	{
		// Token: 0x060032F2 RID: 13042 RVA: 0x000E9018 File Offset: 0x000E7218
		// Note: this type is marked as 'beforefieldinit'.
		static ImageSky()
		{
			Il2CppClassPointerStore<ImageSky>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "ImageSky");
			ImageSky.NativeFieldInfoPtr_topTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "topTextureName");
			ImageSky.NativeFieldInfoPtr_bottomTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "bottomTextureName");
			ImageSky.NativeFieldInfoPtr_leftTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "leftTextureName");
			ImageSky.NativeFieldInfoPtr_rightTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "rightTextureName");
			ImageSky.NativeFieldInfoPtr_frontTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "frontTextureName");
			ImageSky.NativeFieldInfoPtr_backTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "backTextureName");
			ImageSky.NativeFieldInfoPtr_processing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "processing");
			ImageSky.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "topId");
			ImageSky.NativeFieldInfoPtr_bottomId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "bottomId");
			ImageSky.NativeFieldInfoPtr_leftId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "leftId");
			ImageSky.NativeFieldInfoPtr_rightId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "rightId");
			ImageSky.NativeFieldInfoPtr_frontId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "frontId");
			ImageSky.NativeFieldInfoPtr_backId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "backId");
			ImageSky.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "queue");
			ImageSky.NativeMethodInfoPtr_get_TopId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670975);
			ImageSky.NativeMethodInfoPtr_set_TopId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670976);
			ImageSky.NativeMethodInfoPtr_get_BottomId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670977);
			ImageSky.NativeMethodInfoPtr_set_BottomId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670978);
			ImageSky.NativeMethodInfoPtr_get_LeftId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670979);
			ImageSky.NativeMethodInfoPtr_set_LeftId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670980);
			ImageSky.NativeMethodInfoPtr_get_RightId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670981);
			ImageSky.NativeMethodInfoPtr_set_RightId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670982);
			ImageSky.NativeMethodInfoPtr_get_FrontId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670983);
			ImageSky.NativeMethodInfoPtr_set_FrontId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670984);
			ImageSky.NativeMethodInfoPtr_get_BackId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670985);
			ImageSky.NativeMethodInfoPtr_set_BackId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670986);
			ImageSky.NativeMethodInfoPtr_get_NetworktopId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670996);
			ImageSky.NativeMethodInfoPtr_set_NetworktopId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670997);
			ImageSky.NativeMethodInfoPtr_get_NetworkbottomId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670998);
			ImageSky.NativeMethodInfoPtr_set_NetworkbottomId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670999);
			ImageSky.NativeMethodInfoPtr_get_NetworkleftId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671000);
			ImageSky.NativeMethodInfoPtr_set_NetworkleftId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671001);
			ImageSky.NativeMethodInfoPtr_get_NetworkrightId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671002);
			ImageSky.NativeMethodInfoPtr_set_NetworkrightId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671003);
			ImageSky.NativeMethodInfoPtr_get_NetworkfrontId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671004);
			ImageSky.NativeMethodInfoPtr_set_NetworkfrontId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671005);
			ImageSky.NativeMethodInfoPtr_get_NetworkbackId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671006);
			ImageSky.NativeMethodInfoPtr_set_NetworkbackId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671007);
			ImageSky.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670993);
			ImageSky.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670987);
			ImageSky.NativeMethodInfoPtr_Apply_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670988);
			ImageSky.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670989);
			ImageSky.NativeMethodInfoPtr_LoadSkyboxImage_Private_IEnumerator_ImageLoadQueueEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670990);
			ImageSky.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670991);
			ImageSky.NativeMethodInfoPtr_RpcSetImageId_Private_Void_SkyboxSide_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670992);
			ImageSky.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100670995);
			ImageSky.NativeMethodInfoPtr_UserCode_RpcSetImageId__SkyboxSide__Int32_Protected_Void_SkyboxSide_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671008);
			ImageSky.NativeMethodInfoPtr_InvokeUserCode_RpcSetImageId__SkyboxSide__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671009);
			ImageSky.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671010);
			ImageSky.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, 100671011);
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x000E9428 File Offset: 0x000E7628
		// (set) Token: 0x060032F4 RID: 13044 RVA: 0x000E9464 File Offset: 0x000E7664
		public unsafe int TopId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_TopId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 104203, RefRangeEnd = 104208, XrefRangeStart = 104187, XrefRangeEnd = 104203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_TopId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x000E94A4 File Offset: 0x000E76A4
		// (set) Token: 0x060032F6 RID: 13046 RVA: 0x000E94E0 File Offset: 0x000E76E0
		public unsafe int BottomId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_BottomId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 104224, RefRangeEnd = 104228, XrefRangeStart = 104208, XrefRangeEnd = 104224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_BottomId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x060032F7 RID: 13047 RVA: 0x000E9520 File Offset: 0x000E7720
		// (set) Token: 0x060032F8 RID: 13048 RVA: 0x000E955C File Offset: 0x000E775C
		public unsafe int LeftId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_LeftId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 104244, RefRangeEnd = 104248, XrefRangeStart = 104228, XrefRangeEnd = 104244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_LeftId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x060032F9 RID: 13049 RVA: 0x000E959C File Offset: 0x000E779C
		// (set) Token: 0x060032FA RID: 13050 RVA: 0x000E95D8 File Offset: 0x000E77D8
		public unsafe int RightId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_RightId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 104264, RefRangeEnd = 104268, XrefRangeStart = 104248, XrefRangeEnd = 104264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_RightId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x060032FB RID: 13051 RVA: 0x000E9618 File Offset: 0x000E7818
		// (set) Token: 0x060032FC RID: 13052 RVA: 0x000E9654 File Offset: 0x000E7854
		public unsafe int FrontId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_FrontId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 104284, RefRangeEnd = 104288, XrefRangeStart = 104268, XrefRangeEnd = 104284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_FrontId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x060032FD RID: 13053 RVA: 0x000E9694 File Offset: 0x000E7894
		// (set) Token: 0x060032FE RID: 13054 RVA: 0x000E96D0 File Offset: 0x000E78D0
		public unsafe int BackId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_BackId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 104304, RefRangeEnd = 104308, XrefRangeStart = 104288, XrefRangeEnd = 104304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_BackId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060032FF RID: 13055 RVA: 0x000E9710 File Offset: 0x000E7910
		// (set) Token: 0x06003300 RID: 13056 RVA: 0x000E974C File Offset: 0x000E794C
		public unsafe int NetworktopId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_NetworktopId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104308, XrefRangeEnd = 104314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_NetworktopId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06003301 RID: 13057 RVA: 0x000E978C File Offset: 0x000E798C
		// (set) Token: 0x06003302 RID: 13058 RVA: 0x000E97C8 File Offset: 0x000E79C8
		public unsafe int NetworkbottomId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_NetworkbottomId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104314, XrefRangeEnd = 104320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_NetworkbottomId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06003303 RID: 13059 RVA: 0x000E9808 File Offset: 0x000E7A08
		// (set) Token: 0x06003304 RID: 13060 RVA: 0x000E9844 File Offset: 0x000E7A44
		public unsafe int NetworkleftId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_NetworkleftId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104320, XrefRangeEnd = 104326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_NetworkleftId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x000E9884 File Offset: 0x000E7A84
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x000E98C0 File Offset: 0x000E7AC0
		public unsafe int NetworkrightId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_NetworkrightId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104326, XrefRangeEnd = 104332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_NetworkrightId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x000E9900 File Offset: 0x000E7B00
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x000E993C File Offset: 0x000E7B3C
		public unsafe int NetworkfrontId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_NetworkfrontId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104332, XrefRangeEnd = 104338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_NetworkfrontId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x000E997C File Offset: 0x000E7B7C
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x000E99B8 File Offset: 0x000E7BB8
		public unsafe int NetworkbackId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_get_NetworkbackId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104338, XrefRangeEnd = 104344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_set_NetworkbackId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000E99F8 File Offset: 0x000E7BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104344, XrefRangeEnd = 104352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageSky()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageSky>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000E9A34 File Offset: 0x000E7C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104352, XrefRangeEnd = 104360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageSky.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x000E9A70 File Offset: 0x000E7C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104360, XrefRangeEnd = 104399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageSky.NativeMethodInfoPtr_Apply_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x000E9AAC File Offset: 0x000E7CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104399, XrefRangeEnd = 104410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x000E9AE0 File Offset: 0x000E7CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104410, XrefRangeEnd = 104416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadSkyboxImage(ImageSky.ImageLoadQueueEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_LoadSkyboxImage_Private_IEnumerator_ImageLoadQueueEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x000E9B38 File Offset: 0x000E7D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104416, XrefRangeEnd = 104427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageSky.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x000E9B88 File Offset: 0x000E7D88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 104449, RefRangeEnd = 104455, XrefRangeStart = 104427, XrefRangeEnd = 104449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetImageId(ImageSky.SkyboxSide side, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref side;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_RpcSetImageId_Private_Void_SkyboxSide_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x000E9BD4 File Offset: 0x000E7DD4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageSky.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x000E9C1C File Offset: 0x000E7E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104455, XrefRangeEnd = 104462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetImageId__SkyboxSide__Int32(ImageSky.SkyboxSide side, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref side;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_UserCode_RpcSetImageId__SkyboxSide__Int32_Protected_Void_SkyboxSide_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x000E9C68 File Offset: 0x000E7E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104462, XrefRangeEnd = 104474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetImageId__SkyboxSide__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.NativeMethodInfoPtr_InvokeUserCode_RpcSetImageId__SkyboxSide__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000E9CC4 File Offset: 0x000E7EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104474, XrefRangeEnd = 104491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageSky.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000E9D20 File Offset: 0x000E7F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104491, XrefRangeEnd = 104528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageSky.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00014297 File Offset: 0x00012497
		public ImageSky(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06003318 RID: 13080 RVA: 0x000E9D7C File Offset: 0x000E7F7C
		// (set) Token: 0x06003319 RID: 13081 RVA: 0x000142A0 File Offset: 0x000124A0
		public unsafe static string topTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImageSky.NativeFieldInfoPtr_topTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageSky.NativeFieldInfoPtr_topTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x0600331A RID: 13082 RVA: 0x000E9D9C File Offset: 0x000E7F9C
		// (set) Token: 0x0600331B RID: 13083 RVA: 0x000142B2 File Offset: 0x000124B2
		public unsafe static string bottomTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImageSky.NativeFieldInfoPtr_bottomTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageSky.NativeFieldInfoPtr_bottomTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600331C RID: 13084 RVA: 0x000E9DBC File Offset: 0x000E7FBC
		// (set) Token: 0x0600331D RID: 13085 RVA: 0x000142C4 File Offset: 0x000124C4
		public unsafe static string leftTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImageSky.NativeFieldInfoPtr_leftTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageSky.NativeFieldInfoPtr_leftTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x000E9DDC File Offset: 0x000E7FDC
		// (set) Token: 0x0600331F RID: 13087 RVA: 0x000142D6 File Offset: 0x000124D6
		public unsafe static string rightTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImageSky.NativeFieldInfoPtr_rightTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageSky.NativeFieldInfoPtr_rightTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06003320 RID: 13088 RVA: 0x000E9DFC File Offset: 0x000E7FFC
		// (set) Token: 0x06003321 RID: 13089 RVA: 0x000142E8 File Offset: 0x000124E8
		public unsafe static string frontTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImageSky.NativeFieldInfoPtr_frontTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageSky.NativeFieldInfoPtr_frontTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x000E9E1C File Offset: 0x000E801C
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x000142FA File Offset: 0x000124FA
		public unsafe static string backTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImageSky.NativeFieldInfoPtr_backTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageSky.NativeFieldInfoPtr_backTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x000E9E3C File Offset: 0x000E803C
		// (set) Token: 0x06003325 RID: 13093 RVA: 0x0001430C File Offset: 0x0001250C
		public unsafe bool processing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_processing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_processing)) = value;
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x000E9E64 File Offset: 0x000E8064
		// (set) Token: 0x06003327 RID: 13095 RVA: 0x00014327 File Offset: 0x00012527
		public unsafe int topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x000E9E8C File Offset: 0x000E808C
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x00014342 File Offset: 0x00012542
		public unsafe int bottomId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_bottomId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_bottomId)) = value;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x000E9EB4 File Offset: 0x000E80B4
		// (set) Token: 0x0600332B RID: 13099 RVA: 0x0001435D File Offset: 0x0001255D
		public unsafe int leftId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_leftId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_leftId)) = value;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x000E9EDC File Offset: 0x000E80DC
		// (set) Token: 0x0600332D RID: 13101 RVA: 0x00014378 File Offset: 0x00012578
		public unsafe int rightId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_rightId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_rightId)) = value;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x0600332E RID: 13102 RVA: 0x000E9F04 File Offset: 0x000E8104
		// (set) Token: 0x0600332F RID: 13103 RVA: 0x00014393 File Offset: 0x00012593
		public unsafe int frontId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_frontId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_frontId)) = value;
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06003330 RID: 13104 RVA: 0x000E9F2C File Offset: 0x000E812C
		// (set) Token: 0x06003331 RID: 13105 RVA: 0x000143AE File Offset: 0x000125AE
		public unsafe int backId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_backId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_backId)) = value;
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06003332 RID: 13106 RVA: 0x000E9F54 File Offset: 0x000E8154
		// (set) Token: 0x06003333 RID: 13107 RVA: 0x000143C9 File Offset: 0x000125C9
		public unsafe Queue<ImageSky.ImageLoadQueueEntry> queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ImageSky.ImageLoadQueueEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002721 RID: 10017
		private static readonly IntPtr NativeFieldInfoPtr_topTextureName;

		// Token: 0x04002722 RID: 10018
		private static readonly IntPtr NativeFieldInfoPtr_bottomTextureName;

		// Token: 0x04002723 RID: 10019
		private static readonly IntPtr NativeFieldInfoPtr_leftTextureName;

		// Token: 0x04002724 RID: 10020
		private static readonly IntPtr NativeFieldInfoPtr_rightTextureName;

		// Token: 0x04002725 RID: 10021
		private static readonly IntPtr NativeFieldInfoPtr_frontTextureName;

		// Token: 0x04002726 RID: 10022
		private static readonly IntPtr NativeFieldInfoPtr_backTextureName;

		// Token: 0x04002727 RID: 10023
		private static readonly IntPtr NativeFieldInfoPtr_processing;

		// Token: 0x04002728 RID: 10024
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04002729 RID: 10025
		private static readonly IntPtr NativeFieldInfoPtr_bottomId;

		// Token: 0x0400272A RID: 10026
		private static readonly IntPtr NativeFieldInfoPtr_leftId;

		// Token: 0x0400272B RID: 10027
		private static readonly IntPtr NativeFieldInfoPtr_rightId;

		// Token: 0x0400272C RID: 10028
		private static readonly IntPtr NativeFieldInfoPtr_frontId;

		// Token: 0x0400272D RID: 10029
		private static readonly IntPtr NativeFieldInfoPtr_backId;

		// Token: 0x0400272E RID: 10030
		private static readonly IntPtr NativeFieldInfoPtr_queue;

		// Token: 0x0400272F RID: 10031
		private static readonly IntPtr NativeMethodInfoPtr_get_TopId_Public_get_Int32_0;

		// Token: 0x04002730 RID: 10032
		private static readonly IntPtr NativeMethodInfoPtr_set_TopId_Public_set_Void_Int32_0;

		// Token: 0x04002731 RID: 10033
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomId_Public_get_Int32_0;

		// Token: 0x04002732 RID: 10034
		private static readonly IntPtr NativeMethodInfoPtr_set_BottomId_Public_set_Void_Int32_0;

		// Token: 0x04002733 RID: 10035
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftId_Public_get_Int32_0;

		// Token: 0x04002734 RID: 10036
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftId_Public_set_Void_Int32_0;

		// Token: 0x04002735 RID: 10037
		private static readonly IntPtr NativeMethodInfoPtr_get_RightId_Public_get_Int32_0;

		// Token: 0x04002736 RID: 10038
		private static readonly IntPtr NativeMethodInfoPtr_set_RightId_Public_set_Void_Int32_0;

		// Token: 0x04002737 RID: 10039
		private static readonly IntPtr NativeMethodInfoPtr_get_FrontId_Public_get_Int32_0;

		// Token: 0x04002738 RID: 10040
		private static readonly IntPtr NativeMethodInfoPtr_set_FrontId_Public_set_Void_Int32_0;

		// Token: 0x04002739 RID: 10041
		private static readonly IntPtr NativeMethodInfoPtr_get_BackId_Public_get_Int32_0;

		// Token: 0x0400273A RID: 10042
		private static readonly IntPtr NativeMethodInfoPtr_set_BackId_Public_set_Void_Int32_0;

		// Token: 0x0400273B RID: 10043
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworktopId_Public_get_Int32_0;

		// Token: 0x0400273C RID: 10044
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworktopId_Public_set_Void_Int32_0;

		// Token: 0x0400273D RID: 10045
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkbottomId_Public_get_Int32_0;

		// Token: 0x0400273E RID: 10046
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkbottomId_Public_set_Void_Int32_0;

		// Token: 0x0400273F RID: 10047
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkleftId_Public_get_Int32_0;

		// Token: 0x04002740 RID: 10048
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkleftId_Public_set_Void_Int32_0;

		// Token: 0x04002741 RID: 10049
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkrightId_Public_get_Int32_0;

		// Token: 0x04002742 RID: 10050
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkrightId_Public_set_Void_Int32_0;

		// Token: 0x04002743 RID: 10051
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkfrontId_Public_get_Int32_0;

		// Token: 0x04002744 RID: 10052
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkfrontId_Public_set_Void_Int32_0;

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkbackId_Public_get_Int32_0;

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkbackId_Public_set_Void_Int32_0;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Protected_Virtual_Void_0;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeMethodInfoPtr_LoadSkyboxImage_Private_IEnumerator_ImageLoadQueueEntry_0;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetImageId_Private_Void_SkyboxSide_Int32_0;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetImageId__SkyboxSide__Int32_Protected_Void_SkyboxSide_Int32_0;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetImageId__SkyboxSide__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;

		// Token: 0x020003F0 RID: 1008
		public sealed class ImageLoadQueueEntry : ValueType
		{
			// Token: 0x06004DF3 RID: 19955 RVA: 0x00151C2C File Offset: 0x0014FE2C
			// Note: this type is marked as 'beforefieldinit'.
			static ImageLoadQueueEntry()
			{
				Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "ImageLoadQueueEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr);
				ImageSky.ImageLoadQueueEntry.NativeFieldInfoPtr__TextureName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr, "<TextureName>k__BackingField");
				ImageSky.ImageLoadQueueEntry.NativeFieldInfoPtr__ImageId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr, "<ImageId>k__BackingField");
				ImageSky.ImageLoadQueueEntry.NativeMethodInfoPtr_get_TextureName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr, 100671012);
				ImageSky.ImageLoadQueueEntry.NativeMethodInfoPtr_set_TextureName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr, 100671013);
				ImageSky.ImageLoadQueueEntry.NativeMethodInfoPtr_get_ImageId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr, 100671014);
				ImageSky.ImageLoadQueueEntry.NativeMethodInfoPtr_set_ImageId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr, 100671015);
			}

			// Token: 0x17001A46 RID: 6726
			// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x00151CD0 File Offset: 0x0014FED0
			// (set) Token: 0x06004DF5 RID: 19957 RVA: 0x00151D0C File Offset: 0x0014FF0C
			public unsafe string TextureName
			{
				[CallerCount(116)]
				[CachedScanResults(RefRangeStart = 24169, RefRangeEnd = 24285, XrefRangeStart = 24169, XrefRangeEnd = 24285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.ImageLoadQueueEntry.NativeMethodInfoPtr_get_TextureName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 104073, RefRangeEnd = 104083, XrefRangeStart = 104072, XrefRangeEnd = 104073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.ImageLoadQueueEntry.NativeMethodInfoPtr_set_TextureName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001A47 RID: 6727
			// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x00151D54 File Offset: 0x0014FF54
			// (set) Token: 0x06004DF7 RID: 19959 RVA: 0x00151D98 File Offset: 0x0014FF98
			public unsafe int ImageId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.ImageLoadQueueEntry.NativeMethodInfoPtr_get_ImageId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 58133, RefRangeEnd = 58136, XrefRangeStart = 58133, XrefRangeEnd = 58136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky.ImageLoadQueueEntry.NativeMethodInfoPtr_set_ImageId_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004DF8 RID: 19960 RVA: 0x0001D877 File Offset: 0x0001BA77
			public ImageLoadQueueEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004DF9 RID: 19961 RVA: 0x0001D880 File Offset: 0x0001BA80
			public ImageLoadQueueEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17001A44 RID: 6724
			// (get) Token: 0x06004DFA RID: 19962 RVA: 0x00151DDC File Offset: 0x0014FFDC
			// (set) Token: 0x06004DFB RID: 19963 RVA: 0x0001D892 File Offset: 0x0001BA92
			public unsafe string _TextureName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.ImageLoadQueueEntry.NativeFieldInfoPtr__TextureName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.ImageLoadQueueEntry.NativeFieldInfoPtr__TextureName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001A45 RID: 6725
			// (get) Token: 0x06004DFC RID: 19964 RVA: 0x00151E04 File Offset: 0x00150004
			// (set) Token: 0x06004DFD RID: 19965 RVA: 0x0001D8B1 File Offset: 0x0001BAB1
			public unsafe int _ImageId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.ImageLoadQueueEntry.NativeFieldInfoPtr__ImageId_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky.ImageLoadQueueEntry.NativeFieldInfoPtr__ImageId_k__BackingField)) = value;
				}
			}

			// Token: 0x04003C6A RID: 15466
			private static readonly IntPtr NativeFieldInfoPtr__TextureName_k__BackingField;

			// Token: 0x04003C6B RID: 15467
			private static readonly IntPtr NativeFieldInfoPtr__ImageId_k__BackingField;

			// Token: 0x04003C6C RID: 15468
			private static readonly IntPtr NativeMethodInfoPtr_get_TextureName_Public_get_String_0;

			// Token: 0x04003C6D RID: 15469
			private static readonly IntPtr NativeMethodInfoPtr_set_TextureName_Public_set_Void_String_0;

			// Token: 0x04003C6E RID: 15470
			private static readonly IntPtr NativeMethodInfoPtr_get_ImageId_Public_get_Int32_0;

			// Token: 0x04003C6F RID: 15471
			private static readonly IntPtr NativeMethodInfoPtr_set_ImageId_Public_set_Void_Int32_0;
		}

		// Token: 0x020003F1 RID: 1009
		public enum SkyboxSide
		{
			// Token: 0x04003C71 RID: 15473
			Top,
			// Token: 0x04003C72 RID: 15474
			Bottom,
			// Token: 0x04003C73 RID: 15475
			Left,
			// Token: 0x04003C74 RID: 15476
			Right,
			// Token: 0x04003C75 RID: 15477
			Front,
			// Token: 0x04003C76 RID: 15478
			Back
		}

		// Token: 0x020003F2 RID: 1010
		[ObfuscatedName("Polytoria.Datamodel.ImageSky+<LoadSkyboxImage>d__35")]
		public sealed class _LoadSkyboxImage_d__35 : Object
		{
			// Token: 0x06004DFE RID: 19966 RVA: 0x00151E2C File Offset: 0x0015002C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadSkyboxImage_d__35()
			{
				Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageSky>.NativeClassPtr, "<LoadSkyboxImage>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr);
				ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, "<>1__state");
				ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, "<>2__current");
				ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, "<>4__this");
				ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, "entry");
				ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, "<uwr>5__2");
				ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr__twr_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, "<twr>5__3");
				ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, 100671021);
				ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, 100671023);
				ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, 100671016);
				ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, 100671017);
				ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, 100671018);
				ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, 100671019);
				ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, 100671020);
				ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr, 100671022);
			}

			// Token: 0x17001A4E RID: 6734
			// (get) Token: 0x06004DFF RID: 19967 RVA: 0x00151F70 File Offset: 0x00150170
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A4F RID: 6735
			// (get) Token: 0x06004E00 RID: 19968 RVA: 0x00151FB0 File Offset: 0x001501B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E01 RID: 19969 RVA: 0x00151FF0 File Offset: 0x001501F0
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadSkyboxImage_d__35(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageSky._LoadSkyboxImage_d__35>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E02 RID: 19970 RVA: 0x00152038 File Offset: 0x00150238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104083, XrefRangeEnd = 104093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E03 RID: 19971 RVA: 0x0015206C File Offset: 0x0015026C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104093, XrefRangeEnd = 104176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E04 RID: 19972 RVA: 0x001520A8 File Offset: 0x001502A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104176, XrefRangeEnd = 104179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E05 RID: 19973 RVA: 0x001520DC File Offset: 0x001502DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104179, XrefRangeEnd = 104182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E06 RID: 19974 RVA: 0x00152110 File Offset: 0x00150310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104182, XrefRangeEnd = 104187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSky._LoadSkyboxImage_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E07 RID: 19975 RVA: 0x0001D8CC File Offset: 0x0001BACC
			public _LoadSkyboxImage_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A48 RID: 6728
			// (get) Token: 0x06004E08 RID: 19976 RVA: 0x00152144 File Offset: 0x00150344
			// (set) Token: 0x06004E09 RID: 19977 RVA: 0x0001D8D5 File Offset: 0x0001BAD5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A49 RID: 6729
			// (get) Token: 0x06004E0A RID: 19978 RVA: 0x0015216C File Offset: 0x0015036C
			// (set) Token: 0x06004E0B RID: 19979 RVA: 0x0001D8F0 File Offset: 0x0001BAF0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A4A RID: 6730
			// (get) Token: 0x06004E0C RID: 19980 RVA: 0x0015219C File Offset: 0x0015039C
			// (set) Token: 0x06004E0D RID: 19981 RVA: 0x0001D90F File Offset: 0x0001BB0F
			public unsafe ImageSky __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageSky>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A4B RID: 6731
			// (get) Token: 0x06004E0E RID: 19982 RVA: 0x001521CC File Offset: 0x001503CC
			// (set) Token: 0x06004E0F RID: 19983 RVA: 0x0001D92E File Offset: 0x0001BB2E
			public ImageSky.ImageLoadQueueEntry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr_entry);
					return new ImageSky.ImageLoadQueueEntry(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr_entry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ImageSky.ImageLoadQueueEntry>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001A4C RID: 6732
			// (get) Token: 0x06004E10 RID: 19984 RVA: 0x001521FC File Offset: 0x001503FC
			// (set) Token: 0x06004E11 RID: 19985 RVA: 0x0001D95C File Offset: 0x0001BB5C
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A4D RID: 6733
			// (get) Token: 0x06004E12 RID: 19986 RVA: 0x0015222C File Offset: 0x0015042C
			// (set) Token: 0x06004E13 RID: 19987 RVA: 0x0001D97B File Offset: 0x0001BB7B
			public unsafe UnityWebRequest _twr_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr__twr_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSky._LoadSkyboxImage_d__35.NativeFieldInfoPtr__twr_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C77 RID: 15479
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C78 RID: 15480
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C79 RID: 15481
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003C7A RID: 15482
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04003C7B RID: 15483
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003C7C RID: 15484
			private static readonly IntPtr NativeFieldInfoPtr__twr_5__3;

			// Token: 0x04003C7D RID: 15485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C7E RID: 15486
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C7F RID: 15487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C80 RID: 15488
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C81 RID: 15489
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C82 RID: 15490
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003C83 RID: 15491
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003C84 RID: 15492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
