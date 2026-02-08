using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000203 RID: 515
	[Serializable]
	public class DynamicConvertSettings : Settings
	{
		// Token: 0x0600293F RID: 10559 RVA: 0x000C4DE0 File Offset: 0x000C2FE0
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicConvertSettings()
		{
			Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "DynamicConvertSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr);
			DynamicConvertSettings.NativeFieldInfoPtr__prefabFolderDropRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, "_prefabFolderDropRect");
			DynamicConvertSettings.NativeFieldInfoPtr__convertableObjectTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, "_convertableObjectTypes");
			DynamicConvertSettings.NativeFieldInfoPtr__prefabFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, "_prefabFolder");
			DynamicConvertSettings.NativeFieldInfoPtr__processPrefabSubfolders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, "_processPrefabSubfolders");
			DynamicConvertSettings.NativeMethodInfoPtr_get_ConvertableObjectTypes_Public_get_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, 100669593);
			DynamicConvertSettings.NativeMethodInfoPtr_set_ConvertableObjectTypes_Public_set_Void_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, 100669594);
			DynamicConvertSettings.NativeMethodInfoPtr_get_PrefabFolder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, 100669595);
			DynamicConvertSettings.NativeMethodInfoPtr_set_PrefabFolder_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, 100669596);
			DynamicConvertSettings.NativeMethodInfoPtr_get_ProcessPrefabSubfolders_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, 100669597);
			DynamicConvertSettings.NativeMethodInfoPtr_set_ProcessPrefabSubfolders_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, 100669598);
			DynamicConvertSettings.NativeMethodInfoPtr_get_PrefabFolderDropRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, 100669599);
			DynamicConvertSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr, 100669600);
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000C4F00 File Offset: 0x000C3100
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x000C4F40 File Offset: 0x000C3140
		public unsafe GameObjectType ConvertableObjectTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicConvertSettings.NativeMethodInfoPtr_get_ConvertableObjectTypes_Public_get_GameObjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectType>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicConvertSettings.NativeMethodInfoPtr_set_ConvertableObjectTypes_Public_set_Void_GameObjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x000C4F84 File Offset: 0x000C3184
		// (set) Token: 0x06002943 RID: 10563 RVA: 0x000C4FBC File Offset: 0x000C31BC
		public unsafe string PrefabFolder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicConvertSettings.NativeMethodInfoPtr_get_PrefabFolder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91559, XrefRangeEnd = 91560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicConvertSettings.NativeMethodInfoPtr_set_PrefabFolder_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x000C5000 File Offset: 0x000C3200
		// (set) Token: 0x06002945 RID: 10565 RVA: 0x000C503C File Offset: 0x000C323C
		public unsafe bool ProcessPrefabSubfolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicConvertSettings.NativeMethodInfoPtr_get_ProcessPrefabSubfolders_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicConvertSettings.NativeMethodInfoPtr_set_ProcessPrefabSubfolders_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x000C507C File Offset: 0x000C327C
		public unsafe Rect PrefabFolderDropRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicConvertSettings.NativeMethodInfoPtr_get_PrefabFolderDropRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
			}
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000C50BC File Offset: 0x000C32BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91570, RefRangeEnd = 91571, XrefRangeStart = 91560, XrefRangeEnd = 91570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicConvertSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicConvertSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicConvertSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x0001048D File Offset: 0x0000E68D
		public DynamicConvertSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x000C50F8 File Offset: 0x000C32F8
		// (set) Token: 0x0600294A RID: 10570 RVA: 0x00010496 File Offset: 0x0000E696
		public unsafe Rect _prefabFolderDropRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicConvertSettings.NativeFieldInfoPtr__prefabFolderDropRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicConvertSettings.NativeFieldInfoPtr__prefabFolderDropRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x000C5128 File Offset: 0x000C3328
		// (set) Token: 0x0600294C RID: 10572 RVA: 0x000104B5 File Offset: 0x0000E6B5
		public unsafe GameObjectType _convertableObjectTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicConvertSettings.NativeFieldInfoPtr__convertableObjectTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObjectType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicConvertSettings.NativeFieldInfoPtr__convertableObjectTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x000C5158 File Offset: 0x000C3358
		// (set) Token: 0x0600294E RID: 10574 RVA: 0x000104D4 File Offset: 0x0000E6D4
		public unsafe string _prefabFolder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicConvertSettings.NativeFieldInfoPtr__prefabFolder);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicConvertSettings.NativeFieldInfoPtr__prefabFolder), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x000C5180 File Offset: 0x000C3380
		// (set) Token: 0x06002950 RID: 10576 RVA: 0x000104F3 File Offset: 0x0000E6F3
		public unsafe bool _processPrefabSubfolders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicConvertSettings.NativeFieldInfoPtr__processPrefabSubfolders);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicConvertSettings.NativeFieldInfoPtr__processPrefabSubfolders)) = value;
			}
		}

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeFieldInfoPtr__prefabFolderDropRect;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeFieldInfoPtr__convertableObjectTypes;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeFieldInfoPtr__prefabFolder;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeFieldInfoPtr__processPrefabSubfolders;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr_get_ConvertableObjectTypes_Public_get_GameObjectType_0;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr_set_ConvertableObjectTypes_Public_set_Void_GameObjectType_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabFolder_Public_get_String_0;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr_set_PrefabFolder_Public_set_Void_String_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessPrefabSubfolders_Public_get_Boolean_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr_set_ProcessPrefabSubfolders_Public_set_Void_Boolean_0;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabFolderDropRect_Public_get_Rect_0;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
