using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200023D RID: 573
	public class ObjectSelectEntireHierarchy : Singleton<ObjectSelectEntireHierarchy>
	{
		// Token: 0x06002CDD RID: 11485 RVA: 0x000D1C5C File Offset: 0x000CFE5C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectEntireHierarchy()
		{
			Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectEntireHierarchy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr);
			ObjectSelectEntireHierarchy.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr, "_isActive");
			ObjectSelectEntireHierarchy.NativeFieldInfoPtr__ignoreObjectGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr, "_ignoreObjectGroups");
			ObjectSelectEntireHierarchy.NativeMethodInfoPtr_get_IgnoreObjectGroups_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr, 100670083);
			ObjectSelectEntireHierarchy.NativeMethodInfoPtr_set_IgnoreObjectGroups_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr, 100670084);
			ObjectSelectEntireHierarchy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr, 100670089);
			ObjectSelectEntireHierarchy.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr, 100670085);
			ObjectSelectEntireHierarchy.NativeMethodInfoPtr_OnPreSelectCustomize_Private_Void_ObjectPreSelectCustomizeInfo_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr, 100670086);
			ObjectSelectEntireHierarchy.NativeMethodInfoPtr_OnPreDeselectCustomize_Private_Void_ObjectPreDeselectCustomizeInfo_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr, 100670087);
			ObjectSelectEntireHierarchy.NativeMethodInfoPtr_GetFurthestParentNotGroup_Private_Transform_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr, 100670088);
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x000D1D40 File Offset: 0x000CFF40
		// (set) Token: 0x06002CDF RID: 11487 RVA: 0x000D1D7C File Offset: 0x000CFF7C
		public unsafe bool IgnoreObjectGroups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectEntireHierarchy.NativeMethodInfoPtr_get_IgnoreObjectGroups_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectEntireHierarchy.NativeMethodInfoPtr_set_IgnoreObjectGroups_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000D1DBC File Offset: 0x000CFFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96698, XrefRangeEnd = 96704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectEntireHierarchy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectEntireHierarchy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectEntireHierarchy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000D1DF8 File Offset: 0x000CFFF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96732, RefRangeEnd = 96734, XrefRangeStart = 96704, XrefRangeEnd = 96732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isActive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectEntireHierarchy.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000D1E38 File Offset: 0x000D0038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96734, XrefRangeEnd = 96795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreSelectCustomize(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customizeInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toBeSelected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectEntireHierarchy.NativeMethodInfoPtr_OnPreSelectCustomize_Private_Void_ObjectPreSelectCustomizeInfo_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000D1E8C File Offset: 0x000D008C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96795, XrefRangeEnd = 96856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreDeselectCustomize(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customizeInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toBeDeselected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectEntireHierarchy.NativeMethodInfoPtr_OnPreDeselectCustomize_Private_Void_ObjectPreDeselectCustomizeInfo_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000D1EE0 File Offset: 0x000D00E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96876, RefRangeEnd = 96878, XrefRangeStart = 96856, XrefRangeEnd = 96876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetFurthestParentNotGroup(GameObject gameObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectEntireHierarchy.NativeMethodInfoPtr_GetFurthestParentNotGroup_Private_Transform_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x00011D3B File Offset: 0x0000FF3B
		public ObjectSelectEntireHierarchy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000D1F30 File Offset: 0x000D0130
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x00011D44 File Offset: 0x0000FF44
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectEntireHierarchy.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectEntireHierarchy.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000D1F58 File Offset: 0x000D0158
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x00011D5F File Offset: 0x0000FF5F
		public unsafe bool _ignoreObjectGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectEntireHierarchy.NativeFieldInfoPtr__ignoreObjectGroups);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectEntireHierarchy.NativeFieldInfoPtr__ignoreObjectGroups)) = value;
			}
		}

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeFieldInfoPtr__ignoreObjectGroups;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreObjectGroups_Public_get_Boolean_0;

		// Token: 0x0400228B RID: 8843
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreObjectGroups_Public_set_Void_Boolean_0;

		// Token: 0x0400228C RID: 8844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeMethodInfoPtr_OnPreSelectCustomize_Private_Void_ObjectPreSelectCustomizeInfo_List_1_GameObject_0;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeMethodInfoPtr_OnPreDeselectCustomize_Private_Void_ObjectPreDeselectCustomizeInfo_List_1_GameObject_0;

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeMethodInfoPtr_GetFurthestParentNotGroup_Private_Transform_GameObject_0;
	}
}
