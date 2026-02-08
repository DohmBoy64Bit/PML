using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000223 RID: 547
	[Serializable]
	public class ObjectSelectionSettings : Settings
	{
		// Token: 0x06002AA9 RID: 10921 RVA: 0x000C9EFC File Offset: 0x000C80FC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionSettings()
		{
			Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr);
			ObjectSelectionSettings.NativeFieldInfoPtr__multiSelectOverlapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_multiSelectOverlapMode");
			ObjectSelectionSettings.NativeFieldInfoPtr__selectableObjectTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_selectableObjectTypes");
			ObjectSelectionSettings.NativeFieldInfoPtr__selectableLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_selectableLayers");
			ObjectSelectionSettings.NativeFieldInfoPtr__duplicatableLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_duplicatableLayers");
			ObjectSelectionSettings.NativeFieldInfoPtr__deletableLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_deletableLayers");
			ObjectSelectionSettings.NativeFieldInfoPtr__nonSelectableObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_nonSelectableObjects");
			ObjectSelectionSettings.NativeFieldInfoPtr__nonSelectableCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_nonSelectableCameras");
			ObjectSelectionSettings.NativeFieldInfoPtr__canClickSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_canClickSelect");
			ObjectSelectionSettings.NativeFieldInfoPtr__enableCyclicalClickSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_enableCyclicalClickSelect");
			ObjectSelectionSettings.NativeFieldInfoPtr__canMultiSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_canMultiSelect");
			ObjectSelectionSettings.NativeFieldInfoPtr__minMultiSelectSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "_minMultiSelectSize");
			ObjectSelectionSettings.NativeMethodInfoPtr_get_MultiSelectOverlapMode_Public_get_MultiSelectOverlapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669789);
			ObjectSelectionSettings.NativeMethodInfoPtr_set_MultiSelectOverlapMode_Public_set_Void_MultiSelectOverlapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669790);
			ObjectSelectionSettings.NativeMethodInfoPtr_get_CanClickSelect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669791);
			ObjectSelectionSettings.NativeMethodInfoPtr_set_CanClickSelect_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669792);
			ObjectSelectionSettings.NativeMethodInfoPtr_get_EnableCyclicalClickSelect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669793);
			ObjectSelectionSettings.NativeMethodInfoPtr_set_EnableCyclicalClickSelect_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669794);
			ObjectSelectionSettings.NativeMethodInfoPtr_get_CanMultiSelect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669795);
			ObjectSelectionSettings.NativeMethodInfoPtr_set_CanMultiSelect_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669796);
			ObjectSelectionSettings.NativeMethodInfoPtr_get_SelectableLayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669797);
			ObjectSelectionSettings.NativeMethodInfoPtr_set_SelectableLayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669798);
			ObjectSelectionSettings.NativeMethodInfoPtr_get_DuplicatableLayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669799);
			ObjectSelectionSettings.NativeMethodInfoPtr_set_DuplicatableLayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669800);
			ObjectSelectionSettings.NativeMethodInfoPtr_get_DeletableLayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669801);
			ObjectSelectionSettings.NativeMethodInfoPtr_set_DeletableLayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669802);
			ObjectSelectionSettings.NativeMethodInfoPtr_get_MinMultiSelectSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669803);
			ObjectSelectionSettings.NativeMethodInfoPtr_set_MinMultiSelectSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669804);
			ObjectSelectionSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669819);
			ObjectSelectionSettings.NativeMethodInfoPtr_IsCameraSelectable_Public_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669805);
			ObjectSelectionSettings.NativeMethodInfoPtr_SetCameraSelectable_Public_Void_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669806);
			ObjectSelectionSettings.NativeMethodInfoPtr_SetCameraCollectionSelectable_Public_Void_List_1_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669807);
			ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectTypeSelectable_Public_Boolean_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669808);
			ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectTypeSelectable_Public_Void_GameObjectType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669809);
			ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectLayerSelectable_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669810);
			ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectLayerSelectable_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669811);
			ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectSelectable_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669812);
			ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectSelectable_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669813);
			ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectCollectionSelectable_Public_Void_List_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669814);
			ObjectSelectionSettings.NativeMethodInfoPtr_RemoveNullObjectRefs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669815);
			ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectLayerDuplicatable_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669816);
			ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectLayerDuplicatable_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669817);
			ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectLayerDeletable_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, 100669818);
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x000CA274 File Offset: 0x000C8474
		// (set) Token: 0x06002AAB RID: 10923 RVA: 0x000CA2B4 File Offset: 0x000C84B4
		public unsafe MultiSelectOverlapMode MultiSelectOverlapMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_get_MultiSelectOverlapMode_Public_get_MultiSelectOverlapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultiSelectOverlapMode>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_set_MultiSelectOverlapMode_Public_set_Void_MultiSelectOverlapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x000CA2F8 File Offset: 0x000C84F8
		// (set) Token: 0x06002AAD RID: 10925 RVA: 0x000CA334 File Offset: 0x000C8534
		public unsafe bool CanClickSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_get_CanClickSelect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_set_CanClickSelect_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06002AAE RID: 10926 RVA: 0x000CA374 File Offset: 0x000C8574
		// (set) Token: 0x06002AAF RID: 10927 RVA: 0x000CA3B0 File Offset: 0x000C85B0
		public unsafe bool EnableCyclicalClickSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_get_EnableCyclicalClickSelect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_set_EnableCyclicalClickSelect_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x000CA3F0 File Offset: 0x000C85F0
		// (set) Token: 0x06002AB1 RID: 10929 RVA: 0x000CA42C File Offset: 0x000C862C
		public unsafe bool CanMultiSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_get_CanMultiSelect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_set_CanMultiSelect_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x000CA46C File Offset: 0x000C866C
		// (set) Token: 0x06002AB3 RID: 10931 RVA: 0x000CA4A8 File Offset: 0x000C86A8
		public unsafe int SelectableLayers
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 21737, RefRangeEnd = 21743, XrefRangeStart = 21737, XrefRangeEnd = 21743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_get_SelectableLayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_set_SelectableLayers_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x000CA4E8 File Offset: 0x000C86E8
		// (set) Token: 0x06002AB5 RID: 10933 RVA: 0x000CA524 File Offset: 0x000C8724
		public unsafe int DuplicatableLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_get_DuplicatableLayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_set_DuplicatableLayers_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06002AB6 RID: 10934 RVA: 0x000CA564 File Offset: 0x000C8764
		// (set) Token: 0x06002AB7 RID: 10935 RVA: 0x000CA5A0 File Offset: 0x000C87A0
		public unsafe int DeletableLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_get_DeletableLayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_set_DeletableLayers_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x000CA5E0 File Offset: 0x000C87E0
		// (set) Token: 0x06002AB9 RID: 10937 RVA: 0x000CA61C File Offset: 0x000C881C
		public unsafe int MinMultiSelectSize
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 88781, RefRangeEnd = 88785, XrefRangeStart = 88781, XrefRangeEnd = 88785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_get_MinMultiSelectSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_set_MinMultiSelectSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x000CA65C File Offset: 0x000C885C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93586, XrefRangeEnd = 93601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x000CA698 File Offset: 0x000C8898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93601, XrefRangeEnd = 93604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCameraSelectable(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_IsCameraSelectable_Public_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x000CA6E8 File Offset: 0x000C88E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93604, XrefRangeEnd = 93612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraSelectable(Camera camera, bool isSelectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSelectable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_SetCameraSelectable_Public_Void_Camera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x000CA738 File Offset: 0x000C8938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93612, XrefRangeEnd = 93637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraCollectionSelectable(List<Camera> cameraCollection, bool areSelectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameraCollection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref areSelectable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_SetCameraCollectionSelectable_Public_Void_List_1_Camera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x000CA788 File Offset: 0x000C8988
		[CallerCount(0)]
		public unsafe bool IsObjectTypeSelectable(GameObjectType gameObjectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectTypeSelectable_Public_Boolean_GameObjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x000CA7D8 File Offset: 0x000C89D8
		[CallerCount(0)]
		public unsafe void SetObjectTypeSelectable(GameObjectType gameObjectType, bool isSelectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSelectable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectTypeSelectable_Public_Void_GameObjectType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x000CA828 File Offset: 0x000C8A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93637, XrefRangeEnd = 93638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectLayerSelectable(int objectLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectLayerSelectable_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x000CA874 File Offset: 0x000C8A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93638, XrefRangeEnd = 93639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectLayerSelectable(int objectLayer, bool isSelectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectLayer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSelectable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectLayerSelectable_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x000CA8C0 File Offset: 0x000C8AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93639, XrefRangeEnd = 93646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectSelectable(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectSelectable_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x000CA910 File Offset: 0x000C8B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93646, XrefRangeEnd = 93654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectSelectable(GameObject gameObject, bool isSelectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSelectable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectSelectable_Public_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x000CA960 File Offset: 0x000C8B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93654, XrefRangeEnd = 93679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectCollectionSelectable(List<GameObject> gameObjectCollection, bool areSelectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjectCollection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref areSelectable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectCollectionSelectable_Public_Void_List_1_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x000CA9B0 File Offset: 0x000C8BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93679, XrefRangeEnd = 93698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNullObjectRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_RemoveNullObjectRefs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x000CA9E4 File Offset: 0x000C8BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93698, XrefRangeEnd = 93699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectLayerDuplicatable(int objectLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectLayerDuplicatable_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000CAA30 File Offset: 0x000C8C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93699, XrefRangeEnd = 93700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectLayerDuplicatable(int objectLayer, bool isDuplicatable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectLayer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDuplicatable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_SetObjectLayerDuplicatable_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x000CAA7C File Offset: 0x000C8C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93700, XrefRangeEnd = 93701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectLayerDeletable(int objectLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.NativeMethodInfoPtr_IsObjectLayerDeletable_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x00010DD1 File Offset: 0x0000EFD1
		public ObjectSelectionSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x000CAAC8 File Offset: 0x000C8CC8
		// (set) Token: 0x06002ACB RID: 10955 RVA: 0x00010DDA File Offset: 0x0000EFDA
		public unsafe MultiSelectOverlapMode _multiSelectOverlapMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__multiSelectOverlapMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiSelectOverlapMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__multiSelectOverlapMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x000CAAF8 File Offset: 0x000C8CF8
		// (set) Token: 0x06002ACD RID: 10957 RVA: 0x00010DF9 File Offset: 0x0000EFF9
		public unsafe GameObjectType _selectableObjectTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__selectableObjectTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObjectType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__selectableObjectTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x000CAB28 File Offset: 0x000C8D28
		// (set) Token: 0x06002ACF RID: 10959 RVA: 0x00010E18 File Offset: 0x0000F018
		public unsafe int _selectableLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__selectableLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__selectableLayers)) = value;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x000CAB50 File Offset: 0x000C8D50
		// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x00010E33 File Offset: 0x0000F033
		public unsafe int _duplicatableLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__duplicatableLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__duplicatableLayers)) = value;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x000CAB78 File Offset: 0x000C8D78
		// (set) Token: 0x06002AD3 RID: 10963 RVA: 0x00010E4E File Offset: 0x0000F04E
		public unsafe int _deletableLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__deletableLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__deletableLayers)) = value;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x000CABA0 File Offset: 0x000C8DA0
		// (set) Token: 0x06002AD5 RID: 10965 RVA: 0x00010E69 File Offset: 0x0000F069
		public unsafe HashSet<GameObject> _nonSelectableObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__nonSelectableObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__nonSelectableObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x000CABD0 File Offset: 0x000C8DD0
		// (set) Token: 0x06002AD7 RID: 10967 RVA: 0x00010E88 File Offset: 0x0000F088
		public unsafe HashSet<Camera> _nonSelectableCameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__nonSelectableCameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__nonSelectableCameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06002AD8 RID: 10968 RVA: 0x000CAC00 File Offset: 0x000C8E00
		// (set) Token: 0x06002AD9 RID: 10969 RVA: 0x00010EA7 File Offset: 0x0000F0A7
		public unsafe bool _canClickSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__canClickSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__canClickSelect)) = value;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x000CAC28 File Offset: 0x000C8E28
		// (set) Token: 0x06002ADB RID: 10971 RVA: 0x00010EC2 File Offset: 0x0000F0C2
		public unsafe bool _enableCyclicalClickSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__enableCyclicalClickSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__enableCyclicalClickSelect)) = value;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x000CAC50 File Offset: 0x000C8E50
		// (set) Token: 0x06002ADD RID: 10973 RVA: 0x00010EDD File Offset: 0x0000F0DD
		public unsafe bool _canMultiSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__canMultiSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__canMultiSelect)) = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x000CAC78 File Offset: 0x000C8E78
		// (set) Token: 0x06002ADF RID: 10975 RVA: 0x00010EF8 File Offset: 0x0000F0F8
		public unsafe int _minMultiSelectSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__minMultiSelectSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionSettings.NativeFieldInfoPtr__minMultiSelectSize)) = value;
			}
		}

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeFieldInfoPtr__multiSelectOverlapMode;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeFieldInfoPtr__selectableObjectTypes;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeFieldInfoPtr__selectableLayers;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr__duplicatableLayers;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeFieldInfoPtr__deletableLayers;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeFieldInfoPtr__nonSelectableObjects;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeFieldInfoPtr__nonSelectableCameras;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr__canClickSelect;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeFieldInfoPtr__enableCyclicalClickSelect;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeFieldInfoPtr__canMultiSelect;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeFieldInfoPtr__minMultiSelectSize;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeMethodInfoPtr_get_MultiSelectOverlapMode_Public_get_MultiSelectOverlapMode_0;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeMethodInfoPtr_set_MultiSelectOverlapMode_Public_set_Void_MultiSelectOverlapMode_0;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeMethodInfoPtr_get_CanClickSelect_Public_get_Boolean_0;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeMethodInfoPtr_set_CanClickSelect_Public_set_Void_Boolean_0;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableCyclicalClickSelect_Public_get_Boolean_0;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableCyclicalClickSelect_Public_set_Void_Boolean_0;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeMethodInfoPtr_get_CanMultiSelect_Public_get_Boolean_0;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeMethodInfoPtr_set_CanMultiSelect_Public_set_Void_Boolean_0;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectableLayers_Public_get_Int32_0;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectableLayers_Public_set_Void_Int32_0;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeMethodInfoPtr_get_DuplicatableLayers_Public_get_Int32_0;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeMethodInfoPtr_set_DuplicatableLayers_Public_set_Void_Int32_0;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeMethodInfoPtr_get_DeletableLayers_Public_get_Int32_0;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeMethodInfoPtr_set_DeletableLayers_Public_set_Void_Int32_0;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeMethodInfoPtr_get_MinMultiSelectSize_Public_get_Int32_0;

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeMethodInfoPtr_set_MinMultiSelectSize_Public_set_Void_Int32_0;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeMethodInfoPtr_IsCameraSelectable_Public_Boolean_Camera_0;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraSelectable_Public_Void_Camera_Boolean_0;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraCollectionSelectable_Public_Void_List_1_Camera_Boolean_0;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectTypeSelectable_Public_Boolean_GameObjectType_0;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectTypeSelectable_Public_Void_GameObjectType_Boolean_0;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectLayerSelectable_Public_Boolean_Int32_0;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectLayerSelectable_Public_Void_Int32_Boolean_0;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectSelectable_Public_Boolean_GameObject_0;

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectSelectable_Public_Void_GameObject_Boolean_0;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectCollectionSelectable_Public_Void_List_1_GameObject_Boolean_0;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNullObjectRefs_Public_Void_0;

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectLayerDuplicatable_Public_Boolean_Int32_0;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectLayerDuplicatable_Public_Void_Int32_Boolean_0;

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectLayerDeletable_Public_Boolean_Int32_0;

		// Token: 0x020003D3 RID: 979
		[ObfuscatedName("RLD.ObjectSelectionSettings+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004CC5 RID: 19653 RVA: 0x0014E5EC File Offset: 0x0014C7EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObjectSelectionSettings.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectSelectionSettings>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionSettings.__c>.NativeClassPtr);
				ObjectSelectionSettings.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings.__c>.NativeClassPtr, "<>9");
				ObjectSelectionSettings.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionSettings.__c>.NativeClassPtr, "<>9__45_0");
				ObjectSelectionSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings.__c>.NativeClassPtr, 100669821);
				ObjectSelectionSettings.__c.NativeMethodInfoPtr__RemoveNullObjectRefs_b__45_0_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionSettings.__c>.NativeClassPtr, 100669822);
			}

			// Token: 0x06004CC6 RID: 19654 RVA: 0x0014E668 File Offset: 0x0014C868
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionSettings.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CC7 RID: 19655 RVA: 0x0014E6A4 File Offset: 0x0014C8A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93582, XrefRangeEnd = 93586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveNullObjectRefs_b__45_0(GameObject item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionSettings.__c.NativeMethodInfoPtr__RemoveNullObjectRefs_b__45_0_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004CC8 RID: 19656 RVA: 0x0001CEEA File Offset: 0x0001B0EA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019DE RID: 6622
			// (get) Token: 0x06004CC9 RID: 19657 RVA: 0x0014E6F4 File Offset: 0x0014C8F4
			// (set) Token: 0x06004CCA RID: 19658 RVA: 0x0001CEF3 File Offset: 0x0001B0F3
			public unsafe static ObjectSelectionSettings.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectSelectionSettings.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSettings.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectSelectionSettings.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019DF RID: 6623
			// (get) Token: 0x06004CCB RID: 19659 RVA: 0x0014E71C File Offset: 0x0014C91C
			// (set) Token: 0x06004CCC RID: 19660 RVA: 0x0001CF05 File Offset: 0x0001B105
			public unsafe static Predicate<GameObject> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectSelectionSettings.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectSelectionSettings.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BB4 RID: 15284
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BB5 RID: 15285
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x04003BB6 RID: 15286
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BB7 RID: 15287
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNullObjectRefs_b__45_0_Internal_Boolean_GameObject_0;
		}
	}
}
