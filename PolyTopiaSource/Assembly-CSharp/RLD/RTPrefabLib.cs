using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200019D RID: 413
	[Serializable]
	public class RTPrefabLib : global::Il2CppSystem.Object
	{
		// Token: 0x06001FAC RID: 8108 RVA: 0x0009F830 File Offset: 0x0009DA30
		// Note: this type is marked as 'beforefieldinit'.
		static RTPrefabLib()
		{
			Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTPrefabLib");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr);
			RTPrefabLib.NativeFieldInfoPtr_PrefabCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, "PrefabCreated");
			RTPrefabLib.NativeFieldInfoPtr_PrefabRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, "PrefabRemoved");
			RTPrefabLib.NativeFieldInfoPtr_Cleared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, "Cleared");
			RTPrefabLib.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, "_name");
			RTPrefabLib.NativeFieldInfoPtr__prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, "_prefabs");
			RTPrefabLib.NativeMethodInfoPtr_get_NumPrefabs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668119);
			RTPrefabLib.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668120);
			RTPrefabLib.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668121);
			RTPrefabLib.NativeMethodInfoPtr_add_PrefabCreated_Public_add_Void_PrefabCreatedInLibHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668113);
			RTPrefabLib.NativeMethodInfoPtr_remove_PrefabCreated_Public_rem_Void_PrefabCreatedInLibHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668114);
			RTPrefabLib.NativeMethodInfoPtr_add_PrefabRemoved_Public_add_Void_PrefabRemovedFromLibHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668115);
			RTPrefabLib.NativeMethodInfoPtr_remove_PrefabRemoved_Public_rem_Void_PrefabRemovedFromLibHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668116);
			RTPrefabLib.NativeMethodInfoPtr_add_Cleared_Public_add_Void_PrefabLibClearedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668117);
			RTPrefabLib.NativeMethodInfoPtr_remove_Cleared_Public_rem_Void_PrefabLibClearedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668118);
			RTPrefabLib.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668133);
			RTPrefabLib.NativeMethodInfoPtr_CreatePrefab_Public_RTPrefab_GameObject_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668122);
			RTPrefabLib.NativeMethodInfoPtr_CreatePrefabFromSceneObject_Public_RTPrefab_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668123);
			RTPrefabLib.NativeMethodInfoPtr_CreatePrefabsFromSceneObjects_Public_List_1_RTPrefab_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668124);
			RTPrefabLib.NativeMethodInfoPtr_Remove_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668125);
			RTPrefabLib.NativeMethodInfoPtr_Remove_Public_Void_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668126);
			RTPrefabLib.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668127);
			RTPrefabLib.NativeMethodInfoPtr_Contains_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668128);
			RTPrefabLib.NativeMethodInfoPtr_Contains_Public_Boolean_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668129);
			RTPrefabLib.NativeMethodInfoPtr_GetPrefabIndex_Public_Int32_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668130);
			RTPrefabLib.NativeMethodInfoPtr_GetPrefab_Public_RTPrefab_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668131);
			RTPrefabLib.NativeMethodInfoPtr_GetPrefab_Public_RTPrefab_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, 100668132);
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0009FA68 File Offset: 0x0009DC68
		public unsafe int NumPrefabs
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83719, RefRangeEnd = 83720, XrefRangeStart = 83718, XrefRangeEnd = 83719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_get_NumPrefabs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x0009FAA4 File Offset: 0x0009DCA4
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x0009FADC File Offset: 0x0009DCDC
		public unsafe string Name
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x0009FB20 File Offset: 0x0009DD20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83724, RefRangeEnd = 83726, XrefRangeStart = 83720, XrefRangeEnd = 83724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PrefabCreated(PrefabCreatedInLibHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_add_PrefabCreated_Public_add_Void_PrefabCreatedInLibHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x0009FB64 File Offset: 0x0009DD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83726, XrefRangeEnd = 83730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PrefabCreated(PrefabCreatedInLibHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_remove_PrefabCreated_Public_rem_Void_PrefabCreatedInLibHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0009FBA8 File Offset: 0x0009DDA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83734, RefRangeEnd = 83736, XrefRangeStart = 83730, XrefRangeEnd = 83734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PrefabRemoved(PrefabRemovedFromLibHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_add_PrefabRemoved_Public_add_Void_PrefabRemovedFromLibHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x0009FBEC File Offset: 0x0009DDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83736, XrefRangeEnd = 83740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PrefabRemoved(PrefabRemovedFromLibHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_remove_PrefabRemoved_Public_rem_Void_PrefabRemovedFromLibHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x0009FC30 File Offset: 0x0009DE30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83744, RefRangeEnd = 83746, XrefRangeStart = 83740, XrefRangeEnd = 83744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Cleared(PrefabLibClearedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_add_Cleared_Public_add_Void_PrefabLibClearedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0009FC74 File Offset: 0x0009DE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83746, XrefRangeEnd = 83750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Cleared(PrefabLibClearedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_remove_Cleared_Public_rem_Void_PrefabLibClearedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x0009FCB8 File Offset: 0x0009DEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83750, XrefRangeEnd = 83760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefabLib()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x0009FCF4 File Offset: 0x0009DEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83760, XrefRangeEnd = 83788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefab CreatePrefab(GameObject unityPrefab, Texture2D prefabPreview)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityPrefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefabPreview);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_CreatePrefab_Public_RTPrefab_GameObject_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefab>(intPtr3) : null;
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x0009FD58 File Offset: 0x0009DF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83788, XrefRangeEnd = 83821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefab CreatePrefabFromSceneObject(GameObject sceneObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_CreatePrefabFromSceneObject_Public_RTPrefab_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefab>(intPtr3) : null;
			}
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x0009FDA8 File Offset: 0x0009DFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83821, XrefRangeEnd = 83882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<RTPrefab> CreatePrefabsFromSceneObjects(List<GameObject> sceneObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_CreatePrefabsFromSceneObjects_Public_List_1_RTPrefab_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RTPrefab>>(intPtr3) : null;
			}
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x0009FDF8 File Offset: 0x0009DFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83882, XrefRangeEnd = 83889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(int prefabIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref prefabIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_Remove_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0009FE38 File Offset: 0x0009E038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83889, XrefRangeEnd = 83899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_Remove_Public_Void_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x0009FE7C File Offset: 0x0009E07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83899, XrefRangeEnd = 83901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x0009FEB0 File Offset: 0x0009E0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83901, XrefRangeEnd = 83916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(GameObject unityPrefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityPrefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_Contains_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0009FF00 File Offset: 0x0009E100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83916, XrefRangeEnd = 83920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_Contains_Public_Boolean_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x0009FF50 File Offset: 0x0009E150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83920, XrefRangeEnd = 83924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPrefabIndex(RTPrefab prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_GetPrefabIndex_Public_Int32_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0009FFA0 File Offset: 0x0009E1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83928, RefRangeEnd = 83929, XrefRangeStart = 83924, XrefRangeEnd = 83928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefab GetPrefab(int prefabIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref prefabIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_GetPrefab_Public_RTPrefab_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefab>(intPtr3) : null;
			}
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0009FFEC File Offset: 0x0009E1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83929, XrefRangeEnd = 83947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTPrefab GetPrefab(GameObject unityPrefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityPrefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.NativeMethodInfoPtr_GetPrefab_Public_RTPrefab_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTPrefab>(intPtr3) : null;
			}
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0000CE12 File Offset: 0x0000B012
		public RTPrefabLib(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x000A003C File Offset: 0x0009E23C
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x0000CE1B File Offset: 0x0000B01B
		public unsafe PrefabCreatedInLibHandler PrefabCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr_PrefabCreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabCreatedInLibHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr_PrefabCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x000A006C File Offset: 0x0009E26C
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x0000CE3A File Offset: 0x0000B03A
		public unsafe PrefabRemovedFromLibHandler PrefabRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr_PrefabRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabRemovedFromLibHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr_PrefabRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000A009C File Offset: 0x0009E29C
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x0000CE59 File Offset: 0x0000B059
		public unsafe PrefabLibClearedHandler Cleared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr_Cleared);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabLibClearedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr_Cleared), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000A00CC File Offset: 0x0009E2CC
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x0000CE78 File Offset: 0x0000B078
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x000A00F4 File Offset: 0x0009E2F4
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x0000CE97 File Offset: 0x0000B097
		public unsafe List<RTPrefab> _prefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr__prefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RTPrefab>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.NativeFieldInfoPtr__prefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeFieldInfoPtr_PrefabCreated;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeFieldInfoPtr_PrefabRemoved;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeFieldInfoPtr_Cleared;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeFieldInfoPtr__prefabs;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_get_NumPrefabs_Public_get_Int32_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr_add_PrefabCreated_Public_add_Void_PrefabCreatedInLibHandler_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr_remove_PrefabCreated_Public_rem_Void_PrefabCreatedInLibHandler_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_add_PrefabRemoved_Public_add_Void_PrefabRemovedFromLibHandler_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr_remove_PrefabRemoved_Public_rem_Void_PrefabRemovedFromLibHandler_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_add_Cleared_Public_add_Void_PrefabLibClearedHandler_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_remove_Cleared_Public_rem_Void_PrefabLibClearedHandler_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrefab_Public_RTPrefab_GameObject_Texture2D_0;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrefabFromSceneObject_Public_RTPrefab_GameObject_0;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrefabsFromSceneObjects_Public_List_1_RTPrefab_List_1_GameObject_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Int32_0;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_RTPrefab_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_GameObject_0;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_RTPrefab_0;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabIndex_Public_Int32_RTPrefab_0;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefab_Public_RTPrefab_Int32_0;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefab_Public_RTPrefab_GameObject_0;

		// Token: 0x02000399 RID: 921
		[ObfuscatedName("RLD.RTPrefabLib+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004B5B RID: 19291 RVA: 0x0014A4A8 File Offset: 0x001486A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass22_0>.NativeClassPtr);
				RTPrefabLib.__c__DisplayClass22_0.NativeFieldInfoPtr_unityPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass22_0>.NativeClassPtr, "unityPrefab");
				RTPrefabLib.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass22_0>.NativeClassPtr, 100668134);
				RTPrefabLib.__c__DisplayClass22_0.NativeMethodInfoPtr__Contains_b__0_Internal_Boolean_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass22_0>.NativeClassPtr, 100668135);
			}

			// Token: 0x06004B5C RID: 19292 RVA: 0x0014A510 File Offset: 0x00148710
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B5D RID: 19293 RVA: 0x0014A54C File Offset: 0x0014874C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83708, XrefRangeEnd = 83713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Contains_b__0(RTPrefab item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.__c__DisplayClass22_0.NativeMethodInfoPtr__Contains_b__0_Internal_Boolean_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B5E RID: 19294 RVA: 0x0001C389 File Offset: 0x0001A589
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001973 RID: 6515
			// (get) Token: 0x06004B5F RID: 19295 RVA: 0x0014A59C File Offset: 0x0014879C
			// (set) Token: 0x06004B60 RID: 19296 RVA: 0x0001C392 File Offset: 0x0001A592
			public unsafe GameObject unityPrefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.__c__DisplayClass22_0.NativeFieldInfoPtr_unityPrefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.__c__DisplayClass22_0.NativeFieldInfoPtr_unityPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A7B RID: 14971
			private static readonly IntPtr NativeFieldInfoPtr_unityPrefab;

			// Token: 0x04003A7C RID: 14972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A7D RID: 14973
			private static readonly IntPtr NativeMethodInfoPtr__Contains_b__0_Internal_Boolean_RTPrefab_0;
		}

		// Token: 0x0200039A RID: 922
		[ObfuscatedName("RLD.RTPrefabLib+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004B61 RID: 19297 RVA: 0x0014A5CC File Offset: 0x001487CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTPrefabLib>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass26_0>.NativeClassPtr);
				RTPrefabLib.__c__DisplayClass26_0.NativeFieldInfoPtr_unityPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass26_0>.NativeClassPtr, "unityPrefab");
				RTPrefabLib.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass26_0>.NativeClassPtr, 100668136);
				RTPrefabLib.__c__DisplayClass26_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_RTPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass26_0>.NativeClassPtr, 100668137);
			}

			// Token: 0x06004B62 RID: 19298 RVA: 0x0014A634 File Offset: 0x00148834
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTPrefabLib.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B63 RID: 19299 RVA: 0x0014A670 File Offset: 0x00148870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83713, XrefRangeEnd = 83718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPrefab_b__0(RTPrefab item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTPrefabLib.__c__DisplayClass26_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_RTPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B64 RID: 19300 RVA: 0x0001C3B1 File Offset: 0x0001A5B1
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001974 RID: 6516
			// (get) Token: 0x06004B65 RID: 19301 RVA: 0x0014A6C0 File Offset: 0x001488C0
			// (set) Token: 0x06004B66 RID: 19302 RVA: 0x0001C3BA File Offset: 0x0001A5BA
			public unsafe GameObject unityPrefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.__c__DisplayClass26_0.NativeFieldInfoPtr_unityPrefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTPrefabLib.__c__DisplayClass26_0.NativeFieldInfoPtr_unityPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A7E RID: 14974
			private static readonly IntPtr NativeFieldInfoPtr_unityPrefab;

			// Token: 0x04003A7F RID: 14975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A80 RID: 14976
			private static readonly IntPtr NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_RTPrefab_0;
		}
	}
}
